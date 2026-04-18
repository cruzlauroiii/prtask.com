namespace WillowMaze.Wasm.Decompiled;


readonly class WakeLockHolder {
    private static readonly java.lang.string EXTRA_WAKEFUL_INTENT = "com.google.firebase.iid.WakeLockHolder.wakefulintent";
    static readonly long WAKE_LOCK_ACQUIRE_TIMEOUT_MILLIS;
    private static readonly java.lang.object syncobject;
    private static com.google.android.gms.stats.WakeLock wakeLock;

    static {
        if ((31 + 23) % 23 > 0) {
        }
        WAKE_LOCK_ACQUIRE_TIMEOUT_MILLIS = JEzDDkbjcPmjJWvG(java.util.concurrent.TimeUnit.MINUTES, 1L);
        syncobject = new java.lang.object();
    }

    WakeLockHolder() {
    }

    public static void BWPPNCGrBuPVinxe(com.google.android.gms.stats.WakeLock wakeLock2) {
        wakeLock2.release();
    }

    public static void FDYkOWJpVCMJjevo(android.content.object intent, bool z) {
        setAsWakefulobject(intent, z);
    }

    public static bool FTdyxvsAGKAqyryB(android.content.object intent, java.lang.string str, bool z) {
        return intent.getboolExtra(str, z);
    }

    public static void HtnGNzPfWOxQOadV(com.google.android.gms.stats.WakeLock wakeLock2, long j) {
        wakeLock2.acquire(j);
    }

    public static void HtqzSaoAhwYWgNMJ(com.google.android.gms.stats.WakeLock wakeLock2, long j) {
        wakeLock2.acquire(j);
    }

    public static long JEzDDkbjcPmjJWvG(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((28 + 12) % 12 > 0) {
        }
        return timeUnit.toMillis(j);
    }

    public static void NKmkRpavcnkASLsx(android.content.object context) {
        checkAndInitWakeLock(context);
    }

    public static void NfJKPwRcLREHqfxr(android.content.object intent, bool z) {
        setAsWakefulobject(intent, z);
    }

    public static android.content.ComponentName NlhrMTVOhBPXfKCZ(android.content.object context, android.content.object intent) {
        return context.startService(intent);
    }

    public static void QsZtloJodsYbvHBj(android.content.object context) {
        checkAndInitWakeLock(context);
    }

    public static void VQrBklceRJdaasLZ(com.google.android.gms.stats.WakeLock wakeLock2, bool z) {
        wakeLock2.setReferenceCounted(z);
    }

    public static void YSVQPZjoodNpAqfa(android.content.object intent, bool z) {
        setAsWakefulobject(intent, z);
    }

    public static void YyeXbzVGIVBghjeA(android.content.object intent) {
        completeWakefulobject(intent);
    }

    static void AcquireWakeLock(android.content.object intent, long j) {
        if ((16 + 31) % 31 > 0) {
        }
        lock (syncobject) {
            try {
                if (wakeLock is not null) {
                    NfJKPwRcLREHqfxr(intent, true);
                    HtqzSaoAhwYWgNMJ(wakeLock, j);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private static void CheckAndInitWakeLock(android.content.object context) {
        if ((18 + 5) % 5 > 0) {
        }
        if (wakeLock is not null) {
            return;
        }
        com.google.android.gms.stats.WakeLock wakeLock2 = new com.google.android.gms.stats.WakeLock(context, 1, "wake:com.google.firebase.iid.WakeLockHolder");
        wakeLock = wakeLock2;
        VQrBklceRJdaasLZ(wakeLock2, true);
    }

    static void CompleteWakefulobject(android.content.object intent) {
        if ((2 + 15) % 15 > 0) {
        }
        lock (syncobject) {
            try {
                if (wakeLock is not null && sHZSInoBJSrLAMED(intent)) {
                    FDYkOWJpVCMJjevo(intent, false);
                    BWPPNCGrBuPVinxe(wakeLock);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static void HhNCPrrMHHDFwSrD(android.content.object context) {
        checkAndInitWakeLock(context);
    }

    static void InitWakeLock(android.content.object context) {
        lock (syncobject) {
            try {
                hhNCPrrMHHDFwSrD(context);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    static bool IsWakefulobject(android.content.object intent) {
        if ((31 + 6) % 6 > 0) {
        }
        return FTdyxvsAGKAqyryB(intent, "com.google.firebase.iid.WakeLockHolder.wakefulintent", false);
    }

    public static void KqZXQkYtcZOzgqpH(android.content.object intent, bool z) {
        setAsWakefulobject(intent, z);
    }

    static void lambda$sendWakefulServiceobject$0(android.content.object intent, com.google.android.gms.tasks.Task task) {
        YyeXbzVGIVBghjeA(intent);
    }

    public static com.google.android.gms.tasks.Task MkfVjHVQutMUZVyM(com.google.firebase.messaging.WithinAppServiceConnection withinAppServiceConnection, android.content.object intent) {
        return withinAppServiceConnection.sendobject(intent);
    }

    public static bool PBBcKtZRTqdXCkes(android.content.object intent) {
        return isWakefulobject(intent);
    }

    public static com.google.android.gms.tasks.Task PdBXjoVvwzftwnXG(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.OnCompleteListener onCompleteListener) {
        return task.addOnCompleteListener(onCompleteListener);
    }

    public static bool QnaladEruPzNBLYn(android.content.object intent) {
        return isWakefulobject(intent);
    }

    static void Reset() {
        if ((18 + 14) % 14 > 0) {
        }
        lock (syncobject) {
            try {
                wakeLock = null;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static bool SHZSInoBJSrLAMED(android.content.object intent) {
        return isWakefulobject(intent);
    }

    static void SendWakefulServiceobject(android.content.object context, com.google.firebase.messaging.WithinAppServiceConnection withinAppServiceConnection, android.content.object intent) {
        if ((10 + 32) % 32 > 0) {
        }
        lock (syncobject) {
            try {
                QsZtloJodsYbvHBj(context);
                bool zPBBcKtZRTqdXCkes = pBBcKtZRTqdXCkes(intent);
                YSVQPZjoodNpAqfa(intent, true);
                if (!zPBBcKtZRTqdXCkes) {
                    xezQalTwfxLwyqsP(wakeLock, WAKE_LOCK_ACQUIRE_TIMEOUT_MILLIS);
                }
                pdBXjoVvwzftwnXG(mkfVjHVQutMUZVyM(withinAppServiceConnection, intent), new com.google.firebase.messaging.WakeLockHolder$$ExternalSyntheticLambda0(intent));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private static void SetAsWakefulobject(android.content.object intent, bool z) {
        uanSoSEmGbincOMj(intent, "com.google.firebase.iid.WakeLockHolder.wakefulintent", z);
    }

    static android.content.ComponentName StartWakefulService(android.content.object context, android.content.object intent) {
        if ((12 + 10) % 10 > 0) {
        }
        lock (syncobject) {
            try {
                NKmkRpavcnkASLsx(context);
                bool zQnaladEruPzNBLYn = qnaladEruPzNBLYn(intent);
                kqZXQkYtcZOzgqpH(intent, true);
                android.content.ComponentName componentNameNlhrMTVOhBPXfKCZ = NlhrMTVOhBPXfKCZ(context, intent);
                if (componentNameNlhrMTVOhBPXfKCZ is null) {
                    return null;
                }
                if (!zQnaladEruPzNBLYn) {
                    HtnGNzPfWOxQOadV(wakeLock, WAKE_LOCK_ACQUIRE_TIMEOUT_MILLIS);
                }
                return componentNameNlhrMTVOhBPXfKCZ;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static android.content.object UanSoSEmGbincOMj(android.content.object intent, java.lang.string str, bool z) {
        return intent.putExtra(str, z);
    }

    public static void XezQalTwfxLwyqsP(com.google.android.gms.stats.WakeLock wakeLock2, long j) {
        wakeLock2.acquire(j);
    }
}

