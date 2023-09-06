using T25_01_01_AccesModifiersLibrary;

namespace T25_01_01_AccesModifiers
{
    public class ModifiedDataAcces : DataAcces
    {
        public void GetUnsecuredConnectionInfo()
        {
            GetConnectionString();
        }
    }
}