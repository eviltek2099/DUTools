using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DUTools
{
  class screen
  {
    public screen()
      {

      }

    public void setRawHTML() {

    }
  }
    static class Helpers
    {
        public static string SerializeObject<T>(T toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }
    }
  class LuaError {
    public string signature { get; set; }
    public int? line { get; set; }
    public string error { get; set; }
    public string key { get; set; }
    public int slotKey { get; set; }
  }
  internal class ModelJson
    {
        public Dictionary<int, Modelslots> slots { get; set; }
        public List<Modelhandlers> handlers { get; set; }
        public List<string> methods { get; set; }
        public List<string> events { get; set; }
    }
    class Modelslots
    {
        public string name { get; set; }
        public Modeltype type { get; set; }
    }
    class Modeltype
    {
        public List<string> events { get; set; }
        public List<string> methods { get; set; }
    }
    class Modelhandlers
    {
        public string code { get; set; }
        public Modelfilter filter { get; set; }
        public string key { get; set; }
    }
    class Modelfilter
    {
        public List<Modelargs> args { get; set; }
        public string signature { get; set; }
        public int slotKey { get; set; }
    }
    class Modelargs
    {
        public string variable { get; set; }
    }
    class Modelmethods
    {

    }
    class Modelevents
    {

    }

}
