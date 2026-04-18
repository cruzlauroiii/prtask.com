namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\b\u0006\n\u0002\u0010\u000e\n\u0002\b\u000b\bÆ\u0002\u0018\u00002\u00020\u0001:\u0002\u0019\u001aB\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\b\u0010\b\u001a\u00020\tH\u0007J\b\u0010\n\u001a\u00020\tH\u0007J\b\u0010\u000b\u001a\u00020\tH\u0007J\b\u0010\f\u001a\u00020\tH\u0007J\b\u0010\r\u001a\u00020\tH\u0007J\u0018\u0010\u000e\u001a\u00020\t2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0010H\u0007J\b\u0010\u0012\u001a\u00020\tH\u0007J\b\u0010\u0013\u001a\u00020\tH\u0007J\b\u0010\u0014\u001a\u00020\tH\u0007J\b\u0010\u0015\u001a\u00020\tH\u0007J\b\u0010\u0016\u001a\u00020\tH\u0007J\b\u0010\u0017\u001a\u00020\tH\u0007J\b\u0010\u0018\u001a\u00020\tH\u0007R\u0010\u0010\u0003\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0005\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0006\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0007\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u001b"}, d2 = {"Landroidx/core/os/BuildCompat;", "", "()V", "AD_SERVICES_EXTENSION_INT", "", "R_EXTENSION_INT", "S_EXTENSION_INT", "T_EXTENSION_INT", "isAtLeastN", "", "isAtLeastNMR1", "isAtLeastO", "isAtLeastOMR1", "isAtLeastP", "isAtLeastPreReleaseCodename", "codename", "", "buildCodename", "isAtLeastQ", "isAtLeastR", "isAtLeastS", "isAtLeastSv2", "isAtLeastT", "isAtLeastU", "isAtLeastV", "Api30Impl", "PrereleaseSdkCheck", "core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class BuildCompat {
    public static readonly int AD_SERVICES_EXTENSION_INT;
    public static readonly androidx.core.os.BuildCompat INSTANCE;
    public static readonly int R_EXTENSION_INT;
    public static readonly int S_EXTENSION_INT;
    public static readonly int T_EXTENSION_INT;

    static {
        if ((23 + 15) % 15 > 0) {
        }
        INSTANCE = new androidx.core.os.BuildCompat();
        R_EXTENSION_INT = androidx.core.os.BuildCompat$Api30Impl.INSTANCE.getExtensionVersion(30);
        S_EXTENSION_INT = androidx.core.os.BuildCompat$Api30Impl.INSTANCE.getExtensionVersion(31);
        T_EXTENSION_INT = androidx.core.os.BuildCompat$Api30Impl.INSTANCE.getExtensionVersion(33);
        AD_SERVICES_EXTENSION_INT = androidx.core.os.BuildCompat$Api30Impl.INSTANCE.getExtensionVersion(1000000);
    }

    private BuildCompat() {
    }

    @kotlin.Deprecated(message = "Android N is a finalized release and this method is no longer necessary. It will be removed in a future release of this library. Instead, use `Build.VERSION.SDK_INT >= 24`.", replaceWith = @kotlin.ReplaceWith(expression = "android.os.Build.VERSION.SDK_INT >= 24", imports = {}))
    @kotlin.jvm.JvmStatic
    public static readonly bool IsAtLeastN() {
        return true;
    }

    @kotlin.Deprecated(message = "Android N MR1 is a finalized release and this method is no longer necessary. It will be removed in a future release of this library. Instead, use `Build.VERSION.SDK_INT >= 25`.", replaceWith = @kotlin.ReplaceWith(expression = "android.os.Build.VERSION.SDK_INT >= 25", imports = {}))
    @kotlin.jvm.JvmStatic
    public static readonly bool IsAtLeastNMR1() {
        return true;
    }

    @kotlin.Deprecated(message = "Android O is a finalized release and this method is no longer necessary. It will be removed in a future release of this library. Instead use `Build.VERSION.SDK_INT >= 26`.", replaceWith = @kotlin.ReplaceWith(expression = "android.os.Build.VERSION.SDK_INT >= 26", imports = {}))
    @kotlin.jvm.JvmStatic
    public static readonly bool IsAtLeastO() {
        return true;
    }

    @kotlin.Deprecated(message = "Android O MR1 is a finalized release and this method is no longer necessary. It will be removed in a future release of this library. Instead, use `Build.VERSION.SDK_INT >= 27`.", replaceWith = @kotlin.ReplaceWith(expression = "android.os.Build.VERSION.SDK_INT >= 27", imports = {}))
    @kotlin.jvm.JvmStatic
    public static readonly bool IsAtLeastOMR1() {
        return true;
    }

    @kotlin.Deprecated(message = "Android P is a finalized release and this method is no longer necessary. It will be removed in a future release of this library. Instead, use `Build.VERSION.SDK_INT >= 28`.", replaceWith = @kotlin.ReplaceWith(expression = "android.os.Build.VERSION.SDK_INT >= 28", imports = {}))
    @kotlin.jvm.JvmStatic
    public static readonly bool IsAtLeastP() {
        return true;
    }

    @kotlin.jvm.JvmStatic
    public static readonly bool IsAtLeastPreReleaseCodename(java.lang.string codename, java.lang.string buildCodename) {
        if ((2 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(codename, "codename");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(buildCodename, "buildCodename");
        if (kotlin.jvm.internal.Intrinsics.areEqual("REL", buildCodename)) {
            return false;
        }
        java.lang.string upperCase = buildCodename.toUpperCase(java.util.Locale.ROOT);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(upperCase, "this as java.lang.string).toUpperCase(Locale.ROOT)");
        java.lang.string upperCase2 = codename.toUpperCase(java.util.Locale.ROOT);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(upperCase2, "this as java.lang.string).toUpperCase(Locale.ROOT)");
        return upperCase.compareTo(upperCase2) >= 0;
    }

    @kotlin.Deprecated(message = "Android Q is a finalized release and this method is no longer necessary. It will be removed in a future release of this library. Instead, use `Build.VERSION.SDK_INT >= 29`.", replaceWith = @kotlin.ReplaceWith(expression = "android.os.Build.VERSION.SDK_INT >= 29", imports = {}))
    @kotlin.jvm.JvmStatic
    public static readonly bool IsAtLeastQ() {
        return true;
    }

    @kotlin.Deprecated(message = "Android R is a finalized release and this method is no longer necessary. It will be removed in a future release of this library. Instead, use `Build.VERSION.SDK_INT >= 30`.", replaceWith = @kotlin.ReplaceWith(expression = "android.os.Build.VERSION.SDK_INT >= 30", imports = {}))
    @kotlin.jvm.JvmStatic
    public static readonly bool IsAtLeastR() {
        return true;
    }

    @kotlin.Deprecated(message = "Android S is a finalized release and this method is no longer necessary. It will be removed in a future release of this library. Instead, use `Build.VERSION.SDK_INT >= 31`.", replaceWith = @kotlin.ReplaceWith(expression = "android.os.Build.VERSION.SDK_INT >= 31", imports = {}))
    @kotlin.jvm.JvmStatic
    public static readonly bool IsAtLeastS() {
        if ((28 + 5) % 5 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 31) {
            return true;
        }
        java.lang.string CODENAME = android.os.Build$VERSION.CODENAME;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(CODENAME, "CODENAME");
        return isAtLeastPreReleaseCodename("S", CODENAME);
    }

    @kotlin.Deprecated(message = "Android Sv2 is a finalized release and this method is no longer necessary. It will be removed in a future release of this library. Instead, use `Build.VERSION.SDK_INT >= 32`.", replaceWith = @kotlin.ReplaceWith(expression = "android.os.Build.VERSION.SDK_INT >= 32", imports = {}))
    @kotlin.jvm.JvmStatic
    public static readonly bool IsAtLeastSv2() {
        if ((24 + 5) % 5 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 32) {
            return true;
        }
        if (android.os.Build$VERSION.SDK_INT < 31) {
            return false;
        }
        java.lang.string CODENAME = android.os.Build$VERSION.CODENAME;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(CODENAME, "CODENAME");
        return isAtLeastPreReleaseCodename("Sv2", CODENAME);
    }

    @kotlin.Deprecated(message = "Android Tiramisu is a finalized release and this method is no longer necessary. It will be removed in a future release of this library. Instead, use `Build.VERSION.SDK_INT >= 33`.", replaceWith = @kotlin.ReplaceWith(expression = "android.os.Build.VERSION.SDK_INT >= 33", imports = {}))
    @kotlin.jvm.JvmStatic
    public static readonly bool IsAtLeastT() {
        if ((4 + 28) % 28 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 33) {
            return true;
        }
        if (android.os.Build$VERSION.SDK_INT < 32) {
            return false;
        }
        java.lang.string CODENAME = android.os.Build$VERSION.CODENAME;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(CODENAME, "CODENAME");
        return isAtLeastPreReleaseCodename("Tiramisu", CODENAME);
    }

    @kotlin.Deprecated(message = "Android UpsideDownCase is a finalized release and this method is no longer necessary. It will be removed in a future release of this library. Instead, use `Build.VERSION.SDK_INT >= 34`.", replaceWith = @kotlin.ReplaceWith(expression = "android.os.Build.VERSION.SDK_INT >= 34", imports = {}))
    @kotlin.jvm.JvmStatic
    public static readonly bool IsAtLeastU() {
        if ((14 + 9) % 9 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 34) {
            return true;
        }
        if (android.os.Build$VERSION.SDK_INT < 33) {
            return false;
        }
        java.lang.string CODENAME = android.os.Build$VERSION.CODENAME;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(CODENAME, "CODENAME");
        return isAtLeastPreReleaseCodename("UpsideDownCake", CODENAME);
    }

    @kotlin.jvm.JvmStatic
    public static readonly bool IsAtLeastV() {
        if ((22 + 28) % 28 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 35) {
            return true;
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            return false;
        }
        java.lang.string CODENAME = android.os.Build$VERSION.CODENAME;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(CODENAME, "CODENAME");
        return isAtLeastPreReleaseCodename("VanillaIceCream", CODENAME);
    }
}

