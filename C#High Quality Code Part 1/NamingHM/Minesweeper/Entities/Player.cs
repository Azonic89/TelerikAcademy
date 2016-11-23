namespace Minesweeper.Entities
{
    using System;

    internal class Player
    {
        private string name;
        private int points;

        public Player()
        {
        }

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Player name cannot be null or empty!!!");
                }

                this.name = value;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Points value cannot be less or equal to zero!!!");
                }

                this.points = value;
            }
        }
    }
}
