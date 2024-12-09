package Lesson15;

public class Sample1 {

	public static void main(String[] args) {
		// TODO 自動生成されたメソッド・スタブ
		Car car1=new Car("1号車");
		car1.start();//新しいスレッドを起動
		
		Car car2=new Car("2号車");
		car2.start();//新しいスレッドを起動
		
		for(int i=0;i<5;i++)
		{
			System.out.println("main()の処理をしています。");
		}

	}

}

//まとめ
/*
*
*スレッドは複数起動することができる。
*スレッドを起動するにはThreadクラスを継承しstart()メソッドを呼び出す
*スレッドの最初の処理として、run()メソッドが呼び出される。
*スレッドを一時停止するには、sleep()メソッドを呼び出す
*スレッドの終了を待つ場合、join()を呼び出す。
*複数のスレッドが共有するフィールドなどの処理をするときは、メソッドに
*synchronizedを指定する。
*
*/