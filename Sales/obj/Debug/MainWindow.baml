   M S B A M L   `   `   `  ����@  <Sales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SalesSales  5   	       Sales.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   !lclr-namespace:Sales     5   	     � Icon$-  '2cccbff5f934d551071a19de1ac311fc_ol.ico��5   	    � Title$! 卒業・教職単位管理��5   	   $	��550��6   $	��800��6(    � 
ResizeMode$ CanMinimize=�64    � DataContext 5        Sales.MainWindowViewModel  5   
   .��5
      �  � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��* �6   �� 5      $��35 �6   .+�5   
   �� $��0��6   $
��Left=�6"   .+�5      �� $��4q�6   $��60��6"     Sales.Years   Items#��Z 6-    �� SelectedItem 6T   ��  �� Path$
 Year��� 5      $��4q�6   $��	年度生��6#   �� 5      $��4q�6   $��読み込み��6    ��6/   �� $ ReadCommand�5      &   System.Windows.Controls.DataGrid  5   
   $��1��6   $��4q�6       AutoGenerateColumns .  	   
IsReadOnly	 . $
 �� IsSynchronizedWithCurrentItem$

 TrueY�6Y      SelectionMode$ Single=�6�   ��6~   �� $ Items� �� Mode$ OneWay=� 6�   �� $
 Item�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 5         Header$ 年生��5         	CellStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [  5         Binding 5      �� $ Month�  5      $
 120* 5      $ 履修単位数��5      # [  5        5!      �� $ ResultPrice� �� StringFormat$ 
##,###,###��  5"      $
 120* 5#      $ 卒業単位不足数��5$      # [  5%       5&      �� $ SubtractPrice�$ 
##,###,###��  5'      $
 120* 5(      $ 教職単位不足数��5)      # [  5*       5+      �� $ 
TotalPrice�$ 
##,###,###��5-      �� 5.   
   $��2��6   .+�5/      �� $��	一覧...��6:   ��6   �� $ ListCommand�6:   �� 50      $��	印刷...��6;   ��6   �� $ PrintCommand�6;   �� 51      $��インポート...��6<   ��6   �� $ ImportCommand�6<   �� 52      $��エクスポート...��6<   ��6   �� $ ExportCommand�6<   �� 53      -   5        $��	閉じる��53      6#   �� 54      $��32��6   �� 55      $��ヘルプ...��6:   ��6   �� $ HelpCommand�6:   �� 56      $��バージョン情報...��6;   ��6   �� $ AboutCommand�6;   57      58      59      