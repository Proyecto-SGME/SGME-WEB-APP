<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmCreaTipoUsuario.aspx.cs" Inherits="SMVM_1.view.Formularios_Usuarios.frmCreaTipoUsuario" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%---------------------------------------------%>
    <section class="content">
        <!-- Default box -->
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">CREA TIPO DE USUARIOS</h3>
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
                        <label>Ingresa Nombre Tipo Usuario</label>
                        <div>
                            <asp:TextBox ID="txtTipoUsuario" runat="server" Width="300px" class="form-control btn-group" placeholder="Tipo Usuario" required MaxLength="15"></asp:TextBox>
                        </div>
                    </div>
                    <div class="box-footer">
                        <asp:Button ID="btnRegistrar" runat="server" class="btn btn-group btn-primary" Text="Registrar" OnClick="btnRegistrar_Click1" />
                    </div>

                    <div id="ListadoTiposUsuarios" runat="server" class="box-body no-padding">
                            </div>
                </div>

                <!--Fin Contenido de la pagina-->
            </div>
        </div>
    </section>
    <%----------------------------------------------%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>
