namespace DIKUfundamentals {
    class Fundamentals {
        public void CountBackwards() {
            for (int i = 10; i > 0; i--) {
                Console.Write(i + ", ");
            }
            Console.WriteLine("Finished!");
        }
        
        public string ReverseString(string str) {
            if (str.Length == 1) {
                return str;
            }
            char firstLetter = str[0];

            return ReverseString(str.Substring(1)) + firstLetter;
        }

        public int GCD(int x, int y) {
            double r = x % y;
            while (r != 0) {
                r = x % y;
                x = y;
                y = Convert.ToInt32(r);
            }
            if (x == 0) {
                Console.WriteLine(y);
                return y;
            }
            else {
                Console.WriteLine(x);
                return x;
            }
        }
    }
}