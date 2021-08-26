using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Emgu.CV.UI;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

using System.IO;
using System.Xml;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Drawing.Imaging;
using System.Drawing;

/// <summary>
/// Desingned to remove the training a EigenObjectRecognizer code from the main form
/// </summary>
class Classifier_Train: IDisposable
{

#region Variables

//Eigen
//EigenObjectRecognizer recognizer;
public FaceRecognizer recognizer;
appvb.dsTableAdapters.tmp_fotosTableAdapter ta_tmp = new appvb.dsTableAdapters.tmp_fotosTableAdapter();
appvb.ds.tmp_fotosDataTable dt_tmp = new appvb.ds.tmp_fotosDataTable();
appvb.ds.tmp_fotosRow fila_fotos;

//training variables
public List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();//Images
//TODO: see if this can be combined in Ditionary format this will remove support for old data
public List<string> Names_List = new List<string>(); //labels
public List<int> Names_List_ID = new List<int>();
int ContTrain, NumLabels;
public float Eigen_Distance = 0;
string Eigen_label;
public int Eigen_threshold = 4500;
int LBPH_threshold = 0;
//Class Variables
string Error;
bool _IsTrained = false;

public string Recognizer_Type = "EMGU.CV.EigenFaceRecognizer";
#endregion

	#region Constructors
	/// <summary>
	/// Default Constructor, Looks in (Application.StartupPath + "\\TrainedFaces") for traing data.
	/// </summary>



	/// <summary>
	/// Takes String input to a different location for training data
	/// </summary>
	/// <param name="Training_Folder"></param>
public Classifier_Train()
{
	string metodo;
	appvb.dsTableAdapters.parametrosTableAdapter ta = new appvb.dsTableAdapters.parametrosTableAdapter();
	appvb.ds.parametrosDataTable dt = new appvb.ds.parametrosDataTable();
	appvb.ds.parametrosRow fila;
	try
	{
		ta.Fill(dt);
		fila = (appvb.ds.parametrosRow)dt.Rows[0];
		metodo = fila.metodo;
		Recognizer_Type = metodo;
	}
	catch {
		Recognizer_Type = "EMGU.CV.LBPHFaceRecognizer";
	}

	_IsTrained = LoadTrainingData();
}
    #endregion

    #region Public
    /// <summary>
    /// Retrains the recognizer witout resetting variables like recognizer type.
    /// </summary>
    /// <returns></returns>
    public bool Retrain()
    {
        return _IsTrained = LoadTrainingData();
    }
    /// <summary>
    /// Retrains the recognizer witout resetting variables like recognizer type.
    /// Takes String input to a different location for training data.
    /// </summary>
    /// <returns></returns>
    //public bool Retrain()
    //{
    //    return _IsTrained = LoadTrainingData();
    //}

    /// <summary>
    /// <para>Return(True): If Training data has been located and Eigen Recogniser has been trained</para>
    /// <para>Return(False): If NO Training data has been located of error in training has occured</para>
    /// </summary>
    public bool IsTrained
    {
        get { return _IsTrained; }
    }
	public void cambiar_tipo_reg() {
		try
		{
			switch (Recognizer_Type)
			{
				case ("EMGU.CV.EigenFaceRecognizer"):
					recognizer = new EigenFaceRecognizer(80, double.PositiveInfinity);
					break;
				case ("EMGU.CV.LBPHFaceRecognizer"):
					recognizer = new LBPHFaceRecognizer(1, 8, 8, 8, 100);//50
					break;
				case ("EMGU.CV.FisherFaceRecognizer"):
					recognizer = new FisherFaceRecognizer(0, 3500);//4000
					break;
			}
		}
		catch {
		}


	}
    /// <summary>
    /// Recognise a Grayscale Image using the trained Eigen Recogniser
    /// </summary>
    /// <param name="Input_image"></param>
    /// <returns></returns>
	/// 
public string Recognise(Image<Gray, byte> Input_image, int Eigen_Thresh = -1)
{
    if (_IsTrained)
    {       
		FaceRecognizer.PredictionResult ER = recognizer.Predict(Input_image);
		if (ER.Label == Names_List.Count+1 )
		{
			Eigen_label = "Unknown";
			Eigen_Distance = 0;
			return Eigen_label;
		}

		if (ER.Label == -1)
        {
            Eigen_label = "Unknown";
            Eigen_Distance = 0;
            return Eigen_label;
        }
        else
        {
            Eigen_label = Names_List[ER.Label-1];
            Eigen_Distance = (float)ER.Distance;

			if (Eigen_Thresh > -1)
			{
				Eigen_threshold = Eigen_Thresh;
			}
				// Solo use la regla de umbral posterior si estamos usando un Eigen Recognizer
				// dado que el umbral de Fisher y LBHP establecido durante el constructor funcionará correctamente
				switch (Recognizer_Type)
            {
				case ("EMGU.CV.EigenFaceRecognizer"):
					if (Eigen_Distance < Eigen_threshold) return Eigen_label;
					else return "Unknown";

				case ("EMGU.CV.LBPHFaceRecognizer"):
						//entre mas pequeño el umbral el match es perfecto
						// umbral mayor a 48 significa que es una cara parecida
						//pero no es el individuo de la base de datos
						if (Eigen_Distance <46 ) return Eigen_label;
						else return "Unknown";
					case ("EMGU.CV.FisherFaceRecognizer"):
						if (Eigen_Distance < 200) return Eigen_label;
						else return "Unknown";
					default:
					return Eigen_label; //the threshold set in training controls unknowns
			}
        }
    }
    else return "";
}

    /// <summary>
    /// Sets the threshold confidence value for string Recognise(Image<Gray, byte> Input_image) to be used.
    /// </summary>
    public int Set_Eigen_Threshold
    {
        set
        {
            //NOTE: This is still not working correctley 
            //recognizer.EigenDistanceThreshold = value;
            Eigen_threshold = value;
        }
    }

    /// <summary>
    /// Returns a string containg the recognised persons name
    /// </summary>
    public string Get_Eigen_Label
    {
        get
        {
            return Eigen_label;
        }
    }

    /// <summary>
    /// Returns a float confidence value for potential false clasifications
    /// </summary>
    public float Get_Eigen_Distance
    {
        get
        {
            //get eigenDistance
            return Eigen_Distance;
        }
    }

    /// <summary>
    /// Returns a string contatining any error that has occured
    /// </summary>
    public string Get_Error
    {
        get { return Error; }
    }

    /// <summary>
    /// Saves the trained Eigen Recogniser to specified location
    /// </summary>
    /// <param name="filename"></param>
    public void Save_Eigen_Recogniser(string filename)
    {
        recognizer.Save(filename);

        //save label data as this isn't saved with the network
        string direct = Path.GetDirectoryName(filename);
        FileStream Label_Data = File.OpenWrite(direct + "/Labels.xml");
        using (XmlWriter writer = XmlWriter.Create(Label_Data))
        {
            writer.WriteStartDocument();
            writer.WriteStartElement("Labels_For_Recognizer_sequential");
            for (int i = 0; i < Names_List.Count; i++)
            {
                writer.WriteStartElement("LABEL");
                writer.WriteElementString("POS", i.ToString());
                writer.WriteElementString("NAME", Names_List[i]);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
        }
        Label_Data.Close();
    }

    /// <summary>
    /// Loads the trained Eigen Recogniser from specified location
    /// </summary>
    /// <param name="filename"></param>
    public void Load_Eigen_Recogniser(string filename)
    {
        //Lets get the recogniser type from the file extension
        string ext = Path.GetExtension(filename);
        switch (ext)
        {
            case (".LBPH"):
                Recognizer_Type = "EMGU.CV.LBPHFaceRecognizer";
                recognizer = new LBPHFaceRecognizer(1, 8, 8, 8, 100);//50
                break;
            case (".FFR"):
                Recognizer_Type = "EMGU.CV.FisherFaceRecognizer";
                recognizer = new FisherFaceRecognizer(0, 3500);//4000
                break;
            case (".EFR"):
                Recognizer_Type = "EMGU.CV.EigenFaceRecognizer";
                recognizer = new EigenFaceRecognizer(80, double.PositiveInfinity);
                break;
        }

        //introduce error checking
        recognizer.Load(filename);

        //Now load the labels
        string direct = Path.GetDirectoryName(filename);
        Names_List.Clear();
        if (File.Exists(direct + "/Labels.xml"))
        {
            FileStream filestream = File.OpenRead(direct + "/Labels.xml");
            long filelength = filestream.Length;
            byte[] xmlBytes = new byte[filelength];
            filestream.Read(xmlBytes, 0, (int)filelength);
            filestream.Close();

            MemoryStream xmlStream = new MemoryStream(xmlBytes);

            using (XmlReader xmlreader = XmlTextReader.Create(xmlStream))
            {
                while (xmlreader.Read())
                {
                    if (xmlreader.IsStartElement())
                    {
                        switch (xmlreader.Name)
                        {
                            case "NAME":
                                if (xmlreader.Read())
                                {
                                    Names_List.Add(xmlreader.Value.Trim());
                                }
                                break;
                        }
                    }
                }
            }
            ContTrain = NumLabels;
        }
        _IsTrained = true;

    }

        /// <summary>
    /// Dispose of Class call Garbage Collector
    /// </summary>
    public void Dispose()
    {
        recognizer = null;
        trainingImages = null;
        Names_List = null;
        Error = null;
        GC.Collect();
    }

	#endregion

	#region Private
	/// <summary>
	/// Loads the traing data given a (string) folder location
	/// </summary>
	/// <param name="Folder_location"></param>
	/// <returns></returns>


private bool LoadTrainingData(){
try {
	ta_tmp.Fill(dt_tmp);
	Names_List.Clear();
    Names_List_ID.Clear();
    trainingImages.Clear();
	string LoadFaces;
	Int32 poss;
	for (int kl = 0; kl < dt_tmp.Rows.Count; kl++){
		fila_fotos = (appvb.ds.tmp_fotosRow)dt_tmp.Rows[kl ];
		Names_List_ID.Add(fila_fotos.pos ); //0, 1, 2, 3....
		Names_List.Add(fila_fotos.ced );
		poss = kl+1;
		LoadFaces = "face" + fila_fotos.pos.ToString()  + ".jpg";
		trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
		NumLabels += 1;
	}
    ContTrain = NumLabels;
    if (trainingImages.ToArray().Length != 0) {
		switch (Recognizer_Type) {
            case ("EMGU.CV.LBPHFaceRecognizer"):
                recognizer = new LBPHFaceRecognizer(1, 8, 8, 8, 100);//50
                break;
            case ("EMGU.CV.FisherFaceRecognizer"):
                recognizer = new FisherFaceRecognizer(0, 3500);//4000
                break;
            case("EMGU.CV.EigenFaceRecognizer"):
            default:
                recognizer = new EigenFaceRecognizer(80, double.PositiveInfinity);
                break;
        }
        recognizer.Train(trainingImages.ToArray(), Names_List_ID.ToArray());
        return true;
    }
    else return false;
}
catch (Exception ex) {
    Error = ex.ToString();
    return false;
}
}


	#endregion
}

