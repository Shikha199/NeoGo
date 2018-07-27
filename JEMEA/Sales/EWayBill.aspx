<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPEA.Master" AutoEventWireup="true"
    CodeBehind="EWayBill.aspx.cs" Inherits="JEMEA.EWayBill.EWayBill" %>

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
                            <li class="active">EwayBill Entry</li>
                        </ul>
                    </div>

                </div>
                <div class="row mp_ctrl_ph">
                    <div class="col-md-6">
                        <h2 class="mp_ctrl_frmheading">EwayBill Entry</h2>
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
                                    <asp:BoundField DataField="SEWB_HDR_ID" />
                                    <%--<0>--%><asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                        <ItemTemplate>
                                            <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                         
                                    
                                    <asp:BoundField DataField="SINV_No" HeaderText="Invoice No" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <%--<asp:BoundField DataField="vSEWB_DT" HeaderText="Invoice Dt" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />--%>
                                    
                                    <asp:BoundField DataField="SEWB_Trn_SubType" HeaderText="SubType" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SEWB_Trn_Doc_Type" HeaderText="Document Type " ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SEWB_Trn_Doc_No" HeaderText="DocNo" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="vSEWB_Trn_Doc_Date" HeaderText="DocumentDt" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SEWB_TranspoterName" HeaderText="TransporterName" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SEWB_TranspoterNo" HeaderText="TransporterId" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SEWB_Distance" HeaderText="Distance" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SEWB_Trn_SubDesc" HeaderText="SubDiscription" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />

                                    
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
                            <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8">
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Transporter Details</h3>
                                    </div>

                                    <div class="panel-body">
                                        <div class="form-horizontal">
                                            <div class="row">
                                                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                                    <div class="form-group">
                                                        <label class="col-sm-2 control-label">Invoice No</label>
                                                        <div class="col-md-10">
                                                            <asp:DropDownList ID="Fk_VendorID" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                                AutoPostBack="true" OnSelectedIndexChanged="Fk_VendorID_SelectedIndexChanged" DataTextField="Text" runat="server">
                                                            </asp:DropDownList>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">

                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Sub Type</label>
                                                        <div class="col-md-8">
                                                            <asp:DropDownList ID="ddlSEWB_Trn_Type" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" runat="server">
                                                                <asp:ListItem Text="--Select--" Value=""></asp:ListItem>
                                                                <asp:ListItem Text="Supply" Value="Supply"></asp:ListItem>
                                                                <asp:ListItem Text="Export" Value="Export"></asp:ListItem>
                                                                <asp:ListItem Text="JobWork" Value="JobWork"></asp:ListItem>
                                                                <asp:ListItem Text="SKD/CKD" Value="SKD/CKD"></asp:ListItem>
                                                                <asp:ListItem Text="Recipient Not Known" Value="Recipient Not Known"></asp:ListItem>
                                                                <asp:ListItem Text="For Own Us" Value="For Own Us"></asp:ListItem>
                                                                <asp:ListItem Text="Exehibition of Fairs" Value="Exehibition of Fairs"></asp:ListItem>
                                                            </asp:DropDownList>
                                                        </div>

                                                    </div>
                                                </div>
                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Doc No</label>
                                                        <div class="col-md-4">

                                                            <asp:TextBox ID="SEWB_Doc_No" CssClass="form-control" ToolTip="Item Code" runat="server"  MaxLength="10"/>
                                                            
                                                          

                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">

                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Document Type</label>
                                                        <div class="col-md-4">
                                                            <asp:DropDownList ID="ddlSEWB_Trn_Doc_Type" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" runat="server">
                                                                <asp:ListItem Text="--Select--" Value=""></asp:ListItem>
                                                                <asp:ListItem Text="Invoice" Value="Invoice"></asp:ListItem>
                                                                <asp:ListItem Text="Bill" Value="Bill"></asp:ListItem>
                                                                <asp:ListItem Text="Bill Of Entry" Value="Bill Of Entry"></asp:ListItem>
                                                                <asp:ListItem Text="Challan" Value="Challan"></asp:ListItem>
                                                                <asp:ListItem Text="Credit Note" Value="Credit Note"></asp:ListItem>
                                                                <asp:ListItem Text="Others" Value="Others"></asp:ListItem>
                                                            </asp:DropDownList>

                                                        </div>
                                                    </div>

                                                </div>
                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">Document Date</label>

                                                        <div class="col-md-4">
                                                            <asp:TextBox ID="SEWB_Doc_Date" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                            <asp:CalendarExtender ID="CE_SEWB_PO_DT" runat="server" TargetControlID="SEWB_Doc_Date"
                                                                CssClass="cal_Theme1" Format="dd-MMM-yyyy"></asp:CalendarExtender>

                                                        </div>
                                                    </div>
                                                </div>


                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">

                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">TransPorterName</label>
                                                        <div class="col-md-4">
                                                            <asp:TextBox ID="SEWB_TranspoterName"  Text="30" CssClass="form-control" ToolTip="Item Code" runat="server" />


                                                        </div>
                                                    </div>

                                                </div>
                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">TransporterId</label>

                                                        <div class="col-md-4">
                                                            <asp:TextBox ID="SEWB_TransporterID" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="False" />

                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                   <div class="form-group">
                                                        <label class="col-sm-4 control-label">Distance (in km) </label>

                                                        <div class="col-md-4">
                                                            <asp:TextBox ID="SEWB_Distance" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="False"   />
                                                            <asp:RangeValidator  ControlToValidate="SEWB_Distance" Text="Distance should be More than 100KM" MinimumValue="100000"   MaximumValue="1000000000"   Type="Integer" Runat="server" />
                                                        </div>
                                                    </div>
                                                </div>
                                               <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                                    <div class="form-group">
                                                        <label class="col-sm-4 control-label">SubDiscription</label>

                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="SEWB_Trn_SubDesc" CssClass="form-control " TextMode="MultiLine" Rows="3" ToolTip="Item Code" runat="server" MaxLength="1200" />

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
                                        <h3 class="panel-title">Vehicle Details</h3>
                                    </div>

                                    <div class="panel-body">

                                        <div class="form-horizontal">

                                           

                                            <div class="form-group">
                                                <label class="col-sm-4 control-label">Mode</label>
                                                <div class="col-md-8">
       
                                                     <asp:DropDownList ID="ddlSEWB_Trans_Mode" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" runat="server" 
                                                         DataValueField="Value" OnSelectedIndexChanged="ddlSEWB_Trans_Mode_SelectedIndexChanged" DataTextField="Text" AutoPostBack="true">
                                                                <asp:ListItem Text="--Select Transporter--" Value=""></asp:ListItem>
                                                                <asp:ListItem Text="Road" Value="Road"></asp:ListItem>
                                                                <asp:ListItem Text="Rail" Value="Rail"></asp:ListItem>
                                                                <asp:ListItem Text="Air" Value="Air"></asp:ListItem>
                                                                <asp:ListItem Text="Ship" Value="Ship"></asp:ListItem>
                                                               
                                                            </asp:DropDownList>
                                                </div>
                                            </div>
                                             <div class="form-group">
                                                <label class="col-sm-4 control-label">Vehicle Type</label>
                                                <div class="col-md-8">
                                                     <asp:DropDownList ID="DDlVehicle" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" runat="server">
                                                                <asp:ListItem Text="--Select Vehicle--" Value=""></asp:ListItem>
                                                                <asp:ListItem Text="Over Dimensional Cargo" Value="Over Dimensional Cargo"></asp:ListItem>
                                                                </asp:DropDownList>
                                                </div>
                                            </div>
                                          
                                      
                                            <div class="form-group">
                                                <label class="col-sm-4 control-label">Vehicle No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="SEWB_Vehicle_No" CssClass="form-control " ToolTip="Item Code" runat="server" MaxLength="6" />
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-sm-4 control-label">Transporter Doc. No</label>

                                                <div class="col-md-8   ">
                                                   
                                                    <asp:TextBox ID="SEWB_Trans_Doc_No" CssClass="form-control" ToolTip="Item Code" runat="server" MaxLength="20" />
                                                            

                                                </div>

                                            </div>
                                            <div class="form-group">

                                                <label class="col-sm-4 control-label">Transporter Doc. Date</label>
                                                <div class="col-md-8">

                                                    <asp:TextBox ID="SEWB_Trans_Doc_Date" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                    <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="SEWB_Trans_Doc_Date"
                                                                CssClass="cal_Theme1" Format="dd-MMM-yyyy"></asp:CalendarExtender>
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

                                    <asp:TextBox ID="SEWB_HDR_ID" runat="server" Visible="false" />
                                    <asp:TextBox ID="SEWB_CTL_ID" runat="server" Visible="false" />



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
                                    <asp:BoundField DataField="SEWB_CTL_ID" />
                                    <asp:BoundField DataField="Fk_SEWB_HDR_ID" />
                                    <%--<asp:BoundField DataField="Fk_MItem_ID" />--%>



                                    <asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                        <ItemTemplate>
                                            <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                     
                                    <asp:BoundField DataField="SEWB_Trans_Mode" HeaderText="Mode" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SEWB_Vehicle_Type" HeaderText="Vehicle Type" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                     <asp:BoundField DataField="SEWB_Vehicle_No" HeaderText="Vehicle No" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SEWB_Trans_Doc_No" HeaderText="Transporter Document No" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="SEWB_Trans_Doc_Date" HeaderText="TransPoretr Document Date" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                                   
                                   

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
                                 <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Supplier Details</h3>
                                    </div>
                                    <div class="panel-body">
                                        <div class="form-horizontal">
                                            <div class="row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <div class="row m0">
                                                           
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <label class="col-md-4 control-label">Contact Name</label>
                                                                    <div class="col-md-8">
                                                                        <asp:TextBox ID="SEWB_ShippedFrom_ContactPersone" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                    </div>
                                                                </div>
                                                            </div>
                                                            
                                                        </div>
                                                        <div class="row m0">
                                                            <label class="col-md-4 control-label">Address</label>
                                                            <div class="col-md-8">
                                                                <asp:TextBox ID="SEWB_ShippedFrom_Add1" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                                <asp:TextBox ID="SEWB_ShippedFrom_Add2" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                                <asp:TextBox ID="SEWB_ShippedFrom_Add3" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                            </div>

                                                        </div>

                                                        <div class="row m0">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <label class="col-md-4 control-label">Pincode</label>
                                                                    <div class="col-md-8">
                                                                        <asp:TextBox ID="SEWB_ShippedFrom_Pincode" CssClass="form-control" ToolTip="MobileNo" runat="server" />

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
                                                                    <asp:TextBox ID="MVen_Reg_StateDisplayName" ReadOnly="False" CssClass="form-control" ToolTip="MobileNo" runat="server" />
                                                                </div>

                                                      


                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">GSTIN No</label>
                                                                <div class="col-md-8">
                                                                    <asp:TextBox ID="SEWB_ShippedFrom_GSTNo" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                </div>
                                                            </div>
                                                        </div>
                                                                <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">Place</label>
                                                                <div class="col-md-8">
                                                                    <asp:TextBox ID="SEWB_ShippFrom_Place" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">POS</label>
                                                                <div class="col-md-8">
                                                                   <%-- <asp:TextBox ID="SEWB_ShippedFrom_PANNO" CssClass="form-control" ToolTip="MobileNo" runat="server" />--%>
                                                                    <asp:DropDownList ID="SEWB_ShippFrom_State_ID" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                           AutoPostBack="true" OnSelectedIndexChanged="PurchaseState_SelectedIndexChanged"      DataTextField="Text" runat="server">
                                                            </asp:DropDownList>

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
</div>

                                   <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Recipient Details</h3>
                                    </div>
                                    <div class="panel-body">
                                        <div class="form-horizontal">
                                            <div class="row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <div class="row m0">
                                                           
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <label class="col-md-4 control-label">Contact Name</label>
                                                                    <div class="col-md-8">
                                                                        <asp:TextBox ID="SEWB_ShippTo_ContactPersone" CssClass="form-control" ToolTip="MobileNo" runat="server" readonly="true"/>

                                                                    </div>
                                                                </div>
                                                            </div>
                                                           
                                                        </div>
                                                        <div class="row m0">
                                                            <label class="col-md-4 control-label">Address</label>
                                                            <div class="col-md-8">
                                                                <asp:TextBox ID="SEWB_ShippTo_Add1" CssClass="form-control" ToolTip="Residential Address" runat="server"  readonly="true"/>

                                                                <asp:TextBox ID="SEWB_ShippTo_Add2" CssClass="form-control" ToolTip="Residential Address" runat="server" readonly="true" />

                                                                <asp:TextBox ID="SEWB_ShippTo_Add3" CssClass="form-control" ToolTip="Residential Address" runat="server" readonly="true" />

                                                            </div>

                                                        </div>

                                                        <div class="row m0">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <label class="col-md-4 control-label">Pincode</label>
                                                                    <div class="col-md-8">
                                                                        <asp:TextBox ID="SEWB_ShippTo_Pincode" CssClass="form-control" ToolTip="MobileNo" runat="server" readonly="true" />

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
                                                                    <asp:TextBox ID="SEWB_BillTo_StateDisplayName"  CssClass="form-control" ToolTip="MobileNo" runat="server" readonly="true" />
                                                                </div>

                                                            </div>


                                                        </div>

                                                        
                                                     
                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">GSTIN No</label>
                                                                <div class="col-md-8">
                                                                    <asp:TextBox ID="SEWB_ShippTo_GSTNo" CssClass="form-control" ToolTip="MobileNo" runat="server" readonly="true" />

                                                                </div>
                                                            </div>
                                                        </div>

                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">Place</label>
                                                                <div class="col-md-8">
                                                                    <asp:TextBox ID="SEWB_ShippTo_Place" CssClass="form-control" ToolTip="MobileNo" runat="server"  readonly="true"/>

                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">POS</label>
                                                                <div class="col-md-8">
                                                                    <%--<asp:TextBox ID="SEWB_ShippTo_PANNO" CssClass="form-control" ToolTip="MobileNo" runat="server" />--%>
                                                                    <asp:DropDownList ID="SEWB_ShippTo_State_ID" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value" 
                                                           AutoPostBack="true" OnSelectedIndexChanged="PurchaseState_SelectedIndexChanged"      DataTextField="Text" runat="server" >
                                                            </asp:DropDownList>

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

                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h3 class="panel-title">Total</h3>
                                    </div>

                                    <div class="panel-body">

                                        <div class="form-horizontal">

                                            <%--<div class="form-group">
                                                <label class="col-sm-7 control-label">Basic Amt</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="SEWB_HDR_BasicAmt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>--%>
                                            <div class="form-group">
                                                <label class="col-sm-7 control-label">Discount Amt</label>
                                                <div class="col-md-5">


                                                    <asp:TextBox ID="SEWB_HDR_DiscountAmt" CssClass="form-control " ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-sm-7 control-label">Taxable Amt</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="SEWB_HDR_Net_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>

                                            <div class="form-group" style="display: none;">
                                                <label class="col-sm-7 control-label">Freight Charges</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="SEWB_HDR_Freight_Charges" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>

                                            <div class="form-group" id="Div_CGST_HDR" runat="server">
                                                <label class="col-sm-7 control-label">Add:CGST</label>

                                                <div class="col-md-5   ">
                                                    <asp:TextBox ID="SEWB_HDR_CGST_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />


                                                </div>

                                            </div>
                                            <div class="form-group" id="Div_SGST_HDR" runat="server">

                                                <label class="col-sm-7 control-label">ADD:SGST</label>
                                                <div class="col-md-5">

                                                    <asp:TextBox ID="SEWB_HDR_SGST_Amt" ReadOnly="true" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                </div>
                                            </div>
                                            <div class="form-group" id="Div_IGST_HDR" runat="server">

                                                <label class="col-sm-7 control-label">ADD:IGST</label>
                                                <div class="col-md-5">

                                                    <asp:TextBox ID="SEWB_HDR_IGST_Amt" ReadOnly="true" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                </div>
                                            </div>
                                            <div class="form-group">

                                                <label class="col-sm-7 control-label">ADD:CESS</label>
                                                <div class="col-md-5">

                                                    <asp:TextBox ID="SEWB_HDR_CESS_Amt" ReadOnly="true" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-sm-7 control-label">Total GST</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="SEWB_HDR_Total_Tax_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>




                                            <div class="form-group">
                                                <label class="col-sm-7 control-label">Grand Total</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="SEWB_HDR_Gross_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>

                                            <div class="form-group">
                                                <label class="col-sm-7 control-label">Round Off</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="SEWB_HDR_Round_Off_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>

                                            <div class="form-group">
                                                <label class="col-sm-7 control-label">Invoice Amt</label>
                                                <div class="col-md-5">
                                                    <asp:TextBox ID="SEWB_HDR_Total_Gross_Amt" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>



                            </div>


                        
                            </div>
                        
                        <div class="row">
                        <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8">
                             

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
