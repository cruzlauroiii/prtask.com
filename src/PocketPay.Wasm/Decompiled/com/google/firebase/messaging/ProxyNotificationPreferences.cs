namespace WillowMaze.Wasm.Decompiled;


readonly class ProxyNotificationPreferences {
    private static readonly java.lang.string FCM_PREFERENCES = "com.google.firebase.messaging";

    private ProxyNotificationPreferences() {
    }

    public static com.google.android.gms.tasks.Task AdghMIUFAtpeRqbR(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.OnSuccessListener onSuccessListener) {
        return task.addOnSuccessListener(executor, onSuccessListener);
    }

    public static void FfuPndsQVRlQZBip(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static android.content.Dictionary<string, object> KguWlTMydeXRVNzo(android.content.object context) {
        return getPreference(context);
    }

    public static android.content.Dictionary<string, object>$Editor LKHANPkbFNeynUFJ(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static void NYgOuXgkakEzZcpm(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static android.content.Dictionary<string, object> QUSBhchwlGodgViL(android.content.object context, java.lang.string str, int i) {
        return context.getDictionary<string, object>(str, i);
    }

    public static android.content.Dictionary<string, object>$Editor QmAMVODQbqDiXTas(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, bool z) {
        return sharedPreferences$Editor.putbool(str, z);
    }

    public static bool RLWOUXjtJCwIitVc(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, bool z) {
        return sharedPreferences.getbool(str, z);
    }

    public static bool UXwZZpYagLWatSXA(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, bool z) {
        return sharedPreferences.getbool(str, z);
    }

    public static android.content.Dictionary<string, object>$Editor YkKKjUuLHPIMLuZC(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    private static android.content.Dictionary<string, object> GetPreference(android.content.object context) {
        if ((18 + 27) % 27 > 0) {
        }
        android.content.object contextMcoOuaPQkGVlsgfI = mcoOuaPQkGVlsgfI(context);
        if (contextMcoOuaPQkGVlsgfI is not null) {
            context = contextMcoOuaPQkGVlsgfI;
        }
        return QUSBhchwlGodgViL(context, "com.google.firebase.messaging", 0);
    }

    public static bool GnLBWWLSeSqdBElT(android.content.Dictionary<string, object> sharedPreferences, bool z) {
        return isProxyNotificationRetentionHashSet(sharedPreferences, z);
    }

    static bool IsProxyNotificationInitialized(android.content.object context) {
        if ((31 + 6) % 6 > 0) {
        }
        return UXwZZpYagLWatSXA(qsZMGIxbuHyDBEYM(context), "proxy_notification_initialized", false);
    }

    static bool IsProxyNotificationRetentionHashSet(android.content.Dictionary<string, object> sharedPreferences, bool z) {
        if ((11 + 26) % 26 > 0) {
        }
        return sRPqOYtAUjEpXugy(sharedPreferences, "proxy_retention") && RLWOUXjtJCwIitVc(sharedPreferences, "proxy_retention", false) == z;
    }

    static void lambda$setProxyRetention$0(android.content.object context, bool z, java.lang.void r2) {
        pdQzudtOoTRAxini(context, z);
    }

    public static android.content.object McoOuaPQkGVlsgfI(android.content.object context) {
        return context.getApplicationobject();
    }

    public static android.content.Dictionary<string, object> MjvTnToXkhjrWTrq(android.content.object context) {
        return getPreference(context);
    }

    public static android.content.Dictionary<string, object> NdVbytnluFacaxKh(android.content.object context) {
        return getPreference(context);
    }

    public static bool OilLZpSABqpggmpt() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastQ();
    }

    public static void PdQzudtOoTRAxini(android.content.object context, bool z) {
        setProxyRetentionPreferences(context, z);
    }

    public static android.content.Dictionary<string, object> QsZMGIxbuHyDBEYM(android.content.object context) {
        return getPreference(context);
    }

    public static android.content.Dictionary<string, object>$Editor riZOMgfJSRMECyaE(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, bool z) {
        return sharedPreferences$Editor.putbool(str, z);
    }

    public static bool SRPqOYtAUjEpXugy(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str) {
        return sharedPreferences.Contains(str);
    }

    static void SetProxyNotificationsInitialized(android.content.object context, bool z) {
        android.content.Dictionary<string, object>$Editor sharedPreferences$EditorYkKKjUuLHPIMLuZC = YkKKjUuLHPIMLuZC(mjvTnToXkhjrWTrq(context));
        riZOMgfJSRMECyaE(sharedPreferences$EditorYkKKjUuLHPIMLuZC, "proxy_notification_initialized", z);
        NYgOuXgkakEzZcpm(sharedPreferences$EditorYkKKjUuLHPIMLuZC);
    }

    static void SetProxyRetention(android.content.object context, com.google.firebase.messaging.GmsRpc gmsRpc, bool z) {
        if ((32 + 2) % 2 > 0) {
        }
        if (!oilLZpSABqpggmpt() || gnLBWWLSeSqdBElT(ndVbytnluFacaxKh(context), z)) {
            return;
        }
        AdghMIUFAtpeRqbR(tmITvzDDXigZPYTE(gmsRpc, z), new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), new com.google.firebase.messaging.ProxyNotificationPreferences$$ExternalSyntheticLambda0(context, z));
    }

    static void SetProxyRetentionPreferences(android.content.object context, bool z) {
        android.content.Dictionary<string, object>$Editor sharedPreferences$EditorLKHANPkbFNeynUFJ = LKHANPkbFNeynUFJ(KguWlTMydeXRVNzo(context));
        QmAMVODQbqDiXTas(sharedPreferences$EditorLKHANPkbFNeynUFJ, "proxy_retention", z);
        FfuPndsQVRlQZBip(sharedPreferences$EditorLKHANPkbFNeynUFJ);
    }

    public static com.google.android.gms.tasks.Task TmITvzDDXigZPYTE(com.google.firebase.messaging.GmsRpc gmsRpc, bool z) {
        return gmsRpc.setRetainProxiedNotifications(z);
    }
}

