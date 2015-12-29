using System;

namespace Steam_Update_Creator {
    internal static class Tools {
        public static DateTime UnixTimeStampToDateTime(long unixTimeStamp) {
            var dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static string SizeViewOptimize(string sizeInB) {
            string result;
            long sizeInKB = long.Parse(sizeInB) >> 10;
            if (sizeInKB > 0) {
                sizeInB = (long.Parse(sizeInB)%1024).ToString();
                var sizeInMB = sizeInKB >> 10;
                if (sizeInMB > 0) {
                    sizeInKB %= 1024;
                    var sizeInGb = sizeInMB >> 10;
                    if (sizeInGb > 0) {
                        sizeInMB %= 1024;
                        result = string.Format("{0} GB  {1} MB", sizeInGb, sizeInMB);
                    } else {
                        result = string.Format("{0} MB  {1} KB", sizeInMB, sizeInKB);
                    }
                } else {
                    result = string.Format("{0} KB  {1} B", sizeInKB, sizeInB);
                }
            } else {
                result = string.Format("{0} B", sizeInB);
            }
            return result;
        }
    }
}
