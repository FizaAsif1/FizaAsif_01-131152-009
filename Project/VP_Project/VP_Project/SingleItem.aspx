<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterpage.Master" AutoEventWireup="true" CodeBehind="SingleItem.aspx.cs" Inherits="VP_Project.SingleItem" EnableEventValidation="false" %>


<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Mobile View
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="searchBar" runat="server">
</asp:Content>


<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="server">
    <!-- breadcrumbs -->
	<div class="w3layouts-breadcrumbs text-center">
		<div class="container">
			<span class="agile-breadcrumbs">
			<a href="Home.aspx"><i class="fa fa-home home_1"></i></a> / 
			<a href="AllAds.aspx">All Ads</a> / 
			<span>Car name</span></span>
		</div>
	</div>
	<!-- //breadcrumbs -->
	<!--single-page-->
   
    

	<div class="single-page main-grid-border">
		<div class="container">
            <asp:ListView ID="ListView" runat="server">
             <ItemTemplate>
			<div class="product-desc">
				<div class="col-md-7 product-view">
                    
					<h2> <%# Eval("title") %> </h2>
                       
					<p> <i class="glyphicon glyphicon-map-marker"></i>City : <%# Eval("location") %>| Added on <%# Eval("date") %></p>

					<div class="flexslider">
						<ul class="slides">
							<li data-thumb="images/ss1.jpg">
								<img src="<%# Eval("image") %>" />
							</li>
						</ul>
					</div>
					<!-- FlexSlider -->
					  <script defer="defer" src="js/jquery.flexslider.js"></script>

						<script>
					// Can also be used with $(document).ready()
					$(window).load(function() {
					  $('.flexslider').flexslider({
						animation: "slide",
						controlNav: "thumbnails"
					  });
					});
					</script>
					<!-- //FlexSlider -->
					<div class="product-details">
						<h4><span class="w3layouts-agileinfo">Brand </span> : <%# Eval("brand") %><div class="clearfix"></div></h4>
						<h4><span class="w3layouts-agileinfo">Mobile Name </span> : <%# "name" %></h4>
						<h4><span class="w3layouts-agileinfo">Description</span> :<p><%# Eval("description") %></p><div class="clearfix"></div></h4>
					
					</div>
				</div>
				<div class="col-md-5 product-details-grid">
					<div class="item-price">
						<div class="product-price">
							<p class="p-price">Price</p>
							<h3 class="rate"><%# Eval("price") %> PKR</h3>
							<div class="clearfix"></div>
						</div>
						<div class="condition">
							<p class="p-price">Condition</p>
							<h4><%# Eval("condition") %></h4>
							<div class="clearfix"></div>
						</div>
						
					</div>
					<div class="interested text-center">
						<h4>Interested in this Ad?<small> Contact the Seller!</small></h4>
						<p><i class="glyphicon glyphicon-earphone"></i>0000</p>
					</div>
						<div class="tips">
						<h4>Safety Tips for Buyers</h4>
							<ol>
								<li>Meet At Safe Place.</li>
								<li>Check product before buying.</li>
								<li>Donot send money in advance.</li>	
							</ol>
						</div>
				</div>
                
			<div class="clearfix"></div>
			</div>
                 </ItemTemplate>
             </asp:ListView>   
		</div>
	</div>
        
	<!--//single-page-->
</asp:Content>
