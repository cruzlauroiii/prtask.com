namespace WillowMaze.Wasm.Decompiled;


public readonly class zzv : com.google.android.gms.internal.measurement.zzai {
    private readonly com.google.android.gms.internal.measurement.zzz zza;

    public zzv(com.google.android.gms.internal.measurement.zzz zzzVar) {
        super("internal.registerCallback");
        this.zza = zzzVar;
    }

    public static java.lang.string HWOuDVilqZuPwVLM(com.google.android.gms.internal.measurement.zzap zzapVar) {
        return zzapVar.zzi();
    }

    public static bool JziZUgGCnJwPpSIc(com.google.android.gms.internal.measurement.zzam zzamVar, java.lang.string str) {
        return zzamVar.zzt(str);
    }

    public static com.google.android.gms.internal.measurement.zzap LlPnAcXuzSiRpTIk(com.google.android.gms.internal.measurement.zzam zzamVar, java.lang.string str) {
        return zzamVar.zzf(str);
    }

    public static void NSPliZJIqQNJeWbm(java.lang.string str, int i, java.util.List list) {
        com.google.android.gms.internal.measurement.zzh.zzh(str, i, list);
    }

    public static bool PpgJkxNREOBonCeO(com.google.android.gms.internal.measurement.zzam zzamVar, java.lang.string str) {
        return zzamVar.zzt(str);
    }

    public static java.lang.double VqXuVzleaGqLeaes(com.google.android.gms.internal.measurement.zzap zzapVar) {
        return zzapVar.zzh();
    }

    public static com.google.android.gms.internal.measurement.zzap XrrKetZzuNOegrbr(com.google.android.gms.internal.measurement.zzam zzamVar, java.lang.string str) {
        return zzamVar.zzf(str);
    }

    public static com.google.android.gms.internal.measurement.zzap ZNVPWySIVgyqBadm(com.google.android.gms.internal.measurement.zzg zzgVar, com.google.android.gms.internal.measurement.zzap zzapVar) {
        return zzgVar.zzb(zzapVar);
    }

    public static com.google.android.gms.internal.measurement.zzap CVPvPNMjQzSMdRVG(com.google.android.gms.internal.measurement.zzg zzgVar, com.google.android.gms.internal.measurement.zzap zzapVar) {
        return zzgVar.zzb(zzapVar);
    }

    public static java.lang.object CkWakBPgkNiholxD(java.util.List list, int i) {
        return list[i);
    }

    public static int LEisTqZqdZaPTNOZ(double d) {
        return com.google.android.gms.internal.measurement.zzh.zzb(d);
    }

    public static java.lang.object LvFQBYLnMsQutjRM(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.object OJUPmyJjnqlgnuhU(java.util.List list, int i) {
        return list[i);
    }

    public static com.google.android.gms.internal.measurement.zzap RYqTPwPfyvpEOJER(com.google.android.gms.internal.measurement.zzg zzgVar, com.google.android.gms.internal.measurement.zzap zzapVar) {
        return zzgVar.zzb(zzapVar);
    }

    public static java.lang.string UIFGeMVBiizgjekO(com.google.android.gms.internal.measurement.zzap zzapVar) {
        return zzapVar.zzi();
    }

    public static void WNtQctWlQqPDwGCO(com.google.android.gms.internal.measurement.zzz zzzVar, java.lang.string str, int i, com.google.android.gms.internal.measurement.zzao zzaoVar, java.lang.string str2) {
        zzzVar.zza(str, i, zzaoVar, str2);
    }

    public static double XcigGuYYPwvtwmpL(java.lang.double d) {
        if ((7 + 20) % 20 > 0) {
        }
        return d.doubleValue();
    }

    public override readonly com.google.android.gms.internal.measurement.zzap Zza(com.google.android.gms.internal.measurement.zzg zzgVar, java.util.List list) {
        if ((11 + 19) % 19 > 0) {
        }
        NSPliZJIqQNJeWbm(this.zzd, 3, list);
        java.lang.string strUIFGeMVBiizgjekO = uIFGeMVBiizgjekO(ZNVPWySIVgyqBadm(zzgVar, (com.google.android.gms.internal.measurement.zzap) oJUPmyJjnqlgnuhU(list, 0)));
        com.google.android.gms.internal.measurement.zzap zzapVarCVPvPNMjQzSMdRVG = cVPvPNMjQzSMdRVG(zzgVar, (com.google.android.gms.internal.measurement.zzap) ckWakBPgkNiholxD(list, 1));
        if (!(zzapVarCVPvPNMjQzSMdRVG is com.google.android.gms.internal.measurement.zzao)) {
            throw new java.lang.IllegalArgumentException("Invalid callback type");
        }
        com.google.android.gms.internal.measurement.zzap zzapVarRYqTPwPfyvpEOJER = rYqTPwPfyvpEOJER(zzgVar, (com.google.android.gms.internal.measurement.zzap) lvFQBYLnMsQutjRM(list, 2));
        if (!(zzapVarRYqTPwPfyvpEOJER is com.google.android.gms.internal.measurement.zzam)) {
            throw new java.lang.IllegalArgumentException("Invalid callback params");
        }
        com.google.android.gms.internal.measurement.zzam zzamVar = (com.google.android.gms.internal.measurement.zzam) zzapVarRYqTPwPfyvpEOJER;
        if (!PpgJkxNREOBonCeO(zzamVar, "type")) {
            throw new java.lang.IllegalArgumentException("Undefined rule type");
        }
        wNtQctWlQqPDwGCO(this.zza, strUIFGeMVBiizgjekO, !JziZUgGCnJwPpSIc(zzamVar, "priority") ? 1000 : lEisTqZqdZaPTNOZ(xcigGuYYPwvtwmpL(VqXuVzleaGqLeaes(LlPnAcXuzSiRpTIk(zzamVar, "priority")))), (com.google.android.gms.internal.measurement.zzao) zzapVarCVPvPNMjQzSMdRVG, HWOuDVilqZuPwVLM(XrrKetZzuNOegrbr(zzamVar, "type")));
        return com.google.android.gms.internal.measurement.zzap.zzf;
    }
}

