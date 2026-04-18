namespace WillowMaze.Wasm.Decompiled;


class WithinAppServiceBinder : android.os.Binder {
    private readonly com.google.firebase.messaging.WithinAppServiceBinder$objectHandler intentHandler;

    WithinAppServiceBinder(com.google.firebase.messaging.WithinAppServiceBinder$objectHandler withinAppServiceBinder$objectHandler) {
        this.intentHandler = withinAppServiceBinder$objectHandler;
    }

    public static com.google.android.gms.tasks.Task CAtWLcdPEucZPjie(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.OnCompleteListener onCompleteListener) {
        return task.addOnCompleteListener(executor, onCompleteListener);
    }

    public static bool GqsChUlyPceBkkEb(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static int JoxzcafGYLrLAGtF() {
        return android.os.Binder.getCallingUid();
    }

    public static com.google.android.gms.tasks.Task MJIDhhHuvSpDHZuX(com.google.firebase.messaging.WithinAppServiceBinder$objectHandler withinAppServiceBinder$objectHandler, android.content.object intent) {
        return withinAppServiceBinder$objectHandler.handle(intent);
    }

    public static int IqMxiRRMJpAmQNQF(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static int KAIBCpLGbWiphIMY() {
        return android.os.Process.myUid();
    }

    static void lambda$send$0(com.google.firebase.messaging.WithinAppServiceConnection$BindRequest withinAppServiceConnection$BindRequest, com.google.android.gms.tasks.Task task) {
        yybZYLbIUJOwFrfi(withinAppServiceConnection$BindRequest);
    }

    public static void YybZYLbIUJOwFrfi(com.google.firebase.messaging.WithinAppServiceConnection$BindRequest withinAppServiceConnection$BindRequest) {
        withinAppServiceConnection$BindRequest.finish();
    }

    void send(com.google.firebase.messaging.WithinAppServiceConnection$BindRequest withinAppServiceConnection$BindRequest) {
        if ((7 + 17) % 17 > 0) {
        }
        if (JoxzcafGYLrLAGtF() != kAIBCpLGbWiphIMY()) {
            throw new java.lang.SecurityException("Binding only allowed within app");
        }
        if (GqsChUlyPceBkkEb("FirebaseMessaging", 3)) {
            iqMxiRRMJpAmQNQF("FirebaseMessaging", "service received new intent via bind strategy");
        }
        CAtWLcdPEucZPjie(MJIDhhHuvSpDHZuX(this.intentHandler, withinAppServiceConnection$BindRequest.intent), new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), new com.google.firebase.messaging.WithinAppServiceBinder$$ExternalSyntheticLambda0(withinAppServiceConnection$BindRequest));
    }
}

