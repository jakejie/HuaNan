#include"BST.h"

void InitBSTree(BST *bst)
{
	bst->root = NULL;
}

BOOL InsertBSTree(BSTNode **t, T x)
{
	if(*t == NULL)
	{
		*t = (BSTNode*)malloc(sizeof(BSTNode));
		assert(*t != NULL);
		(*t)->data = x;
		(*t)->leftChild = NULL;
		(*t)->rightChild = NULL;
		return TRUE;
	}
	else if(x < (*t)->data)
	{
		InsertBSTree(&(*t)->leftChild,x);
	}
	else if(x > (*t)->data)
	{
		InsertBSTree(&(*t)->rightChild,x);
	}
	return FALSE;
}
BOOL InsertBSTree(BST *bst, T x)
{
	return InsertBSTree(&bst->root, x);
}

T Min(BSTNode *t)
{
	while(t->leftChild != NULL)
		t = t->leftChild;
	return t->data;
}
T Min(BST *bst)
{
	assert(bst->root != NULL);
	return Min(bst->root);
}
T Max(BSTNode *t)
{
	while(t->rightChild != NULL)
		t = t->rightChild;
	return t->data;
}
T Max(BST *bst)
{
	assert(bst->root != NULL);
	return Max(bst->root);
}

void Sort(BSTNode *t)
{
	if(t != NULL)
	{
		Sort(t->leftChild);
		printf("%d ",t->data);
		Sort(t->rightChild);
	}
}
void Sort(BST *bst)
{
	Sort(bst->root);
}

BSTNode* Search(BSTNode *t, T key)
{
	if(t == NULL)
		return NULL;
	if(t->data == key)
		return t;
	if(key < t->data)
		return Search(t->leftChild,key);
	else
		return Search(t->rightChild,key);
}
BSTNode* Search(BST *bst, T key)
{
	return Search(bst->root, key);
}


void MakeEmptyBSTree(BSTNode **t)
{
	if(*t != NULL)
	{
		MakeEmptyBSTree(&(*t)->leftChild);
		MakeEmptyBSTree(&(*t)->rightChild);
		free(*t);
		*t = NULL;
	}
}
void MakeEmptyBSTree(BST *bst)
{
	MakeEmptyBSTree(&bst->root);
}

BOOL RemoveBSTree(BSTNode **t, T key)
{
	if(*t == NULL)
		return FALSE;
	if(key < (*t)->data)
		RemoveBSTree(&(*t)->leftChild, key);
	else if(key > (*t)->data)
		RemoveBSTree(&(*t)->rightChild, key);
	else
	{
		BSTNode *p = NULL;
		if((*t)->leftChild!=NULL && (*t)->rightChild!=NULL)
		{
			p = (*t)->rightChild;
			while(p->leftChild != NULL)
				p = p->leftChild;
			(*t)->data = p->data;
			RemoveBSTree(&(*t)->rightChild,p->data);
		}
		else
		{
			p = *t;
			if((*t)->leftChild == NULL)
				(*t) = (*t)->rightChild;
			else
				(*t) = (*t)->leftChild;
			free(p);
			p = NULL;
		}
	}
	return TRUE;
}
BOOL RemoveBSTree(BST *bst, T key)
{
	return RemoveBSTree(&bst->root,key);
}

/*
BOOL RemoveBSTree(BSTNode **t, T key)
{
	if(*t == NULL)
		return FALSE;
	if(key < (*t)->data)
		RemoveBSTree(&(*t)->leftChild, key);
	else if(key > (*t)->data)
		RemoveBSTree(&(*t)->rightChild, key);
	else
	{
		BSTNode *p = NULL;
		if((*t)->leftChild==NULL && (*t)->rightChild==NULL)
		{
			free(*t);
			*t = NULL;
		}
		else if((*t)->leftChild!=NULL && (*t)->rightChild==NULL)
		{
			p = *t;
			*t = (*t)->leftChild;
			free(p);
			p = NULL;
		}
		else if((*t)->leftChild==NULL && (*t)->rightChild!=NULL)
		{
			p = *t;
			*t = (*t)->rightChild;
			free(p);
			p = NULL;
		}
		else
		{
			p = (*t)->rightChild;
			while(p->leftChild != NULL)
				p = p->leftChild;
			(*t)->data = p->data;
			RemoveBSTree(&(*t)->rightChild,p->data);
		}
	}
}
BOOL RemoveBSTree(BST *bst, T key)
{
	return RemoveBSTree(&bst->root,key);
}
*/