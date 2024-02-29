﻿using Microsoft.AspNetCore.Authorization;

namespace MenuManagement.Authorization
{
    public class PermissionRequirement : IAuthorizationRequirement
    {
        public PermissionRequirement(string permission)
        {
            Permission = permission;

        }

        public string Permission { get; }
    }
}
