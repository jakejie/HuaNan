#include"SparseMatrix.h"

void CreateMatrix(SMatrix *M)
{
	FILE *fp = fopen("Matrix.txt","r");
	if(fp == NULL)
		exit(1);

	fscanf(fp,"%d %d",&M->mu, &M->nu);

	int value;
	int k = 0;
	for(int i=0; i<M->mu; ++i)
	{
		for(int j=0; j<M->nu; ++j)
		{
			fscanf(fp,"%d",&value);
			if(value != 0)
			{
				M->data[k].e = value;
				M->data[k].i = i;
				M->data[k].j = j;
				k++;
			}
		}
	}
	M->tu = k;
	fclose(fp);
}

void PrintMatrix(SMatrix *M)
{
	printf("row=%d, col=%d\n",M->mu,M->nu);
	for(int i=0; i<M->tu; ++i)
	{
		printf("(%d, %d, %d)\n",M->data[i].i,M->data[i].j,M->data[i].e);
	}
}

void CopyMatrix(SMatrix *M, SMatrix *T)
{
	T->mu = M->mu;
	T->nu = M->nu;
	T->tu = M->tu;

	for(int i=0; i<M->tu; i++)
	{
		T->data[i].i = M->data[i].i;
		T->data[i].j = M->data[i].j;
		T->data[i].e = M->data[i].e;
	}
}

void TransposeMatrix(SMatrix *M, SMatrix *T)
{
	T->mu = M->nu;
	T->nu = M->mu;
	T->tu = M->tu;

	int q = 0;
	if(M->tu != 0)
	{
		for(int col=0; col<M->nu; ++col)
		{
			for(int p=0; p<M->tu; ++p)
			{
				if(M->data[p].j == col)
				{
					T->data[q].i = M->data[p].j;
					T->data[q].j = M->data[p].i;
					T->data[q].e = M->data[p].e;
					q++;
				}
			}
		}
	}
}

void FastTransposeMatrix(SMatrix *M, SMatrix *T)
{
	T->mu = M->nu;
	T->nu = M->mu;
	T->tu = M->tu;

	int *num = (int *)malloc(sizeof(int) * M->nu);
	assert(num != NULL);
	int *cpot = (int*)malloc(sizeof(int) * M->nu);
	assert(cpot != NULL);

	if(T->tu != 0)
	{
		for(int col=0; col<M->nu; ++col)
		{
			num[col] = 0;
		}
		for(int t=0; t<M->tu; ++t)
		{
			num[M->data[t].j]++;
		}
		cpot[0] = 0;
		for(col=1; col<M->nu; ++col)
		{
			cpot[col] = cpot[col-1] + num[col-1];
		}

		int q = 0;
		for(int p=0; p<M->tu; ++p)
		{
			col = M->data[p].j;
			q = cpot[col];
			T->data[q].i = M->data[p].j;
			T->data[q].j = M->data[p].i;
			T->data[q].e = M->data[p].e;
			cpot[col]++;
		}
	}
	free(num);
	free(cpot);
}