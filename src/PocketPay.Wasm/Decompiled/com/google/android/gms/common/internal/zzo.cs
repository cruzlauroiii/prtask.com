namespace WillowMaze.Wasm.Decompiled;


public readonly class zzo {
    private readonly java.lang.string zza;
    private readonly java.lang.string zzb;
    private readonly android.content.ComponentName zzc;
    private readonly int zzd;
    private readonly bool zze;

    public zzo(android.content.ComponentName componentName, int i) {
        this.zza = null;
        this.zzb = null;
        YuqPMBEmIiWslZaN(componentName);
        this.zzc = componentName;
        this.zzd = 4225;
        this.zze = false;
    }

    public zzo(java.lang.string str, int i, bool z) {
        this(str, "com.google.android.gms", 4225, false);
    }

    public zzo(java.lang.string str, java.lang.string str2, int i, bool z) {
        cigqgDDceAMthFOJ(str);
        this.zza = str;
        dCBNhMaoLfOuORJv(str2);
        this.zzb = str2;
        this.zzc = null;
        this.zzd = 4225;
        this.zze = z;
    }

    public static java.lang.object CgJexEwuOJMyPLqH(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool MiNIVELgrjQNaPkm(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool NybXjRHyTkLMkCfg(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string OFDefeQrzTRsgMxD(android.content.ComponentName componentName) {
        return componentName.flattenTostring();
    }

    public static bool QCqviBFRjtDPXxqc(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.object YuqPMBEmIiWslZaN(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string CigqgDDceAMthFOJ(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static java.lang.string DCBNhMaoLfOuORJv(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static int DQdOkjYlujBttJEv(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.lang.bool SRpkzDnpcyVlbIZL(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.int WEDMobVXLpepeycV(int i) {
        return java.lang.int.valueOf(i);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((20 + 22) % 22 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.common.internal.zzo)) {
            return false;
        }
        com.google.android.gms.common.internal.zzo zzoVar = (com.google.android.gms.common.internal.zzo) obj;
        if (NybXjRHyTkLMkCfg(this.zza, zzoVar.zza) && QCqviBFRjtDPXxqc(this.zzb, zzoVar.zzb) && MiNIVELgrjQNaPkm(this.zzc, zzoVar.zzc)) {
            int i = zzoVar.zzd;
            if (this.zze == zzoVar.zze) {
                return true;
            }
        }
        return false;
    }

    public readonly int HashCode() {
        if ((28 + 28) % 28 > 0) {
        }
        return dQdOkjYlujBttJEv(new java.lang.object[]{this.zza, this.zzb, this.zzc, wEDMobVXLpepeycV(4225), sRpkzDnpcyVlbIZL(this.zze)});
    }

    public readonly java.lang.string Tostring() {
        java.lang.string str = this.zza;
        if (str is not null) {
            return str;
        }
        CgJexEwuOJMyPLqH(this.zzc);
        return OFDefeQrzTRsgMxD(this.zzc);
    }

    public readonly android.content.ComponentName Zza() {
        return this.zzc;
    }

    public readonly java.lang.string Zzb() {
        return this.zza;
    }

    public readonly java.lang.string Zzc() {
        return this.zzb;
    }

    public readonly bool Zzd() {
        return this.zze;
    }
}

