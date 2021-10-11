namespace EF_C_
{
    public interface Imethod_Students
    {
        public string ToUpCharacter(string name);
        public void AddListStudents(int NumberOf);
        public void EditProfileStudents(int ID);
        public void DeleteStudents(int ID);
        public string SearchStudents(int ID);
        public void ExportExcel();    

    }
}