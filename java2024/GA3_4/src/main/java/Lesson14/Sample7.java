package Lesson14;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
public class Sample7 {

	public static void main(String[] args) {
		// TODO 自動生成されたメソッド・スタブ
		try {
			PrintWriter pw =new PrintWriter(
					new BufferedWriter(new FileWriter("test1.txt")));
					
			pw.println("Hello");
			pw.println("Goodbye!");
			System.out.println("ファイルに書き込みました");
			
		}catch(IOException e) {
			
		}
	}

}
