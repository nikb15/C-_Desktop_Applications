   M S B A M L   `   `   `  ����N  JEmployeeManager.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:EmployeeManager.Wpf.ControlsEmployeeManager.Wpf.Controls  5   	   $    EmployeeManager.Wpf.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?controls*clr-namespace:EmployeeManager.Wpf.Controls     5   	     � Title$  
MainWindow��5   	   $	��550��6   $	��800��6)   $��18(�65   .��5	      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5&      �� 
��� ���$��2��6!   ._�5'   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�6.   .+�5(      �� $��/Images/logo.png��5)      $��90��5*      $��5q�5+      �� 5,      $��WPF ALLPLICATION ��6   $��40(�5-      5/      50      � 54   
   $��1��6    55      �� 56      $
��Auto �6    �� 57      $��* �6    .+�59      �� $��Refresh��6   $��10q�5:      ��5;      �� *LoadCommand+ �� Mode$ OneWay=��� 5=      $��1��6    �� DisplayMemberPath$ 	FirstName��5@      ��5>      �� *	Employees+$ OneWay=� �� SelectedItem 5?      �� *SelectedEmployee+$ TwoWay=�5@      5A      � 5D   
   $��1��6   $��1��6   y�5E      �� *isEmployeSelected+$ OneWay=�    BooleanToVisibilityConverter �� 	Converter# [   5I      �� 5J      $
��Auto �6    �� 5K      $
��Auto �6    �� 5L      $
��Auto �6    �� 5M      $
��Auto �6    �� 5N      $
��Auto �6    �� 5O      $
��Auto �6    �� 5P      $
��Auto �6    �� 5Q      $
��Auto �6    �� 5R      $
��Auto �6    .+�5W      �� $��10 10 10 0 q�6   
First NAme69   �� 5X      $��1��5Y      $��10q�5Z      ��5[      �� *SelectedEmployee.FirstName+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5]      $��2��6   $��
10 10 10 0q�6%   Entry Datey6F   (  "System.Windows.Controls.DatePicker  5^      $��3��5_      $��10q�5`      	   SelectedDate	 5a      �� * SelectedEmployee.EntryDateTime+$ TwoWay=��� 5c      $��4��6   $��
10 10 10 0q�6%   
Job Role6C   �� 5d      $��5��5e      $��10q�5f      $��Stretch=�5g      $ RoleName��5i      
 �� SelectedValuePath$
 Id��5j      ��5h      �� *
JobRoles+$ OneTime=� �� SelectedValue 5k      �� *SelectedEmployee.JobRoleId+$ TwoWay=��� 5m      $��6��5n      $��Is Coffee Drinker ?��5o      $��10q�5p       d� 	IsChecked 5q      �� *" SelectedEmployee.IsCoffeeDrinker+$ TwoWay=��� 5s      $��7��5t      $
��Save��5u      $��10 10 10 30q�5v      $��Bottom=�5w      $
��Left=�5x      ��5y      �� *SelectedEmployee.SaveCommand+$ OneWay=�5}      5~      5      