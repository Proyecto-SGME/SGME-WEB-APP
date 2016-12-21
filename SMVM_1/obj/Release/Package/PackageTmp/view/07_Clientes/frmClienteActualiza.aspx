<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmClienteActualiza.aspx.cs" Inherits="SMVM_1.view.FormulariosClientes.frmClienteActualiza" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%---------------------------------------------%>
    <section class="content">
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">ELIMINA CLIENTES</h3>
                <div class="box-tools pull-right">
                    <button type="button" class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip" title="Collapse">
                        <i class="fa fa-minus"></i>
                    </button>
                </div>
            </div>
            <div class="box-body">
                <!--Aqui iria el Contenido de la pagina-->
                <div class="box box-warning">
                    <!--Rut y DV-->
                    <div class="form-group">
                        <label>Ingresa Rut</label>
                        <div>
                            <asp:TextBox ID="txtRut" runat="server" Width="300px" class="form-control btn-group" placeholder="11.111.111-1" MaxLength="12"></asp:TextBox>
                            <asp:Button ID="btnBuscar" runat="server" class="btn btn-group btn-default " Text="Verificar" OnClick="btnBuscar_Click" />
                        </div>

                    </div>
                    <!--Mostrar Nombre Apellido Paterno y Materno-->
                    <div class="form-group">
                        <label>Nombre Cliente</label>
                        <asp:TextBox ID="txtNombre" runat="server" Width="300px" class="form-control" placeholder="Nombre ..."></asp:TextBox>
                    </div>

                    <%--Datos Cliente Celular--%>
                    <div class="form-group">
                        <label>US phone mask:</label>

                        <div class="input-group">
                            <div class="input-group-addon">
                                <i class="fa fa-mobile-phone"></i>
                            </div>
                            <asp:TextBox ID="txtCelular" runat="server" Width="260px" class="form-control" data-inputmask='"mask": "(569) 9999-9999"' data-mask></asp:TextBox>
                        </div>
                    </div>

                    <%--Datos Cliente Telefono Fijo--%>
                    <div class="form-group">
                        <label>Telefono Fijo</label>

                        <div class="input-group">
                            <div class="input-group-addon">
                                <i class="fa fa-phone"></i>
                            </div>
                            <asp:TextBox ID="txtFijo" runat="server" Width="260px" class="form-control" data-inputmask='"mask": "(569) 9999-9999"' data-mask></asp:TextBox>
                        </div>
                    </div>

                    <%--Datos Cliente Email--%>
                    <div class="form-group">
                        <label>Email</label>
                        <asp:TextBox ID="txtEmail" runat="server" Width="300px" class="form-control" placeholder="Email ..."></asp:TextBox>
                    </div>

                    <!-- /.box-body -->
                    <div class="box-footer">
                        <%-- <asp:Button ID="btnActualizar" runat="server" class="btn btn-group btn-success" Text="Actualizar" />--%>
                        <%--</div>
            <div class="box-footer">--%>
                        <asp:Button ID="btnRegistrar" runat="server" class="btn btn-group btn-primary" Text="Registrar" OnClick="btnRegistrar_Click" />
                    </div>
                </div>
                <!--Fin-->
            </div>
        </div>
    </section>
    <%---------------------------------------------%>
</asp:Content>
<asp:Content ContentPlaceHolderID="ScriptContent" runat="server">
    <script type="text/javascript">
        inputmask();
    </script>
</asp:Content>
