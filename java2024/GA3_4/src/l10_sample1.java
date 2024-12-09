import java.util.Scanner;

public class l10_sample1 {

	public static void main(String[] args) {
		// TODO 自動生成されたメソッド・スタブ
		//String str="Hello";
		/*
		 * String str=new String("Hello");
		 */
		//char ch =str.charAt(2);
		Scanner scanner = new Scanner(System.in);
		String text = scanner.next();
		
		
		int len= text.length()-1;
		
		System.out.print("逆順は、");
		// TODO 自動生成されたメソッド・スタブ
		for(;0<len;len--)
		{
			
			System.out.print(text.charAt(len));
		}
		System.out.print(text.charAt(0));
		
	}

}
