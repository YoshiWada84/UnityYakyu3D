import java.util.Arrays;
import java.util.Scanner;
public class kadai1021 {

	public static void main(String[] args) {
		// TODO 自動生成されたメソッド・スタブ
		int[] test= {0,0,0};
		
		Scanner score = new Scanner(System.in);
		for(int i=0;i<test.length;i++)
		{
			
			int number = score.nextInt();
			test[i]=number;
			System.out.println((i+1)+"番目の人の点数は"+test[i]);
		}
		score.close();
		Arrays.sort(test);
		System.out.println(Arrays.toString(test));
	}

}
