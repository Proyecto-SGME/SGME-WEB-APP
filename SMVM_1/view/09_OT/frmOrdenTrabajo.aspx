﻿<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="frmOrdenTrabajo.aspx.cs" Inherits="SMVM_1.view._09_OT.frmOrdenCompra" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%---------------------------------------------%>
    <section class="content">
        <!-- Default box -->
        <div class="box">
            <div class="box-header with-border">
                <h3 class="box-title">CREA USUARIOS</h3>
                <div class="box-tools pull-right">
                    <button type="button" class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip" title="Collapse">
                        <i class="fa fa-minus"></i>
                    </button>
                </div>
            </div>
            <div class="box-body">
                <!--Aqui iria el Contenido de la pagina-->
                <div class="box box-warning">
                    <table id="t_cliente" runat="server">
                        <tr>
                            <td>
                                <div class="form-group">
                                    <label>Seleccione Empresa</label>
                                    <asp:DropDownList ID="ddlEmpresa" runat="server" Width="300px" class="form-control" OnSelectedIndexChanged="ddlEmpresa_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                                </div>
                            </td>
                            <td>
                                <div class="form-group">
                                    <label>Seleccione Contacto</label>
                                    <asp:DropDownList ID="ddlContacto" runat="server" Width="300px" class="form-control" ></asp:DropDownList>
                                </div>
                            </td>
                           
                        </tr>
                    </table>
                    <table id="t_cuerpo" runat="server">
                        <tr>
                            <td>
                                <!--Fecha de Trabajo-->
                                <div class="form-group">
                                    <label>Fecha de Trabajo</label>

                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <i class="fa fa-calendar"></i>
                                        </div>
                                        <asp:TextBox ID="txtFechaTrabajo" runat="server" Width="260px" class="form-control" data-inputmask="'alias': 'dd/mm/yyyy'" data-mask ></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td></td>
                            <td>
                                <%--Cantidad de Horas--%>
                                <div class="form-group">
                                    <label>Cantidad de Horas</label>
                                    <asp:TextBox ID="txtHH" runat="server" Width="300px" class="form-control" placeholder="Cantidad de Horas..." MaxLength="20" required></asp:TextBox>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>

                                <!--Hora de Inicio-->
                               <%-- <div class="form-group">
                                    <label>Hora de Inicio</label>

                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <i class="fa fa-calendar"></i>
                                        </div>
                                        <asp:TextBox ID="txtHoraInicio" runat="server" Width="260px" class="form-control" data-inputmask="'alias': 'dd/mm/yyyy'" data-mask required></asp:TextBox>
                                    </div>
                                </div>--%>

                                <!-- time Picker -->
                              <div class="bootstrap-timepicker">
                                <div class="form-group">
                                  <label>Hora de Inicio</label>

                                  <div class="input-group">
                                    <%--<input type="text" class="form-control timepicker">--%>
                                      <asp:TextBox ID="txtHoraInicio" runat="server" class="form-control timepicker" ></asp:TextBox>

                                    <div class="input-group-addon">
                                      <i class="fa fa-clock-o"></i>
                                    </div>
                                  </div>
                                  <!-- /.input group -->
                                </div>
                                <!-- /.form group -->
                              </div>


                            </td>
                            <td></td>
                            <td>
                                <!-- time Picker -->
                              <div class="bootstrap-timepicker">
                                <div class="form-group">
                                  <label>Hora de Termino</label>

                                  <div class="input-group">
                                    <%--<input type="text" class="form-control timepicker">--%>
                                      <asp:TextBox ID="txtHoraTermino" runat="server" class="form-control timepicker" ></asp:TextBox>

                                    <div class="input-group-addon">
                                      <i class="fa fa-clock-o"></i>
                                    </div>
                                  </div>
                                  <!-- /.input group -->
                                </div>
                                <!-- /.form group -->
                              </div>
                                <!--Hora de Termino-->
                                <%--<div class="form-group">
                                    <label>Hora de Termino</label>

                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <i class="fa fa-calendar"></i>
                                        </div>
                                        <asp:TextBox ID="txtHoraTermino" runat="server" Width="260px" class="form-control" data-inputmask="'alias': 'dd/mm/yyyy'" data-mask required></asp:TextBox>
                                    </div>
                                </div>--%>
                            </td>
                        </tr>
                       
                    </table>
                    <table id="t_detalle" runat="server">
                        <tr>
                            <td>
                                <!--Requerimiento-->
                                <div class="form-group">
                                    
                                    <div class="form-group">
                                        <label>Requerimiento</label>
                                        <textarea id="txtRequerimiento" runat="server" class="form-control" rows="3" placeholder="Enter ..." required></textarea>
                                    </div>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <!--Solución-->
                                <div class="form-group">
                                    <div class="form-group">
                                        <label>Solución</label>
                                        <textarea id="txtSolucion" runat="server" class="form-control" rows="3" placeholder="Enter ..." required></textarea>
                                    </div>
                                </div>

                            </td>
                        </tr>
                        
                    </table>



                    <div class="box-footer">
                        <%--<asp:Button ID="btnRegistrar" runat="server" class="btn btn-group btn-primary" Text="Registrar" OnClick="btnRegistrar_Click" />--%>
                        <asp:Button ID="btnRegistro" runat="server" class="btn btn-group btn-primary" Text="Registrar" OnClick="btnRegistro_Click" />
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
