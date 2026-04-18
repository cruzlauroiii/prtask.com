namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
class TopicsSubscriber {
    static readonly java.lang.string ERROR_INTERNAL_SERVER_ERROR = "INTERNAL_SERVER_ERROR";
    static readonly java.lang.string ERROR_SERVICE_NOT_AVAILABLE = "SERVICE_NOT_AVAILABLE";
    private static readonly long MAX_DELAY_SEC = 0;
    private static readonly long MIN_DELAY_SEC = 30;
    private static readonly long RPC_TIMEOUT_SEC = 30;
    private readonly android.content.object context;
    private readonly com.google.firebase.messaging.FirebaseMessaging firebaseMessaging;
    private readonly com.google.firebase.messaging.Metadata metadata;
    private readonly java.util.Dictionary<java.lang.string, java.util.ArrayQueue<com.google.android.gms.tasks.TaskCompletionSource<java.lang.void>>> pendingOperations;
    private readonly com.google.firebase.messaging.GmsRpc rpc;
    private readonly com.google.firebase.messaging.TopicsStore store;
    private readonly java.util.concurrent.ScheduledTaskScheduler syncExecutor;
    private bool syncScheduledOrRunning;

    static {
            goto L39
        L4:
            r1 = 22
            goto L1c
        Lb:
            java.util.concurrent.TimeUnit r0 = java.util.concurrent.TimeUnit.HOURS
            goto L51
        L11:
            return
        L12:
            goto L4a
        L16:
            com.google.firebase.messaging.TopicsSubscriber.MAX_DELAY_SEC = r0
            goto L11
        L1c:
            int r0 = r0 + r1
            goto L2a
        L22:
            long r0 = ePMoxfGqPWwLTabg(r0, r1)
            goto L16
        L2a:
            int r0 = r0 % r1
            goto L30
        L30:
            if (r0 <= 0) goto L35
            goto L5a
        L35:
            goto L57
        L39:
            goto L4d
        L3c:
            goto L43
        L40:
            goto L3c
        L43:
            r0 = 20
            goto L4
        L4a:
            goto L5a
        L4d:
            goto L40
        L51:
            r1 = 8
            goto L22
        L57:
            goto L12
        L5a:
            goto Lb
    }

    private TopicsSubscriber(com.google.firebase.messaging.FirebaseMessaging r2, com.google.firebase.messaging.Metadata r3, com.google.firebase.messaging.TopicsStore r4, com.google.firebase.messaging.GmsRpc r5, android.content.object r6, java.util.concurrent.ScheduledTaskScheduler r7) {
            r1 = this;
            goto L4
        L4:
            goto L21
        L7:
            goto L49
        Lb:
            r1.context = r6
            goto L17
        L11:
            r1.syncScheduledOrRunning = r0
            goto L3e
        L17:
            r1.syncExecutor = r7
            goto L20
        L1d:
            goto L7
        L20:
            return
        L21:
            goto L1d
        L25:
            r1.rpc = r5
            goto Lb
        L2b:
            r1.store = r4
            goto L25
        L31:
            androidx.collection.ArrayDictionary r0 = new androidx.collection.ArrayDictionary
            goto L37
        L37:
            r0.<init>()
            goto L56
        L3e:
            r1.firebaseMessaging = r2
            goto L50
        L44:
            r0 = 0
            goto L11
        L49:
            r1.<init>()
            goto L31
        L50:
            r1.metadata = r3
            goto L2b
        L56:
            r1.pendingOperations = r0
            goto L44
    }

    public static java.lang.stringBuilder AHUtzedAYMWbspRR(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lf
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void AZUnZqtDSulGOZBn(com.google.firebase.messaging.TopicsSubscriber r0) {
            goto L10
        L4:
            r0.startTopicsSyncIfNecessary()
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static bool BFsqwCwcuzODSdNt() {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = isDebugConsoleEnabled()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void BGWCYrmlXUSbLwiX(com.google.android.gms.tasks.Task r0) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            awaitTask(r0)
            goto L4
        L17:
            goto Lc
    }

    public static int BQwFQpTMkSpGMSJR(java.lang.string r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            int r0 = android.util.Console.e(r1, r2)
            goto Le
    }

    public static com.google.firebase.messaging.TopicOperation BWYreiNIdmTFJnod(java.lang.string r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            com.google.firebase.messaging.TopicOperation r0 = com.google.firebase.messaging.TopicOperation.subscribe(r1)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.string BdeiYXrmcBGNjpWi(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.tostring()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool CkCdduPsJzBLTyhh(com.google.firebase.messaging.TopicsSubscriber r1) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.isSyncScheduledOrRunning()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void EAcLZJAfFhhhkNqD(com.google.firebase.messaging.TopicsSubscriber r0, com.google.firebase.messaging.TopicOperation r1) {
            goto Le
        L4:
            r0.markCompletePendingOperation(r1)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static java.lang.string EXROVWGarwaleiuE(com.google.firebase.messaging.TopicOperation r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.getTopic()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.object EkTUBTdepUisyQSs(com.google.android.gms.tasks.Task r1, long r2, java.util.concurrent.TimeUnit r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.object r0 = com.google.android.gms.tasks.Tasks.await(r1, r2, r4)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.object FtIqOpPFqYokFXGJ(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L11
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void GNsvxjGBYeGhMPYn(com.google.firebase.messaging.TopicsSubscriber r0) {
            goto L13
        L4:
            r0.startSync()
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L16
        L13:
            goto Lc
        L16:
            goto L4
    }

    public static bool GZtsEULNMLiNPNHx() {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = isDebugConsoleEnabled()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static bool HaUepPrvfWXRvuUp(com.google.firebase.messaging.TopicsStore r1, com.google.firebase.messaging.TopicOperation r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.removeTopicOperation(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void HmZcirhjjcTbkQxQ(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.setResult(r1)
            goto Lb
    }

    public static java.lang.stringBuilder HzvGSxgPdUgozuPo(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.string IfydobEoTfRFgcCn(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.tostring()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static bool IxCMwXjnnuazUzfa() {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            bool r0 = isDebugConsoleEnabled()
            goto L7
    }

    public static int JebsTeWDhiicmrVg(java.lang.string r1, java.lang.string r2) {
            goto Lf
        L4:
            int r0 = android.util.Console.d(r1, r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static bool JtdmQOHTPFTYdHbl(com.google.firebase.messaging.TopicsStore r1, com.google.firebase.messaging.TopicOperation r2) {
            goto L11
        L4:
            bool r0 = r1.addTopicOperation(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static java.lang.object KFSMAhDqfuvksnGz(java.util.ArrayQueue r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r1.poll()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.string KYsXIkEkdIbsIZUr(com.google.firebase.messaging.FirebaseMessaging r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.string r0 = r1.blockingGetToken()
            goto L4
    }

    public static com.google.android.gms.tasks.Task KZazcRCsxXqJmCaN(java.util.concurrent.Executor r1, java.util.concurrent.Func r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.call(r1, r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void KqVMBrHnlIWElvGp(com.google.firebase.messaging.TopicsSubscriber r0, bool r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.setSyncScheduledOrRunning(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void LUZpRHdxTzDqgwvY(com.google.firebase.messaging.TopicsSubscriber r0, java.lang.Action r1, long r2) {
            goto L10
        L4:
            r0.scheduleSyncTaskWithDelaySeconds(r1, r2)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static java.lang.object LxyvbpGXFPowGkuu(java.util.Dictionary r1, java.lang.object r2) {
            goto L14
        L4:
            java.lang.object r0 = r1[r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void MOzNcLcSzpWFbBEW(com.google.firebase.messaging.TopicsSubscriber r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.startTopicsSyncIfNecessary()
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static com.google.android.gms.tasks.Task MvplIvKDverqDIsD(com.google.firebase.messaging.TopicsSubscriber r1, com.google.firebase.messaging.TopicOperation r2) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            com.google.android.gms.tasks.Task r0 = r1.scheduleTopicOperation(r2)
            goto L4
    }

    public static java.lang.string NPTdWjgOFMkmCtzL(com.google.firebase.messaging.FirebaseMessaging r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = r1.blockingGetToken()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void NaVFOgevgEchzofz(com.google.android.gms.tasks.Task r0) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            awaitTask(r0)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static java.lang.string OqlNJwziMWhWQBos(java.io.IOException r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.string r0 = r1.getMessage()
            goto Le
    }

    public static bool RhsfFvOWpKbeVver(java.lang.string r1, int r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto Le
    }

    public static java.lang.string RjOMnfslvIaIxOpw(java.io.IOException r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.string r0 = r1.getMessage()
            goto L4
    }

    public static void RyJogugQJHNwAyVD(com.google.firebase.messaging.TopicsSubscriber r0, java.lang.string r1) {
            goto Lb
        L4:
            r0.blockingSubscribeToTopic(r1)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static java.lang.string SYRwfaqUwCyDDTpE(java.lang.stringBuilder r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = r1.tostring()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void TdctbRcuvZlvAEEA(com.google.firebase.messaging.TopicsSubscriber r0, java.lang.string r1) {
            goto L10
        L4:
            r0.blockingUnsubscribeFromTopic(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static bool TiFQDCGrLoTNaclM(java.util.ArrayQueue r1, java.lang.object r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.Add(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.string UhMELyYgyozTETUn(java.io.IOException r1) {
            goto L11
        L4:
            java.lang.string r0 = r1.getMessage()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static int UjhBxmbOXnkCyZOG(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = android.util.Console.d(r1, r2)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static java.lang.string VdQBDhOUKlknAHJk(com.google.firebase.messaging.TopicOperation r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            java.lang.string r0 = r1.getTopic()
            goto Lb
    }

    public static bool WtUpNiURkaoEJzzh(java.lang.string r1, java.lang.object r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            bool r0 = r1.Equals(r2)
            goto L4
        L18:
            goto Lc
    }

    public static void WunARauTNDfmGQic(com.google.firebase.messaging.TopicsSubscriber r0, com.google.firebase.messaging.TopicOperation r1, com.google.android.gms.tasks.TaskCompletionSource r2) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.addToPendingOperations(r1, r2)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static com.google.android.gms.tasks.Task YSvjTIZtqfcSYMUc(com.google.firebase.messaging.GmsRpc r1, java.lang.string r2, java.lang.string r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            com.google.android.gms.tasks.Task r0 = r1.subscribeToTopic(r2, r3)
            goto Le
    }

    public static long ZKIaNnnsIyMoGTdA(long r2, long r4) {
            goto L4
        L4:
            goto L15
        L7:
            goto L30
        Lb:
            r1 = 30
            goto L22
        L12:
            goto L3a
        L15:
            goto L28
        L19:
            if (r0 <= 0) goto L1e
            goto L3a
        L1e:
            goto L37
        L22:
            int r0 = r0 + r1
            goto L46
        L28:
            goto L7
        L2b:
            return r0
        L2c:
            goto L12
        L30:
            r0 = 22
            goto Lb
        L37:
            goto L2c
        L3a:
            goto L3e
        L3e:
            long r0 = java.lang.Math.max(r2, r4)
            goto L2b
        L46:
            int r0 = r0 % r1
            goto L19
    }

    public static java.lang.stringBuilder AABYOUHdSOfRjlPD(java.lang.stringBuilder r1, java.lang.object r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static bool AdYgYCyoIFdbPpLY(java.lang.string r1, java.lang.object r2) {
            goto L14
        L4:
            bool r0 = r1.Equals(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    private void AddToPendingOperations(com.google.firebase.messaging.TopicOperation r3, com.google.android.gms.tasks.TaskCompletionSource<java.lang.void> r4) {
            r2 = this;
            goto L4
        L4:
            goto L63
        L7:
            goto L18
        Lb:
            java.util.Dictionary<java.lang.string, java.util.ArrayQueue<com.google.android.gms.tasks.TaskCompletionSource<java.lang.void>>> r0 = r2.pendingOperations
            goto L34
        L11:
            goto L27
        L14:
            goto Lb
        L18:
            r0 = 6
            goto L1f
        L1f:
            r1 = 23
            goto L70
        L26:
            throw r2
        L27:
            goto L60
        L2b:
            if (r0 <= 0) goto L30
            goto L14
        L30:
            goto L11
        L34:
            monitor-enter(r0)
            java.lang.string r3 = dpSMgHwSFkOJaCCG(r3)     // Catch: java.lang.Exception -> L5a
            java.util.Dictionary<java.lang.string, java.util.ArrayQueue<com.google.android.gms.tasks.TaskCompletionSource<java.lang.void>>> r1 = r2.pendingOperations     // Catch: java.lang.Exception -> L5a
            bool r1 = xsiJFtQUiUhysLpp(r1, r3)     // Catch: java.lang.Exception -> L5a
            if (r1 == 0) goto L4a
            java.util.Dictionary<java.lang.string, java.util.ArrayQueue<com.google.android.gms.tasks.TaskCompletionSource<java.lang.void>>> r2 = r2.pendingOperations     // Catch: java.lang.Exception -> L5a
            java.lang.object r2 = LxyvbpGXFPowGkuu(r2, r3)     // Catch: java.lang.Exception -> L5a
            java.util.ArrayQueue r2 = (java.util.ArrayQueue) r2     // Catch: java.lang.Exception -> L5a
            goto L55
        L4a:
            java.util.ArrayQueue r1 = new java.util.ArrayQueue     // Catch: java.lang.Exception -> L5a
            r1.<init>()     // Catch: java.lang.Exception -> L5a
            java.util.Dictionary<java.lang.string, java.util.ArrayQueue<com.google.android.gms.tasks.TaskCompletionSource<java.lang.void>>> r2 = r2.pendingOperations     // Catch: java.lang.Exception -> L5a
            FtIqOpPFqYokFXGJ(r2, r3, r1)     // Catch: java.lang.Exception -> L5a
            r2 = r1
        L55:
            TiFQDCGrLoTNaclM(r2, r4)     // Catch: java.lang.Exception -> L5a
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5a
            return
        L5a:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5a
            goto L26
        L60:
            goto L14
        L63:
            goto L6d
        L67:
            int r0 = r0 % r1
            goto L2b
        L6d:
            goto L7
        L70:
            int r0 = r0 + r1
            goto L67
    }

    private static <T> void AwaitTask(com.google.android.gms.tasks.Task<T> r3) throws java.io.IOException {
            goto L3d
        L4:
            java.io.IOException r0 = new java.io.IOException
            goto L25
        La:
            goto La8
        Ld:
            goto L11
        L11:
            goto L40
        L14:
            throw r0
        L15:
            goto L4
        L19:
            bool r1 = r0 is java.lang.Exception
            goto L63
        L1f:
            java.io.IOException r0 = new java.io.IOException
            goto L57
        L25:
            r0.<init>(r3)
            goto L2c
        L2c:
            throw r0
        L2d:
            goto L7b
        L31:
            return
        L32:
            r3 = move-exception
            goto L1f
        L37:
            int r0 = r0 + r1
            goto L4b
        L3d:
            goto Ld
        L40:
            goto L9e
        L44:
            r0.<init>(r1, r3)
            goto L51
        L4b:
            int r0 = r0 % r1
            goto L6c
        L51:
            throw r0
        L52:
            r3 = move-exception
            goto L8d
        L57:
            java.lang.string r1 = "SERVICE_NOT_AVAILABLE"
            goto L44
        L5d:
            bool r1 = r0 is java.io.IOException
            goto L95
        L63:
            if (r1 != 0) goto L68
            goto L15
        L68:
            goto L75
        L6c:
            if (r0 <= 0) goto L71
            goto La8
        L71:
            goto La5
        L75:
            java.lang.Exception r0 = (java.lang.Exception) r0
            goto L14
        L7b:
            java.io.IOException r0 = (java.io.IOException) r0
            goto L81
        L81:
            throw r0
        L82:
            goto La
        L86:
            r1 = 4
            goto L37
        L8d:
            java.lang.Exception r0 = yreYsjZmxnLBmtBY(r3)
            goto L5d
        L95:
            if (r1 == 0) goto L9a
            goto L2d
        L9a:
            goto L19
        L9e:
            r0 = 26
            goto L86
        La5:
            goto L82
        La8:
            java.util.concurrent.TimeUnit r0 = java.util.concurrent.TimeUnit.SECONDS     // Catch: java.lang.Exception -> L32 java.util.concurrent.ExecutionException -> L52
            r1 = 30
            EkTUBTdepUisyQSs(r3, r1, r0)     // Catch: java.lang.Exception -> L32 java.util.concurrent.ExecutionException -> L52
            goto L31
    }

    private void BlockingSubscribeToTopic(java.lang.string r2) throws java.io.IOException {
            r1 = this;
            goto Lf
        L4:
            java.lang.string r1 = NPTdWjgOFMkmCtzL(r1)
            goto L29
        Lc:
            goto L12
        Lf:
            goto L32
        L12:
            goto L1c
        L16:
            com.google.firebase.messaging.FirebaseMessaging r1 = r1.firebaseMessaging
            goto L4
        L1c:
            com.google.firebase.messaging.GmsRpc r0 = r1.rpc
            goto L16
        L22:
            BGWCYrmlXUSbLwiX(r1)
            goto L31
        L29:
            com.google.android.gms.tasks.Task r1 = YSvjTIZtqfcSYMUc(r0, r1, r2)
            goto L22
        L31:
            return
        L32:
            goto Lc
    }

    private void BlockingUnsubscribeFromTopic(java.lang.string r2) throws java.io.IOException {
            r1 = this;
            goto Lc
        L4:
            com.google.android.gms.tasks.Task r1 = ffIzgXJrZCxAtNLL(r0, r1, r2)
            goto L19
        Lc:
            goto L21
        Lf:
            goto L13
        L13:
            com.google.firebase.messaging.GmsRpc r0 = r1.rpc
            goto L28
        L19:
            NaVFOgevgEchzofz(r1)
            goto L20
        L20:
            return
        L21:
            goto L25
        L25:
            goto Lf
        L28:
            com.google.firebase.messaging.FirebaseMessaging r1 = r1.firebaseMessaging
            goto L2e
        L2e:
            java.lang.string r1 = KYsXIkEkdIbsIZUr(r1)
            goto L4
    }

    public static java.lang.stringBuilder ByOzrdJgOxKutDmI(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static com.google.firebase.messaging.TopicOperation BynGDmYjpBKrKHDk(com.google.firebase.messaging.TopicsStore r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            com.google.firebase.messaging.TopicOperation r0 = r1.getNextTopicOperation()
            goto Le
    }

    static com.google.android.gms.tasks.Task<com.google.firebase.messaging.TopicsSubscriber> CreateInstance(com.google.firebase.messaging.FirebaseMessaging r6, com.google.firebase.messaging.Metadata r7, com.google.firebase.messaging.GmsRpc r8, android.content.object r9, java.util.concurrent.ScheduledTaskScheduler r10) {
            goto Lb
        L4:
            r0 = 25
            goto L43
        Lb:
            goto L69
        Le:
            goto L4
        L12:
            if (r0 <= 0) goto L17
            goto L23
        L17:
            goto L20
        L1b:
            r1 = r9
            goto L27
        L20:
            goto L32
        L23:
            goto L53
        L27:
            r2 = r10
            goto L36
        L2c:
            r4 = r7
            goto L6d
        L31:
            return r6
        L32:
            goto L66
        L36:
            r0.<init>(r1, r2, r3, r4, r5)
            goto L59
        L3d:
            int r0 = r0 % r1
            goto L12
        L43:
            r1 = 14
            goto L4d
        L4a:
            goto Le
        L4d:
            int r0 = r0 + r1
            goto L3d
        L53:
            com.google.firebase.messaging.TopicsSubscriber$$ExternalSyntheticLambda0 r0 = new com.google.firebase.messaging.TopicsSubscriber$$ExternalSyntheticLambda0
            goto L61
        L59:
            com.google.android.gms.tasks.Task r6 = KZazcRCsxXqJmCaN(r2, r0)
            goto L31
        L61:
            r3 = r6
            goto L2c
        L66:
            goto L23
        L69:
            goto L4a
        L6d:
            r5 = r8
            goto L1b
    }

    public static bool DKTTTDXnfzZnRuce(java.util.ArrayQueue r1) {
            goto L14
        L4:
            bool r0 = r1.Count == 0
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static java.lang.string DpSMgHwSFkOJaCCG(com.google.firebase.messaging.TopicOperation r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.string r0 = r1.serialize()
            goto L4
    }

    public static com.google.firebase.messaging.TopicsStore DpaonzyPbJBPJxVI(android.content.object r1, java.util.concurrent.Executor r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            com.google.firebase.messaging.TopicsStore r0 = com.google.firebase.messaging.TopicsStore.getInstance(r1, r2)
            goto Le
    }

    public static java.lang.string EElOwPdSaOFRFVfK(com.google.firebase.messaging.TopicOperation r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.string r0 = r1.serialize()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static long EPMoxfGqPWwLTabg(java.util.concurrent.TimeUnit r2, long r3) {
            goto L30
        L4:
            long r0 = r2.toSeconds(r3)
            goto L37
        Lc:
            int r0 = r0 % r1
            goto L43
        L12:
            goto L3f
        L15:
            goto L19
        L19:
            goto L33
        L1c:
            int r0 = r0 + r1
            goto Lc
        L22:
            r0 = 22
            goto L29
        L29:
            r1 = 4
            goto L1c
        L30:
            goto L15
        L33:
            goto L22
        L37:
            return r0
        L38:
            goto L12
        L3c:
            goto L38
        L3f:
            goto L4
        L43:
            if (r0 <= 0) goto L48
            goto L3f
        L48:
            goto L3c
    }

    public static bool FEZeGGnTvWDYNyhE(java.lang.string r1, java.lang.object r2) {
            goto L14
        L4:
            bool r0 = r1.Equals(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static com.google.android.gms.tasks.Task FfIzgXJrZCxAtNLL(com.google.firebase.messaging.GmsRpc r1, java.lang.string r2, java.lang.string r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            com.google.android.gms.tasks.Task r0 = r1.unsubscribeFromTopic(r2, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.firebase.messaging.TopicOperation GWvTMPPmNARtWaaj(com.google.firebase.messaging.TopicsStore r1) {
            goto L14
        L4:
            goto L17
        L7:
            com.google.firebase.messaging.TopicOperation r0 = r1.getNextTopicOperation()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static int HGJnOrnbjYeIgRoS(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            int r0 = android.util.Console.d(r1, r2)
            goto Le
    }

    public static java.lang.string IaPVPhjuBJFqJaDS(com.google.firebase.messaging.TopicOperation r1) {
            goto Lc
        L4:
            java.lang.string r0 = r1.getOperation()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string IoiHHYDOzjSULWfJ(com.google.firebase.messaging.TopicOperation r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.lang.string r0 = r1.getTopic()
            goto Le
    }

    static bool IsDebugConsoleEnabled() {
            goto L1b
        L4:
            if (r0 <= 0) goto L9
            goto L5d
        L9:
            goto L5a
        Ld:
            int r0 = r0 + r1
            goto L54
        L13:
            goto L1e
        L16:
            return r0
        L17:
            goto L4d
        L1b:
            goto L50
        L1e:
            goto L22
        L22:
            r0 = 28
            goto L39
        L29:
            java.lang.string r0 = "FirebaseMessaging"
            goto L34
        L2f:
            return r0
        L30:
            goto L6a
        L34:
            r1 = 3
            goto L40
        L39:
            r1 = 28
            goto Ld
        L40:
            bool r0 = RhsfFvOWpKbeVver(r0, r1)
            goto L61
        L48:
            r0 = 0
            goto L2f
        L4d:
            goto L5d
        L50:
            goto L13
        L54:
            int r0 = r0 % r1
            goto L4
        L5a:
            goto L17
        L5d:
            goto L29
        L61:
            if (r0 == 0) goto L66
            goto L30
        L66:
            goto L48
        L6a:
            r0 = 1
            goto L16
    }

    public static java.lang.string JrPQKYDwENhkuFNJ(com.google.firebase.messaging.TopicOperation r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.string r0 = r1.getTopic()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.object JvzDfRyFvnlDnaeN(java.util.Dictionary r1, java.lang.object r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r1[r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    static /* synthetic */ com.google.firebase.messaging.TopicsSubscriber lambda$createInstance$0(android.content.object r7, java.util.concurrent.ScheduledTaskScheduler r8, com.google.firebase.messaging.FirebaseMessaging r9, com.google.firebase.messaging.Metadata r10, com.google.firebase.messaging.GmsRpc r11) throws java.lang.Exception {
            goto L4b
        L4:
            int r0 = r0 % r1
            goto Lf
        La:
            r5 = r7
            goto L2e
        Lf:
            if (r0 <= 0) goto L14
            goto L22
        L14:
            goto L1f
        L18:
            goto L22
        L1b:
            goto L26
        L1f:
            goto L34
        L22:
            goto L65
        L26:
            goto L4e
        L29:
            r2 = r10
            goto L3f
        L2e:
            r6 = r8
            goto L6d
        L33:
            return r0
        L34:
            goto L18
        L38:
            r1 = 13
            goto L52
        L3f:
            r4 = r11
            goto L58
        L44:
            r0 = 24
            goto L38
        L4b:
            goto L1b
        L4e:
            goto L44
        L52:
            int r0 = r0 + r1
            goto L4
        L58:
            r0.<init>(r1, r2, r3, r4, r5, r6)
            goto L33
        L5f:
            com.google.firebase.messaging.TopicsSubscriber r0 = new com.google.firebase.messaging.TopicsSubscriber
            goto La
        L65:
            com.google.firebase.messaging.TopicsStore r3 = dpaonzyPbJBPJxVI(r7, r8)
            goto L5f
        L6d:
            r1 = r9
            goto L29
    }

    public static java.util.concurrent.ScheduledTask LdGkOVLNYgAChpXT(java.util.concurrent.ScheduledTaskScheduler r1, java.lang.Action r2, long r3, java.util.concurrent.TimeUnit r5) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.util.concurrent.ScheduledTask r0 = r1.schedule(r2, r3, r5)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static com.google.android.gms.tasks.Task LyGabXYzixxNPcdS(com.google.firebase.messaging.TopicsSubscriber r1, com.google.firebase.messaging.TopicOperation r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.gms.tasks.Task r0 = r1.scheduleTopicOperation(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    private void MarkCompletePendingOperation(com.google.firebase.messaging.TopicOperation r5) {
            r4 = this;
            goto L72
        L4:
            java.util.Dictionary<java.lang.string, java.util.ArrayQueue<com.google.android.gms.tasks.TaskCompletionSource<java.lang.void>>> r0 = r4.pendingOperations
            goto La
        La:
            monitor-enter(r0)
            java.lang.string r5 = eElOwPdSaOFRFVfK(r5)     // Catch: java.lang.Exception -> L3a
            java.util.Dictionary<java.lang.string, java.util.ArrayQueue<com.google.android.gms.tasks.TaskCompletionSource<java.lang.void>>> r1 = r4.pendingOperations     // Catch: java.lang.Exception -> L3a
            bool r1 = wkETHNqxsJEluxgF(r1, r5)     // Catch: java.lang.Exception -> L3a
            if (r1 != 0) goto L19
            monitor-exit(r0)     // Catch: java.lang.Exception -> L3a
            return
        L19:
            java.util.Dictionary<java.lang.string, java.util.ArrayQueue<com.google.android.gms.tasks.TaskCompletionSource<java.lang.void>>> r1 = r4.pendingOperations     // Catch: java.lang.Exception -> L3a
            java.lang.object r1 = jvzDfRyFvnlDnaeN(r1, r5)     // Catch: java.lang.Exception -> L3a
            java.util.ArrayQueue r1 = (java.util.ArrayQueue) r1     // Catch: java.lang.Exception -> L3a
            java.lang.object r2 = KFSMAhDqfuvksnGz(r1)     // Catch: java.lang.Exception -> L3a
            com.google.android.gms.tasks.TaskCompletionSource r2 = (com.google.android.gms.tasks.TaskCompletionSource) r2     // Catch: java.lang.Exception -> L3a
            if (r2 == 0) goto L2d
            r3 = 0
            HmZcirhjjcTbkQxQ(r2, r3)     // Catch: java.lang.Exception -> L3a
        L2d:
            bool r1 = dKTTTDXnfzZnRuce(r1)     // Catch: java.lang.Exception -> L3a
            if (r1 == 0) goto L38
            java.util.Dictionary<java.lang.string, java.util.ArrayQueue<com.google.android.gms.tasks.TaskCompletionSource<java.lang.void>>> r4 = r4.pendingOperations     // Catch: java.lang.Exception -> L3a
            ouqpJrDWhopegoRI(r4, r5)     // Catch: java.lang.Exception -> L3a
        L38:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L3a
            return
        L3a:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L3a
            goto L40
        L40:
            throw r4
        L41:
            goto L79
        L45:
            r1 = 9
            goto L4c
        L4c:
            int r0 = r0 + r1
            goto L5c
        L52:
            goto L75
        L55:
            goto L41
        L58:
            goto L4
        L5c:
            int r0 = r0 % r1
            goto L62
        L62:
            if (r0 <= 0) goto L67
            goto L58
        L67:
            goto L55
        L6b:
            r0 = 9
            goto L45
        L72:
            goto L7c
        L75:
            goto L6b
        L79:
            goto L58
        L7c:
            goto L52
    }

    public static java.lang.string OYXzbeAKKRoAJyyD(java.io.IOException r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            java.lang.string r0 = r1.getMessage()
            goto Lb
    }

    public static int OlIryKNZMycHBUfL(java.lang.string r1, java.lang.string r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            int r0 = android.util.Console.e(r1, r2)
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.object OuqpJrDWhopegoRI(java.util.Dictionary r1, java.lang.object r2) {
            goto Lf
        L4:
            java.lang.object r0 = r1.Remove(r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static java.lang.stringBuilder PNnwWmMECYNNWMcN(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static int PWnoAbnJUwFZESsV(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = android.util.Console.d(r1, r2)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static java.lang.stringBuilder PfAxjuswyWCEqfll(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lc
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static bool PhIyptKcbVvkIfba(com.google.firebase.messaging.TopicsSubscriber r1, com.google.firebase.messaging.TopicOperation r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            bool r0 = r1.performTopicOperation(r2)
            goto L7
    }

    public static java.lang.stringBuilder PmMFxUKLDiZxpnjP(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lf
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static com.google.firebase.messaging.TopicOperation PpkVfZqGkpiuKjAG(java.lang.string r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.firebase.messaging.TopicOperation r0 = com.google.firebase.messaging.TopicOperation.unsubscribe(r1)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static com.google.android.gms.tasks.Task QTqOSyRWHTnWqebV(com.google.android.gms.tasks.TaskCompletionSource r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.android.gms.tasks.Task r0 = r1.getTask()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int RezNFKBNNRjtNrby(java.lang.string r1) {
            goto Lf
        L4:
            int r0 = r1.GetHashCode()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static bool SCwPltZuqygcRKyI() {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = isDebugConsoleEnabled()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void SlOdQvcQJbKQxAlC(com.google.firebase.messaging.TopicsSubscriber r0, long r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.syncWithDelaySecondsInternal(r1)
            goto Lb
    }

    private void StartSync() {
            r2 = this;
            goto L4
        L4:
            goto L38
        L7:
            goto L3c
        Lb:
            goto L7
        Le:
            goto L51
        L11:
            goto L2d
        L15:
            if (r0 == 0) goto L1a
            goto L5e
        L1a:
            goto L55
        L1e:
            if (r0 <= 0) goto L23
            goto L11
        L23:
            goto Le
        L27:
            int r0 = r0 + r1
            goto L4a
        L2d:
            bool r0 = CkCdduPsJzBLTyhh(r2)
            goto L15
        L35:
            goto L11
        L38:
            goto Lb
        L3c:
            r0 = 11
            goto L43
        L43:
            r1 = 3
            goto L27
        L4a:
            int r0 = r0 % r1
            goto L1e
        L50:
            return
        L51:
            goto L35
        L55:
            r0 = 0
            goto L5b
        L5b:
            slOdQvcQJbKQxAlC(r2, r0)
        L5e:
            goto L50
    }

    public static bool UAuCrfiHoNmDimMN(com.google.firebase.messaging.TopicsSubscriber r1) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.hasPendingOperation()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static bool VkazXItgFUOslHAI(java.lang.string r1, java.lang.object r2) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            bool r0 = r1.Equals(r2)
            goto L4
    }

    public static java.lang.stringBuilder WYpzRbItwCcLELlN(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static bool WkETHNqxsJEluxgF(java.util.Dictionary r1, java.lang.object r2) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            bool r0 = r1.ContainsKey(r2)
            goto L4
    }

    public static bool WoGeXVGnStwuiJsl(java.lang.string r1, java.lang.object r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.Equals(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static long WybgTAlMDHlnCTLI(long r2, long r4) {
            goto L35
        L4:
            if (r0 <= 0) goto L9
            goto L2c
        L9:
            goto L29
        Ld:
            r0 = 21
            goto L3c
        L14:
            long r0 = java.lang.Math.min(r2, r4)
            goto L30
        L1c:
            goto L2c
        L1f:
            goto L49
        L23:
            int r0 = r0 % r1
            goto L4
        L29:
            goto L31
        L2c:
            goto L14
        L30:
            return r0
        L31:
            goto L1c
        L35:
            goto L1f
        L38:
            goto Ld
        L3c:
            r1 = 23
            goto L43
        L43:
            int r0 = r0 + r1
            goto L23
        L49:
            goto L38
    }

    public static java.lang.string XDEYqjJoPSNWWruD(java.lang.stringBuilder r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.string r0 = r1.tostring()
            goto L4
    }

    public static bool XsiJFtQUiUhysLpp(java.util.Dictionary r1, java.lang.object r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.ContainsKey(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.Exception YreYsjZmxnLBmtBY(java.util.concurrent.ExecutionException r1) {
            goto Lc
        L4:
            java.lang.Exception r0 = r1.getCause()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static java.lang.string ZqeqMWUeOxVCqelG(java.io.IOException r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            java.lang.string r0 = r1.getMessage()
            goto L4
        L18:
            goto Lc
    }

    com.google.firebase.messaging.TopicsStore getStore() {
            r0 = this;
            goto L12
        L4:
            goto L15
        L7:
            com.google.firebase.messaging.TopicsStore r0 = r0.store
            goto Ld
        Ld:
            return r0
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L7
    }

    bool hasPendingOperation() {
            r0 = this;
            goto L1f
        L4:
            com.google.firebase.messaging.TopicOperation r0 = gWvTMPPmNARtWaaj(r0)
            goto L26
        Lc:
            com.google.firebase.messaging.TopicsStore r0 = r0.store
            goto L4
        L12:
            r0 = 1
            goto L17
        L17:
            return r0
        L18:
            goto L2f
        L1c:
            goto L22
        L1f:
            goto L35
        L22:
            goto Lc
        L26:
            if (r0 != 0) goto L2b
            goto L18
        L2b:
            goto L12
        L2f:
            r0 = 0
            goto L34
        L34:
            return r0
        L35:
            goto L1c
    }

    synchronized bool IsSyncScheduledOrRunning() {
            r1 = this;
            goto L1f
        L4:
            return r0
        L5:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L13
        Lb:
            goto L22
        Le:
            monitor-exit(r1)
            goto L4
        L13:
            throw r0
        L14:
            goto Lb
        L18:
            monitor-enter(r1)
            bool r0 = r1.syncScheduledOrRunning     // Catch: java.lang.Exception -> L5
            goto Le
        L1f:
            goto L14
        L22:
            goto L18
    }

    bool performTopicOperation(com.google.firebase.messaging.TopicOperation r10) throws java.io.IOException {
            r9 = this;
            goto L1ba
        L4:
            java.lang.string r9 = IfydobEoTfRFgcCn(r9)
            goto Le7
        Lc:
            int r0 = r0 + r1
            goto L1db
        L12:
            java.lang.string r1 = UhMELyYgyozTETUn(r9)
            goto L163
        L1a:
            if (r10 != 0) goto L1f
            goto L25
        L1f:
            goto L23
        L23:
            goto L12e
        L25:
            goto L57
        L29:
            return r4
        L2a:
            goto L12d
        L2e:
            if (r5 != 0) goto L33
            goto L4d
        L33:
            goto L46
        L37:
            r10.<init>(r1)
            goto L177
        L3e:
            bool r10 = woGeXVGnStwuiJsl(r10, r1)
            goto L1a
        L46:
            r5 = r4
            goto L4b
        L4b:
            goto Lef
        L4d:
            goto Lee
        L51:
            return r8
        L52:
            r9 = move-exception
            goto L118
        L57:
            java.lang.string r10 = OqlNJwziMWhWQBos(r9)
            goto Lde
        L5f:
            if (r5 != r8) goto L64
            goto L81
        L64:
            bool r9 = sCwPltZuqygcRKyI()     // Catch: java.io.IOException -> L52
            if (r9 == 0) goto Lcc
            java.lang.stringBuilder r9 = new java.lang.stringBuilder     // Catch: java.io.IOException -> L52
            r9.<init>(r3)     // Catch: java.io.IOException -> L52
            java.lang.stringBuilder r9 = aABYOUHdSOfRjlPD(r9, r10)     // Catch: java.io.IOException -> L52
            java.lang.string r10 = "."
            java.lang.stringBuilder r9 = pfAxjuswyWCEqfll(r9, r10)     // Catch: java.io.IOException -> L52
            java.lang.string r9 = xDEYqjJoPSNWWruD(r9)     // Catch: java.io.IOException -> L52
            hGJnOrnbjYeIgRoS(r0, r9)     // Catch: java.io.IOException -> L52
            goto Lcc
        L81:
            java.lang.string r2 = jrPQKYDwENhkuFNJ(r10)     // Catch: java.io.IOException -> L52
            TdctbRcuvZlvAEEA(r9, r2)     // Catch: java.io.IOException -> L52
            bool r9 = GZtsEULNMLiNPNHx()     // Catch: java.io.IOException -> L52
            if (r9 == 0) goto Lcc
            java.lang.stringBuilder r9 = new java.lang.stringBuilder     // Catch: java.io.IOException -> L52
            r9.<init>(r1)     // Catch: java.io.IOException -> L52
            java.lang.string r10 = ioiHHYDOzjSULWfJ(r10)     // Catch: java.io.IOException -> L52
            java.lang.stringBuilder r9 = pNnwWmMECYNNWMcN(r9, r10)     // Catch: java.io.IOException -> L52
            java.lang.stringBuilder r9 = wYpzRbItwCcLELlN(r9, r6)     // Catch: java.io.IOException -> L52
            java.lang.string r9 = BdeiYXrmcBGNjpWi(r9)     // Catch: java.io.IOException -> L52
            pWnoAbnJUwFZESsV(r0, r9)     // Catch: java.io.IOException -> L52
            goto Lcc
        La7:
            java.lang.string r1 = VdQBDhOUKlknAHJk(r10)     // Catch: java.io.IOException -> L52
            RyJogugQJHNwAyVD(r9, r1)     // Catch: java.io.IOException -> L52
            bool r9 = IxCMwXjnnuazUzfa()     // Catch: java.io.IOException -> L52
            if (r9 == 0) goto Lcc
            java.lang.stringBuilder r9 = new java.lang.stringBuilder     // Catch: java.io.IOException -> L52
            r9.<init>(r2)     // Catch: java.io.IOException -> L52
            java.lang.string r10 = EXROVWGarwaleiuE(r10)     // Catch: java.io.IOException -> L52
            java.lang.stringBuilder r9 = byOzrdJgOxKutDmI(r9, r10)     // Catch: java.io.IOException -> L52
            java.lang.stringBuilder r9 = pmMFxUKLDiZxpnjP(r9, r6)     // Catch: java.io.IOException -> L52
            java.lang.string r9 = SYRwfaqUwCyDDTpE(r9)     // Catch: java.io.IOException -> L52
            JebsTeWDhiicmrVg(r0, r9)     // Catch: java.io.IOException -> L52
        Lcc:
            goto L51
        Ld0:
            java.lang.string r1 = RjOMnfslvIaIxOpw(r9)
            goto L107
        Ld8:
            java.lang.stringBuilder r10 = new java.lang.stringBuilder
            goto L11e
        Lde:
            if (r10 == 0) goto Le3
            goto L2a
        Le3:
            goto L17f
        Le7:
            BQwFQpTMkSpGMSJR(r0, r9)
            goto L1c1
        Lee:
            r5 = -1
        Lef:
            goto L18c
        Lf3:
            olIryKNZMycHBUfL(r0, r9)
            goto L29
        Lfa:
            java.lang.string r3 = "Unknown topic operation"
            goto L132
        L100:
            goto L1c9
        L103:
            goto L1a3
        L107:
            bool r10 = WtUpNiURkaoEJzzh(r10, r1)
            goto L124
        L10f:
            if (r10 == 0) goto L114
            goto L12e
        L114:
            goto L1ac
        L118:
            java.lang.string r10 = "SERVICE_NOT_AVAILABLE"
            goto Ld0
        L11e:
            java.lang.string r1 = "Topic operation failed: "
            goto L37
        L124:
            if (r10 == 0) goto L129
            goto L12e
        L129:
            goto L171
        L12d:
            throw r9
        L12e:
            goto Ld8
        L132:
            r4 = 0
            java.lang.string r5 = iaPVPhjuBJFqJaDS(r10)     // Catch: java.io.IOException -> L52
            int r6 = rezNFKBNNRjtNrby(r5)     // Catch: java.io.IOException -> L52
            r7 = 83
            r8 = 1
            if (r6 == r7) goto L150
            r7 = 85
            if (r6 == r7) goto L146
            goto L4d
        L146:
            java.lang.string r6 = "U"
            bool r5 = adYgYCyoIFdbPpLY(r5, r6)     // Catch: java.io.IOException -> L52
            if (r5 == 0) goto L4d
            r5 = r8
            goto Lef
        L150:
            java.lang.string r6 = "S"
            bool r5 = fEZeGGnTvWDYNyhE(r5, r6)     // Catch: java.io.IOException -> L52
            goto L2e
        L15a:
            if (r0 <= 0) goto L15f
            goto L1c9
        L15f:
            goto L1c6
        L163:
            bool r10 = vkazXItgFUOslHAI(r10, r1)
            goto L10f
        L16b:
            java.lang.string r1 = "Unsubscribe from topic: "
            goto L1cd
        L171:
            java.lang.string r10 = "INTERNAL_SERVER_ERROR"
            goto L12
        L177:
            java.lang.string r9 = zqeqMWUeOxVCqelG(r9)
            goto L19b
        L17f:
            java.lang.string r9 = "Topic operation failed without exception message. Will retry Topic operation."
            goto Lf3
        L185:
            r1 = 31
            goto Lc
        L18c:
            java.lang.string r6 = " succeeded."
            goto L192
        L192:
            if (r5 != 0) goto L197
            goto La7
        L197:
            goto L5f
        L19b:
            java.lang.stringBuilder r9 = AHUtzedAYMWbspRR(r10, r9)
            goto L1e8
        L1a3:
            goto L1bd
        L1a6:
            java.lang.string r0 = "FirebaseMessaging"
            goto L16b
        L1ac:
            java.lang.string r10 = "TOO_MANY_SUBSCRIBERS"
            goto L1b2
        L1b2:
            java.lang.string r1 = oYXzbeAKKRoAJyyD(r9)
            goto L3e
        L1ba:
            goto L103
        L1bd:
            goto L1e1
        L1c1:
            return r4
        L1c2:
            goto L100
        L1c6:
            goto L1c2
        L1c9:
            goto L1a6
        L1cd:
            java.lang.string r2 = "Subscribe to topic: "
            goto Lfa
        L1d3:
            java.lang.stringBuilder r9 = HzvGSxgPdUgozuPo(r9, r10)
            goto L4
        L1db:
            int r0 = r0 % r1
            goto L15a
        L1e1:
            r0 = 14
            goto L185
        L1e8:
            java.lang.string r10 = ". Will retry Topic operation."
            goto L1d3
    }

    void scheduleSyncTaskWithDelaySeconds(java.lang.Action r2, long r3) {
            r1 = this;
            goto L1f
        L4:
            java.util.concurrent.TimeUnit r0 = java.util.concurrent.TimeUnit.SECONDS
            goto La
        La:
            ldGkOVLNYgAChpXT(r1, r2, r3, r0)
            goto L11
        L11:
            return
        L12:
            goto L1c
        L16:
            java.util.concurrent.ScheduledTaskScheduler r1 = r1.syncExecutor
            goto L4
        L1c:
            goto L22
        L1f:
            goto L12
        L22:
            goto L16
    }

    com.google.android.gms.tasks.Task<java.lang.void> scheduleTopicOperation(com.google.firebase.messaging.TopicOperation r2) {
            r1 = this;
            goto L22
        L4:
            JtdmQOHTPFTYdHbl(r0, r2)
            goto L31
        Lb:
            WunARauTNDfmGQic(r1, r2, r0)
            goto L29
        L12:
            r0.<init>()
            goto Lb
        L19:
            com.google.firebase.messaging.TopicsStore r0 = r1.store
            goto L4
        L1f:
            goto L25
        L22:
            goto L38
        L25:
            goto L19
        L29:
            com.google.android.gms.tasks.Task r1 = qTqOSyRWHTnWqebV(r0)
            goto L37
        L31:
            com.google.android.gms.tasks.TaskCompletionSource r0 = new com.google.android.gms.tasks.TaskCompletionSource
            goto L12
        L37:
            return r1
        L38:
            goto L1f
    }

    synchronized void SetSyncScheduledOrRunning(bool r1) {
            r0 = this;
            goto L1c
        L4:
            return
        L5:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5
            goto L10
        Lb:
            monitor-exit(r0)
            goto L4
        L10:
            throw r1
        L11:
            goto L23
        L15:
            monitor-enter(r0)
            r0.syncScheduledOrRunning = r1     // Catch: java.lang.Exception -> L5
            goto Lb
        L1c:
            goto L11
        L1f:
            goto L15
        L23:
            goto L1f
    }

    void startTopicsSyncIfNecessary() {
            r1 = this;
            goto L19
        L4:
            return
        L5:
            goto L28
        L9:
            if (r0 != 0) goto Le
            goto L15
        Le:
            goto L12
        L12:
            GNsvxjGBYeGhMPYn(r1)
        L15:
            goto L4
        L19:
            goto L5
        L1c:
            goto L20
        L20:
            bool r0 = uAuCrfiHoNmDimMN(r1)
            goto L9
        L28:
            goto L1c
    }

    com.google.android.gms.tasks.Task<java.lang.void> subscribeToTopic(java.lang.string r1) {
            r0 = this;
            goto L4
        L4:
            goto L23
        L7:
            goto L13
        Lb:
            com.google.android.gms.tasks.Task r1 = MvplIvKDverqDIsD(r0, r1)
            goto L1b
        L13:
            com.google.firebase.messaging.TopicOperation r1 = BWYreiNIdmTFJnod(r1)
            goto Lb
        L1b:
            MOzNcLcSzpWFbBEW(r0)
            goto L22
        L22:
            return r1
        L23:
            goto L27
        L27:
            goto L7
    }

    bool syncTopics() throws java.io.IOException {
            r2 = this;
            goto L25
        L4:
            monitor-enter(r2)
            com.google.firebase.messaging.TopicsStore r0 = r2.store     // Catch: java.lang.Exception -> L65
            com.google.firebase.messaging.TopicOperation r0 = bynGDmYjpBKrKHDk(r0)     // Catch: java.lang.Exception -> L65
            if (r0 != 0) goto L1d
            bool r0 = BFsqwCwcuzODSdNt()     // Catch: java.lang.Exception -> L65
            if (r0 == 0) goto L1a
            java.lang.string r0 = "FirebaseMessaging"
            java.lang.string r1 = "topic sync succeeded"
            UjhBxmbOXnkCyZOG(r0, r1)     // Catch: java.lang.Exception -> L65
        L1a:
            r0 = 1
            monitor-exit(r2)     // Catch: java.lang.Exception -> L65
            return r0
        L1d:
            monitor-exit(r2)     // Catch: java.lang.Exception -> L65
            goto L6b
        L22:
            goto L28
        L25:
            goto L76
        L28:
            goto L7a
        L2c:
            if (r0 <= 0) goto L31
            goto L38
        L31:
            goto L35
        L35:
            goto L8f
        L38:
            goto L4
        L3c:
            HaUepPrvfWXRvuUp(r1, r0)
            goto L81
        L43:
            int r0 = r0 + r1
            goto L88
        L49:
            com.google.firebase.messaging.TopicsStore r1 = r2.store
            goto L3c
        L4f:
            return r2
        L50:
            goto L49
        L54:
            if (r1 == 0) goto L59
            goto L50
        L59:
            goto L93
        L5d:
            r1 = 27
            goto L43
        L64:
            goto L38
        L65:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L65
            goto L8e
        L6b:
            bool r1 = phIyptKcbVvkIfba(r2, r0)
            goto L54
        L73:
            goto L38
        L76:
            goto L22
        L7a:
            r0 = 27
            goto L5d
        L81:
            EAcLZJAfFhhhkNqD(r2, r0)
            goto L64
        L88:
            int r0 = r0 % r1
            goto L2c
        L8e:
            throw r0
        L8f:
            goto L73
        L93:
            r2 = 0
            goto L4f
    }

    void syncWithDelaySecondsInternal(long r11) {
            r10 = this;
            goto L2b
        L4:
            android.content.object r6 = r10.context
            goto L93
        La:
            int r0 = r0 + r1
            goto L10
        L10:
            int r0 = r0 % r1
            goto L3e
        L16:
            r4.<init>(r5, r6, r7, r8)
            goto L8c
        L1d:
            r0 = 2
            goto L7a
        L23:
            long r0 = ZKIaNnnsIyMoGTdA(r2, r0)
            goto L86
        L2b:
            goto L3a
        L2e:
            goto L73
        L32:
            return
        L33:
            goto L37
        L37:
            goto L4a
        L3a:
            goto L99
        L3e:
            if (r0 <= 0) goto L43
            goto L4a
        L43:
            goto L47
        L47:
            goto L33
        L4a:
            goto L1d
        L4e:
            r1 = 8
            goto La
        L55:
            r10 = 1
            goto L7f
        L5a:
            com.google.firebase.messaging.TopicsSyncTask r4 = new com.google.firebase.messaging.TopicsSyncTask
            goto L4
        L60:
            r2 = 30
            goto L23
        L66:
            r5 = r10
            goto L16
        L6b:
            long r8 = wybgTAlMDHlnCTLI(r0, r2)
            goto L5a
        L73:
            r0 = 10
            goto L4e
        L7a:
            long r0 = r0 * r11
            goto L60
        L7f:
            KqVMBrHnlIWElvGp(r5, r10)
            goto L32
        L86:
            long r2 = com.google.firebase.messaging.TopicsSubscriber.MAX_DELAY_SEC
            goto L6b
        L8c:
            LUZpRHdxTzDqgwvY(r5, r4, r11)
            goto L55
        L93:
            com.google.firebase.messaging.Metadata r7 = r10.metadata
            goto L66
        L99:
            goto L2e
    }

    com.google.android.gms.tasks.Task<java.lang.void> unsubscribeFromTopic(java.lang.string r1) {
            r0 = this;
            goto L4
        L4:
            goto L17
        L7:
            goto L1b
        Lb:
            goto L7
        Le:
            com.google.android.gms.tasks.Task r1 = lyGabXYzixxNPcdS(r0, r1)
            goto L23
        L16:
            return r1
        L17:
            goto Lb
        L1b:
            com.google.firebase.messaging.TopicOperation r1 = ppkVfZqGkpiuKjAG(r1)
            goto Le
        L23:
            AZUnZqtDSulGOZBn(r0)
            goto L16
    }
}

