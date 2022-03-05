namespace DIKUdebate {
    class DIKUperson {
        // I chose to make all the set modifiers private
        // and keep all the get modifiers public.
        // I did this because it made the most sense in my eyes,
        // since in real life, the logic is often the same;
        // You can see somethng that others own, but not do anything
        // to it.
        public string Name {get; private set;}
        public int MaxIntellect {get; private set;}
        public int Intellect {get; private set;}
        public int StrengthOfArgument {get; private set;}
        public int Semester {get; private set;}
        public int CounterArgument {get; private set;}
        public int CriticalArgument {get; private set;}
        public DIKUPreparation Preparation {get; private set;}
        Random rand = new Random();

        public DIKUperson(string name, DIKUPreparation prep) {
            this.Name = name;
            this.Preparation = prep;
            this.Semester = 1;
            this.MaxIntellect = 30;
            this.Intellect = 30;
            this.StrengthOfArgument = 3;
            this.CounterArgument = 10;
            this.CriticalArgument = 10;
        }

        public override string ToString()
        {
            return String.Format("Name: " + this.Name +
                "\nPreparation: " + this.Preparation +
                "\nSemester: " + this.Semester +
                "\nMax Intellect: " + this.MaxIntellect +
                "\nIntellect: " + this.Intellect +
                "\nStrength Of Argument: " + this.StrengthOfArgument +
                "\nCounter Argument Chance: " + this.CounterArgument + "%" +
                "\nCritical Argument Chance: " + this.CriticalArgument + "%");
        }

        public bool HasLost() {
            if (this.Intellect > 0) {
                return false;
            }
            else {
                return true;
            }
        }

        public bool BeDrained(int amount) {
            if (this.CounterArgument > this.rand.Next(101)) {
                Console.WriteLine("But " + this.Name + " managed to counter the argument!\n");
                return true;
            }
            else {
                this.Intellect -= amount;
                return false;
            }
        }

        public void Argue(DIKUperson opponent) {
            Console.Write(this.Name + " argues their point to " + opponent.Name + " dealing ");
            if (this.CriticalArgument > this.rand.Next(101)) {
                Console.Write(2*this.StrengthOfArgument);
                Console.WriteLine(" of draining!");
                opponent.BeDrained(2*this.StrengthOfArgument);
            }
            else {
                Console.Write(this.StrengthOfArgument);
                Console.WriteLine(" of draining!");
                opponent.BeDrained(this.StrengthOfArgument);
            }
        }

        public void RestoreIntellect() {
            this.Intellect = this.MaxIntellect;
        }

        public void GetExperience() {
            this.Semester++;
            this.StrengthOfArgument += 2;
            
            // Increase MaxIntellect
            if (this.Preparation == DIKUPreparation.ReadingNone) {
                this.MaxIntellect += 20;
            }
            else {
                this.MaxIntellect += 10;
            }
            
            // Increase CounterArgument
            if (this.Preparation != DIKUPreparation.ReadingNone) {
                this.CounterArgument += 6;
            }
            else {
                this.CounterArgument += 3;
            }

            // Increase CriticalArgument
            if (this.Preparation == DIKUPreparation.ReadingAll) {
                this.CriticalArgument += 6;
            }
            else {
                this.CriticalArgument += 3;
            }

            this.Intellect = this.MaxIntellect;
        }


    }
}