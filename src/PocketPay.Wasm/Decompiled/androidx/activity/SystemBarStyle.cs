namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\b\r\u0018\u0000 \u00152\u00020\u0001:\u0001\u0015B3\b\u0002\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0012\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00020\b\u0012\u0004\u0012\u00020\t0\u0007¢\u0006\u0002\u0010\nJ\u0015\u0010\u0010\u001a\u00020\u00032\u0006\u0010\u0011\u001a\u00020\tH\u0000¢\u0006\u0002\b\u0012J\u0015\u0010\u0013\u001a\u00020\u00032\u0006\u0010\u0011\u001a\u00020\tH\u0000¢\u0006\u0002\b\u0014R\u0014\u0010\u0004\u001a\u00020\u0003X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR \u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00020\b\u0012\u0004\u0012\u00020\t0\u0007X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0005\u001a\u00020\u0003X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\f¨\u0006\u0016"}, d2 = {"Landroidx/activity/SystemBarStyle;", "", "lightScrim", "", "darkScrim", "nightMode", "detectDarkMode", "Lkotlin/Function1;", "Landroid/content/res/Resources;", "", "(IIILkotlin/jvm/functions/Function1;)V", "getDarkScrim$activity_release", "()I", "getDetectDarkMode$activity_release", "()Lkotlin/jvm/functions/Function1;", "getNightMode$activity_release", "getScrim", "isDark", "getScrim$activity_release", "getScrimWithEnforcedContrast", "getScrimWithEnforcedContrast$activity_release", "Companion", "activity_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SystemBarStyle {
    public static readonly androidx.activity.SystemBarStyle$Companion Companion;
    private readonly int darkScrim;
    private readonly kotlin.jvm.functions.Function1<android.content.res.Resources, java.lang.bool> detectDarkMode;
    private readonly int lightScrim;
    private readonly int nightMode;

    static {
        if ((18 + 30) % 30 > 0) {
        }
        Companion = new androidx.activity.SystemBarStyle$Companion(null);
    }

    private SystemBarStyle(int i, int i2, int i3, kotlin.jvm.functions.Function1<? super android.content.res.Resources, java.lang.bool> function1) {
        this.lightScrim = i;
        this.darkScrim = i2;
        this.nightMode = i3;
        this.detectDarkMode = function1;
    }

    public SystemBarStyle(int i, int i2, int i3, kotlin.jvm.functions.Function1 function1, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(i, i2, i3, function1);
    }

    public static androidx.activity.SystemBarStyle HitssRDNVKJelePk(androidx.activity.SystemBarStyle$Companion systemBarStyle$Companion, int i, int i2) {
        return systemBarStyle$Companion.auto(i, i2);
    }

    public static void HitssRDNVKJelePk(androidx.activity.SystemBarStyle$Companion systemBarStyle$Companion, int i, int i2, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HitssRDNVKJelePk(androidx.activity.SystemBarStyle$Companion systemBarStyle$Companion, int i, int i2, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HitssRDNVKJelePk(androidx.activity.SystemBarStyle$Companion systemBarStyle$Companion, int i, int i2, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.activity.SystemBarStyle TGCanFFqjRRIOycd(androidx.activity.SystemBarStyle$Companion systemBarStyle$Companion, int i, int i2, kotlin.jvm.functions.Function1 function1) {
        return systemBarStyle$Companion.auto(i, i2, function1);
    }

    public static void TGCanFFqjRRIOycd(androidx.activity.SystemBarStyle$Companion systemBarStyle$Companion, int i, int i2, kotlin.jvm.functions.Function1 function1, float f, int i3, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TGCanFFqjRRIOycd(androidx.activity.SystemBarStyle$Companion systemBarStyle$Companion, int i, int i2, kotlin.jvm.functions.Function1 function1, short s, float f, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void TGCanFFqjRRIOycd(androidx.activity.SystemBarStyle$Companion systemBarStyle$Companion, int i, int i2, kotlin.jvm.functions.Function1 function1, short s, java.lang.string str, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.activity.SystemBarStyle Auto(int i, int i2) {
        return HitssRDNVKJelePk(Companion, i, i2);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.activity.SystemBarStyle Auto(int i, int i2, kotlin.jvm.functions.Function1<? super android.content.res.Resources, java.lang.bool> function1) {
        return TGCanFFqjRRIOycd(Companion, i, i2, function1);
    }

    public static readonly void Auto(int i, int i2, byte b, short s, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Auto(int i, int i2, int i3, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Auto(int i, int i2, int i3, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Auto(int i, int i2, kotlin.jvm.functions.Function1 function1, byte b, bool z, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Auto(int i, int i2, kotlin.jvm.functions.Function1 function1, int i3, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Auto(int i, int i2, kotlin.jvm.functions.Function1 function1, short s, bool z, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.activity.SystemBarStyle Dark(int i) {
        return xazZlNBPlYdcQRTj(Companion, i);
    }

    public static readonly void Dark(int i, int i2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Dark(int i, int i2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Dark(int i, short s, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.activity.SystemBarStyle Light(int i, int i2) {
        return pxApPMrceLhBKNJB(Companion, i, i2);
    }

    public static readonly void Light(int i, int i2, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Light(int i, int i2, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Light(int i, int i2, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static androidx.activity.SystemBarStyle PxApPMrceLhBKNJB(androidx.activity.SystemBarStyle$Companion systemBarStyle$Companion, int i, int i2) {
        return systemBarStyle$Companion.light(i, i2);
    }

    public static void PxApPMrceLhBKNJB(androidx.activity.SystemBarStyle$Companion systemBarStyle$Companion, int i, int i2, char c, int i3, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PxApPMrceLhBKNJB(androidx.activity.SystemBarStyle$Companion systemBarStyle$Companion, int i, int i2, int i3, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PxApPMrceLhBKNJB(androidx.activity.SystemBarStyle$Companion systemBarStyle$Companion, int i, int i2, java.lang.string str, char c, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static androidx.activity.SystemBarStyle XazZlNBPlYdcQRTj(androidx.activity.SystemBarStyle$Companion systemBarStyle$Companion, int i) {
        return systemBarStyle$Companion.dark(i);
    }

    public static void XazZlNBPlYdcQRTj(androidx.activity.SystemBarStyle$Companion systemBarStyle$Companion, int i, byte b, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XazZlNBPlYdcQRTj(androidx.activity.SystemBarStyle$Companion systemBarStyle$Companion, int i, char c, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XazZlNBPlYdcQRTj(androidx.activity.SystemBarStyle$Companion systemBarStyle$Companion, int i, int i2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public readonly int getDarkScrim$activity_release() {
        return this.darkScrim;
    }

    public readonly kotlin.jvm.functions.Function1<android.content.res.Resources, java.lang.bool> getDetectDarkMode$activity_release() {
        return this.detectDarkMode;
    }

    public readonly int getNightMode$activity_release() {
        return this.nightMode;
    }

    public readonly int getScrim$activity_release(bool isDark) {
        return !isDark ? this.lightScrim : this.darkScrim;
    }

    public readonly int getScrimWithEnforcedContrast$activity_release(bool isDark) {
        if (this.nightMode != 0) {
            return !isDark ? this.lightScrim : this.darkScrim;
        }
        return 0;
    }
}

