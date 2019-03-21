#include<stdio.h>
#include<malloc.h>
#include<assert.h>
#include"Stack.h"

#define ElemType char

typedef struct BinTreeNode
{
	ElemType data;
	struct BinTreeNode *leftChild;
	struct BinTreeNode *rightChild;
}BinTreeNode;

typedef struct BinTree
{
	BinTreeNode *root;
	ElemType     refvalue; //stop flag
}BinTree;

void InitBinTree(BinTree *bt, ElemType ref);
void CreateBinTree_4(BinTree *bt, char *str);
void CreateBinTree_4(BinTree *bt, BinTreeNode *&t, char *&str);
void PostOrder(BinTree *bt);
void PostOrder(BinTreeNode *t);
/////////////////////////////////////////////////////////////////

void InitBinTree(BinTree *bt, ElemType ref)
{
	bt->root = NULL;
	bt->refvalue = ref;
}
void CreateBinTree_4(BinTree *bt, char *str)
{
	CreateBinTree_4(bt,bt->root,str);
}
void CreateBinTree_4(BinTree *bt, BinTreeNode *&t, char *&str)
{
	if(*str == bt->refvalue)
		t = NULL;
	else
	{
		t = (BinTreeNode*)malloc(sizeof(BinTreeNode));
		assert(t != NULL);
		t->data = *str;
		CreateBinTree_4(bt,t->leftChild,++str);
		CreateBinTree_4(bt,t->rightChild,++str);
	}
}

void PostOrder(BinTree *bt)
{
	PostOrder(bt->root);
}
void PostOrder(BinTreeNode *t)
{
	if(t != NULL)
	{
		SeqStack st;
		InitStack(&st);
		BinTreeNode *p;
		StkNode sn;
		do
		{
			while(t != NULL)
			{
				sn.ptr = t;
				sn.tag = L;
				Push(&st,sn);
				t = t->leftChild;
			}
			bool flag = true; //continue visit
			while(flag && !IsEmpty(&st))
			{
				GetTop(&st,&sn);
				Pop(&st);
				p = sn.ptr;
				switch(sn.tag)
				{
				case L:
					sn.tag = R;
					Push(&st,sn);
					flag = false;
					t = p->rightChild;
					break;
				case R:
					printf("%c ",p->data);
					break;
				}
			}
		}while(!IsEmpty(&st));
	}
}
/////////////////////////////////////////////////////////////
void main()
{
	char *str = "ABC##DE##F##G#H##";
	BinTree mytree;
	InitBinTree(&mytree,'#');

	CreateBinTree_4(&mytree,str);

	PostOrder(&mytree);
	printf("\n");
}