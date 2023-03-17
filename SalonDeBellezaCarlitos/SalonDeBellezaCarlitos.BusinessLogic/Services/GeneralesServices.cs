using SalonDeBellezaCarlitos.DataAccess.Repository;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalonDeBellezaCarlitos.BusinessLogic.Services
{
    public class GeneralesServices
    {
        private readonly CargoRepository _CargoRepository;
        private readonly EmpleadoRepository _EmpleadoRepository;
        private readonly UsuarioRepository _UsuariosRepository;
        private readonly ServicioRepository _ServicioRepository;
        private readonly CategoriaRepository _CategoriaRepository;
        private readonly DepartametoRepository _DepartamentosRepository;
        private readonly MunicipioRepository _MunicipiosRepository;
        private readonly ClienteRepository _ClientesRepository;
        private readonly EstadoCivilRepository _EstadosCivilesRepository;
        private readonly SucursalesRepository _SucursalesRepository;
        private readonly ProductoRepository _ProductosRepository;
        private readonly ReservacionRepository _ReservacionRepository;
        private readonly FacturasRepository _FacturasRepository;
        private readonly MetodopagoRepositpory _MetodopagoRepository;
        private readonly ProveedorRepository _ProveedoresRepository;

        public GeneralesServices(CargoRepository CargoRepository,
                                    EmpleadoRepository EmpleadoRepository,
                                    UsuarioRepository usuarioRepository,
                                    ServicioRepository servicioRepository,
                                    CategoriaRepository categoriaRepository,
                                    DepartametoRepository departametoRepository,
                                    MunicipioRepository municipioRepository,
                                    ClienteRepository clienteRepository,
                                    EstadoCivilRepository estadoCivilRepository,
                                    SucursalesRepository sucursalesRepository,
                                    ProductoRepository productoRepository,
                                    ReservacionRepository reservacionRepository,
                                    FacturasRepository facturasRepository,
                                    MetodopagoRepositpory metodopagoRepositpory,
                                    ProveedorRepository proveedorRepository
            )
        {
            _CargoRepository = CargoRepository;
            _EmpleadoRepository = EmpleadoRepository;
            _UsuariosRepository = usuarioRepository;
            _ServicioRepository = servicioRepository;
            _CategoriaRepository = categoriaRepository;
            _DepartamentosRepository = departametoRepository;
            _MunicipiosRepository = municipioRepository;
            _ClientesRepository = clienteRepository;
            _EstadosCivilesRepository = estadoCivilRepository;
            _SucursalesRepository = sucursalesRepository;
            _ProductosRepository = productoRepository;
            _ReservacionRepository = reservacionRepository;
            _FacturasRepository = facturasRepository;
            _MetodopagoRepository = metodopagoRepositpory;
            _ProveedoresRepository = proveedorRepository;
        }


        #region Cargos

        public IEnumerable<tbCargos> ListadoCargos(out string error)
        {
            error = string.Empty;
            try
            {
                return _CargoRepository.List();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<tbCargos>();
            }
        }

        public int InsertarCargo(tbCargos item)
        {

            try
            {
                var resultado = _CargoRepository.Insert(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }


        public tbCargos BuscarCargo(int? id)
        {
            try
            {
                var resultado = _CargoRepository.find(id);

                return resultado;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public int EditarCargo(tbCargos categoria)
        {
           
            try
            {
                var resultado =  _CargoRepository.Update(categoria);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public int EliminarCargo(tbCargos categoria)
        {

            try
            {
                var resultado = _CargoRepository.Delete(categoria);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        #endregion

        #region Empleados

        public int EliminarEmpleado(tbEmpleados Empleado)
        {

            try
            {
                var resultado = _EmpleadoRepository.Delete(Empleado);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public IEnumerable<tbEmpleados> ListadoEmpleados(out string error)
        {
            error = string.Empty;
            try
            {
                return _EmpleadoRepository.List();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<tbEmpleados>();
            }
        }


        public tbEmpleados findEmpleado(int? id)
        {
            try
            {
                return _EmpleadoRepository.find(id);
            }
            catch (Exception)
            {
                return null;
            }
        }


        public int InsertarEmpleado(tbEmpleados item)
        {

            try
            {
                var resultado = _EmpleadoRepository.Insert(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public int EditarEmpleado(tbEmpleados item)
        {

            try
            {
                var resultado = _EmpleadoRepository.Update(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public IEnumerable<tbEmpleados> BuscarEmpleados(int? id) 
        {
            try
            {
                return _EmpleadoRepository.BuscarEmpleado(id);
            }
            catch (Exception)
            {
                return Enumerable.Empty<tbEmpleados>();
            }
        }

        #endregion

        #region Usuarios

        public tbUsuarios BuscarUsuario(int? id)
        {
            try
            {
                var resultado = _UsuariosRepository.find(id);

                return resultado;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<tbUsuarios> ListadoUsuarios(out string error)
        {
            error = string.Empty;
            try
            {
                return _UsuariosRepository.List();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<tbUsuarios>();
            }
        }

        #endregion

        #region Servicios

        public IEnumerable<tbServicios> ListadoServicios(out string error)
        {
            error = string.Empty;
            try
            {
                return _ServicioRepository.List();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<tbServicios>();
            }
        }
        public int InsertarServicio(tbServicios item)
        {

            try
            {
                var resultado = _ServicioRepository.Insert(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public int EditarServicio(tbServicios servicio)
        {

            try
            {
                var resultado = _ServicioRepository.Update(servicio);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public int EliminarServicio(tbServicios servicio)
        {

            try
            {
                var resultado = _ServicioRepository.Delete(servicio);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public IEnumerable<tbServicios> BuscarServicios(int? id)
        {
            try
            {
                return _ServicioRepository.BuscarServicio(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region Categorias

        public IEnumerable<tbCategorias> ListadoCategorias(out string error)
        {
            error = string.Empty;
            try
            {
                return _CategoriaRepository.List();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<tbCategorias>();
            }
        }

        public int InsertarCategoria(tbCategorias item)
        {

            try
            {
                var resultado = _CategoriaRepository.Insert(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public int EliminarCategoria(tbCategorias categorias)
        {

            try
            {
                var resultado = _CategoriaRepository.Delete(categorias);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        #endregion

        #region Departamentos

        public IEnumerable<tbDepartamentos> ListadoDepartamentos(out string error)
        {
            error = string.Empty;
            try
            {
                return _DepartamentosRepository.List();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<tbDepartamentos>();
            }
        }

        public int InsertarDepartamento(tbDepartamentos item)
        {

            try
            {
                var resultado = _DepartamentosRepository.Insert(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public int EditarDepartamento(tbDepartamentos departamentos)
        {
            try
            {
                var resultado = _DepartamentosRepository.Update(departamentos);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public IEnumerable<tbDepartamentos> BuscarDepartameto(int? id)
        {
            try
            {
                return _DepartamentosRepository.BuscarDepartamento(id);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int EliminarDepartamento(tbDepartamentos departamentos)
        {

            try
            {
                var resultado = _DepartamentosRepository.Delete(departamentos);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        #endregion

        #region Municipios

        public IEnumerable<tbMunicipios> ListadoMunicipios(out string error)
        {
            error = string.Empty;
            try
            {
                return _MunicipiosRepository.List();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<tbMunicipios>();
            }
        }
        public int InsertarMunicipio(tbMunicipios item)
        {

            try
            {
                var resultado = _MunicipiosRepository.Insert(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public IEnumerable<tbMunicipios> ListadoMunicipiosPorDepartamento(int id)
        {
            try
            {
                return _MunicipiosRepository.MunicipiosxDepartamento(id);
            }
            catch (Exception )
            {
                return Enumerable.Empty<tbMunicipios>();
            }
        }


        public tbMunicipios BuscarMunicipio(int? id)
        {
            try
            {
                var resultado = _MunicipiosRepository.find(id);

                return resultado;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region clientes

        public IEnumerable<tbClientes> ListadoClientes(out string error)
        {
            error = string.Empty;
            try
            {
                return _ClientesRepository.List();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<tbClientes>();
            }
        }
        public int InsertarCLientes(tbClientes item)
        {

            try
            {
                var resultado = _ClientesRepository.Insert(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        #endregion

        #region Estados Civiles

        public tbEstadosCiviles BuscarEstadoCivil(int? id)
        {
            try
            {
                var resultado = _EstadosCivilesRepository.find(id);

                return resultado;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<tbEstadosCiviles> BuscarEstadoCivil_IEnumerable(int? id)
        {
            try
            {
                var resultado = _EstadosCivilesRepository.Buscar(id);

                return resultado;
            }
            catch (Exception)
            {
                return Enumerable.Empty<tbEstadosCiviles>();
            }
        }

        public IEnumerable<tbEstadosCiviles> ListadoEstadosCiviles(out string error)
        {
            error = string.Empty;
            try
            {
                return _EstadosCivilesRepository.List();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<tbEstadosCiviles>();
            }
        }
        public int InsertarEstadoCivil(tbEstadosCiviles item)
        {

            try
            {
                var resultado = _EstadosCivilesRepository.Insert(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public int EliminarEstadoCivil(tbEstadosCiviles estados)
        {

            try
            {
                var resultado = _EstadosCivilesRepository.Delete(estados);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public int EditarEstadoCivil(tbEstadosCiviles estados)
        {

            try
            {
                var resultado = _EstadosCivilesRepository.Update(estados);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        //public IEnumerable<tbEstadosCiviles> BuscarEstadoCivil(int? id)
        //{
        //    try
        //    {
        //        return _EstadosCivilesRepository.BuscarEstado(id);
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        #endregion

        #region Sucursales

        public IEnumerable<tbSucursales> ListadoSucursales(out string error) 
        {
            error = string.Empty;
            try
            {
                return _SucursalesRepository.List();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<tbSucursales>();
            }
        }
        public int InsertarSucursal(tbSucursales item)
        {

            try
            {
                var resultado = _SucursalesRepository.Insert(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        #endregion

        #region Productos

        public IEnumerable<tbProductos> ListadoProductos(out string error)
        {
            error = string.Empty;
            try
            {
                return _ProductosRepository.List();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<tbProductos>();
            }
        }
        public int InsertarProducto(tbProductos item)
        {

            try
            {
                var resultado = _ProductosRepository.Insert(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        #endregion

        #region Reservaciones

        public IEnumerable<tbReservaciones> ListadoReservaciones(out string error)
        {
            error = string.Empty;
            try
            {
                return _ReservacionRepository.List();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<tbReservaciones>();
            }
        }
        public int InsertarReservaciones(tbReservaciones item)
        {

            try
            {
                var resultado = _ReservacionRepository.Insert(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        #endregion

        #region Facturas

        public IEnumerable<tbFacturas> ListadoFacturas(out string error)
        {
            error = string.Empty;
            try
            {
                return _FacturasRepository.List();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<tbFacturas>();
            }
        }
        public int InsertarFacturas(tbFacturas item)
        {

            try
            {
                var resultado = _FacturasRepository.Insert(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        #endregion

        #region Proveedor

        public IEnumerable<tbProveedores> ListadoProveedores(out string error)
        {
            error = string.Empty;
            try
            {
                return _ProveedoresRepository.List();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<tbProveedores>();
            }

        }
        public int InsertarProveedor(tbProveedores item)
        {

            try
            {
                var resultado = _ProveedoresRepository.Insert(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        #endregion

        #region Metodo pago

        public IEnumerable<tbMetodoPago> ListadoMetodoPago(out string error)
        {
            error = string.Empty;
            try
            {
                return _MetodopagoRepository.List();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<tbMetodoPago>();
            }
        }

        public int InsertarMetodoPago(tbMetodoPago item)
        {

            try
            {
                var resultado = _MetodopagoRepository.Insert(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public int EliminarMetodoPago(tbMetodoPago metodoPago)
        {

            try
            {
                var resultado = _MetodopagoRepository.Delete(metodoPago);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public int EditarMetodoPago(tbMetodoPago metodoPago)
        {

            try
            {
                var resultado = _MetodopagoRepository.Update(metodoPago);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public IEnumerable<tbMetodoPago> BuscarMetodoPago(int? id)
        {
            try
            {
                return _MetodopagoRepository.BuscarMetodoPago(id);
            }
            catch (Exception)
            {
                return null;
            }
        }


        #endregion


    }
}