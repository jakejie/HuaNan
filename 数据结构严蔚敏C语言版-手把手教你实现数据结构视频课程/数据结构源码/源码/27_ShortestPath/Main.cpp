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

	InsertEdge(&gm,'A','B',10);
	InsertEdge(&gm,'A','D',30);
	InsertEdge(&gm,'A','E',100);
	InsertEdge(&gm,'B','C',50);
	InsertEdge(&gm,'C','E',10);
	InsertEdge(&gm,'D','C',20);
	InsertEdge(&gm,'D','E',60);
	ShowGraph(&gm);

	int n = gm.NumVertices;
	//
	E dist[5];
	int path[5];
	//E *dist = (E *)malloc(sizeof(E) * n);
	//int *path = (int*)malloc(sizeof(int) *n);
	//assert(dist!=NULL && path!=NULL);

	ShortestPath(&gm,'A',dist,path);
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