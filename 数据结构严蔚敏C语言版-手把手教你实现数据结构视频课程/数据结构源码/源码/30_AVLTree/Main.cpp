#include"AVLTree.h"

void main()
{
	//Insert
	//Type ar[] = {13,24,20,37,90,53};
	//Type ar[] = {50,40,60,10,45,70,5,30,20};
	//Type ar[] = {30,20,50,10,40,70,60,80,65};

	//Delete
	//Type ar[] = {50,40,60,10,45,70,5,30}; //R
	//Type ar[] = {30,20,60,10,50,70,40,65,80};  //L
	Type ar[] = {50,30,60,20,40,55,70,10,25,35,45,58,65,80,5,33,38,48,75,32};
	int n = sizeof(ar)/sizeof(Type);

	AVLTree avl;
	InitAVLTree(&avl);

	for(int i=0; i<n; ++i)
	{
		InsertAVL(&avl, ar[i]);
	}

	//Type key = 70;
	Type key = 60;
	RemoveAVL(&avl, key);

}