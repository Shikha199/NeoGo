<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPEA.Master" AutoEventWireup="true"
     CodeBehind="CompanyDetails.aspx.cs" Inherits="JEMEA.SA.CompanyDetails" %>


 
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
                            <li>App Setting</li>
                            <li class="active">Company Details</li>
                        </ul>
                    </div>

                </div>
                <div class="row mp_ctrl_ph">
                    <div class="col-md-6">
                        <h2 class="mp_ctrl_frmheading">Company Details</h2>
                    </div>
                    <div class="col-md-6">
                        <div class="mp_ctrl_box  pull-right">

                             
                             
                            <asp:LinkButton ID="btnListClose" runat="server" OnClick="btnClose_Click" CssClass="btn btn-danger">Close</asp:LinkButton>

                        </div>
                    </div>
                </div>
                

                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h3 class="panel-title">System Details</h3>
                            </div>
                            <div class="panel-body">
                                <div class="form-horizontal">
                                    <div class="row">
                                         
                                          
                                          <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-sm-4 control-label">Company Name</label>
                                                
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="MDBSC_BR_Name"  ReadOnly="true" MaxLength="150" CssClass="form-control" ToolTip="Item Code" runat="server"   />
                                                </div>
                                            </div>
                                        </div>
                                        
                                      
                                          <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-sm-4 control-label">Invoice Perfix</label>
                                                
                                                <div class="col-md-3">
                                                    <asp:TextBox ID="MDBSC_BR_Perfix" ReadOnly="true"  MaxLength="2" CssClass="form-control" ToolTip="Item Code" runat="server"  />
                                                </div>
                                            </div>
                                        </div>
                                      

                                         
                                             
                                         <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="col-md-2 control-label">Company Address</label>
                                                <div class="col-md-10">
                                                   <asp:TextBox ID="MDBSC_BR_Print_HeaderTxt"  MaxLength="150" TextMode="MultiLine" Rows="3" CssClass="form-control" ToolTip="Item Code" runat="server"  />
                                                </div>
                                            </div>
                                        </div>

                                         <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="col-md-2 control-label">Invoice Declaration</label>
                                                <div class="col-md-10">
                                                   <asp:TextBox ID="MDBSC_BR_Print_Rpt_Default_Declaration"  MaxLength="150" TextMode="MultiLine" Rows="5" CssClass="form-control" ToolTip="Item Code" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                           <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Registration Type</label>
                                                <div class="col-md-8">
                                                     <asp:DropDownList ID="BR_RegType" Enabled="false" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                                DataTextField="Text" runat="server">
                                                            </asp:DropDownList>
                                                   
                                                </div>
                                            </div>
                                        </div>
                                        
                                    </div>
                                </div>
                            </div>
                        </div>


                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h3 class="panel-title">Contact Person Details</h3>
                            </div>
                            <div class="panel-body">
                                <div class="form-horizontal">

                                    <div class="row">
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Contact Person Name</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BR_Primary_Contact_Person"  MaxLength="50" CssClass="form-control" ToolTip="RegPinCode" runat="server" />

                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Designation</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BR_Primary_Contact_Designation"  MaxLength="50" CssClass="form-control" ToolTip="Pan No" runat="server" />

                                                </div>
                                            </div>
                                        </div>
                                    </div>



                                    <div class="row">

                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Phone No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BR_Primary_CP_PhoneNo"  MaxLength="15" CssClass="form-control" ToolTip="Adhar No" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                          <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Mobile No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BR_Primary_CP_MobileNo"  MaxLength="10" CssClass="form-control" ToolTip="Adhar No" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                        



                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Email ID</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BR_Primary_CP_EmailID"  MaxLength="50" CssClass="form-control" ToolTip="Adhar No" runat="server" />
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
                                                <label class="col-md-4 control-label">Contact Person Name</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BR_Buyer_Contact_Person"  MaxLength="50" CssClass="form-control" ToolTip="RegPinCode" runat="server" />

                                                </div>
                                            </div>
                                        </div>
                                         <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Mobile No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BR_Buyer_CP_MobileNo"  MaxLength="10" CssClass="form-control" ToolTip="Pan No" runat="server" />

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                           
                                    <div class="row">
                                       <div class="col-md-6">
                                            <div class="form-group">
                                                <div class="row m0">
                                                    <label class="col-md-4 control-label">Address</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="BR_Reg_Add1" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                        <asp:TextBox ID="BR_Reg_Add2" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                        <asp:TextBox ID="BR_Reg_Add3" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                    </div>

                                                </div>
                                                 <div class="row m0">
                                                      
                                                     <div class="col-md-12">
                                                         <div class="form-group">
                                                             <label class="col-md-4 control-label">Pincode</label>
                                                             <div class="col-md-8">
                                                                 <asp:TextBox ID="BR_Reg_Pincode" MaxLength="6" CssClass="form-control" ToolTip="Last Name" runat="server" />
                                                             </div>
                                                          
                                                         </div>
                                                     </div>

                                               <div class="col-md-12">
                                                         <div class="form-group">
                                                             <label class="col-md-4 control-label">City</label>
                                                             <div class="col-md-8">
                                                                 <asp:TextBox ID="BR_Reg_City" CssClass="form-control" ToolTip="Last Name" runat="server" />
                                                             </div>
                                                          
                                                         </div>
                                                     </div>
                                                       <div class="col-md-12">
                                                         <div class="form-group">
                                                             <label class="col-md-4 control-label">State</label>
                                                             <div class="col-md-8">
                                                                   <asp:DropDownList ID="BR_Reg_State_ID" Enabled="false" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                        DataTextField="Text" runat="server">
                                                        </asp:DropDownList>
                                                             </div>
                                                          
                                                         </div>
                                                     </div>

                                                     <div class="col-md-12">
                                                         <div class="form-group">
                                                             <label class="col-md-4 control-label">Country</label>
                                                             <div class="col-md-8">
                                                                 <asp:TextBox ID="BR_Reg_Country" Text="India" ReadOnly="true" CssClass="form-control" ToolTip="Last Name" runat="server" />
                                                             </div>
                                                          
                                                         </div>
                                                     </div>

                                                 </div>
                                                 
                                            </div>
                                             
                                        </div>
                                      <div class="col-md-6">
                                            <div class="form-group">
                                                        <label class="col-md-4 control-label">Phone No 1</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="BR_Contact_OfficeNo1" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                        </div>
                                                    </div>
                                        </div>
                                       

                                        <div class="col-md-6">
                                            
                                                
                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Phone No 2</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="BR_Contact_OfficeNo2" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                        </div>
                                                    </div>
                                                     <div class="form-group">
                                                        <label class="col-md-4 control-label">Fax No</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="BR_Contact_FaxNo" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                        </div>
                                                    </div>
                                                 <div class="form-group">
                                                        <label class="col-md-4 control-label">Email ID</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="BR_Contact_Email_Admin" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                        </div>
                                                    </div>

                                            <div class="form-group">
                                                <label class="col-md-4 control-label">ARN No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BL_ARNNO" MaxLength="15" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">GST No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BL_GSTNO" MaxLength="15" ReadOnly="true" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">PAN  No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BL_PANNO" MaxLength="10" ReadOnly="true" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                </div>
                                            </div>




                                        </div>

                                    </div>

                                      
                            </div>
                        </div>
                            </div>
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h3 class="panel-title">Shipping Details</h3>
                            </div>
                            <div class="panel-body">
                                <div class="form-horizontal">

                                     <div class="row">
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Contact Person Name</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BR_Consignee_Contact_Person"  MaxLength="50" CssClass="form-control" ToolTip="RegPinCode" runat="server" />

                                                </div>
                                            </div>
                                        </div>
                                          <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Mobile No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BR_Consignee_CP_MobileNo"  MaxLength="10" CssClass="form-control" ToolTip="Pan No" runat="server" />

                                                </div>
                                            </div>
                                        </div>
                                       
                                    </div>
                                    
                                    <div class="row">
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <div class="row m0">
                                                    <label class="col-md-4 control-label">Address</label>
                                                    <div class="col-md-8">
                                                        <asp:TextBox ID="BR_Consignee_Add1" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                        <asp:TextBox ID="BR_Consignee_Add2" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                        <asp:TextBox ID="BR_Consignee_Add3" CssClass="form-control" ToolTip="Residential Address" runat="server" />

                                                    </div>

                                                </div>
                                                <div class="row m0">
                                                    <div class="col-md-12">
                                                        <div class="form-group">
                                                            <label class="col-md-4 control-label">Pincode</label>
                                                            <div class="col-md-8">
                                                                <asp:TextBox ID="BR_Consignee_Pincode" MaxLength="6" CssClass="form-control" ToolTip="Last Name" runat="server" />
                                                            </div> 
                                                        </div>
                                                    </div>

                                                         <div class="col-md-12">
                                                        <div class="form-group">
                                                            <label class="col-md-4 control-label">City</label>
                                                            <div class="col-md-8">
                                                                <asp:TextBox ID="BR_Consignee_City" MaxLength="6" CssClass="form-control" ToolTip="Last Name" runat="server" />
                                                            </div> 
                                                        </div>
                                                         </div>
                                                    <div class="col-md-12">
                                                        <div class="form-group">
                                                            <label class="col-md-4 control-label">State</label>
                                                            <div class="col-md-8">
                                                                <asp:DropDownList ID="BR_Consignee_State_ID" Enabled="false" CssClass="form-control mp_ctrl_js_dd" ToolTip="Status" DataValueField="Value"
                                                                    DataTextField="Text" runat="server">
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </div>
                                                       <div class="col-md-12">
                                                         <div class="form-group">
                                                             <label class="col-md-4 control-label">Country</label>
                                                             <div class="col-md-8">
                                                                 <asp:TextBox ID="BR_Consignee_Country" Text="India" ReadOnly="true" CssClass="form-control" ToolTip="Last Name" runat="server" />
                                                             </div>
                                                             
                                                         </div>
                                                     </div>
                                                  
                                                 </div>

                                                  


                                               
                                            </div>



                                        </div>
                                         <div class="col-md-6">
                                             <div class="form-group">
                                                        <label class="col-md-4 control-label">Phone No 1</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="BR_Consignee_PhoneNo1" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                        </div>
                                                    </div>
                                        </div>
                                        <div class="col-md-6">
                                           
                                            
                                                <div class="form-group">
                                                        <label class="col-md-4 control-label">Phone No 2</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="BR_Consignee_PhoneNo2" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                        </div>
                                                    </div>
                                                 <div class="form-group">
                                                        <label class="col-md-4 control-label">Fax No</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="BR_Consignee_FaxNo" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                        </div>
                                                    </div>
                                               

                                                    <div class="form-group">
                                                        <label class="col-md-4 control-label">Email ID</label>
                                                        <div class="col-md-8">
                                                            <asp:TextBox ID="BR_Consignee_EmailID" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                        </div>
                                                    </div>
                                              
                                                  <div class="form-group">
                                                <label class="col-md-4 control-label">ARN No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BR_Consignee_ARNNO" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">GST No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BR_Consignee_GSTNO" ReadOnly="true" CssClass="form-control" ToolTip="MobileNo" runat="server" />

                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">PAN  No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BR_Consignee_PANNO" ReadOnly="true" CssClass="form-control" ToolTip="MobileNo" runat="server" />

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
                                                    <asp:TextBox ID="BR_AccountHolderName"  MaxLength="150" CssClass="form-control" ToolTip="Excise No" runat="server" />


                                                </div>
                                            </div>
                                        </div>
                                        
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Bank Name</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BR_BankName"  MaxLength="150" CssClass="form-control" ToolTip="Service Tax" runat="server" />


                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Account No</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BR_AccountNo"  MaxLength="20" CssClass="form-control" ToolTip="Pan No" runat="server" />

                                                </div>
                                            </div>
                                        </div>
                                          <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">Bank Branch</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BR_BankBranch"  MaxLength="50" CssClass="form-control" ToolTip="Service Tax" runat="server" />


                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="col-md-4 control-label">IFSC Code</label>
                                                <div class="col-md-8">
                                                    <asp:TextBox ID="BR_IFSCNo"  MaxLength="20" CssClass="form-control" ToolTip="Adhar No" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                     


                                </div>

                            </div>
                        </div>
                <div class="panel panel-default">
                            <div class="panel-heading">
                                <h3 class="panel-title">System Setup</h3>
                            </div>
                            <div class="panel-body">
                                <div class="form-horizontal">
                                     <div class="row">
                                                        <div class="col-md-6">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">Logo</label>
                                                                <div class="col-md-8">
                                                                    <asp:AsyncFileUpload id="CF_CMPLogo_Upload"   runat="server"
                                                                        onclientuploaderror="CF_CMPLogo_UploadError" 
                                                                        onclientuploadstarted="CF_CMPLogo_StartUpload"
                                                                        onclientuploadcomplete="CF_CMPLogo_UploadComplete"
                                                                        completebackcolor="Lime" uploaderstyle="Traditional"
                                                                        errorbackcolor="Red" throbberid="ImageUploading"
                                                                        onuploadedcomplete="CF_CMPLogo_FileUpload"
                                                                        uploadingbackcolor="Blue" 
                                                                        ClientIDMode="Static"
                                                                         
                                                                        /> 
                                                                     <asp:Label ID="Lbl_FU_CL_Msg_CF_CMPLogo" runat="server" Text=""></asp:Label>  
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6">
                                                            <div class="form-group">
                                                                <label class="col-md-4 control-label">Preview File</label>
                                                                <div class="col-md-8">
                                                                    <a id="HLnk_CF_CMPLogo" runat="server" class="btn btn-success" >view/download</a>
                                                                      
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
                                    <asp:TextBox ID="M_RT_CMP_BR_ID" runat="server" Visible="false" />
                                    <div class="spacer-20"></div>
                                </div>
                            </div>
                        </div>
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
<asp:Content ID="Content3" ContentPlaceHolderID="footerscript" runat="server">
        <script type="text/javascript">
            function CF_CMPLogo_UploadError(sender, args) {
                document.getElementById('<%=Lbl_FU_CL_Msg_CF_CMPLogo.ClientID %>').innerText = "Sorry, file is:“" + args.get_fileName() + "”Error：" + args.get_errorMessage();
            }
            function CF_CMPLogo_StartUpload(sender, args) {
                $('#m_core_mp_apploading_bx').modal('show');
                //Start Validation
                var filename = args.get_fileName();
                var ext = filename.substring(filename.lastIndexOf(".") + 1);
                if ((ext == 'png') || (ext == 'jpeg') || (ext == 'jpg')) {

                }
                else {
                    $('#m_core_mp_apploading_bx').modal('hide');
                    $('#m_core_mp_alert_bx').modal('show');
                    $('#m_core_mp_alert_bx_message').html('Invalid File Type. Upload Only png,jpeg,jpg')
                    throw {
                        name: "Invalid File Type",
                        level: "Error",
                        message: "Invalid File Type (Only png,jpeg,jpg)",
                        htmlMessage: "Invalid File Type (Only png,jpeg,jpg)"
                    }
                    return false;
                }
                return true;
                //END Validation
                document.getElementById('<%=Lbl_FU_CL_Msg_CF_CMPLogo.ClientID %>').innerText = "File “" + args.get_fileName() + "” Uploading...";
           }
            function CF_CMPLogo_UploadComplete(sender, args) {
                $('#m_core_mp_apploading_bx').modal('hide');
                $("[class*='modal-backdrop']").remove();

               
               //  document.getElementById('<%=Lbl_FU_CL_Msg_CF_CMPLogo.ClientID %>').innerText = "File“" + args.get_fileName() + "”Finished, Size：" + args.get_length() + " bytes";
                 document.getElementById('<%=Lbl_FU_CL_Msg_CF_CMPLogo.ClientID %>').innerText = "File Uploaded Successfully";
                document.getElementById('<%=btnRefreshPageOnFileUpload.ClientID %>').click();
             }



             
    </script>
</asp:Content>