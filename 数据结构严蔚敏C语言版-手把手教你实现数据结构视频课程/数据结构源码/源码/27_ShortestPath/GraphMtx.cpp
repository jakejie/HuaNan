#include"GraphMtx.h"

void InitGraph(GraphMtx *g)
{
	g->MaxVertices = Default_Vertex_Size;
	g->NumVertices = g->NumEdges = 0;

	g->VerticesList = (T*)malloc(sizeof(T)*(g->MaxVertices));
	assert(g->VerticesList != NULL);

	g->Edge = (int**)malloc(sizeof(int*) * g->MaxVertices);
	assert(g->Edge != NULL);
	for(int i=0; i<g->MaxVertices; ++i)
	{
		g->Edge[i] = (int*)malloc(sizeof(int) * g->MaxVertices);
	}
	for(i=0; i<g->MaxVertices; ++i)
	{
		for(int j=0; j<g->MaxVertices; ++j)
		{
			if(i == j)
			{
				g->Edge[i][j] = 0;
			}
			else
			{
				g->Edge[i][j] = MAX_COST;
			}
		}
	}
}

int  GetVertexPos(GraphMtx *g, T v)
{
	for(int i=0; i<g->NumVertices; ++i)
	{
		if(g->VerticesList[i] == v)
			return i;
	}
	return -1;
}

void ShowGraph(GraphMtx *g)
{
	printf("  ");
	for(int i=0; i<g->NumVertices; ++i)
	{
		printf("%2c  ",g->VerticesList[i]);
	}
	printf("\n");
	for(i=0; i<g->NumVertices; ++i)
	{
		printf("%c ",g->VerticesList[i]);
		for(int j=0; j<g->NumVertices; ++j)
		{
			if(g->Edge[i][j] == MAX_COST)
			{
				printf("%2c  ",'@');
			}
			else
			{
				printf("%2d  ",g->Edge[i][j]);
			}
		}
		printf("\n");
	}
	printf("\n");
}

void InsertVertex(GraphMtx *g, T v)
{
	if(g->NumVertices >= g->MaxVertices)
		return;
	g->VerticesList[g->NumVertices++] = v;
}

void InsertEdge(GraphMtx *g, T v1, T v2, E cost)
{
	int p1 = GetVertexPos(g,v1);
	int p2 =  GetVertexPos(g,v2);
	if(p1==-1 || p2==-1)
		return;

	g->Edge[p1][p2] = cost;
	//g->Edge[p1][p2] = g->Edge[p2][p1] = cost;
	g->NumEdges++;
}

void RemoveEdge(GraphMtx *g, T v1, T v2)
{
	int p1 = GetVertexPos(g,v1);
	int p2 =  GetVertexPos(g,v2);
	if(p1==-1 || p2==-1)
		return;

	if(g->Edge[p1][p2] == 0)
		return;

	g->Edge[p1][p2] = g->Edge[p2][1] = 0;
	g->NumEdges--;
}

void RemoveVertex(GraphMtx *g, T v)
{
	int p = GetVertexPos(g,v);
	if(p == -1)
		return;

	int numedges = 0;

	for(int i=p; i<g->NumVertices-1; ++i)
	{
		g->VerticesList[i] = g->VerticesList[i+1];
	}

	for(i=0; i<g->NumVertices; ++i)
	{
		if(g->Edge[p][i] != 0)
		{
			numedges++;
		}
	}

	for(i=p; i<g->NumVertices-1; ++i)
	{
		for(int j=0; j<g->NumVertices; ++j)
		{
			g->Edge[i][j] = g->Edge[i+1][j];
		}
	}

	for(i=p; i<g->NumVertices; ++i)
	{
		for(int j=0; j<g->NumVertices; ++j)
		{
			g->Edge[j][i] = g->Edge[j][i+1];
		}
	}
	g->NumVertices--;
	g->NumEdges -= numedges;
}

void DestroyGraph(GraphMtx *g)
{
	free(g->VerticesList);
	g->VerticesList = NULL;
	for(int i=0; i<g->NumVertices; ++i)
	{
		free(g->Edge[i]);
	}
	free(g->Edge);
	g->Edge = NULL;
	g->MaxVertices = g->NumEdges = g->NumVertices = 0;
}
int  GetFirstNeighbor(GraphMtx *g, T v)
{
	int p = GetVertexPos(g,v);
	if(p == -1)
		return -1;

	for(int i=0; i<g->NumVertices; ++i)
	{
		if(g->Edge[p][i] == 1)
			return i;
	}
	return -1;
}
int  GetNextNeighbor(GraphMtx *g, T v, T w)
{
	int pv = GetVertexPos(g,v);
	int pw = GetVertexPos(g,w);
	if(pv==-1 || pw==-1)
		return -1;

	for(int i=pw+1; i<g->NumVertices; ++i)
	{
		if(g->Edge[pv][i] == 1)
			return i;
	}
	return -1;
}

E    GetWeight(GraphMtx *g, int v1, int v2)
{
	if(v1==-1 || v2==-1)
		return MAX_COST;
	return g->Edge[v1][v2];
}


void ShortestPath(GraphMtx *g, T vertex, E dist[], int path[])
{
	int n = g->NumVertices;
	bool *S = (bool*)malloc(sizeof(bool) * n);
	assert( S != NULL);
	int v = GetVertexPos(g,vertex);

	for(int i=0; i<n; ++i)
	{
		dist[i] = GetWeight(g,v,i);
		S[i] = false;
		if(i!=v && dist[i]<MAX_COST)
		{
			path[i] = v;
		}
		else
		{
			path[i] = -1;
		}
	}

	S[v] = true;
	int min;
	int w;

	for(i=0; i<n-1; ++i)
	{
		min = MAX_COST;
		int u = v;
		for(int j=0; j<n; ++j)
		{
			if(!S[j] && dist[j]<min)
			{
				u = j;
				min = dist[j];
			}
		}

		S[u] = true;
		for(int k=0; k<n; ++k)
		{
			w = GetWeight(g,u,k);
			if(!S[k] && w<MAX_COST && dist[u]+w<dist[k])
			{
				dist[k] = dist[u]+w;
				path[k] = u;
			}
		}
	}
}