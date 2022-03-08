﻿using car.Data.interfaces;
using car.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace car.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        Name = "Tesla",
                        ShortDesc= "Стоимость около 15 кредитов ЛНР",
                        LongDesc="покупать смысла нету зарядить не сможешь с 4 этажа по переноске только и ожидаешь зарядки 2 года+ украдут переноску и кабель зарядки, то есть нужны ещё камеры блять СЛАВА УКРАИне нАХУЙ",
                        Img= "https://otvet.imgsmail.ru/download/11855968_a7264278e1f6cd0fc2ebdde695fe1747_800.png",
                        Price = "12536 запплаты лнр и 62 кредита",
                        IsFavourite=true,Available=true,
                        Category=_categoryCars.AllCategories.Last()
                    },

                     new Car{
                        Name = "Прима мобиль AMG H63",
                        ShortDesc = "Пушка гонка, нужно возить с собой трос и пусковые проводки, до 100 за 0.16мс",
                        LongDesc= "Карбюратор, инжектор, инспектор проректор, ИК-порт, блютуз, туз, козырь, валет, дама, румба, сальса, танго, манго, Мис Бахар, сеть магазинов Сабина, сисле, Элвис Пресли, Джек Дэниелс, Уолт Дисней, Френсис Форд Коппола, акапелла, опера, хор, нейша хор, винзавод, Новый Год, Новруз Байрам, День Независимости, Праздник Св. Патрика.Дальше. Фул-салон, наверху-внизу люк, панорама, балкон, фасад, смотровая площадка, зеркало заднего вида, зеркало дисплея, зеркало фона, зеркало заставки, приставка, 10 к 1 ставка, пол-ставки, подставка, булавка, козявка.Пошли дальше. Затем - DVD, VCD, впереди, не перди, CD, и не рыпайся, MP3, MP4, М-пакет, М-торба, М-зембиль, changer, excange, I see no changes, California love, Two of America′s most wanted, Hit′em Up, мемори-пакет, мемори-кард, мультимедиа-кард, флеш-карт, кард-ридер, сидер, гнойный пидер, Лидер, АНС, Аз-ТВ, Аз Саманд, Аз-Петрол, аста ла виста, Vista, XP, Windows",
                        Img= "https://drive-boom.ru/gallery/opel/photo/opel-h-2004-2007-7454sm.jpeg",
                        Price= "5 компутеров и квартира в антрасити",
                        IsFavourite =true, Available=true,
                        Category= _categoryCars.AllCategories.First()

                     },
                     new Car
                     {
                         Name ="Shevrolet Trushin 750Li Long",
                         ShortDesc="Самая топовая комплектация Shevrolet Tahoe, p.s. это авео(",
                         LongDesc ="Машина топ Расход бензина 0 л-100км (если использовать газ) Никогда не ломается если не ездить, 0-100- возможно , можно лить даже водку она будет не против, стоимость запчастей как пачка дарсайда, возможность докинуть саб в багажник если не возить картошку на дачу,Пробег - 0 по рф и всех стран кроме украины и лнр",
                         Img = "https://a.d-cd.net/344aaecs-960.jpg",
                         Price = "21л самогона 15л дизеля и 2 кофе с вога + 4 кальяна биты",
                         IsFavourite =true, Available=true,
                         Category= _categoryCars.AllCategories.First()
                     },
                     new Car
                     {
                         Name= "Pasasatb 5раз",
                         ShortDesc="тачка премиум класса епта, кампфорт на 10из10 , скоро 7из10, управляемость 6из10 ",
                         LongDesc= "Не бита не крашена, выебана дважды,освятили в церви 4 раза, руль не грызли, музыка есть, 2 улитки под капотом, турбина тоже под капотом, можно ебаться в ней и с ней тоже",
                         Img= "https://i.pinimg.com/originals/3d/ed/7b/3ded7baa3ce21e76a899671b0e4699ae.jpg",
                         Price ="2 мои жопы и через месяц 1000 долларов (1к152520 рублям)",
                         IsFavourite =true, Available=true,
                         Category= _categoryCars.AllCategories.First()
                     }
                    
                }; // надо ещё сделать приму мобиль трушина мобиль и украина мобиль.
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
