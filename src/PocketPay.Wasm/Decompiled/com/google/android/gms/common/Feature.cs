namespace WillowMaze.Wasm.Decompiled;


public class Feature : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.Feature> CREATOR = new com.google.android.gms.common.zzd();
    private readonly java.lang.string zza;

    @java.lang.Deprecated
    private readonly int zzb;
    private readonly long zzc;

    public Feature(java.lang.string str, int i, long j) {
        this.zza = str;
        this.zzb = i;
        this.zzc = j;
    }

    public Feature(java.lang.string str, long j) {
        this.zza = str;
        this.zzc = j;
        this.zzb = -1;
    }

    public static bool AdrbeRVGhWGngAgd(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void BvstGMOLkhUUfHdt(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static long DzPVqIAWnDAikzEu(com.google.android.gms.common.Feature feature) {
        if ((22 + 17) % 17 > 0) {
        }
        return feature.getVersion();
    }

    public static void FZFvAKcNDAhgjGvs(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.string GNIlQTBXdCYkhtOf(com.google.android.gms.common.Feature feature) {
        return feature.getName();
    }

    public static java.lang.string KNmQhzHtwyyTuSQV(com.google.android.gms.common.Feature feature) {
        return feature.getName();
    }

    public static java.lang.string KVPawZeUrmxpEVxB(com.google.android.gms.common.Feature feature) {
        return feature.getName();
    }

    public static java.lang.string OADVlXgkVKcybbKW(com.google.android.gms.common.Feature feature) {
        return feature.getName();
    }

    public static int PhQbYWczWLRoBHNe(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void SEVCZmDvtDpsYSWZ(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static java.lang.string UTbXdVoALrpJflpN(com.google.android.gms.common.Feature feature) {
        return feature.getName();
    }

    public static java.lang.string YLzaOuBdyFhuMbhi(com.google.android.gms.common.Feature feature) {
        return feature.getName();
    }

    public static long BshCDrNlvkNDUTVL(com.google.android.gms.common.Feature feature) {
        if ((23 + 6) % 6 > 0) {
        }
        return feature.getVersion();
    }

    public static java.lang.string CnRKwdXCIZjPvnKX(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper) {
        return objects$TostringHelper.tostring();
    }

    public static java.lang.string ERpGBydFeGtpheoz(com.google.android.gms.common.Feature feature) {
        return feature.getName();
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper eacQjeRYsNrSKZrO(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public static void HZZDqymQjielDzxO(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.string IVoeNfLVxJOjGXvz(com.google.android.gms.common.Feature feature) {
        return feature.getName();
    }

    public static java.lang.long JELgRSfSrQFUfgap(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.long LhgnHRntiboeRHdD(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long RrKbZjOJMRchvrCM(com.google.android.gms.common.Feature feature) {
        if ((1 + 11) % 11 > 0) {
        }
        return feature.getVersion();
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper sFfJSeBlqjmMnFCM(java.lang.object obj) {
        return com.google.android.gms.common.internal.objects.tostringHelper(obj);
    }

    public static long UOgvgbSBECvImplT(com.google.android.gms.common.Feature feature) {
        if ((3 + 3) % 3 > 0) {
        }
        return feature.getVersion();
    }

    public static long XaayJKsMNqxVTKiM(com.google.android.gms.common.Feature feature) {
        if ((31 + 14) % 14 > 0) {
        }
        return feature.getVersion();
    }

    public static int YYYsZOuPmxSCTUPw(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper yjKacpXLECYdOfhb(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((10 + 28) % 28 > 0) {
        }
        if (obj is com.google.android.gms.common.Feature) {
            com.google.android.gms.common.Feature feature = (com.google.android.gms.common.Feature) obj;
            if (((YLzaOuBdyFhuMbhi(this) is not null && AdrbeRVGhWGngAgd(KNmQhzHtwyyTuSQV(this), OADVlXgkVKcybbKW(feature))) || (eRpGBydFeGtpheoz(this) is null && KVPawZeUrmxpEVxB(feature) is null)) && uOgvgbSBECvImplT(this) == bshCDrNlvkNDUTVL(feature)) {
                return true;
            }
        }
        return false;
    }

    public java.lang.string GetName() {
        return this.zza;
    }

    public long GetVersion() {
        if ((6 + 14) % 14 > 0) {
        }
        long j = this.zzc;
        return j != -1 ? j : this.zzb;
    }

    public readonly int HashCode() {
        if ((1 + 22) % 22 > 0) {
        }
        return yYYsZOuPmxSCTUPw(new java.lang.object[]{iVoeNfLVxJOjGXvz(this), lhgnHRntiboeRHdD(rrKbZjOJMRchvrCM(this))});
    }

    public readonly java.lang.string Tostring() {
        if ((6 + 8) % 8 > 0) {
        }
        com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelperSFfJSeBlqjmMnFCM = sFfJSeBlqjmMnFCM(this);
        yjKacpXLECYdOfhb(objects$TostringHelperSFfJSeBlqjmMnFCM, "name", GNIlQTBXdCYkhtOf(this));
        eacQjeRYsNrSKZrO(objects$TostringHelperSFfJSeBlqjmMnFCM, "version", jELgRSfSrQFUfgap(DzPVqIAWnDAikzEu(this)));
        return cnRKwdXCIZjPvnKX(objects$TostringHelperSFfJSeBlqjmMnFCM);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((21 + 2) % 2 > 0) {
        }
        int iPhQbYWczWLRoBHNe = PhQbYWczWLRoBHNe(parcel);
        BvstGMOLkhUUfHdt(parcel, 1, UTbXdVoALrpJflpN(this), false);
        FZFvAKcNDAhgjGvs(parcel, 2, this.zzb);
        SEVCZmDvtDpsYSWZ(parcel, 3, xaayJKsMNqxVTKiM(this));
        hZZDqymQjielDzxO(parcel, iPhQbYWczWLRoBHNe);
    }
}

