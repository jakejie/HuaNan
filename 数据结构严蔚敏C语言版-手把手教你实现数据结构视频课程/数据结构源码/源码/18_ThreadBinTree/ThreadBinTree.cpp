#include"ThreadBinTree.h"

void InitBinTree(BinTree *bt, ElemType ref)
{
	bt->root = NULL;
	bt->refvalue = ref;
}

BinTreeNode* _Buynode(ElemType x)
{
	BinTreeNode *s = (BinTreeNode*)malloc(sizeof(BinTreeNode));
	assert(s != NULL);
	s->data = x;
	s->leftChild = s->rightChild = NULL;
	s->ltag = s->rtag = LINK;
	return s;
}

void CreateBinTree(BinTree *bt, char *str)
{
	CreateBinTree(bt,bt->root,str);
}
void CreateBinTree(BinTree *bt, BinTreeNode *&t, char *&str)
{
	if(*str == bt->refvalue)
		t = NULL;
	else
	{
		t = _Buynode(*str);
		CreateBinTree(bt,t->leftChild,++str);
		CreateBinTree(bt,t->rightChild,++str);
	}
}

void CreateInThread(BinTree *bt)
{
	BinTreeNode *pre = NULL;
	CreateInThread(bt->root,pre);
	pre->rightChild = NULL;
	pre->rtag = THREAD;
}
void CreateInThread(BinTreeNode *&t, BinTreeNode *&pre)
{
	if(t == NULL)
		return;
	CreateInThread(t->leftChild,pre);
	if(t->leftChild == NULL)
	{
		t->ltag = THREAD;
		t->leftChild = pre;
	}
	if(pre!=NULL && pre->rightChild==NULL)
	{
		pre->rtag = THREAD;
		pre->rightChild = t;
	}
	pre = t;
	CreateInThread(t->rightChild,pre);
}

//////////////////////////////////////////////////////////
//2

BinTreeNode* First(BinTree *bt)
{
	return First(bt->root);
}
BinTreeNode* First(BinTreeNode *t)
{
	if(t == NULL)
		return NULL;
	BinTreeNode *p = t;
	while(p->ltag == LINK)
		p = p->leftChild;
	return p;
}
BinTreeNode* Last(BinTree *bt)
{
	return Last(bt->root);
}
BinTreeNode* Last(BinTreeNode *t)
{
	if(t == NULL)
		return NULL;
	BinTreeNode *p = t;
	while(p->rtag == LINK)
		p = p->rightChild;
	return p;
}

BinTreeNode* Next(BinTree *bt, BinTreeNode *cur)
{
	return Next(bt->root,cur);
}
BinTreeNode* Next(BinTreeNode *t, BinTreeNode *cur)
{
	if(t==NULL || cur==NULL)
		return NULL;
	if(cur->rtag == THREAD)
		return cur->rightChild;
	return First(cur->rightChild);
}
BinTreeNode* Prio(BinTree *bt, BinTreeNode *cur)
{
	return Prio(bt->root,cur);
}
BinTreeNode* Prio(BinTreeNode *t, BinTreeNode *cur)
{
	if(t==NULL || cur==NULL)
		return NULL;
	if(cur->ltag == THREAD)
		return cur->leftChild;
	return Last(cur->leftChild);
}

void InOrder(BinTree *bt)
{
	InOrder(bt->root);
}
void InOrder(BinTreeNode *t)
{
	BinTreeNode *p;
	for(p=First(t); p!=NULL; p=Next(t,p))
	{
		printf("%c ",p->data);
	}
	printf("\n");
}

BinTreeNode* Search(BinTree *bt, ElemType key)
{
	return Search(bt->root,key);
}
BinTreeNode* Search(BinTreeNode *t, ElemType key)
{
	if(t == NULL)
		return NULL;
	if(t->data == key)
		return t;

	BinTreeNode *p;
	for(p=First(t); p!=NULL; p=Next(t,p))
	{
		if(p->data == key)
			return p;
	}
	return NULL;

}
BinTreeNode* Parent(BinTree *bt, BinTreeNode *cur)
{
	return Parent(bt->root,cur);
}
BinTreeNode* Parent(BinTreeNode *t, BinTreeNode *cur)
{
	if(t==NULL || cur==NULL)
		return NULL;
	if(t == cur)
		return NULL;

	BinTreeNode *p;
	if(cur->ltag == THREAD)
	{
		p = cur->leftChild;
		if(p->rightChild == cur)
			return p;
	}
	if(cur->rtag == THREAD)
	{
		p = cur->rightChild;
		if(p->leftChild == cur)
			return p;
	}

	p = First(cur->leftChild);
	p = p->leftChild;
	if(p!=NULL && p->rightChild == cur)
		return p;

	p = Last(cur->rightChild);
	return p->rightChild;
}