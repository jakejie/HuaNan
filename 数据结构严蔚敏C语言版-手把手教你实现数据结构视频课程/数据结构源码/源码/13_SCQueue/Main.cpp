#include"SeqQueue.h"

void main()
{
	Queue Q;
	InitQueue(&Q);

	for(int i=1; i<=8; ++i)
	{
		EnQueue(&Q, i);
	}
	ShowQueue(&Q);
	DeQueue(&Q);
	EnQueue(&Q,10);
	DeQueue(&Q);
	EnQueue(&Q,20);
	ShowQueue(&Q);
}

