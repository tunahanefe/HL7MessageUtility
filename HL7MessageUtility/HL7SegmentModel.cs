using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7MessageUtility
{
    public class HL7SegmentModel
    {
        public string SegmentName { get; set; }
        public Dictionary<Int32, string> Elements { get; set; }

        /// <summary>
        /// Standart bir HL7 Mesaj oluşturmak için.
        /// </summary>
        /// <param name="segmentName">Segment ismi. Örn: MSH, PID, PV1.</param>
        /// <param name="elementCount">Segmentin içindeki element sayısı.</param>
        public HL7SegmentModel(string segmentName, Int32 elementCount)
        {
            this.SegmentName = segmentName;
            Bind(elementCount);
        }

        /// <summary>
        /// Segment değerleri belli olan veya bazı standart element verilerini tek seferde kurmak için.
        /// Gerekli diğer veriler element değeri üzerinden değiştirilebilir.
        /// </summary>
        /// <param name="elementVals">Segment değerleri dizisi. örn : MSH|^~\&|MIA_TECHNOLOGY|MIA_MED|ExtremePACS_001||</param>
        public HL7SegmentModel(string[] elementVals)
        {
            this.SegmentName = elementVals[0];
            Bind(elementVals);
        }

        /// <summary>
        /// Kurulacak model yapısının boş bir şekilde kurulması için. Genellikle kod tarafında DB verileri ile oluşturulurken kullanılır.
        /// </summary>
        /// <param name="elementCount">Element sayısı.</param>
        private void Bind(int elementCount)
        {
            Elements = new Dictionary<int, string>();
            for (int i = 1; i < elementCount; i++)
            {
                Elements.Add(i, "");
            }
        }

        /// <summary>
        /// Hazır HL7 mesajını modellemek için kullanılır.
        /// </summary>
        /// <param name="elementVals">Element değerleri.</param>
        private void Bind(string[] elementVals)
        {
            this.Elements = new Dictionary<int, string>();
            for (int i = 1; i < elementVals.Length; i++)
            {
                Elements.Add(i, elementVals[i]);
            }
        }
    }
}
