namespace Bank
{
    public class InputCheck
    {
        public decimal? Input()
        {
            decimal? amount = null;
            try
            {
                amount = decimal.Parse(Console.ReadLine());

                if (amount < 0 || amount > 1000000)
                {
                    throw new DepositException("Ошибка в зачисляемой сумме");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($" {ex.Message}");
            }
            return amount;
        }
    }
}
