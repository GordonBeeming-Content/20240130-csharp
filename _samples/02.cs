var permissions = (Permissions)3;
string stringPermissions;

switch(permissions)
{
    case Permissions.Read:
        stringPermissions = "Read";
        break;
    case Permissions.Write:
        stringPermissions = "Write";
        break;
    case Permissions.Read_and_Write:
        stringPermissions = "Read and Write";
        break;
    default:
        stringPermissions = "No Access";
        break;
}

Console.WriteLine(stringPermissions);
Console.WriteLine(permissions.ToString());
Console.WriteLine((int)permissions);

public enum Permissions
{
    No_access = 0,
    Read = 1,
    Write = 2,
    Read_and_Write = 3,
}