<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPEA.Master" AutoEventWireup="true"
     CodeBehind="MenuMST.aspx.cs" Inherits="JEMEA.Utility.MenuMST" %>

<asp:Content ID="Content4" ContentPlaceHolderID="HeadContent_Js" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MAPPMAINCONTENT" runat="server">
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        
        <ContentTemplate>

             <div class="container-fluid">
                 
            <div class="mp_ctrl_breadcrumb row clearfix">
               
                    <div class="breadcrumb-line">
                        <ul class="breadcrumb">
                            <li>Setting</li>
                            <li class="active">Menu Master</li>
                        </ul>
                    </div>
                 
            </div>
                  <div class="row mp_ctrl_ph">
                <div class="col-md-6">
                    <h2 class="mp_ctrl_frmheading">Menu Master</h2>
                </div>
                <div class="col-md-6">
                    <div class="mp_ctrl_box  pull-right">
                         
                        <asp:LinkButton ID="LnkNew"   runat="server" CssClass="btn btn-success" OnClick="LnkNew_Click">Update Serial No</asp:LinkButton>
                        <asp:LinkButton ID="btnBack"  runat="server" CssClass="btn btn-primary" OnClick="btnBack_Click">Create Menu</asp:LinkButton>
                        <asp:LinkButton ID="btnListClose" runat="server" OnClick="btnClose_Click" CssClass="btn btn-danger" >Close</asp:LinkButton>

                    </div>
                </div>
            </div>
                 <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="List" runat="server">
                 <div class="panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title">Selection</h3>
                        </div>
                        <div class="panel-body">
                            <div class="form-horizontal">
                                         <div class="row"> 
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label class="col-sm-4 control-label">Module</label>
                                                    <div class="col-md-8">
                                                        <asp:DropDownList ID="M_RT_AM_ID" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                        OnSelectedIndexChanged="M_RT_AM_ID_SelectedIndexChanged"    AutoPostBack="true"   DataTextField="Text" runat="server">
                                                        </asp:DropDownList>
                                                    </div>
                                                </div>
                                            </div>                                             
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label class="col-sm-4 control-label">Parent Menu</label>
                                                    <div class="col-md-8 ">
                                                        <asp:DropDownList ID="M_RT_AppMenu_ID" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                          AutoPostBack="true"      OnSelectedIndexChanged="M_RT_AppMenu_ID_SelectedIndexChanged"    DataTextField="Text" runat="server">
                                                        </asp:DropDownList>
                                                    </div>
                                                </div>
                                            </div>
                                         </div>
                                <div class="row">
                                    <div class="col-md-12 mpu_txtCenter">
                                        <div class="form-group">
                                            <asp:Button ID="btnsave" runat="server" CssClass="btn btn-success" Text="Update" OnClick="btnsave_Click" />
                                            <asp:TextBox ID="MItem_ID" runat="server" Visible="false" />
                                            <div class="spacer-20"></div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    
                    
                       <div class="row mp_ctrl_searchbox">
                        <div class="col-md-12 ">
                            <div  >
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
                                         
                                        <asp:ImageButton ID="imgButtonGo" runat="server" ImageUrl="~/Content/images/shared/icon/go.png" OnClick="imgButtonGo_Click" />
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
                        <asp:GridView ID="gvList" runat="server" AllowPaging="false" AutoGenerateColumns="False"  OnRowDataBound="gvList_RowDataBound"
                            Width="100%"   OnRowCreated="gvList_RowCreated" CssClass="mp_ctrl_gv"   HeaderStyle-CssClass="mp_ctrl_gv_header"  PagerStyle-CssClass="mp_ctrl_gv_pagination">
                            <Columns>
                              
                                <asp:BoundField DataField="M_RT_AppMenu_ID" />
                                 <%--<0>--%><asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                    <ItemTemplate>
                                        <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                  <asp:BoundField DataField="MDBSC_Menu_For" HeaderText="Menu For" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                <asp:BoundField DataField="FK_MDBSC_Menu_ModuleID" HeaderText="ModuleID" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                <asp:BoundField DataField="MDBSC_Menu_Menu" HeaderText="Menu" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                
                                 
                                <asp:BoundField DataField="MDBSC_Menu_Level" HeaderText="Menu Level" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                <asp:BoundField DataField="MDBSC_Menu_ParentID" HeaderText="Parent ID" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                <asp:BoundField DataField="MDBSC_Menu_Url" HeaderText="URL" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                <asp:BoundField DataField="MDBSC_Menu_IsShow" HeaderText="To Show" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />

                                <asp:TemplateField HeaderText="Serial No" ItemStyle-HorizontalAlign="right">
                                    <ItemTemplate>
                                        <asp:TextBox ID="MDBSC_Menu_SerialNo" CssClass="form-control" Text='<%# Bind("MDBSC_Menu_SerialNo") %>' ToolTip="Item Code" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>

                               




                            </Columns>
                        </asp:GridView>
                    </div>
                </asp:View>
                 <asp:View ID="View1" runat="server">
                     </asp:View>
            </asp:MultiView>
                 </div>


           
           

            





        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerscript" runat="server">
</asp:Content>
