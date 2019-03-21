#include"GraphLnk.h"

void main()
{
	GraphLnk gl;
	InitGraph(&gl);
	InsertVertex(&gl,'A');
	InsertVertex(&gl,'B');
	InsertVertex(&gl,'C');
	InsertVertex(&gl,'D');
	InsertVertex(&gl,'E');
	InsertVertex(&gl,'F');
	
	InsertEdge(&gl,'A','B');
	InsertEdge(&gl,'A','C');
	InsertEdge(&gl,'A','D');
	InsertEdge(&gl,'C','B');
	InsertEdge(&gl,'C','E');
	InsertEdge(&gl,'D','E');
	InsertEdge(&gl,'F','D');
	InsertEdge(&gl,'F','E');

	ShowGraph(&gl);

	TopologicalSort(&gl);
	printf("\n");

	DestroyGraph(&gl);
}