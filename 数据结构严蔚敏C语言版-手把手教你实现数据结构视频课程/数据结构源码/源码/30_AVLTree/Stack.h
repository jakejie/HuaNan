#ifndef __Stack_H__
#define __Stack_H__


#include<stdio.h>
#include<malloc.h>
#include<assert.h>

struct AVLNode;

#define ElemType AVLNode*

typedef struct StackNode
{
	ElemType data;
	struct StackNode *next;
}StackNode;

typedef StackNode* Stack;

void InitStack(Stack *s);
void Push(Stack *s, ElemType x);
void Show(Stack *s);
void Pop(Stack *s);
bool IsEmpty(Stack *s);
ElemType GetTop(Stack *s);

#endif //__Stack_H__