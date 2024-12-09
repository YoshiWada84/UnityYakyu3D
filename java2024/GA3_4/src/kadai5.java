import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
public class kadai5 {

	public static void main(String[] args) throws IOException{
		BufferedReader br=
				new BufferedReader(new InputStreamReader(System.in));
		
		int res=Integer.parseInt(br.readLine());
		int suuji=0;
		for(int i=0;i<=res;i++)
		{
			suuji+=res-i;
		}
		
		
		System.out.println(suuji);
		
	}

}
