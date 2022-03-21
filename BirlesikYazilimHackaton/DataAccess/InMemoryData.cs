using BirlesikYazilimHackaton.Entity;

namespace BirlesikYazilimHackaton.DataAccess
{
    public class InMemoryData<T> : IMemoryDal<UretimOperayonBildirimleri>
    {
        List<UretimOperasyonBilgileri> _uretim;
        List<StandartDuruslar> _durus;
        List<UretimOperayonBildirimleri> _uretimBildirimleri;
        public InMemoryData()
        {
            _uretim = new List<UretimOperasyonBilgileri>()
            {
                new UretimOperasyonBilgileri{Id=1, Baslangic= new DateTime(2020,5,23,7,30,00),Bitis= new DateTime(2020,5,23,8,30,00),ToplamSure= new TimeSpan(1,0,0),Statu="Uretim"},
                new UretimOperasyonBilgileri{Id=2, Baslangic= new DateTime(2020,5,23,8,30,00),Bitis= new DateTime(2020,5,23,12,00,00),ToplamSure= new TimeSpan(3,30,0),Statu="Uretim"},
                new UretimOperasyonBilgileri{Id=3, Baslangic= new DateTime(2020,5,23,12,00,00),Bitis= new DateTime(2020,5,23,13,00,00),ToplamSure= new TimeSpan(1,0,0),Statu="Uretim"},
                new UretimOperasyonBilgileri{Id=4, Baslangic= new DateTime(2020,5,23,13,00,00),Bitis= new DateTime(2020,5,23,13,45,00),ToplamSure= new TimeSpan(0,45,0),Statu="Durus",DurusNedeni="Ariza"},
                new UretimOperasyonBilgileri{Id=5, Baslangic= new DateTime(2020,5,23,13,45,00),Bitis= new DateTime(2020,5,23,17,30,00),ToplamSure= new TimeSpan(3,45,0),Statu="Uretim"}
            };

            _durus = new List<StandartDuruslar>()
            {
                new StandartDuruslar{Id=1, Baslangic=new TimeSpan(10,0,0), Bitis=new TimeSpan(10,15,0), DurusNedeni="Cay Molasi"},
                new StandartDuruslar{Id=2, Baslangic=new TimeSpan(12,0,0), Bitis=new TimeSpan(12,30,0), DurusNedeni="Yemek Molasi"},
                new StandartDuruslar{Id=3, Baslangic=new TimeSpan(15,0,0), Bitis=new TimeSpan(15,15,0), DurusNedeni="Cay Molasi"}
            };

            _uretimBildirimleri = new List<UretimOperayonBildirimleri>()
            {
                new UretimOperayonBildirimleri{Id=1, Baslangic= new DateTime(2020,5,23,7,30,00),Bitis= new DateTime(2020,5,23,8,30,00),ToplamSure= new TimeSpan(1,0,0),Statu="Uretim"},
                new UretimOperayonBildirimleri{Id=2, Baslangic= new DateTime(2020,5,23,8,30,00),Bitis= new DateTime(2020,5,23,12,00,00),ToplamSure= new TimeSpan(3,30,0),Statu="Uretim"},
                new UretimOperayonBildirimleri{Id=3, Baslangic= new DateTime(2020,5,23,12,00,00),Bitis= new DateTime(2020,5,23,13,00,00),ToplamSure= new TimeSpan(1,0,0),Statu="Uretim"},
                new UretimOperayonBildirimleri{Id=4, Baslangic= new DateTime(2020,5,23,13,00,00),Bitis= new DateTime(2020,5,23,13,45,00),ToplamSure= new TimeSpan(0,45,0),Statu="Durus"},
                new UretimOperayonBildirimleri{Id=5, Baslangic= new DateTime(2020,5,23,13,45,00),Bitis= new DateTime(2020,5,23,17,30,00),ToplamSure= new TimeSpan(3,45,0),Statu="Uretim"}
            };
        }

        public List<UretimOperayonBildirimleri> GetAll()
        {
            DateTime caymolasi1baslangic = new DateTime(2020, 5, 23, 10, 0, 0);
            DateTime caymolasi1bitis = new DateTime(2020, 5, 23, 10, 15, 0);
            DateTime yemekmolasibaslangic = new DateTime(2020, 5, 23, 12, 00, 0);
            DateTime yemekmolasibitis = new DateTime(2020, 5, 23, 12, 30, 0);
            DateTime caymolasi2baslangic = new DateTime(2020, 5, 23, 15, 0, 0);
            DateTime caymolasi2bitis = new DateTime(2020, 5, 23, 15, 15, 0);

            //var join = _uretim.Join(
            //        _uretimBildirimleri,
            //        uretimOperasyonBilgileri => uretimOperasyonBilgileri.Id,
            //        uretimOperayonBildirimleri => uretimOperayonBildirimleri.Id,
            //        (uretimOperasyonBilgileri, uretimOperayonBildirimleri) => new
            //        {
            //            Baslangic = uretimOperasyonBilgileri.Baslangic,
            //            Bitis = uretimOperasyonBilgileri.Bitis,
            //            TolamSure = uretimOperasyonBilgileri.ToplamSure,
            //            Statu = uretimOperasyonBilgileri.Statu
            //        });

            var result1 = _uretim.Where(x => x.Baslangic >= caymolasi1baslangic || x.Bitis <= caymolasi1bitis).ToList();

            if (result1.Count >= 1)
            {
                _uretimBildirimleri = new List<UretimOperayonBildirimleri>()
                {
                     new UretimOperayonBildirimleri{Id=1, Baslangic= new DateTime(2020,5,23,7,30,00),Bitis= new DateTime(2020,5,23,8,30,00),ToplamSure= new TimeSpan(1,0,0),Statu="Uretim"},
                     new UretimOperayonBildirimleri{Id=2, Baslangic= new DateTime(2020,5,23,8,30,00),Bitis= new DateTime(2020,5,23,10,30,00),ToplamSure= new TimeSpan(1,30,0),Statu="Uretim"},
                     new UretimOperayonBildirimleri{Id=2, Baslangic= new DateTime(2020,5,23,10,00,00),Bitis= new DateTime(2020,5,23,10,15,00),ToplamSure= new TimeSpan(0,15,0),Statu="Duruş", DurusNedeni="Çay Molası"},
                     new UretimOperayonBildirimleri{Id=2, Baslangic= new DateTime(2020,5,23,10,15,00),Bitis= new DateTime(2020,5,23,12,00,00),ToplamSure= new TimeSpan(1,45,0),Statu="Uretim"},
                     new UretimOperayonBildirimleri{Id=3, Baslangic= new DateTime(2020,5,23,12,00,00),Bitis= new DateTime(2020,5,23,13,00,00),ToplamSure= new TimeSpan(1,0,0),Statu="Uretim"},
                     new UretimOperayonBildirimleri{Id=4, Baslangic= new DateTime(2020,5,23,13,00,00),Bitis= new DateTime(2020,5,23,13,45,00),ToplamSure= new TimeSpan(0,45,0),Statu="Durus"},
                     new UretimOperayonBildirimleri{Id=5, Baslangic= new DateTime(2020,5,23,13,45,00),Bitis= new DateTime(2020,5,23,17,30,00),ToplamSure= new TimeSpan(3,45,0),Statu="Uretim"}
                   };
            }

            var result2 = _uretim.Where(x => x.Baslangic >= yemekmolasibaslangic || x.Bitis <= yemekmolasibitis).ToList();

            if (result2.Count >= 1)
            {
                _uretimBildirimleri = new List<UretimOperayonBildirimleri>()
                {
                     new UretimOperayonBildirimleri{Id=1, Baslangic= new DateTime(2020,5,23,7,30,00),Bitis= new DateTime(2020,5,23,8,30,00),ToplamSure= new TimeSpan(1,0,0),Statu="Uretim"},
                     new UretimOperayonBildirimleri{Id=2, Baslangic= new DateTime(2020,5,23,8,30,00),Bitis= new DateTime(2020,5,23,10,30,00),ToplamSure= new TimeSpan(1,30,0),Statu="Uretim"},
                     new UretimOperayonBildirimleri{Id=2, Baslangic= new DateTime(2020,5,23,10,00,00),Bitis= new DateTime(2020,5,23,10,15,00),ToplamSure= new TimeSpan(0,15,0),Statu="Duruş", DurusNedeni="Çay Molası"},
                     new UretimOperayonBildirimleri{Id=2, Baslangic= new DateTime(2020,5,23,10,15,00),Bitis= new DateTime(2020,5,23,12,00,00),ToplamSure= new TimeSpan(1,45,0),Statu="Uretim"},
                     new UretimOperayonBildirimleri{Id=3, Baslangic= new DateTime(2020,5,23,12,00,00),Bitis= new DateTime(2020,5,23,12,30,00),ToplamSure= new TimeSpan(1,45,0),Statu="Uretim"},
                     new UretimOperayonBildirimleri{Id=3, Baslangic= new DateTime(2020,5,23,12,00,00),Bitis= new DateTime(2020,5,23,13,00,00),ToplamSure= new TimeSpan(0,30,0),Statu="Uretim", DurusNedeni="Yemek Molası"},
                     new UretimOperayonBildirimleri{Id=4, Baslangic= new DateTime(2020,5,23,13,00,00),Bitis= new DateTime(2020,5,23,13,45,00),ToplamSure= new TimeSpan(0,45,0),Statu="Durus"},
                     new UretimOperayonBildirimleri{Id=5, Baslangic= new DateTime(2020,5,23,13,45,00),Bitis= new DateTime(2020,5,23,17,30,00),ToplamSure= new TimeSpan(3,45,0),Statu="Uretim"}
                   };
            }

            var result3 = _uretim.Where(x => x.Baslangic >= caymolasi2baslangic || x.Bitis <= caymolasi2bitis).ToList();

            if (result3.Count >= 1)
            {
                _uretimBildirimleri = new List<UretimOperayonBildirimleri>()
                {
                     new UretimOperayonBildirimleri{Id=1, Baslangic= new DateTime(2020,5,23,7,30,00),Bitis= new DateTime(2020,5,23,8,30,00),ToplamSure= new TimeSpan(1,0,0),Statu="Uretim"},
                     new UretimOperayonBildirimleri{Id=2, Baslangic= new DateTime(2020,5,23,8,30,00),Bitis= new DateTime(2020,5,23,10,30,00),ToplamSure= new TimeSpan(1,30,0),Statu="Uretim"},
                     new UretimOperayonBildirimleri{Id=2, Baslangic= new DateTime(2020,5,23,10,00,00),Bitis= new DateTime(2020,5,23,10,15,00),ToplamSure= new TimeSpan(0,15,0),Statu="Duruş", DurusNedeni="Çay Molası"},
                     new UretimOperayonBildirimleri{Id=2, Baslangic= new DateTime(2020,5,23,10,15,00),Bitis= new DateTime(2020,5,23,12,00,00),ToplamSure= new TimeSpan(1,45,0),Statu="Uretim"},
                     new UretimOperayonBildirimleri{Id=3, Baslangic= new DateTime(2020,5,23,12,00,00),Bitis= new DateTime(2020,5,23,12,30,00),ToplamSure= new TimeSpan(0,30,0),Statu="Duruş", DurusNedeni="Yemek Molası"},
                     new UretimOperayonBildirimleri{Id=3, Baslangic= new DateTime(2020,5,23,12,30,00),Bitis= new DateTime(2020,5,23,13,00,00),ToplamSure= new TimeSpan(0,30,0),Statu="Uretim"},
                     new UretimOperayonBildirimleri{Id=4, Baslangic= new DateTime(2020,5,23,13,00,00),Bitis= new DateTime(2020,5,23,13,45,00),ToplamSure= new TimeSpan(0,45,0),Statu="Duruş",DurusNedeni="Arıza"},
                     new UretimOperayonBildirimleri{Id=5, Baslangic= new DateTime(2020,5,23,13,45,00),Bitis= new DateTime(2020,5,23,15,15,00),ToplamSure= new TimeSpan(1,15,0),Statu="Uretim"},
                     new UretimOperayonBildirimleri{Id=5, Baslangic= new DateTime(2020,5,23,15,00,00),Bitis= new DateTime(2020,5,23,15,15,00),ToplamSure= new TimeSpan(0,15,0),Statu="Duruş", DurusNedeni="Çay Molası"},
                     new UretimOperayonBildirimleri{Id=5, Baslangic= new DateTime(2020,5,23,15,15,00),Bitis= new DateTime(2020,5,23,17,15,00),ToplamSure= new TimeSpan(2,15,0),Statu="Uretim"}
                   };
            }

            return _uretimBildirimleri;
        }
    }
}
