   M S B A M L   `   `   `  ����@  <Firma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Firma.ViewsFirma.Views  5          Firma.Views.ClientView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Firma.Views     5        � 	Resources  5	       �� Source�� 5
   
   $" StyleZakladekDictionary.xaml?�6   %    .��5      � 
�������.+�5   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��6   ��6/   �� *List+ �� SelectedValue 6L   ��  �� Path$ CClient� �� Mode$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6"   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6.   �� *	IdKlienci+  5      $
 Name��6!    6/   �� *Imie+  5      $ Surname��6!    62   �� *
Nazwisko+  5      $ 
Birht Date��6!    65   �� *DataUrodzenia+  5      $	 Sex��6!    6.   �� *Plec+  5      $ Address��6!    62   �� *Adres+  5      $ Phone Number��6!    67   �� *NumerTelefonu+  5      $ Address E-MAIL��6!    69   �� *
AdresEmail+  5      $ 
Start Date��6%    69   �� *
DataZapisu+  5      $ Status��6%    65   �� *	Aktywnosc+  5      $ 	Who Added��6!    64   �� *
KtoDodal+  5      $ 
When Added��6!    65   �� *KiedyDodane+5      5      5      