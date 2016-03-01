<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BootstrapASP.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
   <div class="control-group"> 
       <asp:Label ID="Label1" runat="server" Text="Identity Number"></asp:Label>
   <div class="controls">
       <asp:TextBox id="txtId" MaxLength="13" runat="server"></asp:TextBox>
   </div> 
</div> 
<div class="control-group"> 
   <div class="controls"> 
       <asp:Button runat="server" id="btnValidate" Text="Validate" OnClick="btnValidate_Click"/>
       
       <br/>
       
       <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
   </div> 
</div>
</asp:Content>
