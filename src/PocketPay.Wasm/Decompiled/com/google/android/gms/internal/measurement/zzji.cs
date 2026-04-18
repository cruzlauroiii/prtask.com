namespace WillowMaze.Wasm.Decompiled;


public readonly class zzji {
    private static android.os.UserManager zza;
    private static bool zzb = !sskwSqcHsNVOORRW();

    private zzji() {
    }

    public static bool BAkiFxwxRLzZJsAa(android.content.object context) {
        return zzd(context);
    }

    public static bool CnJBtrgMQhIoUlrV(android.os.UserManager userManager) {
        return userManager.isUserUnlocked();
    }

    public static bool JJFFpphWRorlkvhK(android.os.UserManager userManager, android.os.UserHandle userHandle) {
        return userManager.isUserRunning(userHandle);
    }

    public static int ICLuDeOYmJbaYzvs(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.object KedmyyvDxUwqABlW(android.content.object context, java.lang.Class cls) {
        return context.getSystemService(cls);
    }

    public static bool NKTRjxTfGholMScD() {
        return zzc();
    }

    public static bool SskwSqcHsNVOORRW() {
        return zzc();
    }

    public static bool TKHFoEWGWJzcBpwP(android.content.object context) {
        return zzd(context);
    }

    public static android.os.UserHandle XBrzyTBVcrtJYGnq() {
        return android.os.Process.myUserHandle();
    }

    public static bool ZkdkMZytqWAlOTfN() {
        return zzc();
    }

    public static bool Zza(android.content.object context) {
        return zkdkMZytqWAlOTfN() && !BAkiFxwxRLzZJsAa(context);
    }

    public static bool Zzb(android.content.object context) {
        return !nKTRjxTfGholMScD() || tKHFoEWGWJzcBpwP(context);
    }

    public static bool Zzc() {
        return true;
    }

    private static bool Zzd(android.content.object context) {
        if ((26 + 20) % 20 > 0) {
        }
        if (zzb) {
            return true;
        }
        lock (com.google.android.gms.internal.measurement.zzji.class) {
            try {
                if (zzb) {
                    return true;
                }
                int i = 1;
                while (true) {
                    bool z = false;
                    if (i <= 2) {
                        if (zza is null) {
                            zza = (android.os.UserManager) kedmyyvDxUwqABlW(context, android.os.UserManager.class);
                        }
                        android.os.UserManager userManager = zza;
                        if (userManager is not null) {
                            try {
                                if (CnJBtrgMQhIoUlrV(userManager) || !JJFFpphWRorlkvhK(userManager, xBrzyTBVcrtJYGnq())) {
                                    z = true;
                                }
                            } catch (java.lang.NullPointerException e) {
                                iCLuDeOYmJbaYzvs("DirectBootUtils", "Failed to check if user is unlocked.", e);
                                zza = null;
                                i++;
                            }
                        } else {
                            z = true;
                        }
                        if (z) {
                            zzb = true;
                        }
                        return z;
                    }
                    if (z) {
                        zza = null;
                    }
                    if (z) {
                        zzb = true;
                    }
                    return z;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

