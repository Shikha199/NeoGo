<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPEA.Master" AutoEventWireup="true"
    CodeBehind="TaxInvoice.aspx.cs" Inherits="JEMEA.Sales.TaxInvoice" %>
 
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
                            <li class="active">Tax Invoice</li>
                        </ul>
                    </div>

                </div>
                <div class="row mp_ctrl_ph">
                    <div class="col-md-6">
                        <h2 class="mp_ctrl_frmheading">Tax Invoice</h2>
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
                        <hr class="mp_ctrl_gv_hr" id="hr3" runat="server" />
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

                                   <%-- <asp:BoundField DataField="SINV_ewb_EwayBillNo" HeaderText="Eway Bill No" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_ewb_TransDocNo" HeaderText="Document No" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="vSINV_ewb_TransDocDate" HeaderText="Document Dt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_ewb_Distance" HeaderText="Distance" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_ewb_TransporterId" HeaderText="Transporter Id" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_ewb_TransactionType" HeaderText="Transaction Type" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_ewb_TransactionSubType" HeaderText="Transaction SubType" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_ewb_VehicleType" HeaderText="Vehicle Type" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_ewb_Amount" HeaderText="E way Bill Amount" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />--%>



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
                    <asp:View ID="Entry" runat="server">
                        <div class="row">
                            <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8">
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Invoice Details</h3>
                                    </div>

                                    <div class="panel-body">
                                        <div class="form-horizontal">
                                            <div class="row">
                                                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                                    <div class="form-group">
                                                        <label class="col-sm-2 control-label">Customer</label>
                                                        <div class="col-md-10">
                                                            <asp:DropDownList ID="Fk_CustomerID" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                                AutoPostBack="true" OnSelectedIndexChanged="Fk_CustomerID_SelectedIndexChanged" DataTextField="Text" runat="server">
                                                            </asp:DropDownList>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">

                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Invoice No</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="SINV_No" ReadOnly="true" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                        </div>

                                                    </div>
                                                </div>
                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Inv Date</label>
                                                        <div class="col-md-4">

                                                            <asp:TextBox ID="SINV_DT" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                            <asp:CalendarExtender ID="CE_SINV_DT" runat="server" TargetControlID="SINV_DT"
                                                                CssClass="cal_Theme1" Format="dd-MMM-yyyy"></asp:CalendarExtender>

                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">

                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">P.O. No.</label>
                                                        <div class="col-md-4">
                                                            <asp:TextBox ID="SINV_PONo" CssClass="form-control" ToolTip="Item Code" runat="server" />


                                                        </div>
                                                    </div>

                                                </div>
                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">P.O. Date</label>

                                                        <div class="col-md-4">
                                                            <asp:TextBox ID="SINV_PO_DT" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                            <asp:CalendarExtender ID="CE_SINV_PO_DT" runat="server" TargetControlID="SINV_PO_DT"
                                                                CssClass="cal_Theme1" Format="dd-MMM-yyyy"></asp:CalendarExtender>

                                                        </div>
                                                    </div>
                                                </div>


                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">

                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Credit Days</label>
                                                        <div class="col-md-4">
                                                            <asp:TextBox ID="SINV_CreditDays" MaxLength="2" Text="30" CssClass="form-control" ToolTip="Item Code" runat="server" />


                                                        </div>
                                                    </div>

                                                </div>
                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Due Date</label>

                                                        <div class="col-md-4">
                                                            <asp:TextBox ID="SINV_DueDT" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />

                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Tax Type</label>

                                                        <div class="col-md-4">
                                                            <asp:TextBox ID="SINV_Taxtype" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />

                                                        </div>
                                                    </div>
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
                                                        <label class="col-md-4 control-label">Place Of Supply</label>
                                                        <div class="col-md-8">
                                                            <asp:DropDownList ID="SINV_ShippTo_State_ID" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                           AutoPostBack="true" OnSelectedIndexChanged="SalesState_SelectedIndexChanged"      DataTextField="Text" runat="server">
                                                            </asp:DropDownList>
                                                        </div>

                                                    </div>
                                                </div>

                                                   <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Ship From</label>
                                                        <div class="col-md-8">
                                                            <asp:DropDownList ID="SINV_ShippedFrom_State_ID" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                           AutoPostBack="true" OnSelectedIndexChanged="SalesState_SelectedIndexChanged"      DataTextField="Text" runat="server">
                                                            </asp:DropDownList>

                                                        </div>
                                                    </div>
                                                </div>



                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Narration</label>

                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="SINV_Remark" CssClass="form-control " TextMode="MultiLine" Rows="3" ToolTip="Item Code" runat="server" />

                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Created By</label>
                                                        <div class="col-md-8">

                                                            <asp:TextBox ID="MDBSC_RowCreatedByUserName" ReadOnly="true" CssClass="form-control " ToolTip="Item Code" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Created On</label>
                                                        <div class="col-md-4">

                                                            <asp:TextBox ID="MDBSC_RowCreatedOn_DT" ReadOnly="true" CssClass="form-control " ToolTip="Item Code" runat="server" />
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
                                                    <asp:TextBox ID="SINV_HSNCode" ReadOnly="true" CssClass="form-control " MaxLength="8" ToolTip="Item Code" runat="server" />
                                                </div>
                                            </div>


                                            <div class="form-group">
                                                <label class="col-sm-4 control-label">Unit Rate</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="SINV_BasicRate" CssClass="form-control " ToolTip="Item Code" runat="server" />
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-sm-4 control-label">Quantity</label>

                                                <div class="col-md-8   ">
                                                    <asp:TextBox ID="SINV_QTY" CssClass="form-control" ToolTip="Item Code" runat="server" />


                                                </div>

                                            </div>
                                            <div class="form-group">

                                                <label class="col-sm-4 control-label">Disc Rate (%)</label>
                                                <div class="col-md-8">

                                                    <asp:TextBox ID="SINV_DiscountRate" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                </div>
                                            </div>




                                            <div class="form-group">
                                                <label class="col-sm-4 control-label">Item Narration</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="SINV_ItemRemark_DTL" CssClass="form-control" ToolTip="Item Code" runat="server" />
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
                                      <asp:Button ID="BtnGnrateBill" runat="server" CssClass="btn btn-success" Text="Generate Bill" OnClick="btnGenerateEwayBill_Click" />

                                    <asp:TextBox ID="SINVHDR_ID" runat="server" Visible="false" />
                                    <asp:TextBox ID="SINVDTL_ID" runat="server" Visible="false" />
                                     <asp:TextBox ID="FK_MEWVehicle_ID" runat="server" Visible="false" /> 



                                </div>
                            </div>
                        </div>
                        <div id="ItemListdiv" runat="server">
                        <div class="row" id="Row" runat="server">
                            <div class="col-md-12" id="item_Id" runat="server">
                                <h2 class="mp_ctrl_gv_title">Item List
                                 <span class="pull-right">
                                     <asp:Label ID="Msg_RCNTItem" runat="server" CssClass="mp_e_msg_default" Text=""></asp:Label></span>
                                </h2>
                            </div>
                        </div>
                        <hr class="mp_ctrl_gv_hr" id="hr1" runat="server" />
                        <div class="table-responsive">
                            <asp:GridView ID="gvdtl" runat="server" AllowPaging="false" AutoGenerateColumns="False" OnRowDataBound="gvdtl_RowDataBound"
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

                                    <asp:BoundField DataField="Item_Type" HeaderText="Group" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="vItemName" HeaderText="Item" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="UOM" HeaderText="UOM" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_HSNCode" HeaderText="HSN/SAC" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_QTY" HeaderText="Qty" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_BasicRate" HeaderText="Unit Rate" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_BasicAmt" HeaderText="Amount" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />


                                    <asp:BoundField DataField="SINV_DiscountRate" HeaderText="Discount Rate" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_DiscountAmt" HeaderText="Discount Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="SINV_NetTaxableAmt" HeaderText="Taxable Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="SINV_CGST_Tax_DisplayName" HeaderText="CGST" ItemStyle-HorizontalAlign="left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_CGST_Amt" HeaderText="CGST Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="SINV_SGST_Tax_DisplayName" HeaderText="SGST" ItemStyle-HorizontalAlign="left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_SGST_Amt" HeaderText="SGST Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />


                                    <asp:BoundField DataField="SINV_IGST_Tax_DisplayName" HeaderText="IGST" ItemStyle-HorizontalAlign="left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_IGST_Amt" HeaderText="IGST Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />


                                    <asp:BoundField DataField="SINV_CESS_Tax_DisplayName" HeaderText="CESS" ItemStyle-HorizontalAlign="left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_CESS_Amt" HeaderText="CESS Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_TotalTax" HeaderText="Total Tax" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="SINV_GrossRateWithTax" HeaderText="Item Total" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="SINV_ItemRemark_DTL" HeaderText="Remark" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />





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

                        <div class="row" id="ViewINV" runat="server">
                            <div class="col-md-8" id="ViewINV11" runat="server" >
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Terms & Conditions</h3>
                                    </div>
                                    <div class="panel-body">
                                        <div class="form-horizontal">
                                            <div class="row">
                                                <div class="col-md-12 CompactInputBx">
                                                    <div class="form-group">
                                                        <label class="col-md-2 control-label">Payment Terms</label>
                                                        <div class="col-md-10">

                                                            <asp:TextBox ID="SINV_PaymentTerms" MaxLength="150" TextMode="MultiLine" Rows="2" CssClass="form-control" ToolTip="ResPinCode" runat="server" />
                                                        </div>

                                                    </div>

                                                </div>


                                            </div>

                                            <div class="row">

                                                <div class="col-md-6 CompactInputBx">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Mode Of Dispatch</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="SINV_ModeOfDispatch" MaxLength="75" ToolTip="File No" CssClass="form-control" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="col-md-6 CompactInputBx">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Delivery Period</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="SINV_DelvieryPeriod" ToolTip="File No" CssClass="form-control" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="col-md-6 CompactInputBx">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Transpoter Name</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="SINV_TranspoterName" MaxLength="75" ToolTip="File No" CssClass="form-control" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-md-6 CompactInputBx">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Place Of Delivery</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="SINV_PlaceOfDelivery" MaxLength="75" ToolTip="File No" CssClass="form-control" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="col-md-6 CompactInputBx">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Vehicle Number</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="SINV_VehicleNumber" MaxLength="75" ToolTip="File No" CssClass="form-control" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>

                                                 <div class="col-md-6 CompactInputBx">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">L.R Number</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="SINV_LRNumber" MaxLength="75" ToolTip="File No" CssClass="form-control" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                        </div>

                                    </div>
                                </div>


                                <div class="panel panel-default"  >
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Bill To Details</h3>
                                    </div>
                                    <div class="panel-body">
                                        <div class="form-horizontal">
                                            <div class="row">
                                                <div class="col-md-6">
                                                    <div class="form-group">

                                                        <div class="row m0">
                                                            <label class="col-md-4 control-label">Address</label>
                                                            <div class="col-md-8">
                                                                <asp:TextBox ID="SINV_BillTo_Add1" ReadOnly="true" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                                <asp:TextBox ID="SINV_BillTo_Add2" ReadOnly="true" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                                <asp:TextBox ID="SINV_BillTo_Add3" ReadOnly="true" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                            </div>

                                                        </div>

                                                        <div class="row m0">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <label class="col-md-4 control-label">Pincode</label>
                                                                    <div class="col-md-8">
                                                                        <asp:TextBox ID="SINV_BillTo_Pincode" ReadOnly="true" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <label class="col-md-4 control-label">City</label>
                                                                    <div class="col-md-8">
                                                                        <asp:TextBox ID="SINV_BillTo_City" ReadOnly="true" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                    </div>
                                                                </div>
                                                            </div>
                                                       </div>
                                                     </div>
                                                   </div>

                                                <div class="col-md-6">
                                                    <div class="row m0">

                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">State</label>
                                                                <div class="col-md-8">
                                                                    <asp:TextBox ID="MCust_Reg_StateDisplayName" ReadOnly="true" CssClass="form-control" ToolTip="MobileNo" runat="server" />
                                                                </div>

                                                            </div>
                                                        </div>

                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">Country</label>
                                                                <div class="col-md-8">
                                                                    <asp:TextBox ID="SINV_BillTo_Country" ReadOnly="true" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                </div>
                                                            </div>
                                                        </div>
                                                <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">GSTIN No</label>
                                                                <div class="col-md-8">
                                                                    <asp:TextBox ID="SINV_BillTo_GSTNo" ReadOnly="true" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">PAN No</label>
                                                                <div class="col-md-8">
                                                                    <asp:TextBox ID="SINV_BillTo_PANNO" ReadOnly="true" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                </div>
                                                            </div>
                                                        </div>
                                                     </div>
                                                    </div>
                                                 </div>
                                              </div>
                                            </div>
                                            </div>
                                    <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Shipping / Consignee Details</h3>
                                    </div>
                                    <div class="panel-body">
                                        <div class="form-horizontal">
                                            <div class="row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <div class="row m0">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <label class="col-md-4 control-label">Name</label>
                                                                    <div class="col-md-8">
                                                                        <asp:TextBox ID="SINV_ShippTo_CompanyName" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <label class="col-md-4 control-label">Contact Name</label>
                                                                    <div class="col-md-8">
                                                                        <asp:TextBox ID="SINV_ShippTo_ContactPersone" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <label class="col-md-4 control-label">Mobile No</label>
                                                                    <div class="col-md-8">
                                                                        <asp:TextBox ID="SINV_ShippTo_CP_MobileNo" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row m0">
                                                            <label class="col-md-4 control-label">Address</label>
                                                            <div class="col-md-8">
                                                                <asp:TextBox ID="SINV_ShippTo_Add1" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                                <asp:TextBox ID="SINV_ShippTo_Add2" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                                <asp:TextBox ID="SINV_ShippTo_Add3" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                            </div>

                                                        </div>

                                                        <div class="row m0">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <label class="col-md-4 control-label">Pincode</label>
                                                                    <div class="col-md-8">
                                                                        <asp:TextBox ID="SINV_ShippTo_Pincode" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                    </div>
                                                                </div>
                                                            </div>



                                                        </div>





                                                    </div>



                                                </div>

                                                <div class="col-md-6">
                                                    <div class="row m0">
                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">City</label>
                                                                <div class="col-md-8">
                                                                    <asp:TextBox ID="SINV_ShippTo_City" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                </div>
                                                            </div>
                                                        </div>

                                                        
                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">Country</label>
                                                                <div class="col-md-8">
                                                                    <asp:TextBox ID="SINV_ShippTo_Country" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                </div>
                                                            </div>
                                                        </div>



                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">GSTIN No</label>
                                                                <div class="col-md-8">
                                                                    <asp:TextBox ID="SINV_ShippTo_GSTNo" MaxLength="15" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">PAN No</label>
                                                                <div class="col-md-8">
                                                                    <asp:TextBox ID="SINV_ShippTo_PANNO" MaxLength="10" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                </div>
                                                            </div>
                                                        </div>



                                                    </div>


                                                </div>

                                            </div>






                                        </div>

                                    </div>
                                </div>
                                

                                





                            </div>

                            <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4">

                                <div class="panel panel-default" id="PnlTotal" runat="server">
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Total</h3>
                                    </div>

                                    <div class="panel-body">

                                        <div class="form-horizontal">

                                            <div class="form-group">
                                                <label class="col-sm-7 control-label">Basic Amt</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="SINV_HDR_BasicAmt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-sm-7 control-label">Discount Amt</label>
                                                <div class="col-md-5">


                                                    <asp:TextBox ID="SINV_HDR_DiscountAmt" CssClass="form-control " ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-sm-7 control-label">Taxable Amt</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="SINV_HDR_Net_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>

                                            <div class="form-group" style="display: none;">
                                                <label class="col-sm-7 control-label">Freight Charges</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="SINV_HDR_Freight_Charges" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>







                                            <div class="form-group" id="Div_CGST_HDR" runat="server">
                                                <label class="col-sm-7 control-label">Add:CGST</label>

                                                <div class="col-md-5   ">
                                                    <asp:TextBox ID="SINV_HDR_CGST_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />


                                                </div>

                                            </div>
                                            <div class="form-group" id="Div_SGST_HDR" runat="server">

                                                <label class="col-sm-7 control-label">ADD:SGST</label>
                                                <div class="col-md-5">

                                                    <asp:TextBox ID="SINV_HDR_SGST_Amt" ReadOnly="true" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                </div>
                                            </div>
                                            <div class="form-group" id="Div_IGST_HDR" runat="server">

                                                <label class="col-sm-7 control-label">ADD:IGST</label>
                                                <div class="col-md-5">

                                                    <asp:TextBox ID="SINV_HDR_IGST_Amt" ReadOnly="true" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                </div>
                                            </div>

                                             <div class="form-group" id="Div_EwayBill_HDR" runat="server">

                                                <label class="col-sm-7 control-label">ADD:Eway Bill</label>
                                                <div class="col-md-5">

                                                    <asp:TextBox ID="SINV_ewb_Amount" ReadOnly="true" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                </div>
                                            </div>
                                            <div class="form-group">

                                                <label class="col-sm-7 control-label">ADD:CESS</label>
                                                <div class="col-md-5">

                                                    <asp:TextBox ID="SINV_HDR_CESS_Amt" ReadOnly="true" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-sm-7 control-label">Total GST</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="SINV_HDR_Total_Tax_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>




                                            <div class="form-group">
                                                <label class="col-sm-7 control-label">Grand Total</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="SINV_HDR_Gross_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>

                                            <div class="form-group">
                                                <label class="col-sm-7 control-label">Round Off</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="SINV_HDR_Round_Off_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>

                                            <div class="form-group">
                                                <label class="col-sm-7 control-label">Invoice Amt</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="SINV_HDR_Total_Gross_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>



                            </div>
                        </div>

                            </div>

                        <div id="EwabillDiv" runat="server" >
                          <div class="row" id="divEway" runat="server">
                            <div class="col-md-12">
                                <h2 class="mp_ctrl_gv_title">E-way Bill List
                                 <span class="pull-right">
                                     <asp:Label ID="Msg_RCNTItem1" runat="server" CssClass="mp_e_msg_default" Text=""></asp:Label></span>
                                </h2>
                            </div>
                        </div>
                        <hr class="mp_ctrl_gv_hr"  id="hr2" runat="server"/>

                        <div class="table-responsive">
                            <asp:GridView ID="gvEwayBill" runat="server" AllowPaging="false" AutoGenerateColumns="False" OnRowDataBound="gvEwayBill_RowDataBound"
                                Width="100%" OnRowCreated="gvEwayBill_RowCreated" CssClass="mp_ctrl_gv_dtl" HeaderStyle-CssClass="mp_ctrl_gv_header_dtl" PagerStyle-CssClass="mp_ctrl_gv_pagination">
                                <Columns>
                                    <asp:BoundField DataField="SINVDTL_ID" />
                                    <asp:BoundField DataField="Fk_SINVHDR_ID" />
                                    <asp:BoundField DataField="Fk_MItem_ID" />
                                    <asp:BoundField DataField="FK_MEWVehicle_ID" />
                                    <asp:BoundField DataField="SINVHDR_ID" />


                                    <asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                        <ItemTemplate>
                                            <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:BoundField DataField="SINV_ewb_EwayBillNo" HeaderText="Eway Bill No" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_ewb_TransDocNo" HeaderText="Document No" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="vSINV_ewb_TransDocDate" HeaderText="Document Dt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_ewb_Distance" HeaderText="Distance" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_ewb_TransporterId" HeaderText="Transporter Id" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_ewb_TransactionType" HeaderText="Transaction Type" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_ewb_TransactionSubType" HeaderText="Transaction SubType" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_ewb_VehicleType" HeaderText="Vehicle Type" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_ewb_Amount" HeaderText="E way Bill Amount" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />

                                    <%--<asp:BoundField DataField="Item_Type" HeaderText="Group" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="vItemName" HeaderText="Item" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="UOM" HeaderText="UOM" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_HSNCode" HeaderText="HSN/SAC" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_QTY" HeaderText="Qty" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_BasicRate" HeaderText="Unit Rate" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_BasicAmt" HeaderText="Amount" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />


                                    <asp:BoundField DataField="SINV_DiscountRate" HeaderText="Discount Rate" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_DiscountAmt" HeaderText="Discount Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="SINV_NetTaxableAmt" HeaderText="Taxable Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="SINV_CGST_Tax_DisplayName" HeaderText="CGST" ItemStyle-HorizontalAlign="left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_CGST_Amt" HeaderText="CGST Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="SINV_SGST_Tax_DisplayName" HeaderText="SGST" ItemStyle-HorizontalAlign="left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_SGST_Amt" HeaderText="SGST Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />


                                    <asp:BoundField DataField="SINV_IGST_Tax_DisplayName" HeaderText="IGST" ItemStyle-HorizontalAlign="left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_IGST_Amt" HeaderText="IGST Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />


                                    <asp:BoundField DataField="SINV_CESS_Tax_DisplayName" HeaderText="CESS" ItemStyle-HorizontalAlign="left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_CESS_Amt" HeaderText="CESS Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SINV_TotalTax" HeaderText="Total Tax" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="SINV_GrossRateWithTax" HeaderText="Item Total" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="SINV_ItemRemark_DTL" HeaderText="Remark" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
--%>




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

                        <div >
                            <divclass="col-xs-12 col-sm-4 col-md-4 col-lg-4 >
                                <div class="panel panel-default" id="panelEwawill" runat="server">
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Transaction Details</h3>
                                    </div>
                                    <div class="panel-body">
                                        <div class="form-horizontal">
                                           
                                            <div class="row">

                                                <div class="col-md-12 CompactInputBx">
                                                    <div class="form-group">
                                                        <label class="col-sm-2 control-label">Mode Of Dispatch</label>
                                                        <div class="col-md-10">
                                                 <asp:RadioButton ID="rbl_Supplier" Text="Supplier" runat="server" GroupName="Gender" Checked="true" />
                                                 <asp:RadioButton ID="rbl_reciepent" Text="Reciepent" runat="server" GroupName="Gender" />
       
                                                        </div>
                                                    </div>
                                                  
                                                </div>
                                                    <div class="col-md-6 CompactInputBx">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Sub Type</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="SINV_ewb_TransactionSubType" MaxLength="75" ToolTip="File No" CssClass="form-control" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-md-6 CompactInputBx">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Document No</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="SINV_ewb_TransDocNo" ToolTip="Item Code" ReadOnly="true" CssClass="form-control" runat="server" />
                                                            
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="col-md-6 CompactInputBx">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Transaction Type </label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="SINV_ewb_TransactionType" MaxLength="75" ToolTip="File No" CssClass="form-control" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>

                                                 <div class="col-md-6 CompactInputBx">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Document Date</label>
                                                        <div class="col-md-8">
                                                         
                                                             <asp:TextBox ID="SINV_ewb_TransDocDate" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                           <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="SINV_ewb_TransDocDate"
                                                                  CssClass="cal_Theme1" Format="dd-MMM-yyyy"></asp:CalendarExtender>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                        </div>

                                    </div>
                                </div>
                                    <div class="panel panel-default" id="panelEwawill2" runat="server">
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Transporter Details</h3>
                                    </div>
                                    <div class="panel-body">
                                        <div class="form-horizontal">
                                            <div class="row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <div class="row m0">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <label class="col-md-4 control-label">Transporter Id</label>
                                                                    <div class="col-md-8">
                                                                        <asp:TextBox ID="SINV_ewb_TransporterId" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <label class="col-md-4 control-label">Vehicle Type</label>
                                                                    <div class="col-md-8">
                                                                        <asp:TextBox ID="SINV_ewb_VehicleType" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row m0">
                                                           
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="row m0">
                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">Distance (in km) </label>
                                                                <div class="col-md-8">
                                                                    <asp:TextBox ID="SINV_ewb_Distance" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">Bill Amount</label>
                                                                <div class="col-md-8">
                                                                    <asp:TextBox ID="SINV_ewbill_Amount" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                    <%-- <asp:Button ID="BtnUpdate" runat="server" CssClass="btn btn-success" Text="Update" OnClick="btnUpdate_Click" />--%>
                                      <div class="row">
                                <div class="col-md-12 mpu_txtCenter">
                                    <div class="form-group">
                                        <asp:Button ID="BtnUpdate" runat="server" CssClass="btn btn-success" Text="Update" OnClick="btnUpdate_Click" />
                                          <asp:Button ID="BtnExit" runat="server" CssClass="btn btn-warning" Text="Exit" OnClick="btnExit_Click" />
                                       
                                        <div class="spacer-20"></div>
                                    </div>
                                </div>
                            </div>
                                </div>
                                </div>
                            </divclass="col-xs-12>
                        </div>
                    </asp:View>
                </asp:MultiView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerscript" runat="server">
</asp:Content>
