import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class l5_sample6 {

	public static void main(String[] args)throws IOException {
		
		System.out.println("aかbを入力");
		
		BufferedReader br=
				new BufferedReader(new InputStreamReader(System.in));
		String str=br.readLine();
		char res=str.charAt(0);//入力した文字列から文字を取り出す
		
		switch(res)
		{
		case'a':
			System.out.println("aが入力されました。");
			break;
		case'b':
			System.out.println("bが入力されました。");
			break;
		default:
			System.out.println("aかbを入力してください。");
			break;
		}

	}

}
