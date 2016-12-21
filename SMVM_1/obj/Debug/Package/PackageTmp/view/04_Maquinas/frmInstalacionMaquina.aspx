<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmInstalacionMaquina.aspx.cs" Inherits="SMVM_1.view.Formularios_Maquinas.frmInstalacionMaquina" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <section class="content">
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">INSTALACION DE MAQUINAS</h3>
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
                        <label>Selecciona Ubicación</label>
                        <div>
                            <asp:DropDownList ID="ddlUbicacion" runat="server" Width="300px" class="form-control btn-group"></asp:DropDownList>
                        </div>
                    </div>

                    <div class="form-group">
                        <label>Selecciona Máquina</label>
                        <div>
                            <asp:DropDownList ID="ddlMaquina" runat="server" Width="300px" class="form-control btn-group"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="form-group">
                            <label>Detalle Instalación</label>
                            <textarea id="txtDetalle" runat="server" class="form-control" rows="4" placeholder="Enter ..." MaxLength="500"></textarea>
                        </div>
                    <div class="box-footer">
                        <asp:Button ID="btnRegistra" runat="server" class="btn btn-group btn-primary" Text="Registrar" OnClick="btnRegistra_Click" />
                    </div>

                    <div id="ListadoInstalaciones" runat="server" class="box-body no-padding">
                            </div>
                </div>



                <!--Fin-->
            </div>
        </div>
    </section>
    <%---------------------------------------------%>



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>
