namespace Tyuiu.AgafonovAO.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numOne, int[] numeTwo) 
        {
            int[] resultArray = new int[5];
            for (var i = 0; i < resultArray.Length; i++) 
            {
                resultArray[i] = numOne[i] + numeTwo[i];
            }
            return resultArray;
        }
    }
}
