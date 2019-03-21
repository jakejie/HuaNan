#include"HString.h"

void InitString(HString *S)
{
	S->ch = NULL;
	S->length = 0;
}

void StrAssign(HString *S, char *str)
{
	int len = strlen(str);
	if(S->ch != NULL)
		free(S->ch);
	S->ch = (char*)malloc(sizeof(char)*len);
	assert(S->ch != NULL);
	for(int i=0; i<len; ++i)
	{
		S->ch[i] = str[i];
	}
	S->length = len;
}

void PrintString(HString *S)
{
	for(int i=0; i<S->length; ++i)
	{
		printf("%c",S->ch[i]);
	}
	printf("\n");
}

int  StrLength(HString *S)
{
	return S->length;
}

void StrCopy(HString *S, HString *T)
{
	int len = StrLength(T);
	if(S->ch != NULL)
		free(S->ch);

	S->ch = (char *)malloc(sizeof(char) * len);
	assert(S->ch != NULL);
	for(int i=0; i<len; ++i)
	{
		S->ch[i] = T->ch[i];
	}
	S->length = len;
}

bool StrEmpty(HString *S)
{
	return S->length==0;
}

int  StrCompare(HString *S, HString *T)
{
	if(S->length==0 && T->length==0)
		return 0;
	int result = 0;
	
	int i=0;
	int j=0;
	while(i<S->length && j<T->length)
	{
		if(S->ch[i] > T->ch[j])
			return 1;
		else if(S->ch[i] < T->ch[j])
			return -1;
		else
		{
			i++;
			j++;
		}
	}

	if(i<S->length)
		result = 1;
	if(j<T->length)
		result = -1;
	return result;
}

void StrConcat(HString *T, HString *s1, HString *s2)
{
	if(T->ch != NULL)
		free(T->ch);
	int len1 = StrLength(s1);
	int len2 = StrLength(s2);

	T->ch = (char *)malloc(sizeof(char)*(len1+len2));
	assert(T->ch != NULL);

	for(int i=0; i<len1; ++i)
	{
		T->ch[i] = s1->ch[i];
	}
	for(int j=0; j<len2; ++j)
	{
		T->ch[i+j] = s2->ch[j];
	}

	T->length = len1 + len2;
}

void SubString(HString *S, HString *sub,int pos, int len)
{
	if(pos<0 ||pos>S->length ||len<0 ||len>S->length-pos)
		return;

	if(sub->ch != NULL)
		free(sub->ch);
	sub->ch = (char*)malloc(sizeof(char) * len);
	assert(sub->ch != NULL);

	int j = pos;
	for(int i=0; i<len; ++i)
	{
		sub->ch[i] = S->ch[j+i];
	}
	sub->length = len;
}

void StrInsert(HString *S, int pos, HString *T)
{
	if(T->length == 0)
		return;
	if(pos<0 || pos>S->length)
		return;

	char *ch = (char*)realloc(S->ch,sizeof(char)*(S->length+T->length));
	assert(ch != NULL);
	S->ch = ch;

	for(int i=S->length-1; i>=pos; --i)
	{
		S->ch[i+T->length] = S->ch[i];
	}

	int j = pos;
	for(i=0; i<T->length; ++i)
	{
		S->ch[j+i] = T->ch[i];
	}
	S->length += T->length;
}

void StrDelete(HString *S, int pos, int len)
{
	if(pos<0 ||pos>S->length)
		return;
	if(len <= 0 || len >S->length)
		return;

	int j = pos;
	for(int i=0; i<len; ++i)
	{
		S->ch[j+i] = S->ch[j+i+len];
	}
	S->length -= len;
}
void StrClear(HString *S)
{
	S->length = 0;
	if(S->ch != NULL)
		free(S->ch);
	S->ch = NULL;
}