<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPEA.Master" AutoEventWireup="true"
    CodeBehind="ItemMstBulkUpdate.aspx.cs" Inherits="JEMEA.Master.ItemMstBulkUpdate" %>


 
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
                            <asp:LinkButton ID="LnkBulkUpdateSave" runat="server" CssClass="btn btn-primary" OnClick="LnkBulkUpdateSave_Click">Bulk Update Save</asp:LinkButton>
                             
                             
                             
                            <asp:LinkButton ID="btnListClose" runat="server" OnClick="btnClose_Click" CssClass="btn btn-danger">Close</asp:LinkButton>
                        </div>
                    </div>
                </div>
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

                                     <asp:Label ID="Msg_RCNT_BIU" runat="server" CssClass="mp_e_msg_default" Text=""></asp:Label></span>
                                </h2>
                            </div>
                        </div>
                        <hr class="mp_ctrl_gv_hr" />
                         <div class="table-responsive">
                            <asp:GridView ID="gv_BulkItemUpdate" runat="server" AllowPaging="true" AutoGenerateColumns="False" OnPageIndexChanging="gvList_PageIndexChanging"
                                Width="100%" PageSize="100" OnRowCreated="gv_BulkItemUpdate_OnRowCreated" OnRowDataBound="gv_BulkItemUpdate_OnRowDataBound" CssClass="mp_ctrl_gv" HeaderStyle-CssClass="mp_ctrl_gv_header" PagerStyle-CssClass="mp_ctrl_gv_pagination">
                                <Columns>
                                    <asp:BoundField DataField="MItem_ID" />
                                    <asp:BoundField DataField="Item_Tax_GST_ID" />
                                    <%--<0>--%><asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                        <ItemTemplate>
                                            <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ItemStyle-HorizontalAlign="left" HeaderText="Item Details" HeaderStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <div class="row">
                                                  <div class="col-md-12">
                                               <label class="col-md-12 control-label">Item Name</label>
                                                <div class="col-md-12">
                                                    <asp:TextBox ID="Item_Name" Text='<%# Bind("Item_Name") %>'     CssClass="form-control" ToolTip="Adhar No" runat="server" />
                                                </div>
                                                     </div>
                                            </div>
                                             <div class="row">
                                                  <div class="col-md-12">
                                               <label class="col-md-12 control-label">Inv Description</label>
                                                <div class="col-md-12">
                                                    <asp:TextBox ID="Item_Inv_Desc" Text='<%# Bind("Item_Inv_Desc") %>'     CssClass="form-control" ToolTip="Adhar No" runat="server" />
                                                </div>
                                                     </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">User Code</label>
                                                        <div class="col-md-4">
                                                            <asp:TextBox ID="I_UserCode" Text='<%# Bind("I_UserCode") %>' MaxLength="10" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>
                                                 <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Selling Rate</label>
                                                        <div class="col-md-4">
                                                            <asp:TextBox ID="Item_Selling_Rate" Text='<%# Bind("Item_Selling_Rate") %>' MaxLength="10" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
                                                        </div>
                                                    </div>
                                                </div>
                                                  <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Purchase Rate</label>
                                                        <div class="col-md-4">
                                                            <asp:TextBox ID="Item_Purchase_Rate"  Text='<%# Bind("Item_Purchase_Rate") %>' MaxLength="10" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
                                                        </div>
                                                    </div>
                                                  </div>
                                                
                                            </div>



                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="Update" HeaderStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                             <asp:Button ID="btnsaveItem" runat="server" CssClass="btn btn-success" Text="Update" OnClick="btnsaveItem_Click" />
                                           
                                        </ItemTemplate>
                                    </asp:TemplateField>
   
                                </Columns>
                            </asp:GridView>
                        </div>
                
                
               
                
                
                
                
                  
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerscript" runat="server">
</asp:Content>
