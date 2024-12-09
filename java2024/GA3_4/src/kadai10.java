class MyPoint{
	int x;
	int y;
	void setNum(int num,int num2) {
		
		x=num;
		y=num2;
		System.out.println("numを変更しました");
		
		
	}
}
public class kadai10 {

	public static void main(String[] args) {
		
		
		MyPoint P1;
		P1=new MyPoint();//Carオブジェクトを作成
		
		P1.setNum(5,2);
		
		System.out.println("x："+P1.x);
		System.out.println("y："+P1.y);
	}
	
}
