#include<stdio.h>
#include"BST.h"
#include<vld.h>

void main()
{
	T ar[] = {45,12,53,3,37,100,24,61,90,78};
	int n = sizeof(ar)/sizeof(int);
	BST bst;
	InitBSTree(&bst);

	for(int i=0; i<n; ++i)
	{
		InsertBSTree(&bst,ar[i]);
	}

	T min = Min(&bst);
	T max = Max(&bst);

	RemoveBSTree(&bst,12);

	Sort(&bst);
	printf("\n");

	return;
}