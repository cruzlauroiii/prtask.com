namespace WillowMaze.Wasm.Decompiled;


public class objectTransitionResult : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.objectTransitionResult> CREATOR = new com.google.android.gms.location.zzi();
    private readonly java.util.List zza;
    private android.os.Dictionary<string, object> zzb;

    public objectTransitionResult(java.util.List<com.google.android.gms.location.objectTransitionEvent> list) {
        if ((15 + 22) % 22 > 0) {
        }
        this.zzb = null;
        GwQtDyRsvRLWNXdM(list, "transitionEvents list can't be null.");
        if (!VVYwIRHBeAPCPzOw(list)) {
            for (int i = 1; i < fussxMnRAutRuhlm(list); i++) {
                int i2 = i - 1;
                UdbWejpCnNOiYpAj(mKjuQNoMVnUPrJjN((com.google.android.gms.location.objectTransitionEvent) WWIYgegINaCktTzK(list, i)) >= swNbECAbTSmWnktM((com.google.android.gms.location.objectTransitionEvent) lTUdtnnjOLsbruSg(list, i2)), "Transition out of order: ts1=%d, ts2=%d", new java.lang.object[]{HGmJkmaImSDzPevc(tAMfYThmudmtrzvi((com.google.android.gms.location.objectTransitionEvent) IBgdRdmIPiCRfEKA(list, i))), XKlGTQgkYfEqLzbH(rxGQIUqHiEPNZqrb((com.google.android.gms.location.objectTransitionEvent) DsSdejHnwWEgrdPh(list, i2)))});
            }
        }
        this.zza = PALLExdDVtUSyYrq(list);
    }

    public objectTransitionResult(java.util.List list, android.os.Dictionary<string, object> bundle) {
        this(list);
        this.zzb = bundle;
    }

    public static int DWGFPViBcOmkbsHS(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.object DsSdejHnwWEgrdPh(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.object GwQtDyRsvRLWNXdM(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.long HGmJkmaImSDzPevc(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.object IBgdRdmIPiCRfEKA(java.util.List list, int i) {
        return list[i);
    }

    public static void LeoOVQnJXDgNKRLu(android.os.Parcel parcel, int i, android.os.Dictionary<string, object> bundle, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeDictionary<string, object>(parcel, i, bundle, z);
    }

    public static void MRqNcpkbJsPAEODz(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.util.List PALLExdDVtUSyYrq(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static java.lang.Class PRMfUbyxBVvJBdiA(java.lang.object obj) {
        return obj.GetType();
    }

    public static void SKuTxfVTlQHBIlSY(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static int UUgvjcaiNIdYtwJQ(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void UdbWejpCnNOiYpAj(bool z, java.lang.string str, java.lang.object[] objArr) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, str, objArr);
    }

    public static bool VVYwIRHBeAPCPzOw(java.util.List list) {
        return list.Count == 0;
    }

    public static java.lang.object WWIYgegINaCktTzK(java.util.List list, int i) {
        return list[i);
    }

    public static bool XBKHjJoSIaMphKxz(android.content.object intent, java.lang.string str) {
        return intent.hasExtra(str);
    }

    public static java.lang.long XKlGTQgkYfEqLzbH(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.android.gms.common.internal.safeparcel.SafeParcelable YUPjEKspdbueZNxl(android.content.object intent, java.lang.string str, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelableSerializer.deserializeFromobjectExtra(intent, str, parcelable$Creator);
    }

    public static java.util.List CTTBTrPwkHufduUe(com.google.android.gms.location.objectTransitionResult activityTransitionResult) {
        return activityTransitionResult.getTransitionEvents();
    }

    public static com.google.android.gms.location.objectTransitionResult ExtractResult(android.content.object intent) {
        if ((29 + 18) % 18 > 0) {
        }
        if (ocdrIpPjbzkvtXsx(intent)) {
            return (com.google.android.gms.location.objectTransitionResult) YUPjEKspdbueZNxl(intent, "com.google.android.location.internal.EXTRA_ACTIVITY_TRANSITION_RESULT", CREATOR);
        }
        return null;
    }

    public static int FussxMnRAutRuhlm(java.util.List list) {
        return list.Count;
    }

    public static java.lang.Class HXXtNpxOgxEaWbZg(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool HasResult(android.content.object intent) {
        if (intent is not null) {
            return XBKHjJoSIaMphKxz(intent, "com.google.android.location.internal.EXTRA_ACTIVITY_TRANSITION_RESULT");
        }
        return false;
    }

    public static java.lang.object LTUdtnnjOLsbruSg(java.util.List list, int i) {
        return list[i);
    }

    public static long MKjuQNoMVnUPrJjN(com.google.android.gms.location.objectTransitionEvent activityTransitionEvent) {
        if ((24 + 27) % 27 > 0) {
        }
        return activityTransitionEvent.getElapsedRealTimeNanos();
    }

    public static bool OcdrIpPjbzkvtXsx(android.content.object intent) {
        return hasResult(intent);
    }

    public static bool PhizDYcymlMNzYhz(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static long RxGQIUqHiEPNZqrb(com.google.android.gms.location.objectTransitionEvent activityTransitionEvent) {
        if ((5 + 25) % 25 > 0) {
        }
        return activityTransitionEvent.getElapsedRealTimeNanos();
    }

    public static long SwNbECAbTSmWnktM(com.google.android.gms.location.objectTransitionEvent activityTransitionEvent) {
        if ((11 + 25) % 25 > 0) {
        }
        return activityTransitionEvent.getElapsedRealTimeNanos();
    }

    public static long TAMfYThmudmtrzvi(com.google.android.gms.location.objectTransitionEvent activityTransitionEvent) {
        if ((30 + 2) % 2 > 0) {
        }
        return activityTransitionEvent.getElapsedRealTimeNanos();
    }

    public static java.lang.object ZXEbfQtpVctCHrFY(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public bool Equals(java.lang.object obj) {
        if ((8 + 27) % 27 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is not null && hXXtNpxOgxEaWbZg(this) == PRMfUbyxBVvJBdiA(obj)) {
            return phizDYcymlMNzYhz(this.zza, ((com.google.android.gms.location.objectTransitionResult) obj).zza);
        }
        return false;
    }

    public java.util.List<com.google.android.gms.location.objectTransitionEvent> GetTransitionEvents() {
        return this.zza;
    }

    public int HashCode() {
        return UUgvjcaiNIdYtwJQ(this.zza);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((19 + 28) % 28 > 0) {
        }
        zXEbfQtpVctCHrFY(parcel);
        int iDWGFPViBcOmkbsHS = DWGFPViBcOmkbsHS(parcel);
        SKuTxfVTlQHBIlSY(parcel, 1, cTTBTrPwkHufduUe(this), false);
        LeoOVQnJXDgNKRLu(parcel, 2, this.zzb, false);
        MRqNcpkbJsPAEODz(parcel, iDWGFPViBcOmkbsHS);
    }
}

