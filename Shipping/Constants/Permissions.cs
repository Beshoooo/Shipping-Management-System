﻿using NuGet.Packaging;

namespace Shipping.Constants
{
    public static class Permissions
    {
        public static List<string> GeneratePermissionList(String module)
        {

            return new List<string>()
            {
                $"Permissions.{module}.View",
                $"Permissions.{module}.Create",
                $"Permissions.{module}.Edit",
                $"Permissions.{module}.Delete",
            };

        }
        public static List<string> GenerateAllPermissions()
        {

            var allPermissions = new List<string>();
            var modules = Enum.GetValues(typeof(Modules));
            foreach (var module in modules)
            {
                allPermissions.AddRange(GeneratePermissionList(module.ToString()));
            }

            return allPermissions;
        }

        ////////////////////////////////////// Calls /////////////////////////////////////////
        public static class Controls
        {
            public const string View = "Permissions.Controls.View";
            public const string Create = "Permissions.Controls.Create";
            public const string Edit = "Permissions.Controls.Edit";
            public const string Delete = "Permissions.Controls.Delete";
        }
        public static class Merchants
        {
            public const string View = "Permissions.Merchants.View";
            public const string Create = "Permissions.Merchants.Create";
            public const string Edit = "Permissions.Merchants.Edit";
            public const string Delete = "Permissions.Merchants.Delete";
        }
        public static class Representative
        {
            public const string View = "Permissions.Representative.View";
            public const string Create = "Permissions.Representative.Create";
            public const string Edit = "Permissions.Representative.Edit";
            public const string Delete = "Permissions.Representative.Delete";
        }
        public static class Employees
        {
            public const string View = "Permissions.Employees.View";
            public const string Create = "Permissions.Employees.Create";
            public const string Edit = "Permissions.Employees.Edit";
            public const string Delete = "Permissions.Employees.Delete";
        }

    }
}