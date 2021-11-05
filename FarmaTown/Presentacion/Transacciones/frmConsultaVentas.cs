﻿using FarmaTown.Logica;
using FarmaTown.Presentacion.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTown.Presentacion.Transacciones
{
    public partial class frmConsultaVentas : Form
    {
        Venta oVenta;
        Farmacia oFarmacia;
        Localidad oLocalidad;
        Empleado oEmpleado;
        ObraSocial oObraSocial;
        Usuario oUsuarioLogueado;
        public frmConsultaVentas(Usuario _oUsuarioLogueado)
        {
            InitializeComponent();
            oVenta = new Venta();
            oFarmacia = new Farmacia();
            oLocalidad = new Localidad();
            oEmpleado = new Empleado();
            oObraSocial = new ObraSocial();
            oUsuarioLogueado = _oUsuarioLogueado;
        }

        private void frmConsVentas_Load(object sender, EventArgs e)
        {
            this.dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            this.dtpFechaHasta.Value = DateTime.Today.AddDays(1);

            ComboBoxService.cargarCombo(this.cboFarmacias, oFarmacia.recuperarTodos()
                , "Nombre", "IdFarmacia");
            ComboBoxService.cargarCombo(this.cboLocalidades, oLocalidad.recuperarTodos()
                , "Nombre", "IdLocalidad");
            ComboBoxService.cargarCombo(this.cboEmpleados, oEmpleado.recuperarTodos()
                , "Nombre", "IdEmpleado");
            ComboBoxService.cargarCombo(this.cboObrasSociales, oObraSocial.recuperarTodos()
                , "Nombre", "IdOS");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /*
             * Inicializa los filtros del generador
             * del Reporte.
             */
            this.dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            this.dtpFechaHasta.Value = DateTime.Today;
            this.cboFarmacias.SelectedIndex = -1;
            this.cboLocalidades.SelectedIndex = -1;
            this.cboEmpleados.SelectedIndex = -1;
            this.cboObrasSociales.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int indexFarm = this.cboFarmacias.SelectedIndex;
            int indexLocalidad = this.cboLocalidades.SelectedIndex;
            int indexEmpleado = this.cboEmpleados.SelectedIndex;
            int indexObraSocial = this.cboObrasSociales.SelectedIndex;
            string fechaDesde = this.dtpFechaDesde.Value.ToString();
            string fechaHasta = this.dtpFechaHasta.Value.ToString();

            string idFarm;
            string idLocalidad;
            string idEmpleado;
            string idObraSocial;

            if (indexFarm == -1)
                idFarm = "-1";
            else
                idFarm = this.cboFarmacias.SelectedValue.ToString();

            if (indexLocalidad == -1)
                idLocalidad = "-1";
            else
                idLocalidad = this.cboLocalidades.SelectedValue.ToString();

            if (indexEmpleado == -1)
                idEmpleado = "-1";
            else
                idEmpleado = this.cboEmpleados.SelectedValue.ToString();

            if (indexObraSocial == -1)
                idObraSocial = "-1";
            else
                idObraSocial = this.cboObrasSociales.SelectedValue.ToString();

            if (validarCampos())
            {
                List<Venta> ventas = this.oVenta.recuperarVentasConParam(idFarm,
                    idLocalidad, idEmpleado, idObraSocial, fechaDesde, fechaHasta);
                this.cargarGrilla(this.dgvVentas, ventas);
            }
        }

        private bool validarCampos()
        {
            DateTime fechaDesde = this.dtpFechaDesde.Value;
            DateTime fechaHasta = this.dtpFechaHasta.Value;
            int indexFarmacia = this.cboFarmacias.SelectedIndex;
            int indexEmpleado = this.cboEmpleados.SelectedIndex;
            int indexLocalidad = this.cboLocalidades.SelectedIndex;
            int indexObraSocial = this.cboObrasSociales.SelectedIndex;

            if (fechaHasta < fechaDesde)
            {
                MessageBox.Show("La fecha hasta es mayor" +
                    "que la fecha desde.", "Información"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtpFechaDesde.Focus();
            }
            else if (indexFarmacia == -1
                && indexEmpleado == -1
                && indexLocalidad == -1
                && indexObraSocial == -1)
            {
                this.actualizar();
            }
            else
                return true;

            return false;
        }

        private void actualizar()
        {
            this.cargarGrilla(this.dgvVentas, oVenta.recuperarTodos());
            this.deshabilitarBotones();              
        }

        private void cargarGrilla(DataGridView dgv, List<Venta> lista)
        {
            /*
             * Carga la grilla con los datos necesarios
             */
            double total = 0;
            dgv.Rows.Clear();
            if (lista != null)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    foreach (DetalleVenta item in lista[i].Detalles)
                    {
                        total += item.Importe;    
                    }

                    dgv.Rows.Add(lista[i].IdVenta.ToString(),
                                lista[i].NroFactura.ToString(),
                                lista[i].FechaFactura.ToString(),
                                lista[i].Farmacia.Nombre.ToString(),
                                total,
                                lista[i].MedioPago.Nombre.ToString(),
                                lista[i].TipoFactura.Nombre.ToString(),
                                lista[i].ObraSocial.Nombre.ToString(),
                                lista[i].Empleado.Nombre.ToString(),
                                lista[i].Farmacia.Barrio.Localidad.Nombre.ToString());
                }
                dgv.ClearSelection();
            }
        }

        private void deshabilitarBotones()
        {
            /*
             * Deshabilita los botones cambiándoles
             * el color para que el usuario visualmente
             * lo vea
             */
            this.btnEliminar.Enabled = false;
            this.btnEliminar.BackColor = Color.Gray;
            this.lblAviso.Visible = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaVenta oFrmVentas = new frmAltaVenta(oUsuarioLogueado);
            oFrmVentas.ShowDialog();
        }
    }
}
