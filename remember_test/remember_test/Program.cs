namespace Bank
{
    class Program
    {
        public static void Main()
        {
            InputCheck inputCheck = new InputCheck();
            Console.WriteLine("Введите ваше имя:");
            BankAccount bankAccount = new BankAccount(Console.ReadLine());

            for (int i = 0; i< 1; ++i)
            {
                Console.WriteLine("Выбирите операцию: \n " +
                "1. Внести деньги \n 2. Снять деньги \n 3. Проверить баланс \n 4. Показать историю операций \n 5. Выйти \n");
                if (int.TryParse(Console.ReadLine(), out int input) && input > 0 && input < 6)
                {
                    try
                    {
                        switch (input)
                        {
                            case 1:
                                Console.WriteLine("Какую сумму вы хотите внести ?");
                                bankAccount.Deposit((decimal)inputCheck.Input());
                                break;
                            case 2:
                                Console.WriteLine("Какую сумму вы хотите снять ?");
                                bankAccount.Withdraw((decimal)inputCheck.Input());
                                break;
                            case 3:
                                Console.WriteLine(bankAccount.GetBalance());
                                break;
                            case 4:
                                Console.WriteLine("История ваших операций:");
                                bankAccount.GetTransactionHistory();
                                break;
                            case 5:
                                i += 2;
                                break;
                        }
                        
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine($"Операция не была завершена из-за ошибки : {ex.Message}");
                    }
                    finally
                    {
                        --i;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Такой операции не существует \n");
                    --i;
                }
            }
            

        }
    }

}