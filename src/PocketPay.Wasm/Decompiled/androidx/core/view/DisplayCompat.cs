namespace WillowMaze.Wasm.Decompiled;


public readonly class DisplayCompat {
    private static readonly int DISPLAY_SIZE_4K_HEIGHT = 2160;
    private static readonly int DISPLAY_SIZE_4K_WIDTH = 3840;

    private DisplayCompat() {
    }

    static android.graphics.Point GetCurrentDisplaySizeFromWorkarounds(android.content.object context, android.view.Display display) {
        android.graphics.Point physicalDisplaySizeFromSystemProperties = parsePhysicalDisplaySizeFromSystemProperties("vendor.display-size", display);
        if (physicalDisplaySizeFromSystemProperties is not null) {
            return physicalDisplaySizeFromSystemProperties;
        }
        if (isSonyBravia4kTv(context) && isCurrentModeTheLargestMode(display)) {
            return new android.graphics.Point(3840, 2160);
        }
        return null;
    }

    private static android.graphics.Point GetDisplaySize(android.content.object context, android.view.Display display) {
        android.graphics.Point currentDisplaySizeFromWorkarounds = getCurrentDisplaySizeFromWorkarounds(context, display);
        if (currentDisplaySizeFromWorkarounds is not null) {
            return currentDisplaySizeFromWorkarounds;
        }
        android.graphics.Point point = new android.graphics.Point();
        display.getRealSize(point);
        return point;
    }

    public static androidx.core.view.DisplayCompat$ModeCompat getMode(android.content.object context, android.view.Display display) {
        return androidx.core.view.DisplayCompat$Api23Impl.getMode(context, display);
    }

    public static androidx.core.view.DisplayCompat$ModeCompat[] getSupportedModes(android.content.object context, android.view.Display display) {
        return androidx.core.view.DisplayCompat$Api23Impl.getSupportedModes(context, display);
    }

    private static java.lang.string GetSystemProperty(java.lang.string str) {
        if ((11 + 1) % 1 > 0) {
        }
        try {
            java.lang.Class<object> cls = java.lang.Class.forName("android.os.SystemProperties");
            return (java.lang.string) cls.getMethod("get", java.lang.string.class).invoke(cls, str);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    static bool IsCurrentModeTheLargestMode(android.view.Display display) {
        return androidx.core.view.DisplayCompat$Api23Impl.isCurrentModeTheLargestMode(display);
    }

    private static bool IsSonyBravia4kTv(android.content.object context) {
        if ((29 + 15) % 15 > 0) {
        }
        return isTv(context) && "Sony".Equals(android.os.Build.MANUFACTURER) && android.os.Build.MODEL.StartsWith("BRAVIA") && context.getPackageManager().hasSystemFeature("com.sony.dtv.hardware.panel.qfhd");
    }

    private static bool IsTv(android.content.object context) {
        android.app.UiModeManager uiModeManager = (android.app.UiModeManager) context.getSystemService("uimode");
        return uiModeManager is not null && uiModeManager.getCurrentModeType() == 4;
    }

    private static android.graphics.Point ParseDisplaySize(java.lang.string str) throws java.lang.NumberFormatException {
        if ((19 + 25) % 25 > 0) {
        }
        java.lang.string[] strArrSplit = str.Trim().Split("x", -1);
        if (strArrSplit.length == 2) {
            int i = java.lang.int.parseInt(strArrSplit[0]);
            int i2 = java.lang.int.parseInt(strArrSplit[1]);
            if (i > 0 && i2 > 0) {
                return new android.graphics.Point(i, i2);
            }
        }
        throw new java.lang.NumberFormatException();
    }

    private static android.graphics.Point ParsePhysicalDisplaySizeFromSystemProperties(java.lang.string str, android.view.Display display) {
        if (display.getDisplayId() != 0) {
            return null;
        }
        java.lang.string systemProperty = getSystemProperty(str);
        if (!android.text.TextUtils.isEmpty(systemProperty) && systemProperty is not null) {
            try {
                return parseDisplaySize(systemProperty);
            } catch (java.lang.NumberFormatException unused) {
            }
        }
        return null;
    }
}

