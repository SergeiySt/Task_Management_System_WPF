create database db_task
go

use db_task
go

create table Task_table
(
	id_task_table int not null identity(1,1) primary key,
	TaskNumber int not null,
	TaskName nvarchar(50) check (TaskName <> '') not null,
	TaskDescription nvarchar(max) check (TaskDescription  <> '') not null,
	TaskStatus nvarchar(50) check (TaskStatus   <> '') not null,
	TaskDate date not null
);


insert into Task_table values
(2345, 'Купити хліб', 'Піти у магазин АТБ і купити хліба', 'Виконується', '2023-07-20'),
(2456, 'Здати тести по C#', 'Перевірка знань по C#', 'Виконується', '2023-07-25');

insert into Task_table values
(254, 'Java', 'Вивчити Java', 'Виконується', '2023-07-26');
