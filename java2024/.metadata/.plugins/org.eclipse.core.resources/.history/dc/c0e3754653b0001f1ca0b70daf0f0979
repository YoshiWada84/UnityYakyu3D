package Lesson14;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class kadai11_ワダヨシノリ
{

	public static void main(String[] args) 
	{
				
	
	try {
	      File f = new File("kadai11.txt");
	      BufferedWriter bw = new BufferedWriter(new FileWriter(f));
	      Scanner scanner = new Scanner(System.in);
	        // 入力処理を行う
	      String scan=scanner.nextLine();
	      
	      bw.write(scan);
	      
	      bw.newLine();
	      System.out.println(scan);
	      //scanner.close();
	      Scanner scanner2 = new Scanner(System.in);
	        // 入力処理を行う
	      String scan2=scanner2.nextLine();
	      System.out.println(scan2);
	      
	      for(int i=0;i<scan2.length();i++)
	      {
	    	  for(int a=0;a<scan.length();a++)
	    	  {
	    		  if(scan2.equals(scan)) {
	    		  System.out.println("一致"+(i+1)+"文字目");
	    		  }
	    	  }
	    		  
	    	  
	      }
	      bw.close();
	    } catch (IOException e) {
	      System.out.println(e);
	    }
	  }

}


