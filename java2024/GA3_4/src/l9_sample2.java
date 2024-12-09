//メンバへのアクセス制限
public class l9_sample2 {

	public static void main(String[] args) {
		Car car1=new Car();
		
		//privateなのでアクセス不可能
		//car1.num=123;
		//car1.gas=10.0f;
		car1.set(1234,120.0f);
		car1.Show();
		car1.set(1234,-120.0f);
		car1.set(1234,220.0f);
		car1.Show();
	}
	

}
