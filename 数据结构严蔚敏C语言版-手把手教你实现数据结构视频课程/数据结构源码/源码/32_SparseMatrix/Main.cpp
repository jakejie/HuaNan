#include"SparseMatrix.h"

void main()
{
	SMatrix sm, sm1;
	memset(&sm, 0, sizeof(sm));
	CreateMatrix(&sm);
	PrintMatrix(&sm);

	//TransposeMatrix(&sm, &sm1);
	//CopyMatrix(&sm, &sm1);
	FastTransposeMatrix(&sm, &sm1);
	PrintMatrix(&sm1);
}