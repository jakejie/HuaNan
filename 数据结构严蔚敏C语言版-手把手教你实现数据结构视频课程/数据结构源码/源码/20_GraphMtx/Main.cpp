#include"GraphMtx.h"

void main()
{
	GraphMtx gm;
	InitGraph(&gm);
	InsertVertex(&gm,'A');
	InsertVertex(&gm,'B');
	InsertVertex(&gm,'C');
	InsertVertex(&gm,'D');
	InsertVertex(&gm,'E');

	InsertEdge(&gm,'A','B');
	InsertEdge(&gm,'A','D');
	InsertEdge(&gm,'B','C');
	InsertEdge(&gm,'B','E');
	InsertEdge(&gm,'C','E');
	InsertEdge(&gm,'C','D');
	ShowGraph(&gm);
	//int p = GetFirstNeighbor(&gm,'D');
	int p = GetNextNeighbor(&gm,'D','C');
}


/*
void main()
{
	GraphMtx gm;
	InitGraph(&gm);
	InsertVertex(&gm,'A');
	InsertVertex(&gm,'B');
	InsertVertex(&gm,'C');
	InsertVertex(&gm,'D');
	InsertVertex(&gm,'E');

	InsertEdge(&gm,'A','B');
	InsertEdge(&gm,'A','D');
	InsertEdge(&gm,'B','C');
	InsertEdge(&gm,'B','E');
	InsertEdge(&gm,'C','E');
	InsertEdge(&gm,'C','D');
	ShowGraph(&gm);

	RemoveEdge(&gm,'B','C');
	ShowGraph(&gm);

	RemoveVertex(&gm,'C');
	ShowGraph(&gm);



	DestroyGraph(&gm);
}
*/