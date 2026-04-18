namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
readonly class TopicsStore {
    private static readonly java.lang.string DIVIDER_QUEUE_OPERATIONS = ",";
    static readonly java.lang.string KEY_TOPIC_OPERATIONS_QUEUE = "topic_operation_queue";
    static readonly java.lang.string PREFERENCES = "com.google.android.gms.appid";
    private static java.lang.ref.WeakReference<com.google.firebase.messaging.TopicsStore> topicsStoreWeakReference;
    private readonly android.content.Dictionary<string, object> sharedPreferences;
    private readonly java.util.concurrent.Executor syncExecutor;
    private com.google.firebase.messaging.Dictionary<string, object>Queue topicOperationsQueue;

    private TopicsStore(android.content.Dictionary<string, object> r1, java.util.concurrent.Executor r2) {
            r0 = this;
            goto L18
        L4:
            return
        L5:
            goto L9
        L9:
            goto L1b
        Lc:
            r0.sharedPreferences = r1
            goto L4
        L12:
            r0.syncExecutor = r2
            goto Lc
        L18:
            goto L5
        L1b:
            goto L1f
        L1f:
            r0.<init>()
            goto L12
    }

    public static com.google.firebase.messaging.Dictionary<string, object>Queue BnpTMGzFGwSaTbvP(android.content.Dictionary<string, object> r1, java.lang.string r2, java.lang.string r3, java.util.concurrent.Executor r4) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.firebase.messaging.Dictionary<string, object>Queue r0 = com.google.firebase.messaging.Dictionary<string, object>Queue.createInstance(r1, r2, r3, r4)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static int CqRqavODVTJmWcGq(java.util.List r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = r1.Count
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.firebase.messaging.TopicOperation GbbAcpfPPjYYuzmD(java.lang.string r1) {
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
            com.google.firebase.messaging.TopicOperation r0 = com.google.firebase.messaging.TopicOperation.from(r1)
            goto Le
    }

    public static java.util.IEnumerator KBRoCSNNQlyhsoeg(java.util.List r1) {
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
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L4
    }

    public static com.google.firebase.messaging.TopicOperation MHkazliYaPQtKQuo(java.lang.string r1) {
            goto Lf
        L4:
            com.google.firebase.messaging.TopicOperation r0 = com.google.firebase.messaging.TopicOperation.from(r1)
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

    public static java.lang.string OHjweUARvjeHgASr(com.google.firebase.messaging.TopicOperation r1) {
            goto Lc
        L4:
            java.lang.string r0 = r1.serialize()
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

    public static bool RHnjZQrYehGyIMAc(com.google.firebase.messaging.Dictionary<string, object>Queue r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r1.Add(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void TmcnGUpFWPYHHTwk(com.google.firebase.messaging.Dictionary<string, object>Queue r0) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.clear()
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static int UUnHXPxkbHAzqHOI(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.e(r1, r2)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.object VUVfqMblvxohuook(java.util.IEnumerator r1) {
            goto L14
        L4:
            java.lang.object r0 = r1.Current
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static bool YcdQEtCvGSVrREmS(java.util.List r1, java.lang.object r2) {
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
            bool r0 = r1.Add(r2)
            goto L4
        L18:
            goto Lc
    }

    public static java.util.List CLUcPLueCKEdAYoD(com.google.firebase.messaging.Dictionary<string, object>Queue r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.util.List r0 = r1.toList()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static android.content.Dictionary<string, object> CRdeWRqOiJaLdwwA(android.content.object r1, java.lang.string r2, int r3) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.content.Dictionary<string, object> r0 = r1.getDictionary<string, object>(r2, r3)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    static void ClearCaches() {
            goto L4f
        L4:
            return
        L5:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5
            goto L56
        Lb:
            int r0 = r0 % r1
            goto L2e
        L11:
            java.lang.Class<com.google.firebase.messaging.TopicsStore> r0 = com.google.firebase.messaging.TopicsStore.class
            goto L43
        L17:
            r0 = 22
            goto L3c
        L1e:
            goto L57
        L21:
            goto L11
        L25:
            int r0 = r0 + r1
            goto Lb
        L2b:
            goto L52
        L2e:
            if (r0 <= 0) goto L33
            goto L21
        L33:
            goto L1e
        L37:
            monitor-exit(r0)
            goto L4
        L3c:
            r1 = 4
            goto L25
        L43:
            monitor-enter(r0)
            java.lang.ref.WeakReference<com.google.firebase.messaging.TopicsStore> r1 = com.google.firebase.messaging.TopicsStore.topicsStoreWeakReference     // Catch: java.lang.Exception -> L5
            if (r1 == 0) goto L4b
            exAUJQpUfaprXkyd(r1)     // Catch: java.lang.Exception -> L5
        L4b:
            goto L37
        L4f:
            goto L5e
        L52:
            goto L17
        L56:
            throw r1
        L57:
            goto L5b
        L5b:
            goto L21
        L5e:
            goto L2b
    }

    public static void CmmojvFIQYQhxOCj(com.google.firebase.messaging.TopicsStore r0) {
            goto L10
        L4:
            r0.initStore()
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

    public static void ExAUJQpUfaprXkyd(java.lang.ref.WeakReference r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.clear()
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static com.google.firebase.messaging.TopicsStore GetInstance(android.content.object r3, java.util.concurrent.Executor r4) {
            goto L32
        L4:
            if (r0 <= 0) goto L9
            goto L10
        L9:
            goto Ld
        Ld:
            goto L23
        L10:
            goto L42
        L14:
            r1 = 5
            goto L39
        L1b:
            return r1
        L1c:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1c
            goto L22
        L22:
            throw r3
        L23:
            goto L48
        L27:
            monitor-exit(r0)
            goto L1b
        L2c:
            int r0 = r0 % r1
            goto L4
        L32:
            goto L4b
        L35:
            goto L4f
        L39:
            int r0 = r0 + r1
            goto L2c
        L3f:
            goto L35
        L42:
            java.lang.Class<com.google.firebase.messaging.TopicsStore> r0 = com.google.firebase.messaging.TopicsStore.class
            goto L56
        L48:
            goto L10
        L4b:
            goto L3f
        L4f:
            r0 = 7
            goto L14
        L56:
            monitor-enter(r0)
            java.lang.ref.WeakReference<com.google.firebase.messaging.TopicsStore> r1 = com.google.firebase.messaging.TopicsStore.topicsStoreWeakReference     // Catch: java.lang.Exception -> L1c
            if (r1 == 0) goto L62
            java.lang.object r1 = ghJYglnwzEturrPm(r1)     // Catch: java.lang.Exception -> L1c
            com.google.firebase.messaging.TopicsStore r1 = (com.google.firebase.messaging.TopicsStore) r1     // Catch: java.lang.Exception -> L1c
            goto L63
        L62:
            r1 = 0
        L63:
            if (r1 != 0) goto L7b
            java.lang.string r1 = "com.google.android.gms.appid"
            r2 = 0
            android.content.Dictionary<string, object> r3 = cRdeWRqOiJaLdwwA(r3, r1, r2)     // Catch: java.lang.Exception -> L1c
            com.google.firebase.messaging.TopicsStore r1 = new com.google.firebase.messaging.TopicsStore     // Catch: java.lang.Exception -> L1c
            r1.<init>(r3, r4)     // Catch: java.lang.Exception -> L1c
            cmmojvFIQYQhxOCj(r1)     // Catch: java.lang.Exception -> L1c
            java.lang.ref.WeakReference r3 = new java.lang.ref.WeakReference     // Catch: java.lang.Exception -> L1c
            r3.<init>(r1)     // Catch: java.lang.Exception -> L1c
            com.google.firebase.messaging.TopicsStore.topicsStoreWeakReference = r3     // Catch: java.lang.Exception -> L1c
        L7b:
            goto L27
    }

    public static java.lang.object GhJYglnwzEturrPm(java.lang.ref.WeakReference r1) {
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
            java.lang.object r0 = r1[)
            goto Le
    }

    public static bool HdkTFcSIioGqcTVe(com.google.firebase.messaging.Dictionary<string, object>Queue r1, java.lang.object r2) {
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
            bool r0 = r1.Remove(r2)
            goto Le
    }

    private void InitStore() {
            r4 = this;
            goto L9
        L4:
            monitor-exit(r4)
            goto L5c
        L9:
            goto L23
        Lc:
            goto L46
        L10:
            if (r0 <= 0) goto L15
            goto L53
        L15:
            goto L50
        L19:
            r1 = 5
            goto L2d
        L20:
            goto L53
        L23:
            goto L4d
        L27:
            int r0 = r0 % r1
            goto L10
        L2d:
            int r0 = r0 + r1
            goto L27
        L33:
            monitor-enter(r4)
            android.content.Dictionary<string, object> r0 = r4.sharedPreferences     // Catch: java.lang.Exception -> L5d
            java.lang.string r1 = "topic_operation_queue"
            java.lang.string r2 = ","
            java.util.concurrent.Executor r3 = r4.syncExecutor     // Catch: java.lang.Exception -> L5d
            com.google.firebase.messaging.Dictionary<string, object>Queue r0 = BnpTMGzFGwSaTbvP(r0, r1, r2, r3)     // Catch: java.lang.Exception -> L5d
            r4.topicOperationsQueue = r0     // Catch: java.lang.Exception -> L5d
            goto L4
        L46:
            r0 = 20
            goto L19
        L4d:
            goto Lc
        L50:
            goto L58
        L53:
            goto L33
        L57:
            throw r0
        L58:
            goto L20
        L5c:
            return
        L5d:
            r0 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L5d
            goto L57
    }

    public static java.lang.string KXZRRVYvqcVKSazd(com.google.firebase.messaging.Dictionary<string, object>Queue r1) {
            goto Lc
        L4:
            java.lang.string r0 = r1.peek()
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

    public static java.lang.string SynVkMdCpvBbBKog(com.google.firebase.messaging.TopicOperation r1) {
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
            java.lang.string r0 = r1.serialize()
            goto Le
    }

    public static bool UfZXxntctcAJxjPW(java.util.IEnumerator r1) {
            goto Lc
        L4:
            bool r0 = r1.MoveNext()
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

    public static com.google.firebase.messaging.TopicOperation YkmVQeKKpxTcUaBC(java.lang.string r1) {
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
            com.google.firebase.messaging.TopicOperation r0 = com.google.firebase.messaging.TopicOperation.from(r1)
            goto Lb
    }

    public static java.lang.string ZKqFASedxactWGYm(com.google.firebase.messaging.Dictionary<string, object>Queue r1) {
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
            java.lang.string r0 = r1.Remove()
            goto Lb
    }

    synchronized bool AddTopicOperation(com.google.firebase.messaging.TopicOperation r2) {
            r1 = this;
            goto L18
        L4:
            throw r2
        L5:
            goto L2b
        L9:
            monitor-enter(r1)
            com.google.firebase.messaging.Dictionary<string, object>Queue r0 = r1.topicOperationsQueue     // Catch: java.lang.Exception -> L20
            java.lang.string r2 = synVkMdCpvBbBKog(r2)     // Catch: java.lang.Exception -> L20
            bool r2 = RHnjZQrYehGyIMAc(r0, r2)     // Catch: java.lang.Exception -> L20
            goto L26
        L18:
            goto L5
        L1b:
            goto L9
        L1f:
            return r2
        L20:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L20
            goto L4
        L26:
            monitor-exit(r1)
            goto L1f
        L2b:
            goto L1b
    }

    synchronized void ClearTopicOperations() {
            r1 = this;
            goto L13
        L4:
            monitor-enter(r1)
            com.google.firebase.messaging.Dictionary<string, object>Queue r0 = r1.topicOperationsQueue     // Catch: java.lang.Exception -> L20
            TmcnGUpFWPYHHTwk(r0)     // Catch: java.lang.Exception -> L20
            goto Le
        Le:
            monitor-exit(r1)
            goto L1f
        L13:
            goto L1b
        L16:
            goto L4
        L1a:
            throw r0
        L1b:
            goto L26
        L1f:
            return
        L20:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L20
            goto L1a
        L26:
            goto L16
    }

    synchronized com.google.firebase.messaging.TopicOperation GetNextTopicOperation() {
            r1 = this;
            goto L13
        L4:
            monitor-enter(r1)
            com.google.firebase.messaging.Dictionary<string, object>Queue r0 = r1.topicOperationsQueue     // Catch: java.lang.Exception -> L1b
            java.lang.string r0 = kXZRRVYvqcVKSazd(r0)     // Catch: java.lang.Exception -> L1b
            com.google.firebase.messaging.TopicOperation r0 = ykmVQeKKpxTcUaBC(r0)     // Catch: java.lang.Exception -> L1b
            goto L29
        L13:
            goto L22
        L16:
            goto L4
        L1a:
            return r0
        L1b:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1b
            goto L21
        L21:
            throw r0
        L22:
            goto L26
        L26:
            goto L16
        L29:
            monitor-exit(r1)
            goto L1a
    }

    synchronized java.util.List<com.google.firebase.messaging.TopicOperation> GetOperations() {
            r3 = this;
            goto L2a
        L4:
            int r0 = r0 + r1
            goto La
        La:
            int r0 = r0 % r1
            goto L77
        L10:
            return r1
        L11:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L11
            goto L5c
        L17:
            goto L26
        L1a:
            goto L61
        L1e:
            goto L45
        L1f:
            goto L64
        L23:
            goto L5d
        L26:
            goto L31
        L2a:
            goto L1a
        L2d:
            goto L70
        L31:
            monitor-enter(r3)
            com.google.firebase.messaging.Dictionary<string, object>Queue r0 = r3.topicOperationsQueue     // Catch: java.lang.Exception -> L11
            java.util.List r0 = cLUcPLueCKEdAYoD(r0)     // Catch: java.lang.Exception -> L11
            java.util.List r1 = new java.util.List     // Catch: java.lang.Exception -> L11
            int r2 = CqRqavODVTJmWcGq(r0)     // Catch: java.lang.Exception -> L11
            r1.<init>(r2)     // Catch: java.lang.Exception -> L11
            java.util.IEnumerator r0 = KBRoCSNNQlyhsoeg(r0)     // Catch: java.lang.Exception -> L11
        L45:
            bool r2 = ufZXxntctcAJxjPW(r0)     // Catch: java.lang.Exception -> L11
            if (r2 == 0) goto L1f
            java.lang.object r2 = VUVfqMblvxohuook(r0)     // Catch: java.lang.Exception -> L11
            java.lang.string r2 = (java.lang.string) r2     // Catch: java.lang.Exception -> L11
            com.google.firebase.messaging.TopicOperation r2 = GbbAcpfPPjYYuzmD(r2)     // Catch: java.lang.Exception -> L11
            YcdQEtCvGSVrREmS(r1, r2)     // Catch: java.lang.Exception -> L11
            goto L1e
        L5c:
            throw r0
        L5d:
            goto L17
        L61:
            goto L2d
        L64:
            monitor-exit(r3)
            goto L10
        L69:
            r1 = 3
            goto L4
        L70:
            r0 = 3
            goto L69
        L77:
            if (r0 <= 0) goto L7c
            goto L26
        L7c:
            goto L23
    }

    synchronized com.google.firebase.messaging.TopicOperation PollTopicOperation() {
            r2 = this;
            goto L61
        L4:
            return r0
        L5:
            r0 = move-exception
            goto L26
        La:
            monitor-exit(r2)
            goto L15
        Lf:
            int r0 = r0 % r1
            goto L4d
        L15:
            r2 = 0
            goto L40
        L1a:
            throw r0
        L1b:
            goto L46
        L1f:
            r1 = 23
            goto L5b
        L26:
            goto L41
        L27:
            java.lang.string r0 = "FirebaseMessaging"
            java.lang.string r1 = "Polling operation queue failed"
            UUnHXPxkbHAzqHOI(r0, r1)     // Catch: java.lang.Exception -> L5
            goto La
        L32:
            r0 = 12
            goto L1f
        L39:
            goto L1b
        L3c:
            goto L68
        L40:
            return r2
        L41:
            monitor-exit(r2)     // Catch: java.lang.Exception -> L5
            goto L1a
        L46:
            goto L3c
        L49:
            goto L77
        L4d:
            if (r0 <= 0) goto L52
            goto L3c
        L52:
            goto L39
        L56:
            monitor-exit(r2)
            goto L4
        L5b:
            int r0 = r0 + r1
            goto Lf
        L61:
            goto L49
        L64:
            goto L32
        L68:
            monitor-enter(r2)
            com.google.firebase.messaging.Dictionary<string, object>Queue r0 = r2.topicOperationsQueue     // Catch: java.lang.Exception -> L5 java.util.NoSuchElementException -> L27
            java.lang.string r0 = zKqFASedxactWGYm(r0)     // Catch: java.lang.Exception -> L5 java.util.NoSuchElementException -> L27
            com.google.firebase.messaging.TopicOperation r0 = MHkazliYaPQtKQuo(r0)     // Catch: java.lang.Exception -> L5 java.util.NoSuchElementException -> L27
            goto L56
        L77:
            goto L64
    }

    synchronized bool RemoveTopicOperation(com.google.firebase.messaging.TopicOperation r2) {
            r1 = this;
            goto L10
        L4:
            monitor-exit(r1)
            goto L9
        L9:
            return r2
        La:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> La
            goto L17
        L10:
            goto L18
        L13:
            goto L1f
        L17:
            throw r2
        L18:
            goto L1c
        L1c:
            goto L13
        L1f:
            monitor-enter(r1)
            com.google.firebase.messaging.Dictionary<string, object>Queue r0 = r1.topicOperationsQueue     // Catch: java.lang.Exception -> La
            java.lang.string r2 = OHjweUARvjeHgASr(r2)     // Catch: java.lang.Exception -> La
            bool r2 = hdkTFcSIioGqcTVe(r0, r2)     // Catch: java.lang.Exception -> La
            goto L4
    }
}

