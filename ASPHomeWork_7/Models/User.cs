﻿namespace ASPHomeWork_7.Models;

public class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string PasswordHash { get; set; }
    public bool IsAdmin { get; set; }
}
