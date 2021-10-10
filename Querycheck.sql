--INSERT INTO dbo.Students (students.Name,students.TeacherID) values ('le anh phi',1)
--INSERT INTO dbo.Students (students.Name,students.TeacherID) values ('nguyen van a',2)
--select tc.[Name Class] from dbo.Teacher as tc join dbo.students as st 
--on tc.ID = st.TeacherID
-- delete dbo.students 
-- select count(*) from dbo.Students where [TeacherID] =  1
-- select * from Teacher 
-- SET IDENTITY_INSERT Students ON

select * from dbo.Students
-- select tc.[Name Class] from dbo.Teacher as tc 
-- join dbo.Students as st 
-- ON tc.ID = st.TeacherID 
-- where st.TeacherID = 2
--    select Count(*) as cou from dbo.Students as student INNER JOIN dbo.Teacher as tc ON student.TeacherID = tc.ID group by tc.[Name Class]
                                 
-- UPDATE dbo.Teacher SET [Number of Class] = 0 
select * from Teacher 