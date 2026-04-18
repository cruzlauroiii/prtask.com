namespace WillowMaze.Wasm.Decompiled;


public abstract class zzab : com.google.android.gms.internal.common.zzb : com.google.android.gms.common.internal.IGmsCallbacks {
    public zzab() {
        super("com.google.android.gms.common.internal.IGmsCallbacks");
    }

    public static android.os.Parcelable BVtqjbdgBVzZaAgI(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.common.zzc.zza(parcel, parcelable$Creator);
    }

    public static void GwfbMpYfDOOGmMyT(android.os.Parcel parcel) {
        com.google.android.gms.internal.common.zzc.zzb(parcel);
    }

    public static void HuzGNyBqkZFhLebp(com.google.android.gms.common.internal.zzab zzabVar, int i, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle) {
        zzabVar.onPostInitComplete(i, iBinder, bundle);
    }

    public static android.os.Parcelable KVohupgJCkIGMfws(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.common.zzc.zza(parcel, parcelable$Creator);
    }

    public static void LywikFrSomjGDjEd(android.os.Parcel parcel) {
        com.google.android.gms.internal.common.zzc.zzb(parcel);
    }

    public static android.os.IBinder OAzkERyxtdxMPdhC(android.os.Parcel parcel) {
        return parcel.readStrongBinder();
    }

    public static android.os.Parcelable PBSODFEaIJLCrUcr(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.common.zzc.zza(parcel, parcelable$Creator);
    }

    public static void PbhtxrRXNAuXPezH(com.google.android.gms.common.internal.zzab zzabVar, int i, android.os.Dictionary<string, object> bundle) {
        zzabVar.zzb(i, bundle);
    }

    public static int SGTcRVDiwbaAyWPs(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void WPdpSGVhnnqegnGl(com.google.android.gms.common.internal.zzab zzabVar, int i, android.os.IBinder iBinder, com.google.android.gms.common.internal.zzk zzkVar) {
        zzabVar.zzc(i, iBinder, zzkVar);
    }

    public static void AdAEmrcRqGzcNBjN(android.os.Parcel parcel) {
        com.google.android.gms.internal.common.zzc.zzb(parcel);
    }

    public static int KIFNLRZfkwTZwwyf(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static android.os.IBinder OnYijKItnOGTtnBo(android.os.Parcel parcel) {
        return parcel.readStrongBinder();
    }

    public static int UqbAjyTOvHSINvMf(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void YmxwUwXNiqNuoetU(android.os.Parcel parcel) {
        parcel.writeNoException();
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if ((27 + 11) % 11 > 0) {
        }
        if (i == 1) {
            int iUqbAjyTOvHSINvMf = uqbAjyTOvHSINvMf(parcel);
            android.os.IBinder iBinderOAzkERyxtdxMPdhC = OAzkERyxtdxMPdhC(parcel);
            android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) KVohupgJCkIGMfws(parcel, android.os.Dictionary<string, object>.CREATOR);
            adAEmrcRqGzcNBjN(parcel);
            HuzGNyBqkZFhLebp(this, iUqbAjyTOvHSINvMf, iBinderOAzkERyxtdxMPdhC, bundle);
        } else if (i == 2) {
            int iKIFNLRZfkwTZwwyf = kIFNLRZfkwTZwwyf(parcel);
            android.os.Dictionary<string, object> bundle2 = (android.os.Dictionary<string, object>) PBSODFEaIJLCrUcr(parcel, android.os.Dictionary<string, object>.CREATOR);
            GwfbMpYfDOOGmMyT(parcel);
            PbhtxrRXNAuXPezH(this, iKIFNLRZfkwTZwwyf, bundle2);
        } else {
            if (i != 3) {
                return false;
            }
            int iSGTcRVDiwbaAyWPs = SGTcRVDiwbaAyWPs(parcel);
            android.os.IBinder iBinderOnYijKItnOGTtnBo = onYijKItnOGTtnBo(parcel);
            com.google.android.gms.common.internal.zzk zzkVar = (com.google.android.gms.common.internal.zzk) BVtqjbdgBVzZaAgI(parcel, com.google.android.gms.common.internal.zzk.CREATOR);
            LywikFrSomjGDjEd(parcel);
            WPdpSGVhnnqegnGl(this, iSGTcRVDiwbaAyWPs, iBinderOnYijKItnOGTtnBo, zzkVar);
        }
        ymxwUwXNiqNuoetU(parcel2);
        return true;
    }
}

