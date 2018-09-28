
using Engie.Standard;

namespace EngieDAL
{
    public class ReaderFactory: IReaderFactory
    {
        public IDataReader GetReader(string readerType)
        {
            IDataReader reader = null;
            if (readerType.ToLower().Equals("xml"))
            {
                reader = new XmlDataReader();
            }
            else if (readerType.ToLower().Equals("csv"))
            {
                reader = new CsvDataReader();
            }
            else if (readerType.ToLower().Equals("xls"))
            {
                reader = new ExcelDataReader();
            }
            else if (readerType.ToLower().Equals("db"))
            {
                reader = new DbDataReader();
            }
            return reader;
        }
    }

    public interface IReaderFactory
    {
        IDataReader GetReader(string readerType);
    }
}
