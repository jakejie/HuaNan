#include"Tree.h"

void main()
{
	char *str = "RAD#E##B#CFG#H#K#####";
	Tree  tree;
	InitTree(&tree,'#');
	CreateTree(&tree,str);

	//TreeNode *r = Root(&tree);
	TreeNode *p = Find(&tree, 'H');
	TreeNode *parent = Parent(&tree,p);
}