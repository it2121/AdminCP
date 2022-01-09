<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="reportsView.aspx.cs" Inherits="foody.reportsView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <script type="text/javascript">
      $(document).ready(function () {
      
          $(document).ready(function () {
              $('#Gridview1').DataTable();
          });
        
          $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
         $('.table1').DataTable();
      }); 
        </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid ">
      <div class="row">
         <div class="col-md-12">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Reports</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                            <img width="100px" src="imgs/evaluation.png" />
                       
                        </center>
                         <div class="col-md-12">
                            <hr />
                           <br />
                        </div>
                     </div>
                  </div>
                   
                         

                  <div class="row">
                        
           
                   <div class="col-md-6">
                                            
                        
                        <div class="form-group form-check">



                                <label class="form-check-label" for="flexCheckDefault">
                           From
                                     </label>

                         
                   
                                  
                           <asp:TextBox CssClass="form-control" ID="dateFrom" runat="server" placeholder="Start Date" TextMode="Date"></asp:TextBox>
                        </div>
                     </div>
                      
                   <div class="col-md-6">
                                            

                        <div class="form-group form-check">
                                                        <asp:CheckBox class="form-check-input" ID="FromToChB" runat="server" OnCheckedChanged="OnOffFromToDate" AutoPostBack="true"/>

                                <label class="form-check-label" for="flexCheckDefault">
                            To
                                     </label>

                         
                   
                                  
                           <asp:TextBox CssClass="form-control" ID="dateTo" runat="server" placeholder="Start Date" TextMode="Date"></asp:TextBox>
                        </div>
                      
                     </div>
                                         <div class="col-md-12">

                       <hr />
                                       </div>

                  </div>
             <div class="row">
                 

                   <div class="col-md-12">
                                            

                        <div class="form-group form-check">
                            <asp:CheckBox class="form-check-input" ID="DateChB" runat="server" OnCheckedChanged="OnOffDate" AutoPostBack="true"/>
                                <label class="form-check-label" for="flexCheckDefault">
                            By Day
                                     </label>

                         
                   
                                  
                           <asp:TextBox CssClass="form-control" ID="date" runat="server" placeholder="Start Date" TextMode="Date"></asp:TextBox>
                        </div>
                     </div>
                   
                     
                  </div>



                       <div class="row">
                 


                     <div class="col-md-6">
                                            
                         <div class="form-group form-check">
                            <asp:CheckBox class="form-check-input" ID="projectCHB" runat="server" OnCheckedChanged="OnOffPRO" AutoPostBack="true"/>
                             <label class="form-check-label" for="flexCheckDefault">
                                   By Project
                                     </label>
                           <asp:DropDownList class="form-control" ID="projectDDL" runat="server">
                              <asp:ListItem Text=" 1" Value=" 1" />
                              <asp:ListItem Text=" 2" Value=" 2" />
                           </asp:DropDownList>
                        </div>
                        
                     </div>

                           <div class="col-md-6">
                                            
                         <div class="form-group form-check">
                            <asp:CheckBox class="form-check-input" ID="locationsCHB" runat="server" OnCheckedChanged="OnOffLOC" AutoPostBack="true"/>
                             <label class="form-check-label" for="flexCheckDefault">
                                By Location


                             </label>
                           <asp:DropDownList class="form-control" ID="locationsDDL" runat="server">
                              <asp:ListItem Text=" 1" Value=" 1" />
                              <asp:ListItem Text=" 2" Value=" 2" />
                           </asp:DropDownList>
                        </div>
                        
                     </div>
                     
                  </div>
           
                        <div class="row">
                 


                     <div class="col-md-6">
                                            
                         <div class="form-group form-check">
                            <asp:CheckBox class="form-check-input" ID="superNameCHB" runat="server" OnCheckedChanged="OnOffSUPER" AutoPostBack="true"/>
                             <label class="form-check-label" for="flexCheckDefault">
                                   By Supervisor
                                     </label>
                           <asp:DropDownList class="form-control" ID="superNameDDL" runat="server">
                              <asp:ListItem Text=" 1" Value=" 1" />
                              <asp:ListItem Text=" 2" Value=" 2" />
                           </asp:DropDownList>
                        </div>
                        
                     </div>

                           <div class="col-md-6">
                                            
                         <div class="form-group form-check">
                            <asp:CheckBox class="form-check-input" ID="empNameCHB" runat="server" OnCheckedChanged="OnOffEMP" AutoPostBack="true"/>
                             <label class="form-check-label" for="flexCheckDefault">
                                  By Employee
                                     </label>
                           <asp:DropDownList class="form-control" ID="empNameDDL" runat="server">
                              <asp:ListItem Text=" 1" Value=" 1" />
                              <asp:ListItem Text=" 2" Value=" 2" />
                           </asp:DropDownList>
                        </div>
                        
                     </div>
                     
                  </div>                     
                                        
                  
                
                   <hr />
                     <div class="row">
                     <div class="col-10">
                        <div class="form-group">
                                    
                                  <asp:Button ID="Button1" class=" btn btn-lg btn-block btn-primary" runat="server" Text="Apply" OnClick="Button1_Click"   />
                                                            
                      </div>
                     </div>
                          <div class="col-2">
                        <div class="form-group">
                                    
                                                            
                              <asp:Button ID="Button3" class=" btn btn-lg btn-block btn-dark" runat="server" Text="Export" OnClick="Export_Click"   />
                      </div>
                     </div>
                  </div>
               </div>
            
            </div>
           
            <br>
         </div>
         <div class="col-md-12">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>List</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col ">
                         
                           
                        <asp:GridView class="table table-striped table-bordered table-responsive table-hover" style="" Font-Size="0.8em" ID="GridView1" runat="server">



                            </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
     </div>

</asp:Content>
