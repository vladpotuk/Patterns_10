class Program
{
    static void Main(string[] args)
    {
        
        UserManagementFacade userFacade = new UserManagementFacade();

        
        User newUser = new User
        {
            Username = "Vlad",
            Password = "pass123",
            Email = "potukvlad@gmail.com",
            FullName = "Potuk Vlad",
            IsActive = true
        };
        userFacade.AddUser(newUser);

        
        User existingUser = userFacade.GetUser("Vlad");
        if (existingUser != null)
        {
            existingUser.IsActive = false;
            userFacade.UpdateUser(existingUser);
        }

        
        userFacade.DeleteUser("Vlad");

        Console.ReadKey();
    }
}
