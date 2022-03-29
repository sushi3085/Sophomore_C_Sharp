```c#
using system;

namespace N
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sentenceA = Console.ReadLine();
            string sentenceB = Console.ReadLine();
            int result = Math.Abs(sentenceA.Length - senntenceB.Length);
            
            for(int i=Math.Min(sentenceA.Length, sentenceB.Length); i>=0; i--)
                if(sentenceA[i] != sentenceB[i]) result++;
            Console.WriteLine(reuslt);
        }
    }
}
```

