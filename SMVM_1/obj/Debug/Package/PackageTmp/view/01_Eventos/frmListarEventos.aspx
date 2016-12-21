<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmListarEventos.aspx.cs" Inherits="SMVM_1.view._01_Eventos.frmListarEventos" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%---------------------------------------------%>
    <section class="content">
        <!-- Default box -->
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">LISTAR EVENTOS</h3>
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
                            <label>Seleccione Estado de Eventos</label>
                            <asp:DropDownList ID="ddlEstatoEvento" runat="server" Width="300px" class="form-control"  AutoPostBack="True" OnSelectedIndexChanged="ddlEstatoEvento_SelectedIndexChanged" ></asp:DropDownList>
                        </div>
                    </div>


                    <div id="ListarEventos" runat="server" class="box-body no-padding">
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
