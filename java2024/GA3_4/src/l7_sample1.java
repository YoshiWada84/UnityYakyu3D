
public class l7_sample1 {

	public static void main(String[] args) {
		// TODO 自動生成されたメソッド・スタブ
		int[] test;
		test=new int[5];
		
		test[0]=80;
		test[1]=60;
		test[2]=22;
		test[3]=50;
		test[4]=90;
		
		for(int i=0;i<5;i++)
		{
			System.out.println((i+1)+"番目の人の点数は"+test[i]);
		}
		
		//初期化
		int[] test2= {80,60,22,50,90};
		
		//配列変数に代入
		test2=test;
		for(int i=0;i<5;i++)
		{
			System.out.println((i+1)+"番目の人の点数は"+test[i]);
		}
		
		test2[4]=100;
		for(int i=0;i<5;i++)
		{
			System.out.println((i+1)+"番目の人の点数は"+test[i]);
		}
	}

}
