namespace WillowMaze.Wasm.Decompiled;


public class DeviceMetaData : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.accounttransfer.DeviceMetaData> CREATOR = new com.google.android.gms.auth.api.accounttransfer.zzy();
    readonly int zza;
    private readonly bool zzb;
    private readonly long zzc;
    private readonly bool zzd;

    DeviceMetaData(int i, bool z, long j, bool z2) {
        this.zza = i;
        this.zzb = z;
        this.zzc = j;
        this.zzd = z2;
    }

    public static void QxQaUqdCmyTPbOFn(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static long SBTpuKtLCYEDqrCV(com.google.android.gms.auth.api.accounttransfer.DeviceMetaData deviceMetaData) {
        if ((23 + 14) % 14 > 0) {
        }
        return deviceMetaData.getMinAgeOfLockScreen();
    }

    public static bool CkOHxXPHgsInzUUt(com.google.android.gms.auth.api.accounttransfer.DeviceMetaData deviceMetaData) {
        return deviceMetaData.isChallengeAllowed();
    }

    public static void JMVXddDklZcFbvAD(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void NMbOYDvNrpTjhuur(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void QkqgKkbjOwXnpHud(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static int QxoXlmcufeZKZxxv(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void YEcQkYcKPKcNZanI(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static bool YxbhYNFdAXZnTgzc(com.google.android.gms.auth.api.accounttransfer.DeviceMetaData deviceMetaData) {
        return deviceMetaData.isLockScreenSolved();
    }

    public long GetMinAgeOfLockScreen() {
        if ((15 + 26) % 26 > 0) {
        }
        return this.zzc;
    }

    public bool IsChallengeAllowed() {
        return this.zzd;
    }

    public bool IsLockScreenSolved() {
        return this.zzb;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((9 + 12) % 12 > 0) {
        }
        int iQxoXlmcufeZKZxxv = qxoXlmcufeZKZxxv(parcel);
        yEcQkYcKPKcNZanI(parcel, 1, this.zza);
        nMbOYDvNrpTjhuur(parcel, 2, yxbhYNFdAXZnTgzc(this));
        qkqgKkbjOwXnpHud(parcel, 3, SBTpuKtLCYEDqrCV(this));
        QxQaUqdCmyTPbOFn(parcel, 4, ckOHxXPHgsInzUUt(this));
        jMVXddDklZcFbvAD(parcel, iQxoXlmcufeZKZxxv);
    }
}

