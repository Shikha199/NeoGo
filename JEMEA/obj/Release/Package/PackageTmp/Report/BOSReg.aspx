<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPEA.Master" AutoEventWireup="true"
    CodeBehind="BOSReg.aspx.cs" Inherits="JEMEA.Purchase.BOSReg" %>

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
                            <li class="active">Bill Of Supply Register</li>
                        </ul>
                    </div>

                </div>
                <div class="row mp_ctrl_ph">
                    <div class="col-md-6">
                        <h2 class="mp_ctrl_frmheading">Bill Of Supply Register</h2>
                    </div>
                    <div class="col-md-6">
                        <div class="mp_ctrl_box  pull-right">

                            <asp:LinkButton ID="LnkRptSummary" runat="server" CssClass="btn btn-success" OnClick="LnkRptSummary_Click">Summary Report</asp:LinkButton>
                            <asp:LinkButton ID="btnDetail" runat="server" CssClass="btn btn-primary" OnClick="btnDetail_Click">Detail Report</asp:LinkButton>
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
                                        <label>From Date</label>
                                        <asp:TextBox ID="Txt_FromDT" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                        <asp:CalendarExtender ID="CalendarExtender4" runat="server" TargetControlID="Txt_FromDT"
                                            CssClass="cal_Theme1" Format="dd-MMM-yyyy"></asp:CalendarExtender>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label>To Date</label>
                                        <asp:TextBox ID="Txt_ToDT" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                        <asp:CalendarExtender ID="CalendarExtender5" runat="server" TargetControlID="Txt_ToDT"
                                            CssClass="cal_Theme1" Format="dd-MMM-yyyy"></asp:CalendarExtender>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12 ">
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label>Search On</label>
                                        <asp:DropDownList ID="ddSearchBy" CssClass="form-control mp_ctrl_js_dd" runat="server" DataTextFormatString="ColumnHeader"
                                            DataValueField="ColumnName">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label>Operator</label>
                                        <asp:DropDownList ID="ddOperator" CssClass="form-control mp_ctrl_js_dd" runat="server" DataTextField="operatortext" DataValueField="operator">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label>Value</label>
                                        <asp:TextBox ID="searchvalue" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <div class="spacer-20"></div>
                                        <asp:ImageButton ID="imgButtonGo" runat="server" ImageUrl="~/Content/images/appimg/appicon/system/search.png" OnClick="imgButtonGo_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <h2 class="mp_ctrl_gv_title">Bill Of Supply Summary Report

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
                    <asp:View ID="Entry" runat="server">
                        


                         <div class="row mp_ctrl_searchbox">
                            <div class="col-md-12 ">
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label>From Date</label>
                                        <asp:TextBox ID="Dtl_Txt_FromDT" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                        <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="Dtl_Txt_FromDT"
                                            CssClass="cal_Theme1" Format="dd-MMM-yyyy"></asp:CalendarExtender>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label>To Date</label>
                                        <asp:TextBox ID="Dtl_Txt_ToDT" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                        <asp:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="Dtl_Txt_ToDT"
                                            CssClass="cal_Theme1" Format="dd-MMM-yyyy"></asp:CalendarExtender>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12 ">
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label>Search On</label>
                                        <asp:DropDownList ID="Dtl_ddSearchBy" CssClass="form-control mp_ctrl_js_dd" runat="server" DataTextFormatString="ColumnHeader"
                                            DataValueField="ColumnName">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label>Operator</label>
                                        <asp:DropDownList ID="Dtl_ddOperator" CssClass="form-control mp_ctrl_js_dd" runat="server" DataTextField="operatortext" DataValueField="operator">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label>Value</label>
                                        <asp:TextBox ID="Dtl_searchvalue" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <div class="spacer-20"></div>
                                        <asp:ImageButton ID="Dtl_imgButtonGo" runat="server" ImageUrl="~/Content/images/appimg/appicon/system/search.png" OnClick="Dtl_imgButtonGo_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-12">
                                <h2 class="mp_ctrl_gv_title">Bill Of Supply Detail Report
                                 <span class="pull-right">
                                     <asp:Label ID="Msg_RCNTItem" runat="server" CssClass="mp_e_msg_default" Text=""></asp:Label></span>
                                </h2>
                            </div>
                        </div>
                        <hr class="mp_ctrl_gv_hr" />
                        <div class="table-responsive">
                            <asp:GridView ID="gvdtl" runat="server" AllowPaging="false" AutoGenerateColumns="False"    OnPageIndexChanging="gvdtl_PageIndexChanging"
                                Width="100%" OnRowCreated="gvdtl_RowCreated" CssClass="mp_ctrl_gv_dtl" HeaderStyle-CssClass="mp_ctrl_gv_header_dtl" PagerStyle-CssClass="mp_ctrl_gv_pagination">
                                <Columns>
                                    <asp:BoundField DataField="SINVDTL_ID" />
                                    <asp:BoundField DataField="Fk_SINVHDR_ID" />
                                    <asp:BoundField DataField="Fk_MItem_ID" />
                                     
                                     

                                    <asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                        <ItemTemplate>
                                            <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                      
                                    <asp:BoundField DataField="SINV_No" HeaderText="Invoice No" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="vSINV_DT"  HeaderText="Invoice Dt" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="MCust_Name" HeaderText="Customer" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    
                                     
                                    
                                    <asp:BoundField DataField="SINV_CreditDays" HeaderText="Credit Days" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="vSINV_DueDT" HeaderText="Dute Dt" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" />
                                     
                                          <asp:BoundField DataField="vItem_Group" HeaderText="Group" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="Item_Name" HeaderText="Item" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="UMO" HeaderText="UOM" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_HSNCode" HeaderText="HSN/SAC" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                 <asp:BoundField DataField="SINV_QTY" HeaderText="Qty" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_BasicRate" HeaderText="Unit Rate" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_BasicAmt" HeaderText="Amount" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />


                                    <asp:BoundField DataField="SINV_DiscountRate" HeaderText="Discount Rate" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_DiscountAmt" HeaderText="Discount Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />

                                    
                                 
                                    <asp:BoundField DataField="SINV_GrossRateWithTax" HeaderText="Taxable Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                     
                                    <asp:BoundField DataField="SINV_ItemRemark_DTL" HeaderText="Remark" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />

                                    

                                

                                     
                                   
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
