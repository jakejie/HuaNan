#include"LinkStack.h"

void main()
{
	LinkStack st;
	InitStack(&st);

	for(int i=1; i<=5; ++i)
	{
		Push(&st,i);
	}
	Show(&st);
	Pop(&st);
	Show(&st);
}