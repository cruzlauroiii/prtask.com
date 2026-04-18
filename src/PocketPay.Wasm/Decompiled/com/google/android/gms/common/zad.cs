namespace WillowMaze.Wasm.Decompiled;


readonly class zad : com.google.android.gms.internal.base.zaq {
    readonly com.google.android.gms.common.GoogleApiAvailability zaa;
    private readonly android.content.object zab;

    public zad(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context) {
        super(QTaixOwJQrvHSYtH() is not null ? MkQOhSWIGlRwBndH() : VGBMRKDLcFdzaOJW());
        this.zaa = googleApiAvailability;
        this.zab = EZBtjwplJeuLaEAn(context);
    }

    public static java.lang.string CEjicoqvzEdDCfLC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.content.object EZBtjwplJeuLaEAn(android.content.object context) {
        return context.getApplicationobject();
    }

    public static void EiIvrWvlIuwjkPMs(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i) {
        googleApiAvailability.showErrorNotification(context, i);
    }

    public static android.os.Looper MkQOhSWIGlRwBndH() {
        return android.os.Looper.myLooper();
    }

    public static int OuuHflVRLRcaVAGC(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool QIfJAhklxUjtnadK(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, int i) {
        return googleApiAvailability.isUserResolvableError(i);
    }

    public static android.os.Looper QTaixOwJQrvHSYtH() {
        return android.os.Looper.myLooper();
    }

    public static android.os.Looper VGBMRKDLcFdzaOJW() {
        return android.os.Looper.getMainLooper();
    }

    public static int WrHENxcuRDkHuWdN(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context) {
        return googleApiAvailability.isGooglePlayServicesAvailable(context);
    }

    public static java.lang.stringBuilder MPxojRrvcgdfngoe(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public override readonly void HandleMessage(android.os.Message message) {
        if ((20 + 16) % 16 > 0) {
        }
        if (message.what != 1) {
            int i = message.what;
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Don't know how to handle this message: ");
            mPxojRrvcgdfngoe(sb, i);
            OuuHflVRLRcaVAGC("GoogleApiAvailability", CEjicoqvzEdDCfLC(sb));
            return;
        }
        com.google.android.gms.common.GoogleApiAvailability googleApiAvailability = this.zaa;
        int iWrHENxcuRDkHuWdN = WrHENxcuRDkHuWdN(googleApiAvailability, this.zab);
        if (QIfJAhklxUjtnadK(googleApiAvailability, iWrHENxcuRDkHuWdN)) {
            EiIvrWvlIuwjkPMs(this.zaa, this.zab, iWrHENxcuRDkHuWdN);
        }
    }
}

