   M S B A M L   `   `   `  ����B  >Group01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Group01Group01  5   	       Group01.ReservationReport   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Group01     5   	   -   5          �Name$  wndReservationReport��5   	    � Title$ Reservation Report��5   	   $	��500��6$   $
��1000��61    � WindowStartupLocation$ CenterScreen=�6>   .��5	      � ��5
   
   �� 5       �� ImageSource$ Images/background5.jpg��6    j� Stretch$ UniformToFill=�6>   .+�5   
   �� -   5         ��Name$ gbxFilterInformation��5      $��Filter Info��61   $
��Left=�6F   $	��240��6a   $��	21,60,0,0q�6n   $	��Top=�6�   $	��293��6�   �� 5   
   -   5         ��Name$ btnReturnToMainWindow��5      $��Return ��60   $
��Left=�6B   $��	905,0,0,0q�6]   $	��Top=�6p   $��87��6�   $��34��6�    J� RenderTransformOrigin$ 0.717,0.634&�6�   $
��Bold"�6�   $��16(�6�   
�������$��7��6  ��5      �� 5       �� Color$ White��6"   	 �� Opacity$	 0Q�60   ��5      �� 5      $ White��6"   $	 0Q�60   5      (  "System.Windows.Controls.DatePicker  5   
   -   5        
  Name$
 dtpFromThisDate��5      $
��Left=�6.   $��
166,85,0,0q�6I   $	��Top=�6]   $��0��6u     5   
   -   5        $
 dtpToThisDate��5      $
��Left=�6,   $��166,128,0,0q�6G   $	��Top=�6\   $��1��6t   �� 5   
   -   5         ��Name$ lblFromThisDate��5      $��From This Date:��6)   $
��Left=�6C   $��	40,85,0,0q�6^   $	��Top=�6q   $
��Bold"�6�   $	��108��6�   ���	#FFE6CDCD6�   �� 5   
   -   5        $ lblToThisDate��5      $��To This Date:��6'   $
��Left=�6?   $��
40,126,0,0q�6Z   $	��Top=�6n   $	��108��6�   $
��Bold"�6�   
�������6�   �� 5   
   -   5        $ lblLastName��5      $��
Last Name:��6%   $
��Left=�6:   $��
40,169,0,0q�6U   $	��Top=�6i   $	��108��6�   $
��Bold"�6�   
�������6�   �� 5   
   -	   5         ��Name$ txtLastName��5      $
��Left=�6'   $��23��6B   $��166,173,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��120��6�   $
��Bold"�6�   $��2��6�   �� 5   
   -
   5        $ lblFirstName��5      $��First Name:��6&   $
��Left=�6<   $��
40,215,0,0q�6W   $	��Top=�6k   $	��108��6�   $
��Bold"�6�   
�������6�   �� 5   
   -   5        $ txtFirstName��5      $
��Left=�6(   $��23��6C   $��166,219,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   $
��Bold"�6�   $��3��6�   �� 5   
   -   5         ��Name$ cbxRoomType��5      $
��Left=�6(   $��166,254,0,0q�6C   $	��Top=�6X   $	��120��6p   $��4��6|   .@�5       �� $��One King��6   �� 5!      $��One King Deluxe��6   �� 5"      $��
Two Queens��6   �� 5#      $��Two Queen Deluxe��6   �� 5$      $��One King Suite��6   �� 5%      $!��One King Presidential Suite��6   5&      �� 5'   
   -   5        $ lblRoomType��5'      $��Select Room Type:��6%   $
��Left=�6A   $��
40,254,0,0q�6\   $	��Top=�6p   $
��Bold"�6�   ���	#FFFFFBFB6�   �� 5(   
   -   5        $ lblSystemTitle��5(      $)��#Enterprise Hotel Reservation System��6(   $��Center=�6V   $	��Top=�6s   $��34��6�   $	��342��6�   $��18.667(�6�   $
��Bold"�6�   
�������$��Center=�6�   $��325,0q�6�   �� 5)   
   -   5        $ txtRoomReport��5)      $
��Left=�6)   $	��331��6D   $��
422,95,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��468��6�   $
��Bold"�6�   ��.   �� 
IsReadOnly . .��6�   ��5*      �� 5+      $ White��6"   $		 0.9Q�60   .��5,   "   5-      �� 5.   
   -   5        $ lblRoomReport��5.      $��Room Report:��6'   $
��Left=�6>   $��
422,55,0,0q�6Y   $	��Top=�6m   $��18.667(�6�   $
��Bold"�6�   
�������$	��132��6�   $��40��6�   $��Center=�6�   �� 5/   
   -   5        $ btnGenerateReport��5/      $��Generate Report��6,   $
��Left=�6F   $��
21,332,0,0q�6a   $	��Top=�6u   $	��120��6�   $��38��6�   $��5��6�   6�   �� 50   
   -   5        $ btnClear��50      $��Clear��6#   $
��Left=�63   $��194,332,0,0q�6N   $	��Top=�6c   $	��120��6{   $��38��6�   $��6��6�   6�   52      53      