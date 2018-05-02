using System.ComponentModel;

namespace World_War_Aviation
{
    class Aviation : INotifyPropertyChanged
    {
        private string image;
        private string name;
        private string description;
        private string type;
        private string produced;
        private string totalUnits;
        private string averagePower;
        private string averageSpeed;
        private string limitHeight;

        public string Image
        {
            get { return this.image; }
            set
            {
                this.image = value;
                this.OnPropertyChanged(nameof(Image));
            }
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                this.OnPropertyChanged(nameof(Name));
            }
        }
        public string Description
        {
            get { return this.description; }
            set
            {
                this.description = value;
                this.OnPropertyChanged(nameof(Description));
            }
        }
        public string Type
        {
            get { return this.type; }
            set
            {
                this.type = value;
                this.OnPropertyChanged(nameof(Type));
            }
        }
        public string Produced
        {
            get { return this.produced; }
            set
            {
                this.produced = value;
                this.OnPropertyChanged(nameof(Produced));
            }
        }
        public string TotalUnits
        {
            get { return this.totalUnits; }
            set
            {
                this.totalUnits = value;
                this.OnPropertyChanged(nameof(TotalUnits));
            }
        }
        public string AveragePower
        {
            get { return this.averagePower; }
            set
            {
                this.averagePower = value;
                this.OnPropertyChanged(nameof(AveragePower));
            }
        }
        public string AverageSpeed
        {
            get { return this.averageSpeed; }
            set
            {
                this.averageSpeed = value;
                this.OnPropertyChanged(nameof(AverageSpeed));
            }
        }
        public string LimitHeight
        {
            get { return this.limitHeight; }
            set
            {
                this.limitHeight = value;
                this.OnPropertyChanged(nameof(LimitHeight));
            }
        }


        protected virtual void OnPropertyChanged(string propertyName)
        { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }
        // событие приводит представление к отображению последней версии данных
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
