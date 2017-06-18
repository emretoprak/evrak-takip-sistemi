using System;
using System.Linq;
using DevExpress.XtraEditors;using DevExpress.XtraEditors.Controls;
using ETS.VeriKatmani;

namespace ETS.Akislar.Istatistikler
{
    public class OlayBilgileriYillikDokum
    {
        /// <summary>
        /// Yıllık döküm raporu
        /// </summary>
        /// <param name="lstRaporElemanlari"></param>
        /// <param name="raporYili"></param>
        /// <returns></returns>
        public string YillikDokum(ImageListBoxControl lstRaporElemanlari, int raporYili)
        {
            var htmlTable = "<html xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:x=\"urn:schemas-microsoft-com:office:excel\" xmlns=\"http://www.w3.org/TR/REC-html40\"><head><!--[if gte mso 9]><xml><x:ExcelWorkbook><x:ExcelWorksheets><x:ExcelWorksheet><x:Name>Yıllık Döküm</x:Name><x:WorksheetOptions><x:DisplayGridlines/></x:WorksheetOptions></x:ExcelWorksheet></x:ExcelWorksheets></x:ExcelWorkbook></xml><![endif]-->" +
                            "<title>Yıllık Döküm</title>" +
                            "<style>" +
                //"table,td,tr {border:1px solid #474747;}" +
                            "th {text-align:center; font-weight:bold;}" +
                            "</style>" +
                            "</head>" +
                            "<body>" +
                            "<table>" +
                            "<tr>" +
                            string.Format("<th colspan='{0}'>", lstRaporElemanlari.ItemCount + 7) +
                            string.Format("BOZDOĞAN İLÇE J.K.LIĞI {0} YILINDA MEYDANA GELEN OLAYLAR ÇİZELGESİ", raporYili) +
                            "</th>" +
                            "</tr>" +
                            "<tr style='mso-height-source:userset;height:55pt'>";

            // : Başlıklar
            htmlTable += "<th>";
            htmlTable += string.Format("{0} YILI OLAY SAYISI", raporYili);
            htmlTable += "</th>";
            for (var i = 0; i < lstRaporElemanlari.ItemCount; i++)
            {
                htmlTable += "<th>";
                htmlTable += lstRaporElemanlari.Items[i].ToString();
                htmlTable += "</th>";
            }
            htmlTable += "<th>";
            htmlTable += "TOPLAM";
            htmlTable += "</th>";

            // : Geçmiş Rapor Yılları
            var gecmisRaporYillari = raporYili;
            for (var i = 0; i < 5; i++)
            {
                gecmisRaporYillari = gecmisRaporYillari - 1;
                htmlTable += "<th style='background-color: #59b4cc; vertical-align:middle; text-align:center; width:48pt'>";
                htmlTable += gecmisRaporYillari + " YILI AYLIK OLAY SAYISI";
                htmlTable += "</th>";
            }
            htmlTable += "</tr>";

            using (var db = new ETSEntities())
            {
                // : Aylar
                for (var i = 1; i < 13; i++)
                {
                    htmlTable += "<tr>";

                    htmlTable += "<td style='background-color: #73FF9D;' width='30px' style='text-align:center;'>";
                    htmlTable += AyinAdiAl(i);
                    htmlTable += "</td>";

                    gecmisRaporYillari = raporYili;

                    // : Aylara ait veriler
                    for (var j = 0; j < lstRaporElemanlari.ItemCount + 6; j++)
                    {
                        // : Rapor elemanları istatistikleri
                        if (j < lstRaporElemanlari.ItemCount)
                        {
                            var raporElemani = lstRaporElemanlari.Items[j].ToString();
                            htmlTable += "<td width='30px' style='text-align:center;'>";
                            htmlTable += db.OlaylarBilgisi.Count(c => c.Tasnifler.Baslik.Equals(raporElemani) && c.OlayTarihi.Month == i && c.OlayTarihi.Year == raporYili);
                            htmlTable += "</td>";
                        }

                        // : Toplam satırı
                        if (j == lstRaporElemanlari.ItemCount)
                        {
                            htmlTable += "<td width='30px' style='text-align:center;'>";
                            htmlTable += db.OlaylarBilgisi.Count(c => c.OlayTarihi.Month == i && c.OlayTarihi.Year == raporYili);
                            htmlTable += "</td>";
                        }

                        // : Geçmiş yıllar verileri
                        if (j >= lstRaporElemanlari.ItemCount + 1)
                        {
                            gecmisRaporYillari = gecmisRaporYillari - 1;
                            htmlTable += "<td width='30px' style='text-align:center;'>";
                            htmlTable += db.OlaylarBilgisi.Count(c => c.OlayTarihi.Year == gecmisRaporYillari && c.OlayTarihi.Month == i);
                            htmlTable += "</td>";
                        }
                    }

                    htmlTable += "</tr>";
                }

                // : Toplamlar satırı
                htmlTable += "<tr>";

                htmlTable += "<td style='background-color: #e1e1e1;' width='30px' style='text-align:center;'>";
                htmlTable += "TOPLAM";
                htmlTable += "</td>";

                gecmisRaporYillari = raporYili;

                for (var j = 0; j < lstRaporElemanlari.ItemCount + 6; j++)
                {
                    // : Rapor elemanları toplamları
                    if (j < lstRaporElemanlari.ItemCount)
                    {
                        var raporElemani = lstRaporElemanlari.Items[j].ToString();
                        htmlTable += "<td width='30px' style='text-align:center;'>";
                        htmlTable += db.OlaylarBilgisi.Count(c => c.Tasnifler.Baslik.Equals(raporElemani) && c.OlayTarihi.Year == raporYili);
                        htmlTable += "</td>";
                    }

                    // : Toplam satırı
                    if (j == lstRaporElemanlari.ItemCount)
                    {
                        htmlTable += "<td width='30px' style='text-align:center;'>";
                        htmlTable += db.OlaylarBilgisi.Count(c => c.OlayTarihi.Year == raporYili);
                        htmlTable += "</td>";
                    }

                    // : Geçmiş yıllar toplamları
                    if (j >= lstRaporElemanlari.ItemCount + 1)
                    {
                        gecmisRaporYillari = gecmisRaporYillari - 1;
                        htmlTable += "<td style='background-color: #FFD966;' width='30px' style='text-align:center;'>";
                        htmlTable += db.OlaylarBilgisi.Count(c => c.OlayTarihi.Year == gecmisRaporYillari);
                        htmlTable += "</td>";
                    }
                }

                htmlTable += "</tr>";
            }

            htmlTable += "</table>";
            htmlTable += "</body>";
            htmlTable += "</html>";

            return htmlTable;
        }

        /// <summary>
        /// Olay dağılımı raporu
        /// </summary>
        /// <param name="lstRaporElemanlari">Seçili rapor elemanları</param>
        /// <returns></returns>
        public string OlayDagilimi(ImageListBoxItemCollection lstRaporElemanlari)
        {
            var htmlTable = "<html xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:x=\"urn:schemas-microsoft-com:office:excel\" xmlns=\"http://www.w3.org/TR/REC-html40\"><head><!--[if gte mso 9]><xml><x:ExcelWorkbook><x:ExcelWorksheets><x:ExcelWorksheet><x:Name>Yıllık Döküm</x:Name><x:WorksheetOptions><x:DisplayGridlines/></x:WorksheetOptions></x:ExcelWorksheet></x:ExcelWorksheets></x:ExcelWorkbook></xml><![endif]-->" +
                            "<title>Yıllık Döküm</title>" +
                            "<style>" +
                            "th {text-align:center; font-weight:bold;}" +
                            "</style>" +
                            "</head>" +
                            "<body>" +
                            "<table>";

            using (var db = new ETSEntities())
            {
                // : Başlıklar
                htmlTable += "<tr>";
                for (var i = -1; i < lstRaporElemanlari.Count; i++)
                {
                    if (i >= 0)
                    {
                        htmlTable += "<td colspan='6' style='background-color: "+ RaporRengi(i) +";' valign='center' align='center'>" + lstRaporElemanlari[i] + "</td>";
                    }
                    else
                    {
                        htmlTable += "<td></td>";
                    }
                }

                // : Genel Toplam
                htmlTable += "<td colspan='6' style='background-color: " + RaporRengi(99) + ";' valign='center' align='center'>GENEL TOPLAM</td>";

                htmlTable += "</tr>";

                // : Yıllar
                htmlTable += "<tr>";
                for (var i = -1; i < lstRaporElemanlari.Count + 1; i++)
                {
                    if (i >= 0)
                    {
                        for (var yil = DateTime.Now.Year - 4; yil <= DateTime.Now.Year; yil++)
                        {
                            htmlTable += "<td style='background-color: " + RaporRengi(i) + ";' valign='center' align='center'>" + yil + "</td>";
                            if (yil == DateTime.Now.Year)
                            {
                                htmlTable += "<td style='background-color: " + RaporRengi(i) + ";' valign='center' align='center'>TOPLAM</td>";
                            }
                        }
                    }
                    else
                    {
                        htmlTable += "<td></td>";
                    }
                }
                htmlTable += "</tr>";

                // : Köyler ve rakamları
                var olayYerleri = db.OlayYerleri.Distinct().ToArray();
                foreach (var t in olayYerleri)
                {
                    htmlTable += "<tr>";
                    var aralik = 0;
                    var yil = DateTime.Now.Year - 4;
                    var toplam = 6 * lstRaporElemanlari.Count;
                    var digerKolon = false;
                    for (var j = 0; j < toplam; j++)
                    {
                        if (j == 0)
                        {
                            htmlTable += "<td>" + t.OlayYeri + "</td>";
                        }
                        else
                        {
                            if (j > 1 && yil == DateTime.Now.Year - 4)
                            {
                                aralik++;
                                digerKolon = aralik >= lstRaporElemanlari.Count;
                            }
                            if (!digerKolon){
                                var grup = lstRaporElemanlari[aralik].ToString();
                                var ids = db.Tasnifler.Where(s => s.Grup == grup).Select(s => s.Id).ToList();
                                htmlTable += "<td style='background-color: " + RaporRengi(aralik) + ";'>" + db.OlaylarBilgisi.Count(w => ids.Contains((int) w.TansifId) && w.OlayTarihi.Year == yil && w.OlayYeriId == t.Id) + "</td>";
                                if (j % 5 == 0)
                                {
                                    yil = DateTime.Now.Year - 4;
                                    htmlTable += "<td style='background-color: " + RaporRengi(aralik) + ";'>" + db.OlaylarBilgisi.Count(w => ids.Contains((int)w.TansifId) && yil <= w.OlayTarihi.Year && yil + 5 >= w.OlayTarihi.Year && w.OlayYeriId == t.Id) + "</td>";
                                }
                                else
                                {
                                    yil++;
                                }
                            }
                        }
                    }// : Genel Toplamlar
                    for (var genelToplamYili = DateTime.Now.Year - 4; genelToplamYili <= DateTime.Now.Year + 1; genelToplamYili++)
                    {
                        if (genelToplamYili > DateTime.Now.Year)
                        {
                            htmlTable += "<td style='background-color: " + RaporRengi(aralik) + ";'>" + db.OlaylarBilgisi.Count(w => DateTime.Now.Year - 4 <= w.OlayTarihi.Year && DateTime.Now.Year >= w.OlayTarihi.Year && w.OlayYeriId == t.Id) + "</td>";
                        }
                        else
                        {
                            htmlTable += "<td style='background-color: " + RaporRengi(aralik) + ";'>" + db.OlaylarBilgisi.Count(w => w.OlayTarihi.Year == genelToplamYili && w.OlayYeriId == t.Id) + "</td>";
                        }
                    }
                    htmlTable += "</tr>";
                }
            }

            htmlTable += "</table>";
            htmlTable += "</body>";
            htmlTable += "</html>";

            return htmlTable;
        }

        /// <summary>
        /// Rapor renkleri
        /// </summary>
        /// <param name="sira"></param>
        /// <returns></returns>
        private static string RaporRengi(int sira)
        {
            switch (sira)
            {
                case 0:
                    return "#99FF99";
                case 1:
                    return "#FFBFFF";
                case 2:
                    return "#00A3D9";
                case 3:
                    return "#FFFF73";
                case 4:
                    return "#BFFFCF";
                case 5:
                    return "#B399FF";
                case 6:
                    return "#FFCFBF";
                case 7:
                    return "#BFDFFF";
                case 8:
                    return "#FFFF73";
                case 9:
                    return "#FFFF73";
                case 10:
                    return "#FFFF73";
                case 11:
                    return "#FFFF73";
                case 99:
                    return "#66ccff";
                default:
                    return "#ffffff";
            }
        }

        /// <summary>
        /// Girilen ay rakamını isimine çevirir
        /// </summary>
        /// <param name="ay">ay rakamı</param>
        /// <returns>Ayın ismi</returns>
        internal string AyinAdiAl(int ay)
        {
            switch (ay)
            {
                case 1:
                    return "Ocak";
                case 2:
                    return "Şubat";
                case 3:
                    return "Mart";
                case 4:
                    return "Nisan";
                case 5:
                    return "Mayıs";
                case 6:
                    return "Haziran";
                case 7:
                    return "Temmuz";
                case 8:
                    return "Ağustos";
                case 9:
                    return "Eylül";
                case 10:
                    return "Ekim";
                case 11:
                    return "Kasım";
                case 12:
                    return "Aralık";
            }
            return "";
        }
    }
}
