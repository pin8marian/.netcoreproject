using Engie.DTO;
using Engie.Standard;
using eSAW;
using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace EngieDAL
{
    public class SignUtil : ISignUtil
    {
        public string[] UploadPdfsAndGetDocIds(ApiSoapClient ws, string authXml, string[] documentPaths)
        {
            string[] docIds = new string[documentPaths.Length];
            for (int i = 0; i < docIds.Length; i++)
            {
                string docXml = GetDocXml(documentPaths[i]);
                string fileUploadResponseXml = ws.UploadTemporarySspFile_v1Async(authXml, docXml).GetAwaiter().GetResult();
                SignAnywhereResponse uploadResult = SignAnywhereResponse.parseResponse(fileUploadResponseXml);
                docIds[i] = uploadResult.okInfo.InnerText;
            }
            return docIds;
        }

        public string GetDocXml(string filePath)
        {
            SignAnywhereFile sawFile = new SignAnywhereFile();
            FileInfo pdfFile = new FileInfo(filePath);
            sawFile.Data = File.ReadAllBytes(pdfFile.FullName);
            sawFile.FileName = pdfFile.Name;

            return sawFile.ToXml();
        }

        public XmlDocument FormatedXmlNotaInformativa(EngieNotaInformatiovaDataDto engieData, string xmlOverrideOptionTests) {

            XElement document = XElement.Parse(xmlOverrideOptionTests);

            document.SetElementValue("name", "Nota Verificaret " + engieData.nume_client_final);
            document.SetElementValue("eMailSubject", "Nota Verificare " + engieData.nume_client_final);

            var listOfTextBoxes = document.Element("overrideFormFieldValues").Element("document").Descendants("textBox");

            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "nr_inreg_dgsr").SetElementValue("value", engieData.nr_inreg_dgsr);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "nr_fisa_evidenta").SetElementValue("value", engieData.nr_fisa_evidenta);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "data_inreg_dgsr").SetElementValue("value", DateTime.Now.ToShortDateString());
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "cod_loc_consum").SetElementValue("value", engieData.cod_loc_consum);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "nume_client_final").SetElementValue("value", engieData.nume_client_final);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "nume_client_final2").SetElementValue("value", engieData.nume_client_final2);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "strada").SetElementValue("value", engieData.strada);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "numar").SetElementValue("value", engieData.numar);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "bloc_scara_apartament").SetElementValue("value", engieData.bloc_scara_apartament);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "localitate_judet").SetElementValue("value", engieData.bloc_scara_apartament);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "telefon").SetElementValue("value", engieData.localitate_judet);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "aparat_debit_1").SetElementValue("value", engieData.aparat_debit_1);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "aparat_nr_1").SetElementValue("value", engieData.aparat_nr_1);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "aparat_nr_2").SetElementValue("value", engieData.aparat_nr_2);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "aparat_nr_3").SetElementValue("value", engieData.aparat_nr_3);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "aparat_nr_4").SetElementValue("value", engieData.aparat_nr_4);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "aparat_debit_2").SetElementValue("value", engieData.aparat_debit_2);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "aparat_debit_3").SetElementValue("value", engieData.aparat_debit_3);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "aparat_debit_4").SetElementValue("value", engieData.aparat_debit_4);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "aparat_tip_1").SetElementValue("value", engieData.aparat_tip_1);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "aparat_tip_2").SetElementValue("value", engieData.aparat_tip_2);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "aparat_tip_3").SetElementValue("value", engieData.aparat_tip_3);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "aparat_tip_4").SetElementValue("value", engieData.aparat_tip_4);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "reprezentantul_legal_nume_prenume").SetElementValue("value", engieData.reprezentantul_legal_nume_prenume);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "instalatorul_autorizat_nume_prenume").SetElementValue("value", engieData.instalatorul_autorizat_nume_prenume);

            var documentc = new XmlDocument();
            documentc.LoadXml(document.ToString());

            return documentc;
        }

        public XmlDocument FormatedXmlContractEngie(CtrEngieDataDTO engieData, string xmlOverrideOptionTests)
        {
            XElement document = XElement.Parse(xmlOverrideOptionTests);

            document.SetElementValue("name", "Contract Electricitate " + engieData.client);
            document.SetElementValue("eMailSubject", "Contract Electricitate " + engieData.client);

            var listOfTextBoxes = document.Element("overrideFormFieldValues").Element("document").Descendants("textBox");

            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "cod_move_in").SetElementValue("value", engieData.cod_move_in);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "cod_partener").SetElementValue("value", engieData.cod_partener);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "nr_contract").SetElementValue("value", engieData.nr_contract);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "data_semnarii").SetElementValue("value", engieData.data_semnarii);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "nume_contractant").SetElementValue("value", engieData.nume_contractant);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "localitate").SetElementValue("value", engieData.localitate);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "strada").SetElementValue("value", engieData.strada);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "nr").SetElementValue("value", engieData.nr);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "cod_cladire").SetElementValue("value", engieData.cod_cladire);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "apt").SetElementValue("value", engieData.apt);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "cod_postal").SetElementValue("value", engieData.cod_postal);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "judet").SetElementValue("value", engieData.judet);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "tel").SetElementValue("value", engieData.tel);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "email").SetElementValue("value", engieData.email);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "serie_nr_ci").SetElementValue("value", engieData.serie_nr_ci);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "eliberat_de").SetElementValue("value", engieData.eliberat_de);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "eliberat_la_data").SetElementValue("value", engieData.eliberat_la_data);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "valabil_pana_la").SetElementValue("value", engieData.valabil_pana_la);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "cnp").SetElementValue("value", engieData.cnp);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "iban").SetElementValue("value", engieData.iban);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "banca").SetElementValue("value", engieData.banca);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "c_localitatea").SetElementValue("value", engieData.c_localitatea);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "c_strada").SetElementValue("value", engieData.c_strada);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "c_nr").SetElementValue("value", engieData.c_nr);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "c_cod_cladire").SetElementValue("value", engieData.c_cod_cladire);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "c_apt").SetElementValue("value", engieData.c_apt);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "c_cod_postal").SetElementValue("value", engieData.c_cod_postal);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "c_judet").SetElementValue("value", engieData.c_judet);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "c_nr_loc_consum").SetElementValue("value", engieData.c_nr_loc_consum);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "c_cod_loc_consum").SetElementValue("value", engieData.c_cod_loc_consum);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "c_distribuitor").SetElementValue("value", engieData.c_distribuitor);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "c_serie_contor").SetElementValue("value", engieData.c_serie_contor);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "c_putere").SetElementValue("value", engieData.c_putere);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "denumire_oferta").SetElementValue("value", engieData.denumire_oferta);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "pret_dela").SetElementValue("value", engieData.pret_dela);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "pret_pana_la").SetElementValue("value", engieData.pret_pana_la);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "pret").SetElementValue("value", engieData.pret);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "nivel_tensiune").SetElementValue("value", engieData.nivel_tensiune);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "termen_plata").SetElementValue("value", engieData.termen_plata);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "f_localitate").SetElementValue("value", engieData.f_localitate);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "f_strada").SetElementValue("value", engieData.f_strada);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "f_nr").SetElementValue("value", engieData.f_nr);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "f_ap").SetElementValue("value", engieData.f_ap);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "f_cod_postal").SetElementValue("value", engieData.f_cod_postal);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "f_judet").SetElementValue("value", engieData.f_judet);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "ianuarie").SetElementValue("value", engieData.ianuarie);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "februarie").SetElementValue("value", engieData.februarie);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "martie").SetElementValue("value", engieData.martie);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "aprilie").SetElementValue("value", engieData.aprilie);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "mai").SetElementValue("value", engieData.mai);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "iunie").SetElementValue("value", engieData.iunie);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "iulie").SetElementValue("value", engieData.iulie);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "august").SetElementValue("value", engieData.august);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "septembrie").SetElementValue("value", engieData.septembrie);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "octombrie").SetElementValue("value", engieData.octombrie);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "noiembrie").SetElementValue("value", engieData.noiembrie);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "decembrie").SetElementValue("value", engieData.decembrie);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "total").SetElementValue("value", engieData.total);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "vanzator").SetElementValue("value", engieData.vanzator);
            listOfTextBoxes.Single(x => (string)x.Attribute("name") == "client").SetElementValue("value", engieData.client);

            var documentc = new XmlDocument();
            documentc.LoadXml(document.ToString());

            return documentc;
        }
    }
}
