#include<stdio.h>
#include<malloc.h>
#include<assert.h>

#define P 7

#define NULL_DATA -1
#define BUCKET_NODE_SIZE 3

struct bucket_node	
{
	int data[BUCKET_NODE_SIZE];
	struct bucket_node *next;
};

bucket_node hash_table[P];

void Init_bucket_node()
{
	for(int i=0; i<P; ++i)
	{
		for(int j=0; j<BUCKET_NODE_SIZE; ++j)
		{
			hash_table[i].data[j] = NULL_DATA;
		}
		hash_table[i].next = NULL;
	}
}

int Hash(int key)
{
	return key % P;
}

int Insert_new_element(int x)
{
	int index = Hash(x);
	for(int i=0; i<BUCKET_NODE_SIZE; ++i)
	{
		if(hash_table[index].data[i] == NULL_DATA)
		{
			hash_table[index].data[i] = x;
			return 0;
		}
	}

	bucket_node *p = &hash_table[index];
	while(p->next != NULL)
	{
		p = p->next;
		for(i=0; i<BUCKET_NODE_SIZE; ++i)
		{
			if(p->data[i] == NULL_DATA)
			{
				p->data[i] = x;
				return 0;
			}
		}
	}

	bucket_node *s = (bucket_node*)malloc(sizeof(bucket_node));
	assert(s != NULL);
	for(i=0; i<BUCKET_NODE_SIZE; ++i)
	{
		s->data[i] = NULL_DATA;	
	}
	s->next = NULL;

	s->data[0] = x;
	p->next = s;   //
	return 0;
}

int main()
{
	Init_bucket_node();
	int array[] = {15,14,21,87,96,293,35,24,149,19,63,16,103,77,5,153,145,356,51,68,705,453 };
	//int array[] = {1,8,15,22,29,36,43};
	for(int i = 0; i < sizeof(array)/sizeof(int); i++)
	{
		Insert_new_element(array[i]);
	}
	return 0;
}



/*
#define ElemType int
#define P 13

typedef struct HashNode
{
	ElemType data;
	struct HashNode *link;
}HashNode;

typedef HashNode* HashTable[P]; //

void InitHashTable(HashTable &ht)
{
	for(int i=0; i<P; ++i)
	{
		ht[i] = NULL;
	}
}

int Hash(ElemType key)
{
	return key % P;
}

void InsertHashTable(HashTable &ht, ElemType x)
{
	int index = Hash(x);
	HashNode *s = (HashNode *)malloc(sizeof(HashNode));
	assert(s != NULL);
	s->data = x;

	s->link = ht[index];
	ht[index] = s;
}

void ShowHashTable(HashTable &ht)
{
	for(int i=0; i<P; ++i)
	{
		printf("%d : ",i);
		HashNode *p = ht[i];
		while(p != NULL)
		{
			printf("%d-->",p->data);
			p = p->link;
		}
		printf("Nul. \n");
	}
}

HashNode* SearchHashTable(HashTable &ht, ElemType key)
{
	int index = Hash(key);
	HashNode *p = ht[index];
	while(p!=NULL && p->data!=key)
		p = p->link;
	return p;
}

bool RemoveHashTable(HashTable &ht, ElemType key)
{
	HashNode *p = SearchHashTable(ht,key);
	if(p == NULL)
		return false;

	int index = Hash(key);
	HashNode *q = ht[index];
	if(q == p)
	{
		ht[index] = p->link;
		free(p);
		return true;
	}

	while(q->link != p)
		q = q->link;
	q->link = p->link;
	free(p);
	return true;
}
////////////////////////////////////////////////////

void main()
{
	HashTable ht;
	InitHashTable(ht);

	ElemType ar[] = {19,14,23,1,68,20,84,27,55,11,10,79};
	int n = sizeof(ar)/sizeof(ElemType);

	for(int i=0; i<n; ++i)
	{
		InsertHashTable(ht, ar[i]);
	}

	ElemType key = 27;
	HashNode *p = SearchHashTable(ht, key);

	RemoveHashTable(ht, key);

	ShowHashTable(ht);
}
*/