#pragma once

#include<stdio.h>
#include<malloc.h>
#include<assert.h>

#define T int
#define FALSE 0
#define TRUE  1
#define BOOL  int

typedef struct BSTNode
{
	T data;
	BSTNode *leftChild;
	BSTNode *rightChild;
}BSTNode;

typedef struct BST
{
	BSTNode *root;
}BST;

void InitBSTree(BST *bst);

BOOL InsertBSTree(BSTNode **t, T x);
BOOL InsertBSTree(BST *bst, T x);
T Min(BSTNode *t);
T Min(BST *bst);
T Max(BSTNode *t);
T Max(BST *bst);
void Sort(BSTNode *t);
void Sort(BST *bst);


BSTNode* Search(BSTNode *t, T key);
BSTNode* Search(BST *bst, T key);

BOOL RemoveBSTree(BSTNode **t, T key);
BOOL RemoveBSTree(BST *bst, T key);

void MakeEmptyBSTree(BSTNode **t);
void MakeEmptyBSTree(BST *bst);
