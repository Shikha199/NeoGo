<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPEA.Master" AutoEventWireup="true" CodeBehind="WAU.aspx.cs" Inherits="JEMEA.Dashboard.WAU" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent_Css" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent_JS" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MAPPMAINCONTENT" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
            <div class="container-fluid">
                <div class="mp_ctrl_breadcrumb row clearfix">
                    <div class="breadcrumb-line">
                        <ul class="breadcrumb">
                            <li>Home</li>
                            <li class="active">Dashboard</li>
                        </ul>
                    </div>
                </div>  
                <div class="row mp_ctrl_ph">
                    <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                        <h2 class="mp_ctrl_frmheading">Dashboard</h2>
                    </div>
                  <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                      <div class="mp_ctrl_box  pull-right"> 
                      </div>
                  </div>
                </div>
            </div> 
        </ContentTemplate>
          </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FooterScript" runat="server">
</asp:Content>
