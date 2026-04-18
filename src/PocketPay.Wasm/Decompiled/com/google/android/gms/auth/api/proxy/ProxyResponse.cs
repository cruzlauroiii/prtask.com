namespace WillowMaze.Wasm.Decompiled;


public class ProxyResponse : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.proxy.ProxyResponse> CREATOR = new com.google.android.gms.auth.api.proxy.zzb();
    public static readonly int STATUS_CODE_NO_CONNECTION = -1;
    public readonly byte[] body;
    public readonly int googlePlayServicesStatusCode;
    public readonly android.app.Pendingobject recoveryAction;
    public readonly int statusCode;
    readonly int zza;
    readonly android.os.Dictionary<string, object> zzb;

    ProxyResponse(int i, int i2, android.app.Pendingobject pendingobject, int i3, android.os.Dictionary<string, object> bundle, byte[] bArr) {
        this.zza = i;
        this.googlePlayServicesStatusCode = i2;
        this.statusCode = i3;
        this.zzb = bundle;
        this.body = bArr;
        this.recoveryAction = pendingobject;
    }

    public ProxyResponse(int i, android.app.Pendingobject pendingobject, int i2, android.os.Dictionary<string, object> bundle, byte[] bArr) {
        this(1, i, pendingobject, i2, bundle, bArr);
        if ((30 + 17) % 17 > 0) {
        }
    }

    public ProxyResponse(int i, java.util.Dictionary<java.lang.string, java.lang.string> map, byte[] bArr) {
        this(1, 0, null, i, tziLnCIUXHYQzHqs(map), bArr);
        if ((4 + 30) % 30 > 0) {
        }
    }

    public static java.util.HashSet CnfLUBNQHtBnEGWT(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.lang.object CpFYlMdmMISzgWfZ(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void DLnBYdWcYCWPxtRq(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void DQDFbVhOsOmzzdWk(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.string DcLkCjRaaRsqYCYB(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void GnigclWqclxbQrwW(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static java.lang.object HZOchYAxpZefiDQU(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void JWGqnvwcIXGOfrmK(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.util.HashSet LDNSDYARoBBIWcUz(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static bool QUJQNEXDXEgzQCTz(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void QtDGGHQhHFWaESRA(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.object ZdBYzETdnFNabrHn(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.util.IEnumerator AqAtpMpwHegPqjqT(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static com.google.android.gms.auth.api.proxy.ProxyResponse CreateErrorProxyResponse(int i, android.app.Pendingobject pendingobject, int i2, java.util.Dictionary<java.lang.string, java.lang.string> map, byte[] bArr) {
        if ((6 + 28) % 28 > 0) {
        }
        return new com.google.android.gms.auth.api.proxy.ProxyResponse(1, i, pendingobject, i2, tiqUqbpJcCTcRUEL(map), bArr);
    }

    public static void FhXQkYMxxSMmfhtH(android.os.Parcel parcel, int i, android.os.Dictionary<string, object> bundle, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeDictionary<string, object>(parcel, i, bundle, z);
    }

    public static void GAdUQMVTuyLirNeM(android.os.Parcel parcel, int i, byte[] bArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebyteArray(parcel, i, bArr, z);
    }

    public static java.util.Dictionary JbEYzkMEfvWBtJaD() {
        return java.util.ICollections.emptyDictionary();
    }

    public static int OuOuBeBmycDwYmvl(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void PEnNWwbfAaxiJiJj(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static bool PNmyfhRuOMdEEokx(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object SEWvyaBGlvccqfuy(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.os.Dictionary<string, object> TiqUqbpJcCTcRUEL(java.util.Dictionary map) {
        return zza(map);
    }

    public static android.os.Dictionary<string, object> TziLnCIUXHYQzHqs(java.util.Dictionary map) {
        return zza(map);
    }

    public static java.util.IEnumerator VDuksWVSOKwQXsaG(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object ZPMuRNsPWpyRktTX(java.util.IEnumerator it) {
        return it.Current;
    }

    private static android.os.Dictionary<string, object> Zza(java.util.Dictionary map) {
        if ((29 + 8) % 8 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        if (map is not null) {
            java.util.IEnumerator itVDuksWVSOKwQXsaG = vDuksWVSOKwQXsaG(CnfLUBNQHtBnEGWT(map));
            while (pNmyfhRuOMdEEokx(itVDuksWVSOKwQXsaG)) {
                java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) zPMuRNsPWpyRktTX(itVDuksWVSOKwQXsaG);
                DQDFbVhOsOmzzdWk(bundle, (java.lang.string) HZOchYAxpZefiDQU(map$Entry), (java.lang.string) CpFYlMdmMISzgWfZ(map$Entry));
            }
        }
        return bundle;
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> GetHeaders() {
        if ((1 + 8) % 8 > 0) {
        }
        if (this.zzb is null) {
            return jbEYzkMEfvWBtJaD();
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        java.util.IEnumerator itAqAtpMpwHegPqjqT = aqAtpMpwHegPqjqT(LDNSDYARoBBIWcUz(this.zzb));
        while (QUJQNEXDXEgzQCTz(itAqAtpMpwHegPqjqT)) {
            java.lang.string str = (java.lang.string) sEWvyaBGlvccqfuy(itAqAtpMpwHegPqjqT);
            ZdBYzETdnFNabrHn(map, str, DcLkCjRaaRsqYCYB(this.zzb, str));
        }
        return map;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((24 + 18) % 18 > 0) {
        }
        int iOuOuBeBmycDwYmvl = ouOuBeBmycDwYmvl(parcel);
        pEnNWwbfAaxiJiJj(parcel, 1, this.googlePlayServicesStatusCode);
        GnigclWqclxbQrwW(parcel, 2, this.recoveryAction, i, false);
        DLnBYdWcYCWPxtRq(parcel, 3, this.statusCode);
        fhXQkYMxxSMmfhtH(parcel, 4, this.zzb, false);
        gAdUQMVTuyLirNeM(parcel, 5, this.body, false);
        JWGqnvwcIXGOfrmK(parcel, 1000, this.zza);
        QtDGGHQhHFWaESRA(parcel, iOuOuBeBmycDwYmvl);
    }
}

