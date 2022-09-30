namespace DataHandling
{
    public class FileHandler
    {

        private string DirectoryPath = @"C:\Users\nikha\Downloads\SW Challenge 2022 - dataset\PSA_ADAS_W3_FC_2022-09-01_14-49_0054.MF4\";


        public void ReadFile()
        {
            string[] lines = File.ReadAllLines(DirectoryPath + "Group_349.csv");

            string[] headers = lines[0].Split(',');

            string[] camsDatas = headers.Where(x => x.Contains("camData")).ToArray();

            string[] cornerDatas = headers.Where(x => x.Contains("cornerData")).ToArray();

            string[] posCams = headers.Where(x => x.Contains("pos") && x.Contains("Cam")).ToArray();

            string[] refSWs = headers.Where(x => x.Contains("Ref_sw")).ToArray();

            var sum = camsDatas.Length + cornerDatas.Length + posCams.Length + refSWs.Length;
        }
    }
}