   M S B A M L   `   `   `  ���� 	  Sales    Sales.ListView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  一覧��$	��600��$	��800�� � WindowStartupLocation$ CenterOwner=� � 	Resources    listViewItem �� 
TargetType �� Property �� Value  date �� Path �� StringFormat 
 client 	 title 	 price��%U  &	        &	 m     &	 �     &	 �     &	 �     �� " ��.���  � ��
 �������  � ��$	 0.1q���  � ��$ Stretch=���  � ��$ 35���� .R��� ���� $
 Date�$ 
yyyy/MM/dd���� .R��� ���� $ Client��� .R��� ���� $ Title��� .R��� $��Right=����� $ Price�$ 
##,###,###��.���  � RowDefinitions �� $��35 ��� $��* ��� $��35 �.+�� $��0��	 � ColumnDefinitions	 �� $
��auto ��� $��* ��� $
��auto �.+��� $��2q�$��0��
 �� Orientation$
 
Horizontal=�.+��� $��80������ $
 Year�$ ####年度生�� �� Mode$ OneTime=��� $��50������ $ Month�$ ##年生��$ OneTime=��� $��1��$��2q�#��[  
������� �� SelectionMode$ Single=����� $ Items�$ OneWay=� �� SelectedItem �� $
 Item�$ TwoWay=� �� View �� .P���  �� Width$	 250�� �� CellTemplate# [ $	��群���� $	 250��# [ $��授業科目���� $	 100��# [ $��	単位数���� $��2��.+��� $��最新の状態に更新������ $ RenewCommand��� $��追加������ $ AppendCommand��� $��変更������ $ UpdateCommand��� $��削除������ $ DeleteCommand��� $��	閉じる������ $ CloseCommand�