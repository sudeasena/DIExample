using DIExample.Service.Abstract;

namespace DIExample.Service;
public class ScopedService : IOperationService {
    public Guid OperationId { get; private set; }
    public ScopedService() {
        OperationId = Guid.NewGuid();
    }
}
