namespace Git_Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count_start = 1;
            int count_end = 100;
            int sleep_time_ms = 500;

            FizzBuzzCount(count_start, count_end, sleep_time_ms);
        }

        public static void FizzBuzzCount(int count_start, int count_end, int sleep_time_ms)
        {
            for (int count = count_start; count < count_end; count++)
            {
                string fizzbuzz_out = "";
                if ((count % 3 == 0) && (count % 5 == 0))
                {
                    fizzbuzz_out = "\x1b[35mFizzbuzz\x1b[39m";
                } else if ((count % 3 == 0))
                {
                    fizzbuzz_out = "Fizz";
                } else if ((count % 5 == 0))
                {
                    fizzbuzz_out = "\x1b[34mBuzz\x1b[39m";
                }
                Console.WriteLine($"{count}! {fizzbuzz_out}");
                Thread.Sleep(sleep_time_ms);
                count++;
            }
        }
    }
}
