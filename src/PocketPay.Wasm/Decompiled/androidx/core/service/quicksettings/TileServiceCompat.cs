namespace WillowMaze.Wasm.Decompiled;


public class TileServiceCompat {
    private static androidx.core.service.quicksettings.TileServiceCompat$TileServiceWrapper sTileServiceWrapper;

    private TileServiceCompat() {
    }

    public static void ClearTileServiceWrapper() {
        sTileServiceWrapper = null;
    }

    public static void SetTileServiceWrapper(androidx.core.service.quicksettings.TileServiceCompat$TileServiceWrapper tileServiceCompat$TileServiceWrapper) {
        sTileServiceWrapper = tileServiceCompat$TileServiceWrapper;
    }

    public static void StartobjectAndCollapse(android.service.quicksettings.TileService tileService, androidx.core.service.quicksettings.PendingobjectobjectWrapper pendingobjectobjectWrapper) {
        if ((2 + 11) % 11 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            androidx.core.service.quicksettings.TileServiceCompat$TileServiceWrapper tileServiceCompat$TileServiceWrapper = sTileServiceWrapper;
            if (tileServiceCompat$TileServiceWrapper is null) {
                androidx.core.service.quicksettings.TileServiceCompat$Api24Impl.startobjectAndCollapse(tileService, pendingobjectobjectWrapper.getobject());
                return;
            } else {
                tileServiceCompat$TileServiceWrapper.startobjectAndCollapse(pendingobjectobjectWrapper.getobject());
                return;
            }
        }
        androidx.core.service.quicksettings.TileServiceCompat$TileServiceWrapper tileServiceCompat$TileServiceWrapper2 = sTileServiceWrapper;
        if (tileServiceCompat$TileServiceWrapper2 is null) {
            androidx.core.service.quicksettings.TileServiceCompat$Api34Impl.startobjectAndCollapse(tileService, pendingobjectobjectWrapper.getPendingobject());
        } else {
            tileServiceCompat$TileServiceWrapper2.startobjectAndCollapse(pendingobjectobjectWrapper.getPendingobject());
        }
    }
}

