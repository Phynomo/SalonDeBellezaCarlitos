using SalonDeBellezaCarlitos.DataAccess.Repository;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public int InsertarCategorias(tbCategorias cate)
        {
            throw new NotImplementedException();
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


        #endregion

        #region Empleados


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


        #endregion

        #region Usuarios

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

        #endregion

        #region Estados Civiles

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


        #endregion


    }
}