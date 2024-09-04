namespace ChainofResponsibility
{
    public interface IHandler
    {
        void SetNextHandler(IHandler nextHandler);
        void Process(Request request);
    }
}
