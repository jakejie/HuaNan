#include"SeqStack.h"

void main()
{
	SeqStack st;
	InitStack(&st);

	ElemType v;
	for(int i=1; i<=10; ++i)
	{
		Push(&st,i);
	}
	Show(&st);
	Clear(&st);
	Show(&st);

	Destroy(&st);
}