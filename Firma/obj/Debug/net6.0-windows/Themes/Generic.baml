   M S B A M L   `   `   `  ����@  <Firma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Firma.ViewsFirma.Views  5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089#    Firma.Views.WszystkieViewBase  �� 
TargetType �� Property �� Value �� 
TargetType � RowDefinitions `� 
Background �� ImageSource �� SelectedValue �� Path	 �� Mode
 �� Padding   Firma.Views.JedenViewBase�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      #localclr-namespace:Firma.Views  5      %!  '         '      �� 5      "    6   .�5   
   ��  � �� 5	      �� 5
      "   6"   .R�5      � $��
20,0,20,20q�6    5      �� 5      $
��Auto �6-   �� 5      $
��Auto �6-   �� 5      $��* �6-   .+�5      `� $��0��6&   
 �����$��Center=�6G   $��Center=�6b   .�5      c� 
�������$��0��6>   $��50��6L   $��2,2,2,2q�6Y   .@�5   "   d� $��90��60   $��30��6<   $��4q�6H   ��6S   �� *
AddCommand+��5   &   �� 5   *   $? 9pack://application:,,,/Firma;component/Views/icon/add.png��65   5   #   d� 5   "   $��90��60   $��30��6;   $��4q�6G   ��5   &   �� 5   *   $B <pack://application:,,,/Firma;component/Views/icon/modify.png��65   5   #   d� 5   "   $��90��60   $��30��6<   $��4q�6H   ��5   &   �� 5   *   $B <pack://application:,,,/Firma;component/Views/icon/delete.png��65   5!   #   d� 5"   "   $��90��60   $��30��6<   $��4q�6H   ��6S   �� *LoadCommand+��5#   &   �� 5$   *   $C =pack://application:,,,/Firma;component/Views/icon/refresh.png��65   5&   #   5'      5(      c� 5)      $��1��6"   
�������$��50��6F   $��1q�6R   $��Center=�6]   $��Center=�6x   .@�5*      �� $��9q�6$   $��Sort:��6/   �� 5+      $	��100��5-   #   ��5+   '   �� *SortComboboxItems+ 5,   #   �� $ 	SortField�$	 TwoWay=�5-   #   �� 5.      ��6%   �� *SortCommand+��5/   "   �� 50   &   $��2q�6-   
���   �$
 4q�6U   
�������._�51   *   �� $
��Sort��64   52   '   54      �� 57      �� 5:      $��9q�6$   $��Search:��6/   �� 5;      $	��100��5=   #   ��5;   '   �� *FindComboboxItems+ 5<   #   �� $ 	FindField�$	 TwoWay=�5=   #   �� 5>      $	��100��6C   ��6&   �� *FindTextBox+6C   �� 5?      ��6%   �� *FindCommand+��5@   "   �� 5A   &   $��2q�6-   
���   �$
 4q�6U   
�������._�5B   *   �� $��Search��64   5C   '   5E      5F      �� 5H      $��2��6,   $��0,5,0,5q�6:   5I      5K      5M      5N      �� 5P      "   6   .�5Q   
   ��  � �� 5R      �� 5S      "  6"   .R�5T      � $��
20,0,20,20q�6    5U      �� 5V      $��60 �6-   �� 5W      $��* �6-   .+�5Y      `� $��Center=�6&   $��Center=�6A   .�5Z      c� 
�������$��0��6>   $��50��6L   $��2,2,2,2q�6Y   .@�5\   "   d� $��90��60   $��30��6;   $��4q�6G   ��6R   �� *SaveCommand+��5]   &   �� 5^   *   $@ :pack://application:,,,/Firma;component/Views/icon/save.png��65   5`   #   d� 5a   "   $��90��60   $��30��6;   $��4q�6G   ��6R   �� *SaveAndCloseCommand+��5b   &   �� 5c   *   $H Bpack://application:,,,/Firma;component/Views/icon/saveandclose.png��65   5e   #   d� 5g   "   $��90��60   $��30��6;   $��4q�6G   ��6R   �� *CancelCommand+��5h   &   �� 5i   *   $B <pack://application:,,,/Firma;component/Views/icon/cancel.png��65   5k   #   5m      5n      �� 5o      $��1��6+   $��0,5,0,5q�68   5p      5r      5t      5u      5v      