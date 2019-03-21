#pragma once

#include<stdio.h>
#include<malloc.h>
#include<assert.h>

#define Default_Vertex_Size 10
#define T  char

typedef struct Edge
{
	int dest;
	struct Edge *link;
}Edge;

typedef struct Vertex
{
	T data;
	Edge *adj;
}Vertex;

typedef struct GraphLnk
{
	int MaxVertices;
	int NumVertices;
	int NumEdges;

	Vertex *NodeTable;
}GraphLnk;

void InitGraph(GraphLnk *g);
int  GetVertexPos(GraphLnk *g, T v);
void ShowGraph(GraphLnk *g);
void InsertVertex(GraphLnk *g, T v);
void InsertEdge(GraphLnk *g, T vertex1, T vertex2);

void RemoveEdge(GraphLnk *g, T vertex1, T vertex2);
void RemoveVertex(GraphLnk *g, T vertex);
void DestroyGraph(GraphLnk *g);
int  GetFirstNeighbor(GraphLnk *g, T vertex);
int  GetNextNeighbor(GraphLnk *g,  T vertex1, T vertex2);

void TopologicalSort(GraphLnk *g);

