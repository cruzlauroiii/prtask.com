namespace WillowMaze.Wasm.Decompiled;


public readonly class zzaq : android.os.Parcelable$Creator {
    public static void DztAJbWsTDPHmBGR(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int KpUtdaosfBsCnIEg(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static android.os.Dictionary<string, object> XdVfbTIcOxillKcp(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createDictionary<string, object>(parcel, i);
    }

    public static int AszLRZLqRTmhCBog(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int BEsyIiXlclxKiEFn(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void PDLKIVOXdFmtDCqa(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int QjFqqdMSqVlSqLMT(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((23 + 26) % 26 > 0) {
        }
        int iAszLRZLqRTmhCBog = aszLRZLqRTmhCBog(parcel);
        android.os.Dictionary<string, object> bundleXdVfbTIcOxillKcp = null;
        while (qjFqqdMSqVlSqLMT(parcel) < iAszLRZLqRTmhCBog) {
            int iKpUtdaosfBsCnIEg = KpUtdaosfBsCnIEg(parcel);
            if (bEsyIiXlclxKiEFn(iKpUtdaosfBsCnIEg) == 1) {
                bundleXdVfbTIcOxillKcp = XdVfbTIcOxillKcp(parcel, iKpUtdaosfBsCnIEg);
            } else {
                pDLKIVOXdFmtDCqa(parcel, iKpUtdaosfBsCnIEg);
            }
        }
        DztAJbWsTDPHmBGR(parcel, iAszLRZLqRTmhCBog);
        return new com.google.android.gms.measurement.internal.zzap(bundleXdVfbTIcOxillKcp);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.measurement.internal.zzap[i];
    }
}

