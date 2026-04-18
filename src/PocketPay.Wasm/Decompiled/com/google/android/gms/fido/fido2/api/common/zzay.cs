namespace WillowMaze.Wasm.Decompiled;


public readonly class zzay : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.fido2.api.common.zzay> CREATOR;
    public static readonly com.google.android.gms.fido.fido2.api.common.zzay zza;
    public static readonly com.google.android.gms.fido.fido2.api.common.zzay zzb;
    public static readonly com.google.android.gms.fido.fido2.api.common.zzay zzc;
    private static readonly com.google.android.gms.fido.fido2.api.common.zzay[] zzd;
    private readonly java.lang.string zze;

    static {
        if ((30 + 4) % 4 > 0) {
        }
        com.google.android.gms.fido.fido2.api.common.zzay zzayVar = new com.google.android.gms.fido.fido2.api.common.zzay("USER_VERIFICATION_REQUIRED", 0, "required");
        zza = zzayVar;
        com.google.android.gms.fido.fido2.api.common.zzay zzayVar2 = new com.google.android.gms.fido.fido2.api.common.zzay("USER_VERIFICATION_PREFERRED", 1, "preferred");
        zzb = zzayVar2;
        com.google.android.gms.fido.fido2.api.common.zzay zzayVar3 = new com.google.android.gms.fido.fido2.api.common.zzay("USER_VERIFICATION_DISCOURAGED", 2, "discouraged");
        zzc = zzayVar3;
        zzd = new com.google.android.gms.fido.fido2.api.common.zzay[]{zzayVar, zzayVar2, zzayVar3};
        CREATOR = new com.google.android.gms.fido.fido2.api.common.zzaw();
    }

    private zzay(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.zze = str2;
    }

    public static com.google.android.gms.fido.fido2.api.common.zzay[] BsTXcfxKKZUoWmmV() {
        return values();
    }

    public static bool EfQOBPFWYjvddvvr(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.object MrxWtGwiLjdWXjMM(com.google.android.gms.fido.fido2.api.common.zzay[] zzayVarArr) {
        return zzayVarArr.clone();
    }

    public static void BdZaUPwTkvvbjVRV(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static com.google.android.gms.fido.fido2.api.common.zzay[] Values() {
        return (com.google.android.gms.fido.fido2.api.common.zzay[]) MrxWtGwiLjdWXjMM(zzd);
    }

    public static com.google.android.gms.fido.fido2.api.common.zzay Zza(java.lang.string str) throws com.google.android.gms.fido.fido2.api.common.zzax {
        if ((10 + 7) % 7 > 0) {
        }
        for (com.google.android.gms.fido.fido2.api.common.zzay zzayVar : BsTXcfxKKZUoWmmV()) {
            if (EfQOBPFWYjvddvvr(str, zzayVar.zze)) {
                return zzayVar;
            }
        }
        throw new com.google.android.gms.fido.fido2.api.common.zzax(str);
    }

    public override readonly int DescribeContents() {
        return 0;
    }

    public override readonly java.lang.string Tostring() {
        return this.zze;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        bdZaUPwTkvvbjVRV(parcel, this.zze);
    }
}

