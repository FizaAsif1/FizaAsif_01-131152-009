<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterpage.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="VP_Project.Signup"  EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Sign-Up
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="searchBar" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="server">
    <!-- sign up form -->
	 <section>
		<div id="agileits-sign-in-page" class="sign-in-wrapper">
			<div class="agileinfo_signin">
			<h3>Sign Up</h3>
				
                    <asp:TextBox ID="txtName" type="text" name="Name" placeholder="Your Name" required="" runat="server"></asp:TextBox>
					<asp:TextBox ID="txtEmail" type="email" name="Email" placeholder="Your Email" required="" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtTel" type="tel" name="tel" placeholder="Mobile" required="" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtPassword" type="password" name="Password" placeholder="Password" required="" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtPasswordConfirm" type="password" name="Password" placeholder="Confirm Password" required="" runat="server"></asp:TextBox>
                    <asp:Button ID="btnSignup" runat="server" Text="Sign Up" value="Sign Up" OnClick="btnSignup_Click" />
				
			</div>
		</div>
	</section>
	<!-- //sign up form -->
</asp:Content>
