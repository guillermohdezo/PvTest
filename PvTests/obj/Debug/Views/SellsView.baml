   M S B A M L   `   `   `  ����B  >PvTests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PvTests.ViewsPvTests.Views  5   	   7 clr-namespace:PvTests.ViewModelsPvTests.ViewModels  5   	       PvTests.Views.SellsView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PvTests.Views     5   	   6	viewmodel clr-namespace:PvTests.ViewModels     5   	     � Title$  Venta��5	   	   $��358.629��6   $��371.418��6(    � 	Resources 5
      &    PvTests.ViewModels.SellViewModel   sellViewModel��%   &	          5   
   6"   5      .��5      � $��0,0,14,2q�6    � DataContext# [  6   .+�5   
   �� $��Producto��6   $
��Left=�6#   $��	24,10,0,0q�6>   $	��Top=�6Q   �� 5   
   $
��Left=�6   $��	87,14,0,0q�6.   $	��Top=�6A   $	��142��6Y   ��6e   �� *ProductStringList+ �� SelectedValue 6�   �� *ProductSelected+�� 5   
   $��Cantidad��6   $
��Left=�6#   $��	24,44,0,0q�6>   $	��Top=�6Q   �� 5   
   $
��Left=�6   $��23��6-   $��	87,44,0,0q�69    �� TextWrapping$
 Wrap=�6L   $	��Top=�6z   $	��142��6�   ��6`   �� *
Quantity+6�   �� 5   
   $��Agregar��6   $
��Left=�6#   $��
245,44,0,0q�6>   $	��Top=�6R   $��75��6j   $��23��6u   ��6�   �� *AddSellCommand+�� 5   
   $��24,75,29,42q�6   ��6(   �� *
SellList+ �� View 5      �� 5      .P�5      �� $��Producto��6%    �� Width$	 130��67    �� DisplayMemberBinding 5      �� *Description+5      �� 5      $��Cantidad��5      $ 60��6%    5   %   �� *
Quantity+5   %   �� 5      $��Total��5      $	 100��6"    5   %   �� *Total+5   "   5      5      �� 5!   
   $��Pagar��6   $
��Left=�6!   $��24��6<   $��245,289,0,0q�6H   $	��Top=�6]   $��75��6u   ��6�   �� *SendSellCommand+�� 5"   
   $
��Left=�60   $��
24,290,0,0q�6K   $	��Top=�6_   $��23��6w   $	��136��6�   ��6   �� *TotalString+6�   �� 5#   
   -   5        $��Regresar��5#      $
��Left=�6$   $��
24,290,0,0q�6?   $	��Top=�6S   $��75��6k   $��23��6v   6�   5$      5%      