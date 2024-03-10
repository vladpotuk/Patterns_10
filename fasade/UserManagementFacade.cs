public class UserManagementFacade
{
    private UserManager _userManager;

    public UserManagementFacade()
    {
        _userManager = new UserManager();
    }

    public void AddUser(User user)
    {
        _userManager.AddUser(user);
    }

    public void DeleteUser(string username)
    {
        _userManager.DeleteUser(username);
    }

    public User GetUser(string username)
    {
        return _userManager.GetUser(username);
    }

    public void UpdateUser(User user)
    {
        _userManager.UpdateUser(user);
    }
}
