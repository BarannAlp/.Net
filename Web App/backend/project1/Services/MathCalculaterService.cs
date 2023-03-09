namespace project1.Services
{
    public class MathCalculaterService : IMathCalculaterService
    {
        public int FctMethod(int b)
        {

            if (b == 1)
            {
                return 1;
            }
            return b * FctMethod(b - 1);

        }

        public double SqrtMethod(int sayi)
        {
            return Math.Sqrt(sayi);


        }
    }
}
