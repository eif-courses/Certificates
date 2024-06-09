// See https://aka.ms/new-console-template for more information

using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

QuestPDF.Settings.License = LicenseType.Community;

var imageData =
    File.ReadAllBytes("C:\\Users\\Marius\\RiderProjects\\Certificates\\Certificates\\resources\\5718079.jpg");

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
                    "C:\\Users\\Marius\\RiderProjects\\Certificates\\Certificates\\resources\\frame.webp"));


            layers
                .PrimaryLayer()
                .Column(col =>
                {
                    col.Item()
                        .AlignCenter()
                        .Width(70, Unit.Millimetre)
                        .PaddingTop(20, Unit.Millimetre)
                        .Image(Image.FromFile(
                            "C:\\Users\\Marius\\RiderProjects\\Certificates\\Certificates\\resources\\logo.jpg"));
                    col.Item()
                        .AlignCenter()
                        .PaddingTop(30)
                        .Text("Certificate of Completion")
                        .FontSize(36)
                        .Bold()
                        .FontColor(Colors.Black);

                    col.Item()
                        .AlignCenter()
                        .PaddingTop(10)
                        .Text("This is to certify that:")
                        .FontSize(24)
                        .FontColor(Colors.Black);

                    col.Item()
                        .AlignCenter()
                        .PaddingTop(5)
                        .Text("John Doe")
                        .FontSize(30)
                        .Bold()
                        .FontColor(Colors.Black);

                    col.Item()
                        .AlignCenter()
                        .PaddingTop(5)
                        .Text("has successfully completed the course.")
                        .FontSize(24)
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
            layers
                .Layer()
                .AlignCenter()
                .AlignMiddle()
                .Text("Watermark")
                .FontSize(48).Bold().FontColor(Colors.Green.Lighten3);

            layers
                .Layer()
                .AlignBottom();
        });
    });
    document.Page(page => { page.Header().Height(1, Unit.Inch).Background(Colors.Black); });
}).ShowInPreviewer();