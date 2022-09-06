using System;

namespace exam
{
    public class User
    {
        public int money;
        public int month = 12;

        public User(int money)
        {
            this.money = money;
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            debugAndTrace.onStart();
            readSaveData.onStart("answer.txt");

            int money = 0;

            Console.Write("Пополните счет: ");
            money = Convert.ToInt32(Console.ReadLine()); // пополнение счета

            int startMoney = money;
            User user = new User(money);
            userDeposit deposit = new userDeposit(user.money);
            for (int i = 1; i <= user.month; i++)
            {
                deposit.all_money += deposit.GetPercentMoney(); // прибавка процента
                debugAndTrace.debugAction($"{deposit.all_money}, {deposit.percent}%");
                readSaveData.Save($"{deposit.all_money}, {deposit.percent}%");
                Console.WriteLine($"Баланс: {deposit.all_money}\nВаша процентная ставка: {deposit.percent}%");

                if (i % 3 == 0)
                {
                    deposit.UpdatePercent(); // обновление процента
                }
            }
            debugAndTrace.debugAction($"Доход за год: {deposit.all_money - startMoney}");
            readSaveData.Save($"Доход за год: {deposit.all_money - startMoney}");
            Console.WriteLine($"Доход за год: {deposit.all_money - startMoney}");
            readSaveData.onEnd();
            Console.ReadKey();
        }
    }
}