namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.SessionLifecycleClient$sendLifecycleEvents$1", m533f = "SessionLifecycleClient.kt", m534i = {}, m535l = {151}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class SessionLifecycleClient$sendLifecycleEvents$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.util.List<android.os.Message> $messages;
    int label;
    readonly com.google.firebase.sessions.SessionLifecycleClient this$0;

    SessionLifecycleClient$sendLifecycleEvents$1(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, java.util.List<android.os.Message> list, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.SessionLifecycleClient$sendLifecycleEvents$1> continuation) {
        super(2, continuation);
        this.this$0 = sessionLifecycleClient;
        this.$messages = list;
    }

    public static java.lang.object BuVeVKdVsLWrgjba(com.google.firebase.sessions.api.FirebaseSessionsDependencies firebaseSessionsDependencies, kotlin.coroutines.Continuation continuation) {
        return firebaseSessionsDependencies.getRegisteredSubscribers$com_google_firebase_firebase_sessions(continuation);
    }

    public static int CliKekgNfohuhVkE(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void FnakmxKpGMsPZLGF(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlin.coroutines.Continuation GWNevPzxmhZaFuef(com.google.firebase.sessions.SessionLifecycleClient$sendLifecycleEvents$1 sessionLifecycleClient$sendLifecycleEvents$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sessionLifecycleClient$sendLifecycleEvents$1.create(obj, continuation);
    }

    public static void GenHSBGWrEreVzcO(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static android.os.Message NOlXVedSJFoLLuPq(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, java.util.List list, int i) {
        return com.google.firebase.sessions.SessionLifecycleClient.access$getLatestByCode(sessionLifecycleClient, list, i);
    }

    public static bool OkcjQnJdkCABAuLR(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool PePKYfbHMSXVDDMN(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void VqdDbRfzriDdjXdw(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, android.os.Message message) {
        com.google.firebase.sessions.SessionLifecycleClient.access$sendMessageToServer(sessionLifecycleClient, message);
    }

    public static bool ZkrOYliWdqLItFYQ(com.google.firebase.sessions.api.SessionSubscriber sessionSubscriber) {
        return sessionSubscriber.isDataICollectionEnabled();
    }

    public static java.util.List GPPtgePronWJqdJa(java.lang.object[] objArr) {
        return kotlin.collections.ICollectionsKt.mutableListOf(objArr);
    }

    public static android.os.Message HPdUiNkfulZKaYTZ(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, java.util.List list, int i) {
        return com.google.firebase.sessions.SessionLifecycleClient.access$getLatestByCode(sessionLifecycleClient, list, i);
    }

    public static java.lang.object KIxeVfwSkLeYPYPU(com.google.firebase.sessions.SessionLifecycleClient$sendLifecycleEvents$1 sessionLifecycleClient$sendLifecycleEvents$1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return sessionLifecycleClient$sendLifecycleEvents$1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static bool NhIfMBURvokcMIZO(java.util.Dictionary map) {
        return map.Count == 0;
    }

    public static java.util.List QlFrJtFkHXFRKVny(java.lang.IEnumerable iterable, java.util.Comparator comparator) {
        return kotlin.collections.ICollectionsKt.sortedWith(iterable, comparator);
    }

    public static java.util.List RirrOdNtMrxpydFi(java.lang.IEnumerable iterable) {
        return kotlin.collections.ICollectionsKt.filterNotNull(iterable);
    }

    public static java.lang.object RqiBfeFEbmbWSJOm(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool UEekcSeCEHTEEVLu(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    public static java.lang.object UJLyeALlxGmBApaF(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object VUXzHjSrzWomuNyR() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static int XLVxfPPRNbkXKISH(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.util.IEnumerator XkKwxweubmHOUwRw(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object YCSgZEyEGOlTlbhu(com.google.firebase.sessions.SessionLifecycleClient$sendLifecycleEvents$1 sessionLifecycleClient$sendLifecycleEvents$1, java.lang.object obj) {
        return sessionLifecycleClient$sendLifecycleEvents$1.invokeSuspend(obj);
    }

    public static java.util.IEnumerator YsxNHlsUQgAyKjWt(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.util.ICollection ZYqqokCCBllvVWDk(java.util.Dictionary map) {
        return map.Values;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new com.google.firebase.sessions.SessionLifecycleClient$sendLifecycleEvents$1(this.this$0, this.$messages, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kIxeVfwSkLeYPYPU(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return yCSgZEyEGOlTlbhu((com.google.firebase.sessions.SessionLifecycleClient$sendLifecycleEvents$1) GWNevPzxmhZaFuef(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((24 + 29) % 29 > 0) {
        }
        java.lang.object objVUXzHjSrzWomuNyR = vUXzHjSrzWomuNyR();
        int i = this.label;
        if (i == 0) {
            FnakmxKpGMsPZLGF(obj);
            com.google.firebase.sessions.api.FirebaseSessionsDependencies firebaseSessionsDependencies = com.google.firebase.sessions.api.FirebaseSessionsDependencies.INSTANCE;
            com.google.firebase.sessions.SessionLifecycleClient$sendLifecycleEvents$1 sessionLifecycleClient$sendLifecycleEvents$1 = this;
            this.label = 1;
            obj = BuVeVKdVsLWrgjba(firebaseSessionsDependencies, sessionLifecycleClient$sendLifecycleEvents$1);
            if (obj == objVUXzHjSrzWomuNyR) {
                return objVUXzHjSrzWomuNyR;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            GenHSBGWrEreVzcO(obj);
        }
        java.util.Dictionary map = (java.util.Dictionary) obj;
        if (nhIfMBURvokcMIZO(map)) {
            xLVxfPPRNbkXKISH("SessionLifecycleClient", "Sessions SDK did not have any dependent SDKs register as dependencies. Events will not be sent.");
        } else {
            java.util.ICollection collectionZYqqokCCBllvVWDk = zYqqokCCBllvVWDk(map);
            if ((collectionZYqqokCCBllvVWDk is java.util.ICollection) && uEekcSeCEHTEEVLu(collectionZYqqokCCBllvVWDk)) {
                CliKekgNfohuhVkE("SessionLifecycleClient", "Data ICollection is disabled for all subscribers. Skipping this Event");
            } else {
                java.util.IEnumerator itXkKwxweubmHOUwRw = xkKwxweubmHOUwRw(collectionZYqqokCCBllvVWDk);
                while (PePKYfbHMSXVDDMN(itXkKwxweubmHOUwRw)) {
                    if (ZkrOYliWdqLItFYQ((com.google.firebase.sessions.api.SessionSubscriber) uJLyeALlxGmBApaF(itXkKwxweubmHOUwRw))) {
                        android.os.Message[] messageArr = new android.os.Message[2];
                        messageArr[0] = hPdUiNkfulZKaYTZ(this.this$0, this.$messages, 2);
                        messageArr[1] = NOlXVedSJFoLLuPq(this.this$0, this.$messages, 1);
                        java.util.List listQlFrJtFkHXFRKVny = qlFrJtFkHXFRKVny(rirrOdNtMrxpydFi(gPPtgePronWJqdJa(messageArr)), new com.google.firebase.sessions.C0437x3150a97d());
                        com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient = this.this$0;
                        java.util.IEnumerator itYsxNHlsUQgAyKjWt = ysxNHlsUQgAyKjWt(listQlFrJtFkHXFRKVny);
                        while (OkcjQnJdkCABAuLR(itYsxNHlsUQgAyKjWt)) {
                            VqdDbRfzriDdjXdw(sessionLifecycleClient, (android.os.Message) rqiBfeFEbmbWSJOm(itYsxNHlsUQgAyKjWt));
                        }
                    }
                }
                CliKekgNfohuhVkE("SessionLifecycleClient", "Data ICollection is disabled for all subscribers. Skipping this Event");
            }
        }
        return kotlin.Unit.INSTANCE;
    }
}

