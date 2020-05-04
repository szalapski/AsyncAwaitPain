using System.IO;

namespace BigBallOfMud.Lib
{
    /// <summary>
    /// 
    /// </summary>
    public class VersionProvider : IVersionProvider
    {
        public string GetVersion()
        {
            return File.ReadAllText("version.txt");
        }
    }
}