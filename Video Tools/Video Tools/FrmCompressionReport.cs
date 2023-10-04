using System;
using System.Windows.Forms;

namespace Video_Tools
{
    public partial class FrmCompressionReport : Form
    {
        public FrmCompressionReport(int nbFiles, string duration, long inputSize, long outputSize,
            string extraReportInfo, uint nbRevertedFiles, string revertedFiles)
        {
            InitializeComponent();

            txtReportDesc.Text = string.Format(
                "{0} files were compressed in {1}.\nThe total size went from {2} bytes to {3} bytes.\n" +
                "The average file shrinking is {4}%.\n{5}\n{6} output files were bigger than their input.\n{7}",
                nbFiles, duration, inputSize, outputSize, 100 - Math.Round((double)outputSize / inputSize * 100),
                extraReportInfo, nbRevertedFiles, revertedFiles
            );
        }

        private void btnReportClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
