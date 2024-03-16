using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Hotel.DataBase;

namespace Hotel
{
    public partial class Report : Form
    {

        HotelDBContext context = new HotelDBContext();
        string customerSSN;


        public Report(string _customerSSN)
        {
            InitializeComponent();
            customerSSN = _customerSSN;
        }


        private void crystalReportViewer_Load(object sender, EventArgs e)
        {
            ReportDocument bookingReport = new ReportDocument();
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            bookingReport.Load(projectDirectory + @"\\Hotel\\BookingReport.rpt");
     

            var dataReports = context.Bookings.Where(b => b.CustomerSSN == customerSSN)
                .Select(b => new 
                {
                    RoomID = b.RoomID,
                    BookingDate = b.BookingDate,
                    CheckInDate = b.CheckInDate,
                    CheckOutDate = b.CheckOutDate,
                    Duration = b.Duration,
                    BookingCost = b.BookingCost
                }).ToList();

            Customer customer = context.Customers.Find(customerSSN);

            bookingReport.SetDataSource(dataReports);
            bookingReport.SetParameterValue("CustomerName", customer.Name);
            bookingReport.SetParameterValue("SSN", customer.SSN);
            bookingReport.SetParameterValue("Phone", customer.PhoneNumber);
            bookingReport.SetParameterValue("Address", customer.Address);
            bookingReport.SetParameterValue("DateNow", DateTime.Today.ToShortDateString());
            
            crystalReportViewer.ReportSource = bookingReport;
            crystalReportViewer.Refresh();

            bookingReport.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, projectDirectory + $@"\\Reports\\{customer.SSN}.pdf");

        
        }
    }
}
