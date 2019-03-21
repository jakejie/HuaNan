#pragma once

#include"Sort.h"
#include"SList.h"

//278
int getkey(T value, int k)
{
	int key;
	while(k >= 0)
	{
		key = value % 10;
		value /= 10;
		k--;
	}
	return key;
}

void Distribute(SqList &L, int n, List (&lt)[10], int k)
{
	for(int i=0; i<10; ++i)
	{
		clear(&lt[i]);
	}
	int key;
	for(i=0; i<n; ++i)
	{
		key = getkey(L[i], k);
		push_back(&lt[key],L[i]);
	}
}

void Collect(SqList &L, List(&lt)[10])
{
	int k = 0;
	for(int i=0; i<10; ++i)
	{
		Node *p = lt[i].first->next;
		while(p != NULL)
		{
			L[k++] = p->data;
			p = p->next;
		}
	}
}

void RadixSort(SqList &L, int n)
{
	List list[10];
	for(int i=0; i<10; ++i)
	{
		InitList(&list[i]);
	}

	for(i = 0; i<3; ++i)// 5  0  5
	{
		Distribute(L, n, list, i);
		Collect(L,list);
	}

}