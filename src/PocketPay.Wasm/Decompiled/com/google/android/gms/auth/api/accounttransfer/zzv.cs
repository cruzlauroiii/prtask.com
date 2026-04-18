namespace WillowMaze.Wasm.Decompiled;


public readonly class zzv : android.os.Parcelable$Creator {
    public static java.lang.int CRhrMocvaeVIqvHv(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int ElEGeozZYASkJXZV(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static android.os.Parcelable FyRhNETDTYVFpKpI(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int IkRsuHjhsoMwzePB(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static bool KuBXwTkANgeUcbPO(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.lang.string KzMfBNAeHWUkdoyS(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int LeYdAZpTcCtPvIBk(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static bool SIFJTfurwJhPyeDW(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static int TYjnSTSjRYGuXjYW(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static bool ZmkitOXXmmKbZtwI(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static int GmwpRHHfUqbLunpS(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static bool KPJxhiQMcqTxdtmZ(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.lang.int KVQyJnXoVxtqFuwm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string NwksOXCfSqmKNGiW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder OWuvKJnEbaJKMhhi(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.int OsmQPPWbsTVmcxyL(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int QQApOcYCLernQuWr(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int SDpvmQPENeuBXuEf(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static bool SEDZtiFIkIgPYkUO(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.lang.string TeNjHMTKyfJJBYZf(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.lang.string VbDSkETFECzlupvG(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.lang.int XZeCJTGcyOEihkLN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void XmuTHFsZFIolcUcg(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((18 + 22) % 22 > 0) {
        }
        int iLeYdAZpTcCtPvIBk = LeYdAZpTcCtPvIBk(parcel);
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        int iElEGeozZYASkJXZV = 0;
        com.google.android.gms.auth.api.accounttransfer.zzw zzwVar = null;
        java.lang.string strVbDSkETFECzlupvG = null;
        java.lang.string strKzMfBNAeHWUkdoyS = null;
        java.lang.string strTeNjHMTKyfJJBYZf = null;
        while (gmwpRHHfUqbLunpS(parcel) < iLeYdAZpTcCtPvIBk) {
            int iIkRsuHjhsoMwzePB = IkRsuHjhsoMwzePB(parcel);
            int iTYjnSTSjRYGuXjYW = TYjnSTSjRYGuXjYW(iIkRsuHjhsoMwzePB);
            if (iTYjnSTSjRYGuXjYW == 1) {
                iElEGeozZYASkJXZV = ElEGeozZYASkJXZV(parcel, iIkRsuHjhsoMwzePB);
                ZmkitOXXmmKbZtwI(hashHashSet, CRhrMocvaeVIqvHv(1));
            } else if (iTYjnSTSjRYGuXjYW == 2) {
                zzwVar = (com.google.android.gms.auth.api.accounttransfer.zzw) FyRhNETDTYVFpKpI(parcel, iIkRsuHjhsoMwzePB, com.google.android.gms.auth.api.accounttransfer.zzw.CREATOR);
                kPJxhiQMcqTxdtmZ(hashHashSet, xZeCJTGcyOEihkLN(2));
            } else if (iTYjnSTSjRYGuXjYW == 3) {
                strVbDSkETFECzlupvG = vbDSkETFECzlupvG(parcel, iIkRsuHjhsoMwzePB);
                sEDZtiFIkIgPYkUO(hashHashSet, kVQyJnXoVxtqFuwm(3));
            } else if (iTYjnSTSjRYGuXjYW == 4) {
                strKzMfBNAeHWUkdoyS = KzMfBNAeHWUkdoyS(parcel, iIkRsuHjhsoMwzePB);
                SIFJTfurwJhPyeDW(hashHashSet, osmQPPWbsTVmcxyL(4));
            } else if (iTYjnSTSjRYGuXjYW == 5) {
                strTeNjHMTKyfJJBYZf = teNjHMTKyfJJBYZf(parcel, iIkRsuHjhsoMwzePB);
                KuBXwTkANgeUcbPO(hashHashSet, qQApOcYCLernQuWr(5));
            } else {
                xmuTHFsZFIolcUcg(parcel, iIkRsuHjhsoMwzePB);
            }
        }
        if (sDpvmQPENeuBXuEf(parcel) == iLeYdAZpTcCtPvIBk) {
            return new com.google.android.gms.auth.api.accounttransfer.zzu(hashHashSet, iElEGeozZYASkJXZV, zzwVar, strVbDSkETFECzlupvG, strKzMfBNAeHWUkdoyS, strTeNjHMTKyfJJBYZf);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Overread allowed size end=");
        oWuvKJnEbaJKMhhi(sb, iLeYdAZpTcCtPvIBk);
        throw new com.google.android.gms.common.internal.safeparcel.SafeParcelReader$ParseException(nwksOXCfSqmKNGiW(sb), parcel);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.accounttransfer.zzu[i];
    }
}

