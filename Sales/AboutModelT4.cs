/*********************************************************************
警告！！
このソースコードは自動生成されたものです
このファイルを直接編集すると、編集した内容が失われる可能性があります
**********************************************************************/
using System;
using System.Reflection;

namespace Sales
{
    static class AboutModel
	{
        public static string Title
		{
		    get
			{
			    AssemblyTitleAttribute a =
				    GetExecutingAssemblCustomAttributes<AssemblyTitleAttribute>();
				return (a == null) ? "" : a.Title;

			}
		}
        public static string Product
		{
		    get
			{
			    AssemblyProductAttribute a =
				    GetExecutingAssemblCustomAttributes<AssemblyProductAttribute>();
				return (a == null) ? "" : a.Product;

			}
		}
        public static string Copyright
		{
		    get
			{
			    AssemblyCopyrightAttribute a =
				    GetExecutingAssemblCustomAttributes<AssemblyCopyrightAttribute>();
				return (a == null) ? "" : a.Copyright;

			}
		}
        public static string Company
		{
		    get
			{
			    AssemblyCompanyAttribute a =
				    GetExecutingAssemblCustomAttributes<AssemblyCompanyAttribute>();
				return (a == null) ? "" : a.Company;

			}
		}
        public static string Description
		{
		    get
			{
			    AssemblyDescriptionAttribute a =
				    GetExecutingAssemblCustomAttributes<AssemblyDescriptionAttribute>();
				return (a == null) ? "" : a.Description;

			}
		}
        
		public static string Version
		{
		    get
			{
			    return MyAssembly.GetName().Version.ToString();
			}
		}

		private static T GetExecutingAssemblCustomAttributes<T>()
		    where T : Attribute
		{
		    object[] attributes =
			    MyAssembly.GetCustomAttributes(typeof(T), false);
			if (attributes.Length == 0) return null;
			return (T)attributes[0];
		}

		private static Assembly MyAssembly
		{
		    get
			{
			    return Assembly.GetExecutingAssembly();
			}
		}
	}
}

