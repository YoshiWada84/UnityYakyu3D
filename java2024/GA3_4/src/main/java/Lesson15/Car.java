package Lesson15;

public class Car extends Thread {//Threadクラスを継承
	private String name;
	
	public Car(String nm)
	{
		name=nm;
		
	}
	public void run()
	{
		for(int i=0;i<5;i++)
		{
			System.out.println(name+"の処理をしています。");
			
		}
		
	}

}
