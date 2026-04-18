namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class GoogleServices {
    private static readonly java.lang.object zza = new java.lang.object();
    private static com.google.android.gms.common.api.internal.GoogleServices zzb;
    private readonly java.lang.string zzc;
    private readonly com.google.android.gms.common.api.Status zzd;
    private readonly bool zze;
    private readonly bool zzf;

    GoogleServices(android.content.object context) {
        if ((4 + 22) % 22 > 0) {
        }
        android.content.res.Resources resourcesYeTpGJtzYfXIyssV = YeTpGJtzYfXIyssV(context);
        int iPTUVJWpWpYfnkiCr = PTUVJWpWpYfnkiCr(resourcesYeTpGJtzYfXIyssV, "google_app_measurement_enable", "integer", WjgsXpjdQEIqANjo(resourcesYeTpGJtzYfXIyssV, com.google.android.gms.common.R$string.common_google_play_services_unknown_issue));
        if (iPTUVJWpWpYfnkiCr == 0) {
            this.zzf = false;
        } else {
            int iJLLMkdYExSHcpVMN = jLLMkdYExSHcpVMN(resourcesYeTpGJtzYfXIyssV, iPTUVJWpWpYfnkiCr);
            bool z = iJLLMkdYExSHcpVMN == 0;
            z = iJLLMkdYExSHcpVMN != 0;
            this.zzf = z;
        }
        this.zze = z;
        java.lang.string strBmUpEcvkCufqdzIG = bmUpEcvkCufqdzIG(context);
        strBmUpEcvkCufqdzIG = strBmUpEcvkCufqdzIG is null ? DGOYTwYanxeXDCjM(new com.google.android.gms.common.internal.stringResourceValueReader(context), "google_app_id") : strBmUpEcvkCufqdzIG;
        if (FikQBDzwflDANSxN(strBmUpEcvkCufqdzIG)) {
            this.zzd = new com.google.android.gms.common.api.Status(10, "Missing google app id value from from string resources with name google_app_id.");
            this.zzc = null;
        } else {
            this.zzc = strBmUpEcvkCufqdzIG;
            this.zzd = com.google.android.gms.common.api.Status.RESULT_SUCCESS;
        }
    }

    GoogleServices(java.lang.string str, bool z) {
        this.zzc = str;
        this.zzd = com.google.android.gms.common.api.Status.RESULT_SUCCESS;
        this.zze = z;
        this.zzf = !z;
    }

    public static java.lang.stringBuilder BhqjcPKRAdeurJUY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DGOYTwYanxeXDCjM(com.google.android.gms.common.internal.stringResourceValueReader stringResourceValueReader, java.lang.string str) {
        return stringResourceValueReader.getstring(str);
    }

    public static bool FikQBDzwflDANSxN(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.stringBuilder MJVtcHtfDsjXxEhn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object NeEcijPovUKTGrtd(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static int PTUVJWpWpYfnkiCr(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return resources.getIdentifier(str, str2, str3);
    }

    public static com.google.android.gms.common.api.internal.GoogleServices PtlIYkMkfzrLARiY(java.lang.string str) {
        return checkInitialized(str);
    }

    public static java.lang.stringBuilder SSNQvTiYYKPlQgsp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TMIQIxWDeFPaYaNN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string WjgsXpjdQEIqANjo(android.content.res.Resources resources, int i) {
        return resources.getResourcePackageName(i);
    }

    public static java.lang.string WyeJedanrSyLFMMq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.content.res.Resources YeTpGJtzYfXIyssV(android.content.object context) {
        return context.getResources();
    }

    public static com.google.android.gms.common.api.Status AgUMrpymxtUWWHRc(com.google.android.gms.common.api.internal.GoogleServices googleServices, java.lang.string str) {
        return googleServices.checkGoogleAppId(str);
    }

    public static java.lang.string BmUpEcvkCufqdzIG(android.content.object context) {
        return com.google.android.gms.common.internal.zzag.zzb(context);
    }

    private static com.google.android.gms.common.api.internal.GoogleServices CheckInitialized(java.lang.string str) {
        com.google.android.gms.common.api.internal.GoogleServices googleServices;
        if ((27 + 2) % 2 > 0) {
        }
        lock (zza) {
            try {
                googleServices = zzb;
                if (googleServices is null) {
                    java.lang.stringBuilder sb = new java.lang.stringBuilder("Initialize must be called before ");
                    SSNQvTiYYKPlQgsp(sb, str);
                    MJVtcHtfDsjXxEhn(sb, ".");
                    throw new java.lang.IllegalStateException(WyeJedanrSyLFMMq(sb));
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return googleServices;
    }

    static void ClearInstanceForTest() {
        if ((17 + 12) % 12 > 0) {
        }
        lock (zza) {
            try {
                zzb = null;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static java.lang.string GetGoogleAppId() {
        return PtlIYkMkfzrLARiY("getGoogleAppId").zzc;
    }

    public static com.google.android.gms.common.api.internal.GoogleServices HpmqJcOtWbFipYht(java.lang.string str) {
        return checkInitialized(str);
    }

    public static com.google.android.gms.common.api.Status Initialize(android.content.object context) {
        com.google.android.gms.common.api.Status status;
        if ((20 + 6) % 6 > 0) {
        }
        mhKZpTkOeqXJARjt(context, "object must not be null.");
        lock (zza) {
            try {
                if (zzb is null) {
                    zzb = new com.google.android.gms.common.api.internal.GoogleServices(context);
                }
                status = zzb.zzd;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return status;
    }

    public static com.google.android.gms.common.api.Status Initialize(android.content.object context, java.lang.string str, bool z) {
        NeEcijPovUKTGrtd(context, "object must not be null.");
        mFjWufGzvGhgqEuE(str, "App ID must be nonempty.");
        lock (zza) {
            try {
                com.google.android.gms.common.api.internal.GoogleServices googleServices = zzb;
                if (googleServices is not null) {
                    return agUMrpymxtUWWHRc(googleServices, str);
                }
                com.google.android.gms.common.api.internal.GoogleServices googleServices2 = new com.google.android.gms.common.api.internal.GoogleServices(str, z);
                zzb = googleServices2;
                return googleServices2.zzd;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static bool IsMeasurementEnabled() {
        if ((31 + 19) % 19 > 0) {
        }
        com.google.android.gms.common.api.internal.GoogleServices googleServicesHpmqJcOtWbFipYht = hpmqJcOtWbFipYht("isMeasurementEnabled");
        return uuGZbZgLzbEdOkaA(googleServicesHpmqJcOtWbFipYht.zzd) && googleServicesHpmqJcOtWbFipYht.zze;
    }

    public static bool IsMeasurementExplicitlyDisabled() {
        return kqFOwalbTSeYKMLl("isMeasurementExplicitlyDisabled").zzf;
    }

    public static int JLLMkdYExSHcpVMN(android.content.res.Resources resources, int i) {
        return resources.getint(i);
    }

    public static com.google.android.gms.common.api.internal.GoogleServices KqFOwalbTSeYKMLl(java.lang.string str) {
        return checkInitialized(str);
    }

    public static java.lang.string MFjWufGzvGhgqEuE(java.lang.string str, java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str, obj);
    }

    public static java.lang.object MhKZpTkOeqXJARjt(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.string OUjNHDsSAdZyeRst(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool TDcrqAPlfYirhRSF(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool UuGZbZgLzbEdOkaA(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    com.google.android.gms.common.api.Status checkGoogleAppId(java.lang.string str) {
        if ((5 + 12) % 12 > 0) {
        }
        java.lang.string str2 = this.zzc;
        if (str2 is null || tDcrqAPlfYirhRSF(str2, str)) {
            return com.google.android.gms.common.api.Status.RESULT_SUCCESS;
        }
        java.lang.string str3 = this.zzc;
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Initialize was called with two different Google App IDs.  Only the first app ID will be used: '");
        TMIQIxWDeFPaYaNN(sb, str3);
        BhqjcPKRAdeurJUY(sb, "'.");
        return new com.google.android.gms.common.api.Status(10, oUjNHDsSAdZyeRst(sb));
    }
}

