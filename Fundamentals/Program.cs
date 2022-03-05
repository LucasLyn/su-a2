namespace DIKUfundamentals {
    class Program {
        public static void Main(string[] args){
            Fundamentals Fund1 = new Fundamentals();
            Fund1.CountBackwards();
            Console.WriteLine(Fund1.ReverseString("This string is reversed!"));
            Fund1.GCD(6, 24);
        }
    }
}