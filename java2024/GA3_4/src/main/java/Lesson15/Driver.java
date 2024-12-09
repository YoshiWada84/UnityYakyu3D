package Lesson15;

public class Driver extends Thread{
	private Company comp;
	
	public Driver(Company c)
	{
		comp=c;
	}
	
	public void run()
	{
		for(int i=0;i<3;i++)
		{
			comp.add(50);
		}
	}

}
