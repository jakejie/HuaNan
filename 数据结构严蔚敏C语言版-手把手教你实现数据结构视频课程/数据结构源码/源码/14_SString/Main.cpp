#include"SString.h"

void main()
{
	SString S;
	InitString(S);
	StrAssign(S,"ababcababcabc");

	SString T;
	InitString(T);
	StrAssign(T,"abc");

	SString V;
	InitString(V);
	StrAssign(V,"xy");

	StrReplace(S,T,V);

	PrintString(S); //abxyabxyab

	//int index = StrIndex(S,T,0);
}

/*
void main()
{
	SString S;
	InitString(S);
	SString T;
	InitString(T);

	StrAssign(S,"abc");
	StrAssign(T,"xyz");

	SString Y;
	InitString(Y);
	StrConcat(Y,S,T);
	PrintString(Y);
}
*/