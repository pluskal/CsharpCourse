﻿using System;

namespace Sample.DAL.Entities
{
    public class StudentEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
    }
}