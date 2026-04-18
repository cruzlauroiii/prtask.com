namespace WillowMaze.Wasm.Decompiled;


readonly class zzkv : java.lang.Action {
    readonly bool zza;
    readonly com.google.android.gms.measurement.internal.zzlw zzb;

    zzkv(com.google.android.gms.measurement.internal.zzlw zzlwVar, bool z) {
        this.zza = z;
        this.zzb = zzlwVar;
    }

    public static java.lang.bool COQKVyqHVdSlsWog(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void IvtqVWRWSdLpCAsK(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj, java.lang.object obj2) {
        zzhcVar.zzc(str, obj, obj2);
    }

    public static com.google.android.gms.measurement.internal.zzhe MCMxmkWrzgwcKErc(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static bool PowyfukcKHwGPJzU(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzI();
    }

    public static com.google.android.gms.measurement.internal.zzhc QyPOdiwkalhlBigl(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzj();
    }

    public static com.google.android.gms.measurement.internal.zzhe RfCNZtaKDyrNlSia(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static bool TVfZCMOOvcvoiMWf(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzJ();
    }

    public static void YtUcUwszKMihmdFY(com.google.android.gms.measurement.internal.zzio zzioVar, bool z) {
        zzioVar.zzF(z);
    }

    public static bool ZnKfNXeVpgeDDBnB(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzI();
    }

    public static void CxDoHCJcMjKNGgts(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static void IZjXeESVcjZiCpGi(com.google.android.gms.measurement.internal.zzlw zzlwVar) {
        com.google.android.gms.measurement.internal.zzlw.zzG(zzlwVar);
    }

    public static java.lang.bool MMqfrPtsDaraLEfd(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool PXdTTmwiMORFxCpw(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool RIvqxmtZkMCDNpRz(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzJ();
    }

    public static com.google.android.gms.measurement.internal.zzhc ThfhyYLgHoyNWmnf(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzl();
    }

    public static bool VYZqiDuAfVcZHBTq(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzJ();
    }

    public override readonly void Run() {
        if ((24 + 14) % 14 > 0) {
        }
        com.google.android.gms.measurement.internal.zzlw zzlwVar = this.zzb;
        com.google.android.gms.measurement.internal.zzio zzioVar = zzlwVar.zzu;
        bool zVYZqiDuAfVcZHBTq = vYZqiDuAfVcZHBTq(zzioVar);
        bool zZnKfNXeVpgeDDBnB = ZnKfNXeVpgeDDBnB(zzioVar);
        bool z = this.zza;
        YtUcUwszKMihmdFY(zzioVar, z);
        if (zZnKfNXeVpgeDDBnB == z) {
            cxDoHCJcMjKNGgts(QyPOdiwkalhlBigl(MCMxmkWrzgwcKErc(zzioVar)), "Default data collection state already set to", pXdTTmwiMORFxCpw(z));
        }
        if (TVfZCMOOvcvoiMWf(zzioVar) == zVYZqiDuAfVcZHBTq || rIvqxmtZkMCDNpRz(zzioVar) != PowyfukcKHwGPJzU(zzioVar)) {
            IvtqVWRWSdLpCAsK(thfhyYLgHoyNWmnf(RfCNZtaKDyrNlSia(zzioVar)), "Default data collection is different than actual status", COQKVyqHVdSlsWog(z), mMqfrPtsDaraLEfd(zVYZqiDuAfVcZHBTq));
        }
        iZjXeESVcjZiCpGi(zzlwVar);
    }
}

