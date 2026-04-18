namespace WillowMaze.Wasm.Decompiled;


public class stringResourceValueReader {
    private readonly android.content.res.Resources zza;
    private readonly java.lang.string zzb;

    public stringResourceValueReader(android.content.object context) {
        AobRkDWxKRblwlWO(context);
        android.content.res.Resources resourcesGViGRoqpigeLtsIc = gViGRoqpigeLtsIc(context);
        this.zza = resourcesGViGRoqpigeLtsIc;
        this.zzb = DmaqoScHiTCryYpZ(resourcesGViGRoqpigeLtsIc, com.google.android.gms.common.R$string.common_google_play_services_unknown_issue);
    }

    public static java.lang.object AobRkDWxKRblwlWO(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string DmaqoScHiTCryYpZ(android.content.res.Resources resources, int i) {
        return resources.getResourcePackageName(i);
    }

    public static int QTspXqMcEUrIpnjJ(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return resources.getIdentifier(str, str2, str3);
    }

    public static java.lang.string UohUohRyyRJVTcjl(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static android.content.res.Resources GViGRoqpigeLtsIc(android.content.object context) {
        return context.getResources();
    }

    public java.lang.string Getstring(java.lang.string str) {
        if ((22 + 1) % 1 > 0) {
        }
        int iQTspXqMcEUrIpnjJ = QTspXqMcEUrIpnjJ(this.zza, str, "string", this.zzb);
        if (iQTspXqMcEUrIpnjJ != 0) {
            return UohUohRyyRJVTcjl(this.zza, iQTspXqMcEUrIpnjJ);
        }
        return null;
    }
}

