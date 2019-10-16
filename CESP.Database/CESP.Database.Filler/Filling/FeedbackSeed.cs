using System;
using System.Linq;
using CESP.Database.Context;
using CESP.Database.Context.Feedbacks.Models;
using CESP.Database.Context.Files.Models;

namespace CESP.Database.Filler.Filling
{
    public static class FeedbackSeed
    {
        public static void SeedFeedback(this CespContext context)
        {
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Ермилова" && c.FirstName == "Ольга") == null)
            {
                var photo = new FileDto
                {
                    Name = "feedback/ermilova_olga.png",
                    Info = "Ермилова Ольга",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2016, 4, 17),
                    LastName = "Ермилова",
                    FirstName = "Ольга",
                    Message =
                        "Занятиями очень довольна. Уроки проходят на одном дыхании; в доброжелательной обстановке. Преподаватель Йосу Санчес все понятно объясняет. Отработка тем включает игровые формы, что делает изчение языка увлекательным. Закончила курс А1, теперь учусь здесь же на следующей ступени. Все супер! Спасибо за позитив!",
                    PhotoId = photo.Id
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }

            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Кирьянова" && c.FirstName == "Александра") == null)
            {
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2016, 8, 31),
                    LastName = "Кирьянова",
                    FirstName = "Александра",
                    SourceId = (int) FeedbackSourceEnum.Fb,
                    Message =
                        "Отличные курсы, я не пожалела ни капли,что пошла на них. Преподаватель Анхель лучший, объясняет доступно,понятно.Очень позитивный и добрейший человек. Занятия проходят в дружеской атмосфере. Я довольна, надеюсь продолжить занятия именно на этих курсах.",
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Титова" && c.FirstName == "Елена") == null)
            {               
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2016, 2, 26),
                    LastName = "Титова",
                    FirstName = "Елена",
                    SourceId = (int) FeedbackSourceEnum.Worksheet,
                    Message =
                        "Очень-очень хорошие курсы. Приятная доброжелательная атмосфера. Удобное расписание. Каждый может выбрать оптимальное время для себя. Достаточно неформальное общение между студентами и преподавателями. Сама занимаюсь второй год и очень довольна.",
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }

            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Горбачук" && c.FirstName == "Надежда") == null)
            {
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2013, 4, 7),
                    LastName = "Горбачук",
                    FirstName = "Надежда",
                    SourceId = (int) FeedbackSourceEnum.Worksheet,
                    Message =
                        "Хожу в школу на испанский язык уже второй год. Всем советуют. Обучение проводят педагоги носителя языка, что не мало важно, так как сразу грамотно ставят речь. Также очень удобное место расположение.",
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Tortuga" && c.FirstName == "Maria") == null)
            {
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2014, 4, 26),
                    LastName = "Tortuga",
                    FirstName = "Maria",
                    SourceId = (int) FeedbackSourceEnum.Worksheet,
                    Message =
                        "Perdonad, voy a escribir en ruso. Прекрасный, очень уютный, очень доброжелательный цент, при этом, работающий четко и профессионально. Редкое сочетание для Москвы. Отдельно отмечу прекрасного преподавателя, у которого училась Roger Vila. Надеюсь когда-нибудь продолжить.",
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Хузин" && c.FirstName == "Ильдар") == null)
            {
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2015, 5, 30),
                    LastName = "Хузин",
                    FirstName = "Ильдар",
                    SourceId = (int) FeedbackSourceEnum.Worksheet,
                    Message =
                        "По качеству преподавания центр Vamos для меня лучший из трех, где я проходил обучение.",
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Sakharova" && c.FirstName == "Alena") == null)
            {
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2014, 7, 11),
                    LastName = "Sakharova",
                    FirstName = "Alena",
                    SourceId = (int) FeedbackSourceEnum.Worksheet,
                    Message =
                        "Отличная школа. Цены, преподаватели, администраторы, качество обучения и место расположения школы - все на высшем уровне. Очень дружественная атмосфера! Преподаватели не зациклены на какой-то программе и предлагают множество различных способов изучения и всегда подстраиваются под темп группы. Мы ходили на занятия как на праздник. За 3 месяца изучения языка в Vamos, приехав в Испанию я начала говорить. Можно выучить испанский язык действительно недорого. Всем рекомендую эту школу!!",
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Самодумова" && c.FirstName == "Катерина") == null)
            {
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2014, 7, 10),
                    LastName = "Самодумова",
                    FirstName = "Катерина",
                    SourceId = (int) FeedbackSourceEnum.Worksheet,
                    Message =
                        "Изучаю испанский в центре Vamos в Москве уже 9 месяцев, планирую продолжить обучение в следующем году. Очень довольна качеством преподавания (не смотря на то, что у каждого преподавателя свой особенный стиль). Хочу отметить приятную атмосферу в центре, гибкий график занятий и индивидуальный подход к студентам. Расположение центра также довольно удобно, в случае переезда, выбирают офис в центре и близко к станциям метро. Классы проходят динамично, позитивно, с юмором. Настоящее живое общение с носителями языка. Так держать!;))",
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Монахова" && c.FirstName == "Наталья") == null)
            {
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2015, 4, 19),
                    LastName = "Монахова",
                    FirstName = "Наталья",
                    SourceId = (int) FeedbackSourceEnum.Worksheet,
                    Message =
                        "Хорошая школа, обучения проходят в дружественной и доверительной обстановке в игровой форме. К сожалению нет возможности продолжать пока заниматься, спасибо всем учителям, особенно нашему Julio Ruizy:-)",
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Томчук" && c.FirstName == "Ирина") == null)
            {
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2015, 6, 2),
                    LastName = "Томчук",
                    FirstName = "Ирина",
                    SourceId = (int) FeedbackSourceEnum.Worksheet,
                    Message =
                        "Хороший центр для изучения испанского языка. Всегда дружелюбная обстановка, интересные люди. Важно, что все преподаватели nativos. Это мне нравится больше всего. Удобное расположение Центра - в центре Москвы. Погружаешься в испанский мир и на время занятий забываешь обо всех заботах дня. Спасибо за обучение! Я очень рада, что училась в вашей школе. Вы стали моей дверью в Испанию.",
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Захарова" && c.FirstName == "Наталья") == null)
            {
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2015, 6, 2),
                    LastName = "Захарова",
                    FirstName = "Наталья",
                    SourceId = (int) FeedbackSourceEnum.Worksheet,
                    Message = "Центр очень хороший. Дружественное отношение преподавателей и администрации.",
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.FirstName == "Наталия" && c.LastName == null) == null)
            {
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2015, 6, 8),
                    FirstName = "Наталия",
                    SourceId = (int) FeedbackSourceEnum.Worksheet,
                    Message = "Все хорошо, но хотелось бы побольше объяснения на русском языке.",
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.FirstName == "Нина"&& c.LastName == null) == null)
            {
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2015, 5, 30),
                    FirstName = "Нина",
                    SourceId = (int) FeedbackSourceEnum.Worksheet,
                    Message = "В целом мне все понравилось, но хотелось бы больше объяснения грамматики.",
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.FirstName == "Екатерина" && c.LastName == null) == null)
            {
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2015, 6, 8),
                    FirstName = "Екатерина",
                    SourceId = (int) FeedbackSourceEnum.Worksheet,
                    Message = "Все хорошо! Мне нравится ваша школа, и я хочу продолжать обучение.",
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.FirstName == "Игорь" && c.LastName == null) == null)
            {
                var photo = new FileDto
                {
                    Name = "feedback/igor.png",
                    Info = "Игорь",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2015, 5, 30),
                    FirstName = "Игорь",
                    Message = "Это пока лучший центр, где я обучался.",
                    PhotoId = photo.Id
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Sorokina" && c.FirstName == "Alexandra") == null)
            {
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2015, 2, 5),
                    LastName = "Sorokina",
                    FirstName = "Alexandra",
                    SourceId = (int) FeedbackSourceEnum.Fb,
                    Message = "Учусь в школе в настоящее время!Восторг!!!! Каждый раз, как на праздник ✌️",
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Zimina" && c.FirstName == "Luba") == null)
            {
                var photo = new FileDto
                {
                    Name = "feedback/zimina_luba.jpg",
                    Info = "Luba Zimina",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2015, 4, 26),
                    LastName = "Zimina",
                    FirstName = "Luba",
                    Message =
                        "Учусь в этой школе почти 2 года. Дружеская, семейная атмосфера, небольшие группы. Преподают носители языка. На занятиях очень интересно и весело. Эффект есть, в Испании свободно разговариваю, почти нет языкового барьера. Учусь у Орьола. Всем рекомендую!",
                    PhotoId = photo.Id
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.FirstName == "Анастасия" && c.LastName == null) == null)
            {
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2015, 12, 12),
                    FirstName = "Анастасия",
                    SourceId = (int) FeedbackSourceEnum.Worksheet,
                    Message =
                        "В Целом, занятия оправдали мои ожидания. Мой преподаватель умел донести материал, всегда был готов к уроку и оставил только положительные впечатлеия. Очень рада, что в моей группе преподавал именно он!",
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Лукашев" && c.FirstName == "Виталий") == null)
            {
                var photo = new FileDto
                {
                    Name = "feedback/lukashev_vitalij.jpg",
                    Info = "Виталий Лукашев",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2016, 2, 10),
                    LastName = "Лукашев",
                    FirstName = "Виталий",
                    Message =
                        "Я изучаю испанский язык в школе уже 4-й год и на каникулах решил подтянуть свои знания. Мне очень понравилось, что учительница спокойная, никогда не ругала за ошибки, а просто и понятно объясняла недочёты. Осталось приятное ощущение от общения. При случае обращусь опять за помощью.",
                    PhotoId = photo.Id
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.FirstName == "Андрей, Света, Аня, Соня") == null)
            {
                var photo = new FileDto
                {
                    Name = "feedback/andrej_sveta_tanja_sonja.jpg",
                    Info = "Андрей, Света, Аня, Соня",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2016, 1, 10),
                    FirstName = "Андрей, Света, Аня, Соня",
                    Message =
                        @"Дорогой Vamos! С удовольствием занимаемся у вас всей семьей, и прогресс налицо - всего через два месяца после того, как мы начали 'с нуля', уже общались в Испании с живыми испанцами на разные темы, включая разговор в автосалоне по поводу тест-драйва и беседу в банке, а рестораны вообще не представляют никакой проблемы 
Нам очень нравятся наш el profesor - Йосу.Уроки интересные,
живые,
и,
как мы уже сказали,
полезные и ориентированные на 'быстрый запуск' разговорных навыков.С точки зрения грамматики мы уже знаем целых 5 времен,
что позволяет понимать общий смысл оригинальных текстов.
Мы рады,
что нашли ваш центр,
и верим,
что с вашей помощью сможем достичь того уровня владения языком,
с которого можно будет продолжать совершенствоваться и самостоятельно.Спасибо!",
                    PhotoId = photo.Id
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Родина" && c.FirstName == "Анна") == null)
            {
                var photo = new FileDto
                {
                    Name = "feedback/rodina_anna.png",
                    Info = "Родина Анна",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2016, 1, 17),
                    LastName = "Родина",
                    FirstName = "Анна",
                    Message =
                        "Я обучалась в течении 3-х лет (правда, с перерывами в обучении), у разных преподавателей. Мне очень трудно было первые два-три урока, но потом, н мере увелечения словарного запаса - легче. Очень нравится, что преподаватели - носители языка - это заставляет напрягаться, думать, искать синонимы, не не говорить по-русски. Атмосфера в классе дружелюбная, почти семейная, заниматься интересно.",
                    PhotoId = photo.Id
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Ластенкова" && c.FirstName == "Анжелика") == null)
            {
                var photo = new FileDto
                {
                    Name = "feedback/lastenkova_angylika.jpg",
                    Info = "Анжелика Ластенкова",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2016, 2, 15),
                    LastName = "Ластенкова",
                    FirstName = "Анжелика",
                    Message =
                        "Я начала изучать испанский язык с нуля. Никогда не думала,что изучать язык может быть так познавательно, весело и захватывающе, т.к. из школьного детства всплывали совершенно другие воспоминания. Всем рекомендую эту школу испанского языка! Приходите заниматься, не бойтесь открывать новые страницы своей жизни!",
                    PhotoId = photo.Id
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Трубилова" && c.FirstName == "Ольга") == null)
            {
                var photo = new FileDto
                {
                    Name = "feedback/trubilova_olga.jpg",
                    Info = "Ольга Трубилова",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2016, 3, 5),
                    LastName = "Трубилова",
                    FirstName = "Ольга",
                    Message =
                        "Учусь в школе с октября 2015г. практически с нуля. До этого три месяца занималась с репетитором, не понравилось категорически. В школе все совершенно иначе: у нас потрясающий преподаватели, обладающие фантастическим терпением, очень внятно все объясняющие и безгранично добрые. При этом постоянно хвалят и поддерживают. Готовы повторять и исправлять миллион раз, с отличным здоровым чувством юмора, весьма изобретательны и артистичны: споют, станцуют, принесут какое-нибудь занимательное кино. У них широкий кругозор, на каждом уроке обязательно расскажут какие-то интересные факты и истории. Т.е. мы не только учим испанский, но еще узнаем много нового и интересного. У нас потрясающая группа: на уроках царит дружелюбная атмосфера, мы очень много смеемся, фонтанируем какими-то идеями. В общем, занятия испанским языком в школе VAMOS это и знания, и досуг, и знакомство с новыми людьми, и расширение кругозора. Большое спасибо также администраторам школы! С ними всегда можно связаться по любому вопросу и на все получить ответ и помощь. Все сотрудники школы очень добрые и позитивные люди. И даже если вы придете на занятие уставшим, взвинченным и нервным, то выйдете с урока с улыбкой!",
                    PhotoId = photo.Id
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(
                    c => c.FirstName == "Татьяна"
                         && c.Date == new DateTime(2016, 3, 17)) == null)
            {
                var photo = new FileDto
                {
                    Name = "feedback/tatjana.jpg",
                    Info = "Татьяна",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2016, 3, 17),
                    FirstName = "Татьяна",
                    Message =
                        "Я выбирала курсы испанского через Интернет и нисколько не разочаровалась! Мне нравится и все подходит: и месторасположение, и время занятий, и класс, и компания, и продолжительность урока, и наполнение, и темп, и конечно наш преподаватель. У него несомненно талант преподавания. Каждое занятие с ним - это восторг! Очень тяжело после рабочего дня приходить в класс и усваивать что-то новое, приходится заставлять себя. Но стоит прийти и включиться - вся усталость пропадает! Наш преподаватель бесконечно терпелив и неизменно доброжелателен с каждым. Считаю, мне очень повезло! Кроме того, у нас подобралась отличная группа, мне нравятся все ребята, хочется учиться с ними дальше. Спасибо Наталье за оперативное решение всех вопросов и отличную организацию занятий!",
                    PhotoId = photo.Id
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Чурина" && c.FirstName == "Маргарита") == null)
            {
                var photo = new FileDto
                {
                    Name = "feedback/churova_margarita.png",
                    Info = "Маргарита Чурина",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2016, 4, 11),
                    LastName = "Чурина",
                    FirstName = "Маргарита",
                    Message =
                        "Я ещё не закончила заниматься на курсах, но уже поняла, что мой выбор был абсолютно правильным! Сначала я хотела позаниматься только на начальном уровне, но мне так понравилось, что я решила продолжить. Я более 30 лет преподаю английский язык и разбираюсь в методиках. На наших курсах методика самая лучшая! Мой преподаватель Йосу очень хороший и ответственный учитель, мне нравится, как он нас обучает. Йосу любит свою работу, и это всегда видно ученикам и мотивирует их на учёбу. Я желаю и Йосу, и всем остальным преподавателям наших курсов успехов в работе, и пусть к вам не зарастает народная тропа!",
                    PhotoId = photo.Id
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(c => c.LastName == "Фаримжанова" && c.FirstName == "Динара") == null)
            {
                var photo = new FileDto
                {
                    Name = "feedback/farimjanova_dinara.jpg",
                    Info = "Фаримжанова Динара",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2017, 6, 3),
                    LastName = "Фаримжанова",
                    FirstName = "Динара",
                    Message =
                        "Я была в Испании с октября по январь, и вот теперь опять я здесь с конца апреля. Курсы мне конечно очень и очень помогли, Рафа дал отличную основу, он отличный Учитель! Когда я была здесь осенью, я ходила на местные курсы для иностранцев, там Учитель постоянно говорит быстро на испанском, понимай, как хочешь, но через какое-то время начинаешь общаться как-то от неизбежности. И опять же, конечно, без Вашей школы и Рафы я бы там вообще ничего не поняла, ходила постоянно с нашими распечатками и тетрадями Я, кстати, рекомендовала нашу школу одной мое знакомой, она тоже хотела учить испанский Спасибо, что вы такие внимательные! Всегда на связи с учениками! Это здорово! Рафе от меня большой привет!",
                    PhotoId = photo.Id
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(
                    c => c.LastName == "Шишканова"
                         && c.FirstName == "Екатерина"
                         && c.Date ==  new DateTime(2016, 9, 19)) == null)
            {
                var photo = new FileDto
                {
                    Name = "feedback/shishkanova_ekaterina.png",
                    Info = "Екатерина Шишканова",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2016, 9, 19),
                    LastName = "Шишканова",
                    FirstName = "Екатерина",
                    Message =
                        "Этим летом я поехала учить испанский в Валенсию. Очень приятная школа испанского языка…. Хорошее сочетание высокого уровня образования и красивого и жаркого города с отличными пляжами. Я училась там в течении 3-х недель и заметно подтянула свой уровень испанского! Валенсия- очень приятный город, школа располагается в самом центре, в симпатичном квартале, в пешей доступности от всех достопримечательностей, город- не дорогой и люди очень открытые и дружелюбные. И можно бегать в парке с другими помешенными на спорте людьми, как никогда… Спасибо International House Valencia за чудесный опыт! Спасибо моей школе испанского языка в Москве (Vamos), которая мне посоветовала поехать в Валенсию! Незабываемые впечатления!",
                    PhotoId = photo.Id
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(
                    c => c.LastName == null && c.FirstName == null
                         && c.Date == new DateTime(2018, 2, 1)) == null)
            {
                var photo = new FileDto
                {
                    Name = "feedback/noname.jpg",
                    Info = "",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2018, 2, 1),
                    Message =
                        "Добрый день! Пишу Вам из Сантьяго:) Оказалось, у меня хороший испанский, я могу сама покупать поездки, еду и перемещаться, меня прекрасно понимают:) А в школе испанского были удивлены, что этот уровень я освоила за ваших 2,5 курса. Ещё раз спасибо большое за базу, только здесь поняла, что разговариваю на испанском.",
                    PhotoId = photo.Id
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
            
            if (context.Feedbacks.FirstOrDefault(
                    c => c.LastName == "Шишканова" && c.FirstName == "Екатерина"
                         && c.Date == new DateTime(2018, 12, 5)) == null)
            {
                var photo = new FileDto
                {
                    Name = "feedback/shishkanova_ekaterine_2.jpg",
                    Info = "Екатерина Шишканова",
                };
                context.Files.Add(photo);
                context.SaveChanges();
                
                var feedback = new FeedbackDto
                {
                    Date = new DateTime(2018, 12, 5),
                    LastName = "Шишканова",
                    FirstName = "Екатерина",
                    Message =
                        "Я занималась в школе Vamos около года. Обучение было очень продуктивным и интересным - все уроки буквально на одном дыхании. Огромное спасибо Рафаэлю, Анхелю и Альберто за это! Сейчас я продолжаю обучение в Испании и очень уверенно чувствую себя на занятиях. Местные жители думают, что я училась минимум лет 5 и очень удивляются, когда я говорю, что всего год в России. Если сравнивать обучение в школе Vamos и в испанской школе, то могу сказать, что по многим параметрам (цена, индивидуальный подход, использование игровых практик и тд) учеба в школе Vamos лучше. Рекомендую всем! Удачи в изучении испанского!",
                    PhotoId = photo.Id
                };
                context.Feedbacks.Add(feedback);
                context.SaveChanges();
            }
        }
    }
}