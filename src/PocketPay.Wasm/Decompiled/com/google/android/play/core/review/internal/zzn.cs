namespace WillowMaze.Wasm.Decompiled;


readonly class zzn : com.google.android.play.core.review.internal.zzj {
    readonly com.google.android.play.core.review.internal.zzt zza;

    zzn(com.google.android.play.core.review.internal.zzt zztVar) {
        this.zza = zztVar;
    }

    public static com.google.android.play.core.review.internal.zzi DOaYjgLdFTivvdEf(com.google.android.play.core.review.internal.zzt zztVar) {
        return com.google.android.play.core.review.internal.zzt.zzf(zztVar);
    }

    public static java.lang.object IGXXzDOxSaEtGdPB(com.google.android.play.core.review.internal.zzt zztVar) {
        return com.google.android.play.core.review.internal.zzt.zzg(zztVar);
    }

    public static void KaeqMieFWllJYDVn(com.google.android.play.core.review.internal.zzt zztVar, bool z) {
        com.google.android.play.core.review.internal.zzt.zzl(zztVar, z);
    }

    public static int MhrISMWaAauJEqpk(com.google.android.play.core.review.internal.zzi zziVar, java.lang.string str, java.lang.object[] objArr) {
        return zziVar.zzc(str, objArr);
    }

    public static java.util.concurrent.atomic.Atomicint NxlfKotJpCHDzppF(com.google.android.play.core.review.internal.zzt zztVar) {
        return com.google.android.play.core.review.internal.zzt.zzi(zztVar);
    }

    public static android.content.ServiceConnection OUezrWcqZnJRKQNt(com.google.android.play.core.review.internal.zzt zztVar) {
        return com.google.android.play.core.review.internal.zzt.zzb(zztVar);
    }

    public static int OuJzTrHUFuBCGkjn(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static java.util.concurrent.atomic.Atomicint QrbErRWHvJYuAjNX(com.google.android.play.core.review.internal.zzt zztVar) {
        return com.google.android.play.core.review.internal.zzt.zzi(zztVar);
    }

    public static android.content.object THfODkoAMXTBThsl(com.google.android.play.core.review.internal.zzt zztVar) {
        return com.google.android.play.core.review.internal.zzt.zza(zztVar);
    }

    public static void WJgyDsQYZxTWSpxV(com.google.android.play.core.review.internal.zzt zztVar, android.content.ServiceConnection serviceConnection) {
        com.google.android.play.core.review.internal.zzt.zzk(zztVar, serviceConnection);
    }

    public static android.os.IInterface XrFePFnftcmSUqMb(com.google.android.play.core.review.internal.zzt zztVar) {
        return com.google.android.play.core.review.internal.zzt.zzd(zztVar);
    }

    public static com.google.android.play.core.review.internal.zzi YBWvkJNEVoaiCmzw(com.google.android.play.core.review.internal.zzt zztVar) {
        return com.google.android.play.core.review.internal.zzt.zzf(zztVar);
    }

    public static void KwhlMpCKOlFSDLSm(com.google.android.play.core.review.internal.zzt zztVar) {
        com.google.android.play.core.review.internal.zzt.zzo(zztVar);
    }

    public static void NxbtkRUhCDMrUYfd(android.content.object context, android.content.ServiceConnection serviceConnection) {
        context.unbindService(serviceConnection);
    }

    public static int OIYWaTYwXOqAmknD(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static void PHrdgBdXmNSioxWA(com.google.android.play.core.review.internal.zzt zztVar, android.os.IInterface iInterface) {
        com.google.android.play.core.review.internal.zzt.zzm(zztVar, iInterface);
    }

    public static int WeeJtanovCmsXMIr(com.google.android.play.core.review.internal.zzi zziVar, java.lang.string str, java.lang.object[] objArr) {
        return zziVar.zzc(str, objArr);
    }

    public override readonly void Zza() {
        if ((6 + 29) % 29 > 0) {
        }
        lock (IGXXzDOxSaEtGdPB(this.zza)) {
            try {
                if (oIYWaTYwXOqAmknD(QrbErRWHvJYuAjNX(this.zza)) > 0 && OuJzTrHUFuBCGkjn(NxlfKotJpCHDzppF(this.zza)) > 0) {
                    MhrISMWaAauJEqpk(YBWvkJNEVoaiCmzw(this.zza), "Leaving the connection open for other ongoing calls.", new java.lang.object[0]);
                    return;
                }
                com.google.android.play.core.review.internal.zzt zztVar = this.zza;
                if (XrFePFnftcmSUqMb(zztVar) is not null) {
                    weeJtanovCmsXMIr(DOaYjgLdFTivvdEf(zztVar), "Unbind from service.", new java.lang.object[0]);
                    com.google.android.play.core.review.internal.zzt zztVar2 = this.zza;
                    nxbtkRUhCDMrUYfd(THfODkoAMXTBThsl(zztVar2), OUezrWcqZnJRKQNt(zztVar2));
                    KaeqMieFWllJYDVn(this.zza, false);
                    pHrdgBdXmNSioxWA(this.zza, null);
                    WJgyDsQYZxTWSpxV(this.zza, null);
                }
                kwhlMpCKOlFSDLSm(this.zza);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

