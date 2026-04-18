namespace WillowMaze.Wasm.Decompiled;


public readonly class zah : android.os.Parcelable$Creator {
    public static int FwGaYxhVUoCUeVOY(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int JIyzqbdQalkcvPNx(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int MzCYApkhHiYeeqWg(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void PjkWpipSvQLLxyiq(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static android.os.Parcelable RKoDIFGkBITupDBO(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int XsnZSmNzDmufefmZ(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int KnOaniaMOwRujOQu(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int TvCdbYBZpwxgwOBY(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void UsztZkIRCTtOomfn(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int VdjPXDNLtCGeiYuB(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((27 + 3) % 3 > 0) {
        }
        int iMzCYApkhHiYeeqWg = MzCYApkhHiYeeqWg(parcel);
        int iTvCdbYBZpwxgwOBY = 0;
        int iKnOaniaMOwRujOQu = 0;
        android.net.Uri uri = null;
        int iVdjPXDNLtCGeiYuB = 0;
        while (XsnZSmNzDmufefmZ(parcel) < iMzCYApkhHiYeeqWg) {
            int iJIyzqbdQalkcvPNx = JIyzqbdQalkcvPNx(parcel);
            int iFwGaYxhVUoCUeVOY = FwGaYxhVUoCUeVOY(iJIyzqbdQalkcvPNx);
            if (iFwGaYxhVUoCUeVOY == 1) {
                iTvCdbYBZpwxgwOBY = tvCdbYBZpwxgwOBY(parcel, iJIyzqbdQalkcvPNx);
            } else if (iFwGaYxhVUoCUeVOY == 2) {
                uri = (android.net.Uri) RKoDIFGkBITupDBO(parcel, iJIyzqbdQalkcvPNx, android.net.Uri.CREATOR);
            } else if (iFwGaYxhVUoCUeVOY == 3) {
                iVdjPXDNLtCGeiYuB = vdjPXDNLtCGeiYuB(parcel, iJIyzqbdQalkcvPNx);
            } else if (iFwGaYxhVUoCUeVOY == 4) {
                iKnOaniaMOwRujOQu = knOaniaMOwRujOQu(parcel, iJIyzqbdQalkcvPNx);
            } else {
                usztZkIRCTtOomfn(parcel, iJIyzqbdQalkcvPNx);
            }
        }
        PjkWpipSvQLLxyiq(parcel, iMzCYApkhHiYeeqWg);
        return new com.google.android.gms.common.images.WebImage(iTvCdbYBZpwxgwOBY, uri, iVdjPXDNLtCGeiYuB, iKnOaniaMOwRujOQu);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.images.WebImage[i];
    }
}

