<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleHeroe.aspx.cs" Inherits="WebHeroes.DetalleHeroe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        h3{
            color:palevioletred;
        }
    </style>

    <%--<asp:ScriptManager runat="server"  ID="ScripManager1"></asp:ScriptManager>/>--%>
    <div class="row" style="text-align:center;padding:10px">
        <h3>FORMULARIO HEROE</h3>
    </div>
    <div class="row" style="border:5px solid lightgray;border-radius:1%;padding:10px">  <%-- contenedor--%>
        <div class="col-6">   <%--contenedor DIV  de inputs--%>
            <%--cajas--%>
            <div class="mb-3"> 
                <label for="txtId" class="form-label">ID:</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtCodigo" class="form-label">Código:</label>
                <asp:TextBox runat="server" ID="txtCodigo" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre:</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
            </div>
           <%-- <div class="mb-3">
                <label for="txtUrlImagen" class="form-label">URL Imagen:</label>
                <asp:TextBox runat="server" ID="txtUrlImagen" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
            </div>--%>
            <div class="row">
                
                <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div class="mb-3"> <%-- align-items-end alinea la imagen con el input --%>
            
                        <%-- Contenedor del Input (ocupa la mayor parte) --%>
                        <div class="mb-3"> 
                            <label for="txtUrl" class="form-label">URL Imagen:</label>
                            <asp:TextBox runat="server" ID="txtUrl" CssClass="form-control" 
                                TextMode="Url" AutoPostBack="true" OnTextChanged="txtUrl_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-6 mb-3">
                            <asp:Button ID="btnUrl" runat="server" Text="Pre visualizar Imagen" CssClass="btn btn-info" OnClick="btnUrl_Click" />
                        </div>

                        <%-- Contenedor de la Previsualización (ocupa el resto) --%>
                        <div class="col-6 text-center">
                            <img src="<%= Imagen %>" 
                                 onerror="this.src='https://www.pulsecarshalton.co.uk/wp-content/uploads/2016/08/jk-placeholder-image.jpg'" 
                                 alt="Previsualización" 
                                 style="height: 200px; width: auto; border-radius: 5px; border: 1px solid #ddd;" />
                        </div>

                    </div>
                </ContentTemplate>
                </asp:UpdatePanel>
                <hr />
            </div>
        </div>
            <%-- Columna Derecha: Atributos y Estadísticas --%>
        <div class="col-6">
                <div class="row">
                    <div class="col-6 mb-3">
                        <label for="txtAltura" class="form-label">Altura (0,00):</label>
                        <asp:TextBox runat="server" ID="txtAltura" CssClass="form-control" Text="0,00"></asp:TextBox>
                    </div>
                    <div class="col-6 mb-3">
                        <label for="txtPeso" class="form-label">Peso (kg): </label>
                        <asp:TextBox runat="server" ID="txtPeso" CssClass="form-control" TextMode="Number" ></asp:TextBox>
                    </div>
                </div>

                <div class="mb-3">
                    <label for="txtFuerza" class="form-label">Fuerza:</label>
                    <asp:TextBox runat="server" ID="txtFuerza" CssClass="form-control" TextMode="Number"></asp:TextBox>
                </div>
        
                <div class="mb-3">
                    <label for="txtVelocidad" class="form-label">Velocidad:</label>
                    <asp:TextBox runat="server" ID="txtVelocidad" CssClass="form-control" TextMode="Number"></asp:TextBox>
                </div>

                <div class="mb-3">
                    <label for="txtPeleasGanadas" class="form-label">Peleas Ganadas:</label>
                    <asp:TextBox runat="server" ID="txtPeleasGanadas" CssClass="form-control" TextMode="Number"></asp:TextBox>
                </div>
                <hr />
                <div class="row">
                    <div class="col-6 mb-3">
                        <asp:Button ID="btnAccion" runat="server" Text="<Acción>" CssClass="btn btn-primary" OnClick="btnAccion_Click" />
                    </div>
                    <%if (botonBorrar)
                      {  %>
                            <div class="col-6 mb-3">
                                <asp:Button ID="btnBorrar" runat="server" Text="BORRAR HEROE" CssClass="btn btn-danger" OnClick="btnBorrar_Click" />
                            </div>
                    <%}%>

                </div>
                <%if (activarBorrado)
                  {  %>
                     <div class="row col-lg-8" style="background-color:lightcyan; border-radius:2%; border:2px solid lightgray; padding:6px" >
                         <asp:Label ID="lblBorrarHeroeOK" runat="server" Text=""></asp:Label>
                         <br /> <br />
                         <div class="col-6">
                             <div class="mb-3">
                                <asp:Button ID="btnCancelar" runat="server" Text="CANCELAR" CssClass="btn btn-info" OnClick="btnCancelar_Click"  />
                            </div>
                             <br />
                             <div class="mb-3">
                                    <asp:Button ID="btnEliminar" runat="server" Text="ELIMINAR" CssClass="btn btn-danger" OnClick="btnEliminar_Click"  />
                                </div>
                         </div>
                         
                     </div>
                <%}%>

          </div>

   </div>

    <br />
    <div class="col-6 mb-3">
       <button onclick="saludar()">SALUDAR</button>
    </div>
    <script>
        function saludar() {
            alert("hola chiques");
        }
    </script>

</asp:Content>
