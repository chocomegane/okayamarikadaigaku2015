   M S B A M L   `   `   `  ���� 	  Sales    Sales.TotalReportView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .���   � RowDefinitions  �� $��35 ��� $��* �.+��� .+��� $��40������  �� Path$
 Year��� $��60��$��年度���� $	��120������ $ Section�&   System.Windows.Controls.DataGrid  $��1��   AutoGenerateColumns .     
IsReadOnly . ���� $ Items� �� Mode$ OneWay=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80    Header$	 月��   	CellStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [  	   Binding	 �� $ Month�  $	 120 $ 	目標額��# [  	 �� $ 	PlanPrice�
 �� StringFormat$
 
##,###,###��  $	 120 $ 	実績額��# [  	 �� $ ResultPrice�$
 
##,###,###��  $	 120 $ 差額��# [  	 �� $ SubtractPrice�$
 
##,###,###��  $	 120 $ 差額累計��# [  	 �� $ 
TotalPrice�$
 
##,###,###��