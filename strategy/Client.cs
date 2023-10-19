namespace Strategy {
    class Client {
        private IPricing _pricingStrategy;
        private double _totalMoneySpent = 0;
        public double TotalMoneySpent { get => _totalMoneySpent; }

        public void SetPricingStrategy(IPricing pricingStrategy) {
            _pricingStrategy = pricingStrategy;
        }

        // One remark on this function: This will throw an exception 
        // when it encounters an null in PricingStrategy. 
        public void UsePower(double hours) {
            _totalMoneySpent += _pricingStrategy.GetPrice(hours);
        }
    }
}
