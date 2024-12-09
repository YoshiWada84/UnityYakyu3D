import java.util.Scanner;

public class kadai11 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		// TODO 自動生成されたメソッド・スタブ
		MyPoint2 car1=new MyPoint2();
		int number = scanner.nextInt();
		int a=0;
		int b=0;
		a=number;
		Scanner scanner2 = new Scanner(System.in);
		int number2 = scanner2.nextInt();
		b=number2;
		MyPoint2.showSum(a,b);//クラスメソッドの呼び出し
		
	}

}
