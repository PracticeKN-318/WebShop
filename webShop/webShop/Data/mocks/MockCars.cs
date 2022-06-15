using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webShop.Data.interfaces;
using webShop.Data.Models;

namespace webShop.Data.mocks
{
    public class MockCars : IAllCars{

        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars {
            get {
                return new List<Car> {
                    new Car {
                        name = "Tesla Model S",
                        shortDesc = "Швидкий автомобіль",
                        longDesc = "Красивий, швидкий та зручний автомобіль компанії Tesla",
                        img = "https://www.bing.com/images/search?view=detailV2&ccid=uqttrgsP&id=55BAE99AEF070BF89583BF34786D29B8520AD53A&thid=OIP.uqttrgsPJl_HdVvg8Zs7tAHaEK&mediaurl=https%3a%2f%2fmedia.evo.co.uk%2fimage%2fprivate%2fs--gX-AUuIY--%2fv1606324138%2fevo%2f2020%2f11%2fTesla+Model+S+2020-5.jpg&cdnurl=https%3a%2f%2fth.bing.com%2fth%2fid%2fR.baab6dae0b0f265fc7755be0f19b3bb4%3frik%3dOtUKUrgpbXg0vw%26pid%3dImgRaw%26r%3d0&exph=1800&expw=3200&q=tesla+model+s&simid=608019721387910894&FORM=IRPRST&ck=79EB3D49BABE03A46643BD5A1BD57260&selectedIndex=0&ajaxhist=0&ajaxserp=0",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First() 
                },
                 new Car {
                     name = "Ford Fiesta",
                     shortDesc = "Тихий і спокійний",
                     longDesc = "Зручний автомобіль для місцевого життя",
                     img = "https://www.bing.com/images/search?view=detailV2&ccid=oXIgnz%2fi&id=1DBEE6F05840315DD6409C7D54233476A1DECB16&thid=OIP.oXIgnz_iVGrU9ezVM4ZsVAHaFj&mediaurl=https%3a%2f%2fwww.carsinvasion.com%2fgallery%2f2014-ford-fiesta%2f2014-ford-fiesta-01.jpg&cdnurl=https%3a%2f%2fth.bing.com%2fth%2fid%2fR.a172209f3fe2546ad4f5ecd533866c54%3frik%3dFsveoXY0I1R9nA%26pid%3dImgRaw%26r%3d0&exph=1200&expw=1600&q=ford+fiesta&simid=608040783901764291&FORM=IRPRST&ck=FE1D6F85FCA91ECEB1F901F2B8F5BD4C&selectedIndex=2&ajaxhist=0&ajaxserp=0",
                     price = 11000,
                     isFavourite = false,
                     available = true,
                     Category = _categoryCars.AllCategories.Last()
                 },
                  new Car {
                      name = "BMW M3",
                      shortDesc = "Зухвалий і стильний",
                      longDesc = "Автомобіль для дрифту і шашок по місту",
                      img = "https://www.bing.com/images/search?view=detailV2&ccid=%2f3XiDaVU&id=A66B0A2FC48BC37942849372ED741E4B69A2A8C7&thid=OIP._3XiDaVUlqG-rES747sk-QHaFH&mediaurl=https%3a%2f%2fth.bing.com%2fth%2fid%2fR.ff75e20da55496a1beac44bbe3bb24f9%3frik%3dx6iiaUsedO1ykw%26riu%3dhttp%253a%252f%252fgaragedreams.net%252fwp-content%252fuploads%252f2020%252f06%252fBMW-F80-M3-Sedan.jpg%26ehk%3dmbsSs7E3lt6iguJcZ9X8V4XIW3H4qa6HzSlXNtop6RE%253d%26risl%3d%26pid%3dImgRaw%26r%3d0&exph=1212&expw=1753&q=bmw+m3&simid=608037047283092330&FORM=IRPRST&ck=9FE71E72A2200FCEB79AFDE7B3AD0BC2&selectedIndex=3&ajaxhist=0&ajaxserp=0",
                      price = 65000,
                      isFavourite = true,
                      available = true,
                      Category = _categoryCars.AllCategories.Last()
                  },
                   new Car {
                       name = "Mercedes C Class",
                       shortDesc = "Зручний і великий",
                       longDesc = "",
                       img = "https://www.bing.com/images/search?view=detailV2&ccid=7gzfvooK&id=354225FED2CA546F0ABE56A0523241364C2BE8B4&thid=OIP.7gzfvooKiRJc_PlsFb4xzAHaE4&mediaurl=https%3a%2f%2fth.bing.com%2fth%2fid%2fR.ee0cdfbe8a0a89125cfcf96c15be31cc%3frik%3dtOgrTDZBMlKgVg%26riu%3dhttp%253a%252f%252fwww.ausmotive.com%252fpics%252f2013%252fMercedes-C-Class-W205-17.jpg%26ehk%3dLY2aU8X0tNJpMHnqacSnbW82AlBFUGRREoPGGLD9lQI%253d%26risl%3d%26pid%3dImgRaw%26r%3d0&exph=1320&expw=2000&q=mercedes+c+class&simid=607994733267743223&FORM=IRPRST&ck=DC7F1422E323BB631F438E414FB49080&selectedIndex=3&ajaxhist=0&ajaxserp=0",
                       price = 40000,
                       isFavourite = false,
                       available = false,
                       Category = _categoryCars.AllCategories.Last()
                   },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Безшумний і економний",
                        longDesc = "Зручний автомобіль для тихої їзди",
                        img = "https://www.bing.com/images/search?view=detailV2&ccid=hF2oAjWB&id=9D6DB88F6D080FA36D82D55B020D339C505D4F10&thid=OIP.hF2oAjWBR9DnFeuntw5v6wHaE7&mediaurl=https%3a%2f%2fimages.news18.com%2fibnlive%2fuploads%2f2018%2f07%2fNissan-Leaf-Nismo-2.jpg%3fimpolicy%3dwebsite%26width%3d0%26height%3d0&cdnurl=https%3a%2f%2fth.bing.com%2fth%2fid%2fR.845da802358147d0e715eba7b70e6feb%3frik%3dEE9dUJwzDQJb1Q%26pid%3dImgRaw%26r%3d0&exph=583&expw=875&q=nissan+leaf&simid=608010680485247832&FORM=IRPRST&ck=E66779F2AD3D997488E537F9ABF73962&selectedIndex=2&ajaxhist=0&ajaxserp=0",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };

            }

        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
