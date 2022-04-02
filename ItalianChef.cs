namespace hwapp
{
    public class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes  paela");
        }
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }
    }
}