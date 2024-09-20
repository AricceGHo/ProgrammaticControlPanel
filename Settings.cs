using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace ProgrammaticControlPanel
{
    public class Settings
    {
        [JsonIgnore]
        public JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
        {
            AllowTrailingCommas = true,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic,UnicodeRanges.All),
            WriteIndented = true
        };
        [JsonIgnore]
        public  CsvConfiguration csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
        {
            HasHeaderRecord = false,
            Comment = '#',
            AllowComments = true,
            Delimiter = ",",
            MissingFieldFound = null,
            BadDataFound = null,

        };
        [JsonIgnore]
        public static Settings instance;
        public string LastLessionsPath { get; set; }
        public Settings(string lastLessionsPath)
        {
            LastLessionsPath = lastLessionsPath;
        }
        public Settings() { instance = this; }

        public bool SaveSettings(string path) 
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                
                JsonSerializer.Serialize<Settings>(fs, this);
                return true;
                
            }
            return false;
        }
        
        public bool SaveSettings()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\settings.json";
            Debug.WriteLine("Путь сохранения: "+path);
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

                JsonSerializer.Serialize<Settings>(fs, this, jsonSerializerOptions);
                return true;

            }
            return false;
        }

        public bool TryLoadSettings(out Settings settings,string path="")
        {
            path = path == "" ? (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\settings.json") : path;
            Debug.WriteLine("TLS " + path);
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {

                    settings= JsonSerializer.Deserialize<Settings>(fs);
                    return true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
           "Файл настроек не найден, откройте или создайте его",
           "Ошибка",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information,
           MessageBoxDefaultButton.Button1);
                settings = this;
                return false;
                
                    
                    
                
            }

        }
        public bool SaveLessions(List<LessionData> lessionDatas, string path = "")
        {
            path = path == "" ? (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\lessions.json") : path;
            Debug.WriteLine("SL " + path);
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

                JsonSerializer.Serialize(fs, lessionDatas, jsonSerializerOptions);
                LastLessionsPath = path;
                return true;
            }
            return false;
        }
    }
}
