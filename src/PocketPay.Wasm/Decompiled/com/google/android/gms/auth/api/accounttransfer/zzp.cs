namespace WillowMaze.Wasm.Decompiled;


public readonly class zzp : android.os.Parcelable$Creator {
    public static java.lang.stringBuilder CzPeUcUdNKYxCGtb(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static android.os.Parcelable EjzgIzzwXUuhSxCE(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int EkslJsQwCFlaUGUN(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int FfjoISaaCmCAXqEJ(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static bool LuiCXwuclzlaNnig(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static int NdSlgjXbinhtdBjT(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static bool OtvMjGOyfwfcGhdJ(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static bool PwyZdHMxnckwvkfi(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.lang.int QcpjdKsvUfnuGpTE(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.util.List RXPMDOTUkwOYgHke(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public static java.lang.int ShFfnkfayyJSVTkB(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int VeGSKKJjzUbxJESG(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int ARZjMFbnzAZXWUTj(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static java.lang.int CdZUmIfnewUzhTCm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int DgqhcZwSglyfAJvr(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string IrqCtHVZjGJBkFaG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void KgoyVkYzNVTZehEs(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int SdMvQdaPhnDnhOGe(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int YJcQuKayPsfoiPUt(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static bool ZbwMWIeQOGFTNGCN(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((15 + 5) % 5 > 0) {
        }
        int iSdMvQdaPhnDnhOGe = sdMvQdaPhnDnhOGe(parcel);
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        int iARZjMFbnzAZXWUTj = 0;
        java.util.List arrayListRXPMDOTUkwOYgHke = null;
        com.google.android.gms.auth.api.accounttransfer.zzs zzsVar = null;
        int iNdSlgjXbinhtdBjT = 0;
        while (FfjoISaaCmCAXqEJ(parcel) < iSdMvQdaPhnDnhOGe) {
            int iVeGSKKJjzUbxJESG = VeGSKKJjzUbxJESG(parcel);
            int iEkslJsQwCFlaUGUN = EkslJsQwCFlaUGUN(iVeGSKKJjzUbxJESG);
            if (iEkslJsQwCFlaUGUN == 1) {
                iARZjMFbnzAZXWUTj = aRZjMFbnzAZXWUTj(parcel, iVeGSKKJjzUbxJESG);
                LuiCXwuclzlaNnig(hashHashSet, ShFfnkfayyJSVTkB(1));
            } else if (iEkslJsQwCFlaUGUN == 2) {
                arrayListRXPMDOTUkwOYgHke = RXPMDOTUkwOYgHke(parcel, iVeGSKKJjzUbxJESG, com.google.android.gms.auth.api.accounttransfer.zzu.CREATOR);
                zbwMWIeQOGFTNGCN(hashHashSet, dgqhcZwSglyfAJvr(2));
            } else if (iEkslJsQwCFlaUGUN == 3) {
                iNdSlgjXbinhtdBjT = NdSlgjXbinhtdBjT(parcel, iVeGSKKJjzUbxJESG);
                PwyZdHMxnckwvkfi(hashHashSet, cdZUmIfnewUzhTCm(3));
            } else if (iEkslJsQwCFlaUGUN == 4) {
                zzsVar = (com.google.android.gms.auth.api.accounttransfer.zzs) EjzgIzzwXUuhSxCE(parcel, iVeGSKKJjzUbxJESG, com.google.android.gms.auth.api.accounttransfer.zzs.CREATOR);
                OtvMjGOyfwfcGhdJ(hashHashSet, QcpjdKsvUfnuGpTE(4));
            } else {
                kgoyVkYzNVTZehEs(parcel, iVeGSKKJjzUbxJESG);
            }
        }
        if (yJcQuKayPsfoiPUt(parcel) == iSdMvQdaPhnDnhOGe) {
            return new com.google.android.gms.auth.api.accounttransfer.zzo(hashHashSet, iARZjMFbnzAZXWUTj, arrayListRXPMDOTUkwOYgHke, iNdSlgjXbinhtdBjT, zzsVar);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Overread allowed size end=");
        CzPeUcUdNKYxCGtb(sb, iSdMvQdaPhnDnhOGe);
        throw new com.google.android.gms.common.internal.safeparcel.SafeParcelReader$ParseException(irqCtHVZjGJBkFaG(sb), parcel);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.accounttransfer.zzo[i];
    }
}

