namespace Bank
{
    public class BankAccount
    {
        private string _ownerName;
        private decimal _balance;
        private List<string> _transactionHistory;

        public BankAccount(string ownerName)
        {
            _ownerName = ownerName;
            _balance = 0;
            _transactionHistory = new List<string>();
        }

        public string GetBalance()
        {
            _transactionHistory.Add("Проверка баланса");
            return $"{_ownerName}, на вашем балансе: {_balance}";
        }


        public void Deposit(decimal amount)
        {
            _balance = amount;
            _transactionHistory.Add("Пополнение баланса");

            Console.WriteLine($" Баланс пополнен ...\n");
        }

        public void Withdraw(decimal amount)
        {
            try
            {
                if (_balance < amount)
                {
                    throw new WithdrawException("Недостаточно средств");
                }
                _balance -= amount;
                Console.WriteLine($"Выдача наличных ... \n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _transactionHistory.Add("Cнятие денег");
            }

        }

        public void GetTransactionHistory()
        {
            foreach (var history in _transactionHistory)
            {
                Console.WriteLine(history);
            }
            _transactionHistory.Add("Просмотр истории орераций со счётом");
        }
    }
}
