#pragma once
#include<stdio.h>
#include<malloc.h>
#include<assert.h>

#define Default_Vertex_Size  10

#define T char

typedef struct GraphMtx
{
	int MaxVertices;
	int NumVertices;
	int NumEdges;

	T   *VerticesList;
	int **Edge;
}GraphMtx;

void InitGraph(GraphMtx *g);
int  GetVertexPos(GraphMtx *g, T v);
void ShowGraph(GraphMtx *g);
void InsertVertex(GraphMtx *g, T v);
void InsertEdge(GraphMtx *g, T v1, T v2);
void RemoveVertex(GraphMtx *g, T v);
void RemoveEdge(GraphMtx *g, T v1, T v2);
void DestroyGraph(GraphMtx *g);
int  GetFirstNeighbor(GraphMtx *g, T v);
int  GetNextNeighbor(GraphMtx *g, T v, T w);