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
        private readonly ServicioxProductoRepository _ServicioxProductoRepository;

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
                                    ProveedorRepository proveedorRepository,
                                    ServicioxProductoRepository servicioxProductoRepository
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
            _ServicioxProductoRepository = servicioxProductoRepository;
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


        public IEnumerable<tbCargos> BuscarCargo(int? id)
        {
            try
            {
                var resultado = _CargoRepository.buscar(id);

                return resultado;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public tbCargos FindCargo(int? id)
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

        public IEnumerable<VW_tbUsuarios_View> ListadoUsuariosView(out string error)
        {
            error = string.Empty;
            try
            {
                return _UsuariosRepository.ListView();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<VW_tbUsuarios_View>();
            }
        }

        public int InsertarUsuario(tbUsuarios item)
        {
            try
            {
                var resultado = _UsuariosRepository.Insert(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }


        public int RecuperarUsuario(tbUsuarios item)
        {
            try
            {
                var resultado = _UsuariosRepository.Recuperar(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public IEnumerable<VW_Login_View> Login(tbUsuarios item)
        {
            try
            {
                return _UsuariosRepository.Login(item);
            }
            catch (Exception )
            {
                return null;
            }
        }


        public int EditarUsuario(tbUsuarios item)
        {
            try
            {
                var resultado = _UsuariosRepository.Update(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public int EliminarUsuario(tbUsuarios item)
        {
            try
            {
                var resultado = _UsuariosRepository.Delete(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }


        public IEnumerable<VW_tbUsuarios_View> BuscarUsuarioView(int? id)
        {
            try
            {
                return _UsuariosRepository.BuscarView(id);
            }
            catch (Exception)
            {
                return null;
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
        public tbServicios findServicio(int? id)
        {
            try
            {
                return _ServicioRepository.find(id);
            }
            catch (Exception)
            {
                return null;
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
        public int EditarCategoria(tbCategorias categoria)
        {

            try
            {
                var resultado = _CategoriaRepository.Update(categoria);

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
        public tbCategorias BuscarCategoria(int? id)
        {
            try
            {
                return _CategoriaRepository.find(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<tbCategorias> BuscarCategoriaIEnumerable(int? id)
        {
            try
            {
                return _CategoriaRepository.BuscarCategoria(id);
            }
            catch (Exception)
            {
                return null;
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

        public tbDepartamentos findDepartameto(int? id)
        {
            try
            {
                return _DepartamentosRepository.find(id);
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

        public IEnumerable<VW_tbMunicipios_View> ListadoMunicipios(out string error)
        {
            error = string.Empty;
            try
            {
                return _MunicipiosRepository.ListView();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<VW_tbMunicipios_View>();
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

        public IEnumerable<VW_tbMunicipios_View> BuscarMunicipioView(int? id)
        {
            try
            {
                return _MunicipiosRepository.BuscarView(id);
            }
            catch (Exception )
            {
                return Enumerable.Empty<VW_tbMunicipios_View>();
            }
        }

        public int EditarMunicipio(tbMunicipios item)
        {

            try
            {
                var resultado = _MunicipiosRepository.Update(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public int EliminarMunicipio(tbMunicipios item)
        {

            try
            {
                var resultado = _MunicipiosRepository.Delete(item);

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
        public int EditarCliente(tbClientes item)
        {

            try
            {
                var resultado = _ClientesRepository.Update(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public int EliminarCliente(tbClientes cliente)
        {

            try
            {
                var resultado = _ClientesRepository.Delete(cliente);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public IEnumerable<tbClientes> BuscarCliente(int? id)
        {
            try
            {
                return _ClientesRepository.BuscarCliente(id);
            }
            catch (Exception)
            {
                return null;
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


        public tbSucursales BuscarSucursal(int? id)
        {
            try
            {
                var resultado = _SucursalesRepository.find(id);

                return resultado;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int EliminarSucursal(tbSucursales Sucursal)
        {

            try
            {
                var resultado = _SucursalesRepository.Delete(Sucursal);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }
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

        public IEnumerable<VW_tbSucursales_View> ListadoSucursalesView(out string error)
        {
            error = string.Empty;
            try
            {
                return _SucursalesRepository.ListView();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<VW_tbSucursales_View>();
            }
        }

        public IEnumerable<VW_tbSucursales_View> BuscarSucursalesView(int? id)
        {
            try
            {
                return _SucursalesRepository.findView(id);
            }
            catch (Exception)
            {
                return Enumerable.Empty<VW_tbSucursales_View>();
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
        public int EditarSucursal(tbSucursales item)
        {

            try
            {
                var resultado = _SucursalesRepository.Update(item);

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

        public IEnumerable<VW_tbProductos_View> ListadoProductosView(out string error)
        {
            error = string.Empty;
            try
            {
                return _ProductosRepository.ListView();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<VW_tbProductos_View>();
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
        public tbProductos findProducto(int? id)
        {
            try
            {
                return _ProductosRepository.find(id);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int EliminarProducto(tbProductos producto)
        {

            try
            {
                var resultado = _ProductosRepository.Delete(producto);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public int EditarProducto(tbProductos item)
        {

            try
            {
                var resultado = _ProductosRepository.Update(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public IEnumerable<tbProductos> BuscarProducto(int? id)
        {
            try
            {
                return _ProductosRepository.BuscarProducto(id);
            }
            catch (Exception)
            {
                return Enumerable.Empty<tbProductos>();
            }
        }


        #endregion

        #region Reservaciones


        public int EliminarReservacion(tbReservaciones reservaciones)
        {

            try
            {
                var resultado = _ReservacionRepository.Delete(reservaciones);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public int EditarReservacion(tbReservaciones item)
        {

            try
            {
                var resultado = _ReservacionRepository.Update(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

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
        public IEnumerable<VW_tbReservaciones_View> ListadoReservacionesView(out string error)
        {
            error = string.Empty;
            try
            {
                return _ReservacionRepository.ListView();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<VW_tbReservaciones_View>();
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

        public tbReservaciones findReservaciones(int? id)
        {
            try
            {
                return _ReservacionRepository.find(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<VW_tbReservaciones_View> BuscarReservaciones(int? id)
        {
            try
            {
                return _ReservacionRepository.BuscarView(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region Facturas

        public int stockMaximo(int prod_Id, int serv_Id)
        {
            try
            {
                return _FacturasRepository.stockmax(prod_Id, serv_Id);
            }
            catch (Exception)
            {
                return 999;
            }
        }
        public IEnumerable<VW_tbFacturas_Listado> BuscarFactura(int? id)
        {
            //No se mutee miamor :(
            try
            {
                return _FacturasRepository.BuscarFactura(id);
            }
            catch (Exception)
            {
                return Enumerable.Empty<VW_tbFacturas_Listado>();
            }
        }

        public IEnumerable<VW_tbFacturas_Listado> ListadoFacturas(out string error, int sucu_id)
        {
            error = string.Empty;
            try
            {
                return _FacturasRepository.ListView(sucu_id);
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<VW_tbFacturas_Listado>();
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

        public int InsertarFacturasDetalles(tbFacturas item)
        {

            try
            {
                var resultado = _FacturasRepository.InsertFacturaDetalles(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public IEnumerable<VW_tbFacturaDetalle_View> BuscarFacturasDetalles(int? item)
        {

            try
            {
                var resultado = _FacturasRepository.BuscarFacturaDetalles(item);

                return resultado;
            }
            catch (Exception)
            {
                return null;
            }

        }


        public int EliminarDetalle(tbFacturas facturas)
        {

            try
            {
                var resultado = _FacturasRepository.DeleteDetalle(facturas);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        #endregion

        #region Proveedor

        public int EliminarProveedor(tbProveedores Proveedor)
        {

            try
            {
                var resultado = _ProveedoresRepository.Delete(Proveedor);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }


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
        
        public int EditarProveedor(tbProveedores item)
        {

            try
            {
                var resultado = _ProveedoresRepository.Update(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public IEnumerable<tbProveedores> BuscarProveedor(int? id)
        {
            try
            {
                return _ProveedoresRepository.BuscarProveedor(id);
            }
            catch (Exception)
            {
                return Enumerable.Empty<tbProveedores>();
            }
        }


        public tbProveedores findProveedor(int? id)
        {
            try
            {
                return _ProveedoresRepository.find(id);
            }
            catch (Exception)
            {
                return null;
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

        public tbMetodoPago findMetodo(int? id)
        {
            try
            {
                return _MetodopagoRepository.find(id);
            }
            catch (Exception)
            {
                return null;
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


        #region ServicioxProducto

        public IEnumerable<VW_tbProductosxServicio_View> ListadoServicioxproducto(out string error)
        {
            error = string.Empty;
            try
            {
                return _ServicioxProductoRepository.ListView();
            }
            catch (Exception e)
            {
                error = e.Message;
                return Enumerable.Empty<VW_tbProductosxServicio_View>();
            }
        }
        public int InsertarServicioxProducto(tbProductosXServicio item)
        {
            try
            {
                var resultado = _ServicioxProductoRepository.Insert(item);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public int EditarServicioxProducto(tbProductosXServicio servicio)
        {

            try
            {
                var resultado = _ServicioxProductoRepository.Update(servicio);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public int EliminarServicioxProducto(tbProductosXServicio serprod)
        {

            try
            {
                var resultado = _ServicioxProductoRepository.Delete(serprod);

                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public tbProductosXServicio findServicioXProducto(int? id)
        {
            try
            {
                return _ServicioxProductoRepository.find(id);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public IEnumerable<tbProductosXServicio> BuscarServicioXProducto(int? id)
        {
            try
            {
                return _ServicioxProductoRepository.BuscarServicioXProducto(id);
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

    }
}