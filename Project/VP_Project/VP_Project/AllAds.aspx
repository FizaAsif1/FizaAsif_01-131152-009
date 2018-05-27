<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterpage.Master" AutoEventWireup="true" CodeBehind="AllAds.aspx.cs" Inherits="VP_Project.AllAds" EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    All Classified Ads
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="searchBar" runat="server">
    <asp:TextBox ID="searchTextBox" type="text" placeholder="Search Product" runat="server"></asp:TextBox>
    <asp:Button ID="searchButton" runat="server" Text="Search"  type="submit" class="btn btn-default" aria-label="Left Align" OnClick="searchButton_Click" />
		<i class="fa fa-search" aria-hidden="true"> </i>
</asp:Content>


<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="server">
    <!-- breadcrumbs -->
	<div class="w3layouts-breadcrumbs text-center">
		<div class="container">
			<span class="agile-breadcrumbs"><a href="home.aspx"><i class="fa fa-home home_1"></i></a> / <span>All Ads</span></span>
		</div>
	</div>
	<!-- //breadcrumbs -->
	<!-- Products -->
	<div class="total-ads main-grid-border">
		<div class="container">
			<div class="select-box">
				<div class="select-city-for-local-ads ads-list">
					<label>Select your city to see local ads</label>
						<asp:DropDownList ID="locationList" DataTextField="city" runat="server" Width="200" OnSelectedIndexChanged="locationList_SelectedIndexChanged">
                        </asp:DropDownList>
				</div>

				<div class="search-product ads-list">
					<label>Search for a specific product</label>
					<div class="search">
						<div id="custom-search-input">
						<div class="input-group">
							<input type="text" class="form-control input-lg" placeholder="Buscar" />
							<span class="input-group-btn">
								<button class="btn btn-info btn-lg" type="button">
									<i class="glyphicon glyphicon-search"></i>
								</button>
							</span>
						</div>
					</div>
					</div>
				</div>
				<div class="clearfix"></div>
			</div>
			
			<div class="ads-grid">
				<div class="side-bar col-md-3">
					<div class="search-hotel">
					<h3 class="agileits-sear-head">Name contains</h3>
					<form>
						<input type="text" value="Product name..." onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Product name...';}" >
						<input type="submit" value=" ">
					</form>
				</div>
				
				
							
				</div>
				<div class="w3-brand-select">
					<h3 class="agileits-sear-head">Brand name</h3>
					  <select class="selectpicker" data-live-search="true">
					  <option data-tokens="All">All</option>
					  <option data-tokens="Asus">Asus</option>
					  <option data-tokens="Black Berry">Black Berry</option>
					  <option data-tokens="HTC">HTC</option>
					  <option data-tokens="Intex">Intex</option>
					  <option data-tokens="iPhone">iPhone</option>
					  <option data-tokens="Karbonn">Karbonn</option>
					  <option data-tokens="Lava">Lava</option>
					  <option data-tokens="Lenovo">Lenovo</option>
					  <option data-tokens="LG">LG</option>
					  <option data-tokens="Mi">Mi</option>
					  <option data-tokens="Micromax">Micromax</option>
					  <option data-tokens="Motorola">Motorola</option>
					  <option data-tokens="Nokia">Nokia</option>
					  <option data-tokens="Samsung">Samsung</option>
					  <option data-tokens="Sony">Sony</option>
					  <option data-tokens="Other Mobiles">Other Mobiles</option>
					</select>
				</div>
				
				</div>
				<div class="agileinfo-ads-display col-md-9">
					<div class="wrapper">					
					<div class="bs-example bs-example-tabs" role="tabpanel" data-example-id="togglable-tabs">
					  <ul id="myTab" class="nav nav-tabs nav-tabs-responsive" role="tablist">
						<li role="presentation" class="active">
						  <a href="#home" id="home-tab" role="tab" data-toggle="tab" aria-controls="home" aria-expanded="true">
							<span class="text">All Ads</span>
						  </a>
						</li>
											  </ul>
					  <div id="myTabContent" class="tab-content">
						<div role="tabpanel" class="tab-pane fade in active" id="home" aria-labelledby="home-tab">
						   <div>
												<div id="container">
								<div class="view-controls-list" id="viewcontrols">
									<label>view :</label>
										<a class="listview active"><i class="glyphicon glyphicon-th-list"></i></a>
								</div>
								<div class="sort">
								   <div class="sort-by">
										
									   </div>
									 </div>
								<div class="clearfix"></div>
						<ul class="list">


                            <!--data from server side-->

                            <asp:ListView ID="mobileList" runat="server">
                            <ItemTemplate>
								<a href="SingleItem.aspx?image="<%#Eval("id")%> ">
									<li> 
									<img src="<%# Eval("image") %>" title="" alt="" />
									<section class="list-left">
									<h5 class="title"><%# Eval("name") %></h5>
									<span class="adprice"><%# Eval("price") %> PKR</span>
									<p class="catpath">Mobile Phones » <%# Eval("brand") %></p>
									</section>
									<section class="list-right">
									<span class="date"><%# Eval("date") %></span>
									<span class="cityname"><%# Eval("location") %></span>
									</section>
									<div class="clearfix"></div>
									</li> 
								</a>

                            </ItemTemplate>
                            </asp:ListView>
								
							</ul>
						</div>
							</div>
						</div>
						
						
					  </div>
					</div>
				</div>
				</div>
				<div class="clearfix"></div>
			</div>
		</div>	
	</div>
	<!-- // Products -->
</asp:Content>
