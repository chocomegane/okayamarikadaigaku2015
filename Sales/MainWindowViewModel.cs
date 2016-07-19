using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.TeamFoundation.MVVM;

namespace Sales
{
    partial class MainWindowViewModel : ModelBase
    {
        public Func<string> ShowOpenFileDialog { get; set; }
        public Func<string> ShowSaveFileDialog { get; set; }
        public Action<string> ShowInformationDialog { get; set; }
        public Action<string> ShowErrorDialog { get; set; }

        public short Year
        {
            get
            {
                return Years.Item;
            }
            set
            {
                if (Years.Item == value) return;
                Years.Item = value;
                RaisePropertyChanged("Year");
            }
        }

        public Section Section
        {
            get
            {
                return Sections.Item;
            }
            set
            {
                if (Sections.Item == value) return;
                Sections.Item = value;
                RaisePropertyChanged("Section");
            }
        }

        private SalesMonthModel _item;
        public SalesMonthModel Item
        {
            get
            {
                return _item;
            }
            set
            {
                if (_item == value) return;
                _item = value;
                RaisePropertyChanged("Item");
            }
        }
        public IEnumerable<SalesMonthModel> Items
        {
            get
            {
                return SalesModel.MonthModels;
            }
        }

        private ICommand _ListCommand;
        public ICommand ListCommand
        {
            get
            {
                if (_ListCommand == null)
                {
                    _ListCommand = new RelayCommand(
                        ExecuteListCommand, CanExecuteListCommand);

                }
                return _ListCommand;
            }
        }

        private void ExecuteListCommand(object x)
        {
            ListViewModel.ShowDialog(Item);
            Item = null;
            Renew();
        }

        private bool CanExecuteListCommand(object x)
        {
            return Item != null;
        }

        private void ExecuteReadCommand()
        {
            Renew();
        }

        private void ExecutePrintCommand()
        {
            TotalReportViewModel.ShowDialog();
        }

        private void ExecuteImportCommand()
        {
            string filename = ShowOpenFileDialog();
            if (string.IsNullOrEmpty(filename)) return;
            try
            {
                SalesModel.Import(filename);
                ShowInformationDialog("インポート完了！");
                Renew();
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void ExecuteExportCommand()
        {
            string filename = ShowSaveFileDialog();
            if (string.IsNullOrEmpty(filename)) return;
            try
            {
                SalesModel.Export(filename);
                ShowInformationDialog("エクスポート完了！");
                Renew();
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void ExecuteHelpCommand(object x)
        {
            string s = Properties.Settings.Default.HelpUri;
            try
            {
                System.Diagnostics.Process.Start(s);
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void ExecuteAboutCommand(object x)
        {
            AboutViewModel.ShowDialog();
        }
        private void Renew()
        {
            Item = null;
            SalesModel.Renew();
            RaisePropertyChanged("Items");
        }
    }
}
