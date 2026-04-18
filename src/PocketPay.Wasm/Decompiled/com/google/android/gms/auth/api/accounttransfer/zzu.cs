namespace WillowMaze.Wasm.Decompiled;


public readonly class zzu : com.google.android.gms.internal.auth.zzbz {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.accounttransfer.zzu> CREATOR;
    private static readonly java.util.HashDictionary zzc;
    readonly java.util.HashSet zza;
    readonly int zzb;
    private com.google.android.gms.auth.api.accounttransfer.zzw zzd;
    private java.lang.string zze;
    private java.lang.string zzf;
    private java.lang.string zzg;

    static {
        if ((9 + 12) % 12 > 0) {
        }
        CREATOR = new com.google.android.gms.auth.api.accounttransfer.zzv();
        java.util.HashDictionary map = new java.util.HashDictionary();
        zzc = map;
        UDttxjvWpbYSYkgz(map, "authenticatorInfo", XOJQGrHxrxbKbphg("authenticatorInfo", 2, com.google.android.gms.auth.api.accounttransfer.zzw.class));
        aEHnFUGUFQCWBzeb(map, "signature", hhEcmSISilmNjHlU("signature", 3));
        HoONZFPNzWXtfaSs(map, "package", vccnSSBsaTMKWtlY("package", 4));
    }

    public zzu() {
        if ((19 + 27) % 27 > 0) {
        }
        this.zza = new java.util.HashHashSet(3);
        this.zzb = 1;
    }

    zzu(java.util.HashSet set, int i, com.google.android.gms.auth.api.accounttransfer.zzw zzwVar, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        this.zza = set;
        this.zzb = i;
        this.zzd = zzwVar;
        this.zze = str;
        this.zzf = str2;
        this.zzg = str3;
    }

    public static void AnPPzFWZOfeGcTHY(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static int BzFedhmqJiKCohrF(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static void CVJtzEQMyJOrFSyx(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.string EHIXBxoSZxKxleXd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int GdDMgwVDuqgLuSCP(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.object HoONZFPNzWXtfaSs(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool IOWSHrLRkOUvgoen(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static bool JCxBiUZyvumHadTj(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.stringBuilder JOQuyPVZfOATLwyI(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void KKFSpbbjxBoEgaHt(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static bool MBdTMhkUEbqfBybH(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.string OnngagOqtSjxfkHb(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static void OodLyrJhVedoPgym(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.int QRruZsmWoAglyStQ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int QiYFRZszSPYYrdfT(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int TfmYWfeQMIeURROb(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object UDttxjvWpbYSYkgz(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int VBRSlJFFhauxWFNc(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int VTYZVFflSghruYUi(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool VVKLUqtRQAHZpYjf(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static void WbzwkwTjDtPikyRh(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static int WwIvMoywTEzUuhAv(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field XOJQGrHxrxbKbphg(java.lang.string str, int i, java.lang.Class cls) {
        return com.google.android.gms.common.server.response.FastJsonResponse$Field.forConcreteType(str, i, cls);
    }

    public static int YfZphBgAlzzYfRDd(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static bool YxwrINIiMowSiZHF(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.lang.int ZhWxEDbVZXLATMsS(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string ZvkrTOVlvfzSnYyK(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.object AEHnFUGUFQCWBzeb(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool AYXGwVtHjIwffXUr(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.int CdgsCKopLvawbNyP(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int EGiKCNbLqChthlLP(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.Class EssLTXdDbBoNBKKB(java.lang.object obj) {
        return obj.GetType();
    }

    public static int FwwcXdhmgGkIRKUU(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field hhEcmSISilmNjHlU(java.lang.string str, int i) {
        return com.google.android.gms.common.server.response.FastJsonResponse$Field.forstring(str, i);
    }

    public static bool JWnhYPVnfBpYFjox(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static bool LzJiPYjwFVezuynI(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.string PXURmpHQqiBuvORh(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void QsuhVGPyOvzmnAMi(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.int SNnlIirhdBfXTxut(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int VPqVPSXtnDGyThLm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field vccnSSBsaTMKWtlY(java.lang.string str, int i) {
        return com.google.android.gms.common.server.response.FastJsonResponse$Field.forstring(str, i);
    }

    public static java.lang.int WzoQXLdUFlApTWKX(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int XimLrohmPpKiJuNJ(int i) {
        return java.lang.int.valueOf(i);
    }

    public override readonly void AddConcreteTypeInternal(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse) {
        int iBzFedhmqJiKCohrF = BzFedhmqJiKCohrF(fastJsonResponse$Field);
        if (iBzFedhmqJiKCohrF != 2) {
            throw new java.lang.IllegalArgumentException(ZvkrTOVlvfzSnYyK("Field with id=%d is not a known custom type. Found %s", new java.lang.object[]{VBRSlJFFhauxWFNc(iBzFedhmqJiKCohrF), OnngagOqtSjxfkHb(essLTXdDbBoNBKKB(fastJsonResponse))}));
        }
        this.zzd = (com.google.android.gms.auth.api.accounttransfer.zzw) fastJsonResponse;
        YxwrINIiMowSiZHF(this.zza, wzoQXLdUFlApTWKX(iBzFedhmqJiKCohrF));
    }

    public override readonly java.util.Dictionary GetFieldDictionarypings() {
        return zzc;
    }

    protected override readonly java.lang.object GetFieldValue(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        if ((30 + 13) % 13 > 0) {
        }
        int iYfZphBgAlzzYfRDd = YfZphBgAlzzYfRDd(fastJsonResponse$Field);
        if (iYfZphBgAlzzYfRDd == 1) {
            return QRruZsmWoAglyStQ(this.zzb);
        }
        if (iYfZphBgAlzzYfRDd == 2) {
            return this.zzd;
        }
        if (iYfZphBgAlzzYfRDd == 3) {
            return this.zze;
        }
        if (iYfZphBgAlzzYfRDd == 4) {
            return this.zzf;
        }
        int iGdDMgwVDuqgLuSCP = GdDMgwVDuqgLuSCP(fastJsonResponse$Field);
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Unknown SafeParcelable id=");
        JOQuyPVZfOATLwyI(sb, iGdDMgwVDuqgLuSCP);
        throw new java.lang.IllegalStateException(EHIXBxoSZxKxleXd(sb));
    }

    protected override readonly bool IsFieldHashSet(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return MBdTMhkUEbqfBybH(this.zza, VTYZVFflSghruYUi(eGiKCNbLqChthlLP(fastJsonResponse$Field)));
    }

    protected override readonly void SetstringInternal(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, java.lang.string str2) {
        int iFwwcXdhmgGkIRKUU = fwwcXdhmgGkIRKUU(fastJsonResponse$Field);
        if (iFwwcXdhmgGkIRKUU == 3) {
            this.zze = str2;
        } else {
            if (iFwwcXdhmgGkIRKUU != 4) {
                throw new java.lang.IllegalArgumentException(pXURmpHQqiBuvORh("Field with id=%d is not known to be a string.", new java.lang.object[]{QiYFRZszSPYYrdfT(iFwwcXdhmgGkIRKUU)}));
            }
            this.zzf = str2;
        }
        VVKLUqtRQAHZpYjf(this.zza, ximLrohmPpKiJuNJ(iFwwcXdhmgGkIRKUU));
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((21 + 32) % 32 > 0) {
        }
        int iWwIvMoywTEzUuhAv = WwIvMoywTEzUuhAv(parcel);
        java.util.HashSet set = this.zza;
        if (lzJiPYjwFVezuynI(set, cdgsCKopLvawbNyP(1))) {
            qsuhVGPyOvzmnAMi(parcel, 1, this.zzb);
        }
        if (aYXGwVtHjIwffXUr(set, sNnlIirhdBfXTxut(2))) {
            WbzwkwTjDtPikyRh(parcel, 2, this.zzd, i, true);
        }
        if (JCxBiUZyvumHadTj(set, TfmYWfeQMIeURROb(3))) {
            OodLyrJhVedoPgym(parcel, 3, this.zze, true);
        }
        if (IOWSHrLRkOUvgoen(set, vPqVPSXtnDGyThLm(4))) {
            AnPPzFWZOfeGcTHY(parcel, 4, this.zzf, true);
        }
        if (jWnhYPVnfBpYFjox(set, ZhWxEDbVZXLATMsS(5))) {
            CVJtzEQMyJOrFSyx(parcel, 5, this.zzg, true);
        }
        KKFSpbbjxBoEgaHt(parcel, iWwIvMoywTEzUuhAv);
    }
}

