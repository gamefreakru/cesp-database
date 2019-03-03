using Centroespanol.Database.Context.Activities;
using Centroespanol.Database.Context.Activities.Models;
using Centroespanol.Database.Context.Education;
using Centroespanol.Database.Context.Education.Models;
using Centroespanol.Database.Context.Models.Press;
using Centroespanol.Database.Context.Models.Press.Models;
using Centroespanol.Database.Context.Models.Schools;
using Centroespanol.Database.Context.Payments;
using Centroespanol.Database.Context.Payments.Models;
using Centroespanol.Database.Context.Schedules;
using Centroespanol.Database.Context.Schedules.Models;
using Centroespanol.Database.Context.Users;
using Centroespanol.Database.Context.Users.Models;
using Microsoft.EntityFrameworkCore;

namespace Centroespanol.Database.Context
{
    public class CentroespanolContext: DbContext
    { 
        public CentroespanolContext(DbContextOptions<CentroespanolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CurrencyDto> Currencies { get; set; }
        public virtual DbSet<PaymentPeriodDto> PaymentPeriods { get; set; }
        public virtual DbSet<PriceDto> Prices { get; set; }

        public virtual DbSet<ScheduleDto> Schedules { get; set; }
        public virtual DbSet<ScheduleDayDto> ScheduleDays { get; set; }
        
        public virtual DbSet<FeedbackDto> Feedbacks  { get; set; }
        public virtual DbSet<UserDto> Users  { get; set; }
        
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
        }
    }
}