﻿namespace T26_02_02_HomeworkExtensionMethods
{
    public class PersonModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }

        public PersonModel(string? firstName, string? lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}