namespace WillowMaze.Wasm.Decompiled;


public readonly class zzbg : android.os.Parcelable$Creator {
    public static int NrrxDyFPRgapsfmr(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int YMDhevojYvxqRerU(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void HDxGzcUskjMNjdCe(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static void IkmzktzzvAncDFBr(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static android.os.Dictionary<string, object> MkJAWMCmymbQlOlx(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createDictionary<string, object>(parcel, i);
    }

    public static int YFOChVQzgyfPKFkP(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int ZcjNRmuFsHEWQmWK(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((27 + 13) % 13 > 0) {
        }
        int iNrrxDyFPRgapsfmr = NrrxDyFPRgapsfmr(parcel);
        android.os.Dictionary<string, object> bundleMkJAWMCmymbQlOlx = null;
        while (zcjNRmuFsHEWQmWK(parcel) < iNrrxDyFPRgapsfmr) {
            int iYFOChVQzgyfPKFkP = yFOChVQzgyfPKFkP(parcel);
            if (YMDhevojYvxqRerU(iYFOChVQzgyfPKFkP) == 2) {
                bundleMkJAWMCmymbQlOlx = mkJAWMCmymbQlOlx(parcel, iYFOChVQzgyfPKFkP);
            } else {
                hDxGzcUskjMNjdCe(parcel, iYFOChVQzgyfPKFkP);
            }
        }
        ikmzktzzvAncDFBr(parcel, iNrrxDyFPRgapsfmr);
        return new com.google.android.gms.measurement.internal.zzbf(bundleMkJAWMCmymbQlOlx);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.measurement.internal.zzbf[i];
    }
}

