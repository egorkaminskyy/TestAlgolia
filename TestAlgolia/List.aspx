<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="List.aspx.cs" Inherits="TestAlgolia.List" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <header>
    <div>
       <input id="search-input" placeholder="Search for products">
       <!-- We use a specific placeholder in the input to guides users in their search. -->
    
  </header>
  <main>
      
      
  </main>

  <script type="text/html" id="hit-template">
    
      <p class="hit-name">{{{_highlightResult.Name.value}}} {{{_highlightResult.Prise.value}}}</p>
    
  </script>

  <script src="https://cdn.jsdelivr.net/instantsearch.js/1/instantsearch.min.js"></script>
  <script src="app.js"></script>
</asp:Content>

