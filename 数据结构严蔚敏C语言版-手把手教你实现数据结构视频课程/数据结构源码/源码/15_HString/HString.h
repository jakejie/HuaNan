#ifndef __HSTRING_H__
#define __HSTRING_H__

#include<stdio.h>
#include<malloc.h>
#include<assert.h>
#include<string.h>

typedef struct HString
{
	char *ch;
	int   length;
}HString;

void InitString(HString *S);
void PrintString(HString *S);

void StrAssign(HString *S, char *str);
void StrCopy(HString *S, HString *T);
bool StrEmpty(HString *S);
int  StrCompare(HString *S, HString *T);
int  StrLength(HString *S);
void StrConcat(HString *T, HString *s1, HString *s2);
void SubString(HString *S, HString *sub,int pos, int len);
void StrInsert(HString *S, int pos, HString *T);
void StrDelete(HString *S, int pos, int len);
void StrClear(HString *S);
/////////////////////////////////////////////////////////
void StrIndex(HString *S, HString *T, int pos);
void StrReplace(HString *S, HString *T, HString *V);

#endif //__HSTRING_H__