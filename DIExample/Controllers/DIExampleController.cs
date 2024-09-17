using DIExample.Service;
using Microsoft.AspNetCore.Mvc;

namespace DIExample.Controllers; 
[ApiController]
[Route("[controller]")]
public class DIExampleController(
    TransientService transientService1,
    TransientService transientService2,
    ScopedService scopedService1,
    ScopedService scopedService2,
    SingletonService singletonService1,
    SingletonService singletonService2) : ControllerBase {
    private readonly TransientService _transientService1 = transientService1;
    private readonly TransientService _transientService2 = transientService2;
    private readonly ScopedService _scopedService1 = scopedService1;
    private readonly ScopedService _scopedService2 = scopedService2;
    private readonly SingletonService _singletonService1 = singletonService1;
    private readonly SingletonService _singletonService2 = singletonService2;

    [HttpGet]
    public IActionResult Get() {
        return Ok(new {
            Transient1 = _transientService1.OperationId,
            Transient2 = _transientService2.OperationId,
            Scoped1 = _scopedService1.OperationId,
            Scoped2 = _scopedService2.OperationId,
            Singleton1 = _singletonService1.OperationId,
            Singleton2 = _singletonService2.OperationId,
        });
    }
}
