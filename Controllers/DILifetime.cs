namespace APIDependencyInjectionLifetimes.Controllers
{
    public class DILifetimeResponse
    {
        public Guid TransientId { get; set; }
        public Guid ScopeId { get; set; }
        public Guid SingletonId { get; set; }
    }
}
