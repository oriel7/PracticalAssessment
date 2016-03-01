<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BootstrapASP.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
   <div class="control-group"> 
   <label class="control-label" for="inputId">Identity Number</label> 
   <div class="controls">
       <input type="text" id="inputId"/> 
   </div> 
</div> 
<div class="control-group"> 
   <div class="controls"> 
     <button type="submit" class="btn">Validate</button> 
   </div> 
</div>
</asp:Content>
