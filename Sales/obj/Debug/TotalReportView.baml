   M S B A M L   `   `   `  ����	  Sales    Sales.TotalReportView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      �   � RowDefinitions  5   
   �� 5	      $��35 �6   �� 5
      $��* �6   .+�5   
   �� .+�5      �� $��40��6   ��6$   ��  �� Path$
 Year��� 5      $��60��6   $��年度��6#   �� 5      $	��120��6   ��6$   �� $ Section�5      &   System.Windows.Controls.DataGrid  5   
   $��1��6      AutoGenerateColumns .     
IsReadOnly . ��6O   �� $ Items� �� Mode$ OneWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 5         Header$	 月��5         	CellStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [  5      	   Binding	 5      �� $ Month�  5      $	 120 5      $ 	目標額��5      # [  5      	 5      �� $ 	PlanPrice�
 �� StringFormat$
 
##,###,###��  5      $	 120 5      $ 	実績額��5      # [  5       	 5!      �� $ ResultPrice�$
 
##,###,###��  5"      $	 120 5#      $ 差額��5$      # [  5%      	 5&      �� $ SubtractPrice�$
 
##,###,###��  5'      $	 120 5(      $ 差額累計��5)      # [  5*      	 5+      �� $ 
TotalPrice�$
 
##,###,###��5-      5.      5/      