/*********************************************************************
警告！！
このソースコードは自動生成されたものです
このファイルを直接編集すると、編集した内容が失われる可能性があります
**********************************************************************/
using System.Windows.Input;
using Microsoft.TeamFoundation.MVVM;

namespace Sales
{
    partial class MainWindowViewModel : ModelBase
	{
    
	    private ICommand _ReadCommand;
	    public ICommand ReadCommand
		{
		    get
			{
			    if (_ReadCommand == null)
				{
				    _ReadCommand = new RelayCommand(ExecuteReadCommand);
				}
				return _ReadCommand;
			}
		}
    
	    private ICommand _PrintCommand;
	    public ICommand PrintCommand
		{
		    get
			{
			    if (_PrintCommand == null)
				{
				    _PrintCommand = new RelayCommand(ExecutePrintCommand);
				}
				return _PrintCommand;
			}
		}
    
	    private ICommand _ImportCommand;
	    public ICommand ImportCommand
		{
		    get
			{
			    if (_ImportCommand == null)
				{
				    _ImportCommand = new RelayCommand(ExecuteImportCommand);
				}
				return _ImportCommand;
			}
		}
    
	    private ICommand _ExportCommand;
	    public ICommand ExportCommand
		{
		    get
			{
			    if (_ExportCommand == null)
				{
				    _ExportCommand = new RelayCommand(ExecuteExportCommand);
				}
				return _ExportCommand;
			}
		}
    
	    private ICommand _HelpCommand;
	    public ICommand HelpCommand
		{
		    get
			{
			    if (_HelpCommand == null)
				{
				    _HelpCommand = new RelayCommand(ExecuteHelpCommand);
				}
				return _HelpCommand;
			}
		}
    
	    private ICommand _AboutCommand;
	    public ICommand AboutCommand
		{
		    get
			{
			    if (_AboutCommand == null)
				{
				    _AboutCommand = new RelayCommand(ExecuteAboutCommand);
				}
				return _AboutCommand;
			}
		}
	}
}