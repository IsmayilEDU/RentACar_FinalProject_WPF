   M S B A M L   `   `   `  ����P  LRentACar_FinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:RentACar_FinalProject.Views.Customer.Pages*RentACar_FinalProject.Views.Customer.Pages  5      <    6RentACar_FinalProject.Views.Customer.Pages.AllCarsPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      Dlocal8clr-namespace:RentACar_FinalProject.Views.Customer.Pages  5       	  sPage#��[  5	      .��5      �� -   5          ��Name$  AllCarsList��5      $
��Auto=�6$     cBackground#��[ 5      $��20q�69   
������ ��5   )   �� *	AllCars+��5   
   �� 5      .R�5      ��  �� CornerRadius$ 30��6   
�������$	��120��6B   $	��650��6O   $��10q�6[   ._�5      � $
��20 0q�6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��0��6%    �� Orientation$ 
Horizontal=�65   .+�5      �� $��Center=�6(   $
��Bold"�6C   $��25(�6V   $
��10 0q�6z   ��6d   �� *Make+6z   �� 5      $��Center=�6(   $
��Bold"�6C   $��25(�6U   $
��10 0q�6z   ��6c   �� *Model+6z   �� 5      $��Center=�6(   $
��Bold"�6C   $��25(�6U   $
��10 0q�6y   ��6c   �� *Year+6y   5       �� 5"      $��1��6%   .+�5#      �� $��25(�6)   $��Center=�6V   $��Center=�6q   ��67   �� *RentDayAmount+6q   �� 5%      $��1��6%     sRectangleButton#��[ 65   ��6_   �� *DataContext.Rent+ �� RelativeSource ��  �� AncestorType" ��.��5&   "   �� $ 
Horizontal=�6-   .+�5'   &   "  FontAwesome.WPF.ImageAwesome   	 sIcon#��[ 66      Icon$ Money=�6U   �� 5(   &     sButtonText#��[ 60   $
��Rent��6U   5)   #   5*      5+      5-      5.      50      54      55      