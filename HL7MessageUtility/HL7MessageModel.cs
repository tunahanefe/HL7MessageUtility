﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7MessageUtility
{
    // yeni satır için karakter sıralaması : \r\n
    // karakter karşılıkları
    // \r ~ vbCr ~ ToChar(13) > ''
    // \n ~ vbLf ~ ToChar(10) > ''

    public class HL7MessageModel
    {
        public List<HL7SegmentModel> Segments { get; set; }

        public HL7MessageModel(params HL7SegmentModel[] hL7SegmentModels)
        {
            this.Segments = hL7SegmentModels.ToList();
            // segmentin çoğatma parametresi var ise burada ataması yapılabilir

            //hL7SegmentModels.ToList().ForEach(x =>
            //{
            //    x.
            //}
            //);

            foreach (var itemSegment in hL7SegmentModels.ToList())
            {
                for (int i = 1; i < itemSegment.SegmentCount; i++)
                {
                    itemSegment.Elements[1] = i.ToString();
                    this.Segments.Add(itemSegment);
                }
            }
        }

        public string ModelToMesaj()
        {
            string sonuc = "";



            foreach (var itemSeg in Segments)
            {
                sonuc += itemSeg.SegmentName;
                //foreach (KeyValuePair<int, string> itemElement in itemSeg.Elements)
                //{
                //    sonuc += "|" + itemElement.Value;
                //}
                for (int i = 1; i < (itemSeg.Elements.Count+1); i++)
                {
                    if (itemSeg.SegmentName == "MSH" && i <= 1)
                    {
                        // MSH segmentinin özel bir durumu var MSH|^~\& -> ifadesindeki | File speratör karakteri 1. element sayılıyor
                        continue;
                    }
                    sonuc += "|" + itemSeg.Elements[i];
                }
                sonuc += Convert.ToChar(13);
            }

            return sonuc;
        }

        public static HL7MessageModel MesajToModel(string mesaj)
        {
            var diziMesajModel = mesaj.Split(new char[] { Convert.ToChar(10), Convert.ToChar(13) }).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            var lstSM = new List<HL7SegmentModel>();
            string[] elementDizisi;
            for (int i = 0; i < diziMesajModel.Length; i++)
            {
                if (diziMesajModel[i] != "")
                {
                    elementDizisi = diziMesajModel[i].Split('|').ToArray();

                    lstSM.Add(new HL7SegmentModel(elementDizisi));
                }
            }

            return new HL7MessageModel(lstSM.ToArray());
        }

        /// <summary>
        /// Var olan modele aynı isimli segmenti sadece index numarasını (element no 1i) arttırarak element ya da liste sayısı kadar ekler.
        /// </summary>
        public void AddNewSegments(string segmentName, Int16 segmentCount, Int16 elementCount)
        {
            //'DG1|1|||||
            //'DG1|2|||||
            //'DG1|3|||||
            //'DG1|4|||||
            // parametre olarak segmentName, liste ve element countda alabilir. Static yapılı method olursa parametre olarak model referansı gerekir.
            // liste tanı listesi vs..
        }
    }
}
