using System;
using System.Linq;
using CESP.Database.Context;
using CESP.Database.Context.Education.Models;
using CESP.Database.Context.Files.Models;

namespace CESP.Database.Filler.Filling
{
    public static class SpeakingSeed
    {
        public static void SeeSpeakingClub(this CespContext context)
        {
            if (context.SpeakingClubMeetings.FirstOrDefault(
                    s => s.Name == "Doble check") == null)
            {
                var photo = new FileDto
                {
                    Name = "club/doblecheck.jpg",
                    Info = "Doble check",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var teacherId = context.Teachers.FirstOrDefault(t => t.Name == "Рафаэль").Id;
                var club = new SpeakingClubMeetingDto
                {
                    SysName = "20190426",
                    Name = "Doble check",
                    ShortInfo =
                        "В век общения в интернете мы очень часто становимся зависимыми он социальных сетей и мессенджеров. Именно об этом рассказывается в короткометражном фильме «Doble check», который мы посмотрим вместе и обсудим его все вместе.",
                    Date = new DateTime(2019, 4, 26, 19, 0, 0), //26.04.2019
                    TeacherId = teacherId,
                    PhotoId = photo.Id,
                };
                context.SpeakingClubMeetings.Add(club);
                context.SaveChanges();
            }

            if (context.SpeakingClubMeetings.FirstOrDefault(
                    s => s.Name == "La igualdad de genero") == null)
            {
                var photo = new FileDto
                {
                    Name = "club/equality.jpg",
                    Info = "La igualdad de genero",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var teacherId = context.Teachers.FirstOrDefault(t => t.Name == "Рафаэль").Id;
                var minLevelId = context.LanguageLevels.FirstOrDefault(l => l.Name == "B1.2").Id;
                var maxLevelId = context.LanguageLevels.FirstOrDefault(l => l.Name == "B2.2").Id;
                var club = new SpeakingClubMeetingDto
                {
                    SysName = "20190301",
                    Name = "La igualdad de genero",
                    ShortInfo =
                        "В наше время равноправие стало одной из центральных тем для обсуждения. Вот и мы решили затронуть эту неоднозначную, но очень интересную для всех нас тему.",
                    Info = @"1. ¿Qué significa la iguaidad para ti? <br>
            2. ¿Quién tiene más derechos ahora: hombres o mujeres? <br>
            3. ¿Por qué el hombre tiene que pagar por la mujer en la cita? <br>
            4. ¿Por qué los hombres cobran más que las mujeres? <br>
            5. ¿Por qué los hombres se dedican solo a trabajar y las mujeres a trabajar, cocinar, limpiar y cuidar a los niños? <br>
            6. ¿Por qué existen los trabajos exclusivamente para los hombres? <br>
            7. ¿Por qué las mujeres ahora quieren independizarse tanto? <br>
            8. ¿Cuáles son las carecteristicas principales de la desigualidad en la sociedad? <br>
            9. ¿En tu casa hay desigualdad? <br>
            10. ¿En que paises hay mucha desigualdad y en que otros no existe? <br>",
                    Date = new DateTime(2019, 3, 1, 19, 0, 0),
                    TeacherId = teacherId,
                    MinLanguageLevelId = minLevelId,
                    MaxLanguageLevelId = maxLevelId,
                    PhotoId = photo.Id,
                };
                context.SpeakingClubMeetings.Add(club);
                context.SaveChanges();
            }

            if (context.SpeakingClubMeetings.FirstOrDefault(
                    s => s.Name == "El terrorismo") == null)
            {
                var photo = new FileDto
                {
                    Name = "club/terrorism.jpg",
                    Info = "El terrorismo",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var teacherId = context.Teachers.FirstOrDefault(t => t.Name == "Рафаэль").Id;
                var minLevelId = context.LanguageLevels.FirstOrDefault(l => l.Name == "B1.2").Id;
                var maxLevelId = context.LanguageLevels.FirstOrDefault(l => l.Name == "B2.2").Id;
                var club = new SpeakingClubMeetingDto
                {
                    SysName = "20190208",
                    Name = "El terrorismo",
                    ShortInfo =
                        "Обсудим очень актуальную тему в наше время тему - терроризм. Почему это явление происходит так часто именно сейчас? Можно ли предотвратить террористические атаки? На эти многие другие вопросы мы постараемся найти ответы в эту пятницу.",
                    Info = @"1.	¿Por qué crees la gente utiliza el terrorismo para conseguir lo que quiere? <br>
            2.	¿Qué acciones terroristas recuerdas? <br>
            3.	¿Recuerdas dónde te encontrabas y qué estabas haciendo? <br>
            4.	¿Qué crees que se debería hacer para prevenir el terrorismo? <br>
            5.	¿Te da miedo ser víctima de ataques terroristicas? <br>
            6.	¿Por qué crees que el terrorismo se utiliza más en unos países que en otros? <br>
            7.	¿Conoces otras formas de terrorismo además de las bombas? <br>
            8.	¿Crees que el uso del terrorismo está justificado? <br>
            9.	¿Crees que las compañías aéreas se hanvisto afectadas por el terrorismo? <br>
            10.	¿Crees que el control en los aeropuertos es demasiado exagerado? <br>
            11.	¿Crees que los actos terroristas son efectivos? <br>
            12.	¿Crees que un gobierno puede llevar a cabo actos terroristas? <br>
            13.	¿Cuál es la base del terrorismo? ¿Religión, nacionalismo..? <br>
            14.	¿Crees que siempre hay que culpar a la religión de los actos terroristas que se cometen? <br>
            15.	¿Puedes nombrar 3 grupos terroristas? <br>
            16.	¿Cómo crees que operan los grupos terroristas? <br>
            17.	¿Qué países han sido culpados por proteger a terroristas? <br>
            18.	¿Qué países han sido los más afectados por el terrorismo? <br>
            19.	¿Cómo crees que podemos luchar contra el terrorismo? <br>
            20.	¿Qúé es lo que pueden hacer los gobiernos para luchar contra el terrorismo? <br>
            21.	¿Crees que los gobiernos están luchando lo sufucuente contra el extremismo? <br>
            22.	¿Llegarías a cometer suicido por una cosa en la que creyeses completamente? <br>
            23.	¿Piensas que hay alguna manera de negociar con los terroristas? <br>
            24.	¿Qué crees que va a ocurrir en el futuro, desaparecerá el terrorismo o aumentará? <br>
            25.	¿Cómo crees que la gente se convierte en terrorista? <br>
            26.	¿Piensas que cometer abusos a un grupo de gente o a unas comunidades puede derivar en la aparación de terroristas? <br>",
                    Date = new DateTime(2019, 2, 8, 19, 0, 0),
                    TeacherId = teacherId,
                    MinLanguageLevelId = minLevelId,
                    MaxLanguageLevelId = maxLevelId,
                    PhotoId = photo.Id,
                };
                context.SpeakingClubMeetings.Add(club);
                context.SaveChanges();
            }

            if (context.SpeakingClubMeetings.FirstOrDefault(
                    s => s.Name == "El matrimonio") == null)
            {
                var photo = new FileDto
                {
                    Name = "club/wedding.jpg",
                    Info = "El matrimonio",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var teacherId = context.Teachers.FirstOrDefault(t => t.Name == "Рафаэль").Id;
                var minLevelId = context.LanguageLevels.FirstOrDefault(l => l.Name == "B1.2").Id;
                var maxLevelId = context.LanguageLevels.FirstOrDefault(l => l.Name == "B2.2").Id;
                var club = new SpeakingClubMeetingDto
                {
                    SysName = "20190125",
                    Name = "El matrimonio",
                    ShortInfo =
                        "Обсудим вопрос брака, женитьбы, супружеста, союза двух любящих людей! В наш век понятие брака видоизменятся и модифицируется с каждым днем, и нам, безусловно, интересно Ваше мнение, дорогие друзья! Во сколько лет нужно выходить замуж (жениться), что вы думаете вообще по поводу брака в целом, что хорошего в браке? И что хорошего в том, чтобы быть одному? Все это обсудим уже в эту пятницу! Приходите, ждем Вас!",
                    Info = @"1. ¿Cuál crees que es la mejor edad para el matrimonio? <br/>
            2. ¿A qué edad te gustaría casarte? <br/>
            3. ¿Qué opinas de los matrimonios concertados? <br/>
            4. ¿Crees que el matrimonio es para toda la vida? <br/>
            5. ¿Qué opinas del divorcio? <br/>
            6. ¿Piensas que casarse significa perder libertad? <br/>
            6. ¿Crees que tras casarse cambiarás de alguna manera? <br/>
            7. ¿Qué es más importante para ti, un buen matrimonio o tu carrera? <br/>
            8. ¿Qué piensas que es mejor, estar soltero o casado? <br/>
            9. ¿Qué es lo bueno de estar soltero? <br/>
            10. ¿Qué es lo bueno de estar casado? <br/>
            11. ¿Crees que es bueno para una pareja vivir juntos antes de formalizar su matrimonio? <br/>
            12. ¿Piensas que el amor es necesario en un matrimonio? <br/>
            13. ¿Crees que los matrimonios basados en el amor tienen más posibilidades de durar? <br/>
            14. ¿Crees que es complicado casarse con una persona de diferente raza o religión? <br/>
            15. ¿Piensas que el matrimonio es algo necesario? <br/>
            16. ¿Crees que el matrimonio es algo muy estresante para las mujeres? ¿Y para los hombres? <br/>
            17. ¿Crees que tu marido o mujer debería ser mayor, menor o tener la misma edad que tú? <br/>
            18. ¿Quieres tener hijos? ¿Cuántos te gustaría tener? <br/>
            19. ¿Cuánto tiempo crees que las parejas se deberían conocer antes de contraer matrimonio? <br/>
            20. ¿Crees que es importante que tu familia acepte a tu marido o mujer? <br/>
            21. ¿Cuáles son las razones principales por las cuales la gente se separa o divorcia? <br/>
            22. ¿Qué opinas de la gente que se divorcia? ¿Lo considerarías como una posibilidad? <br/>
            23. ¿Qué cualidades crees que son importantes en una pareja? <br/>
            25. ¿Qué opinas sobre los matrimonios entre personas del mismo sexo? <br/>
            26. ¿Y qué opinas de las madres solteras? <br/>
            27. ¿Cómo crees que se debe celebrar un matrimonio o una boda? <br/>
            28. ¿Qué es lo que convierte a una persona en un buen marido o mujer? <br/>",
                    Date = new DateTime(2019, 1, 25, 19, 0, 0),
                    TeacherId = teacherId,
                    MinLanguageLevelId = minLevelId,
                    MaxLanguageLevelId = maxLevelId,
                    PhotoId = photo.Id,
                };
                context.SpeakingClubMeetings.Add(club);
                context.SaveChanges();
            }

            if (context.SpeakingClubMeetings.FirstOrDefault(
                    s => s.Name == "La amistad") == null)
            {
                var photo = new FileDto
                {
                    Name = "club/friendship.jpeg",
                    Info = "La amistad",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var teacherId = context.Teachers.FirstOrDefault(t => t.Name == "Рафаэль").Id;
                var minLevelId = context.LanguageLevels.FirstOrDefault(l => l.Name == "B1.2").Id;
                var maxLevelId = context.LanguageLevels.FirstOrDefault(l => l.Name == "B2.2").Id;
                var club = new SpeakingClubMeetingDto
                {
                    SysName = "20181114",
                    Name = "La amistad",
                    ShortInfo =
                        "Говорят, что дружба между мужчиной и женщиной, как жизнь на Марсе — явление предполагаемое, но трудно доказуемое. Существует ли дружба между мужчиной и женщиной? От чего зависит вероятность появления такого явления? А если добавить к этому еще и разницу в возрасте? Об этом и многом другом поговорим в пятницу. Хотели бы выразить свое мнение по этой теме? Может быть Вы сами сталкивались с этим? Ждем вас!",
                    Info = @"1. Qué es la amistad para ti? <br/>
                    2. Es fácil para ti hacer amigos? <br/>
                    3. Q te parece, eres buen/a amigo/a? Por qué? <br/>
                    4. Dicen que es más fácil hacer amigos cuando eres el niño, que cuando eres mayor. Estas de acuerdo? Por qué? <br/>
                    5. Alguna vez has estado enamorado de tu amigo/a? Cuéntanos<br/>
                    6. Alguna vez has estado en la situación cuando tu amigo/a estaba enamorado/de ti? Cuentanos<br/>
                    7. La diferencia de edad enriquece la amistad? <br/>
                    8. ¿Un hombre y una mujer pueden ser amigos?<br/>
                    9. ¿Si hay atracción no hay amistad?<br/>
                    10. ¿Al hombre le cuesta más tener amigas que a la mujer tener amigos?<br/>
                    11. Cuando una tiene una aventura con un amigo, después ¿es posible retomar la amistad?<br/>
                    12. ¿Tienes muchos amigos del sexo opuesto?<br/>
                    13. ¿Sabes qué dice la ciencia de los amigos del sexo opuesto?<br/>
                    14. ¿Hay algunos beneficios de ser amigos del sexo opuesto?<br/>",
                    Date = new DateTime(2018, 11, 14, 19, 0, 0),
                    TeacherId = teacherId,
                    MinLanguageLevelId = minLevelId,
                    MaxLanguageLevelId = maxLevelId,
                    PhotoId = photo.Id,
                };
                context.SpeakingClubMeetings.Add(club);
                context.SaveChanges();
            }

            if (context.SpeakingClubMeetings.FirstOrDefault(
                    s => s.Name == "Vamos de viaje") == null)
            {
                var photo = new FileDto
                {
                    Name = "club/adventure.jpeg",
                    Info = "Vamos de viaje",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var teacherId = context.Teachers.FirstOrDefault(t => t.Name == "Рафаэль").Id;
                var minLevelId = context.LanguageLevels.FirstOrDefault(l => l.Name == "A2.1").Id;
                var maxLevelId = context.LanguageLevels.FirstOrDefault(l => l.Name == "B1.1").Id;
                var club = new SpeakingClubMeetingDto
                {
                    SysName = "20181107",
                    Name = "Vamos de viaje",
                    ShortInfo =
                        "«Истинное назначение вашего путешествия- это не место на карте, а новый взгляд на мир»- Генри Миллер. Согласны ли Вы с этим утверждением? Что такое «путешествие» для Вас? Об этом поговорим на нашей встрече в пятницу! Приходите и выразите Ваше мнение! Ждем вас!",
                    Date = new DateTime(2018, 11, 7, 19, 0, 0),
                    TeacherId = teacherId,
                    MinLanguageLevelId = minLevelId,
                    MaxLanguageLevelId = maxLevelId,
                    PhotoId = photo.Id,
                };
                context.SpeakingClubMeetings.Add(club);
                context.SaveChanges();
            }

            if (context.SpeakingClubMeetings.FirstOrDefault(
                    s => s.SysName == "20171215") == null)
            {
                var photo = new FileDto
                {
                    Name = "club/christmas.jpg",
                    Info = "Cine y vino",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var teacherId = context.Teachers.FirstOrDefault(t => t.Name == "Пабло").Id;
                var minLevelId = context.LanguageLevels.FirstOrDefault(l => l.Name == "B1.2").Id;
                var maxLevelId = context.LanguageLevels.FirstOrDefault(l => l.Name == "B2.2").Id;
                var club = new SpeakingClubMeetingDto
                {
                    SysName = "20171215",
                    Name = "Cine y vino",
                    ShortInfo = @"Приглашаем окунуться в Рождественскую атмосферу уже в эту пятницу!
                    Все мы знаем прекрасный фильм  «‎Рождественская История». Приглашаем вас посмотреть испанскую версию этого кино и поговорить о таком чудесном и всеми любимом празднике как Рождество. Ждем вас!",
                    Date = new DateTime(2017, 12, 15, 19, 0, 0),
                    TeacherId = teacherId,
                    MinLanguageLevelId = minLevelId,
                    MaxLanguageLevelId = maxLevelId,
                    PhotoId = photo.Id,
                };
                context.SpeakingClubMeetings.Add(club);
                context.SaveChanges();
            }

            if (context.SpeakingClubMeetings.FirstOrDefault(
                    s => s.SysName == "20171201") == null)

            {
                var photo = new FileDto
                {
                    Name = "club/12people.jpg",
                    Info = "Cine y vino",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var teacherId = context.Teachers.FirstOrDefault(t => t.Name == "Пабло").Id;
                var club = new SpeakingClubMeetingDto
                {
                    SysName = "20171201",
                    Name = "Cine y vino",
                    ShortInfo =
                        "Друзья, мы решили вернуться к формату КИНО и ВИНО и ждем всех в первый зимний день на наш разговорный клуб! В программе просмотр части фильма «12 hombres sin piedad», его обсуждение...Но не просто разговор, а дебаты! Не будем раскрывать вам все подробности, но будет очень интересно! Ждем вас!",
                    Date = new DateTime(2017, 12, 1, 19, 0, 0),
                    TeacherId = teacherId,
                    PhotoId = photo.Id,
                };
                context.SpeakingClubMeetings.Add(club);
                context.SaveChanges();
            }

            if (context.SpeakingClubMeetings.FirstOrDefault(
                    s => s.Name == "Amor en la red") == null)
            {
                var photo = new FileDto
                {
                    Name = "club/love.jpg",
                    Info = "Amor en la red",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var teacherId = context.Teachers.FirstOrDefault(t => t.Name == "Рафаэль").Id;
                var club = new SpeakingClubMeetingDto
                {
                    SysName = "20171103",
                    Name = "Amor en la red",
                    ShortInfo =
                        "Очень актуальная тема XXI века, любовь в сети. В век технологий по интернету найти можно все, даже ... любовь! Не верите, приходите к нам на разговорный клуб и поделитесь своим мнением! Мы ждем вас!",
                    Info = @"¿Crees que es posible enamorarse de alguien que solo conoces por Internet?<br/>

                        ¿Qué estarías dispuesto a hacer por amor?<br/>

                    ¿Crees que nos enamoramos siempre de alguien similar a nuestro padre o madre? <br/>

                    ¿Cuáles son las señales de que estás enamorado?<br/>
                    ¿Qué es para ti el amor romántico? ¿Conoces<br/>

                    alguno de sus tópicos? ¿Qué consecuencias puede tener este modelo en una pareja?<br/>

                    ¿Por qué nos enamoramos? ¿Por qué nos desenamoramos?<br/>

                    ¿Buscamos amor en internet o lo que queremos primero es sexo?<br/>

                    ¿Has hecho alguna vez alguna locura por amor? <br/>",
                    Date = new DateTime(2017, 11, 3, 19, 0, 0),
                    TeacherId = teacherId,
                    PhotoId = photo.Id,
                };
                context.SpeakingClubMeetings.Add(club);
                context.SaveChanges();
            }

            if (context.SpeakingClubMeetings.FirstOrDefault(
                    s => s.Name == "Háblame de tu amigo ideal") == null)
            {
                var photo = new FileDto
                {
                    Name = "club/friendshipOld.jpg",
                    Info = "Háblame de tu amigo ideal",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var teacherId = context.Teachers.FirstOrDefault(t => t.Name == "Рафаэль").Id;
                var club = new SpeakingClubMeetingDto
                {
                    SysName = "20171027",
                    Name = "Háblame de tu amigo ideal",
                    ShortInfo =
                        "«Старый друг лучше новых двух», гласит поговорка, а как вы относитесь к теме дружбы? Много ли у вас друзей? Зачем дружба вообще нужна и почему ее стоит беречь. Об этом и многом другом поговорим в пятницу. Мы ждем вас!",
                    Info = @"Háblame de tu mejor amigo de la infancia<br/>

                        ¿Cuántos amigos crees que se puede tener? <br/>

                    ¿Hay algo que nunca le pedirías a un amigo?<br/>


                    ¿Y hay algo que nunca aceptarías si te lo pidiera un amigo?<br/>

                    ¿Es compatible tener pareja con tener amigos?<br/>

                    ¿Los amigos de mi pareja tienen que ser mis amigos y viceversa?<br/>

                    ¿Es posible tener muchos amigos en las redes sociales? ¿Qué opinas de los que tienen miles de amigos en las redes sociales?<br/>

                    ¿Qué amistades merece la pena conservar? <br/>

                    ¿Cómo es posible mantener una amistad?<br/>

                    ¿Por qué motivo dejarías de ser amigo de alguien? <br/>

                    ¿ Los hombres buscan amistad con una mujer porque sí o por que su objetivo es otro ?<br/>",
                    Date = new DateTime(2017, 10, 27, 19, 0, 0),
                    TeacherId = teacherId,
                    PhotoId = photo.Id,
                };
                context.SpeakingClubMeetings.Add(club);
                context.SaveChanges();
            }
        }
    }
}