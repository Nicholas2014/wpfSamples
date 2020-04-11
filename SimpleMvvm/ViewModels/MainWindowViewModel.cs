using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using SimpleMvvm.Commands;

namespace SimpleMvvm.ViewModels
{
    public class MainWindowViewModel : NotificationObject
    {
        private double input1;

        public double Input1
        {
            get { return input1; }
            set
            {
                input1 = value;
                this.OnPropertyChanged(nameof(Input1));
            }
        }

        private double input2;

        public double Input2
        {
            get { return input2; }
            set
            {
                input2 = value;
                this.OnPropertyChanged(nameof(Input2));
            }
        }

        private double result;

        public double Result
        {
            get { return result; }
            set
            {
                result = value;
                this.OnPropertyChanged(nameof(Result));
            }
        }

        public DelegateCommand AddCommand { get; set; }
        public DelegateCommand SaveCommand { get; set; }

        private void Add(object p)
        {
            this.Result = this.Input1 + this.Input2;
        }

        private void Save(object p)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
        }

        public MainWindowViewModel()
        {
            this.AddCommand = new DelegateCommand {ExecuteAction = this.Add};

            this.SaveCommand = new DelegateCommand {ExecuteAction = this.Save};
        }
    }
}
