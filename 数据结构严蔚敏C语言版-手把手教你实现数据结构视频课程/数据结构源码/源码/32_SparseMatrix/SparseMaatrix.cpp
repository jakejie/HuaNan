#include"SparseMatrix.h"

void CreateMatrix(SMatrix *M)
{
	FILE *fp = fopen("Matrix.txt","r");
	if(fp == NULL)
		exit(1);

	fscanf(fp,"%d %d",&M->mu,&M->nu);

	fclose(fp);
}