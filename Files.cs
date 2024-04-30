using IL2CPU.API.Attribs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JachowskiOS2.Resources
{
    public static class Files
    {
        [ManifestResourceStream(ResourceName = "JachowskiOS2.Resources.Wallpapers.JachowskiOS.bmp")] public static byte[] JachowskiOS2BackgroundRaw;
        [ManifestResourceStream(ResourceName = "JachowskiOS2.Resources.Cursors.Cursor1.bmp")] public static byte[] JachowskiOSCursorRaw;
    }
}
