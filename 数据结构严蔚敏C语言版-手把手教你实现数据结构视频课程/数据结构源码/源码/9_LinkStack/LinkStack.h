#ifndef __LINKSTACK_H__
#define __LINKSTACK_H__


#include<stdio.h>
#include<malloc.h>
#include<assert.h>

#define ElemType int

typedef struct StackNode
{
	ElemType data;
	struct StackNode *next;
}StackNode;

typedef StackNode* LinkStack;

void InitStack(LinkStack *s);
void Push(LinkStack *s, ElemType x);
void Show(LinkStack *s);
void Pop(LinkStack *s);

#endif //__LINKSTACK_H__