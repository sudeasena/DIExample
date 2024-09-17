using DIExample.Service.Abstract;

namespace DIExample.Service; 
public class SingletonService : IOperationService {
    public Guid OperationId { get; private set; }
    public SingletonService() {
        OperationId = Guid.NewGuid();
    }
}
