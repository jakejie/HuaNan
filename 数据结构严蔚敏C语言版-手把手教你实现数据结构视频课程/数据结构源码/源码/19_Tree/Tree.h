#pragma once

#include<stdio.h>
#include<malloc.h>
#include<assert.h>

#define ElemType char

typedef struct TreeNode
{
	ElemType data;
	struct TreeNode *fristChild; 
	struct TreeNode *nextSibling; 
}TreeNode;

typedef struct Tree
{
	TreeNode *root;
	ElemType refvalue;
}Tree;

void InitTree(Tree *tree,ElemType ref);
void CreateTree(Tree *tree, char *str);
void CreateTree(Tree *tree, TreeNode *&t, char *&str);

TreeNode* Root(Tree *tree);
TreeNode* FirstChild(Tree *tree);
TreeNode* FirstChild(TreeNode *t);
TreeNode* NextSibling(Tree *tree);
TreeNode* NextSibling(TreeNode *t);
TreeNode* Find(Tree *tree, ElemType key);
TreeNode* Find(TreeNode *t, ElemType key);
TreeNode* Parent(Tree *tree, TreeNode *p);
TreeNode* Parent(TreeNode *t, TreeNode *p);