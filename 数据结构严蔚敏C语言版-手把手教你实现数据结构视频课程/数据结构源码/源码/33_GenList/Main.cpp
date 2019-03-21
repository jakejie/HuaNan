#include"GenList.h"

void main()
{
	GenList gl;
	InitGenList(gl);
	
	char *ga = "(1,2,3)";
	char *gb = "(1,(2,3))";
	char *gc = "(1,(2,3),4)";
	char *gd = "((1,2),3)";
	char *ge = "((1,2,3))";
	char *gf = "()";
	char *gg = "(1,(2,(3,(10,20),4),5),6)";

	CreateGenList(gl, gg);
	ShowGenList(gl);
	printf("\n");
	int length = GenListLength(gl);
	printf("length = %d\n",length);

	int depth = GenListDepth(gl);
	printf("depth = %d\n",depth);

}