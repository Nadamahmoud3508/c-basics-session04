namespace Assignment03S5
{
    internal class Program
    {
         static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book Title: {title}");
        }       
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        static void ApplyDiscount(double[] prices)
        {
            if(prices is null || prices.Length == 0)
            {
                return ;
            }   
            prices[0] = prices[0] - 5;
        }
        static int AddBonusPagesByRef(ref int pages)
        {
            return pages += 50;
        }
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Pages: " + pages);
        }
        static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
        }
        static void Main(string[] args)
        {
            #region q1
            double[] prices = [25.5, 40.0, 33.75];
            Console.WriteLine(prices[1]);
            #endregion

            #region q2
            int[,] shelfCopies =
            {
                { 3, 5 },
                { 1, 4 }

            };
            Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region q3
            PrintWelcomeMessage();
            #endregion

            #region q4
            PrintBookTitle("Clean Code");
            #endregion

            #region q5
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine($"Total Pages: {pages}");
            // The output will be 400 because the AddBonusPages method does not modify the original pages variable since it is passed by value. 
            #endregion

            #region q6
            double[] Prices = { 25.5, 40.0 };
            ApplyDiscount(Prices) ;
            Console.WriteLine(Prices[0]);
            #endregion

            #region q7
            Console.WriteLine(AddBonusPagesByRef(ref pages));
            // The output will be 450 because the AddBonusPagesByRef method modifies the original pages variable since it is passed by reference.   

            #endregion

            #region q8
            double[] pprices = { 25.5, 40.0 };
            ReplaceArray(ref pprices);
            Console.WriteLine(pprices.Length);

            #endregion

            #region q9
            double price;
            bool found = TryGetPrice("Clean Code", out price);
            if (found)
            {
                Console.WriteLine(price);
            }
            else
            {
                Console.WriteLine("Book not found");
            }
            #endregion

            #region q10
            PrintBookInfo("Clean Code");
            PrintBookInfo("C# Basics", 400);
            #endregion

            #region q11
            PrintBookInfo(pages: 500, title: "Java Basics");
            #endregion

            #region q12
            PrintAllTitles("Clean Code", "C# Basics", "Java Programming");
            #endregion
















        }
    }
}
