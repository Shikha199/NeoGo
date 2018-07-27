<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPEA.Master" AutoEventWireup="true"
    CodeBehind="GST_GSTR1.aspx.cs" Inherits="JEMEA.Report.GST_GSTR1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent_Css" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MAPPMAINCONTENT" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <Triggers>
           
        </Triggers>
        <ContentTemplate>

            <div class="container-fluid">

                <div class="mp_ctrl_breadcrumb row clearfix">

                    <div class="breadcrumb-line">
                        <ul class="breadcrumb">
                            <li>Sales</li>
                            <li class="active">Sales Register</li>
                        </ul>
                    </div>

                </div>
                <div class="row mp_ctrl_ph">
                    <div class="col-md-6">
                        <h2 class="mp_ctrl_frmheading">Sales Register</h2>
                    </div>
                    <div class="col-md-6">
                        <div class="mp_ctrl_box  pull-right">

                             
                             
                            <asp:LinkButton ID="btnListClose" runat="server" OnClick="btnClose_Click" CssClass="btn btn-danger">Close</asp:LinkButton>

                        </div>
                    </div>
                </div>
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="List" runat="server">
                         <div class="row mp_ctrl_searchbox">
                            <div class="col-md-12 ">
                                  <div class="col-md-3">
                                    <div class="form-group">
                                        <label>Year</label>
                                         <asp:DropDownList ID="YearDesc" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                    DataTextField="Text" runat="server">
                                                </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label>Month</label>
                                        <asp:DropDownList ID="MonthDesc" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                    DataTextField="Text" runat="server">
                                                </asp:DropDownList>
                                    </div>
                                </div>
                               
                            </div>
                             
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <h2 class="mp_ctrl_gv_title">Sales Summary Report

                                 <span class="pull-right">
                                     <asp:Label ID="Msg_RCNT" runat="server" CssClass="mp_e_msg_default" Text=""></asp:Label></span>
                                </h2>
                            </div>
                        </div>
                        <hr class="mp_ctrl_gv_hr" />
                        <div class="table-responsive">
                            <asp:GridView ID="gvList" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="gvList_PageIndexChanging"
                                Width="100%" PageSize="10" OnRowCreated="gvList_RowCreated" CssClass="mp_ctrl_gv"
                                PagerStyle-CssClass="mp_ctrl_gv_pagination" HeaderStyle-CssClass="mp_ctrl_gv_header">
                                <Columns>
                                    <asp:BoundField DataField="SINVHDR_ID" />
                                    <%--<0>--%><asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                        <ItemTemplate>
                                            <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="SINV_Taxtype" HeaderText="Tax Type" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_No" HeaderText="Invoice No" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="vSINV_DT" HeaderText="Invoice Dt" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="MCust_Name" HeaderText="Customer" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    
                                     
                                    
                                    <asp:BoundField DataField="SINV_CreditDays" HeaderText="Credit Days" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="vSINV_DueDT" HeaderText="Dute Dt" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" />
                                     
                                     
                                    <asp:BoundField DataField="SINV_HDR_Net_Amt" HeaderText="Taxable Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    
                                    <asp:BoundField DataField="SINV_HDR_Total_Tax_Amt" HeaderText="GST" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_HDR_Total_Gross_Amt" HeaderText="Invoice Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    
                                    <asp:BoundField DataField="SINV_HDR_CreditNote_AsOn_Amt" HeaderText="Credit Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_HDR_DebitNote_AsOn_Amt" HeaderText="Dedit Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_HDR_Paid_AsOn_Amt" HeaderText="Paid As On" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_HDR_Outstanding_AsOn_Amt" HeaderText="Outstanding As On" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />

                                    

                                      <asp:BoundField DataField="MDBSC_RowStatus" HeaderText="Status" ItemStyle-HorizontalAlign="left" HeaderStyle-HorizontalAlign="Center" />
                                
                                  
                                </Columns>
                            </asp:GridView>
                        </div>
                    </asp:View>
                    
                </asp:MultiView>
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerscript" runat="server">
</asp:Content>
