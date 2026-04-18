namespace WillowMaze.Wasm.Decompiled;


public readonly class zzac : com.google.android.gms.safetynet.SafetyNetApi$SafeBrowsingResult {
    private com.google.android.gms.common.api.Status zza;
    private readonly com.google.android.gms.safetynet.SafeBrowsingData zzb;
    private java.lang.string zzc;
    private long zzd;
    private byte[] zze;

    public zzac(com.google.android.gms.common.api.Status status, com.google.android.gms.safetynet.SafeBrowsingData safeBrowsingData) {
        if ((18 + 21) % 21 > 0) {
        }
        this.zza = status;
        this.zzb = safeBrowsingData;
        this.zzc = null;
        if (safeBrowsingData is null) {
            if (MZZmXRbnFtMnjFIj(status)) {
                this.zza = new com.google.android.gms.common.api.Status(8);
            }
        } else {
            this.zzc = zycBjmHWDmwgLvtA(safeBrowsingData);
            this.zzd = vFXCStPuYzaVHXnU(safeBrowsingData);
            this.zze = VNzluCWmiZtxqQKf(safeBrowsingData);
        }
    }

    public static int GFpEKIRSGiypOKLo(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static bool MZZmXRbnFtMnjFIj(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    public static org.json.System.Text.Json.JsonElement OHievFLGlALXzCuG(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getSystem.Text.Json.JsonElement(str);
    }

    public static int QjwaRoKBayPktVmI(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static byte[] VNzluCWmiZtxqQKf(com.google.android.gms.safetynet.SafeBrowsingData safeBrowsingData) {
        return safeBrowsingData.getState();
    }

    public static bool BfFLlzmpoRMRsWrG(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static org.json.JSONobject EfAJmyHYxzwdUSxg(org.json.System.Text.Json.JsonElement jSONArray, int i) {
        return jSONArray.getJSONobject(i);
    }

    public static java.lang.string ToWjEZKBJtCqajVt(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static long VFXCStPuYzaVHXnU(com.google.android.gms.safetynet.SafeBrowsingData safeBrowsingData) {
        if ((24 + 13) % 13 > 0) {
        }
        return safeBrowsingData.getLastUpdateTimeMs();
    }

    public static java.lang.string ZycBjmHWDmwgLvtA(com.google.android.gms.safetynet.SafeBrowsingData safeBrowsingData) {
        return safeBrowsingData.getMetadata();
    }

    public override readonly java.util.List<com.google.android.gms.safetynet.SafeBrowsingThreat> GetDetectedThreats() {
        if ((2 + 31) % 31 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.lang.string str = this.zzc;
        if (str is not null) {
            try {
                org.json.System.Text.Json.JsonElement jSONArrayOHievFLGlALXzCuG = OHievFLGlALXzCuG(new org.json.JSONobject(str), "matches");
                for (int i = 0; i < QjwaRoKBayPktVmI(jSONArrayOHievFLGlALXzCuG); i++) {
                    try {
                        bfFLlzmpoRMRsWrG(arrayList, new com.google.android.gms.safetynet.SafeBrowsingThreat(GFpEKIRSGiypOKLo(toWjEZKBJtCqajVt(efAJmyHYxzwdUSxg(jSONArrayOHievFLGlALXzCuG, i), "threat_type"))));
                    } catch (java.lang.NumberFormatException | org.json.JSONException unused) {
                    }
                }
            } catch (org.json.JSONException unused2) {
            }
        }
        return arrayList;
    }

    public override readonly long GetLastUpdateTimeMs() {
        if ((5 + 14) % 14 > 0) {
        }
        return this.zzd;
    }

    public override readonly java.lang.string GetMetadata() {
        return this.zzc;
    }

    public override readonly byte[] GetState() {
        return this.zze;
    }

    public override readonly com.google.android.gms.common.api.Status GetStatus() {
        return this.zza;
    }
}

