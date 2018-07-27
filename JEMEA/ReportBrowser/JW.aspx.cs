using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MABL.ATDataModal;
using MaheshAF18.Application;
using MaheshAF18.Utility;
using MaheshAF18.UIControlHelper.UILayout;
using MABL.MCore.STDataModal;
using System.IO;

namespace JEMEA.ReportBrowser
{
    public partial class JW : Mahesh_Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetReport();
        }
        public void GetReport()
        {
            try
            {
                string sReportHeading = "";
                string sAmtInWords = "";
                string sReportcomment = "";
                string sReportInFile = "";
                string strSQL = "";

                sReportHeading = "";

                sReportInFile = "GST_SU_JobWork.rpt";

                strSQL = " AAA_M_USP_Print_JobWork " + SessionUserData.Company.CompanyID +
                                           "," + SessionUserData.Company.BranchID +
                                           "," + SessionUserData.Company.YearID +
                                           "," + SessionUserData.AppInfo.TempIntVariable_1;
                DataTable myDS = new DataTable();
                myDS = MaheshAF18.Application.MEF.DA_GetDataTable(strSQL);

                if (File.Exists(Server.MapPath(myDS.Rows[0]["BL_Logo_Url"].ToString())))
                {
                    FileStream stream = new FileStream(Server.MapPath(myDS.Rows[0]["BL_Logo_Url"].ToString()), FileMode.Open, FileAccess.Read);
                    byte[] ImgData = new byte[stream.Length];
                    stream.Read(ImgData, 0, Convert.ToInt32(stream.Length));
                    stream.Close();
                    myDS.Rows[0]["BL_Logo_Img"] = ImgData;
                }



                decimal vatTotalAmt = Convert.ToDecimal(0 + myDS.Rows[0]["JW_HDR_Gross_Amt"].ToString());
                sAmtInWords = MaheshAF18.Utility.NoToWord.AmtInWord_INR(vatTotalAmt);
                CrystalDecisions.CrystalReports.Engine.ReportDocument myReportDocument = default(CrystalDecisions.CrystalReports.Engine.ReportDocument);

                myReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                myReportDocument.Load(Server.MapPath("..\\Rpt\\") + sReportInFile + "");

                myReportDocument.Database.Tables[0].SetDataSource(myDS);
                //myReportDocument.SetParameterValue("pRepHeading", sReportHeading);
                myReportDocument.SetParameterValue("AmtInWords ", sAmtInWords);
                myReportDocument.ExportToHttpResponse(ExportFormatType.PortableDocFormat, System.Web.HttpContext.Current.Response, false, "JobWork");
                //Session["reportDataSource"] = myReportDocument;
                //CrystalReportViewer1.DisplayGroupTree = false;
                //CrystalReportViewer1.ReportSource = myReportDocument;
                //CrystalReportViewer1.DataBind();
            }
            catch (Exception ex)
            {
                DisplayCustomMessageSummary(ex.Message);
            }
        }

    }
}