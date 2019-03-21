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
	InsertVertex(&gm,'G');
	InsertVertex(&gm,'H');
	InsertVertex(&gm,'I');

	InsertEdge(&gm,'A','B',6);
	InsertEdge(&gm,'A','C',4);
	InsertEdge(&gm,'A','D',5);
	InsertEdge(&gm,'B','E',1);
	InsertEdge(&gm,'C','E',1);
	InsertEdge(&gm,'D','F',2);
	InsertEdge(&gm,'E','G',9);
	InsertEdge(&gm,'E','H',7);
	InsertEdge(&gm,'F','H',4);
	InsertEdge(&gm,'G','I',2);
	InsertEdge(&gm,'H','I',6);

	ShowGraph(&gm);

	CriticalPath(&gm);
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