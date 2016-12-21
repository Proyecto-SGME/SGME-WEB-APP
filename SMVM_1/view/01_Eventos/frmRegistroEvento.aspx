<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmRegistroEvento.aspx.cs" Inherits="SMVM_1.view.frmRegistroEvento"  EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content">
        <!-- Default box -->
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">REGISTRO DE EVENTOS</h3>
                <div class="box-tools pull-right">
                    <button type="button" class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip" title="Collapse">
                        <i class="fa fa-minus"></i>
                    </button>
                </div>
            </div>
            <div class="box-body">
            <!--Aqui iria el Contenido de la pagina-->
                <div class="box box-warning">
                    <!--Texto-->
                    <div class="form-group">
                        <label>Seleccione Cliente</label>
                        <asp:DropDownList ID="ddlCliente" runat="server" Width="300px" class="form-control" ></asp:DropDownList>
                    </div>
                    <!-- select -->
                    <div class="form-group">
                        <label>Tipo Evento</label>
                        <asp:DropDownList ID="ddlTipoEvento" runat="server" Width="300px" class="form-control"></asp:DropDownList>
                    </div>
                    <!-- Aqui debe cargar las ubicaciones y al seleccionar debe mostrar en el ddlMaquina las maquinas de esa ubicacion -->
                    <div class="form-group">
                        <label>Ubicación</label>
                        <asp:DropDownList ID="ddlUbicacion" runat="server" Width="300px" class="form-control" OnSelectedIndexChanged="ddlUbicacion_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>Maquina</label>
                        <asp:DropDownList ID="ddlMaquina" runat="server" Width="300px" class="form-control"></asp:DropDownList>
                    </div>
                    <!-- textarea -->
                    <div class="form-group">
                        <label>Detalle Evento</label>
                        <textarea id="txtDetalle" runat="server" class="form-control" rows="3" placeholder="Enter ..." required></textarea>
                    </div>
                    <div class="box-footer">
                        <asp:Button ID="btnAgregar" runat="server" class="btn btn-primary" Text="Ingresar" OnClick="btnAgregar_Click" />
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
