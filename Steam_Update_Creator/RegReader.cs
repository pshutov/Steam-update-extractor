using System;
using Microsoft.Win32;

namespace Steam_Update_Creator {
    internal class RegReader {
        public static string ReadValue(string path, string name) {
            string result = string.Empty;
            try {
                using (var key = Registry.LocalMachine.OpenSubKey(path)) {
                    if (key != null) {
                        result = key.GetValue(name).ToString();
                    }
                }
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            return result;
        }
    }
}
