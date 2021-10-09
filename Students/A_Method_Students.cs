using System;
using System.Linq;
namespace EF_C_
{
    public abstract class A_Method_Students : Imethod_Students
    {
        public string ToUpCharacter(string name)
        {
            char[] names = name.ToCharArray();
            if(names.Length == 1)
                names[0] = char.ToUpper(names[0]);
            else if( names.Length > 1)
            {
                names[0] = char.ToUpper(names[0]);
                for (int i = 1; i < names.Length; i++)
                {
                    if (names[i - 1] == ' ')
                    {
                        if(char.IsLower(names[i]))
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
                string temp,temp2;
                // Teacher Teacher = new() {ClassRoom = "CCQ2011C", NumberOfClass = 39};
                // Teacher Teacher2 = new() {ClassRoom = "CCQ2011D", NumberOfClass = 40};
                // dbcontext.teacher.Add(Teacher);
                // dbcontext.teacher.Add(Teacher2);
                // dbcontext.SaveChanges();
                for (int i = 0; i < NumberOf; i++)
                {
                    Console.Clear();
                    try
                    {
                        Students st = new();
                        for (int k = 0; k < 5; k++)
                        {
                            Console.WriteLine("");
                        }
                        Console.Write("\t\t\t\tEnter student code: ");
                        st.StudentCode = Convert.ToInt32(Console.ReadLine());
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
                        var Classrooms = (from teacher in dbcontext.teacher where
                                         st.TeacherID == Convert.ToInt32(teacher.CodeGv) 
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
                        dbcontext.students.Add(st);
                        dbcontext.SaveChanges();
                        Console.WriteLine($"Add {NumberOf} succeeded!");
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        for (int j = 0; j < 5; j++)
                        {
                            Console.WriteLine("");
                        }
                        Console.WriteLine("\t\t\t\t Error while adding student!");
                    }
                }
            }
        }
        public void EditProfileStudents(int ID)
        {

        }
        public void DeleteStudents(int ID)
        {

        }
        public string SearchStudents(int ID)
        {
            return "";
        }
        public void ViewProfile(int ID)
        {

        }
        public void ExportExcel()
        {

        }
    }
}
