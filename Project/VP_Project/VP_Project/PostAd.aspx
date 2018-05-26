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

    <section>

    </section>
	<div class="submit-ad main-grid-border">
		<div class="container">
			<h2 class="w3-head">Post an Ad</h2>
			<div class="post-ad-form">
				<form>
					<label>Select Brand<span>*</span></label>
                    <asp:DropDownList ID="brand" runat="server" >
                        <asp:ListItem Selected="True">Apple</asp:ListItem>
                        <asp:ListItem>Samsung</asp:ListItem>
                        <asp:ListItem>LG</asp:ListItem>
                    </asp:DropDownList>
					<div class="clearfix"></div>
					<label>Ad Title <span>*</span></label>
                    <asp:TextBox ID="adTitle" type="text" placeholder="Enter Ad Title" required="" runat="server"></asp:TextBox>

					<div class="clearfix"></div>
					<label>Ad Description <span>*</span></label>
                    <textarea id="TextArea1" cols="20" rows="2" class="mess" placeholder="Write few lines about your product" required="" runat="server" ></textarea>

					<div class="clearfix"></div>
				<div class="upload-ad-photos">
				<label>Photo for your ad :</label>	
					<div class="photos-upload-view">
						<form id="upload" enctype="multipart/form-data">

						<input type="hidden" id="MAX_FILE_SIZE" name="MAX_FILE_SIZE" value="300000" />

						<div>
							<input type="file" id="fileselect" name="fileselect[]" multiple="multiple" />
							<div id="filedrag">or drop files here</div>
						</div>

						<div id="submitbutton">
							<button type="submit">Upload Files</button>
						</div>

						</form>

						<div id="messages">
						<p>Status Messages</p>
						</div>
						</div>
					<div class="clearfix"></div>
						<script src="js/filedrag.js"></script>
				</div>
					<div class="personal-details">
					<form>
						<label>Product Price <span>*</span></label>
                        <asp:TextBox ID="productPrice" type="text" placeholder="Enter Price (PKR)" required="" runat="server"></asp:TextBox>

						<div class="clearfix"></div>
						<label>Product Condition<span>*</span></label>
                        <asp:TextBox ID="condition" type="text" placeholder="Describe Product Condition In 1 Word" required="" runat="server"></asp:TextBox>

						<div class="clearfix"></div>
						<label>Location<span>*</span></label>
                        <asp:TextBox ID="location" type="text" placeholder="Enter Location" required="" runat="server"></asp:TextBox>

						<div class="clearfix"></div>
						<p class="post-terms">By clicking <strong>post Button</strong> you accept our <a href="terms.html" target="_blank">Terms of Use </a> and <a href="privacy.html" target="_blank">Privacy Policy</a></p>
                        <asp:Button ID="postAdButton" type="submit" runat="server" Text="Post" OnClick="postAdButton_Click" />	
					<div class="clearfix"></div>
					</form>
					</div>
			</div>
		</div>	
	</div>
	<!-- // Submit Ad -->
</asp:Content>
