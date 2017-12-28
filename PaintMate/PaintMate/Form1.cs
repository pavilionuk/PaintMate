using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintMate
{
    public partial class PaintMateForm1 : Form
    {
        public PaintMateForm1()
        {
            InitializeComponent();
        }
        float roomVolume, paintArea, floorArea, paintRequired;
        float f1, f2, f3;
        string paintType;
        float dwH, dwW, maskT;
        List<float> DWlist = new List<float>();
        List<float> maskTlist = new List<float>();
        private void txtRoomWidth_TextChanged(object sender, EventArgs e)
        {
            calculateRoomDimensions();
        }

        private void cmbPaintType_SelectedIndexChanged(object sender, EventArgs e)
        {
            paintRequirements();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    using (var sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                        DateTime now = DateTime.Now;
                        sfd.FileName = ("PaintMate RoomInfo.txt");
                        sfd.FilterIndex = 2;

                        Invoke((Action)(() => { sfd.ShowDialog(); }));
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(sfd.FileName))
                        {
                            file.WriteLine("Area to paint: " + txtRoomArea.Text + "m²");
                            file.WriteLine("Area of floor: " + txtFloorArea.Text + "m²");
                            file.WriteLine("Volume of room: " + txtRoomVolume.Text + "m³");
                        file.WriteLine(" ");
                        file.WriteLine("Paint type: " + cmbPaintType.Text);
                        file.WriteLine("Minimum paint required: " + txtPaintRequired.Text + " Litres");
                        file.WriteLine("No. of coats: " + txtCoats.Text);
                        file.WriteLine("Drying time: " + txtDryingTime.Text + " Hours");
                        file.WriteLine("Recoat time: " + txtRecoatTime.Text + " Hours");
                        file.WriteLine(" ");
                        file.WriteLine("Masking Tape Length: " + txtMaskingTapeLength.Text + "m");
                        file.Close();
                      }
                        MessageBox.Show("File saved!", "Paint Mate");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "PaintMate");
                }
            
        


    }

    private void btnAddDW_Click(object sender, EventArgs e)
        {
            if(float.TryParse(txtDWwidth.Text, out dwW) && float.TryParse(txtDWheight.Text, out dwH))
            {
                if (cmbDoorOrWindow.Text != "")
                {
                    if (cmbDoorOrWindow.Text == "Door")
                    {
                        maskT = (maskT + (dwH * 2));
                        maskTlist.Add(dwH * 2);
                    }
                    else if (cmbDoorOrWindow.Text == "Windows")
                    {
                        maskT = (maskT + ((dwH * 2) + (dwW * 2)));
                        maskTlist.Add((dwH * 2) + (dwW * 2));
                    }
                    DWlist.Add(dwW*dwH);
                    this.dgvDW.Rows.Add(cmbDoorOrWindow.Text, dwW.ToString(), dwH.ToString());
                    paintArea = (paintArea - (dwH * dwW));
                    txtRoomArea.Text = paintArea.ToString();
                    txtMaskingTapeLength.Text = maskT.ToString();
                }
            }
        }

        private void txtRoomHeight_TextChanged(object sender, EventArgs e)
        {
            calculateRoomDimensions();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaintMateForm1_Load(object sender, EventArgs e)
        {

        }

        private void txtRoomBase_TextChanged(object sender, EventArgs e)
        {
            calculateRoomDimensions();
        }
        public void paintRequirements()
        {
            paintType = cmbPaintType.Text;
            switch (paintType)
            {
                case "Estate Emulsion":
                    paintRequired = (paintArea / 14);
                    txtPaintRequired.Text = paintRequired.ToString();
                    txtCoats.Text = "2";
                    txtDryingTime.Text = "2";
                    txtRecoatTime.Text = "4";
                    break;
                case "Modern Emulsion":
                    paintRequired = (paintArea / 12);
                    txtPaintRequired.Text = paintRequired.ToString();
                    txtCoats.Text = "2";
                    txtDryingTime.Text = "2";
                    txtRecoatTime.Text = "4";
                    break;
                case "Estate Eggshell":
                    paintRequired = (paintArea / 12);
                    txtPaintRequired.Text = paintRequired.ToString();
                    txtCoats.Text = "2";
                    txtDryingTime.Text = "2";
                    txtRecoatTime.Text = "4";
                    break;
                case "Modern Eggshell":
                    paintRequired = (paintArea / 12);
                    txtPaintRequired.Text = paintRequired.ToString();
                    txtCoats.Text = "2";
                    txtDryingTime.Text = "2";
                    txtRecoatTime.Text = "4";
                    break;
                case "Full Gloss":
                    paintRequired = (paintArea / 12);
                    txtPaintRequired.Text = paintRequired.ToString();
                    txtCoats.Text = "2";
                    txtDryingTime.Text = "2";
                    txtRecoatTime.Text = "4";
                    break;
                case "Dead Flat":
                    paintRequired = (paintArea / 12);
                    txtPaintRequired.Text = paintRequired.ToString();
                    txtCoats.Text = "2";
                    txtDryingTime.Text = "2";
                    txtRecoatTime.Text = "4";
                    break;
                case "Exterior Masonry":
                    paintRequired = (paintArea / 8);
                    txtPaintRequired.Text = paintRequired.ToString();
                    txtCoats.Text = "2";
                    txtDryingTime.Text = "2";
                    txtRecoatTime.Text = "5";
                    break;
                case "Exterior Eggshell":
                    paintRequired = (paintArea / 13);
                    txtPaintRequired.Text = paintRequired.ToString();
                    txtCoats.Text = "2";
                    txtDryingTime.Text = "2";
                    txtRecoatTime.Text = "4";
                    break;
                case "Casein Distemper":
                    paintRequired = (paintArea / 13);
                    txtPaintRequired.Text = paintRequired.ToString();
                    txtCoats.Text = "2";
                    txtDryingTime.Text = "2";
                    txtRecoatTime.Text = "2";
                    break;
                case "Soft Distemper":
                    paintRequired = (paintArea / 13);
                    txtPaintRequired.Text = paintRequired.ToString();
                    txtCoats.Text = "2";
                    txtDryingTime.Text = "2";
                    txtRecoatTime.Text = "2";
                    break;
            }
        }
        public void calculateRoomDimensions()
        {
            if(txtRoomBase.Text=="" || txtRoomHeight.Text=="" || txtRoomWidth.Text=="")
            {
                
            }
            else
            {
                if (float.TryParse(txtRoomBase.Text, out f1) && float.TryParse(txtRoomHeight.Text, out f2) && float.TryParse(txtRoomWidth.Text, out f3))
                {
                    maskT = (((f1 * 2) + (f3 * 2))*2);
                    if(maskTlist.Count!=0)
                    {
                        for(int i = 0; i==maskTlist.Count; i++)
                        {
                            maskT = (maskT + maskTlist[i]);
                        }
                    }
                    txtMaskingTapeLength.Text = maskT.ToString();
                    paintArea = ((f1 * f2) * 2) + ((f3 * f2) * 2);
                    floorArea = (f1 * f3);
                    roomVolume = (f1 * f3 * f2);
                    if (dgvDW.Rows.Count > 0)
                    {

                    }
                    txtRoomArea.Text = paintArea.ToString();
                    txtFloorArea.Text = floorArea.ToString();
                    txtRoomVolume.Text = roomVolume.ToString();
                    paintType = cmbPaintType.Text;

                }
                else
                {

                }
            }
        }
    }
}
