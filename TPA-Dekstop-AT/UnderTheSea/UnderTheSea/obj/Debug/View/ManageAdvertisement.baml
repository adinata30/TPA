   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:UnderTheSea.ViewUnderTheSea.View  5   	   *    $UnderTheSea.View.ManageAdvertisement   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:UnderTheSea.View     5   	   -   5          � Title$  ManageAdvertisement��5   	   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5
      $��
10,70,10,0q�6%   $	��Top=�69   $	��424��6Q      
IsReadOnly .    Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Update��6)      CellTemplate 5      �� 5      .R�5      ��  ��Name$ 	UpdateBtn��6%   -   5        $��	Edit Mode��5   8   6h   5      5        5      $ Delete��6)    5      �� 5      .R�5      �� $ 	DeleteBtn��6%   -   5        $��Delete��5   8   6g   5      5      5      �� 5    
   -   5        $ 	insertBtn��5       $��Insert New Advertisement��6$   $
��Left=�6G   $��	72,24,0,0q�6b   $	��Top=�6u   $	��306��6�   $��20(�6�   6�   �� 5!   
   -   5        $ 
refreshBtn��5!      $��Refresh��6%   $
��Left=�67   $��
615,24,0,0q�6R   $	��Top=�6f   $	��135��6~   $��20(�6�   6�   5#      5$      