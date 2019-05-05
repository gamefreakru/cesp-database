using System.Linq;
using CESP.Database.Context;
using CESP.Database.Context.Files.Models;
using CESP.Database.Context.Partners.Models;

namespace CESP.Database.Filler.Filling
{
    public static class PartnerSeed
    {
        public static void SeedPartners(this CespContext context)
        {
            if (context.Partners.FirstOrDefault(c => c.SysName == "asador") == null)
            {
                var photo = new FileDto
                {
                    Name = "partners/asador.jpg",
                    Info = "El Asador",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var partner = new PartnerDto
                {
                    SysName = "asador",
                    Name = "El Asador",
                    Url = "http://asador.ru/",
                    Info =
                        @"El Asador - это маленькая Испании в центре нашего города, в котором вам предложат познакомиться с северо-испанской кухней. Эта кухня имеет мировую известность, а кулинары Страны Басков в рейтинге занимают первые места в десятке лучших кулинаров планеты. В El Asador утонченная баскская кухня идет нога в ногу с древнейшей и богатейшей наваррской. Многие их блюда готовятся в традиционной испанской глиняной печи на на душистых ольховых дровах. И эту пищу без сомнения можно назвать здоровой, ведь при таком приготовлении сохраняются все полезные свойства продуктов. Да, и кстати, блюда томленые в печи всегда необыкновенно сочные и нежные. Чурраско, пинчос, тапас, утка, голяшка молодого ягненка из печи, бакалао или уникальные морепродукты, каждое блюдо приготовлено в лучших чертах северо-испанской кухни. <br><br>
                    Ну и конечно же 9 сортов вкуснейшего сидра St. Anton, приготовленного ими собственноручно по древнейшим рецептам Страны Басков, не оставят вас равнодушными. <br><br>
                    По пятницам в сидрерии всегда проходят концерты живой испанской музыки. А по праздничным дням проводят тематические мероприятия, фестивали и другие яркие вечеринки.",
                    PhotoId = photo.Id,
                    Address = "Россия, г. Москва, ул. Большая Ордынка, д.45/8 (м. Третьяковская)",
                    Phone = "+7 495 953‑15-64, +7 495 953‑14-18",
                };
                context.Partners.Add(partner);
                context.SaveChanges();

                var photo1 = new FileDto
                {
                    Name = "partners/asador_hall.jpg",
                    Info = "El Asador",
                };
                context.Files.Add(photo1);
                context.SaveChanges();

                var photo2 = new FileDto
                {
                    Name = "partners/asador_corner.jpg",
                    Info = "El Asador",
                };
                context.Files.Add(photo2);
                context.SaveChanges();

                var photo3 = new FileDto
                {
                    Name = "partners/asador_white.jpg",
                    Info = "El Asador",
                };
                context.Files.Add(photo3);
                context.SaveChanges();

                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo1.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo2.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo3.Id,
                    });
                context.SaveChanges();
            }

            if (context.Partners.FirstOrDefault(c => c.SysName == "mdk") == null)
            {
                var photo = new FileDto
                {
                    Name = "partners/mdk.jpg",
                    Info = "Московский Дом Книги",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var partner = new PartnerDto
                {
                    SysName = "mdk",
                    Name = "Московский Дом Книги",
                    Url = "http://www.mdk-arbat.ru/",
                    Info =
                        @"Один из крупнейших в Европе и самый большой в России Московский дом книги на Новом Арбате был открыт в 1967 году и с тех пор стал самым популярным книжным магазином нашего города Здесь регулярно проводят различные встречи с интересными и знаменитыми личностями: писателями, актерами и ведущими, мероприятия при поддержке Правительства Москвы, детские фестивали, образовательные программы, благотворительные акции в помощь детям. <br><br> Так же вы можете попасть на различные бесплатные мастер-классы от уроков по макияжу до изучения испанского языка, поиграть в настольные игры или литературную мафию.
                В «Московском Доме Книги» регулярно проходят видео показы и презентации наилучших творений отечественного и зарубежного кинематографа в рамках проекта «Реальное кино». <br><br>
                А так же на площадке Art-клуба «Переплет» вы можете окунуться в мир творческих людей, артистов Московских театров и кино, познакомиться с покупателями и зрителями и обрести новых друзей по интересам.",
                    PhotoId = photo.Id,
                    Address = "Россия, г. Москва, ул. Новый Арбат, д.8 (м. Арбатская)",
                    Phone = "+7 (495) 789-35-91 (сеть магазинов), +7 (495) 648-17-68 (интернет-магазин)",
                };
                context.Partners.Add(partner);
                context.SaveChanges();

                var photo1 = new FileDto
                {
                    Name = "partners/mdk_10.jpg",
                    Info = "Московский Дом Книги"
                };
                context.Files.Add(photo1);
                context.SaveChanges();
                var photo2 = new FileDto
                {
                    Name = "partners/mdk_darin.jpg",
                    Info = "Московский Дом Книги",
                };
                context.Files.Add(photo2);
                context.SaveChanges();
                var photo3 = new FileDto
                {
                    Name = "partners/mdk_go.jpg",
                    Info = "Московский Дом Книги",
                };
                context.Files.Add(photo3);
                context.SaveChanges();

                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo1.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo2.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo3.Id,
                    });
                context.SaveChanges();
            }

            if (context.Partners.FirstOrDefault(c => c.SysName == "vinniybazar") == null)
            {
                var photo = new FileDto
                {
                    Name = "partners/vinniybazar.jpg",
                    Info = "Винный базар на Садовой",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var partner = new PartnerDto
                {
                    SysName = "vinniybazar",
                    Name = "Винный базар на Садовой",
                    Url = "https://vinniybazar.ru/",
                    Info =
                        @"В Москве открылся первый Винный базар в формате тапас-бара. Более 20 видов классических тапас, тапинада, зеленые салаты, морепродукты и мясо. В винной подборке, собранной со всего света, также особое место отведено Испании: альбариньо, вердехо, монастрель, виура и другие испанские автохтоны собранны на наших полках. Стоимость бутылки от 750 рублей и бокала от 250 рублей.. Все это в интересном интерьере из винных стеллажей, с большим количеством акцентов. До встречи, друзья!",
                    PhotoId = photo.Id,
                    Address = "Россия, Москва, Большая Садовая, 1",
                    Phone = "8 (499) 341-43-00",
                };
                context.Partners.Add(partner);
                context.SaveChanges();
                
                var photo1 = new FileDto
                {
                    Name = "partners/vinniybazar_meal.jpg",
                    Info = "Винный базар на Садовой"
                };
                context.Files.Add(photo1);
                context.SaveChanges();

                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo1.Id,
                    });
                context.SaveChanges();
            }

            if (context.Partners.FirstOrDefault(c => c.SysName == "spicysalsa") == null)
            {
                var photo = new FileDto
                {
                    Name = "partners/spicysalsa.png",
                    Info = "Spicy Salsa",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var partner = new PartnerDto
                {
                    SysName = "spicysalsa",
                    Name = "Spicy Salsa",
                    Url = "https://www.spicy-salsa.ru/",
                    Info =
                        @"Spicy Salsa - одна из самых известных и ярких танцевальных школ нашего города. Там научат вас танцевать зажигательные одиночные и парные латиноамериканские танцы: сальсу, зумбу, бачатау, сольную латину, кизомбу, реггетон и модный в последнее время тверк. Занятия танцами способствуют улучшению пластики и чувству музыки, формируют стройную и изящную фигуру и осанку. Помогают вам превратиться в более уверенную и раскрепощенную личность.<br> <br> Латиноамериканские танцы это - позитивное и приятное общение в кругу увлеченных в танцевальный процесс людей, поэтому они регулярно проводят зажигательные вечеринки в клубах, ресторанах и различных площадках нашего города, организуют разнообразные танцевальные события, участвуют в телешоу и фестивалях.",
                    PhotoId = photo.Id,
                    Address = "Россия, г. Москва, ул. Малая Ордынка, д.25, (м. Третьяковская)",
                    Phone = "+7 (965) 107-48-35",
                };
                context.Partners.Add(partner);
                context.SaveChanges();

                var photo1 = new FileDto
                {
                    Name = "partners/spicysalsa_hall3.jpg",
                    Info = "Spicy Salsa"
                };
                context.Files.Add(photo1);
                context.SaveChanges();
                var photo2 = new FileDto
                {
                    Name = "partners/spicysalsa_hall2.jpg",
                    Info = "Spicy Salsa"
                };
                context.Files.Add(photo2);
                context.SaveChanges();
                var photo3 = new FileDto
                {
                    Name = "partners/spicysalsa_people.jpg",
                    Info = "Spicy Salsa"
                };
                context.Files.Add(photo3);
                context.SaveChanges();
                var photo4 = new FileDto
                {
                    Name = "partners/spicysalsa_men.jpg",
                    Info = "Spicy Salsa"
                };
                context.Files.Add(photo4);
                context.SaveChanges();

                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo1.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo2.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo3.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo4.Id,
                    });
                context.SaveChanges();
            }


            if (context.Partners.FirstOrDefault(c => c.SysName == "panspain") == null)
            {
                var photo = new FileDto
                {
                    Name = "partners/panspain.png",
                    Info = "PanSpain Group",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var partner = new PartnerDto
                {
                    SysName = "panspain",
                    Name = "PanSpain Group",
                    Url = "http://www.panspain-group.com/",
                    Info =
                        @"PanSpain Group — испанская компания, успешно работающая на рынке недвижимости, девелопмента, а также в сфере организации мероприятий любого масштаба. Деятельность фирмы в основном сосредоточена на побережье Коста дель Соль— райском уголке на юге Испании. <br><br>
                Компания является постоянным членом Британской Торгово-промышленной Палаты на территории Испании. <br><br>
                В настоящее время Компания имеет председательства в г. Москва (Россия) и г. Алматы (Казахстан), при этом основной офис расположен в г. Марбелья (Испания).<br><br>

                Наши специалисты помогут организовать Вам незабываемый отдых в любое время года на побережье Коста дель Соль. Мы предоставляем услуги по аренде апартаментов и вилл, бронированию отелей и авиабилетов, трансферам из аэропорта, прокату автомобилей и подбору недвижимости на любой вкус. <br><br>
                Узнать подробней об инфраструктуре и достопримечательностях побережья, а также ознакомиться с нашими предложениями по объектам недвижимости Вы можете на нашем сайте www.panspain-group.com<br><br>

                Для Вашего удобства совместно с Испанским центром Vamos мы поможем организовать Вам обучение испанском языку на любом уровне знаний и на любой срок в лучших языковых центрах на Коста дель Соль, как для взрослых так и для детей.<br><br>

                Благодаря нашим партнерам — адвокатскому бюро Щеглов и Партнеры (г. Москва) и адвокатскому бюро Perez de Vargas (г. Марбелья, Испания) мы гарантируем качественное юридическое сопровождение сделок по приобретения недвижимости, а также мы поможем Вам получить Вид на Жительство в Испании.<br><br>

                Для желающих приобрести недвижимость при помощи ипотечного кредитования мы поможем подобрать необходимый пакет документов и оформить заявку на получение ипотеки в испанском банке. <br><br>

                Наша команда состоит из высококвалифицированных профессионалов, получивших международное образование и свободно владеющих несколькими иностранными языками.<br><br>
                Наши специалисты всегда с радостью придут Вам на помощь и ответят на все интересующие Вас вопросы. В своей работе мы делаем акцент на профессионализме и индивидуальном подходе к каждому клиенту, каждый клиент для нас является особенным. Мы всегда находимся на связи, Вы можете в любое время связаться с нами по указанным ниже контактным данным.",
                    PhotoId = photo.Id,
                    Address = "Россия, г. Москва, ул. 8 Марта, д.1, стр. 12, офис 4, БЦ «Трио» (м. Динамо)",
                    Phone = " +7 905 768 1841, +7 495 748 0032",
                };
                context.Partners.Add(partner);
                context.SaveChanges();
                
                var photo1 = new FileDto
                {
                    Name = "partners/panspain_sea.jpg",
                    Info = "PanSpain Group",
                };
                context.Files.Add(photo1);
                context.SaveChanges();
                var photo2 = new FileDto
                {
                    Name = "partners/panspain_view.jpg",
                    Info = "PanSpain Group",
                };
                context.Files.Add(photo2);
                context.SaveChanges();
                var photo3 = new FileDto
                {
                    Name = "partners/panspain_people.jpg",
                    Info = "PanSpain Group",
                };
                context.Files.Add(photo3);
                context.SaveChanges();
                var photo4 = new FileDto
                {
                    Name = "partners/panspain_reception.jpg",
                    Info = "PanSpain Group",
                };
                context.Files.Add(photo4);
                context.SaveChanges();

                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo1.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo2.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo3.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo4.Id,
                    });
                context.SaveChanges();
            }

            if (context.Partners.FirstOrDefault(c => c.SysName == "costalucia") == null)
            {
                var photo = new FileDto
                {
                    Name = "partners/costalucia.jpeg",
                    Info = "Costa Lucia",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var partner = new PartnerDto
                {
                    SysName = "costalucia",
                    Name = "Costa Lucia",
                    Url = "http://www.costalucia.com/",
                    Info =
                        @"Испания – прекрасная солнечная страна. Наверное, для меня она такая потому, что живу и работаю я на самом солнечном побережье Испании – Коста дель Соль. Удивительный край: горы, море, серый с галькой песок и много красивых мест, куда я вас хочу пригласить. Постараюсь удивить даже самых заядлых путешественников, которые скажут, например: «Я в Ронде был неоднократно!». Им мой ответ: «А посещали ли вы испанскую усадьбу на окраине города, где известный тореадор занимается разведением быков породы «Торре браво» для корриды, а также красивейших в мире испанских лошадей? А может вы посетили одну из 20 винодельческих производств и отведали экологические вина региона? Прошлись ли тропой к таинственной пещере с наскальными рисунками доисторических времен?» Удивила? Я очень рада. А сколько новых открытий ещё могу предложить по уже известному вам побережью Коста дель Соль и провинции Малага: мастер-классы по приготовлению сыра из козьего молока на фермерском хозяйстве, приготовление шоколада в кондитерской, хлеба в булочной и на ферме, изготовление керамической тарелочки или кувшинчика, посещение производства оливкового масла, вина, экологических продуктов питания; музеев меда, изюма, тунца… Много вкусного и интересного на побережье Коста дель Соль. Добро пожаловать, друзья! Я вас жду! Ваш сопровождающий гид – Светлана Калениченко.",
                    PhotoId = photo.Id,
                    Phone = "+34 671-54-46-64",
                    SocialNetwork = "Facebook: Светлана Калениченко<br>Гид в Малаге, Марбелье ",
                };
                context.Partners.Add(partner);
                context.SaveChanges();

                var photo1 = new FileDto
                {
                    Name = "partners/costalucia_kid.jpeg",
                    Info = "Costa Lucia",
                };
                context.Files.Add(photo1);
                context.SaveChanges();
                var photo2 = new FileDto
                {
                    Name = "partners/costalucia_fish.jpeg",
                    Info = "Costa Lucia",
                };
                context.Files.Add(photo2);
                context.SaveChanges();
                var photo3 = new FileDto
                {
                    Name = "partners/costalucia_mountain.jpeg",
                    Info = "Costa Lucia",
                };
                context.Files.Add(photo3);
                context.SaveChanges();
                var photo4 = new FileDto
                {
                    Name = "partners/costalucia_kitchen.jpeg",
                    Info = "Costa Lucia",
                };
                context.Files.Add(photo4);
                context.SaveChanges();

                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo1.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo2.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo3.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo4.Id,
                    });
                context.SaveChanges();
            }

            if (context.Partners.FirstOrDefault(c => c.SysName == "vivaraphael") == null)
            {
                var photo = new FileDto
                {
                    Name = "partners/vivarafael.jpg",
                    Info = "Viva Raphael",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var partner = new PartnerDto
                {
                    SysName = "vivaraphael",
                    Name = "Viva Raphael",
                    Url = "https://viva-raphael.com/",
                    Info = @"<b>Знаете ли Вы,...</b> <br>
                    ... какой испанский артист является обладателем первого из трех урановых дисков, существующих в мире, за продажу более 50 миллионов экземпляров (после него награду получили только Майкл Джексон и группа Queen)?<br><br>
                    ...кому посвящен великолепный по техническому оснащению и дизайну музей, открытый не только при его жизни, но тогда, когда артист находится в расцвете своего творчества?<br><br>
                    ... в честь какой из его побед на международном фестивале открыт специальный знак-стела в престижном испанском городе-курорте Бенидорме?<br><br>
                    ... и чье имя носят две улицы в городах Линарес и Эстапоне уже почти 20 лет?",
                    PhotoId = photo.Id,
                };
                context.Partners.Add(partner);
                context.SaveChanges();

                var photo1 = new FileDto
                {
                    Name = "partners/vivarafael_singer.jpg",
                    Info = "Viva Raphael",
                };
                context.Files.Add(photo1);
                context.SaveChanges();

                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo1.Id,
                    });
                context.SaveChanges();
            }

            if (context.Partners.FirstOrDefault(c => c.SysName == "iflamenco") == null)
            {
                var photo = new FileDto
                {
                    Name = "partners/iflamenco.jpg",
                    Info = "Школа Фламенко Оксаны Серик",
                };
                context.Files.Add(photo);
                context.SaveChanges();

                var partner = new PartnerDto
                {
                    SysName = "iflamenco",
                    Name = "Школа Фламенко Оксаны Серик",
                    Url = "http://www.iflamenco.ru/",
                    Info = @"Занятия Фламенко – настоящая Испания в Москве. <br><br>

                Уважаемые господа! <br>

                Команда Школы Фламенко Оксаны Серик приглашает Вас в мир испанского танцевального искусства – Фламенко! <br><br>


                В рамках коммерческого предложения мы рады предоставить ученикам Centro Espanol VAMOS специальную скидку: <br>

                - СКИДКА 10% НА ОБУЧЕНИЕ ФЛАМЕНКО<br>

                Начните освоение искусства Фламенко «с нуля», либо присоединитесь к одной из продолжающих групп.<br><br>


                Школа Фламенко Оксаны Серик – одна из ведущий школ в России, основана в 2008 году. От других школ нас отличает то, что мы преподаем настоящее Фламенко, передаем атмосферу Испании и особенности культуры этой прекрасной страны.<br><br>

                Занятия в группах разного уровня («с нуля» и продолжающие) проходят два раза в неделю в комфортабельном зале, специально оборудованном для исполнения Фламенко. Занятия проводит опытный педагог и хореограф фламенко Оксана Серик. Оксана – известная танцовщица, которая училась у признанных мастеров фламенко на родине этого искусства – в Испании. Искренне влюбленная в танец, она заряжает его энергией свои учеников.<br><br>

                Оксана внимательна к ученикам и к процессу обучения, благодаря чему со временем начинающие танцоры показывают значимый прогресс. Это наглядно демонстрируют ежегодные отчетные концерты, на которых блистают студенты школы.<br><br>

                Помимо занятий, мы также проводим ежемесячные вечера Испанского таблао. Таблао - это формат вечера, который сохраняет и передает самое главное - магию искусства фламенко. Танцовщица исполняет фламенко под звуки живой музыки и пения на расстоянии трех шагов от зрителей.<br><br>

                Более подробную информацию о школе и преподавателе Вы можете найти на сайте <a href='http://www.iflamenco.ru'>www.iflamenco.ru</a> и в группе Вконтакте <a href='http://www.vk.com/iflamenco'>www.vk.com/iflamenco</a><br><br>


                Чтобы воспользоваться скидками – свяжитесь с представителями Школы Фламенко Оксаны Серик по телефону или электронной почте указанной ниже<br><br>


                Мы будем рады видеть Вас!",
                    PhotoId = photo.Id,
                    Phone = "+7 (915) 003-65-73",
                    Email = "info@iflamenco.ru",
                };
                context.Partners.Add(partner);
                context.SaveChanges();

                var photo1 = new FileDto
                {
                    Name = "partners/flamenco1.jpg",
                    Info = "Школа Фламенко Оксаны Серик",
                };
                context.Files.Add(photo1);
                context.SaveChanges();
                var photo2 = new FileDto
                {
                    Name = "partners/flamenco2.jpg",
                    Info = "Школа Фламенко Оксаны Серик",
                };
                context.Files.Add(photo2);
                context.SaveChanges();
                var photo3 = new FileDto
                {
                    Name = "partners/flamenco3.jpg",
                    Info = "Школа Фламенко Оксаны Серик",
                };
                context.Files.Add(photo3);
                context.SaveChanges();
                var photo4 = new FileDto
                {
                    Name = "partners/flamenco4.jpg",
                    Info = "Школа Фламенко Оксаны Серик",
                };
                context.Files.Add(photo4);
                context.SaveChanges();
                var photo5 = new FileDto
                {
                    Name = "partners/flamenco5.jpg",
                    Info = "Школа Фламенко Оксаны Серик",
                };
                context.Files.Add(photo5);
                context.SaveChanges();
                var photo6 = new FileDto
                {
                    Name = "partners/flamenco6.jpg",
                    Info = "Школа Фламенко Оксаны Серик",
                };
                context.Files.Add(photo6);
                context.SaveChanges();

                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo1.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo2.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo3.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo4.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo5.Id,
                    });
                context.PartnerFiles.Add(
                    new PartnerFileDto
                    {
                        PartnerId = partner.Id,
                        FileId = photo6.Id,
                    });
                context.SaveChanges();
            }
        }
    }
}