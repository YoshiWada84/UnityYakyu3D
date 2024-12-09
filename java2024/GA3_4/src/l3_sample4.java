//キーボードから入力
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class l3_sample4 {

	public static void main(String[] args)throws IOException{
		BufferedReader br =
	new BufferedReader(new InputStreamReader(System.in));
		
		
		String str= br.readLine();
		
		System.out.println(str);
		
		System.out.println("numを入力");
		int num;
		str = br.readLine();
		num=Integer.parseInt(str);//int型に変換
		
		System.out.println(num);
		} 

}
