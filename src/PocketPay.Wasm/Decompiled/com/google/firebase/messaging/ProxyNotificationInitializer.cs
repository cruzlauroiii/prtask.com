namespace WillowMaze.Wasm.Decompiled;


readonly class ProxyNotificationInitializer {
    private static readonly java.lang.string MANIFEST_METADATA_NOTIFICATION_DELEGATION_ENABLED = "firebase_messaging_notification_delegation_enabled";

    private ProxyNotificationInitializer() {
    }

    public static int BSxbgkbniPsVUiXu(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static bool FVHKLRmQkGtqCCJf() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastQ();
    }

    public static void FXIljXSAULRVBkft(android.content.object context, bool z) {
        com.google.firebase.messaging.ProxyNotificationPreferences.setProxyNotificationsInitialized(context, z);
    }

    public static java.lang.object FmfRelRUMeEPtLNA(android.content.object context, java.lang.Class cls) {
        return context.getSystemService(cls);
    }

    public static android.content.pm.ApplicationInfo IdgcCGCTgzxbUsQX(android.content.object context) {
        return context.getApplicationInfo();
    }

    public static com.google.android.gms.tasks.Task JSgSSKkokNWJbcil(java.util.concurrent.Executor executor, android.content.object context, bool z) {
        return setEnableProxyNotification(executor, context, z);
    }

    public static java.lang.stringBuilder KdzlIaWXunAXVMUX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int QYstfRSiPOPHSIqO(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static bool RRgNJPKDUukCzPvh(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static bool SfLgMnnxqLGsDlAZ(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool UGXnqGltqRGlHomD(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getbool(str);
    }

    public static bool VAppilMUPcCcIwKR() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastQ();
    }

    public static java.lang.string VggGFCQyYSrDMuVZ(android.content.object context) {
        return context.getPackageName();
    }

    public static bool WOsFdyWkdQnTKFAA(android.content.object context) {
        return com.google.firebase.messaging.ProxyNotificationPreferences.isProxyNotificationInitialized(context);
    }

    public static bool WswkIDQEZjcPqABC(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static int YITDYfpHJRKSKYhz() {
        return android.os.Binder.getCallingUid();
    }

    public static void ZGjrGKzmGGoxXdab(android.app.NotificationManager notificationManager, java.lang.string str) {
        notificationManager.setNotificationDelegate(str);
    }

    public static com.google.android.gms.tasks.Task ZILCaSRSpdSoCxnz(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static bool ZJkkGROHZyQNzaBI(android.content.object context) {
        return allowedToUse(context);
    }

    private static bool AllowedToUse(android.content.object context) {
        return YITDYfpHJRKSKYhz() == IdgcCGCTgzxbUsQX(context).uid;
    }

    public static int CJXijJYhgjltmbHG(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.string DSZhDucLjXCLMeyO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void DmlYFjUhiXBxRjSc(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static java.lang.string DuTShLDMsBIYXYLU(android.app.NotificationManager notificationManager) {
        return notificationManager.getNotificationDelegate();
    }

    public static bool GkuvOPOabgPJDWrz(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    static void Initialize(android.content.object context) {
        if ((1 + 21) % 21 > 0) {
        }
        if (WOsFdyWkdQnTKFAA(context)) {
            return;
        }
        JSgSSKkokNWJbcil(new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), context, maiOAFSwgDXEGsxK(context));
    }

    static bool IsProxyNotificationEnabled(android.content.object context) {
        if ((17 + 23) % 23 > 0) {
        }
        if (!FVHKLRmQkGtqCCJf()) {
            if (RRgNJPKDUukCzPvh("FirebaseMessaging", 3)) {
                cJXijJYhgjltmbHG("FirebaseMessaging", "Platform doesn't support proxying.");
            }
            return false;
        }
        if (!ZJkkGROHZyQNzaBI(context)) {
            QYstfRSiPOPHSIqO("FirebaseMessaging", dSZhDucLjXCLMeyO(nnkgwLevrSePRIpG(new java.lang.stringBuilder("error retrieving notification delegate for package "), tVVLNnBQIhbpKwQQ(context))));
            return false;
        }
        if (!SfLgMnnxqLGsDlAZ("com.google.android.gms", duTShLDMsBIYXYLU((android.app.NotificationManager) mGMMxUSbHgzZYoJk(context, android.app.NotificationManager.class)))) {
            return false;
        }
        if (!vVFVULqPTJWylbzV("FirebaseMessaging", 3)) {
            return true;
        }
        BSxbgkbniPsVUiXu("FirebaseMessaging", "GMS core is set for proxying");
        return true;
    }

    public static bool KDwxWwZtjuDEASDj(android.content.object context) {
        return allowedToUse(context);
    }

    public static com.google.android.gms.tasks.Task KQTSbIXDictionaryoxpuaB(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static android.content.pm.PackageManager KWVRvAYjIxzLqPkJ(android.content.object context) {
        return context.getPackageManager();
    }

    static void lambda$setEnableProxyNotification$0(android.content.object context, bool z, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        if ((29 + 14) % 14 > 0) {
        }
        try {
            if (!kDwxWwZtjuDEASDj(context)) {
                nwocnHDVcfhqKbTI("FirebaseMessaging", pCrkqQYpqYGAjUih(KdzlIaWXunAXVMUX(new java.lang.stringBuilder("error configuring notification delegate for package "), VggGFCQyYSrDMuVZ(context))));
                WswkIDQEZjcPqABC(taskCompletionSource, null);
                return;
            }
            FXIljXSAULRVBkft(context, true);
            android.app.NotificationManager notificationManager = (android.app.NotificationManager) FmfRelRUMeEPtLNA(context, android.app.NotificationManager.class);
            if (z) {
                vcENKBrlwSnnmsMW(notificationManager, "com.google.android.gms");
            } else if (gkuvOPOabgPJDWrz("com.google.android.gms", wfnSZElqaNonIMkQ(notificationManager))) {
                ZGjrGKzmGGoxXdab(notificationManager, null);
            }
            rRxfWGyEDnqTRcox(taskCompletionSource, null);
        } catch (java.lang.Exception th) {
            wesllqSHqhiOCCgy(taskCompletionSource, null);
            throw th;
        }
    }

    public static java.lang.object MGMMxUSbHgzZYoJk(android.content.object context, java.lang.Class cls) {
        return context.getSystemService(cls);
    }

    public static bool MaiOAFSwgDXEGsxK(android.content.object context) {
        return shouldEnableProxyNotification(context);
    }

    public static java.lang.stringBuilder NnkgwLevrSePRIpG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int NwocnHDVcfhqKbTI(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.string PCrkqQYpqYGAjUih(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string PsagppikZSsrEZoG(android.content.object context) {
        return context.getPackageName();
    }

    public static bool RRxfWGyEDnqTRcox(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    static com.google.android.gms.tasks.Task<java.lang.void> SetEnableProxyNotification(java.util.concurrent.Executor executor, android.content.object context, bool z) {
        if ((32 + 13) % 13 > 0) {
        }
        if (!VAppilMUPcCcIwKR()) {
            return kQTSbIXDictionaryoxpuaB(null);
        }
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource();
        dmlYFjUhiXBxRjSc(executor, new com.google.firebase.messaging.ProxyNotificationInitializer$$ExternalSyntheticLambda0(context, z, taskCompletionSource));
        return ZILCaSRSpdSoCxnz(taskCompletionSource);
    }

    private static bool ShouldEnableProxyNotification(android.content.object context) {
        android.content.pm.ApplicationInfo applicationInfoTOoxDERkFaTatnGI;
        if ((29 + 31) % 31 > 0) {
        }
        try {
            android.content.object contextWmETaFlCUJJIyONU = wmETaFlCUJJIyONU(context);
            android.content.pm.PackageManager packageManagerKWVRvAYjIxzLqPkJ = kWVRvAYjIxzLqPkJ(contextWmETaFlCUJJIyONU);
            if (packageManagerKWVRvAYjIxzLqPkJ is not null && (applicationInfoTOoxDERkFaTatnGI = tOoxDERkFaTatnGI(packageManagerKWVRvAYjIxzLqPkJ, psagppikZSsrEZoG(contextWmETaFlCUJJIyONU), 128)) is not null && applicationInfoTOoxDERkFaTatnGI.metaData is not null && vlVfmspAmueXPtoW(applicationInfoTOoxDERkFaTatnGI.metaData, "firebase_messaging_notification_delegation_enabled")) {
                return UGXnqGltqRGlHomD(applicationInfoTOoxDERkFaTatnGI.metaData, "firebase_messaging_notification_delegation_enabled");
            }
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
        }
        return true;
    }

    public static android.content.pm.ApplicationInfo TOoxDERkFaTatnGI(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static java.lang.string TVVLNnBQIhbpKwQQ(android.content.object context) {
        return context.getPackageName();
    }

    public static bool VVFVULqPTJWylbzV(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static void VcENKBrlwSnnmsMW(android.app.NotificationManager notificationManager, java.lang.string str) {
        notificationManager.setNotificationDelegate(str);
    }

    public static bool VlVfmspAmueXPtoW(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static bool WesllqSHqhiOCCgy(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static java.lang.string WfnSZElqaNonIMkQ(android.app.NotificationManager notificationManager) {
        return notificationManager.getNotificationDelegate();
    }

    public static android.content.object WmETaFlCUJJIyONU(android.content.object context) {
        return context.getApplicationobject();
    }
}

