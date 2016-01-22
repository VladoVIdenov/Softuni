using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2
{
    public class Ratings
    {
        private string playerName;

        private int points;

        public Ratings()
        {
        }

        public Ratings(string playerName, int points)
        {
            this.PlayerName = playerName;
            this.Points = points;
        }

        public string PlayerName
        {
            get
            {
                return this.playerName;
            }

            set
            {
                this.playerName = value;
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
                this.points = value;
            }
        }
    }
}
