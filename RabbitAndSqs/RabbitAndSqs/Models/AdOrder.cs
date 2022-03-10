using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitAndSqs.Models
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.adsml.org/adsmlbookings/2.5", IsNullable = false)]
    public partial class AdsMLBookings
    {

        private Header headerField;

        private AdsMLBookingsAdOrder adOrderField;

        private string transmissionIDField;

        private string transmissionStatusField;

        private System.DateTime firstTransmissionDateTimeField;

        private System.DateTime transmissionDateTimeField;

        private string systemsIDField;

        private byte transmissionSequenceField;

        private bool administrativeResponseRequiredField;

        private byte sendCountField;

        private string schemaVersionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public Header Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        public AdsMLBookingsAdOrder AdOrder
        {
            get
            {
                return this.adOrderField;
            }
            set
            {
                this.adOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string transmissionID
        {
            get
            {
                return this.transmissionIDField;
            }
            set
            {
                this.transmissionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string transmissionStatus
        {
            get
            {
                return this.transmissionStatusField;
            }
            set
            {
                this.transmissionStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public System.DateTime firstTransmissionDateTime
        {
            get
            {
                return this.firstTransmissionDateTimeField;
            }
            set
            {
                this.firstTransmissionDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public System.DateTime transmissionDateTime
        {
            get
            {
                return this.transmissionDateTimeField;
            }
            set
            {
                this.transmissionDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string systemsID
        {
            get
            {
                return this.systemsIDField;
            }
            set
            {
                this.systemsIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public byte transmissionSequence
        {
            get
            {
                return this.transmissionSequenceField;
            }
            set
            {
                this.transmissionSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public bool administrativeResponseRequired
        {
            get
            {
                return this.administrativeResponseRequiredField;
            }
            set
            {
                this.administrativeResponseRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public byte sendCount
        {
            get
            {
                return this.sendCountField;
            }
            set
            {
                this.sendCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string schemaVersion
        {
            get
            {
                return this.schemaVersionField;
            }
            set
            {
                this.schemaVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0", IsNullable = false)]
    public partial class Header
    {

        private HeaderTransmissionFrom transmissionFromField;

        private HeaderTransmissionTo transmissionToField;

        /// <remarks/>
        public HeaderTransmissionFrom TransmissionFrom
        {
            get
            {
                return this.transmissionFromField;
            }
            set
            {
                this.transmissionFromField = value;
            }
        }

        /// <remarks/>
        public HeaderTransmissionTo TransmissionTo
        {
            get
            {
                return this.transmissionToField;
            }
            set
            {
                this.transmissionToField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class HeaderTransmissionFrom
    {

        private HeaderTransmissionFromIdentifier identifierField;

        private string nameField;

        /// <remarks/>
        public HeaderTransmissionFromIdentifier Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class HeaderTransmissionFromIdentifier
    {

        private string iDLabelField;

        private string iDValueField;

        /// <remarks/>
        public string IDLabel
        {
            get
            {
                return this.iDLabelField;
            }
            set
            {
                this.iDLabelField = value;
            }
        }

        /// <remarks/>
        public string IDValue
        {
            get
            {
                return this.iDValueField;
            }
            set
            {
                this.iDValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class HeaderTransmissionTo
    {

        private HeaderTransmissionToIdentifier identifierField;

        private string nameField;

        /// <remarks/>
        public HeaderTransmissionToIdentifier Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class HeaderTransmissionToIdentifier
    {

        private string iDLabelField;

        private string iDValueField;

        /// <remarks/>
        public string IDLabel
        {
            get
            {
                return this.iDLabelField;
            }
            set
            {
                this.iDLabelField = value;
            }
        }

        /// <remarks/>
        public string IDValue
        {
            get
            {
                return this.iDValueField;
            }
            set
            {
                this.iDValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrder
    {

        private string bookingIdentifierField;

        private AdsMLBookingsAdOrderAuxiliaryBookingReferences auxiliaryBookingReferencesField;

        private System.DateTime businessMessageDateField;

        private BookingParty bookingPartyField;

        private SellingParty sellingPartyField;

        private Campaign campaignField;

        private AdsMLBookingsAdOrderPlacementNewspaperMagazine placementNewspaperMagazineField;

        private string messageClassField;

        private string messageIDField;

        private string messageCodeField;

        /// <remarks/>
        public string BookingIdentifier
        {
            get
            {
                return this.bookingIdentifierField;
            }
            set
            {
                this.bookingIdentifierField = value;
            }
        }

        /// <remarks/>
        public AdsMLBookingsAdOrderAuxiliaryBookingReferences AuxiliaryBookingReferences
        {
            get
            {
                return this.auxiliaryBookingReferencesField;
            }
            set
            {
                this.auxiliaryBookingReferencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public System.DateTime BusinessMessageDate
        {
            get
            {
                return this.businessMessageDateField;
            }
            set
            {
                this.businessMessageDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public BookingParty BookingParty
        {
            get
            {
                return this.bookingPartyField;
            }
            set
            {
                this.bookingPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public SellingParty SellingParty
        {
            get
            {
                return this.sellingPartyField;
            }
            set
            {
                this.sellingPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public Campaign Campaign
        {
            get
            {
                return this.campaignField;
            }
            set
            {
                this.campaignField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Placement.NewspaperMagazine")]
        public AdsMLBookingsAdOrderPlacementNewspaperMagazine PlacementNewspaperMagazine
        {
            get
            {
                return this.placementNewspaperMagazineField;
            }
            set
            {
                this.placementNewspaperMagazineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string messageClass
        {
            get
            {
                return this.messageClassField;
            }
            set
            {
                this.messageClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string messageID
        {
            get
            {
                return this.messageIDField;
            }
            set
            {
                this.messageIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string messageCode
        {
            get
            {
                return this.messageCodeField;
            }
            set
            {
                this.messageCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderAuxiliaryBookingReferences
    {

        private uint buyersReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public uint BuyersReference
        {
            get
            {
                return this.buyersReferenceField;
            }
            set
            {
                this.buyersReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0", IsNullable = false)]
    public partial class BookingParty
    {

        private BookingPartyIdentifier identifierField;

        private string nameField;

        private BookingPartyPartyAddress partyAddressField;

        private BookingPartyContact contactField;

        /// <remarks/>
        public BookingPartyIdentifier Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public BookingPartyPartyAddress PartyAddress
        {
            get
            {
                return this.partyAddressField;
            }
            set
            {
                this.partyAddressField = value;
            }
        }

        /// <remarks/>
        public BookingPartyContact Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class BookingPartyIdentifier
    {

        private string iDLabelField;

        private string iDValueField;

        /// <remarks/>
        public string IDLabel
        {
            get
            {
                return this.iDLabelField;
            }
            set
            {
                this.iDLabelField = value;
            }
        }

        /// <remarks/>
        public string IDValue
        {
            get
            {
                return this.iDValueField;
            }
            set
            {
                this.iDValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class BookingPartyPartyAddress
    {

        private BookingPartyPartyAddressCommunicationChannelPhysicalAddress communicationChannelPhysicalAddressField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommunicationChannel.PhysicalAddress")]
        public BookingPartyPartyAddressCommunicationChannelPhysicalAddress CommunicationChannelPhysicalAddress
        {
            get
            {
                return this.communicationChannelPhysicalAddressField;
            }
            set
            {
                this.communicationChannelPhysicalAddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class BookingPartyPartyAddressCommunicationChannelPhysicalAddress
    {

        private string streetField;

        private ushort zipPostalCodeField;

        private string cityField;

        private string countryCodeField;

        /// <remarks/>
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public ushort ZipPostalCode
        {
            get
            {
                return this.zipPostalCodeField;
            }
            set
            {
                this.zipPostalCodeField = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class BookingPartyContact
    {

        private string nameField;

        private BookingPartyContactCommunicationChannelPhone communicationChannelPhoneField;

        private BookingPartyContactCommunicationChannelEMail communicationChannelEMailField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommunicationChannel.Phone")]
        public BookingPartyContactCommunicationChannelPhone CommunicationChannelPhone
        {
            get
            {
                return this.communicationChannelPhoneField;
            }
            set
            {
                this.communicationChannelPhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommunicationChannel.EMail")]
        public BookingPartyContactCommunicationChannelEMail CommunicationChannelEMail
        {
            get
            {
                return this.communicationChannelEMailField;
            }
            set
            {
                this.communicationChannelEMailField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class BookingPartyContactCommunicationChannelPhone
    {

        private string typeField;

        private uint phoneNumberField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public uint PhoneNumber
        {
            get
            {
                return this.phoneNumberField;
            }
            set
            {
                this.phoneNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class BookingPartyContactCommunicationChannelEMail
    {

        private string eMailAddressField;

        /// <remarks/>
        public string EMailAddress
        {
            get
            {
                return this.eMailAddressField;
            }
            set
            {
                this.eMailAddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0", IsNullable = false)]
    public partial class SellingParty
    {

        private SellingPartyIdentifier identifierField;

        private string nameField;

        /// <remarks/>
        public SellingPartyIdentifier Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class SellingPartyIdentifier
    {

        private string iDLabelField;

        private string iDValueField;

        /// <remarks/>
        public string IDLabel
        {
            get
            {
                return this.iDLabelField;
            }
            set
            {
                this.iDLabelField = value;
            }
        }

        /// <remarks/>
        public string IDValue
        {
            get
            {
                return this.iDValueField;
            }
            set
            {
                this.iDValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0", IsNullable = false)]
    public partial class Campaign
    {

        private uint codeValueField;

        private string descriptionField;

        /// <remarks/>
        public uint CodeValue
        {
            get
            {
                return this.codeValueField;
            }
            set
            {
                this.codeValueField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazine
    {

        private string placementIdentifierField;

        private bool isStandAloneField;

        private AdType adTypeField;

        private AdsMLBookingsAdOrderPlacementNewspaperMagazineAdvertiserBrand advertiserBrandField;

        private DocumentRendering[] documentRenderingField;

        private AdsMLBookingsAdOrderPlacementNewspaperMagazinePublication publicationField;

        private AdsMLBookingsAdOrderPlacementNewspaperMagazineInsertionPeriod insertionPeriodField;

        private AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazine productionDetailNewspaperMagazineField;

        private AdContent adContentField;

        /// <remarks/>
        public string PlacementIdentifier
        {
            get
            {
                return this.placementIdentifierField;
            }
            set
            {
                this.placementIdentifierField = value;
            }
        }

        /// <remarks/>
        public bool IsStandAlone
        {
            get
            {
                return this.isStandAloneField;
            }
            set
            {
                this.isStandAloneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public AdType AdType
        {
            get
            {
                return this.adTypeField;
            }
            set
            {
                this.adTypeField = value;
            }
        }

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazineAdvertiserBrand AdvertiserBrand
        {
            get
            {
                return this.advertiserBrandField;
            }
            set
            {
                this.advertiserBrandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentRendering", Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public DocumentRendering[] DocumentRendering
        {
            get
            {
                return this.documentRenderingField;
            }
            set
            {
                this.documentRenderingField = value;
            }
        }

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazinePublication Publication
        {
            get
            {
                return this.publicationField;
            }
            set
            {
                this.publicationField = value;
            }
        }

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazineInsertionPeriod InsertionPeriod
        {
            get
            {
                return this.insertionPeriodField;
            }
            set
            {
                this.insertionPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductionDetail.NewspaperMagazine")]
        public AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazine ProductionDetailNewspaperMagazine
        {
            get
            {
                return this.productionDetailNewspaperMagazineField;
            }
            set
            {
                this.productionDetailNewspaperMagazineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/adsmlmaterials/2.5")]
        public AdContent AdContent
        {
            get
            {
                return this.adContentField;
            }
            set
            {
                this.adContentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0", IsNullable = false)]
    public partial class AdType
    {

        private string codeValueField;

        /// <remarks/>
        public string CodeValue
        {
            get
            {
                return this.codeValueField;
            }
            set
            {
                this.codeValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazineAdvertiserBrand
    {

        private Advertiser advertiserField;

        private AdsMLBookingsAdOrderPlacementNewspaperMagazineAdvertiserBrandBrand brandField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public Advertiser Advertiser
        {
            get
            {
                return this.advertiserField;
            }
            set
            {
                this.advertiserField = value;
            }
        }

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazineAdvertiserBrandBrand Brand
        {
            get
            {
                return this.brandField;
            }
            set
            {
                this.brandField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0", IsNullable = false)]
    public partial class Advertiser
    {

        private AdvertiserIdentifier[] identifierField;

        private string nameField;

        private AdvertiserPartyAddress partyAddressField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Identifier")]
        public AdvertiserIdentifier[] Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public AdvertiserPartyAddress PartyAddress
        {
            get
            {
                return this.partyAddressField;
            }
            set
            {
                this.partyAddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class AdvertiserIdentifier
    {

        private string iDLabelField;

        private string iDValueField;

        /// <remarks/>
        public string IDLabel
        {
            get
            {
                return this.iDLabelField;
            }
            set
            {
                this.iDLabelField = value;
            }
        }

        /// <remarks/>
        public string IDValue
        {
            get
            {
                return this.iDValueField;
            }
            set
            {
                this.iDValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class AdvertiserPartyAddress
    {

        private AdvertiserPartyAddressCommunicationChannelPhysicalAddress communicationChannelPhysicalAddressField;

        private AdvertiserPartyAddressCommunicationChannelPhone communicationChannelPhoneField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommunicationChannel.PhysicalAddress")]
        public AdvertiserPartyAddressCommunicationChannelPhysicalAddress CommunicationChannelPhysicalAddress
        {
            get
            {
                return this.communicationChannelPhysicalAddressField;
            }
            set
            {
                this.communicationChannelPhysicalAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommunicationChannel.Phone")]
        public AdvertiserPartyAddressCommunicationChannelPhone CommunicationChannelPhone
        {
            get
            {
                return this.communicationChannelPhoneField;
            }
            set
            {
                this.communicationChannelPhoneField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class AdvertiserPartyAddressCommunicationChannelPhysicalAddress
    {

        private string[] streetField;

        private ushort zipPostalCodeField;

        private string cityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Street")]
        public string[] Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public ushort ZipPostalCode
        {
            get
            {
                return this.zipPostalCodeField;
            }
            set
            {
                this.zipPostalCodeField = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class AdvertiserPartyAddressCommunicationChannelPhone
    {

        private string typeField;

        private uint phoneNumberField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public uint PhoneNumber
        {
            get
            {
                return this.phoneNumberField;
            }
            set
            {
                this.phoneNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazineAdvertiserBrandBrand
    {

        private string nameField;

        private AdsMLBookingsAdOrderPlacementNewspaperMagazineAdvertiserBrandBrandCode codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazineAdvertiserBrandBrandCode Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazineAdvertiserBrandBrandCode
    {

        private string codeValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string CodeValue
        {
            get
            {
                return this.codeValueField;
            }
            set
            {
                this.codeValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0", IsNullable = false)]
    public partial class DocumentRendering
    {

        private DocumentRenderingContentProperties contentPropertiesField;

        private string contentDataField;

        /// <remarks/>
        public DocumentRenderingContentProperties ContentProperties
        {
            get
            {
                return this.contentPropertiesField;
            }
            set
            {
                this.contentPropertiesField = value;
            }
        }

        /// <remarks/>
        public string ContentData
        {
            get
            {
                return this.contentDataField;
            }
            set
            {
                this.contentDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class DocumentRenderingContentProperties
    {

        private string mIMETypeField;

        private string contentDataEncodingField;

        private uint contentSizeInBytesField;

        private string fileNameField;

        /// <remarks/>
        public string MIMEType
        {
            get
            {
                return this.mIMETypeField;
            }
            set
            {
                this.mIMETypeField = value;
            }
        }

        /// <remarks/>
        public string ContentDataEncoding
        {
            get
            {
                return this.contentDataEncodingField;
            }
            set
            {
                this.contentDataEncodingField = value;
            }
        }

        /// <remarks/>
        public uint ContentSizeInBytes
        {
            get
            {
                return this.contentSizeInBytesField;
            }
            set
            {
                this.contentSizeInBytesField = value;
            }
        }

        /// <remarks/>
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazinePublication
    {

        private AdsMLBookingsAdOrderPlacementNewspaperMagazinePublicationPublicationCode publicationCodeField;

        private string nameField;

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazinePublicationPublicationCode PublicationCode
        {
            get
            {
                return this.publicationCodeField;
            }
            set
            {
                this.publicationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazinePublicationPublicationCode
    {

        private string codeValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string CodeValue
        {
            get
            {
                return this.codeValueField;
            }
            set
            {
                this.codeValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazineInsertionPeriod
    {

        private string scheduleEntryIdentifierField;

        private System.DateTime firstPossibleTimeField;

        private System.DateTime lastPossibleTimeField;

        /// <remarks/>
        public string ScheduleEntryIdentifier
        {
            get
            {
                return this.scheduleEntryIdentifierField;
            }
            set
            {
                this.scheduleEntryIdentifierField = value;
            }
        }

        /// <remarks/>
        public System.DateTime FirstPossibleTime
        {
            get
            {
                return this.firstPossibleTimeField;
            }
            set
            {
                this.firstPossibleTimeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime LastPossibleTime
        {
            get
            {
                return this.lastPossibleTimeField;
            }
            set
            {
                this.lastPossibleTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazine
    {

        private AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazineSize sizeField;

        private AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazineColors colorsField;

        private AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioning positioningField;

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazineSize Size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazineColors Colors
        {
            get
            {
                return this.colorsField;
            }
            set
            {
                this.colorsField = value;
            }
        }

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioning Positioning
        {
            get
            {
                return this.positioningField;
            }
            set
            {
                this.positioningField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazineSize
    {

        private AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazineSizeWidth widthField;

        private AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazineSizeHeight heightField;

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazineSizeWidth Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazineSizeHeight Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazineSizeWidth
    {

        private string unitOfMeasureField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string UnitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazineSizeHeight
    {

        private string unitOfMeasureField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string UnitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazineColors
    {

        private AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazineColorsColorType colorTypeField;

        private byte numberOfColorsField;

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazineColorsColorType ColorType
        {
            get
            {
                return this.colorTypeField;
            }
            set
            {
                this.colorTypeField = value;
            }
        }

        /// <remarks/>
        public byte NumberOfColors
        {
            get
            {
                return this.numberOfColorsField;
            }
            set
            {
                this.numberOfColorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazineColorsColorType
    {

        private string codeValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string CodeValue
        {
            get
            {
                return this.codeValueField;
            }
            set
            {
                this.codeValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioning
    {

        private AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioningPrimaryPositioning primaryPositioningField;

        private bool cuttablePositionField;

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioningPrimaryPositioning PrimaryPositioning
        {
            get
            {
                return this.primaryPositioningField;
            }
            set
            {
                this.primaryPositioningField = value;
            }
        }

        /// <remarks/>
        public bool CuttablePosition
        {
            get
            {
                return this.cuttablePositionField;
            }
            set
            {
                this.cuttablePositionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioningPrimaryPositioning
    {

        private AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioningPrimaryPositioningPlacementInBook placementInBookField;

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioningPrimaryPositioningPlacementInBook PlacementInBook
        {
            get
            {
                return this.placementInBookField;
            }
            set
            {
                this.placementInBookField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioningPrimaryPositioningPlacementInBook
    {

        private AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioningPrimaryPositioningPlacementInBookSectionCode sectionCodeField;

        private AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioningPrimaryPositioningPlacementInBookPlacementCode placementCodeField;

        private AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioningPrimaryPositioningPlacementInBookClassifiedPlacementCode classifiedPlacementCodeField;

        private Specifications specificationsField;

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioningPrimaryPositioningPlacementInBookSectionCode SectionCode
        {
            get
            {
                return this.sectionCodeField;
            }
            set
            {
                this.sectionCodeField = value;
            }
        }

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioningPrimaryPositioningPlacementInBookPlacementCode PlacementCode
        {
            get
            {
                return this.placementCodeField;
            }
            set
            {
                this.placementCodeField = value;
            }
        }

        /// <remarks/>
        public AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioningPrimaryPositioningPlacementInBookClassifiedPlacementCode ClassifiedPlacementCode
        {
            get
            {
                return this.classifiedPlacementCodeField;
            }
            set
            {
                this.classifiedPlacementCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public Specifications Specifications
        {
            get
            {
                return this.specificationsField;
            }
            set
            {
                this.specificationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioningPrimaryPositioningPlacementInBookSectionCode
    {

        private string codeValueField;

        private string descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string CodeValue
        {
            get
            {
                return this.codeValueField;
            }
            set
            {
                this.codeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioningPrimaryPositioningPlacementInBookPlacementCode
    {

        private string codeValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string CodeValue
        {
            get
            {
                return this.codeValueField;
            }
            set
            {
                this.codeValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlbookings/2.5")]
    public partial class AdsMLBookingsAdOrderPlacementNewspaperMagazineProductionDetailNewspaperMagazinePositioningPrimaryPositioningPlacementInBookClassifiedPlacementCode
    {

        private string codeValueField;

        private string descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string CodeValue
        {
            get
            {
                return this.codeValueField;
            }
            set
            {
                this.codeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0")]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.adsml.org/typelibrary/2.0", IsNullable = false)]
    public partial class Specifications
    {

        private SpecificationsCode codeField;

        /// <remarks/>
        public SpecificationsCode Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/typelibrary/2.0")]
    public partial class SpecificationsCode
    {

        private string codeValueField;

        /// <remarks/>
        public string CodeValue
        {
            get
            {
                return this.codeValueField;
            }
            set
            {
                this.codeValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.adsml.org/adsmlmaterials/2.5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.adsml.org/adsmlmaterials/2.5", IsNullable = false)]
    public partial class AdContent
    {

        private string materialsIdentifierField;

        private string adContentTextField;

        /// <remarks/>
        public string MaterialsIdentifier
        {
            get
            {
                return this.materialsIdentifierField;
            }
            set
            {
                this.materialsIdentifierField = value;
            }
        }

        /// <remarks/>
        public string AdContentText
        {
            get
            {
                return this.adContentTextField;
            }
            set
            {
                this.adContentTextField = value;
            }
        }
    }


}
