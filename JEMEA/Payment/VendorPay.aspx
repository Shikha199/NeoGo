<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPEA.Master" AutoEventWireup="true"
    CodeBehind="VendorPay.aspx.cs" Inherits="JEMEA.Master.VendorPay" %>



<asp:Content ID="Content2" ContentPlaceHolderID="MAPPMAINCONTENT" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <Triggers>
        </Triggers>
        <ContentTemplate>
            <div class="container-fluid">
                <div class="mp_ctrl_breadcrumb row clearfix">
                    <div class="breadcrumb-line">
                        <ul class="breadcrumb">
                            <li>Master</li>
                            <li class="active">Vendor Payment</li>
                        </ul>
                    </div>
                </div>

                <div class="row mp_ctrl_ph">
                    <div class="col-md-6">
                        <h2 class="mp_ctrl_frmheading">Vendor Payment</h2>
                    </div>
                    <div class="col-md-6">
                        <div class="mp_ctrl_box  pull-right">
                            <asp:LinkButton ID="LnkNew" runat="server" CssClass="btn btn-success" OnClick="LnkNew_Click">Create New</asp:LinkButton>
                            <asp:LinkButton ID="btnBack" runat="server" CssClass="btn btn-primary" OnClick="btnBack_Click">View List</asp:LinkButton>
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
                                Width="100%" PageSize="250" OnRowCreated="gvList_RowCreated" CssClass="mp_ctrl_gv" HeaderStyle-CssClass="mp_ctrl_gv_header" PagerStyle-CssClass="mp_ctrl_gv_pagination">
                                <Columns>
                                    <asp:BoundField DataField="AVPHDR_ID" />
                                    <%--<0>--%><asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                        <ItemTemplate>
                                            <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="VP_No" HeaderText="Ref No" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="vVP_DT" HeaderText="Entry DT" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" /> 
                                    <asp:BoundField DataField="MVen_Code" HeaderText="Vendor Code" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="MVen_Name" HeaderText="Vendor" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" /> 
                                  
                                      <asp:BoundField DataField="VP_DTL_CNT" HeaderText="No Of Inv Adjusted" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                     <asp:BoundField DataField="VP_Received_Amt" HeaderText="Received Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="VP_Adjusted_Amt" HeaderText="Adjusted Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" /> 
                                    <asp:BoundField DataField="VP_OnAccount_Amt" HeaderText="On Account" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" /> 
                                    <asp:BoundField DataField="VP_Payment_Mode" HeaderText="Payment Mode" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" /> 
                                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="View / Edit" HeaderStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:ImageButton ImageUrl="~/Content/images/appimg/appicon/system/edit.png" ID="lnkEdit" OnClick="lnkEdit_Click"
                                                runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>

                    </asp:View>
                    <asp:View ID="Entry" runat="server">
                        <div class="row">
                            <div class="col-md-5">
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Vendor Payment Details</h3>
                                    </div>
                                    <div class="panel-body">
                                        <div class="form-horizontal">
                                            <div class="row">

                                                <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Entry Dt</label>
                                                        <div class="col-md-4 ">
                                                            <asp:TextBox ID="VP_DT" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                            <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="VP_DT"
                                                                CssClass="cal_Theme1" Format="dd-MMM-yyyy"></asp:CalendarExtender>
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Ref No</label>
                                                        <div class="col-md-4 ">
                                                            <asp:TextBox ID="VP_No" ReadOnly="true" CssClass="form-control" ToolTip="Item Code" runat="server" />

                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Vendor</label>
                                                        <div class="col-md-8  ">
                                                            <asp:DropDownList ID="Fk_VendorID"   CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                              DataTextField="Text" runat="server">
                                                            </asp:DropDownList>
                                                        </div>
                                                    </div>
                                                </div>


                                                <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Recieved Amt</label>
                                                        <div class="col-md-4 ">
                                                            <asp:TextBox ID="VP_Received_Amt" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Adjusted Amt</label>
                                                        <div class="col-md-4">
                                                            <asp:TextBox ID="VP_Adjusted_Amt" ReadOnly="true" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">On Account Amt</label>
                                                        <div class="col-md-4 ">
                                                            <asp:TextBox ID="VP_OnAccount_Amt" ReadOnly="true" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Payment Mode</label>
                                                        <div class="col-md-4 ">
                                                            <asp:DropDownList ID="VP_Payment_Mode" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                                DataTextField="Text" runat="server">
                                                            </asp:DropDownList>
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Ref No</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="VP_Ref_No" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Cheque DT</label>
                                                        <div class="col-md-4 ">
                                                            <asp:TextBox ID="VP_Ref_DT" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
                                                            <asp:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="VP_Ref_DT"
                                                                CssClass="cal_Theme1" Format="dd-MMM-yyyy"></asp:CalendarExtender>
                                                        </div>
                                                    </div>
                                                </div>






                                                <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Narration</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="VP_Narration" TextMode="MultiLine" Rows="2" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
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
                                                <asp:TextBox ID="AVPHDR_ID" runat="server" Visible="false" />
                                                <div class="spacer-20"></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-7">
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Vendor Invoice</h3>
                                    </div>
                                    <div class="panel-body">
                                      <div class="row">
                            <div class="col-md-12">
                                <h2 class="mp_ctrl_gv_title">List

                                 <span class="pull-right">
                                     <asp:Label ID="Msg_RCNT_DTL" runat="server" CssClass="mp_e_msg_default" Text=""></asp:Label></span>
                                </h2>
                            </div>
                        </div>
                        <hr class="mp_ctrl_gv_hr" />
                        <div class="table-responsive">
                            <asp:GridView ID="gv_VP_Inv" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="gv_VP_Inv_PageIndexChanging"
                                Width="100%" PageSize="25" OnRowCreated="gv_VP_Inv_RowCreated" CssClass="mp_ctrl_gv" OnRowDataBound="gv_VP_Inv_OnRowDataBound"
                                PagerStyle-CssClass="mp_ctrl_gv_pagination" HeaderStyle-CssClass="mp_ctrl_gv_header">
                                <Columns>
                                    <asp:BoundField DataField="AVPDTL_ID" />
                                    <asp:BoundField DataField="Fk_AVPHDRID" />
                                    <asp:BoundField DataField="Fk_InvoiceID" />
                                    <%--<0>--%><asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                        <ItemTemplate>
                                            <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="PINV_No" HeaderText="Inv No" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="vPINV_DT" HeaderText="Inv Dt" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="PINV_HDR_Total_Gross_Amt" HeaderText="Inv Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="PINV_HDR_Paid_AsOn_Amt" HeaderText="Paid As On" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="PINV_HDR_Outstanding_AsOn_Amt" HeaderText="Outstanding Amt" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:TemplateField HeaderText="Adjusted Amt" ItemStyle-HorizontalAlign="left" ItemStyle-Width="100">
                                        <ItemTemplate>
                                            <asp:TextBox ID="Inv_Adjusted_Amt" CssClass="form-control" Text='<%# Bind("Inv_Adjusted_Amt") %>' ToolTip="Item Code" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>






                                </Columns>
                            </asp:GridView>
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
