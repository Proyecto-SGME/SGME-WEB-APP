<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmCreaRuta.aspx.cs" Inherits="SMVM_1.view._03_Rutas.frmCreaRuta" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%---------------------------------------------%>
    <section class="content">
        <!-- Default box -->
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">ASIGNA RUTAS DE TRABAJO</h3>
                <div class="box-tools pull-right">
                    <button type="button" class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip" title="Collapse">
                        <i class="fa fa-minus"></i>
                    </button>
                </div>
            </div>
            <div class="box-body">
                <!--Aqui iria el Contenido de la pagina-->
                <div class="box box-warning">
                    <div class="form-group">
                        <label>Seleccione Evento Activo</label>
                        <asp:DropDownList ID="ddlEvento" runat="server" Width="300px" class="form-control" AutoPostBack="True"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>Seleccione Técnico</label>
                        <asp:DropDownList ID="ddlTecnico" runat="server" Width="300px" class="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlTecnico_SelectedIndexChanged"></asp:DropDownList>
                    </div>
                    <%--<div class="form-group">
                        <label>Detalle Evento</label>
                        <textarea id="txtDetalle" runat="server" class="form-control" rows="4" placeholder="Enter ..."></textarea>
                    </div>--%>
                    <div class="box-footer">
                        <asp:Button ID="btnAgregar" runat="server" class="btn btn-primary" Text="Ingresar" OnClick="btnAgregar_Click"/>
                    </div>
                    <div class="box">
                        <div class="box-header">
                            <h3 class="box-title">Detalles de Eventos por Técnico</h3>
                        </div>

                        <div id="ListadoRutasTecnicos" runat="server" class="box-body no-padding">
                        </div>
                    </div>
                  <%--  <div class="box-footer">
                        <asp:Button ID="btnCerrar" runat="server" class="btn btn-danger" Text="CERRAR EVENTO" />
                    </div>--%>
                </div>



                <!--Fin-->
            </div>
        </div>
    </section>
    <%----------------------------------------------%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>
