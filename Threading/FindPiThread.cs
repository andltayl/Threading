using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    class FindPiThread
    {
        int numDarts, goodDarts;
        Random r;

        public FindPiThread(int numDarts)
        {
            this.numDarts = numDarts;
            this.goodDarts = 0;
            this.r = new Random();
        }

        public int GetDarts()
        {
            return goodDarts;
        }

        public void throwDarts()
        {
            for(int i = 0; i < numDarts; i++)
            {
                double x, y;

                x = r.NextDouble();
                y = r.NextDouble();

                if((x*x + y*y) <= 1)            // Determine if the dart landed inside the circle
                {
                    goodDarts++;
                }
            }
        }
    }
    

}
