var permission = Permissions.Read | Permissions.Write;

Console.WriteLine(permission.HasFlag(Permissions.Read_and_Write));

[Flags]
public enum Permissions : byte
{
    No_access = 0,
    Read = 1,
    Write = 2,
    Read_and_Write = 3,
}