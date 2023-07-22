select * from teacher_data;
select * from student_data;
update student_data set Contact_No = 'mani rathore' where Name ='kkkkkkkkkk';
ALTER TABLE student_data
DROP COLUMN Teacher;
ALTER TABLE teacher_data
ADD Salary varchar(255);

CREATE TABLE student_data (
   id INT PRIMARY KEY IDENTITY(1,1),
   Name VARCHAR(50) NOT NULL,
   Contact_No varchar(255) not null,
   Email varchar(255) not null,
   Address varchar(255) not null,
   Gender varchar(255) not null,
   Date_Of_Birth varchar(255) not null,
   Course varchar(255) not null,
   Fees varchar(255) not null,
  
);
DROP TABLE student_data;
