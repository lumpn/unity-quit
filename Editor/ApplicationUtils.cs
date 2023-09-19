using UnityEditor;

namespace Lumpn.Quitting
{
    public static class ApplicationUtils
    {
        public static void Quit()
        {
            EditorApplication.isPlaying = false;
        }
    }
}
