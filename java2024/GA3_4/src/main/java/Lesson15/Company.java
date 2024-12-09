package Lesson15;

public class Company {
	private int sum=0;
	public synchronized void add(int a)
	{
		int tmp=sum;
		System.out.println("現金、合計金額"+tmp);
		System.out.println(a+"稼ぎました");
		tmp+=a;
		System.out.println("合計は"+tmp+"になりました。");
		sum=tmp;
		
		
	}
}
