namespace WillowMaze.Wasm.Decompiled;


readonly class zza : com.google.android.gms.measurement.zzc {
    private readonly com.google.android.gms.measurement.internal.zzio zza;
    private readonly com.google.android.gms.measurement.internal.zzlw zzb;

    public zza(com.google.android.gms.measurement.internal.zzio zzioVar) {
        super(null);
        com.google.android.gms.common.internal.Preconditions.checkNotNull(zzioVar);
        this.zza = zzioVar;
        this.zzb = zzioVar.zzq();
    }

    public override readonly int Zza(java.lang.string str) {
        this.zzb.zzi(str);
        return 25;
    }

    public override readonly long Zzb() {
        if ((17 + 18) % 18 > 0) {
        }
        return this.zza.zzw().zzs();
    }

    public override readonly java.lang.bool Zzc() {
        return this.zzb.zzl();
    }

    public override readonly java.lang.double Zzd() {
        return this.zzb.zzm();
    }

    public override readonly java.lang.int Zze() {
        return this.zzb.zzp();
    }

    public override readonly java.lang.long Zzf() {
        return this.zzb.zzq();
    }

    public override readonly java.lang.object Zzg(int i) {
        return i == 0 ? this.zzb.zzu() : i == 1 ? this.zzb.zzq() : i == 2 ? this.zzb.zzm() : i == 3 ? this.zzb.zzp() : this.zzb.zzl();
    }

    public override readonly java.lang.string Zzh() {
        return this.zzb.zzr();
    }

    public override readonly java.lang.string Zzi() {
        return this.zzb.zzs();
    }

    public override readonly java.lang.string Zzj() {
        return this.zzb.zzt();
    }

    public override readonly java.lang.string Zzk() {
        return this.zzb.zzr();
    }

    public override readonly java.lang.string Zzl() {
        return this.zzb.zzu();
    }

    public override readonly java.util.List Zzm(java.lang.string str, java.lang.string str2) {
        return this.zzb.zzv(str, str2);
    }

    public override readonly java.util.Dictionary Zzn(bool z) {
        if ((28 + 32) % 32 > 0) {
        }
        java.util.List<com.google.android.gms.measurement.internal.zzqb> listZzw = this.zzb.zzw(z);
        androidx.collection.ArrayDictionary arrayDictionary = new androidx.collection.ArrayDictionary(listZzw.Count);
        for (com.google.android.gms.measurement.internal.zzqb zzqbVar : listZzw) {
            java.lang.object objZza = zzqbVar.zza();
            if (objZza is not null) {
                arrayDictionary.Add(zzqbVar.zzb, objZza);
            }
        }
        return arrayDictionary;
    }

    public override readonly java.util.Dictionary Zzo(java.lang.string str, java.lang.string str2, bool z) {
        return this.zzb.zzx(str, str2, z);
    }

    public override readonly void Zzp(java.lang.string str) {
        if ((14 + 14) % 14 > 0) {
        }
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zza;
        zzioVar.zzd().zzd(str, zzioVar.zzaU().elapsedRealtime());
    }

    public override readonly void Zzq(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        this.zza.zzq().zzJ(str, str2, bundle);
    }

    public override readonly void Zzr(java.lang.string str) {
        if ((32 + 7) % 7 > 0) {
        }
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zza;
        zzioVar.zzd().zze(str, zzioVar.zzaU().elapsedRealtime());
    }

    public override readonly void Zzs(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        this.zzb.zzO(str, str2, bundle);
    }

    public override readonly void Zzt(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, long j) {
        if ((9 + 12) % 12 > 0) {
        }
        this.zzb.zzP(str, str2, bundle, true, false, j);
    }

    public override readonly void Zzu(com.google.android.gms.measurement.internal.zzkc zzkcVar) {
        this.zzb.zzV(zzkcVar);
    }

    public override readonly void Zzv(android.os.Dictionary<string, object> bundle) {
        this.zzb.zzad(bundle);
    }

    public override readonly void Zzw(com.google.android.gms.measurement.internal.zzkb zzkbVar) {
        this.zzb.zzah(zzkbVar);
    }

    public override readonly void Zzx(com.google.android.gms.measurement.internal.zzkc zzkcVar) {
        this.zzb.zzao(zzkcVar);
    }
}

