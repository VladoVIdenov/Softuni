namespace Problem04TextFilter
{
    using System;

    public class TextFilter
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] banWordsArr = input.Trim().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int i = 0; i < banWordsArr.Length; i++)
            {
                string banWord = banWordsArr[i];
                string asterix = new string('*', banWord.Length);
                text = text.Replace(banWord, asterix);
            }

            Console.WriteLine(text);
        }
    }
}
