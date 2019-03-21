#include"BinTree.h"

//ABC##DE##F##G#H##

void main()
{
	char *VLR = "ABCDEFGH";
	char *LVR = "CBEDFAGH";
    char *LRV = "CEFDBHGA";

	int n = strlen(VLR);

	BinTree mytree;
	InitBinTree(&mytree,'#');

	CreateBinTree_5(&mytree,VLR,LVR,n);

	BinTree youtree;
	InitBinTree(&youtree,'#');
	CreateBinTree_6(&youtree,LVR,LRV,n);

}

/*
void main()
{
	char *str = "ABC##DE##F##G#H##";
	BinTree mytree;
	InitBinTree(&mytree,'#');

	CreateBinTree_4(&mytree,str);

	PreOrder_1(&mytree);
	printf("\n");
	InOrder_1(&mytree);
	printf("\n");
}

/*
void main()
{
	char *str = "ABC##DE##F##G#H##";
	//char *str = "ABC##D##G#H##";
	BinTree mytree;
	InitBinTree(&mytree,'#');

	CreateBinTree_4(&mytree,str);

	PreOrder(&mytree);
	printf("\n");
	InOrder(&mytree);
	printf("\n");
	PostOrder(&mytree);
	printf("\n");
	LevelOrder(&mytree);
	printf("\n");

	printf("Size = %d\n",Size(&mytree));
	printf("Height = %d\n",Height(&mytree));
	BinTreeNode *p = Search(&mytree,'E');
	BinTreeNode *parent = Parent(&mytree,p);

	BinTree youtree;
	InitBinTree(&youtree,'#');
	Copy(&youtree,&mytree);

	BinTreeClear(&youtree);
}
*/