package com.stone;

import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.LinkedList;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerConfigurationException;
import javax.xml.transform.TransformerException;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.xml.sax.SAXException;

import com.stone.tool.Grade;

public class ExamFive {
	private static LinkedList<Grade> grades;
	
	//读入文件
	public ExamFive()throws IOException, ParserConfigurationException, SAXException
	{
		grades=new LinkedList<Grade>();
		char[] b=new char[1024];
		FileInputStream fileInputStream=new FileInputStream("src/grades.txt");
		InputStreamReader file=new InputStreamReader(fileInputStream);
		file.read(b);
		//System.out.println(b);
		String [] arraystr=String.valueOf(b).split(" ");
		int num=0;
		while(arraystr.length>num+3)
		{
			Grade grade=new Grade(arraystr[num+0],arraystr[num+1],arraystr[num+2],Integer.parseInt(arraystr[num+3]));
			add(grade);
			num+=4;
		}
		file.close();
	}
	public void printString()
	{
		//文件输出炒作
		for(Grade grade:grades)
		{
			System.out.println(grade.getId()+" "+grade.getName()+" "+grade.getCourse()+" "+grade.getScore());
		}
	}
	
	private static Document getDocument()throws ParserConfigurationException,SAXException,IOException
	{
		DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();//得到创建 DOM 解析器的工厂。  
        DocumentBuilder builder = factory.newDocumentBuilder();//得到 DOM 解析器对象。  
        Document document = builder.newDocument();
		return document;
	}
	
	public void Xmlprint()throws IOException, ParserConfigurationException, SAXException, TransformerException
	{
		//创建 xml文党
		Document document=getDocument();
		Element Eroot=document.createElement("grades");
		for(Grade grade:grades)
		{
			Element Emem=document.createElement("grade");
			
			Element EmemId=document.createElement("id");
			EmemId.setTextContent(grade.getId());
			Element EmemName=document.createElement("name");
			EmemName.setTextContent(grade.getName());
			Element EmemCourse=document.createElement("course");
			EmemCourse.setTextContent(grade.getCourse());
			Element EmemScore=document.createElement("score");
			EmemScore.setTextContent(Integer.toString(grade.getScore()));
			
			Emem.appendChild(EmemId);
			Emem.appendChild(EmemName);
			Emem.appendChild(EmemCourse);
			Emem.appendChild(EmemScore);
			
			Eroot.appendChild(Emem);
		}
		document.appendChild(Eroot);
		document.setXmlVersion("1.0");
		
		TransformerFactory  factory=TransformerFactory.newInstance();
		Transformer transformer=factory.newTransformer();
		transformer.transform(new DOMSource(document),new StreamResult("src/grades.xml"));
	}
	
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
			while(i<grades.size()&&grades.get(i).getScore()>grade.getScore())
			{
				i++;
			}
			grades.add(i, grade);
		}
		
	}
	public static void main(String []argv)
	{
		try {
			ExamFive examFive=new ExamFive();
			examFive.printString();
			examFive.Xmlprint();
		} catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}
		
	}
}
