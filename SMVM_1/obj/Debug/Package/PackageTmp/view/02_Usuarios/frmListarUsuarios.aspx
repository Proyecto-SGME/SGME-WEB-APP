<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmListarUsuarios.aspx.cs" Inherits="SMVM_1.view._02_Usuarios.frmListarUsuarios" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%---------------------------------------------%>
    <section class="content">
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">LISTA USUARIIOS</h3>
                <div class="box-tools pull-right">
                    <button type="button" class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip" title="Collapse">
                        <i class="fa fa-minus"></i>
                    </button>
                </div>
            </div>
            <div class="box-body">
                <!--Aqui iria el Contenido de la pagina-->
                <%--<div class="box box-warning">

                <div class="box-footer">
                        <asp:Button ID="btnAgregar" runat="server" class="btn btn-primary" Text="Listar" OnClick="btnAgregar_Click"  />
                    </div>
                    </div>--%>

                    <div id="ListarUsuarios" runat="server" class="box-body no-padding">
                    </div>
                </div>
                <!--Fin-->
            </div>
        </div>
    </section>

    <%----------------------------------------------%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>
