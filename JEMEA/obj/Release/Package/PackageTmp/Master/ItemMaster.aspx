﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPEA.Master" AutoEventWireup="true"
    CodeBehind="ItemMaster.aspx.cs" Inherits="JEMEA.Master.ItemMaster" %>



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
                            <li class="active">Item Master</li>
                        </ul>
                    </div>
                </div>

                <div class="row mp_ctrl_ph">
                    <div class="col-md-6">
                        <h2 class="mp_ctrl_frmheading">Item  Master</h2>
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
                                Width="100%" PageSize="250" OnRowCreated="gvList_RowCreated" CssClass="mp_ctrl_gv" HeaderStyle-CssClass="mp_ctrl_gv_header" PagerStyle-CssClass="mp_ctrl_gv_pagination">
                                <Columns>
                                    <asp:BoundField DataField="MItem_ID" />
                                    <%--<0>--%><asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                        <ItemTemplate>
                                            <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="Item_Type" HeaderText="Item Type" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="Item_Code" HeaderText="Item Code" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="Item_Name" HeaderText="Item Name" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" /> 
                                     
                                     
                                     <asp:BoundField DataField="UOM" HeaderText="UOM" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="Item_Selling_Rate" HeaderText="Selling Rate" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" /> 
                                    <asp:BoundField DataField="Tax_Rate" HeaderText="Tax Rate" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                   
                                    





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
                                <h3 class="panel-title">Item Details</h3>
                            </div>
                            <div class="panel-body">
                                <div class="form-horizontal">
                                    <div class="row">
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-sm-4 control-label">Item Type</label>
                                                <div class="col-md-8  ">
                                                    <asp:DropDownList ID="Item_Type" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" runat="server">
                                                        <asp:ListItem Text="Goods" Value="Goods"></asp:ListItem>
                                                        <asp:ListItem Text="Services" Value="Services"></asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </div>

                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-sm-4 control-label">Created On</label>
                                                <div class="col-md-4 ">
                                                    <asp:TextBox ID="MDBSC_RowCreatedOn_DT" CssClass="form-control" ToolTip="Item Code" ReadOnly="true" Columns="15" MaxLength="50" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Item Code</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="Item_Code" ReadOnly="true" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-sm-4 control-label">Created By</label>
                                                <div class="col-md-8 ">
                                                    <asp:TextBox ID="MDBSC_RowCreatedByUserName" CssClass="form-control" ToolTip="Item Code" Columns="15" MaxLength="50" ReadOnly="true" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                         </div>
                                          <div class="row">
                                          <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="col-md-2 control-label">Item Name</label>
                                                <div class="col-md-10">
                                                    <asp:TextBox ID="Item_Name"  TextMode="MultiLine" Rows="2"  CssClass="form-control" ToolTip="Adhar No" runat="server" />
                                                </div>
                                            </div>
                                        </div>    
                                            
                                              <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="col-sm-2 control-label">Description</label>
                                                <div class="col-md-10">
                                                    <asp:TextBox ID="Item_Desc" TextMode="MultiLine" Rows="3" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                               </div>
                                        <div class="row">
                                            
                                          
                                           
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-sm-4 control-label">Unit Of Measurment</label>
                                                <div class="col-md-4">
                                                    <asp:DropDownList ID="UOM_ID" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                       DataTextField="Text" runat="server">
                                                    </asp:DropDownList>
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

                                        
                                     
                                       
                                      
                                            </div>
                                    
                                       
                                         
                                        
                                         
                                         


                                    </div>

                                </div>
                            </div> 
                           
                            </div>
                          <div class="panel panel-default">
                            <div class="panel-heading">
                                <h3 class="panel-title">Billing Setting</h3>
                            </div>
                            <div class="panel-body">
                                <div class="form-horizontal">
                                    <div class="row">
                                          <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">HSN / SAC Code</label>
                                                <div class="col-md-4">
                                                    <asp:TextBox ID="HSNCode"   CssClass="form-control" MaxLength="8" ToolTip="RegPinCode" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                         <div class="col-md-6">
                                            <div class="form-group" id="Div_CGST_DTL" runat="server">
                                                <label class="col-sm-4 control-label">Integrated Tax Rate</label>
                                                <div class="col-md-4">
                                                    <asp:DropDownList ID="Item_Tax_GST_ID" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                        DataTextField="Text" runat="server">
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </div>
                                          <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Selling Rate</label>
                                                <div class="col-md-4">
                                                    <asp:TextBox ID="Item_Selling_Rate" MaxLength="12" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
                                                </div>
                                            </div>
                                        </div>

                                          <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Integrated Tax Effective From</label>
                                                <div class="col-md-4">
                                                      <asp:TextBox ID="Item_Tax_GST_Effective_From" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                        <asp:CalendarExtender ID="CalendarExtender5" runat="server" TargetControlID="Item_Tax_GST_Effective_From"
                                            CssClass="cal_Theme1" Format="dd-MMM-yyyy"></asp:CalendarExtender>
                                                </div>
                                            </div>
                                        </div>

                                           <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Purchase Rate</label>
                                                <div class="col-md-4">
                                                    <asp:TextBox ID="Item_Purchase_Rate" MaxLength="12" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                         <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">CGST Rate</label>
                                                <div class="col-md-4">
                                                    <asp:TextBox ID="Item_CGST_Rate" ReadOnly="true" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="form-group" id="Div_SGST_DTL" runat="server">
                                                <label class="col-sm-4 control-label">CESS Tax Rate</label>
                                                <div class="col-md-4">
                                                  <asp:TextBox ID="Item_CESS_Rate"  MaxLength="6" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
                                                    
                                                </div>
                                            </div>
                                        </div>
                                      
                                         <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">SGST Rate</label>
                                                <div class="col-md-4">
                                                    <asp:TextBox ID="Item_SGST_Rate" ReadOnly="true" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                           <div class="col-md-6">
                                               </div>
                                         <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">IGST Rate</label>
                                                <div class="col-md-4">
                                                    <asp:TextBox ID="Item_IGST_Rate" ReadOnly="true" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
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
                                        <asp:TextBox ID="MItem_ID" runat="server" Visible="false" />
                                        <div class="spacer-20"></div>
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
