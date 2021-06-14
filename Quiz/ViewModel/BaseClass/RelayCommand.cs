﻿using System;
using System.Windows.Input;

namespace Quiz.ViewModel.BaseClass
{
    class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged 
        {
            add {
                if (canExecute != null) CommandManager.RequerySuggested += value; 
            }
            remove {
                if (canExecute != null) CommandManager.RequerySuggested -= value;
            }
        }

        private Action<object> execute;
        private Predicate<object> canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
        public RelayCommand(Action<object> execute, Action<object> execute2, Predicate<object> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {

            return canExecute==null ? true: canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }

    }
}
