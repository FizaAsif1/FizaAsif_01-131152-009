<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterpage.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="VP_Project.SignIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Sign-In
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <!-- sign in form -->
	 <section>
		<div id="agileits-sign-in-page" class="sign-in-wrapper">
			<div class="agileinfo_signin">
			<h3>Sign In</h3>
				<form action="#" method="post">
                    <asp:TextBox ID="txtEmail" type="email" name="Email" placeholder="Your Email" required="" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtPassword" type="password" name="Password" placeholder="Password" required="" runat="server"></asp:TextBox>
					<asp:Button ID="btnSignin" runat="server" Text="Sign In" value="Sign In" OnClick="btnSignin_Click" />

					<div class="forgot-grid">
						
						
						<!-- Modal -->
						<%--<div class="modal fade" id="myModal2" role="dialog">
							<div class="modal-dialog">
							<!-- Modal content-->
							<div class="modal-dialog modal-lg">
								<div class="modal-content">
									<div class="modal-header">
										<button type="button" class="close" data-dismiss="modal">&times;</button>
										<h3 class="w3ls-password">Get Password</h3>		
										<p class="get-pw">Enter your email address below and we'll send you an email with instructions.</p>
										<form action="#" method="post">
											<input type="text" class="user" name="email" placeholder="Email" required="">
											<input type="submit" value="Submit">
										</form>
									</div>
								</div>
							</div>
							</div>
						</div>--%>
						<div class="clearfix"> </div>
					</div>
				</form>
				<h6> Not a Member Yet? <a href="Signup.aspx">Sign Up Now</a> </h6>
			</div>
		</div>
	</section>
	<!-- //sign in form -->
</asp:Content>
