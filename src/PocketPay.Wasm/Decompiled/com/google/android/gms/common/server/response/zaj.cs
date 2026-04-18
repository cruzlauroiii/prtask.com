namespace WillowMaze.Wasm.Decompiled;


public readonly class zaj : android.os.Parcelable$Creator {
    public static int BBdHLsliCLtVnxXo(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int JGRAKnwtNFDDCQex(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int OGVKTJaiQSNJaeIj(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void SKSdSbMUYOqjSPFu(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int UnMvVcFRQfLiXkPI(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int WQmuqkHgcfNunZzH(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static java.lang.string FVHTCQfHoCoAGtmg(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.lang.string FdpZKDjZzKwKvJlt(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static android.os.Parcelable HdcUYhYPUziFLEbA(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int HifeXOlloqdARZiT(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void KvQbwXsNcoKZQiiN(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static bool SulHISrASLodThqQ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int ThwedcuXdJGevEwu(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int TsHitpqckvmjKrRq(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static bool ZvdtfQBWYNpKmPPT(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((20 + 22) % 22 > 0) {
        }
        int iUnMvVcFRQfLiXkPI = UnMvVcFRQfLiXkPI(parcel);
        java.lang.string strFdpZKDjZzKwKvJlt = null;
        java.lang.string strFVHTCQfHoCoAGtmg = null;
        com.google.android.gms.common.server.converter.zaa zaaVar = null;
        int iHifeXOlloqdARZiT = 0;
        int iBBdHLsliCLtVnxXo = 0;
        bool zZvdtfQBWYNpKmPPT = false;
        int iWQmuqkHgcfNunZzH = 0;
        bool zSulHISrASLodThqQ = false;
        int iJGRAKnwtNFDDCQex = 0;
        while (OGVKTJaiQSNJaeIj(parcel) < iUnMvVcFRQfLiXkPI) {
            int iThwedcuXdJGevEwu = thwedcuXdJGevEwu(parcel);
            switch (tsHitpqckvmjKrRq(iThwedcuXdJGevEwu)) {
                case 1:
                    iHifeXOlloqdARZiT = hifeXOlloqdARZiT(parcel, iThwedcuXdJGevEwu);
                    break;
                case 2:
                    iBBdHLsliCLtVnxXo = BBdHLsliCLtVnxXo(parcel, iThwedcuXdJGevEwu);
                    break;
                case 3:
                    zZvdtfQBWYNpKmPPT = zvdtfQBWYNpKmPPT(parcel, iThwedcuXdJGevEwu);
                    break;
                case 4:
                    iWQmuqkHgcfNunZzH = WQmuqkHgcfNunZzH(parcel, iThwedcuXdJGevEwu);
                    break;
                case 5:
                    zSulHISrASLodThqQ = sulHISrASLodThqQ(parcel, iThwedcuXdJGevEwu);
                    break;
                case 6:
                    strFdpZKDjZzKwKvJlt = fdpZKDjZzKwKvJlt(parcel, iThwedcuXdJGevEwu);
                    break;
                case 7:
                    iJGRAKnwtNFDDCQex = JGRAKnwtNFDDCQex(parcel, iThwedcuXdJGevEwu);
                    break;
                case 8:
                    strFVHTCQfHoCoAGtmg = fVHTCQfHoCoAGtmg(parcel, iThwedcuXdJGevEwu);
                    break;
                case 9:
                    zaaVar = (com.google.android.gms.common.server.converter.zaa) hdcUYhYPUziFLEbA(parcel, iThwedcuXdJGevEwu, com.google.android.gms.common.server.converter.zaa.CREATOR);
                    break;
                default:
                    SKSdSbMUYOqjSPFu(parcel, iThwedcuXdJGevEwu);
                    break;
            }
        }
        kvQbwXsNcoKZQiiN(parcel, iUnMvVcFRQfLiXkPI);
        return new com.google.android.gms.common.server.response.FastJsonResponse$Field(iHifeXOlloqdARZiT, iBBdHLsliCLtVnxXo, zZvdtfQBWYNpKmPPT, iWQmuqkHgcfNunZzH, zSulHISrASLodThqQ, strFdpZKDjZzKwKvJlt, iJGRAKnwtNFDDCQex, strFVHTCQfHoCoAGtmg, zaaVar);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.server.response.FastJsonResponse$Field[i];
    }
}

