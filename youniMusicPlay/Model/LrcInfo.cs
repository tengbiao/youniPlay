using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Configuration;
namespace youni.Model
{
    public class LrcInfo
    {
        public static string BaseUrl = ConfigurationManager.AppSettings["MP3AndVideoFolder"];

        /// <summary>
        /// 歌曲
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 艺术家
        /// </summary>
        public string Artist { get; set; }
        /// <summary>
        /// 专辑
        /// </summary>
        public string Album { get; set; }
        /// <summary>
        /// 歌词作者
        /// </summary>
        public string LrcBy { get; set; }
        /// <summary>
        /// 偏移量
        /// </summary>
        public string Offset { get; set; }

        /// <summary>
        /// 歌词
        /// </summary>
        public Dictionary<double, string> LrcWord = new Dictionary<double, string>();

        /// <summary>
        /// 获得歌词信息
        /// </summary>
        /// <param name="LrcPath">歌词路径</param>
        /// <returns>返回歌词信息(Lrc实例)</returns>
        public static LrcInfo InitLrc(string LrcPath)
        {
            try
            {
                //读取网络lrc歌词
                if (LrcPath.Contains("http"))
                {
                    var requst = (HttpWebRequest)WebRequest.Create(new Uri(LrcPath));
                    requst.Method = "GET";
                    using (var response = (HttpWebResponse)requst.GetResponse())
                    {
                        using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                        {
                            return GetLrcInfoByStream(sr);
                        }
                    }
                }
                else
                {//本地歌词
                    using (FileStream fs = new FileStream(Path.Combine(BaseUrl,LrcPath), FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        using (StreamReader sr = new StreamReader(fs, Encoding.Default))
                        {
                            return GetLrcInfoByStream(sr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private static LrcInfo GetLrcInfoByStream(StreamReader sr)
        {
            LrcInfo lrc = new LrcInfo();
            string line;
            Regex regex = new Regex(@"\[([0-9.:]*)\]+(.*)", RegexOptions.Compiled);
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("[ti:"))
                {
                    lrc.Title = SplitInfo(line);
                }
                else if (line.StartsWith("[ar:"))
                {
                    lrc.Artist = SplitInfo(line);
                }
                else if (line.StartsWith("[al:"))
                {
                    lrc.Album = SplitInfo(line);
                }
                else if (line.StartsWith("[by:"))
                {
                    lrc.LrcBy = SplitInfo(line);
                }
                else if (line.StartsWith("[offset:"))
                {
                    lrc.Offset = SplitInfo(line);
                }
                else
                {
                    if (!string.IsNullOrEmpty(line) && line.StartsWith("["))
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            MatchCollection mc = regex.Matches(line);
                            if (mc.Count > 0)
                            {
                                double time = TimeSpan.Parse("00:" + mc[0].Groups[1].Value).TotalSeconds;
                                string word = mc[0].Groups[2].Value;
                                if (word.LastIndexOf(']') > 0)
                                    word = word.Substring(word.LastIndexOf(']')+1);
                                lrc.LrcWord.Add(time, word);
                                line = line.Substring(9);
                            }
                            else
                            {
                                break;
                            }
                        }


                    }
                }
            }
            return lrc;
        }

        /// <summary>
        /// 处理信息(私有方法)
        /// </summary>
        /// <param name="line"></param>
        /// <returns>返回基础信息</returns>
        static string SplitInfo(string line)
        {
            return line.Substring(line.IndexOf(":") + 1).TrimEnd(']');
        }
    }
}
