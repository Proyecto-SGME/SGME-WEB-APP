<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmCrearMarcaModelo.aspx.cs" Inherits="SMVM_1.view.Formularios_Maquinas.frmCrearMarcaModelo" EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%---------------------------------------------%>
    <section class="content">
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">CREA MARCA DE MAQUINAS</h3>
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
                        <label>Ingresa Nombre de Marca</label>
                        <div>
                            <asp:TextBox ID="txtMarca" runat="server" Width="300px" class="form-control btn-group" placeholder="Tipo Usuario"  MaxLength="60"></asp:TextBox>
                        </div>
                    </div>
                    <div class="box-footer">
                        <asp:Button ID="btnRegistraMarca" runat="server" class="btn btn-group btn-primary" Text="Registrar" OnClick="btnRegistraMarca_Click" />
                    </div>

                    <div id="ListadoMarcas" runat="server" class="box-body no-padding">
                            </div>
                </div>



                <!--Fin-->
            </div>
        </div>
<%--    </section>


    <section class="content">--%>
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">CREA MODELOS DE MAQUINAS</h3>
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
                        <label>Selecciona Marca</label>
                        <div>
                            <asp:DropDownList ID="ddlMarca" runat="server" Width="300px" class="form-control btn-group"></asp:DropDownList>
                        </div>
                    </div>

                    <div class="form-group">
                        <label>Ingresa Nombre Modelo</label>
                        <div>
                            <asp:TextBox ID="txtModelo" runat="server" Width="300px" class="form-control btn-group" placeholder="Tipo Usuario" MaxLength="60"></asp:TextBox>
                        </div>
                    </div>
                    <div class="box-footer">
                        <asp:Button ID="btnRegistraModelo" runat="server" class="btn btn-group btn-primary" Text="Registrar" OnClick="btnRegistraModelo_Click" />
                    </div>

                    <div id="ListadoModelos" runat="server" class="box-body no-padding">
                            </div>
                </div>



                <!--Fin-->
            </div>
            <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        </div>
        
    </section>
    <%----------------------------------------------%>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>
