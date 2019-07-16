using System.IO;
using System.Text;

namespace HpNotepad
{
    public class FileOperation
    {

        public static void WriteFile(string path, string fileContent)
        {            
            string dir = path.Substring(0, path.LastIndexOf("\\"));
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            //StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
            //try
            //{
            //    sw.Write(fileContent);
            //    sw.Flush();
            //    sw.Close();
            //    sw.Dispose();
            //}
            //catch (Exception e)
            //{
            //    throw e;
            //}
            //finally
            //{

            //}

            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.Write(fileContent);
            }
        }

        public static string ReadFile(string path)
        {          
            string content = "";
             
            if (System.IO.File.Exists(path))
            {
                //StreamReader sr = new StreamReader(path, Encoding.UTF8, false);
                //try
                //{
                //    content = sr.ReadToEnd();
                //}
                //catch (Exception ex)
                //{

                //}
                //finally
                //{
                //    sr.Close();
                //    sr.Dispose();
                //}
                using (StreamReader sr = new StreamReader(path, Encoding.Default, false))
                {
                    content = sr.ReadToEnd();
                }
            }
            return content;

        }
    }
}