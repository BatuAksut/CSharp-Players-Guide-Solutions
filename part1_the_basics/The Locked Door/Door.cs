public class Door
{
    public bool IsLocked { get; set; }
    public bool IsOpen { get; set; }
    public int Password { get; set; }

    public Door(int passcode)
    {
        Password = passcode;
        IsLocked = true;
        IsOpen = false;
    }

    public void ChangePassword(int currentPassword, int newPassword)
    {
        if (currentPassword == Password)
        {
            Password = newPassword;
            Console.WriteLine("Password changed successfully");
        }
        else
        {
            Console.WriteLine("Wrong password");
        }
    }

    public void Lock()
    {
        if (!IsLocked && !IsOpen)
        {
            IsLocked = true;
            Console.WriteLine("Door is locked");
        }
        else if (IsOpen)
        {
            Console.WriteLine("Door should be closed first");
        }
        else if (IsLocked)
        {
            Console.WriteLine("Door is already locked");
        }
    }

    public void Unlock(int pass)
    {
        if (IsLocked && !IsOpen && pass == Password)
        {
            IsLocked = false;
            Console.WriteLine("Door is unlocked");
        }
        else if (IsOpen)
        {
            Console.WriteLine("Door should be closed first");
        }
        else if (!IsLocked)
        {
            Console.WriteLine("Door is already unlocked");
        }
    }

    public void Close()
    {
        if (!IsLocked && IsOpen)
        {
            IsOpen = false;
            Console.WriteLine("Door is closed");
        }
        else if (!IsOpen)
        {
            Console.WriteLine("Door is already closed");
        }
        else if (IsLocked)
        {
            Console.WriteLine("Door is locked");
        }
    }

    public void Open()
    {
        if (!IsLocked && !IsOpen)
        {
            IsOpen = true;
            Console.WriteLine("Door is open");
        }
        else if (IsOpen)
        {
            Console.WriteLine("Door is already open");
        }
        else if (IsLocked)
        {
            Console.WriteLine("Door is locked");
        }
    }
}
