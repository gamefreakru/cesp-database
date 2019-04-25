using System;
using System.Linq;
using CESP.Database.Context;
using CESP.Database.Context.Education.Models;
using CESP.Database.Context.Files.Models;
using CESP.Database.Context.Payments.Models;
using CESP.Database.Context.Schedules.Models;

namespace CESP.Database.Filler.Filling
{
    public static class CoursesSeed
    {
        public static void SeedCourses(this CespContext context)
        {
            if (context.Courses.FirstOrDefault(c => c.Name == "Испанский язык для начинающих") == null)
            {
                var course = new CourseDto
                {
                    Name = "Испанский язык для начинающих",
                    DurationInfo =
                        @"60 часов — 9 недель при занятиях по будням, 12 недель по выходным.",
                    Description =
                        @"Самое большое количество вопросов, конечно, задается теми, кто впервые начинает учить испанский язык. Что я буду знать после окончания курса? Как я смогу понимать репетитора, который говорит на испанском? Будем ли мы изучать грамматику и научусь ли я говорить?
                    Существует множество методик для изучения иностранного языка как для взрослых так и для детей, и каждый выбирает ту, которая ему подходит больше.
                    В своей программе обучения испанского языка для начинающих мы придерживаемся коммуникативной методики. Это значит, главная задача для нас: научить вас говорить по-испански. Начиная с первого занятия преподаватель общается со студентами на испанском языке. Вы увидите, что такие фразы как «Меня зовут Анна», «Я живу в Москве» выучить даже проще, чем алфавит. Это не значит, что мы не уделяем внимание теории. Каждый блок курса включает в себя лексику и грамматику. 
                    Не смотря на максимальное использование испанского языка во время занятия, вы всегда можете задать вопрос по-русски и получить объяснение, не боясь, что преподаватель вас не понимает. Вам не обязательно носить с собой словарь. Любое неизвестное слово вы можете спросить у преподавателя. Даже если он не знает перевод, он умеет рисовать, а также объяснять значение другими, известными вам словами. 
                    Закончив курс «Испанский для начинающих», вы уже сможете вести несложный диалог на испанском языке. Вы будете уметь представляться, описывать внешность, сможете спросить и объяснить дорогу, выразить свое отношение к предметам и ситуациям, рассказать о своих обычных занятиях. Выучите настоящее и одно прошедшее время глаголов.",
                };
                context.Courses.Add(course);
                context.SaveChanges();
            }

            if (context.Courses.FirstOrDefault(c => c.Name == "Стандартный курс испанского") == null)
            {
                var photo = new FileDto
                {
                    Name = "cources/standart_course.jpg",
                    Info = "Стандартный курс испанского",
                };
                context.Files.Add(photo);
                context.SaveChanges();


                var course = new CourseDto
                {
                    Name = "Стандартный курс испанского",
                    DurationInfo =
                        @"60 ак. часов — 2 занятия в неделю по 3,3 академических часа плюс перерыв 15 минут. Общая продолжительность курса — 9 недель.",
                    Description =
                        "Классический курс испанского языка в Москве продолжительностью около двух месяцев. Такой курс легко можно сочетать с работой или учебой. Количество занятий в неделю спланировано так, чтобы не отнимать у Вас много свободного времени, но и не позволить забыть пройденный материал.",
                    PhotoId = photo.Id,
                };
                context.Courses.Add(course);
                context.SaveChanges();

                var group = new StudentGroupDto
                {
                    IsAvailable = true,
                    IsWorking = false,
                    CourseId = course.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var price = new PriceDto
                {
                    DiscountPer = 19,
                    DiscountInfo = "на утренние группы.",
                    CostInfo = "В стоимость входят учебные материалы.",
                    StudentGroupId = group.Id,
                    CurrencyId = (int) CurrencyEnum.Rub,
                };
                context.Prices.Add(price);
                context.SaveChanges();
            }

            if (context.Courses.FirstOrDefault(c => c.Name == "Интенсивный курс испанского") == null)
            {
                var photo = new FileDto
                {
                    Name = "cources/intensive_course.jpg",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var course = new CourseDto
                {
                    Name = "Интенсивный курс испанского",
                    DurationInfo =
                        @"60 часов — 4 занятия в неделю по 3,3 академических часа плюс перерыв 15 минут. Общая продолжительность курса — 4,5 недели. ",
                    Description =
                        "Для тех, кто хочет выучить испанский язык в короткие сроки и располагает достаточным для этого временем, мы предлагаем интенсивные курсы разговорного испанского. Занятия проходят в нашем испанском центре 4 раза в неделю, скорость обучения увеличивается в два раза. При этом вы получаете курс в полном объеме без каких-либо сокращений.",
                    PhotoId = photo.Id,
                };
                context.Courses.Add(course);
                context.SaveChanges();

                var group = new StudentGroupDto
                {
                    CourseId = course.Id,
                    IsAvailable = true,
                    IsWorking = false,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                context.Prices.AddRange(new[]
                {
                    new PriceDto
                    {
                        StudentGroupId = group.Id,
                        DiscountPer = 20,
                        CostInfo = "В стоимость входят учебные материалы.",
                    },
                    new PriceDto
                    {
                        StudentGroupId = group.Id,
                        Cost = 16000,
                        CurrencyId = (int) CurrencyEnum.Rub,
                        CostInfo = "(утренний интенсив), включая учебные материалы",
                    },
                    new PriceDto
                    {
                        StudentGroupId = group.Id,
                        Cost = 16500,
                        CurrencyId = (int) CurrencyEnum.Rub,
                        CostInfo = "(дневной интенсив), включая учебные материалы",
                    },
                    new PriceDto
                    {
                        StudentGroupId = group.Id,
                        Cost = 18000,
                        CurrencyId = (int) CurrencyEnum.Rub,
                        CostInfo = "(вечерний интенсив), включая учебные материалы",
                    }
                });
                context.SaveChanges();

                context.Schedules.AddRange(new[]
                    {
                        new ScheduleDto
                        {
                            Day = "с понедельника по четверг",
                            StartLessonTime = new TimeSpan(9, 0, 0),
                            EndLessonTime = new TimeSpan(11, 45, 0),
                            StudentGroupId = group.Id,
                        },
                        new ScheduleDto
                        {
                            Day = "с понедельника по четверг",
                            StartLessonTime = new TimeSpan(12, 15, 0),
                            EndLessonTime = new TimeSpan(15, 0, 0),
                            StudentGroupId = group.Id,
                        },
                        new ScheduleDto
                        {
                            Day = "с понедельника по четверг",
                            StartLessonTime = new TimeSpan(19, 0, 0),
                            EndLessonTime = new TimeSpan(21, 45, 0),
                            StudentGroupId = group.Id,
                        }
                    }
                );
                context.SaveChanges();
            }

            if (context.Courses.FirstOrDefault(c => c.Name == "Курс выходного дня") == null)
            {
                var photo = new FileDto
                {
                    Name = "cources/weekend_course.jpg",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var course = new CourseDto
                {
                    Name = "Курс выходного дня",
                    DurationInfo =
                        @"60 часов — 1 занятие в неделю по 5 академических часов плюс два перерыва по 10 минут. Общая продолжительность курса — 12 недель.",
                    Description =
                        "Хотите учить испанский или каталанский язык с нуля, но в течение недели загружены работой? Уделите ему один из выходных дней в нашей испанской школе. Занятия проводятся в первую или вторую половину дня, с перерывами на чай , во время которых Вы сможете передохнуть, а также насладиться нашей дружной испанской атмосферой.",
                    PhotoId = photo.Id,
                };
                context.Courses.Add(course);
                context.SaveChanges();

                var group = new StudentGroupDto
                {
                    CourseId = course.Id,
                    IsAvailable = true,
                    IsWorking = false,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                context.Prices.Add(new PriceDto
                    {
                        StudentGroupId = group.Id,
                        CostInfo = "В стоимость входят учебные материалы.",
                    }
                );
                context.SaveChanges();
            }

            if (context.Courses.FirstOrDefault(c => 
                c.Name == 
                "Индивидуальные занятия с репетитором и курсы в мини-группах по испанскому языку у нас в центре или у вас дома"
                ) == null)
            {
                var photo = new FileDto
                {
                    Name = "cources/individual_course.jpg",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var course = new CourseDto
                {
                    Name = 
                        "Индивидуальные занятия с репетитором и курсы в мини-группах по испанскому языку у нас в центре или у вас дома",
                    DurationInfo =
                        @"Один уровень длится примерно 50 часов — частота и продолжительность занятий согласовывается с группой.",
                    Description =
                        "Занятия проходят индивидуально 1-2 человека или в мини-группах 3-4 человека. Продолжительность занятия и количество уроков в неделю зависит от решения группы. Такой вариант учить испанский язык подходит вам, если вы не можете подстроится под общее расписание или хотите заниматься со своей семьей или друзьями в менее шумной обстановке.",
                    PhotoId = photo.Id,
                };
                context.Courses.Add(course);
                context.SaveChanges();
            }

            if (context.Courses.FirstOrDefault(c => c.Name == "Испанский для детей") == null)
            {
                var photo = new FileDto
                {
                    Name = "cources/children_course.jpg",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var course = new CourseDto
                {
                    Name = "Испанский для детей",
                    Description =
                        "Методики преподавания испанского языка для детей отличается от методик для взрослых. Здесь большое внимание уделяется заданиям в игровой форме, используется много визуальных материалов. Мы проводим занятия для детей от 4 до 16 лет.",
                    PhotoId = photo.Id,
                };
                context.Courses.Add(course);
                context.SaveChanges();
            }

            if (context.Courses.FirstOrDefault(c => c.Name == "Каталонский язык") == null)
            {
                var photo = new FileDto
                {
                    Name = "cources/catalonia_course.jpg",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var course = new CourseDto
                {
                    Name = "Каталонский язык",
                    Description =
                        "Каталонский язык является официальным языком Каталонии, Балеарских островов, Арагона, Валенсии и Андорры. У нас Вы можете изучать каталанский, общаясь с носителями языка, узнать новые аспекты много-культурной Испании.",
                    PhotoId = photo.Id,
                };
                context.Courses.Add(course);
                context.SaveChanges();
            }

            if (context.Courses.FirstOrDefault(c => c.Name == "Португальский язык") == null)
            {
                var photo = new FileDto
                {
                    Name = "cources/portugal_course.jpg",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var course = new CourseDto
                {
                    Name = "Португальский язык",
                    Description =
                        @"На португальском языке говорят в Португалии, в Африке, в таких странах как: Ангола, Мозамбик, Гвинея Биссау, Сан Томе и Принсипи, Кабо Верде, а также в Бразилии, крупнейшей и высокоразвитой стране Латинской Америки. Отношения между Россией и Бразилией быстро развиваются, наши страны сотрудничают в области торговли, инвестиций, нефтегазовой промышленности, атомной энергии, а также биотехнологий, космонавтики, информационных и военных технологий.

                    Поэтому изучение португальского языка – это ваше вложение в будущее, и его знание станет плюсом к Вашему профессиональному резюме.

                    У нас работают педагоги ведущих вузов России, имеющие ученые степени и опыт работы в португалоговорящих странах, а также носители языка.
                    Только мы обучаем португальскому языку по специальной методике специалистов с испанским языком.",
                    PhotoId = photo.Id,
                };
                context.Courses.Add(course);
                context.SaveChanges();
            }

            if (context.Courses.FirstOrDefault(c => c.Name == "Курс делового испанского и каталонского языков") == null)
            {
                var photo = new FileDto
                {
                    Name = "cources/deal_course.jpg",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var course = new CourseDto
                {
                    Name = "Курс делового испанского и каталонского языков",
                    Description =
                        @"Если у Вас, с учетом Вашей профессиональной деятельности, возникла необходимость освоить или вспомнить испанский язык и, в частности, лексический минимум (юридический, экономический, дипломатический, медицинский или просто бизнес), необходимый по работе - обращайтесь к нам! Пройдя курс обучения, основанный на Вашей профессиональной ориентации, Вы получите необходимый Вам объем знаний и уверенность в своих силах!",
                    DurationInfo = "Частота и продолжительность занятий согласовывается с учетом Ваших пожеланий.",
                    PhotoId = photo.Id,
                };
                context.Courses.Add(course);
                context.SaveChanges();
            }

            if (context.Courses.FirstOrDefault(c => c.Name == "Корпоративный курс у вас в офисе") == null)
            {
                var photo = new FileDto
                {
                    Name = "cources/inoffice_course.jpg",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var course = new CourseDto
                {
                    Name = "Корпоративный курс у вас в офисе",
                    Description =
                        @"Если Вы с вашими коллегами по работе решили пройти курс делового испанского или каталонского языков с юридической, экономической, дипломатической или медицинской лексикой, мы вам обязательно поможем. Лучшие преподаватели нашего центра направятся к вам офис и предложат вам эффективную методику усвоения языка не отрываясь от рабочего места.",
                    DurationInfo = "Частота и продолжительность занятий согласовывается с учетом Ваших пожеланий.",
                    PhotoId = photo.Id,
                };
                context.Courses.Add(course);
                context.SaveChanges();
            }

            if (context.Courses.FirstOrDefault(c => c.Name == "Занятия по СКАЙП") == null)
            {
                var photo = new FileDto
                {
                    Name = "cources/skype_course.jpg",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var course = new CourseDto
                {
                    Name = "Занятия по СКАЙП",
                    Description =
                        @"Эта самая удобная учебная программа для широкого круга слушателей, как для начинающих так и для имеющих опыт изучения языка, которая включает в себя комплексный подход к изучению языка (грамматика, необходимая лексика для повседневного общения, путешествий или работы , восприятие на слух аудиоматериалов, устная речь, чтение, написание сочинений и эссе и перевод ). Эта методика разработана в соответствии с международными стандартами обучения европейских языков.",
                    DurationInfo = "Частота и продолжительность занятий согласовывается с учетом Ваших пожеланий.",
                    PhotoId = photo.Id,
                };
                context.Courses.Add(course);
                context.SaveChanges();
            }

            if (context.Courses.FirstOrDefault(c => c.Name == "Подготовка к ЕГЭ и к DELE") == null)
            {
                var photo = new FileDto
                {
                    Name = "cources/ege_dele_course.jpg",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var course = new CourseDto
                {
                    Name = "Подготовка к ЕГЭ и к DELE",
                    Description =
                        @"Уважаемые родители! Если Ваши дети оканчивают школу, и им предстоит сдача ЕГЭ по испанскому языку, не волнуйтесь, а обращайтесь к нам. Наши преподаватели подготовят ваших детей, дадут им необходимые знания, чтобы успешно сдать экзамен и при этом, чувствовать себя спокойно и уверенно. 
DELE – международная система обучения испанскому языку, предполагающая получение сертификата, действующего во всех странах мира. Мы подготовим Вас и/или ваших детей к сдаче экзаменов на получение этого сертификата нужного Вам уровня.

Обратите внимание, что занятия проводятся не только в нашем учебном центре, но и, по Вашему желанию, у вас дома.",
                    DurationInfo = "Частота и продолжительность занятий согласовывается с учетом Ваших пожеланий.",
                    PhotoId = photo.Id,
                };
                context.Courses.Add(course);
                context.SaveChanges();
            }

            if (context.Courses.FirstOrDefault(c => c.Name == "Письменный (в том числе срочный) или устный перевод") ==
                null)
            {
                var photo = new FileDto
                {
                    Name = "cources/translate_course.jpg",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var course = new CourseDto
                {
                    Name = "Письменный (в том числе срочный) или устный перевод",
                    Description =
                        @"Дополнительная услуга, оказываемая только нашим Центром, – письменный (в том числе срочный) или устный перевод по любой тематике и любого уровня сложности на/с испанского и каталонского языков.",
                    PhotoId = photo.Id,
                };
                context.Courses.Add(course);
                context.SaveChanges();
            }
        }
    }
}