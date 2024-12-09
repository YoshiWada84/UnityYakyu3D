//車クラス
class L11Car{//スーパークラス
	protected int num;
	private double gas;
	protected int x;//サブクラスからアクセス可能
	
	public L11Car() {
		num=0;
		gas=0.0;
		System.out.println("車を作成しました。");
		
	}
	public L11Car(int n,double g) {
		num=n;
		gas=g;
		System.out.println("ナンバー"+num+"車を作成しました。");
		
	}
	
	public void SetCar(int n,double g) {
		num=n;
		gas=g;
		System.out.println("ナンバーを"+num+"にガソリン量を"+gas+"にしました");
		
	}
	public void show()
	{
		System.out.println("車のナンバーは"+num+"です。");
		System.out.println("ガソリン量は"+gas+"です。");
	}
	

}

//レーシングカークラス
class RacingCar extends L11Car{
	private int course;
	
	public RacingCar()
	{
	course=0;
	System.out.println("レーシングカーを作成しました。");
	}
	public RacingCar(int n,double g,int c)
	{
		super(n,g);//スーパークラスの引数2個のコンストラクタ
	course=c;
	System.out.println("レーシングカーを作成しました。");
	System.out.println("コース番号を"+course+"です。");
	}
	public void setCource(int c)
	{
		course=c;
		System.out.println("コース番号を"+course+"にしました。");
	}
	
	public void show()
	{
		System.out.println("レーシングカーのナンバーは"+num);
		
	}//サブクラスのshow()メソッド
	
	
}

public class l11_sample1 {

	public static void main(String[] args) {
		RacingCar rccar2=new RacingCar(555,20.5,4);
		RacingCar rccar1;
		rccar1=new RacingCar();//サブクラスのオブジェクトを作成
		
		rccar1.SetCar(1234,20.5);
		rccar1.setCource(5);
		
		rccar1.show();
		
	}

}
