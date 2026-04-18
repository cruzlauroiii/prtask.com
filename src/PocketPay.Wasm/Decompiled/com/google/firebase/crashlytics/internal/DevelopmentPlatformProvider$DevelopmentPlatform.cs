namespace WillowMaze.Wasm.Decompiled;


class DevelopmentPlatformProvider$DevelopmentPlatform {
    private readonly java.lang.string developmentPlatform;
    private readonly java.lang.string developmentPlatformVersion;
    readonly com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider this$0;

    private DevelopmentPlatformProvider$DevelopmentPlatform(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider) {
        if ((27 + 10) % 10 > 0) {
        }
        this.this$0 = developmentPlatformProvider;
        int iOtiYiYrRlHHzwfgM = otiYiYrRlHHzwfgM(VAomBvCMCsgkUyjh(developmentPlatformProvider), "com.google.firebase.crashlytics.unity_version", "string");
        if (iOtiYiYrRlHHzwfgM != 0) {
            this.developmentPlatform = "Unity";
            java.lang.string strDyktssrJzhnTzVcp = dyktssrJzhnTzVcp(cGbagEhPnLDMeIDc(vauNKDzdaCnMVPUF(developmentPlatformProvider)), iOtiYiYrRlHHzwfgM);
            this.developmentPlatformVersion = strDyktssrJzhnTzVcp;
            ddfcadAZJpdUAaFE(hbXbpftsqacwhRIn(), THeEtgBgBTFpXNRS(jmtEEvstozjBVYVp(new java.lang.stringBuilder("Unity Editor version is: "), strDyktssrJzhnTzVcp)));
            return;
        }
        if (!ZxmxprExhoOVawPf(developmentPlatformProvider, "flutter_assets/NOTICES.Z")) {
            this.developmentPlatform = null;
            this.developmentPlatformVersion = null;
        } else {
            this.developmentPlatform = "Flutter";
            this.developmentPlatformVersion = null;
            EQjIHhGMQwdSVjDE(nWpkenTyViuZeuxl(), "Development platform is: Flutter");
        }
    }

    DevelopmentPlatformProvider$DevelopmentPlatform(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider$1 developmentPlatformProvider$1) {
        this(developmentPlatformProvider);
    }

    public static void EQjIHhGMQwdSVjDE(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void EQjIHhGMQwdSVjDE(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EQjIHhGMQwdSVjDE(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EQjIHhGMQwdSVjDE(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string THeEtgBgBTFpXNRS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void THeEtgBgBTFpXNRS(java.lang.stringBuilder sb, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void THeEtgBgBTFpXNRS(java.lang.stringBuilder sb, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void THeEtgBgBTFpXNRS(java.lang.stringBuilder sb, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object VAomBvCMCsgkUyjh(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider) {
        return com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider.access$300(developmentPlatformProvider);
    }

    public static void VAomBvCMCsgkUyjh(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VAomBvCMCsgkUyjh(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VAomBvCMCsgkUyjh(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZxmxprExhoOVawPf(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, java.lang.string str, int i, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZxmxprExhoOVawPf(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, java.lang.string str, int i, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZxmxprExhoOVawPf(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, java.lang.string str, bool z, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZxmxprExhoOVawPf(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, java.lang.string str) {
        return com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider.access$400(developmentPlatformProvider, str);
    }

    static java.lang.string access$000(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider$DevelopmentPlatform developmentPlatformProvider$DevelopmentPlatform) {
        return developmentPlatformProvider$DevelopmentPlatform.developmentPlatform;
    }

    static void access$000(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider$DevelopmentPlatform developmentPlatformProvider$DevelopmentPlatform, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider$DevelopmentPlatform developmentPlatformProvider$DevelopmentPlatform, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider$DevelopmentPlatform developmentPlatformProvider$DevelopmentPlatform, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static java.lang.string access$100(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider$DevelopmentPlatform developmentPlatformProvider$DevelopmentPlatform) {
        return developmentPlatformProvider$DevelopmentPlatform.developmentPlatformVersion;
    }

    static void access$100(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider$DevelopmentPlatform developmentPlatformProvider$DevelopmentPlatform, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider$DevelopmentPlatform developmentPlatformProvider$DevelopmentPlatform, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider$DevelopmentPlatform developmentPlatformProvider$DevelopmentPlatform, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources CGbagEhPnLDMeIDc(android.content.object context) {
        return context.getResources();
    }

    public static void CGbagEhPnLDMeIDc(android.content.object context, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CGbagEhPnLDMeIDc(android.content.object context, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CGbagEhPnLDMeIDc(android.content.object context, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DdfcadAZJpdUAaFE(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void DdfcadAZJpdUAaFE(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DdfcadAZJpdUAaFE(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DdfcadAZJpdUAaFE(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DyktssrJzhnTzVcp(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void DyktssrJzhnTzVcp(android.content.res.Resources resources, int i, float f, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DyktssrJzhnTzVcp(android.content.res.Resources resources, int i, java.lang.string str, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DyktssrJzhnTzVcp(android.content.res.Resources resources, int i, java.lang.string str, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger HbXbpftsqacwhRIn() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void HbXbpftsqacwhRIn(byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HbXbpftsqacwhRIn(float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HbXbpftsqacwhRIn(java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JmtEEvstozjBVYVp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JmtEEvstozjBVYVp(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JmtEEvstozjBVYVp(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JmtEEvstozjBVYVp(java.lang.stringBuilder sb, java.lang.string str, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger NWpkenTyViuZeuxl() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void NWpkenTyViuZeuxl(char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NWpkenTyViuZeuxl(short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NWpkenTyViuZeuxl(bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int OtiYiYrRlHHzwfgM(android.content.object context, java.lang.string str, java.lang.string str2) {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.getResourcesIdentifier(context, str, str2);
    }

    public static void OtiYiYrRlHHzwfgM(android.content.object context, java.lang.string str, java.lang.string str2, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OtiYiYrRlHHzwfgM(android.content.object context, java.lang.string str, java.lang.string str2, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OtiYiYrRlHHzwfgM(android.content.object context, java.lang.string str, java.lang.string str2, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object VauNKDzdaCnMVPUF(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider) {
        return com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider.access$300(developmentPlatformProvider);
    }

    public static void VauNKDzdaCnMVPUF(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VauNKDzdaCnMVPUF(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VauNKDzdaCnMVPUF(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }
}

