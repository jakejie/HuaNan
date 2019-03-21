#include"AVLTree.h"
#include"Stack.h"

void InitAVLTree(AVLTree *avl)
{
	avl->root = NULL;
}

AVLNode* BuyNode(Type x)
{
	AVLNode *p = (AVLNode *)malloc(sizeof(AVLNode));
	assert(p != NULL);
	p->data = x;
	p->leftChild = p->rightChild = NULL;
	p->bf = 0;
	return p;
}

BOOL InsertAVL(AVLTree *avl, Type x)
{
	return InsertAVL(avl->root, x);
}

BOOL InsertAVL(AVLNode *&t , Type x)
{
	AVLNode *p = t;
	AVLNode *parent = NULL;

	Stack st;
	InitStack(&st);

	while(p != NULL)
	{
		if(x == p->data)
			return FALSE;
		parent = p;
		Push(&st,parent);
		if(x < p->data)
			p = p->leftChild;
		else
			p = p->rightChild;
	}
	p = BuyNode(x);
	if(parent == NULL)
	{
		t = p;
		return TRUE;
	}
	if(x < parent->data)
		parent->leftChild = p;
	else
		parent->rightChild = p;

	/////////////////////////////////////////////
	//调整BF
	while(!IsEmpty(&st))
	{
		parent = GetTop(&st);
		Pop(&st);
		if(parent->leftChild == p)
			parent->bf--;
		else
			parent->bf++;
		if(parent->bf == 0)
			break;
		if(parent->bf==1 || parent->bf==-1)
			p = parent;
		else
		{
			//////////////////////////////
			//旋转化平衡调整
			int flag = (parent->bf<0)?-1:1;
			if(p->bf == flag)   //单旋转
			{
				if(flag == -1)
					RotateR(parent);  //   /
				else
					RotateL(parent);  //   \

			}
			else   //双旋转
			{
				if(flag == 1)
					RotateRL(parent); // >
				else
					RotateLR(parent); // <
			}	
			break;
		}
	}

	if(IsEmpty(&st))
		t = parent;
	else
	{
		AVLNode *q = GetTop(&st);
		if(q->data > parent->data)
			q->leftChild = parent;
		else
			q->rightChild = parent;
	}

	return TRUE;
}

BOOL RemoveAVL(AVLTree *avl, Type key)
{
	return RemoveAVL(avl->root, key);
}
BOOL RemoveAVL(AVLNode *&t, Type key)
{
	AVLNode *ppr    = NULL;
	AVLNode *parent = NULL;
	AVLNode *p = t;
	Stack st;
	InitStack(&st);
	while(p != NULL)
	{
		if(p->data == key)
			break;
		parent = p;
		Push(&st,parent);
		if(key < p->data)
			p = p->leftChild;
		else
			p = p->rightChild;
	}
	if(p == NULL)
		return FALSE;

	AVLNode *q;
	int f = 0;   //leftChild NULL   Or  rightChild NULL
	if(p->leftChild!=NULL && p->rightChild!=NULL)
	{
		parent = p;
		Push(&st,parent);
		q = p->leftChild;
		while(q->rightChild != NULL)
		{
			parent = q;
			Push(&st,parent);
			q = q->rightChild;
		}
		p->data = q->data;
		p = q;
	}
	if(p->leftChild != NULL)
		q = p->leftChild;
	else
		q = p->rightChild;

	if(parent == NULL)
		t = parent;
	else
	{
		if(parent->leftChild == p)
		{
			parent->leftChild = q;
			f = 0; // L
		}
		else
		{
			parent->rightChild = q;
			f = 1; //R
		}

		int link_flag = 0;  //-1 leftChild
		                    //1  rightChild
		                    //0  no link
		while(!IsEmpty(&st))
		{
			parent = GetTop(&st);
			Pop(&st);
			if(parent->rightChild==q && f==1)
				parent->bf--;
			else
				parent->bf++;

			if(!IsEmpty(&st))
			{
				ppr = GetTop(&st);
				link_flag = (ppr->leftChild==parent)?-1 : 1;
			}
			else
			{
				link_flag = 0; //
			}

			if(parent->bf==-1 || parent->bf==1)
				break;
			if(parent->bf == 0)
				q = parent;
			else   //|2|
			{
				int flag = 0;
				if(parent->bf < 0)
				{
					flag = -1;
					q = parent->leftChild;
				}
				else
				{
					flag = 1;
					q = parent->rightChild;
				}
				if(q->bf == 0) //单旋转
				{
					if(flag == -1) //右单旋转
					{
						RotateR(parent);
						parent->bf = 1;
						parent->rightChild->bf = -1;
					}
					else
					{
						RotateL(parent);
						parent->bf = -1;
						parent->leftChild->bf = 1;
					}
					break;
				}
				if(q->bf == flag)
				{
					if(flag == -1) //右单旋转
						RotateR(parent);
					else
						RotateL(parent);
				}
				else
				{
					if(flag == -1)
						RotateLR(parent);
					else
						RotateRL(parent);
				}
				if(link_flag == 1)
					ppr->rightChild = parent;
				else if(link_flag == -1)
					ppr->leftChild = parent;

			}
		}

		if(IsEmpty(&st))
			t = parent;
	}

	free(p);
	return TRUE;
}

void RotateR(AVLNode *&ptr)
{
	AVLNode *subR = ptr;
	ptr = subR->leftChild;
	subR->leftChild = ptr->rightChild;
	ptr->rightChild = subR;
	ptr->bf = subR->bf = 0;
}
void RotateL(AVLNode *&ptr)
{
	AVLNode *subL = ptr;
	ptr = subL->rightChild;
	subL->rightChild = ptr->leftChild;
	ptr->leftChild = subL;
	ptr->bf = subL->bf = 0;
}

void RotateLR(AVLNode *&ptr)
{
	AVLNode *subR = ptr;
	AVLNode *subL = subR->leftChild;
	ptr = subL->rightChild;

	subL->rightChild = ptr->leftChild;
	ptr->leftChild = subL;
	if(ptr->bf <= 0)
		subL->bf = 0;
	else
		subL->bf = -1;

	subR->leftChild = ptr->rightChild;
	ptr->rightChild = subR;
	if(ptr->bf == -1)
		subR->bf = 1;
	else
		subR->bf = 0;
	ptr->bf = 0;
}
void RotateRL(AVLNode *&ptr)
{
	AVLNode *subL = ptr;
	AVLNode *subR = subL->rightChild;
	ptr = subR->leftChild;

	subR->leftChild = ptr->rightChild;
	ptr->rightChild = subR;
	if(ptr->bf >= 0)
		subR->bf = 0;
	else
		subR->bf = 1;

	subL->rightChild = ptr->leftChild;
	ptr->leftChild = subL;
	if(ptr->bf == 1)
		subL->bf = -1;
	else
		subL->bf = 0;
	ptr->bf = 0;
}