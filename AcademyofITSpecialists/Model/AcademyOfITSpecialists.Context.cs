﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcademyofITSpecialists.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AcademyofITSpecialistsEntities : DbContext
    {
        public AcademyofITSpecialistsEntities()
            : base("name=AcademyofITSpecialistsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClassTime> ClassTime { get; set; }
        public virtual DbSet<DayOfTheWeek> DayOfTheWeek { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<GroupStudent> GroupStudent { get; set; }
        public virtual DbSet<Records> Records { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserGS> UserGS { get; set; }
        public virtual DbSet<UserRecords> UserRecords { get; set; }
        public virtual DbSet<UserSchedule> UserSchedule { get; set; }
    }
}
