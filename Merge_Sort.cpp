#include <stdio.h>
#include <stdlib.h>

//对两个有序子序列归并排序 
Merge(int *arr,int *brr,int left,int mid,int right)
{
	for(int i=left;i<=right;i++)//将arr复制到brr中 
		brr[i]=arr[i];
	int s1=left;
	int s2=mid+1;
	int k=left;
	while(s1<=mid&&s2<=right)	
	{
		if(brr[s1]<=brr[s2])
			arr[k++]=brr[s1++];
		else
			arr[k++]=brr[s2++];
	}
	while(s1<=mid)//左边尚未归并完 
	{
		arr[k++]=brr[s1++];
	}
	while(s2<=right)//右边尚未归并完 
	{
		arr[k++]=brr[s2++];
	}
	
 } 

void Merge_Sort(int *arr,int *brr,int left,int right)
{
	if(left>=right)
		return ;
	int mid=(left+right)/2;
	Merge_Sort(arr,brr,left,mid);//对左边序列归并排序 
	Merge_Sort(arr,brr,mid+1,right);//对右边序列归并排序 
	Merge(arr,brr,left,mid,right);//对两个有序子序列归并排序 
	
}

int main()
{
	int num;
	printf("请输入要排序的元素的个数：");
	scanf("%d",&num);
	int *arr=(int *)malloc(num*sizeof(int));
	int *brr=(int *)malloc(num*sizeof(int));
	int i;
	for(i=0;i<num;i++)
		scanf("%d",arr+i);
	printf("排序后的顺序为：");
	Merge_Sort(arr,brr,0,num-1);
	for(i=0;i<num;i++)
		printf("%d ",arr[i]);
}
