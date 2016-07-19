using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Sales
{
    partial class ListViewModel : ModelBase
    {
        private SalesMonthModel _model;// → SalesMonthModel._model？

        private ListViewModel(SalesMonthModel monthModel)
        {
            _model = monthModel;
        }
        public Action CloseDialogBox { get; set; }
        public Action ShowDialogBox { get; set; }
        public Func<string, bool> ShowYesNoDialogBox { get; set; }

        public short Year
        {
            get
            {
                return Years.Item;
            }
        }

        public int Month
        {
            get
            {
                return _model.Month;
            }
        }

        public string Section
        {
            get
            {
                return Sections.Item.Title;
            }
        }

        public int TotalPrice
        {
            get
            {
                return _model.ResultPrice;
            }
        }

        private Result _item;
        public Result Item
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

        public ObservableCollection<Result> Items
        {
            get
            {
                return _model.ResultItems;
            }
        }

        private void ExecuteRenewCommand()
        {
            Renew();
        }

        private void ExecuteAppendCommand()
        {
            Result result = _model.NewResult(Item);
            if (!EditViewModel.ShowDialog(result)) return;
            _model.Add(result);
            _model.SaveChanges();
            Item = result;
        }

        private void ExecuteUpdateCommand(object x)
        {
            Result result = _model.NewResult(Item);
            if (!EditViewModel.ShowDialog(result)) return;
            Item.SetProperties(result);
            _model.SaveChanges();
        }

        private bool CanExecuteUpdateCommand(object x)
        {
            return Item != null;
        }

        private void ExecuteDeleteCommand(object x)
        {
            if (!ShowYesNoDialogBox("削除しても良いですか？")) return;       

            Result model = Item;
            Item = null;
            _model.Remove(model);
            _model.SaveChanges();
        }

        private bool CanExecuteDeleteCommand(object x)
        {
            return Item != null;
        }

        private void ExecuteCloseCommand()
        {
            CloseDialogBox();
        }

        public void Renew()                           //
        {
            Item = null;
            _model.Renew();
            RaisePropertyChanged("TotalPrice");
        }

        static public void ShowDialog(SalesMonthModel month)
        {
            ListViewModel vm = new ListViewModel(month);         //
            ListView v = new ListView();
            v.DataContext =vm;
            vm.ShowDialogBox();
        }
    }
}
