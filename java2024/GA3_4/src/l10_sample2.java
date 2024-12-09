import java.util.Scanner;

public class l10_sample2 {

	public static void main(String[] args) {
		// TODO 自動生成されたメソッド・スタブ
		Scanner scanner = new Scanner(System.in);
		String text = scanner.next();
		Scanner scanner2 = new Scanner(System.in);
		// TODO 自動生成されたメソッド・スタブ
		int number = scanner2.nextInt();
		number-=1;
		int len= text.length();
		
		
		for(int num=0;num<len+1;num++)
		{
			if(number<num)
			{
				
				System.out.print(text.charAt(num-1));
				
			}
			else if(number==num)
			{
				System.out.print("a");
				
			}
			else
			{
				System.out.print(text.charAt(num));
			}
		}
		System.out.print("になりました");
		//System.out.println(text);
	}

}
