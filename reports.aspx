<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="reports.aspx.cs" Inherits="foody.reports" %>
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
     <div class="container-fluid">
      <div class="row">
         <div class="col-md-12">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Reports Details</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                            <img width="100px" src="imgs/immigration.png" />
                           
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-2">
                        <label>ID</label>&nbsp;&nbsp;&nbsp;&nbsp;
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-2" ID="TextID" runat="server" placeholder="ID" BackColor="White" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                              <asp:LinkButton class="btn btn-dark" ID="LinkButton4" runat="server" OnClick="LinkButton4_Click" Width="16px" ><i class="fas fa-check-circle"></i></asp:LinkButton>
                           </div>
                        </div>
                     </div>
                     
                     <div class="col-md-5">
                        <label>Location</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-1" ID="TextLocation" runat="server" placeholder="Location" ReadOnly="false" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                               
                           </div>
                        </div>
                     </div>
                      <div class="col-md-5">
                        <label>Project</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-1" ID="TextProject" runat="server" placeholder="Project" ReadOnly="false" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                               
                           </div>
                        </div>
                       
                     </div>
                                        <div class="col-md-12">

                      <hr />
                                            </div>

                       <div class="col-md-6">
                        <label>Supervisor Name</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-1" ID="TextSuperName" runat="server" placeholder="Supervisor Name" ReadOnly="false" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                               
                           </div>
                        </div>
                     </div>
                      <div class="col-md-6">
                        <label>Employee Name</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-1" ID="TextEmpName" runat="server" placeholder="Employee Name" ReadOnly="false" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                               
                           </div>
                        </div>
                     </div>
                        <div class="col-md-12">
                        <hr />
                                           </div>

                       <div class="col-md-4">
                        <label>Date</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-1" ID="TextDate" runat="server" placeholder="Date" ReadOnly="false" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                               
                           </div>
                        </div>
                     </div>
                       <div class="col-md-4">
                        <label>Check in Time</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-1" ID="TextChIn" runat="server" placeholder="Check in Time" ReadOnly="false" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                               
                           </div>
                        </div>
                     </div>
                       <div class="col-md-4">
                        <label>Check out Time</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-1" ID="TextChOut" runat="server" placeholder="Check out Time" ReadOnly="false" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                               
                           </div>
                        </div>
                          
                     </div>
                      <div class="col-md-12">
                        <hr />
                                           </div>


                       <div class="col-md-3">
                        <label>Daily Wage</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-1" ID="TextDW" runat="server" placeholder="Daily Wage" ReadOnly="false" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                               
                           </div>
                        </div>
                     </div>
                       <div class="col-md-9">
                        <label>Long/Lat</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-1" ID="TextLongLat" runat="server" placeholder="Long/Lat" ReadOnly="false" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                               
                           </div>
                        </div>
                     </div>

                   
                  </div>
                   <div class="row">
                                                <div class="col-md-4"></div>

                         <div class="col-md-4">
                       
                        <div class="form-group">
                           <div class="input-group">
                               
                           </div>
                        </div>
                                                                             <div class="col-md-4"></div>

                     </div>


                   </div>
              
            
                      <div class="row">
                     <div class="col">
                        <center>
                           
                           <hr />
                        </center>
                     </div>
                  </div>
              
                  <div class="row">
               

  <div class="col-md-12">
          <asp:Button ID="Button4" class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button4_Click"   />
</div>
                                        
                </div>  
                  
                   <hr />
                     <div class="row">
                        
                       <div class="col-md-12">
                          
                        <div class="form-group">
                                  
                                                          <asp:Button ID="Button1" class=" btn btn-lg btn-block btn-danger" runat="server" Text="Delete Permanently" OnClick="Button1_Click"   />

                        

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
                     <div class="col">
                         
                           
                        <asp:GridView class="table table-striped table-bordered table-responsive table-hover" Font-Size="0.8em" ID="GridView1" runat="server">
                           

                            </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>
</asp:Content>
