using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitAndSqs.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:sap-com:document:sap:rfc:functions")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:sap-com:document:sap:rfc:functions", IsNullable = false)]
    public partial class ZADP_INVOICE_V1
    {

        private IT_INVOICE_ADDRESS iT_INVOICE_ADDRESSField;

        private IT_INVOICE_LEV1 iT_INVOICE_LEV1Field;

        private IT_INVOICE_LEV2 iT_INVOICE_LEV2Field;

        private IT_INVOICE_LEV2_CB iT_INVOICE_LEV2_CBField;

        private IT_INVOICE_LEV3 iT_INVOICE_LEV3Field;

        private IT_INVOICE_LEV4 iT_INVOICE_LEV4Field;

        private string i_INTERFACEField;

        private I_INVOICE_TOP i_INVOICE_TOPField;

        private string i_TRANSACTIONIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public IT_INVOICE_ADDRESS IT_INVOICE_ADDRESS
        {
            get
            {
                return this.iT_INVOICE_ADDRESSField;
            }
            set
            {
                this.iT_INVOICE_ADDRESSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public IT_INVOICE_LEV1 IT_INVOICE_LEV1
        {
            get
            {
                return this.iT_INVOICE_LEV1Field;
            }
            set
            {
                this.iT_INVOICE_LEV1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public IT_INVOICE_LEV2 IT_INVOICE_LEV2
        {
            get
            {
                return this.iT_INVOICE_LEV2Field;
            }
            set
            {
                this.iT_INVOICE_LEV2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public IT_INVOICE_LEV2_CB IT_INVOICE_LEV2_CB
        {
            get
            {
                return this.iT_INVOICE_LEV2_CBField;
            }
            set
            {
                this.iT_INVOICE_LEV2_CBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public IT_INVOICE_LEV3 IT_INVOICE_LEV3
        {
            get
            {
                return this.iT_INVOICE_LEV3Field;
            }
            set
            {
                this.iT_INVOICE_LEV3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public IT_INVOICE_LEV4 IT_INVOICE_LEV4
        {
            get
            {
                return this.iT_INVOICE_LEV4Field;
            }
            set
            {
                this.iT_INVOICE_LEV4Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string I_INTERFACE
        {
            get
            {
                return this.i_INTERFACEField;
            }
            set
            {
                this.i_INTERFACEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public I_INVOICE_TOP I_INVOICE_TOP
        {
            get
            {
                return this.i_INVOICE_TOPField;
            }
            set
            {
                this.i_INVOICE_TOPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string I_TRANSACTIONID
        {
            get
            {
                return this.i_TRANSACTIONIDField;
            }
            set
            {
                this.i_TRANSACTIONIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class IT_INVOICE_ADDRESS
    {

        private IT_INVOICE_ADDRESSItem itemField;

        /// <remarks/>
        public IT_INVOICE_ADDRESSItem item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IT_INVOICE_ADDRESSItem
    {

        private byte iNVOICEIDField;

        private string sAP_PAYERIDField;

        private object aDP_CUSTOMERIDField;

        private string nAMEField;

        private string sTREETField;

        private string sTREET2Field;

        private string pOSTL_CODEField;

        private string cITYField;

        private string cOUNTRYField;

        private string iNVOICEATTNOFField;

        private string cVRField;

        private string eMAILField;

        private string cUST_PROFILEField;

        private string iNVOICE_DISPATCHField;

        private string tAXCODEField;

        /// <remarks/>
        public byte INVOICEID
        {
            get
            {
                return this.iNVOICEIDField;
            }
            set
            {
                this.iNVOICEIDField = value;
            }
        }

        /// <remarks/>
        public string SAP_PAYERID
        {
            get
            {
                return this.sAP_PAYERIDField;
            }
            set
            {
                this.sAP_PAYERIDField = value;
            }
        }

        /// <remarks/>
        public object ADP_CUSTOMERID
        {
            get
            {
                return this.aDP_CUSTOMERIDField;
            }
            set
            {
                this.aDP_CUSTOMERIDField = value;
            }
        }

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string STREET
        {
            get
            {
                return this.sTREETField;
            }
            set
            {
                this.sTREETField = value;
            }
        }

        /// <remarks/>
        public string STREET2
        {
            get
            {
                return this.sTREET2Field;
            }
            set
            {
                this.sTREET2Field = value;
            }
        }

        /// <remarks/>
        public string POSTL_CODE
        {
            get
            {
                return this.pOSTL_CODEField;
            }
            set
            {
                this.pOSTL_CODEField = value;
            }
        }

        /// <remarks/>
        public string CITY
        {
            get
            {
                return this.cITYField;
            }
            set
            {
                this.cITYField = value;
            }
        }

        /// <remarks/>
        public string COUNTRY
        {
            get
            {
                return this.cOUNTRYField;
            }
            set
            {
                this.cOUNTRYField = value;
            }
        }

        /// <remarks/>
        public string INVOICEATTNOF
        {
            get
            {
                return this.iNVOICEATTNOFField;
            }
            set
            {
                this.iNVOICEATTNOFField = value;
            }
        }

        /// <remarks/>
        public string CVR
        {
            get
            {
                return this.cVRField;
            }
            set
            {
                this.cVRField = value;
            }
        }

        /// <remarks/>
        public string EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string CUST_PROFILE
        {
            get
            {
                return this.cUST_PROFILEField;
            }
            set
            {
                this.cUST_PROFILEField = value;
            }
        }

        /// <remarks/>
        public string INVOICE_DISPATCH
        {
            get
            {
                return this.iNVOICE_DISPATCHField;
            }
            set
            {
                this.iNVOICE_DISPATCHField = value;
            }
        }

        /// <remarks/>
        public string TAXCODE
        {
            get
            {
                return this.tAXCODEField;
            }
            set
            {
                this.tAXCODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class IT_INVOICE_LEV1
    {

        private IT_INVOICE_LEV1Item itemField;

        /// <remarks/>
        public IT_INVOICE_LEV1Item item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IT_INVOICE_LEV1Item
    {

        private byte iNVOICEIDField;

        private string iNVOICETYPEField;

        private string iNVOICE_OFFICEField;

        private string sAP_PAYERIDField;

        private string sAP_CUSTOMERIDField;

        private object eAN_NUMBERField;

        private string iNVOICEDATEField;

        private string pAYMENTTERMSField;

        private string pAYMENTTERMSTEXTField;

        private string dUEDATEField;

        private string cURRENCYField;

        private byte eXCHANGE_RATEField;

        private string eXCHAN_RATE_DATEField;

        private byte iNVOICE_AMOUNTField;

        private byte iNVOICEVATAMOUNTField;

        /// <remarks/>
        public byte INVOICEID
        {
            get
            {
                return this.iNVOICEIDField;
            }
            set
            {
                this.iNVOICEIDField = value;
            }
        }

        /// <remarks/>
        public string INVOICETYPE
        {
            get
            {
                return this.iNVOICETYPEField;
            }
            set
            {
                this.iNVOICETYPEField = value;
            }
        }

        /// <remarks/>
        public string INVOICE_OFFICE
        {
            get
            {
                return this.iNVOICE_OFFICEField;
            }
            set
            {
                this.iNVOICE_OFFICEField = value;
            }
        }

        /// <remarks/>
        public string SAP_PAYERID
        {
            get
            {
                return this.sAP_PAYERIDField;
            }
            set
            {
                this.sAP_PAYERIDField = value;
            }
        }

        /// <remarks/>
        public string SAP_CUSTOMERID
        {
            get
            {
                return this.sAP_CUSTOMERIDField;
            }
            set
            {
                this.sAP_CUSTOMERIDField = value;
            }
        }

        /// <remarks/>
        public object EAN_NUMBER
        {
            get
            {
                return this.eAN_NUMBERField;
            }
            set
            {
                this.eAN_NUMBERField = value;
            }
        }

        /// <remarks/>
        public string INVOICEDATE
        {
            get
            {
                return this.iNVOICEDATEField;
            }
            set
            {
                this.iNVOICEDATEField = value;
            }
        }

        /// <remarks/>
        public string PAYMENTTERMS
        {
            get
            {
                return this.pAYMENTTERMSField;
            }
            set
            {
                this.pAYMENTTERMSField = value;
            }
        }

        /// <remarks/>
        public string PAYMENTTERMSTEXT
        {
            get
            {
                return this.pAYMENTTERMSTEXTField;
            }
            set
            {
                this.pAYMENTTERMSTEXTField = value;
            }
        }

        /// <remarks/>
        public string DUEDATE
        {
            get
            {
                return this.dUEDATEField;
            }
            set
            {
                this.dUEDATEField = value;
            }
        }

        /// <remarks/>
        public string CURRENCY
        {
            get
            {
                return this.cURRENCYField;
            }
            set
            {
                this.cURRENCYField = value;
            }
        }

        /// <remarks/>
        public byte EXCHANGE_RATE
        {
            get
            {
                return this.eXCHANGE_RATEField;
            }
            set
            {
                this.eXCHANGE_RATEField = value;
            }
        }

        /// <remarks/>
        public string EXCHAN_RATE_DATE
        {
            get
            {
                return this.eXCHAN_RATE_DATEField;
            }
            set
            {
                this.eXCHAN_RATE_DATEField = value;
            }
        }

        /// <remarks/>
        public byte INVOICE_AMOUNT
        {
            get
            {
                return this.iNVOICE_AMOUNTField;
            }
            set
            {
                this.iNVOICE_AMOUNTField = value;
            }
        }

        /// <remarks/>
        public byte INVOICEVATAMOUNT
        {
            get
            {
                return this.iNVOICEVATAMOUNTField;
            }
            set
            {
                this.iNVOICEVATAMOUNTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class IT_INVOICE_LEV2
    {

        private IT_INVOICE_LEV2Item itemField;

        /// <remarks/>
        public IT_INVOICE_LEV2Item item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IT_INVOICE_LEV2Item
    {

        private byte iNVOICEIDField;

        private byte oRDERIDField;

        private string oRDERNAMEField;

        private string oRDERNOTEField;

        private string sELLINGOFFICEField;

        private string pREPAY_REQUIREDField;

        private string iNVOICE_METHODField;

        private object cONTRACTIDField;

        private string cONTRACTTYPEField;

        private string cONTRACTREFNOField;

        private string cONTRACTNOTEField;

        private string cONTRACTDATEField;

        private string cONTRACTSTARTField;

        private string cONTRACTENDField;

        private byte cONTRACTAMOUNTField;

        private string cONTRACTCURRField;

        private string eINVOICEACCINFOField;

        private string pURCHASEORDERNOField;

        /// <remarks/>
        public byte INVOICEID
        {
            get
            {
                return this.iNVOICEIDField;
            }
            set
            {
                this.iNVOICEIDField = value;
            }
        }

        /// <remarks/>
        public byte ORDERID
        {
            get
            {
                return this.oRDERIDField;
            }
            set
            {
                this.oRDERIDField = value;
            }
        }

        /// <remarks/>
        public string ORDERNAME
        {
            get
            {
                return this.oRDERNAMEField;
            }
            set
            {
                this.oRDERNAMEField = value;
            }
        }

        /// <remarks/>
        public string ORDERNOTE
        {
            get
            {
                return this.oRDERNOTEField;
            }
            set
            {
                this.oRDERNOTEField = value;
            }
        }

        /// <remarks/>
        public string SELLINGOFFICE
        {
            get
            {
                return this.sELLINGOFFICEField;
            }
            set
            {
                this.sELLINGOFFICEField = value;
            }
        }

        /// <remarks/>
        public string PREPAY_REQUIRED
        {
            get
            {
                return this.pREPAY_REQUIREDField;
            }
            set
            {
                this.pREPAY_REQUIREDField = value;
            }
        }

        /// <remarks/>
        public string INVOICE_METHOD
        {
            get
            {
                return this.iNVOICE_METHODField;
            }
            set
            {
                this.iNVOICE_METHODField = value;
            }
        }

        /// <remarks/>
        public object CONTRACTID
        {
            get
            {
                return this.cONTRACTIDField;
            }
            set
            {
                this.cONTRACTIDField = value;
            }
        }

        /// <remarks/>
        public string CONTRACTTYPE
        {
            get
            {
                return this.cONTRACTTYPEField;
            }
            set
            {
                this.cONTRACTTYPEField = value;
            }
        }

        /// <remarks/>
        public string CONTRACTREFNO
        {
            get
            {
                return this.cONTRACTREFNOField;
            }
            set
            {
                this.cONTRACTREFNOField = value;
            }
        }

        /// <remarks/>
        public string CONTRACTNOTE
        {
            get
            {
                return this.cONTRACTNOTEField;
            }
            set
            {
                this.cONTRACTNOTEField = value;
            }
        }

        /// <remarks/>
        public string CONTRACTDATE
        {
            get
            {
                return this.cONTRACTDATEField;
            }
            set
            {
                this.cONTRACTDATEField = value;
            }
        }

        /// <remarks/>
        public string CONTRACTSTART
        {
            get
            {
                return this.cONTRACTSTARTField;
            }
            set
            {
                this.cONTRACTSTARTField = value;
            }
        }

        /// <remarks/>
        public string CONTRACTEND
        {
            get
            {
                return this.cONTRACTENDField;
            }
            set
            {
                this.cONTRACTENDField = value;
            }
        }

        /// <remarks/>
        public byte CONTRACTAMOUNT
        {
            get
            {
                return this.cONTRACTAMOUNTField;
            }
            set
            {
                this.cONTRACTAMOUNTField = value;
            }
        }

        /// <remarks/>
        public string CONTRACTCURR
        {
            get
            {
                return this.cONTRACTCURRField;
            }
            set
            {
                this.cONTRACTCURRField = value;
            }
        }

        /// <remarks/>
        public string EINVOICEACCINFO
        {
            get
            {
                return this.eINVOICEACCINFOField;
            }
            set
            {
                this.eINVOICEACCINFOField = value;
            }
        }

        /// <remarks/>
        public string PURCHASEORDERNO
        {
            get
            {
                return this.pURCHASEORDERNOField;
            }
            set
            {
                this.pURCHASEORDERNOField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class IT_INVOICE_LEV2_CB
    {

        private IT_INVOICE_LEV2_CBItem itemField;

        /// <remarks/>
        public IT_INVOICE_LEV2_CBItem item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IT_INVOICE_LEV2_CBItem
    {

        private object iNVOICEIDField;

        private object oRDERIDField;

        private string cATCHBATCH_EXNOField;

        /// <remarks/>
        public object INVOICEID
        {
            get
            {
                return this.iNVOICEIDField;
            }
            set
            {
                this.iNVOICEIDField = value;
            }
        }

        /// <remarks/>
        public object ORDERID
        {
            get
            {
                return this.oRDERIDField;
            }
            set
            {
                this.oRDERIDField = value;
            }
        }

        /// <remarks/>
        public string CATCHBATCH_EXNO
        {
            get
            {
                return this.cATCHBATCH_EXNOField;
            }
            set
            {
                this.cATCHBATCH_EXNOField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class IT_INVOICE_LEV3
    {

        private IT_INVOICE_LEV3Item itemField;

        /// <remarks/>
        public IT_INVOICE_LEV3Item item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IT_INVOICE_LEV3Item
    {

        private byte iNVOICEIDField;

        private byte oRDERIDField;

        private byte aDIDField;

        private string aDNAMEField;

        private object oRIGINALDOCIDField;

        private string aDPATTERNNAMEField;

        private string mEDIABRANDField;

        private string mEDIANAMEField;

        private string pUBLICATIONDATEField;

        private string pUB_STARTDATEField;

        private string pUB_ENDDATEField;

        private string pLACEMENTNAMEField;

        private string aDSIZENAMEField;

        private string aDSIZEHIGHTMMField;

        private string aDSIZEWIDTHCOLField;

        private string aDSIZEWIDTHMMField;

        private string iNSERTWEIGHTField;

        private byte aD_AMOUNTField;

        private string qUANTITYTYPEField;

        private byte qUANTITYField;

        private string pOSTING_FLAGField;

        private string cATCHBATCH_EXNOField;

        /// <remarks/>
        public byte INVOICEID
        {
            get
            {
                return this.iNVOICEIDField;
            }
            set
            {
                this.iNVOICEIDField = value;
            }
        }

        /// <remarks/>
        public byte ORDERID
        {
            get
            {
                return this.oRDERIDField;
            }
            set
            {
                this.oRDERIDField = value;
            }
        }

        /// <remarks/>
        public byte ADID
        {
            get
            {
                return this.aDIDField;
            }
            set
            {
                this.aDIDField = value;
            }
        }

        /// <remarks/>
        public string ADNAME
        {
            get
            {
                return this.aDNAMEField;
            }
            set
            {
                this.aDNAMEField = value;
            }
        }

        /// <remarks/>
        public object ORIGINALDOCID
        {
            get
            {
                return this.oRIGINALDOCIDField;
            }
            set
            {
                this.oRIGINALDOCIDField = value;
            }
        }

        /// <remarks/>
        public string ADPATTERNNAME
        {
            get
            {
                return this.aDPATTERNNAMEField;
            }
            set
            {
                this.aDPATTERNNAMEField = value;
            }
        }

        /// <remarks/>
        public string MEDIABRAND
        {
            get
            {
                return this.mEDIABRANDField;
            }
            set
            {
                this.mEDIABRANDField = value;
            }
        }

        /// <remarks/>
        public string MEDIANAME
        {
            get
            {
                return this.mEDIANAMEField;
            }
            set
            {
                this.mEDIANAMEField = value;
            }
        }

        /// <remarks/>
        public string PUBLICATIONDATE
        {
            get
            {
                return this.pUBLICATIONDATEField;
            }
            set
            {
                this.pUBLICATIONDATEField = value;
            }
        }

        /// <remarks/>
        public string PUB_STARTDATE
        {
            get
            {
                return this.pUB_STARTDATEField;
            }
            set
            {
                this.pUB_STARTDATEField = value;
            }
        }

        /// <remarks/>
        public string PUB_ENDDATE
        {
            get
            {
                return this.pUB_ENDDATEField;
            }
            set
            {
                this.pUB_ENDDATEField = value;
            }
        }

        /// <remarks/>
        public string PLACEMENTNAME
        {
            get
            {
                return this.pLACEMENTNAMEField;
            }
            set
            {
                this.pLACEMENTNAMEField = value;
            }
        }

        /// <remarks/>
        public string ADSIZENAME
        {
            get
            {
                return this.aDSIZENAMEField;
            }
            set
            {
                this.aDSIZENAMEField = value;
            }
        }

        /// <remarks/>
        public string ADSIZEHIGHTMM
        {
            get
            {
                return this.aDSIZEHIGHTMMField;
            }
            set
            {
                this.aDSIZEHIGHTMMField = value;
            }
        }

        /// <remarks/>
        public string ADSIZEWIDTHCOL
        {
            get
            {
                return this.aDSIZEWIDTHCOLField;
            }
            set
            {
                this.aDSIZEWIDTHCOLField = value;
            }
        }

        /// <remarks/>
        public string ADSIZEWIDTHMM
        {
            get
            {
                return this.aDSIZEWIDTHMMField;
            }
            set
            {
                this.aDSIZEWIDTHMMField = value;
            }
        }

        /// <remarks/>
        public string INSERTWEIGHT
        {
            get
            {
                return this.iNSERTWEIGHTField;
            }
            set
            {
                this.iNSERTWEIGHTField = value;
            }
        }

        /// <remarks/>
        public byte AD_AMOUNT
        {
            get
            {
                return this.aD_AMOUNTField;
            }
            set
            {
                this.aD_AMOUNTField = value;
            }
        }

        /// <remarks/>
        public string QUANTITYTYPE
        {
            get
            {
                return this.qUANTITYTYPEField;
            }
            set
            {
                this.qUANTITYTYPEField = value;
            }
        }

        /// <remarks/>
        public byte QUANTITY
        {
            get
            {
                return this.qUANTITYField;
            }
            set
            {
                this.qUANTITYField = value;
            }
        }

        /// <remarks/>
        public string POSTING_FLAG
        {
            get
            {
                return this.pOSTING_FLAGField;
            }
            set
            {
                this.pOSTING_FLAGField = value;
            }
        }

        /// <remarks/>
        public string CATCHBATCH_EXNO
        {
            get
            {
                return this.cATCHBATCH_EXNOField;
            }
            set
            {
                this.cATCHBATCH_EXNOField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class IT_INVOICE_LEV4
    {

        private IT_INVOICE_LEV4Item itemField;

        /// <remarks/>
        public IT_INVOICE_LEV4Item item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IT_INVOICE_LEV4Item
    {

        private byte iNVOICEIDField;

        private byte oRDERIDField;

        private byte aDIDField;

        private string aPPLY_ORDERField;

        private string iTEMDETAILNAMEField;

        private object bILLINGPROFILENAField;

        private byte iTEMDETAILAMOUNTField;

        private string iTEMDETAILSUPPTEField;

        private string dIMENSION1Field;

        private string dIMENSION2Field;

        private string dIMENSION3Field;

        private string dIMENSION4Field;

        private string dIMENSION5Field;

        /// <remarks/>
        public byte INVOICEID
        {
            get
            {
                return this.iNVOICEIDField;
            }
            set
            {
                this.iNVOICEIDField = value;
            }
        }

        /// <remarks/>
        public byte ORDERID
        {
            get
            {
                return this.oRDERIDField;
            }
            set
            {
                this.oRDERIDField = value;
            }
        }

        /// <remarks/>
        public byte ADID
        {
            get
            {
                return this.aDIDField;
            }
            set
            {
                this.aDIDField = value;
            }
        }

        /// <remarks/>
        public string APPLY_ORDER
        {
            get
            {
                return this.aPPLY_ORDERField;
            }
            set
            {
                this.aPPLY_ORDERField = value;
            }
        }

        /// <remarks/>
        public string ITEMDETAILNAME
        {
            get
            {
                return this.iTEMDETAILNAMEField;
            }
            set
            {
                this.iTEMDETAILNAMEField = value;
            }
        }

        /// <remarks/>
        public object BILLINGPROFILENA
        {
            get
            {
                return this.bILLINGPROFILENAField;
            }
            set
            {
                this.bILLINGPROFILENAField = value;
            }
        }

        /// <remarks/>
        public byte ITEMDETAILAMOUNT
        {
            get
            {
                return this.iTEMDETAILAMOUNTField;
            }
            set
            {
                this.iTEMDETAILAMOUNTField = value;
            }
        }

        /// <remarks/>
        public string ITEMDETAILSUPPTE
        {
            get
            {
                return this.iTEMDETAILSUPPTEField;
            }
            set
            {
                this.iTEMDETAILSUPPTEField = value;
            }
        }

        /// <remarks/>
        public string DIMENSION1
        {
            get
            {
                return this.dIMENSION1Field;
            }
            set
            {
                this.dIMENSION1Field = value;
            }
        }

        /// <remarks/>
        public string DIMENSION2
        {
            get
            {
                return this.dIMENSION2Field;
            }
            set
            {
                this.dIMENSION2Field = value;
            }
        }

        /// <remarks/>
        public string DIMENSION3
        {
            get
            {
                return this.dIMENSION3Field;
            }
            set
            {
                this.dIMENSION3Field = value;
            }
        }

        /// <remarks/>
        public string DIMENSION4
        {
            get
            {
                return this.dIMENSION4Field;
            }
            set
            {
                this.dIMENSION4Field = value;
            }
        }

        /// <remarks/>
        public string DIMENSION5
        {
            get
            {
                return this.dIMENSION5Field;
            }
            set
            {
                this.dIMENSION5Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class I_INVOICE_TOP
    {

        private string iNVOICE_BATCHField;

        private string cREATION_DATEField;

        private string cREATION_TIMEField;

        private string cREATION_USERField;

        private string iNVOICEBATCHNAMEField;

        private string aDB_START_DATEField;

        private string aDB_END_DATEField;

        /// <remarks/>
        public string INVOICE_BATCH
        {
            get
            {
                return this.iNVOICE_BATCHField;
            }
            set
            {
                this.iNVOICE_BATCHField = value;
            }
        }

        /// <remarks/>
        public string CREATION_DATE
        {
            get
            {
                return this.cREATION_DATEField;
            }
            set
            {
                this.cREATION_DATEField = value;
            }
        }

        /// <remarks/>
        public string CREATION_TIME
        {
            get
            {
                return this.cREATION_TIMEField;
            }
            set
            {
                this.cREATION_TIMEField = value;
            }
        }

        /// <remarks/>
        public string CREATION_USER
        {
            get
            {
                return this.cREATION_USERField;
            }
            set
            {
                this.cREATION_USERField = value;
            }
        }

        /// <remarks/>
        public string INVOICEBATCHNAME
        {
            get
            {
                return this.iNVOICEBATCHNAMEField;
            }
            set
            {
                this.iNVOICEBATCHNAMEField = value;
            }
        }

        /// <remarks/>
        public string ADB_START_DATE
        {
            get
            {
                return this.aDB_START_DATEField;
            }
            set
            {
                this.aDB_START_DATEField = value;
            }
        }

        /// <remarks/>
        public string ADB_END_DATE
        {
            get
            {
                return this.aDB_END_DATEField;
            }
            set
            {
                this.aDB_END_DATEField = value;
            }
        }
    }

}
