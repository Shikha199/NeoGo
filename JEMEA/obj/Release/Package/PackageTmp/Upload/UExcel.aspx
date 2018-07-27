<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPEA.Master" AutoEventWireup="true"
    CodeBehind="UExcel.aspx.cs" Inherits="JEMEA.Upload.UExcel" %>



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
                            <li class="active">Excel Processing Engine</li>
                        </ul>
                    </div>
                </div>

                <div class="row mp_ctrl_ph">
                    <div class="col-md-6">
                        <h2 class="mp_ctrl_frmheading">Excel Processing Engine</h2>
                    </div>
                    <div class="col-md-6">
                        <div class="mp_ctrl_box  pull-right">
                          
                            <asp:LinkButton ID="btnListClose" runat="server" OnClick="btnClose_Click" CssClass="btn btn-danger">Close</asp:LinkButton>
                        </div>
                    </div>
                </div>
                  <ajaxToolkit:TabContainer ID="M_ATab_C" runat="server"   OnActiveTabChanged="On_Active_Tab_Changed"
                    CssClass="m_tab_container" OnDemand="true" ActiveTabIndex="0"     >
                            <ajaxToolkit:TabPanel ID="MTabPanelA" runat="server" HeaderText="Upload Excel" Enabled="true" OnDemandMode="Always">
                                <ContentTemplate>
                                    <div class="row mp_ctrl_ph">
                                        <div class="col-md-6">
                                            <h2 class="mp_ctrl_frmheading">Upload Excel</h2>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="mp_ctrl_box  pull-right">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="panel panel-default">
                                        <div class="panel-heading">
                                            <h3 class="panel-title">Upload Excel</h3>
                                        </div>
                                        <div class="panel-body">
                                            <div class="form-horizontal">

                                                <div class="row">
                                                    <div class="col-md-6">
                                                        <div class="form-group">
                                                            <label class="col-md-4 control-label">GSTIN</label>
                                                            <div class="col-md-4">
                                                                <asp:TextBox ID="GSTIN" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-6">
                                                        <div class="form-group">
                                                            <label class="col-md-4 control-label">Preview File</label>
                                                            <div class="col-md-4">
                                                                <a id="Hlnk_AF_UserExcel" runat="server" class="btn btn-success">File Not Avaliable</a>
                                                            </div>
                                                        </div>
                                                    </div>
                                                     
                                                       



  
                                                     
                                                        
                                                   </div>
                                                <div class="row">
                                                         <div class="col-md-6">
                                                        <div class="form-group">
                                                            <label class="col-md-4 control-label">Upload Excel File</label>
                                                            <div class="col-md-8">
                                                                  <asp:AsyncFileUpload id="AF_UserExcel_Upload"   runat="server"
                                                                        onclientuploaderror="AF_UserExcel_UploadError" 
                                                                        onclientuploadstarted="AF_UserExcel_StartUpload"
                                                                        onclientuploadcomplete="AF_UserExcel_UploadComplete"
                                                                        completebackcolor="Lime" uploaderstyle="Traditional"
                                                                        errorbackcolor="Red" throbberid="ImageUploading"
                                                                        onuploadedcomplete="AF_UserExcel_FileUpload"
                                                                        uploadingbackcolor="Blue" 
                                                                        ClientIDMode="Static"
                                                                         
                                                                        /> 
                                                                     <asp:Label ID="lblMsg_AF_UserExcel" runat="server" Text=""></asp:Label>  
                                                            </div>
                                                        </div>
                                                    </div>
                                                         <div class="col-md-6">
                                                        <div class="form-group">
                                                            <label class="col-md-4 control-label"></label>
                                                            <div class="col-md-8">
                                                                <asp:Button ID="btnExtractColumn" runat="server" CssClass="btn btn-primary" Text="Extract Column" OnClick="btnExtractColumn_Click" />

                                                            </div>
                                                        </div>
                                                    </div>
                                                         </div>

                                            </div>
                                        </div>
                                    </div>
                                   
                                       
                         

 
                                </ContentTemplate>
                            </ajaxToolkit:TabPanel>
                            <ajaxToolkit:TabPanel ID="TabPanel1" runat="server" HeaderText="Map Column" OnDemandMode="Always">
                                <ContentTemplate>
                                    <div class="row mp_ctrl_ph">
                                        <div class="col-md-6">
                                            <h2 class="mp_ctrl_frmheading">Map Column</h2>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="mp_ctrl_box  pull-right">
                                            </div>
                                        </div>
                                    </div>
                                    
                                         <div class="row">
                                        <div class="col-md-12">
                                            <h2 class="mp_ctrl_gv_title">List

                                 <span class="pull-right">
                                     <asp:Label ID="lblGSTIN" runat="server" CssClass="mp_e_msg_default" Text=""></asp:Label> 
                                     
                                     <%--<asp:Button ID="btnRefreshList" runat="server" CssClass="btn btn-success" Text="Refresh List" OnClick="btnRefreshList_Click" />--%>
                                     <asp:Button ID="btnUpdateColumnMapping" runat="server" CssClass="btn btn-primary" Text="Update Mapping" OnClick="btnUpdateColumnMapping_Click" />
                                     <asp:Label ID="Msg_RCNT_User" runat="server" CssClass="mp_e_msg_default" Text=""></asp:Label>
                                                </span>
                                            </h2>
                                        </div>
                                    </div>
                                    <hr class="mp_ctrl_gv_hr" />
                                    <div class="table-responsive">

                                        <asp:GridView ID="gv_UserColumn" runat="server" AllowPaging="false" AutoGenerateColumns="False"
                                            PageSize="200" OnRowCreated="gv_UserColumn_RowCreated" OnRowDataBound="gv_UserColumn_RowDataBound" CssClass="mp_ctrl_gv" HeaderStyle-CssClass="mp_ctrl_gv_header" PagerStyle-CssClass="mp_ctrl_gv_pagination">
                                            <Columns>
                                                <asp:BoundField DataField="FUDTL_ID" />
                                                 
                                                <asp:TemplateField HeaderText="Sr No" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50">
                                                    <ItemTemplate>
                                                        <asp:Label ID="SrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="GSTIN" HeaderText="GSTIN" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                                
                                                <asp:BoundField DataField="FU_UserColumn" HeaderText="User Column" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Center" />
                                                <asp:TemplateField ItemStyle-HorizontalAlign="left" HeaderText="System Column" HeaderStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                    <asp:DropDownList ID="FU_SystemColumn" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" runat="server">
                                                        <asp:ListItem Text="Column1" Value="Column1"></asp:ListItem>
                                                        <asp:ListItem Text="Column2" Value="Column2"></asp:ListItem>
                                                        <asp:ListItem Text="Column3" Value="Column3"></asp:ListItem>
                                                        <asp:ListItem Text="Column4" Value="Column4"></asp:ListItem>
                                                        <asp:ListItem Text="Column5" Value="Column5"></asp:ListItem>
                                                    </asp:DropDownList>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </div>


                                </ContentTemplate>
                            </ajaxToolkit:TabPanel>
                             
                             


                             
                             

                        </ajaxToolkit:TabContainer>
                 <div class="row" style="display: none;">
                            <div class="col-md-12 mpu_txtCenter">
                                <div class="form-group">
                                    <asp:Button ID="btnRefreshPageOnFileUpload" runat="server" CssClass="btn btn-success" Text="Refresh Page" OnClick="btnRefreshPageOnFileUpload_Click" />
                                    <div class="spacer-20"></div>
                                </div>
                            </div>
                        </div>
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
 
<asp:Content ID="Content1" ContentPlaceHolderID="footerscript" runat="server">
        <script type="text/javascript">
            function AF_UserExcel_UploadError(sender, args) {
                document.getElementById('<%=lblMsg_AF_UserExcel.ClientID %>').innerText = "Sorry, file is:“" + args.get_fileName() + "”Error：" + args.get_errorMessage();
            }
            function AF_UserExcel_StartUpload(sender, args) {
                $('#m_core_mp_apploading_bx').modal('show');
                //Start Validation
                var filename = args.get_fileName();
                var ext = filename.substring(filename.lastIndexOf(".") + 1);
                var recipient = $("#<%=GSTIN.ClientID%>").val();
                var mclerrmsg = '';
                var mclerrmsg_txt = '';
                if (!recipient.trim()) {
                    mclerrmsg = mclerrmsg + 'GSTIN No Cannot Be Blank<br>';
                    var mclerrmsg_txt = 'File Type cannot be blank';
                }

                if ((ext == 'xls') || (ext == 'xlsx')) {

                }
                else {
                    mclerrmsg = mclerrmsg + 'Invalid File Type (Only xlsx , xls)<br>';
                    var mclerrmsg_txt = 'Invalid File Type (Only xlsx , xls)';
                    }

                if (mclerrmsg.length > 0) {
                    $('#m_core_mp_apploading_bx').modal('hide');
                    $('#m_core_mp_alert_bx').modal('show');
                    $('#m_core_mp_alert_bx_message').html(mclerrmsg)
                    $(sender._element).find('input').val('');
                    throw {
                        name: mclerrmsg_txt,
                        level: "Error",
                        message: mclerrmsg_txt,
                        htmlMessage: mclerrmsg_txt
                    }



                //if ((ext == 'xls') || (ext == 'xlsx')) {

                //}
                //else {
                //    $('#m_core_mp_apploading_bx').modal('hide');
                //    $('#m_core_mp_alert_bx').modal('show');
                //    $('#m_core_mp_alert_bx_message').html('Invalid File Type. Upload Only xlsx , xls')
                //    throw {
                //        name: "Invalid File Type",
                //        level: "Error",
                //        message: "Invalid File Type (Only xlsx , xls)",
                //        htmlMessage: "Invalid File Type (Only xlsx , xls)"
                //    }
                //    return false;
                }
                return true;
                //END Validation
                document.getElementById('<%=lblMsg_AF_UserExcel.ClientID %>').innerText = "File “" + args.get_fileName() + "” Uploading...";
            }
            function AF_UserExcel_UploadComplete(sender, args) {
                $('#m_core_mp_apploading_bx').modal('hide');

                //  document.getElementById('<%=lblMsg_AF_UserExcel.ClientID %>').innerText = "File“" + args.get_fileName() + "”Finished, Size：" + args.get_length() + " bytes";
                document.getElementById('<%=lblMsg_AF_UserExcel.ClientID %>').innerText = "File Uploaded Successfully";
                //   document.getElementById('<%=btnRefreshPageOnFileUpload.ClientID %>').click();
            }

 
    </script>
</asp:Content>