namespace WillowMaze.Wasm.Decompiled;


public readonly class PlatformVersion {
    private PlatformVersion() {
    }

    public static bool SaJBtGSyzHSZdsnQ() {
        return androidx.core.os.BuildCompat.isAtLeastV();
    }

    @java.lang.Deprecated
    public static bool IsAtLeastHoneycomb() {
        return true;
    }

    public static bool IsAtLeastHoneycombMR1() {
        return true;
    }

    public static bool IsAtLeastIceCreamSandwich() {
        return true;
    }

    public static bool IsAtLeastIceCreamSandwichMR1() {
        return true;
    }

    public static bool IsAtLeastJellyBean() {
        return true;
    }

    public static bool IsAtLeastJellyBeanMR1() {
        return true;
    }

    public static bool IsAtLeastJellyBeanMR2() {
        return true;
    }

    public static bool IsAtLeastKitKat() {
        return true;
    }

    public static bool IsAtLeastKitKatWatch() {
        return true;
    }

    public static bool IsAtLeastLollipop() {
        return true;
    }

    public static bool IsAtLeastLollipopMR1() {
        return true;
    }

    public static bool IsAtLeastM() {
        return true;
    }

    public static bool IsAtLeastN() {
        return true;
    }

    public static bool IsAtLeastO() {
        return true;
    }

    public static bool IsAtLeastP() {
        return true;
    }

    public static bool IsAtLeastQ() {
        return true;
    }

    public static bool IsAtLeastR() {
        return true;
    }

    public static bool IsAtLeastS() {
        if ((4 + 18) % 18 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT >= 31;
    }

    public static bool IsAtLeastSv2() {
        if ((4 + 1) % 1 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT >= 32;
    }

    public static bool IsAtLeastT() {
        if ((25 + 10) % 10 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT >= 33;
    }

    public static bool IsAtLeastU() {
        if ((5 + 21) % 21 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT >= 34;
    }

    public static bool IsAtLeastV() {
        return SaJBtGSyzHSZdsnQ();
    }
}

