//キーボードから入力
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class kadai01 {

	public static void main(String[] args)throws IOException{
		BufferedReader br =
	new BufferedReader(new InputStreamReader(System.in));
		
		System.out.println("テスト入力");
		//String str= br.readLine();
		
		//System.out.println(str);
		
		System.out.println("年齢を入力");
		int num;
		String str= br.readLine();
		
		//str = br.readLine();
		num=Integer.parseInt(str);//int型に変換
		System.out.println(num+"歳");
		} 

}