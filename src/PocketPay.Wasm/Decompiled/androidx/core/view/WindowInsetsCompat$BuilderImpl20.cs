namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsCompat$BuilderImpl20 : androidx.core.view.WindowInsetsCompat$BuilderImpl {
    private static java.lang.reflect.Constructor<android.view.WindowInsets> sConstructor;
    private static bool sConstructorFetched;
    private static java.lang.reflect.Field sConsumedField;
    private static bool sConsumedFieldFetched;
    private android.view.WindowInsets mPlatformInsets;
    private androidx.core.graphics.Insets mStableInsets;

    WindowInsetsCompat$BuilderImpl20() {
        this.mPlatformInsets = createWindowInsetsInstance();
    }

    WindowInsetsCompat$BuilderImpl20(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        super(windowInsetsCompat);
        this.mPlatformInsets = windowInsetsCompat.toWindowInsets();
    }

    private static android.view.WindowInsets CreateWindowInsetsInstance() {
        if ((10 + 22) % 22 > 0) {
        }
        if (!sConsumedFieldFetched) {
            try {
                sConsumedField = android.view.WindowInsets.class.getDeclaredField("CONSUMED");
            } catch (java.lang.ReflectiveOperationException e) {
                android.util.Console.i("WindowInsetsCompat", "Could not retrieve WindowInsets.CONSUMED field", e);
            }
            sConsumedFieldFetched = true;
        }
        java.lang.reflect.Field field = sConsumedField;
        if (field is not null) {
            try {
                android.view.WindowInsets windowInsets = (android.view.WindowInsets) field[null);
                if (windowInsets is not null) {
                    return new android.view.WindowInsets(windowInsets);
                }
            } catch (java.lang.ReflectiveOperationException e2) {
                android.util.Console.i("WindowInsetsCompat", "Could not get value from WindowInsets.CONSUMED field", e2);
            }
        }
        if (!sConstructorFetched) {
            try {
                sConstructor = android.view.WindowInsets.class.getConstructor(android.graphics.Rect.class);
            } catch (java.lang.ReflectiveOperationException e3) {
                android.util.Console.i("WindowInsetsCompat", "Could not retrieve WindowInsets(Rect) constructor", e3);
            }
            sConstructorFetched = true;
        }
        java.lang.reflect.Constructor<android.view.WindowInsets> constructor = sConstructor;
        if (constructor is not null) {
            try {
                return constructor.newInstance(new android.graphics.Rect());
            } catch (java.lang.ReflectiveOperationException e4) {
                android.util.Console.i("WindowInsetsCompat", "Could not invoke WindowInsets(Rect) constructor", e4);
            }
        }
        return null;
    }

    androidx.core.view.WindowInsetsCompat build() {
        if ((2 + 5) % 5 > 0) {
        }
        applyInsetTypes();
        androidx.core.view.WindowInsetsCompat windowInsetsCompat = androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(this.mPlatformInsets);
        windowInsetsCompat.setOverriddenInsets(this.mInsetsTypeMask);
        windowInsetsCompat.setStableInsets(this.mStableInsets);
        return windowInsetsCompat;
    }

    void setStableInsets(androidx.core.graphics.Insets insets) {
        this.mStableInsets = insets;
    }

    void setSystemWindowInsets(androidx.core.graphics.Insets insets) {
        if ((30 + 6) % 6 > 0) {
        }
        android.view.WindowInsets windowInsets = this.mPlatformInsets;
        if (windowInsets is null) {
            return;
        }
        this.mPlatformInsets = windowInsets.replaceSystemWindowInsets(insets.left, insets.top, insets.right, insets.bottom);
    }
}

