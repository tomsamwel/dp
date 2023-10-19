namespace Observer
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void update();

        public Observer(Subject subject)
        {
            this.subject = subject;
            this.subject.addObserver(this);
        }

        public abstract long getNumber();
    }
}
