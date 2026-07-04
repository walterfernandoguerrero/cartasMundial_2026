<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AutoForm.aspx.cs" Inherits="WebHeroes.AutoForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class ="row" style="margin:5%">
        <div class ="col-6">
            <div class ="mb-3">

                <label for="txtId" class="form-label" >Id:</label>
                 <asp:Label ID="lblId" runat="server" Text="ID automatico"></asp:Label>
                <asp:TextBox ID="txtId" runat="server" cssclass="form-control"/>
            </div>

            <div class ="mb-3">
                <label for="txtModelo" class="form-label" >Modelo:</label>
                <asp:TextBox ID="txtModelo" runat="server" cssclass="form-control"/>

            </div>
            <div class ="mb-3">
                <label for="txtDescripcion" class="form-label" >Descripcion:</label>
                <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" cssclass="form-control"/>

            </div>
            <div class ="mb-3">
                <label for="ddlColores" class="form-label" >Color:</label>
                <asp:DropDownList ID="ddlColores" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
             <div class ="mb-3">
                <label for="txtFecha" class="form-label" >Fecha de antiguedad:</label>
                <asp:TextBox ID="txtFecha" runat="server" TextMode="Date" cssclass="form-control"/>
            </div>
            <br />
            <div class="mb-3">
                <asp:CheckBox ID="ckbUsado" runat="server" />
                <asp:Label ID="lblUsado" runat="server" Text="Usado" ></asp:Label>
            </div>
            <br />
            <div class="mb-3">
                <asp:RadioButton ID="rdbImportado" runat="server" Text="Importado" GroupName="Nacionalidad" CssClass="radio-inline" />
                <asp:RadioButton ID="rdbNacional" runat="server" Text="Nacional" GroupName="Nacionalidad"  CssClass="radio-inline" />
            </div>
            <br />
            <div class="mb-3">
                <asp:Button ID="btnGrabar" runat="server" Text="Grabar" CssClass="btn-primary" OnClick="btnGrabar_Click" />
                <a href="Default.aspx" class="btn-link">Cancelar</a>
            </div>  
        </div>
    </div>


</asp:Content>
