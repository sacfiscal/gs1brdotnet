using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gs1Br
{
    public static class Gs1brExtensions
    {
        public static string LerDescricao(this Product product)
        {
            Tradeitemdescriptioninformationlang descricao = product.tradeItemDescriptionInformationLang.FirstOrDefault(x => x.languageCode.Equals("pt-BR"));

            if (descricao == null)
                return "";

            return descricao.tradeItemDescription;
        }

        public static string LerUrlFoto(this Product product)
        {
            Referencedfileinformation foto = product.referencedFileInformations.FirstOrDefault(x => x.languageCode.Equals("pt-BR"));

            if (foto == null)
                return "";

            return foto.uniformResourceIdentifier;
        }

        public static string LerMarca(this Product product)
        {
            Brandnameinformationlang marca = product.brandNameInformationLang.FirstOrDefault(x => x.languageCode.Equals("pt-BR"));

            if (marca == null)
                return "";

            return marca.brandName;
        }

        public static Tuple<string, decimal> LerEmbalagem(this Product product)
        {
            Tradeitemmeasurements embalagem = product.tradeItemMeasurements;

            if (embalagem == null)
                return null;

            if (embalagem.netContent.value == null)
                return null;

            return new Tuple<string, decimal>(embalagem.netContent.measurementUnitCode, embalagem.netContent.value.Value);
        }

        public static string LerNCM(this Product product)
        {
            Additionaltradeitemclassification ncm = product.tradeItemClassification.additionalTradeItemClassifications.FirstOrDefault(x => x.additionalTradeItemClassificationSystemCode.Equals("NCM"));

            if (ncm == null)
                return "";

            return ncm.additionalTradeItemClassificationCodeValue.Replace(".", "");
        }

        public static string LerCEST(this Product product)
        {
            Additionaltradeitemclassification cest = product.tradeItemClassification.additionalTradeItemClassifications.FirstOrDefault(x => x.additionalTradeItemClassificationSystemCode.Equals("CEST"));

            if (cest == null)
                return "";

            return cest.additionalTradeItemClassificationCodeValue.Replace(".", ""); ;
        }

        public static Tuple<string, string> LerClassificacaoGPC(this Product product)
        {
            Tradeitemclassification gpc = product.tradeItemClassification;

            if (gpc == null)
                return null;

            if (gpc.gpcCategoryName == null)
                return null;

            return new Tuple<string, string>(gpc.gpcCategoryCode, gpc.gpcCategoryName);
        }
    }
}
