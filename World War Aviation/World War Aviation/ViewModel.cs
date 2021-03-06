﻿using System.Collections.Generic;
using System.ComponentModel;

namespace World_War_Aviation
{
    class ViewModel : INotifyPropertyChanged
    {
        // команды
        public Command NextAviation     { get; private set; }
        public Command PreviousAviation { get; private set; }

        private int  currentAviation;
        private bool isAtStart, isAtEnd;
        // лист объектов, модель (данные)
        private List<Aviation> aviations;

        public ViewModel() {
            this.currentAviation = 0;
            this.IsAtStart = true;
            this.IsAtEnd   = false;

            // инициализация команд
            this.NextAviation     = new Command(this.Next, () =>
            { return (this.aviations.Count > 1) && !this.IsAtEnd; });
            this.PreviousAviation = new Command(this.Previous, () =>
            { return (this.aviations.Count > 0) && !this.IsAtStart; });

            // создать данные
            this.aviations = new List<Aviation>
            #region aviations
            {
                new Aviation {                  // #1
                    Image = "Resources/И-16.jpg",
                    Name = "И-16 Поликарпов",
                    Description = "Деревянный низкоплан с небывало коротким фюзеляжем — менее 6 м. Применялся английский двигатель Bristol Jupiter, выпускаемый в СССР как М-22, затем американский Wright R-1820 Cyclone, производившейся по лицензии как М-25, а после доработок получившей марку М-62 и М-63.",
                    Type ="истребитель",
                    Produced ="1934 — 1942",
                    TotalUnits ="более 10 тысяч",
                    AveragePower ="480 — 1100",
                    AverageSpeed ="346 — 470",
                    LimitHeight ="7440 — 9800"
                },
                new Aviation {                  // #2
                    Image = "Resources/МиГ-3.jpg",
                    Name = "МиГ-3",
                    Description = "Низкоплан смешанной конструкции. Фюзеляж в передней части сварной из стальных труб с дюралевой обшивкой, хвостовая часть — деревянный монокок, центроплан — дюралевый. Мотор А. А. Микулина АМ-35А взлётной мощностью 1350 лс. Обладал наивысшей в мире скоростью, достигнутой на серийных самолётах и был по манёвренности лучше других истребителей.",
                    Type ="высотный ночной истребитель",
                    Produced ="1940 — 1941",
                    TotalUnits ="3178",
                    AveragePower ="1350",
                    AverageSpeed ="640",
                    LimitHeight ="11500"
                },
                new Aviation {                  // #3
                    Image = "Resources/Ла-5.jpg",
                    Name = "Ла-5",
                    Description = "Одноместный моноплан цельнодеревянной конструкции из дельта-древесины, фюзеляж которого собирался на клею. Применялся двигатель воздушного охлаждения М-82 и его модификации.",
                    Type ="истребитель",
                    Produced ="1942 — 1944",
                    TotalUnits ="9920",
                    AveragePower ="1700 — 2200",
                    AverageSpeed ="580 — 685",
                    LimitHeight ="9500 — 10800"
                }
            };
            #endregion
        }

        public Aviation Current => (this.aviations.Count > 0) ?
            this.aviations[currentAviation] : null;

        public bool IsAtStart
        {
            get { return this.isAtStart; }
            set
            {
                this.isAtStart = value;
                this.OnPropertyChanged(nameof(IsAtStart));
            }
        }
        public bool IsAtEnd
        {
            get { return this.isAtEnd; }
            set
            {
                this.isAtEnd = value;
                this.OnPropertyChanged(nameof(IsAtEnd));
            }
        }

        private void Next()
        {
            if (this.aviations.Count - 1 > this.currentAviation)
            {
                this.currentAviation++;
                this.OnPropertyChanged(nameof(Current));
                this.IsAtStart = false;
                this.IsAtEnd   = (this.aviations.Count - 1 == this.currentAviation);
            }
        }
        private void Previous()
        {
            if (this.currentAviation > 0)
            {
                this.currentAviation--;
                this.OnPropertyChanged(nameof(Current));
                this.IsAtEnd   = false;
                this.IsAtStart = (this.currentAviation == 0);
            }
        }


        protected virtual void OnPropertyChanged(string propertyName)
        { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }
        // событие приводит представление к отображению последней версии данных
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
