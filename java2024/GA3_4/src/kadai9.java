import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
public class kadai9 {

	public static void main(String[] args) throws IOException{
		BufferedReader br=
				new BufferedReader(new InputStreamReader(System.in));
		
		int num;
		String str= br.readLine();
		num=Integer.parseInt(str);//int型に変換
		if(1>=num)
		{
			System.out.println("素数ではない");
		}
		for(int i=2;i<num;i++)
		{
			if(num%i==0)
			{
				System.out.println("素数ではない");
				return;
			}
		
		}
		System.out.println("素数");
		
		
	}

}
