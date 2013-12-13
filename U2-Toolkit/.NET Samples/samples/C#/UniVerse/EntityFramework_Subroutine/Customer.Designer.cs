﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace EntityFramework_Subroutine
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CustomerContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CustomerContainer object using the connection string found in the 'CustomerContainer' section of the application configuration file.
        /// </summary>
        public CustomerContainer() : base("name=CustomerContainer", "CustomerContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CustomerContainer object.
        /// </summary>
        public CustomerContainer(string connectionString) : base(connectionString, "CustomerContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CustomerContainer object.
        /// </summary>
        public CustomerContainer(EntityConnection connection) : base(connection, "CustomerContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<CUSTOMER> CUSTOMERS
        {
            get
            {
                if ((_CUSTOMERS == null))
                {
                    _CUSTOMERS = base.CreateObjectSet<CUSTOMER>("CUSTOMERS");
                }
                return _CUSTOMERS;
            }
        }
        private ObjectSet<CUSTOMER> _CUSTOMERS;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<CUSTOMER_MV> CUSTOMERS_MV
        {
            get
            {
                if ((_CUSTOMERS_MV == null))
                {
                    _CUSTOMERS_MV = base.CreateObjectSet<CUSTOMER_MV>("CUSTOMERS_MV");
                }
                return _CUSTOMERS_MV;
            }
        }
        private ObjectSet<CUSTOMER_MV> _CUSTOMERS_MV;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CUSTOMERS EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCUSTOMERS(CUSTOMER cUSTOMER)
        {
            base.AddObject("CUSTOMERS", cUSTOMER);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CUSTOMERS_MV EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCUSTOMERS_MV(CUSTOMER_MV cUSTOMER_MV)
        {
            base.AddObject("CUSTOMERS_MV", cUSTOMER_MV);
        }

        #endregion
        #region Function Imports
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="cMD">No Metadata Documentation available.</param>
        /// <param name="oPTIONS">No Metadata Documentation available.</param>
        /// <param name="rESULT">No Metadata Documentation available.</param>
        /// <param name="xSD_DATA">No Metadata Documentation available.</param>
        /// <param name="eRRMSG">No Metadata Documentation available.</param>
        /// <param name="eRRNUM">No Metadata Documentation available.</param>
        public int GetXmlSubroutine(global::System.String cMD, global::System.String oPTIONS, ObjectParameter rESULT, ObjectParameter xSD_DATA, ObjectParameter eRRMSG, ObjectParameter eRRNUM)
        {
            ObjectParameter cMDParameter;
            if (cMD != null)
            {
                cMDParameter = new ObjectParameter("CMD", cMD);
            }
            else
            {
                cMDParameter = new ObjectParameter("CMD", typeof(global::System.String));
            }
    
            ObjectParameter oPTIONSParameter;
            if (oPTIONS != null)
            {
                oPTIONSParameter = new ObjectParameter("OPTIONS", oPTIONS);
            }
            else
            {
                oPTIONSParameter = new ObjectParameter("OPTIONS", typeof(global::System.String));
            }
    
            return base.ExecuteFunction("GetXmlSubroutine", cMDParameter, oPTIONSParameter, rESULT, xSD_DATA, eRRMSG, eRRNUM);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectResult<CUSTOMER> GetCustomer()
        {
            return base.ExecuteFunction<CUSTOMER>("GetCustomer");
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="mergeOption"></param>
        public ObjectResult<CUSTOMER> GetCustomer(MergeOption mergeOption)
        {
            return base.ExecuteFunction<CUSTOMER>("GetCustomer", mergeOption);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Customer", Name="CUSTOMER")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CUSTOMER : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CUSTOMER object.
        /// </summary>
        /// <param name="cUSTID">Initial value of the CUSTID property.</param>
        public static CUSTOMER CreateCUSTOMER(global::System.Int32 cUSTID)
        {
            CUSTOMER cUSTOMER = new CUSTOMER();
            cUSTOMER.CUSTID = cUSTID;
            return cUSTOMER;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CUSTID
        {
            get
            {
                return _CUSTID;
            }
            set
            {
                if (_CUSTID != value)
                {
                    OnCUSTIDChanging(value);
                    ReportPropertyChanging("CUSTID");
                    _CUSTID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CUSTID");
                    OnCUSTIDChanged();
                }
            }
        }
        private global::System.Int32 _CUSTID;
        partial void OnCUSTIDChanging(global::System.Int32 value);
        partial void OnCUSTIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PHONE
        {
            get
            {
                return _PHONE;
            }
            set
            {
                OnPHONEChanging(value);
                ReportPropertyChanging("PHONE");
                _PHONE = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PHONE");
                OnPHONEChanged();
            }
        }
        private global::System.String _PHONE;
        partial void OnPHONEChanging(global::System.String value);
        partial void OnPHONEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ZIP
        {
            get
            {
                return _ZIP;
            }
            set
            {
                OnZIPChanging(value);
                ReportPropertyChanging("ZIP");
                _ZIP = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ZIP");
                OnZIPChanged();
            }
        }
        private global::System.String _ZIP;
        partial void OnZIPChanging(global::System.String value);
        partial void OnZIPChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String STATENAME
        {
            get
            {
                return _STATENAME;
            }
            set
            {
                OnSTATENAMEChanging(value);
                ReportPropertyChanging("STATENAME");
                _STATENAME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("STATENAME");
                OnSTATENAMEChanged();
            }
        }
        private global::System.String _STATENAME;
        partial void OnSTATENAMEChanging(global::System.String value);
        partial void OnSTATENAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String STATE
        {
            get
            {
                return _STATE;
            }
            set
            {
                OnSTATEChanging(value);
                ReportPropertyChanging("STATE");
                _STATE = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("STATE");
                OnSTATEChanged();
            }
        }
        private global::System.String _STATE;
        partial void OnSTATEChanging(global::System.String value);
        partial void OnSTATEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CITY
        {
            get
            {
                return _CITY;
            }
            set
            {
                OnCITYChanging(value);
                ReportPropertyChanging("CITY");
                _CITY = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CITY");
                OnCITYChanged();
            }
        }
        private global::System.String _CITY;
        partial void OnCITYChanging(global::System.String value);
        partial void OnCITYChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FULLADDR
        {
            get
            {
                return _FULLADDR;
            }
            set
            {
                OnFULLADDRChanging(value);
                ReportPropertyChanging("FULLADDR");
                _FULLADDR = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FULLADDR");
                OnFULLADDRChanged();
            }
        }
        private global::System.String _FULLADDR;
        partial void OnFULLADDRChanging(global::System.String value);
        partial void OnFULLADDRChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ADDR2
        {
            get
            {
                return _ADDR2;
            }
            set
            {
                OnADDR2Changing(value);
                ReportPropertyChanging("ADDR2");
                _ADDR2 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ADDR2");
                OnADDR2Changed();
            }
        }
        private global::System.String _ADDR2;
        partial void OnADDR2Changing(global::System.String value);
        partial void OnADDR2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ADDR1
        {
            get
            {
                return _ADDR1;
            }
            set
            {
                OnADDR1Changing(value);
                ReportPropertyChanging("ADDR1");
                _ADDR1 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ADDR1");
                OnADDR1Changed();
            }
        }
        private global::System.String _ADDR1;
        partial void OnADDR1Changing(global::System.String value);
        partial void OnADDR1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String COMPANY
        {
            get
            {
                return _COMPANY;
            }
            set
            {
                OnCOMPANYChanging(value);
                ReportPropertyChanging("COMPANY");
                _COMPANY = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("COMPANY");
                OnCOMPANYChanged();
            }
        }
        private global::System.String _COMPANY;
        partial void OnCOMPANYChanging(global::System.String value);
        partial void OnCOMPANYChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FULLNAME
        {
            get
            {
                return _FULLNAME;
            }
            set
            {
                OnFULLNAMEChanging(value);
                ReportPropertyChanging("FULLNAME");
                _FULLNAME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FULLNAME");
                OnFULLNAMEChanged();
            }
        }
        private global::System.String _FULLNAME;
        partial void OnFULLNAMEChanging(global::System.String value);
        partial void OnFULLNAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LNAME
        {
            get
            {
                return _LNAME;
            }
            set
            {
                OnLNAMEChanging(value);
                ReportPropertyChanging("LNAME");
                _LNAME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LNAME");
                OnLNAMEChanged();
            }
        }
        private global::System.String _LNAME;
        partial void OnLNAMEChanging(global::System.String value);
        partial void OnLNAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FNAME
        {
            get
            {
                return _FNAME;
            }
            set
            {
                OnFNAMEChanging(value);
                ReportPropertyChanging("FNAME");
                _FNAME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FNAME");
                OnFNAMEChanged();
            }
        }
        private global::System.String _FNAME;
        partial void OnFNAMEChanging(global::System.String value);
        partial void OnFNAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SAL
        {
            get
            {
                return _SAL;
            }
            set
            {
                OnSALChanging(value);
                ReportPropertyChanging("SAL");
                _SAL = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("SAL");
                OnSALChanged();
            }
        }
        private global::System.String _SAL;
        partial void OnSALChanging(global::System.String value);
        partial void OnSALChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Customer", Name="CUSTOMER_MV")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CUSTOMER_MV : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CUSTOMER_MV object.
        /// </summary>
        /// <param name="cUSTID">Initial value of the CUSTID property.</param>
        /// <param name="fNAME">Initial value of the FNAME property.</param>
        /// <param name="lNAME">Initial value of the LNAME property.</param>
        public static CUSTOMER_MV CreateCUSTOMER_MV(global::System.Int32 cUSTID, global::System.String fNAME, global::System.String lNAME)
        {
            CUSTOMER_MV cUSTOMER_MV = new CUSTOMER_MV();
            cUSTOMER_MV.CUSTID = cUSTID;
            cUSTOMER_MV.FNAME = fNAME;
            cUSTOMER_MV.LNAME = lNAME;
            return cUSTOMER_MV;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CUSTID
        {
            get
            {
                return _CUSTID;
            }
            set
            {
                if (_CUSTID != value)
                {
                    OnCUSTIDChanging(value);
                    ReportPropertyChanging("CUSTID");
                    _CUSTID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CUSTID");
                    OnCUSTIDChanged();
                }
            }
        }
        private global::System.Int32 _CUSTID;
        partial void OnCUSTIDChanging(global::System.Int32 value);
        partial void OnCUSTIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FNAME
        {
            get
            {
                return _FNAME;
            }
            set
            {
                OnFNAMEChanging(value);
                ReportPropertyChanging("FNAME");
                _FNAME = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FNAME");
                OnFNAMEChanged();
            }
        }
        private global::System.String _FNAME;
        partial void OnFNAMEChanging(global::System.String value);
        partial void OnFNAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LNAME
        {
            get
            {
                return _LNAME;
            }
            set
            {
                OnLNAMEChanging(value);
                ReportPropertyChanging("LNAME");
                _LNAME = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LNAME");
                OnLNAMEChanged();
            }
        }
        private global::System.String _LNAME;
        partial void OnLNAMEChanging(global::System.String value);
        partial void OnLNAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> SVC_PAID_DATE
        {
            get
            {
                return _SVC_PAID_DATE;
            }
            set
            {
                OnSVC_PAID_DATEChanging(value);
                ReportPropertyChanging("SVC_PAID_DATE");
                _SVC_PAID_DATE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SVC_PAID_DATE");
                OnSVC_PAID_DATEChanged();
            }
        }
        private Nullable<global::System.DateTime> _SVC_PAID_DATE;
        partial void OnSVC_PAID_DATEChanging(Nullable<global::System.DateTime> value);
        partial void OnSVC_PAID_DATEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> SVC_PRICE
        {
            get
            {
                return _SVC_PRICE;
            }
            set
            {
                OnSVC_PRICEChanging(value);
                ReportPropertyChanging("SVC_PRICE");
                _SVC_PRICE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SVC_PRICE");
                OnSVC_PRICEChanged();
            }
        }
        private Nullable<global::System.Int32> _SVC_PRICE;
        partial void OnSVC_PRICEChanging(Nullable<global::System.Int32> value);
        partial void OnSVC_PRICEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> SVC_END
        {
            get
            {
                return _SVC_END;
            }
            set
            {
                OnSVC_ENDChanging(value);
                ReportPropertyChanging("SVC_END");
                _SVC_END = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SVC_END");
                OnSVC_ENDChanged();
            }
        }
        private Nullable<global::System.DateTime> _SVC_END;
        partial void OnSVC_ENDChanging(Nullable<global::System.DateTime> value);
        partial void OnSVC_ENDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> SVC_START
        {
            get
            {
                return _SVC_START;
            }
            set
            {
                OnSVC_STARTChanging(value);
                ReportPropertyChanging("SVC_START");
                _SVC_START = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SVC_START");
                OnSVC_STARTChanged();
            }
        }
        private Nullable<global::System.DateTime> _SVC_START;
        partial void OnSVC_STARTChanging(Nullable<global::System.DateTime> value);
        partial void OnSVC_STARTChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> DISCOUNT
        {
            get
            {
                return _DISCOUNT;
            }
            set
            {
                OnDISCOUNTChanging(value);
                ReportPropertyChanging("DISCOUNT");
                _DISCOUNT = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DISCOUNT");
                OnDISCOUNTChanged();
            }
        }
        private Nullable<global::System.Decimal> _DISCOUNT;
        partial void OnDISCOUNTChanging(Nullable<global::System.Decimal> value);
        partial void OnDISCOUNTChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> PRICE
        {
            get
            {
                return _PRICE;
            }
            set
            {
                OnPRICEChanging(value);
                ReportPropertyChanging("PRICE");
                _PRICE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PRICE");
                OnPRICEChanged();
            }
        }
        private Nullable<global::System.Int32> _PRICE;
        partial void OnPRICEChanging(Nullable<global::System.Int32> value);
        partial void OnPRICEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> LIST_PRICE
        {
            get
            {
                return _LIST_PRICE;
            }
            set
            {
                OnLIST_PRICEChanging(value);
                ReportPropertyChanging("LIST_PRICE");
                _LIST_PRICE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LIST_PRICE");
                OnLIST_PRICEChanged();
            }
        }
        private Nullable<global::System.Int32> _LIST_PRICE;
        partial void OnLIST_PRICEChanging(Nullable<global::System.Int32> value);
        partial void OnLIST_PRICEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> PAID_DATE
        {
            get
            {
                return _PAID_DATE;
            }
            set
            {
                OnPAID_DATEChanging(value);
                ReportPropertyChanging("PAID_DATE");
                _PAID_DATE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PAID_DATE");
                OnPAID_DATEChanged();
            }
        }
        private Nullable<global::System.DateTime> _PAID_DATE;
        partial void OnPAID_DATEChanging(Nullable<global::System.DateTime> value);
        partial void OnPAID_DATEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> BUY_DATE
        {
            get
            {
                return _BUY_DATE;
            }
            set
            {
                OnBUY_DATEChanging(value);
                ReportPropertyChanging("BUY_DATE");
                _BUY_DATE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BUY_DATE");
                OnBUY_DATEChanged();
            }
        }
        private Nullable<global::System.DateTime> _BUY_DATE;
        partial void OnBUY_DATEChanging(Nullable<global::System.DateTime> value);
        partial void OnBUY_DATEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SER_NUM
        {
            get
            {
                return _SER_NUM;
            }
            set
            {
                OnSER_NUMChanging(value);
                ReportPropertyChanging("SER_NUM");
                _SER_NUM = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("SER_NUM");
                OnSER_NUMChanged();
            }
        }
        private global::System.String _SER_NUM;
        partial void OnSER_NUMChanging(global::System.String value);
        partial void OnSER_NUMChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String DESCRIPTION
        {
            get
            {
                return _DESCRIPTION;
            }
            set
            {
                OnDESCRIPTIONChanging(value);
                ReportPropertyChanging("DESCRIPTION");
                _DESCRIPTION = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("DESCRIPTION");
                OnDESCRIPTIONChanged();
            }
        }
        private global::System.String _DESCRIPTION;
        partial void OnDESCRIPTIONChanging(global::System.String value);
        partial void OnDESCRIPTIONChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PRODID
        {
            get
            {
                return _PRODID;
            }
            set
            {
                OnPRODIDChanging(value);
                ReportPropertyChanging("PRODID");
                _PRODID = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PRODID");
                OnPRODIDChanged();
            }
        }
        private global::System.String _PRODID;
        partial void OnPRODIDChanging(global::System.String value);
        partial void OnPRODIDChanged();

        #endregion
    
    }

    #endregion
    
}
