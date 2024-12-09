import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
public class kadai7 {

	public static void main(String[] args) throws IOException{
		BufferedReader br=
				new BufferedReader(new InputStreamReader(System.in));
		
		int suuji=0;
		
		while(true) {
			int res=Integer.parseInt(br.readLine());
				suuji+=res;
				if(res<=0)
				{
					break;
				}
		}
			
		
		
		
		System.out.println(suuji);
		
	}

}
