using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Subgurim.Controles;
using GMaps;
using System.Configuration;
using System.Text;

namespace SMVM_1.view.Formularios_Direcciones
{
    public partial class frmCreaDireccion : System.Web.UI.Page
    {
        

        private void CargaBox(DropDownList control, int flag, int ddlFlag)
        {
            Bu_Direccion box = new Bu_Direccion();
            DataSet ds = box.CargarComboBox(flag, ddlFlag);
            control.DataSource = ds;
            control.DataTextField = "Nombre";
            control.DataValueField = "Codigo";
            control.DataBind();
            /*para mostrar los box se debe enviar los siguientes flag
             * 7-Region, 8-Ciudad, 9-Comuna
             */
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CargaBox(ddlRegion, 7, 0);
                    //GLatLng l = {-33.4498337,-70.6658478};
                    //CargarMapa("Región Metropolitana","Santiago","Santiago","Abdón Cifuentes, 115",l);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

       
        protected void ddlRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaBox(ddlProvincia, 8, Convert.ToInt32(ddlRegion.SelectedValue));
        }
        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaBox(ddlComuna, 9, Convert.ToInt32(ddlProvincia.SelectedValue));
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text!=""&&ddlRegion.SelectedValue!="0")
            {
                //GLatLng valor = coordenadas;
                Bu_Direccion r = new Bu_Direccion();
                Direcciones d = new Direcciones();
                d.comuna_id = Convert.ToInt32(ddlComuna.SelectedValue);
                d.direccion_des = hdDireccion.Value.ToString();
                //d.direccion_nro = 10;
                d.latitud = Convert.ToDouble(hdLatitud.Value);
                d.longitud = Convert.ToDouble(hdLongitud.Value);
                d.id_user = 16712750;

                r.RegistraDireccion(d);
                //
                limpiar();
            }
            else
            {
                Response.Write("<script language=javascript>alert('DEBES INGRESAR UNA DIRECCION\n ANTES DE REGISTRAR LA RIRECCIÓN');</script>");
            }
        }

        private void limpiar()
        {
            txtDireccion.Text = "";
            //txtNro.Text = "";
            ddlRegion.SelectedIndex = 0;
            ddlProvincia.SelectedIndex = 0;
            ddlComuna.SelectedIndex = 0;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDireccion.Text.Trim() != "" && ddlRegion.SelectedValue != "0")
                {
                    BuscarDireccion(txtDireccion.Text.Trim() + " " + ddlComuna.SelectedItem.Text + " " + ddlProvincia.SelectedItem.Text );
                }
                else
                {
                    Response.Write("<script language=javascript>alert('DEBES INGRESAR UNA DIRECCION');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert('"+ex.ToString()+"');</script>");
            }
            
        }

        private void BuscarDireccion(string datos)
        {
            string region, provincia, comuna;
            GLatLng coordenadas;
            if (!string.IsNullOrEmpty(datos))
            {
                string key = ConfigurationManager.AppSettings.Get("googlemaps.subgurim.net");
                GeoCode geocode = GMap.geoCodeRequest(datos, key, new GLatLngBounds(new GLatLng(40, 10), new GLatLng(50, 20)));
                try
                {
                    if ((null != geocode) && geocode.valid)
                    {
                        region = geocode.Placemark.AddressDetails.Country.AdministrativeArea.AdministrativeAreaName;
                        provincia = geocode.Placemark.AddressDetails.Country.AdministrativeArea.SubAdministrativeArea.SubAdministrativeAreaName;
                        comuna = geocode.Placemark.AddressDetails.Country.AdministrativeArea.SubAdministrativeArea.Locality.LocalityName;
                        hdDireccion.Value = geocode.Placemark.AddressDetails.Country.AdministrativeArea.SubAdministrativeArea.Locality.Thoroughfare.ThoroughfareName;
                        coordenadas = geocode.Placemark.coordinates;
                        
                        hdLatitud.Value = coordenadas.lat.ToString();
                        hdLongitud.Value = coordenadas.lng.ToString();
                        CargarMapa(region, provincia, comuna, hdDireccion.Value, coordenadas);
                    }
                    else
                    {
                        Response.Write("<script language=javascript>alert('DIRECCION INCORRECTA');</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script language=javascript>alert('" + ex.ToString() + "');</script>");
                }
            }
        }
        private void CargarMapa(string region, string provincia, string comuna, string direccion, GLatLng coordenadas)
        {
            
            //GLatLng ubicacion = new GLatLng(coordenadas);
            GMap1.setCenter(coordenadas, 15);
            GMap1.Height = 460;
            GMap1.Width = 560;
            //Adiciona el control de la parte izq superior (moverse, ampliar y reducir)
            GMap1.addControl(new GControl(GControl.preBuilt.LargeMapControl));
            //GControl.preBuilt.MapTypeControl: permite elegir un tipo de mapa y otro.
            GMap1.addControl(new GControl(GControl.preBuilt.MapTypeControl));
            //Pone la marca de gota de agua con el nombre de la ubicacion
            GMarker marker = new GMarker(coordenadas);
            string strMarker = "<div style='width: 185px; height: 100px'><b>" +
                "SGME_MAPS</b><br> " + region + "<br />" + comuna + ", " + provincia + "<br />" +
                ""+direccion+"</div>";
            GInfoWindow window = new GInfoWindow(marker, strMarker, true);
            GMap1.addInfoWindow(window);
            GMap1.enableHookMouseWheelToZoom = true;
            //Tipo de mapa a mostrar
            GMap1.mapType = GMapType.GTypes.Normal;
            //Moverse con el cursor del teclado
            GMap1.enableGKeyboardHandler = true;
            GMap1.ShowMapTypeControl = true;



            //GMap1.GZoom = 9;
            //GMap1.Add(new GControl(GControl.preBuilt.LargeMapControl));

            //GeoCoding geoCoding = new GeoCoding();

            //geoCoding.show = GeoCoding.ShowEnum.infowindow;
            //geoCoding.openedOnLoad = true;
            //geoCoding.errorText = "Not found";
            //geoCoding.buttonText = "Search";
            //geoCoding.infoText = "GeoCode";
            //geoCoding.baseCountryCode = "au"; // Search Newcastle, and you'll find it elsewhere...
            //// geoCoding.viewport = new GLatLngBounds(new GLatLng(44, 14), new GLatLng(46, 16));

            //geoCoding.showErrorCode = true;
            //GMap1.Add(geoCoding);

            //Con esto podemos definir el icono que se mostrara en la ubicacion
            //#region Crear Icono
            //GIcon iconPropio = new GIcon();
            //iconPropio.image = "../images/iconBuilding.png";
            //iconPropio.shadow = "../images/iconBuildingS.png";
            //iconPropio.iconSize = new GSize(32, 32);
            //iconPropio.shadowSize = new GSize(29, 16);
            //iconPropio.iconAnchor = new GPoint(10, 18);
            //iconPropio.infoWindowAnchor = new GPoint(10, 9);
            //#endregion
        }
     
        
    }
}