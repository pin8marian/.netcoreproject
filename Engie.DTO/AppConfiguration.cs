namespace EngiePOC.DTO
{
    public class AppSettings
    {
        public string NotaVericareExcelFilePath { get; set; }
        public string NotaVerficareExcelFileName { get; set; }
        public string NotaVerificareSignConfig { get; set; }
        public string NotaVerificareFormPdf { get; set; }

        public string ContractElExcelFilePath { get; set; }
        public string ContractelExcelFileName { get; set; }
        public string ContractElSignConfig { get; set; }
        public string ContractFormPdf { get; set; }

        public string ExcelDocument { get; set; }
        public string XmlDocument { get; set; }
        public string CsvDocument { get; set; }
        public string Database { get; set; }
        public string eSawUrlBeta3 { get; set; }
        public string eSawUrl { get; set; }
        public string UserAccountName { get; set; }
        public string OrganizationKeyBeta3 { get; set; }
        public string TemplateEnvelopeID { get; set; }
        public string eSawUrlAPI { get; set; }
        public string AndroidLinkTemplate { get; set; }

        public AppSettings() { }
    }

}
