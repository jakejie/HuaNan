#include"SeqQueue.h"

void InitQueue(Queue *Q)
{
	Q->base = (ElemType *)malloc(sizeof(ElemType) * MAXSIZE);
	assert(Q->base != NULL);
	Q->front = Q->rear = 0;
}

void EnQueue(Queue *Q, ElemType x)
{
	if(((Q->rear+1)%MAXSIZE) == Q->front)
		return;

	Q->base[Q->rear] = x;
	Q->rear = (Q->rear+1)%MAXSIZE;
}

void ShowQueue(Queue *Q)
{
	for(int i=Q->front; i!=Q->rear;)
	{
		printf("%d ",Q->base[i]);
		i = (i+1)%MAXSIZE;
	}
	printf("\n");
}

void DeQueue(Queue *Q)
{
	if(Q->front == Q->rear)
		return;
	Q->front = (Q->front+1)%MAXSIZE;
}

void GetHdad(Queue *Q, ElemType *v)
{
	if(Q->front == Q->rear)
		return;
	*v = Q->base[Q->front];
}
int Length(Queue *Q)
{
	return (Q->rear - Q->front);
}
void ClearQueue(Queue *Q)
{
	Q->front = Q->rear = 0;
}
void DestroyQueue(Queue *Q)
{
	free(Q->base);
	Q->base = NULL;
}
