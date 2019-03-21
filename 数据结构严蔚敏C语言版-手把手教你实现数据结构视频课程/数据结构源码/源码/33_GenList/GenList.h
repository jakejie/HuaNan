#pragma once

#include<stdio.h>
#include<string.h>
#include<malloc.h>
#include<assert.h>
#include<stdlib.h>

#define AtomType int
typedef enum{HEAD,ATOM,CHILDLIST}ElemTag;

typedef struct GLNode
{
	ElemTag tag; //
	union
	{
		AtomType atom;
		struct GLNode *hp;
	};
	struct GLNode *tp;
}GLNode;

typedef GLNode* GenList; //
void InitGenList(GenList &gl);
void CreateGenList(GenList &gl, char *str);
bool sever(char *sub, char *hsub);

///////////////////////////////////////////////////
void ShowGenList(GenList &gl);
bool GenListEmpty(GenList &gl);
int  GenListLength(GenList &gl);
int  GenListDepth(GenList &gl);