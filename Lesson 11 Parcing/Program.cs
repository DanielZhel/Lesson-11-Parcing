using Lesson_11_Parcing;
using System;
using System.Text.Json;
using System.Xml.Serialization;

//List<Members> members = new List<Members>();


//List<string> powerOfSupaMan = new List<string> { "few", "wfewef" };
//List<string> powerOfIronMan = new List<string> { "1power", " 2power" };


//Members supaMan = new Members("dsvs", 3, "fedff", powerOfSupaMan);
//Members ironMan = new Members("dol", 342, "HU", powerOfIronMan);
//members.Add(supaMan);
//members.Add(ironMan);

//Squad Super = new Squad("Super hero squad", "Metro City", 2016, "Super tower", true, members);


//using (FileStream fs = new FileStream("squad.json", FileMode.OpenOrCreate))
//{
//    JsonSerializer.Serialize(fs, Super);

//}
Squad forXML;

string file = "squad1.json";

if (File.Exists(file) == true)
{
    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
    {
        Squad? squad = await JsonSerializer.DeserializeAsync<Squad>(fs);
        forXML = squad;
        
    }
}
else
    throw new Exception("File does not exist");


XmlSerializer Serializer = new XmlSerializer(typeof(Squad));

using (FileStream fs1 = new FileStream("squadXML.xml", FileMode.OpenOrCreate))
{
    Serializer.Serialize(fs1, forXML);

    Console.WriteLine("Object has been serialized");
}
