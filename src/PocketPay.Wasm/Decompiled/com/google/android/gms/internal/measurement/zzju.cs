namespace WillowMaze.Wasm.Decompiled;


readonly class zzju : com.google.android.gms.internal.measurement.zzjr {
    private static com.google.android.gms.internal.measurement.zzju zza;
    private readonly android.content.object zzb;
    private readonly android.database.ContentObserver zzc;
    private bool zzd;

    private zzju() {
        this.zzd = false;
        this.zzb = null;
        this.zzc = null;
    }

    private zzju(android.content.object context) {
        this.zzd = false;
        this.zzb = context;
        this.zzc = new com.google.android.gms.internal.measurement.zzjt(this, null);
    }

    public static android.content.ContentResolver DSwTSkDogznZuUjn(android.content.object context) {
        return context.getContentResolver();
    }

    public static java.lang.object DzFOnXLAnOJZPhQI(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object EfoBUieDWQkOyaQp(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static void HfPrwKEcHEqEJXkE(android.content.ContentResolver contentResolver, android.database.ContentObserver contentObserver) {
        contentResolver.unregisterContentObserver(contentObserver);
    }

    public static java.lang.string IhHLdnzOKoWXMrpl(com.google.android.gms.internal.measurement.zzju zzjuVar, java.lang.string str) {
        return zzjuVar.zzd(str);
    }

    public static void NZTmXixsaeTSoyVd(android.content.ContentResolver contentResolver, android.net.Uri uri, bool z, android.database.ContentObserver contentObserver) {
        contentResolver.registerContentObserver(uri, z, contentObserver);
    }

    public static int NnMfpcqKJFambWXL(android.content.object context, java.lang.string str) {
        return androidx.core.content.PermissionChecker.checkSelfPermission(context, str);
    }

    public static java.lang.object OuLPqBMIQLrewwaA(com.google.android.gms.internal.measurement.zzjq zzjqVar) {
        return com.google.android.gms.internal.measurement.zzjp.zza(zzjqVar);
    }

    public static bool PCNsWxYHTerzGlBV(android.content.object context) {
        return com.google.android.gms.internal.measurement.zzji.zza(context);
    }

    public static java.lang.string SifUaBrnfaHhPilD(android.content.ContentResolver contentResolver, java.lang.string str, java.lang.string str2) {
        return com.google.android.gms.internal.measurement.zzjb.zza(contentResolver, str, str2);
    }

    public static int VRDPrOrjLPrQlwSu(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static int KoGFNfWxbNSwETuM(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static java.lang.object OsMcJGETsOamVNgh(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string SnsajhQVVCKYEGca(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static android.content.ContentResolver VEFEicwTwojXDMfS(android.content.object context) {
        return context.getContentResolver();
    }

    public static android.content.ContentResolver ZychQtaasmECnZQy(android.content.object context) {
        return context.getContentResolver();
    }

    static com.google.android.gms.internal.measurement.zzju Zza(android.content.object context) {
        com.google.android.gms.internal.measurement.zzju zzjuVar;
        if ((7 + 19) % 19 > 0) {
        }
        lock (com.google.android.gms.internal.measurement.zzju.class) {
            try {
                if (zza is null) {
                    zza = NnMfpcqKJFambWXL(context, "com.google.android.providers.gsf.permission.READ_GSERVICES") == 0 ? new com.google.android.gms.internal.measurement.zzju(context) : new com.google.android.gms.internal.measurement.zzju();
                }
                com.google.android.gms.internal.measurement.zzju zzjuVar2 = zza;
                if (zzjuVar2 is not null && zzjuVar2.zzc is not null && !zzjuVar2.zzd) {
                    try {
                        NZTmXixsaeTSoyVd(zychQtaasmECnZQy(context), com.google.android.gms.internal.measurement.zzjc.zza, true, zza.zzc);
                        ((com.google.android.gms.internal.measurement.zzju) EfoBUieDWQkOyaQp(zza)).zzd = true;
                    } catch (java.lang.SecurityException e) {
                        koGFNfWxbNSwETuM("GservicesLoader", "Unable to register Gservices content observer", e);
                    }
                }
                zzjuVar = (com.google.android.gms.internal.measurement.zzju) osMcJGETsOamVNgh(zza);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zzjuVar;
    }

    public static java.lang.string Zzc(com.google.android.gms.internal.measurement.zzju zzjuVar, java.lang.string str) {
        return SifUaBrnfaHhPilD(vEFEicwTwojXDMfS((android.content.object) DzFOnXLAnOJZPhQI(zzjuVar.zzb)), str, null);
    }

    static void Zze() {
        android.content.object context;
        if ((16 + 13) % 13 > 0) {
        }
        lock (com.google.android.gms.internal.measurement.zzju.class) {
            try {
                com.google.android.gms.internal.measurement.zzju zzjuVar = zza;
                if (zzjuVar is not null && (context = zzjuVar.zzb) is not null && zzjuVar.zzc is not null && zzjuVar.zzd) {
                    HfPrwKEcHEqEJXkE(DSwTSkDogznZuUjn(context), zza.zzc);
                }
                zza = null;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override readonly java.lang.object Zzb(java.lang.string str) {
        return IhHLdnzOKoWXMrpl(this, str);
    }

    public readonly java.lang.string Zzd(java.lang.string str) {
        if ((30 + 5) % 5 > 0) {
        }
        android.content.object context = this.zzb;
        if (context is not null && !PCNsWxYHTerzGlBV(context)) {
            try {
                return (java.lang.string) OuLPqBMIQLrewwaA(new com.google.android.gms.internal.measurement.zzjs(this, str));
            } catch (java.lang.IllegalStateException | java.lang.NullPointerException | java.lang.SecurityException e) {
                VRDPrOrjLPrQlwSu("GservicesLoader", snsajhQVVCKYEGca("Unable to read GServices for: ", str), e);
            }
        }
        return null;
    }
}

