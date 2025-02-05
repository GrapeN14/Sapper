﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sapper
{
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> execute;
        private readonly Predicate<T> canExecute;

        public RelayCommand(Action<T> execute) : this(execute,null)
        {   
        }

        public RelayCommand(Action<T> execute, Predicate<T> canExecute)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value;}
            remove {  CommandManager.RequerySuggested -= value;}
        }

        public bool CanExecute(object parameter) 
        {
            return canExecute?.Invoke((T)parameter) ?? false;
        }

        public void Execute(object parameter) 
        {
            execute((T)parameter);
        }
    }
}
