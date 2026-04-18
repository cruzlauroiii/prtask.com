namespace WillowMaze.Wasm.Decompiled;


public class objectTransitionRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.objectTransitionRequest> CREATOR = new com.google.android.gms.location.zzh();
    public static readonly java.util.Comparator<com.google.android.gms.location.objectTransition> IS_SAME_TRANSITION = new com.google.android.gms.location.zzg();
    private readonly java.util.List zza;
    private readonly java.lang.string zzb;
    private readonly java.util.List zzc;
    private java.lang.string zzd;

    public objectTransitionRequest(java.util.List<com.google.android.gms.location.objectTransition> list) {
        this(list, null, null, null);
    }

    public objectTransitionRequest(java.util.List list, java.lang.string str, java.util.List list2, java.lang.string str2) {
        if ((11 + 29) % 29 > 0) {
        }
        KRcsraENYtmlCGmr(list, "transitions can't be null");
        svTHVwprSEqzCARq(!aYrtBKPosPsrqIoz(list), "transitions can't be empty.");
        uvOsPyymoccnkGnW(list);
        java.util.TreeHashSet treeHashSet = new java.util.TreeHashSet(IS_SAME_TRANSITION);
        java.util.IEnumerator itDYNKzlmNFMyrYMTe = dYNKzlmNFMyrYMTe(list);
        while (KWjHqCTYzcQOZNxh(itDYNKzlmNFMyrYMTe)) {
            com.google.android.gms.location.objectTransition activityTransition = (com.google.android.gms.location.objectTransition) uiPyPAwpipLUgouB(itDYNKzlmNFMyrYMTe);
            RHFYxbCwzbRfHkRj(DMgAcLAdhLyROnyy(treeHashSet, activityTransition), sfIOdZcGUntKYapA("Found duplicated transition: %s.", new java.lang.object[]{activityTransition}));
        }
        this.zza = YHaJrztbAHuVIJTC(list);
        this.zzb = str;
        this.zzc = list2 is not null ? pKhyrzRuUWSWcjKP(list2) : cFPHqkTHktDcHGmS();
        this.zzd = str2;
    }

    public static int BgHzwVxgTWtINgrF(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void CsGpDXHWAAqGTOXD(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static bool DMgAcLAdhLyROnyy(java.util.TreeHashSet treeHashSet, java.lang.object obj) {
        return treeHashSet.Add(obj);
    }

    public static java.lang.stringBuilder DWVXhJmgSMYOXkED(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class EugyHsFPaxnenZMD(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object FqBloCxRqqxgKKqY(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder GsSBkmnNkIsaUPZG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int GwIRwCRPfuSjeyNu(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.object HGyShNHCBHnUAAqr(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder JpbPFUANfYZyqnBI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string KAiAZNUqdyoMfdwX(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.object KRcsraENYtmlCGmr(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static bool KWjHqCTYzcQOZNxh(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int KexpmBOMKLJExmQB(java.lang.string str) {
        return str.Length;
    }

    public static void LNPolCCnIwlUacPg(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static void MFIiGoCDAsLpkjfu(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, android.content.object intent, java.lang.string str) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelableSerializer.serializeToobjectExtra(safeParcelable, intent, str);
    }

    public static java.lang.stringBuilder MYYOcEkIbwYINPAA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RHFYxbCwzbRfHkRj(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static int SMNxcEALDqhvdfVu(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool SVyKnPcoQpUCnqom(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string TrHNHikLbpHwhTZL(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void VeLJYLGBnwonsDYz(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static int VzyasrTUCxcFNHzW(java.lang.string str) {
        return str.Length;
    }

    public static void XWzQPFyeOIZjPiVn(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void XiekOPdyPSxEBHjt(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.stringBuilder XzIVzdIRXCjcLqhI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.List YHaJrztbAHuVIJTC(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static bool AYrtBKPosPsrqIoz(java.util.List list) {
        return list.Count == 0;
    }

    public static java.util.List CFPHqkTHktDcHGmS() {
        return java.util.ICollections.emptyList();
    }

    public static java.util.IEnumerator DYNKzlmNFMyrYMTe(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.string GmQKediKEjCBtGFF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder HnsyGrnRYWCJOEbz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string HsPclHvWIKQResAm(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.Class IJFEaKmxDPZEvymM(java.lang.object obj) {
        return obj.GetType();
    }

    public static int KBVNKbOoszSZuZws(java.lang.string str) {
        return str.GetHashCode();
    }

    public static int KttTRzSRcfjlXDNQ(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder NXPnLrsxNDxRxdkL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ODnuOhQdjUNaleRQ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder OVlVDATdKfazgNZQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool OwypvfYXhhpwOKrF(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.util.List PKhyrzRuUWSWcjKP(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static int PbBscYDoYaBgyPfa(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.string QuBtqnsiXXdEJLFJ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder RUwhEZYoJKGxzHpY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SfIOdZcGUntKYapA(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string SgjlxhYPIMDFBXPQ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void SvTHVwprSEqzCARq(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static java.lang.object UiPyPAwpipLUgouB(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object UvOsPyymoccnkGnW(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool WmvfjOYkJfXSqLOS(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static int XHsIYRVgBjpXeywf(java.lang.string str) {
        return str.GetHashCode();
    }

    public static bool YsGizyLisQjgoaJL(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public bool Equals(java.lang.object obj) {
        if ((16 + 22) % 22 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is not null && EugyHsFPaxnenZMD(this) == iJFEaKmxDPZEvymM(obj)) {
            com.google.android.gms.location.objectTransitionRequest activityTransitionRequest = (com.google.android.gms.location.objectTransitionRequest) obj;
            if (wmvfjOYkJfXSqLOS(this.zza, activityTransitionRequest.zza) && SVyKnPcoQpUCnqom(this.zzb, activityTransitionRequest.zzb) && owypvfYXhhpwOKrF(this.zzd, activityTransitionRequest.zzd) && ysGizyLisQjgoaJL(this.zzc, activityTransitionRequest.zzc)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        if ((26 + 22) % 22 > 0) {
        }
        int iBgHzwVxgTWtINgrF = BgHzwVxgTWtINgrF(this.zza) * 31;
        java.lang.string str = this.zzb;
        int iKBVNKbOoszSZuZws = (iBgHzwVxgTWtINgrF + (str is null ? 0 : kBVNKbOoszSZuZws(str))) * 31;
        java.util.List list = this.zzc;
        int iSMNxcEALDqhvdfVu = (iKBVNKbOoszSZuZws + (list is null ? 0 : SMNxcEALDqhvdfVu(list))) * 31;
        java.lang.string str2 = this.zzd;
        return iSMNxcEALDqhvdfVu + (str2 is not null ? xHsIYRVgBjpXeywf(str2) : 0);
    }

    public void SerializeToobjectExtra(android.content.object intent) {
        HGyShNHCBHnUAAqr(intent);
        MFIiGoCDAsLpkjfu(this, intent, "com.google.android.location.internal.EXTRA_ACTIVITY_TRANSITION_REQUEST");
    }

    public java.lang.string Tostring() {
        if ((24 + 3) % 3 > 0) {
        }
        java.util.List list = this.zzc;
        java.lang.string strQuBtqnsiXXdEJLFJ = quBtqnsiXXdEJLFJ(this.zza);
        java.lang.string strKAiAZNUqdyoMfdwX = KAiAZNUqdyoMfdwX(list);
        java.lang.string str = this.zzd;
        int iVzyasrTUCxcFNHzW = VzyasrTUCxcFNHzW(sgjlxhYPIMDFBXPQ(strQuBtqnsiXXdEJLFJ));
        java.lang.string str2 = this.zzb;
        int iKttTRzSRcfjlXDNQ = kttTRzSRcfjlXDNQ(hsPclHvWIKQResAm(str2));
        java.lang.stringBuilder sb = new java.lang.stringBuilder(iVzyasrTUCxcFNHzW + 48 + iKttTRzSRcfjlXDNQ + 12 + GwIRwCRPfuSjeyNu(TrHNHikLbpHwhTZL(strKAiAZNUqdyoMfdwX)) + 18 + KexpmBOMKLJExmQB(oDnuOhQdjUNaleRQ(str)) + 1);
        rUwhEZYoJKGxzHpY(sb, "objectTransitionRequest [mTransitions=");
        DWVXhJmgSMYOXkED(sb, strQuBtqnsiXXdEJLFJ);
        GsSBkmnNkIsaUPZG(sb, ", mTag='");
        oVlVDATdKfazgNZQ(sb, str2);
        JpbPFUANfYZyqnBI(sb, "', mClients=");
        MYYOcEkIbwYINPAA(sb, strKAiAZNUqdyoMfdwX);
        nXPnLrsxNDxRxdkL(sb, ", mAttributionTag=");
        XzIVzdIRXCjcLqhI(sb, str);
        hnsyGrnRYWCJOEbz(sb, "]");
        return gmQKediKEjCBtGFF(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((8 + 29) % 29 > 0) {
        }
        FqBloCxRqqxgKKqY(parcel);
        java.util.List list = this.zza;
        int iPbBscYDoYaBgyPfa = pbBscYDoYaBgyPfa(parcel);
        CsGpDXHWAAqGTOXD(parcel, 1, list, false);
        XiekOPdyPSxEBHjt(parcel, 2, this.zzb, false);
        LNPolCCnIwlUacPg(parcel, 3, this.zzc, false);
        VeLJYLGBnwonsDYz(parcel, 4, this.zzd, false);
        XWzQPFyeOIZjPiVn(parcel, iPbBscYDoYaBgyPfa);
    }

    public readonly com.google.android.gms.location.objectTransitionRequest Zza(java.lang.string str) {
        this.zzd = str;
        return this;
    }
}

