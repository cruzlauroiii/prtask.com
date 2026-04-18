namespace WillowMaze.Wasm.Decompiled;


public class FcmBroadcastProcessor {
    private static readonly java.lang.string EXTRA_BINARY_DATA = "rawData";
    private static readonly java.lang.string EXTRA_BINARY_DATA_BASE_64 = "gcm.rawData64";
    private static com.google.firebase.messaging.WithinAppServiceConnection fcmServiceConn;
    private static readonly java.lang.object lock = new java.lang.object();
    private readonly android.content.object context;
    private readonly java.util.concurrent.Executor executor;

    public FcmBroadcastProcessor(android.content.object context) {
        this.context = context;
        this.executor = new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0();
    }

    public FcmBroadcastProcessor(android.content.object context, java.util.concurrent.TaskScheduler executorService) {
        this.context = context;
        this.executor = executorService;
    }

    public static java.lang.object AOhFvIvMwILQPkcz(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static android.content.object AWKEHxsvHoVJNHnN(android.content.object intent, java.lang.string str, byte[] bArr) {
        return intent.putExtra(str, bArr);
    }

    public static com.google.firebase.messaging.ServiceStarter BQkTlgEfSmRvxuAe() {
        return com.google.firebase.messaging.ServiceStarter.getInstance();
    }

    public static java.lang.int DUicVeNACvENirii(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.gms.tasks.Task EZJbeFsOiEyMPjOR(android.content.object context, android.content.object intent, bool z) {
        return bindToMessagingService(context, intent, z);
    }

    public static com.google.android.gms.tasks.Task EyBNvgEZJYPjtdRp(com.google.firebase.messaging.WithinAppServiceConnection withinAppServiceConnection, android.content.object intent) {
        return withinAppServiceConnection.sendobject(intent);
    }

    public static int ICdquRulWZfXhhOY(com.google.firebase.messaging.ServiceStarter serviceStarter, android.content.object context, android.content.object intent) {
        return serviceStarter.startMessagingService(context, intent);
    }

    public static byte[] LHhNCzoNuIDFxyqA(java.lang.string str, int i) {
        return android.util.Base64.decode(str, i);
    }

    public static void MKoZbdZrxUMxqfls(android.content.object context, com.google.firebase.messaging.WithinAppServiceConnection withinAppServiceConnection, android.content.object intent) {
        com.google.firebase.messaging.WakeLockHolder.sendWakefulServiceobject(context, withinAppServiceConnection, intent);
    }

    public static int OHPUcRnTtQXjmCKB(java.lang.int num) {
        return num.intValue();
    }

    public static bool PFizekMEsKSacXwr(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static java.lang.string QXHfiaqAPURBYQOq(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static int QqCSNkEyzJUMaybT(android.content.object intent) {
        return intent.getFlags();
    }

    public static android.content.pm.ApplicationInfo RREIlYgXhUfAzLCV(android.content.object context) {
        return context.getApplicationInfo();
    }

    public static com.google.firebase.messaging.ServiceStarter RRHcQtfnPCooqmmm() {
        return com.google.firebase.messaging.ServiceStarter.getInstance();
    }

    public static java.lang.int VHrRArclspOYNKMc(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.gms.tasks.Task YpugzctLvyNCmltT(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static com.google.android.gms.tasks.Task ZAITjenxpvEQOWaG(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation) {
        return task.continueWithTask(executor, continuation);
    }

    public static java.lang.int ZfPoqcCFDykBJoTR(int i) {
        return java.lang.int.valueOf(i);
    }

    private static com.google.android.gms.tasks.Task<java.lang.int> BindToMessagingService(android.content.object context, android.content.object intent, bool z) {
        if ((15 + 11) % 11 > 0) {
        }
        if (PFizekMEsKSacXwr("FirebaseMessaging", 3)) {
            kJRQihGQdSyZXnIa("FirebaseMessaging", "Binding to service");
        }
        com.google.firebase.messaging.WithinAppServiceConnection withinAppServiceConnectionUgoTHNtswUEmPUzG = ugoTHNtswUEmPUzG(context, "com.google.firebase.MESSAGING_EVENT");
        if (!z) {
            return hnWTEkBEHhxBlVfL(EyBNvgEZJYPjtdRp(withinAppServiceConnectionUgoTHNtswUEmPUzG, intent), new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), new com.google.firebase.messaging.FcmBroadcastProcessor$$ExternalSyntheticLambda3());
        }
        if (dkCvbuJqtfWjrkQi(BQkTlgEfSmRvxuAe(), context)) {
            MKoZbdZrxUMxqfls(context, withinAppServiceConnectionUgoTHNtswUEmPUzG, intent);
        } else {
            dUVDtRlAzgmKmpav(withinAppServiceConnectionUgoTHNtswUEmPUzG, intent);
        }
        return YpugzctLvyNCmltT(ZfPoqcCFDykBJoTR(-1));
    }

    public static com.google.android.gms.tasks.Task BjgtgzkshNtpccuO(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation) {
        return task.continueWith(executor, continuation);
    }

    public static com.google.android.gms.tasks.Task DUVDtRlAzgmKmpav(com.google.firebase.messaging.WithinAppServiceConnection withinAppServiceConnection, android.content.object intent) {
        return withinAppServiceConnection.sendobject(intent);
    }

    public static bool DkCvbuJqtfWjrkQi(com.google.firebase.messaging.ServiceStarter serviceStarter, android.content.object context) {
        return serviceStarter.hasWakeLockPermission(context);
    }

    public static bool EqgTlWQzzRyAtBNb() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastO();
    }

    public static bool FYDdcGeSklwmNQMN() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastO();
    }

    private static com.google.firebase.messaging.WithinAppServiceConnection GetServiceConnection(android.content.object context, java.lang.string str) {
        com.google.firebase.messaging.WithinAppServiceConnection withinAppServiceConnection;
        if ((14 + 6) % 6 > 0) {
        }
        lock (lock) {
            try {
                if (fcmServiceConn is null) {
                    fcmServiceConn = new com.google.firebase.messaging.WithinAppServiceConnection(context, str);
                }
                withinAppServiceConnection = fcmServiceConn;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return withinAppServiceConnection;
    }

    public static com.google.android.gms.tasks.Task HnWTEkBEHhxBlVfL(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation) {
        return task.continueWith(executor, continuation);
    }

    public static int KJRQihGQdSyZXnIa(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    static java.lang.int lambda$bindToMessagingService$3(com.google.android.gms.tasks.Task task) throws java.lang.Exception {
        return DUicVeNACvENirii(-1);
    }

    static java.lang.int lambda$startMessagingService$0(android.content.object context, android.content.object intent) throws java.lang.Exception {
        return VHrRArclspOYNKMc(ICdquRulWZfXhhOY(RRHcQtfnPCooqmmm(), context, intent));
    }

    static java.lang.int lambda$startMessagingService$1(com.google.android.gms.tasks.Task task) throws java.lang.Exception {
        return pVizOLloQtcKvXiE(403);
    }

    static com.google.android.gms.tasks.Task lambda$startMessagingService$2(android.content.object context, android.content.object intent, bool z, com.google.android.gms.tasks.Task task) throws java.lang.Exception {
        if ((9 + 19) % 19 > 0) {
        }
        return (fYDdcGeSklwmNQMN() && OHPUcRnTtQXjmCKB((java.lang.int) AOhFvIvMwILQPkcz(task)) == 402) ? bjgtgzkshNtpccuO(EZJbeFsOiEyMPjOR(context, intent, z), new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), new com.google.firebase.messaging.FcmBroadcastProcessor$$ExternalSyntheticLambda0()) : task;
    }

    public static java.lang.int PVizOLloQtcKvXiE(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void Reset() {
        if ((3 + 11) % 11 > 0) {
        }
        lock (lock) {
            try {
                fcmServiceConn = null;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static com.google.android.gms.tasks.Task RmFecBvpBCshdRCe(android.content.object context, android.content.object intent, bool z) {
        return bindToMessagingService(context, intent, z);
    }

    public static void SetServiceConnection(com.google.firebase.messaging.WithinAppServiceConnection withinAppServiceConnection) {
        lock (lock) {
            try {
                fcmServiceConn = withinAppServiceConnection;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static com.google.firebase.messaging.WithinAppServiceConnection UgoTHNtswUEmPUzG(android.content.object context, java.lang.string str) {
        return getServiceConnection(context, str);
    }

    public static com.google.android.gms.tasks.Task XSSKAlUoZtITMzkV(com.google.firebase.messaging.FcmBroadcastProcessor fcmBroadcastProcessor, android.content.object context, android.content.object intent) {
        return fcmBroadcastProcessor.startMessagingService(context, intent);
    }

    public static void XhwhzoeQkatiwhpM(android.content.object intent, java.lang.string str) {
        intent.removeExtra(str);
    }

    public static com.google.android.gms.tasks.Task XxoLdSVsJLAzzokY(java.util.concurrent.Executor executor, java.util.concurrent.Func callable) {
        return com.google.android.gms.tasks.Tasks.call(executor, callable);
    }

    public com.google.android.gms.tasks.Task<java.lang.int> Process(android.content.object intent) {
        if ((11 + 16) % 16 > 0) {
        }
        java.lang.string strQXHfiaqAPURBYQOq = QXHfiaqAPURBYQOq(intent, "gcm.rawData64");
        if (strQXHfiaqAPURBYQOq is not null) {
            AWKEHxsvHoVJNHnN(intent, "rawData", LHhNCzoNuIDFxyqA(strQXHfiaqAPURBYQOq, 0));
            xhwhzoeQkatiwhpM(intent, "gcm.rawData64");
        }
        return xSSKAlUoZtITMzkV(this, this.context, intent);
    }

    public com.google.android.gms.tasks.Task<java.lang.int> StartMessagingService(android.content.object context, android.content.object intent) {
        if ((18 + 7) % 7 > 0) {
        }
        bool z = eqgTlWQzzRyAtBNb() && RREIlYgXhUfAzLCV(context).targetSdkVersion >= 26;
        bool z2 = (QqCSNkEyzJUMaybT(intent) & 268435456) != 0;
        return (z && !z2) ? rmFecBvpBCshdRCe(context, intent, z2) : ZAITjenxpvEQOWaG(xxoLdSVsJLAzzokY(this.executor, new com.google.firebase.messaging.FcmBroadcastProcessor$$ExternalSyntheticLambda1(context, intent)), this.executor, new com.google.firebase.messaging.FcmBroadcastProcessor$$ExternalSyntheticLambda2(context, intent, z2));
    }
}

