using BuilderExample.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Builders.Abstracts;

#nullable disable

public abstract class ReportBuilder
{
    protected Report reportObject;
    public abstract void SetReportType();
    public abstract void SetReportHeader();
    public abstract void SetReportContent();
    public abstract void SetReportFooter();

    public void CreateNewReport()
    {
        reportObject = new Report();
    }

    public Report GetReport()
    {
        return reportObject;
    }
}
