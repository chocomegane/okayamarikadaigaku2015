using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Sales.Properties;

namespace Sales
{
    using ItemsType = ObservableCollection<Result>;
    class SalesMonthModel
    {
        
        private readonly SalesDatabaseContext _dataContext;
        private readonly SalesMonthModel _previousModel;
        public SalesMonthModel(
            SalesDatabaseContext dataContext,
            byte month,
            SalesMonthModel previousModel)
        {
            _resultItems.CollectionChanged += _resultItems_CollectionChanged;
            _dataContext = dataContext;       
            _previousModel = previousModel;
           _month = month;
            Renew();
        }
        private readonly byte _month;
        public byte Month
        {
            get
            {
                return _month;
            }
        }

        public int PlanPrice

        {
            get
            {
                return Settings.Default.PlanPrice;
            }
        }
        /*public int pprice　　　　　　pprice→試行錯誤の末作った新しいもの（未使用）
        {
            get
            {
                return Settings.Default.pprice;
            }
        }*/
        public int ResultPrice { get; private set; }//EditViewに記入された単位が入る。
        public int SubtractPrice//卒業単位数不足数
        {
            get
            {
                /*aの初期設定を-124設定している（nullの時-124を代入）*/
                int a = _previousModel == null ?
                    -124 :
                    _previousModel.SubtractPrice;
                return ResultPrice + a ;  　　　　 //ResultPrice に先月のSubtractPriceをたして表示（履修単位数+先月の卒業単位不足数）
            }                                                         
        }

        public int TotalPrice                      　　　　　　　　
        {                                          　　　　　　　　　
            get                                                
            {          
                
                /*pの初期設定を-20設定している（nullの時-20を代入）*/
                int p =                           　　　　　　　　　
                    _previousModel == null ?       　　　　　　　
                    -20 :                          　　
                    _previousModel.TotalPrice;     
                return ResultPrice + p ;    　　　 //ResultPrice に先月のTotalPriceを足して表示（履修単位数-先月の教職単位不足数）

            }
        }
        private readonly ItemsType _resultItems = new ItemsType();
        public ItemsType ResultItems
        {
            get
            {
                return _resultItems;
            }
        }

        public void Renew()
        {
            /*linq*/
           var q =
                from p in _dataContext.Results      //ここの操作がいまいち。。現在の月を呼び出し同じかたしかめている？？
                where
                     p.Date.Year == Years.Item &&
                     p.Date.Month == Month &&
                     p.SectionId == Sections.Item.Id
                select p;

            _resultItems.Clear();
            foreach (Result x in q)
            {

                _resultItems.Add(x);
            }

        }
        public Result NewResult(Result source)
        {
            Result r = new Result();
            if (source == null)
            {
                r.SectionId = Sections.Item.Id;
                r.Date = new DateTime(Years.Item, Month, 1);
            }
            else
            {
                r.SetProperties(source);
            }
            return r;
        }

        public void Add(Result row)
        {
  
            _dataContext.Results.Add(row);
            _resultItems.Add(row);
            
        }

        public void Remove(Result row)
        {

            

            _dataContext.Results.Remove(row);
            _resultItems.Remove(row);

        }
        public int SaveChanges()
        {

            return _dataContext.SaveChanges();
            
        }
 


        
        private void _resultItems_CollectionChanged(
            object sender, NotifyCollectionChangedEventArgs e ) 
        {
            /*rinq*/
            


            /*qに　Binding Path　＝　Price　の　EditView　に記載された数値取得*/
            var q =
                from p in _resultItems
                select p.Price;




/* 群の記入欄をコンボボックスに変えて　
 　コンボボックスからどれを選択したかで
 　処理の仕方を変えるようにしたい
 　教職と卒業単位によって分別し整理したい
 今後使いそうなもの
 * Sections.cs

 */

          /*  var c =
                from p in _resultItems
                select p.Client;*/
          
            ResultPrice = q.Sum();　/*ResultPriceに取得数値を代入*/

        }

    }
}


/*
問題
 * 
 * インポートした際日付けが合致しない
 * 年生を月（month）扱いしている
 * このままではエクスポートが上手くいかない
 * ☓☓☓☓年度入学が記入日扱いされている
 * 教職単位の物が卒業単位でも引かれている
 * EditView.xamlで未記入でも追加できる
 * 
 * 
あったらいいな、
 * 後期、前期（春学期、秋学期）の記載
 * 並び順変更機能とか（）今は追加が古い順
 *A群B1群・・・D群などの各自合計表示
 *
 * 
 * 
 * 
 */