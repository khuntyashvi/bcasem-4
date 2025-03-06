using System;
class swastika
{
	public void fun()
	{
		Console.Write("Enter Size of Row :");
		double num=Convert.ToInt32(Console.ReadLine());
		if(num>4)
		{
			if(num%2==0)
			{
				Console.Write("You Enter Even Number");
				Console.Write("\n{0}-1={1}",num,num-1);
				num--;
				//double m=(num/2)+0.5;
			}
			Console.WriteLine("\nNumber is :{0}",num);
			double m=(num/2)+0.5;
			Console.WriteLine(m);
			for(int r=1;r<=num;r++)
			{
				for(int c=1;c<=num;c++)
				{
					if((r==m||c==m)||(r==1&&c>=m)||(c==1&&r<=m)||(r==num&&c<=m)||(c==num&&r>=m))
					{
						Console.Write("* ");
					}
					else
					{
						Console.Write("  ");
					}
				}
				Console.Write("\n");
			}
		}
	}
}
class main_cls
{
	public static void Main()
	{
		swastika obj=new swastika();
		obj.fun();
	}
}
				