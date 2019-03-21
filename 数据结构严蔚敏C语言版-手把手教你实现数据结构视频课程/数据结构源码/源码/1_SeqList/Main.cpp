#include"SeqList.h"

void main()
{
	SeqList mylist,youlist,list;
	InitSeqList(&mylist);
	InitSeqList(&youlist);

	push_back(&mylist,1);
	push_back(&mylist,3);
	push_back(&mylist,5);
	push_back(&mylist,7);
	push_back(&mylist,9);

	push_back(&youlist,2);
	push_back(&youlist,4);
	//push_back(&youlist,6);
	push_back(&youlist,8);
	//push_back(&youlist,10);

	merge(&list,&mylist,&youlist);
	show_list(&list);
}

/*

void main()
{
	SeqList mylist;
	InitSeqList(&mylist);

	ElemType Item;
	int pos;
	int select = 1;
	while(select)
	{
		printf("**************************************\n");
		printf("* [1]  push_back    [2]  push_fornt  *\n");
		printf("* [3]  show_list    [4]  pop_back    *\n");
		printf("* [5]  pop_front    [6]  insert_pos  *\n");
		printf("* [7]  find         [8]  lenght      *\n");
		printf("* [9]  delete_pos   [10]  delete_val *\n");
		printf("* [11] sort         [12]  resver     *\n");
		printf("* [13] clear        [14*]  destroy   *\n");
		printf("* [0]  quit_system                   *\n");
		printf("**************************************\n");
		printf("请选择:>");
		scanf("%d",&select);
		if(select == 0)
			break;

		switch(select)
		{
		case 1:
			printf("请输入要插入的数据(-1结束):>");
			while(scanf("%d",&Item),Item!=-1)
			{
				push_back(&mylist,Item);
			}
			break;
		case 2:
			printf("请输入要插入的数据(-1结束):>");
			while(scanf("%d",&Item),Item!=-1)
			{
				push_front(&mylist,Item);
			}
			break;
		case 3:
			show_list(&mylist);
			break;
		case 4:
			pop_back(&mylist);
			break;
		case 5:
			pop_front(&mylist);
			break;
		case 6:
			printf("请输入要插入数据:>");
			scanf("%d",&Item);
			printf("请输入要插入的位置:>");
			scanf("%d",&pos);
			insert_pos(&mylist,pos,Item);
			break;
		case 7:
			printf("请输入要查找的数据:>");
			scanf("%d",&Item);
			pos = find(&mylist,Item);
			if(pos == -1)
				printf("查找的数据%d在顺序表中不存在.\n",Item);
			else
				printf("查找的数据%d在顺序表中的%d下标位置.\n",Item,pos);
			break;
		case 8:
			printf("顺序表的长度为:> %d\n",length(&mylist));
			break;
		case 9:
			printf("请输入要删除数据的位置:>");
			scanf("%d",&pos);
			delete_pos(&mylist,pos);
			break;
		case 10:
			printf("请输入要删除的数据:>");
			scanf("%d",&Item);
			delete_val(&mylist,Item);
			break;
		case 11:
			sort(&mylist);
			break;
		case 12:
			resver(&mylist);
			break;
		case 13:
			clear(&mylist);
			break;
		//case 14:
			//destroy(&mylist);
		//	break;
		default:
			printf("输入的选择错误，请重新输入.\n");
			break;
		}
	}
	destroy(&mylist);
}
*/