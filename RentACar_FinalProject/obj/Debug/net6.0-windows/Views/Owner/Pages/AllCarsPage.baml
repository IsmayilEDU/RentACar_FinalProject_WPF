   M S B A M L   `   `   `  ����P  LRentACar_FinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:RentACar_FinalProject.Views.Owner.Pages'RentACar_FinalProject.Views.Owner.Pages  5      9    3RentACar_FinalProject.Views.Owner.Pages.AllCarsPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      Alocal5clr-namespace:RentACar_FinalProject.Views.Owner.Pages  5       	  sPage#��[  5	      .��5      � 
�������  � RowDefinitions  5   
   �� 5      �� 5      $
��0.2* �6   .+�5   
   �� -   5         ��Name$ AllCarsList��5   >   $��0��5      $��0q�5   S   ��6   �� *SelectedOwner.Cars+ �� View 5      �� 5      .P�5      �� $��ID��6%    �� Width$	 185��61    �� DisplayMemberBinding 6=   �� *ID+�� 5      $
��Make��6%   $	 185��63    6?   �� *Make+�� 5      $��Model��6%   $	 185��64    6@   �� *Model+�� 5      $
��Year��6%   $	 185��63    6?   �� *Year+5      5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5!      ��   sRectangleButton#��[ 6   $��10q�6?   ��6K   �� *AddCar+.��5"      �� $ 
Horizontal=�6   .+�5#      "  FontAwesome.WPF.ImageAwesome   	 sIcon#��[ 6&      Icon$
 Plus=�6E   �� 5$        sButtonText#��[ 6    $��Add car��6E   5%      5&      �� 5(      #��[ 6   $	��250��6?   $��10q�6K   ��6W   �� *	UpdateCar+.��5)      �� $ 
Horizontal=�6   .+�5*        #��[ 6&   $ Wrench=�6E   �� 5+      #��[ 6    $��
Update car��6E   5,      5-      �� 5/      #��[ 6     
cRedButton#��[ 6@   $	��250��6i   ��6u   �� *	DeleteCar+.��50      �� $ 
Horizontal=�6   .+�51        #��[ 6&   $ Trash=�6E   �� 52      #��[ 6    $��
Delete car��6E   53      54      57      59      5:      