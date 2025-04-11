namespace Bank
{
    public class WithdrawException : Exception
    {
        public WithdrawException(string masage) : base(masage) { }
    }
}
