   M S B A M L   `   `   `  ����Q  MTask_Management_System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Task_Management_SystemTask_Management_System  5   	   %    Task_Management_System.Task_WPF   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Task_Management_System     5   	     � Title$  Опис задачі��5   	   $	��619��6   $	��435��6*    � Icon$ /Picture/document03.ico��66    � 	Resources 5	         NoSpacingParagraph �� 
TargetType �� Property �� Value��%�   &	        �� 5
   
   " J�6+   .�5      ��  �@��Margin$ 0q�6'   �� 5       �@��
LineHeight$ 1��6+   5      5      .��5      � .+�5   
   �� $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $��Номер задачі: ��6V   $	��Top=�6l   $��14(�6�   �� 5   
   -   5         ��Name$ textBoxTaskNumber��5      $��109,10,10,0q�6-    �� TextWrapping$
 Wrap=�6B   $	��Top=�6W   $��14(�6o   �� 5   
   $��Назва задачі: ��6   $
��Left=�6)   $��	11,33,0,0q�6D   $	��Top=�6W   $��14(�6o   �� 5   
   -   5        $ textBoxTaskName��5      $��109,37,10,0q�6+   $
 Wrap=�6@   $	��Top=�6U   $��14(�6m   �� 5   
   $��Опис задачі: ��6   $
��Left=�6(   $��
16,130,0,0q�6C   $	��Top=�6W   $��14(�6o   �� 5   
   -   5         ��Name$ richTextBox��5      $��11,164,10,0q�6+   $	��355��6@   $	��Top=�6M   . �5      /� .T�5      J� #��[  6   .*�6H   5      5      5      �� 5   
   -   5        	 ��Name$	 
buttonSave��5      $!��Зберегти зміни��6%   $
��Left=�6>   $��
10,535,0,0q�6Y   $	��159��6m   $��31��6y   $	��Top=�6�   6�   �� 5   
   -   5        $	 buttonClose��5      $��Закрити��6&   $��267,535,10,0q�68   $��31��6N   $	��Top=�6Z   6r   �� 5   
   $��
Дата: ��6   $
��Left=�6!   $��	57,62,0,0q�6<   $	��Top=�6O   $��14(�6g   (  "System.Windows.Controls.DatePicker  5   
   -   5        
  Name$
 
datePicker��5      $��109,64,10,0q�6)   $	��Top=�6>   �� 5    
   $��Статус:��6   $
��Left=�6"   $��	50,96,0,0q�6=   $	��Top=�6P   $��14(�6h   �� 5!   
   -   5        $ textBoxStatus��5!      $��109,100,10,0q�6)   $
 Wrap=�6?   $	��Top=�6S   $��14(�6k   5"      5#      