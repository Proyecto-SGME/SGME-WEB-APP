<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmCreaDireccion.aspx.cs" Inherits="SMVM_1.view.Formularios_Direcciones.frmCreaDireccion" EnableEventValidation="false"%>
<%@ Register Assembly="GMaps" Namespace="Subgurim.Controles" TagPrefix="cc" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

 <script type = "text/javascript">
     function Confirm() {
         var confirm_value = document.createElement("INPUT");
         confirm_value.type = "hidden";
         confirm_value.name = "confirm_value";
         if (confirm("ESTA SEGURO DE GUARDAR LA DIRECCIÓN?")) {
             confirm_value.value = "SI";
         } else {
             confirm_value.value = "NO";
         }
         document.forms[0].appendChild(confirm_value);
     }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%---------------------------------------------%>
    <section class="content">
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">CREA DIRECCIONES</h3>
                <div class="box-tools pull-right">
                    <button type="button" class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip" title="Collapse">
                        <i class="fa fa-minus"></i>
                    </button>
                </div>
            </div>
            <div class="box-body">
                <!--Aqui iria el Contenido de la pagina-->
                <table>
                    <td>
                        <div class="box box-warning">
                            
                            <div class="form-group">
                                <label>Seleccione Región</label>
                                <asp:DropDownList ID="ddlRegion" runat="server" Width="300px" class="form-control" OnSelectedIndexChanged="ddlRegion_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                            </div>

                            <div class="form-group">
                                <label>Seleccione Ciudad</label>
                                <asp:DropDownList ID="ddlProvincia" runat="server" Width="300px" class="form-control" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                            </div>

                            <div class="form-group">
                                <label>Seleccione Comuna</label>
                                <asp:DropDownList ID="ddlComuna" runat="server" Width="300px" class="form-control"></asp:DropDownList>
                            </div>
                            
                            <div class="form-group">
                                <label>Dirección</label>
                                <div>
                                    <asp:TextBox ID="txtDireccion" runat="server" Width="300px" class="form-control btn-group" placeholder="Ingrese Dirección ..."></asp:TextBox>
                                    <asp:Button ID="btnBuscar" runat="server" class="btn btn-primary" Text="Buscar" OnClick="btnBuscar_Click"/>
                                    <%--<asp:TextBox ID="txtNro" runat="server" Width="100px" class="form-control btn-group" placeholder="Nro ..."></asp:TextBox>--%>
                                </div>
                            </div>
                            <!-- /.box-body -->
                            <div class="box-footer">
                                <asp:Button ID="btnAgregar" runat="server" class="btn btn-primary" Text="Registrar" OnClick="btnAgregar_Click" />
                                
                                
                                
                            </div>

                        </div>
                    </td>
                    <td>
                        <div class="form-group">
                            <%--<strong><asp:Literal ID="lt_Texto" runat="server" meta:resourcekey="lt_TextoResource1"></asp:Literal></strong>
                            <asp:TextBox ID="tb_Buscar" runat="server"></asp:TextBox>
                            <asp:Button ID="bt_Buscar" runat="server" Text="Buscar" meta:resourcekey="bt_BuscarResource1" />
                                    </p>
                                    <p>
                            
                                    </p>--%>    
                            <cc:GMap ID="GMap1" runat="server" />
                            <asp:Label ID="lb_Buscar" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                        </div>
                        <%--<div class="form-group">
                                <label>Latitud</label>
                               <asp:TextBox ID="txtLatitud" runat="server" Width="300px" class="form-control" Enabled="false"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Longitud</label>
                               <asp:TextBox ID="txtLongitud" runat="server" Width="300px" class="form-control" Enabled="false"></asp:TextBox>
                            </div>--%>
                    </td>
                </table>
                <!--Fin-->
            </div>
        </div>
    </section>
    <%---------------------------------------------%>
    <asp:HiddenField ID="hdDireccion" runat="server" />
    <asp:HiddenField ID="hdLatitud" runat="server" />
    <asp:HiddenField ID="hdLongitud" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>
