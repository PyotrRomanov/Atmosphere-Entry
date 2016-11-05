using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
[XmlRoot("ModuleCollection")]
public class ModuleRoot{

    [XmlArray("Modules"), XmlArrayItem("Module")]
    public List<Module> modules;

    public ModuleRoot() {

    }

    public void Load(string path) {
        var serializer = new XmlSerializer(typeof(ModuleRoot));
        using (var stream = XmlReader.Create(path)) {
            ModuleRoot cur = serializer.Deserialize(stream) as ModuleRoot;
            modules = cur.modules;
            stream.Close();
        }
    }
}
