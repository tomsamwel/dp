namespace Strategy {
    interface IPricing {
        double GetPrice(double hours);
    }

    class DayPricing : IPricing {
        public double GetPrice(double hours) {
            return hours * 0.3d;
        }
    }

    class NightPricing : IPricing {
        public double GetPrice(double hours) {
            return hours * 0.2d;
        }
    }
}
