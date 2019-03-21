#include <stdio.h>
#include <stdlib.h>

int Partition(int *arr,int low,int high)
{
	int pk=arr[low];	//定义第一个元素为枢轴元素 
	while(low<high)
	{
		while(low<high&&arr[high]>=pk)	//从右往左找比枢轴元素小的元素 
			high--;
		arr[low]=arr[high];		
		while(low<high&&arr[low]<pk)	//从左往右找比枢轴元素大的元素 
			low++;
		arr[high]=arr[low];
	}
	arr[low]=pk;	//一趟排序后枢轴元素的最终位置 
	return low;	//返回枢轴元素下标 
}

void Quick_Sort(int *arr,int low,int high)
{
	if(low<high)
	{
		int pkloc=Partition(arr,low,high);//找枢轴元素的位置 
		Quick_Sort(arr,low,pkloc-1);//枢轴元素左序列排序 
		Quick_Sort(arr,pkloc+1,high);//枢轴元素右序列排序 
	}
 } 
 
 
 int main()
 {
 	int num;
 	printf("请输入排序的元素的个数:");
 	scanf("%d",&num);
 	int i;
 	int *arr=(int*)malloc(num*(sizeof(int)));//分配数组空间
	
 	for(i=0;i<num;i++) 
 		scanf("%d",arr+i);
	
 	printf("快速排序后的顺序：");
 	Quick_Sort(arr,0,num-1);
	
 	for(i=0;i<num;i++)
 		printf("%d ",arr[i]);
 	printf("\n");
 	
 	free(arr);
 	arr=0;
 	return 0;
 }
