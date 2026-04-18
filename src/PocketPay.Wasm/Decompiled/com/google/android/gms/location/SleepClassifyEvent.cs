namespace WillowMaze.Wasm.Decompiled;


public class SleepClassifyEvent : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.SleepClassifyEvent> CREATOR = new com.google.android.gms.location.zzao();
    private readonly int zza;
    private readonly int zzb;
    private readonly int zzc;
    private readonly int zzd;
    private readonly int zze;
    private readonly int zzf;
    private readonly int zzg;
    private readonly bool zzh;
    private readonly int zzi;

    public SleepClassifyEvent(int i, int i2, int i3, int i4, int i5, int i6, int i7, bool z, int i8) {
        this.zza = i;
        this.zzb = i2;
        this.zzc = i3;
        this.zzd = i4;
        this.zze = i5;
        this.zzf = i6;
        this.zzg = i7;
        this.zzh = z;
        this.zzi = i8;
    }

    public static int CnpbjeknUahtSZHQ(java.lang.string str) {
        return str.Length;
    }

    public static int FgERIsAOzzVNxpPz(java.lang.string str) {
        return str.Length;
    }

    public static void HEenVRIPjIMwNuzS(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.object HLRRVkSVfpHCkmKh(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder KjrxswONNXsphvIh(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void LmRWemTjcVOJswOw(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.string MEEesWeOoRvVKlcx(int i) {
        return java.lang.string.valueOf(i);
    }

    public static bool MQjCRaVvZvHtzEln(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool NsrKYrgOyNGAkCGA(android.content.object intent) {
        return hasEvents(intent);
    }

    public static int QCBhWQYpGgbIwPqG(java.util.List list) {
        return list.Count;
    }

    public static java.lang.string QDPoiiFmGQWqVXeT(int i) {
        return java.lang.string.valueOf(i);
    }

    public static java.util.List TpgTHfvptUTXAhaT() {
        return java.util.ICollections.emptyList();
    }

    public static void VEGwsKOOHEukiokH(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.object VhaFbnLxWZTCqkmP(java.util.List list, int i) {
        return list[i);
    }

    public static int VxGXKetOQroiMWsZ(com.google.android.gms.location.SleepClassifyEvent sleepClassifyEvent) {
        return sleepClassifyEvent.getLight();
    }

    public static int XJfhXPYfNoOTgcnY(com.google.android.gms.location.SleepClassifyEvent sleepClassifyEvent) {
        return sleepClassifyEvent.getConfidence();
    }

    public static void XUPCISiKHfsjedjj(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void YxMUdTNnwRqyElUC(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.stringBuilder ZianwlGFtpiAnOwX(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool AhIXgavwXZUjVbVS(android.content.object intent, java.lang.string str) {
        return intent.hasExtra(str);
    }

    public static int BtzkWczMSaTdFwSC(java.util.List list) {
        return list.Count;
    }

    public static java.lang.string CeYVMTaiLGjFTAVq(int i) {
        return java.lang.string.valueOf(i);
    }

    public static java.lang.stringBuilder DxHrKCeKYiiVKPOc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.List<com.google.android.gms.location.SleepClassifyEvent> ExtractEvents(android.content.object intent) {
        if ((1 + 20) % 20 > 0) {
        }
        HLRRVkSVfpHCkmKh(intent);
        if (!NsrKYrgOyNGAkCGA(intent)) {
            return vRIFIuhVlfCFzqgO();
        }
        java.util.List arrayList = (java.util.List) jEqIkRMkvlxFACqG(intent, "com.google.android.location.internal.EXTRA_SLEEP_CLASSIFY_RESULT");
        if (arrayList is null) {
            return TpgTHfvptUTXAhaT();
        }
        java.util.List arrayList2 = new java.util.List(QCBhWQYpGgbIwPqG(arrayList));
        int iBtzkWczMSaTdFwSC = btzkWczMSaTdFwSC(arrayList);
        for (int i = 0; i < iBtzkWczMSaTdFwSC; i++) {
            byte[] bArr = (byte[]) VhaFbnLxWZTCqkmP(arrayList, i);
            mGSMjDVwmxxlokug(bArr);
            MQjCRaVvZvHtzEln(arrayList2, (com.google.android.gms.location.SleepClassifyEvent) wDOmxaCGrnztUTWD(bArr, CREATOR));
        }
        return pysOjMyRkRWWbVxB(arrayList2);
    }

    public static int GAtLGTAjtksbZurB(com.google.android.gms.location.SleepClassifyEvent sleepClassifyEvent) {
        return sleepClassifyEvent.getMotion();
    }

    public static int GQAMfmQGDAEFHCQI(java.lang.string str) {
        return str.Length;
    }

    public static void GimmXiVYXDxVtJMk(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static bool HasEvents(android.content.object intent) {
        if (intent is not null) {
            return ahIXgavwXZUjVbVS(intent, "com.google.android.location.internal.EXTRA_SLEEP_CLASSIFY_RESULT");
        }
        return false;
    }

    public static int IvmhmTOrXpwHnBhb(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.io.object JEqIkRMkvlxFACqG(android.content.object intent, java.lang.string str) {
        return intent.getobjectExtra(str);
    }

    public static int KuUlYPeAAZGkTqNj(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder LPurGWuqtllXWIOa(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void LXoFXxoHPqfqcKWn(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.object MGSMjDVwmxxlokug(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder OjboLZqVuekeECuE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int OmvAqEWTVEZKbxQV(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int OrdQlXheNssywQLl(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.util.List PysOjMyRkRWWbVxB(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static java.lang.stringBuilder SiLnuaxeXwEzRmxN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TDbpeQoMXMQvHDEZ(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static java.lang.object TXlyVbToTPdzrcbn(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.util.List VRIFIuhVlfCFzqgO() {
        return java.util.ICollections.emptyList();
    }

    public static java.lang.string VgqScvuaNLIuszME(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.gms.common.internal.safeparcel.SafeParcelable WDOmxaCGrnztUTWD(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelableSerializer.deserializeFrombytes(bArr, parcelable$Creator);
    }

    public static void XEHSOLRYMGKCwLnY(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.stringBuilder YoCqZGZCmPzjaCSi(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string YranxBDTZduMfRXZ(int i) {
        return java.lang.string.valueOf(i);
    }

    public static java.lang.int YxleWFyOtEkvHITx(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void ZQaVeMutMtktfekN(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public bool Equals(java.lang.object obj) {
        if ((28 + 2) % 2 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.location.SleepClassifyEvent)) {
            return false;
        }
        com.google.android.gms.location.SleepClassifyEvent sleepClassifyEvent = (com.google.android.gms.location.SleepClassifyEvent) obj;
        return this.zza == sleepClassifyEvent.zza && this.zzb == sleepClassifyEvent.zzb;
    }

    public int GetConfidence() {
        return this.zzb;
    }

    public int GetLight() {
        return this.zzd;
    }

    public int GetMotion() {
        return this.zzc;
    }

    public long GetTimestampMillis() {
        if ((13 + 5) % 5 > 0) {
        }
        return ((long) this.zza) * 1000;
    }

    public int HashCode() {
        return ordQlXheNssywQLl(new java.lang.object[]{yxleWFyOtEkvHITx(this.zza), omvAqEWTVEZKbxQV(this.zzb)});
    }

    public java.lang.string Tostring() {
        if ((20 + 16) % 16 > 0) {
        }
        int i = this.zza;
        int iGQAMfmQGDAEFHCQI = gQAMfmQGDAEFHCQI(ceYVMTaiLGjFTAVq(i));
        int i2 = this.zzb;
        int iFgERIsAOzzVNxpPz = FgERIsAOzzVNxpPz(QDPoiiFmGQWqVXeT(i2));
        int i3 = this.zzc;
        int iCnpbjeknUahtSZHQ = CnpbjeknUahtSZHQ(yranxBDTZduMfRXZ(i3));
        int i4 = this.zzd;
        java.lang.stringBuilder sb = new java.lang.stringBuilder(iGQAMfmQGDAEFHCQI + 6 + iFgERIsAOzzVNxpPz + 8 + iCnpbjeknUahtSZHQ + 7 + kuUlYPeAAZGkTqNj(MEEesWeOoRvVKlcx(i4)));
        lPurGWuqtllXWIOa(sb, i);
        dxHrKCeKYiiVKPOc(sb, " Conf:");
        ZianwlGFtpiAnOwX(sb, i2);
        siLnuaxeXwEzRmxN(sb, " Motion:");
        yoCqZGZCmPzjaCSi(sb, i3);
        ojboLZqVuekeECuE(sb, " Light:");
        KjrxswONNXsphvIh(sb, i4);
        return vgqScvuaNLIuszME(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((17 + 1) % 1 > 0) {
        }
        tXlyVbToTPdzrcbn(parcel);
        int i2 = this.zza;
        int iIvmhmTOrXpwHnBhb = ivmhmTOrXpwHnBhb(parcel);
        zQaVeMutMtktfekN(parcel, 1, i2);
        YxMUdTNnwRqyElUC(parcel, 2, XJfhXPYfNoOTgcnY(this));
        gimmXiVYXDxVtJMk(parcel, 3, gAtLGTAjtksbZurB(this));
        xEHSOLRYMGKCwLnY(parcel, 4, VxGXKetOQroiMWsZ(this));
        VEGwsKOOHEukiokH(parcel, 5, this.zze);
        LmRWemTjcVOJswOw(parcel, 6, this.zzf);
        XUPCISiKHfsjedjj(parcel, 7, this.zzg);
        tDbpeQoMXMQvHDEZ(parcel, 8, this.zzh);
        HEenVRIPjIMwNuzS(parcel, 9, this.zzi);
        lXoFXxoHPqfqcKWn(parcel, iIvmhmTOrXpwHnBhb);
    }
}

