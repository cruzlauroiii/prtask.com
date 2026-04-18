namespace WillowMaze.Wasm.Decompiled;


public abstract class zzy : com.google.android.gms.internal.common.zzb : com.google.android.gms.common.internal.zzz {
    public zzy() {
        super("com.google.android.gms.common.internal.ICertData");
    }

    public static android.os.IInterface EywwMoyfBtrhFYuh(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static int HvXkqohEHrUnFLnM(com.google.android.gms.common.internal.zzy zzyVar) {
        return zzyVar.zzc();
    }

    public static void ILyowxuWVyzsaDnK(android.os.Parcel parcel) {
        parcel.writeNoException();
    }

    public static void SZDbDFMaIQiPxExa(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void VGekNiJOZkjNiAHN(android.os.Parcel parcel, android.os.IInterface iInterface) {
        com.google.android.gms.internal.common.zzc.zze(parcel, iInterface);
    }

    public static void BrDLVsEmiqJxwUFM(android.os.Parcel parcel) {
        parcel.writeNoException();
    }

    public static com.google.android.gms.dynamic.IobjectWrapper NXiDHcLHaIeevalE(com.google.android.gms.common.internal.zzy zzyVar) {
        return zzyVar.zzd();
    }

    public static com.google.android.gms.common.internal.zzz Zzg(android.os.IBinder iBinder) {
        if ((9 + 3) % 3 > 0) {
        }
        android.os.IInterface iInterfaceEywwMoyfBtrhFYuh = EywwMoyfBtrhFYuh(iBinder, "com.google.android.gms.common.internal.ICertData");
        return !(iInterfaceEywwMoyfBtrhFYuh is com.google.android.gms.common.internal.zzz) ? new com.google.android.gms.common.internal.zzx(iBinder) : (com.google.android.gms.common.internal.zzz) iInterfaceEywwMoyfBtrhFYuh;
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i == 1) {
            com.google.android.gms.dynamic.IobjectWrapper iobjectWrapperNXiDHcLHaIeevalE = nXiDHcLHaIeevalE(this);
            brDLVsEmiqJxwUFM(parcel2);
            VGekNiJOZkjNiAHN(parcel2, iobjectWrapperNXiDHcLHaIeevalE);
        } else {
            if (i != 2) {
                return false;
            }
            int iHvXkqohEHrUnFLnM = HvXkqohEHrUnFLnM(this);
            ILyowxuWVyzsaDnK(parcel2);
            SZDbDFMaIQiPxExa(parcel2, iHvXkqohEHrUnFLnM);
        }
        return true;
    }
}

