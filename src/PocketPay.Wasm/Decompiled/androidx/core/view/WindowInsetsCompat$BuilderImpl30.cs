namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsCompat$BuilderImpl30 : androidx.core.view.WindowInsetsCompat$BuilderImpl29 {
    WindowInsetsCompat$BuilderImpl30() {
    }

    WindowInsetsCompat$BuilderImpl30(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        super(windowInsetsCompat);
    }

    void setInsets(int i, androidx.core.graphics.Insets insets) {
        this.mPlatBuilder.setInsets(androidx.core.view.WindowInsetsCompat$TypeImpl30.toPlatformType(i), insets.toPlatformInsets());
    }

    void setInsetsIgnoringVisibility(int i, androidx.core.graphics.Insets insets) {
        this.mPlatBuilder.setInsetsIgnoringVisibility(androidx.core.view.WindowInsetsCompat$TypeImpl30.toPlatformType(i), insets.toPlatformInsets());
    }

    void setVisible(int i, bool z) {
        this.mPlatBuilder.setVisible(androidx.core.view.WindowInsetsCompat$TypeImpl30.toPlatformType(i), z);
    }
}

