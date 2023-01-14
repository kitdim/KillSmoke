using System.Text;

namespace KillSmokeConsoleaApp.Main
{
    internal class Load
    {
        private const string PATH = @"data\countCig.dat";
        private static int countCig;

        public static int Loading() //TODO Разобраться как сохранять данные из файла dat
        {
            try
            {
                using (var stream = File.Open(PATH, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        countCig = reader.ReadInt32();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error\n");
                Console.WriteLine(e.ToString());
            }

            return countCig;
        }

    }
}
