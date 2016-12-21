<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmReportesTecnicos.aspx.cs" Inherits="SMVM_1.view._00_Metricas.frmReportesTecnicos" EnableEventValidation="false"%>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%---------------------------------------------%>
    <section class="content">
        <!-- Default box -->
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">CANTIDAD DE RUTAS ASIGNADAS POR TECNICO</h3>
                <div class="box-tools pull-right">
                    <button type="button" class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip" title="Collapse">
                        <i class="fa fa-minus"></i>
                    </button>
                </div>
            </div>
            <div class="box-body">
                <!--Aqui iria el Contenido de la pagina-->
                   <div class="box box-warning">
                    <asp:Chart ID="Chart1" runat="server" Height="386px" Width="667px" CssClass="auto-style1" style="margin-right: 139px">
                        <Series>
                            <asp:Series Name="Series1" XValueMember="TÉCNICO" YValueMembers="CANTIDAD DE RUTAS"></asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1" Area3DStyle-Enable3D="true"></asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                    <div id="ListarTecnico" runat="server" class="box-body no-padding">
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
