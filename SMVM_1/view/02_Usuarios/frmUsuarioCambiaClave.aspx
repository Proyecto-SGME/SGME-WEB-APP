<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmUsuarioCambiaClave.aspx.cs" Inherits="SMVM_1.view.Formularios_Usuarios.frmUsuarioActualiza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%---------------------------------------------%>
    <section class="content">
        <!-- Default box -->
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">CAMBIA CLAVE</h3>
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
                        <label>Seleccione Usuario</label>
                        <asp:DropDownList ID="ddlUsuario" runat="server" Width="300px" class="form-control"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                                <label>Password</label>
                                <asp:TextBox ID="txtPw" runat="server" Width="300px" class="form-control" placeholder="Password ..." MaxLength="20" type="password" required></asp:TextBox>
                            </div>
                    <div class="form-group">
                                <label>Repite Password</label>
                                <asp:TextBox ID="txtPwRepite" runat="server" Width="300px" class="form-control" placeholder="Password ..." MaxLength="20" type="password" required></asp:TextBox>
                            </div>


                    <div class="box-footer">
                        <asp:Button ID="btnRegistrar" runat="server" class="btn btn-group btn-primary" Text="Registrar" OnClick="btnRegistrar_Click" />
                    </div>
                    <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red" ></asp:Label>

                </div>



                <!--Fin Contenido de la pagina-->
            </div>
        </div>
    </section>
    <%----------------------------------------------%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>
