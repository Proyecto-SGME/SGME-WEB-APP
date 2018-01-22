<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmUsuarios.aspx.cs" Inherits="SMVM_1.view.frmUsuarios" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%---------------------------------------------%>
    <section class="content">
        <!-- Default box -->
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">CREA USUARIOS</h3>
                <div class="box-tools pull-right">
                    <button type="button" class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip" title="Collapse">
                        <i class="fa fa-minus"></i>
                    </button>
                </div>
            </div>
            <div class="box-body">
                <!--Aqui iria el Contenido de la pagina-->
                <div class="box box-warning">
                    <table id="t1" runat="server">
                    <tr>
                        <td>
                            <!--Rut y DV-->
                            <div class="form-group">
                                <label>Ingresa Rut</label>
                                <div>
                                    <asp:TextBox ID="txtRut" runat="server" Width="300px" class="form-control btn-group" placeholder="11.111.111-1" MaxLength="15" required></asp:TextBox>
                                    <%--<asp:Button ID="btnVerificar" runat="server" class="btn btn-group btn-default " Text="Verificar" />--%>
                                </div>

                            </div>
                        </td>
                        <td></td>
                        <td>
                            <div class="form-group">
                                <label>Usuario</label>
                                <asp:TextBox ID="txtUs" runat="server" Width="300px" class="form-control" placeholder="Usuario ..." MaxLength="20" required></asp:TextBox>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="form-group">
                                <label>Nombre</label>
                                <asp:TextBox ID="txtNombre" runat="server" Width="300px" class="form-control" placeholder="Nombre ..." MaxLength="50" required></asp:TextBox>
                            </div>
                        </td>
                        <td></td>
                        <td>
                            <div class="form-group">
                                <label>Password</label>
                                <asp:TextBox ID="txtPw" runat="server" Width="300px" class="form-control" placeholder="Password ..." MaxLength="20" type="password" required></asp:TextBox>
                            </div>
                        </td>
                    </tr>
                        <tr>
                            <td>
                            <div class="form-group">
                                <label>Apellido Paterno</label>
                                <asp:TextBox ID="txtPaterno" runat="server" Width="300px" class="form-control" placeholder="Apellido Paterno ..." MaxLength="50" required></asp:TextBox>
                            </div>
                            </td>
                            <td></td>
                            <td>
                                <div class="form-group">
                                        <label>Seleccione Tipo Usuario</label>
                                        <asp:DropDownList ID="ddlTipoUsuario" runat="server" Width="300px" class="form-control" AutoPostBack="True"></asp:DropDownList>
                                    </div>
                            </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div class="form-group">
                                    <label>Apelido Materno</label>
                                    <asp:TextBox ID="txtMaterno" runat="server" Width="300px" class="form-control" placeholder="Apellido Materno ..." MaxLength="50" required></asp:TextBox>
                                </div>
                            </td>
                            <td></td>
                            <td>
                                <%--Libre al lado del paterno--%>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div class="form-group">
                        <label>Fecha de Nacimiento</label>

                        <div class="input-group">
                            <div class="input-group-addon">
                                <i class="fa fa-calendar"></i>
                            </div>
                            <asp:TextBox ID="txtNacimiento" runat="server" Width="260px" class="form-control" data-inputmask="'alias': 'dd/mm/yyyy'" data-mask required></asp:TextBox>
                        </div>
                    </div>
                            </td>
                            <td></td>
                            <td>
                                <%--Libre al LAdo del MAterno--%>
                            </td>
                        </tr>
                        <tr>
                            <td>

                            </td>
                            <td>

                            </td>
                        </tr>
                       
                </table>
                  

                    <div class="box-footer">
                        <asp:Button ID="btnRegistrar" runat="server" class="btn btn-group btn-primary" Text="Registrar" OnClick="btnRegistrar_Click"/>
                    </div>
                </div>



                <!--Fin Contenido de la pagina-->
            </div>
        </div>
    </section>
    <%----------------------------------------------%>
</asp:Content>
<asp:Content ContentPlaceHolderID="ScriptContent" runat="server">
    <script type="text/javascript">
        inputmask();
    </script>
    
</asp:Content>