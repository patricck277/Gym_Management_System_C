   M S B A M L   `   `   `  ����@  <Firma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Firma.ViewsFirma.Views  5      "    Firma.Views.AddEquipmentView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Firma.Views     5        � 	Resources  5	       �� Source�� 5
   
   $" StyleZakladekDictionary.xaml?�6   %    .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $	��150 �6    �� 5      $	��200 �6     � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $��0��6"   $��Equipment Name��60   $��0,8,0,8q�6J   �� 5   
   $��1��6   $��0��6$   $��0,8,0,8q�61   $	��100��6C   $
��Left=�6O   ��5       ��  �� Path$ NazwaSprzetu� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True���� 5"   
   $��0��6   $��1��6"   $��Manufacturer��60   $��0,8,0,8q�6H   �� 5#   
   $��1��6   $��1��6$   $��0,8,0,8q�61   $	��150��6C   $
��Left=�6O   ��5$      �� $ 	Producent�$ PropertyChanged=�$
 True���� 5&   
   $��0��6   $��2��6"   $��Year of Production��60   $��0,8,0,8q�6N   (  "System.Windows.Controls.DatePicker  5'   
   $��1��6   $��2��6'   $��0,8,0,8q�64   $	��120��6F   $
��Left=�6R      SelectedDate 6n   �� $ RokProdukcji�$ PropertyChanged=��� 5)   
   $��0��6   $��3��6"   $��Quantity Available��60   $��0,8,0,8q�6N   �� 5*   
   $��1��6   $��3��6$   $��0,8,0,8q�61   $	��150��6C   $
��Left=�6O   ��5+      �� $ IloscDostepnych�$ PropertyChanged=�$
 True���� 5-   
   $��0��6   $��4��6"   $��Status��60   $��0,8,0,8q�6A   �� 5.   
   $��1��6   $��4��6$   $��0,8,0,8q�61   $	��120��6C   $
��Left=�6O   ��6k   �� $ 	Aktywnosc�$ PropertyChanged=��� 50   
   $��0��6   $��5��6"   $��Who Add��60   $��0,8,0,8q�6B   �� 51   
   $��1��6   $��5��6%   $��0,8,0,8q�63   $	��120��6E   $
��Left=�6Q    �� DisplayMemberPath$
 Imie��6�   	 �� SelectedValuePath$	 IdPracownicy��6�   ��6m   �� *IdPracownicyComboBoxItems+
 �� SelectedValue
 6�   �� $ KtoDodal� �� Mode$ TwoWay=��� 53   
   $��0��6   $��6��6"   $
��Date��60   $��0,8,0,8q�6@     54   
   $��1��6   $��6��6'   $��0,8,0,8q�64   $	��120��6F   $
��Left=�6R    6n   �� $ KiedyDodane�$ PropertyChanged=�57      58      