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
	InsertVertex(&gl,'G');
	InsertVertex(&gl,'H');
	InsertVertex(&gl,'I');
	InsertVertex(&gl,'J');
	InsertVertex(&gl,'K');
	InsertVertex(&gl,'L');
	InsertVertex(&gl,'M');

	InsertEdge(&gl,'A','B');
	InsertEdge(&gl,'A','C');
	InsertEdge(&gl,'A','F');
	InsertEdge(&gl,'A','L');
	InsertEdge(&gl,'B','M');
	InsertEdge(&gl,'L','J');
	InsertEdge(&gl,'L','M');
	InsertEdge(&gl,'J','M');
	InsertEdge(&gl,'D','E');
	InsertEdge(&gl,'G','H');
	InsertEdge(&gl,'G','I');
	InsertEdge(&gl,'G','K');
	InsertEdge(&gl,'H','K');

	ShowGraph(&gl);

	DFS(&gl,'D');
	printf("Nul.\n");

	BFS(&gl,'A');
	printf("Nul.\n");

	Components(&gl);
	printf("Nul.\n");

	DestroyGraph(&gl);
}