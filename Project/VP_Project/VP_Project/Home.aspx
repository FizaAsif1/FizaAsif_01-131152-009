<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterpage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="VP_Project.Home" EnableEventValidation="false" %>


<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Home
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="searchBar" runat="server">
    <asp:TextBox ID="searchTextBox" type="text" placeholder="Search Product" runat="server"></asp:TextBox>
    <asp:Button ID="searchButton" runat="server" Text="Search"  type="submit" class="btn btn-default" aria-label="Left Align" OnClick="searchButton_Click" />
    
		<i class="fa fa-search" aria-hidden="true"> </i>
    

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="server">
    <!-- Slider -->
		<div class="slider">
			<ul class="rslides" id="slider">
				<li>
					<div class="w3ls-slide-text">
						<h3>Sell Mobiles Online</h3>
						<a href="AllAds.aspx" class="w3layouts-explore-all">Browse all Ads</a>
					</div>
				</li>
				
			</ul>
		</div>
		<!-- //Slider -->
		<!-- content-starts-here -->
		<div class="main-content">
											
			<div class="trending-ads">
				<div class="container">
				<!-- slider -->
				<div class="agile-trend-ads">
					<h2>Mobiles</h2>
							<ul id="flexiselDemo3">
                                
                                <asp:ListView ID="mobileList" runat="server">
                                <ItemTemplate>
								<li>
									<div class="col-md-3 biseller-column">
										<a href="SingleItem.aspx?id="<%#Eval("id")%> ">
											<img src="<%# Eval("image") %>" alt="" />
											<span class="price"><%# Eval("price") %> PKR</span>
										</a>
										<div class="w3-ad-info">
											<h5><%# Eval("name") %></h5>
											<span><%# Eval("date") %></span>
										</div>
									</div>
									
								</li>
                                </ItemTemplate>
                                </asp:ListView>
								
								
						</ul>
					</div>   
			</div>
			<!-- //slider -->				
			</div>
			<!--partners-->
			<div class="w3layouts-partners">
				<h3>Our Partners</h3>
					<div class="container">
						<ul>
							<li><a href="#"><img class="img-responsive" src="images/p-1.png" alt=""></a></li>
							<li><a href="#"><img class="img-responsive" src="images/p-2.png" alt=""></a></li>
							<li><a href="#"><img class="img-responsive" src="images/p-3.png" alt=""></a></li>
							<li><a href="#"><img class="img-responsive" src="images/p-4.png" alt=""></a></li>
							<li><a href="#"><img class="img-responsive" src="images/p-5.png" alt=""></a></li>
							<li><a href="#"><img class="img-responsive" src="images/p-6.png" alt=""></a></li>
							<li><a href="#"><img class="img-responsive" src="images/p-7.png" alt=""></a></li>
							<li><a href="#"><img class="img-responsive" src="images/p-8.png" alt=""></a></li>
							<li><a href="#"><img class="img-responsive" src="images/p-9.png" alt=""></a></li>
							<li><a href="#"><img class="img-responsive" src="images/p-10.png" alt=""></a></li>	
						</ul>
					</div>
				</div>	
		<!--//partners-->	
		<!-- mobile app -->
			<div class="agile-info-mobile-app">
				<div class="container">
					<div class="col-md-5 w3-app-left">
						<a href="mobileapp.html"><img src="images/app.png" alt=""></a>
					</div>
					<div class="col-md-7 w3-app-right">
						<h3>Resale App is the <span>Easiest</span> way for Selling and buying second-hand goods</h3>
						<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam auctor Sed bibendum varius euismod. Integer eget turpis sit amet lorem rutrum ullamcorper sed sed dui. vestibulum odio at elementum. Suspendisse et condimentum nibh.</p>
						<div class="agileits-dwld-app">
							<h6>Download The App : 
								<a href="#"><i class="fa fa-apple"></i></a>
								<a href="#"><i class="fa fa-windows"></i></a>
								<a href="#"><i class="fa fa-android"></i></a>
							</h6>
						</div>
					</div>
					<div class="clearfix"></div>
				</div>
			</div>
			<!-- //mobile app -->
		</div>
</asp:Content>
