using Microsoft.AspNetCore.Mvc;

namespace APIDependencyInjectionLifetimes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DILifetimeController : ControllerBase
    {
        private readonly ILogger<DILifetimeController> _logger;
        private readonly IOperationTransient _operationTransient;
        private readonly IOperationScoped _operationScoped;
        private readonly IOperationSingleton _operationSingleton;
        private readonly IOperationService _operationService;

        public DILifetimeController(ILogger<DILifetimeController> logger, IOperationService operationService, IOperationTransient operationTransient, IOperationScoped operationScoped, IOperationSingleton operationSingleton)
        {
            _logger = logger;
            _operationTransient = operationTransient;
            _operationScoped = operationScoped;
            _operationSingleton = operationSingleton;
            _operationService = operationService;
        }

        [HttpGet(Name = "GetDILifetime")]
        public IActionResult Get()
        {
            return Ok(new
            {
                Transient_ControllerOperationId = _operationTransient.OperationId,
                Transient_ServiceOperationId = _operationService.TransientOperation.OperationId,
                Scope_ControllerOperationId = _operationScoped.OperationId,
                Scope_ServiceOperationId = _operationService.ScopedOperation.OperationId,
                Singleton_ControllerOperationId = _operationSingleton.OperationId,
                Singleton_ServiceOperationId = _operationService.SingletonOperation.OperationId
            });
        }
    }
}
