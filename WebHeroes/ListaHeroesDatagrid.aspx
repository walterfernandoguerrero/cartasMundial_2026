<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaHeroesDatagrid.aspx.cs" Inherits="WebHeroes.ListaHeroresDatagrid" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .tarjeta{
           position: absolute; 
           top: 0; 
           left: 0; 
           width: 100%;
           height: 100%; object-fit: contain; /* Cambiado a contain para no cortar nada */
           object-position: center;
        }
                   
    </style>
    <h1>Lista de Cartas Heroes con datagrid</h1>
    <br />
    <div class="row">
        <div class="col-6">
            <asp:Label ID="lblFiltro" runat="server" Text="FILTRO POR NOMBRE:"></asp:Label>
            <asp:TextBox ID="txtFiltro" runat="server" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtFiltro_TextChanged"  ></asp:TextBox>
        </div>
        <div class="col-10">
            <asp:CheckBox Text="Filtro Avanzado" runat="server" ID="checkFiltro" OnCheckedChanged="checkFiltro_CheckedChanged" AutoPostback="true" />
        </div>
    </div>
    <br />
    <%--filtro avanzado--%>
        <%if (FiltroAvanzado)
          { %>
                <div class="row" style="background-color:cornsilk; border-radius:3%">
                    <div class ="col-3">
                        <div = "mb-3">
                            <asp:Label Text="Campo:" ID="ddlCampo" runat="server" />
                            <asp:DropDownList runat="server" CssClass="form-control">
                                <asp:ListItem Text="Nombre" />
                                <asp:ListItem Text="Tipo" />
                                <asp:ListItem Text="Número" />
                            </asp:DropDownList>

                        </div>
                    </div>
                    <div class="col-3" >   
                        <div class="mb-3">   
                            <asp:Label Text="Criterio" runat="server" />
                            <asp:DropDownList runat="server" ID="ddlCriterio" CssClass="form-control"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-3" >   
                        <div class="mb-3">   
                            <asp:Label Text="Filtro" runat="server" />
                            <asp:TextBox runat="server" ID="txtFiltroAvanzado" CssClass="form-control" />
                        </div>
                    </div>
                    <div class="col-3" >   
                        <div class="mb-3">   
                            <asp:Label Text="Estado" runat="server" />
                            <asp:DropDownList runat="server" ID="ddlEstado" CssClass="form-control">
                                <asp:ListItem Text="Todos" />
                                <asp:ListItem Text="Activo" />
                                <asp:ListItem Text="Inactivo" />
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class ="col-3">
                            <div class="mb-3">
                                <asp:Button Text="Buscar" runat="server" CssClass="btn btn-primary"  ID="btnBuscar"/>
                            </div>
                        </div>
                    </div>
                </div>
        <%} %>
    <br />
    <br />

    <asp:GridView ID="dgvHeroes" runat="server" AutoGenerateColumns="false"
        CssClass="table" DataKeyNames="Id" OnSelectedIndexChanged="dgvHeroes_SelectedIndexChanged"
        OnPageIndexChanging="dgvHeroes_PageIndexChanging" AllowPaging="true" PageSize="4">
        <Columns >
            <asp:BoundField HeaderText="Codigo" DataField="Codigo" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Peleas Ganadas" DataField="PeleasGanadas" />

            <asp:CommandField HeaderText="ACCION" ShowSelectButton="true" SelectText="< ✍ >" />
        </Columns>   
    </asp:GridView>
    <a href="DetalleHeroe.aspx" class="btn btn-primary">Agregar Heroe</a>


    <%--desde aca la tarjeta--%>

   <div class="container mt-5">
      
       <%--probar buscador--%>
              <div class="container mt-4">
                <div class="row justify-content-center">
                    <div class="col-md-6">
                        <div class="input-group mb-3 shadow-sm">
                            <span class="input-group-text bg-primary text-white border-0">
                                <i class="bi bi-search"></i>
                            </span>
                            <input type="text" id="txtBuscador" class="form-control border-0" 
                                   placeholder="Buscar héroe por nombre..." 
                                   onkeyup="filtrarHeroes()">
                        </div>
                    </div>
                </div>
            </div>

       <%--fin buscador--%>

    <h2 class="mb-4">Lista de Cartas Heroes</h2>
    
    <div class="row row-cols-1 row-cols-md-3 row-cols-lg-4 g-4">
        <% foreach (Modelo.SuperHeroe heroe in listaHeroes) { %>
            <div class="col heroe-item">
                <div class="card h-100 shadow-sm border-0">
                    
                    <div class="d-flex align-items-center justify-content-center bg-light" 
                         style="height: 200px; overflow: hidden; border-radius: 15px 15px 0 0;">
                        <img src="<%: heroe.UrlImagen %>" 
                             class="img-fluid" 
                             alt="<%: heroe.Nombre %>" 
                             style="max-height: 100%; object-fit: contain;">
                    </div>
                    
                    <div class="card-body pt-3">
                        <div class="d-flex justify-content-between align-items-start mb-2">
                            <h5 class="card-title fw-bold mb-0 heroe-nombre"><%: heroe.Nombre %></h5>
                            <span class="badge bg-dark"><%: heroe.Codigo %></span>
                        </div>
                        <div class="row">
                            <div class="col-6">
                                <p class="text-muted small mb-3">ID: #<%: heroe.Id %></p>
                            </div>
                            <div class="col-6">
                                 <p class="text-muted small mb-3">Peso (Kgs):<%: heroe.Peso %></p>
                            </div>
                        </div>
                      
                        <div class="row g-2 text-center">
                            <div class="col-6">
                                <div class="p-2 border rounded bg-light" style="font-size: 0.85rem;">
                                    <small class="d-block text-muted">Fuerza</small>
                                    <strong><%: heroe.Fuerza %></strong>
                                </div>
                            </div>
                            <div class="col-6">
                                <div class="p-2 border rounded bg-light" style="font-size: 0.85rem;">
                                    <small class="d-block text-muted">Velocidad</small>
                                    <strong><%: heroe.Velocidad %></strong>
                                </div>
                            </div>
                            <div class="col-6 mt-2">
                                <div class="p-2 border rounded bg-light" style="font-size: 0.85rem;">
                                    <small class="d-block text-muted">Altura</small>
                                    <strong><%: heroe.Altura %> m</strong>
                                </div>
                            </div>
                            <div class="col-6 mt-2">
                                <div class="p-2 border rounded bg-light text-success" style="font-size: 0.85rem;">
                                    <small class="d-block text-muted">Victorias</small>
                                    <strong><%: heroe.PeleasGanadas %></strong>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="card-footer bg-white border-0 pb-3">
                        <a href="DetalleHeroe.aspx?id=<%: heroe.Id %>" class="btn btn-primary w-100 rounded-pill shadow-sm">
                            Ver Carta
                        </a>
                    </div>
                </div>
            </div>
        <% } %>
    </div>

       <%-- 2. El Script de magia --%>
        <script>
            function filtrarHeroes() {
                let filtro = document.getElementById('txtBuscador').value.toLowerCase();
                let tarjetas = document.getElementsByClassName('heroe-item');

                for (let i = 0; i < tarjetas.length; i++) {
                    let nombre = tarjetas[i].querySelector('.heroe-nombre').innerText.toLowerCase();
                    // Si el nombre contiene lo que escribimos, se muestra, si no, se oculta
                    tarjetas[i].style.display = nombre.includes(filtro) ? "" : "none";
                }
            }
        </script>


 </div>


</asp:Content>
