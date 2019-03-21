#ifndef __LINKQUEUE_H__
#define __LINKQUEUE_H__

#include<stdio.h>
#include<malloc.h>
#include<assert.h>

#define ElemType int

typedef struct QueueNode
{
	ElemType data;
	struct QueueNode *next;
}QueueNode;

typedef struct LinkQueue
{
	QueueNode *front;
	QueueNode *tail;
}LinkQueue;

bool Empty(LinkQueue *Q);
void InitQueue(LinkQueue *Q);
void EnQueue(LinkQueue *Q, ElemType x);
void ShowQueue(LinkQueue *Q);
void DeQueue(LinkQueue *Q);
void GetHead(LinkQueue *Q, ElemType *v);
int Length(LinkQueue *Q);
void ClearQueue(LinkQueue *Q);
void DestroyQueue(LinkQueue *Q);

#endif //__LINKQUEUE_H__