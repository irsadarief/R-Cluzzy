using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using RDotNet; //memanggil RdotNet agar dapat digunakan
using System.Globalization;
using System.Threading;
using System.Diagnostics;

namespace R_Cluzzy.Analyze
{
    public partial class PFCMForm : Form
    {
        //inisialisasi
        private MainForm mf = new MainForm();
        private System.Windows.Forms.DataGridView maxDGV = new DataGridView();
        private System.Windows.Forms.DataGridView minDGV = new DataGridView();
        private DataTable dat = new DataTable();
        private List<String> parname = new List<string>();
        private List<String> parval = new List<string>();
        private List<String> viname = new List<string>();
        private List<double> vival = new List<double>();
        private Boolean isnamed;
        private DataTable center = new DataTable();
        private DataTable partition = new DataTable();
        private DataTable allclusters = new DataTable();
        private ProcessingBar pb = new ProcessingBar();

        public PFCMForm()
        {
            InitializeComponent();
        }

        public PFCMForm(MainForm form)
        {

            InitializeComponent();
            mf = form;
            listBox_distance.SelectedItem = "Euclidean";

            picheckBox.Checked = true;

            xbcheckBox.Checked = true;
            kwonbox.Checked = true;

            ProcessButton.Enabled = false;
            plotcheckBox.Checked = true;
            RadarPlotCheckBox.Enabled = false;
        }

        public DataTable GetFromMainForm(DataTable dt)
        {
            this.dat = dt;
            return dat;
        }
        private DataTable GetFromMainForm()
        {
            return dat;
        }

        public System.Windows.Forms.ListBox GetAllListBox()
        {
            System.Windows.Forms.ListBox allvar = this.allvarListBox;
            return allvar;
        }


        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void picheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void xbcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kwonbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_distance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void moveToButton_Click(object sender, EventArgs e)
        {
            if (allvarListBox.SelectedItems.Count != 0)
            {
                int itemcount = allvarListBox.SelectedItems.Count;
                for (int i = itemcount - 1; i >= 0; i--)
                {
                    selectedListBox.Items.Add(allvarListBox.SelectedItems[i]);
                    allvarListBox.Items.Remove(allvarListBox.SelectedItems[i]);
                }
                allvarListBox.Sorted = true;
                selectedListBox.Sorted = true;
                ProcessButton.Enabled = true;
                //rescalecheckBox.Enabled = true;

                if (selectedListBox.Items.Count > 2)
                {
                    RadarPlotCheckBox.Enabled = true;
                    RadarPlotCheckBox.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("You have to select at least 1 variable");
            }
        }

        private void moveFromButton_Click(object sender, EventArgs e)
        {
            if (selectedListBox.SelectedItems.Count != 0)
            {
                int itemcount = selectedListBox.SelectedItems.Count;
                for (int i = itemcount - 1; i >= 0; i--)
                {
                    allvarListBox.Items.Add(selectedListBox.SelectedItems[i]);
                    selectedListBox.Items.Remove(selectedListBox.SelectedItems[i]);
                }
                allvarListBox.Sorted = true;
                if (selectedListBox.Items.Count == 0)
                {
                    ProcessButton.Enabled = false;
                    //rescalecheckBox.Enabled = false;
                }

                if (selectedListBox.Items.Count < 3)
                {
                    RadarPlotCheckBox.Enabled = false;
                    RadarPlotCheckBox.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("You have to select at least 1 variable");
            }
        }

        private void addNameButton_Click(object sender, EventArgs e)
        {
            if (allvarListBox.SelectedItems.Count != 0)
            {
                nameListBox.Items.Add(allvarListBox.SelectedItem);
                allvarListBox.Items.Remove(allvarListBox.SelectedItem);
                allvarListBox.Sorted = true;
                nameListBox.Sorted = true;
            }
            else
            {
                MessageBox.Show("You have to select at least 1 variable");
            }
        }

        private void removeNameButton_Click(object sender, EventArgs e)
        {
            if (nameListBox.SelectedItems.Count != 0)
            {
                allvarListBox.Items.Add(nameListBox.SelectedItem);
                nameListBox.Items.Remove(nameListBox.SelectedItem);
                allvarListBox.Sorted = true;
                nameListBox.Sorted = true;
            }
            else
            {
                MessageBox.Show("You have to select at least 1 variable");
            }
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            {
                double number; //for string exception

                //null exception
                if (selectedListBox.Items.Count == 0)
                { //variable
                    MessageBox.Show("You have to choose at least 1 variable!");
                }
                else if (string.IsNullOrWhiteSpace(textBox_m.Text) == true)
                { //particle
                    MessageBox.Show("Number of fuzzifier(m) shouldn't be empty!");
                }
                else if (string.IsNullOrWhiteSpace(textBox_konsa.Text) == true)
                {
                    MessageBox.Show("Coef (A) shouldn't be empty!");
                }
                else if (string.IsNullOrWhiteSpace(textBox_eta.Text) == true)
                {
                    MessageBox.Show("Number of fuzzifier(η) shouldn't be empty!");
                }
                else if (string.IsNullOrWhiteSpace(textBox_konsb.Text) == true)
                {
                    MessageBox.Show("Coef (B) shouldn't be empty!");
                }
                else if (string.IsNullOrWhiteSpace(textBox_konsk.Text) == true)
                {
                    MessageBox.Show("Coef (K) shouldn't be empty!");
                }
                else if (string.IsNullOrWhiteSpace(textBox_maxiter.Text) == true)
                {
                    MessageBox.Show("max iteration PFCM shouldn't be empty!");
                }
                else if (string.IsNullOrWhiteSpace(textBox_error.Text) == true)
                {
                    MessageBox.Show("error coef shouldn't be empty!");
                }
                else if (string.IsNullOrWhiteSpace(textBox_clus.Text) == true)
                {
                    MessageBox.Show("Number of cluster shouldn't be empty!");
                }


                //string exception
                else if (double.TryParse(textBox_m.Text, out number) == false)
                { //particle
                    MessageBox.Show("Number of fuzzifier(m) should be a natural number!");
                }
                else if (double.TryParse(textBox_konsa.Text, out number) == false)
                { //particle
                    MessageBox.Show("Coef (A) should be a number!");
                }
                else if (double.TryParse(textBox_eta.Text, out number) == false)
                { //mulai disini
                    MessageBox.Show("Number of fuzzifier(η) should be a  number!");
                }
                else if (double.TryParse(textBox_konsb.Text, out number) == false)
                { //particle
                    MessageBox.Show("Coef (B) should be a natural number!");
                }
                else if (double.TryParse(textBox_konsk.Text, out number) == false)
                { //particle
                    MessageBox.Show("Coef (K) should be a natural number!");
                }
                else if (double.TryParse(textBox_maxiter.Text, out number) == false)
                { //particle
                    MessageBox.Show("max iteration PFCM should be a natural number!");
                }
                else if (double.TryParse(textBox_error.Text, out number) == false)
                { //particle
                    MessageBox.Show("error coef should be a natural number!");
                }
                else if (double.TryParse(textBox_clus.Text, out number) == false)
                { //particle
                    MessageBox.Show("Number of cluster should be a number!");
                }
                

                else
                {
                    double ncluster = Convert.ToDouble(textBox_clus.Text);
                    double m = Convert.ToDouble(textBox_m.Text);
                    double eta = Convert.ToDouble(textBox_eta.Text);
                    double a = Convert.ToDouble(textBox_konsa.Text);
                    double b = Convert.ToDouble(textBox_konsb.Text);
                    double K = Convert.ToDouble(textBox_konsk.Text);
                    double error = Convert.ToDouble(textBox_error.Text);
                    double maxiter = Convert.ToDouble(textBox_maxiter.Text);

                    DataTable dt = GetFromMainForm();

                    if (maxiter < 1)
                    {
                        MessageBox.Show("Maximum iteration should be greater or equal to 1!");
                    }
                    else if (maxiter % 1 != 0)
                    {
                        MessageBox.Show("Maximum iteration shouldn't be in decimal!");
                    }
                    else if (ncluster < 2)
                    {
                        MessageBox.Show("Number of cluster should be greater or equal to 2!");
                    }
                    else if (ncluster % 1 != 0)
                    {
                        MessageBox.Show("Number of cluster shouldn't be in decimal!");
                    }
                    else if (a < 1)
                    {
                        MessageBox.Show("Coef (A) should be equal or greater than 1");
                    }
                    else if (b <= 0)
                    {
                        MessageBox.Show("Coef (B) should be equal or greater than 1");
                    }
                    else if (K < 0)
                    {
                        MessageBox.Show("Coef (K) should be equal or greater than 1");
                    }
                    else if (error <= 0)
                    {
                        MessageBox.Show("Value of error should be greater than 0");
                    }
                    else if (m < 1)
                    {
                        MessageBox.Show("Fuzzifier (m) should be greater or equal to 1!");
                    }
                    else if (eta < 1)
                    {
                        MessageBox.Show("Fuzzifier (η) should be greater or equal to 1!");
                    }

                    else if (mapcheckBox.Checked == true && (string.IsNullOrWhiteSpace(maptextBox.Text) || datakeyListBox.Items.Count == 0))
                    {
                        MessageBox.Show("You have checked the map, so you must have a shapefile and its datakey or you can uncheck it!");
                    }

                    else
                    {
                        pb.Show();
                        ProcessButton.Enabled = false;
                        fcmCancelButton.Enabled = false;
                        this.UseWaitCursor = true;
                        processOutput();
                        OutputForm of = new OutputForm("Posibillistic - Fuzzy C-Means", parname, parval,
                            center, partition, allclusters, viname, vival, isnamed, mf.userlang.NumberFormat.NumberDecimalSeparator);
                        of.Show();
                        mf.WindowState = FormWindowState.Minimized;
                        this.UseWaitCursor = false;
                        this.Close();
                        pb.Dispose();
                    }
                }

            }
        }
        private void processOutput()
        {
            DataTable dt = GetFromMainForm();
            REngine.SetEnvironmentVariables(); //Mencari lokasi .dll R secara otomatis
            REngine engine = REngine.GetInstance(); //inisialisasi R

            List<double> t = new List<double>();
            int nkol = selectedListBox.Items.Count;
            int kol1 = dt.Columns[selectedListBox.Items[0].ToString()].Ordinal;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                String row = dt.Rows[i].ItemArray[kol1].ToString();
                if (String.IsNullOrEmpty(row))
                {
                    break;
                }
                else
                {
                    double r = Convert.ToDouble(row);
                    t.Add(r);
                }
            }
            NumericVector u = engine.CreateNumericVector(t);
            engine.SetSymbol("matdt", u); //assign u in c# as matdt in R
            NumericMatrix matdata = engine.Evaluate("matdt").AsNumericMatrix();
            if (nkol > 1)
            {
                for (int j = 1; j < nkol; j++)
                {
                    //j = j + 1;
                    int kol = dt.Columns[selectedListBox.Items[j].ToString()].Ordinal;
                    List<double> s = new List<double>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        String row = dt.Rows[i].ItemArray[kol].ToString();
                        if (String.IsNullOrEmpty(row))
                        {
                            break;
                        }
                        else
                        {
                            double r = Convert.ToDouble(row);
                            s.Add(r);
                        }
                    }
                    String nokol = Convert.ToString(j + 1);
                    NumericVector v = engine.CreateNumericVector(s);
                    engine.SetSymbol("dum", v);
                    matdata = engine.Evaluate("matdt=matrix(cbind(matdt,dum),ncol=" + nokol + ")").AsNumericMatrix();
                }
            }
            int namekol = nameListBox.Items.Count;

            if (namekol != 0)
            {
                List<String> n = new List<String>();
                int namekol1 = dt.Columns[nameListBox.Items[0].ToString()].Ordinal;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    String row = dt.Rows[i].ItemArray[namekol1].ToString();
                    if (String.IsNullOrEmpty(row))
                    {
                        break;
                    }
                    else
                    {
                        n.Add(row);
                    }
                }
                CharacterVector a = engine.CreateCharacterVector(n);
                engine.SetSymbol("namedt", a);
                CharacterMatrix namedata = engine.Evaluate("namedt").AsCharacterMatrix();
                if (namekol > 1)
                {
                    for (int j = 1; j < nkol; j++)
                    {
                        //j = j + 1;
                        int kol = dt.Columns[nameListBox.Items[j].ToString()].Ordinal;
                        List<String> s = new List<String>();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            String row = dt.Rows[i].ItemArray[kol].ToString();
                            if (String.IsNullOrEmpty(row))
                            {
                                break;
                            }
                            else
                            {
                                s.Add(row);
                            }
                        }
                        String nokol = Convert.ToString(j + 1);
                        CharacterVector v = engine.CreateCharacterVector(s);
                        engine.SetSymbol("dum", v);
                        namedata = engine.Evaluate("namedt=matrix(cbind(namedt,dum),ncol=" + nokol + ")").AsCharacterMatrix();
                    }
                }
            }

            engine.Evaluate("m <- " + textBox_m.Text);
            CharacterVector m_ = engine.GetSymbol("m").AsCharacter();
            parname.Add("Fuzzifier (m)");
            parval.Add(m_[0]);

            engine.Evaluate("a <- " + textBox_konsa.Text);
            CharacterVector a_ = engine.GetSymbol("a").AsCharacter();
            parname.Add("a");
            parval.Add(a_[0]);

            engine.Evaluate("eta <- " + textBox_eta.Text);
            CharacterVector eta_ = engine.GetSymbol("eta").AsCharacter();
            parname.Add("Fuzzifier (η)");
            parval.Add(eta_[0]);

            engine.Evaluate("b <- " + textBox_konsb.Text);
            CharacterVector b_ = engine.GetSymbol("b").AsCharacter();
            parname.Add("b");
            parval.Add(b_[0]);

            engine.Evaluate("k <- " + textBox_konsk.Text);
            CharacterVector k_ = engine.GetSymbol("k").AsCharacter();
            parname.Add("K");
            parval.Add(k_[0]);

            String distance_text = listBox_distance.SelectedItem.ToString();
            //engine.Evaluate(@"distance <- """ + distance_text + "\"");
            engine.Evaluate(@"distance <- """ + distance_text + @"""");
            CharacterVector distance_ = engine.GetSymbol("distance").AsCharacter();
            parname.Add("Distance");
            parval.Add(distance_[0]);

            engine.Evaluate("c <- " + textBox_clus.Text);
            CharacterVector c_ = engine.GetSymbol("c").AsCharacter();
            parname.Add("Cluster");
            parval.Add(c_[0]);

            engine.Evaluate("loop <- " + textBox_maxiter.Text);
            CharacterVector loop_ = engine.GetSymbol("loop").AsCharacter();
            parname.Add("max PFCM loop");
            parval.Add(loop_[0]);

            engine.Evaluate("e <- " + textBox_error.Text);
            CharacterVector e_ = engine.GetSymbol("e").AsCharacter();
            parname.Add("Error criteria");
            parval.Add(e_[0]);

            engine.Evaluate("actualdata <- matdt");
            string bound_value = @"
             madt <- matrix(apply(matdt, 2, max),nrow = 1)
             midt <- matrix(apply(matdt, 2, min),nrow = 1)
            ";
            engine.Evaluate(bound_value);

            string path_source = Path.GetDirectoryName(Application.ExecutablePath);
            path_source = Path.Combine(path_source, "Main/PFCM.R");
            String pd_source = path_source.Replace("\\", Regex.Escape("/"));
            String cdplot_source = "";
            String apppath_source = pd_source + cdplot_source;
            engine.Evaluate("source('" + apppath_source + "')");

            String p_compute = @"
                       result <- pfcm(data = as.matrix(matdt), ncluster = c, m = m, eta = eta, K = k, a = a, b = b, distance = distance, max.iter = loop, error = e)
                        V <- result$centroid
                        U <- result$membership
                        loop <-result$max.iter
                        jf <- result$jf
                        actualcen = result$centroid
                        kel = result$finaldata[,1]
                        "

                       ;

            var watch = Stopwatch.StartNew();
            engine.Evaluate(p_compute);

            NumericMatrix cen = engine.GetSymbol("V").AsNumericMatrix();
            NumericMatrix loop = engine.GetSymbol("loop").AsNumericMatrix();
            parname.Add("Number of iteration");
            parval.Add((loop[0, 0] - 1).ToString());
            NumericMatrix lastof = engine.Evaluate("jf").AsNumericMatrix();
            parname.Add("Last objective function");
            parval.Add(lastof[0, 0].ToString());
            
            parname.Add("Computation time");
            parval.Add(watch.Elapsed.ToString());

            NumericMatrix actualdat = engine.GetSymbol("actualdata").AsNumericMatrix();
            NumericMatrix actualcen = engine.GetSymbol("actualcen").AsNumericMatrix();

            for (int i = 0; i < actualcen.ColumnCount; ++i)
            {
                center.Columns.Add();
            }
            for (int k = 0; k < actualcen.RowCount; ++k)
            {
                center.Rows.Add();
            }
            for (int i = 0; i < actualcen.RowCount; ++i)
            {
                for (int k = 0; k < actualcen.ColumnCount; ++k)
                {
                    center.Rows[i].SetField(k, actualcen[i, k]);
                }
            }

            NumericMatrix partmat = engine.Evaluate("U").AsNumericMatrix();

            if (namekol != 0)
            {
                DataFrame allpartmat = engine.Evaluate("data.frame(cbind(namedt,U))").AsDataFrame();
                for (int i = 0; i < allpartmat.ColumnCount; ++i)
                {
                    partition.Columns.Add();
                }
                for (int k = 0; k < allpartmat.RowCount; ++k)
                {
                    partition.Rows.Add();
                }
                for (int i = 0; i < allpartmat.RowCount; ++i)
                {
                    for (int k = 0; k < allpartmat.ColumnCount; ++k)
                    {
                        partition.Rows[i].SetField(k, allpartmat[i, k]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < partmat.ColumnCount; ++i)
                {
                    partition.Columns.Add();
                }
                for (int k = 0; k < partmat.RowCount; ++k)
                {
                    partition.Rows.Add();
                }
                for (int i = 0; i < partmat.RowCount; ++i)
                {
                    for (int k = 0; k < partmat.ColumnCount; ++k)
                    {
                        partition.Rows[i].SetField(k, partmat[i, k]);
                    }
                }
            }

            String partcm = @"
    kelompok=matrix(ncol=1,nrow=nrow(U))
    for(i in 1:nrow(U)){
        kelompok[i,]=which.max(U[i,])
    }
    ";
            engine.Evaluate(partcm);
            NumericMatrix kelompok = engine.Evaluate("kelompok").AsNumericMatrix();
            //validity index

            this.vival = new List<double>();
            this.viname = new List<String>();
            if (picheckBox.Checked)
            {
                engine.Evaluate(@"nPE <- result$validasi$EPE");
                NumericVector a = engine.GetSymbol("nPE").AsNumeric();
                vival.Add(a[0]);
                viname.Add("Partition Entropy");
            }

            if (xbcheckBox.Checked)
            {
                engine.Evaluate(@"nXB <- result$validasi$EXB");
                NumericVector a = engine.GetSymbol("nXB").AsNumeric();
                vival.Add(a[0]);
                viname.Add("Modified Partition Coefficient");
            }

            if (kwonbox.Checked)
            {
                engine.Evaluate(@"nKwon <- result$validasi$EKwon");
                NumericVector a = engine.GetSymbol("nKwon").AsNumeric();
                vival.Add(a[0]);
                viname.Add("Kwon");
            }

            String cm;

            if (namekol != 0)
            {
                cm = @"actualdata=data.frame(cbind(namedt,actualdata))
                    actualdata=cbind(actualdata,kelompok)";
                DataFrame allclust = engine.Evaluate(cm).AsDataFrame();
                for (int i = 0; i < allclust.ColumnCount; ++i)
                {
                    allclusters.Columns.Add();
                }
                for (int k = 0; k < allclust.RowCount; ++k)
                {
                    allclusters.Rows.Add();
                }

                for (int i = 0; i < allclust.RowCount; ++i)
                {
                    for (int k = 0; k < allclust.ColumnCount; ++k)
                    {
                        allclusters.Rows[i].SetField(k, allclust[i, k]);
                    }
                }
            }
            else
            {
                NumericMatrix allclust = engine.Evaluate("actualdata=cbind(actualdata,kelompok)").AsNumericMatrix();
                for (int i = 0; i < allclust.ColumnCount; ++i)
                {
                    allclusters.Columns.Add();
                }
                for (int k = 0; k < allclust.RowCount; ++k)
                {
                    allclusters.Rows.Add();
                }
                for (int i = 0; i < allclust.RowCount; ++i)
                {
                    for (int k = 0; k < allclust.ColumnCount; ++k)
                    {
                        allclusters.Rows[i].SetField(k, allclust[i, k]);
                    }
                }
            }

            if (namekol != 0)
            {
                isnamed = true;
            }
            else
            {
                isnamed = false;
            }

            if (plotcheckBox.Checked == true)
            {
                engine = REngine.GetInstance();
                engine.SetSymbol("data", actualdat);
                engine.SetSymbol("cluster", kelompok);
                string path_sourceR = Path.GetDirectoryName(Application.ExecutablePath);
                path_sourceR = Path.Combine(path_sourceR, "Main/fcm_distance.R");
                String pd_sourceR = path_sourceR.Replace("\\", Regex.Escape("/"));
                String cdplot_sourceR = "";
                String apppath_sourceR = pd_sourceR + cdplot_sourceR;
                engine.Evaluate("source('" + apppath_sourceR + "')");
                String script_cluster_plot = @"
    library(cluster)
    clusplot(data, cluster, color=TRUE, shade=TRUE,labels=0, lines=0,span=TRUE)
                ";

                String script_facto = @"
dev.new()
library(factoextra)
library(FactoMineR)
bi <- bi.plot(data=data,cluster=kel)
    print(bi)
";
                NumericVector klaster = engine.GetSymbol("c").AsNumeric();

                try
                {
                    //engine.Evaluate(script_cluster_plot);
                    //engine.Evaluate(script_ggplot);
                    if (klaster[0] <= 6)
                    {
                        engine.Evaluate(script_facto);
                    }
                    else
                    {
                        engine.Evaluate(script_cluster_plot);
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to display plot");
                }
            }
            if (RadarPlotCheckBox.Checked == true)
            {
                engine = REngine.GetInstance();
                engine.SetSymbol("data", actualdat);
                engine.SetSymbol("cluster", kelompok);
                engine.Evaluate("c <- " + textBox_clus.Text);

                string path_sourceR = Path.GetDirectoryName(Application.ExecutablePath);
                path_sourceR = Path.Combine(path_sourceR, "Main/fcm_distance.R");
                String pd_sourceR = path_sourceR.Replace("\\", Regex.Escape("/"));
                String cdplot_sourceR = "";
                String apppath_sourceR = pd_sourceR + cdplot_sourceR;
                engine.Evaluate("source('" + apppath_sourceR + "')");

                String script_radar = @"
                dev.new()
                rad <- radarplot (data=data, cluster=kel)
                print(rad)
                ";
                try
                {
                    engine.Evaluate(script_radar);
                }
                catch
                {
                    MessageBox.Show("Failed to display plot");
                }

            }
            if (mapcheckBox.Checked == true && maptextBox.Text != null && datakeyListBox.ValueMember != null)
            {
                engine = REngine.GetInstance();
                engine.SetSymbol("data", actualdat);
                string sha = maptextBox.Text.ToString();
                string shp = Regex.Replace(sha, @"\\", @"/");
                engine.Evaluate("shp <- '" + shp + "'");
                List<string> dk = new List<string>();
                int nk = datakeyListBox.Items.Count;
                int k1 = dt.Columns[datakeyListBox.Items[0].ToString()].Ordinal;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    String row = dt.Rows[i].ItemArray[k1].ToString();
                    if (String.IsNullOrEmpty(row))
                    {
                        break;
                    }
                    else
                    {
                        string ll = Convert.ToString(row);
                        dk.Add(ll);
                    }
                }
                CharacterVector dtk = engine.CreateCharacterVector(dk);
                engine.SetSymbol("dk", dtk);
                string path_sourceR = Path.GetDirectoryName(Application.ExecutablePath);
                path_sourceR = Path.Combine(path_sourceR, "Main/fcm_distance.R");
                String pd_sourceR = path_sourceR.Replace("\\", Regex.Escape("/"));
                String cdplot_sourceR = "";
                String apppath_sourceR = pd_sourceR + cdplot_sourceR;
                engine.Evaluate("source('" + apppath_sourceR + "')");
                String script_map = @"                
                dev.new()
                ma <- mapping(data, kel, shp, dk)
                print(ma)
                ";
                engine.Evaluate(script_map);
            }
        }


        private void textBox_att_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_c_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void shpDialog_FileOk(object sender, CancelEventArgs e)
        {
            string path = shpDialog.FileName;
            maptextBox.Text = path;
        }


        private void addDatakeyButton_Click(object sender, EventArgs e)
        {
            if (datakeyListBox.Items.Count == 0 && mapcheckBox.Checked == true)
            {
                if (allvarListBox.SelectedItems.Count == 1)
                {
                    datakeyListBox.Items.Add(allvarListBox.SelectedItem);
                    allvarListBox.Items.Remove(allvarListBox.SelectedItem);
                    allvarListBox.Sorted = true;
                    datakeyListBox.Sorted = true;
                }
                else MessageBox.Show("You can select only 1 variable");
            }
            else MessageBox.Show("You can put only 1 variable or you should check show map");
        }

        private void removeDatakeyButton_Click(object sender, EventArgs e)
        {
            if (datakeyListBox.SelectedItems.Count != 0)
            {
                allvarListBox.Items.Add(datakeyListBox.SelectedItem);
                datakeyListBox.Items.Remove(datakeyListBox.SelectedItem);
                allvarListBox.Sorted = true;
                datakeyListBox.Sorted = true;
            }
        }

        private void mapcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mapcheckBox.Checked == true)
            {
                addDatakeyButton.Enabled = true;
                removeDatakeyButton.Enabled = true;
                datakeyListBox.Enabled = true;
                browseButton.Enabled = true;
                maptextBox.Enabled = true;
            }
            else
            {
                addDatakeyButton.Enabled = false;
                removeDatakeyButton.Enabled = false;
                datakeyListBox.Enabled = false;
                browseButton.Enabled = false;
                maptextBox.Enabled = false;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (mapcheckBox.Checked)
            {
                shpDialog.Title = "Import Shapefile";
                shpDialog.FileName = "";
                shpDialog.RestoreDirectory = true;
                shpDialog.Filter = "Shapefile (*.shp)|*.shp";
                shpDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must check show map");
            }
        }

        private void allvarListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

