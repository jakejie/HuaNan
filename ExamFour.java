package com.stone;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Iterator;
import java.util.LinkedList;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;
import org.xml.sax.SAXException;

import com.stone.tool.Grade;

public class ExamFour {
	//使用链表数组存储数据
	private static LinkedList<Grade> grades;
	public ExamFour()throws IOException, ParserConfigurationException, SAXException
	{
		grades=new LinkedList<Grade>();
		//获取xml文档树形结构
		Document document=getDocument();
		
		//获去文档树结构下grade标签
		NodeList list=document.getElementsByTagName("grade");
		for(int i=0;i<list.getLength();i++)
		{
			Element element=(Element)list.item(i);
			Grade grade=new Grade();
			grade.setId(element.getElementsByTagName("id").item(0).getTextContent());
			grade.setName(element.getElementsByTagName("name").item(0).getTextContent());
			grade.setCourse(element.getElementsByTagName("course").item(0).getTextContent());
			grade.setScore(Integer.valueOf(element.getElementsByTagName("score").item(0).getTextContent()));
			grades.add(grade);
		}
		
	}
	//边添加边排序
	private static void add(Grade grade)
	{
		if(grades.isEmpty())
		{
			grades.add(grade);
		}
		else
		{
			int i=0;
			//比较
			while(i<grades.size()&&grades.get(i).getScore()<grade.getScore())
			{
				i++;
			}
			grades.add(i, grade);
		}
		
	}
	
	//通过工厂模式读入文件
	private static Document getDocument()throws ParserConfigurationException,SAXException,IOException
	{
		DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();//得到创建 DOM 解析器的工厂。  
        DocumentBuilder builder = factory.newDocumentBuilder();//得到 DOM 解析器对象。  
        Document document = builder.parse(new File("src/grades.xml"));
		return document;
	}
	

	public void printString()
	{
		//文件输出炒作
		FileOutputStream fileOutputStream;
		try
		{
			fileOutputStream=new FileOutputStream(new File("src/grades.txt"));	
			Iterator<Grade> iterator=grades.descendingIterator();
			while(iterator.hasNext())
			{
				Grade grade=iterator.next();
				System.out.println(grade.getId()+" "+grade.getName()+" "+grade.getCourse()+" "+grade.getScore());
				fileOutputStream.write(grade.toString().getBytes());
			}
			fileOutputStream.flush();
		}catch(IOException e)
		{
			e.printStackTrace();
		}finally {
			
		}
		
		
	}
	public static void main(String []argv)
	{
		try {
			ExamFour examFour=new ExamFour();
			examFour.printString();
		} catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}
		
	}
}
