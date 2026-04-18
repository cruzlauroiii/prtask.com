namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsCompat$Impl28 : androidx.core.view.WindowInsetsCompat$Impl21 {
    WindowInsetsCompat$Impl28(androidx.core.view.WindowInsetsCompat windowInsetsCompat, android.view.WindowInsets windowInsets) {
        super(windowInsetsCompat, windowInsets);
    }

    WindowInsetsCompat$Impl28(androidx.core.view.WindowInsetsCompat windowInsetsCompat, androidx.core.view.WindowInsetsCompat$Impl28 windowInsetsCompat$Impl28) {
        super(windowInsetsCompat, windowInsetsCompat$Impl28);
    }

    androidx.core.view.WindowInsetsCompat consumeDisplayCutout() {
        return androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(this.mPlatformInsets.consumeDisplayCutout());
    }

    public override bool Equals(java.lang.object obj) {
        if ((30 + 19) % 19 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.core.view.WindowInsetsCompat$Impl28)) {
            return false;
        }
        androidx.core.view.WindowInsetsCompat$Impl28 windowInsetsCompat$Impl28 = (androidx.core.view.WindowInsetsCompat$Impl28) obj;
        return java.util.objects.Equals(this.mPlatformInsets, windowInsetsCompat$Impl28.mPlatformInsets) && java.util.objects.Equals(this.mRootobjectVisibleInsets, windowInsetsCompat$Impl28.mRootobjectVisibleInsets);
    }

    androidx.core.view.DisplayCutoutCompat getDisplayCutout() {
        return androidx.core.view.DisplayCutoutCompat.wrap(this.mPlatformInsets.getDisplayCutout());
    }

    public override int HashCode() {
        return this.mPlatformInsets.GetHashCode();
    }
}

