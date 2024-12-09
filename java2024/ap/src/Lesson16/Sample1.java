//Javaアプレット
package Lesson16;
//簡単なアプレット
import java.applet.Applet;
import java.awt.Graphics;
public class Sample1 extends Applet {

	@Override
	public void paint(Graphics g)
	{
		g.drawString("サンプル sample",10,10);
		
	}
}
