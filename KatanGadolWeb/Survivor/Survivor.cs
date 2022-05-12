using System.IO;
using Xabe.FFmpeg;
using Emgu.CV;
using Emgu.Util;
using System.Collections.Generic;
using System.Linq;

namespace Survivor
{
    public class Survivor
    {
        int age;
        string name;
        string country;
        Stream image;
        Stream intoVid;
        Stream storyVid;

        Survivor(int age, string name, string country, Stream image, Stream intoVid, Stream storyVid)
        {
            this.name = name;
            this.country = country;
            this.image = image;
            this.intoVid = intoVid;
            this.storyVid = storyVid;

            //ffmpeg
            // generate the convertion tool
            IConversion convertion = FFmpeg.Conversions.New();
            convertion.SetOutput("./final_video");

            // specifying the formats
            convertion.SetOutputFormat(Format.mp4);
            convertion.SetInputFormat(Format.mp4);

            //xable.CV
            
        }

        /// <summary>
        /// get the files to convert
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <returns></returns>
        private static IEnumerable<FileInfo> GetFilesToConvert(string directoryPath)
        {
            return new DirectoryInfo(directoryPath).GetFiles().Where(x => x.Extension == ".mkv" || x.Extension == ".mp4");
        }

        /// <summary>
        /// return a zoomIn video on a location
        /// </summary>
        /// <param name="loc"></param>
        public void ZoomIn(string loc)
        {
            switch (loc)
            {
                case "פולין":
                    return;
                case "הונגריה":
                    return;
                case "גרמניה":
                    return;
                case "שוויץ":
                    return;
                default:
                    break;
            }
        }
       
        public void StartMuvie()
        { 
            //
        }
    }

    
}
