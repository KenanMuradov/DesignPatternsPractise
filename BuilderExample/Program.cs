using BuilderExample.Builders.Abstracts;
using BuilderExample.Builders.Concretes;
using BuilderExample.Directors;
using BuilderExample.Products;
using System;

namespace BuilderExample;

public class Program
{
    public static void Main()
    {
        // Client Code
        Report report;
        ReportDirector reportDirector = new ReportDirector();
        // Construct and display Reports
        ReportBuilder pdfReport = new PDFReport();
        report = reportDirector.MakeReport(pdfReport);
        report.DisplayReport();
        Console.WriteLine("-------------------");
        ReportBuilder excelReport = new ExcelReport();
        report = reportDirector.MakeReport(excelReport);
        report.DisplayReport();

        Console.ReadKey();
    }
}