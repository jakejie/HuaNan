#pragma once

#include"Sort.h"

void siftDown(T heap[], int n, int p)
{
	int i = p;
	int j = 2*i+1;
	while(j < n)
	{
		if(j<n-1 && heap[j]>heap[j+1])
			j++;
		if(heap[i] <= heap[j])
			break;
		else
		{
			Swap(&heap[i], &heap[j]);
			i = j;
			j = 2*i+1;
		}
	}
}

T RemoveMinKey(T heap[], int n)
{
	T key = heap[0];
	heap[0] = heap[n];
	siftDown(heap,n,0);
	return key;
}

void HeapSort(SqList &L, int n)
{
	T *heap = (T *)malloc(sizeof(T) * n);
	assert(heap != NULL);
	for(int i=0; i<n; ++i)
	{
		heap[i] = L[i];
	}

	int curpos = n/2-1;
	while(curpos >= 0)
	{
		siftDown(heap, n, curpos);
		curpos--;
	}

	for(i=0; i<n; ++i)
	{
		L[i] = RemoveMinKey(heap, n-i-1);
	}

	free(heap);
	heap = NULL;
}