using System;
using System.Windows.Input;
using Windows.UI.Xaml;

namespace World_War_Aviation
{
    class Command : ICommand
    {
        private Action     methodToExecute          = null;
        private Func<bool> methodToDetectCanExecute = null;
        // таймер инициирует интервальный запуск события CanExecuteChanged
        private DispatcherTimer canExecuteChangedEventTimer = null;

        public Command(Action methodToExecute, Func<bool> methodToDetectCanExecute) {
            // инициализация делегатов
            this.methodToExecute          = methodToExecute;
            this.methodToDetectCanExecute = methodToDetectCanExecute;

            // инициализация/запуск таймера
            this.canExecuteChangedEventTimer          = new DispatcherTimer();
            this.canExecuteChangedEventTimer.Interval = new TimeSpan(0, 0, 1);
            this.canExecuteChangedEventTimer.Tick    += canExecuteChangedEventTimer_Tick;
            this.canExecuteChangedEventTimer.Start();
        }

        public void Execute(object parameter)
        { this.methodToExecute(); }

        public bool CanExecute(object parameter) => (this.methodToDetectCanExecute == null) ?
            true : this.methodToDetectCanExecute();


        private void canExecuteChangedEventTimer_Tick(object sender, object e)
        { this.CanExecuteChanged?.Invoke(this, EventArgs.Empty); }
        // событие уведомит элемент управления об изменении состояния
        public event EventHandler CanExecuteChanged;
    }
}
