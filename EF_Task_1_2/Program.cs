//1.Curators

//■ Identifier(Id).Unique identifier of the curator.
//▷ Data type is int.
//▷ Auto increment.
//▷ Cannot contain null values.
//▷ Primary key.

//■ Name. Name of the curator.
//▷ Data type is nvarchar(max).
//▷ Cannot contain null values.
//▷ Cannot be empty.

//■ Surname. Surname of the curator.
//▷ Data type is nvarchar(max).
//▷ Cannot contain null values.
//▷ Cannot be empty

//--------------------------------------------

//2.Departments

//■ Identifier(Id).Unique identifier of the department.
//▷ Data type is int.
//▷ Auto increment.
//▷ Cannot contain null values.
//▷ Primary key.

//■ Building. Number of the building in which the department 
//is located.
//▷ Data type is int.
//▷ Cannot contain null values.
//▷ Must be in the range from 1 to 5.

//■ Financing. Financing fund of the department.
//▷ Data type is money.
//▷ Cannot contain null values.
//▷ Cannot be less than 0.
//▷ Default value is 0.

//■ Name. Name of the department.
//▷ Data type is nvarchar(100).
//▷ Cannot contain null values.
//▷ Cannot be empty.
//▷ Must be unique.

//■ Faculty identifier (FacultyId). Faculty, which includes the department.
//▷ Data type is int.
//▷ Cannot contain null values.
//▷ Foreign key.

//--------------------------------------------

//3.Faculties

//■ Identifier(Id).Unique identifier of the faculty.
//▷ Data type is int.
//▷ Auto increment.
//▷ Cannot contain null values.
//▷ Primary key.

//■ Name. Faculty name.
//▷ Data type is nvarchar(100).
//▷ Cannot contain null values.
//▷ Cannot be empty.
//▷ Must be unique.

//--------------------------------------------

//4.Groups(Groups)

//■ Identifier(Id).Unique identifier of the group.
//▷ Data type is int.
//▷ Auto increment.
//▷ Cannot contain null values.
//▷ Primary key.

//■ Name. Group name.
//▷ Data type is nvarchar(10).
//▷ Cannot contain null values.
//▷ Cannot be empty.
//▷ Must be unique.

//■ Year. Year in which the group studies.
//▷ Data type is int.
//▷ Cannot contain null values.
//▷ Must be in the range from 1 to 5.

//■ Department identifier (DepartmentId). Department, which 
//includes the group.
//▷ Data type is int.
//▷ Cannot contain null values.
//▷ Foreign key

//--------------------------------------------

//5.Groups and curators(GroupsCurators)

//■ Identifier(Id).Unique identifier of the group and curator.
//▷ Data type is int.
//▷ Auto increment.
//▷ Cannot contain null values.
//▷ Primary key.

//■ Curator identifier (CuratorId). Curator.
//▷ Data type is int.
//▷ Cannot contain null values.
//▷ Foreign key.

//■ Group identifier (GroupId). Group.
//▷ Data type is int.
//▷ Cannot contain null values.
//▷ Foreign key.

//--------------------------------------------

//8.Lectures

//■ Identifier(Id).Unique identifier of the lecture.
//▷ Data type is int.
//▷ Auto increment.
//▷ Cannot contain null values.
//▷ Primary key.

//■ Date of the lecture. Date of the lecture.
//▷ Data type is date.
//▷ Cannot contain null values.
//▷ Cannot be greater than the current date.

//■ Subject identifier (SubjectId). Subject in which the lecture is 
//delivered.
//▷ Data type is int.
//▷ Cannot contain null values.
//▷ Foreign key.

//■ Teacher identifier (TeacherId). Teacher who delivers a lecture.
//▷ Data type is int.
//▷ Cannot contain null values.
//▷ Foreign key.

//--------------------------------------------

//7.Groups and students(GroupsStudents)

//■ Identifier(Id).Unique identifier of the group and students.
//▷ Data type is int.
//▷ Auto increment.
//▷ Cannot contain null values.
//▷ Primary key.

//■ Group identifier (GroupId). Group.
//▷ Data type is int.
//▷ Cannot contain null values.
//▷ Foreign key.

//■ Student identifier (StudentId). Student.
//▷ Data type is int.
//▷ Cannot contain null values.
//▷ Foreign key.

//--------------------------------------------

//8.Lectures

//■ Identifier(Id).Unique identifier of the lecture.
//▷ Data type is int.
//▷ Auto increment.
//▷ Cannot contain null values.
//▷ Primary key.

//■ Date of the lecture. Date of the lecture.
//▷ Data type is date.
//▷ Cannot contain null values.
//▷ Cannot be greater than the current date.

//■ Subject identifier (SubjectId). Subject in which the lecture is 
//delivered.
//▷ Data type is int.
//▷ Cannot contain null values.
//▷ Foreign key.

//■ Teacher identifier (TeacherId). Teacher who delivers a lecture.
//▷ Data type is int.
//▷ Cannot contain null values.
//▷ Foreign key.

//--------------------------------------------

//9.Students

//■ Identifier(Id).Unique identifier of the student.
//▷ Data type is int.
//▷ Auto increment.
//▷ Cannot contain null values.
//▷ Primary key.

//■ Name. Name of the student.
//▷ Data type is nvarchar(max).
//▷ Cannot contain null values.
//▷ Cannot be empty.

//■ Rating. Rating of the student.
//▷ Data type is int.
//▷ Cannot contain null values.
//▷ Must be between 0 and 5.

//■ Surname. Surname of the student.
//▷ Data type is nvarchar(max).
//▷ Cannot contain null values.
//▷ Cannot be empty

//--------------------------------------------

//10.Subjects

//■ Identifier(Id).Unique identifier of the subject.
//▷ Data type is int.
//▷ Auto increment.
//▷ Cannot contain null values.
//▷ Primary key.

//■ Name. The name of the discipline.
//▷ The data type is nvarchar (100).
//▷ Cannot contain null values.
//▷ Cannot be empty.
//▷ Must be unique.

//--------------------------------------------

//11.Teachers

//■ Identifier(Id).The unique identifier of the teacher.
//▷ The data type is int.
//▷ Auto increment.
//▷ Cannot contain null values.
//▷ Primary key.

//■ Professor (IsProfessor). Is the professor professor.
//▷ The data type is bit.
//▷ Cannot contain null values.
//▷ The default value is 0.

//■ Name. The name of the teacher.
//▷ The data type is nvarchar(max).
//▷ Cannot contain null values.
//▷ Cannot be empty.

//■ The rate (Salary). The teacher's rate.
//▷ The data type is money.
//▷ Cannot contain null values.
//▷ Cannot be less than or equal to 0.

//■ Surname. Name of the teacher.
//▷ The data type is nvarchar(max).
//▷ Cannot contain null values.
//▷ Cannot be empty

//--------------------------------------------

Console.WriteLine("Hello");