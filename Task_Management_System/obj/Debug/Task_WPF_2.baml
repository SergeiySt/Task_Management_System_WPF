   M S B A M L   `   `   `  ����Q  MTask_Management_System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Task_Management_SystemTask_Management_System  5   	   '    !Task_Management_System.Task_WPF_2   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Task_Management_System     5   	     � Title$%  Створення задачі��5   
   $	��619��6#   $	��435��60    � Icon$ /Picture/document03.ico��6<    � WindowStartupLocation$ CenterScreen=�6[    � 
ResizeMode$ NoResize=�6�    � 	Resources 5	         NoSpacingParagraph �� 
TargetType �� Property �� Value��%�   &	        �� 5
   
   " J�6+   .�5      ��  �@��Margin$ 0q�6'   �� 5       �@��
LineHeight$ 1��6+   5      5      .��5      � .+�5   
   �� $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $��Номер задачі: ��6V   $	��Top=�6l   $��14(�6�   �� 5   
   -   5         ��Name$ textBoxTaskNumber2��5      $��109,10,10,0q�6.   	 �� TextWrapping$
	 Wrap=�6C   $	��Top=�6X   $��14(�6p   �� 5   
   $��Назва задачі: ��6   $
��Left=�6)   $��	11,33,0,0q�6D   $	��Top=�6W   $��14(�6o   �� 5   
   -   5        $ textBoxTaskName2��5      $��109,37,10,0q�6,   $
	 Wrap=�6A   $	��Top=�6V   $��14(�6n   �� 5   
   $��Опис задачі: ��6   $
��Left=�6(   $��
16,130,0,0q�6C   $	��Top=�6W   $��14(�6o   �� 5   
   -   5        
 ��Name$
 richTextBox2��5      $��11,164,10,0q�6,   $	��355��6A   $	��Top=�6N   . �5      /� .T�5      J� #��[  6   .*�6H   5      5      5      �� 5   
   -   5         ��Name$ 	buttonAdd��5      $��Додати��6$   $
��Left=�65   $��
10,535,0,0q�6P   $	��159��6d   $��31��6p   $	��Top=�6|   6�   �� 5   
   -   5        $ buttonClose��5      $��Закрити��6&   $��267,535,10,0q�68   $��31��6N   $	��Top=�6Z   6r   �� 5   
   $��
Дата: ��6   $
��Left=�6!   $��	57,62,0,0q�6<   $	��Top=�6O   $��14(�6g   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ datePicker2��5      $��109,64,10,0q�6*   $	��Top=�6?   �� 5    
   $��Статус:��6   $
��Left=�6"   $��	50,96,0,0q�6=   $	��Top=�6P   $��14(�6h   �� 5!   
   -   5        $ textBoxStatus2��5!      $��109,100,10,0q�6*   $
	 Wrap=�6@   $	��Top=�6T   $��14(�6l   5"      5#      