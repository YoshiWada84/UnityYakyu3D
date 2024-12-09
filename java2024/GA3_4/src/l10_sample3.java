import java.util.Scanner;

public class l10_sample3 {

	public static void main(String[] args) {
		
		// TODO 自動生成されたメソッド・スタブ
		Scanner scanner = new Scanner(System.in);
		Scanner scanner2 = new Scanner(System.in);
		// TODO 自動生成されたメソッド・スタブ
		int number = scanner.nextInt();
		int number2 = scanner2.nextInt();
		
		if(number>number2)
		{
			System.out.println(number+"は"+number2+"より大きいです");	
		}
		else if(number==number2)
		{
			System.out.println(number+"は"+number2+"と同じです");	
		}
		else if(number<number2)
		{
			System.out.println(number+"は"+number2+"より小さいです");	
		}
		//System.out.println(text);
	}
}