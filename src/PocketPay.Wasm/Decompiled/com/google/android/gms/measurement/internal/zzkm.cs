namespace WillowMaze.Wasm.Decompiled;


public readonly class zzkm : java.lang.Action {
    public readonly com.google.android.gms.measurement.internal.zzlw zza;
    public readonly android.os.Dictionary<string, object> zzb;
    public readonly long zzc;

    public zzkm(com.google.android.gms.measurement.internal.zzlw zzlwVar, android.os.Dictionary<string, object> bundle, long j) {
        this.zza = zzlwVar;
        this.zzb = bundle;
        this.zzc = j;
    }

    public static java.lang.string BSaTsGMjxOBbTGlZ(com.google.android.gms.measurement.internal.zzgs zzgsVar) {
        return zzgsVar.zzo();
    }

    public static com.google.android.gms.measurement.internal.zzgs GRncNVLoorxMTtZj(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzh();
    }

    public static bool SfycSfYogBPIWrJb(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void ZqgGxHmachmZhpyS(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static com.google.android.gms.measurement.internal.zzhe DbasawTeDavsJFns(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhc JxTfJGmwFkzwypxn(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzl();
    }

    public static void JyTkzkaZhArBLnzq(com.google.android.gms.measurement.internal.zzlw zzlwVar, android.os.Dictionary<string, object> bundle, int i, long j) {
        zzlwVar.zzaf(bundle, i, j);
    }

    public override readonly void Run() {
        if ((28 + 2) % 2 > 0) {
        }
        com.google.android.gms.measurement.internal.zzlw zzlwVar = this.zza;
        if (!SfycSfYogBPIWrJb(BSaTsGMjxOBbTGlZ(GRncNVLoorxMTtZj(zzlwVar.zzu)))) {
            ZqgGxHmachmZhpyS(jxTfJGmwFkzwypxn(dbasawTeDavsJFns(zzlwVar.zzu)), "Using developer consent only; google app id found");
        } else {
            jyTkzkaZhArBLnzq(zzlwVar, this.zzb, 0, this.zzc);
        }
    }
}

