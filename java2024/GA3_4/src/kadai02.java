//キーボードから入力
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class kadai02 {

	public static void main(String[] args)throws IOException{
		BufferedReader br =
	new BufferedReader(new InputStreamReader(System.in));
		
		System.out.println("テスト入力");
		
		
		//System.out.println(str);
		
		System.out.println("円の長さを入力");
		int num;
		String str= br.readLine();
		num=Integer.parseInt(str);//int型に変換
		double num2;
		num2=num*num*Math.PI;
		System.out.println(num2);
		} 

}