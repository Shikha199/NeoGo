<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPEA.Master"  
    AutoEventWireup="true" CodeBehind="App_Module.aspx.cs" Inherits="JEMEA.AI.AppGateway.App_Module" %>
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
                            <li>Master</li>
                            <li class="active">Modules Selection</li>
                        </ul>
                    </div>
                 
            </div>

            <div class="row mp_ctrl_ph">
                <div class="col-md-6">
                    <h2 class="mp_ctrl_frmheading">Modules  Selection</h2>
                </div>
                <div class="col-md-6">
                    <div class="mp_ctrl_box  pull-right">
                         
                     
                        <asp:LinkButton ID="btnListClose" OnClick="btnClose_Click" runat="server" CssClass="btn btn-danger" >Close</asp:LinkButton>

                    </div>
                </div>
            </div>
           

          




            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FooterScript" runat="server">
</asp:Content>