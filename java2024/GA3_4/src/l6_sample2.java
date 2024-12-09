
public class l6_sample2 {

	public static void main(String[] args) {
		for(int i=0;i<=5;i++)
		{
			if(i==3)continue;//処理を飛ばす
			System.out.println(i);
		}
		int i=0;
		
		while(i<=5)//条件がtrueの間繰り返す
		{
			i++;
			System.out.println(i);
			
		}
		do {
			i++;
			System.out.println(i);
		}while(i<=5);
	}

}
