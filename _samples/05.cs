var permissions = Enum.GetValuesAsUnderlyingType<Permissions>();

foreach(var permission in permissions)
{
    Console.WriteLine(permission);
    Console.WriteLine(permission.GetType());
}


public enum Permissions : byte
{
    No_access = 0,
    Read = 1,
    Write = 2,
    Read_and_Write = 3,
}