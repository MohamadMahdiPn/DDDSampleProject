﻿namespace DDDSampleProject.Application.Dtos;

public class UserDto
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public bool IsConfirmed { get; set; }


}