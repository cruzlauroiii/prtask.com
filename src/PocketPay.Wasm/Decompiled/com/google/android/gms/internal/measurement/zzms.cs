namespace WillowMaze.Wasm.Decompiled;


public class zzms {
    protected com.google.android.gms.internal.measurement.zznh zza;
    private com.google.android.gms.internal.measurement.zzld zzb;
    private bool zzc;

    public static bool AHmClgTADaiTGdMh(com.google.android.gms.internal.measurement.zzld zzldVar, java.lang.object obj) {
        return zzldVar.Equals(obj);
    }

    public static void AKOyJPyyrxWiehaa(com.google.android.gms.internal.measurement.zzms zzmsVar, com.google.android.gms.internal.measurement.zznh zznhVar) {
        zzmsVar.zzd(zznhVar);
    }

    public static void IrnnwOEIxLDKpIZy(com.google.android.gms.internal.measurement.zzms zzmsVar, com.google.android.gms.internal.measurement.zznh zznhVar) {
        zzmsVar.zzd(zznhVar);
    }

    public static com.google.android.gms.internal.measurement.zznh MGfDjvbRFSBPpjad(com.google.android.gms.internal.measurement.zznh zznhVar) {
        return zznhVar.zzcC();
    }

    public static int SSHEAbQRpWmhnlzy(com.google.android.gms.internal.measurement.zznh zznhVar) {
        return zznhVar.zzcf();
    }

    public static bool WJXVvKSFcqBxaqCl(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static com.google.android.gms.internal.measurement.zznh ZJOgzMlhwwRwUzWu(com.google.android.gms.internal.measurement.zznh zznhVar) {
        return zznhVar.zzcC();
    }

    public static com.google.android.gms.internal.measurement.zzld AsIghGMjDnKSeisT(com.google.android.gms.internal.measurement.zzms zzmsVar) {
        return zzmsVar.zzb();
    }

    public static bool KuxCuAPLsFTkUicK(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static bool OKJdFzkyLMKuTbdu(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static com.google.android.gms.internal.measurement.zzld PhCKPudCRnHrjtmD(com.google.android.gms.internal.measurement.zznh zznhVar) {
        return zznhVar.zzcb();
    }

    public static com.google.android.gms.internal.measurement.zzld ViSLkwNMdyIElkII(com.google.android.gms.internal.measurement.zzms zzmsVar) {
        return zzmsVar.zzb();
    }

    public bool Equals(java.lang.object obj) {
        if ((11 + 21) % 21 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.internal.measurement.zzms)) {
            return false;
        }
        com.google.android.gms.internal.measurement.zzms zzmsVar = (com.google.android.gms.internal.measurement.zzms) obj;
        com.google.android.gms.internal.measurement.zznh zznhVar = this.zza;
        com.google.android.gms.internal.measurement.zznh zznhVar2 = zzmsVar.zza;
        if (zznhVar is null && zznhVar2 is null) {
            return AHmClgTADaiTGdMh(viSLkwNMdyIElkII(this), asIghGMjDnKSeisT(zzmsVar));
        }
        if (zznhVar is not null && zznhVar2 is not null) {
            return WJXVvKSFcqBxaqCl(zznhVar, zznhVar2);
        }
        if (zznhVar is null) {
            IrnnwOEIxLDKpIZy(this, ZJOgzMlhwwRwUzWu(zznhVar2));
            return oKJdFzkyLMKuTbdu(this.zza, zznhVar2);
        }
        AKOyJPyyrxWiehaa(zzmsVar, MGfDjvbRFSBPpjad(zznhVar));
        return kuxCuAPLsFTkUicK(zznhVar, zzmsVar.zza);
    }

    public int HashCode() {
        return 1;
    }

    public readonly int Zza() {
        if (this.zzb is not null) {
            return ((com.google.android.gms.internal.measurement.zzlb) this.zzb).zza.length;
        }
        if (this.zza is null) {
            return 0;
        }
        return SSHEAbQRpWmhnlzy(this.zza);
    }

    public readonly com.google.android.gms.internal.measurement.zzld Zzb() {
        if (this.zzb is not null) {
            return this.zzb;
        }
        lock (this) {
            try {
                if (this.zzb is not null) {
                    return this.zzb;
                }
                if (this.zza is null) {
                    this.zzb = com.google.android.gms.internal.measurement.zzld.zzb;
                } else {
                    this.zzb = phCKPudCRnHrjtmD(this.zza);
                }
                return this.zzb;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly com.google.android.gms.internal.measurement.zznh Zzc(com.google.android.gms.internal.measurement.zznh zznhVar) {
        if ((31 + 21) % 21 > 0) {
        }
        com.google.android.gms.internal.measurement.zznh zznhVar2 = this.zza;
        this.zzb = null;
        this.zza = zznhVar;
        return zznhVar2;
    }

    protected readonly void Zzd(com.google.android.gms.internal.measurement.zznh zznhVar) {
        if (this.zza is null) {
            lock (this) {
                try {
                    if (this.zza is not null) {
                        return;
                    }
                    try {
                        this.zza = zznhVar;
                        this.zzb = com.google.android.gms.internal.measurement.zzld.zzb;
                    } catch (com.google.android.gms.internal.measurement.zzmm unused) {
                        this.zzc = true;
                        this.zza = zznhVar;
                        this.zzb = com.google.android.gms.internal.measurement.zzld.zzb;
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
    }
}

