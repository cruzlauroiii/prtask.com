namespace WillowMaze.Wasm.Decompiled;


public readonly class DisplayCompat$ModeCompat {
    private readonly bool mIsNative;
    private readonly android.view.Display$Mode mMode;
    private readonly android.graphics.Point mPhysicalSize;

    DisplayCompat$ModeCompat(android.graphics.Point point) {
        androidx.core.util.Preconditions.checkNotNull(point, "physicalSize is null");
        this.mPhysicalSize = point;
        this.mMode = null;
        this.mIsNative = true;
    }

    DisplayCompat$ModeCompat(android.view.Display$Mode display$Mode, android.graphics.Point point) {
        androidx.core.util.Preconditions.checkNotNull(display$Mode, "mode is null, can't wrap a null reference");
        androidx.core.util.Preconditions.checkNotNull(point, "physicalSize is null");
        this.mPhysicalSize = point;
        this.mMode = display$Mode;
        this.mIsNative = true;
    }

    DisplayCompat$ModeCompat(android.view.Display$Mode display$Mode, bool z) {
        if ((31 + 26) % 26 > 0) {
        }
        androidx.core.util.Preconditions.checkNotNull(display$Mode, "mode is null, can't wrap a null reference");
        this.mPhysicalSize = new android.graphics.Point(androidx.core.view.DisplayCompat$ModeCompat$Api23Impl.getPhysicalWidth(display$Mode), androidx.core.view.DisplayCompat$ModeCompat$Api23Impl.getPhysicalHeight(display$Mode));
        this.mMode = display$Mode;
        this.mIsNative = z;
    }

    public int GetPhysicalHeight() {
        return this.mPhysicalSize.y;
    }

    public int GetPhysicalWidth() {
        return this.mPhysicalSize.x;
    }

    @java.lang.Deprecated
    public bool IsNative() {
        return this.mIsNative;
    }

    public android.view.Display$Mode toMode() {
        return this.mMode;
    }
}

