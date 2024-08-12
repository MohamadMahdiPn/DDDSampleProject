﻿namespace DDDSampleProject.Infrastructure.Ef.Models.UserManagement;

public class RoleReadModel : BaseReadModel
{
    public string RoleName { get; set; }
    public IReadOnlyList<UserRoleReadModel> UserRoles { get; set; }
}