   M S B A M L   `   `   `  ����@  <Firma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Firma.ViewsFirma.Views  5      "    Firma.Views.AddEmployeesView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Firma.Views     5        � 	Resources  5	       �� Source�� 5
   
   $" StyleZakladekDictionary.xaml?�6   %    .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $	��150 �6    �� 5      $	��200 �6     � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $��0��6"   $
��Name��60   $��0,8,0,8q�6@   �� 5    
   $��1��6   $��0��6$   $��0,8,0,8q�61   $	��100��6C   $
��Left=�6O   ��5!      ��  �� Path$
 Imie� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True���� 5#   
   $��0��6   $��1��6"   $��Surname��60   $��0,8,0,8q�6C   �� 5$   
   $��1��6   $��1��6$   $��0,8,0,8q�61   $	��150��6C   $
��Left=�6O   ��5%      �� $ Nazwisko�$ PropertyChanged=�$
 True���� 5'   
   $��0��6   $��2��6"   $��	Hire Date��60   $��0,8,0,8q�6E   (  "System.Windows.Controls.DatePicker  5(   
   $��1��6   $��2��6'   $��0,8,0,8q�64   $	��120��6F   $
��Left=�6R      SelectedDate 6n   �� $ DataZatrudnienia�$ PropertyChanged=��� 5*   
   $��0��6   $��3��6"   $��Position��60   $��0,8,0,8q�6D   �� 5+   
   $��1��6   $��3��6$   $��0,8,0,8q�61   $	��120��6C   $
��Left=�6O   ��6k   �� $ 
Stanowisko�$ PropertyChanged=��� 5-   
   $��0��6   $��4��6"   $��Salary��60   $��0,8,0,8q�6B   �� 5.   
   $��1��6   $��4��6$   $��0,8,0,8q�61   $	��120��6C   $
��Left=�6O   ��6k   �� $ Pensja�$ PropertyChanged=�$
 True���� 51   
   $��0��6   $��5��6"   $��Status��60   $��0,8,0,8q�6A   �� 52   
   $��1��6   $��5��6$   $��0,8,0,8q�61   $	��120��6C   $
��Left=�6O   ��6k   �� $ 	Aktywnosc�$ PropertyChanged=��� 54   
   $��0��6   $��6��6"   $��Who Add��60   $��0,8,0,8q�6B   �� 55   
   $��1��6   $��6��6%   $��0,8,0,8q�63   $	��120��6E   $
��Left=�6Q    �� DisplayMemberPath$
 Imie��6�   	 �� SelectedValuePath$	 IdPracownicy��6�   ��6m   �� *IdPracownicyComboBoxItems+
 �� SelectedValue
 6�   �� $ KtoDodal� �� Mode$ TwoWay=��� 57   
   $��0��6   $��7��6"   $��When Add��60   $��0,8,0,8q�6D     58   
   $��1��6   $��7��6'   $��0,8,0,8q�64   $	��120��6F   $
��Left=�6R    6n   �� $ KiedyDodane�$ PropertyChanged=�5;      5<      