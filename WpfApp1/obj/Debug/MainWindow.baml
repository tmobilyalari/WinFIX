   M S B A M L   `   `   `  ����B  >WpfApp1, Version=0.1.0.1, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��700��6   $
��1000��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   5      �� 5      $
��auto �6   5      �� 5      $
��auto �6   5       � ColumnDefinitions 5   
   �� 5      $
��auto �6   5      �� 5      $
��auto �6   5      �� 5      $
��auto �6   5      .+�5   
   �� -   5        $��SFC Hizmeti��5      $
��Left=�6'   $��
80,300,0,0q�6B   $��1��6V   $��1��6c   $��2��6s   6�   �� 5    
   -   5        $��Komut İstemi��5       $
��Left=�6(   $��280,300,0,0q�6C   $��1��6X   $	��Top=�6e   $��1��6}   6�   �� 5!   
   -   5        $��DISM Hizmeti��5!      $
��Left=�6(   $��480,300,0,0q�6C   $��1��6X   $	��Top=�6e   $��1��6}   6�   �� 5"   
   $��1��6   $��2��6    $;��5Seçiminizi yapın Windows kendini onarmayı denesin.��64   $��Center=�6q   $��	80,72,0,0q�6�   $��0��6�   $��39��6�   $	��454��6�   $��Center=�6�   �� 5#   
   -   5         ��Name$ Chkdsk��5#      $��2��6!   $��Disk Kontrolü��61   $
��Left=�6I   $��150,300,0,0q�6d   $��1��6y   $	��Top=�6�   $��2��6�   6�   �� 5$   
   -   5        $ Temp_Delete��5$      $��1��6&   $��Çöp Temizleyen��66   $
��Left=�6O   $��
70,221,0,0q�6j   $��1��6~   $	��Top=�6�   6�   5%      5'      