<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPEA.Master" AutoEventWireup="true"
     CodeBehind="Vendor.aspx.cs" Inherits="JEMEA.Master.Vendor" %>

 
<asp:Content ID="Content4" ContentPlaceHolderID="HeadContent_Js" runat="server"></asp:Content>
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
                            <li class="active">Vendor Master</li>
                        </ul>
                    </div>

                </div>
                <div class="row mp_ctrl_ph">
                    <div class="col-md-6">
                        <h2 class="mp_ctrl_frmheading">Vendor Master</h2>
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
                                <div>
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
                                Width="100%" PageSize="50" OnRowCreated="gvList_RowCreated" CssClass="mp_ctrl_gv" HeaderStyle-CssClass="mp_ctrl_gv_header" PagerStyle-CssClass="mp_ctrl_gv_pagination">
                                <Columns>
                                    <asp:BoundField DataField="M_Ven_ID" />
                                    <%--<0>--%><asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                        <ItemTemplate>
                                            <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="MVen_RegType" HeaderText="Type" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                     <asp:BoundField DataField="MVen_Code" HeaderText="Vendor Code" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="MVen_Name" HeaderText="Vendor Name" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                     <asp:BoundField DataField="MVen_CreditDays" HeaderText="Credit Days" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="MVen_Primary_Contact_Person" HeaderText="Contact Person" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="MVen_Primary_CP_MobileNo" HeaderText="Mobile" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />

                                    <asp:BoundField DataField="MVen_Primary_CP_EmailID" HeaderText="Email ID" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    
                                    
                                    
                                    <asp:BoundField DataField="MVen_Reg_City" HeaderText="City" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                     
                                    <asp:BoundField DataField="MVen_Reg_StateDisplayName" HeaderText="State" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                     
                                     <asp:BoundField DataField="MVen_BL_GSTNO" HeaderText="GST No" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />

                                    
                                     
                                    
                                    <asp:BoundField DataField="MDBSC_RowCreatedByUserName" HeaderText="Created By" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="vMDBSC_RowCreatedOn_DT" HeaderText="Created On" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="MDBSC_RowStatus" HeaderText="Status" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />





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











                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h3 class="panel-title">System Details</h3>
                            </div>
                            <div class="panel-body">
                                <div class="form-horizontal">
                                    <div class="row">
                                        <div class="col-md-6">
                                            <div class="form-group">

                                                <label class="col-sm-4 control-label">Vendor Code</label>

                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MVen_Code" MaxLength="50" ToolTip="File No" CssClass="form-control" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>
                                        </div>
                                         
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-sm-4 control-label">Created On</label>
                                                <div class="col-md-3">
                                                    <asp:TextBox ID="RecCreatedOn" MaxLength="50" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>
                                        </div>
                                           <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Vendor Name</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MVen_Name" MaxLength="150" CssClass="form-control" ToolTip="ResPinCode" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-sm-4 control-label">Created By</label>

                                                <div class="col-md-8">
                                                    <asp:TextBox ID="RecCreatedUser" MaxLength="50" CssClass="form-control" ToolTip="Item Code" runat="server" ReadOnly="true" />
                                                </div>
                                            </div>
                                        </div>
                                            <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Trade / Billing Name</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MVen_TradeName" MaxLength="150" CssClass="form-control" ToolTip="ResPinCode" runat="server" />
                                                </div>
                                            </div>
                                        </div>

                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Status</label>
                                                <div class="col-md-3">
                                                    <asp:DropDownList ID="MDBSC_RowStatus" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" runat="server">
                                                        <asp:ListItem Text="Active" Value="Active"></asp:ListItem>
                                                        <asp:ListItem Text="In Active" Value="In Active"></asp:ListItem>

                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </div>

                                      <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Vendor Type</label>
                                                <div class="col-md-8">
                                                     <asp:DropDownList ID="MVen_RegType" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                                DataTextField="Text" runat="server">
                                                            </asp:DropDownList>
                                                   
                                                </div>
                                            </div>
                                        </div>
                                        
                                         <div class="col-md-6">
                                        <div class="form-group">
                                            <label class="col-md-4 control-label">Credit Days</label>
                                            <div class="col-md-4">
                                                <asp:TextBox ID="MVen_CreditDays" MaxLength="3" CssClass="form-control" ToolTip="Pan No" runat="server" />

                                            </div>
                                        </div>
                                    </div>
                                    </div>
                                </div>
                            </div>
                        </div>


                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h3 class="panel-title">Contact Details</h3>
                            </div>
                            <div class="panel-body">
                                <div class="form-horizontal">
                                    <div class="row">
                                        <div class="col-md-12">
                                            <h2 class="mp_ctrl_gv_title">Contact Person

                                 <span class="pull-right">
                                     <asp:Label ID="Label1" runat="server" CssClass="mp_e_msg_default" Text=""></asp:Label></span>
                                            </h2>
                                        </div>
                                    </div>
                                <hr class="mp_ctrl_gv_hr" />
                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label class="col-md-4 control-label">Contact Person Name</label>
                                            <div class="col-md-8">
                                                <asp:TextBox ID="MVen_Primary_Contact_Person" MaxLength="50" CssClass="form-control" ToolTip="RegPinCode" runat="server" />

                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label class="col-md-4 control-label">Designation</label>
                                            <div class="col-md-8">
                                                <asp:TextBox ID="MVen_Primary_Contact_Designation" MaxLength="50" CssClass="form-control" ToolTip="Pan No" runat="server" />

                                            </div>
                                        </div>
                                    </div>
                                </div>



                                <div class="row">

                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Phone No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MVen_Primary_CP_PhoneNo"  MaxLength="25" CssClass="form-control" ToolTip="Adhar No" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                          <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Mobile No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MVen_Primary_CP_MobileNo"  MaxLength="10" CssClass="form-control" ToolTip="Adhar No" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                        



                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Email ID</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MVen_Primary_CP_EmailID"  MaxLength="50" CssClass="form-control" ToolTip="Adhar No" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                           
                                     
                                        
                                    </div>

                                     <div class="row">
                                        <div class="col-md-12">
                                            <h2 class="mp_ctrl_gv_title">Office Details

                                 <span class="pull-right">
                                     <asp:Label ID="Label2" runat="server" CssClass="mp_e_msg_default" Text=""></asp:Label></span>
                                            </h2>
                                        </div>
                                    </div>
                                <hr class="mp_ctrl_gv_hr" />

                                    <div class="row">

                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Phone No 1</label>
                                                <div class="col-md-8">
                                                        <asp:TextBox ID="MVen_Contact_OfficeNo1"  MaxLength="25" CssClass="form-control" ToolTip="MobileNo" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                          <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Phone No 2</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MVen_Contact_OfficeNo2"  MaxLength="25" CssClass="form-control" ToolTip="MobileNo" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                        



                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Fax No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MVen_Contact_FaxNo"  MaxLength="50" CssClass="form-control" ToolTip="MobileNo" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Email ID</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MVen_Contact_Email_Admin"  MaxLength="50" CssClass="form-control" ToolTip="MobileNo" runat="server" />
                                                </div>
                                            </div>
                                        </div>

                                          <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Web Site</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MVen_Contact_Website"   MaxLength="50" CssClass="form-control" ToolTip="MobileNo" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                           
                                     
                                       
                                    </div>
                                </div>

                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h3 class="panel-title">Billing Details</h3>
                            </div>
                            <div class="panel-body">
                                <div class="form-horizontal">
                                    <div class="row">
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <div class="row m0">
                                                    <label class="col-md-4 control-label">Address</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="MVen_Reg_Add1"  MaxLength="150" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                        <asp:TextBox ID="MVen_Reg_Add2"  MaxLength="150" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                        <asp:TextBox ID="MVen_Reg_Add3"  MaxLength="150" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                    </div>

                                                </div>
                                                <div class="row m0">
                                                      
                                                     <div class="col-md-12">
                                                         <div class="form-group">
                                                             <label class="col-md-4 control-label">Pincode</label>
                                                             <div class="col-md-4">
                                                                 <asp:TextBox ID="MVen_Reg_Pincode" MaxLength="6" CssClass="form-control" ToolTip="Last Name" runat="server" />
                                                             </div>
                                                          
                                                         </div>
                                                     </div>

                                               <div class="col-md-12">
                                                         <div class="form-group">
                                                             <label class="col-md-4 control-label">City</label>
                                                             <div class="col-md-8">
                                                                 <asp:TextBox ID="MVen_Reg_City" CssClass="form-control" ToolTip="Last Name" runat="server" />
                                                             </div>
                                                          
                                                         </div>
                                                     </div>
                                                       <div class="col-md-12">
                                                         <div class="form-group">
                                                             <label class="col-md-4 control-label">State</label>
                                                             <div class="col-md-8">
                                                                   <asp:DropDownList ID="MVen_Reg_State_ID" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                        DataTextField="Text" runat="server">
                                                        </asp:DropDownList>
                                                             </div>
                                                          
                                                         </div>
                                                     </div>

                                                     <div class="col-md-12">
                                                         <div class="form-group">
                                                             <label class="col-md-4 control-label">Country</label>
                                                             <div class="col-md-8">
                                                                 <asp:TextBox ID="MVen_Reg_Country" Text="India" ReadOnly="true" CssClass="form-control" ToolTip="Last Name" runat="server" />
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
                                                        <label class="col-md-4 control-label">PAN No</label>
                                                        <div class="col-md-8">
                                                            
                                                            <asp:TextBox ID="MVen_BL_PANNO"   MaxLength="10" CssClass="form-control" ToolTip="MobileNo" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>



                                                <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">GST No</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="MVen_BL_GSTNO"   MaxLength="15" CssClass="form-control" ToolTip="MobileNo" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>
                                                
                                                 <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Copy To Consigner Details</label>
                                                        <div class="col-md-8">
                                                            <asp:Button ID="btnAddressCopy" runat="server" CssClass="btn btn-primary" Text="Copy" OnClick="btnAddressCopy_Click" />

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
                                <h3 class="panel-title">Consigner Details</h3>
                            </div>
                            <div class="panel-body">
                                <div class="form-horizontal">
                                    <div class="row">
                                         

                                           <div class="col-md-6">
                                            <div class="form-group">
                                                <div class="row m0">
                                                    <label class="col-md-4 control-label">Address</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="MVen_DispatchFrom_Add1"  MaxLength="150" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                        <asp:TextBox ID="MVen_DispatchFrom_Add2"  MaxLength="150" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                        <asp:TextBox ID="MVen_DispatchFrom_Add3"  MaxLength="150" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                    </div>

                                                </div>
                                                <div class="row m0">
                                                      
                                                     <div class="col-md-12">
                                                         <div class="form-group">
                                                             <label class="col-md-4 control-label">Pincode</label>
                                                             <div class="col-md-4">
                                                                 <asp:TextBox ID="MVen_DispatchFrom_Pincode" MaxLength="6" CssClass="form-control" ToolTip="Last Name" runat="server" />
                                                             </div>
                                                          
                                                         </div>
                                                     </div>

                                               <div class="col-md-12">
                                                         <div class="form-group">
                                                             <label class="col-md-4 control-label">City</label>
                                                             <div class="col-md-8">
                                                                 <asp:TextBox ID="MVen_DispatchFrom_City" CssClass="form-control" ToolTip="Last Name" runat="server" />
                                                             </div>
                                                          
                                                         </div>
                                                     </div>
                                                       <div class="col-md-12">
                                                         <div class="form-group">
                                                             <label class="col-md-4 control-label">State</label>
                                                             <div class="col-md-8">
                                                                   <asp:DropDownList ID="MVen_DispatchFrom_State_ID" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                        DataTextField="Text" runat="server">
                                                        </asp:DropDownList>
                                                             </div>
                                                          
                                                         </div>
                                                     </div>

                                                     <div class="col-md-12">
                                                         <div class="form-group">
                                                             <label class="col-md-4 control-label">Country</label>
                                                             <div class="col-md-8">
                                                                 <asp:TextBox ID="MVen_DispatchFrom_Country" Text="India" ReadOnly="true" CssClass="form-control" ToolTip="Last Name" runat="server" />
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
                                                        <label class="col-md-4 control-label">Consignee Name</label>
                                                        <div class="col-md-8">
                                                        <asp:TextBox ID="MVen_DispatchFrom_CompanyName"   MaxLength="150" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Contact Person Name </label>
                                                        <div class="col-md-8">
                                                        <asp:TextBox ID="MVen_DispatchFrom_ContactPerson"   MaxLength="150" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                        </div>
                                                    </div>
                                                </div>
                                                 <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Mobile No</label>
                                                        <div class="col-md-8">
                                                            
                                                            <asp:TextBox ID="MVen_DispatchFrom_CP_MobileNo"   MaxLength="10" CssClass="form-control" ToolTip="MobileNo" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>
                                                   <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">PAN No</label>
                                                        <div class="col-md-8">
                                                            
                                                            <asp:TextBox ID="MVen_DispatchFrom_PANNO"   MaxLength="10" CssClass="form-control" ToolTip="MobileNo" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>



                                                <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">GST No</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="MVen_DispatchFrom_GSTNO"   MaxLength="15" CssClass="form-control" ToolTip="MobileNo" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">ARN No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MVen_DispatchFrom_ARNO"   MaxLength="15" CssClass="form-control" ToolTip="MobileNo" runat="server" />

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
                                <h3 class="panel-title">Bank Details</h3>
                            </div>
                            <div class="panel-body">
                                <div class="form-horizontal">



                                    <div class="row">
                                         <div class="col-md-6">

                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Account Holder Name</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MVen_AccountHolderName"  MaxLength="150" CssClass="form-control" ToolTip="Excise No" runat="server" />


                                                </div>
                                            </div>
                                        </div>
                                        
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Bank Name</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MVen_BankName"  MaxLength="150" CssClass="form-control" ToolTip="Service Tax" runat="server" />


                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Account No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MVen_AccountNo"  MaxLength="20" CssClass="form-control" ToolTip="Pan No" runat="server" />

                                                </div>
                                            </div>
                                        </div>
                                          <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Bank Branch</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MVen_BankBranch"  MaxLength="50" CssClass="form-control" ToolTip="Service Tax" runat="server" />


                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">IFSC Code</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MVen_IFSCNo"  MaxLength="20" CssClass="form-control" ToolTip="Adhar No" runat="server" />
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
                                    <asp:TextBox ID="M_Ven_ID" runat="server" Visible="false" />
                                    <div class="spacer-20"></div>
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
