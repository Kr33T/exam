using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public class userDeposit
    {
        public int all_money;
        public int percent_money;
        public int tax = 0;
        public double percent;
        private double percent_bank = 8.0;

        public userDeposit(int all_money)
        {
            this.all_money = all_money;

            if (all_money < 700000) // расчет процента
            {
                percent = all_money / 50000 + 1;
            }
            else
            {
                int s = all_money - 700000;
                percent = 20 - s / 50000;
            }
            if (percent > percent_bank + 5)
            {
                tax = 30; // налог
            }
        }

        public int GetPercentMoney() // прибавка процента
        {
            var m = (int)Math.Round(percent * all_money / 100);
            return m - (tax * m / 100);
        }

        public void UpdatePercent() // обновление процента
        {
            percent += 0.5;
            if (percent > percent_bank + 5)
            {
                tax = 30;
            }
        }
    }
}
