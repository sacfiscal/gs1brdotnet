using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using RestSharp;

namespace Gs1Br
{
    public class RetornoConsultaGtinGs1Br
    {
        public Product product { get; set; }
        public string status { get; set; }
        public string message { get; set; }
    }

    public class Product
    {
        public Gs1tradeitemidentificationkey gs1TradeItemIdentificationKey { get; set; }
        public Tradeitemdescriptioninformationlang[] tradeItemDescriptionInformationLang { get; set; }
        public object[] childTradeItems { get; set; }
        public Referencedfileinformation[] referencedFileInformations { get; set; }
        public string gtinStatusCode { get; set; }
        public Brandnameinformationlang[] brandNameInformationLang { get; set; }
        public object languageCode { get; set; }
        public Tradeitemweight tradeItemWeight { get; set; }
        public Tradeitemmeasurements tradeItemMeasurements { get; set; }
        public Tradeitemclassification tradeItemClassification { get; set; }
    }

    public class Gs1tradeitemidentificationkey
    {
        public string gs1TradeItemIdentificationKeyCode { get; set; }
        public string gtin { get; set; }
        public string fixedLengthGtin { get; set; }
    }

    public class Tradeitemweight
    {
        public Grossweight grossWeight { get; set; }
        public Netweight netWeight { get; set; }
    }

    public class Grossweight
    {
        public string measurementUnitCode { get; set; }
        public float value { get; set; }
        public float originalValue { get; set; }
    }

    public class Netweight
    {
        public object measurementUnitCode { get; set; }
        public object value { get; set; }
    }

    public class Tradeitemmeasurements
    {
        public Netcontent netContent { get; set; }
        public Height height { get; set; }
        public Width width { get; set; }
        public Depth depth { get; set; }
    }

    public class Netcontent
    {
        public string measurementUnitCode { get; set; }
        public int? value { get; set; }
        public int? originalValue { get; set; }
    }

    public class Height
    {
        public object measurementUnitCode { get; set; }
        public object value { get; set; }
        public object originalValue { get; set; }
    }

    public class Width
    {
        public object measurementUnitCode { get; set; }
        public object value { get; set; }
        public object originalValue { get; set; }
    }

    public class Depth
    {
        public object measurementUnitCode { get; set; }
        public object value { get; set; }
        public object originalValue { get; set; }
    }

    public class Tradeitemclassification
    {
        public string gpcCategoryCode { get; set; }
        public Additionaltradeitemclassification[] additionalTradeItemClassifications { get; set; }
        public string gpcCategoryName { get; set; }
    }

    public class Additionaltradeitemclassification
    {
        public string additionalTradeItemClassificationSystemCode { get; set; }
        public string additionalTradeItemClassificationCodeValue { get; set; }
    }

    public class Tradeitemdescriptioninformationlang
    {
        public string languageCode { get; set; }
        public string tradeItemDescription { get; set; }
        public bool _default { get; set; }
    }

    public class Referencedfileinformation
    {
        public string languageCode { get; set; }
        public string contentDescription { get; set; }
        public string uniformResourceIdentifier { get; set; }
        public bool featuredFile { get; set; }
        public bool _default { get; set; }
        public string referencedFileTypeCode { get; set; }
    }

    public class Brandnameinformationlang
    {
        public string languageCode { get; set; }
        public string brandName { get; set; }
        public bool _default { get; set; }
    }

}
