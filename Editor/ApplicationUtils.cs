//----------------------------------------
// MIT License
// Copyright(c) 2023 Jonas Boetel
//----------------------------------------
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
