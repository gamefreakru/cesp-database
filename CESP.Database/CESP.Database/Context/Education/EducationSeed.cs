using CESP.Database.Context.Education.Models;
using Microsoft.EntityFrameworkCore;

namespace Centroespanol.Database.Context.Education
{
    public static class EducationSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            SeedLanguageLevelsTable(modelBuilder);
            SeedTeachersTable(modelBuilder);
        }

        private static void SeedTeachersTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherDto>()
                .HasData(new TeacherDto
                {
                    Id = 1,
                    Name = "Йосу",
                    Post = "преподаватель",
                    Info =
                        "Йосу — преподаватель-носитель испанского языка из Барселоны с большим опытом работы. Имеет международный сертификат ELE для преподавания испанского как иностранного (от International House Barcelona, утвержденным Университетом Барселоны). Кроме того Йосу является дипломированным экзаменатором экзамена DELE, это значит что он может как принимать экзамен, так и подготавливать студентов для сдачи DELE. И конечно, имеет сертификат, подтверждающий квалификацию преподавателя от Института Сервантеса г. Москвы. Работает как со взрослыми, так и с детьми у которых всегда имеет особенный успех. Уроки проходят в дружественной, неформальной обстановке, что способствует эффективному и быстрому усвоению материала. Владеет русским языком.",
                    PhotoId = 1,
                });
            modelBuilder.Entity<TeacherDto>()
                .HasData(new TeacherDto
                {
                    Id = 2,
                    Name = "Анхель",
                    Post = "преподаватель",
                    Info =
                        "Анхель – опытный преподаватель испанского языка из Малаги. Позитивный, открытый и добрый. На уроках любит разложить все объяснения по полочкам, что облегчает процесс усвоения материала. В Москве преподаёт испанский с 2012 прекрасно ладит как со взрослыми, так и с детьми, готовит свои уроки индивидуально, с учетом потребностей, интересов и особенностей каждой группы, но конечно в рамках Международного стандарта преподавания испанского языка иностранцам. Увлекается классической музыкой. Прекрасно владеет русским языком.",
                    PhotoId = 2,
                });
            modelBuilder.Entity<TeacherDto>()
                .HasData(new TeacherDto
                {
                    Id = 3,
                    Name = "Рафаэль",
                    Post = "преподаватель",
                    Info =
                        "Рафаэль - преподаватель-носитель испанского и каталанского языков из Барселоны. В Россию приехал в 2013 году, до этого жил и работал в Англии. Имеет сертификаты Института Сервантеса о специальной подготовке преподавателей которые дают право преподавать язык иностранным студентам. Открытый, жизнерадостный и общительный. Ему нравится путешествовать, познавать новые культуры и обмениваться своим опытом с другими людьми. Творчески подходит к подготовке своих уроков испанского и каталанского и поэтому его занятия всегда динамичные и интересные. На своих уроках он использует коммуникативную методику, соответствующую международным стандартам. На занятиях у Рафаэля при погружении в языковую среду студент с первых уроков начинает говорить на испанском языке. Прекрасно ладит как со взрослыми, так и с детьми и подростками. Владеет русским языком.",
                    PhotoId = 3,
                });
            modelBuilder.Entity<TeacherDto>()
                .HasData(new TeacherDto
                {
                    Id = 4,
                    Name = "Альберто",
                    Post = "преподаватель",
                    Info =
                        "Альберто преподаватель-носитель испанского языка, родился в Гранаде. Имеет обширный опыт преподавания испанского языка для иностранцев, как в Испании так и в России. На занятиях с Альберто всегда интересно и весело. Студенты активно вовлечены в учебный процесс. Альберто знает древние языки, такие как: латинский и греческий, что позволяет ему давать более глубокий материал по испанскому языку. Так же свободно владеет русским языком.",
                    PhotoId = 4,
                });

            modelBuilder.Entity<TeacherDto>()
                .HasData(new TeacherDto
                {
                    Id = 5,
                    Name = "Хулио",
                    Post = "преподаватель",
                    Info =
                        "Хулио - квалифицированный преподаватель испанского языка, преподает испанский в общей сложности около 9 лет. Аккредитован как преподаватель ELE (испанский язык, как иностранный) в International House Madrid, а также Институтом Сервантеса в Москве. Хулио является аккредитованным экзаменатором экзамена DELE для уровней от А1 до B2 и в совершенстве владеет коммуникативной методикой преподавания языка. Всегда уделяет внимание каждому студенту, занятия проходят в дружеской обстановке.",
                    PhotoId = 5,
                });
            modelBuilder.Entity<TeacherDto>()
                .HasData(new TeacherDto
                {
                    Id = 6,
                    Name = "Алехо",
                    Post = "преподаватель",
                    Info =
                        "Алехо - преподаватель испанского языка с более чем девятилетним опытом работы. Он отлично понимает потребности и трудности своих учеников, так как сам учился русскому, английскому, французскому и португальскому языкам, и знает все \"подводные камни\" при изучении иностранных языков и, несомненно, поможет их избежать своим судентам. Алехо очень позитивный, понимающий и терпеливый человек, что особенно важно в профессии преподавателя. Алехо имеет диплом бакалавра по экономике, также успешно прошел курсы по повышению квалиффикации в Институте Сервантеса. Кроме того, является официальным экзаменатором Dele для уровней A, B и C.",
                    PhotoId = 6,
                });
            modelBuilder.Entity<TeacherDto>()
                .HasData(new TeacherDto
                {
                    Id = 7,
                    Name = "Пабло",
                    Post = "преподаватель",
                    Info =
                        "Пабло - преподаватель испанского языка из Венесуэлы. Работает как со взрослыми, так и с детскими группами, у которых всегда имеет особенный успех. Веселый, молодой, харизматичный преподаватель. Всегда тщательно подбирает материалы для каждого занятия. Очень ответственно относится к своей работе, и результатам своих студентов.",
                    PhotoId = 7,
                });
            modelBuilder.Entity<TeacherDto>()
                .HasData(new TeacherDto
                {
                    Id = 8,
                    Name = "Джонатан",
                    Post = "преподаватель",
                    Info =
                        @"Джонатан жизнелюбивый и опытный преподаватель из Испании (Барселона). Имеет педагогическое образование (воспитатель в детском саду), что дало ему возможность работать с детьми разных возрастов и преподавать им испанский язык как иностранный. 
                    Уже три года Джонатан обучает испанскому языку как детей, так и взрослых. Программу занятий для каждого ученика подбирает индивидуально и адаптирует методику под его особенности, уровень владения языком, возраст и потребности. Его занятия всегда увлекательны и динамичными, и при всем при этом, эффективные и полезные.Владеет русским языком.",
                    PhotoId = 8,
                });
            modelBuilder.Entity<TeacherDto>()
                .HasData(new TeacherDto
                {
                    Id = 9,
                    Name = "Юлия",
                    Post = "преподаватель, лингвист",
                    Info =
                        "Юлия разносторонний и творческий человек. Закончила с отличием филологический факультет МГУ им М.В. Ломоносова. Прошла стажировку в Университете Барселоны. Три года работает преподавателем испанского и каталанского языков. Владеет коммуникативной методикой преподавания для иностранцев. На своих уроках особое внимание уделяет грамматике и разговорной лексике, а также культуре и литературе стран изучаемого языка.",
                    PhotoId = 9,
                });
        }

        private static void SeedLanguageLevelsTable(ModelBuilder modelBuilder)
        {
            // language_levels
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 1,
                    Name = "A1.1",
                    Rang = 1,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 2,
                    Name = "A1.2",
                    Rang = 2,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 3,
                    Name = "A2.1",
                    Rang = 3,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 4,
                    Name = "A2.2",
                    Rang = 4,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 5,
                    Name = "B1.1",
                    Rang = 5,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 6,
                    Name = "B1.2",
                    Rang = 6,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 7,
                    Name = "B2.1",
                    Rang = 7,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 8,
                    Name = "B2.2",
                    Rang = 8,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 9,
                    Name = "C1.1",
                    Rang = 9,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 10,
                    Name = "C1.2",
                    Rang = 10,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 11,
                    Name = "C2.1",
                    Rang = 11,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 12,
                    Name = "C2.2",
                    Rang = 12,
                });
        }
    }
}