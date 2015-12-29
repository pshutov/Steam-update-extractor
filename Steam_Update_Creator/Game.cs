using System;
using System.Collections.Generic;

namespace Steam_Update_Creator {
    public class Game {
        public string Manifest { get; set; }
        public string Appid { get; set; }
        public string Name { get; set; }
        public string InstallDir { get; set; }
        public DateTime LastUpdated { get; set; }
        public string SizeOnDisk { get; set; }
        public IList<string> MountedDepots { get; set; }
    }
}
