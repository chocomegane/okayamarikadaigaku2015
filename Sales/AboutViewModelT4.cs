/*********************************************************************
警告！！
このソースコードは自動生成されたものです
このファイルを直接編集すると、編集した内容が失われる可能性があります
**********************************************************************/
using System;

namespace Sales
{
    class AboutViewModel : ModelBase
	{
	    public Action ShowDialogBox { get; set; }
        public string Title
		{
		    get
			{
			    return AboutModel.Title;
			}
		}
        public string Product
		{
		    get
			{
			    return AboutModel.Product;
			}
		}
        public string Version
		{
		    get
			{
			    return AboutModel.Version;
			}
		}
        public string Copyright
		{
		    get
			{
			    return AboutModel.Copyright;
			}
		}
        public string Company
		{
		    get
			{
			    return AboutModel.Company;
			}
		}
        public string Description
		{
		    get
			{
			    return AboutModel.Description;
			}
		}
        public static void ShowDialog()
		{
		    AboutViewModel vm = new AboutViewModel();
			AboutView v = new AboutView();
			v.DataContext = vm;
			vm.ShowDialogBox();
		}
	}
}