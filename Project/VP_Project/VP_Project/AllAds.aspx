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
						<asp:DropDownList ID="locationList" DataTextField="city" runat="server" Width="200" OnSelectedIndexChanged="locationList_SelectedIndexChanged" OnTextChanged="locationList_TextChanged">
                        </asp:DropDownList>
                    <asp:Button ID="searchByLocation" runat="server" Text="search" OnClick="searchByLocation_Click" />
				</div>

				
				<div class="clearfix"></div>
			</div>
			
			<div class="ads-grid">
				
				
				</div>
				<div class="agileinfo-ads-display col-md-12">
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
								<a href="singleitem.aspx?id="<%# Eval("id")%> ">
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
