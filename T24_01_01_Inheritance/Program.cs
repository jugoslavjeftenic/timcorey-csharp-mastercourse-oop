namespace T24_01_01_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Corolla corolla = new();
            corolla.StartCar();

            SmartPhone smartPhone = new();
            smartPhone.ConnectToInternet();

            LandLine landLine = new();
            landLine.PlaceCall();

            Phone phone = new SmartPhone();
            phone.PlaceCall();

            List<Phone> phones = new List<Phone>();
            phones.Add(new Cellphone());
            phones.Add(new SmartPhone());
            phones.Add(new LandLine());

            foreach (var item in phones)
            {
                if (item is Cellphone cell)
                {
                    cell.Carrier = "";
                }

                if (item is SmartPhone smart)
                {
                    smart.ConnectToInternet();
                }
            }
        }
    }
}