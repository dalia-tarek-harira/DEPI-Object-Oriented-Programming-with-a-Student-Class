namespace sheetTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student("Dalia Tarek", 21, 100);
            studentOne.DisplayInfo();


            Student studentTwo = new Student("Rania Tarek", 15, 99);
            studentTwo.DisplayInfo();
            
        }
    }
}
