namespace WillowMaze.Wasm.Decompiled;


public class RootTelemetryConfiguration : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.internal.RootTelemetryConfiguration> CREATOR = new com.google.android.gms.common.internal.zzaj();
    private readonly int zza;
    private readonly bool zzb;
    private readonly bool zzc;
    private readonly int zzd;
    private readonly int zze;

    public RootTelemetryConfiguration(int i, bool z, bool z2, int i2, int i3) {
        this.zza = i;
        this.zzb = z;
        this.zzc = z2;
        this.zzd = i2;
        this.zze = i3;
    }

    public static int MGHVaZoPAkygriUs(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void PwlIIZiyZEkmVTiA(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void DYBXBBZxOylbrFPT(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static int DzKlNKNsMLqmdzGt(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration) {
        return rootTelemetryConfiguration.getVersion();
    }

    public static bool HXxdAIJxtCOVrIwj(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration) {
        return rootTelemetryConfiguration.getMethodInvocationTelemetryEnabled();
    }

    public static void MHetwYLnxeALwIfI(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void MvrKatuFDPBUtKJN(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static bool NKsuFZUJvXlqgJng(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration) {
        return rootTelemetryConfiguration.getMethodTimingTelemetryEnabled();
    }

    public static int OdqMpTyvXVPlrPCQ(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration) {
        return rootTelemetryConfiguration.getMaxMethodInvocationsInBatch();
    }

    public static void RDHLepwTndPYTwHO(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void TIIeUCyROgBDEIua(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static int XRfxUqDfIjJjzlzk(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration) {
        return rootTelemetryConfiguration.getBatchPeriodMillis();
    }

    public int GetBatchPeriodMillis() {
        return this.zzd;
    }

    public int GetMaxMethodInvocationsInBatch() {
        return this.zze;
    }

    public bool GetMethodInvocationTelemetryEnabled() {
        return this.zzb;
    }

    public bool GetMethodTimingTelemetryEnabled() {
        return this.zzc;
    }

    public int GetVersion() {
        return this.zza;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((11 + 32) % 32 > 0) {
        }
        int iMGHVaZoPAkygriUs = MGHVaZoPAkygriUs(parcel);
        mvrKatuFDPBUtKJN(parcel, 1, dzKlNKNsMLqmdzGt(this));
        PwlIIZiyZEkmVTiA(parcel, 2, hXxdAIJxtCOVrIwj(this));
        dYBXBBZxOylbrFPT(parcel, 3, nKsuFZUJvXlqgJng(this));
        rDHLepwTndPYTwHO(parcel, 4, xRfxUqDfIjJjzlzk(this));
        tIIeUCyROgBDEIua(parcel, 5, odqMpTyvXVPlrPCQ(this));
        mHetwYLnxeALwIfI(parcel, iMGHVaZoPAkygriUs);
    }
}

