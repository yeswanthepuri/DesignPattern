namespace FlyweightDesignPattern
{
    public interface ICar
    {
        string Color { get; }
        string Engine { get; }
        void SetLocation(decimal lat, decimal lng);
    }
}
