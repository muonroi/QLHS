namespace EF_C_
{
    public interface Imethod_Students
    {
        public void AddListStudents(int NumberOf);
        public void EditProfileStudents(int ID);
        public void DeleteStudents(int ID);
        public void SearchStudents(int ID);
        public void ExportExcel();    

    }
}