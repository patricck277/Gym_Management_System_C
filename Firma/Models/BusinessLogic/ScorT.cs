using Firma.Models.Context;
using Firma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Firma.Models.BusinessLogic
{
    public class ScorT : DatabaseClass
    {
        #region Konstruktor
        public ScorT(GymEntities gymEntities)
            : base(gymEntities)
        {
        }
        #endregion
        #region Funkcje biz

        public decimal? RaportOcenaT(int IdTrener, DateTime dataOd, DateTime dataDo)
        {
            // Oblicza średnią ocenę dla danego trenera w określonym przedziale czasowym
            var sredniaOcena = (
                from OcenyTrenerow in gymEntities.OcenyTrenerows
                where
                    OcenyTrenerow.IdTrener == IdTrener &&
                    OcenyTrenerow.DataOceny >= dataOd &&
                    OcenyTrenerow.DataOceny <= dataDo
                select OcenyTrenerow.Ocena
            ).Average();

            return sredniaOcena.HasValue ? (decimal?)Math.Round(sredniaOcena.Value, 2) : null;
        }

        #endregion

        #region PDF
        public void GenerujRaportPDF(int IdTrener, DateTime dataOd, DateTime dataDo, decimal? sredniaOcena, string imieTrenera)
        {
            string path = "raport_ocena_trenera.pdf";
            FileStream fs = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4, 25, 25, 30, 30); // Ustawienia marginesów
            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            document.Open();

            document.Add(new Paragraph($"Raport oceny trenera: {imieTrenera}"));
            document.Add(new Paragraph($"Identyfikator trenera: {IdTrener}"));
            document.Add(new Paragraph($"Okres: {dataOd.ToString("dd-MM-yyyy")} - {dataDo.ToString("dd-MM-yyyy")}"));
            document.Add(new Paragraph($"Średnia ocena: {sredniaOcena?.ToString("0.00")}"));

            document.Close();
            fs.Close();
        }

        #endregion
    }
}
