namespace PriceEstimatior.Models
{
    interface ICustomer
    {
        string Name { get; set; }
        string Password { get; set; }
        CustomerType Category { get; set; }
    }

    public enum CustomerType
    {
        Regular = 1,
        Privilege = 2
    }
}
