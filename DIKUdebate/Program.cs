namespace DIKUdebate {
    class Program {
        public static void Main(string[] args) {
            DIKUperson Lucas = new DIKUperson("Lucas", DIKUPreparation.ReadingNone);
            DIKUperson Marcus = new DIKUperson("Marcus", DIKUPreparation.ReadingAll);
            Classroom Aud1 = new Classroom();

            Console.WriteLine("Today's contestants are:");
            Console.WriteLine(Lucas);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("And:");
            Console.WriteLine("");
            Console.WriteLine(Marcus);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("\n \nAnd the winners new stats are:\n" +
                Aud1.Discussion(Lucas, Marcus));
        }
    }
}