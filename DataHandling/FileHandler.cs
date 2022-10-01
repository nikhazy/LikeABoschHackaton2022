using DataHandling.Model.ADMA;
using DataHandling.Model.Cam;
using DataHandling.Model.Common;
using DataHandling.Model.HostVehicle;
using DataHandling.Model.Rad;

namespace DataHandling
{
    public class FileHandler
    {

        //private string DirectoryPath = @"C:\Users\nikha\Downloads\SW Challenge 2022 - dataset\PSA_ADAS_W3_FC_2022-09-01_14-49_0054.MF4\";

        public void ReadAllFilesInFolder(string directory)
        {
            string[] files = Directory.GetFiles(directory);
            string path340 = files.FirstOrDefault(x => Path.GetFileNameWithoutExtension(x).Contains("340"));
            string path342 = files.FirstOrDefault(x => Path.GetFileNameWithoutExtension(x).Contains("342"));
            string path343 = files.FirstOrDefault(x => Path.GetFileNameWithoutExtension(x).Contains("343"));
            string path349 = files.FirstOrDefault(x => Path.GetFileNameWithoutExtension(x).Contains("349"));
            string path416 = files.FirstOrDefault(x => Path.GetFileNameWithoutExtension(x).Contains("416"));

            ReadAndProcessGroup416(path416);
            ReadAndProcessGroup349(path349);
            ReadAndProcessGroup340_342_343(path340, path342, path343);
        }

        public void ReadAndProcessGroup349(string path)
        {
            //string[] lines = File.ReadAllLines(DirectoryPath + "Group_349.csv");
            string[] lines = File.ReadAllLines(path);

            string[] headers = lines[0].Split(',');

            //Cam datas
            string[] camsDatasHeader = headers.Where(x => x.Contains("camData")).ToArray();

            int camDataTimeStampIndex = 0;
            List<List<int>> camIndexes = new List<List<int>>();
            for (int i = 0; i < 15; i++)
            {
                camIndexes.Add(new List<int>());
            }

            foreach (var camData in camsDatasHeader)
            {
                int colNumber = headers.ToList().IndexOf(camData);
                string[] camHeaderElement = camData.Split("_");
                if(camHeaderElement.Length > 25)
                {
                    int camObjIndex = Int32.Parse(camHeaderElement[23]);
                    camIndexes[camObjIndex].Add(colNumber);
                }
                else
                {
                    camDataTimeStampIndex = colNumber;
                }
            }

            //Radar datas
            string[] cornerDatas = headers.Where(x => x.Contains("cornerData")).ToArray();

            List<int> radataTimeStampIndexes = new List<int>();
            List<List<List<int>>> radarIndexes = new List<List<List<int>>>();
            for (int i = 0; i < 4; i++)
            {
                radarIndexes.Add(new List<List<int>>());
                for (int j = 0; j < 10; j++)
                {
                    radarIndexes.Last().Add(new List<int>());
                }
            }

            foreach (var radarData in cornerDatas)
            {

                int colNumber = headers.ToList().IndexOf(radarData);

                string[] radarHeaderElement = radarData.Split("_");
                int radarIndex = Int32.Parse(radarHeaderElement[21]);

                if (radarHeaderElement.Length > 28)
                {
                    int radarObjIndex = Int32.Parse(radarHeaderElement[27]);
                    radarIndexes[radarIndex][radarObjIndex].Add(colNumber);
                }
                else
                {
                    radataTimeStampIndexes.Add(colNumber);
                }
            }

            //Pos Cam
            string[] posCams = headers.Where(x => x.Contains("pos") && x.Contains("Cam")).ToArray();
            List<int> camPosIndexes = new List<int>();

            foreach (var posCamera in posCams)
            {
                int colNumber = headers.ToList().IndexOf(posCamera);

                camPosIndexes.Add(colNumber);
            }

            //Host vehicle
            //string[] vehicleHeaders = headers.Where(x => x.Contains("Ref_sw")).ToArray();
            //List<int> vehiclePosIndexes = new List<int>();

            //foreach (var vehivleHeader in vehicleHeaders)
            //{
            //    int colNumber = headers.ToList().IndexOf(vehivleHeader);

            //    vehiclePosIndexes.Add(colNumber);
            //}

            var sum = camsDatasHeader.Length + cornerDatas.Length + posCams.Length;

            for (int i = 1; i < lines.Length; i++)
            {
                string[] lineElements = lines[i].Split(',');

                Measurement.Instance.TimeStamp.Add(double.Parse(lineElements[0]));

                //Create Camera datas
                double timeStamp = double.Parse(lineElements[camDataTimeStampIndex]);

                Measurement.Instance.Camera.CameraTimeStamps.Add(timeStamp);
                for (int j = 0; j < 15; j++)
                {
                    List<string> camDataElements = new List<string>();
                    for (int k = 0; k < camIndexes[j].Count; k++)
                    {
                        camDataElements.Add(lineElements[camIndexes[j][k]]);
                    }
                    Measurement.Instance.Camera.CameraObjects[j].CameraDatas.Add(new CamData(camDataElements.ToArray()));
                }

                //Create Radar datas
                for (int j = 0; j < 4; j++)
                {
                    double radarTimeStamp = double.Parse(lineElements[radataTimeStampIndexes[j]]);
                    for (int k = 0; k < 10; k++)
                    {
                        List<string> radarDataElements = new List<string>();

                        for (int l = 0; l < radarIndexes[j][k].Count; l++)
                        {
                            radarDataElements.Add(lineElements[radarIndexes[j][k][l]]);
                        }

                        Measurement.Instance.Radars[j].RadarObjects[k].RadarDatas.Add(new RadarData(radarDataElements.ToArray()));
                    }
                }

                //Cam position
                List<string> camPosDataElements = new List<string>();
                for (int j = 0; j < camPosIndexes.Count; j++)
                {
                    camPosDataElements.Add(lineElements[camPosIndexes[j]]);
                }

                Measurement.Instance.Camera.CameraPositions.Add(new Position(camPosDataElements.ToArray()));

            }
        }

        public void ReadAndProcessGroup340_342_343(string path340, string path342, string path343)
        {
            string[] lines340 = File.ReadAllLines(path340);
            string[] lines342 = File.ReadAllLines(path342);
            string[] lines343 = File.ReadAllLines(path343);

            for (int i = 1; i < lines340.Length; i++)
            {
                List<string> dataElements = new List<string>();
                string[] lineElement340 = lines340[i].Split(',');
                string[] lineElement342 = lines342[i].Split(',');
                string[] lineElement343 = lines343[i].Split(',');

                dataElements.Add(lineElement340[0]);
                dataElements.Add(lineElement340[1]);
                dataElements.Add(lineElement342[1]);
                dataElements.Add(lineElement342[2]);
                dataElements.Add(lineElement343[1]);
                dataElements.Add(lineElement343[2]);

                Measurement.Instance.Adma.AdmaDatas.Add(new AdmaData(dataElements.ToArray()));

            }
        }

        public void ReadAndProcessGroup416(string path)
        {
            //string[] lines = File.ReadAllLines(DirectoryPath + "Group_416.csv");
            string[] lines = File.ReadAllLines(path);
            string[] headers = lines[0].Split(',');

            for (int i = 1; i < lines.Length; i++)
            {
                string[] lineElements = lines[i].Split(',');

                Measurement.Instance.Vehicle.VehicleDatas.Add(new VehicleData(lineElements.ToArray()));

            }
        }

        //public List<int> GetIndexesFromHeader(string[] headers)
        //{

        //}
    }
}