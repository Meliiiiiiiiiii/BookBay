<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceiptManagementSystemViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
       <div class="container">
            <div style="height:100vh"  class="row justify-content-center align-items-center">

                       <div  class="row align-items-center justify-content-center">
                           <div class="d-flex justify-content-end mb-3">
                              <asp:Button ID="createReceiptBtn" runat="server" CssClass="btn btn-dark fs-5 fw-medium" Text="Create" OnClick="createReceiptBtn_Click" />
                           </div>
                           <div class="shadow-lg p-3 rounded">
                                <table class="table table-borderless " >
                                                  <thead>
                                                    <tr>
                                                      <th scope="col">#</th>
                                                      <th scope="col">First</th>
                                                      <th scope="col">Last</th>
                                                      <th scope="col">Handle</th> 
                                                      <th scope="col">Action</th> 
                                                    </tr>
                                                  </thead>
                                                  <tbody id="tableBody" runat="server">
                                                    <tr>
                                                      <th scope="row">1</th>
                                                      <td>Mark</td>
                                                      <td>Otto</td>
                                                      <td>@mdo</td>
                                                    </tr>
                                                  </tbody> 
                               </table>
                           </div>              
                       </div>
                   </div>
       </div>
       
    </form>
</body>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</html>
