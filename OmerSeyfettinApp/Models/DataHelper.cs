using System.Linq;
using DevExpress.XtraRichEdit;

namespace OmerSeyfettinApp.Models
{
    public class DataHelper
    {

        
            public static byte[] GetDocument()
            {

            OmerSeyfettinAppDb context = new OmerSeyfettinAppDb();
                return context.Docs.FirstOrDefault().DocBytes.ToArray();
        
            }

            public static void SaveDocument(byte[] bytes)
            {
                OmerSeyfettinAppDb context = new OmerSeyfettinAppDb();
                context.Docs.FirstOrDefault().DocBytes = bytes;
                context.SaveChanges();
            }
        }
        public class RichEditData
        {

            public int Id { get; set; }
            public string DocumentId { get; set; }
            public DocumentFormat DocumentFormat { get; set; }
            public byte[] Document { get; set; }
        }
    }


