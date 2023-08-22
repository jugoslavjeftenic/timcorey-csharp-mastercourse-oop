
namespace T17_01_02_HomeworkPropertyTypes
{
    public class AddressModel
    {
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }

        private string? _fullAddress;

        public string FullAddress
        {
            get
            {
                string output = $"{Street} {City} {State} {Zip}";
                return output;
            }
        }
    }
}
