package Lesson15;

public class Sample7 {

	public static void main(String[] args) {
		// TODO 自動生成されたメソッド・スタブ
		Company cmp=new Company();//会社オブジェクト
		
		Driver drv1=new Driver(cmp);//運転手1
		drv1.start();
		
		Driver drv2=new Driver(cmp);//運転手2
		drv2.start();
		

	}

}
