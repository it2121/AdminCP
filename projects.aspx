<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="projects.aspx.cs" Inherits="foody.projects" %>
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
         <div class="col-md-5">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Projects</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                            <img width="100px" src="imgs/project.png" />
                           
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-12">
                         ID <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-2" ID="TextBox1" runat="server" placeholder=" ID" BackColor="White" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                              <asp:LinkButton class="btn btn-dark" ID="LinkButton4" runat="server" OnClick="LinkButton4_Click" ><i class="fas fa-check-circle"></i></asp:LinkButton>
                           </div>
                        </div>
                     </div>
                    
                  </div>
                   <div class="row">

                           <div class="col-md-12">
                        <label>Project</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-1" ID="TextBox2" runat="server" placeholder="Project" ReadOnly="false" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                               
                           </div>
                        </div>
                     </div>


                   </div>
              
            
                
                 <hr />
                  <div class="row">
               
                                           <div class="col-6 mx-auto">                                                 <asp:Button ID="Button2" class="btn btn-lg btn-block  btn-success" runat="server" Text="Add" OnClick="Button2_Click1"   />
</div>
                                           <div class="col-6 mx-auto">                                                 <asp:Button ID="Button4" class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button4_Click"   />
</div>
                                        
                  
                  </div>
                   <hr />
                     <div class="row">
                     <div class="col-12">
                        <div class="form-group">
                                    
                                  <asp:Button ID="Button1" class=" btn btn-lg btn-block btn-danger" runat="server" Text="Delete Permanently" OnClick="Button1_Click"   />

                      </div>
                     </div>
                  </div>
               </div>
            </div>
             <br>
            <br>
         </div>
         <div class="col-md-7">
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
                        <asp:GridView class="table table-striped table-bordered table-hover" ID="GridView1" runat="server"></asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>
</asp:Content>
