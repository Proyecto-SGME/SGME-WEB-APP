<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmDetalleEventos.aspx.cs" Inherits="SMVM_1.view._01_Eventos.frmDetalleEventos" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%---------------------------------------------%>
    <section class="content">
        <!-- Default box -->
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">REGISRO DETALLE DE EVENTOS</h3>
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
                            <label>Seleccione Eventos Activos</label>
                            <asp:DropDownList ID="ddlEvento" runat="server" Width="300px" class="form-control" OnSelectedIndexChanged="ddlEvento_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>Detalle Evento</label>
                            <textarea id="txtDetalle" runat="server" class="form-control" rows="4" placeholder="Enter ..."></textarea>
                        </div>
                        <div class="box-footer">
                            <asp:Button ID="btnAgregar" runat="server" class="btn btn-primary" Text="Ingresar" OnClick="btnAgregar_Click" />
                        </div>
                        <div class="box">
                            <div class="box-header">
                                <h3 class="box-title">Detalles de Eventos</h3>
                            </div>

                            <div id="ListadoDetalle" runat="server" class="box-body no-padding">
                            </div>
                        </div>
                        <div class="box-footer">
                            <asp:Button ID="btnCerrar" runat="server" class="btn btn-danger" Text="CERRAR EVENTO" OnClick="btnCerrar_Click" />
                        </div>
                </div>
                <%--FIN--%>
                <asp:HiddenField ID="valor" runat="server" />
            </div>
        </div>
    </section>
    <%----------------------------------------------%>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>
