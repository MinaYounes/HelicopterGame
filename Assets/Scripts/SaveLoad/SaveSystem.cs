using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveSystem
{

    /* reused code from youtuber Brackley */

    // saves player information
    public static void SavePlayer()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        
        // put saved file at the following path with subfile playerinfo
        string path = Application.persistentDataPath + "/playerinfo";
        
        // stream used to write from file
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData();
        
        // inserts information into file
        formatter.Serialize(stream, data);
        stream.Close();
    }

    // loads player info if exists
    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/playerinfo";
        // if the file exists
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            // stream used to write from file
            FileStream stream = new FileStream(path, FileMode.Open);

            // binary to readable format
            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        // file does not exist at that path
        else
        {
            return null;
        }
    }
}
   
