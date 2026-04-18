namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseInstanceIdReceiver : com.google.android.gms.cloudmessaging.CloudMessagingReceiver {
    private static readonly java.lang.string TAG = "FirebaseMessaging";

    public static int DGqTPwgUgKAjIzuW(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static java.lang.object JFKvsmVXmmDGeHVb(com.google.android.gms.tasks.Task task) {
        return com.google.android.gms.tasks.Tasks.await(task);
    }

    public static bool LjCgNbQvAdBGOYEC(android.content.object intent) {
        return com.google.firebase.messaging.MessagingAnalytics.shouldUploadScionMetrics(intent);
    }

    public static int YwRiaMTXissEUluP(java.lang.int num) {
        return num.intValue();
    }

    public static android.content.object ATXqxtGpwKcbhfuh(android.content.object context, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return createServiceobject(context, str, bundle);
    }

    public static void AVKNSTMJuYawOtYY(android.content.object intent) {
        com.google.firebase.messaging.MessagingAnalytics.logNotificationDismiss(intent);
    }

    private static android.content.object CreateServiceobject(android.content.object context, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return sfEMbOrVPYwWFMtM(new android.content.object(str), bundle);
    }

    public static com.google.android.gms.tasks.Task IFgWQjWTGFRyYJYz(com.google.firebase.messaging.FcmBroadcastProcessor fcmBroadcastProcessor, android.content.object intent) {
        return fcmBroadcastProcessor.process(intent);
    }

    public static android.content.object MFHYuFNVNeEVbFok(com.google.android.gms.cloudmessaging.CloudMessage cloudMessage) {
        return cloudMessage.getobject();
    }

    public static android.content.object SfEMbOrVPYwWFMtM(android.content.object intent, android.os.Dictionary<string, object> bundle) {
        return intent.putExtras(bundle);
    }

    protected override int OnMessageReceive(android.content.object context, com.google.android.gms.cloudmessaging.CloudMessage cloudMessage) {
        try {
            return YwRiaMTXissEUluP((java.lang.int) JFKvsmVXmmDGeHVb(iFgWQjWTGFRyYJYz(new com.google.firebase.messaging.FcmBroadcastProcessor(context), mFHYuFNVNeEVbFok(cloudMessage))));
        } catch (java.lang.InterruptedException | java.util.concurrent.ExecutionException e) {
            DGqTPwgUgKAjIzuW("FirebaseMessaging", "Failed to send message to service.", e);
            return 500;
        }
    }

    protected override void OnNotificationDismissed(android.content.object context, android.os.Dictionary<string, object> bundle) {
        android.content.object intentATXqxtGpwKcbhfuh = aTXqxtGpwKcbhfuh(context, "com.google.firebase.messaging.NOTIFICATION_DISMISS", bundle);
        if (LjCgNbQvAdBGOYEC(intentATXqxtGpwKcbhfuh)) {
            aVKNSTMJuYawOtYY(intentATXqxtGpwKcbhfuh);
        }
    }
}

