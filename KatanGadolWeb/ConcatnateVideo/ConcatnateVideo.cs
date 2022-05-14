using NReco.VideoConverter;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatnateVideo
{
    class ConcatnateVideo
    {
    
        static void Main(string[] args)
        {
            while (true)
            {
                // the file exists -> check the stop cindition
                if (File.Exists(@"C:\hackathon5\KatanGadol\KatanGadolWeb\Done\Done.txt"))
                {
                    //File.Delete(@"C:\hackathon5\KatanGadol\KatanGadolWeb\Done\Done.txt");
                    //File.Delete();
                    //get the files from the folder only if the done file id oploaded
                    string[] filesToConcat = GetFilesToConvert(@"C:\hackathon5\KatanGadol\KatanGadolWeb\inputVideos");
                    string dest = @"C:\hackathon5\KatanGadol\KatanGadolWeb\outputVideo\holocast.mp4";

                    // render the concatenated video
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    NReco.VideoConverter.ConcatSettings set = new NReco.VideoConverter.ConcatSettings();
                    ffMpeg.ConcatMedia(filesToConcat, dest, NReco.VideoConverter.Format.mp4, set);

                    Process.Start(dest);
                    break;
                }
            }
        }

        /// <summary>
        /// get the files to convert
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <returns></returns>
        private static string[] GetFilesToConvert(string directoryPath)
        {
            return new DirectoryInfo(directoryPath).GetFiles().Where(x => x.Extension == ".mkv" || x.Extension == ".mp4")
                                                              .Select(x=> x.FullName).ToArray();
        }
   
    }
}
