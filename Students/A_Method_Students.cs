using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace EF_C_
{
    public class A_Method_Students : Imethod_Students
    {
        public string ToUpCharacter(string name)
        {
            char[] names = name.ToCharArray();
            if (names.Length == 1)
                names[0] = char.ToUpper(names[0]);
            else if (names.Length > 1)
            {
                names[0] = char.ToUpper(names[0]);
                for (int i = 1; i < names.Length; i++)
                {
                    if (names[i - 1] == ' ')
                    {
                        if (char.IsLower(names[i]))
                            names[i] = char.ToUpper(names[i]);
                    }
                }
            }
            return new string(names);
        }
        public void AddListStudents(int NumberOf)
        {
            using (var dbcontext = new School_DbContext())
            {
                Students st = new();
                string temp, temp2;
                // Teacher Teacher = new() {ClassRoom = "CCQ2011C", NumberOfClass = 0};
                // Teacher Teacher2 = new() {ClassRoom = "CCQ2011D", NumberOfClass = 0};
                // dbcontext.teacher.Add(Teacher);
                // dbcontext.teacher.Add(Teacher2);
                // dbcontext.SaveChanges();
                for (int i = 0; i < NumberOf; i++)
                {
                    Console.Clear();
                    try
                    {

                        for (int k = 0; k < 5; k++)
                        {
                            Console.WriteLine("");
                        }
                        Console.Write("\t\t\t\tEnter student code: ");
                        st.StudentCode = Console.ReadLine();
                        Console.Write("\t\t\t\tEnter student name: ");
                        temp = Console.ReadLine();
                        st.Name = ToUpCharacter(temp);
                        Console.WriteLine("\t\t\t\t");
                        Console.Write("\t\t\t\tEnter student age: ");
                        st.Age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\t\t\t\t");
                        Console.Write("\t\t\t\tEnter student sex: ");
                        temp2 = Console.ReadLine();
                        st.Sex = ToUpCharacter(temp2);
                        Console.WriteLine("\t\t\t\t");
                        Console.Write("\t\t\t\tEnter teacher code: ");
                        st.TeacherID = int.Parse(Console.ReadLine());
                        Console.WriteLine("\t\t\t\t");
                        var Classrooms = (from teacher in dbcontext.teacher
                                          where st.TeacherID == Convert.ToInt32(teacher.CodeGv)
                                          select teacher.ClassRoom).FirstOrDefault();
                        st.Classroom = Convert.ToString(Classrooms);
                        Console.Write("\t\t\t\tEnter score math: ");
                        st.ScoreMath = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\t\t\t\t");
                        Console.Write("\t\t\t\tEnter score chemical: ");
                        st.ScoreChemical = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\t\t\t\t");
                        Console.Write("\t\t\t\tEnter score Physics: ");
                        st.ScorePhysics = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\t\t\t\t");
                        Console.Write("\t\t\t\tEnter PhoneNumber: ");
                        st.PhoneNumber = int.Parse(Console.ReadLine());
                        double temp3 = (st.ScoreMath + st.ScoreChemical + st.ScorePhysics) / 3;
                        st.ScoreAverage = Math.Round(temp3, 2);
                        dbcontext.students.Add(st);
                        dbcontext.SaveChanges();
                        string rawTeacher = $@"UPDATE dbo.Teacher SET [Number of Class] = [Number of Class] + 1 where [ID] = {st.TeacherID}";
                        var cmd = dbcontext.teacher.FromSqlRaw(rawTeacher);
                        dbcontext.Database.ExecuteSqlRaw(rawTeacher);
                        dbcontext.Database.CloseConnection();
                    }
                    catch (Exception er)
                    {
                        Console.Clear();
                        for (int j = 0; j < 5; j++)
                        {
                            Console.WriteLine("");
                        }
                        Console.WriteLine("\t\t\t\t{0}", er.Message);
                    }
                }

            }
        }
        public void EditProfileStudents(int ID)
        {
            
            using (var dbcontext = new School_DbContext())
            {
                Students st = new();
                string temp, temp2;
                var temp_ = from _temp in dbcontext.students
                            where _temp.StudentCode == Convert.ToString(ID)
                            select new
                            {
                                Name = _temp.Name,
                                Age = _temp.Age,
                                Sex = _temp.Sex,
                                Math = _temp.ScoreMath,
                                Chemical = _temp.ScoreChemical,
                                Physics = _temp.ScorePhysics,
                                PhoneNumber = _temp.PhoneNumber,
                                TeacherID = _temp.TeacherID,
                            };
               
                Console.Clear();
                try
                {

                    for (int k = 0; k < 5; k++)
                    {
                        Console.WriteLine("");
                    }
                    st.StudentCode = Convert.ToString(ID);
                    Console.Write("\t\t\t\tPress 0 when you want keep default value! ");
                    Console.WriteLine("\t\t\t\t");
                    Console.Write("\t\t\t\tEnter student name: ");
                    temp = Console.ReadLine();
                    st.Name = ToUpCharacter(temp);
                    Console.WriteLine("\t\t\t\t");
                    Console.Write("\t\t\t\tEnter student age: ");
                    st.Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\t\t\t\t");
                    Console.Write("\t\t\t\tEnter student sex: ");
                    temp2 = Console.ReadLine();
                    st.Sex = ToUpCharacter(temp2);
                    Console.WriteLine("\t\t\t\t");
                    Console.Write("\t\t\t\tEnter teacher code: ");
                    st.TeacherID = int.Parse(Console.ReadLine());
                    Console.WriteLine("\t\t\t\t");
                    var Classrooms = (from teacher in dbcontext.teacher
                                      where st.TeacherID == Convert.ToInt32(teacher.CodeGv)
                                      select teacher.ClassRoom).FirstOrDefault();
                    st.Classroom = Convert.ToString(Classrooms);
                    Console.Write("\t\t\t\tEnter score math: ");
                    st.ScoreMath = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\t\t\t\t");
                    Console.Write("\t\t\t\tEnter score chemical: ");
                    st.ScoreChemical = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\t\t\t\t");
                    Console.Write("\t\t\t\tEnter score Physics: ");
                    st.ScorePhysics = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\t\t\t\t");
                    Console.Write("\t\t\t\tEnter PhoneNumber: ");
                    st.PhoneNumber = int.Parse(Console.ReadLine());
                    double temp3 = (st.ScoreMath + st.ScoreChemical + st.ScorePhysics) / 3;
                    st.ScoreAverage = Math.Round(temp3, 2);
                    foreach (var item in temp_)
                    {
                        //set value deafault if input 0 number
                        if (st.Name == "0")
                            st.Name = item.Name;
                        if (st.Age == 0)
                            st.Age = item.Age;
                        if (st.Sex == "0")
                            st.Sex = item.Sex;
                        if (st.TeacherID == 0)
                            st.TeacherID = item.TeacherID;
                        else if (st.TeacherID != 0 && st.TeacherID != item.TeacherID)
                        {
                                string Teacher_ = $@"UPDATE dbo.Teacher SET [Number of Class] = [Number of Class] - 1 where [ID] = {item.TeacherID}";
                                var command = dbcontext.teacher.FromSqlRaw(Teacher_);
                                dbcontext.Database.ExecuteSqlRaw(Teacher_);
                               
                        }
                        
                        if (st.ScoreMath == 0)
                            st.ScoreMath = item.Math;
                        if (st.ScoreChemical == 0)
                            st.ScoreChemical = item.Chemical;
                        if (st.ScorePhysics == 0)
                            st.ScorePhysics = item.Physics;
                        if (st.PhoneNumber == 0)
                            st.PhoneNumber = item.PhoneNumber;
                    }
                        dbcontext.students.Update(st);
                        dbcontext.SaveChanges();
                        string rawTeacher = $@"UPDATE dbo.Teacher SET [Number of Class] = [Number of Class] + 1 where [ID] = {st.TeacherID}";
                        var cmd = dbcontext.teacher.FromSqlRaw(rawTeacher);
                        dbcontext.Database.ExecuteSqlRaw(rawTeacher);
                        Console.Clear();
                        for (int k = 0; k < 5; k++)
                        {
                            Console.WriteLine("");
                        }
                        Console.WriteLine($"\t\t\t\t\tEdit profile student success!");
                }
                catch (Exception er)
                {
                    Console.Clear();
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine("");
                    }
                    Console.WriteLine("\t\t\t\t{0}", er.Message);
                }

            }

        }
        public void DeleteStudents(int ID)
        {
            using (var dbcontext = new School_DbContext())
            {
                var idst = ((from sto in dbcontext.students 
                           where  sto.StudentCode == Convert.ToString(ID)
                           select sto.StudentCode).ToList()).FirstOrDefault();  
                var idteacher = ((from sto in dbcontext.students 
                           where  sto.StudentCode == Convert.ToString(ID)
                           select sto.TeacherID).ToList()).FirstOrDefault();  
                var studentsid = new Students() {StudentCode = idst}; 
                dbcontext.Entry(studentsid).State = EntityState.Deleted;
                dbcontext.SaveChanges();
                Console.WriteLine($"Deleted success!");
               string Teacher_ = $@"UPDATE dbo.Teacher SET [Number of Class] = [Number of Class] - 1 where [ID] = {idteacher}";
                                var command = dbcontext.teacher.FromSqlRaw(Teacher_);
                                dbcontext.Database.ExecuteSqlRaw(Teacher_);
            }
        }
        public string SearchStudents(int ID)
        {
            using (var dbcontext = new School_DbContext())
            {
                
            }
            return "";
        }
        public void ExportExcel()
        {

        }
    }
}
