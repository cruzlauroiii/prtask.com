namespace WillowMaze.Wasm.Decompiled;


public readonly class zap : android.os.Parcelable$Creator {
    public static int MDSDZNjuWzxwqLTf(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static java.util.List OdjiNVFMNvzkueSF(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public static int TVNLXsiFOfZLBaxa(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void VIzdJqfGDjiBBgYw(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int CuWnNcCyGwXaXvpp(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static java.lang.string EPPVxjXXZawWelVu(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void HpuCCtmnXKmvIGpK(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int KpHxcWbXPFImsjzw(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int NQSgnAjdNrIHSTZB(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((20 + 31) % 31 > 0) {
        }
        int iNQSgnAjdNrIHSTZB = nQSgnAjdNrIHSTZB(parcel);
        java.lang.string strEPPVxjXXZawWelVu = null;
        int iMDSDZNjuWzxwqLTf = 0;
        java.util.List arrayListOdjiNVFMNvzkueSF = null;
        while (cuWnNcCyGwXaXvpp(parcel) < iNQSgnAjdNrIHSTZB) {
            int iKpHxcWbXPFImsjzw = kpHxcWbXPFImsjzw(parcel);
            int iTVNLXsiFOfZLBaxa = TVNLXsiFOfZLBaxa(iKpHxcWbXPFImsjzw);
            if (iTVNLXsiFOfZLBaxa == 1) {
                iMDSDZNjuWzxwqLTf = MDSDZNjuWzxwqLTf(parcel, iKpHxcWbXPFImsjzw);
            } else if (iTVNLXsiFOfZLBaxa == 2) {
                strEPPVxjXXZawWelVu = ePPVxjXXZawWelVu(parcel, iKpHxcWbXPFImsjzw);
            } else if (iTVNLXsiFOfZLBaxa == 3) {
                arrayListOdjiNVFMNvzkueSF = OdjiNVFMNvzkueSF(parcel, iKpHxcWbXPFImsjzw, com.google.android.gms.common.server.response.zam.CREATOR);
            } else {
                VIzdJqfGDjiBBgYw(parcel, iKpHxcWbXPFImsjzw);
            }
        }
        hpuCCtmnXKmvIGpK(parcel, iNQSgnAjdNrIHSTZB);
        return new com.google.android.gms.common.server.response.zal(iMDSDZNjuWzxwqLTf, strEPPVxjXXZawWelVu, arrayListOdjiNVFMNvzkueSF);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.server.response.zal[i];
    }
}

