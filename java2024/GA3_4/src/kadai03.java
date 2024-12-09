import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class kadai03 {

	public static void main(String[] args)throws IOException {
		
		System.out.println("整数を入力");
		
		BufferedReader br=
				new BufferedReader(new InputStreamReader(System.in));
		
		int res=Integer.parseInt(br.readLine());
		if(0<=res&&res<=10)
			System.out.println("正解です");
		
		else
			System.out.println("不正解です");


	}

}