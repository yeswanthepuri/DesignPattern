using Bridge.BridgeImplementation;

namespace Bridge
{
    public abstract class CarInsurance
    {
        protected CarInsurance(int year, string model, string maker, Discount discount)
        {
            Year = year;
            Model = model;
            Maker = maker;
            _discount = discount;
        }
        public int Year { get; set; }
        public string Model { get; set; }
        public string Maker { get; set; }
        private Discount _discount { get; set; }

        protected abstract decimal GetPremium();
        public decimal CalculatePremium()
        {
            var price = GetPremium();
            var dicountPortion = price * _discount.GetDiscount() / 100;
            return price - dicountPortion;
        }
    }
}
