using Microsoft.EntityFrameworkCore.Migrations;

namespace CESP.Database.Migrations
{
    public partial class SeedDictionaries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "currencies",
                columns: new[] { "id", "name" },
                values: new object[] { 1, "руб." });

            migrationBuilder.InsertData(
                table: "feedback_sources",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 4, "анкета" },
                    { 2, "vk" },
                    { 1, "facebook" },
                    { 3, "e-mail" }
                });

            migrationBuilder.InsertData(
                table: "files",
                columns: new[] { "id", "info", "name" },
                values: new object[,]
                {
                    { 8, "Юлия", "teachers/julia.png" },
                    { 7, "Джонатан", "teachers/jonatan.jpg" },
                    { 6, "Пабло", "teachers/pablo.jpeg" },
                    { 5, "Алехо", "teachers/alejo.jpg" },
                    { 4, "Альберто", "teachers/alberto.jpg" },
                    { 3, "Рафаэль", "teachers/rafael_200x193.png" },
                    { 2, "Анхель", "teachers/anhel-photo.jpeg" },
                    { 1, "Йосу", "teachers/josu-foto.jpg" }
                });

            migrationBuilder.InsertData(
                table: "language_levels",
                columns: new[] { "id", "info", "name", "native_name", "rang" },
                values: new object[,]
                {
                    { 14, null, "C2+", null, 15 },
                    { 12, null, "C2.2", null, 13 },
                    { 11, null, "C2.1", null, 12 },
                    { 10, null, "C1.2", null, 11 },
                    { 9, null, "C1.1", null, 10 },
                    { 8, null, "B2.3", null, 9 },
                    { 7, null, "B2.2", null, 8 },
                    { 6, null, "B2.1", null, 7 },
                    { 5, null, "B1.2", null, 6 },
                    { 4, null, "B1.1", null, 5 },
                    { 3, null, "A2.2", null, 4 },
                    { 2, null, "A2.1", null, 3 },
                    { 13, null, "C1+", null, 14 },
                    { 1, null, "A1", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "id", "info", "name", "photo_id", "post" },
                values: new object[,]
                {
                    { 1, "Йосу — преподаватель-носитель испанского языка из Барселоны с большим опытом работы. Имеет международный сертификат ELE для преподавания испанского как иностранного (от International House Barcelona, утвержденным Университетом Барселоны). Кроме того Йосу является дипломированным экзаменатором экзамена DELE, это значит что он может как принимать экзамен, так и подготавливать студентов для сдачи DELE. И конечно, имеет сертификат, подтверждающий квалификацию преподавателя от Института Сервантеса г. Москвы. Работает как со взрослыми, так и с детьми у которых всегда имеет особенный успех. Уроки проходят в дружественной, неформальной обстановке, что способствует эффективному и быстрому усвоению материала. Владеет русским языком.", "Йосу", 1, "преподаватель" },
                    { 2, "Анхель – опытный преподаватель испанского языка из Малаги. Позитивный, открытый и добрый. На уроках любит разложить все объяснения по полочкам, что облегчает процесс усвоения материала. В Москве преподаёт испанский с 2012 прекрасно ладит как со взрослыми, так и с детьми, готовит свои уроки индивидуально, с учетом потребностей, интересов и особенностей каждой группы, но конечно в рамках Международного стандарта преподавания испанского языка иностранцам. Увлекается классической музыкой. Прекрасно владеет русским языком.", "Анхель", 2, "преподаватель" },
                    { 3, "Рафаэль - преподаватель-носитель испанского и каталанского языков из Барселоны. В Россию приехал в 2013 году, до этого жил и работал в Англии. Имеет сертификаты Института Сервантеса о специальной подготовке преподавателей которые дают право преподавать язык иностранным студентам. Открытый, жизнерадостный и общительный. Ему нравится путешествовать, познавать новые культуры и обмениваться своим опытом с другими людьми. Творчески подходит к подготовке своих уроков испанского и каталанского и поэтому его занятия всегда динамичные и интересные. На своих уроках он использует коммуникативную методику, соответствующую международным стандартам. На занятиях у Рафаэля при погружении в языковую среду студент с первых уроков начинает говорить на испанском языке. Прекрасно ладит как со взрослыми, так и с детьми и подростками. Владеет русским языком.", "Рафаэль", 3, "преподаватель" },
                    { 4, "Альберто преподаватель-носитель испанского языка, родился в Гранаде. Имеет обширный опыт преподавания испанского языка для иностранцев, как в Испании так и в России. На занятиях с Альберто всегда интересно и весело. Студенты активно вовлечены в учебный процесс. Альберто знает древние языки, такие как: латинский и греческий, что позволяет ему давать более глубокий материал по испанскому языку. Так же свободно владеет русским языком.", "Альберто", 4, "преподаватель" },
                    { 5, "Алехо - преподаватель испанского языка с более чем девятилетним опытом работы. Он отлично понимает потребности и трудности своих учеников, так как сам учился русскому, английскому, французскому и португальскому языкам, и знает все \"подводные камни\" при изучении иностранных языков и, несомненно, поможет их избежать своим судентам. Алехо очень позитивный, понимающий и терпеливый человек, что особенно важно в профессии преподавателя. Алехо имеет диплом бакалавра по экономике, также успешно прошел курсы по повышению квалиффикации в Институте Сервантеса. Кроме того, является официальным экзаменатором Dele для уровней A, B и C.", "Алехо", 5, "преподаватель" },
                    { 6, "Пабло - преподаватель испанского языка из Венесуэлы. Работает как со взрослыми, так и с детскими группами, у которых всегда имеет особенный успех. Веселый, молодой, харизматичный преподаватель. Всегда тщательно подбирает материалы для каждого занятия. Очень ответственно относится к своей работе, и результатам своих студентов.", "Пабло", 6, "преподаватель" },
                    { 7, @"Джонатан жизнелюбивый и опытный преподаватель из Испании (Барселона). Имеет педагогическое образование (воспитатель в детском саду), что дало ему возможность работать с детьми разных возрастов и преподавать им испанский язык как иностранный. 
                                    Уже три года Джонатан обучает испанскому языку как детей, так и взрослых. Программу занятий для каждого ученика подбирает индивидуально и адаптирует методику под его особенности, уровень владения языком, возраст и потребности. Его занятия всегда увлекательны и динамичными, и при всем при этом, эффективные и полезные.Владеет русским языком.", "Джонатан", 7, "преподаватель" },
                    { 8, "Юлия разносторонний и творческий человек. Закончила с отличием филологический факультет МГУ им М.В. Ломоносова. Прошла стажировку в Университете Барселоны. Три года работает преподавателем испанского и каталанского языков. Владеет коммуникативной методикой преподавания для иностранцев. На своих уроках особое внимание уделяет грамматике и разговорной лексике, а также культуре и литературе стран изучаемого языка.", "Юлия", 8, "преподаватель, лингвист" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "feedback_sources",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "feedback_sources",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "feedback_sources",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "feedback_sources",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "files",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "files",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "files",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "files",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "files",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "files",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "files",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "files",
                keyColumn: "id",
                keyValue: 8);
        }
    }
}
