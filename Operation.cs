namespace APIDependencyInjectionLifetimes
{
    public interface IOperation
    {
        Guid OperationId { get; }
    }

    public interface IOperationTransient : IOperation { }

    public interface IOperationScoped : IOperation { }

    public interface IOperationSingleton : IOperation { }

    public interface IOperationSingletonInstance : IOperation { }

    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton, IOperationSingletonInstance
    {
        Guid _guid;
        public Operation() : this(Guid.NewGuid()) { }

        public Operation(Guid guid)
        {
            _guid = guid;
        }

        public Guid OperationId => _guid;
    }
}
