package Lesson13;

public class Car {

	
		//メンバ
		private int num;
		private double gas;
		//20241101
		
		public Car()
		{
			num=0;
			gas=0.0f;
			System.out.println("車を作成しました。");
			
		}
		
		public void SetCar(int n,double g) {
				{
					num=n;
					gas=g;
					System.out.println("numとgasを更新しました。");
				}
		}
		
		public void set(int n,double g)
		{
			if(g>0&&g<1000) 
			{
				num=n;
				gas=g;
			}
			else
			{
				
				System.out.println("ガソリン量が不適切");
			}
		}
		void Show() 
		{
			System.out.println("num:"+num+"gas:"+gas);
			
		}
		void setNum(int n) {
			num=n;
			System.out.println("numを変更しました");
			
		}
}

