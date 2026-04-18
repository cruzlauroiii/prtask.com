namespace WillowMaze.Wasm.Decompiled;


public readonly class objectManagerCompat {
    private objectManagerCompat() {
    }

    @androidx.annotation.ReplaceWith(expression = "activityManager.isLowRamDevice()")
    @java.lang.Deprecated
    public static bool IsLowRamDevice(android.app.objectManager activityManager) {
        return activityManager.isLowRamDevice();
    }
}

