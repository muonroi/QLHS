--INSERT INTO dbo.Students (students.Name,students.TeacherID) values ('le anh phi',1)
--INSERT INTO dbo.Students (students.Name,students.TeacherID) values ('nguyen van a',2)
--select tc.[Name Class] from dbo.Teacher as tc join dbo.students as st 
--on tc.ID = st.TeacherID
--delete dbo.students 
select * from dbo.Students
-- select tc.[Name Class] from dbo.Teacher as tc 
-- join dbo.Students as st 
-- ON tc.ID = st.TeacherID 
-- where st.TeacherID = 2