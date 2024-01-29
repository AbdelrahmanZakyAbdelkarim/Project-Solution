using DinkToPdf;
using DinkToPdf.Contracts;

namespace Project.PL.Helpers
{
    public class PdfConverter
    {
        private readonly IConverter _converter;


        public PdfConverter()
        {
            _converter = new SynchronizedConverter(new PdfTools());
        }

        public byte[] ConvertHtmlToPdf(string[] items)
        {
            // set up the document
            HtmlToPdfDocument doc = new HtmlToPdfDocument()
            {
              GlobalSettings = {
              PaperSize = new PechkinPaperSize("100","100"),
              Orientation = Orientation.Portrait,
              Margins = new MarginSettings() { Top = 10, Left = 10, Right = 10 },
              
           },
            };

            // add object settings to the document
            foreach (var item in items)
            {
                var page = new ObjectSettings()
                {
                    PagesCount = true,
                    WebSettings = { DefaultEncoding = "utf-8" },
                    HtmlContent = item,
                    
                };
                doc.Objects.Add(page);
            }

            //convert
            var pdf = _converter.Convert(doc);

            return pdf;
        }
    }
}
