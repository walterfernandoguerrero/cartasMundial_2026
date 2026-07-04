<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaAutos.aspx.cs" Inherits="WebHeroes.ListaAutos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col">
            <h1>LISTA DE AUTOS</h1>
            <div class="table-responsive">
                 <asp:GridView ID="dgvAutos" runat="server" CssClass="table table-dark table-bordered" AutoGenerateColumns="false" DataKeyNames="Id" OnSelectedIndexChanged="dgvAutos_SelectedIndexChanged">
                     <Columns>
                         <asp:BoundField  HeaderText="Modelo" DataField="Modelo"/>
                         <asp:BoundField  HeaderText="Descripcion" DataField="Descripcion"/>
                         <asp:BoundField  HeaderText="Color" DataField="Color"/>
                         <asp:CheckBoxField HeaderText="Usado" DataField="Usado" />
                         <asp:CommandField ShowSelectButton="true" SelectText="Capturar" HeaderText="Accion"  />
                     </Columns>
                 </asp:GridView>
            </div>
            <a href="AutoForm.aspx" class="btn btn-primary">Agregar</a>
        </div>
    </div>
    
  
</asp:Content>
