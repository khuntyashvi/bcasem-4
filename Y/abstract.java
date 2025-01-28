abstract class superclass
{
	abstract void Abstractmethod();
}
class ALLM
{
	public static void main(String[] args)
	{
		ALLM staticvari=new ALLM();
		staticvari.nonstatic();
		ALLM.Mstatic();
	}
	void nonstatic()
	{
		System.out.println("Hii I am non static method");
	}
	static void Mstatic()
	{
		System.out.println("Hii I am static method");
	}
}
	