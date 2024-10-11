using System.Diagnostics.PerformanceData;
using System.Text;
using System.IO.Compression;
using System.IO;
using System.Diagnostics.Metrics;
using System.Net;

namespace MakeSVGenome
{
    public partial class Form1 : Form
    {
        StringBuilder insert = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string[] items = txtDonor.Text.Split('-');
            if (items.Length == 0)
            { insert = new StringBuilder(); }
            else
            {
                string fileDonor = FileString.OpenAs("Select the base sequence file", "*.fa|*.fa;*.fasta");
                if (System.IO.File.Exists(fileDonor) == false) { return; }

                insert = new StringBuilder();

                System.IO.StreamReader sf = null;
                try
                {
                    int startPoint = -1;
                    int endPoint = -1;
                    startPoint = Convert.ToInt32(items[0].Replace(",", ""));
                    endPoint = Convert.ToInt32(items[1].Replace(",", ""));
                    if (startPoint > endPoint)
                    {
                        int t = startPoint;
                        startPoint = endPoint;
                        endPoint = t;
                    }

                    sf = new StreamReader(fileDonor);
                    int counter = 0;

                    while (sf.Peek() != 0)
                    {
                        char bp = (char)sf.Read();
                        if (bp == '>')
                        { sf.ReadLine(); }
                        else if (char.IsLetter(bp) == true)
                        {
                            counter++;
                            if (counter >= startPoint && counter <= endPoint)
                            { insert.Append(bp); }
                        }
                        else if (counter > endPoint)
                        { break; }
                    }

                    if (chkRC.Checked == true)
                    { insert = ReverseComplement(insert); }
                    else { insert = UpperCase(insert); }

                }
                catch (Exception ex)
                {
                    insert = new StringBuilder();
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally { if (sf != null) { sf.Close(); } }


                if (insert.Length > 0)
                { lblInsert.Text = "Enter location of donor sequence (e.g. 100,000,000-105,000,000)" + " - " + insert.Length.ToString() + " bp"; }
                else
                { lblInsert.Text = "Enter location of donor sequence (e.g. 100,000,000-105,000,000)" + " - No sequence"; }
            }
        }

        private StringBuilder ReverseComplement(StringBuilder sb)
        {
            StringBuilder RCsb = new StringBuilder(sb.Length);
            for (int i = sb.Length - 1; i > -1; i--)
            {
                switch (sb[i])
                {
                    case 'a':
                    case 'A':
                        RCsb.Append("T");
                        break;
                    case 'c':
                    case 'C':
                        RCsb.Append("G");
                        break;
                    case 'g':
                    case 'G':
                        RCsb.Append("C");
                        break;
                    case 't':
                    case 'T':
                        RCsb.Append("A");
                        break;
                    default:
                        RCsb.Append("N");
                        break;
                }
            }

            return RCsb;
        }

        private string ReverseComplement(string sb)
        {
            StringBuilder RCsb = new StringBuilder(sb.Length);
            for (int i = sb.Length - 1; i > -1; i--)
            {
                switch (sb[i])
                {
                    case 'a':
                    case 'A':
                        RCsb.Append("T");
                        break;
                    case 'c':
                    case 'C':
                        RCsb.Append("G");
                        break;
                    case 'g':
                    case 'G':
                        RCsb.Append("C");
                        break;
                    case 't':
                    case 'T':
                        RCsb.Append("A");
                        break;
                    default:
                        RCsb.Append("N");
                        break;
                }
            }

            return RCsb.ToString();
        }

        private StringBuilder UpperCase(StringBuilder sb)
        {
            StringBuilder Uppersb = new StringBuilder(sb.Length);
            for (int i = 0; i < sb.Length; i++)
            {
                switch (sb[i])
                {
                    case 'a':
                    case 'A':
                        Uppersb.Append("A");
                        break;
                    case 'c':
                    case 'C':
                        Uppersb.Append("C");
                        break;
                    case 'g':
                    case 'G':
                        Uppersb.Append("G");
                        break;
                    case 't':
                    case 'T':
                        Uppersb.Append("T");
                        break;
                    default:
                        Uppersb.Append("N");
                        break;
                }
            }

            return Uppersb;
        }

        private void btnPut_Click(object sender, EventArgs e)
        {
            if (insert == null) { insert = new StringBuilder(); }

            string[] items = txtInsertion.Text.Split('-');
            if (items.Length != 2)
            { MessageBox.Show("Most enter two locations", "Error"); }
            else
            {
                string fileDonor = FileString.OpenAs("Select the base sequence file", "*.fa|*.fa;*.fasta");
                if (System.IO.File.Exists(fileDonor) == false) { return; }

                string fileSaveAs = FileString.SaveAs("Enter the name of the new reference file", "*.fa | *.fa; *.fasta");
                if (fileSaveAs == "Cancel") { return; }

                System.IO.StreamWriter sw = null;
                System.IO.StreamReader sf = null;
                try
                {
                    int startPoint = -1;
                    int endPoint = -1;
                    startPoint = Convert.ToInt32(items[0].Replace(",", ""));
                    endPoint = Convert.ToInt32(items[1].Replace(",", ""));
                    if (startPoint > endPoint)
                    {
                        int t = startPoint;
                        startPoint = endPoint;
                        endPoint = t;
                    }

                    sw = new StreamWriter(fileSaveAs);
                    sf = new StreamReader(fileDonor);

                    int counter = 0;

                    while (sf.Peek() > 0)
                    {
                        char bp = (char)sf.Read();
                        if (bp == '>')
                        {
                            sw.Write(bp + sf.ReadLine() + "\n");
                        }
                        else if (char.IsLetter(bp) == true)
                        {
                            counter++;
                            if (counter < startPoint || counter > endPoint)
                            { sw.Write(bp); }
                            else if (counter == startPoint)
                            { sw.Write(insert.ToString()); }
                        }
                        else if (char.IsLetter(bp) == true)
                        {
                            counter++;
                            if (counter >= startPoint && counter <= endPoint)
                            { insert.Append(bp); }
                        }
                    }

                }
                catch (Exception ex)
                {
                    insert = new StringBuilder();
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (sf != null) { sf.Close(); }
                    if (sw != null) { sw.Close(); }
                }
            }
        }

        private void btnMakeRead_Click(object sender, EventArgs e)
        {
            int length = (int)nudlength.Value * 1000;
            int interval = (int)nudInterval.Value * 1000;


            string folder = FileString.GetFolder("Select the folder of fasta files", "");
            if (System.IO.Directory.Exists(folder) == false) { return; }

            string[] fastas = System.IO.Directory.GetFiles(folder, "*.fasta");
            string[] fas = System.IO.Directory.GetFiles(folder, "*.fa");
            string[] fnas = System.IO.Directory.GetFiles(folder, "*.fna");

            foreach (string s in fastas)
            { MakeReads(s, length, interval); }
            foreach (string s in fas)
            { MakeReads(s, length, interval); }
            foreach (string s in fnas)
            { MakeReads(s, length, interval); }

        }

        private void MakeReads(string filename, int length, int interval)
        {
            string title = Text;

            int index = filename.LastIndexOf('.');
            if (index == -1) { return; }
            
            string output = filename.Substring(0, index) + ".fastq.gz";
            index  = filename.LastIndexOf("\\");
            Text = filename.Substring(index + 1);
            string newTitle = Text + ": ";
            Application.DoEvents();

            StringBuilder wholeSequence = new StringBuilder();
            System.IO.FileStream sw = null;
            
            try
            {
                string qualityString = "+\n" + new string('F', length) +"\n";

                sw = new FileStream(output, FileMode.Create);
                GZipStream gzipStream = new GZipStream(sw, CompressionMode.Compress);
                
                wholeSequence = getSequence(filename);
                string ecneuqeSelohw = ReverseComplement(wholeSequence.ToString());
            
                int count = 0;
                bool invert = false;
                for (index = 0; index < wholeSequence.Length - length; index += interval)
                {
                    string insert = "";
                    if (invert == true)
                    { insert = ReverseComplement(wholeSequence.ToString(index, length)); }
                    else 
                    {
                        int start = (wholeSequence.Length - (length + 1)) - index;
                        insert = ecneuqeSelohw.Substring(start, length); 
                    }
                    invert = !invert;

                    byte[] data = Encoding.UTF8.GetBytes("@" + Readname() + "\n" + insert + "\n" + qualityString);
                    gzipStream.Write(data, 0, data.Length);
                    if (count > 999)
                    { 
                        Text = newTitle + index.ToString("N0");
                        Application.DoEvents();
                        count=0;
                    }
                     count++; 
                }
                gzipStream.Close();
                gzipStream.Dispose();
                sw.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (sw != null) { sw.Close(); }
                Text = title;
            }

        }

        private StringBuilder getSequence(string filename)
        {
            StringBuilder sb = new StringBuilder();
            System.IO.StreamReader sf = null;
            try
            {
                sf = new StreamReader(filename);
                while (sf.Peek() > 0)
                {
                    char bp = (char)sf.Read();
                    if (bp == '>')
                    {
                        sf.ReadLine() ;
                    }
                    else if (char.IsLetter(bp) == true)
                    {
                        if ((bp == 'N' || bp == 'n')== false)
                        { sb.Append(bp); }
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (sf != null) { sf.Close(); }
            }

            return sb;

        }

        private string Readname()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder result = new StringBuilder(25);
            Random random = new Random();

            for (int i = 0; i < 25; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }

    }
}
