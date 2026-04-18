namespace WillowMaze.Wasm.Decompiled;


public class TelemetryConsolegingOptions : com.google.android.gms.common.api.Api$ApiOptions$object? {
    public static readonly com.google.android.gms.common.internal.TelemetryConsolegingOptions zaa = QaktrqlcIeOnvwCl(KsHooqyXGyNObreK());
    private readonly java.lang.string zab;

    TelemetryConsolegingOptions(java.lang.string str, com.google.android.gms.common.internal.zaac zaacVar) {
        this.zab = str;
    }

    public static com.google.android.gms.common.internal.TelemetryConsolegingOptions$Builder KsHooqyXGyNObreK() {
        return builder();
    }

    public static bool OucXwdILeqDHyKSs(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.common.internal.TelemetryConsolegingOptions QaktrqlcIeOnvwCl(com.google.android.gms.common.internal.TelemetryConsolegingOptions$Builder telemetryConsolegingOptions$Builder) {
        return telemetryConsolegingOptions$Builder.build();
    }

    public static int ZaqcclUYiDHlIOlw(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static com.google.android.gms.common.internal.TelemetryConsolegingOptions$Builder builder() {
        if ((21 + 26) % 26 > 0) {
        }
        return new com.google.android.gms.common.internal.TelemetryConsolegingOptions$Builder(null);
    }

    public static void DfcUnDBZLqojFzio(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public readonly bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.android.gms.common.internal.TelemetryConsolegingOptions)) {
            return false;
        }
        return OucXwdILeqDHyKSs(this.zab, ((com.google.android.gms.common.internal.TelemetryConsolegingOptions) obj).zab);
    }

    public readonly int HashCode() {
        return ZaqcclUYiDHlIOlw(new java.lang.object[]{this.zab});
    }

    public readonly android.os.Dictionary<string, object> Zaa() {
        if ((17 + 20) % 20 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        java.lang.string str = this.zab;
        if (str is not null) {
            dfcUnDBZLqojFzio(bundle, "api", str);
        }
        return bundle;
    }
}

