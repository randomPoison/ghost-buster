#if ENABLE_VSTU
using SyntaxTree.VisualStudio.Unity.Bridge;
using System.Linq;
using System.Xml.Linq;
using UnityEditor;

[InitializeOnLoad]
public class GhostBuster
{
    static GhostBuster()
    {
        ProjectFilesGenerator.ProjectFileGeneration += (string name, string content) =>
        {
            var document = XDocument.Parse(content);
            var rootNamespace = document.Root.Name.Namespace;

            document
                .Descendants(rootNamespace + "Reference")
                .Where(element =>
                {
                    var include = element.Attribute("Include").Value;
                    return include == "Boo.Lang" || include == "UnityScript" || include == "UnityScript.Lang";
                })
                .Remove();

            return document.ToString();
        };
    }
}
#endif
