<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmClientes.aspx.cs" Inherits="SMVM_1.view.frmClientes" EnableEventValidation="false" %>

<%@ Register Assembly="Tde.Controles.RutTextBox" Namespace="Tde.Controles" TagPrefix="tde" %>
  


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%---------------------------------------------%>
    <section class="content">
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">CREA CLIENTES</h3>
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
                        <asp:TextBox ID="txtRut" runat="server" Width="300px" class="form-control" placeholder="11.111.111-1" MaxLength="12"></asp:TextBox>
                    </div>
                    </br>
            <!-- Nombre Apellido Paterno y Materno-->
                    <div class="form-group">
                        <label>Ingresar Nombre</label>
                        <asp:TextBox ID="txtNombre" runat="server" Width="300px" class="form-control" placeholder="Nombre ..."></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Ingresar Apellido Paterno</label>
                        <asp:TextBox ID="txtPaterno" runat="server" Width="300px" class="form-control" placeholder="Apellido Paterno ..."></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Ingresar Apellido Materno</label>
                        <asp:TextBox ID="txtMaterno" runat="server" Width="300px" class="form-control" placeholder="Apellido Materno ..."></asp:TextBox>
                    </div>

                    <!-- Fecha de Nacimiento -->
                    <!-- Date dd/mm/yyyy -->
                    <div class="form-group">
                        <label>Fecha de Nacimiento</label>

                        <div class="input-group">
                            <div class="input-group-addon">
                                <i class="fa fa-calendar"></i>
                            </div>
                            <asp:TextBox ID="txtNacimiento" runat="server" Width="260px" class="form-control" data-inputmask="'alias': 'dd/mm/yyyy'" data-mask></asp:TextBox>
                        </div>
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

                    <div class="box-footer">
                        <asp:Button ID="btnAgregar" runat="server" class="btn btn-primary" Text="Registrar" OnClick="btnAgregar_Click" />
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
