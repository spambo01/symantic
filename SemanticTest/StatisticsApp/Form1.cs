using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int countDataSetValues = 0;
            var sampleDataValues = ReadFile();
            double mean = CalculateMean(ref countDataSetValues, sampleDataValues);
            int[] histogram = new int[10];
            int upperLimit = 0;
            lblMeanResult.Text =mean.ToString(); 
            lblStdDeviation.Text = CalculateStddeviation(countDataSetValues,mean, sampleDataValues).ToString();           
            histogram = CalculateHistogram(sampleDataValues);
            lblHistogramResults.Text = "";
            for (int i = 0; i < histogram.Length; i++)
            {
                upperLimit = i + 1;
                lblHistogramResults.Text += "From " + i + "0 to " + upperLimit + "0 there are " + histogram[i] + " numbers \n";
            }
        }

        private List<double> ReadFile()
        {
            List<double> values = new List<double>();
            try
            {                
                using (var reader = new StreamReader(Application.StartupPath +
                   "\\Data\\SampleData.csv"))
                {
                    List<double> sampleDataNumbers = new List<double>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        values = line.Split(',').Select(double.Parse).ToList();
                    }
                }                
            }
            catch (PathTooLongException pathTooLong)
            {
                MessageBox.Show("PathTooLongException " + pathTooLong.Message);
            }
            catch (DirectoryNotFoundException directoryNotFound)
            {
                MessageBox.Show("DirectoryNotFoundException " + directoryNotFound.Message);
            }
            catch (UnauthorizedAccessException unauthorizedAccess)
            {
                MessageBox.Show("UnauthorizedAccessException " + unauthorizedAccess.Message);
            }
            catch (FileNotFoundException fileNotFound)
            {
                MessageBox.Show("FileNotFoundException " + fileNotFound.Message);
            }
            catch (NotSupportedException notSupported)
            {
                MessageBox.Show("NotSupportedException " + notSupported.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic" + ex.Message);
            }
                return values;            
        }

        private double CalculateMean(ref int countOfValues, List<double> sampleDataValues)
        {
            double mean = 0;
            double sum = 0;
            // I can get the size of the list by doing sampleDataValues.Count but accordingly to the
            // instructions I should use built in functionality as little as possible
            countOfValues = 0;            
            foreach (var dataValue in sampleDataValues)
            {
                sum += dataValue;
                countOfValues++;
            }
            mean = (sum / countOfValues);
            return mean;
        }

        private double CalculateStddeviation(int countDataSetValues, double mean, List<double> sampleDataValues)
        {
            double stdDeviation = 0;
            double sumDistances = 0;
            double squareOfDistanceFromMean = 0;
            foreach (var dataValue in sampleDataValues)
            {
                // I can use Math.Pow for square but accordingly to the
                // instructions I should use built in functionality as little as possible
                squareOfDistanceFromMean = (dataValue - mean) * (dataValue - mean);
                sumDistances += squareOfDistanceFromMean;
            }
            stdDeviation= Math.Sqrt(sumDistances/ countDataSetValues);
            return stdDeviation;
        }

        //to avoid a huge switch/else if statement I ll use mod because there is
        //a relation between the index of the table and the bins of 10.
        //Code is cleaner and more efficient.
        private int[] CalculateHistogram(List<double> sampleDataValues)
        {
            int[] histogram = new int[10];
            int index;
            foreach (var dataValue in sampleDataValues)
            {
                index = (int)(Math.Floor(dataValue / 10));
                histogram[index]++;
            }
            return histogram;
        }
    }
}
