#ifndef __SEQQUEUE_H__
#define __SEQQUEUE_H__

#include<stdio.h>
#include<malloc.h>
#include<assert.h>

#define ElemType int

#define MAXSIZE 8

typedef struct Queue
{
	ElemType *base;
	int       front;
	int       rear;
}Queue;

void InitQueue(Queue *Q);
void EnQueue(Queue *Q, ElemType x);
void ShowQueue(Queue *Q);
void DeQueue(Queue *Q);

void GetHdad(Queue *Q, ElemType *v);
int Length(Queue *Q);
void ClearQueue(Queue *Q);
void DestroyQueue(Queue *Q);


#endif //__SEQQUEUE_H__