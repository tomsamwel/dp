namespace Observer
{
    public class Subject
    {
        private List<Observer> observerCollection = new List<Observer>();
        private int number;

        public int getNumber()
        {
            return number;
        }

        public void setNumber(int number)
        {
            this.number = number;
            updateObservers();
        }

        public void addObserver(Observer observer)
        {
            observerCollection.Add(observer);
        }

        private void updateObservers()
        {
            foreach (Observer observer in observerCollection)
            {
                observer.update();
            }
        }
    }
}
