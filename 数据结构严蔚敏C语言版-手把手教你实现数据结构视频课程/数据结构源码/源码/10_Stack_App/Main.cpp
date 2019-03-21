#include"SeqStack.h"

void LineEdit()
{
	SeqStack st;
	InitStack(&st);

	char ch = getchar();
	while(ch != '$')
	{
		while(ch!='$' && ch!='\n')
		{
			switch(ch)
			{
			case '#':
				Pop(&st);
				break;
			case '@':
				Clear(&st);
				break;
			default:
				Push(&st,ch);
				break;
			}

			ch = getchar();
		}
		Print(&st);
		ch = getchar();
	}
	Destroy(&st);
}

void main()
{
	LineEdit();
}

/*
bool Cheak(char *str)
{
	SeqStack st;
	InitStack(&st);

	char v;
	while(*str != '\0')
	{
		if(*str == '[' || *str == '(')
		{
			Push(&st,*str);
		}
		else if(*str == ']')
		{
			GetTop(&st,&v);
			if(v != '[')
				return false;
			Pop(&st);
		}
		else if(*str == ')')
		{
			GetTop(&st,&v);
			if(v != '(')
				return false;
			Pop(&st);
		}
		++str;
	}
	return IsEmpty(&st);
}

void main()
{
	char *str = "[([(])[])]";
	bool flag = Cheak(str);
	if(flag)
	{
		printf("OK!\n");
	}
	else
	{
		printf("Error!\n");
	}
}

/*
void Convert_8(int value)
{
	SeqStack st;
	InitStack(&st);
	int v;

	while(value)
	{
		Push(&st,value%8);
		value /= 8;
	}
	//Show(&st);
	while(!IsEmpty(&st))
	{
		GetTop(&st,&v);
		Pop(&st);
		printf("%d",v);
	}
	printf("\n");
}

void main()
{
	int value = 47183;
	Convert_8(value); // --> 8
}
*/