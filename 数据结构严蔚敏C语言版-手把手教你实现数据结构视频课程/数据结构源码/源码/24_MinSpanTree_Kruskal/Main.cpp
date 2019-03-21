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
	InsertVertex(&gm,'F');

	InsertEdge(&gm,'A','B',6);
	InsertEdge(&gm,'A','C',1);
	InsertEdge(&gm,'A','D',5);
	InsertEdge(&gm,'B','C',5);
	InsertEdge(&gm,'B','E',3);
	InsertEdge(&gm,'C','D',5);
	InsertEdge(&gm,'C','E',6);
	InsertEdge(&gm,'C','F',4);
	InsertEdge(&gm,'D','F',2);
	InsertEdge(&gm,'E','F',6);
	ShowGraph(&gm);

	//MinSpanTree_Prim(&gm,'E');
	MinSpanTree_Kruskal(&gm);
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