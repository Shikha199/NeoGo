<%@ Page Title="" Language="C#" MasterPageFile="~/AI/LayoutEnterprise/MPAuth.Master" 
    AutoEventWireup="true" CodeBehind="AppLogin.aspx.cs" Inherits="JEMEA.Account.AppLogin1" %>
 

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent_Css" runat="server">
<style>

.loginBg {background: url(../Content/Images/liveproject/CLLoginBg.jpeg) 50% 0px / cover no-repeat fixed;}
    .mp_cb_w {background:      rgba(0, 0, 0, 0.5);}
    .btn {padding: 6px 12px;    }
    label {font-weight:normal !important;    }
    .form-group .fa {font-size: 1.4em;    }
    .form-control {font-size:16px ;     height: 34px;    }
    p {margin:0px;    }
     .copyright {text-align: center;margin: 0 auto;padding: 10px;color: #eee !important;font-size: 13px;}
     .copyright a {text-align: center;margin: 0 auto;padding: 10px;color: #eee;font-size: 13px;}
</style>

    </asp:Content>
    
<asp:Content ID="Content3" ContentPlaceHolderID="AppAuth_MainContent" runat="server">

   <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       <ContentTemplate>
           <div class="container-fluid">
               <div class="row">
                   <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                       <div class="mp_cb_w"  >
                           <div class="mp_cb_c">
                               <div class="text-center m-b">
                                   <img src="../Content/images/liveproject/ClientLogoLogin.png" width="75%" height="75%" />
                        <h2 class="text-uppercase"  >Invoice Management</h2>
                                   <h4 class="text-uppercase"  >Welcome back</h4>
                        <p>Please sign in to your account</p>
                    </div>
                    <div class="login-form" >
                           
                            <div class="form-group">
                                <!--ie8, ie9 does not support html5 placeholder, so we just show field title for that-->
                                <label class="control-label visible-ie8 visible-ie9">User ID</label>
                              <div class="form-group form-group_icon">
                                    <i class="fa fa-user"></i>
                                     
                                      <asp:TextBox ID="userid"  class="mp_input_wth_icon form-control   " runat="server" placeholder="Username" AutoCompleteType="Disabled"></asp:TextBox>
                                    
                                </div>
                            </div>
                        <div class="spacer-10"></div>
                            <div class="form-group">
                                <label class="control-label visible-ie8 visible-ie9">Password</label>
                                <div class="form-group form-group_icon">
                                    <i class="fa fa-lock"></i>
                                    <asp:TextBox ID="Password" class="mp_input_wth_icon form-control   " TextMode="Password" runat="server" AutoCompleteType="Disabled" placeholder="Password"></asp:TextBox>
                                    
                                </div>
                            </div>
                        <div class="spacer-10"></div>
                      

                         

                          <div class="form-actions " style="text-align: center;">
                            
                                <asp:Button ID="btnLogin" CssClass="btn btn-primary  col-xs-12 col-sm-6 col-md-6 col-lg-6  " OnClick="btnLogin_Click" runat="server" Text="Log In" />
                            
                          
                                <asp:Button ID="btnCancel" CssClass="btn btn-danger   col-xs-12 col-sm-6 col-md-6 col-lg-6" runat="server" Text="Cancel"
                                    OnClientClick="javascript:self.close()" />
                          


                        </div> <div class="spacer-5"></div>
                        <div class="copyright">
                       <%--<a href="http://www.jyotibaenterprise.com" target="_blank"> powered by www.jyotibaenterprise.com</a>--%>
                    </div>
                          <div class="spacer-5"></div>


                    </div>
                           </div>
                       </div>
        </div>
    </div>
            </div>
    
            </ContentTemplate>
            </asp:UpdatePanel>
</asp:Content>
 
