<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterpage.Master" AutoEventWireup="true" CodeBehind="PostAd.aspx.cs" Inherits="VP_Project.PostAd" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Post Ad
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="searchBar" runat="server">
</asp:Content>


<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="server">
    <!-- breadcrumbs -->
	<div class="w3layouts-breadcrumbs text-center">
		<div class="container">
			<span class="agile-breadcrumbs"><a href="home.aspx"><i class="fa fa-home home_1"></i></a> / <span>Post your Ad</span></span>
		</div>
	</div>
	<!-- //breadcrumbs -->

	<!-- Submit Ad -->
	<div class="submit-ad main-grid-border">
		<div class="container">
			<h2 class="w3-head">Post an Ad</h2>
			<div class="post-ad-form">
                    <asp:DropDownList ID="mobileBrand" runat="server" >
                        <asp:ListItem Selected="True">Apple</asp:ListItem>
                        <asp:ListItem>Samsung</asp:ListItem>
                        <asp:ListItem>LG</asp:ListItem>
                    </asp:DropDownList>
                   <br></br>

                <div class="clearfix"></div>

                    <asp:TextBox ID="mobileName" type="text" placeholder="Enter Mobile Name" required="" runat="server"></asp:TextBox>

					<div class="clearfix"></div>
				
                    <asp:TextBox ID="adTitle" type="text" placeholder="Enter Ad Title" required="" runat="server"></asp:TextBox>
                    
					<div class="clearfix"></div>
				
                    <textarea id="adDescription" cols="20" rows="2" class="mess" placeholder="Write few lines about your product" required="" runat="server" ></textarea>
                     <div class="clearfix"></div>
              
					
				<div class="upload-ad-photos">
				
					<div class="photos-upload-view">
                        <asp:Label ID="upload" runat="server" Text="Select Image: "></asp:Label>
                        <asp:FileUpload ID="imageUpload" runat="server" />
                        <br />
				</div>
					<div class="personal-details">
					<form>
						
                        <asp:TextBox ID="productPrice" type="text" placeholder="Enter Price (PKR)" required="" runat="server"></asp:TextBox>

						<div class="clearfix"></div>
						
                        <asp:TextBox ID="productCondition" type="text" placeholder="Describe Product Condition In 1 Word" required="" runat="server"></asp:TextBox>

						<div class="clearfix"></div>

                        <asp:Label ID="locationLabel" runat="server" Text="Your Location"></asp:Label>

                            <asp:DropDownList ID="locationList" DataTextField="city" runat="server" Width="200">
                            </asp:DropDownList>


						<div class="clearfix"></div>
						<p class="post-terms">By clicking <strong>post Button</strong> you accept our <a href="#">Terms of Use </a> and <a href="#">Privacy Policy</a></p>
                        <asp:Button ID="postAdButton" type="submit" runat="server" Text="Post" OnClick="postAdButton_Click" />	
					<div class="clearfix"></div>

					</form>
					</div>
			</div>
		</div>	
	</div>
	<!-- // Submit Ad -->
</asp:Content>
