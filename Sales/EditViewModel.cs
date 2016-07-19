using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.TeamFoundation.MVVM;

namespace Sales
{
    partial class EditViewModel : ModelBase
    {
        private Result _model;

        public EditViewModel(Result result)
        {
            _model = result;
            Date = _model.Date;
            Section = Sections.Items.First(x => x.Id == _model.SectionId);
            Client = _model.Client;
            Title = _model.Title;
            Price = _model.Price.ToString();
        }



        public Action<bool> CloseDialogBox { get; set; }
        public Func<bool> ShowDialogBox { get; set; }

        private Section _Section;
        public Section Section
        {
            get
            {
                return _Section;
            }
            set
            {
                if (_Section == value) return;
                _Section = value;

                try
                {
                    _model.SectionId = value.Id;
                    base.UpdateErrors("Section", "");
                }
                catch (Exception ex)
                {
                    base.UpdateErrors("Section", ex.Message);
                }
                RaisePropertyChanged("Section");
                RaisePropertyChanged("Error");
            }
        }

        private string _Price;
        public string Price
        {
            get
            {
                return _Price;
            }
            set
            {
                if (_Price == value) return;
                _Price = value;

                try
                {
                    _model.Price = int.Parse(value);
                    base.UpdateErrors("Price", "");
                }
                catch(Exception ex)
                {
                    base.UpdateErrors("Price", ex.Message);
                }
                RaisePropertyChanged("Section");
                RaisePropertyChanged("Error");
            }
        }

        private ICommand _OkCommand;
        public ICommand OkCommand
        {
            get
            {
                if (_OkCommand == null)
                {
                    _OkCommand =
                        new RelayCommand(ExecuteOkCommand, CanExecuteOkCommand);
                }
                return _OkCommand;
            }
        }

        private void ExecuteOkCommand(object x)
        {
            CloseDialogBox(true);
        }

        private bool CanExecuteOkCommand(object x)
        {
            return !base.HasErrors;
        }

        private ICommand _CancelCommand;
        public ICommand CancelCommand
        {
            get
            {
                if (_CancelCommand == null)
                {
                    _CancelCommand = new RelayCommand(ExecuteCancelCommand);
                }
                return _CancelCommand;
            }
        }

        private void ExecuteCancelCommand()
        {
            CloseDialogBox(false);
        }

        static public bool ShowDialog(Result result)
        {
            EditViewModel vm = new EditViewModel(result);
            EditView v = new EditView();
            v.DataContext = vm;
            return vm.ShowDialogBox();
        }

    }
}
