namespace RSRD243;

internal class OperationPriority
{
    // public bool Check(UserPermissions required)
    // {
    //     return Permissions & required == required;
    // }
    //
    // public string GetUserRole()
    // {
    //     return "Role" + Check(UserPermissions.All) ? "Admin" : "User";
    // }

    [Flags]
    public enum UserPermissions
    {
        All,
        Admin,
        User
    }

    public UserPermissions Permissions { get; set; }
}
