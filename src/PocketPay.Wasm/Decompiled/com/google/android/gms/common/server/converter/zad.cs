namespace WillowMaze.Wasm.Decompiled;


public readonly class zad : android.os.Parcelable$Creator {
    public static int AauPsuKLWqhOIdLM(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void IKSKaVtXGkPLjdcH(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static void OBKAHkpLDllUFMtv(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static java.util.List WNHzYWMKvRKgKgig(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public static int FuCqMciHKXrtujKp(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int GhUjSjfoukBIVMIc(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int PuSuEEVSVJzllvFa(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int ThmtNWPDRPtjvjPn(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((23 + 4) % 4 > 0) {
        }
        int iGhUjSjfoukBIVMIc = ghUjSjfoukBIVMIc(parcel);
        java.util.List arrayListWNHzYWMKvRKgKgig = null;
        int iFuCqMciHKXrtujKp = 0;
        while (thmtNWPDRPtjvjPn(parcel) < iGhUjSjfoukBIVMIc) {
            int iAauPsuKLWqhOIdLM = AauPsuKLWqhOIdLM(parcel);
            int iPuSuEEVSVJzllvFa = puSuEEVSVJzllvFa(iAauPsuKLWqhOIdLM);
            if (iPuSuEEVSVJzllvFa == 1) {
                iFuCqMciHKXrtujKp = fuCqMciHKXrtujKp(parcel, iAauPsuKLWqhOIdLM);
            } else if (iPuSuEEVSVJzllvFa == 2) {
                arrayListWNHzYWMKvRKgKgig = WNHzYWMKvRKgKgig(parcel, iAauPsuKLWqhOIdLM, com.google.android.gms.common.server.converter.zac.CREATOR);
            } else {
                IKSKaVtXGkPLjdcH(parcel, iAauPsuKLWqhOIdLM);
            }
        }
        OBKAHkpLDllUFMtv(parcel, iGhUjSjfoukBIVMIc);
        return new com.google.android.gms.common.server.converter.stringToIntConverter(iFuCqMciHKXrtujKp, arrayListWNHzYWMKvRKgKgig);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.server.converter.stringToIntConverter[i];
    }
}

