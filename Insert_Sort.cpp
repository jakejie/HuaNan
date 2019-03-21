#include <stdio.h>
#include <stdlib.h>

void Insert_Sort(int *arr,int len)
{
	int i,j;
	for(i=1;i<len;i++)
		if(arr[i]<arr[i-1])	//后一个数小于前一个数 
		{	
			//向前逐个比较，直到需要插入的地方 
			int key=arr[i];		//要插入的元素 
			for(j=i-1;j>=0&&arr[j]>key;j--)
				arr[j+1]=arr[j];	//交换元素 
			arr[j+1]=key; 	
		} 	
 } 
 
 int main()
{
	int num;
	printf("请输入要排序的元素个数：",num);
	scanf("%d",&num);
	printf("请输入要排序的元素：");
	int *arr=(int*)malloc(num*(sizeof(int)));
	int i;
	for(i=0;i<num;i++)
		scanf("%d",arr+i);
	Insert_Sort(arr,num);
	printf("直接插入排序后的顺序为：");
	for(i=0;i<num;i++)
		printf("%d ",arr[i]); 
	free(arr);
	arr=0;	
	return 0;
}
