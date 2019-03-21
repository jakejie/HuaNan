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

	InsertEdge(&gl,'A','B');
	InsertEdge(&gl,'A','D');
	InsertEdge(&gl,'B','C');
	InsertEdge(&gl,'B','E');
	InsertEdge(&gl,'C','D');
	InsertEdge(&gl,'C','E');
	ShowGraph(&gl);

	//RemoveEdge(&gl,'A','C');
	//RemoveVertex(&gl,'C');
	ShowGraph(&gl);

	//int v = GetFirstNeighbor(&gl,'A');
	int v = GetNextNeighbor(&gl,'B','A');

	DestroyGraph(&gl);
}