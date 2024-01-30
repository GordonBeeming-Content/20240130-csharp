var permissions = Enum.GetValues<Permissions>()
                    .Select(o=> new { Name = o.ToString().Replace("_"," "), Value = (int)o });

foreach(var permission in permissions)
{
    Console.WriteLine(permission);
}

public enum Permissions
{
    No_access = 0,
    Read = 1,
    Write = 2,
    Read_and_Write = 3,
}