namespace EF_C_
{
    interface Attribute_Su
    {
       public int CheckUser(string UserName);

       public int CheckPassword(string Password);
       
       public string PasswordConverter(string Password);
    }
}