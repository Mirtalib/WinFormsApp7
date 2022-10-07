using WinFormsApp7.MOdels;
namespace WinFormsApp7.Reposidory
{
    public class FaceRepo
    {

        static public List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student(1,"avatar2.png","Leyle" , "Shefiyeva" , "Dursun" , new DateTime(2022, 10,3),ParticipationStatus.Late , null, null , null , null),
                new Student(2,null,"Mirtalib" , "Huseynzade" , "Ziya" , new DateTime(2022, 10,4),ParticipationStatus.Unknown , null, null , null , null),
                new Student(3,"avatar1.png","Ali" , "Shamilzade" , "Azer" , new DateTime(2022, 10,2),ParticipationStatus.Present , null, null , null , null),
                new Student(4,"avatar1.png","Huseyn" , "Ibrahimov" , "Allahverdi" , new DateTime(2022, 10,3),ParticipationStatus.Absent , null, null , null , null),
            };
        }

    }
}
