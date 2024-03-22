struct Numbers
{
	private int real1;
	private int real2;
	private int im1;
	private int im2;
	public Numbers(int r1, int i1, int r2, int i2)
	{
		real1 = r1;
		real2 = r2;
		im1 = i1;
		im2 = i2;
	} 
	public void Plus()
	{
		//Console.WriteLine($"");
		int real= real1 + real2;
		int im = im1+im2;
		Console.WriteLine($"сумма = {real}+{im}i");
	}
	public void Minus()
	{
		int real = real1 - real2;
		int im = im1-im2;
		Console.WriteLine($"разность = {real}+{im}i");
	}
	public void Umn()
	{
		int real = real1 * real2 - im1*im2;
		int im = real1*im2+im1*real2;
		Console.WriteLine($"умножение = {real}+{im}i");
	}
	public void Del()
	{
		int real = (real1 * real2 + im1 * im2)/(real2*real2+im2*im2);
		int im = (real2*im1-real1*im2) / (real2 * real2 + im2 * im2);
		Console.WriteLine($"деление = {real}+{im}i");
	}
}
class programm
{
	static void Main()
	{
		Console.WriteLine("введите реальную часть числа1:");
		int real1 = int.Parse(Console.ReadLine());
		Console.WriteLine("введите мнимую часть числа1:");
		int im1 = int.Parse(Console.ReadLine());
		Console.WriteLine();
		Console.WriteLine("введите реальную часть числа2:");
		int real2 = int.Parse(Console.ReadLine());
		Console.WriteLine("введите мнимую часть числа2:");
		int im2 = int.Parse(Console.ReadLine());
		Console.WriteLine();
		Console.WriteLine($"ваши числа: \t{real1}+{im1}i\t{real2}+{im2}i");
		Numbers[] num = new Numbers[1];
		num[0]=new Numbers(real1, im1, real2, im2);
		for (int i=0; i<1; i++) 
		{
			num[i].Plus();
			num[i].Minus();
			num[i].Del();
			num[i].Umn();
		}
	}
}
