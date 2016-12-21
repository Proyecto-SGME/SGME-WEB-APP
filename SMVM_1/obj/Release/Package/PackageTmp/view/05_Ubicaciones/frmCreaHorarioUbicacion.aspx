<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmCreaHorarioUbicacion.aspx.cs" Inherits="SMVM_1.view.Formularios_Direcciones.frmCreaHorarioUbicacion" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%---------------------------------------------%>
    <section class="content">
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">CREA LOS HORARIOS DE LAS UBICACIONES</h3>
                <div class="box-tools pull-right">
                    <button type="button" class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip" title="Collapse">
                        <i class="fa fa-minus"></i>
                    </button>
                </div>
            </div>
            <div class="box-body">
                <!--Aqui iria el Contenido de la pagina-->
                <div class="box box-warning">
                    <!-- time Picker -->
                    <div class="bootstrap-timepicker">

                        <div class="form-group">
                            <label>Horario Apertura</label>

                            <div class="input-group time">
                                <div class="input-group-addon"><i class="fa fa-clock-o"></i></div>
                                <asp:TextBox ID="txtApertura" runat="server" Width="150px" class="form-control timepicker"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <!--fin time Picker -->
                    <!-- Date -->
                    <div class="form-group">
                        <label>Date:</label>

                        <div class="input-group date">
                            <div class="input-group-addon">
                                <i class="fa fa-calendar"></i>
                            </div>
                            <input type="text" class="form-control pull-right" id="datepicker">
                        </div>
                        <!-- /.input group -->
                    </div>


                    <!-- /.box-body -->
                    <div class="box-footer">
                        <asp:Button ID="btnAgregar" runat="server" class="btn btn-primary" Text="Ingresar" />
                    </div>
                </div>
                <!--Fin-->
            </div>
        </div>
    </section>
    <%---------------------------------------------%>
</asp:Content>
<asp:Content ContentPlaceHolderID="ScriptContent" runat="server">
    <script type="text/javascript">
        inputmask();
        datepicker();
        timepicker();
    </script>
</asp:Content>
