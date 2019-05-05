using System.Linq;
using CESP.Database.Context;
using CESP.Database.Context.Files.Models;
using CESP.Database.Context.Schools.Models;

namespace CESP.Database.Filler.Filling
{
    public static class SchoolSeed
    {
        public static void SeedSchools(this CespContext context)
        {
            if (context.Schools.FirstOrDefault(sch => sch.SysName == "ihbarcelona") == null)
            {
                var photo = new FileDto
                {
                    Name = "schools/ihbarcelona.jpg",
                    Info = "Школа Испанского языка в Барселоне",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var school = new SchoolDto
                {
                    SysName = "ihbarcelona",
                    Name = "International house Barcelona",
                    Location = "Школа Испанского языка в Барселоне",
                    ShortInfo = "IH Barcelona одна из лучших школ испанского языка в Испании.",
                    Info = @"Школа IH Barcelona по праву считается одной из лучших школ испанского языка в Испании.
                    Основанная в 1972 году, она расположена в самом центре Барселоны в пяти минутах ходьбы от
                    Пласа Каталуния и занимает роскошный шестиэтажный особняк. К услугам студентов 40
                    оборудованных аудиторий, материалы для обучения, библиотека, бесплатный интернет и
                    прекрасный бар с верандой на крыше. Кроме того, в стоимость курса входят культурные
                    мероприятия.<br/> <br/>
                    IH Barcelona имеет аккредитацию Института Сервантеса, CEELE, EQUALS, а также является членом
                    Национальной Федерации испанских школ FEDELE. Кроме того IH Barcelona является членом одной
                    из самых крупных и известных сетей независимых языков школ - International House World
                    Organisation.<br/> <br/>
                    IH Barcelona известна на весь мир своим центром подготовки преподавателей, каждый год она
                    подготавливает и выпускает квалифицированных специалистов в области преподавания",
                    PhotoId = photo.Id,
                };
                context.Schools.Add(school);
                context.SaveChanges();
                
                var photo1 = new FileDto
                {
                    Name = "schools/ihbarcelona1.jpg",
                    Info = "Школа Испанского языка в Барселоне",
                };
                context.Files.Add(photo1);
                context.SaveChanges();
                var photo2 = new FileDto
                {
                    Name = "schools/ihbarcelona2.jpg",
                    Info = "Школа Испанского языка в Барселоне",
                };
                context.Files.Add(photo2);
                context.SaveChanges();
                var photo3 = new FileDto
                {
                    Name = "schools/ihbarcelona3.jpg",
                    Info = "Школа Испанского языка в Барселоне",
                };
                context.Files.Add(photo3);
                context.SaveChanges();
                var photo4 = new FileDto
                {
                    Name = "schools/ihbarcelona4.jpg",
                    Info = "Школа Испанского языка в Барселоне",
                };
                context.Files.Add(photo4);
                context.SaveChanges();
                var photo5 = new FileDto
                {
                    Name = "schools/ihbarcelona5.jpg",
                    Info = "Школа Испанского языка в Барселоне",
                };
                context.Files.Add(photo5);
                context.SaveChanges();
                var photo6 = new FileDto
                {
                    Name = "schools/ihbarcelona6.jpg",
                    Info = "Школа Испанского языка в Барселоне",
                };
                context.Files.Add(photo6);
                context.SaveChanges();

                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo1.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo2.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo3.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo4.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo5.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo6.Id
                });
                context.SaveChanges();
            }
            
            if (context.Schools.FirstOrDefault(sch => sch.SysName == "ihtarragona") == null)
            {
                var photo = new FileDto
                {
                    Name = "schools/ihtarragona.jpg",
                    Info = "International House Tarragona",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var school = new SchoolDto
                {
                    SysName = "ihtarragona",
                    Name = "International House Tarragona",
                    Location = "Школа Испанского языка в Таррагоне",
                    ShortInfo = "Школа Испанского языка IH Tarragona отличный выбор для тех, кто хочет выучить язык и отдохнуть от большого города.",
                    Info = @"Языковая школа IH Tarragona не нуждается в представлении. Основанная в 1980
                    году, школа расположена на Рамбла-Нове, в самом центре города.<br/> <br/>
                    Школа предлагает курсы английского и испанского языков для иностранцев: как для взрослых, так
                    и для подростков и детей. Кроме того, в школе проводятся курсы немецкого, французского и каталанского языков, а, также, организуется курс испанского языка для подростков летом.
                    IH предлагает широкий спектр курсов, как общие курсы, так и специализированные: для бизнеса,
                    для сдачи экзаменов, а также индивидуальные курсы для компаний, групп, школ и частных лиц.<br/> <br/>
                    Школа имеет 7 классных комнатах, полностью оборудованных для проведения занятий, и аудиторию с тремя компьютерами с выходом в интернет.
                    Кроме того, школа предлагает широкий выбор книг для чтения, видео и DVD-дисков.",
                    PhotoId = photo.Id,
                };
                context.Schools.Add(school);
                context.SaveChanges();
                
                var photo1 = new FileDto
                {
                    Name = "schools/ihtarragona1.jpg",
                    Info = "International House Tarragona",
                };
                context.Files.Add(photo1);
                context.SaveChanges();
                var photo2 = new FileDto
                {
                    Name = "schools/ihtarragona2.jpg",
                    Info = "International House Tarragona",
                };
                context.Files.Add(photo2);
                context.SaveChanges();
                var photo3 = new FileDto
                {
                    Name = "schools/ihtarragona3.jpg",
                    Info = "International House Tarragona",
                };
                context.Files.Add(photo3);
                context.SaveChanges();
                var photo4 = new FileDto
                {
                    Name = "schools/ihtarragona4.jpg",
                    Info = "International House Tarragona",
                };
                context.Files.Add(photo4);
                context.SaveChanges();
                
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo1.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo2.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo3.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo4.Id
                });
                context.SaveChanges();
            }
            
            if (context.Schools.FirstOrDefault(sch => sch.SysName == "ihvalencia") == null)
            {
                var photo = new FileDto
                {
                    Name = "schools/ihvalencia.jpg",
                    Info = "Españole International House Valencia",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var school = new SchoolDto
                {
                    SysName = "ihvalencia",
                    Name = "Españole International House Valencia",
                    ShortInfo = "Солнце, море, вкусная еда и испанский язык. Изучение испанского языка в Испании еще никогда не была таким приятным!",
                    Location = "Школа Испанского языка в Валенсии",
                    Info = @"Языковая школа Españole IH Valencia приглашает всех желающих изучать испанский язык в уютной атмосфере с профессиональными преподавателями! Españole IH Valencia - член крупнейшей международной сети независимых языковых школ International House World Organisation, целью которой является достижение наивысших стандартов преподавания языков по всему миру. Школа аrкредитована Институтом Сервантеса и, кроме того, является членом Национальной Федерации испанских школ FEDELE.<br/> <br/>


                    Вы, безусловно, по достоинству оцените прекрасное месторасположение школы в самом сердце Валенсии, в его историческом центре. Занятия проходят в красивом отреставрированном здании, которое полностью готово принять в своих стенах студентов со всего мира. Аудитории полностью оборудованы для полноценного изучения испанского языка. Кроме самих языковых курсов вас ждет обширная и интересная культурная программа. <br/> <br/>


                    Все преподаватели школы - профессионалы своего дела, которые не один год преподают испанский язык иностранным студентам и в полной мере владеют коммуникативной методикой преподавания языка, которая позволяет студентам в кратчайшие сроки погрузиться в язык, а также улучшить свои коммуникативные навыки.",
                    PhotoId = photo.Id,
                };
                context.Schools.Add(school);
                context.SaveChanges();
                
                var photo1 = new FileDto
                {
                    Name = "schools/ihvalencia1.jpg",
                    Info = "Españole International House Valencia",
                };
                context.Files.Add(photo1);
                context.SaveChanges();
                var photo2 = new FileDto
                {
                    Name = "schools/ihvalencia2.jpg",
                    Info = "Españole International House Valencia",
                };
                context.Files.Add(photo2);
                context.SaveChanges();
                var photo3 = new FileDto
                {
                    Name = "schools/ihvalencia3.jpg",
                    Info = "Españole International House Valencia",
                };
                context.Files.Add(photo3);
                context.SaveChanges();
                var photo4 = new FileDto
                {
                    Name = "schools/ihvalencia4.jpg",
                    Info = "Españole International House Valencia",
                };
                context.Files.Add(photo4);
                context.SaveChanges();
                var photo5 = new FileDto
                {
                    Name = "schools/ihvalencia5.jpg",
                    Info = "Españole International House Valencia",
                };
                context.Files.Add(photo5);
                context.SaveChanges();
                
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo1.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo2.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo3.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo4.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo5.Id
                });
                context.SaveChanges();
            }
                        
            if (context.Schools.FirstOrDefault(sch => sch.SysName == "malaca") == null)
            {
                var photo = new FileDto
                {
                    Name = "schools/malaca.jpg",
                    Info = "Instituto Malaca",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var school = new SchoolDto
                {
                    SysName = "malaca",
                    Name = "Instituto Malaca",
                    Location = "Школа Испанского языка в Малаге",
                    ShortInfo = "Отличный вариант для изучения испанского языка, школа Instituto Malaca в Магаге.",
                    Info = @"Одна из лучших испанских языковых школ Малаги - Instituto Malaca<br/> <br/>


                    Instituto Malaca был основан 40 лет назад и, безусловно, держит высокую планку в обучении испанскому языку. Школа Instituto Malaca аккредитована Институтом Сервантеса, CEELE, EAQUALS, кроме того, в течение последних пяти лет школа была удостоена международной премии LTM Star Aword в номинации “Испанская языковая школа”.<br/> <br/>


                    Школа оснащена всем необходимым оборудованием и готова принять всех делающих изучать испанский язык в своих стенах. Для вашего комфорта школа располагает 26 аудиториями, залом для самостоятельной подготовки, мультимедийной аудиторией, резиденцией Club Hispánico, который находится на территории школы; кроме того, здесь имеются прачечная, бассейн, террасы, бар, ресторан и танцевальная студия.<br/> <br/>


                    И это еще не все! Также вас ждет обширная культурная программа, благодаря которой мы сможете ближе познакомиться с культурой и традициями Андалусии. Вашему вниманию будут представлены поездки в соседние города региона или даже в Марокко! Уроки танцев, посещение тапас - баров и многое другое. Обучение еще никогда не было таким увлекательным и интересным!
                    ",
                    PhotoId = photo.Id,
                };
                context.Schools.Add(school);
                context.SaveChanges();
                
                var photo1 = new FileDto
                {
                    Name = "schools/malaca1.jpg",
                    Info = "Instituto Malaca",
                };
                context.Files.Add(photo1);
                context.SaveChanges();
                var photo2 = new FileDto
                {
                    Name = "schools/malaca2.jpg",
                    Info = "Instituto Malaca",
                };
                context.Files.Add(photo2);
                context.SaveChanges();
                var photo3 = new FileDto
                {
                    Name = "schools/malaca3.jpg",
                    Info = "Instituto Malaca",
                };
                context.Files.Add(photo3);
                context.SaveChanges();
                var photo4 = new FileDto
                {
                    Name = "schools/malaca4.jpg",
                    Info = "Instituto Malaca",
                };
                context.Files.Add(photo4);
                context.SaveChanges();
                
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo1.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo2.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo3.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo4.Id
                });
                context.SaveChanges();
            }
                                    
            if (context.Schools.FirstOrDefault(sch => sch.SysName == "picasso") == null)
            {
                var photo = new FileDto
                {
                    Name = "schools/picasso.jpg",
                    Info = "Instituto Picasso",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var school = new SchoolDto
                {
                    SysName = "picasso",
                    Name = "Instituto Picasso",
                    Location = "Школа Испанского языка в Малаге",
                    ShortInfo = "Еще один вариант для тех, кто желает учиться именно в Магале - школа Instituto Picasso.",
                    Info = @"Школа испанского языка Пабло Пикассо - еще одна прекрасная языковая школа Малаги. Центр Instituto Picasso был основан в 1982 году, за эти годы через его стены прошло более 30000 студентов со всего мира. Школа аккредитована Институтом Сервантеса, имеет сертификат качества туристического профессионализма SICTED, который она получила от мэрии Малаги. Кроме того, школа официально признана правительством Швеции как центр, имеющий право на получение грантов в рамках программы финансовой помощи для обучения шведских студентов (CSN).
                    Так же школа была аккредитована отделом культуры Посольства Китайской Народной Республики в качестве заслуженного центра для китайских студентов для изучения испанского языка и культуры.<br/> <br/>


                    Instituto Picasso располагает командой высококвалифицированных проподавателей с высшим образованием в различным областях, каждый из которых имеет опыт преподавания испанского языка как иностранного более 15 лет. <br/> <br/>


                    Школа расположена в историческом центре города в здании XIX века, в 50 метрах от дома, где в 1881 году родился всем известный Пабло Пикассо.",
                    PhotoId = photo.Id,
                };
                context.Schools.Add(school);
                context.SaveChanges();
                
                var photo1 = new FileDto
                {
                    Name = "schools/picasso1.jpg",
                    Info = "Instituto Picasso",
                };
                context.Files.Add(photo1);
                context.SaveChanges();
                var photo2 = new FileDto
                {
                    Name = "schools/picasso2.jpg",
                    Info = "Instituto Picasso",
                };
                context.Files.Add(photo2);
                context.SaveChanges();
                var photo3 = new FileDto
                {
                    Name = "schools/picasso3.jpg",
                    Info = "Instituto Picasso",
                };
                context.Files.Add(photo3);
                context.SaveChanges();
                var photo4 = new FileDto
                {
                    Name = "schools/picasso4.jpg",
                    Info = "Instituto Picasso",
                };
                context.Files.Add(photo4);
                context.SaveChanges();
                
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo1.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo2.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo3.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo4.Id
                });
                context.SaveChanges();
            }
                                                
            if (context.Schools.FirstOrDefault(sch => sch.SysName == "sol") == null)
            {
                var photo = new FileDto
                {
                    Name = "schools/sol.jpg",
                    Info = "Instituto Mediterráneo Sol",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var school = new SchoolDto
                {
                    SysName = "sol",
                    Name = "Instituto Mediterráneo Sol",
                    Location = "Школа Испанского языка в Гранаде",
                    ShortInfo = "Instituto Mediterráneo Sol - прекрасный вариант для любителей города Гранада. Учитесь в самом центре этого прекрасного города!",
                    Info = @"Школа Испанского языка Instituto Mediterráneo Sol в Гранаде - это прекрасное место для погружения в Испанский язык и культуру. Школа находится в самом центре города, в уникальном историческом районе Реалехо.<br/> <br/>


                    Школа Instituto Mediterráneo Sol аккредитована Институтом Сервантеса. К услугам студентов: полностью оборудованные аудитории и самые профессиональные преподаватели с большим опытом работы. <br/> <br/>


                    Небольшие группы (до 8 человек) позволяют более эффективно изучать испанский язык в приятной, дружеской обстановке.
                    ",
                    PhotoId = photo.Id,
                };
                context.Schools.Add(school);
                context.SaveChanges();
                
                var photo1 = new FileDto
                {
                    Name = "schools/sol1.jpg",
                    Info = "Instituto Mediterráneo Sol",
                };
                context.Files.Add(photo1);
                context.SaveChanges();
                var photo2 = new FileDto
                {
                    Name = "schools/sol2.jpg",
                    Info = "Instituto Mediterráneo Sol",
                };
                context.Files.Add(photo2);
                context.SaveChanges();
                var photo3 = new FileDto
                {
                    Name = "schools/sol3.jpg",
                    Info = "Instituto Mediterráneo Sol",
                };
                context.Files.Add(photo3);
                context.SaveChanges();
                var photo4 = new FileDto
                {
                    Name = "schools/sol4.jpg",
                    Info = "Instituto Mediterráneo Sol",
                };
                context.Files.Add(photo4);
                context.SaveChanges();
                
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo1.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo2.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo3.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo4.Id
                });
                context.SaveChanges();
            }
                                                            
            if (context.Schools.FirstOrDefault(sch => sch.SysName == "tenerife") == null)
            {
                var photo = new FileDto
                {
                    Name = "schools/tenerife.jpg",
                    Info = "FU International Academy, Tenerife",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var school = new SchoolDto
                {
                    SysName = "tenerife",
                    Name = "FU International Academy, Tenerife",
                    Location = "Школа Испанского языка на Тенерифе",
                    ShortInfo = "FU International Academy, Tenerife предоставляет прекрасную возможность не только учиться, но познакомиться с островной жизнью Тенерифе, где круглый год царит вечная весна!",
                    Info = @"Школа FU International Academy - идеальное место для всех, кто желает изучать испанский язык в укромном уголке Испании, таком как Тенерифе.<br/> <br/>


                    Школа была открыта в 2000 году и с тех пор получила множество позитивных отзывов и рекомендаций от своих студентов.<br/> <br/>


                    Академия FU является семейным бизнесом, и это прослеживается во всем: например, каждый понедельник проводятся своеобразные приветственные завтраки для студентов школы на террасе собственного кафе FU Café. Руководство школы всегда идет на встречу своим гостям для решения всех возникающих вопросов.<br/> <br/>


                    Занятия проходят в группах, в которых обучаются не более 8 студентов.<br/> <br/>


                    Данная школа отличается от других языковых академий в Испании, в первую очередь, из-за локации: Тенерифе -остров вечной весны и, безусловно, самый красивый в мире. Расположен он в непосредственной близости от Африки со средней температурой 23 ° C; температура здесь редко опускается ниже 18 ° C .",
                    PhotoId = photo.Id,
                };
                context.Schools.Add(school);
                context.SaveChanges();
                
                var photo1 = new FileDto
                {
                    Name = "schools/tenerife1.jpg",
                    Info = "FU International Academy, Tenerife",
                };
                context.Files.Add(photo1);
                context.SaveChanges();
                var photo2 = new FileDto
                {
                    Name = "schools/tenerife2.jpg",
                    Info = "FU International Academy, Tenerife",
                };
                context.Files.Add(photo2);
                context.SaveChanges();
                var photo3 = new FileDto
                {
                    Name = "schools/tenerife3.jpg",
                    Info = "FU International Academy, Tenerife",
                };
                context.Files.Add(photo3);
                context.SaveChanges();
                var photo4 = new FileDto
                {
                    Name = "schools/tenerife4.jpg",
                    Info = "FU International Academy, Tenerife",
                };
                context.Files.Add(photo4);
                context.SaveChanges();
               
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo1.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo2.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo3.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo4.Id
                });
                context.SaveChanges();
            }
                                                                        
            if (context.Schools.FirstOrDefault(sch => sch.SysName == "clic") == null)
            {
                var photo = new FileDto
                {
                    Name = "schools/clic.jpg",
                    Info = "CLIC IH Sevilla y Cádiz",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var school = new SchoolDto
                {
                    SysName = "clic",
                    Name = "CLIC IH Sevilla y Cádiz",
                    Location = "Школа Испанского языка в Севилье и Кадисе",
                    ShortInfo = "CLIC IH Sevilla y Cádiz - прекрасный вариант для изучения испанского языка в колоритном регионе Андалусия.",
                    Info = @"Школы испанского языка CLIC IH Sevilla y Cádiz вступили в организацию International House World Organsation (сеть независимых языковых школ по всему миру) в 1997 году. <br/> <br/>


                    Главное условие для вступления в организацию Internationa House World — это исключительно высокое качество оказываемых услуг. Только школам, отвечающим высочайшим стандартам качества, позволено использовать бренд International House.<br/> <br/>


                    И, конечно, CLIC IH Sevilla y Cádiz заслуживает свое звание одной из лучших языковых школ Испании. <br/> <br/>


                    IH Sevilla y Cádiz аккредитована Институтом Сервантеса, FEDELE, Universitat de Barcelona, Univercity of Cembridge. <br/> <br/>


                    IH Sevilla y Cádiz - это отличная возможность выучить испанский язык в среде носителей с профессиональными преподавателями.",
                    PhotoId = photo.Id,
                };
                context.Schools.Add(school);
                context.SaveChanges();
                
                var photo1 = new FileDto
                {
                    Name = "schools/clic1.jpg",
                    Info = "CLIC IH Sevilla y Cádiz",
                };
                context.Files.Add(photo1);
                context.SaveChanges();
                var photo2 = new FileDto
                {
                    Name = "schools/clic2.jpg",
                    Info = "CLIC IH Sevilla y Cádiz",
                };
                context.Files.Add(photo2);
                context.SaveChanges();
                var photo3 = new FileDto
                {
                    Name = "schools/clic3.jpg",
                    Info = "CLIC IH Sevilla y Cádiz",
                };
                context.Files.Add(photo3);
                context.SaveChanges();
                var photo4 = new FileDto
                {
                    Name = "schools/clic4.jpg",
                    Info = "CLIC IH Sevilla y Cádiz",
                };
                context.Files.Add(photo4);
                context.SaveChanges();
                var photo5 = new FileDto
                {
                    Name = "schools/clic5.jpg",
                    Info = "CLIC IH Sevilla y Cádiz",
                };
                context.Files.Add(photo5);
                context.SaveChanges();
                var photo6 = new FileDto
                {
                    Name = "schools/clic6.jpg",
                    Info = "CLIC IH Sevilla y Cádiz",
                };
                context.Files.Add(photo6);
                context.SaveChanges();

                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo1.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo2.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo3.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo4.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo5.Id
                });
                context.SchoolFiles.Add(new SchoolFileDto
                {
                    SchoolId = school.Id,
                    FileId = photo6.Id
                });
                context.SaveChanges();
            }
        }
    }
}