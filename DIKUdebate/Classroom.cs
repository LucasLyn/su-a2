namespace DIKUdebate {
    class Classroom {
        private int round = 1;
        private DIKUperson winner;
        private DIKUperson loser;

        public DIKUperson Discussion(DIKUperson d1, DIKUperson d2) {
            Console.WriteLine("Let the arguing... Begin!");
                Console.WriteLine("");
            
            while (!d1.HasLost() && !d2.HasLost()) {
                Console.WriteLine("");
                Console.WriteLine("Current round: " + this.round);
                d1.Argue(d2);
                d2.Argue(d1);
                this.round++;
            }

            // If both people are out of intellect at the end of a round,
            // it's assumed that d1 wins, since it attacks first.
            if ((d1.HasLost() && d2.HasLost()) || d2.HasLost()) {
                this.winner = d1;
                this.loser = d2;
            }
            else {
                this.winner = d2;
                this.loser = d1;
            }

            Console.WriteLine(this.winner.Name + " has won in only " + this.round + " rounds!");
            this.winner.GetExperience();
            this.loser.RestoreIntellect();
            return this.winner;
        }
    }
}