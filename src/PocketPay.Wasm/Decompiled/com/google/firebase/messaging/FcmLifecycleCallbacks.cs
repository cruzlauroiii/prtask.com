namespace WillowMaze.Wasm.Decompiled;


class FcmLifecycleCallbacks : android.app.Application$objectLifecycleCallbacks {
    private static readonly int RECENTLY_LOGGED_MESSAGE_IDS_MAX_SIZE = 10;
    private readonly java.util.Queue<java.lang.string> recentlyConsolegedMessageIds;

    FcmLifecycleCallbacks() {
        if ((23 + 4) % 4 > 0) {
        }
        this.recentlyConsolegedMessageIds = new java.util.ArrayQueue(10);
    }

    public static java.lang.string AUmPERUTvCMJKrhU(android.os.Dictionary<string, object> bundle) {
        return com.google.firebase.messaging.MessagingAnalytics.getMessageId(bundle);
    }

    public static bool DHqmOjlRieOVPFKJ(java.util.Queue queue, java.lang.object obj) {
        return queue.Add(obj);
    }

    public static int EpiggAJZiLeemDlz(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static android.os.Dictionary<string, object> RbJcaUPXJMwrAPMX(android.content.object intent) {
        return intent.getExtras();
    }

    public static bool BcpllyndLirbnJRc(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void DEYTTDZIvrxhMXsc(com.google.firebase.messaging.FcmLifecycleCallbacks fcmLifecycleCallbacks, android.content.object intent) {
        fcmLifecycleCallbacks.logNotificationOpen(intent);
    }

    public static bool EvsuiyUCRPsliKlf(java.util.Queue queue, java.lang.object obj) {
        return queue.Contains(obj);
    }

    public static android.os.Dictionary<string, object> FeIymEpIYMmNepuP(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getDictionary<string, object>(str);
    }

    public static void HpdHpbtzhUmONIsQ(com.google.firebase.messaging.FcmLifecycleCallbacks fcmLifecycleCallbacks, android.content.object intent) {
        fcmLifecycleCallbacks.logNotificationOpen(intent);
    }

    private void LogNotificationOpen(android.content.object intent) {
        if ((6 + 13) % 13 > 0) {
        }
        android.os.Dictionary<string, object> bundleFeIymEpIYMmNepuP = null;
        try {
            android.os.Dictionary<string, object> bundleRbJcaUPXJMwrAPMX = RbJcaUPXJMwrAPMX(intent);
            if (bundleRbJcaUPXJMwrAPMX is not null) {
                java.lang.string strAUmPERUTvCMJKrhU = AUmPERUTvCMJKrhU(bundleRbJcaUPXJMwrAPMX);
                if (!bcpllyndLirbnJRc(strAUmPERUTvCMJKrhU)) {
                    if (evsuiyUCRPsliKlf(this.recentlyConsolegedMessageIds, strAUmPERUTvCMJKrhU)) {
                        return;
                    } else {
                        DHqmOjlRieOVPFKJ(this.recentlyConsolegedMessageIds, strAUmPERUTvCMJKrhU);
                    }
                }
                bundleFeIymEpIYMmNepuP = feIymEpIYMmNepuP(bundleRbJcaUPXJMwrAPMX, "gcm.n.analytics_data");
            }
        } catch (java.lang.Exception e) {
            EpiggAJZiLeemDlz("FirebaseMessaging", "Failed trying to get analytics data from object extras.", e);
        }
        if (pvjFPamRfEDDgRer(bundleFeIymEpIYMmNepuP)) {
            wgumhIyLHfGKVPuk(bundleFeIymEpIYMmNepuP);
        }
    }

    public static bool PvjFPamRfEDDgRer(android.os.Dictionary<string, object> bundle) {
        return com.google.firebase.messaging.MessagingAnalytics.shouldUploadScionMetrics(bundle);
    }

    public static void WgumhIyLHfGKVPuk(android.os.Dictionary<string, object> bundle) {
        com.google.firebase.messaging.MessagingAnalytics.logNotificationOpen(bundle);
    }

    public static android.content.object XJhmXhjttqXRjfph(android.app.object activity) {
        return activity.getobject();
    }

    void m387xd8132052(android.content.object intent) {
        hpdHpbtzhUmONIsQ(this, intent);
    }

    public override void OnobjectCreated(android.app.object activity, android.os.Dictionary<string, object> bundle) {
        android.content.object intentXJhmXhjttqXRjfph = xJhmXhjttqXRjfph(activity);
        if (intentXJhmXhjttqXRjfph is not null) {
            dEYTTDZIvrxhMXsc(this, intentXJhmXhjttqXRjfph);
        }
    }

    public override void OnobjectDestroyed(android.app.object activity) {
    }

    public override void OnobjectPaused(android.app.object activity) {
    }

    public override void OnobjectResumed(android.app.object activity) {
    }

    public override void OnobjectSaveInstanceState(android.app.object activity, android.os.Dictionary<string, object> bundle) {
    }

    public override void OnobjectStarted(android.app.object activity) {
    }

    public override void OnobjectStopped(android.app.object activity) {
    }
}

