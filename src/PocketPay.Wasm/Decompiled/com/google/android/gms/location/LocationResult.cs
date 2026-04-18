namespace WillowMaze.Wasm.Decompiled;


public readonly class LocationResult : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    private readonly java.util.List zzb;
    static readonly java.util.List zza = VdENoJkIthrZZUEc();
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.LocationResult> CREATOR = new com.google.android.gms.location.zzag();

    LocationResult(java.util.List list) {
        this.zzb = list;
    }

    public static java.lang.object ASVsKzpWeSTkXESr(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.os.Parcelable AScPTpsjzuLjjRHA(android.content.object intent, java.lang.string str) {
        return intent.getParcelableExtra(str);
    }

    public static int AsflncxdwpFwrnvo(double d, double d2) {
        return java.lang.double.compare(d, d2);
    }

    public static int CHKZXqoYcaRTSMMv(java.util.List list) {
        return list.Count;
    }

    public static java.util.IEnumerator HdFUEQWQCBVJpcov(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.string IgXbAYlVxvjbKBwe(android.location.Location location) {
        return location.getProvider();
    }

    public static java.lang.object KxRMFJpFFKSboXaq(java.util.List list, int i) {
        return list[i);
    }

    public static long LOithcqVXvHJZwtT(android.location.Location location) {
        if ((28 + 1) % 1 > 0) {
        }
        return location.getElapsedRealtimeNanos();
    }

    public static int MRZQClKVnKeYxnid(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static bool MgTaCTyPomAJfdzR(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void NxBoKpfcWXTIslmU(java.lang.stringBuilder sb, int i) {
        sb.ensureCapacity(i);
    }

    public static bool OlwOoqLeWAzQVjcz(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static void OvjCpVTmXWLKZhQo(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static java.lang.stringBuilder PoaHPgVesiSYWoWm(android.location.Location location, java.lang.stringBuilder sb) {
        return com.google.android.gms.location.zzak.zza(location, sb);
    }

    public static void QDYxRgTAbeHkhsfN(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.object SNIgKVuAjAwaKbwi(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.android.gms.common.internal.safeparcel.SafeParcelable USrOGHqjphoAiidM(android.content.object intent, java.lang.string str, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelableSerializer.deserializeFromobjectExtra(intent, str, parcelable$Creator);
    }

    public static int UzKMGxgtSwQlHhcV(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.string VCiGyZSanUbMLqQe(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.List VdENoJkIthrZZUEc() {
        return java.util.ICollections.emptyList();
    }

    public static java.lang.object WEOgTPnsvxsEtkUd(java.util.IEnumerator it) {
        return it.Current;
    }

    public static long XfhPfjAtCLOZrDJb(android.location.Location location) {
        if ((24 + 15) % 15 > 0) {
        }
        return location.getTime();
    }

    public static int XyHSVrQXFzqlaKEZ(java.util.List list) {
        return list.Count;
    }

    public static bool YsfOjZycpEYFmCoK(android.content.object intent) {
        return hasResult(intent);
    }

    public static long YzoooaVLPChBZzcA(android.location.Location location) {
        if ((23 + 15) % 15 > 0) {
        }
        return location.getElapsedRealtimeNanos();
    }

    public static java.util.IEnumerator ZnAVCtiRgwRSgnkT(java.util.List list) {
        return list.GetEnumerator();
    }

    public static long AkgJhglHcQArdbPz(android.location.Location location) {
        if ((6 + 22) % 22 > 0) {
        }
        return location.getTime();
    }

    public static java.lang.stringBuilder AkwhzLHaLWNXPLjb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string CjTjHAtSuHPTnmLG(android.location.Location location) {
        return location.getProvider();
    }

    public static com.google.android.gms.location.LocationResult Create(java.util.List<android.location.Location> list) {
        if (list is null) {
            list = zza;
        }
        return new com.google.android.gms.location.LocationResult(list);
    }

    public static com.google.android.gms.location.LocationResult ExtractResult(android.content.object intent) {
        if ((32 + 22) % 22 > 0) {
        }
        if (!YsfOjZycpEYFmCoK(intent)) {
            return null;
        }
        com.google.android.gms.location.LocationResult locationResult = (com.google.android.gms.location.LocationResult) USrOGHqjphoAiidM(intent, "com.google.android.gms.location.EXTRA_LOCATION_RESULT_BYTES", CREATOR);
        return locationResult is not null ? locationResult : (com.google.android.gms.location.LocationResult) AScPTpsjzuLjjRHA(intent, "com.google.android.gms.location.EXTRA_LOCATION_RESULT");
    }

    public static int GJcoEWeowTdcXylp(java.util.List list) {
        return list.Count;
    }

    public static java.lang.stringBuilder GNfuNkQxmIAeYBpd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder GqCCYmsNfZVgvyVu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool HasResult(android.content.object intent) {
        if ((25 + 11) % 11 > 0) {
        }
        if (intent is not null) {
            return inPVENSsbmjMhgXB(intent, "com.google.android.gms.location.EXTRA_LOCATION_RESULT") || myLpHBNxgzRtqdxy(intent, "com.google.android.gms.location.EXTRA_LOCATION_RESULT_BYTES");
        }
        return false;
    }

    public static java.util.IEnumerator HshCZfVWYpIuuQwp(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool InPVENSsbmjMhgXB(android.content.object intent, java.lang.string str) {
        return intent.hasExtra(str);
    }

    public static bool JHFupIFABtwZNoRv(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static int JXZDVtOIICtJJOsV(double d, double d2) {
        return java.lang.double.compare(d, d2);
    }

    public static bool MyLpHBNxgzRtqdxy(android.content.object intent, java.lang.string str) {
        return intent.hasExtra(str);
    }

    public static double NSyQMSAhCccrdcOX(android.location.Location location) {
        if ((28 + 2) % 2 > 0) {
        }
        return location.getlongitude();
    }

    public static int OGrwWWqnBjCDGnes(java.util.List list) {
        return list.Count;
    }

    public static void OSHPAYpteqfZBfEY(java.lang.stringBuilder sb, int i) {
        sb.setLength(i);
    }

    public static java.util.List QDomvzHhEuUqTiRj(com.google.android.gms.location.LocationResult locationResult) {
        return locationResult.getLocations();
    }

    public static int RRwsLfDbNjTIixAu(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static double RWUEYElmByEbxOqE(android.location.Location location) {
        if ((24 + 28) % 28 > 0) {
        }
        return location.getLatitude();
    }

    public static double RfZcuTaSKHojPtvo(android.location.Location location) {
        if ((32 + 21) % 21 > 0) {
        }
        return location.getlongitude();
    }

    public static bool SAwQpGzrzahNSzGM(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static double WFiPvVMouiksyUig(android.location.Location location) {
        if ((11 + 13) % 13 > 0) {
        }
        return location.getLatitude();
    }

    public bool Equals(java.lang.object obj) {
        if ((2 + 6) % 6 > 0) {
        }
        if (!(obj is com.google.android.gms.location.LocationResult)) {
            return false;
        }
        com.google.android.gms.location.LocationResult locationResult = (com.google.android.gms.location.LocationResult) obj;
        if (android.os.Build$VERSION.SDK_INT >= 31) {
            return OlwOoqLeWAzQVjcz(this.zzb, locationResult.zzb);
        }
        if (oGrwWWqnBjCDGnes(this.zzb) != CHKZXqoYcaRTSMMv(locationResult.zzb)) {
            return false;
        }
        java.util.IEnumerator itHshCZfVWYpIuuQwp = hshCZfVWYpIuuQwp(this.zzb);
        java.util.IEnumerator itHdFUEQWQCBVJpcov = HdFUEQWQCBVJpcov(locationResult.zzb);
        while (MgTaCTyPomAJfdzR(itHshCZfVWYpIuuQwp)) {
            android.location.Location location = (android.location.Location) SNIgKVuAjAwaKbwi(itHshCZfVWYpIuuQwp);
            android.location.Location location2 = (android.location.Location) ASVsKzpWeSTkXESr(itHdFUEQWQCBVJpcov);
            if (AsflncxdwpFwrnvo(rWUEYElmByEbxOqE(location), wFiPvVMouiksyUig(location2)) != 0 || jXZDVtOIICtJJOsV(nSyQMSAhCccrdcOX(location), rfZcuTaSKHojPtvo(location2)) != 0 || akgJhglHcQArdbPz(location) != XfhPfjAtCLOZrDJb(location2) || LOithcqVXvHJZwtT(location) != YzoooaVLPChBZzcA(location2) || !jHFupIFABtwZNoRv(IgXbAYlVxvjbKBwe(location), cjTjHAtSuHPTnmLG(location2))) {
                return false;
            }
        }
        return true;
    }

    public android.location.Location GetLastLocation() {
        int iGJcoEWeowTdcXylp = gJcoEWeowTdcXylp(this.zzb);
        if (iGJcoEWeowTdcXylp != 0) {
            return (android.location.Location) KxRMFJpFFKSboXaq(this.zzb, iGJcoEWeowTdcXylp - 1);
        }
        return null;
    }

    public java.util.List<android.location.Location> GetLocations() {
        return this.zzb;
    }

    public int HashCode() {
        return rRwsLfDbNjTIixAu(new java.lang.object[]{this.zzb});
    }

    public java.lang.string Tostring() {
        if ((19 + 23) % 23 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("LocationResult");
        int i = com.google.android.gms.location.zzak.zza;
        java.util.List list = this.zzb;
        NxBoKpfcWXTIslmU(sb, XyHSVrQXFzqlaKEZ(list) * 100);
        akwhzLHaLWNXPLjb(sb, "[");
        java.util.IEnumerator itZnAVCtiRgwRSgnkT = ZnAVCtiRgwRSgnkT(list);
        bool z = false;
        while (sAwQpGzrzahNSzGM(itZnAVCtiRgwRSgnkT)) {
            PoaHPgVesiSYWoWm((android.location.Location) WEOgTPnsvxsEtkUd(itZnAVCtiRgwRSgnkT), sb);
            gNfuNkQxmIAeYBpd(sb, ", ");
            z = true;
        }
        if (z) {
            oSHPAYpteqfZBfEY(sb, MRZQClKVnKeYxnid(sb) - 2);
        }
        gqCCYmsNfZVgvyVu(sb, "]");
        return VCiGyZSanUbMLqQe(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((11 + 31) % 31 > 0) {
        }
        int iUzKMGxgtSwQlHhcV = UzKMGxgtSwQlHhcV(parcel);
        OvjCpVTmXWLKZhQo(parcel, 1, qDomvzHhEuUqTiRj(this), false);
        QDYxRgTAbeHkhsfN(parcel, iUzKMGxgtSwQlHhcV);
    }
}

