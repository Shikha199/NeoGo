<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPEA.Master" AutoEventWireup="true"
     CodeBehind="TaxMst.aspx.cs" Inherits="JEMEA.Master.TaxMst" %>

 
<asp:Content ID="Content4" ContentPlaceHolderID="HeadContent_Js" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MAPPMAINCONTENT" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">

        <ContentTemplate>
             <div class="container-fluid">
                   <div class="mp_ctrl_breadcrumb row clearfix">

                <div class="breadcrumb-line">
                    <ul class="breadcrumb">
                        <li>Master</li>
                        <li class="active">Tax Master</li>
                    </ul>
                </div>

            </div>

            <div class="row mp_ctrl_ph">
                <div class="col-md-6">
                    <h2 class="mp_ctrl_frmheading">Tax Master</h2>
                </div>
                <div class="col-md-6">
                    <div class="mp_ctrl_box  pull-right">



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
                <div class="col-xs-12 col-sm-5 col-md-5 col-lg-5" >
                    <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h3 class="panel-title">Details</h3>
                                </div>
                                <div class="panel-body">
                                    <div class="form-horizontal">
                                        <div class="row">
 

                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="col-sm-4 control-label">Tax Category</label>
                                                    <div class="col-md-8">

                                                        <asp:DropDownList ID="Tax_Category" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" runat="server">
                                                            <asp:ListItem Text="--Select Category--" Value=""></asp:ListItem>
                                                            <asp:ListItem Text="Integrated Tax" Value="Integrated Tax"></asp:ListItem> 
                                                            <asp:ListItem Text="CESS" Value="CESS"></asp:ListItem>
                                                             

                                                        </asp:DropDownList>
                                                    </div>
                                                </div>
                                            </div>


                                                 
 
                          

                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="col-sm-4 control-label">Taxable Rate</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="Tax_Rate" CssClass="form-control" ToolTip="Item Code" Columns="15" MaxLength="50" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                               
                                              <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="col-sm-4 control-label">Description</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="Tax_Desc" CssClass="form-control" ToolTip="Item Code" Columns="15" MaxLength="5" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                                 

                                                 
                                             

                                            
                                                        
                                           
                                        </div>

                                    </div>
                                    <div class="row">
                                       <div class="col-md-4 mp_u_text-center">
                                            </div>
                                        <div class="col-md-8  ">
                                            <div class="form-group">
                                                <asp:Button ID="btnsave" runat="server" CssClass="btn btn-success" Text="Save" OnClick="btnsave_Click" />
                                                <asp:Button ID="btnNew" runat="server" CssClass="btn btn-info" Text="Reset" OnClick="LnkNew_Click" />
                                                <asp:TextBox ID="Tax_ID" runat="server" Visible="false" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                </div>
                 <div class="col-xs-12 col-sm-7 col-md-7 col-lg-7" >
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
                            Width="100%" PageSize="50" OnRowCreated="gvList_RowCreated" CssClass="mp_ctrl_gv"    HeaderStyle-CssClass="mp_ctrl_gv_header" PagerStyle-CssClass="mp_ctrl_gv_pagination">
                            <Columns>
                                  <asp:BoundField DataField="Tax_ID" />
                                <%--<0>--%><asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                    <ItemTemplate>
                                        <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField> 
                                <asp:BoundField DataField="Tax_Category" HeaderText="Category" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" /> 
                                <asp:BoundField DataField="Tax_Rate" HeaderText="Rate" ItemStyle-HorizontalAlign="right" HeaderStyle-HorizontalAlign="Center" />
                                <asp:BoundField DataField="Tax_Desc" HeaderText="Description" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" /> 
                                 <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="View / Edit" HeaderStyle-HorizontalAlign="Center">
                                    <ItemTemplate> 
                                        <asp:ImageButton ImageUrl="~/Content/images/appimg/appicon/system/edit.png" ID="lnkEdit" OnClick="lnkEdit_Click" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                 </div>

            </div>

            </div>
          

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterScript" runat="server">
</asp:Content>
