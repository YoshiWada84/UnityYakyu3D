package Lesson15;

public class Sample5 {

	public static void main(String[] args) {
		// TODO 自動生成されたメソッド・スタブ
			Car car1=new Car("1号車");
			car1.start();//新しいスレッドを起動
			
		try{
				car1.join();
		}catch(InterruptedException e){
				
		}
			
			System.out.println("main()の処理をしています。");
		
	}
}
	


