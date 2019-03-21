#include"LinkQueue.h"

void main()
{
	LinkQueue Q;
	InitQueue(&Q);

	for(int i=1; i<=10; ++i)
	{
		EnQueue(&Q,i);
	}
	ShowQueue(&Q);
	DeQueue(&Q);
	DeQueue(&Q);
	ShowQueue(&Q);
	printf("Len = %d\n",Length(&Q));
}