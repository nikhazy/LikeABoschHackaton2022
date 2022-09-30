namespace DataHandling
{
    public class FileHandler
    {

        private string DirectoryPath = @"C:\Users\nikha\Downloads\SW Challenge 2022 - dataset\PSA_ADAS_W3_FC_2022-09-01_14-49_0054.MF4\";


        public void ReadFile()
        {
            string[] lines = File.ReadAllLines(DirectoryPath + "Group_349.csv");

            string[] headers = lines[0].Split(',');

            string[] camsDatasHeader = headers.Where(x => x.Contains("camData")).ToArray();

            int camDataTimeStampIndex = 0;
            List<List<int>> indexes = new List<List<int>>();
            for (int i = 0; i < 15; i++)
            {
                indexes.Add(new List<int>());
            }

            foreach (var camData in camsDatasHeader)
            {
                int colNumber = headers.ToList().IndexOf(camData);
                string[] camHeaderElement = camData.Split("_");
                if(camHeaderElement.Length > 25)
                {
                    int camObjIndex = Int32.Parse(camHeaderElement[23]);
                    indexes[camObjIndex].Add(colNumber);
                }
                else
                {
                    camDataTimeStampIndex = colNumber;
                }
            }

            string[] cornerDatas = headers.Where(x => x.Contains("cornerData")).ToArray();

            string[] posCams = headers.Where(x => x.Contains("pos") && x.Contains("Cam")).ToArray();

            string[] refSWs = headers.Where(x => x.Contains("Ref_sw")).ToArray();

            var sum = camsDatasHeader.Length + cornerDatas.Length + posCams.Length + refSWs.Length;
        }
    }
}