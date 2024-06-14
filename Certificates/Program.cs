// See https://aka.ms/new-console-template for more information

using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

QuestPDF.Settings.License = LicenseType.Community;

var imageData =
    File.ReadAllBytes("C:\\Users\\Marius\\RiderProjects\\Certificates\\Certificates\\resources\\5718079.jpg");
// REMU PAIESKA
// https://pngtree.com/freepng/gold-line-blue-background-certificate-border_6491225.html 
Console.WriteLine(imageData.Length);

Document.Create(document =>
{
    document.Page(page =>
    {
        page.Content().Layers(layers =>
        {
            // layer below main content
            layers
                .Layer()
                .Image(Image.FromFile(
                    "C:\\Users\\Marius\\RiderProjects\\Certificates\\Certificates\\resources\\naujas.png")).FitUnproportionally();


            layers
                .PrimaryLayer()
                .Column(col =>
                {
                    col.Item()
                        .AlignCenter()
                        .Width(70, Unit.Millimetre)
                        .PaddingTop(25, Unit.Millimetre)
                        .Image(Image.FromFile(
                            "C:\\Users\\Marius\\RiderProjects\\Certificates\\Certificates\\resources\\logo.jpg"));
                    col.Item()
                        .AlignCenter()
                        .PaddingTop(30)
                        .Text("QUALITY CERTIFICATE")
                        .Bold().FontSize(30).FontColor(Colors.Blue.Darken4);

                    col.Item()
                        .AlignCenter()
                        .PaddingTop(10)
                        .Text("This is hereby to certify that")
                        .FontSize(14)
                        .FontColor(Colors.Black);

                    col.Item()
                        .AlignCenter()
                        .PaddingTop(5)
                        .Text("Practice Enterprise: Viko Bankas")
                        .FontSize(16)
                        .Bold()
                        .FontColor(Colors.Black);

                    col.Item()
                        .AlignCenter()
                        .PaddingTop(5)
                        .Text("PE Trainer: Marius Ignatonis")
                        .FontSize(14)
                        .FontColor(Colors.Black);
                    
                    col.Item()
                        .AlignCenter()
                        .PaddingTop(5)
                        .Text("PE Students: Petras Petriukas, Ona Onaitienė, Jonas Jonaitis")
                        .FontSize(14)
                        .FontColor(Colors.Black);
                    
                    col.Item()
                        .AlignCenter()
                        .PaddingTop(5)
                        .Text("Institution: Viko")
                        .FontSize(14)
                        .FontColor(Colors.Black);
                    
                    
                    
                    
                    col.Item()
                        .AlignCenter()
                        .PaddingTop(5)
                        .Text("Country: Lietuva")
                        .FontSize(14)
                        .FontColor(Colors.Black);
                    
                    
                    col.Item()
                        .AlignCenter()
                        .PaddingTop(5)
                        .Text("has participated in external quality management auditing procedures")
                        .FontSize(14)
                        .FontColor(Colors.Black);
                    
                    
                    col.Item()
                        .AlignCenter()
                        .PaddingTop(5)
                        .Text("in the field SALES MANAGEMENT")
                        .FontSize(14)
                        .FontColor(Colors.Black);
                    
                  
                    
                    
                    col.Item()
                        .AlignCenter()
                        .PaddingTop(5)
                        .Text("according to PEN-QM quality system www.pen......")
                        .FontSize(14)
                        .FontColor(Colors.Black);
                    
                    col.Item()
                        .AlignCenter()
                        .PaddingTop(5)
                        .Text("and achieved BRONZE level gathering XX points from max 50")
                        .FontSize(14)
                        .FontColor(Colors.Black);
                    
                    
                    col.Item()
                        .AlignCenter()
                        .PaddingTop(20)
                        .Text("achievements are described in the other side of this certificate")
                        .FontSize(14)
                        .FontColor(Colors.Black);
                    
                    col.Item()
                        .AlignCenter()
                        .PaddingTop(5)
                        .MaxWidth(170, Unit.Millimetre)
                        .Text("Auditors/auditor: Bronius Bronislavas, Viko Elektronikos ir informatikos fakultetas, Lietuva")
                        .FontSize(14)
                        .FontColor(Colors.Black);
                    
                    
                    col.Item()
                        .AlignCenter()
                        .PaddingTop(5)
                        .Text("Certificate No. FE98521325")
                        .FontSize(12)
                        .FontColor(Colors.Black);
                    
                    col.Item()
                        .AlignCenter()
                        .PaddingTop(5)
                        .Text("Date: 06/10/2024")
                        .FontSize(12)
                        .FontColor(Colors.Black);
                    
                    col.Item()
                        .AlignCenter()
                        .PaddingTop(5)
                        .Text("Validation period: 06/10/2026")
                        .FontSize(12)
                        .FontColor(Colors.Black);
                    
                    
                    
                    
                    
                });


            // layers
            //     .PrimaryLayer()
            //     .Padding(25, Unit.Millimetre)
            //     .Column(column =>
            //     {
            //         column.Spacing(5);
            //
            //         foreach (var _ in Enumerable.Range(0, 5))
            //             column.Item().Text(Placeholders.Sentence());
            //     });

            // layer above the main content    
            // layers
            //     .Layer()
            //     .AlignCenter()
            //     .AlignMiddle()
            //     .Text("Watermark")
            //     .FontSize(48).Bold().FontColor(Colors.Green.Lighten3);

            layers
                .Layer()
                .AlignBottom();
        });
    });
    document.Page(page => { page.Header().Height(1, Unit.Inch).Background(Colors.Black); });
}).ShowInPreviewer();