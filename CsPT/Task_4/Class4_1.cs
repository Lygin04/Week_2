namespace CsPT.Task_4
{
    internal class Class4_1
    {
        public void Human(string name)
        {
            Console.WriteLine("Чел");
        }
        public void Human(int year)
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(year + 9999));
        }
    }
}
