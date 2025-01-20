using LibaryManagementSystem.Services;

namespace LibaryManagementSystem.Data
{
    public class StudentList()
    {

        public List<Students> student = new List<Students>(){
            new Students(){
                Id="AF10",
                Name="ccn",
                Class=null,
                Address="ccn-106, Konoha",
                Password="ccn"
            },
             new Students(){
                Id="106",
                Name="AAKKU",
                Class=10,
                Address="your-Heart-106",
                Password="!)^"
            }
        };

    }




}