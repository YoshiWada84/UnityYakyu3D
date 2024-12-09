
class L9Car 
{
		public static int sum=0;//クラス変数
		
		private int num;
		private double gas;
		
		//コンストラクタ
		public L9Car()
		{
			num=0;
			gas=0.0f;
			System.out.println("車を作成しました。");
			sum++;
		}
		public void show()
		{
			System.out.println("車のナンバーは"+num);
			System.out.println("ガソリン量は"+gas);
		}
		public static void showSum()//クラスメソッド
		{
			System.out.println("車の台数は"+sum+"台です。");
		}

	}


