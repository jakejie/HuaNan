#include"ThreadBinTree.h"

void main()
{
	char *str = "ABC##DE##F##G#H##";
	BinTree mytree;
	InitBinTree(&mytree,'#');
	CreateBinTree(&mytree,str);

	CreateInThread(&mytree);

	BinTreeNode *p = Search(&mytree,'B');
	BinTreeNode *parent = Parent(&mytree,p);
	//BinTreeNode *q = Prio(&mytree,p);
	//InOrder(&mytree);
}
