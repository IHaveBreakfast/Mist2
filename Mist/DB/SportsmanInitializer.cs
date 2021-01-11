using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Mist.Models;
using System.Security.Cryptography.X509Certificates;

namespace Mist.DB
{
    public class SportsmanInitializer : DropCreateDatabaseAlways<SportsmanContext>
    {
        protected override void Seed(SportsmanContext context)
        {
            var sportsmans = new List<Sportsman>
            {
                 new Sportsman { ID =1, NameID="Антонов Антон", Birth=2004, Type1="Отжимания", Res1=56, Type2="Спринт 60м", Res2=7.7, Type3="Спринт 200м", Res3=40.1, Type4="Прыжки в длину с места", Res4=2.39},
                new Sportsman { ID =2, NameID="Борисов Борис", Birth=2005, Type1="Отжимания", Res1=53, Type2="Спринт 60м", Res2=8.3, Type3="Спринт 200м", Res3=39.1, Type4="Прыжки в длину с места", Res4=2.11 },
                new Sportsman { ID =3, NameID="Вальерев Велерий", Birth=2004, Type1="Отжимания", Res1=30, Type2="Спринт 60м", Res2=9.7, Type3="Спринт 200м", Res3=45.5, Type4="Прыжки в длину с места", Res4=2.49 },
                new Sportsman { ID =4, NameID="Грибников Алексей", Birth=2004, Type1="Отжимания", Res1=110, Type2="Спринт 60м", Res2=9.0, Type3="Спринт 200м", Res3=55.0, Type4="Прыжки в длину с места", Res4=2.04 },
                new Sportsman { ID =5, NameID="Домашний Дмитрий", Birth=2005, Type1="Отжимания", Res1=80, Type2="Спринт 60м", Res2=9.4, Type3="Спринт 200м", Res3=47.2, Type4="Прыжки в длину с местаа", Res4=2.28 },
                new Sportsman { ID =6, NameID="Заморов Николай", Birth=2005, Type1="Отжимания", Res1=66, Type2="Спринт 60м", Res2=8.4, Type3="Спринт 200м", Res3=48.9, Type4="Прыжки в длину с места", Res4=2.20 },
                new Sportsman { ID =7, NameID="Петров Иван", Birth=2005, Type1="Отжимания", Res1=84, Type2="Спринт 60м", Res2=8.7, Type3="Спринт 200м", Res3=50.7, Type4="Прыжки в длину с места", Res4=2.18 },
                new Sportsman { ID =8, NameID="Сергеев Илья", Birth=2004, Type1="Отжимания", Res1=92, Type2="Спринт 60м", Res2=11.1, Type3="Спринт 200м", Res3=49.4, Type4="Прыжки в длину с места", Res4=2.03 },
                new Sportsman { ID =9, NameID="Талиев Антон", Birth=2003, Type1="Отжимания", Res1=52, Type2="Спринт 60м", Res2=10.0, Type3="Спринт 200м", Res3=51.3, Type4="Прыжки в длину с места", Res4=2.00 },
                new Sportsman { ID =10, NameID="Фазанов Андрей", Birth=2004, Type1="Отжимания", Res1=63, Type2="Спринт 60м", Res2=9.7, Type3="Спринт 200м", Res3=52.2, Type4="Прыжки в длину с места", Res4=2.05 },
                //
                new Sportsman { ID =11, NameID="Аполова Татьяна", Birth=2004, Type1="Отжимания", Res1=64, Type2="Спринт 60м", Res2=7.9, Type3="Спринт 200м", Res3=41.3, Type4="Прыжки в длину с места", Res4=2.45 },
                new Sportsman { ID =12, NameID="Беренгова Яна", Birth=2004, Type1="Отжимания", Res1=31, Type2="Спринт 60м", Res2=8.1, Type3="Спринт 200м", Res3=38.1, Type4="Прыжки в длину с места", Res4=1.89 },
                new Sportsman { ID =13, NameID="Колиавская Елизавета", Birth=2004, Type1="Отжимания", Res1=56, Type2="Спринт 60м", Res2=9.7, Type3="Спринт 200м", Res3=39.9, Type4="Прыжки в длину с места", Res4=2.30 },
                new Sportsman { ID =14, NameID="Мерианова Анастасия", Birth=2005, Type1="Отжимания", Res1=33, Type2="Спринт 60м", Res2=8.9, Type3="Спринт 200м", Res3=40.0, Type4="Прыжки в длину с места", Res4=1.96 },
                new Sportsman { ID =15, NameID="Олейникова Анастасия", Birth=2005, Type1="Отжимания", Res1=32, Type2="Спринт 60м", Res2=8.5, Type3="Спринт 200м", Res3=45.6, Type4="Прыжки в длину с места", Res4=2.06 },
                new Sportsman { ID =16, NameID="Степанова Дарья", Birth=2004, Type1="Отжимания", Res1=40, Type2="Спринт 60м", Res2=9.6, Type3="Спринт 200м", Res3=58.0, Type4="Прыжки в длину с места", Res4=2.10 },
                new Sportsman { ID =17, NameID="Солеанова Мария", Birth=2004, Type1="Отжимания", Res1=74, Type2="Спринт 60м", Res2=8.8, Type3="Спринт 200м", Res3=44.4, Type4="Прыжки в длину с места", Res4=2.11 },
                new Sportsman { ID =18, NameID="Ульянова Ульяна", Birth=2004, Type1="Отжимания", Res1=38, Type2="Спринт 60м", Res2=7.5, Type3="Спринт 200м", Res3=35.5, Type4="Прыжки в длину с места", Res4=2.12 },
                new Sportsman { ID =19, NameID="Хочавоникова Алина", Birth=2004, Type1="Отжимания", Res1=50, Type2="Спринт 60м", Res2=8.8, Type3="Спринт 200м", Res3=36.7, Type4="Прыжки в длину с места", Res4=2.13 },
                new Sportsman { ID =20, NameID="Якорева Ирина", Birth=2005, Type1="Отжимания", Res1=39, Type2="Спринт 60м", Res2=9.8, Type3="Спринт 200м", Res3=40.3, Type4="Прыжки в длину с места", Res4=2.04 },
             };
                       
                   int Best1 = sportsmans.Max(best => best.Res1);
                double Best2 = sportsmans.Min(best => best.Res2);
                double Best3 = sportsmans.Min(best => best.Res3);
                double Best4 = sportsmans.Max(best => best.Res4);
            
            sportsmans.ForEach(s => context.Sportsmans.Add(s));
            context.SaveChanges();
            base.Seed(context);
        }
    }
}