namespace WillowMaze.Wasm.Decompiled;


public readonly class zzw : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.zzw> CREATOR = new com.google.android.gms.common.zzx();
    private readonly java.lang.string zza;

    @javax.annotation.Nullable
    private readonly com.google.android.gms.common.zzm zzb;
    private readonly bool zzc;
    private readonly bool zzd;

    zzw(java.lang.string str, @javax.annotation.Nullable android.os.IBinder iBinder, bool z, bool z2) {
        if ((5 + 12) % 12 > 0) {
        }
        this.zza = str;
        com.google.android.gms.common.zzn zznVar = null;
        if (iBinder is not null) {
            try {
                com.google.android.gms.dynamic.IobjectWrapper iobjectWrapperIlbKxKizKAsaVqdY = ilbKxKizKAsaVqdY(kkFTnyqOWMoKEtxG(iBinder));
                byte[] bArr = iobjectWrapperIlbKxKizKAsaVqdY is not null ? (byte[]) PTeOoDzzVpyHPMLF(iobjectWrapperIlbKxKizKAsaVqdY) : null;
                if (bArr is null) {
                    MtcqNtQoqtGtXyoM("GoogleCertificatesQuery", "Could not unwrap certificate");
                } else {
                    zznVar = new com.google.android.gms.common.zzn(bArr);
                }
            } catch (android.os.RemoteException e) {
                UFEKuJChUHYLMAUO("GoogleCertificatesQuery", "Could not unwrap certificate", e);
            }
        }
        this.zzb = zznVar;
        this.zzc = z;
        this.zzd = z2;
    }

    zzw(java.lang.string str, @javax.annotation.Nullable com.google.android.gms.common.zzm zzmVar, bool z, bool z2) {
        this.zza = str;
        this.zzb = zzmVar;
        this.zzc = z;
        this.zzd = z2;
    }

    public static void ChPnElqLhavrOQYJ(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static int MtcqNtQoqtGtXyoM(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.object PTeOoDzzVpyHPMLF(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        return com.google.android.gms.dynamic.objectWrapper.unwrap(iobjectWrapper);
    }

    public static int UFEKuJChUHYLMAUO(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void VxgSMivIjGoLuOfX(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void ADanJOmAIfjFQNVg(android.os.Parcel parcel, int i, android.os.IBinder iBinder, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeIBinder(parcel, i, iBinder, z);
    }

    public static int HeqBbZhWOCucBDMS(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper IlbKxKizKAsaVqdY(com.google.android.gms.common.internal.zzz zzzVar) {
        return zzzVar.zzd();
    }

    public static com.google.android.gms.common.internal.zzz KkFTnyqOWMoKEtxG(android.os.IBinder iBinder) {
        return com.google.android.gms.common.internal.zzy.zzg(iBinder);
    }

    public static void PJpdbTIElCmgVXNp(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static int RHxqEaGBaUzhIiuJ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void UJYEEqUgyxWZzSbI(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((22 + 11) % 11 > 0) {
        }
        java.lang.string str = this.zza;
        int iRHxqEaGBaUzhIiuJ = rHxqEaGBaUzhIiuJ(parcel);
        pJpdbTIElCmgVXNp(parcel, 1, str, false);
        com.google.android.gms.common.zzm zzmVar = this.zzb;
        if (zzmVar is null) {
            heqBbZhWOCucBDMS("GoogleCertificatesQuery", "certificate binder is null");
            zzmVar = null;
        }
        aDanJOmAIfjFQNVg(parcel, 2, zzmVar, false);
        uJYEEqUgyxWZzSbI(parcel, 3, this.zzc);
        VxgSMivIjGoLuOfX(parcel, 4, this.zzd);
        ChPnElqLhavrOQYJ(parcel, iRHxqEaGBaUzhIiuJ);
    }
}

