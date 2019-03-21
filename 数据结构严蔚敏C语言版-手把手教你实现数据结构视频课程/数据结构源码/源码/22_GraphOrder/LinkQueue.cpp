#include"LinkQueue.h"

bool Empty(LinkQueue *Q)
{
	return Q->front == Q->tail;
}

void InitQueue(LinkQueue *Q)
{
	QueueNode *s = (QueueNode *)malloc(sizeof(QueueNode));
	assert(s != NULL);
	Q->front = Q->tail = s;
	Q->tail->next = NULL;
}

void EnQueue(LinkQueue *Q, ElemType x)
{
	QueueNode *s = (QueueNode *)malloc(sizeof(QueueNode));
	assert(s != NULL);
	s->data = x;
	s->next = NULL;

	Q->tail->next = s;
	Q->tail = s;
}

void ShowQueue(LinkQueue *Q)
{
	QueueNode *p = Q->front->next;
	printf("Front:>");
	while(p != NULL)
	{
		printf("%d ",p->data);
		p = p->next;
	}
	printf("<:Tail.\n");
}

void DeQueue(LinkQueue *Q)
{
	if(Q->front == Q->tail)
		return;

	QueueNode *p = Q->front->next;

	Q->front->next = p->next;
	free(p);
	if(p == Q->tail)
		Q->tail = Q->front;
}

void GetHead(LinkQueue *Q, ElemType *v)
{
	if(Q->front == Q->tail)
		return;
	QueueNode *p = Q->front->next;
	*v = p->data;
}

int Length(LinkQueue *Q)
{
	int len = 0;
	QueueNode *p = Q->front->next;
	while(p != NULL)
	{
		len++;
		p = p->next;
	}
	return len;
}

void ClearQueue(LinkQueue *Q)
{
	if(Q->front == Q->tail)
		return;
	QueueNode *p = Q->front->next;
	while(p != NULL)
	{
		Q->front->next = p->next;
		free(p);
		p = Q->front->next;
	}
	Q->tail = Q->front;
}

void DestroyQueue(LinkQueue *Q)
{
	ClearQueue(Q);
	free(Q->front);
	Q->front = Q->tail = NULL;
}