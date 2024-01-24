namespace Portafolio.Services
{
    public class UniqueServices
    {
        public UniqueServices()
        {
            GetGuid = Guid.NewGuid();
        }

        public Guid GetGuid {  get; private set; }
    }

    public class DelimtedServices
    {
        public DelimtedServices()
        {
            GetGuid = Guid.NewGuid();
        }

        public Guid GetGuid { get; private set;}
    }


    public class TransitoryService
    {
        public TransitoryService()
        {
            GetGuid = Guid.NewGuid();
        }

        public Guid GetGuid { get; private set; }
    }

}
