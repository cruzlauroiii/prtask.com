namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public class ConfigCacheClient {
    private static readonly java.util.concurrent.Executor DIRECT_EXECUTOR = null;
    static readonly long DISK_READ_TIMEOUT_IN_SECONDS = 5;
    private static readonly java.util.Dictionary<java.lang.string, com.google.firebase.remoteconfig.internal.ConfigCacheClient> clientInstances = null;
    private com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigContainer> cachedContainerTask;
    private readonly java.util.concurrent.Executor executor;
    private readonly com.google.firebase.remoteconfig.internal.ConfigStorageClient storageClient;

    /* JADX INFO: renamed from: com.google.firebase.remoteconfig.internal.ConfigCacheClient$1 */
    static /* synthetic */ class C20671 {
    }

    private static class AwaitListener<TResult> : com.google.android.gms.tasks.OnSuccessListener<TResult>, com.google.android.gms.tasks.OnFailureListener, com.google.android.gms.tasks.OnCanceledListener {
        private readonly java.util.concurrent.CountdownEvent latch;

        private AwaitListener() {
                r2 = this;
                goto L42
            L4:
                r0 = 13
                goto L17
            Lb:
                return
            Lc:
                goto L27
            L10:
                r0.<init>(r1)
                goto L54
            L17:
                r1 = 8
                goto L2e
            L1e:
                if (r0 <= 0) goto L23
                goto L37
            L23:
                goto L34
            L27:
                goto L37
            L2a:
                goto L5a
            L2e:
                int r0 = r0 + r1
                goto L49
            L34:
                goto Lc
            L37:
                goto L3b
            L3b:
                r2.<init>()
                goto L5d
            L42:
                goto L2a
            L45:
                goto L4
            L49:
                int r0 = r0 % r1
                goto L1e
            L4f:
                r1 = 1
                goto L10
            L54:
                r2.latch = r0
                goto Lb
            L5a:
                goto L45
            L5d:
                java.util.concurrent.CountdownEvent r0 = new java.util.concurrent.CountdownEvent
                goto L4f
        }

        /* synthetic */ AwaitListener(com.google.firebase.remoteconfig.internal.ConfigCacheClient.C20671 r1) {
                r0 = this;
                goto L13
            L4:
                goto L16
            L7:
                r0.<init>()
                goto Le
            Le:
                return
            Lf:
                goto L4
            L13:
                goto Lf
            L16:
                goto L7
        }

        public static bool AxPdrRbuvxZHalAf(java.util.concurrent.CountdownEvent r1, long r2, java.util.concurrent.TimeUnit r4) {
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
                bool r0 = r1.await(r2, r4)
                goto L4
        }

        public static void EKextCgQbyDbrgqf(java.util.concurrent.CountdownEvent r0) {
                goto L13
            L4:
                goto L16
            L7:
                return
            L8:
                goto L4
            Lc:
                r0.await()
                goto L7
            L13:
                goto L8
            L16:
                goto Lc
        }

        public static void MXtpaFeOnxiVwSsg(java.util.concurrent.CountdownEvent r0) {
                goto L4
            L4:
                goto L13
            L7:
                goto Lb
            Lb:
                r0.countDown()
                goto L12
            L12:
                return
            L13:
                goto L17
            L17:
                goto L7
        }

        public static void WOSPPFjWQCOLDwqa(java.util.concurrent.CountdownEvent r0) {
                goto L13
            L4:
                return
            L5:
                goto L9
            L9:
                goto L16
            Lc:
                r0.countDown()
                goto L4
            L13:
                goto L5
            L16:
                goto Lc
        }

        public static void CFqZKBkitxRTCUvr(java.util.concurrent.CountdownEvent r0) {
                goto L7
            L4:
                goto La
            L7:
                goto Lf
            La:
                goto L13
            Le:
                return
            Lf:
                goto L4
            L13:
                r0.countDown()
                goto Le
        }

        public void Await() throws java.lang.InterruptedException {
                r0 = this;
                goto L19
            L4:
                goto L1c
            L7:
                EKextCgQbyDbrgqf(r0)
                goto L14
            Le:
                java.util.concurrent.CountdownEvent r0 = r0.latch
                goto L7
            L14:
                return
            L15:
                goto L4
            L19:
                goto L15
            L1c:
                goto Le
        }

        public bool Await(long r1, java.util.concurrent.TimeUnit r3) throws java.lang.InterruptedException {
                r0 = this;
                goto L12
            L4:
                bool r0 = AxPdrRbuvxZHalAf(r0, r1, r3)
                goto L1c
            Lc:
                java.util.concurrent.CountdownEvent r0 = r0.latch
                goto L4
            L12:
                goto L1d
            L15:
                goto Lc
            L19:
                goto L15
            L1c:
                return r0
            L1d:
                goto L19
        }

        @Override // com.google.android.gms.tasks.OnCanceledListener
        public void OnCanceled() {
                r0 = this;
                goto L19
            L4:
                return
            L5:
                goto L10
            L9:
                cFqZKBkitxRTCUvr(r0)
                goto L4
            L10:
                goto L1c
            L13:
                java.util.concurrent.CountdownEvent r0 = r0.latch
                goto L9
            L19:
                goto L5
            L1c:
                goto L13
        }

        @Override // com.google.android.gms.tasks.OnFailureListener
        public void OnFailure(java.lang.Exception r1) {
                r0 = this;
                goto La
            L4:
                java.util.concurrent.CountdownEvent r0 = r0.latch
                goto L14
            La:
                goto L1c
            Ld:
                goto L4
            L11:
                goto Ld
            L14:
                WOSPPFjWQCOLDwqa(r0)
                goto L1b
            L1b:
                return
            L1c:
                goto L11
        }

        @Override // com.google.android.gms.tasks.OnSuccessListener
        public void OnSuccess(TResult r1) {
                r0 = this;
                goto L4
            L4:
                goto L13
            L7:
                goto L1a
            Lb:
                MXtpaFeOnxiVwSsg(r0)
                goto L12
            L12:
                return
            L13:
                goto L17
            L17:
                goto L7
            L1a:
                java.util.concurrent.CountdownEvent r0 = r0.latch
                goto Lb
        }
    }

    static {
            goto L27
        L4:
            com.google.firebase.remoteconfig.internal.ConfigCacheClient.clientInstances = r0
            goto L2e
        La:
            goto L2a
        Ld:
            com.google.firebase.remoteconfig.internal.ConfigCacheClient.DIRECT_EXECUTOR = r0
            goto L34
        L13:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto L20
        L19:
            r0.<init>()
            goto Ld
        L20:
            r0.<init>()
            goto L4
        L27:
            goto L35
        L2a:
            goto L13
        L2e:
            androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0 r0 = new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0
            goto L19
        L34:
            return
        L35:
            goto La
    }

    private ConfigCacheClient(java.util.concurrent.Executor r1, com.google.firebase.remoteconfig.internal.ConfigStorageClient r2) {
            r0 = this;
            goto L24
        L4:
            r0.<init>()
            goto Lb
        Lb:
            r0.executor = r1
            goto L1e
        L11:
            r1 = 0
            goto L2b
        L16:
            goto L27
        L19:
            return
        L1a:
            goto L16
        L1e:
            r0.storageClient = r2
            goto L11
        L24:
            goto L1a
        L27:
            goto L4
        L2b:
            r0.cachedContainerTask = r1
            goto L19
    }

    public static com.google.android.gms.tasks.Task ABYDibLxVDdvMSac(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnSuccessListener r3) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.android.gms.tasks.Task r0 = r1.addOnSuccessListener(r2, r3)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.void BBQrkOhqtYXOViiM(com.google.firebase.remoteconfig.internal.ConfigStorageClient r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.void r0 = r1.clear()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.object BzNITJeONKbSMJFX(com.google.android.gms.tasks.Task r1, long r2, java.util.concurrent.TimeUnit r4) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = await(r1, r2, r4)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool HmYxnsGuTgXGqwwj(com.google.firebase.remoteconfig.internal.ConfigCacheClient.AwaitListener r1, long r2, java.util.concurrent.TimeUnit r4) {
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
            bool r0 = r1.await(r2, r4)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.object HvCkwHoEuBTPbqVa(java.lang.object r1) {
            goto L14
        L4:
            java.lang.object r0 = java.util.objects.requireNonNull(r1)
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

    public static com.google.android.gms.tasks.Task JFyLpujzaiRTZkCP(java.lang.object r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forResult(r1)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool JamIUpkSrkCoBuUR(com.google.android.gms.tasks.Task r1) {
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
            bool r0 = r1.isSuccessful()
            goto Le
    }

    public static java.lang.object MjmurpsZSdjGCZYp(java.util.Dictionary r1, java.lang.object r2) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.object r0 = r1[r2)
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

    public static int MsroWmphyIzcyByE(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = android.util.Console.d(r1, r2, r3)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static com.google.android.gms.tasks.Task NQfPKgWrLzWDLQhx(java.util.concurrent.Executor r1, java.util.concurrent.Func r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.call(r1, r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.object OdZFfQScOwOVApFC(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto Le
    }

    public static com.google.android.gms.tasks.Task VygPxgaQynsrRmdG(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.SuccessContinuation r3) {
            goto L14
        L4:
            com.google.android.gms.tasks.Task r0 = r1.onSuccessTask(r2, r3)
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

    public static bool WEQBRQdMriThMoPK(com.google.android.gms.tasks.Task r1) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.isComplete()
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

    private static <TResult> TResult Await(com.google.android.gms.tasks.Task<TResult> r2, long r3, java.util.concurrent.TimeUnit r5) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException, java.util.concurrent.TimeoutException {
            goto Lbd
        L4:
            r1 = 0
            goto L88
        L9:
            goto Lad
        Lc:
            goto L30
        L10:
            java.lang.Exception r2 = swSuqfSXsBhvUOtQ(r2)
            goto L4d
        L18:
            throw r3
        L19:
            goto L47
        L1d:
            java.lang.string r3 = "Task await timed out."
            goto L8f
        L23:
            int r0 = r0 % r1
            goto L5c
        L29:
            zaYdnakcThIoZPMt(r2, r1, r0)
            goto L9b
        L30:
            goto Lc0
        L33:
            r1 = 10
            goto L41
        L3a:
            r0 = 13
            goto L33
        L41:
            int r0 = r0 + r1
            goto L23
        L47:
            java.util.concurrent.TimeoutException r2 = new java.util.concurrent.TimeoutException
            goto L1d
        L4d:
            r3.<init>(r2)
            goto L18
        L54:
            bool r3 = HmYxnsGuTgXGqwwj(r0, r3, r5)
            goto Lc4
        L5c:
            if (r0 <= 0) goto L61
            goto Lad
        L61:
            goto Laa
        L65:
            bool r3 = xZguZMQwfEaQKIvV(r2)
            goto L79
        L6d:
            java.util.concurrent.ExecutionException r3 = new java.util.concurrent.ExecutionException
            goto L10
        L73:
            com.google.firebase.remoteconfig.internal.ConfigCacheClient$AwaitListener r0 = new com.google.firebase.remoteconfig.internal.ConfigCacheClient$AwaitListener
            goto L4
        L79:
            if (r3 != 0) goto L7e
            goto L97
        L7e:
            goto La2
        L82:
            java.util.concurrent.Executor r1 = com.google.firebase.remoteconfig.internal.ConfigCacheClient.DIRECT_EXECUTOR
            goto Lb6
        L88:
            r0.<init>(r1)
            goto L82
        L8f:
            r2.<init>(r3)
            goto Lb1
        L96:
            return r2
        L97:
            goto L6d
        L9b:
            yyEUesUvYoBCqKJV(r2, r1, r0)
            goto L54
        La2:
            java.lang.object r2 = fqDYoadAOMDeAiJR(r2)
            goto L96
        Laa:
            goto Lb2
        Lad:
            goto L73
        Lb1:
            throw r2
        Lb2:
            goto L9
        Lb6:
            ABYDibLxVDdvMSac(r2, r1, r0)
            goto L29
        Lbd:
            goto Lc
        Lc0:
            goto L3a
        Lc4:
            if (r3 != 0) goto Lc9
            goto L19
        Lc9:
            goto L65
    }

    public static bool CWZwOuKdbuyWtwSf(com.google.android.gms.tasks.Task r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.isSuccessful()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void ClearInstancesForTest() {
            goto L37
        L4:
            throw r1
        L5:
            goto L2a
        L9:
            monitor-enter(r0)
            java.util.Dictionary<java.lang.string, com.google.firebase.remoteconfig.internal.ConfigCacheClient> r1 = com.google.firebase.remoteconfig.internal.ConfigCacheClient.clientInstances     // Catch: java.lang.Exception -> L5a
            ljGWuVvRAvcPmDbm(r1)     // Catch: java.lang.Exception -> L5a
            goto L47
        L13:
            if (r0 <= 0) goto L18
            goto L55
        L18:
            goto L52
        L1c:
            r1 = 9
            goto L4c
        L23:
            r0 = 10
            goto L1c
        L2a:
            goto L55
        L2d:
            goto L44
        L31:
            int r0 = r0 % r1
            goto L13
        L37:
            goto L2d
        L3a:
            goto L23
        L3e:
            java.lang.Class<com.google.firebase.remoteconfig.internal.ConfigCacheClient> r0 = com.google.firebase.remoteconfig.internal.ConfigCacheClient.class
            goto L9
        L44:
            goto L3a
        L47:
            monitor-exit(r0)
            goto L59
        L4c:
            int r0 = r0 + r1
            goto L31
        L52:
            goto L5
        L55:
            goto L3e
        L59:
            return
        L5a:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5a
            goto L4
    }

    public static com.google.android.gms.tasks.Task DOCCAOanpGnYrUMI(com.google.firebase.remoteconfig.internal.ConfigCacheClient r1, com.google.firebase.remoteconfig.internal.ConfigContainer r2, bool r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.gms.tasks.Task r0 = r1.Add(r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static com.google.android.gms.tasks.Task EQtukAufXCaPXrvU(com.google.firebase.remoteconfig.internal.ConfigCacheClient r1) {
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
            com.google.android.gms.tasks.Task r0 = r1[)
            goto Le
    }

    public static java.lang.object FqDYoadAOMDeAiJR(com.google.android.gms.tasks.Task r1) {
            goto L14
        L4:
            java.lang.object r0 = r1.getResult()
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

    public static com.google.firebase.remoteconfig.internal.ConfigCacheClient GetInstance(java.util.concurrent.Executor r4, com.google.firebase.remoteconfig.internal.ConfigStorageClient r5) {
            goto L3d
        L4:
            return r4
        L5:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5
            goto L12
        Lb:
            goto L13
        Le:
            goto L64
        L12:
            throw r4
        L13:
            goto L17
        L17:
            goto Le
        L1a:
            goto L44
        L1e:
            monitor-enter(r0)
            java.lang.string r1 = mIdVeJfIMDJoMRJY(r5)     // Catch: java.lang.Exception -> L5
            java.util.Dictionary<java.lang.string, com.google.firebase.remoteconfig.internal.ConfigCacheClient> r2 = com.google.firebase.remoteconfig.internal.ConfigCacheClient.clientInstances     // Catch: java.lang.Exception -> L5
            bool r3 = sJTcuFNTSgTcOeqc(r2, r1)     // Catch: java.lang.Exception -> L5
            if (r3 != 0) goto L33
            com.google.firebase.remoteconfig.internal.ConfigCacheClient r3 = new com.google.firebase.remoteconfig.internal.ConfigCacheClient     // Catch: java.lang.Exception -> L5
            r3.<init>(r4, r5)     // Catch: java.lang.Exception -> L5
            OdZFfQScOwOVApFC(r2, r1, r3)     // Catch: java.lang.Exception -> L5
        L33:
            java.lang.object r4 = MjmurpsZSdjGCZYp(r2, r1)     // Catch: java.lang.Exception -> L5
            com.google.firebase.remoteconfig.internal.ConfigCacheClient r4 = (com.google.firebase.remoteconfig.internal.ConfigCacheClient) r4     // Catch: java.lang.Exception -> L5
            goto L6a
        L3d:
            goto L1a
        L40:
            goto L47
        L44:
            goto L40
        L47:
            r0 = 21
            goto L54
        L4e:
            int r0 = r0 % r1
            goto L5b
        L54:
            r1 = 1
            goto L6f
        L5b:
            if (r0 <= 0) goto L60
            goto Le
        L60:
            goto Lb
        L64:
            java.lang.Class<com.google.firebase.remoteconfig.internal.ConfigCacheClient> r0 = com.google.firebase.remoteconfig.internal.ConfigCacheClient.class
            goto L1e
        L6a:
            monitor-exit(r0)
            goto L4
        L6f:
            int r0 = r0 + r1
            goto L4e
    }

    public static java.lang.object HOlxnyuRDqfVIHhV(com.google.android.gms.tasks.Task r1) {
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
            java.lang.object r0 = r1.getResult()
            goto Lb
        L18:
            goto L7
    }

    public static com.google.android.gms.tasks.Task HSuCxhTjNaZoShGG(java.lang.object r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forResult(r1)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void LjGWuVvRAvcPmDbm(java.util.Dictionary r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            r0.clear()
            goto Lb
        L17:
            goto L7
    }

    public static java.lang.string MIdVeJfIMDJoMRJY(com.google.firebase.remoteconfig.internal.ConfigStorageClient r1) {
            goto L11
        L4:
            java.lang.string r0 = r1.getstringName()
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

    public static java.lang.void PvwQeoNlKyBOGKCI(com.google.firebase.remoteconfig.internal.ConfigStorageClient r1, com.google.firebase.remoteconfig.internal.ConfigContainer r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.void r0 = r1.write(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static com.google.android.gms.tasks.Task SFYSxQPDXUpGECnN(java.lang.object r1) {
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
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forResult(r1)
            goto L4
    }

    public static bool SJTcuFNTSgTcOeqc(java.util.Dictionary r1, java.lang.object r2) {
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

    public static java.lang.Exception SwSuqfSXsBhvUOtQ(com.google.android.gms.tasks.Task r1) {
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
            java.lang.Exception r0 = r1.getException()
            goto Lb
        L18:
            goto L7
    }

    public static void UltfrzGATIHpIoSP(com.google.firebase.remoteconfig.internal.ConfigCacheClient r0, com.google.firebase.remoteconfig.internal.ConfigContainer r1) {
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
            r0.updateInMemoryConfigContainer(r1)
            goto Lb
    }

    private void UpdateInMemoryConfigContainer(com.google.firebase.remoteconfig.internal.ConfigContainer r1) {
            r0 = this;
            goto L17
        L4:
            monitor-exit(r0)
            goto L1e
        L9:
            monitor-enter(r0)
            com.google.android.gms.tasks.Task r1 = JFyLpujzaiRTZkCP(r1)     // Catch: java.lang.Exception -> L1f
            r0.cachedContainerTask = r1     // Catch: java.lang.Exception -> L1f
            goto L4
        L14:
            goto L1a
        L17:
            goto L26
        L1a:
            goto L9
        L1e:
            return
        L1f:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1f
            goto L25
        L25:
            throw r1
        L26:
            goto L14
    }

    public static com.google.android.gms.tasks.Task VpxUyyHoTThqjsjc(java.util.concurrent.Executor r1, java.util.concurrent.Func r2) {
            goto Lc
        L4:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.call(r1, r2)
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

    public static com.google.firebase.remoteconfig.internal.ConfigContainer XSAOmCWFTnhxpKFW(com.google.firebase.remoteconfig.internal.ConfigCacheClient r1, long r2) {
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
            com.google.firebase.remoteconfig.internal.ConfigContainer r0 = r1.getBlocking(r2)
            goto Lb
    }

    public static bool XZguZMQwfEaQKIvV(com.google.android.gms.tasks.Task r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.isSuccessful()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static com.google.android.gms.tasks.Task YyEUesUvYoBCqKJV(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnCanceledListener r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.android.gms.tasks.Task r0 = r1.addOnCanceledListener(r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static com.google.android.gms.tasks.Task ZaYdnakcThIoZPMt(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnFailureListener r3) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.android.gms.tasks.Task r0 = r1.addOnFailureListener(r2, r3)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public void Clear() {
            r1 = this;
            goto L31
        L4:
            goto L34
        L7:
            return
        L8:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L8
            goto L20
        Le:
            BBQrkOhqtYXOViiM(r1)
            goto L7
        L15:
            monitor-enter(r1)
            goto L25
        L1a:
            com.google.firebase.remoteconfig.internal.ConfigStorageClient r1 = r1.storageClient
            goto Le
        L20:
            throw r0
        L21:
            goto L4
        L25:
            r0 = 0
            com.google.android.gms.tasks.Task r0 = sFYSxQPDXUpGECnN(r0)     // Catch: java.lang.Exception -> L8
            r1.cachedContainerTask = r0     // Catch: java.lang.Exception -> L8
            monitor-exit(r1)     // Catch: java.lang.Exception -> L8
            goto L1a
        L31:
            goto L21
        L34:
            goto L15
    }

    public com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigContainer> Get() {
            r3 = this;
            goto L58
        L4:
            goto L48
        L7:
            goto L6c
        Lb:
            monitor-enter(r3)
            com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigContainer> r0 = r3.cachedContainerTask     // Catch: java.lang.Exception -> L60
            if (r0 == 0) goto L1e
            bool r0 = WEQBRQdMriThMoPK(r0)     // Catch: java.lang.Exception -> L60
            if (r0 == 0) goto L30
            com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigContainer> r0 = r3.cachedContainerTask     // Catch: java.lang.Exception -> L60
            bool r0 = JamIUpkSrkCoBuUR(r0)     // Catch: java.lang.Exception -> L60
            if (r0 != 0) goto L30
        L1e:
            java.util.concurrent.Executor r0 = r3.executor     // Catch: java.lang.Exception -> L60
            com.google.firebase.remoteconfig.internal.ConfigStorageClient r1 = r3.storageClient     // Catch: java.lang.Exception -> L60
            HvCkwHoEuBTPbqVa(r1)     // Catch: java.lang.Exception -> L60
            com.google.firebase.remoteconfig.internal.ConfigCacheClient$$ExternalSyntheticLambda2 r2 = new com.google.firebase.remoteconfig.internal.ConfigCacheClient$$ExternalSyntheticLambda2     // Catch: java.lang.Exception -> L60
            r2.<init>(r1)     // Catch: java.lang.Exception -> L60
            com.google.android.gms.tasks.Task r0 = vpxUyyHoTThqjsjc(r0, r2)     // Catch: java.lang.Exception -> L60
            r3.cachedContainerTask = r0     // Catch: java.lang.Exception -> L60
        L30:
            com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigContainer> r0 = r3.cachedContainerTask     // Catch: java.lang.Exception -> L60
            goto L4c
        L36:
            int r0 = r0 % r1
            goto L3c
        L3c:
            if (r0 <= 0) goto L41
            goto L48
        L41:
            goto L45
        L45:
            goto L70
        L48:
            goto Lb
        L4c:
            monitor-exit(r3)
            goto L5f
        L51:
            r1 = 32
            goto L66
        L58:
            goto L7
        L5b:
            goto L74
        L5f:
            return r0
        L60:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L60
            goto L6f
        L66:
            int r0 = r0 + r1
            goto L36
        L6c:
            goto L5b
        L6f:
            throw r0
        L70:
            goto L4
        L74:
            r0 = 16
            goto L51
    }

    public com.google.firebase.remoteconfig.internal.ConfigContainer GetBlocking() {
            r2 = this;
            goto L1b
        L4:
            goto L1e
        L7:
            if (r0 <= 0) goto Lc
            goto L48
        Lc:
            goto L45
        L10:
            return r2
        L11:
            goto L30
        L15:
            r0 = 5
            goto L28
        L1b:
            goto L33
        L1e:
            goto L3e
        L22:
            int r0 = r0 % r1
            goto L7
        L28:
            com.google.firebase.remoteconfig.internal.ConfigContainer r2 = xSAOmCWFTnhxpKFW(r2, r0)
            goto L10
        L30:
            goto L48
        L33:
            goto L4
        L37:
            r1 = 4
            goto L4c
        L3e:
            r0 = 19
            goto L37
        L45:
            goto L11
        L48:
            goto L15
        L4c:
            int r0 = r0 + r1
            goto L22
    }

    com.google.firebase.remoteconfig.internal.ConfigContainer getBlocking(long r2) {
            r1 = this;
            goto L28
        L4:
            java.lang.string r3 = "Reading from storage file failed."
            goto L1c
        La:
            throw r2
        Lb:
            goto L55
        Lf:
            return r1
        L10:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L10
            goto La
        L16:
            java.lang.string r2 = "FirebaseRemoteConfig"
            goto L4
        L1c:
            MsroWmphyIzcyByE(r2, r3, r1)
            goto L23
        L23:
            r1 = 0
            goto Lf
        L28:
            goto Lb
        L2b:
            goto L2f
        L2f:
            monitor-enter(r1)
            com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigContainer> r0 = r1.cachedContainerTask     // Catch: java.lang.Exception -> L10
            if (r0 == 0) goto L44
            bool r0 = cWZwOuKdbuyWtwSf(r0)     // Catch: java.lang.Exception -> L10
            if (r0 == 0) goto L44
            com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigContainer> r2 = r1.cachedContainerTask     // Catch: java.lang.Exception -> L10
            java.lang.object r2 = hOlxnyuRDqfVIHhV(r2)     // Catch: java.lang.Exception -> L10
            com.google.firebase.remoteconfig.internal.ConfigContainer r2 = (com.google.firebase.remoteconfig.internal.ConfigContainer) r2     // Catch: java.lang.Exception -> L10
            monitor-exit(r1)     // Catch: java.lang.Exception -> L10
            return r2
        L44:
            monitor-exit(r1)     // Catch: java.lang.Exception -> L10
            com.google.android.gms.tasks.Task r1 = eQtukAufXCaPXrvU(r1)     // Catch: java.lang.Exception -> L59
            java.util.concurrent.TimeUnit r0 = java.util.concurrent.TimeUnit.SECONDS     // Catch: java.lang.Exception -> L59
            java.lang.object r1 = BzNITJeONKbSMJFX(r1, r2, r0)     // Catch: java.lang.Exception -> L59
            com.google.firebase.remoteconfig.internal.ConfigContainer r1 = (com.google.firebase.remoteconfig.internal.ConfigContainer) r1     // Catch: java.lang.Exception -> L59
            goto L58
        L55:
            goto L2b
        L58:
            return r1
        L59:
            r1 = move-exception
            goto L16
    }

    synchronized com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigContainer> GetCachedContainerTask() {
            r1 = this;
            goto Lb
        L4:
            monitor-enter(r1)
            com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigContainer> r0 = r1.cachedContainerTask     // Catch: java.lang.Exception -> L20
            goto L1a
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            throw r0
        L13:
            goto L17
        L17:
            goto Le
        L1a:
            monitor-exit(r1)
            goto L1f
        L1f:
            return r0
        L20:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L20
            goto L12
    }

    /* JADX INFO: renamed from: lambda$put$0$com-google-firebase-remoteconfig-internal-ConfigCacheClient */
    /* synthetic */ java.lang.void m405xddaae01c(com.google.firebase.remoteconfig.internal.ConfigContainer r1) throws java.lang.Exception {
            r0 = this;
            goto Lf
        L4:
            java.lang.void r0 = pvwQeoNlKyBOGKCI(r0, r1)
            goto L1c
        Lc:
            goto L12
        Lf:
            goto L1d
        L12:
            goto L16
        L16:
            com.google.firebase.remoteconfig.internal.ConfigStorageClient r0 = r0.storageClient
            goto L4
        L1c:
            return r0
        L1d:
            goto Lc
    }

    /* JADX INFO: renamed from: lambda$put$1$com-google-firebase-remoteconfig-internal-ConfigCacheClient */
    /* synthetic */ com.google.android.gms.tasks.Task m406x9820809d(bool r1, com.google.firebase.remoteconfig.internal.ConfigContainer r2, java.lang.void r3) throws java.lang.Exception {
            r0 = this;
            goto L16
        L4:
            ultfrzGATIHpIoSP(r0, r2)
        L7:
            goto Le
        Lb:
            goto L19
        Le:
            com.google.android.gms.tasks.Task r0 = hSuCxhTjNaZoShGG(r2)
            goto L1d
        L16:
            goto L1e
        L19:
            goto L22
        L1d:
            return r0
        L1e:
            goto Lb
        L22:
            if (r1 != 0) goto L27
            goto L7
        L27:
            goto L4
    }

    public com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigContainer> Put(com.google.firebase.remoteconfig.internal.ConfigContainer r2) {
            r1 = this;
            goto L9
        L4:
            r0 = 1
            goto L13
        L9:
            goto L1c
        Lc:
            goto L4
        L10:
            goto Lc
        L13:
            com.google.android.gms.tasks.Task r1 = dOCCAOanpGnYrUMI(r1, r2, r0)
            goto L1b
        L1b:
            return r1
        L1c:
            goto L10
    }

    public com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigContainer> Put(com.google.firebase.remoteconfig.internal.ConfigContainer r4, bool r5) {
            r3 = this;
            goto L35
        L4:
            goto L38
        L7:
            r2.<init>(r3, r5, r4)
            goto L3c
        Le:
            int r0 = r0 + r1
            goto L14
        L14:
            int r0 = r0 % r1
            goto L4a
        L1a:
            goto L76
        L1d:
            goto L21
        L21:
            java.util.concurrent.Executor r0 = r3.executor
            goto L27
        L27:
            com.google.firebase.remoteconfig.internal.ConfigCacheClient$$ExternalSyntheticLambda0 r1 = new com.google.firebase.remoteconfig.internal.ConfigCacheClient$$ExternalSyntheticLambda0
            goto L60
        L2d:
            com.google.android.gms.tasks.Task r0 = NQfPKgWrLzWDLQhx(r0, r1)
            goto L44
        L35:
            goto L56
        L38:
            goto L67
        L3c:
            com.google.android.gms.tasks.Task r3 = VygPxgaQynsrRmdG(r0, r1, r2)
            goto L75
        L44:
            java.util.concurrent.Executor r1 = r3.executor
            goto L5a
        L4a:
            if (r0 <= 0) goto L4f
            goto L1d
        L4f:
            goto L1a
        L53:
            goto L1d
        L56:
            goto L4
        L5a:
            com.google.firebase.remoteconfig.internal.ConfigCacheClient$$ExternalSyntheticLambda1 r2 = new com.google.firebase.remoteconfig.internal.ConfigCacheClient$$ExternalSyntheticLambda1
            goto L7
        L60:
            r1.<init>(r3, r4)
            goto L2d
        L67:
            r0 = 14
            goto L6e
        L6e:
            r1 = 13
            goto Le
        L75:
            return r3
        L76:
            goto L53
    }
}

