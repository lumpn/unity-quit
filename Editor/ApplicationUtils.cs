using UnityEditor;

public static class ApplicationUtils
{
    public static void Quit()
    {
        EditorApplication.isPlaying = false;
    }
}
