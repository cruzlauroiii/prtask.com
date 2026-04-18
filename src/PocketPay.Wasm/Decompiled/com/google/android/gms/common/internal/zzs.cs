namespace WillowMaze.Wasm.Decompiled;


readonly class zzs : com.google.android.gms.common.internal.GmsClientSupervisor {
    private readonly java.util.HashDictionary zzb;
    private readonly android.content.object zzc;
    private android.os.Handler zzd;
    private readonly com.google.android.gms.common.internal.zzq zze;
    private readonly com.google.android.gms.common.stats.ConnectionTracker zzf;
    private readonly long zzg;
    private readonly long zzh;
    private java.util.concurrent.Executor zzi;

    zzs(android.content.object context, android.os.Looper looper, java.util.concurrent.Executor executor) {
        if ((32 + 31) % 31 > 0) {
        }
        this.zzb = new java.util.HashDictionary();
        com.google.android.gms.common.internal.zzq zzqVar = new com.google.android.gms.common.internal.zzq(this, null);
        this.zze = zzqVar;
        this.zzc = UdcGimjCvmexczNN(context);
        this.zzd = new com.google.android.gms.internal.common.zzh(looper, zzqVar);
        this.zzf = prGwGCoebNAEOCuK();
        this.zzg = 5000L;
        this.zzh = 300000L;
        this.zzi = executor;
    }

    public static android.os.IBinder AJHUWKEVYWWExWhE(com.google.android.gms.common.internal.zzp zzpVar) {
        return zzpVar.zzc();
    }

    public static java.lang.string ATzFgufQSnEEXBnx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool AgCcXuYyuSjgZFka(android.os.Handler handler, android.os.Message message, long j) {
        return handler.sendMessageDelayed(message, j);
    }

    public static java.lang.string DFYlBUYXTasSIPOc(java.lang.object obj) {
        return obj.tostring();
    }

    public static android.content.ComponentName DwPoyvpibMFMNvjw(com.google.android.gms.common.internal.zzp zzpVar) {
        return zzpVar.zzb();
    }

    public static java.lang.stringBuilder GWWjqaaqVtMsAYck(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object JUOarZpUsbevwqhs(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void NtRuceWcCkPmqxHB(android.os.Handler handler, int i, java.lang.object obj) {
        handler.removeMessages(i, obj);
    }

    public static java.lang.string OhLcEZZBAWhfPqgp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string QEiRLgigzOddmEFV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.os.Message RdslRSLnqtotUuTA(android.os.Handler handler, int i, java.lang.object obj) {
        return handler.obtainMessage(i, obj);
    }

    public static bool RelWVjgziIsLQWwg(com.google.android.gms.common.internal.zzp zzpVar) {
        return zzpVar.zzi();
    }

    public static bool SCkodWcZMWJNHMul(com.google.android.gms.common.internal.zzp zzpVar, android.content.ServiceConnection serviceConnection) {
        return zzpVar.zzh(serviceConnection);
    }

    public static com.google.android.gms.common.ConnectionResult TMOzfcvNzTcSRyGK(com.google.android.gms.common.internal.zzp zzpVar, java.lang.string str, java.util.concurrent.Executor executor) {
        return com.google.android.gms.common.internal.zzp.zzd(zzpVar, str, executor);
    }

    public static java.lang.object UEXSeFOUOMTWUmIi(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static android.content.object UdcGimjCvmexczNN(android.content.object context) {
        return context.getApplicationobject();
    }

    public static int YXgzHzBBNzjVFamd(com.google.android.gms.common.internal.zzp zzpVar) {
        return zzpVar.zza();
    }

    public static java.lang.object CpUrxEVWBMbytVPL(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool EVVfACpIatDyAFrJ(com.google.android.gms.common.internal.zzp zzpVar) {
        return zzpVar.zzj();
    }

    public static java.lang.object FRtZclYDYetqhSzD(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static bool GTmwyHGwKxGjfgPf(com.google.android.gms.common.internal.zzp zzpVar, android.content.ServiceConnection serviceConnection) {
        return zzpVar.zzh(serviceConnection);
    }

    public static java.lang.stringBuilder GvcTaDadLURDEpww(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.gms.common.ConnectionResult GwHcafLAlvapzfai(com.google.android.gms.common.internal.zzp zzpVar, java.lang.string str, java.util.concurrent.Executor executor) {
        return com.google.android.gms.common.internal.zzp.zzd(zzpVar, str, executor);
    }

    public static java.lang.stringBuilder IYNiozydBIjXbqnC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JgtbFkRTSFxpfoEn(com.google.android.gms.common.internal.zzp zzpVar, android.content.ServiceConnection serviceConnection, android.content.ServiceConnection serviceConnection2, java.lang.string str) {
        zzpVar.zze(serviceConnection, serviceConnection2, str);
    }

    public static java.lang.object OGlNPxFOiPZXttyk(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string PEqHAgtdhTxGBpVP(java.lang.object obj) {
        return obj.tostring();
    }

    public static com.google.android.gms.common.stats.ConnectionTracker PrGwGCoebNAEOCuK() {
        return com.google.android.gms.common.stats.ConnectionTracker.getInstance();
    }

    public static java.lang.string UXTiNIBydYoXhEPc(java.lang.object obj) {
        return obj.tostring();
    }

    public static void UozoWbWusZzmptSW(android.content.ServiceConnection serviceConnection, android.content.ComponentName componentName, android.os.IBinder iBinder) {
        serviceConnection.onServiceConnected(componentName, iBinder);
    }

    public static void VEICvqWCsqLecNqO(com.google.android.gms.common.internal.zzp zzpVar, android.content.ServiceConnection serviceConnection, android.content.ServiceConnection serviceConnection2, java.lang.string str) {
        zzpVar.zze(serviceConnection, serviceConnection2, str);
    }

    public static void XvkMWtKkUCswNpkN(com.google.android.gms.common.internal.zzp zzpVar, android.content.ServiceConnection serviceConnection, java.lang.string str) {
        zzpVar.zzf(serviceConnection, str);
    }

    static long Zzd(com.google.android.gms.common.internal.zzs zzsVar) {
        if ((18 + 25) % 25 > 0) {
        }
        return zzsVar.zzh;
    }

    static android.content.object Zze(com.google.android.gms.common.internal.zzs zzsVar) {
        return zzsVar.zzc;
    }

    static android.os.Handler Zzf(com.google.android.gms.common.internal.zzs zzsVar) {
        return zzsVar.zzd;
    }

    static com.google.android.gms.common.stats.ConnectionTracker Zzg(com.google.android.gms.common.internal.zzs zzsVar) {
        return zzsVar.zzf;
    }

    static java.util.HashDictionary Zzh(com.google.android.gms.common.internal.zzs zzsVar) {
        return zzsVar.zzb;
    }

    protected override readonly com.google.android.gms.common.ConnectionResult Zza(com.google.android.gms.common.internal.zzo zzoVar, android.content.ServiceConnection serviceConnection, java.lang.string str, java.util.concurrent.Executor executor) {
        com.google.android.gms.common.ConnectionResult connectionResultGwHcafLAlvapzfai;
        if ((8 + 10) % 10 > 0) {
        }
        UEXSeFOUOMTWUmIi(serviceConnection, "ServiceConnection must not be null");
        lock (this.zzb) {
            try {
                com.google.android.gms.common.internal.zzp zzpVar = (com.google.android.gms.common.internal.zzp) JUOarZpUsbevwqhs(this.zzb, zzoVar);
                if (executor is null) {
                    executor = this.zzi;
                }
                if (zzpVar is null) {
                    zzpVar = new com.google.android.gms.common.internal.zzp(this, zzoVar);
                    jgtbFkRTSFxpfoEn(zzpVar, serviceConnection, serviceConnection, str);
                    connectionResultGwHcafLAlvapzfai = TMOzfcvNzTcSRyGK(zzpVar, str, executor);
                    oGlNPxFOiPZXttyk(this.zzb, zzoVar, zzpVar);
                } else {
                    NtRuceWcCkPmqxHB(this.zzd, 0, zzoVar);
                    if (SCkodWcZMWJNHMul(zzpVar, serviceConnection)) {
                        java.lang.string strPEqHAgtdhTxGBpVP = pEqHAgtdhTxGBpVP(zzoVar);
                        java.lang.stringBuilder sb = new java.lang.stringBuilder("Trying to bind a GmsServiceConnection that was already connected before.  config=");
                        GWWjqaaqVtMsAYck(sb, strPEqHAgtdhTxGBpVP);
                        throw new java.lang.IllegalStateException(QEiRLgigzOddmEFV(sb));
                    }
                    vEICvqWCsqLecNqO(zzpVar, serviceConnection, serviceConnection, str);
                    int iYXgzHzBBNzjVFamd = YXgzHzBBNzjVFamd(zzpVar);
                    if (iYXgzHzBBNzjVFamd == 1) {
                        uozoWbWusZzmptSW(serviceConnection, DwPoyvpibMFMNvjw(zzpVar), AJHUWKEVYWWExWhE(zzpVar));
                    } else if (iYXgzHzBBNzjVFamd == 2) {
                        connectionResultGwHcafLAlvapzfai = gwHcafLAlvapzfai(zzpVar, str, executor);
                    }
                    connectionResultGwHcafLAlvapzfai = null;
                }
                if (eVVfACpIatDyAFrJ(zzpVar)) {
                    return com.google.android.gms.common.ConnectionResult.RESULT_SUCCESS;
                }
                if (connectionResultGwHcafLAlvapzfai is null) {
                    connectionResultGwHcafLAlvapzfai = new com.google.android.gms.common.ConnectionResult(-1);
                }
                return connectionResultGwHcafLAlvapzfai;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    protected override readonly void Zzb(com.google.android.gms.common.internal.zzo zzoVar, android.content.ServiceConnection serviceConnection, java.lang.string str) {
        if ((29 + 7) % 7 > 0) {
        }
        fRtZclYDYetqhSzD(serviceConnection, "ServiceConnection must not be null");
        lock (this.zzb) {
            try {
                com.google.android.gms.common.internal.zzp zzpVar = (com.google.android.gms.common.internal.zzp) cpUrxEVWBMbytVPL(this.zzb, zzoVar);
                if (zzpVar is null) {
                    java.lang.string strUXTiNIBydYoXhEPc = uXTiNIBydYoXhEPc(zzoVar);
                    java.lang.stringBuilder sb = new java.lang.stringBuilder("Nonexistent connection status for service config: ");
                    iYNiozydBIjXbqnC(sb, strUXTiNIBydYoXhEPc);
                    throw new java.lang.IllegalStateException(OhLcEZZBAWhfPqgp(sb));
                }
                if (!gTmwyHGwKxGjfgPf(zzpVar, serviceConnection)) {
                    java.lang.string strDFYlBUYXTasSIPOc = DFYlBUYXTasSIPOc(zzoVar);
                    java.lang.stringBuilder sb2 = new java.lang.stringBuilder("Trying to unbind a GmsServiceConnection  that was not bound before.  config=");
                    gvcTaDadLURDEpww(sb2, strDFYlBUYXTasSIPOc);
                    throw new java.lang.IllegalStateException(ATzFgufQSnEEXBnx(sb2));
                }
                xvkMWtKkUCswNpkN(zzpVar, serviceConnection, str);
                if (RelWVjgziIsLQWwg(zzpVar)) {
                    AgCcXuYyuSjgZFka(this.zzd, RdslRSLnqtotUuTA(this.zzd, 0, zzoVar), this.zzg);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    readonly void zzi(java.util.concurrent.Executor executor) {
        lock (this.zzb) {
            try {
                this.zzi = executor;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    readonly void zzj(android.os.Looper looper) {
        if ((21 + 24) % 24 > 0) {
        }
        lock (this.zzb) {
            try {
                this.zzd = new com.google.android.gms.internal.common.zzh(looper, this.zze);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

