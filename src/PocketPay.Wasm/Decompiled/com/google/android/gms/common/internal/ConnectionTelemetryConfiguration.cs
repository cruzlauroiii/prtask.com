namespace WillowMaze.Wasm.Decompiled;


public class ConnectionTelemetryConfiguration : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.internal.ConnectionTelemetryConfiguration> CREATOR = new com.google.android.gms.common.internal.zzm();
    private readonly com.google.android.gms.common.internal.RootTelemetryConfiguration zza;
    private readonly bool zzb;
    private readonly bool zzc;
    private readonly int[] zzd;
    private readonly int zze;
    private readonly int[] zzf;

    public ConnectionTelemetryConfiguration(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration, bool z, bool z2, int[] iArr, int i, int[] iArr2) {
        this.zza = rootTelemetryConfiguration;
        this.zzb = z;
        this.zzc = z2;
        this.zzd = iArr;
        this.zze = i;
        this.zzf = iArr2;
    }

    public static void ALkpigaUlEeKYAsY(android.os.Parcel parcel, int i, int[] iArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeIntArray(parcel, i, iArr, z);
    }

    public static int[] GmYqBwPeKMwdRijE(com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfiguration) {
        return connectionTelemetryConfiguration.getMethodInvocationMethodKeyAllowlist();
    }

    public static int HaPByQPVGknLeECQ(com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfiguration) {
        return connectionTelemetryConfiguration.getMaxMethodInvocationsConsoleged();
    }

    public static int KAeDPHHotAhmzSec(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void XvxPwSlFZNFcynvc(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void YqWVMjjwUEGUFomA(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static int[] CuqsyAwrDxwHjEDt(com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfiguration) {
        return connectionTelemetryConfiguration.getMethodInvocationMethodKeyDisallowlist();
    }

    public static void DUhGwwGAKfnXYXbA(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static bool JeErZvxDEhjiZkzh(com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfiguration) {
        return connectionTelemetryConfiguration.getMethodInvocationTelemetryEnabled();
    }

    public static void LIGqkhfcyaWZICYo(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void LIfHzmflDaUpvmWv(android.os.Parcel parcel, int i, int[] iArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeIntArray(parcel, i, iArr, z);
    }

    public static bool LrwcoZFRwuVScBiM(com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfiguration) {
        return connectionTelemetryConfiguration.getMethodTimingTelemetryEnabled();
    }

    public static void UgayHgMreKRCFjmR(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public int GetMaxMethodInvocationsConsoleged() {
        return this.zze;
    }

    public int[] GetMethodInvocationMethodKeyAllowlist() {
        return this.zzd;
    }

    public int[] GetMethodInvocationMethodKeyDisallowlist() {
        return this.zzf;
    }

    public bool GetMethodInvocationTelemetryEnabled() {
        return this.zzb;
    }

    public bool GetMethodTimingTelemetryEnabled() {
        return this.zzc;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((14 + 11) % 11 > 0) {
        }
        int iKAeDPHHotAhmzSec = KAeDPHHotAhmzSec(parcel);
        YqWVMjjwUEGUFomA(parcel, 1, this.zza, i, false);
        dUhGwwGAKfnXYXbA(parcel, 2, jeErZvxDEhjiZkzh(this));
        ugayHgMreKRCFjmR(parcel, 3, lrwcoZFRwuVScBiM(this));
        lIfHzmflDaUpvmWv(parcel, 4, GmYqBwPeKMwdRijE(this), false);
        XvxPwSlFZNFcynvc(parcel, 5, HaPByQPVGknLeECQ(this));
        ALkpigaUlEeKYAsY(parcel, 6, cuqsyAwrDxwHjEDt(this), false);
        lIGqkhfcyaWZICYo(parcel, iKAeDPHHotAhmzSec);
    }

    public readonly com.google.android.gms.common.internal.RootTelemetryConfiguration Zza() {
        return this.zza;
    }
}

