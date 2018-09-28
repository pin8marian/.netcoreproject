using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Engie.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngieDAL
{
    public class ExcelDataReader : IDataReader
    {
        public async Task<List<CtrEngieDataDTO>> ReadDataContractEngie(string _connectionPath)
        {
            var returnData = new List<CtrEngieDataDTO>();

            var ctrEngieDataDTO = new CtrEngieDataDTO();

            string[] strProperties = new string[60];
            int j = 0;
            using (SpreadsheetDocument document = SpreadsheetDocument.Open(_connectionPath, false))
            {
                WorkbookPart workbookPart = document.WorkbookPart;
                IEnumerable<Sheet> sheets = document.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                string relationshipId = sheets.First().Id.Value;
                WorksheetPart worksheetPart = (WorksheetPart)document.WorkbookPart.GetPartById(relationshipId);
                Worksheet workSheet = worksheetPart.Worksheet;
                SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                IEnumerable<Row> rows = sheetData.Descendants<Row>().Where(x => x.RowIndex > 1).ToList();

                string value;

                foreach (Row r in rows)
                {
                    IEnumerable<Cell> cells = SpreedsheetHelper.GetRowCells(r);

                    foreach (Cell c in cells)
                    {
                        if (c != null)
                        {
                            value = c.InnerText;
                            if (c.DataType != null)
                            {
                                switch (c.DataType.Value)
                                {
                                    case CellValues.SharedString:
                                        var stringTable = workbookPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();
                                        if (stringTable != null)
                                        {
                                            value = stringTable.SharedStringTable.
                                              ElementAt(int.Parse(value)).InnerText;
                                        }
                                        break;
                                    case CellValues.Boolean:
                                        switch (value)
                                        {
                                            case "0":
                                                value = "FALSE";
                                                break;
                                            default:
                                                value = "TRUE";
                                                break;
                                        }
                                        break;
                                }
                            }
                            strProperties[j] = value;
                            j = j + 1;
                        }
                    }
                    j = 0;
                    returnData.Add(new CtrEngieDataDTO
                    {
                        nr_contract = strProperties[0],
                        data_semnarii = strProperties[1],
                        nume_contractant = strProperties[2],
                        localitate = strProperties[3],
                        strada = strProperties[4],
                        nr = strProperties[5],
                        cod_cladire = strProperties[6],
                        apt = strProperties[7],
                        cod_postal = strProperties[8],
                        judet = strProperties[9],
                        tel = strProperties[10],
                        email = strProperties[11],
                        serie_nr_ci = strProperties[12],
                        eliberat_de = strProperties[13],
                        eliberat_la_data = strProperties[14],
                        valabil_pana_la = strProperties[15],
                        cnp = strProperties[16],
                        iban = strProperties[17],
                        banca = strProperties[18],
                        c_localitatea = strProperties[19],
                        c_strada = strProperties[20],
                        c_nr = strProperties[21],
                        c_cod_cladire = strProperties[22],
                        c_apt = strProperties[23],
                        c_cod_postal = strProperties[24],
                        c_judet = strProperties[25],
                        c_nr_loc_consum = strProperties[26],
                        c_cod_loc_consum = strProperties[27],
                        c_distribuitor = strProperties[28],
                        c_serie_contor = strProperties[29],
                        c_putere = strProperties[30],
                        denumire_oferta = strProperties[31],
                        pret_dela = strProperties[32],
                        pret_pana_la = strProperties[33],
                        pret = strProperties[34],
                        nivel_tensiune = strProperties[35],
                        termen_plata = strProperties[36],
                        f_localitate = strProperties[37],
                        f_strada = strProperties[38],
                        f_nr = strProperties[39],
                        f_ap = strProperties[40],
                        f_cod_postal = strProperties[41],
                        f_judet = strProperties[42],
                        ianuarie = strProperties[43],
                        februarie = strProperties[44],
                        martie = strProperties[45],
                        aprilie = strProperties[46],
                        mai = strProperties[47],
                        iunie = strProperties[48],
                        iulie = strProperties[49],
                        august = strProperties[50],
                        septembrie = strProperties[51],
                        octombrie = strProperties[52],
                        noiembrie = strProperties[53],
                        decembrie = strProperties[54],
                        total = strProperties[55],
                        cod_move_in = strProperties[56],
                        cod_partener = strProperties[57],
                        vanzator = strProperties[58],
                        client = strProperties[59]
                    });
                }
            }
            return returnData;
        }

        public async Task<List<EngieNotaInformatiovaDataDto>> ReadDataNotaInformativaAsync(string _connectionPath)
        {
            try
            {
                var returnData = new List<EngieNotaInformatiovaDataDto>();
                EngieNotaInformatiovaDataDto engieDataDto = new EngieNotaInformatiovaDataDto();
                string[] strProperties = new string[24];
                int j = 0;
                using (SpreadsheetDocument document = SpreadsheetDocument.Open(_connectionPath, false))
                {
                    WorkbookPart workbookPart = document.WorkbookPart;
                    IEnumerable<Sheet> sheets = document.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                    string relationshipId = sheets.First().Id.Value;
                    WorksheetPart worksheetPart = (WorksheetPart)document.WorkbookPart.GetPartById(relationshipId);
                    Worksheet workSheet = worksheetPart.Worksheet;
                    SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                    IEnumerable<Row> rows = sheetData.Descendants<Row>().Where(x => x.RowIndex > 1).ToList();

                    string value;

                    foreach (Row r in rows)
                    {
                        IEnumerable<Cell> cells = SpreedsheetHelper.GetRowCells(r);

                        foreach (Cell c in cells)
                        {
                            if (c != null)
                            {
                                value = c.InnerText;
                                if (c.DataType != null)
                                {
                                    switch (c.DataType.Value)
                                    {
                                        case CellValues.SharedString:
                                            var stringTable = workbookPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();
                                            if (stringTable != null)
                                            {
                                                value = stringTable.SharedStringTable.
                                                  ElementAt(int.Parse(value)).InnerText;
                                            }
                                            break;
                                        case CellValues.Boolean:
                                            switch (value)
                                            {
                                                case "0":
                                                    value = "FALSE";
                                                    break;
                                                default:
                                                    value = "TRUE";
                                                    break;
                                            }
                                            break;
                                    }
                                }
                                strProperties[j] = value;
                                j = j + 1;
                            }
                        }
                        j = 0;
                        returnData.Add(new EngieNotaInformatiovaDataDto
                        {
                            //id = strProperties[0] != null ? Convert.ToInt32(strProperties[0]) : 0,
                            nr_inreg_dgsr = strProperties[0],
                            nr_fisa_evidenta = strProperties[1],
                            cod_loc_consum = strProperties[2],
                            nume_client_final = strProperties[3],
                            strada = strProperties[4],
                            numar = strProperties[5],
                            bloc_scara_apartament = strProperties[6],
                            localitate_judet = strProperties[7],
                            telefon = strProperties[8],
                            aparat_tip_1 = strProperties[9],
                            aparat_nr_1 = strProperties[10],
                            aparat_debit_1 = strProperties[11],
                            aparat_tip_2 = strProperties[12],
                            aparat_nr_2 = strProperties[13],
                            aparat_debit_2 = strProperties[14],
                            aparat_tip_3 = strProperties[15],
                            aparat_nr_3 = strProperties[16],
                            aparat_debit_3 = strProperties[17],
                            aparat_tip_4 = strProperties[18],
                            aparat_nr_4 = strProperties[19],
                            aparat_debit_4 = strProperties[20],
                            reprezentantul_legal_nume_prenume = strProperties[21],
                            instalatorul_autorizat_nume_prenume = strProperties[22]
                        });
                    }
                }
               // var ddd= await Task.Run(() => returnData);
                return returnData;
            }
            catch (Exception ex)
            {
                var exception = ex.InnerException.Message;
                return new List<EngieNotaInformatiovaDataDto>();
            }
        }

        private static string GetCellValue(SpreadsheetDocument document, Cell cell)
        {
            SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
            string value = cell.CellValue.InnerXml;

            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;
            }
            else
            {
                return value;
            }
        }
    }
}
