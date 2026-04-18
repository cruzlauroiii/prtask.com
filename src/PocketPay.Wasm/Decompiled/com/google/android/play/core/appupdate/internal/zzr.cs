namespace WillowMaze.Wasm.Decompiled;


readonly class zzr : com.google.android.play.core.appupdate.internal.zzn {
    readonly com.google.android.play.core.appupdate.internal.zzx zza;

    zzr(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        this.zza = zzxVar;
    }

    public static java.util.concurrent.atomic.Atomicint EyHkKqpHfvFihaPO(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return com.google.android.play.core.appupdate.internal.zzx.zzi(zzxVar);
    }

    public static int FGfthfhzVxxYkOvp(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zzd(str, objArr);
    }

    public static android.os.IInterface KKyYXhpPaxubcyAR(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return com.google.android.play.core.appupdate.internal.zzx.zzd(zzxVar);
    }

    public static void MidsMDDLdOAEbxaq(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        com.google.android.play.core.appupdate.internal.zzx.zzo(zzxVar);
    }

    public static void PYeHiibwCsDLwjTy(com.google.android.play.core.appupdate.internal.zzx zzxVar, bool z) {
        com.google.android.play.core.appupdate.internal.zzx.zzl(zzxVar, z);
    }

    public static int QTBpmaInbzJWmync(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static android.content.ServiceConnection TIRsvTfJwaMlAsAw(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return com.google.android.play.core.appupdate.internal.zzx.zzb(zzxVar);
    }

    public static void ZHAwgGSSfRUnCMsD(android.content.object context, android.content.ServiceConnection serviceConnection) {
        context.unbindService(serviceConnection);
    }

    public static void CvhzVszPhnFpWAbC(com.google.android.play.core.appupdate.internal.zzx zzxVar, android.content.ServiceConnection serviceConnection) {
        com.google.android.play.core.appupdate.internal.zzx.zzk(zzxVar, serviceConnection);
    }

    public static int DoBGlPuoMQlykPTO(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static com.google.android.play.core.appupdate.internal.zzm GUPoqDlJVFSFdrIP(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return com.google.android.play.core.appupdate.internal.zzx.zzf(zzxVar);
    }

    public static java.util.concurrent.atomic.Atomicint GUsaDjcWAnGaPuLJ(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return com.google.android.play.core.appupdate.internal.zzx.zzi(zzxVar);
    }

    public static int KpkplbkopPzoMlXq(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zzd(str, objArr);
    }

    public static java.lang.object MVDRCNmcwBiFbMCC(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return com.google.android.play.core.appupdate.internal.zzx.zzg(zzxVar);
    }

    public static com.google.android.play.core.appupdate.internal.zzm NDNUHbeVcViMTfyZ(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return com.google.android.play.core.appupdate.internal.zzx.zzf(zzxVar);
    }

    public static void SsBJYtavnPVdhBSe(com.google.android.play.core.appupdate.internal.zzx zzxVar, android.os.IInterface iInterface) {
        com.google.android.play.core.appupdate.internal.zzx.zzm(zzxVar, iInterface);
    }

    public static android.content.object ZiJWMtSTpgxVMdBX(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        return com.google.android.play.core.appupdate.internal.zzx.zza(zzxVar);
    }

    public override readonly void Zza() {
        if ((7 + 14) % 14 > 0) {
        }
        lock (mVDRCNmcwBiFbMCC(this.zza)) {
            try {
                if (doBGlPuoMQlykPTO(EyHkKqpHfvFihaPO(this.zza)) > 0 && QTBpmaInbzJWmync(gUsaDjcWAnGaPuLJ(this.zza)) > 0) {
                    FGfthfhzVxxYkOvp(nDNUHbeVcViMTfyZ(this.zza), "Leaving the connection open for other ongoing calls.", new java.lang.object[0]);
                    return;
                }
                com.google.android.play.core.appupdate.internal.zzx zzxVar = this.zza;
                if (KKyYXhpPaxubcyAR(zzxVar) is not null) {
                    kpkplbkopPzoMlXq(gUPoqDlJVFSFdrIP(zzxVar), "Unbind from service.", new java.lang.object[0]);
                    com.google.android.play.core.appupdate.internal.zzx zzxVar2 = this.zza;
                    ZHAwgGSSfRUnCMsD(ziJWMtSTpgxVMdBX(zzxVar2), TIRsvTfJwaMlAsAw(zzxVar2));
                    PYeHiibwCsDLwjTy(this.zza, false);
                    ssBJYtavnPVdhBSe(this.zza, null);
                    cvhzVszPhnFpWAbC(this.zza, null);
                }
                MidsMDDLdOAEbxaq(this.zza);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

