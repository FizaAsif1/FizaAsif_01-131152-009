<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterpage.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="VP_Project.Signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Sign-Up
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <!-- sign up form -->
	 <section>
		<div id="agileits-sign-in-page" class="sign-in-wrapper">
			<div class="agileinfo_signin">
			<h3>Sign Up</h3>
				<form action="#" method="post">
					<input type="text" name="Name" placeholder="Your Name" required=""> 
					<input type="email" name="Email" placeholder="Your Email" required=""> 
					<input type="tel" name="tel" placeholder="Mobile" required=""> 
					<input type="password" name="Password" placeholder="Password" required=""> 
					<input type="password" name="Password" placeholder="Confirm Password" required=""> 
					<div class="signin-rit">
						<span class="agree-checkbox">
							<label class="checkbox"><input type="checkbox" name="checkbox">I agree to your <a class="w3layouts-t" href="terms.html" target="_blank">Terms of Use</a> and <a class="w3layouts-t" href="privacy.html" target="_blank">Privacy Policy</a></label>
						</span>
					</div>
					<input type="submit" value="Sign Up">
				</form>
			</div>
		</div>
	</section>
	<!-- //sign up form -->
</asp:Content>
