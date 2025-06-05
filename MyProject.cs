using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes.My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ABMEmpresas m_ABMEmpresas;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Almacen m_Almacen;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Buscar m_Buscar;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public calcularkm m_calcularkm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cambiar_Ch m_Cambiar_Ch;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Categorias m_Categorias;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ChartForm m_ChartForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Chatform m_Chatform;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Choferes m_Choferes;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cierre_Guias m_Cierre_Guias;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Clientes m_Clientes;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public CND m_CND;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ConsultaEstado m_ConsultaEstado;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public DatosImport m_DatosImport;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Descarga m_Descarga;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Despachos m_Despachos;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Disponibilidad m_Disponibilidad;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public E_Despachos m_E_Despachos;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public E_Envio m_E_Envio;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public EdicionEtrans m_EdicionEtrans;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Editar m_Editar;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Empresas m_Empresas;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public EmpresasSelector m_EmpresasSelector;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Entregas m_Entregas;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Estados m_Estados;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public EstadosConfig m_EstadosConfig;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Etiquetas_Form m_Etiquetas_Form;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public EtransAdmin m_EtransAdmin;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Eventos m_Eventos;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Eventuales_form m_Eventuales_form;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Explorador m_Explorador;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Feriados m_Feriados;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form1_Inicio m_Form1_Inicio;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form2_AdmDB m_Form2_AdmDB;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form2_Usuario m_Form2_Usuario;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public HDRAlmacen m_HDRAlmacen;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ImporConfig m_ImporConfig;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ImportarConfig m_ImportarConfig;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ImportarOrdenes m_ImportarOrdenes;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ImprimirConfig m_ImprimirConfig;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Inf_seguimiento m_Inf_seguimiento;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Infimportacion m_Infimportacion;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public InfOperaciones m_InfOperaciones;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public InformeAlmacen m_InformeAlmacen;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Informes m_Informes;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ingreso_manual m_Ingreso_manual;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Liquidacion m_Liquidacion;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Listado m_Listado;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ListadoRuta m_ListadoRuta;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Loading m_Loading;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Localidades m_Localidades;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Login m_Login;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mapa m_Mapa;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public masivoEtiquetas m_masivoEtiquetas;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Movimientos_A m_Movimientos_A;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public New_Orden m_New_Orden;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nomb_Adicionales m_Nomb_Adicionales;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Novedades m_Novedades;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public NuevoProducto_Form m_NuevoProducto_Form;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nuevovb m_Nuevovb;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public OrdenSalida m_OrdenSalida;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Posicionar m_Posicionar;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public PosicionModal m_PosicionModal;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Procesos m_Procesos;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Productos_Form m_Productos_Form;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ProductosIn_Form m_ProductosIn_Form;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ProductosOut_Form m_ProductosOut_Form;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pruebas m_Pruebas;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Recepcion m_Recepcion;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Recepcion_form m_Recepcion_form;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public RecepcionEnvios m_RecepcionEnvios;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Retiros m_Retiros;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Rutas m_Rutas;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public RutasConfig m_RutasConfig;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Selector m_Selector;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public SplashScreen1 m_SplashScreen1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Telas_in m_Telas_in;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public TESTposicionar m_TESTposicionar;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public V_Tareas m_V_Tareas;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Variaciones m_Variaciones;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Vehiculos m_Vehiculos;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public VerTabla m_VerTabla;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public XmlLectura m_XmlLectura;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public zonas m_zonas;

		public ABMEmpresas ABMEmpresas
		{
			[DebuggerHidden]
			get
			{
				m_ABMEmpresas = Create__Instance__(m_ABMEmpresas);
				return m_ABMEmpresas;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ABMEmpresas)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ABMEmpresas);
				}
			}
		}

		public Almacen Almacen
		{
			[DebuggerHidden]
			get
			{
				m_Almacen = Create__Instance__(m_Almacen);
				return m_Almacen;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Almacen)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Almacen);
				}
			}
		}

		public Buscar Buscar
		{
			[DebuggerHidden]
			get
			{
				m_Buscar = Create__Instance__(m_Buscar);
				return m_Buscar;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Buscar)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Buscar);
				}
			}
		}

		public calcularkm calcularkm
		{
			[DebuggerHidden]
			get
			{
				m_calcularkm = Create__Instance__(m_calcularkm);
				return m_calcularkm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_calcularkm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_calcularkm);
				}
			}
		}

		public Cambiar_Ch Cambiar_Ch
		{
			[DebuggerHidden]
			get
			{
				m_Cambiar_Ch = Create__Instance__(m_Cambiar_Ch);
				return m_Cambiar_Ch;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Cambiar_Ch)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Cambiar_Ch);
				}
			}
		}

		public Categorias Categorias
		{
			[DebuggerHidden]
			get
			{
				m_Categorias = Create__Instance__(m_Categorias);
				return m_Categorias;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Categorias)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Categorias);
				}
			}
		}

		public ChartForm ChartForm
		{
			[DebuggerHidden]
			get
			{
				m_ChartForm = Create__Instance__(m_ChartForm);
				return m_ChartForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ChartForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ChartForm);
				}
			}
		}

		public Chatform Chatform
		{
			[DebuggerHidden]
			get
			{
				m_Chatform = Create__Instance__(m_Chatform);
				return m_Chatform;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Chatform)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Chatform);
				}
			}
		}

		public Choferes Choferes
		{
			[DebuggerHidden]
			get
			{
				m_Choferes = Create__Instance__(m_Choferes);
				return m_Choferes;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Choferes)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Choferes);
				}
			}
		}

		public Cierre_Guias Cierre_Guias
		{
			[DebuggerHidden]
			get
			{
				m_Cierre_Guias = Create__Instance__(m_Cierre_Guias);
				return m_Cierre_Guias;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Cierre_Guias)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Cierre_Guias);
				}
			}
		}

		public Clientes Clientes
		{
			[DebuggerHidden]
			get
			{
				m_Clientes = Create__Instance__(m_Clientes);
				return m_Clientes;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Clientes)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Clientes);
				}
			}
		}

		public CND CND
		{
			[DebuggerHidden]
			get
			{
				m_CND = Create__Instance__(m_CND);
				return m_CND;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_CND)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_CND);
				}
			}
		}

		public ConsultaEstado ConsultaEstado
		{
			[DebuggerHidden]
			get
			{
				m_ConsultaEstado = Create__Instance__(m_ConsultaEstado);
				return m_ConsultaEstado;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ConsultaEstado)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ConsultaEstado);
				}
			}
		}

		public DatosImport DatosImport
		{
			[DebuggerHidden]
			get
			{
				m_DatosImport = Create__Instance__(m_DatosImport);
				return m_DatosImport;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_DatosImport)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_DatosImport);
				}
			}
		}

		public Descarga Descarga
		{
			[DebuggerHidden]
			get
			{
				m_Descarga = Create__Instance__(m_Descarga);
				return m_Descarga;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Descarga)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Descarga);
				}
			}
		}

		public Despachos Despachos
		{
			[DebuggerHidden]
			get
			{
				m_Despachos = Create__Instance__(m_Despachos);
				return m_Despachos;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Despachos)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Despachos);
				}
			}
		}

		public Disponibilidad Disponibilidad
		{
			[DebuggerHidden]
			get
			{
				m_Disponibilidad = Create__Instance__(m_Disponibilidad);
				return m_Disponibilidad;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Disponibilidad)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Disponibilidad);
				}
			}
		}

		public E_Despachos E_Despachos
		{
			[DebuggerHidden]
			get
			{
				m_E_Despachos = Create__Instance__(m_E_Despachos);
				return m_E_Despachos;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_E_Despachos)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_E_Despachos);
				}
			}
		}

		public E_Envio E_Envio
		{
			[DebuggerHidden]
			get
			{
				m_E_Envio = Create__Instance__(m_E_Envio);
				return m_E_Envio;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_E_Envio)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_E_Envio);
				}
			}
		}

		public EdicionEtrans EdicionEtrans
		{
			[DebuggerHidden]
			get
			{
				m_EdicionEtrans = Create__Instance__(m_EdicionEtrans);
				return m_EdicionEtrans;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_EdicionEtrans)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_EdicionEtrans);
				}
			}
		}

		public Editar Editar
		{
			[DebuggerHidden]
			get
			{
				m_Editar = Create__Instance__(m_Editar);
				return m_Editar;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Editar)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Editar);
				}
			}
		}

		public Empresas Empresas
		{
			[DebuggerHidden]
			get
			{
				m_Empresas = Create__Instance__(m_Empresas);
				return m_Empresas;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Empresas)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Empresas);
				}
			}
		}

		public EmpresasSelector EmpresasSelector
		{
			[DebuggerHidden]
			get
			{
				m_EmpresasSelector = Create__Instance__(m_EmpresasSelector);
				return m_EmpresasSelector;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_EmpresasSelector)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_EmpresasSelector);
				}
			}
		}

		public Entregas Entregas
		{
			[DebuggerHidden]
			get
			{
				m_Entregas = Create__Instance__(m_Entregas);
				return m_Entregas;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Entregas)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Entregas);
				}
			}
		}

		public Estados Estados
		{
			[DebuggerHidden]
			get
			{
				m_Estados = Create__Instance__(m_Estados);
				return m_Estados;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Estados)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Estados);
				}
			}
		}

		public EstadosConfig EstadosConfig
		{
			[DebuggerHidden]
			get
			{
				m_EstadosConfig = Create__Instance__(m_EstadosConfig);
				return m_EstadosConfig;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_EstadosConfig)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_EstadosConfig);
				}
			}
		}

		public Etiquetas_Form Etiquetas_Form
		{
			[DebuggerHidden]
			get
			{
				m_Etiquetas_Form = Create__Instance__(m_Etiquetas_Form);
				return m_Etiquetas_Form;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Etiquetas_Form)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Etiquetas_Form);
				}
			}
		}

		public EtransAdmin EtransAdmin
		{
			[DebuggerHidden]
			get
			{
				m_EtransAdmin = Create__Instance__(m_EtransAdmin);
				return m_EtransAdmin;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_EtransAdmin)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_EtransAdmin);
				}
			}
		}

		public Eventos Eventos
		{
			[DebuggerHidden]
			get
			{
				m_Eventos = Create__Instance__(m_Eventos);
				return m_Eventos;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Eventos)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Eventos);
				}
			}
		}

		public Eventuales_form Eventuales_form
		{
			[DebuggerHidden]
			get
			{
				m_Eventuales_form = Create__Instance__(m_Eventuales_form);
				return m_Eventuales_form;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Eventuales_form)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Eventuales_form);
				}
			}
		}

		public Explorador Explorador
		{
			[DebuggerHidden]
			get
			{
				m_Explorador = Create__Instance__(m_Explorador);
				return m_Explorador;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Explorador)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Explorador);
				}
			}
		}

		public Feriados Feriados
		{
			[DebuggerHidden]
			get
			{
				m_Feriados = Create__Instance__(m_Feriados);
				return m_Feriados;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Feriados)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Feriados);
				}
			}
		}

		public Form1_Inicio Form1_Inicio
		{
			[DebuggerHidden]
			get
			{
				m_Form1_Inicio = Create__Instance__(m_Form1_Inicio);
				return m_Form1_Inicio;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Form1_Inicio)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form1_Inicio);
				}
			}
		}

		public Form2_AdmDB Form2_AdmDB
		{
			[DebuggerHidden]
			get
			{
				m_Form2_AdmDB = Create__Instance__(m_Form2_AdmDB);
				return m_Form2_AdmDB;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Form2_AdmDB)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form2_AdmDB);
				}
			}
		}

		public Form2_Usuario Form2_Usuario
		{
			[DebuggerHidden]
			get
			{
				m_Form2_Usuario = Create__Instance__(m_Form2_Usuario);
				return m_Form2_Usuario;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Form2_Usuario)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form2_Usuario);
				}
			}
		}

		public HDRAlmacen HDRAlmacen
		{
			[DebuggerHidden]
			get
			{
				m_HDRAlmacen = Create__Instance__(m_HDRAlmacen);
				return m_HDRAlmacen;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_HDRAlmacen)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_HDRAlmacen);
				}
			}
		}

		public ImporConfig ImporConfig
		{
			[DebuggerHidden]
			get
			{
				m_ImporConfig = Create__Instance__(m_ImporConfig);
				return m_ImporConfig;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ImporConfig)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ImporConfig);
				}
			}
		}

		public ImportarConfig ImportarConfig
		{
			[DebuggerHidden]
			get
			{
				m_ImportarConfig = Create__Instance__(m_ImportarConfig);
				return m_ImportarConfig;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ImportarConfig)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ImportarConfig);
				}
			}
		}

		public ImportarOrdenes ImportarOrdenes
		{
			[DebuggerHidden]
			get
			{
				m_ImportarOrdenes = Create__Instance__(m_ImportarOrdenes);
				return m_ImportarOrdenes;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ImportarOrdenes)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ImportarOrdenes);
				}
			}
		}

		public ImprimirConfig ImprimirConfig
		{
			[DebuggerHidden]
			get
			{
				m_ImprimirConfig = Create__Instance__(m_ImprimirConfig);
				return m_ImprimirConfig;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ImprimirConfig)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ImprimirConfig);
				}
			}
		}

		public Inf_seguimiento Inf_seguimiento
		{
			[DebuggerHidden]
			get
			{
				m_Inf_seguimiento = Create__Instance__(m_Inf_seguimiento);
				return m_Inf_seguimiento;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Inf_seguimiento)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Inf_seguimiento);
				}
			}
		}

		public Infimportacion Infimportacion
		{
			[DebuggerHidden]
			get
			{
				m_Infimportacion = Create__Instance__(m_Infimportacion);
				return m_Infimportacion;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Infimportacion)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Infimportacion);
				}
			}
		}

		public InfOperaciones InfOperaciones
		{
			[DebuggerHidden]
			get
			{
				m_InfOperaciones = Create__Instance__(m_InfOperaciones);
				return m_InfOperaciones;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_InfOperaciones)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_InfOperaciones);
				}
			}
		}

		public InformeAlmacen InformeAlmacen
		{
			[DebuggerHidden]
			get
			{
				m_InformeAlmacen = Create__Instance__(m_InformeAlmacen);
				return m_InformeAlmacen;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_InformeAlmacen)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_InformeAlmacen);
				}
			}
		}

		public Informes Informes
		{
			[DebuggerHidden]
			get
			{
				m_Informes = Create__Instance__(m_Informes);
				return m_Informes;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Informes)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Informes);
				}
			}
		}

		public Ingreso_manual Ingreso_manual
		{
			[DebuggerHidden]
			get
			{
				m_Ingreso_manual = Create__Instance__(m_Ingreso_manual);
				return m_Ingreso_manual;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Ingreso_manual)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Ingreso_manual);
				}
			}
		}

		public Liquidacion Liquidacion
		{
			[DebuggerHidden]
			get
			{
				m_Liquidacion = Create__Instance__(m_Liquidacion);
				return m_Liquidacion;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Liquidacion)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Liquidacion);
				}
			}
		}

		public Listado Listado
		{
			[DebuggerHidden]
			get
			{
				m_Listado = Create__Instance__(m_Listado);
				return m_Listado;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Listado)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Listado);
				}
			}
		}

		public ListadoRuta ListadoRuta
		{
			[DebuggerHidden]
			get
			{
				m_ListadoRuta = Create__Instance__(m_ListadoRuta);
				return m_ListadoRuta;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ListadoRuta)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ListadoRuta);
				}
			}
		}

		public Loading Loading
		{
			[DebuggerHidden]
			get
			{
				m_Loading = Create__Instance__(m_Loading);
				return m_Loading;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Loading)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Loading);
				}
			}
		}

		public Localidades Localidades
		{
			[DebuggerHidden]
			get
			{
				m_Localidades = Create__Instance__(m_Localidades);
				return m_Localidades;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Localidades)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Localidades);
				}
			}
		}

		public Login Login
		{
			[DebuggerHidden]
			get
			{
				m_Login = Create__Instance__(m_Login);
				return m_Login;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Login)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Login);
				}
			}
		}

		public Mapa Mapa
		{
			[DebuggerHidden]
			get
			{
				m_Mapa = Create__Instance__(m_Mapa);
				return m_Mapa;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Mapa)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Mapa);
				}
			}
		}

		public masivoEtiquetas masivoEtiquetas
		{
			[DebuggerHidden]
			get
			{
				m_masivoEtiquetas = Create__Instance__(m_masivoEtiquetas);
				return m_masivoEtiquetas;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_masivoEtiquetas)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_masivoEtiquetas);
				}
			}
		}

		public Movimientos_A Movimientos_A
		{
			[DebuggerHidden]
			get
			{
				m_Movimientos_A = Create__Instance__(m_Movimientos_A);
				return m_Movimientos_A;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Movimientos_A)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Movimientos_A);
				}
			}
		}

		public New_Orden New_Orden
		{
			[DebuggerHidden]
			get
			{
				m_New_Orden = Create__Instance__(m_New_Orden);
				return m_New_Orden;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_New_Orden)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_New_Orden);
				}
			}
		}

		public Nomb_Adicionales Nomb_Adicionales
		{
			[DebuggerHidden]
			get
			{
				m_Nomb_Adicionales = Create__Instance__(m_Nomb_Adicionales);
				return m_Nomb_Adicionales;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Nomb_Adicionales)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Nomb_Adicionales);
				}
			}
		}

		public Novedades Novedades
		{
			[DebuggerHidden]
			get
			{
				m_Novedades = Create__Instance__(m_Novedades);
				return m_Novedades;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Novedades)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Novedades);
				}
			}
		}

		public NuevoProducto_Form NuevoProducto_Form
		{
			[DebuggerHidden]
			get
			{
				m_NuevoProducto_Form = Create__Instance__(m_NuevoProducto_Form);
				return m_NuevoProducto_Form;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_NuevoProducto_Form)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_NuevoProducto_Form);
				}
			}
		}

		public Nuevovb Nuevovb
		{
			[DebuggerHidden]
			get
			{
				m_Nuevovb = Create__Instance__(m_Nuevovb);
				return m_Nuevovb;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Nuevovb)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Nuevovb);
				}
			}
		}

		public OrdenSalida OrdenSalida
		{
			[DebuggerHidden]
			get
			{
				m_OrdenSalida = Create__Instance__(m_OrdenSalida);
				return m_OrdenSalida;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_OrdenSalida)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_OrdenSalida);
				}
			}
		}

		public Posicionar Posicionar
		{
			[DebuggerHidden]
			get
			{
				m_Posicionar = Create__Instance__(m_Posicionar);
				return m_Posicionar;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Posicionar)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Posicionar);
				}
			}
		}

		public PosicionModal PosicionModal
		{
			[DebuggerHidden]
			get
			{
				m_PosicionModal = Create__Instance__(m_PosicionModal);
				return m_PosicionModal;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_PosicionModal)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_PosicionModal);
				}
			}
		}

		public Procesos Procesos
		{
			[DebuggerHidden]
			get
			{
				m_Procesos = Create__Instance__(m_Procesos);
				return m_Procesos;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Procesos)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Procesos);
				}
			}
		}

		public Productos_Form Productos_Form
		{
			[DebuggerHidden]
			get
			{
				m_Productos_Form = Create__Instance__(m_Productos_Form);
				return m_Productos_Form;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Productos_Form)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Productos_Form);
				}
			}
		}

		public ProductosIn_Form ProductosIn_Form
		{
			[DebuggerHidden]
			get
			{
				m_ProductosIn_Form = Create__Instance__(m_ProductosIn_Form);
				return m_ProductosIn_Form;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ProductosIn_Form)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ProductosIn_Form);
				}
			}
		}

		public ProductosOut_Form ProductosOut_Form
		{
			[DebuggerHidden]
			get
			{
				m_ProductosOut_Form = Create__Instance__(m_ProductosOut_Form);
				return m_ProductosOut_Form;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ProductosOut_Form)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ProductosOut_Form);
				}
			}
		}

		public Pruebas Pruebas
		{
			[DebuggerHidden]
			get
			{
				m_Pruebas = Create__Instance__(m_Pruebas);
				return m_Pruebas;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Pruebas)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Pruebas);
				}
			}
		}

		public Recepcion Recepcion
		{
			[DebuggerHidden]
			get
			{
				m_Recepcion = Create__Instance__(m_Recepcion);
				return m_Recepcion;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Recepcion)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Recepcion);
				}
			}
		}

		public Recepcion_form Recepcion_form
		{
			[DebuggerHidden]
			get
			{
				m_Recepcion_form = Create__Instance__(m_Recepcion_form);
				return m_Recepcion_form;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Recepcion_form)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Recepcion_form);
				}
			}
		}

		public RecepcionEnvios RecepcionEnvios
		{
			[DebuggerHidden]
			get
			{
				m_RecepcionEnvios = Create__Instance__(m_RecepcionEnvios);
				return m_RecepcionEnvios;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_RecepcionEnvios)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_RecepcionEnvios);
				}
			}
		}

		public Retiros Retiros
		{
			[DebuggerHidden]
			get
			{
				m_Retiros = Create__Instance__(m_Retiros);
				return m_Retiros;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Retiros)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Retiros);
				}
			}
		}

		public Rutas Rutas
		{
			[DebuggerHidden]
			get
			{
				m_Rutas = Create__Instance__(m_Rutas);
				return m_Rutas;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Rutas)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Rutas);
				}
			}
		}

		public RutasConfig RutasConfig
		{
			[DebuggerHidden]
			get
			{
				m_RutasConfig = Create__Instance__(m_RutasConfig);
				return m_RutasConfig;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_RutasConfig)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_RutasConfig);
				}
			}
		}

		public Selector Selector
		{
			[DebuggerHidden]
			get
			{
				m_Selector = Create__Instance__(m_Selector);
				return m_Selector;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Selector)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Selector);
				}
			}
		}

		public SplashScreen1 SplashScreen1
		{
			[DebuggerHidden]
			get
			{
				m_SplashScreen1 = Create__Instance__(m_SplashScreen1);
				return m_SplashScreen1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_SplashScreen1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_SplashScreen1);
				}
			}
		}

		public Telas_in Telas_in
		{
			[DebuggerHidden]
			get
			{
				m_Telas_in = Create__Instance__(m_Telas_in);
				return m_Telas_in;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Telas_in)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Telas_in);
				}
			}
		}

		public TESTposicionar TESTposicionar
		{
			[DebuggerHidden]
			get
			{
				m_TESTposicionar = Create__Instance__(m_TESTposicionar);
				return m_TESTposicionar;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_TESTposicionar)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_TESTposicionar);
				}
			}
		}

		public V_Tareas V_Tareas
		{
			[DebuggerHidden]
			get
			{
				m_V_Tareas = Create__Instance__(m_V_Tareas);
				return m_V_Tareas;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_V_Tareas)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_V_Tareas);
				}
			}
		}

		public Variaciones Variaciones
		{
			[DebuggerHidden]
			get
			{
				m_Variaciones = Create__Instance__(m_Variaciones);
				return m_Variaciones;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Variaciones)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Variaciones);
				}
			}
		}

		public Vehiculos Vehiculos
		{
			[DebuggerHidden]
			get
			{
				m_Vehiculos = Create__Instance__(m_Vehiculos);
				return m_Vehiculos;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Vehiculos)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Vehiculos);
				}
			}
		}

		public VerTabla VerTabla
		{
			[DebuggerHidden]
			get
			{
				m_VerTabla = Create__Instance__(m_VerTabla);
				return m_VerTabla;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_VerTabla)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_VerTabla);
				}
			}
		}

		public XmlLectura XmlLectura
		{
			[DebuggerHidden]
			get
			{
				m_XmlLectura = Create__Instance__(m_XmlLectura);
				return m_XmlLectura;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_XmlLectura)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_XmlLectura);
				}
			}
		}

		public zonas zonas
		{
			[DebuggerHidden]
			get
			{
				m_zonas = Create__Instance__(m_zonas);
				return m_zonas;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_zonas)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_zonas);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance == null || Instance.IsDisposed)
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(T), null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError(ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			instance.Dispose();
			instance = null;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyWebServices()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
