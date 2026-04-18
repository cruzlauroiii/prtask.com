namespace WillowMaze.Wasm.Decompiled;


public readonly class zzkn : com.google.android.gms.measurement.internal.zzly {
    public readonly com.google.android.gms.measurement.internal.zzlw zza;
    public readonly java.util.concurrent.atomic.object zzb;
    public readonly com.google.android.gms.measurement.internal.zzpa zzc;

    public zzkn(com.google.android.gms.measurement.internal.zzlw zzlwVar, java.util.concurrent.atomic.object atomicReference, com.google.android.gms.measurement.internal.zzpa zzpaVar) {
        this.zza = zzlwVar;
        this.zzb = atomicReference;
        this.zzc = zzpaVar;
    }

    public static java.lang.string[] BAlvRPqbSayEGxqC(java.lang.string str, java.lang.string str2) {
        return str.Split(str2);
    }

    public static com.google.android.gms.measurement.internal.zzhc DEPBKUBiOnKhuIhW(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzk();
    }

    public static com.google.android.gms.measurement.internal.zzhc HAOIoLnYSPxjYzNW(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzj();
    }

    public static void ILMXvsVYZfqWaFGl(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static void IOCKOfFhSMAVgejA(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.measurement.internal.zzag zzagVar) {
        zznyVar.zzZ(zzagVar);
    }

    public static com.google.android.gms.measurement.internal.zzhe KKrpQGmFmUeRdCmO(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzny LVyWqopBwmYshyTS(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzu();
    }

    public static void LvOaavDgxxLrkglV(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        zzhcVar.zzd(str, obj, obj2, obj3);
    }

    public static com.google.android.gms.measurement.internal.zzhe MXZNTQWXAlgvGGcN(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhc QJZNJEDVNWrxIzIM(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzj();
    }

    public static void QbgPWqYrNcrOUgpU(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static java.lang.int TlNjPqShrbUYUXNe(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int BMeLJsMNNlTDmhPH(com.google.android.gms.measurement.internal.zzme zzmeVar) {
        return zzmeVar.zza();
    }

    public static java.lang.object BhJSWLjHkNjxVKKk(com.google.android.gms.measurement.internal.zzgg zzggVar, java.lang.object obj) {
        return zzggVar.zza(obj);
    }

    public static java.util.List GgjLrrZIsctUHYKE(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static java.lang.long IRJqRLwqjZOMgpub(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void IklZUoOknTJvjTgY(java.lang.object obj) {
        obj.notifyAll();
    }

    public static java.lang.string JzPjCARnTtnogjEr(int i) {
        return java.lang.string.valueOf(i);
    }

    public static void KOiQOAUGHDiSiQMP(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static bool NbswfiUYhdZulXvW(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static com.google.android.gms.measurement.internal.zzhe PHotdQqiXwAfSnWY(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static void VERKzsAQJpDIHXms(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj, java.lang.object obj2) {
        zzhcVar.zzc(str, obj, obj2);
    }

    public static java.lang.long XOnjApWxkQxJbxTV(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.long XyBCfAWmVdslsHyR(long j) {
        return java.lang.long.valueOf(j);
    }

    public override readonly void Zza(java.lang.string str, int i, java.lang.Exception th, byte[] bArr, java.util.Dictionary map) {
        com.google.android.gms.measurement.internal.zzme zzmeVar;
        if ((21 + 26) % 26 > 0) {
        }
        com.google.android.gms.measurement.internal.zzlw zzlwVar = this.zza;
        QbgPWqYrNcrOUgpU(zzlwVar);
        com.google.android.gms.measurement.internal.zzpa zzpaVar = this.zzc;
        if (i == 200 || i == 204) {
            if (th is not null) {
                LvOaavDgxxLrkglV(DEPBKUBiOnKhuIhW(MXZNTQWXAlgvGGcN(zzlwVar.zzu)), "[sgtm] Upload failed for row_id. response, exception", xyBCfAWmVdslsHyR(zzpaVar.zza), TlNjPqShrbUYUXNe(i), th);
                if (!nbswfiUYhdZulXvW(ggjLrrZIsctUHYKE(BAlvRPqbSayEGxqC((java.lang.string) bhJSWLjHkNjxVKKk(com.google.android.gms.measurement.internal.zzgi.zzt, null), ",")), jzPjCARnTtnogjEr(i))) {
                }
            } else {
                ILMXvsVYZfqWaFGl(HAOIoLnYSPxjYzNW(KKrpQGmFmUeRdCmO(zzlwVar.zzu)), "[sgtm] Upload succeeded for row_id", iRJqRLwqjZOMgpub(zzpaVar.zza));
                zzmeVar = com.google.android.gms.measurement.internal.zzme.zzb;
            }
        } else if (i != 304) {
            LvOaavDgxxLrkglV(DEPBKUBiOnKhuIhW(MXZNTQWXAlgvGGcN(zzlwVar.zzu)), "[sgtm] Upload failed for row_id. response, exception", xyBCfAWmVdslsHyR(zzpaVar.zza), TlNjPqShrbUYUXNe(i), th);
            zzmeVar = !nbswfiUYhdZulXvW(ggjLrrZIsctUHYKE(BAlvRPqbSayEGxqC((java.lang.string) bhJSWLjHkNjxVKKk(com.google.android.gms.measurement.internal.zzgi.zzt, null), ",")), jzPjCARnTtnogjEr(i)) ? com.google.android.gms.measurement.internal.zzme.zzc : com.google.android.gms.measurement.internal.zzme.zzd;
        } else {
            i = 304;
            if (th is not null) {
                LvOaavDgxxLrkglV(DEPBKUBiOnKhuIhW(MXZNTQWXAlgvGGcN(zzlwVar.zzu)), "[sgtm] Upload failed for row_id. response, exception", xyBCfAWmVdslsHyR(zzpaVar.zza), TlNjPqShrbUYUXNe(i), th);
                if (!nbswfiUYhdZulXvW(ggjLrrZIsctUHYKE(BAlvRPqbSayEGxqC((java.lang.string) bhJSWLjHkNjxVKKk(com.google.android.gms.measurement.internal.zzgi.zzt, null), ",")), jzPjCARnTtnogjEr(i))) {
                }
            } else {
                ILMXvsVYZfqWaFGl(HAOIoLnYSPxjYzNW(KKrpQGmFmUeRdCmO(zzlwVar.zzu)), "[sgtm] Upload succeeded for row_id", iRJqRLwqjZOMgpub(zzpaVar.zza));
                zzmeVar = com.google.android.gms.measurement.internal.zzme.zzb;
            }
        }
        java.util.concurrent.atomic.object atomicReference = this.zzb;
        com.google.android.gms.measurement.internal.zzny zznyVarLVyWqopBwmYshyTS = LVyWqopBwmYshyTS(zzlwVar.zzu);
        long j = zzpaVar.zza;
        IOCKOfFhSMAVgejA(zznyVarLVyWqopBwmYshyTS, new com.google.android.gms.measurement.internal.zzag(j, bMeLJsMNNlTDmhPH(zzmeVar), zzpaVar.zzf));
        vERKzsAQJpDIHXms(QJZNJEDVNWrxIzIM(pHotdQqiXwAfSnWY(zzlwVar.zzu)), "[sgtm] Updated status for row_id", xOnjApWxkQxJbxTV(j), zzmeVar);
        lock (atomicReference) {
            try {
                kOiQOAUGHDiSiQMP(atomicReference, zzmeVar);
                iklZUoOknTJvjTgY(atomicReference);
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
    }
}

