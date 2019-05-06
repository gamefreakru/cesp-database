using System;
using System.Linq;
using CESP.Database.Context;
using CESP.Database.Context.Activities.Models;
using CESP.Database.Context.Files.Models;

namespace CESP.Database.Filler.Filling
{
    public static class ActivitySeed
    {
        public static void SeedActivities(this CespContext context)
        {
            if (context.Activities.Any())
            {
                return;
            }

            if (context.Activities.FirstOrDefault(
                    a => a.Name == "22-25 апреля Semana Santa") == null)
            {
                var photo = new FileDto
                {
                    Name = "activities/semana.jpeg",
                    Info = "Semana Santa",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var act = new ActivityDto
                {
                    Name = "22-25 апреля Semana Santa",
                    SysName = "semanasanta",
                    Start = new DateTime(2019, 4, 22),
                    End = new DateTime(2019, 4, 25),
                    Info =
                        @"14-19 апреля в Испании широко празднуется Страстная неделя (исп. Semana Santa) — неделя, предшествующая Пасхе, время проведения церковных праздников в Испании. По всей Испании ежедневно совершается множество религиозных процессий, проходящих маршрутами от церкви к церкви. Об этом подробно расскажет наш преподаватель Анхель",
                    PhotoId = photo.Id,
                };
                context.Activities.Add(act);
                context.SaveChanges();

                context.ActivityFiles.Add(new ActivityFilesDto
                {
                    ActivityId = act.Id,
                    FileId = photo.Id,
                });
                context.SaveChanges();
            }

            if (context.Activities.FirstOrDefault(
                    a => a.Name == "8 апреля - Встреча с представителями школы IH Españolé") == null)
            {
                var photo = new FileDto
                {
                    Name = "activities/valensia.jpeg",
                    Info = "IH Españolé",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var act = new ActivityDto
                {
                    SysName = "valensia",
                    Name = "8 апреля - Встреча с представителями школы IH Españolé",
                    Start = new DateTime(2019, 4, 8),
                    Info = @"<font color='orange'>В ВАЛЕНСИЮ СО СПЕЦИАЛЬНОЙ СКИДКОЙ</font></br>
                    <font color='red'>525€ за 2 недели</font> <font color='darkblue'>- курс и проживание в одноместной комнате в студенческих апартаментах. На презентации представители школы 'IH Españolé' разобьют ваши стереотипы об Испании и Валенсии в частности.</font></br>
                    <font color='red'>Valencia y todos sus secretos. ¡Lo que no está escrito en los libros sobre los españoles y los valencianos!</font></br>
                    <font color='darkblue'>Вы узнаете то, о чем не написано в книжках об испанцах и валенсийцах!</font>",
                    PhotoId = photo.Id,
                };
                context.Activities.Add(act);
                context.SaveChanges();
                
                context.ActivityFiles.Add(new ActivityFilesDto
                {
                    ActivityId = act.Id,
                    FileId = photo.Id,
                });
                context.SaveChanges();
            }

            if (context.Activities.FirstOrDefault(
                    a => a.Name == "7 апреля - Cocina Club") == null)
            {
                var photo = new FileDto
                {
                    Name = "activities/сolombian_cuisine.jpeg",
                    Info = "Колумбийская кухня",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var act = new ActivityDto
                {
                    SysName = "сolombian",
                    Name = "7 апреля - Cocina Club",
                    Start = new DateTime(2019, 4, 7, 13, 0, 0),
                    Info =
                        @"Готовы ли Вы к новому приключению в мир Латиноамериканской кухни? В эту пятницу мы отправимся в Колумбию, чтобы научиться готовить знаменитое блюдо колумбийской кухни – Патаконес. Не знаете что это? Приходите и получите уникальную возможность не только научиться готовить одно из самых популярных блюд Латинской Америки, попрактиковать свой испанский язык в веселой компании, а также отведать только что приготовленное Вами блюдо!
            </b><br/>
            <b>Когда: </b>7 апреля в 13.00<br/>
            <b>Где:</b> в школе испанского языка Vamos, Малый Каретный переулок д.11/1<br/>
            <b>Сколько стоит: </b>1200",
                    PhotoId = photo.Id,
                };
                context.Activities.Add(act);
                context.SaveChanges();
                
                context.ActivityFiles.Add(new ActivityFilesDto
                {
                    ActivityId = act.Id,
                    FileId = photo.Id,
                });
                context.SaveChanges();
            }

            if (context.Activities.FirstOrDefault(
                    a => a.Name == "Уже в эту пятницу мы приглашаем Вас в кулинарное приключение!") == null)
            {
                var photo = new FileDto
                {
                    Name = "activities/adventure.jpg",
                    Info = "кулинарное приключение",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var act = new ActivityDto
                {
                    SysName = "adventure",
                    Name = "Уже в эту пятницу мы приглашаем Вас в кулинарное приключение!",
                    Start = new DateTime(2019, 3, 15, 19, 0, 0),
                    ShortInfo =
                        "Вместе с нашим преподавателем Пабло Вы не только научитесь готовить одно из самых популярных блюд Латинской Америки: Качапас, но и получите возможность попрактиковать свой испанский язык в веселой компании, а также отведать только что приготовленное Вами блюдо!",
                    Info = @"<b>
                Уже в эту пятницу мы приглашаем Вас в кулинарное приключение! Вместе с нашим преподавателем Пабло Вы не только научитесь готовить одно из самых популярных блюд Латинской Америки: Качапас, но и получите возможность попрактиковать свой испанский язык в веселой компании, а также отведать только что приготовленное Вами блюдо!                 
            </b>

            <b>Когда: </b>15 марта в 19:00<br/>
            <b>Где:</b> в школе испанского языка Vamos, Малый Каретный переулок д.11/1<br/>
            <b>Сколько стоит: </b>БЕСПЛАТНО",
                    PhotoId = photo.Id,
                };
                context.Activities.Add(act);
                context.SaveChanges();
                
                context.ActivityFiles.Add(new ActivityFilesDto
                {
                    ActivityId = act.Id,
                    FileId = photo.Id,
                });
                context.SaveChanges();
            }

            if (context.Activities.FirstOrDefault(
                    a => a.Name ==
                         "Неизведанная Испания: Страна Басков. Встреча с представителями школы испанского языка LACUNZA") ==
                null)
            {
                var photo = new FileDto
                {
                    Name = "activities/lacunza.png",
                    Info = "LACUNZA",
                };
                context.Files.Add(photo);
                context.SaveChanges();


                var photo2 = new FileDto
                {
                    Name = "activities/lacunzaview.jpg",
                    Info = "LACUNZA sea",
                };
                context.Files.Add(photo2);
                context.SaveChanges();
                var photo3 = new FileDto
                {
                    Name = "activities/surfinglacunza.jpg",
                    Info = "LACUNZA surfing",
                };
                context.Files.Add(photo3);
                context.SaveChanges();

                var act = new ActivityDto
                {
                    SysName = "lacunza",
                    Name =
                        "Неизведанная Испания: Страна Басков. Встреча с представителями школы испанского языка LACUNZA",
                    Start = new DateTime(2018, 12, 2, 15, 0, 0),
                    ShortInfo =
                        "Посетите мероприятие и получите скидку 110 евро на обучение в Испании! </b><br/> Неформальная встреча с представителями школы испанского языка LACUNZA, находящейся в невероятном курортном городе Сан-Себастьян, который также называют Северной Жемчужиной из-за его богатой культуры, многовековой истории, живописной природы и популярности среди туристов со всего мира",
                    Info =
                        @"<b>Посетите мероприятие, забронируйте курс на весну до 1 января будущего года и получите скидку в 110 евро на обучение в Испании! </b></br></br>
            <b>Давно хотели поучиться в Испании, но все никак не могли решиться? Тогда это мероприятие отлично вам подойдет!</b><br/><br/>

            Школа испанского языкв LACUNZA находится в курортном городе Сан Себастьян, который по праву считается одним из самых красивыхгородов севера Испании. Школа имеет более чем 30-летний опыт преподавания испанского языка как иностранного и входит в составкрупнейшей международной сети независимых языковых школ International House, а также имеет аккредитацию IALC, Instituto Cervatnes<br/><br/>

            На встрече представители Lacunza расскажут вам про их школу, систему обучения, условия проживания, преподавателей и все-все, что вас могло интересовать в обучении в Испании<br/><br/>
            Они так же расскажут про испанский город Сан-Себастьян, в котором находится данная школа, ведь Сан-Себастьян – также называют Северной Жемчужиной из-за его богатой культуры, многовековой истории, живописной природы, и cейчасгород пользуется огромной популярностью среди туристов со всего мира. Сан Себастьян- излюбленное место любителей сёрфинга, поэтому Вы сможете совместить обучение с занятиями по сёрфингу или кулинарными курсами

            <br/><br/>

            <b>Когда: </b>2 декабря, 15:00<br/>
            <b>Где:</b> в школе испанского языка Vamos, Малый Каретный переулок д.11к2<br/>
            <b>Сколько стоит: </b>БЕСПЛАТНО",
                    PhotoId = photo.Id,
                };
                context.Activities.Add(act);
                context.SaveChanges();

                context.ActivityFiles.Add(new ActivityFilesDto
                {
                    ActivityId = act.Id,
                    FileId = photo.Id,
                });
                context.ActivityFiles.Add(
                    new ActivityFilesDto
                    {
                        ActivityId = act.Id,
                        FileId = photo2.Id,
                    });
                context.ActivityFiles.Add(
                    new ActivityFilesDto
                    {
                        ActivityId = act.Id,
                        FileId = photo3.Id,
                    });
                context.SaveChanges();
            }

            if (context.Activities.FirstOrDefault(
                    a => a.Name == "MALENA") == null)
            {
                var photo = new FileDto
                {
                    Name = "activities/malena.jpg",
                    Info = "MALENA",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var photo2 = new FileDto
                {
                    Name = "activities/malena2.jpg",
                    Info = "MALENA",
                };
                context.Files.Add(photo2);
                context.SaveChanges();

                var act = new ActivityDto
                {
                    SysName = "malena",
                    Name = "MALENA",
                    Start = new DateTime(2018, 3, 30, 20, 0, 0),
                    ShortInfo =
                        "Танцевально - музыкальный спектакль «Малена»- союз двух направлений в танце, музыке и вокале: Фламенко и Аргентинского Танго.",
                    Info =
                        @"Сюжет спектакля - известная Танго-песня «Малена», которая повествует о судьбе женщины, о любви и свободе, история, рассказанная в танце. <br/><br/>

            <b>Состав:</b><br/><br/>
            <b>Solo Tango orquesta </b>– российский танго-оркестр, покоривший мировой Танго-олимп, первый европейский танго-оркестр, которому рукоплескал Буэнос-Айрес.<br/><br/>

            Дебютное выступление коллектива состоялось 19 августа 2010 года на фестивале «Ночи Милонгеро» в Москве. В том же году Solo Tango orquesta стал победителем XXXV международного конкурса Festival Internazionale della fisarmonica (Кастельфидардо, Италия) в категории «Музыка Пьяццоллы». Позже к числу наград добавилась победы на международных конкурсах XXXXVIII International Accordion Competition (Клингенталь, Германия) и Libertango (Барнаул, Россия), а также специальная премия Фонда имени П. И. Чайковского в Москве.<br/><br/>

            Оркестр выступал на многочисленных крупнейших международных фестивалях танго и принимал участие концертных и театральных постановках! <br/><br/>

            <b>Владимир Слободин- испанская гитара.</b><br/>

            Дипломант международного конкурса, проходившего в городе Петрозаводск (Карелия). Победитель ежегодного международного фестиваля фламенко 'VIVA Espana' 2013 (г.Москва) в номинации 'Лучшее музыкальное исполнение'. Победитель международного конкурса 'Виртуозы гитары СПб 2017' в номинации фламенко гитара. Многократно принимал участие в фестивалях 'Северное Фламенко' (СПб) и 'Viva Espana' (Москва), и многое другое.<br/><br/>

            <b>Сергей Коняев - перкуссия</b> <br/>

            Лауреат Международного конкурса фламенко 'Viva Espana' в 2012г. -в составе коллектива 'Natalia Zaykova Compania', - 2013г.- в составе инструментального коллектива 'El Lobo Compania'.<br/>

            -Победитель конкурса перкуссионистов 'Gari Bej' (производитель кахонов), -2014г.- в номинации лучшее музыкальное исполнение' с коллективом испанского гитариста Тоно Алькальдэ (Tono Alcalde).<br/><br/>

            <b>Татьяна Шишкова - вокал</b><br/>

            Уникальная вокалистка, владеющая музыкальным жанром world music, исполняющая испанское фламенко так, как будто она только что прилетела из-за семи морей. Обладательница титула 'Голос Фламенко России', Татьяна легко и непринуждённо исполняет испанский, афро-кубинский фольклор, джаз, и это ещё не всё - такое нужно слышать вживую!<br/><br/>


            <b>Себастьян Санчес (Sebastian Sanchez)-танец фламенко</b><br/>

            Себастьян прожил много лет Андалусии, и фламенко стало его страстью и смыслом жизни. Он неустанно обучался и тренировался в Севилье и Хересе у таких знаменитых учителей как Rafael Campallo, Manuel Betanzos, Andrés Peña, Juan de los Reyes и Alejandro Granados. Себастьян неоднократно выступал на фламенко-фестивалях в России и Финляндии, а также участвовал в качестве главного танцора в спектаклях в Испании, Германии, Австралии, Новой Каледонии, Скандинавии, странах Прибалтики, Белоруссии и по всей России. Именно в России, в Москве он открыл собственную школу фламенко. Сейчас Себастьян делит свое время между Австралией, Испанией и остальной частью Европы. Он выступает, преподает и продолжает оттачивать свое мастерство в танце фламенко.<br/><br/>

            <b>Николаева Ольга и Дмитрий Кузнецов</b><br/>

            Чемпиона России по аргентинскому танго в номинации танго Эсценарио 2017 года, многократные финалисты чемпионата Европы по Танго в Италии и вице-чемпионы Европы в категории танго Эсценарио 2017 года, финалисты чемпионата Мира в Буэнос- Айресе 2015, 2016 и 2017 гг.в танго Эсценарио и танго Писта , входят в 20 -ку лучших пар мира по танго. Участники многочисленных проектов и концертов и танго- шоу Москвы , Санкт-Петербурга, Италии.<br/><br/>

            <b>Режисер спектакля: Сергей Тягунов</b>


        </p>

        <b>
            <a href='http://teatrium.ru/theater/antrepriza/malena/shedule/' target='_blank'>Купить билеты</a>
        </b>",
                    PhotoId = photo.Id,
                };
                context.Activities.Add(act);
                context.SaveChanges();

                context.ActivityFiles.Add(new ActivityFilesDto
                {
                    ActivityId = act.Id,
                    FileId = photo.Id,
                });
                context.ActivityFiles.Add(
                    new ActivityFilesDto
                    {
                        ActivityId = act.Id,
                        FileId = photo2.Id,
                    });
                context.SaveChanges();
            }

            if (context.Activities.FirstOrDefault(
                    a => a.Name == "Встреча с представителями школы испанского языка CLIC IH Sevilla y Cádiz") == null)
            {
                var photo = new FileDto
                {
                    Name = "activities/clic.jpg",
                    Info = "CLIC IH Sevilla y Cádiz",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var act = new ActivityDto
                {
                    SysName = "clic",
                    Name = "Встреча с представителями школы испанского языка CLIC IH Sevilla y Cádiz",
                    Start = new DateTime(2018, 2, 2, 19, 0, 0),
                    ShortInfo =
                        "Ждем всех желающих познакомиться со школой испанского языка CLIC IH и выиграть 2х недельное обучение в Испании!!",
                    Info =
                        @"<b>2 февраля в 19:00 ждем всех желающих познакомиться со школой испанского языка <a href='http://clic.es/es' target='_blank'>CLIC IH Sevilla y Cádiz</a></b> <br/> <br/>

                    Давно хотите изучать испанский язык в Испании? У вас есть вопросы или сомнения? А может быть вы уже на пол пути и ищете подходящую школу? Мы ждем вас на презентации школы CLIC IH Sevilla y Cádiz, где ее представители расскажут все о центре изучения Испанского языка CLIC IH.<br/>
                    <br/>


                    <b>Записаться:</b> 8 (495) 920 74 30 <br/>
                    <b>Когда:</b> 2 февраля в 19:00<br/>
                    <b>Где:</b> Центр испанского и каталанского языков centro Vamos (Малый Каретный переулок 11 стр 1)<br/>
                    <b>Стоимость:</b> вход свободный<br/> <br/><br/>

                    <b>СПЕЦИАЛЬНЫЙ БОНУС ДЛЯ ВСЕХ ПОСЕТИТЕЛЕЙ ВСТРЕЧИ: розыгрыш 2х недельного бесплатного обучения в школе CLIC IH!! </b>",
                    PhotoId = photo.Id,
                };
                context.Activities.Add(act);
                context.SaveChanges();
                
                context.ActivityFiles.Add(new ActivityFilesDto
                {
                    ActivityId = act.Id,
                    FileId = photo.Id,
                });
                context.SaveChanges();
            }

            if (context.Activities.FirstOrDefault(
                    a => a.Name == "Детский лагерь в школе Vamos") == null)
            {
                var photo = new FileDto
                {
                    Name = "activities/children_camp.jpg",
                    Info = "Детский лагерь",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var act = new ActivityDto
                {
                    SysName = "camp",
                    Name = "Детский лагерь в школе Vamos",
                    Start = new DateTime(2017, 6, 5),
                    End = new DateTime(2017, 6, 16),
                    ShortInfo =
                        "Мы рады объявить вам, что снова второй год подряд запускаем детский испанский лагерь! Ждем всех - всех к нам в лагерь, начните лето правильно!",
                    Info = @"<b>C 5 по 16 июня в нашей школе снова открывается детский испанский лагерь!</b><br/> <br/>


            Прошлый год показал нам, что лагерь даже в условиях города может быть интересным и увлекательным! <br/>
            Именно поэтому по многочисленным просьбам мы возобновляем Детский лагерь в нашем центре испанского языка! <br/>


            <b>В этом году условия остаются прежними: мы набираем группу детей от 9 до 13 лет</b><br/> <br/>


            Количество детей в группе будет от 5 до 7 человек.<br/>
            Время работы лагеря с понедельника по пятницу с 10 до 17.00 часов. Суббота, воскресенье выходные.<br/> <br/>


            <b>Ваши детки в течении двух недель полностью погрузятся в испанский язык и культуру!</b><br/>

            <b>Все мероприятия будут проходить на испанском языке!!</b><br/><br/>


            В программу лагеря входят:<br/> <br/>

            - утреннее 2-х часовое занятие по испанскому языку;<br/>
            - выезды в парки Москвы в сопровождении преподавателя и его помошника;<br/>
            - активные игры на свежем воздухе;<br/>
            - интеллектуальные игры;<br/>
            - занимательные экскурсии;<br/>
            - мануальные занятия, мастер классы по рисованию, сочинению сказок <br/> <br/>
            и многое другое!<br/> <br/>

            Вопрос питания будет обсуждаться дополнительно перед началом лагеря. В прошлом году питание была организовано в кафе на против нашего центра 'Квартира 44'<br/> <br/>


                    <b>Стоимость 2х недельной программы с обучением - 17 500 р.</b><br/> <br/>",
                    PhotoId = photo.Id,
                };
                context.Activities.Add(act);
                context.SaveChanges();
                
                context.ActivityFiles.Add(new ActivityFilesDto
                {
                    ActivityId = act.Id,
                    FileId = photo.Id,
                });
                context.SaveChanges();
            }

            if (context.Activities.FirstOrDefault(
                    a => a.Name == "Подготовка к экзаменам Selectividad или PAU в Испании") == null)
            {
                var photo = new FileDto
                {
                    Name = "activities/selectividad.jpg",
                    Info = "Selectividad",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var act = new ActivityDto
                {
                    SysName = "pau",
                    Name = "Подготовка к экзаменам Selectividad или PAU в Испании",
                    Start = new DateTime(2017, 1, 9),
                    End = new DateTime(2018, 5, 25),
                    ShortInfo =
                        @"Мечтаете поступить в Университет в Испании? Но не знаете что для этого нужно? В школe International House Valencia вам помогут подготовиться к специальным экзаменам необходимым для поступления!",
                    Info =
                        @"<b>Данный курс будет полезен и интересен всем тем, кто желает поступить в Университет Испании</b> <br/> <br/>

            Для поступления в Унивеститеты Испании необходимо сдать экзамены типа PAU и Selectividad. <br/>Программа, разработанная школой International House Valencia составлена таким образом, чтобы удовлетворить все пожелания студента, программа индивидуальна. <br/>
            Это быстрый и, главное, эффективный способ кторый поможет каждому поступить в Университеты Испании.<br/> <br/>


            <b>Самый главный показатель, что на сегодняшний день 100 % студентов школы, которые учились на курсах по подготовке к вступительным экзаменам в университет, успешно сдали экзамены и учатся в разных испанских вузах.
            <b> <br/> <br/>


            <a class='ssilka1' href='http://espanole.es/ru/kurs-po-podgotovke-k-vstupitelnim-ekzamenam-v-universitet'> Подробнее о программе </a> <br/> <br/>",
                    PhotoId = photo.Id,
                };
                context.Activities.Add(act);
                context.SaveChanges();
                
                context.ActivityFiles.Add(new ActivityFilesDto
                {
                    ActivityId = act.Id,
                    FileId = photo.Id,
                });
                context.SaveChanges();
            }
            
            if (context.Activities.FirstOrDefault(
                    a => a.Name == "Майские праздники в Валенсии") == null)
            {
                var photo = new FileDto
                {
                    Name = "activities/valencia_may.jpg",
                    Info = "Майские праздники в Валенсии",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var act = new ActivityDto
                {
                    SysName = "may",
                    Name = "Майские праздники в Валенсии",
                    Start = new DateTime(2017, 5, 1),
                    End = new DateTime(2017, 5, 13),
                    ShortInfo = "Проведите майские каникулы с пользой! 2 недели обучения в школе испанского языка International House Valencia! Присоединяйся!",
                    Info = @"<b> С 1 по 13 мая едем в Валенсию</b>, для изучения испанского языка в среде носителей в школе Internacional House Valencia:<br/> <br/>


            Валенсия - один из красивейших городов Испании, находящийся на побережье Cредиземного моря. Город полный солнечного тепла и света, город - история, не упустите возможность посетить его не просто как турист, но окунуться в его незабываемую атмосферу, и быть ее частью говоря на испанском языке.<br/> <br/>

            <b>В свободное от учебы время в Валенсии вы сможете провести с максимальной пользой в зависимости от ваших желаний:</b> <br/> <br/>

            - К вашем услугам большой выбор активных видов спорта: водные, пляжные такие так: флайборд, серфинг, снорклинг, дайвинг, пляжный волейбол и многое другое<br/>
            - Богатая культурная жизнь города (музеи, театры, парки)<br/>
            - Огромный выбор ресторанов с превосходной средиземноморской кухней<br/>
            - Самый крупный торговый центр Испании «Bonaire», в котором вы сможете насладиться увлекательным шоппингом<br/> <br/>

            и многое другое на любой самый притязательный вкус!!<br/><br/>

            <b>Мы предлагаем ехать с нами потому что:</b><br/>

            1. ЭТО ВЫГОДНО - при поездке в группе от нашей школы вы экономите от 50 до 170 € (в зависимости от типа проживания)<br/>
            2. Это весело - мы собираем людей, которым испанский язык важен, нужен и интересен, а с такими людьми скучать не придется=)<br/>
            3. Мы берем на себя организационные вопросы, вам нужно просто сказать «ДА!»<br/> <br/>

            <b> О важном:</b><br/>

            Стоимость поездки <b> 560 € </b> (стоимость указана за 2 недели с проживанием)<br/> <br/>

            <b>В стоимость 2-х недельной программы входят:</b><br/>

            1. Обучение (40 часов испанского языка с понедельника по пятницу 9.30-14.30)<br/>
            2. 8 культурных мероприятий<br/>
            3. Проживание (тип проживания вы выбираете сами)<br/> <br/>

            <b> В стоимость не входит:</b><br/>
            1. Авиаперелет <br/>
            2. Виза + визовые сборы <br/><br/>


            <b>ВСЕ УРОВНИ ОБУЧЕНИЯ (А1 - С2)</b> <br/> <br/>

            Если вы планируете поездку семьей и кто-то из вас не хочет изучать испанский, это не повод откладывать отдых!<br/>
            Позвоните нам, и мы рассчитаем вам индивидуальную стоимость за вычетом обучения =)<br/> <br/>

            <b>Так же мы рекомендуем Вам посетить встречу с представителями школы International Houce Valencia, которая состоится уже 7 апреля в Москве в нашем центре испанского и каталанского языков Vamos!</b><br/> <br/>
            На встрече вы сможете подробнее узнать про саму школу, обучение, проживание и многое-многое другое! <br/> <br/>


            <a class='ssilka1' href='vstrecha-s-predstaviteliami-international-house-valencia'> Подробнее о встрече с представителями International House Valencia </a><br/>
            <b> Для участников встречи скидка на проживание и обучение!</b><br/> <br/>

            <b>По всем вопросам звоните 8 (985) 765 40 00</b> <br/> <br/>

            Здесь вы можете ознакомиться с фотографиями всех видов проживания, предлагаемые школой<a href='https://www.dropbox.com/sh/pn8qssxmldopjny/AABDAxaBagq82lmwtlxqHgQ4a?dl=0'> посмотреть фотографии </a> <br/>

            Так же прилагаются программа мероприятий на протяжении 2-х недель и фотогаллерея студентов школы <a href='https://cloud.mail.ru/C2FC582B6FAD4EBA9ADB201963DC5CA8'> по ссылке</a> <br/>


            Презентация школы Internaional House Valencia <a href='https://cloud.mail.ru/public/2Krz/8C8g9RbVM'> познакомиться со школой </a> <br/>",
                    PhotoId = photo.Id,
                };
                context.Activities.Add(act);
                context.SaveChanges();
                
                
                var photo1 = new FileDto
                {
                    Name = "activities/valencia_may1.jpg",
                    Info = "Майские праздники в Валенсии",
                };
                context.Files.Add(photo1);
                context.SaveChanges();
                var photo2 = new FileDto
                {
                    Name = "activities/valencia_may2.jpg",
                    Info = "Майские праздники в Валенсии",
                };
                context.Files.Add(photo2);
                context.SaveChanges();

                context.ActivityFiles.Add(new ActivityFilesDto
                {
                    ActivityId = act.Id,
                    FileId = photo1.Id,
                });
                context.ActivityFiles.Add(new ActivityFilesDto
                {
                    ActivityId = act.Id,
                    FileId = photo2.Id,
                });
                context.SaveChanges();
            }
        }
    }
}