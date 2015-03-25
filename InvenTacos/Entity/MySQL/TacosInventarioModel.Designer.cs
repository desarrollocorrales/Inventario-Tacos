﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace InvenTacos.Entity.MySQL
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class TacosInventarioEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto TacosInventarioEntities usando la cadena de conexión encontrada en la sección 'TacosInventarioEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public TacosInventarioEntities() : base("name=TacosInventarioEntities", "TacosInventarioEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto TacosInventarioEntities.
        /// </summary>
        public TacosInventarioEntities(string connectionString) : base(connectionString, "TacosInventarioEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto TacosInventarioEntities.
        /// </summary>
        public TacosInventarioEntities(EntityConnection connection) : base(connection, "TacosInventarioEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<compras> compras
        {
            get
            {
                if ((_compras == null))
                {
                    _compras = base.CreateObjectSet<compras>("compras");
                }
                return _compras;
            }
        }
        private ObjectSet<compras> _compras;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<insumos> insumos
        {
            get
            {
                if ((_insumos == null))
                {
                    _insumos = base.CreateObjectSet<insumos>("insumos");
                }
                return _insumos;
            }
        }
        private ObjectSet<insumos> _insumos;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<inventarios_diarios> inventarios_diarios
        {
            get
            {
                if ((_inventarios_diarios == null))
                {
                    _inventarios_diarios = base.CreateObjectSet<inventarios_diarios>("inventarios_diarios");
                }
                return _inventarios_diarios;
            }
        }
        private ObjectSet<inventarios_diarios> _inventarios_diarios;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet compras. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddTocompras(compras compras)
        {
            base.AddObject("compras", compras);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet insumos. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToinsumos(insumos insumos)
        {
            base.AddObject("insumos", insumos);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet inventarios_diarios. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToinventarios_diarios(inventarios_diarios inventarios_diarios)
        {
            base.AddObject("inventarios_diarios", inventarios_diarios);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TacosInventariosModel", Name="compras")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class compras : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto compras.
        /// </summary>
        /// <param name="id_compra">Valor inicial de la propiedad id_compra.</param>
        /// <param name="id_insumo">Valor inicial de la propiedad id_insumo.</param>
        /// <param name="cantidad">Valor inicial de la propiedad cantidad.</param>
        /// <param name="fecha">Valor inicial de la propiedad fecha.</param>
        public static compras Createcompras(global::System.Int64 id_compra, global::System.String id_insumo, global::System.Decimal cantidad, global::System.DateTime fecha)
        {
            compras compras = new compras();
            compras.id_compra = id_compra;
            compras.id_insumo = id_insumo;
            compras.cantidad = cantidad;
            compras.fecha = fecha;
            return compras;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 id_compra
        {
            get
            {
                return _id_compra;
            }
            set
            {
                if (_id_compra != value)
                {
                    Onid_compraChanging(value);
                    ReportPropertyChanging("id_compra");
                    _id_compra = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id_compra");
                    Onid_compraChanged();
                }
            }
        }
        private global::System.Int64 _id_compra;
        partial void Onid_compraChanging(global::System.Int64 value);
        partial void Onid_compraChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String id_insumo
        {
            get
            {
                return _id_insumo;
            }
            set
            {
                if (_id_insumo != value)
                {
                    Onid_insumoChanging(value);
                    ReportPropertyChanging("id_insumo");
                    _id_insumo = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("id_insumo");
                    Onid_insumoChanged();
                }
            }
        }
        private global::System.String _id_insumo;
        partial void Onid_insumoChanging(global::System.String value);
        partial void Onid_insumoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                if (_cantidad != value)
                {
                    OncantidadChanging(value);
                    ReportPropertyChanging("cantidad");
                    _cantidad = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("cantidad");
                    OncantidadChanged();
                }
            }
        }
        private global::System.Decimal _cantidad;
        partial void OncantidadChanging(global::System.Decimal value);
        partial void OncantidadChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                if (_fecha != value)
                {
                    OnfechaChanging(value);
                    ReportPropertyChanging("fecha");
                    _fecha = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("fecha");
                    OnfechaChanged();
                }
            }
        }
        private global::System.DateTime _fecha;
        partial void OnfechaChanging(global::System.DateTime value);
        partial void OnfechaChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TacosInventariosModel", Name="insumos")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class insumos : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto insumos.
        /// </summary>
        /// <param name="id_insumo">Valor inicial de la propiedad id_insumo.</param>
        /// <param name="descripcion">Valor inicial de la propiedad descripcion.</param>
        /// <param name="unidad">Valor inicial de la propiedad unidad.</param>
        public static insumos Createinsumos(global::System.String id_insumo, global::System.String descripcion, global::System.String unidad)
        {
            insumos insumos = new insumos();
            insumos.id_insumo = id_insumo;
            insumos.descripcion = descripcion;
            insumos.unidad = unidad;
            return insumos;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String id_insumo
        {
            get
            {
                return _id_insumo;
            }
            set
            {
                if (_id_insumo != value)
                {
                    Onid_insumoChanging(value);
                    ReportPropertyChanging("id_insumo");
                    _id_insumo = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("id_insumo");
                    Onid_insumoChanged();
                }
            }
        }
        private global::System.String _id_insumo;
        partial void Onid_insumoChanging(global::System.String value);
        partial void Onid_insumoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                OndescripcionChanging(value);
                ReportPropertyChanging("descripcion");
                _descripcion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("descripcion");
                OndescripcionChanged();
            }
        }
        private global::System.String _descripcion;
        partial void OndescripcionChanging(global::System.String value);
        partial void OndescripcionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String unidad
        {
            get
            {
                return _unidad;
            }
            set
            {
                OnunidadChanging(value);
                ReportPropertyChanging("unidad");
                _unidad = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("unidad");
                OnunidadChanged();
            }
        }
        private global::System.String _unidad;
        partial void OnunidadChanging(global::System.String value);
        partial void OnunidadChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> rendimiento
        {
            get
            {
                return _rendimiento;
            }
            set
            {
                OnrendimientoChanging(value);
                ReportPropertyChanging("rendimiento");
                _rendimiento = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("rendimiento");
                OnrendimientoChanged();
            }
        }
        private Nullable<global::System.Decimal> _rendimiento;
        partial void OnrendimientoChanging(Nullable<global::System.Decimal> value);
        partial void OnrendimientoChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TacosInventariosModel", Name="inventarios_diarios")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class inventarios_diarios : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto inventarios_diarios.
        /// </summary>
        /// <param name="id_insumo">Valor inicial de la propiedad id_insumo.</param>
        /// <param name="cantidad_crudo">Valor inicial de la propiedad cantidad_crudo.</param>
        /// <param name="cantidad_cocido">Valor inicial de la propiedad cantidad_cocido.</param>
        /// <param name="cantidad_total">Valor inicial de la propiedad cantidad_total.</param>
        /// <param name="fecha">Valor inicial de la propiedad fecha.</param>
        public static inventarios_diarios Createinventarios_diarios(global::System.String id_insumo, global::System.Decimal cantidad_crudo, global::System.Decimal cantidad_cocido, global::System.Decimal cantidad_total, global::System.DateTime fecha)
        {
            inventarios_diarios inventarios_diarios = new inventarios_diarios();
            inventarios_diarios.id_insumo = id_insumo;
            inventarios_diarios.cantidad_crudo = cantidad_crudo;
            inventarios_diarios.cantidad_cocido = cantidad_cocido;
            inventarios_diarios.cantidad_total = cantidad_total;
            inventarios_diarios.fecha = fecha;
            return inventarios_diarios;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String id_insumo
        {
            get
            {
                return _id_insumo;
            }
            set
            {
                if (_id_insumo != value)
                {
                    Onid_insumoChanging(value);
                    ReportPropertyChanging("id_insumo");
                    _id_insumo = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("id_insumo");
                    Onid_insumoChanged();
                }
            }
        }
        private global::System.String _id_insumo;
        partial void Onid_insumoChanging(global::System.String value);
        partial void Onid_insumoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal cantidad_crudo
        {
            get
            {
                return _cantidad_crudo;
            }
            set
            {
                Oncantidad_crudoChanging(value);
                ReportPropertyChanging("cantidad_crudo");
                _cantidad_crudo = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("cantidad_crudo");
                Oncantidad_crudoChanged();
            }
        }
        private global::System.Decimal _cantidad_crudo;
        partial void Oncantidad_crudoChanging(global::System.Decimal value);
        partial void Oncantidad_crudoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal cantidad_cocido
        {
            get
            {
                return _cantidad_cocido;
            }
            set
            {
                Oncantidad_cocidoChanging(value);
                ReportPropertyChanging("cantidad_cocido");
                _cantidad_cocido = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("cantidad_cocido");
                Oncantidad_cocidoChanged();
            }
        }
        private global::System.Decimal _cantidad_cocido;
        partial void Oncantidad_cocidoChanging(global::System.Decimal value);
        partial void Oncantidad_cocidoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal cantidad_total
        {
            get
            {
                return _cantidad_total;
            }
            set
            {
                Oncantidad_totalChanging(value);
                ReportPropertyChanging("cantidad_total");
                _cantidad_total = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("cantidad_total");
                Oncantidad_totalChanged();
            }
        }
        private global::System.Decimal _cantidad_total;
        partial void Oncantidad_totalChanging(global::System.Decimal value);
        partial void Oncantidad_totalChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                if (_fecha != value)
                {
                    OnfechaChanging(value);
                    ReportPropertyChanging("fecha");
                    _fecha = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("fecha");
                    OnfechaChanged();
                }
            }
        }
        private global::System.DateTime _fecha;
        partial void OnfechaChanging(global::System.DateTime value);
        partial void OnfechaChanged();

        #endregion

    
    }

    #endregion

    
}
