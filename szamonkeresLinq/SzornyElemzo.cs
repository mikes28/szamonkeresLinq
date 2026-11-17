using System;
using System.Collections.Generic;
using System.Text;

namespace szamonkeresLinq
{
    internal class SzornyElemzo
    {
        //linq qyuerries to get statisctics about the monsters in the database

        private List<Szorny> szornyek;
        public SzornyElemzo(List<Szorny> szornyek)
        {
            this.szornyek = szornyek;
        }

        public int OsszesSzornySzama()
        {
            return szornyek.Count;
        }
        public IEnumerable<Szorny> VeszelyesSzornyekNevei()
        {
            return szornyek.Where(s => s.VeszelyesE).Select(s => s);
        }
        public IEnumerable<string> EgyediElohelyek()
        {
            var places = szornyek.Select(s => s.Elohely).Distinct();
            return (places.OrderBy(p => p));
        }
        public double AtlagosVeszelyesseg()
        {
            return szornyek.Average(s => s.VeszelyessegiSzint);
        }
        public IEnumerable<Szorny> LegveszelyesebbSzornyek()
        {
            int maxVeszelyessegiSzint = szornyek.Max(s => s.VeszelyessegiSzint);
            return szornyek.Where(s => s.VeszelyessegiSzint == maxVeszelyessegiSzint);
        }
        public IEnumerable<Szorny> MocsariVeszelyesSzornyek()
        {
            return szornyek.Where(s => s.Elohely.ToLower().Contains("mocsár") && s.VeszelyessegiSzint>=5);
        }
        public bool VanExtremTuzGyengeSzorny()
        {
            return szornyek.Any(s => s.FoGyengeseg.ToLower().Contains("tűz") && s.VeszelyessegiSzint >= 9);
        }
        public IEnumerable<string> SzornyekSzamaElohelyenkent()
        {
            var query = szornyek.GroupBy(s => s.Elohely)
                                .Select(g => $"{g.Key}: {g.Count()}");
            return query;
        }



    }
}
