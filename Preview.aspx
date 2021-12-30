<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Preview.aspx.vb" Inherits="Career.Preview" %>
<!DOCTYPE html>

  <form id="form1" runat="server" style="width: 100%;width: 100vw;" >       
    <div id="pos_container2" style="" >            
            <div class="form-group row" >
                  <div class="col-12" style="text-align: center;">
                        <h4><b>Application Summary</b></h4>
                  </div>      
            </div>          
            <br /> 
          <div class="form-group row" >
                  <div class="col-12">
	                    <span class="H4">申請職位 Position Applied</span><br />	        
	                    <asp:Label ID ="lbl_refno" runat="server" ></asp:Label> - 
	                    <asp:Label ID ="lbl_appjob" runat="server"></asp:Label>
	              </div>     
          </div>
                  <br /> 
          <div class="form-group row" >
                  <div class="col-12">
	                    <span class="H4">個人資料 Personal Details</span><br />	       
	              </div>     
          </div>
          <div class="form-group row" >
                  <div class="col-4">
	                     <asp:Label ID ="Label1" >稱謂 Salutation</asp:Label>    
	              </div>     
                  <div class="col-8">
	                     <asp:Label ID ="lbl_title" runat="server"></asp:Label>    
	              </div>     
          </div>
          <div class="form-group row" >
                  <div class="col-4">
	                     <asp:Label ID ="Label2" > 姓 Family name</asp:Label>    
	              </div>     
                  <div class="col-8">
	                     <asp:Label ID ="lbl_surname" runat="server"></asp:Label>    
	              </div>     
          </div>
          <div class="form-group row" >
                  <div class="col-4">
	                     <asp:Label ID ="Label3" >名 Given name</asp:Label>    
	              </div>     
                  <div class="col-8">
	                     <asp:Label ID ="lbl_othername" runat="server"></asp:Label>    
	              </div>     
          </div>
          <div class="form-group row" >
                  <div class="col-4">
	                     <asp:Label ID ="Label4" >中文姓名 Name in Chinese</asp:Label>    
	              </div>     
                  <div class="col-8">
	                     <asp:Label ID ="lbl_chnname" runat="server"></asp:Label>    
	              </div>     
          </div>
          <div class="form-group row" >
                  <div class="col-4">
	                     <asp:Label ID ="Label5">電郵 E-mail</asp:Label>    
	              </div>     
                  <div class="col-8">
	                     <asp:Label ID ="lbl_email" runat="server"></asp:Label>    
	              </div>     
          </div>
          <div class="form-group row" >
                  <div class="col-4">
	                     <asp:Label ID ="Label6" >電話 Phone</asp:Label>    
	              </div>     
                  <div class="col-8">
	                     <asp:Label ID ="lbl_phone" runat="server"></asp:Label>    
	              </div>     
          </div>
          <div class="form-group row" >
                  <div class="col-4">
	                     <asp:Label ID ="Label7" >英文地址 Address in English</asp:Label>    
	              </div>     
                  <div class="col-8">
	                     <asp:Label ID ="lbl_address" runat="server"></asp:Label>    
	              </div>     
          </div>       
            <br /> 
          <div class="form-group row" >
                  <div class="col-12">
	                    <span class="H4">教育程度 Education</span><br />	       
	              </div>     
          </div>
          <div class="form-group row" >
          <div class="table-responsive col-12">
                            <asp:Table ID="eduTable" runat ="server" CssClass="mytable2" > 
                                <asp:TableHeaderRow ID="TableHeaderRow1" TableSection="TableHeader" runat="server">
                                    <asp:TableHeaderCell Width="14%" >
                                        教育程度
                                         <br />
                                        Education level
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell  Width="30%">
                                        學校名稱
                                        <br />
                                        Name of school / university
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell  Width="20%">
                                        課程名稱
                                        <br />
                                        Course name
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell  Width="10%">
		                               主科
                                      <br />
                                      Major subject
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell  Width="10%">
		                               畢業年份
                                      <br />
                                      Graduation year <br /> (MM/YYYY)
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="15%">
		                               考獲成績
                                      <br />
                                      Result
                                    </asp:TableHeaderCell>
                                </asp:TableHeaderRow>
                            </asp:Table> 
                </div>
          </div>
          <br />
          <div class="form-group row" >
                  <div class="col-12">
	                    <span class="H4">獎項/獎學金 Awards / Scholarship</span><br />	       
	              </div>     
          </div>
          <div class="form-group row" >
          <div class="table-responsive col-12">
                            <asp:Table ID="awardTable" runat ="server" CssClass="mytable2" >                                 
                                <asp:TableHeaderRow ID="TableHeaderRow2" TableSection="TableHeader" runat="server">
                                    <asp:TableHeaderCell Width="44%" >
                                        機構/院校名稱 Name of organization / institute 
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="38%" >
                                        獎項/獎學金 Name of award / scholarship
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="18%" >
                                       獲取年份 Year obtained (YYYY)
                                    </asp:TableHeaderCell>
                                </asp:TableHeaderRow>
                            </asp:Table>
                     </div>     
           </div>
          <br />
          <div class="form-group row" >
                  <div class="col-12">
	                    <span class="H4">課外活動 Extra-Curricular Activities</span><br />	       
	              </div>     
          </div>
          <div class="form-group row" >
                <div class="table-responsive col-12">
                            <asp:Table ID="actvTable" runat ="server" CssClass="mytable2" >                                 
                                <asp:TableHeaderRow ID="TableHeaderRow3" TableSection="TableHeader" runat="server">
                                    <asp:TableHeaderCell Width="44%" >
                                        機構/院校名稱 Name of organization / institute    
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="36%" >
                                        職位 / 名銜 Position / title obtained
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="10%" >
                                       由 From (MM/YYYY)                                    
                                     </asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="10%" >
                                       至 To (MM/YYYY)            
                                    </asp:TableHeaderCell>
                                </asp:TableHeaderRow>
                            </asp:Table>
                          </div>
                 </div>
          <br />
          <div class="form-group row" >
                  <div class="col-12">
	                    <span class="H4">專業及其他資格 Professional / Other Qualifications</span><br />	       
	              </div>     
          </div>
          <div class="form-group row" >
              <div class="table-responsive col-12">
                            <asp:Table ID="qualiTable" runat ="server" CssClass="mytable2" >                                 
                                <asp:TableHeaderRow ID="TableHeaderRow4" TableSection="TableHeader" runat="server">
                                     <asp:TableHeaderCell Width="40%" >
                                        機構/院校名稱 Name of organization / institute 
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="40%" >
                                        考獲名銜 Title obtained
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="20%" >
                                       獲取年份 Year obtained (YYYY)
                                    </asp:TableHeaderCell>
                                </asp:TableHeaderRow>
                            </asp:Table>   
                          </div>
                  </div>
          <br />
          <div class="form-group row" >
                  <div class="col-12">
	                    <span class="H4">工作經驗 Employment History</span><br />	       
	              </div>     
          </div>
          <div class="form-group row" >
              <div class="table-responsive col-12">
                            <asp:Table ID="jobTable" runat ="server" CssClass="mytable2" >                                 
                                <asp:TableHeaderRow ID="TableHeaderRow5" TableSection="TableHeader" runat="server">
                                    <asp:TableHeaderCell Width="30%" >
                                        公司名稱 Company name  
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="20%" >
                                        職位 Position
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="10%" >
                                       由 From (MM/YYYY)                                    
                                     </asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="10%" >
                                       至 To (MM/YYYY)            
                                    </asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="30%" >
                                       最近/最後薪金 Current/ latest salary (HKD$)        
                                    </asp:TableHeaderCell>
                                </asp:TableHeaderRow>
                            </asp:Table>        
                          </div>
                  </div>
          <br />
          <div class="form-group row" >
                  <div class="col-12">
	                    <span class="H4">語言能力 Language</span><br />	       
	              </div>     
          </div>
          <div class="form-group row" runat="server" id="div_Lang">
   
           </div>
          <br />
          <div class="form-group row" >
                  <div class="col-12">
	                    <span class="H4">電腦軟件 Computer Software</span><br />	       
	              </div>     
          </div>
          <div class="form-group row" runat="server" id="div_Sw">
            
           </div>
          <br />
          <div class="form-group row" >
                  <div class="col-12">
	                    <span class="H4">其他 Others</span><br />	       
	              </div>     
          </div>
          <div class="form-group row" >
                  <div class="col-4">
	                     <asp:Label ID ="Label8" >要求待遇 Expected salary (HKD$)</asp:Label>    
	              </div>     
                  <div class="col-8">
	                     <asp:Label ID ="lbl_sal" runat="server"></asp:Label>    
	              </div>     
          </div>
          <div class="form-group row" >
                  <div class="col-4">
	                     <asp:Label ID ="Label9" >最早到職日期 Earliest available date</asp:Label>    
	              </div>     
                  <div class="col-8">
	                     <asp:Label ID ="lbl_ead" runat="server"></asp:Label>    
	              </div>     
          </div>
          <div class="form-group row" >
                  <div class="col-4">
	                     <asp:Label ID ="Label10" >閣下是否需要工作簽証才能在香港工作? Do you need a working visa in HK?</asp:Label>    
	              </div>     
                  <div class="col-8">
	                     <asp:Label ID ="lbl_workingvisa" runat="server"></asp:Label>    
	              </div>     
          </div>
          <div class="form-group row" >
                  <div class="col-4">
	                     <asp:Label ID ="Label11" >從何得悉空缺 Knew vacancy through</asp:Label>    
	              </div>     
                  <div class="col-8">
	                     <asp:Label ID ="lbl_knowfrom" runat="server"></asp:Label>    
	              </div>     
          </div>
          <br />
          <div class="form-group row" >
                  <div class="col-12">
	                    <span class="H4">已上載的文件 Uploaded documents</span><br />	       
	              </div>     
          </div>
          <div class="form-group row" runat="server" id="div_Files">
            
          </div>
          </div>
        </form>
    <br />