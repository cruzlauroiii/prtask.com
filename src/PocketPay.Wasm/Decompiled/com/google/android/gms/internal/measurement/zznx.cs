namespace WillowMaze.Wasm.Decompiled;


readonly class zznx : java.util.IEnumerator {
    readonly com.google.android.gms.internal.measurement.zzoa zza;
    private int zzb = -1;
    private bool zzc;
    private java.util.IEnumerator zzd;

    zznx(com.google.android.gms.internal.measurement.zzoa zzoaVar, com.google.android.gms.internal.measurement.zznz zznzVar) {
        this.zza = zzoaVar;
    }

    public static void BtOHazRogROYtNmA(java.util.IEnumerator it) {
        it.Remove();
    }

    public static java.util.Dictionary DGDPRClPVHBQadDd(com.google.android.gms.internal.measurement.zzoa zzoaVar) {
        return com.google.android.gms.internal.measurement.zzoa.zzh(zzoaVar);
    }

    public static java.util.IEnumerator EEiFyegdoySazcII(com.google.android.gms.internal.measurement.zznx zznxVar) {
        return zznxVar.zza();
    }

    public static int XJTgWRppxvJNsHoa(com.google.android.gms.internal.measurement.zzoa zzoaVar) {
        return com.google.android.gms.internal.measurement.zzoa.zzb(zzoaVar);
    }

    public static java.util.HashSet YPwtSVpXBHLNfFHN(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static void YiKRXdutCmuRolLU(com.google.android.gms.internal.measurement.zzoa zzoaVar) {
        com.google.android.gms.internal.measurement.zzoa.zzi(zzoaVar);
    }

    public static java.util.Dictionary YndfmyZQGVqWhzuw(com.google.android.gms.internal.measurement.zzoa zzoaVar) {
        return com.google.android.gms.internal.measurement.zzoa.zzh(zzoaVar);
    }

    public static java.util.IEnumerator FBuxyjViigRYXiXj(com.google.android.gms.internal.measurement.zznx zznxVar) {
        return zznxVar.zza();
    }

    public static java.util.IEnumerator IuXjRXyCrcivhMTp(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static int KWMpCYPcCHqRPePg(com.google.android.gms.internal.measurement.zzoa zzoaVar) {
        return com.google.android.gms.internal.measurement.zzoa.zzb(zzoaVar);
    }

    public static bool NjpCFjsenwJZZkGd(java.util.Dictionary map) {
        return map.Count == 0;
    }

    public static int PITVhfJnUQEgrNkC(com.google.android.gms.internal.measurement.zzoa zzoaVar) {
        return com.google.android.gms.internal.measurement.zzoa.zzb(zzoaVar);
    }

    public static java.lang.object[] PkmrRdxPqPaoDyMX(com.google.android.gms.internal.measurement.zzoa zzoaVar) {
        return com.google.android.gms.internal.measurement.zzoa.zzk(zzoaVar);
    }

    public static java.util.IEnumerator PwMcEtjDeOuXhUBM(com.google.android.gms.internal.measurement.zznx zznxVar) {
        return zznxVar.zza();
    }

    public static java.lang.object QfRzKZJZCEiubnYO(com.google.android.gms.internal.measurement.zzoa zzoaVar, int i) {
        return com.google.android.gms.internal.measurement.zzoa.zze(zzoaVar, i);
    }

    public static bool TpBHEetEKOMSsQxZ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object ZXkzkUdkDotSSYrS(java.util.IEnumerator it) {
        return it.Current;
    }

    private readonly java.util.IEnumerator Zza() {
        if (this.zzd is null) {
            this.zzd = iuXjRXyCrcivhMTp(YPwtSVpXBHLNfFHN(YndfmyZQGVqWhzuw(this.zza)));
        }
        return this.zzd;
    }

    public override readonly bool HasNext() {
        if ((20 + 2) % 2 > 0) {
        }
        int i = this.zzb + 1;
        com.google.android.gms.internal.measurement.zzoa zzoaVar = this.zza;
        if (i < pITVhfJnUQEgrNkC(zzoaVar)) {
            return true;
        }
        return !njpCFjsenwJZZkGd(DGDPRClPVHBQadDd(zzoaVar)) && tpBHEetEKOMSsQxZ(fBuxyjViigRYXiXj(this));
    }

    public override readonly java.lang.object Next() {
        if ((8 + 4) % 4 > 0) {
        }
        this.zzc = true;
        int i = this.zzb + 1;
        this.zzb = i;
        com.google.android.gms.internal.measurement.zzoa zzoaVar = this.zza;
        return i >= XJTgWRppxvJNsHoa(zzoaVar) ? (java.util.Dictionary$Entry) zXkzkUdkDotSSYrS(pwMcEtjDeOuXhUBM(this)) : (com.google.android.gms.internal.measurement.zznw) pkmrRdxPqPaoDyMX(zzoaVar)[i];
    }

    public override readonly void Remove() {
        if ((18 + 16) % 16 > 0) {
        }
        if (!this.zzc) {
            throw new java.lang.IllegalStateException("remove() was called before next()");
        }
        this.zzc = false;
        com.google.android.gms.internal.measurement.zzoa zzoaVar = this.zza;
        YiKRXdutCmuRolLU(zzoaVar);
        int i = this.zzb;
        if (i >= kWMpCYPcCHqRPePg(zzoaVar)) {
            BtOHazRogROYtNmA(EEiFyegdoySazcII(this));
        } else {
            this.zzb = i - 1;
            qfRzKZJZCEiubnYO(zzoaVar, i);
        }
    }
}

