#include"HString.h"

void main()
{
	HString S;
	InitString(&S);
	StrAssign(&S,"abcdefghij");

	StrDelete(&S,2,3);

	PrintString(&S); //cde
}