#include<stdio.h>
#include"Sort.h"
#include"Heap.h"
#include"RadixSort.h"

//#define USE_ZERO_SPACE

void main()
{
	SqList L = {278,109,63,930,589,184,505,269,8,83};
	int n = 10;

	RadixSort(L, n);

	for(int i=0; i<n; ++i)
	{
		printf("%d ",L[i]);
	}
	printf("\n");
}

/*
void main()
{
#ifdef USE_ZERO_SPACE
	SqList L = {0,49,38,65,97,76,13,27,49};
	int n = 9;
#else
	SqList L = {49,38,65,97,76,13,27,49};
	int n = 8;
#endif

	//SqList TP;
	//MergeSort(L,TP,0,n-1);

	//HeapSort(L, n);

	//TreeSelectSort(L, n);

	//SelectSort(L, n);

	//int low = 0;
	//int high = n-1;
	//QuickSort(L, low, high);

	//BubbleSort(L,n);

	//int dlta[] = {5,3,2,1};
	//int t = sizeof(dlta)/sizeof(int);
	//ShellSort(L, n, dlta, t);

	//TWayInsertSort(L, n);
	//BInsertSort(L,n);
	//InsertSort(L,n);

#ifdef USE_ZERO_SPACE
	for(int i=1; i<n; ++i)
	{
		printf("%d ",L[i]);
	}
	printf("\n");
#else
	for(int i=0; i<n; ++i)
	{
		printf("%d ",L[i]);
	}
	printf("\n");
#endif
}

/*

void main()
{
	SqList L = {0,49,38,65,97,76,13,27,49};
	int n = 9;
	Table tb;
	tb[0].data = MAXVALUE;
	tb[0].link = 0;
	for(int i=1; i<n; ++i)
	{
		tb[i].data = L[i];
		tb[i].link = 0;
	}

	TableInsertSort(tb, n);

	for(i=0; i<n; ++i)
	{
		printf("%d ",tb[i].data);
	}
	printf("\n");
	for(i=0; i<n; ++i)
	{
		printf("%d ",tb[i].link);
	}
	printf("\n");
}

*/