using HL7MessageUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HL7MessageApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void btnAdt_Click(object sender, EventArgs e)
        {
            var ADT = new HL7MessageModel(new HL7SegmentModel("MSH", 15), new HL7SegmentModel("EVN", 2), new HL7SegmentModel("PID", 13), new HL7SegmentModel("PV1", 3));
            
            var index = -1;
            index = ADT.Segments.ToList().FindIndex(x => x.SegmentName == "MSH");
            if (index > -1)
            {
                ADT.Segments[index].Elements[2] = "^~\\&";
                ADT.Segments[index].Elements[3] = "MIA_TECHNOLOGY";
                ADT.Segments[index].Elements[4] = "Millennium";
                //ADT.Segments[index].Elements[4] = "";
                ADT.Segments[index].Elements[6] = "201803021040";
                ADT.Segments[index].Elements[8] = "ADT^A01";
                ADT.Segments[index].Elements[9] = "76354";
                ADT.Segments[index].Elements[10] = "P";
                ADT.Segments[index].Elements[11] = "2.3";
                ADT.Segments[index].Elements[12] = "NE";
                ADT.Segments[index].Elements[13] = "NE";
                ADT.Segments[index].Elements[14] = "TR";
            }

            index = -1;
            index = ADT.Segments.ToList().FindIndex(x => x.SegmentName == "EVN");
            if (index > -1)
            {
                ADT.Segments[index].Elements[1] = "A01";
                ADT.Segments[index].Elements[2] = "201803021040";
            }

            index = -1;
            index = ADT.Segments.ToList().FindIndex(x => x.SegmentName == "PID");
            if (index > -1)
            {
                ADT.Segments[index].Elements[1] = "1";
                ADT.Segments[index].Elements[3] = "02006196";
                ADT.Segments[index].Elements[5] = "SOYAD^AD";
                ADT.Segments[index].Elements[7] = "19690621";
                ADT.Segments[index].Elements[8] = "F";
                ADT.Segments[index].Elements[11] = "Adresss^^";
                ADT.Segments[index].Elements[13] = "2122xxxx";
            }

            index = -1;
            index = ADT.Segments.ToList().FindIndex(x => x.SegmentName == "PV1");
            if (index > -1)
            {
                ADT.Segments[index].Elements[1] = "1";
                ADT.Segments[index].Elements[2] = "O";
                ADT.Segments[index].Elements[3] = "^^^ULUDAG^^^";
            }

            //10 \n
            //13 \r

            tbHL7.Text = ADT.ModelToMesaj().Replace("\r", "\r\n");
        }

        private void btnAdtToText_Click(object sender, EventArgs e)
        {
            //tbHL7Vals.Text = "";
            //var Mesaj = tbHL7.Text;

            //var _Adt = HL7MessageModel.MesajToModel(Mesaj);

            //treeView1.Nodes.Clear();
            //var root = new TreeNode("HL7");
            //treeView1.Nodes.Add(root);
            //var childNodeIndex = 0;            
            //foreach (var item in _Adt.Segments)
            //{
            //    tbHL7Vals.Text += item.SegmentName + Environment.NewLine;
            //    treeView1.Nodes[0].Nodes.Add(new TreeNode(item.SegmentName));
            //    foreach (var item2 in item.Elements)
            //    {
            //        tbHL7Vals.Text += "\t" + "Element(" + item2.Key.ToString() + "): " + item2.Value.ToString() + Environment.NewLine;
            //        treeView1.Nodes[0].Nodes[childNodeIndex].Nodes.Add(new TreeNode(item2.Key.ToString() + ", " + item2.Value.ToString()));
            //    }
            //    childNodeIndex++;
            //}
            //treeView1.Nodes[0].Expand();

            tbHL7Vals.Text = "";
            var Mesaj = tbHL7.Text;

            var _Adt = HL7MessageModel.MesajToModel(Mesaj);

            treeView1.Nodes.Clear();
            //var root = new TreeNode("HL7");
            //treeView1.Nodes.Add(root);
            var childNodeIndex = 0;

            string[] segments = { "MSH" };
            var rootIndex = -1;

            foreach (var item in _Adt.Segments)
            {
                if (segments.Contains(item.SegmentName))
                {
                    rootIndex++;
                    childNodeIndex = 0;
                    var root = new TreeNode(item.SegmentName);
                    treeView1.Nodes.Add(root);

                }
                tbHL7Vals.Text += item.SegmentName + Environment.NewLine;
                treeView1.Nodes[rootIndex].Nodes.Add(new TreeNode(item.SegmentName));
                foreach (var item2 in item.Elements)
                {
                    tbHL7Vals.Text += "\t" + "Element(" + item2.Key.ToString() + "): " + item2.Value.ToString() + Environment.NewLine;
                    treeView1.Nodes[rootIndex].Nodes[childNodeIndex].Nodes.Add(new TreeNode(item2.Key.ToString() + ", " + item2.Value.ToString()));
                }
                childNodeIndex++;
            }
        }

        private void btnHL7_Click(object sender, EventArgs e)
        {
            string[] segments = { "MSH", "PID", "PV1", "OBX", "ORR", "OBR" };
            foreach (var item in segments)
            {
                string strReplace = "\r\n";
                if (item == "MSH")
                    strReplace += strReplace;
                tbHL7.Text = tbHL7.Text.Replace(item, strReplace + item);
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapım aşamasında");
        }
    }
}
