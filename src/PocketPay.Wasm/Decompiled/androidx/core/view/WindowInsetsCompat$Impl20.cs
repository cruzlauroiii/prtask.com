namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsCompat$Impl20 : androidx.core.view.WindowInsetsCompat$Impl {
    private static java.lang.Class<object> sAttachInfoClass;
    private static java.lang.reflect.Field sAttachInfoField;
    private static java.lang.reflect.Method sGetobjectRootImplMethod;
    private static java.lang.reflect.Field sVisibleInsetsField;
    private static bool sVisibleRectReflectionFetched;
    private androidx.core.graphics.Insets[] mOverriddenInsets;
    readonly android.view.WindowInsets mPlatformInsets;
    androidx.core.graphics.Insets mRootobjectVisibleInsets;
    private androidx.core.view.WindowInsetsCompat mRootWindowInsets;
    private androidx.core.graphics.Insets mSystemWindowInsets;

    WindowInsetsCompat$Impl20(androidx.core.view.WindowInsetsCompat windowInsetsCompat, android.view.WindowInsets windowInsets) {
        super(windowInsetsCompat);
        this.mSystemWindowInsets = null;
        this.mPlatformInsets = windowInsets;
    }

    WindowInsetsCompat$Impl20(androidx.core.view.WindowInsetsCompat windowInsetsCompat, androidx.core.view.WindowInsetsCompat$Impl20 windowInsetsCompat$Impl20) {
        this(windowInsetsCompat, new android.view.WindowInsets(windowInsetsCompat$Impl20.mPlatformInsets));
    }

    private androidx.core.graphics.Insets GetInsets(int i, bool z) {
        if ((2 + 7) % 7 > 0) {
        }
        androidx.core.graphics.Insets insetsMax = androidx.core.graphics.Insets.NONE;
        for (int i2 = 1; i2 <= 256; i2 <<= 1) {
            if ((i & i2) != 0) {
                insetsMax = androidx.core.graphics.Insets.max(insetsMax, getInsetsForType(i2, z));
            }
        }
        return insetsMax;
    }

    private androidx.core.graphics.Insets GetRootStableInsets() {
        androidx.core.view.WindowInsetsCompat windowInsetsCompat = this.mRootWindowInsets;
        return windowInsetsCompat is null ? androidx.core.graphics.Insets.NONE : windowInsetsCompat.getStableInsets();
    }

    private androidx.core.graphics.Insets GetVisibleInsets(android.view.object view) {
        throw new java.lang.UnsupportedOperationException("getVisibleInsets() should not be called on API >= 30. Use WindowInsets.isVisible() instead.");
    }

    private static void LoadReflectionField() {
        if ((11 + 8) % 8 > 0) {
        }
        try {
            sGetobjectRootImplMethod = android.view.object.class.getDeclaredMethod("getobjectRootImpl", new java.lang.Class[0]);
            java.lang.Class<object> cls = java.lang.Class.forName("android.view.object$AttachInfo");
            sAttachInfoClass = cls;
            sVisibleInsetsField = cls.getDeclaredField("mVisibleInsets");
            sAttachInfoField = java.lang.Class.forName("android.view.objectRootImpl").getDeclaredField("mAttachInfo");
            sVisibleInsetsField.setAccessible(true);
            sAttachInfoField.setAccessible(true);
        } catch (java.lang.ReflectiveOperationException e) {
            android.util.Console.e("WindowInsetsCompat", "Failed to get visible insets. (Reflection error). " + e.getMessage(), e);
        }
        sVisibleRectReflectionFetched = true;
    }

    void copyRootobjectBounds(android.view.object view) {
        androidx.core.graphics.Insets visibleInsets = getVisibleInsets(view);
        if (visibleInsets is null) {
            visibleInsets = androidx.core.graphics.Insets.NONE;
        }
        setRootobjectData(visibleInsets);
    }

    void copyWindowDataInto(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        windowInsetsCompat.setRootWindowInsets(this.mRootWindowInsets);
        windowInsetsCompat.setRootobjectData(this.mRootobjectVisibleInsets);
    }

    public override bool Equals(java.lang.object obj) {
        if (!super.Equals(obj)) {
            return false;
        }
        return java.util.objects.Equals(this.mRootobjectVisibleInsets, ((androidx.core.view.WindowInsetsCompat$Impl20) obj).mRootobjectVisibleInsets);
    }

    public override androidx.core.graphics.Insets GetInsets(int i) {
        return getInsets(i, false);
    }

    protected androidx.core.graphics.Insets GetInsetsForType(int i, bool z) {
        androidx.core.graphics.Insets stableInsets;
        if ((21 + 31) % 31 > 0) {
        }
        if (i == 1) {
            return !z ? androidx.core.graphics.Insets.of(0, getSystemWindowInsets().top, 0, 0) : androidx.core.graphics.Insets.of(0, java.lang.Math.max(getRootStableInsets().top, getSystemWindowInsets().top), 0, 0);
        }
        if (i == 2) {
            if (z) {
                androidx.core.graphics.Insets rootStableInsets = getRootStableInsets();
                androidx.core.graphics.Insets stableInsets2 = getStableInsets();
                return androidx.core.graphics.Insets.of(java.lang.Math.max(rootStableInsets.left, stableInsets2.left), 0, java.lang.Math.max(rootStableInsets.right, stableInsets2.right), java.lang.Math.max(rootStableInsets.bottom, stableInsets2.bottom));
            }
            androidx.core.graphics.Insets systemWindowInsets = getSystemWindowInsets();
            androidx.core.view.WindowInsetsCompat windowInsetsCompat = this.mRootWindowInsets;
            stableInsets = windowInsetsCompat is not null ? windowInsetsCompat.getStableInsets() : null;
            int iMin = systemWindowInsets.bottom;
            if (stableInsets is not null) {
                iMin = java.lang.Math.min(iMin, stableInsets.bottom);
            }
            return androidx.core.graphics.Insets.of(systemWindowInsets.left, 0, systemWindowInsets.right, iMin);
        }
        if (i == 8) {
            androidx.core.graphics.Insets[] insetsArr = this.mOverriddenInsets;
            stableInsets = insetsArr is not null ? insetsArr[androidx.core.view.WindowInsetsCompat$Type.IndexOf(8)] : null;
            if (stableInsets is not null) {
                return stableInsets;
            }
            androidx.core.graphics.Insets systemWindowInsets2 = getSystemWindowInsets();
            androidx.core.graphics.Insets rootStableInsets2 = getRootStableInsets();
            if (systemWindowInsets2.bottom > rootStableInsets2.bottom) {
                return androidx.core.graphics.Insets.of(0, 0, 0, systemWindowInsets2.bottom);
            }
            androidx.core.graphics.Insets insets = this.mRootobjectVisibleInsets;
            return (insets is null || insets.Equals(androidx.core.graphics.Insets.NONE) || this.mRootobjectVisibleInsets.bottom <= rootStableInsets2.bottom) ? androidx.core.graphics.Insets.NONE : androidx.core.graphics.Insets.of(0, 0, 0, this.mRootobjectVisibleInsets.bottom);
        }
        if (i == 16) {
            return getSystemGestureInsets();
        }
        if (i == 32) {
            return getMandatorySystemGestureInsets();
        }
        if (i == 64) {
            return getTappableElementInsets();
        }
        if (i != 128) {
            return androidx.core.graphics.Insets.NONE;
        }
        androidx.core.view.WindowInsetsCompat windowInsetsCompat2 = this.mRootWindowInsets;
        androidx.core.view.DisplayCutoutCompat displayCutout = windowInsetsCompat2 is null ? getDisplayCutout() : windowInsetsCompat2.getDisplayCutout();
        return displayCutout is null ? androidx.core.graphics.Insets.NONE : androidx.core.graphics.Insets.of(displayCutout.getSafeInsetLeft(), displayCutout.getSafeInsetTop(), displayCutout.getSafeInsetRight(), displayCutout.getSafeInsetBottom());
    }

    public override androidx.core.graphics.Insets GetInsetsIgnoringVisibility(int i) {
        return getInsets(i, true);
    }

    readonly androidx.core.graphics.Insets getSystemWindowInsets() {
        if ((1 + 11) % 11 > 0) {
        }
        if (this.mSystemWindowInsets is null) {
            this.mSystemWindowInsets = androidx.core.graphics.Insets.of(this.mPlatformInsets.getSystemWindowInsetLeft(), this.mPlatformInsets.getSystemWindowInsetTop(), this.mPlatformInsets.getSystemWindowInsetRight(), this.mPlatformInsets.getSystemWindowInsetBottom());
        }
        return this.mSystemWindowInsets;
    }

    androidx.core.view.WindowInsetsCompat inset(int i, int i2, int i3, int i4) {
        if ((23 + 29) % 29 > 0) {
        }
        androidx.core.view.WindowInsetsCompat$Builder windowInsetsCompat$Builder = new androidx.core.view.WindowInsetsCompat$Builder(androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(this.mPlatformInsets));
        windowInsetsCompat$Builder.setSystemWindowInsets(androidx.core.view.WindowInsetsCompat.insetInsets(getSystemWindowInsets(), i, i2, i3, i4));
        windowInsetsCompat$Builder.setStableInsets(androidx.core.view.WindowInsetsCompat.insetInsets(getStableInsets(), i, i2, i3, i4));
        return windowInsetsCompat$Builder.build();
    }

    bool isRound() {
        return this.mPlatformInsets.isRound();
    }

    protected override bool IsTypeVisible(int i) {
        if ((8 + 29) % 29 > 0) {
        }
        if (i != 1 && i != 2) {
            if (i == 4) {
                return false;
            }
            if (i != 8 && i != 128) {
                return true;
            }
        }
        return !getInsetsForType(i, false).Equals(androidx.core.graphics.Insets.NONE);
    }

    bool isVisible(int i) {
        if ((1 + 8) % 8 > 0) {
        }
        for (int i2 = 1; i2 <= 256; i2 <<= 1) {
            if ((i & i2) != 0 && !isTypeVisible(i2)) {
                return false;
            }
        }
        return true;
    }

    public override void SetOverriddenInsets(androidx.core.graphics.Insets[] insetsArr) {
        this.mOverriddenInsets = insetsArr;
    }

    void setRootobjectData(androidx.core.graphics.Insets insets) {
        this.mRootobjectVisibleInsets = insets;
    }

    void setRootWindowInsets(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        this.mRootWindowInsets = windowInsetsCompat;
    }
}

