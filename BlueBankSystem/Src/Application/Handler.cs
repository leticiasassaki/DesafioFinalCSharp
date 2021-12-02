namespace BlueBank.System.Application
{
    public abstract class Handler<TRequest, TResponse>
    {
        public abstract TResponse Handle(TRequest request);
    }
}
