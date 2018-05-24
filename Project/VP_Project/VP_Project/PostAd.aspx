<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterpage.Master" AutoEventWireup="true" CodeBehind="PostAd.aspx.cs" Inherits="VP_Project.PostAd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Post Ad
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <!-- breadcrumbs -->
	<div class="w3layouts-breadcrumbs text-center">
		<div class="container">
			<span class="agile-breadcrumbs"><a href="index.html"><i class="fa fa-home home_1"></i></a> / <span>Post your Ad</span></span>
		</div>
	</div>
	<!-- //breadcrumbs -->
	<!-- Submit Ad -->
<%--    <!-- sign up form -->
	 <section>
		<div id="agileits-sign-in-page" class="sign-in-wrapper">
			<div class="agileinfo_signin">
			<h3>Sign Up</h3>
				<form action="#" method="post">
                    <asp:TextBox ID="txtName" type="text" name="Name" placeholder="Your Name" required="" runat="server"></asp:TextBox>
					<asp:TextBox ID="txtEmail" type="email" name="Email" placeholder="Your Email" required="" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtTel" type="tel" name="tel" placeholder="Mobile" required="" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtPassword" type="password" name="Password" placeholder="Password" required="" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtPasswordConfirm" type="password" name="Password" placeholder="Confirm Password" required="" runat="server"></asp:TextBox>
                    <asp:Button ID="btnSignup" runat="server" Text="Sign Up" value="Sign Up" OnClick="btnSignup_Click" />
				</form>
			</div>
		</div>
	</section>
	<!-- //sign up form -->--%>
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
				<label>Photos for your ad :</label>	
					<div class="photos-upload-view">
						<form id="upload" action="index.html" method="POST" enctype="multipart/form-data">

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
					<input type="submit" value="Post">					
					<div class="clearfix"></div>
					</form>
					</div>
			</div>
		</div>	
	</div>
	<!-- // Submit Ad -->
</asp:Content>
