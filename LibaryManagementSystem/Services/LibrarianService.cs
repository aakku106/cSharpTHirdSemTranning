namespace LibaryManagementSystem.Services
{
    public class Librarian
    {
        public string LibrarianId = "user";
        public string LibrarianPassword = "@123";
        public static List<Librarian> users = new List<Librarian>()
        {
            new Librarian()
            {
                LibrarianId = "admin",
                LibrarianPassword = "@123",
            }};
    }
}