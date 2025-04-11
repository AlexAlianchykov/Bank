
namespace Bank
{
    public class DepositException: Exception
    {
        public DepositException(string masage) : base(masage) { }
    }
}
