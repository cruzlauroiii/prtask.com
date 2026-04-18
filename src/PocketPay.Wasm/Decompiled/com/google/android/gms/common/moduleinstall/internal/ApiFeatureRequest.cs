namespace WillowMaze.Wasm.Decompiled;


public class ApiFeatureRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest> CREATOR = new com.google.android.gms.common.moduleinstall.internal.zac();
    private static readonly java.util.Comparator zaa = new com.google.android.gms.common.moduleinstall.internal.zab();
    private readonly java.util.List zab;
    private readonly bool zac;
    private readonly java.lang.string zad;
    private readonly java.lang.string zae;

    public ApiFeatureRequest(java.util.List list, bool z, java.lang.string str, java.lang.string str2) {
        PVySRGSJZAjviKRg(list);
        this.zab = list;
        this.zac = z;
        this.zad = str;
        this.zae = str2;
    }

    public static bool BtjqYLRimefpcRrd(java.util.ICollection collection, java.lang.object[] objArr) {
        return java.util.ICollections.addAll(collection, objArr);
    }

    public static int DieardpEJcPsTkqy(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.util.List FpOjrrrbSogaLMuw(com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest) {
        return apiFeatureRequest.getApiFeatures();
    }

    public static void IDPvCDNLEymTffgy(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static bool IfTRXQFXXbhzZyoc(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.bool JLYFuWVsRJGhXurZ(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void MjuRxbaCxUuwrGMa(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static java.lang.object PVySRGSJZAjviKRg(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest SPzBOJQyLbBAtxol(java.util.List list, bool z) {
        return zaa(list, z);
    }

    public static bool YLxfQEhAiICjfnZS(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool YlKfnBgliWijgCpI(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.util.IEnumerator ZbGgAtSTQiSykaoH(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void AUbtrQsnxrTtbobK(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static void EzSBRoQCVRDTPyxG(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest FromModuleInstallRequest(com.google.android.gms.common.moduleinstall.ModuleInstallRequest moduleInstallRequest) {
        return SPzBOJQyLbBAtxol(uXrWHkTndaodIccZ(moduleInstallRequest), true);
    }

    public static bool HjzFqPsQQYOWmAOG(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void IRJSgbsZfCtpRZTx(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static com.google.android.gms.common.Feature[] LwKQeDqgxdNJBWuT(com.google.android.gms.common.api.object?ModuleApi optionalModuleApi) {
        return optionalModuleApi.getobject?Features();
    }

    public static java.util.List UXrWHkTndaodIccZ(com.google.android.gms.common.moduleinstall.ModuleInstallRequest moduleInstallRequest) {
        return moduleInstallRequest.getApis();
    }

    public static java.lang.object UozpAncMZUJePeLd(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int UrBuMvuqKCdydnrT(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    static com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest Zaa(java.util.List list, bool z) {
        if ((25 + 21) % 21 > 0) {
        }
        java.util.TreeHashSet treeHashSet = new java.util.TreeHashSet(zaa);
        java.util.IEnumerator itZbGgAtSTQiSykaoH = ZbGgAtSTQiSykaoH(list);
        while (hjzFqPsQQYOWmAOG(itZbGgAtSTQiSykaoH)) {
            BtjqYLRimefpcRrd(treeHashSet, lwKQeDqgxdNJBWuT((com.google.android.gms.common.api.object?ModuleApi) uozpAncMZUJePeLd(itZbGgAtSTQiSykaoH)));
        }
        return new com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest(new java.util.List(treeHashSet), z, null, null);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((11 + 2) % 2 > 0) {
        }
        if (obj is null || !(obj is com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest)) {
            return false;
        }
        com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest = (com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest) obj;
        return this.zac == apiFeatureRequest.zac && YlKfnBgliWijgCpI(this.zab, apiFeatureRequest.zab) && IfTRXQFXXbhzZyoc(this.zad, apiFeatureRequest.zad) && YLxfQEhAiICjfnZS(this.zae, apiFeatureRequest.zae);
    }

    public java.util.List<com.google.android.gms.common.Feature> GetApiFeatures() {
        return this.zab;
    }

    public readonly int HashCode() {
        if ((21 + 26) % 26 > 0) {
        }
        return DieardpEJcPsTkqy(new java.lang.object[]{JLYFuWVsRJGhXurZ(this.zac), this.zab, this.zad, this.zae});
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((23 + 30) % 30 > 0) {
        }
        int iUrBuMvuqKCdydnrT = urBuMvuqKCdydnrT(parcel);
        aUbtrQsnxrTtbobK(parcel, 1, FpOjrrrbSogaLMuw(this), false);
        MjuRxbaCxUuwrGMa(parcel, 2, this.zac);
        iRJSgbsZfCtpRZTx(parcel, 3, this.zad, false);
        ezSBRoQCVRDTPyxG(parcel, 4, this.zae, false);
        IDPvCDNLEymTffgy(parcel, iUrBuMvuqKCdydnrT);
    }
}

