<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPEA.Master" AutoEventWireup="true"
    CodeBehind="VenDCN.aspx.cs" Inherits="JEMEA.Sales.VenDCN" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent_Css" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MAPPMAINCONTENT" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <Triggers>
            <asp:PostBackTrigger ControlID="btnPrint" />
            <asp:PostBackTrigger ControlID="gvList" />
        </Triggers>
        <ContentTemplate>

            <div class="container-fluid">
                <div class="mp_ctrl_breadcrumb row clearfix">
                    <div class="breadcrumb-line">
                        <ul class="breadcrumb">
                            <li>Sales</li>
                            <li class="active">Vendor Debit/Credit Note Details</li>
                        </ul>
                    </div>
                </div>
                <div class="row mp_ctrl_ph">
                    <div class="col-md-6">
                        <h2 class="mp_ctrl_frmheading">Vendor Debit/Credit Note Details</h2>
                    </div>
                    <div class="col-md-6">
                        <div class="mp_ctrl_box  pull-right">
                            <asp:LinkButton ID="LnkNew" runat="server" CssClass="btn btn-success" OnClick="LnkNew_Click">Create</asp:LinkButton>
                            <asp:LinkButton ID="btnBack" runat="server" CssClass="btn btn-primary" OnClick="btnBack_Click">List</asp:LinkButton>
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
                                <h2 class="mp_ctrl_gv_title">List

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
                                    <asp:BoundField DataField="DCNVHDR_ID" />
                                    <%--<0>--%><asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                        <ItemTemplate>
                                            <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="DCNV_Type" HeaderText="Type" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="DCNV_No" HeaderText="Ref No" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="vDCNV_DT" HeaderText="Entry Dt" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="MVen_Name" HeaderText="Vendor" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="PINV_No" HeaderText="Invoice No" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                     <asp:BoundField DataField="vPINV_DT" HeaderText="Invoice DT" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    
                                      <asp:BoundField DataField="DCNV_DTL_CNT" HeaderText="No Of Item" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                     
                                     
                                    
                                     
                                    <asp:BoundField DataField="DCNV_HDR_Total_Gross_Amt" HeaderText="Amount" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                      <asp:BoundField DataField="MDBSC_RowStatus" HeaderText="Status" ItemStyle-HorizontalAlign="left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="View / Edit" HeaderStyle-HorizontalAlign="Center">
                                        <ItemTemplate>

                                            <asp:ImageButton ImageUrl="~/Content/images/appimg/appicon/system/edit.png" ID="lnkEdit" OnClick="lnkEdit_Click"
                                                runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="Print" HeaderStyle-HorizontalAlign="Center">
                                        <ItemTemplate>

                                            <asp:ImageButton ImageUrl="~/Content/images/appimg/appicon/system/print.png" ID="lnkPrint" OnClick="lnkPrint_Click"
                                                runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </asp:View>
                    <asp:View ID="View1" runat="server">
                         <div class="row mp_ctrl_searchbox">
                            <div class="col-md-12 ">
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label>From Date</label>
                                        <asp:TextBox ID="Inv_Txt_FromDT" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                        <asp:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="Inv_Txt_FromDT"
                                            CssClass="cal_Theme1" Format="dd-MMM-yyyy"></asp:CalendarExtender>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label>To Date</label>
                                        <asp:TextBox ID="Inv_Txt_ToDT" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                        <asp:CalendarExtender ID="CalendarExtender6" runat="server" TargetControlID="Inv_Txt_ToDT"
                                            CssClass="cal_Theme1" Format="dd-MMM-yyyy"></asp:CalendarExtender>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12 ">
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label>Search On</label>
                                        <asp:DropDownList ID="Inv_ddSearchBy" CssClass="form-control mp_ctrl_js_dd" runat="server" DataTextFormatString="ColumnHeader"
                                            DataValueField="ColumnName">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label>Operator</label>
                                        <asp:DropDownList ID="Inv_ddOperator" CssClass="form-control mp_ctrl_js_dd" runat="server" DataTextField="operatortext" DataValueField="operator">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label>Value</label>
                                        <asp:TextBox ID="Inv_searchvalue" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <div class="spacer-20"></div>
                                        <asp:ImageButton ID="Inv_ImgButtonGo" runat="server" ImageUrl="~/Content/images/appimg/appicon/system/search.png" OnClick="Inv_ImgButtonGo_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <h2 class="mp_ctrl_gv_title">List

                                 <span class="pull-right">
                                     <asp:Label ID="Inv_Msg_RCNT" runat="server" CssClass="mp_e_msg_default" Text=""></asp:Label></span>
                                </h2>
                            </div>
                        </div>
                        <hr class="mp_ctrl_gv_hr" />
                        <div class="table-responsive">
                            <asp:GridView ID="gvList_Inv" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="gvList_Inv_PageIndexChanging"
                                Width="100%" PageSize="10" OnRowCreated="gvList_Inv_RowCreated" CssClass="mp_ctrl_gv"
                                PagerStyle-CssClass="mp_ctrl_gv_pagination" HeaderStyle-CssClass="mp_ctrl_gv_header">
                                <Columns>
                                    <asp:BoundField DataField="PINVHDR_ID" />
                                    <%--<0>--%><asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                        <ItemTemplate>
                                            <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="PINV_Taxtype" HeaderText="Tax Type" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="PINV_No" HeaderText="Invoice No" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="vPINV_DT" HeaderText="Invoice Dt" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="MVen_Name" HeaderText="Vendor" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    
                                     
                                    
                                    <asp:BoundField DataField="PINV_CreditDays" HeaderText="Credit Days" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="PINV_DueDT" HeaderText="Dute Dt" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" />
                                     
                                     
                                    <asp:BoundField DataField="PINV_HDR_Net_Amt" HeaderText="Net Total" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    
                                    <asp:BoundField DataField="PINV_HDR_Total_Tax_Amt" HeaderText="GST" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="PINV_HDR_Total_Gross_Amt" HeaderText="Invoice Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                      <asp:BoundField DataField="MDBSC_RowStatus" HeaderText="Status" ItemStyle-HorizontalAlign="left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="" HeaderStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LnkCN" runat="server" CssClass="btn btn-success" CommandArgument="CreditNote" OnClick="LnkDCN_Click">Credit Note</asp:LinkButton>
                                            <asp:LinkButton ID="LnkDN" runat="server" CssClass="btn btn-primary" CommandArgument="DebitNote" OnClick="LnkDCN_Click">Debit Note</asp:LinkButton>
                                           
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    
                                </Columns>
                            </asp:GridView>
                        </div>
                    </asp:View>
                    <asp:View ID="Entry" runat="server">
                        <div class="row">
                            <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8">
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Debit/Credit Note Details</h3>
                                    </div>

                                    <div class="panel-body"> 
                                        <div class="form-horizontal">
                                             <div class="row">
                                                
                                                 </div>
                                            <div class="row">
                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">

                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Ref No</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="DCNV_No" ReadOnly="true" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                        </div>

                                                    </div>
                                                </div>
                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Entry Date</label>
                                                        <div class="col-md-4">

                                                            <asp:TextBox ID="DCNV_DT" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                            <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="DCNV_DT"
                                                                CssClass="cal_Theme1" Format="dd-MMM-yyyy"></asp:CalendarExtender>

                                                        </div>
                                                    </div>
                                                </div>
                                                 <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                                       <div class="form-group">
                                                        <label class="col-sm-2 control-label">Vendor</label>
                                                        <div class="col-md-10">
                                                           <asp:TextBox ID="MVen_Name" ReadOnly="true" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                        </div>
                                                    </div>
                                                     </div> 
                                                   <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">

                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Invoice No</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="PINV_No" ReadOnly="true" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                        </div>

                                                    </div>
                                                </div>
                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Inv Date</label>
                                                        <div class="col-md-4">

                                                            <asp:TextBox ID="vPINV_DT" ReadOnly="true" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                       
                                                        </div>
                                                    </div>
                                                </div>

                                              
                                              

                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                     <div class="form-group">
                                                        <label class="col-sm-4 control-label">Type</label>

                                                        <div class="col-md-4">
                                                           <asp:TextBox ID="DCNV_Type" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />

                                                        </div>
                                                    </div>
                                                </div>
                                                  <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                     <div class="form-group">
                                                        <label class="col-sm-4 control-label">Inv Tax Type</label>

                                                        <div class="col-md-4">
                                                           <asp:TextBox ID="PINV_Taxtype" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />

                                                        </div>
                                                    </div>
                                                </div>
                                                   <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                       </div>
                                                 <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Cancelled</label>

                                                        <div class="col-md-4">
                                                            <asp:DropDownList ID="MDBSC_RowStatus" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" runat="server">
                                                                 <asp:ListItem Text="--Select--" Value=""></asp:ListItem>
                                                                <asp:ListItem Text="Cancelled" Value="Cancelled"></asp:ListItem>
                                                            </asp:DropDownList>

                                                        </div>

                                                    </div>
                                                    </div>
                                              
                                               
                                                
                                                 
                                                
                                                   <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Ship From</label>
                                                        <div class="col-md-8">
                                                            <asp:DropDownList ID="PINV_ShippedFrom_State_ID" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                              DataTextField="Text" runat="server">
                                                            </asp:DropDownList>

                                                        </div>
                                                    </div>
                                                </div>




                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Place Of Supply</label>
                                                        <div class="col-md-8">
                                                            <asp:DropDownList ID="DCNV_ShippTo_State_ID" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                            DataTextField="Text" runat="server">
                                                            </asp:DropDownList>
                                                        </div>

                                                    </div>
                                                </div>


                                             
                                                
                                                 <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                     <div class="form-group">
                                                        <label class="col-sm-4 control-label">Narration</label>

                                                        <div class="col-md-8">
                                                           <asp:TextBox ID="DCNV_Remark" CssClass="form-control " TextMode="MultiLine" Rows="3" ToolTip="Item Code" runat="server" />

                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                     <div class="form-group">
                                                        <label class="col-md-4 control-label">Reason</label>
                                                        <div class="col-md-8">

                                                                 <asp:DropDownList ID="DCNV_Reason" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                                DataTextField="Text" runat="server">
                                                            </asp:DropDownList>
                                                        </div>
                                                    </div>
                                                    </div>
                                                  <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                     <div class="form-group">
                                                        <label class="col-md-4 control-label">Created By</label>
                                                        <div class="col-md-8">

                                                            <asp:TextBox ID="MDBSC_RowCreatedByUserName" ReadOnly="true" CssClass="form-control "   ToolTip="Item Code" runat="server" />
                                                        </div>
                                                    </div>
                                                    </div>

                                                 <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                     <div class="form-group">
                                                        <label class="col-md-4 control-label">Created On</label>
                                                        <div class="col-md-4">

                                                            <asp:TextBox ID="MDBSC_RowCreatedOn_DT" ReadOnly="true" CssClass="form-control "   ToolTip="Item Code" runat="server" />
                                                        </div>
                                                    </div>
                                                    </div>





                                                 
                                            </div>
                                             
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4">
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Item Details</h3>
                                    </div>

                                    <div class="panel-body">

                                        <div class="form-horizontal">

                                            <div class="form-group">
                                                <label class="col-sm-4 control-label">Item</label>
                                                <div class="col-md-8">
                                                    <asp:DropDownList ID="Fk_MItem_ID" AutoPostBack="true" OnSelectedIndexChanged="Fk_MItem_ID_SelectedIndexChanged" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                        DataTextField="Text" runat="server">
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                           
                                              <div class="form-group">
                                                <label class="col-sm-4 control-label">HSN / SAC Code </label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="DCNV_HSNCode" CssClass="form-control " MaxLength="10" ToolTip="Item Code" runat="server"  />
                                                </div>
                                            </div>

                                            
                                             <div class="form-group">
                                                <label class="col-sm-4 control-label">Unit Rate</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="DCNV_BasicRate" CssClass="form-control " ToolTip="Item Code" runat="server"  />
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-sm-4 control-label">Quantity</label>

                                                <div class="col-md-8   ">
                                                    <asp:TextBox ID="DCNV_QTY" CssClass="form-control" ToolTip="Item Code" runat="server"  />


                                                </div>

                                            </div>
                                            <div class="form-group">

                                                <label class="col-sm-4 control-label">Discount Rate</label>
                                                <div class="col-md-8">

                                                    <asp:TextBox ID="DCNV_DiscountRate" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                </div>
                                            </div>
                                            
                                           
                                          
                                              <div class="form-group">
                                                <label class="col-sm-4 control-label">Item Narration</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="DCNV_ItemRemark_DTL" CssClass="form-control" ToolTip="Item Code" runat="server"  />
                                                </div>
                                            </div>

                                        
                                        </div>

                                    </div>
                                </div>


                                
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Server Message</h3>
                                    </div>
                                    <div class="panel-body">
                                        <div class="form-horizontal">
                                            <div class="form-group">
                                                 
                                                <div class="col-md-12">
                                                    <asp:Label ID="Msg_ErrorMsg" runat="server" CssClass="mp_ctrl_lbl_error" Text=""></asp:Label></span>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>


                        <div class="row">
                            <div class="col-md-12 mpu_txtCenter">
                                <div class="form-group">
                                    <asp:Button ID="btnsave" runat="server" CssClass="btn btn-success" Text="Save" OnClick="btnsave_Click" />
                                    <asp:Button ID="btnPrint" runat="server" CssClass="btn btn-warning" Text="Print" OnClick="btnPrint_Click" />

                                    <asp:TextBox ID="DCNVHDR_ID" runat="server" Visible="false" />
                                    <asp:TextBox ID="Fk_INVHDR_ID" runat="server" Visible="false" />
                                    <asp:TextBox ID="DCNVDTL_ID" runat="server" Visible="false" />
                                    


                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-12">
                                <h2 class="mp_ctrl_gv_title">Item List
                                 <span class="pull-right">
                                     <asp:Label ID="Msg_RCNTItem" runat="server" CssClass="mp_e_msg_default" Text=""></asp:Label></span>
                                </h2>
                            </div>
                        </div>
                        <hr class="mp_ctrl_gv_hr" />
                        <div class="table-responsive">
                            <asp:GridView ID="gvdtl" runat="server" AllowPaging="false" AutoGenerateColumns="False" OnRowDataBound="gvdtl_RowDataBound"
                                Width="100%" OnRowCreated="gvdtl_RowCreated" CssClass="mp_ctrl_gv_dtl" HeaderStyle-CssClass="mp_ctrl_gv_header_dtl" PagerStyle-CssClass="mp_ctrl_gv_pagination">
                                <Columns>
                                    <asp:BoundField DataField="DCNVDTL_ID" />
                                    <asp:BoundField DataField="Fk_DCNVHDR_ID" />
                                    <asp:BoundField DataField="Fk_MItem_ID" />
                                    <asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                        <ItemTemplate>
                                            <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                     
                                    <asp:BoundField DataField="Item_Name" HeaderText="Item" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="UOM" HeaderText="UOM" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="DCNV_HSNCode" HeaderText="HSN/SAC" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="DCNV_QTY" HeaderText="Qty" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="DCNV_BasicRate" HeaderText="Unit Rate" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="DCNV_BasicAmt" HeaderText="Amount" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" /> 
                                    <asp:BoundField DataField="DCNV_DiscountRate" HeaderText="Discount Rate" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="DCNV_DiscountAmt" HeaderText="Discount Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="DCNV_NetTaxableAmt" HeaderText="Taxable Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    
                                    <asp:BoundField DataField="DCNV_CGST_Tax_DisplayName" HeaderText="CGST" ItemStyle-HorizontalAlign="left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="DCNV_CGST_Amt" HeaderText="CGST Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                 
                                    <asp:BoundField DataField="DCNV_SGST_Tax_DisplayName" HeaderText="SGST" ItemStyle-HorizontalAlign="left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="DCNV_SGST_Amt" HeaderText="SGST Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                 

                                     <asp:BoundField DataField="DCNV_IGST_Tax_DisplayName" HeaderText="IGST" ItemStyle-HorizontalAlign="left" HeaderStyle-HorizontalAlign="Center" />
                                     <asp:BoundField DataField="DCNV_IGST_Amt" HeaderText="IGST Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                 

                                     <asp:BoundField DataField="DCNV_CESS_Tax_DisplayName" HeaderText="CESS" ItemStyle-HorizontalAlign="left" HeaderStyle-HorizontalAlign="Center" />
                                     <asp:BoundField DataField="DCNV_CESS_Amt" HeaderText="CESS Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" /> 
                                       <asp:BoundField DataField="DCNV_TotalTax" HeaderText="Total Tax" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="DCNV_GrossRateWithTax" HeaderText="Item Total" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                     
                                    <asp:BoundField DataField="DCNV_ItemRemark_DTL" HeaderText="Remark" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />

                                    

                                

                                      <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="Edit" HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                        <ItemTemplate>
                                            <asp:ImageButton ImageUrl="~/Content/images/appimg/appicon/system/edit.png" CssClass="mp_ctrl_gv_icon" ID="lnkItemEdit" OnClick="lnkItemEdit_Click"
                                                OnClientClick="if(ConfirmYesno('Are you sure to edit this record ?')==0) {return false;} "
                                                runat="server" />

                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="Delete" HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                        <ItemTemplate>
                                            <asp:ImageButton ImageUrl="~/Content/images/appimg/appicon/system/delete.png" CssClass="mp_ctrl_gv_icon" ID="lnkItemDelete" OnClick="lnkItemDelete_Click"
                                                OnClientClick="if(ConfirmYesno('Are you sure to delete this record ?')==0) {return false;} "
                                                runat="server" />

                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                            <div class="spacer-20"></div>
                        </div>

                        <div class="row">
                            <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8">
                                
                            </div>

                            <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4">
                                
                                 <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Total</h3>
                                    </div>

                                    <div class="panel-body">

                                        <div class="form-horizontal">

                                            <div class="form-group">
                                                <label class="col-sm-7 control-label">Basic Amt</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="DCNV_HDR_BasicAmt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-sm-7 control-label">Discount</label>
                                                <div class="col-md-5">


                                                    <asp:TextBox ID="DCNV_HDR_DiscountAmt" CssClass="form-control " ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>
                                              <div class="form-group">
                                                <label class="col-sm-7 control-label">Taxable Amt</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="DCNV_HDR_Net_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>
                                             
                                             <div class="form-group" style="display:none;">
                                                <label class="col-sm-7 control-label">Freight Charges</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="DCNV_HDR_Freight_Charges" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>
                                             

                                             

                                          

                                           
                                            <div class="form-group" id="Div_CGST_HDR" runat="server">
                                                <label class="col-sm-7 control-label">Add:CGST</label>

                                                <div class="col-md-5   ">
                                                    <asp:TextBox ID="DCNV_HDR_CGST_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />


                                                </div>

                                            </div>
                                            <div class="form-group" id="Div_SGST_HDR" runat="server">

                                                <label class="col-sm-7 control-label">ADD:SGST</label>
                                                <div class="col-md-5">

                                                    <asp:TextBox ID="DCNV_HDR_SGST_Amt" ReadOnly="true" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                </div>
                                            </div>
                                            <div class="form-group"  id="Div_IGST_HDR" runat="server">

                                                <label class="col-sm-7 control-label">ADD:IGST</label>
                                                <div class="col-md-5">

                                                    <asp:TextBox ID="DCNV_HDR_IGST_Amt" ReadOnly="true" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                </div>
                                            </div>
                                              <div class="form-group">

                                                <label class="col-sm-7 control-label">ADD:CESS</label>
                                                <div class="col-md-5">

                                                    <asp:TextBox ID="DCNV_HDR_CESS_Amt" ReadOnly="true" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-sm-7 control-label">Total GST</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="DCNV_HDR_Total_Tax_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>
                                           
                                            
                                            
                                             
                                              <div class="form-group">
                                                <label class="col-sm-7 control-label">Total Amount</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="DCNV_HDR_Gross_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>

                                             <div class="form-group">
                                                <label class="col-sm-7 control-label">Round Off</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="DCNV_HDR_Round_Off_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>

                                             <div class="form-group">
                                                <label class="col-sm-7 control-label">Grand Amount</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="DCNV_HDR_Total_Gross_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>

                                
                                
                            </div>
                        </div>

                    </asp:View>
                </asp:MultiView>
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerscript" runat="server">
</asp:Content>
