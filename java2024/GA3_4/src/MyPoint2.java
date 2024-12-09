
public class MyPoint2 {
	private static int x=0;//クラス変数
	private static int y=0;//クラス変数
	
	
	//コンストラクタ
	public MyPoint2()
	{
		x=0;
		y=0;
		
		System.out.println("X："+x);
		System.out.println("Y："+y);
		
	}
	
	public static void showSum(int a,int b)//クラスメソッド
	{
		System.out.println("X："+a);
		System.out.println("Y："+b);
	}

}
