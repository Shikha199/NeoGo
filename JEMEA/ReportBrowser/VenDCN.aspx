<%@ Page Title="" Language="C#"  AutoEventWireup="true" 
    CodeBehind="VenDCN.aspx.cs" 
    Inherits="JEMEA.ReportBrowser.VenDCN" %>
 


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Report Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <div>
                        <%--<asp:Panel ID="pnlReport" ScrollBars="Both" Height="100%" Width="100%" runat="server" Style="position: absolute;">--%>
                        <CR:CrystalReportViewer ID="CrystalReportViewer1" Width="100%" Height="100%" BestFitPage="True"
                            BorderWidth="1px" BorderStyle="NotSet" BorderColor="MediumPurple" runat="server"
                            AutoDataBind="true" EnableDatabaseLogonPrompt="False" />
                        <%--</asp:Panel>--%>
                    </div>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

