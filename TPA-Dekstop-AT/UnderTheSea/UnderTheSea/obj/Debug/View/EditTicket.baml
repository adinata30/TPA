   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:UnderTheSea.ViewUnderTheSea.View  5   	   !    UnderTheSea.View.EditTicket   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:UnderTheSea.View     5   	   -   5          � Title$  
EditTicket��5   	   .��5	      �  � ColumnDefinitions 5
   
   .+�5   
   �� -   5         ��Name$ label��5      $��Ticket Type��6   $
��Left=�65   $��22.5,78,0,0q�6P   $	��Top=�6e   $��40(�6}   $��2��6�   �� 5   
   -   5        $ 
label_Copy��5      $��Ticket Price��6$   $
��Left=�6;   $��22.5,146,0,0q�6V   $	��Top=�6l   $��40(�6�   $��2��6�   �� 5   
   -   5        $ label_Copy1��5      $��Ticket Date��6%   $
��Left=�6;   $��22.5,214,0,0q�6V   $	��Top=�6l   $��40(�6�   $��2��6�   �� 5   
   -   5        $ label_Copy2��5      $��	Ticket ID��6%   $
��Left=�69   $��22.5,10,0,0q�6T   $	��Top=�6i   $��40(�6�   $��2��6�   �� 5   
   -   5        $ label_Copy3��5      $��Ticket Status��6%   $
��Left=�6=   $��22.5,277,0,0q�6X   $	��Top=�6n   $��40(�6�   $��2��6�   �� 5   
   -   5         ��Name$ 	updateBtn��5      $��Update Ticket��6$   $
��Left=�6<   $��334.5,397,0,0q�6W   $	��Top=�6n   $	��278��6�   $��40(�6�   $��2��6�   �� 5   
   -   5        $ id��5      $��Label��6   $
��Left=�6,   $��408.5,13,0,0q�6G   $	��Top=�6]   $��40(�6u   $	��254��6�   $��2��6�   �� 5   
   -	   5        $ price��5      $��Label��6   $
��Left=�6/   $��408.5,146,0,0q�6J   $	��Top=�6a   $��40(�6y   $	��254��6�   $��2��6�   �� 5   
   -
   5        $
 date��5      $��Label��6   $
��Left=�6.   $��408.5,214,0,0q�6I   $	��Top=�6`   $��40(�6x   $	��254��6�   $��2��6�   �� 5   
   -   5        $ status��5      $��Label��6    $
��Left=�60   $��408.5,277,0,0q�6K   $	��Top=�6b   $��40(�6z   $	��254��6�   $��2��6�   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6%   $��
408,81,0,0q�6@   $	��Top=�6T   $	��342��6l   $��60��6x    �� SelectedIndex$ 0��6�   $��40(�6�   .@�5      �� $	��Kid��6   $��40(�6)   �� 5      $��Adult��6   $��40(�6+   �� 5      $��Elder��6   $��40(�6+   5      5      5      