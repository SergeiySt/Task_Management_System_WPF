   M S B A M L   `   `   `  ����Q  MTask_Management_System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Task_Management_SystemTask_Management_System  5   	   '    !Task_Management_System.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Task_Management_System     5   	     � Title$  Task Management System��5   	   $	��450��6(   $	��800��65    � WindowStartupLocation$ CenterScreen=�6A    � 
ResizeMode$ NoResize=�6f    � Icon$ /Picture/document03.ico��6|   .��5      � .+�5   
   �� -   5         ��Name$ 
buttonExit��5      $��
Вихід��6%   $��723,359,10,0q�65   $��31��6K   $	��Top=�6W   6o   �� 5   
   $��Task Management System��6   $��Center=�61   $��0,10,0,0q�6N   $	��Top=�6`   $��22(�6x   $
��Bold"�6�   ���	#FF4F60ED6�   �� 5   
   -   5         ��Name$ listBoxTasks��5      $	��277��6(   $	��Top=�65   $��
10,54,10,0q�6M   ��5      �� 5      .R�5      �� .+�5      �� $��0��6C   $��5(�6M   ��6$   �� *id_task_table+6M   �� 5      $��20(�6>   ��6$   �� *
TaskName+6>   �� 5      �� 5      $�Номер задачі: ��6    �� 5      $��16(�66   �6   �� *
TaskNumber+66   5      �� 5      $��12(�6@   ��6$   �� *
TaskStatus+6@   5      5      5       �� 5!   
   -   5        $ buttonCreate��5!      $#��Створити задачу��6'   $
��Left=�6A   $��600,359,0,0q�6\   $	��Top=�6q   $��31��6�   $	��108��6�   6�   �� 5"   
   -   5        $ buttonDelete��5"      $��Вмдалити��6'   $
��Left=�6:   $��504,359,0,0q�6U   $	��Top=�6j   $��31��6�   $��80��6�   6�   �� 5#   
   $��Пошук: ��6   $
��Left=�6"   $��
20,362,0,0q�6=   $	��Top=�6Q   �� 5$   
   -   5         ��Name$ textBoxFinde��5$      $
��Left=�6(   $��
73,366,0,0q�6C    �� TextWrapping$
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��299��6�   6�   �� 5%   
   -   5        $ buttonUpdateList��5%      $!��Оновити список��6+   $
��Left=�6D   $��388,359,0,0q�6_   $	��Top=�6t   $	��104��6�   $��31��6�   6�   5&      5'      