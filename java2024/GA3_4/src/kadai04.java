//if文
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class kadai04 {

	public static void main(String[] args)throws IOException {
		
		System.out.println("整数を入力");
		
		BufferedReader br=
				new BufferedReader(new InputStreamReader(System.in));
		
		int res=Integer.parseInt(br.readLine());
		if(res == 1)
			System.out.println("もっとがんばりましょう");
		else if(res == 2)
			System.out.println("もうすこしがんばりましょう");
		else if(res == 3)
			System.out.println("さらに上をめざしましょう");
		else if(res == 4)
			System.out.println("たいへんよくできました");
		else if(res == 5)
			System.out.println("優秀です");
		else
			System.out.println("それ以外が入力されました");


	}

}