
namespace WebSupplier.WebApp.Models.Supplier
{
    public class PhoneViewModel
    {
        public string Ddd { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(Ddd) && !string.IsNullOrEmpty(Number))
                return Ddd + Number;
            else
                return string.Empty;
        }
    }
}
