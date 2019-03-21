#ifndef _SPARSEMATRIX_H
#define _SPARSEMATRIX_H

#include<stdio.h>
#include<memory.h>
#include<stdlib.h>
#include<assert.h>

#define ElemType int
#define MAXSIZE 100

typedef struct Triple
{
	int i;
	int j;
	ElemType e;
}Triple;

typedef struct SMatrix
{
	Triple data[MAXSIZE]; // 0
	int mu;
	int nu;
	int tu;
}SMatrix;

///////////////////////////////////////////////////////
void CreateMatrix(SMatrix *M);
void PrintMatrix(SMatrix *M);
void CopyMatrix(SMatrix *M, SMatrix *T);
void AddMatrix(SMatrix *M, SMatrix *N, SMatrix *T); //M N
void SubMatrix(SMatrix *M, SMatrix *N, SMatrix *T);
void MulMatrix(SMatrix *M, SMatrix *N, SMatrix *T); //M (m,n) N(x,y)
void TransposeMatrix(SMatrix *M, SMatrix *T);
void FastTransposeMatrix(SMatrix *M, SMatrix *T);

#endif