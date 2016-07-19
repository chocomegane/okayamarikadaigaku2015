/*********************************************************************
警告！！
このソースコードは自動生成されたものです
このファイルを直接編集すると、編集した内容が失われる可能性があります
**********************************************************************/
using System;

namespace Sales
{
    partial class EditViewModel : ModelBase
	{
        private int _Id;
		public int Id
		{
		    get
			{
			    return _Id;
			}
			set
			{
			    if(_Id == value) return;
				_Id = value;

				try
				{
				    _model.Id = value;
					base.UpdateErrors("Id", "");
				}
				catch(Exception ex)
				{
				    base.UpdateErrors("Id", ex.Message);
				}

				RaisePropertyChanged("Id");
				RaisePropertyChanged("Error");
			}
		}
        private DateTime _Date;
		public DateTime Date
		{
		    get
			{
			    return _Date;
			}
			set
			{
			    if(_Date == value) return;
				_Date = value;

				try
				{
				    _model.Date = value;
					base.UpdateErrors("Date", "");
				}
				catch(Exception ex)
				{
				    base.UpdateErrors("Date", ex.Message);
				}

				RaisePropertyChanged("Date");
				RaisePropertyChanged("Error");
			}
		}
        private string _Client;
		public string Client
		{
		    get
			{
			    return _Client;
			}
			set
			{
			    if(_Client == value) return;
				_Client = value;

				try
				{
				    _model.Client = value;
					base.UpdateErrors("Client", "");
				}
				catch(Exception ex)
				{
				    base.UpdateErrors("Client", ex.Message);
				}

				RaisePropertyChanged("Client");
				RaisePropertyChanged("Error");
			}
		}
        private string _Title;
		public string Title
		{
		    get
			{
			    return _Title;
			}
			set
			{
			    if(_Title == value) return;
				_Title = value;

				try
				{
				    _model.Title = value;
					base.UpdateErrors("Title", "");
				}
				catch(Exception ex)
				{
				    base.UpdateErrors("Title", ex.Message);
				}

				RaisePropertyChanged("Title");
				RaisePropertyChanged("Error");
			}
		}
	}
}

