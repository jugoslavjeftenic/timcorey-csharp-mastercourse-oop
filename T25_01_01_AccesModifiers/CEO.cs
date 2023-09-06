using T25_01_01_AccesModifiersLibrary;

namespace T25_01_01_AccesModifiers
{
    public class CEO : Manager
    {
        public void GetConnectionInfo()
        {
            ModifiedDataAcces data = new ModifiedDataAcces();
            data.GetUnsecuredConnectionInfo();
        }
    }
}