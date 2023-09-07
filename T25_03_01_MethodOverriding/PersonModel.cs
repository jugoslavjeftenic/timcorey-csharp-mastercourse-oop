﻿namespace T25_03_01_MethodOverriding
{
    public class PersonModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}