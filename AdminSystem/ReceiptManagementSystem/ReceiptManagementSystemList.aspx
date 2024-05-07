<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceiptManagementSystemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
	    <link href="css/main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
<div class="receipt-content">
    <div class="container bootstrap snippets bootdey">
        <div class="row">
            <div class="col-md-12">
                <div class="invoice-wrapper">
                    <div class="intro">
                        Hi <strong>John McClane</strong>, 
						<br>
                        This is the receipt for a payment of <strong>$312.00</strong> (USD) for your works
                    </div>

                    <div class="payment-info">
                        <div class="row">
                            <div class="col-sm-6">
                                <span>Payment No.</span>
                                <strong>434334343</strong>
                            </div>
                            <div class="col-sm-6 text-right">
                                <span>Payment Date</span>
                                <strong>Jul 09, 2014 - 12:20 pm</strong>
                            </div>
                        </div>
                    </div>

                    <div class="payment-details">
                        <div class="row">
                            <div class="col-sm-6">
                                <span>Client</span>
                                <strong>Andres felipe posada
                                </strong>
                                <p>
                                    989 5th Avenue
                                    <br>
                                    City of monterrey
                                    <br>
                                    55839
                                    <br>
                                    USA
                                    <br>
                                    <a href="#">jonnydeff@gmail.com
                                    </a>
                                </p>
                            </div>
                            <div class="col-sm-6 text-right">
                                <span>Payment To</span>
                                <strong>Juan fernando arias
                                </strong>
                                <p>
                                    344 9th Avenue
                                    <br>
                                    San Francisco
                                    <br>
                                    99383
                                    <br>
                                    USA
                                    <br>
                                    <a href="#">juanfer@gmail.com
                                    </a>
                                </p>
                            </div>
                        </div>
                    </div>

                    <div class="line-items">
                        <table class="table table-borderless">
                          <thead>
                            <tr>
                              <th scope="col">#</th>
                              <th scope="col">Description</th>
                              <th scope="col">Quantity</th>
                              <th scope="col">Amount</th>
                            </tr>
                          </thead>
                          <tbody>
                            <tr>
                              <th scope="row">1</th>
                              <td>Mark</td>
                              <td>Otto</td>
                              <td>@mdo</td>
                            </tr>
                            <tr>
                              <th scope="row">2</th>
                              <td>Jacob</td>
                              <td>Thornton</td>
                              <td>@fat</td>
                            </tr>
                            <tr>
                              <th scope="row">3</th>
                              <td colspan="2">Larry the Bird</td>
                              <td>@twitter</td>
                            </tr>
                          </tbody>
                        </table>
                        <div class="total text-right">
                            <p class="extra-notes">
                                <strong>Extra Notes</strong>
                                Please send all items at the same time to shipping address by next week.
								Thanks a lot.
                            </p>
                            <div class="field">
                                Subtotal <span>$379.00</span>
                            </div>
                            <div class="field">
                                Shipping <span>$0.00</span>
                            </div>
                            <div class="field">
                                Discount <span>4.5%</span>
                            </div>
                            <div class="field grand-total">
                                Total <span>$312.00</span>
                            </div>
                        </div>

                        <div class="print">
                            <a href="#">
                                <i class="fa fa-print"></i>
                                Print this receipt
                            </a>
                        </div>
                    </div>
                </div>

                <div class="footer">
                    Copyright © 2014. company name
                </div>
            </div>
        </div>
    </div>
</div>     
    </form>
    	<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
