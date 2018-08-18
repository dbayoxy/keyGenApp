using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using MatCode;

namespace KeygenApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
                lblImagePath.Text = dlg.FileName;
            }
            dlg.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
            txtKey.Visible = false;


            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            
            
            
            
            lblImagePath.Text = String.Empty;


            cboOffset.Items.Add("0");
            cboOffset.Items.Add("45");
            cboOffset.Items.Add("90");
            cboOffset.Items.Add("135");
            cboOffset.SelectedIndex = 0;

            for (int i = 1; i <= 10; i++)
            {
                cboRadius.Items.Add(i);
            }
                cboRadius.SelectedIndex = 0;
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            lblKey.Text = string.Empty;
            txtKey.Text = string.Empty;
            string strIP = lblImagePath.Text;
            
            if ( strIP == String.Empty)
            {
                MessageBox.Show("Select an Image", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    
                    btnGenerateKey.Enabled = false;
                    int intAngle = Convert.ToInt32(cboOffset.SelectedItem);
                    int intRadius = Convert.ToInt32(cboRadius.SelectedItem);

                    string strRadius = Convert.ToString(intRadius);
                    string strAngle = Convert.ToString(intAngle);


                    if (backgroundWorker1.IsBusy != true)
                    {
                        string[] parameters = new string[] { strIP, strAngle, strRadius };

                        // Start the asynchronous operation.
                        backgroundWorker1.RunWorkerAsync(parameters);
                    }

                    //GLCM(strIP, intAngle, intRadius);
                    //btnGenerateKey.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Error );
                    Application.Exit();
                }
                
               
            }
            
        }

        public string GLCM(string strIP, int D, int R)
        {
            //MWNumericArray arr1 = a;
           // string txt = "C:\\Users\\Adebayo\\Desktop\\mat\\bayo.jpg"; //"C:\\Users\\Adebayo\\Pictures\\2014.jpg";
            //(calc.calculator((MWCharArray)textBox1.Text)[1].ToString());
           // int D = 90;
            var obj = new CustomMatlabClass();


            var varTrace = obj.functTrace((MWCharArray)strIP, (MWNumericArray)D, (MWNumericArray)R);
            var varContrast = obj.functContrast((MWCharArray)strIP, (MWNumericArray)D, (MWNumericArray)R);
            var varCorrelation = obj.functCorrelation((MWCharArray)strIP, (MWNumericArray)D, (MWNumericArray)R);
            var varEnergy = obj.functEnergy((MWCharArray)strIP, (MWNumericArray)D, (MWNumericArray)R);
            var varEntropy = obj.functEntropy((MWCharArray)strIP, (MWNumericArray)D, (MWNumericArray)R);
            var varHomogeneity = obj.functHomogeneity((MWCharArray)strIP, (MWNumericArray)D, (MWNumericArray)R);

                

            string strTrace = varTrace.ToString();
            string strContrast = varContrast.ToString();
            string strCorrelation = varCorrelation.ToString();
            string strEnergy = varEnergy.ToString();
            string strEntropy = varEntropy.ToString();
            string strHomogeneity = varHomogeneity.ToString();

           double dblTrace= Convert.ToDouble(strTrace);
            double dblContrast=Convert.ToDouble(strContrast);
            double dblCorrelation = Convert.ToDouble(strCorrelation);
            double dblEnergy = Convert.ToDouble(strEnergy);
            double dblEntropy = Convert.ToDouble(strEntropy);
           double dblHomogeneity =Convert.ToDouble(strHomogeneity);
           double dblsum = dblTrace * (dblContrast ) * (dblCorrelation) * (dblEnergy ) * 
               (dblEntropy) * (dblEnergy);

           decimal d = Convert.ToDecimal(dblsum);
           int count = BitConverter.GetBytes(decimal.GetBits(d)[3])[2];
           double x = Convert.ToDouble(d);
           x *= Math.Pow(10, count);

           dblsum = x;
          

            string s= "Trace = " + Convert.ToDouble(strTrace);
            s+="Contrast = " + Convert.ToDouble(strContrast)*10000;
            s+="Correlation = " + Convert.ToDouble(strCorrelation)*10000;
            s+="Energy = " + Convert.ToDouble(strEnergy)*10000;
            s+="Entropy = " + Convert.ToDouble(strEntropy)*10000;
            s+="Homogeneity = " + Convert.ToDouble(strHomogeneity)*10000;

            string strKey = Convert.ToString(dblsum);
            return strKey ;
           // lblKey.Text = dblsum.ToString();       
        }

       

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string [] parameters = e.Argument as string [];
            string IP = parameters [0];
            string Angle = parameters[1];
            string Radius = parameters[2];

            int intAngle = Convert.ToInt32(Angle);
            int intRadius = Convert.ToInt32(Radius);


            for (int i = 1; i <= 10; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    e.Result = GLCM(IP, intAngle, intRadius);
                    System.Threading.Thread.Sleep(500);
                    worker.ReportProgress(i * 10);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            resultLabel.Text = (e.ProgressPercentage.ToString() + "%");
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnGenerateKey.Enabled = true;
            if (e.Cancelled == true)
            {
                resultLabel.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                resultLabel.Text = "Error: " + e.Error.Message;
            }
            else
            {
                resultLabel.Text = "Done!";
                string res = e.Result as string;
                lblKey.Text = res;
                txtKey.Text = res;
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
            }
        }

      
    }
}
