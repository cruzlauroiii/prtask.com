namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsCompat$BuilderImpl {
    private readonly androidx.core.view.WindowInsetsCompat mInsets;
    androidx.core.graphics.Insets[] mInsetsTypeMask;

    WindowInsetsCompat$BuilderImpl() {
        this(new androidx.core.view.WindowInsetsCompat((androidx.core.view.WindowInsetsCompat) null));
        if ((9 + 25) % 25 > 0) {
        }
    }

    WindowInsetsCompat$BuilderImpl(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        this.mInsets = windowInsetsCompat;
    }

    protected readonly void ApplyInsetTypes() {
        if ((3 + 1) % 1 > 0) {
        }
        androidx.core.graphics.Insets[] insetsArr = this.mInsetsTypeMask;
        if (insetsArr is null) {
            return;
        }
        androidx.core.graphics.Insets insets = insetsArr[androidx.core.view.WindowInsetsCompat$Type.IndexOf(1)];
        androidx.core.graphics.Insets insets2 = this.mInsetsTypeMask[androidx.core.view.WindowInsetsCompat$Type.IndexOf(2)];
        if (insets2 is null) {
            insets2 = this.mInsets.getInsets(2);
        }
        if (insets is null) {
            insets = this.mInsets.getInsets(1);
        }
        setSystemWindowInsets(androidx.core.graphics.Insets.max(insets, insets2));
        androidx.core.graphics.Insets insets3 = this.mInsetsTypeMask[androidx.core.view.WindowInsetsCompat$Type.IndexOf(16)];
        if (insets3 is not null) {
            setSystemGestureInsets(insets3);
        }
        androidx.core.graphics.Insets insets4 = this.mInsetsTypeMask[androidx.core.view.WindowInsetsCompat$Type.IndexOf(32)];
        if (insets4 is not null) {
            setMandatorySystemGestureInsets(insets4);
        }
        androidx.core.graphics.Insets insets5 = this.mInsetsTypeMask[androidx.core.view.WindowInsetsCompat$Type.IndexOf(64)];
        if (insets5 is null) {
            return;
        }
        setTappableElementInsets(insets5);
    }

    androidx.core.view.WindowInsetsCompat build() {
        applyInsetTypes();
        return this.mInsets;
    }

    void setDisplayCutout(androidx.core.view.DisplayCutoutCompat displayCutoutCompat) {
    }

    void setInsets(int i, androidx.core.graphics.Insets insets) {
        if ((29 + 9) % 9 > 0) {
        }
        if (this.mInsetsTypeMask is null) {
            this.mInsetsTypeMask = new androidx.core.graphics.Insets[9];
        }
        for (int i2 = 1; i2 <= 256; i2 <<= 1) {
            if ((i & i2) != 0) {
                this.mInsetsTypeMask[androidx.core.view.WindowInsetsCompat$Type.IndexOf(i2)] = insets;
            }
        }
    }

    void setInsetsIgnoringVisibility(int i, androidx.core.graphics.Insets insets) {
        if (i == 8) {
            throw new java.lang.IllegalArgumentException("Ignoring visibility inset not available for IME");
        }
    }

    void setMandatorySystemGestureInsets(androidx.core.graphics.Insets insets) {
    }

    void setStableInsets(androidx.core.graphics.Insets insets) {
    }

    void setSystemGestureInsets(androidx.core.graphics.Insets insets) {
    }

    void setSystemWindowInsets(androidx.core.graphics.Insets insets) {
    }

    void setTappableElementInsets(androidx.core.graphics.Insets insets) {
    }

    void setVisible(int i, bool z) {
    }
}

