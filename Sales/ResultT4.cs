/*********************************************************************
警告！！
このソースコードは自動生成されたものです
このファイルを直接編集すると、編集した内容が失われる可能性があります
**********************************************************************/
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sales
{
   class Result : INotifyPropertyChanged
   {
      private readonly ValidationContext _validationContext;
	  public event PropertyChangedEventHandler PropertyChanged;

	  public Result()
	  {
	     _validationContext = new ValidationContext(this, null, null);
         Id = 0;
         Date = DateTime.Today;
         SectionId = 1;
         Client = string.Empty;
         Title = string.Empty;
         Price = 0;
	  }

	  protected virtual void RaisePropertyChanged(string propertyName)
	  {
	     if (PropertyChanged == null) return;
		 PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
	  }
      private int _Id;
	  
	  public int Id
	  {
	     get
		 {
		    return _Id;
		 }
		 set
		 {
		    if (_Id == value) return;
			_validationContext.MemberName = "Id";
			Validator.ValidateProperty(value, _validationContext);
			_Id = value;
			RaisePropertyChanged("Id");
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
		    if (_Date == value) return;
			_validationContext.MemberName = "Date";
			Validator.ValidateProperty(value, _validationContext);
			_Date = value;
			RaisePropertyChanged("Date");
		 }
	  }
      private byte _SectionId;
	  [Range(1,byte.MaxValue,ErrorMessage="設定可能な値の範囲外です")]
	  public byte SectionId
	  {
	     get
		 {
		    return _SectionId;
		 }
		 set
		 {
		    if (_SectionId == value) return;
			_validationContext.MemberName = "SectionId";
			Validator.ValidateProperty(value, _validationContext);
			_SectionId = value;
			RaisePropertyChanged("SectionId");
		 }
	  }
      private string _Client;
	  [StringLength(32, ErrorMessage="32文字以内で設定してください")]
	  public string Client
	  {
	     get
		 {
		    return _Client;
		 }
		 set
		 {
		    if (_Client == value) return;
			_validationContext.MemberName = "Client";
			Validator.ValidateProperty(value, _validationContext);
			_Client = value;
			RaisePropertyChanged("Client");
		 }
	  }
      private string _Title;
	  [StringLength(32, ErrorMessage="32文字以内で設定してください")]
	  public string Title
	  {
	     get
		 {
		    return _Title;
		 }
		 set
		 {
		    if (_Title == value) return;
			_validationContext.MemberName = "Title";
			Validator.ValidateProperty(value, _validationContext);
			_Title = value;
			RaisePropertyChanged("Title");
		 }
	  }
      private int _Price;
	  [Range(0,99999999, ErrorMessage="設定可能な値の範囲外です")]
	  public int Price
	  {
	     get
		 {
		    return _Price;
		 }
		 set
		 {
		    if (_Price == value) return;
			_validationContext.MemberName = "Price";
			Validator.ValidateProperty(value, _validationContext);
			_Price = value;
			RaisePropertyChanged("Price");
		 }
	  }

	  public void SetProperties(Result source)
	  {
         Id = source.Id;
         Date = source.Date;
         SectionId = source.SectionId;
         Client = source.Client;
         Title = source.Title;
         Price = source.Price;
	  }
   }
}


