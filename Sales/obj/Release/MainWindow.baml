   M S B A M L   `   `   `  ���� @  <Sales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SalesSales      Sales.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     !lclr-namespace:Sales       � Icon$-  '2cccbff5f934d551071a19de1ac311fc_ol.ico�� � Title$! 卒業・教職単位管理��$	��550��$	��800�� � 
ResizeMode$ CanMinimize=� � DataContext   Sales.MainWindowViewModel  .���  � RowDefinitions �� $��35 ��� $��* ��� $��35 �.+��� $��0��$
��Left=�.+��� $��4q�$��60��  Sales.Years   Items#��Z  �� SelectedItem ��  �� Path$
 Year��� $��4q�$��	年度生���� $��4q�$��読み込み������ $ ReadCommand�&   System.Windows.Controls.DataGrid  $��1��$��4q�   AutoGenerateColumns .  	   
IsReadOnly	 . $
 �� IsSynchronizedWithCurrentItem$

 TrueY�   SelectionMode$ Single=����� $ Items� �� Mode$ OneWay=� �� $
 Item�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 60    Header$ 年生��   	CellStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [     Binding �� $ Month�  $
 120* $ 履修単位数��# [   �� $ ResultPrice� �� StringFormat$ 
##,###,###��  $
 120* $ 卒業単位不足数��# [   �� $ SubtractPrice�$ 
##,###,###��  $
 120* $ 教職単位不足数��# [   �� $ 
TotalPrice�$ 
##,###,###���� $��2��.+��� $��	一覧...������ $ ListCommand��� $��	印刷...������ $ PrintCommand��� $��インポート...������ $ ImportCommand��� $��エクスポート...������ $ ExportCommand��� -   $��	閉じる���� $��32���� $��ヘルプ...������ $ HelpCommand��� $��バージョン情報...������ $ AboutCommand�