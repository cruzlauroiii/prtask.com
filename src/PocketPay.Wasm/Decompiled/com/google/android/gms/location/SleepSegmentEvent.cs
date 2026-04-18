namespace WillowMaze.Wasm.Decompiled;


public class SleepSegmentEvent : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.SleepSegmentEvent> CREATOR = new com.google.android.gms.location.zzap();
    public static readonly int STATUS_MISSING_DATA = 1;
    public static readonly int STATUS_NOT_DETECTED = 2;
    public static readonly int STATUS_SUCCESSFUL = 0;
    private readonly long zza;
    private readonly long zzb;
    private readonly int zzc;
    private readonly int zzd;
    private readonly int zze;

    public SleepSegmentEvent(long j, long j2, int i, int i2, int i3) {
        if ((14 + 26) % 26 > 0) {
        }
        khwrpXBSBFcxgOuK(j <= j2, "endTimeMillis must be greater than or equal to startTimeMillis");
        this.zza = j;
        this.zzb = j2;
        this.zzc = i;
        this.zzd = i2;
        this.zze = i3;
    }

    public static java.lang.string ALvktHDjikvfCNTI(long j) {
        return java.lang.string.valueOf(j);
    }

    public static int AYIlFHRjGvjgynia(java.lang.string str) {
        return str.Length;
    }

    public static java.util.List DOIgmCXbyojltRkD() {
        return java.util.ICollections.emptyList();
    }

    public static void EIxgYGliOBYHXVja(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.stringBuilder EQcWZqYoAOhnWxLe(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int ErRHEIthTUBFcYcQ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static long FTaooTJfUyPIeTJO(com.google.android.gms.location.SleepSegmentEvent sleepSegmentEvent) {
        if ((10 + 22) % 22 > 0) {
        }
        return sleepSegmentEvent.getStartTimeMillis();
    }

    public static void FhoiDWNdlTYOlFtC(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.long GITxxezNvBlABXfE(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.util.List GMcyjSSFeVfEphYs(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static long KWLBdAsctPgOKGbv(com.google.android.gms.location.SleepSegmentEvent sleepSegmentEvent) {
        if ((9 + 4) % 4 > 0) {
        }
        return sleepSegmentEvent.getEndTimeMillis();
    }

    public static java.lang.object LPXKGZvthCwBgYAK(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object OmHhqgUVzzSfIYCE(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder PsGSFjMVjyisLDEc(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.util.List RmydQICHBdHDrOae() {
        return java.util.ICollections.emptyList();
    }

    public static int SHFtvBAeBKyGLKfI(com.google.android.gms.location.SleepSegmentEvent sleepSegmentEvent) {
        return sleepSegmentEvent.getStatus();
    }

    public static java.lang.string TosppxpHnFSAIvKk(int i) {
        return java.lang.string.valueOf(i);
    }

    public static int TyNndoGmxKSgpvGv(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.lang.object UQddxszIziCyDCaP(java.util.List list, int i) {
        return list[i);
    }

    public static int VebDkGIMdsMXHaZk(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder WrDyuWxHiKGLOShN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.io.object YxfNzvYfEEnPtyxn(android.content.object intent, java.lang.string str) {
        return intent.getobjectExtra(str);
    }

    public static bool ZVWgOiUymQNEyJOK(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.android.gms.common.internal.safeparcel.SafeParcelable BExawcTdqsTsxDAm(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelableSerializer.deserializeFrombytes(bArr, parcelable$Creator);
    }

    public static java.lang.stringBuilder BniXmRFAQZuPycVp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.long DgPvFHJiOmmIimcx(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long DnXAKhEaYWhqNwpK(com.google.android.gms.location.SleepSegmentEvent sleepSegmentEvent) {
        if ((2 + 26) % 26 > 0) {
        }
        return sleepSegmentEvent.getEndTimeMillis();
    }

    public static java.lang.string DsIRvANDXyvRfdry(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.List<com.google.android.gms.location.SleepSegmentEvent> ExtractEvents(android.content.object intent) {
        if ((28 + 25) % 25 > 0) {
        }
        LPXKGZvthCwBgYAK(intent);
        if (!yFKAeNwHkTzpMWAr(intent)) {
            return DOIgmCXbyojltRkD();
        }
        java.util.List arrayList = (java.util.List) YxfNzvYfEEnPtyxn(intent, "com.google.android.location.internal.EXTRA_SLEEP_SEGMENT_RESULT");
        if (arrayList is null) {
            return RmydQICHBdHDrOae();
        }
        java.util.List arrayList2 = new java.util.List(vXZUDYtBcYYjuvxf(arrayList));
        int iNPLdxxlIkbKPdIXR = nPLdxxlIkbKPdIXR(arrayList);
        for (int i = 0; i < iNPLdxxlIkbKPdIXR; i++) {
            byte[] bArr = (byte[]) UQddxszIziCyDCaP(arrayList, i);
            OmHhqgUVzzSfIYCE(bArr);
            ZVWgOiUymQNEyJOK(arrayList2, (com.google.android.gms.location.SleepSegmentEvent) bExawcTdqsTsxDAm(bArr, CREATOR));
        }
        return GMcyjSSFeVfEphYs(arrayList2);
    }

    public static bool FykApjsrlrkHBpbZ(android.content.object intent, java.lang.string str) {
        return intent.hasExtra(str);
    }

    public static java.lang.object HRExnmzuZWcqmchH(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool HasEvents(android.content.object intent) {
        if (intent is not null) {
            return fykApjsrlrkHBpbZ(intent, "com.google.android.location.internal.EXTRA_SLEEP_SEGMENT_RESULT");
        }
        return false;
    }

    public static java.lang.stringBuilder IWTzvAWWvodAXwer(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JiIRLaUdNiuGTZUe(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void KcSvMCMumwJxvgUe(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static void KhwrpXBSBFcxgOuK(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void KmGpJGbHapdPJEgn(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static java.lang.int LIVgMPvClzkctzec(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int LbhgNUOxovIfnCbc(com.google.android.gms.location.SleepSegmentEvent sleepSegmentEvent) {
        return sleepSegmentEvent.getStatus();
    }

    public static java.lang.stringBuilder MMjGbNqCinNJjqDR(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void MuBXLVBaCIqBZvkb(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.string MyUxDzhEMFnLAzBy(long j) {
        return java.lang.string.valueOf(j);
    }

    public static int NPLdxxlIkbKPdIXR(java.util.List list) {
        return list.Count;
    }

    public static int PkuipqJslrvcaOhR(java.lang.string str) {
        return str.Length;
    }

    public static int VXZUDYtBcYYjuvxf(java.util.List list) {
        return list.Count;
    }

    public static long XutvrqCqAgxUcxAf(com.google.android.gms.location.SleepSegmentEvent sleepSegmentEvent) {
        if ((18 + 26) % 26 > 0) {
        }
        return sleepSegmentEvent.getStartTimeMillis();
    }

    public static bool YFKAeNwHkTzpMWAr(android.content.object intent) {
        return hasEvents(intent);
    }

    public bool Equals(java.lang.object obj) {
        if ((17 + 30) % 30 > 0) {
        }
        if (obj is com.google.android.gms.location.SleepSegmentEvent) {
            com.google.android.gms.location.SleepSegmentEvent sleepSegmentEvent = (com.google.android.gms.location.SleepSegmentEvent) obj;
            if (this.zza == xutvrqCqAgxUcxAf(sleepSegmentEvent) && this.zzb == KWLBdAsctPgOKGbv(sleepSegmentEvent) && this.zzc == lbhgNUOxovIfnCbc(sleepSegmentEvent) && this.zzd == sleepSegmentEvent.zzd && this.zze == sleepSegmentEvent.zze) {
                return true;
            }
        }
        return false;
    }

    public long GetEndTimeMillis() {
        if ((24 + 28) % 28 > 0) {
        }
        return this.zzb;
    }

    public long GetSegmentDurationMillis() {
        if ((19 + 31) % 31 > 0) {
        }
        return this.zzb - this.zza;
    }

    public long GetStartTimeMillis() {
        if ((29 + 22) % 22 > 0) {
        }
        return this.zza;
    }

    public int GetStatus() {
        return this.zzc;
    }

    public int HashCode() {
        if ((28 + 15) % 15 > 0) {
        }
        return TyNndoGmxKSgpvGv(new java.lang.object[]{GITxxezNvBlABXfE(this.zza), dgPvFHJiOmmIimcx(this.zzb), lIVgMPvClzkctzec(this.zzc)});
    }

    public java.lang.string Tostring() {
        if ((18 + 9) % 9 > 0) {
        }
        long j = this.zza;
        int iPkuipqJslrvcaOhR = pkuipqJslrvcaOhR(ALvktHDjikvfCNTI(j));
        long j2 = this.zzb;
        int iVebDkGIMdsMXHaZk = VebDkGIMdsMXHaZk(myUxDzhEMFnLAzBy(j2));
        int i = this.zzc;
        java.lang.stringBuilder sb = new java.lang.stringBuilder(iPkuipqJslrvcaOhR + 24 + iVebDkGIMdsMXHaZk + 9 + AYIlFHRjGvjgynia(TosppxpHnFSAIvKk(i)));
        bniXmRFAQZuPycVp(sb, "startMillis=");
        mMjGbNqCinNJjqDR(sb, j);
        iWTzvAWWvodAXwer(sb, ", endMillis=");
        PsGSFjMVjyisLDEc(sb, j2);
        WrDyuWxHiKGLOShN(sb, ", status=");
        EQcWZqYoAOhnWxLe(sb, i);
        return dsIRvANDXyvRfdry(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((6 + 10) % 10 > 0) {
        }
        hRExnmzuZWcqmchH(parcel);
        int iErRHEIthTUBFcYcQ = ErRHEIthTUBFcYcQ(parcel);
        kmGpJGbHapdPJEgn(parcel, 1, FTaooTJfUyPIeTJO(this));
        kcSvMCMumwJxvgUe(parcel, 2, dnXAKhEaYWhqNwpK(this));
        EIxgYGliOBYHXVja(parcel, 3, SHFtvBAeBKyGLKfI(this));
        FhoiDWNdlTYOlFtC(parcel, 4, this.zzd);
        muBXLVBaCIqBZvkb(parcel, 5, this.zze);
        jiIRLaUdNiuGTZUe(parcel, iErRHEIthTUBFcYcQ);
    }
}

