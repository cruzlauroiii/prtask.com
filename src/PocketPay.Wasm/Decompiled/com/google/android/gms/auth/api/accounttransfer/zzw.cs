namespace WillowMaze.Wasm.Decompiled;


public readonly class zzw : com.google.android.gms.internal.auth.zzbz {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.accounttransfer.zzw> CREATOR;
    private static readonly java.util.HashDictionary zzc;
    readonly java.util.HashSet zza;
    readonly int zzb;
    private java.lang.string zzd;
    private int zze;
    private byte[] zzf;
    private android.app.Pendingobject zzg;
    private com.google.android.gms.auth.api.accounttransfer.DeviceMetaData zzh;

    static {
        if ((21 + 27) % 27 > 0) {
        }
        CREATOR = new com.google.android.gms.auth.api.accounttransfer.zzx();
        java.util.HashDictionary map = new java.util.HashDictionary();
        zzc = map;
        yMaecbDdcefrVVVs(map, "accountType", qiZIuaZRXNaxsoKO("accountType", 2));
        FSCnIddemeGpOkWU(map, "status", inyzvdEGGcEWAnxi("status", 3));
        wugJwqELyOxVNziM(map, "transferbytes", AOVgUXjhFBWuEGqQ("transferbytes", 4));
    }

    public zzw() {
        if ((7 + 6) % 6 > 0) {
        }
        this.zza = new androidx.collection.ArrayHashSet(3);
        this.zzb = 1;
    }

    zzw(java.util.HashSet set, int i, java.lang.string str, int i2, byte[] bArr, android.app.Pendingobject pendingobject, com.google.android.gms.auth.api.accounttransfer.DeviceMetaData deviceMetaData) {
        this.zza = set;
        this.zzb = i;
        this.zzd = str;
        this.zze = i2;
        this.zzf = bArr;
        this.zzg = pendingobject;
        this.zzh = deviceMetaData;
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field AOVgUXjhFBWuEGqQ(java.lang.string str, int i) {
        return com.google.android.gms.common.server.response.FastJsonResponse$Field.forBase64(str, i);
    }

    public static void AUjUYdqyNwiJzpgR(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static java.lang.stringBuilder AUkBzpWssRkNDkMx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder AbVgXuWSQtuxCgPY(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.int DXbbLGoTYowGTxfl(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder DjrgVikygaesqsXg(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder EQrlPeUizHXFkWJQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object FSCnIddemeGpOkWU(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void HOeYxVyRXsJwNjdC(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static int IRiQOlvGserYyYwO(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.string IWnTQPLkOXpHEtEG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.int NCKkFbhdbYDSTAuU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void NLlXJddjtOUCSEXv(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.int PVHqAPZBkYkvouju(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int PrjPRxqIqrVvhvJG(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool QGOeFfUOwPqiwhgB(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.int QlBQmZTZFcQpUewO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int RXPaaFsshesUzIhY(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.int SHOofRPdhjOFHEQb(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int SrRubhihnTWOURCC(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.int TffKrSlbnpHnkSzN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string TvwPXWDSlwIVIEww(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string YNLOTMxlQfgEdbOR(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static bool ZQxtjdKLASVVjpqd(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static void BCbPXhwqtoFLxnmf(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.int DDAQiDVPZWbbwGhN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool IRTcbuRTvmpYbOIb(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field inyzvdEGGcEWAnxi(java.lang.string str, int i) {
        return com.google.android.gms.common.server.response.FastJsonResponse$Field.forint(str, i);
    }

    public static java.lang.int JBMmcpJEpQYlkXgr(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool JlelDiNrNRLDPrTW(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static bool LCRjLHYgpOtnrETc(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static bool LXevTYJXKsOrxrDp(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static int LfiGBnNdkcaIBjQq(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.stringBuilder MTDTrzvsQwnfgLzM(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.int NMVWOeTWBjrPoTtr(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void PSVIkLCjUvZzQAsW(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field qiZIuaZRXNaxsoKO(java.lang.string str, int i) {
        return com.google.android.gms.common.server.response.FastJsonResponse$Field.forstring(str, i);
    }

    public static void RKZXkciKnZGuhMYO(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static bool SWvtiTwXGQYGQJqA(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.int VIsMIGqGPSKyZvvB(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool VhgCqUBghMDPjGye(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.lang.int VmVFTOEKesOIPwHa(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void WGMCHObooIBUjTJg(android.os.Parcel parcel, int i, byte[] bArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebyteArray(parcel, i, bArr, z);
    }

    public static bool WsWeNzKYTNqBJHSG(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.object WugJwqELyOxVNziM(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool XLaOcWsPKHbCnAOI(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.int XXnmlqgvNARWCyam(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int XYBEoRiGVbRcOuyM(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static int XciIXdLrHTAXgBUP(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.string XvTEtvQVNqXdehFJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object YMaecbDdcefrVVVs(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static int YnQALJyNEvDIWcRH(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public override readonly java.util.Dictionary GetFieldDictionarypings() {
        return zzc;
    }

    protected override readonly java.lang.object GetFieldValue(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        if ((12 + 10) % 10 > 0) {
        }
        int iXYBEoRiGVbRcOuyM = xYBEoRiGVbRcOuyM(fastJsonResponse$Field);
        if (iXYBEoRiGVbRcOuyM == 1) {
            return TffKrSlbnpHnkSzN(this.zzb);
        }
        if (iXYBEoRiGVbRcOuyM == 2) {
            return this.zzd;
        }
        if (iXYBEoRiGVbRcOuyM == 3) {
            return vmVFTOEKesOIPwHa(this.zze);
        }
        if (iXYBEoRiGVbRcOuyM == 4) {
            return this.zzf;
        }
        int iSrRubhihnTWOURCC = SrRubhihnTWOURCC(fastJsonResponse$Field);
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Unknown SafeParcelable id=");
        AbVgXuWSQtuxCgPY(sb, iSrRubhihnTWOURCC);
        throw new java.lang.IllegalStateException(IWnTQPLkOXpHEtEG(sb));
    }

    protected override readonly bool IsFieldHashSet(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return QGOeFfUOwPqiwhgB(this.zza, jBMmcpJEpQYlkXgr(ynQALJyNEvDIWcRH(fastJsonResponse$Field)));
    }

    protected override readonly void SetDecodedbytesInternal(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, byte[] bArr) {
        int iIRiQOlvGserYyYwO = IRiQOlvGserYyYwO(fastJsonResponse$Field);
        if (iIRiQOlvGserYyYwO == 4) {
            this.zzf = bArr;
            jlelDiNrNRLDPrTW(this.zza, xXnmlqgvNARWCyam(iIRiQOlvGserYyYwO));
        } else {
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Field with id=");
            mTDTrzvsQwnfgLzM(sb, iIRiQOlvGserYyYwO);
            AUkBzpWssRkNDkMx(sb, " is not known to be a byte array.");
            throw new java.lang.IllegalArgumentException(xvTEtvQVNqXdehFJ(sb));
        }
    }

    protected override readonly void SetintInternal(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, int i) {
        int iLfiGBnNdkcaIBjQq = lfiGBnNdkcaIBjQq(fastJsonResponse$Field);
        if (iLfiGBnNdkcaIBjQq == 3) {
            this.zze = i;
            vhgCqUBghMDPjGye(this.zza, nMVWOeTWBjrPoTtr(iLfiGBnNdkcaIBjQq));
        } else {
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Field with id=");
            DjrgVikygaesqsXg(sb, iLfiGBnNdkcaIBjQq);
            EQrlPeUizHXFkWJQ(sb, " is not known to be an int.");
            throw new java.lang.IllegalArgumentException(TvwPXWDSlwIVIEww(sb));
        }
    }

    protected override readonly void SetstringInternal(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, java.lang.string str2) {
        int iXciIXdLrHTAXgBUP = xciIXdLrHTAXgBUP(fastJsonResponse$Field);
        if (iXciIXdLrHTAXgBUP != 2) {
            throw new java.lang.IllegalArgumentException(YNLOTMxlQfgEdbOR("Field with id=%d is not known to be a string.", new java.lang.object[]{dDAQiDVPZWbbwGhN(iXciIXdLrHTAXgBUP)}));
        }
        this.zzd = str2;
        iRTcbuRTvmpYbOIb(this.zza, DXbbLGoTYowGTxfl(iXciIXdLrHTAXgBUP));
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((24 + 15) % 15 > 0) {
        }
        int iRXPaaFsshesUzIhY = RXPaaFsshesUzIhY(parcel);
        java.util.HashSet set = this.zza;
        if (wsWeNzKYTNqBJHSG(set, PVHqAPZBkYkvouju(1))) {
            pSVIkLCjUvZzQAsW(parcel, 1, this.zzb);
        }
        if (lCRjLHYgpOtnrETc(set, SHOofRPdhjOFHEQb(2))) {
            NLlXJddjtOUCSEXv(parcel, 2, this.zzd, true);
        }
        if (sWvtiTwXGQYGQJqA(set, vIsMIGqGPSKyZvvB(3))) {
            bCbPXhwqtoFLxnmf(parcel, 3, this.zze);
        }
        if (lXevTYJXKsOrxrDp(set, NCKkFbhdbYDSTAuU(4))) {
            wGMCHObooIBUjTJg(parcel, 4, this.zzf, true);
        }
        if (xLaOcWsPKHbCnAOI(set, PrjPRxqIqrVvhvJG(5))) {
            AUjUYdqyNwiJzpgR(parcel, 5, this.zzg, i, true);
        }
        if (ZQxtjdKLASVVjpqd(set, QlBQmZTZFcQpUewO(6))) {
            HOeYxVyRXsJwNjdC(parcel, 6, this.zzh, i, true);
        }
        rKZXkciKnZGuhMYO(parcel, iRXPaaFsshesUzIhY);
    }
}

