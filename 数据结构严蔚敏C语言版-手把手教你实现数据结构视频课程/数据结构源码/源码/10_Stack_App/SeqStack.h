#ifndef __SEQSTACK_H__
#define __SEQSTACK_H__

#include<stdio.h>
#include<malloc.h>
#include<assert.h>

#define ElemType char

#define STACK_INIT_SIZE  8
#define STACK_INC_SIZE   3

typedef struct SeqStack
{
	ElemType *base;
	int       capacity;
	int       top;
}SeqStack;

bool Inc(SeqStack *s);

void InitStack(SeqStack *s);
bool IsFull(SeqStack *s);
bool IsEmpty(SeqStack *s);

void Push(SeqStack *s, ElemType x);
void Pop(SeqStack *s);
bool GetTop(SeqStack *s, ElemType *v);
void Show(SeqStack *s);
int Length(SeqStack *s);
void Clear(SeqStack *s);
void Destroy(SeqStack *s);

void Print(SeqStack *s);

#endif //__SEQSTACK_H__