<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmCreaMaquina.aspx.cs" Inherits="SMVM_1.view.Formularios_Maquinas.frmCreaMaquina" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%---------------------------------------------%>
    <section class="content">
        <!-- Default box -->
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">CREA MAQUINAS NUEVAS</h3>
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
                        <label>Seleccione Marca</label>
                        <asp:DropDownList ID="ddlMarca" runat="server" Width="300px" class="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlMarca_SelectedIndexChanged" ></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>Seleccione Modelo</label>
                        <asp:DropDownList ID="ddlModelo" runat="server" Width="300px" class="form-control"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>Ingresa Numero de Serie</label>
                        <div>
                            <asp:TextBox ID="txtNumeroSerie" runat="server" Width="300px" class="form-control btn-group" placeholder="Ingrese Serie" MaxLength="20"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label>Fecha de Fabricación</label>

                        <div class="input-group">
                            <div class="input-group-addon">
                                <i class="fa fa-calendar"></i>
                            </div>
                            <asp:TextBox ID="txtFechaFabri" runat="server" Width="260px" class="form-control" data-inputmask="'alias': 'dd/mm/yyyy'" data-mask></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="box-footer">
                    <asp:Button ID="btnRegistrar" runat="server" class="btn btn-group btn-primary" Text="Registrar"/>
                </div>
            </div>
            <!--Fin-->
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
