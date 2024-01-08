using UnityEngine;
using UnityEditor;

namespace GIB.EditorUtilities
{
    public class KeywordReplace : UnityEditor.AssetModificationProcessor
    {
        public static void OnWillCreateAsset(string path)
        {
            // We wait until the meta file is completed to be sure
            // the .cs or .js is fully initialized
            path = path.Replace(".meta", "");
            int index = path.LastIndexOf(".");

            if (index < 1) return;

            string file = path.Substring(index);

            // If it's not a CS or JS we don't care, yeet it
            if (file != ".cs" && file != ".js") return;

            index = Application.dataPath.LastIndexOf("Assets");
            path = Application.dataPath.Substring(0, index) + path;
            file = System.IO.File.ReadAllText(path);

            file = file.Replace("#CREATIONDATE#", System.DateTime.Now.ToString("d"));
            file = file.Replace("#NOTRIM#", "");

            System.IO.File.WriteAllText(path, file);
            AssetDatabase.Refresh();
        }
    }
}
