<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPEA.Master" AutoEventWireup="true"
     CodeBehind="AppFeedback.aspx.cs" Inherits="JEMEA.Utility.AppFeedback" %>

 
  
<asp:Content ID="Content2" ContentPlaceHolderID="MAPPMAINCONTENT" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
           <Triggers>
            <asp:PostBackTrigger ControlID="btnETE" />
               
        </Triggers>
        <ContentTemplate>
            <div class="container-fluid">
                <div class="mp_ctrl_breadcrumb row clearfix">
                    <div class="breadcrumb-line">
                        <ul class="breadcrumb">
                            <li>Utility</li>
                            <li class="active">Feedback</li>
                        </ul>
                    </div>
                </div>

                <div class="row mp_ctrl_ph">
                    <div class="col-md-6">
                        <h2 class="mp_ctrl_frmheading">Feedback</h2>
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
                                     <asp:Button ID="btnETE" runat="server" OnClick="btnETE_Click" CssClass="btn btn-primary btn-Mtitle"   Text="Download Excel"  />
                                     <asp:Label ID="Msg_RCNT" runat="server" CssClass="mp_e_msg_default" Text=""></asp:Label></span>
                                </h2>
                            </div>
                        </div>
                        <hr class="mp_ctrl_gv_hr" />
                        <div class="table-responsive">
                            <asp:GridView ID="gvList" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="gvList_PageIndexChanging"
                                Width="100%" PageSize="250" OnRowCreated="gvList_RowCreated" CssClass="mp_ctrl_gv" HeaderStyle-CssClass="mp_ctrl_gv_header" PagerStyle-CssClass="mp_ctrl_gv_pagination">
                                <Columns>
                                    <asp:BoundField DataField="MAF_ID" />
                                    <%--<0>--%><asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                        <ItemTemplate>
                                            <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="MDBSC_BR_Name" HeaderText="Site" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="Q_Module" HeaderText="Module" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />


                                    <asp:BoundField DataField="vQ_Date" HeaderText="Date" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="Q_Title" HeaderText="Title" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="Q_Description" HeaderText="Description" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="Q_Priority" HeaderText="Priority" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="MDBSC_RowStatus" HeaderText="Status" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="IsLock" HeaderText="Is Locked" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="MDBSC_RowCreatedByUserName" HeaderText="Created By" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="View / Edit" HeaderStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:ImageButton ImageUrl="~/Content/images/appimg/appicon/system/edit.png" ID="lnkEdit" OnClick="lnkEdit_Click"
                                                runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                        <div class="table-responsive" style="display:none">
                        <asp:GridView ID="gvList_Export"  runat="server" AllowPaging="false" AutoGenerateColumns="False"
                            Width="100%" >
                            <Columns>
                                   
                               <asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                    <ItemTemplate>
                                        <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                    </ItemTemplate>
                               </asp:TemplateField>
                                 <asp:BoundField DataField="MDBSC_BR_Name" HeaderText="Site" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="Q_Module" HeaderText="Module" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />


                                    <asp:BoundField DataField="vQ_Date" HeaderText="Date" ItemStyle-HorizontalAlign="center" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="Q_Title" HeaderText="Title" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="Q_Description" HeaderText="Description" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                <asp:BoundField DataField="Q_Priority" HeaderText="Priority" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                
                                    <asp:BoundField DataField="MDBSC_RowStatus" HeaderText="Status" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                    <asp:BoundField DataField="IsLock" HeaderText="Is Locked" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                <asp:BoundField DataField="Q_URL" HeaderText="URL" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                <asp:BoundField DataField="MDBSC_RowCreatedByUserName" HeaderText="Created By" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                            </Columns>
                        </asp:GridView>
                    </div>
                    </asp:View>
                    <asp:View ID="Entry" runat="server">

                        <div class="panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title">Feedback</h3>
                        </div>
                        <div class="panel-body">
                            <div class="form-horizontal">
                                        <div class="row"> 
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label class="col-sm-4 control-label">Site</label>
                                                    <div class="col-md-8">
                                                        <asp:DropDownList ID="Q_BranchID" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status"  DataValueField="value" 
                                                     DataTextField="Text"  runat="server" ></asp:DropDownList>
                                                      
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
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label class="col-sm-4 control-label">Module</label>
                                                    <div class="col-md-8 ">
                                                        <asp:DropDownList ID="Q_Module" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" runat="server">
                                                            <asp:ListItem Text="--Select Module--" Value=""></asp:ListItem>
                                                            <asp:ListItem Text="Master" Value="Master"></asp:ListItem>
                                                            <asp:ListItem Text="Indent" Value="Indent"></asp:ListItem>
                                                            <asp:ListItem Text="Quotation" Value="Quotation"></asp:ListItem>
                                                            <asp:ListItem Text="Purchase Order" Value="Purchase Order"></asp:ListItem>
                                                            <asp:ListItem Text="Stock" Value="Stock"></asp:ListItem>
                                                            <asp:ListItem Text="GRN" Value="GRN"></asp:ListItem>
                                                            <asp:ListItem Text="Stock Issue" Value="Stock Issue"></asp:ListItem> 
                                                            <asp:ListItem Text="Report" Value="Report"></asp:ListItem> 
                                                            <asp:ListItem Text="Other" Value="Other"></asp:ListItem>

                                                        </asp:DropDownList>
                                                    </div>
                                                </div>
                                            </div>
                                             <div class="col-md-6">
                                                <div class="form-group">
                                                    <label class="col-sm-4 control-label">Date</label>
                                                    <div class="col-md-8 ">
                                                     <asp:TextBox ID="Q_Date" CssClass="form-control" ToolTip="Item Code" ReadOnly="true" Columns="15" MaxLength="50" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                                          
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label class="col-sm-4 control-label">Title</label>
                                                    <div class="col-md-8  ">
                                                        <asp:TextBox ID="Q_Title" CssClass="form-control" ToolTip="Item Code" Columns="15" MaxLength="50"   runat="server" />
                                                       
                                                         
                                                    </div>
                                                </div>
                                            </div>


                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label class="col-md-4 control-label">Status</label>
                                                    <div class="col-md-3">
                                                        <asp:DropDownList ID="MDBSC_RowStatus" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" runat="server">
                                                            <asp:ListItem Text="New" Value="New"></asp:ListItem>
                                                            <asp:ListItem Text="Pending" Value="Pending"></asp:ListItem>
                                                            <asp:ListItem Text="In Process" Value="In Process"></asp:ListItem>
                                                            <asp:ListItem Text="Completed" Value="Completed"></asp:ListItem>

                                                        </asp:DropDownList>
                                                    </div>
                                                </div>
                                            </div>
                                             <div class="col-md-6">
                                                <div class="form-group">
                                                    <label class="col-md-4 control-label">Priority</label>
                                                    <div class="col-md-3">
                                                        <asp:DropDownList ID="Q_Priority" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" runat="server">
                                                            <asp:ListItem Text="--Select Priority--" Value=""></asp:ListItem>
                                                            <asp:ListItem Text="High" Value="High"></asp:ListItem>
                                                            <asp:ListItem Text="Medium" Value="Medium"></asp:ListItem>
                                                            <asp:ListItem Text="Low" Value="Low"></asp:ListItem>
                                                             

                                                        </asp:DropDownList>
                                                    </div>
                                                </div>
                                            </div>
                                             <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">URL</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="Q_URL" CssClass="form-control" ToolTip="Adhar No" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                      
                                        </div>
                                 <div class="row">
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="col-md-2 control-label">Description</label>
                                                <div class="col-md-10">
                                                    <asp:TextBox ID="Q_Description" TextMode="MultiLine" Rows="4" CssClass="form-control" ToolTip="RegPinCode" runat="server" />
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
                                    <asp:TextBox ID="MAF_ID" runat="server" Visible="false" />
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