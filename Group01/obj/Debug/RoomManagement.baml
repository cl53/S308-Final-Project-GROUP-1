   M S B A M L   `   `   `  ����B  >Group01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Group01Group01  5   	       Group01.RoomManagement   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Group01     5   	   -   5          �Name$  winRoomManagement��5   	    � Title$ Room Management��5   	   $	��500��6!   $
��1000��6.    � WindowStartupLocation$ CenterScreen=�6;   .��5	      � ��5
   
   �� 5       �� ImageSource$ Images/background3.jpg��6    j� Stretch$ UniformToFill=�6>   .+�5   
   �� -   5         ��Name$ gbxUpdateGroup��5      $��Room Information Changes��6+   $
��Left=�6M   $	��112��6h   $��
38,237,0,0q�6u   $	��Top=�6�   $	��306��6�   ���	#FFD1B3B36�   �� 5   
   -   5         ��Name$ cbxRoomType��5      $
��Left=�6(   $��183,119,0,0q�6C   $	��Top=�6X   $	��161��6p   $��29��6|   $��0��6�   .@�5      �� $��One King��6   �� 5      $��One King Deluxe��6   �� 5      $��
Two Queens��6   �� 5      $��Two Queen Deluxe��6   �� 5      $��One King Suite��6   �� 5      $!��One King Presidential Suite��6   5      �� 5   
   -   5         ��Name$ lblRoomType��5      $��Select Room Type:��6%   $
��Left=�6A   $��
41,119,0,0q�6\   $	��Top=�6p   $
��Bold"�6�   $��29��6�   $	��116��6�   $��Center=�6�   �� 5   
   -   5         ��Name$ btnReturnToMainWindow��5      $��Return ��60   $
��Left=�6B   $��	905,0,0,0q�6]   $	��Top=�6p   $��87��6�   $��42��6�   $
��Bold"�6�   $��16(�6�   $��5��6�   ��5      �� 5      	 �� Color$	 	#FFDDDDDD��6"   
 �� Opacity$
 0Q�64   ��5      �� 5      $	 	#FF707070��6"   $
 0Q�64   5      �� 5    
   -   5        $ lblSystemTitle��5       $)��#Enterprise Hotel Reservation System��6(   $��Center=�6V   $	��Top=�6s   $��42��6�   $	��344��6�   $��18.667(�6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   �� 5!   
   -   5        $ btnUpdateRoomInfo��5!      $��Update��6,   $
��Left=�6=   $��
92,396,0,0q�6X   $	��Top=�6l   $��90��6�   $��35��6�   $
��Bold"�6�   $��16(�6�   $��3��6�   ��5"      �� 5#      $	 White��6"   $
 0Q�60   ��5%      �� 5&      $	 White��6"   $	
 0.5Q�60   5(      �� 5)   
   -   5         ��Name$ txtCurrentRoomInfo��5)      $
��Left=�60   $��30��6K   $��183,161,0,0q�6W   $
��Wrap=�6l   $��30 - One King: $179��6�   $	��Top=�6�   $	��161��6�   $
��Bold"�6�   �� 5*   
   -	   5         ��Name$ txtPrice��5*      $
��Left=�6$   $��23��6?   $��200,268,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $
��$188��6t   $	��Top=�6�   $	��120��6�   $
��Bold"�6�   $��1��6�   �� 5+   
   -
   5        $ txtQuantity��5+      $
��Left=�6'   $��23��6B   $��200,308,0,0q�6N   $
 Wrap=�6c   $��32��6w   $	��Top=�6�   $	��120��6�   $
��Bold"�6�   $��2��6�   �� 5,   
   -   5        $ lblQuantity��5,      $��Update Quantity To:��6%   $
��Left=�6C   $��
58,304,0,0q�6^   $	��Top=�6r   $
��Bold"�6�   �� 5-   
   -   5        $ lblPrice��5-      $��Update Price To:��6"   $
��Left=�6=   $��
58,265,0,0q�6X   $	��Top=�6l   $
��Bold"�6�   $	��124��6�   �� 5.   
   -   5        $ lblRoomInfo��5.      $��Current Info:��6%   $
��Left=�6=   $��
41,161,0,0q�6X   $	��Top=�6l   $	��116��6�   $��30��6�   $
��Bold"�6�   $��Center=�6�   �� 5/   
   -   5        $ btnClear��5/      $��Clear��6#   $
��Left=�63   $��254,396,0,0q�6N   $	��Top=�6c   $��90��6{   $��35��6�   $
��Bold"�6�   $��16(�6�   $��4��6�   ��50      �� 51      $	 White��6"   $
 0Q�60   ��53      �� 54      $	 White��6"   $	
 0.5Q�60   56      58      59      