﻿using CESP.Database.Context.Activities;
using CESP.Database.Context.Activities.Models;
using CESP.Database.Context.Education;
using CESP.Database.Context.Education.Models;
using CESP.Database.Context.Files;
using CESP.Database.Context.Payments;
using CESP.Database.Context.Payments.Models;
using CESP.Database.Context.Press;
using CESP.Database.Context.Press.Models;
using CESP.Database.Context.Schedules;
using CESP.Database.Context.Schedules.Models;
using CESP.Database.Context.Schools;
using CESP.Database.Context.Users;
using CESP.Database.Context.Users.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context
{
    public class CespContext: DbContext
    { 
        public CespContext(DbContextOptions<CespContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CurrencyDto> Currencies { get; set; }
        public virtual DbSet<PaymentPeriodDto> PaymentPeriods { get; set; }
        public virtual DbSet<PriceDto> Prices { get; set; }

        public virtual DbSet<ScheduleDto> Schedules { get; set; }
        public virtual DbSet<ScheduleDayDto> ScheduleDays { get; set; }

        public virtual DbSet<FeedbackDto> Feedbacks { get; set; }
        public virtual DbSet<FeedbackSourceDto> FeedbackSources { get; set; }
        public virtual DbSet<UserDto> Users { get; set; }

        public virtual DbSet<ActivityDto> Activities  { get; set; }
        public virtual DbSet<SpeakingClubMeetingDto> SpeakingClubMeetings  { get; set; }
        
        public virtual DbSet<CourseDto> Courses { get; set; }
        public virtual DbSet<LanguageLevelDto> LanguageLevels { get; set; }
        public virtual DbSet<StudentGroupDto> StudentGroups  { get; set; }
        public virtual DbSet<StudentGroupPriceDto> StudentGroupPrices { get; set; }
        public virtual DbSet<TeacherDto> Teachers  { get; set; }
        
        public virtual DbSet<PressDto> Presses  { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
           // modelBuilder.HasDefaultSchema("public");
           // base.OnModelCreating(modelBuilder);
            
            ActivityContextConfiguration.Configure(modelBuilder);
            EducationContextConfiguration.Configure(modelBuilder);
            PaymentsContextConfiguration.Configure(modelBuilder);
            PressContextConfiguration.Configure(modelBuilder);
            SchedulesContextConfiguration.Configure(modelBuilder);
            SchoolContextConfiguration.Configure(modelBuilder);
            UserContextConfiguration.Configure(modelBuilder);         
            FilesContextConfiguration.Configure(modelBuilder);
        }
    }
}