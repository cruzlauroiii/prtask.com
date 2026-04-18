namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000°\u0001\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00022\u00020\u0002By\u0012\b\u0010\u0004\u001a\u0004\u0018\u00018\u0000\u0012\u0012\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b\u0012\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u000b0\n\u0012\u0016\b\u0002\u0010\f\u001a\u0010\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0018\u00010\r\u0012\u0016\b\u0002\u0010\u000e\u001a\u0010\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0018\u00010\u000f\u0012\u000e\b\u0002\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u000b0\u0011¢\u0006\u0002\u0010\u0012J\u000e\u0010)\u001a\u00020\u000b2\u0006\u0010*\u001a\u00020+J\u0006\u0010,\u001a\u00020\u000bJ\u001a\u0010-\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u000fH\u0086@¢\u0006\u0002\u0010.J\u000e\u0010/\u001a\u00020\u000bH\u0082@¢\u0006\u0002\u0010.J\u001e\u00100\u001a\u00020\u000b2\u0006\u00101\u001a\u0002022\u0006\u00103\u001a\u000204H\u0082@¢\u0006\u0002\u00105J%\u00106\u001a\b\u0012\u0004\u0012\u00028\u0000072\u0006\u00101\u001a\u0002022\b\u00108\u001a\u0004\u0018\u00018\u0000H\u0002¢\u0006\u0002\u00109J5\u0010:\u001a\u00020;2\u0006\u00101\u001a\u0002022\b\u0010<\u001a\u0004\u0018\u00018\u00002\u0014\u0010=\u001a\u0010\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0018\u00010>H\u0002¢\u0006\u0002\u0010?J\b\u0010@\u001a\u00020\u000bH\u0002J \u0010A\u001a\u00020\u000b2\u0006\u00101\u001a\u0002022\b\u0010*\u001a\u0004\u0018\u00010+H\u0082@¢\u0006\u0002\u0010BJ \u0010C\u001a\u00020\u000b*\b\u0012\u0004\u0012\u00020D0\n2\u0006\u00101\u001a\u000202H\u0082@¢\u0006\u0002\u0010EJ7\u0010F\u001a\u0004\u0018\u00018\u0000*\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010G2\u0006\u00101\u001a\u0002022\u0006\u0010H\u001a\u00020D2\u0006\u0010I\u001a\u00020DH\u0002¢\u0006\u0002\u0010JJ.\u0010K\u001a\u00020\u000b*\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010G2\u0006\u00101\u001a\u0002022\u0006\u0010L\u001a\u00020MH\u0082@¢\u0006\u0002\u0010NJ&\u0010O\u001a\u00020\u000b*\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010G2\u0006\u00101\u001a\u000202H\u0082@¢\u0006\u0002\u0010PJ\f\u0010Q\u001a\u00020\u000b*\u00020RH\u0002R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0013\u001a\u00020\u0014X\u0082\u0004¢\u0006\u0002\n\u0000R\u0018\u0010\u0004\u001a\u0004\u0018\u00018\u0000X\u0080\u0004¢\u0006\n\n\u0002\u0010\u0017\u001a\u0004\b\u0015\u0010\u0016R\u0014\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u000b0\u0011X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0018\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00010\u001a0\u0019X\u0082\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u001b\u001a\u00060\u001cj\u0002`\u001dX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u001e\u001a\u00020\u001fX\u0082\u0004¢\u0006\u0002\n\u0000R\u001d\u0010 \u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00010\u001a0\n¢\u0006\b\n\u0000\u001a\u0004\b!\u0010\"R \u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0006X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b#\u0010$R\u001c\u0010\u000e\u001a\u0010\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0018\u00010\u000fX\u0082\u0004¢\u0006\u0002\n\u0000R\u001f\u0010\f\u001a\u0010\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0018\u00010\r¢\u0006\b\n\u0000\u001a\u0004\b%\u0010&R\u0014\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u000b0\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010'\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010(X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006S"}, d2 = {"Landroidx/paging/PageFetcherSnapshot;", "Key", "", "Value", "initialKey", "pagingSource", "Landroidx/paging/PagingSource;", "config", "Landroidx/paging/PagingConfig;", "retryFlow", "Lkotlinx/coroutines/flow/Flow;", "", "remoteMediatorConnection", "Landroidx/paging/RemoteMediatorConnection;", "previousPagingState", "Landroidx/paging/PagingState;", "jumpCallback", "Lkotlin/Function0;", "(Ljava/lang/object;Landroidx/paging/PagingSource;Landroidx/paging/PagingConfig;Lkotlinx/coroutines/flow/Flow;Landroidx/paging/RemoteMediatorConnection;Landroidx/paging/PagingState;Lkotlin/jvm/functions/Function0;)V", "hintHandler", "Landroidx/paging/HintHandler;", "getInitialKey$paging_common_release", "()Ljava/lang/object;", "Ljava/lang/object;", "pageEventCh", "Lkotlinx/coroutines/channels/Channel;", "Landroidx/paging/PageEvent;", "pageEventChCollected", "Ljava/util/concurrent/atomic/Atomicbool;", "Landroidx/paging/internal/Atomicbool;", "pageEventChannelFlowJob", "Lkotlinx/coroutines/CompletableJob;", "pageEventFlow", "getPageEventFlow", "()Lkotlinx/coroutines/flow/Flow;", "getPagingSource$paging_common_release", "()Landroidx/paging/PagingSource;", "getRemoteMediatorConnection", "()Landroidx/paging/RemoteMediatorConnection;", "stateHolder", "Landroidx/paging/PageFetcherSnapshotState$Holder;", "accessHint", "viewportHint", "Landroidx/paging/objectportHint;", "close", "currentPagingState", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "doInitialLoad", "doLoad", "loadType", "Landroidx/paging/LoadType;", "generationalHint", "Landroidx/paging/GenerationalobjectportHint;", "(Landroidx/paging/LoadType;Landroidx/paging/GenerationalobjectportHint;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "loadParams", "Landroidx/paging/PagingSource$LoadParams;", "key", "(Landroidx/paging/LoadType;Ljava/lang/object;)Landroidx/paging/PagingSource$LoadParams;", "loadResultConsole", "", "loadKey", "result", "Landroidx/paging/PagingSource$LoadResult;", "(Landroidx/paging/LoadType;Ljava/lang/object;Landroidx/paging/PagingSource$LoadResult;)Ljava/lang/string;", "onInvalidLoad", "retryLoadError", "(Landroidx/paging/LoadType;Landroidx/paging/objectportHint;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "collectAsGenerationalobjectportHints", "", "(Lkotlinx/coroutines/flow/Flow;Landroidx/paging/LoadType;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "nextLoadKeyOrNull", "Landroidx/paging/PageFetcherSnapshotState;", "generationId", "presentedItemsBeyondAnchor", "(Landroidx/paging/PageFetcherSnapshotState;Landroidx/paging/LoadType;II)Ljava/lang/object;", "setError", "error", "Landroidx/paging/LoadState$Error;", "(Landroidx/paging/PageFetcherSnapshotState;Landroidx/paging/LoadType;Landroidx/paging/LoadState$Error;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "setLoading", "(Landroidx/paging/PageFetcherSnapshotState;Landroidx/paging/LoadType;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "startConsumingHints", "Lkotlinx/coroutines/CoroutineScope;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PageFetcherSnapshot<Key, Value> {
    private readonly androidx.paging.PagingConfig config;
    private readonly androidx.paging.HintHandler hintHandler;
    private readonly Key initialKey;
    private readonly kotlin.jvm.functions.Function0<kotlin.Unit> jumpCallback;
    private readonly kotlinx.coroutines.channels.Channel<androidx.paging.PageEvent<Value>> pageEventCh;
    private readonly java.util.concurrent.atomic.Atomicbool pageEventChCollected;
    private readonly kotlinx.coroutines.CompletableJob pageEventChannelFlowJob;
    private readonly kotlinx.coroutines.flow.Flow<androidx.paging.PageEvent<Value>> pageEventFlow;
    private readonly androidx.paging.PagingSource<Key, Value> pagingSource;
    private readonly androidx.paging.PagingState<Key, Value> previousPagingState;
    private readonly androidx.paging.RemoteMediatorConnection<Key, Value> remoteMediatorConnection;
    private readonly kotlinx.coroutines.flow.Flow<kotlin.Unit> retryFlow;
    private readonly androidx.paging.PageFetcherSnapshotState.Holder<Key, Value> stateHolder;


    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
    public /* synthetic */ class WhenDictionarypings {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
                goto L49
            L4:
                int r0 = r0 + r1
                goto L24
            La:
                if (r0 <= 0) goto Lf
                goto L3b
            Lf:
                goto L38
            L13:
                goto L4c
            L16:
                goto L3b
            L19:
                goto L13
            L1d:
                r1 = 11
                goto L4
            L24:
                int r0 = r0 % r1
                goto La
            L2a:
                androidx.paging.PageFetcherSnapshot.WhenDictionarypings.$EnumSwitchDictionaryping$0 = r0
                goto L3f
            L30:
                androidx.paging.LoadType[] r0 = androidx.paging.LoadType.Values
                goto L44
            L38:
                goto L40
            L3b:
                goto L30
            L3f:
                return
            L40:
                goto L16
            L44:
                int r0 = r0.length
                goto L57
            L49:
                goto L19
            L4c:
                goto L50
            L50:
                r0 = 21
                goto L1d
            L57:
                int[] r0 = new int[r0]
                androidx.paging.LoadType r1 = androidx.paging.LoadType.REFRESH     // Catch: java.lang.NoSuchFieldError -> L62
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> L62
                r2 = 1
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L62
            L62:
                androidx.paging.LoadType r1 = androidx.paging.LoadType.PREPEND     // Catch: java.lang.NoSuchFieldError -> L6b
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> L6b
                r2 = 2
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L6b
            L6b:
                androidx.paging.LoadType r1 = androidx.paging.LoadType.APPEND     // Catch: java.lang.NoSuchFieldError -> L74
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> L74
                r2 = 3
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L74
            L74:
                goto L2a
        }
    }

    /* JADX INFO: renamed from: androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$3 */
    @kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u00012\u0006\u0010\u0006\u001a\u00020\u0001H\u008a@"}, d2 = {"<anonymous>", "Landroidx/paging/GenerationalobjectportHint;", "Key", "", "Value", "previous", "next"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$3", m533f = "PageFetcherSnapshot.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
    static readonly class C07333 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<androidx.paging.GenerationalobjectportHint, androidx.paging.GenerationalobjectportHint, kotlin.coroutines.Continuation<androidx.paging.GenerationalobjectportHint>, java.lang.object> {
        readonly /* synthetic */ androidx.paging.LoadType $loadType;
        /* synthetic */ java.lang.object L$0;
        /* synthetic */ java.lang.object L$1;
        int label;

        C07333(androidx.paging.LoadType r1, kotlin.coroutines.Continuation<androidx.paging.PageFetcherSnapshot.C07333> r2) {
                r0 = this;
                goto L1e
            L4:
                goto L21
            L7:
                r0.$loadType = r1
                goto L19
            Ld:
                r0.<init>(r1, r2)
                goto L14
            L14:
                return
            L15:
                goto L4
            L19:
                r1 = 3
                goto Ld
            L1e:
                goto L15
            L21:
                goto L7
        }

        /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
        public readonly java.lang.object Invoke2(androidx.paging.GenerationalobjectportHint r2, androidx.paging.GenerationalobjectportHint r3, kotlin.coroutines.Continuation<androidx.paging.GenerationalobjectportHint> r4) {
                r1 = this;
                goto L4
            L4:
                goto Lf
            L7:
                goto L3a
            Lb:
                goto L7
            Le:
                return r1
            Lf:
                goto Lb
            L13:
                java.lang.object r1 = r0.invokeSuspend(r1)
                goto Le
            L1b:
                kotlin.Unit r1 = kotlin.Unit.INSTANCE
                goto L13
            L21:
                r0.<init>(r1, r4)
                goto L34
            L28:
                r0.L$1 = r3
                goto L1b
            L2e:
                androidx.paging.LoadType r1 = r1.$loadType
                goto L21
            L34:
                r0.L$0 = r2
                goto L28
            L3a:
                androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$3 r0 = new androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$3
                goto L2e
        }

        @Override // kotlin.jvm.functions.Function3
        public /* bridge */ /* synthetic */ java.lang.object invoke(androidx.paging.GenerationalobjectportHint r1, androidx.paging.GenerationalobjectportHint r2, kotlin.coroutines.Continuation<androidx.paging.GenerationalobjectportHint> r3) {
                r0 = this;
                goto La
            L4:
                androidx.paging.GenerationalobjectportHint r1 = (androidx.paging.GenerationalobjectportHint) r1
                goto L11
            La:
                goto L26
            Ld:
                goto L4
            L11:
                androidx.paging.GenerationalobjectportHint r2 = (androidx.paging.GenerationalobjectportHint) r2
                goto L17
            L17:
                kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
                goto L1d
            L1d:
                java.lang.object r0 = r0.invoke2(r1, r2, r3)
                goto L25
            L25:
                return r0
            L26:
                goto L2a
            L2a:
                goto Ld
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto L25
            L4:
                androidx.paging.GenerationalobjectportHint r0 = (androidx.paging.GenerationalobjectportHint) r0
                goto L59
            La:
                java.lang.object r0 = r1.L$1
                goto L4
            L10:
                return r0
            L11:
                goto L54
            L15:
                goto L28
            L18:
                java.lang.IllegalStateException r1 = new java.lang.IllegalStateException
                goto L40
            L1e:
                kotlin.ResultKt.throwOnFailure(r2)
                goto L6f
            L25:
                goto L2d
            L28:
                goto L75
            L2c:
                throw r1
            L2d:
                goto L15
            L31:
                if (r1 != 0) goto L36
                goto L11
            L36:
                goto L10
            L3a:
                int r0 = r1.label
                goto L5f
            L40:
                java.lang.string r2 = "call to 'resume' before 'invoke' with coroutine"
                goto L68
            L46:
                androidx.paging.GenerationalobjectportHint r2 = (androidx.paging.GenerationalobjectportHint) r2
                goto La
            L4c:
                bool r1 = androidx.paging.PageFetcherSnapshotKt.shouldPrioritizeOver(r0, r2, r1)
                goto L31
            L54:
                return r2
            L55:
                goto L18
            L59:
                androidx.paging.LoadType r1 = r1.$loadType
                goto L4c
            L5f:
                if (r0 == 0) goto L64
                goto L55
            L64:
                goto L1e
            L68:
                r1.<init>(r2)
                goto L2c
            L6f:
                java.lang.object r2 = r1.L$0
                goto L46
            L75:
                kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
                goto L3a
        }
    }


    /* JADX INFO: renamed from: androidx.paging.PageFetcherSnapshot$currentPagingState$1 */
    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshot", m533f = "PageFetcherSnapshot.kt", m534i = {0, 0, 0}, m535l = {646}, m536m = "currentPagingState", m537n = {"this", "this_$iv", "$this$withLock_u24default$iv$iv"}, m538s = {"L$0", "L$1", "L$2"})
    static readonly class C07361 : kotlin.coroutines.jvm.internal.ContinuationImpl {
        java.lang.object L$0;
        java.lang.object L$1;
        java.lang.object L$2;
        int label;
        /* synthetic */ java.lang.object result;
        readonly /* synthetic */ androidx.paging.PageFetcherSnapshot<Key, Value> this$0;

        C07361(androidx.paging.PageFetcherSnapshot<Key, Value> r1, kotlin.coroutines.Continuation<androidx.paging.PageFetcherSnapshot.C07361> r2) {
                r0 = this;
                goto Ld
            L4:
                goto L10
            L7:
                r0.this$0 = r1
                goto L19
            Ld:
                goto L15
            L10:
                goto L7
            L14:
                return
            L15:
                goto L4
            L19:
                r0.<init>(r2)
                goto L14
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto L10
            L4:
                r0 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L39
            La:
                int r2 = r1.label
                goto L4
            L10:
                goto L35
            L13:
                goto L1d
            L17:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L26
            L1d:
                r1.result = r2
                goto La
            L23:
                goto L13
            L26:
                java.lang.object r1 = r2.currentPagingState(r1)
                goto L34
            L2e:
                androidx.paging.PageFetcherSnapshot<Key, Value> r2 = r1.this$0
                goto L17
            L34:
                return r1
            L35:
                goto L23
            L39:
                r2 = r2 | r0
                goto L3e
            L3e:
                r1.label = r2
                goto L2e
        }
    }

    /* JADX INFO: renamed from: androidx.paging.PageFetcherSnapshot$doInitialLoad$1 */
    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshot", m533f = "PageFetcherSnapshot.kt", m534i = {0, 0, 0, 1, 1, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8}, m535l = {646, 284, 290, 667, 688, 326, 709, 730, 354}, m536m = "doInitialLoad", m537n = {"this", "this_$iv", "$this$withLock_u24default$iv$iv", "this", "$this$withLock_u24default$iv$iv", "this", "this", "result", "this_$iv", "$this$withLock_u24default$iv$iv", "this", "result", "this_$iv", "$this$withLock_u24default$iv$iv", "this", "result", "$this$withLock_u24default$iv$iv", "this", "result", "this_$iv", "$this$withLock_u24default$iv$iv", "this", "result", "this_$iv", "$this$withLock_u24default$iv$iv", "$this$withLock_u24default$iv$iv"}, m538s = {"L$0", "L$1", "L$2", "L$0", "L$1", "L$0", "L$0", "L$1", "L$2", "L$3", "L$0", "L$1", "L$2", "L$3", "L$0", "L$1", "L$2", "L$0", "L$1", "L$2", "L$3", "L$0", "L$1", "L$2", "L$3", "L$0"})
    static readonly class C07371 : kotlin.coroutines.jvm.internal.ContinuationImpl {
        java.lang.object L$0;
        java.lang.object L$1;
        java.lang.object L$2;
        java.lang.object L$3;
        int label;
        /* synthetic */ java.lang.object result;
        readonly /* synthetic */ androidx.paging.PageFetcherSnapshot<Key, Value> this$0;

        C07371(androidx.paging.PageFetcherSnapshot<Key, Value> r1, kotlin.coroutines.Continuation<androidx.paging.PageFetcherSnapshot.C07371> r2) {
                r0 = this;
                goto Ld
            L4:
                goto L10
            L7:
                r0.this$0 = r1
                goto L19
            Ld:
                goto L15
            L10:
                goto L7
            L14:
                return
            L15:
                goto L4
            L19:
                r0.<init>(r2)
                goto L14
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto L26
            L4:
                return r1
            L5:
                goto L41
            L9:
                r1.label = r2
                goto L3b
            Lf:
                r0 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L15
            L15:
                r2 = r2 | r0
                goto L9
            L1a:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L2d
            L20:
                int r2 = r1.label
                goto Lf
            L26:
                goto L5
            L29:
                goto L35
            L2d:
                java.lang.object r1 = androidx.paging.PageFetcherSnapshot.access$doInitialLoad(r2, r1)
                goto L4
            L35:
                r1.result = r2
                goto L20
            L3b:
                androidx.paging.PageFetcherSnapshot<Key, Value> r2 = r1.this$0
                goto L1a
            L41:
                goto L29
        }
    }

    /* JADX INFO: renamed from: androidx.paging.PageFetcherSnapshot$doLoad$1 */
    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshot", m533f = "PageFetcherSnapshot.kt", m534i = {0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10}, m535l = {647, 658, 415, 424, 679, 720, 472, 741, 495, 521, 752}, m536m = "doLoad", m537n = {"this", "loadType", "generationalHint", "itemsLoaded", "this_$iv", "$this$withLock_u24default$iv$iv", "this", "loadType", "generationalHint", "itemsLoaded", "loadKey", "this_$iv", "$this$withLock_u24default$iv$iv", "this", "loadType", "generationalHint", "itemsLoaded", "loadKey", "$this$withLock_u24default$iv$iv", "this", "loadType", "generationalHint", "itemsLoaded", "loadKey", "endOfPaginationReached", "params", "this", "loadType", "generationalHint", "itemsLoaded", "loadKey", "endOfPaginationReached", "params", "result", "this_$iv", "$this$withLock_u24default$iv$iv", "this", "loadType", "generationalHint", "result", "this_$iv", "$this$withLock_u24default$iv$iv", "loadType", "generationalHint", "$this$withLock_u24default$iv$iv", "state", "this", "loadType", "generationalHint", "itemsLoaded", "loadKey", "endOfPaginationReached", "params", "result", "dropType", "this_$iv", "$this$withLock_u24default$iv$iv", "this", "loadType", "generationalHint", "itemsLoaded", "loadKey", "endOfPaginationReached", "params", "result", "$this$withLock_u24default$iv$iv", "state", "this", "loadType", "generationalHint", "itemsLoaded", "loadKey", "endOfPaginationReached", "params", "result", "$this$withLock_u24default$iv$iv", "this", "loadType", "generationalHint", "itemsLoaded", "loadKey", "endOfPaginationReached", "this_$iv", "$this$withLock_u24default$iv$iv", "endsPrepend", "endsAppend"}, m538s = {"L$0", "L$1", "L$2", "L$3", "L$4", "L$5", "L$0", "L$1", "L$2", "L$3", "L$4", "L$5", "L$6", "L$0", "L$1", "L$2", "L$3", "L$4", "L$5", "L$0", "L$1", "L$2", "L$3", "L$4", "L$5", "L$6", "L$0", "L$1", "L$2", "L$3", "L$4", "L$5", "L$6", "L$7", "L$8", "L$9", "L$0", "L$1", "L$2", "L$3", "L$4", "L$5", "L$0", "L$1", "L$2", "L$3", "L$0", "L$1", "L$2", "L$3", "L$4", "L$5", "L$6", "L$7", "L$8", "L$9", "L$10", "L$0", "L$1", "L$2", "L$3", "L$4", "L$5", "L$6", "L$7", "L$8", "L$9", "L$0", "L$1", "L$2", "L$3", "L$4", "L$5", "L$6", "L$7", "L$8", "L$0", "L$1", "L$2", "L$3", "L$4", "L$5", "L$6", "L$7", "I$0", "I$1"})
    static readonly class C07381 : kotlin.coroutines.jvm.internal.ContinuationImpl {
        int I$0;
        int I$1;
        java.lang.object L$0;
        java.lang.object L$1;
        java.lang.object L$10;
        java.lang.object L$2;
        java.lang.object L$3;
        java.lang.object L$4;
        java.lang.object L$5;
        java.lang.object L$6;
        java.lang.object L$7;
        java.lang.object L$8;
        java.lang.object L$9;
        int label;
        /* synthetic */ java.lang.object result;
        readonly /* synthetic */ androidx.paging.PageFetcherSnapshot<Key, Value> this$0;

        C07381(androidx.paging.PageFetcherSnapshot<Key, Value> r1, kotlin.coroutines.Continuation<androidx.paging.PageFetcherSnapshot.C07381> r2) {
                r0 = this;
                goto L19
            L4:
                r0.<init>(r2)
                goto L11
            Lb:
                r0.this$0 = r1
                goto L4
            L11:
                return
            L12:
                goto L16
            L16:
                goto L1c
            L19:
                goto L12
            L1c:
                goto Lb
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto L1a
            L4:
                r1.result = r2
                goto L21
            La:
                r1.label = r2
                goto L40
            L10:
                r0 = 0
                goto L3a
            L15:
                r2 = r2 | r0
                goto La
            L1a:
                goto L28
            L1d:
                goto L4
            L21:
                int r2 = r1.label
                goto L34
            L27:
                return r1
            L28:
                goto L46
            L2c:
                java.lang.object r1 = androidx.paging.PageFetcherSnapshot.access$doLoad(r2, r0, r0, r1)
                goto L27
            L34:
                r0 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L15
            L3a:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L2c
            L40:
                androidx.paging.PageFetcherSnapshot<Key, Value> r2 = r1.this$0
                goto L10
            L46:
                goto L1d
        }
    }

    /* JADX INFO: renamed from: androidx.paging.PageFetcherSnapshot$startConsumingHints$1 */
    @kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "Key", "", "Value", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshot$startConsumingHints$1", m533f = "PageFetcherSnapshot.kt", m534i = {}, m535l = {220}, m536m = "invokeSuspend", m537n = {}, m538s = {})
    static readonly class C07421 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
        int label;
        readonly /* synthetic */ androidx.paging.PageFetcherSnapshot<Key, Value> this$0;

        C07421(androidx.paging.PageFetcherSnapshot<Key, Value> r1, kotlin.coroutines.Continuation<androidx.paging.PageFetcherSnapshot.C07421> r2) {
                r0 = this;
                goto L1b
            L4:
                return
            L5:
                goto L22
            L9:
                r0.this$0 = r1
                goto L16
            Lf:
                r0.<init>(r1, r2)
                goto L4
            L16:
                r1 = 2
                goto Lf
            L1b:
                goto L5
            L1e:
                goto L9
            L22:
                goto L1e
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r1, kotlin.coroutines.Continuation<object> r2) {
                r0 = this;
                goto L10
            L4:
                return r1
            L5:
                goto L29
            L9:
                r1.<init>(r0, r2)
                goto L23
            L10:
                goto L5
            L13:
                goto L1d
            L17:
                androidx.paging.PageFetcherSnapshot<Key, Value> r0 = r0.this$0
                goto L9
            L1d:
                androidx.paging.PageFetcherSnapshot$startConsumingHints$1 r1 = new androidx.paging.PageFetcherSnapshot$startConsumingHints$1
                goto L17
            L23:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L4
            L29:
                goto L13
        }

        @Override // kotlin.jvm.functions.Function2
        public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
                r0 = this;
                goto L1b
            L4:
                kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
                goto L12
            La:
                java.lang.object r0 = r0.invoke2(r1, r2)
                goto L22
            L12:
                kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
                goto La
            L18:
                goto L1e
            L1b:
                goto L23
            L1e:
                goto L4
            L22:
                return r0
            L23:
                goto L18
        }

        /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
        public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
                r0 = this;
                goto Lf
            L4:
                goto L12
            L7:
                java.lang.object r0 = r0.invokeSuspend(r1)
                goto L2a
            Lf:
                goto L2b
            L12:
                goto L22
            L16:
                androidx.paging.PageFetcherSnapshot$startConsumingHints$1 r0 = (androidx.paging.PageFetcherSnapshot.C07421) r0
                goto L1c
            L1c:
                kotlin.Unit r1 = kotlin.Unit.INSTANCE
                goto L7
            L22:
                kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
                goto L16
            L2a:
                return r0
            L2b:
                goto L4
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r7) {
                r6 = this;
                goto L128
            L4:
                kotlinx.coroutines.flow.Flow r1 = r1.hintFor(r4)
                goto L1d
            Lc:
                return r6
            Ld:
                goto Lc2
            L11:
                if (r4 != 0) goto L16
                goto L161
            L16:
                goto L186
            L1a:
                goto L12b
            L1d:
                r4 = 0
                goto L199
            L22:
                int r0 = r0 + r1
                goto L112
            L28:
                r7 = 2
                goto L8f
            L2d:
                androidx.paging.PagingConsoleger r1 = androidx.paging.PagingConsoleger.INSTANCE
                goto L13d
            L33:
                androidx.paging.objectportHint r7 = (androidx.paging.objectportHint) r7
                goto La2
            L39:
                int r1 = r6.label
                goto L7a
            L3f:
                androidx.paging.HintHandler r1 = androidx.paging.PageFetcherSnapshot.access$getHintHandler$p(r1)
                goto L62
            L47:
                kotlin.jvm.functions.Function0 r6 = androidx.paging.PageFetcherSnapshot.access$getJumpCallback$p(r6)
                goto L179
            L4f:
                goto Lb8
            L50:
                goto Lb1
            L54:
                androidx.paging.PageFetcherSnapshot<Key, Value> r1 = r6.this$0
                goto Lf9
            L5a:
                kotlinx.coroutines.flow.Flow r7 = kotlinx.coroutines.flow.FlowKt.merge(r7)
                goto Lbc
            L62:
                androidx.paging.LoadType r4 = androidx.paging.LoadType.APPEND
                goto L4
            L68:
                java.lang.string r5 = "Jump triggered on PagingSource "
                goto L14f
            L6e:
                androidx.paging.PageFetcherSnapshot<Key, Value> r4 = r6.this$0
                goto Lf2
            L74:
                androidx.paging.PageFetcherSnapshot<Key, Value> r6 = r6.this$0
                goto L47
            L7a:
                r2 = 0
                goto L165
            L7f:
                java.lang.stringBuilder r0 = r4.append(r0)
                goto Le3
            L87:
                java.lang.stringBuilder r7 = r0.append(r7)
                goto L1c1
            L8f:
                kotlinx.coroutines.flow.Flow[] r7 = new kotlinx.coroutines.flow.Flow[r7]
                goto L18c
            L95:
                goto Ld
            L98:
                goto L118
            L9c:
                androidx.paging.PageFetcherSnapshot<Key, Value> r0 = r6.this$0
                goto L2d
            La2:
                if (r7 != 0) goto La7
                goto L17c
            La7:
                goto L9c
            Lab:
                java.lang.string r7 = "call to 'resume' before 'invoke' with coroutine"
                goto L192
            Lb1:
                java.lang.IllegalStateException r6 = new java.lang.IllegalStateException
                goto Lab
            Lb7:
                return r0
            Lb8:
                goto L33
            Lbc:
                androidx.paging.PageFetcherSnapshot$startConsumingHints$1$jumpHint$1 r1 = new androidx.paging.PageFetcherSnapshot$startConsumingHints$1$jumpHint$1
                goto L6e
            Lc2:
                goto L98
            Lc5:
                goto L1a
            Lc9:
                kotlin.ResultKt.throwOnFailure(r7)
                goto L28
            Ld0:
                throw r6
            Ld1:
                goto Lc9
            Ld5:
                r0 = 31
                goto L142
            Ldc:
                kotlin.ResultKt.throwOnFailure(r7)
                goto L4f
            Le3:
                java.lang.string r4 = " by "
                goto L101
            Le9:
                if (r0 <= 0) goto Lee
                goto L98
            Lee:
                goto L95
            Lf2:
                r1.<init>(r4, r2)
                goto L1b2
            Lf9:
                androidx.paging.HintHandler r1 = androidx.paging.PageFetcherSnapshot.access$getHintHandler$p(r1)
                goto L180
            L101:
                java.lang.stringBuilder r0 = r0.append(r4)
                goto L87
            L109:
                if (r7 == r0) goto L10e
                goto Lb8
            L10e:
                goto Lb7
            L112:
                int r0 = r0 % r1
                goto Le9
            L118:
                java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
                goto L39
            L120:
                androidx.paging.PagingSource r0 = r0.getPagingSource$paging_common_release()
                goto L7f
            L128:
                goto Lc5
            L12b:
                goto Ld5
            L12f:
                kotlin.coroutines.Continuation r4 = (kotlin.coroutines.Continuation) r4
                goto L149
            L135:
                java.lang.object r7 = kotlinx.coroutines.flow.FlowKt.firstOrNull(r7, r1, r4)
                goto L109
            L13d:
                r3 = 3
                goto L1aa
            L142:
                r1 = 30
                goto L22
            L149:
                r6.label = r3
                goto L135
            L14f:
                r4.<init>(r5)
                goto L120
            L156:
                kotlinx.coroutines.flow.Flow r1 = r1.hintFor(r4)
                goto L173
            L15e:
                r1.log(r3, r7, r2)
            L161:
                goto L74
            L165:
                r3 = 1
                goto L16a
            L16a:
                if (r1 != 0) goto L16f
                goto Ld1
            L16f:
                goto L1b8
            L173:
                r7[r3] = r1
                goto L5a
            L179:
                r6.invoke()
            L17c:
                goto L1a4
            L180:
                androidx.paging.LoadType r4 = androidx.paging.LoadType.PREPEND
                goto L156
            L186:
                java.lang.stringBuilder r4 = new java.lang.stringBuilder
                goto L68
            L18c:
                androidx.paging.PageFetcherSnapshot<Key, Value> r1 = r6.this$0
                goto L3f
            L192:
                r6.<init>(r7)
                goto Ld0
            L199:
                r7[r4] = r1
                goto L54
            L19f:
                r4 = r6
                goto L12f
            L1a4:
                kotlin.Unit r6 = kotlin.Unit.INSTANCE
                goto Lc
            L1aa:
                bool r4 = r1.isConsolegable(r3)
                goto L11
            L1b2:
                kotlin.jvm.functions.Function2 r1 = (kotlin.jvm.functions.Function2) r1
                goto L19f
            L1b8:
                if (r1 == r3) goto L1bd
                goto L50
            L1bd:
                goto Ldc
            L1c1:
                java.lang.string r7 = r7.tostring()
                goto L15e
        }
    }

    /* JADX INFO: renamed from: androidx.paging.PageFetcherSnapshot$startConsumingHints$2 */
    @kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "Key", "", "Value", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshot$startConsumingHints$2", m533f = "PageFetcherSnapshot.kt", m534i = {0, 0}, m535l = {646, 233}, m536m = "invokeSuspend", m537n = {"this_$iv", "$this$withLock_u24default$iv$iv"}, m538s = {"L$0", "L$1"})
    static readonly class C07432 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
        java.lang.object L$0;
        java.lang.object L$1;
        java.lang.object L$2;
        int label;
        readonly /* synthetic */ androidx.paging.PageFetcherSnapshot<Key, Value> this$0;

        C07432(androidx.paging.PageFetcherSnapshot<Key, Value> r1, kotlin.coroutines.Continuation<androidx.paging.PageFetcherSnapshot.C07432> r2) {
                r0 = this;
                goto Lc
            L4:
                goto Lf
            L7:
                return
            L8:
                goto L4
            Lc:
                goto L8
            Lf:
                goto L1a
            L13:
                r0.<init>(r1, r2)
                goto L7
            L1a:
                r0.this$0 = r1
                goto L20
            L20:
                r1 = 2
                goto L13
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r1, kotlin.coroutines.Continuation<object> r2) {
                r0 = this;
                goto L25
            L4:
                r1.<init>(r0, r2)
                goto L1a
            Lb:
                androidx.paging.PageFetcherSnapshot<Key, Value> r0 = r0.this$0
                goto L4
            L11:
                androidx.paging.PageFetcherSnapshot$startConsumingHints$2 r1 = new androidx.paging.PageFetcherSnapshot$startConsumingHints$2
                goto Lb
            L17:
                goto L28
            L1a:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L20
            L20:
                return r1
            L21:
                goto L17
            L25:
                goto L21
            L28:
                goto L11
        }

        @Override // kotlin.jvm.functions.Function2
        public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
                r0 = this;
                goto L4
            L4:
                goto Lc
            L7:
                goto L21
            Lb:
                return r0
            Lc:
                goto L10
            L10:
                goto L7
            L13:
                java.lang.object r0 = r0.invoke2(r1, r2)
                goto Lb
            L1b:
                kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
                goto L13
            L21:
                kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
                goto L1b
        }

        /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
        public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
                r0 = this;
                goto L22
            L4:
                androidx.paging.PageFetcherSnapshot$startConsumingHints$2 r0 = (androidx.paging.PageFetcherSnapshot.C07432) r0
                goto L29
            La:
                return r0
            Lb:
                goto Lf
            Lf:
                goto L25
            L12:
                kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
                goto L4
            L1a:
                java.lang.object r0 = r0.invokeSuspend(r1)
                goto La
            L22:
                goto Lb
            L25:
                goto L12
            L29:
                kotlin.Unit r1 = kotlin.Unit.INSTANCE
                goto L1a
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r8) {
                r7 = this;
                goto Lc0
            L4:
                java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
                goto Lb3
            La:
                java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
                goto L5d
            L12:
                r4 = 0
                goto L63
            L17:
                r7.label = r2
                goto L30
            L1d:
                androidx.paging.PageFetcherSnapshotState$Holder r5 = androidx.paging.PageFetcherSnapshot.access$getStateHolder$p(r1)
                goto Lff
            L25:
                r7.L$2 = r4
                goto L17
            L2b:
                throw r7
            L2c:
                goto L132
            L30:
                java.lang.object r7 = androidx.paging.PageFetcherSnapshot.access$collectAsGenerationalobjectportHints(r1, r8, r3, r5)
                goto L83
            L38:
                goto L11b
            L3b:
                goto La
            L3f:
                r7.L$1 = r8
                goto L8c
            L45:
                r6 = r7
                goto L77
            L4a:
                androidx.paging.PageFetcherSnapshot<Key, Value> r1 = r7.this$0
                goto L1d
            L50:
                r0 = 22
                goto Lf8
            L57:
                androidx.paging.LoadType r3 = androidx.paging.LoadType.PREPEND
                goto L72
            L5d:
                int r1 = r7.label
                goto L107
            L63:
                if (r1 != 0) goto L68
                goto Ld5
            L68:
                goto L9b
            L6c:
                kotlinx.coroutines.sync.Mutex r3 = (kotlinx.coroutines.sync.Mutex) r3
                goto Lf2
            L72:
                r5 = r7
                goto L163
            L77:
                kotlin.coroutines.Continuation r6 = (kotlin.coroutines.Continuation) r6
                goto Lc7
            L7d:
                java.lang.object r3 = r7.L$1
                goto L6c
            L83:
                if (r7 == r0) goto L88
                goto L13f
            L88:
                goto L13e
            L8c:
                r7.L$2 = r1
                goto Lec
            L92:
                if (r0 <= 0) goto L97
                goto L3b
            L97:
                goto L38
            L9b:
                if (r1 != r3) goto La0
                goto L2c
            La0:
                goto Laa
            La4:
                int r0 = r0 + r1
                goto Ld9
            Laa:
                if (r1 == r2) goto Laf
                goto L16f
            Laf:
                goto L143
            Lb3:
                java.lang.string r8 = "call to 'resume' before 'invoke' with coroutine"
                goto Lb9
            Lb9:
                r7.<init>(r8)
                goto L2b
            Lc0:
                goto Le8
            Lc3:
                goto L50
            Lc7:
                r7.L$0 = r5
                goto L3f
            Lcd:
                androidx.paging.PageFetcherSnapshotState$Holder r5 = (androidx.paging.PageFetcherSnapshotState.Holder) r5
                goto L113
            Ld3:
                goto L182
            Ld5:
                goto L10c
            Ld9:
                int r0 = r0 % r1
                goto L92
            Ldf:
                r7.L$1 = r4
                goto L25
            Le5:
                goto L3b
            Le8:
                goto L160
            Lec:
                r7.label = r3
                goto L173
            Lf2:
                java.lang.object r5 = r7.L$0
                goto Lcd
            Lf8:
                r1 = 29
                goto La4
            Lff:
                kotlinx.coroutines.sync.Mutex r8 = androidx.paging.PageFetcherSnapshotState.Holder.access$getLock$p(r5)
                goto L45
            L107:
                r2 = 2
                goto L169
            L10c:
                kotlin.ResultKt.throwOnFailure(r8)
                goto L4a
            L113:
                kotlin.ResultKt.throwOnFailure(r8)
                goto Ld3
            L11a:
                throw r7
            L11b:
                goto Le5
            L11f:
                kotlin.Unit r7 = kotlin.Unit.INSTANCE
                goto L14a
            L125:
                r3.unlock(r4)
                goto L57
            L12c:
                r7.L$0 = r4
                goto Ldf
            L132:
                java.lang.object r1 = r7.L$2
                goto L138
            L138:
                androidx.paging.PageFetcherSnapshot r1 = (androidx.paging.PageFetcherSnapshot) r1
                goto L7d
            L13e:
                return r0
            L13f:
                goto L11f
            L143:
                kotlin.ResultKt.throwOnFailure(r8)
                goto L16e
            L14a:
                return r7
            L14b:
                r7 = move-exception
                goto L159
            L150:
                if (r3 == r0) goto L155
                goto L17d
            L155:
                goto L17b
            L159:
                r3.unlock(r4)
                goto L11a
            L160:
                goto Lc3
            L163:
                kotlin.coroutines.Continuation r5 = (kotlin.coroutines.Continuation) r5
                goto L12c
            L169:
                r3 = 1
                goto L12
            L16e:
                goto L13f
            L16f:
                goto L4
            L173:
                java.lang.object r3 = r8.lock(r4, r6)
                goto L150
            L17b:
                goto L88
            L17d:
                goto L181
            L181:
                r3 = r8
            L182:
                androidx.paging.PageFetcherSnapshotState r8 = androidx.paging.PageFetcherSnapshotState.Holder.access$getState$p(r5)     // Catch: java.lang.Exception -> L14b
                kotlinx.coroutines.flow.Flow r8 = r8.consumePrependGenerationIdAsFlow()     // Catch: java.lang.Exception -> L14b
                goto L125
        }
    }

    /* JADX INFO: renamed from: androidx.paging.PageFetcherSnapshot$startConsumingHints$3 */
    @kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "Key", "", "Value", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshot$startConsumingHints$3", m533f = "PageFetcherSnapshot.kt", m534i = {0, 0}, m535l = {646, 238}, m536m = "invokeSuspend", m537n = {"this_$iv", "$this$withLock_u24default$iv$iv"}, m538s = {"L$0", "L$1"})
    static readonly class C07443 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
        java.lang.object L$0;
        java.lang.object L$1;
        java.lang.object L$2;
        int label;
        readonly /* synthetic */ androidx.paging.PageFetcherSnapshot<Key, Value> this$0;

        C07443(androidx.paging.PageFetcherSnapshot<Key, Value> r1, kotlin.coroutines.Continuation<androidx.paging.PageFetcherSnapshot.C07443> r2) {
                r0 = this;
                goto L4
            L4:
                goto L21
            L7:
                goto L12
            Lb:
                r0.<init>(r1, r2)
                goto L20
            L12:
                r0.this$0 = r1
                goto L1b
            L18:
                goto L7
            L1b:
                r1 = 2
                goto Lb
            L20:
                return
            L21:
                goto L18
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r1, kotlin.coroutines.Continuation<object> r2) {
                r0 = this;
                goto L1c
            L4:
                androidx.paging.PageFetcherSnapshot$startConsumingHints$3 r1 = new androidx.paging.PageFetcherSnapshot$startConsumingHints$3
                goto L23
            La:
                r1.<init>(r0, r2)
                goto L16
            L11:
                return r1
            L12:
                goto L29
            L16:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L11
            L1c:
                goto L12
            L1f:
                goto L4
            L23:
                androidx.paging.PageFetcherSnapshot<Key, Value> r0 = r0.this$0
                goto La
            L29:
                goto L1f
        }

        @Override // kotlin.jvm.functions.Function2
        public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
                r0 = this;
                goto L20
            L4:
                return r0
            L5:
                goto L17
            L9:
                java.lang.object r0 = r0.invoke2(r1, r2)
                goto L4
            L11:
                kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
                goto L9
            L17:
                goto L23
            L1a:
                kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
                goto L11
            L20:
                goto L5
            L23:
                goto L1a
        }

        /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
        public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
                r0 = this;
                goto L22
            L4:
                androidx.paging.PageFetcherSnapshot$startConsumingHints$3 r0 = (androidx.paging.PageFetcherSnapshot.C07443) r0
                goto L29
            La:
                return r0
            Lb:
                goto L1f
            Lf:
                kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
                goto L4
            L17:
                java.lang.object r0 = r0.invokeSuspend(r1)
                goto La
            L1f:
                goto L25
            L22:
                goto Lb
            L25:
                goto Lf
            L29:
                kotlin.Unit r1 = kotlin.Unit.INSTANCE
                goto L17
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r8) {
                r7 = this;
                goto L17e
            L4:
                kotlin.Unit r7 = kotlin.Unit.INSTANCE
                goto L128
            La:
                if (r1 != r3) goto Lf
                goto L81
            Lf:
                goto L160
            L13:
                androidx.paging.PageFetcherSnapshotState$Holder r5 = androidx.paging.PageFetcherSnapshot.access$getStateHolder$p(r1)
                goto L10c
            L1b:
                int r0 = r0 % r1
                goto L169
            L21:
                r7.L$0 = r5
                goto L85
            L27:
                r7.L$2 = r1
                goto Ld0
            L2d:
                androidx.paging.PageFetcherSnapshot<Key, Value> r1 = r7.this$0
                goto L13
            L33:
                r2 = 2
                goto L73
            L38:
                r7.L$2 = r4
                goto L119
            L3e:
                if (r1 != 0) goto L43
                goto L102
            L43:
                goto La
            L47:
                r1 = 17
                goto Lf5
            L4e:
                kotlin.ResultKt.throwOnFailure(r8)
                goto L101
            L55:
                androidx.paging.LoadType r3 = androidx.paging.LoadType.APPEND
                goto Lf0
            L5b:
                java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
                goto L140
            L61:
                java.lang.object r3 = r7.L$1
                goto Lb1
            L67:
                kotlin.coroutines.Continuation r5 = (kotlin.coroutines.Continuation) r5
                goto La5
            L6d:
                androidx.paging.PageFetcherSnapshot r1 = (androidx.paging.PageFetcherSnapshot) r1
                goto L61
            L73:
                r3 = 1
                goto Ld6
            L78:
                java.lang.object r7 = androidx.paging.PageFetcherSnapshot.access$collectAsGenerationalobjectportHints(r1, r8, r3, r5)
                goto L12e
            L80:
                throw r7
            L81:
                goto L11f
            L85:
                r7.L$1 = r8
                goto L27
            L8b:
                goto L133
            L8d:
                goto L153
            L91:
                androidx.paging.PageFetcherSnapshotState$Holder r5 = (androidx.paging.PageFetcherSnapshotState.Holder) r5
                goto L4e
            L97:
                kotlin.ResultKt.throwOnFailure(r8)
                goto L2d
            L9e:
                r3.unlock(r4)
                goto L172
            La5:
                r7.L$0 = r4
                goto Lab
            Lab:
                r7.L$1 = r4
                goto L38
            Lb1:
                kotlinx.coroutines.sync.Mutex r3 = (kotlinx.coroutines.sync.Mutex) r3
                goto Lfb
            Lb7:
                return r0
            Lb8:
                goto L4
            Lbc:
                java.lang.object r3 = r8.lock(r4, r6)
                goto L137
            Lc4:
                r6 = r7
                goto L14d
            Lc9:
                goto L173
            Lcc:
                goto L185
            Ld0:
                r7.label = r3
                goto Lbc
            Ld6:
                r4 = 0
                goto L3e
            Ldb:
                r3.unlock(r4)
                goto L55
            Le2:
                kotlin.ResultKt.throwOnFailure(r8)
                goto L114
            Le9:
                r7.<init>(r8)
                goto L80
            Lf0:
                r5 = r7
                goto L67
            Lf5:
                int r0 = r0 + r1
                goto L1b
            Lfb:
                java.lang.object r5 = r7.L$0
                goto L91
            L101:
                goto L154
            L102:
                goto L97
            L106:
                int r1 = r7.label
                goto L33
            L10c:
                kotlinx.coroutines.sync.Mutex r8 = androidx.paging.PageFetcherSnapshotState.Holder.access$getLock$p(r5)
                goto Lc4
            L114:
                goto Lb8
            L115:
                goto L5b
            L119:
                r7.label = r2
                goto L78
            L11f:
                java.lang.object r1 = r7.L$2
                goto L6d
            L125:
                goto L181
            L128:
                return r7
            L129:
                r7 = move-exception
                goto L9e
            L12e:
                if (r7 == r0) goto L133
                goto Lb8
            L133:
                goto Lb7
            L137:
                if (r3 == r0) goto L13c
                goto L8d
            L13c:
                goto L8b
            L140:
                java.lang.string r8 = "call to 'resume' before 'invoke' with coroutine"
                goto Le9
            L146:
                goto Lcc
            L149:
                goto L125
            L14d:
                kotlin.coroutines.Continuation r6 = (kotlin.coroutines.Continuation) r6
                goto L21
            L153:
                r3 = r8
            L154:
                androidx.paging.PageFetcherSnapshotState r8 = androidx.paging.PageFetcherSnapshotState.Holder.access$getState$p(r5)     // Catch: java.lang.Exception -> L129
                kotlinx.coroutines.flow.Flow r8 = r8.consumeAppendGenerationIdAsFlow()     // Catch: java.lang.Exception -> L129
                goto Ldb
            L160:
                if (r1 == r2) goto L165
                goto L115
            L165:
                goto Le2
            L169:
                if (r0 <= 0) goto L16e
                goto Lcc
            L16e:
                goto Lc9
            L172:
                throw r7
            L173:
                goto L146
            L177:
                r0 = 15
                goto L47
            L17e:
                goto L149
            L181:
                goto L177
            L185:
                java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
                goto L106
        }
    }

    public PageFetcherSnapshot(Key r2, androidx.paging.PagingSource<Key, Value> r3, androidx.paging.PagingConfig r4, kotlinx.coroutines.flow.Flow<kotlin.Unit> r5, androidx.paging.RemoteMediatorConnection<Key, Value> r6, androidx.paging.PagingState<Key, Value> r7, kotlin.jvm.functions.Function0<kotlin.Unit> r8) {
            r1 = this;
            goto Lf2
        L4:
            if (r2 != r5) goto L9
            goto L41
        L9:
            goto Lc1
        Ld:
            kotlinx.coroutines.flow.Flow r2 = kotlinx.coroutines.flow.FlowKt.onStart(r2, r3)
            goto L4a
        L15:
            androidx.paging.PageFetcherSnapshotState$Holder r2 = new androidx.paging.PageFetcherSnapshotState$Holder
            goto L150
        L1b:
            r3.<init>(r1, r5)
            goto L126
        L22:
            r2 = -2
            goto L95
        L27:
            java.lang.string r0 = "retryFlow"
            goto La0
        L2d:
            java.lang.IllegalArgumentException r1 = new java.lang.IllegalArgumentException
            goto L9a
        L33:
            java.lang.string r0 = "jumpCallback"
            goto L6c
        L39:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)
            goto L27
        L40:
            throw r1
        L41:
            goto L88
        L45:
            return
        L46:
            goto L11d
        L4a:
            r1.pageEventFlow = r2
            goto L45
        L50:
            kotlin.jvm.functions.Function2 r3 = (kotlin.jvm.functions.Function2) r3
            goto Ld
        L56:
            r1.pageEventChCollected = r2
            goto L22
        L5c:
            r1.pageEventChannelFlowJob = r2
            goto L101
        L62:
            r2 = 1
            goto L165
        L67:
            goto L41
        L68:
            goto L2d
        L6c:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r8, r0)
            goto L12c
        L73:
            kotlinx.coroutines.flow.Flow r2 = androidx.paging.CancelableChannelFlowKt.cancelableChannelFlow(r2, r3)
            goto L7b
        L7b:
            androidx.paging.PageFetcherSnapshot$pageEventFlow$2 r3 = new androidx.paging.PageFetcherSnapshot$pageEventFlow$2
            goto Lad
        L81:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
            goto Lcf
        L88:
            androidx.paging.HintHandler r2 = new androidx.paging.HintHandler
            goto Lba
        L8e:
            r2.<init>(r3)
            goto L56
        L95:
            r3 = 6
            goto Le7
        L9a:
            java.lang.string r2 = "PagingConfig.jumpThreshold was set, but the associated PagingSource has not marked support for jumps by overriding PagingSource.jumpingSupported to true."
            goto Lf9
        La0:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r5, r0)
            goto L33
        La7:
            r1.remoteMediatorConnection = r6
            goto L107
        Lad:
            r3.<init>(r1, r5)
            goto L50
        Lb4:
            java.util.concurrent.atomic.Atomicbool r2 = new java.util.concurrent.atomic.Atomicbool
            goto L13f
        Lba:
            r2.<init>()
            goto Ldb
        Lc1:
            bool r2 = r3.getJumpingSupported()
            goto L114
        Lc9:
            r1.initialKey = r2
            goto L120
        Lcf:
            java.lang.string r0 = "config"
            goto L39
        Ld5:
            r1.config = r4
            goto Lec
        Ldb:
            r1.hintHandler = r2
            goto Lb4
        Le1:
            r1.stateHolder = r2
            goto L62
        Le7:
            r5 = 0
            goto L15d
        Lec:
            r1.retryFlow = r5
            goto La7
        Lf2:
            goto L46
        Lf5:
            goto L157
        Lf9:
            java.lang.string r2 = r2.tostring()
            goto L10d
        L101:
            kotlinx.coroutines.Job r2 = (kotlinx.coroutines.Job) r2
            goto L139
        L107:
            r1.previousPagingState = r7
            goto L133
        L10d:
            r1.<init>(r2)
            goto L40
        L114:
            if (r2 != 0) goto L119
            goto L68
        L119:
            goto L67
        L11d:
            goto Lf5
        L120:
            r1.pagingSource = r3
            goto Ld5
        L126:
            kotlin.jvm.functions.Function2 r3 = (kotlin.jvm.functions.Function2) r3
            goto L73
        L12c:
            r1.<init>()
            goto Lc9
        L133:
            r1.jumpCallback = r8
            goto L16d
        L139:
            androidx.paging.PageFetcherSnapshot$pageEventFlow$1 r3 = new androidx.paging.PageFetcherSnapshot$pageEventFlow$1
            goto L1b
        L13f:
            r3 = 0
            goto L8e
        L144:
            r1.pageEventCh = r2
            goto L15
        L14a:
            r5 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L4
        L150:
            r2.<init>(r4)
            goto Le1
        L157:
            java.lang.string r0 = "pagingSource"
            goto L81
        L15d:
            kotlinx.coroutines.channels.Channel r2 = kotlinx.coroutines.channels.ChannelKt.Channel$default(r2, r5, r5, r3, r5)
            goto L144
        L165:
            kotlinx.coroutines.CompletableJob r2 = kotlinx.coroutines.JobKt.Job$default(r5, r2, r5)
            goto L5c
        L16d:
            int r2 = r4.jumpThreshold
            goto L14a
    }

    public /* synthetic */ PageFetcherSnapshot(java.lang.object r2, androidx.paging.PagingSource r3, androidx.paging.PagingConfig r4, kotlinx.coroutines.flow.Flow r5, androidx.paging.RemoteMediatorConnection r6, androidx.paging.PagingState r7, kotlin.jvm.functions.Function0 r8, int r9, kotlin.jvm.internal.DefaultConstructorMarker r10) {
            r1 = this;
            goto L39
        L4:
            kotlin.jvm.functions.Function0 r8 = (kotlin.jvm.functions.Function0) r8
        L6:
            goto L43
        La:
            r6 = r0
        Lb:
            goto L5c
        Lf:
            if (r9 != 0) goto L14
            goto L6
        L14:
            goto L4a
        L18:
            r0 = 0
            goto L30
        L1d:
            r7 = r0
        L1e:
            goto L56
        L22:
            return
        L23:
            goto L40
        L27:
            if (r10 != 0) goto L2c
            goto L1e
        L2c:
            goto L1d
        L30:
            if (r10 != 0) goto L35
            goto Lb
        L35:
            goto La
        L39:
            goto L23
        L3c:
            goto L50
        L40:
            goto L3c
        L43:
            r1.<init>(r2, r3, r4, r5, r6, r7, r8)
            goto L22
        L4a:
            androidx.paging.PageFetcherSnapshot$1 r8 = androidx.paging.PageFetcherSnapshot.C07311.INSTANCE
            goto L4
        L50:
            r10 = r9 & 16
            goto L18
        L56:
            r9 = r9 & 64
            goto Lf
        L5c:
            r10 = r9 & 32
            goto L27
    }

    public static readonly /* synthetic */ java.lang.object access$collectAsGenerationalobjectportHints(androidx.paging.PageFetcherSnapshot r0, kotlinx.coroutines.flow.Flow r1, androidx.paging.LoadType r2, kotlin.coroutines.Continuation r3) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r0.collectAsGenerationalobjectportHints(r1, r2, r3)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static readonly /* synthetic */ java.lang.object access$doInitialLoad(androidx.paging.PageFetcherSnapshot r0, kotlin.coroutines.Continuation r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.object r0 = r0.doInitialLoad(r1)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static readonly /* synthetic */ java.lang.object access$doLoad(androidx.paging.PageFetcherSnapshot r0, androidx.paging.LoadType r1, androidx.paging.GenerationalobjectportHint r2, kotlin.coroutines.Continuation r3) {
            goto Lc
        L4:
            java.lang.object r0 = r0.doLoad(r1, r2, r3)
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

    public static readonly /* synthetic */ androidx.paging.PagingConfig access$getConfig$p(androidx.paging.PageFetcherSnapshot r0) {
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
            androidx.paging.PagingConfig r0 = r0.config
            goto Lb
    }

    public static readonly /* synthetic */ androidx.paging.HintHandler access$getHintHandler$p(androidx.paging.PageFetcherSnapshot r0) {
            goto La
        L4:
            androidx.paging.HintHandler r0 = r0.hintHandler
            goto L14
        La:
            goto L15
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            return r0
        L15:
            goto L11
    }

    public static readonly /* synthetic */ kotlin.jvm.functions.Function0 access$getJumpCallback$p(androidx.paging.PageFetcherSnapshot r0) {
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
            kotlin.jvm.functions.Function0<kotlin.Unit> r0 = r0.jumpCallback
            goto Lb
    }

    public static readonly /* synthetic */ kotlinx.coroutines.channels.Channel access$getPageEventCh$p(androidx.paging.PageFetcherSnapshot r0) {
            goto L12
        L4:
            kotlinx.coroutines.channels.Channel<androidx.paging.PageEvent<Value>> r0 = r0.pageEventCh
            goto Ld
        La:
            goto L15
        Ld:
            return r0
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L4
    }

    public static readonly /* synthetic */ java.util.concurrent.atomic.Atomicbool access$getPageEventChCollected$p(androidx.paging.PageFetcherSnapshot r0) {
            goto L4
        L4:
            goto L15
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.util.concurrent.atomic.Atomicbool r0 = r0.pageEventChCollected
            goto L14
        L14:
            return r0
        L15:
            goto Lb
    }

    public static readonly /* synthetic */ androidx.paging.PagingState access$getPreviousPagingState$p(androidx.paging.PageFetcherSnapshot r0) {
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
            androidx.paging.PagingState<Key, Value> r0 = r0.previousPagingState
            goto Le
    }

    public static readonly /* synthetic */ kotlinx.coroutines.flow.Flow access$getRetryFlow$p(androidx.paging.PageFetcherSnapshot r0) {
            goto L12
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            kotlinx.coroutines.flow.Flow<kotlin.Unit> r0 = r0.retryFlow
            goto L4
        L12:
            goto L5
        L15:
            goto Lc
    }

    public static readonly /* synthetic */ androidx.paging.PageFetcherSnapshotState.Holder access$getStateHolder$p(androidx.paging.PageFetcherSnapshot r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L16
        L10:
            androidx.paging.PageFetcherSnapshotState$Holder<Key, Value> r0 = r0.stateHolder
            goto Lb
        L16:
            goto L7
    }

    public static readonly /* synthetic */ java.lang.object access$retryLoadError(androidx.paging.PageFetcherSnapshot r0, androidx.paging.LoadType r1, androidx.paging.objectportHint r2, kotlin.coroutines.Continuation r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r0.retryLoadError(r1, r2, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static readonly /* synthetic */ java.lang.object access$setError(androidx.paging.PageFetcherSnapshot r0, androidx.paging.PageFetcherSnapshotState r1, androidx.paging.LoadType r2, androidx.paging.LoadState.Error r3, kotlin.coroutines.Continuation r4) {
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
            java.lang.object r0 = r0.setError(r1, r2, r3, r4)
            goto L4
    }

    public static readonly /* synthetic */ java.lang.object access$setLoading(androidx.paging.PageFetcherSnapshot r0, androidx.paging.PageFetcherSnapshotState r1, androidx.paging.LoadType r2, kotlin.coroutines.Continuation r3) {
            goto L14
        L4:
            java.lang.object r0 = r0.setLoading(r1, r2, r3)
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

    public static readonly /* synthetic */ void access$startConsumingHints(androidx.paging.PageFetcherSnapshot r0, kotlinx.coroutines.CoroutineScope r1) {
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
            r0.startConsumingHints(r1)
            goto Lb
    }

    private readonly java.lang.object CollectAsGenerationalobjectportHints(kotlinx.coroutines.flow.Flow<java.lang.int> r3, androidx.paging.LoadType r4, kotlin.coroutines.Continuation<kotlin.Unit> r5) {
            r2 = this;
            goto La2
        L4:
            r0 = 29
            goto L7e
        Lb:
            return r2
        Lc:
            goto L61
        L10:
            kotlin.jvm.functions.Function3 r0 = (kotlin.jvm.functions.Function3) r0
            goto L3b
        L16:
            r1 = 0
            goto L52
        L1b:
            kotlinx.coroutines.flow.FlowCollector r0 = (kotlinx.coroutines.flow.FlowCollector) r0
            goto L59
        L21:
            java.lang.object r3 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto Laf
        L29:
            androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$3 r0 = new androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$3
            goto L8d
        L2f:
            goto Lc
        L32:
            goto L43
        L36:
            return r2
        L37:
            goto L68
        L3b:
            kotlinx.coroutines.flow.Flow r3 = androidx.paging.FlowExtKt.simpleRunningReduce(r3, r0)
            goto L9a
        L43:
            androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$$inlined$simpleFlatDictionaryLatest$1 r0 = new androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$$inlined$simpleFlatDictionaryLatest$1
            goto L16
        L49:
            if (r0 <= 0) goto L4e
            goto L32
        L4e:
            goto L2f
        L52:
            r0.<init>(r1, r2, r4)
            goto Lb8
        L59:
            java.lang.object r2 = r3.collect(r0, r5)
            goto L21
        L61:
            goto L32
        L64:
            goto L75
        L68:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto Lb
        L6e:
            r0.<init>(r2, r4)
            goto L1b
        L75:
            goto La5
        L78:
            int r0 = r0 % r1
            goto L49
        L7e:
            r1 = 19
            goto L94
        L85:
            kotlinx.coroutines.flow.Flow r3 = androidx.paging.FlowExtKt.simpleTransformLatest(r3, r0)
            goto L29
        L8d:
            r0.<init>(r4, r1)
            goto L10
        L94:
            int r0 = r0 + r1
            goto L78
        L9a:
            kotlinx.coroutines.flow.Flow r3 = kotlinx.coroutines.flow.FlowKt.conflate(r3)
            goto La9
        La2:
            goto L64
        La5:
            goto L4
        La9:
            androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$4 r0 = new androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$4
            goto L6e
        Laf:
            if (r2 == r3) goto Lb4
            goto L37
        Lb4:
            goto L36
        Lb8:
            kotlin.jvm.functions.Function3 r0 = (kotlin.jvm.functions.Function3) r0
            goto L85
    }

    private readonly java.lang.object DoInitialLoad(kotlin.coroutines.Continuation<kotlin.Unit> r13) {
            r12 = this;
            goto L3e
        L4:
            java.lang.object r2 = r0.L$1
            goto L5d1
        La:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L537
        L12:
            r0.L$1 = r5
            goto L762
        L18:
            r2 = r12
            goto L23
        L1d:
            kotlinx.coroutines.sync.Mutex r12 = (kotlinx.coroutines.sync.Mutex) r12
            goto L21f
        L23:
            r12 = r13
        L24:
            kotlin.Unit r13 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L60
            goto L27f
        L2a:
            r0.log(r4, r13, r5)
        L2d:
            goto L7cf
        L31:
            r12.unlock(r5)
            goto L210
        L38:
            androidx.paging.PageFetcherSnapshot r12 = (androidx.paging.PageFetcherSnapshot) r12
            goto Ld3
        L3e:
            goto L518
        L41:
            goto L26c
        L45:
            int r13 = r13 - r2
            goto L567
        L4a:
            if (r13 != 0) goto L4f
            goto L7d9
        L4f:
            goto L22d
        L53:
            Key r7 = r2.initialKey
            goto L10e
        L59:
            r0.L$2 = r13
            goto Lce
        L5f:
            goto L24
        L60:
            r13 = move-exception
            goto L2cd
        L65:
            if (r0 != 0) goto L6a
            goto L4e7
        L6a:
            goto L757
        L6e:
            return r12
        L6f:
            r12 = move-exception
            goto L307
        L74:
            java.lang.object r13 = r13.load(r12, r0)
            goto L64a
        L7c:
            androidx.paging.PageFetcherSnapshot r6 = (androidx.paging.PageFetcherSnapshot) r6
            goto L82
        L82:
            kotlin.ResultKt.throwOnFailure(r13)
            goto Le1
        L89:
            if (r0 != 0) goto L8e
            goto L7d2
        L8e:
            goto L72b
        L92:
            androidx.paging.PagingSource$LoadResult r2 = (androidx.paging.PagingSource.LoadResult) r2
            goto L2e5
        L98:
            java.lang.object r13 = r0.result
            goto La
        L9e:
            goto L368
        La0:
            goto L70d
        La4:
            r12.requestLoad(r0, r13)
            goto L676
        Lab:
            java.lang.object r12 = r2.getNextKey()
            goto L4ce
        Lb3:
            kotlinx.coroutines.sync.Mutex r12 = (kotlinx.coroutines.sync.Mutex) r12
            goto L3fe
        Lb9:
            androidx.paging.PagingSource$LoadResult r3 = (androidx.paging.PagingSource.LoadResult) r3
            goto L65a
        Lbf:
            androidx.paging.PagingSource<Key, Value> r7 = r2.pagingSource
            goto L5c4
        Lc5:
            if (r7 == r1) goto Lca
            goto L697
        Lca:
            goto L695
        Lce:
            r6 = 1
            goto L129
        Ld3:
            kotlin.ResultKt.throwOnFailure(r13)
            goto L4f8
        Lda:
            r0.<init>(r12, r13)
        Ldd:
            goto L98
        Le1:
            r13 = r12
            goto L317
        Le6:
            if (r3 != 0) goto Leb
            goto L334
        Leb:
            goto L3dd
        Lef:
            java.lang.string r7 = " on "
            goto L4d7
        Lf5:
            kotlinx.coroutines.sync.Mutex r12 = androidx.paging.PageFetcherSnapshotState.Holder.access$getLock$p(r2)
            goto L273
        Lfd:
            r13 = 5
            goto L25b
        L102:
            Key r2 = r7.initialKey
            goto L7bb
        L108:
            r0.L$2 = r2
            goto L3cf
        L10e:
            java.lang.stringBuilder r6 = r6.append(r7)
            goto Lef
        L116:
            r0.L$1 = r13
            goto L6b5
        L11c:
            androidx.paging.PagingSource$LoadResult$Page r2 = (androidx.paging.PagingSource.LoadResult.Page) r2
            goto L404
        L122:
            kotlin.ResultKt.throwOnFailure(r13)
            goto L3ef
        L129:
            r0.label = r6
            goto L191
        L12f:
            goto L709
        L131:
            goto L551
        L135:
            kotlinx.coroutines.sync.Mutex r12 = (kotlinx.coroutines.sync.Mutex) r12
            kotlin.ResultKt.throwOnFailure(r13)     // Catch: java.lang.Exception -> L48f
            goto L48d
        L13e:
            java.lang.object r6 = r0.L$1
            goto L75c
        L144:
            r12 = r3
            goto L344
        L149:
            r0.L$0 = r12
            goto L116
        L14f:
            java.lang.object r2 = r0.L$2
            goto L6c1
        L155:
            java.lang.object r12 = r0.L$1
            goto L3e9
        L15b:
            if (r2 != 0) goto L160
            goto L2c1
        L160:
            goto L712
        L164:
            androidx.paging.PagingSource<Key, Value> r13 = r2.pagingSource
            goto L299
        L16a:
            if (r12 == 0) goto L16f
            goto L7d2
        L16f:
            goto L6a1
        L173:
            androidx.paging.LoadType r13 = androidx.paging.LoadType.REFRESH
            goto L5be
        L179:
            int r0 = r0 % r1
            goto L522
        L17f:
            androidx.paging.RemoteMediatorConnection<Key, Value> r12 = r0.remoteMediatorConnection
            goto L7ff
        L185:
            goto L313
        L187:
            goto L1f9
        L18b:
            java.lang.object r4 = r0.L$0
            goto L788
        L191:
            java.lang.object r6 = r13.lock(r5, r0)
            goto L771
        L199:
            androidx.paging.LoadType r12 = androidx.paging.LoadType.REFRESH
            goto L42f
        L19f:
            r12 = r2
            goto L23c
        L1a4:
            r0.L$1 = r13
            goto L5b2
        L1aa:
            r0.L$1 = r2
            goto L59
        L1b0:
            r12 = r6
            goto L435
        L1b5:
            androidx.paging.PageFetcherSnapshotState$Holder<Key, Value> r2 = r7.stateHolder
            goto Lf5
        L1bb:
            java.lang.object r0 = r0.L$0
            goto L4df
        L1c1:
            if (r1 != 0) goto L1c6
            goto L4e7
        L1c6:
            goto L2d3
        L1ca:
            java.lang.IllegalStateException r12 = new java.lang.IllegalStateException
            goto L73d
        L1d0:
            r12.unlock(r5)
            goto L707
        L1d7:
            androidx.paging.LoadType r1 = androidx.paging.LoadType.REFRESH
            goto L6bb
        L1dd:
            bool r1 = r0.isConsolegable(r4)
            goto L768
        L1e5:
            kotlinx.coroutines.sync.Mutex r12 = (kotlinx.coroutines.sync.Mutex) r12
            goto L14f
        L1eb:
            java.lang.object r13 = r12.lock(r5, r0)
            goto L39b
        L1f3:
            androidx.paging.LoadType r1 = androidx.paging.LoadType.PREPEND
            goto L6e5
        L1f9:
            java.lang.object r12 = r0.L$3
            goto L1e5
        L1ff:
            r0.label = r4
            goto L7f7
        L205:
            goto L4b8
        L207:
            goto L122
        L20b:
            r13 = r12
            goto L795
        L210:
            if (r2 != 0) goto L215
            goto L268
        L215:
            goto L49b
        L219:
            androidx.paging.PageFetcherSnapshotState$Holder r2 = (androidx.paging.PageFetcherSnapshotState.Holder) r2
            goto L301
        L21f:
            java.lang.object r2 = r0.L$1
            goto L219
        L225:
            java.lang.object r7 = r6.lock(r5, r0)
            goto Lc5
        L22d:
            androidx.paging.LoadType r13 = androidx.paging.LoadType.REFRESH
            goto L102
        L233:
            if (r12 == 0) goto L238
            goto L6e8
        L238:
            goto L293
        L23c:
            androidx.paging.PagingSource$LoadResult$Page r12 = (androidx.paging.PagingSource.LoadResult.Page) r12
            goto L393
        L242:
            kotlin.ResultKt.throwOnFailure(r13)
            goto L561
        L249:
            Key r6 = r12.initialKey
            goto L685
        L24f:
            r3 = r6
            goto L3a4
        L254:
            kotlin.ResultKt.throwOnFailure(r13)
            goto L62f
        L25b:
            r0.label = r13
            goto L1eb
        L261:
            java.lang.object r12 = r0.L$3
            goto L30c
        L267:
            throw r13
        L268:
            goto L589
        L26c:
            r0 = 23
            goto L718
        L273:
            r0.L$0 = r7
            goto L50f
        L279:
            androidx.paging.PageFetcherSnapshot r4 = (androidx.paging.PageFetcherSnapshot) r4
            goto L2b9
        L27f:
            r12.unlock(r5)
            goto L199
        L286:
            bool r13 = r12.isConsolegable(r4)
            goto L3f5
        L28e:
            r4 = 7
            goto L1ff
        L293:
            androidx.paging.RemoteMediatorConnection<Key, Value> r12 = r0.remoteMediatorConnection
            goto L1f3
        L299:
            r0.L$0 = r2
            goto L12
        L29f:
            java.lang.object r12 = r0.L$0
            goto L135
        L2a5:
            java.lang.object r2 = r0.L$0
            goto L543
        L2ab:
            kotlin.Unit r12 = kotlin.Unit.INSTANCE
            goto L6e
        L2b1:
            java.lang.object r12 = r12.getNextKey()
            goto L16a
        L2b9:
            kotlin.ResultKt.throwOnFailure(r13)
            goto L635
        L2c0:
            throw r13
        L2c1:
            goto L4b0
        L2c5:
            java.lang.string r6 = r6.tostring()
            goto L322
        L2cd:
            goto L796
        L2cf:
            goto L620
        L2d3:
            int r13 = r0.label
            goto L45
        L2d9:
            bool r0 = r13 is androidx.paging.PageFetcherSnapshot.C07371
            goto L65
        L2df:
            java.lang.string r7 = "Start REFRESH with loadKey "
            goto L59f
        L2e5:
            java.lang.object r3 = r0.L$0
            goto L580
        L2eb:
            kotlinx.coroutines.sync.Mutex r6 = androidx.paging.PageFetcherSnapshotState.Holder.access$getLock$p(r2)
            goto L149
        L2f3:
            androidx.paging.PagingSource$LoadParams r12 = r2.loadParams(r12, r13)
            goto L7c9
        L2fb:
            androidx.paging.PageFetcherSnapshotState$Holder<Key, Value> r2 = r12.stateHolder
            goto L7e9
        L301:
            java.lang.object r6 = r0.L$0
            goto L7c
        L307:
            r11 = r13
            goto L20b
        L30c:
            kotlinx.coroutines.sync.Mutex r12 = (kotlinx.coroutines.sync.Mutex) r12
            goto L6ec
        L312:
            return r12
        L313:
            goto L619
        L317:
            r12 = r6
            goto L205
        L31c:
            java.lang.object r3 = r0.L$1
            goto L57a
        L322:
            r13.log(r3, r6, r5)
        L325:
            goto L164
        L329:
            bool r3 = r2.isConsolegable(r4)
            goto Le6
        L331:
            r2.log(r4, r3, r5)
        L334:
            goto L2fb
        L338:
            java.lang.object r12 = r0.L$3
            goto L7e3
        L33e:
            bool r0 = r13 is androidx.paging.PagingSource.LoadResult.Invalid
            goto L89
        L344:
            r3 = r13
        L345:
            androidx.paging.PageFetcherSnapshotState r13 = androidx.paging.PageFetcherSnapshotState.Holder.access$getState$p(r2)     // Catch: java.lang.Exception -> L48f
            androidx.paging.LoadState$Error r2 = new androidx.paging.LoadState$Error     // Catch: java.lang.Exception -> L48f
            androidx.paging.PagingSource$LoadResult$Error r3 = (androidx.paging.PagingSource.LoadResult.Error) r3     // Catch: java.lang.Exception -> L48f
            java.lang.Exception r3 = r3.getException()     // Catch: java.lang.Exception -> L48f
            r2.<init>(r3)     // Catch: java.lang.Exception -> L48f
            androidx.paging.LoadType r3 = androidx.paging.LoadType.REFRESH     // Catch: java.lang.Exception -> L48f
            r0.L$0 = r12     // Catch: java.lang.Exception -> L48f
            r0.L$1 = r5     // Catch: java.lang.Exception -> L48f
            r0.L$2 = r5     // Catch: java.lang.Exception -> L48f
            r0.L$3 = r5     // Catch: java.lang.Exception -> L48f
            r6 = 9
            r0.label = r6     // Catch: java.lang.Exception -> L48f
            java.lang.object r13 = r4.setError(r13, r3, r2, r0)     // Catch: java.lang.Exception -> L48f
            if (r13 != r1) goto L369
        L368:
            return r1
        L369:
            kotlin.Unit r13 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L48f
            goto L41d
        L36f:
            r0 = r3
        L370:
            androidx.paging.PageFetcherSnapshotState r13 = androidx.paging.PageFetcherSnapshotState.Holder.access$getState$p(r1)     // Catch: java.lang.Exception -> L678
            androidx.paging.HintHandler r1 = r0.hintHandler     // Catch: java.lang.Exception -> L678
            androidx.paging.objectportHint$Access r1 = r1.getLastAccessHint()     // Catch: java.lang.Exception -> L678
            androidx.paging.PagingState r13 = r13.currentPagingState$paging_common_release(r1)     // Catch: java.lang.Exception -> L678
            goto L6f2
        L382:
            r3 = 3
            goto L424
        L387:
            r0.L$3 = r6
            goto L6b0
        L38d:
            goto L368
        L38f:
            goto L18
        L393:
            java.lang.object r13 = r12.getPrevKey()
            goto L6fe
        L39b:
            if (r13 == r1) goto L3a0
            goto L739
        L3a0:
            goto L737
        L3a4:
            r4 = r7
        L3a5:
            androidx.paging.PageFetcherSnapshotState r13 = androidx.paging.PageFetcherSnapshotState.Holder.access$getState$p(r2)     // Catch: java.lang.Exception -> L4ed
            kotlinx.coroutines.channels.Channel<androidx.paging.PageEvent<Value>> r2 = r4.pageEventCh     // Catch: java.lang.Exception -> L4ed
            r6 = r3
            androidx.paging.PagingSource$LoadResult$Page r6 = (androidx.paging.PagingSource.LoadResult.Page) r6     // Catch: java.lang.Exception -> L4ed
            androidx.paging.LoadType r7 = androidx.paging.LoadType.REFRESH     // Catch: java.lang.Exception -> L4ed
            androidx.paging.PageEvent r13 = r13.toPageEvent$paging_common_release(r6, r7)     // Catch: java.lang.Exception -> L4ed
            r0.L$0 = r4     // Catch: java.lang.Exception -> L4ed
            r0.L$1 = r3     // Catch: java.lang.Exception -> L4ed
            r0.L$2 = r12     // Catch: java.lang.Exception -> L4ed
            r0.L$3 = r5     // Catch: java.lang.Exception -> L4ed
            r6 = 6
            r0.label = r6     // Catch: java.lang.Exception -> L4ed
            java.lang.object r13 = r2.send(r13, r0)     // Catch: java.lang.Exception -> L4ed
            if (r13 != r1) goto L3c7
            goto L368
        L3c7:
            r2 = r3
            r3 = r4
        L3c9:
            kotlin.Unit r13 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L4ed
            goto L1d0
        L3cf:
            r0.L$3 = r12
            goto Lfd
        L3d5:
            java.lang.string r13 = r12.loadResultConsole(r1, r2, r13)
            goto L2a
        L3dd:
            androidx.paging.LoadType r3 = androidx.paging.LoadType.REFRESH
            goto L249
        L3e3:
            java.lang.object r7 = r0.L$0
            goto L4a1
        L3e9:
            kotlinx.coroutines.sync.Mutex r12 = (kotlinx.coroutines.sync.Mutex) r12
            goto L2a5
        L3ef:
            androidx.paging.PageFetcherSnapshotState$Holder<Key, Value> r2 = r12.stateHolder
            goto L68d
        L3f5:
            if (r13 != 0) goto L3fa
            goto L656
        L3fa:
            goto L173
        L3fe:
            java.lang.object r2 = r0.L$1
            goto L92
        L404:
            java.lang.object r12 = r2.getPrevKey()
            goto L233
        L40c:
            int r1 = r0.label
            goto L6cd
        L412:
            r0.label = r7
            goto L225
        L418:
            r4 = r12
            goto L144
        L41d:
            r12.unlock(r5)
            goto L7a0
        L424:
            r4 = 2
            goto L749
        L429:
            androidx.paging.PageFetcherSnapshot$doInitialLoad$1 r0 = new androidx.paging.PageFetcherSnapshot$doInitialLoad$1
            goto Lda
        L42f:
            Key r13 = r2.initialKey
            goto L2f3
        L435:
            r6 = r13
        L436:
            androidx.paging.PageFetcherSnapshotState r13 = androidx.paging.PageFetcherSnapshotState.Holder.access$getState$p(r2)     // Catch: java.lang.Exception -> L4f3
            androidx.paging.LoadType r2 = androidx.paging.LoadType.REFRESH     // Catch: java.lang.Exception -> L4f3
            r8 = r6
            androidx.paging.PagingSource$LoadResult$Page r8 = (androidx.paging.PagingSource.LoadResult.Page) r8     // Catch: java.lang.Exception -> L4f3
            r9 = 0
            bool r2 = r13.insert(r9, r2, r8)     // Catch: java.lang.Exception -> L4f3
            androidx.paging.MutableLoadStateICollection r8 = r13.getSourceLoadStates$paging_common_release()     // Catch: java.lang.Exception -> L4f3
            androidx.paging.LoadType r9 = androidx.paging.LoadType.REFRESH     // Catch: java.lang.Exception -> L4f3
            androidx.paging.LoadState$NotLoading$Companion r10 = androidx.paging.LoadState.NotLoading.Companion     // Catch: java.lang.Exception -> L4f3
            androidx.paging.LoadState$NotLoading r10 = r10.getIncomplete$paging_common_release()     // Catch: java.lang.Exception -> L4f3
            androidx.paging.LoadState r10 = (androidx.paging.LoadState) r10     // Catch: java.lang.Exception -> L4f3
            r8.set(r9, r10)     // Catch: java.lang.Exception -> L4f3
            r8 = r6
            androidx.paging.PagingSource$LoadResult$Page r8 = (androidx.paging.PagingSource.LoadResult.Page) r8     // Catch: java.lang.Exception -> L4f3
            java.lang.object r8 = r8.getPrevKey()     // Catch: java.lang.Exception -> L4f3
            if (r8 != 0) goto L46f
            androidx.paging.MutableLoadStateICollection r8 = r13.getSourceLoadStates$paging_common_release()     // Catch: java.lang.Exception -> L4f3
            androidx.paging.LoadType r9 = androidx.paging.LoadType.PREPEND     // Catch: java.lang.Exception -> L4f3
            androidx.paging.LoadState$NotLoading$Companion r10 = androidx.paging.LoadState.NotLoading.Companion     // Catch: java.lang.Exception -> L4f3
            androidx.paging.LoadState$NotLoading r10 = r10.getComplete$paging_common_release()     // Catch: java.lang.Exception -> L4f3
            androidx.paging.LoadState r10 = (androidx.paging.LoadState) r10     // Catch: java.lang.Exception -> L4f3
            r8.set(r9, r10)     // Catch: java.lang.Exception -> L4f3
        L46f:
            r8 = r6
            androidx.paging.PagingSource$LoadResult$Page r8 = (androidx.paging.PagingSource.LoadResult.Page) r8     // Catch: java.lang.Exception -> L4f3
            java.lang.object r8 = r8.getNextKey()     // Catch: java.lang.Exception -> L4f3
            if (r8 != 0) goto L489
            androidx.paging.MutableLoadStateICollection r13 = r13.getSourceLoadStates$paging_common_release()     // Catch: java.lang.Exception -> L4f3
            androidx.paging.LoadType r8 = androidx.paging.LoadType.APPEND     // Catch: java.lang.Exception -> L4f3
            androidx.paging.LoadState$NotLoading$Companion r9 = androidx.paging.LoadState.NotLoading.Companion     // Catch: java.lang.Exception -> L4f3
            androidx.paging.LoadState$NotLoading r9 = r9.getComplete$paging_common_release()     // Catch: java.lang.Exception -> L4f3
            androidx.paging.LoadState r9 = (androidx.paging.LoadState) r9     // Catch: java.lang.Exception -> L4f3
            r13.set(r8, r9)     // Catch: java.lang.Exception -> L4f3
        L489:
            goto L31
        L48d:
            goto L369
        L48f:
            r13 = move-exception
            goto L185
        L494:
            kotlin.ResultKt.throwOnFailure(r13)
            goto L531
        L49b:
            androidx.paging.PagingConsoleger r12 = androidx.paging.PagingConsoleger.INSTANCE
            goto L5e2
        L4a1:
            androidx.paging.PageFetcherSnapshot r7 = (androidx.paging.PageFetcherSnapshot) r7
            goto L242
        L4a7:
            if (r2 != 0) goto L4ac
            goto L5cd
        L4ac:
            goto L6c7
        L4b0:
            bool r2 = r13 is androidx.paging.PagingSource.LoadResult.Error
            goto L4a7
        L4b6:
            goto L368
        L4b8:
            androidx.paging.PageFetcherSnapshotState r2 = androidx.paging.PageFetcherSnapshotState.Holder.access$getState$p(r2)     // Catch: java.lang.Exception -> L6f
            androidx.paging.LoadType r6 = androidx.paging.LoadType.REFRESH     // Catch: java.lang.Exception -> L6f
            r0.L$0 = r12     // Catch: java.lang.Exception -> L6f
            r0.L$1 = r13     // Catch: java.lang.Exception -> L6f
            r0.L$2 = r5     // Catch: java.lang.Exception -> L6f
            r0.label = r4     // Catch: java.lang.Exception -> L6f
            java.lang.object r2 = r12.setLoading(r2, r6, r0)     // Catch: java.lang.Exception -> L6f
            goto L6a7
        L4ce:
            if (r12 == 0) goto L4d3
            goto L7d2
        L4d3:
            goto L17f
        L4d7:
            java.lang.stringBuilder r6 = r6.append(r7)
            goto Lbf
        L4df:
            androidx.paging.PageFetcherSnapshot r0 = (androidx.paging.PageFetcherSnapshot) r0
            goto L254
        L4e5:
            goto Ldd
        L4e7:
            goto L429
        L4eb:
            goto L3c9
        L4ed:
            r13 = move-exception
            goto L12f
        L4f2:
            throw r13
        L4f3:
            r13 = move-exception
            goto L56d
        L4f8:
            goto L558
        L4fa:
            goto L155
        L4fe:
            bool r6 = r13.isConsolegable(r3)
            goto L58f
        L506:
            goto L41
        L509:
            r0.L$0 = r12
            goto L1a4
        L50f:
            r0.L$1 = r6
            goto L108
        L515:
            goto L59b
        L518:
            goto L506
        L51c:
            r0.L$0 = r12
            goto L1aa
        L522:
            if (r0 <= 0) goto L527
            goto L59b
        L527:
            goto L598
        L52b:
            r0.L$2 = r12
            goto L71f
        L531:
            goto L345
        L533:
            goto L261
        L537:
            int r2 = r0.label
            goto L382
        L53d:
            androidx.paging.PageFetcherSnapshotState$Holder r2 = (androidx.paging.PageFetcherSnapshotState.Holder) r2
            goto L13e
        L543:
            androidx.paging.PageFetcherSnapshot r2 = (androidx.paging.PageFetcherSnapshot) r2
            kotlin.ResultKt.throwOnFailure(r13)     // Catch: java.lang.Exception -> L60
            goto L5f
        L54c:
            r3 = r7
        L54d:
            goto L5a6
        L551:
            java.lang.object r12 = r0.L$3
            goto L7c3
        L557:
            r12 = r2
        L558:
            goto L660
        L55c:
            throw r12
        L55d:
            goto L29f
        L561:
            goto L436
        L563:
            goto L5b8
        L567:
            r0.label = r13
            goto L4e5
        L56d:
            r12.unlock(r5)
            goto L2c0
        L574:
            java.lang.object r2 = r0.L$2
            goto L6d3
        L57a:
            androidx.paging.PagingSource$LoadResult r3 = (androidx.paging.PagingSource.LoadResult) r3
            goto L18b
        L580:
            androidx.paging.PageFetcherSnapshot r3 = (androidx.paging.PageFetcherSnapshot) r3
            kotlin.ResultKt.throwOnFailure(r13)     // Catch: java.lang.Exception -> L4ed
            goto L4eb
        L589:
            androidx.paging.PagingConsoleger r12 = androidx.paging.PagingConsoleger.INSTANCE
            goto L286
        L58f:
            if (r6 != 0) goto L594
            goto L325
        L594:
            goto L751
        L598:
            goto L610
        L59b:
            goto L2d9
        L59f:
            r6.<init>(r7)
            goto L53
        L5a6:
            androidx.paging.RemoteMediatorConnection<Key, Value> r12 = r3.remoteMediatorConnection
            goto L77a
        L5ac:
            r0.label = r4
            goto L666
        L5b2:
            r0.L$2 = r2
            goto L6df
        L5b8:
            java.lang.object r12 = r0.L$0
            goto L38
        L5be:
            Key r2 = r7.initialKey
            goto L67d
        L5c4:
            java.lang.stringBuilder r6 = r6.append(r7)
            goto L2c5
        L5cc:
            throw r13
        L5cd:
            goto L33e
        L5d1:
            androidx.paging.PagingSource$LoadResult r2 = (androidx.paging.PagingSource.LoadResult) r2
            goto L1bb
        L5d7:
            r4 = 8
            goto L5ac
        L5dd:
            r1 = r1 & r2
            goto L1c1
        L5e2:
            bool r13 = r12.isConsolegable(r3)
            goto L4a
        L5ea:
            goto L368
        L5ec:
            goto L418
        L5f0:
            java.lang.object r2 = r0.L$2
            goto L53d
        L5f6:
            throw r13
        L610:
            goto L515
        L614:
            r7 = r12
            goto L1b0
        L619:
            r12.unlock(r5)
            goto L5cc
        L620:
            java.lang.object r12 = r0.L$2
            goto L1d
        L626:
            if (r4 == r1) goto L62b
            goto L5ec
        L62b:
            goto L5ea
        L62f:
            goto L370
        L631:
            goto L731
        L635:
            goto L3a5
        L637:
            goto L338
        L63b:
            androidx.paging.PageFetcherSnapshotState$Holder r1 = (androidx.paging.PageFetcherSnapshotState.Holder) r1
            goto L4
        L641:
            if (r0 == r1) goto L646
            goto La0
        L646:
            goto L9e
        L64a:
            if (r13 == r1) goto L64f
            goto L69d
        L64f:
            goto L69b
        L653:
            r12.log(r4, r13, r5)
        L656:
            goto L6f9
        L65a:
            java.lang.object r4 = r0.L$0
            goto L279
        L660:
            androidx.paging.PagingSource$LoadResult r13 = (androidx.paging.PagingSource.LoadResult) r13
            goto L7dd
        L666:
            java.lang.object r4 = r3.lock(r5, r0)
            goto L626
        L66e:
            kotlinx.coroutines.sync.Mutex r13 = androidx.paging.PageFetcherSnapshotState.Holder.access$getLock$p(r12)
            goto L6d9
        L676:
            goto L7d2
        L678:
            r13 = move-exception
            goto L78e
        L67d:
            java.lang.string r13 = r7.loadResultConsole(r13, r2, r5)
            goto L653
        L685:
            java.lang.string r3 = r12.loadResultConsole(r3, r6, r13)
            goto L331
        L68d:
            kotlinx.coroutines.sync.Mutex r13 = androidx.paging.PageFetcherSnapshotState.Holder.access$getLock$p(r2)
            goto L51c
        L695:
            goto L368
        L697:
            goto L614
        L69b:
            goto L368
        L69d:
            goto L557
        L6a1:
            androidx.paging.PageFetcherSnapshotState$Holder<Key, Value> r12 = r3.stateHolder
            goto L66e
        L6a7:
            if (r2 == r1) goto L6ac
            goto L38f
        L6ac:
            goto L38d
        L6b0:
            r7 = 4
            goto L412
        L6b5:
            r0.L$2 = r2
            goto L387
        L6bb:
            Key r2 = r12.initialKey
            goto L3d5
        L6c1:
            androidx.paging.PageFetcherSnapshotState$Holder r2 = (androidx.paging.PageFetcherSnapshotState.Holder) r2
            goto L31c
        L6c7:
            androidx.paging.PagingConsoleger r2 = androidx.paging.PagingConsoleger.INSTANCE
            goto L329
        L6cd:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L5dd
        L6d3:
            androidx.paging.PageFetcherSnapshotState$Holder r2 = (androidx.paging.PageFetcherSnapshotState.Holder) r2
            goto L7f1
        L6d9:
            r0.L$0 = r3
            goto L743
        L6df:
            r0.L$3 = r3
            goto L5d7
        L6e5:
            r12.requestLoad(r1, r13)
        L6e8:
            goto Lab
        L6ec:
            java.lang.object r1 = r0.L$2
            goto L63b
        L6f2:
            r12.unlock(r5)
            goto L11c
        L6f9:
            r2 = r6
            goto L54c
        L6fe:
            if (r13 != 0) goto L703
            goto L16f
        L703:
            goto L2b1
        L707:
            goto L54d
        L709:
            goto L7b4
        L70d:
            r1 = r12
            goto L783
        L712:
            androidx.paging.PageFetcherSnapshotState$Holder<Key, Value> r2 = r12.stateHolder
            goto L2eb
        L718:
            r1 = 29
            goto L79a
        L71f:
            r0.L$3 = r13
            goto L28e
        L725:
            androidx.paging.PageFetcherSnapshot$doInitialLoad$1 r0 = (androidx.paging.PageFetcherSnapshot.C07371) r0
            goto L40c
        L72b:
            androidx.paging.PagingConsoleger r0 = androidx.paging.PagingConsoleger.INSTANCE
            goto L1dd
        L731:
            java.lang.object r12 = r0.L$2
            goto Lb3
        L737:
            goto L368
        L739:
            goto L24f
        L73d:
            java.lang.string r13 = "call to 'resume' before 'invoke' with coroutine"
            goto L7ad
        L743:
            r0.L$1 = r2
            goto L52b
        L749:
            r5 = 0
            switch(r2) {
                case 0: goto L207;
                case 1: goto L2cf;
                case 2: goto L4fa;
                case 3: goto L563;
                case 4: goto L637;
                case 5: goto L131;
                case 6: goto L631;
                case 7: goto L533;
                case 8: goto L187;
                case 9: goto L55d;
                default: goto L74d;
            }
        L74d:
            goto L1ca
        L751:
            java.lang.stringBuilder r6 = new java.lang.stringBuilder
            goto L2df
        L757:
            r0 = r13
            goto L725
        L75c:
            androidx.paging.PagingSource$LoadResult r6 = (androidx.paging.PagingSource.LoadResult) r6
            goto L3e3
        L762:
            r0.label = r3
            goto L74
        L768:
            if (r1 != 0) goto L76d
            goto L2d
        L76d:
            goto L1d7
        L771:
            if (r6 == r1) goto L776
            goto L4b8
        L776:
            goto L4b6
        L77a:
            if (r12 != 0) goto L77f
            goto L7d2
        L77f:
            goto L19f
        L783:
            r12 = r13
            goto L36f
        L788:
            androidx.paging.PageFetcherSnapshot r4 = (androidx.paging.PageFetcherSnapshot) r4
            goto L494
        L78e:
            r12.unlock(r5)
            goto L4f2
        L795:
            r12 = r11
        L796:
            goto L7a6
        L79a:
            int r0 = r0 + r1
            goto L179
        L7a0:
            kotlin.Unit r12 = kotlin.Unit.INSTANCE
            goto L312
        L7a6:
            r12.unlock(r5)
            goto L5f6
        L7ad:
            r12.<init>(r13)
            goto L55c
        L7b4:
            r12.unlock(r5)
            goto L267
        L7bb:
            java.lang.string r13 = r7.loadResultConsole(r13, r2, r6)
            goto L7d6
        L7c3:
            kotlinx.coroutines.sync.Mutex r12 = (kotlinx.coroutines.sync.Mutex) r12
            goto L574
        L7c9:
            androidx.paging.PagingConsoleger r13 = androidx.paging.PagingConsoleger.INSTANCE
            goto L4fe
        L7cf:
            r12.onInvalidLoad()
        L7d2:
            goto L2ab
        L7d6:
            r12.log(r3, r13, r5)
        L7d9:
            goto L1b5
        L7dd:
            bool r2 = r13 is androidx.paging.PagingSource.LoadResult.Page
            goto L15b
        L7e3:
            kotlinx.coroutines.sync.Mutex r12 = (kotlinx.coroutines.sync.Mutex) r12
            goto L5f0
        L7e9:
            kotlinx.coroutines.sync.Mutex r3 = androidx.paging.PageFetcherSnapshotState.Holder.access$getLock$p(r2)
            goto L509
        L7f1:
            java.lang.object r3 = r0.L$1
            goto Lb9
        L7f7:
            java.lang.object r0 = r13.lock(r5, r0)
            goto L641
        L7ff:
            androidx.paging.LoadType r0 = androidx.paging.LoadType.APPEND
            goto La4
    }

    private readonly java.lang.object DoLoad(androidx.paging.LoadType r18, androidx.paging.GenerationalobjectportHint r19, kotlin.coroutines.Continuation<kotlin.Unit> r20) {
            r17 = this;
            goto L11d1
        L4:
            r2.<init>()
            goto Lf61
        Lb:
            java.lang.object r9 = r3.L$5
            goto Lb0e
        L11:
            r1 = 0
            goto Lb82
        L16:
            if (r13 == r4) goto L1b
            goto L2f7
        L1b:
            goto L2f6
        L1f:
            if (r4 != 0) goto L24
            goto Le05
        L24:
            goto L121a
        L28:
            r2.unlock(r14)
            goto Laf1
        L2f:
            r16 = r5
            goto L1004
        L35:
            androidx.paging.PageFetcherSnapshotState$Holder<Key, Value> r1 = r8.stateHolder
            goto La34
        L3b:
            goto Lca6
        L3d:
            goto L210
        L41:
            java.lang.object r4 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L145
        L49:
            kotlin.ResultKt.throwOnFailure(r2)
            goto L5f9
        L50:
            r2.unlock(r9)
            goto L9d2
        L57:
            androidx.paging.PageFetcherSnapshotState$Holder r5 = (androidx.paging.PageFetcherSnapshotState.Holder) r5
            goto L5a4
        L5d:
            r7 = r1
        L5e:
            goto L7e
        L62:
            java.lang.object r13 = r3.L$3
            goto L6b8
        L68:
            kotlin.ResultKt.throwOnFailure(r2)
            goto Lf6c
        L6f:
            int r0 = r11.element
            goto Le1e
        L75:
            if (r1 == 0) goto L7a
            goto L274
        L7a:
            goto L26f
        L7e:
            r5 = r2
            goto Lb9a
        L83:
            bool r2 = r0.isConsolegable(r15)
            goto Lda2
        L8b:
            androidx.paging.PageFetcherSnapshotState$Holder r1 = (androidx.paging.PageFetcherSnapshotState.Holder) r1
            goto L9f3
        L91:
            r3.L$4 = r1
            goto L389
        L97:
            if (r1 == r4) goto L9c
            goto Lbca
        L9c:
            goto Lbc8
        La0:
            r7 = r0
        La1:
            androidx.paging.PageFetcherSnapshotState r2 = androidx.paging.PageFetcherSnapshotState.Holder.access$getState$p(r5)     // Catch: java.lang.Exception -> L605
            int r5 = r9.getGenerationId()     // Catch: java.lang.Exception -> L605
            androidx.paging.objectportHint r13 = r9.getHint()     // Catch: java.lang.Exception -> L605
            int r13 = r13.presentedItemsBeyondAnchor$paging_common_release(r11)     // Catch: java.lang.Exception -> L605
            int r14 = r8.element     // Catch: java.lang.Exception -> L605
            int r13 = r13 + r14
            java.lang.object r5 = r12.nextLoadKeyOrNull(r2, r11, r5, r13)     // Catch: java.lang.Exception -> L605
            if (r5 == 0) goto L7a3
            r3.L$0 = r12     // Catch: java.lang.Exception -> L605
            r3.L$1 = r11     // Catch: java.lang.Exception -> L605
            r3.L$2 = r9     // Catch: java.lang.Exception -> L605
            r3.L$3 = r8     // Catch: java.lang.Exception -> L605
            r3.L$4 = r7     // Catch: java.lang.Exception -> L605
            r3.L$5 = r1     // Catch: java.lang.Exception -> L605
            r3.L$6 = r5     // Catch: java.lang.Exception -> L605
            r3.L$7 = r0     // Catch: java.lang.Exception -> L605
            r13 = 3
            r3.label = r13     // Catch: java.lang.Exception -> L605
            java.lang.object r2 = r12.setLoading(r2, r11, r3)     // Catch: java.lang.Exception -> L605
            goto L1054
        Ld5:
            r3.L$0 = r14
            goto Lf03
        Ldb:
            r1 = r0
            goto L368
        Le0:
            if (r13 == r0) goto Le5
            goto L407
        Le5:
            goto L1041
        Le9:
            kotlin.jvm.internal.Ref$IntRef r11 = (kotlin.jvm.internal.Ref.IntRef) r11
            goto Lb14
        Lef:
            androidx.paging.PageFetcherSnapshotState$Holder r1 = (androidx.paging.PageFetcherSnapshotState.Holder) r1
            goto L95c
        Lf5:
            androidx.paging.PageFetcherSnapshotState$Holder<Key, Value> r1 = r8.stateHolder
            goto L2b8
        Lfb:
            throw r0
        Lfc:
            goto L1029
        L100:
            r2 = r5
            goto L1049
        L105:
            java.lang.object r5 = r3.L$7
            goto L483
        L10b:
            goto Led0
        L10d:
            goto L7c5
        L111:
            kotlin.jvm.internal.Ref$boolRef r13 = (kotlin.jvm.internal.Ref.boolRef) r13
            goto Lbf3
        L117:
            r14 = 0
            goto L87e
        L11c:
            androidx.paging.PagingSource<Key, Value> r13 = r12.pagingSource
            goto L431
        L122:
            androidx.paging.PagingSource$LoadParams r5 = (androidx.paging.PagingSource.LoadParams) r5
            goto L3a4
        L128:
            java.lang.string r13 = " with loadKey "
            goto L11e1
        L12e:
            java.lang.string r1 = " in two\n                            | sequential Pages loaded from a PagingSource. Re-using load keys in\n                            | PagingSource is often an error, and must be explicitly enabled by\n                            | overriding PagingSource.keyReuseSupported.\n                            "
            goto Lae3
        L134:
            r3.L$4 = r9
            goto L1023
        L13a:
            r3.L$5 = r0
            goto Ld91
        L140:
            return r0
        L141:
            goto Ld61
        L145:
            int r5 = r3.label
            goto Ld52
        L14b:
            r8 = r16
        L14d:
            androidx.paging.PageFetcherSnapshotState r5 = androidx.paging.PageFetcherSnapshotState.Holder.access$getState$p(r5)     // Catch: java.lang.Exception -> Lfb3
            int[] r9 = androidx.paging.PageFetcherSnapshot.WhenDictionarypings.$EnumSwitchDictionaryping$0     // Catch: java.lang.Exception -> Lfb3
            int r11 = r1.ordinal()     // Catch: java.lang.Exception -> Lfb3
            r9 = r9[r11]     // Catch: java.lang.Exception -> Lfb3
            if (r9 == r10) goto Lfad
            r11 = 2
            if (r9 == r11) goto L1a5
            r11 = 3
            if (r9 == r11) goto L163
            goto L1f7
        L163:
            int r9 = r5.getInitialPageIndex$paging_common_release()     // Catch: java.lang.Exception -> Lfb3
            androidx.paging.objectportHint r11 = r7.getHint()     // Catch: java.lang.Exception -> Lfb3
            int r11 = r11.getOriginalPageOffsetLast()     // Catch: java.lang.Exception -> Lfb3
            int r9 = r9 + r11
            int r9 = r9 + r10
            if (r9 >= 0) goto L17f
            int r11 = r8.element     // Catch: java.lang.Exception -> Lfb3
            androidx.paging.PagingConfig r12 = r0.config     // Catch: java.lang.Exception -> Lfb3
            int r12 = r12.pageSize     // Catch: java.lang.Exception -> Lfb3
            int r9 = -r9
            int r12 = r12 * r9
            int r11 = r11 + r12
            r8.element = r11     // Catch: java.lang.Exception -> Lfb3
            r9 = 0
        L17f:
            java.util.List r11 = r5.getPages$paging_common_release()     // Catch: java.lang.Exception -> Lfb3
            int r11 = kotlin.collections.ICollectionsKt.getLastIndex(r11)     // Catch: java.lang.Exception -> Lfb3
            if (r9 > r11) goto L1f7
        L189:
            int r12 = r8.element     // Catch: java.lang.Exception -> Lfb3
            java.util.List r13 = r5.getPages$paging_common_release()     // Catch: java.lang.Exception -> Lfb3
            java.lang.object r13 = r13[r9)     // Catch: java.lang.Exception -> Lfb3
            androidx.paging.PagingSource$LoadResult$Page r13 = (androidx.paging.PagingSource.LoadResult.Page) r13     // Catch: java.lang.Exception -> Lfb3
            java.util.List r13 = r13.getData()     // Catch: java.lang.Exception -> Lfb3
            int r13 = r13.Count     // Catch: java.lang.Exception -> Lfb3
            int r12 = r12 + r13
            r8.element = r12     // Catch: java.lang.Exception -> Lfb3
            if (r9 == r11) goto L1f7
            int r9 = r9 + 1
            goto L189
        L1a5:
            int r9 = r5.getInitialPageIndex$paging_common_release()     // Catch: java.lang.Exception -> Lfb3
            androidx.paging.objectportHint r11 = r7.getHint()     // Catch: java.lang.Exception -> Lfb3
            int r11 = r11.getOriginalPageOffsetFirst()     // Catch: java.lang.Exception -> Lfb3
            int r9 = r9 + r11
            int r9 = r9 - r10
            java.util.List r11 = r5.getPages$paging_common_release()     // Catch: java.lang.Exception -> Lfb3
            int r11 = kotlin.collections.ICollectionsKt.getLastIndex(r11)     // Catch: java.lang.Exception -> Lfb3
            if (r9 <= r11) goto L1d8
            int r11 = r8.element     // Catch: java.lang.Exception -> Lfb3
            androidx.paging.PagingConfig r12 = r0.config     // Catch: java.lang.Exception -> Lfb3
            int r12 = r12.pageSize     // Catch: java.lang.Exception -> Lfb3
            java.util.List r13 = r5.getPages$paging_common_release()     // Catch: java.lang.Exception -> Lfb3
            int r13 = kotlin.collections.ICollectionsKt.getLastIndex(r13)     // Catch: java.lang.Exception -> Lfb3
            int r9 = r9 - r13
            int r12 = r12 * r9
            int r11 = r11 + r12
            r8.element = r11     // Catch: java.lang.Exception -> Lfb3
            java.util.List r9 = r5.getPages$paging_common_release()     // Catch: java.lang.Exception -> Lfb3
            int r9 = kotlin.collections.ICollectionsKt.getLastIndex(r9)     // Catch: java.lang.Exception -> Lfb3
        L1d8:
            if (r9 < 0) goto L1f7
            r11 = 0
        L1db:
            int r12 = r8.element     // Catch: java.lang.Exception -> Lfb3
            java.util.List r13 = r5.getPages$paging_common_release()     // Catch: java.lang.Exception -> Lfb3
            java.lang.object r13 = r13[r11)     // Catch: java.lang.Exception -> Lfb3
            androidx.paging.PagingSource$LoadResult$Page r13 = (androidx.paging.PagingSource.LoadResult.Page) r13     // Catch: java.lang.Exception -> Lfb3
            java.util.List r13 = r13.getData()     // Catch: java.lang.Exception -> Lfb3
            int r13 = r13.Count     // Catch: java.lang.Exception -> Lfb3
            int r12 = r12 + r13
            r8.element = r12     // Catch: java.lang.Exception -> Lfb3
            if (r11 == r9) goto L1f7
            int r11 = r11 + 1
            goto L1db
        L1f7:
            kotlin.Unit r5 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> Lfb3
            goto Lad3
        L1fd:
            java.lang.object r11 = r3.L$0
            goto Lffe
        L203:
            r1 = r1[r14]
            goto Ldcf
        L209:
            r8.onInvalidLoad()
            goto L11a9
        L210:
            androidx.paging.PagingConsoleger r0 = androidx.paging.PagingConsoleger.INSTANCE
            goto La07
        L216:
            r8 = r12
            goto Lb95
        L21b:
            java.lang.object r0 = r3.L$5
            goto L10bb
        L221:
            r3.L$1 = r1
            goto L8c6
        L227:
            r3.L$2 = r9
            goto La9b
        L22d:
            bool r5 = r2.isConsolegable(r13)
            goto L9de
        L235:
            goto Lc2a
        L237:
            goto Lc28
        L23b:
            if (r5 == r4) goto L240
            goto L10d5
        L240:
            goto L10d3
        L244:
            r11 = r13
            goto L117c
        L249:
            r5.unlock(r14)
            goto Lfac
        L250:
            androidx.paging.PageFetcherSnapshotState$Holder<Key, Value> r2 = r14.stateHolder
            goto L1248
        L256:
            r3.L$4 = r9
            goto Lb89
        L25c:
            r5.unlock(r10)
            goto Le35
        L263:
            goto L1b
        L265:
            goto L3aa
        L269:
            r3.L$1 = r1
            goto Lbd4
        L26f:
            if (r0 != 0) goto L274
            goto Lfc
        L274:
            goto L250
        L278:
            r3.L$1 = r11
            goto L227
        L27e:
            goto Lbba
        L280:
            goto Ld42
        L284:
            java.lang.object r15 = r3.L$0
            goto L1106
        L28a:
            r2 = 0
            goto L504
        L28f:
            bool r1 = r0.isConsolegable(r2)
            goto L105d
        L297:
            if (r2 != 0) goto L29c
            goto L9c3
        L29c:
            goto L1242
        L2a0:
            r14 = 0
            goto L28
        L2a5:
            goto Ldf9
        L2a7:
            goto L42b
        L2ab:
            goto L902
        L2ae:
            goto Ldab
        L2b2:
            androidx.paging.PagingSource$LoadResult r0 = (androidx.paging.PagingSource.LoadResult) r0
            goto L7eb
        L2b8:
            kotlinx.coroutines.sync.Mutex r2 = androidx.paging.PageFetcherSnapshotState.Holder.access$getLock$p(r1)
            goto L1250
        L2c0:
            java.lang.object r1 = r3.L$5
            goto L11c0
        L2c6:
            androidx.paging.PageFetcherSnapshotState$Holder r1 = (androidx.paging.PageFetcherSnapshotState.Holder) r1
            goto L738
        L2cc:
            r3.L$6 = r7
            goto Lf24
        L2d2:
            java.lang.object r8 = r3.L$6
            goto Ldfd
        L2d8:
            r3.L$2 = r8
            goto L331
        L2de:
            androidx.paging.LoadType r5 = androidx.paging.LoadType.PREPEND
            goto Lf5a
        L2e4:
            r11 = r1
            goto Lce5
        L2e9:
            r8 = r12
            goto L337
        L2ee:
            bool r2 = r0.isConsolegable(r11)
            goto L9f9
        L2f6:
            return r4
        L2f7:
            goto Le4b
        L2fb:
            r1 = r0
            goto L8ac
        L300:
            androidx.paging.LoadType r7 = (androidx.paging.LoadType) r7
            goto Le0f
        L306:
            r2 = r1
            goto L61b
        L30b:
            r0 = r1
            goto L1238
        L310:
            r3.label = r11
            goto L47e
        L316:
            androidx.paging.PageFetcherSnapshot r12 = (androidx.paging.PageFetcherSnapshot) r12
            kotlin.ResultKt.throwOnFailure(r2)     // Catch: java.lang.Exception -> L1210
            goto L120e
        L31f:
            r13 = r9
            goto Lba6
        L324:
            r0.<init>()
        L327:
            goto Lf78
        L32b:
            androidx.paging.LoadType r13 = (androidx.paging.LoadType) r13
            goto L109b
        L331:
            r3.L$3 = r5
            goto L1015
        L337:
            goto Lbbf
        L339:
            r0 = move-exception
            goto L853
        L33e:
            r1 = 1
            goto L111a
        L343:
            r1 = r9
            goto Lbda
        L348:
            r10 = 0
            goto L10a1
        L34d:
            r2.unlock(r14)
            goto L1215
        L354:
            r0.<init>(r6)
            goto L714
        L35b:
            r5 = 0
            goto L7a1
        L360:
            kotlinx.coroutines.sync.Mutex r9 = androidx.paging.PageFetcherSnapshotState.Holder.access$getLock$p(r5)
            goto L425
        L368:
            r0 = r8
            goto L1156
        L36d:
            goto L5d3
        L36f:
            goto L5cb
        L373:
            r2 = 3
            goto Lf30
        L378:
            r2 = 2
            goto L28f
        L37d:
            java.lang.object r9 = r3.L$0
            goto L5c5
        L383:
            java.lang.object r13 = r3.L$1
            goto L32b
        L389:
            r3.L$5 = r0
            goto Le73
        L38f:
            if (r1 == 0) goto L394
            goto L111c
        L394:
            goto L33e
        L398:
            r3.L$2 = r12
            goto La54
        L39e:
            goto L100a
        L3a0:
            goto L1009
        L3a4:
            java.lang.object r7 = r3.L$5
            goto L3eb
        L3aa:
            r16 = r5
            goto L9cd
        L3b0:
            java.lang.stringBuilder r5 = new java.lang.stringBuilder
            goto Lc22
        L3b6:
            androidx.paging.PagingSource$LoadResult r5 = (androidx.paging.PagingSource.LoadResult) r5
            goto L3f9
        L3bc:
            java.lang.object r8 = r3.L$3
            goto Lb52
        L3c2:
            java.lang.string r0 = r0.tostring()
            goto Le28
        L3ca:
            kotlin.jvm.internal.Ref$objectRef r7 = (kotlin.jvm.internal.Ref.objectRef) r7
            goto L3bc
        L3d0:
            if (r1 != r2) goto L3d5
            goto L1216
        L3d5:
            goto Lb7c
        L3d9:
            r1.unlock(r14)
            goto L45f
        L3e0:
            bool r1 = r5 is androidx.paging.PagingSource.LoadResult.Error
            goto Lb73
        L3e6:
            r0 = r1
            goto Le3e
        L3eb:
            kotlin.jvm.internal.Ref$boolRef r7 = (kotlin.jvm.internal.Ref.boolRef) r7
            goto L116d
        L3f1:
            java.lang.object r11 = r7.lock(r9, r3)
            goto L946
        L3f9:
            java.lang.object r7 = r3.L$6
            goto Lbb2
        L3ff:
            r3.label = r14
            goto Lfd4
        L405:
            r8.element = r10
        L407:
            goto L11cc
        L40b:
            java.lang.string r0 = kotlin.text.stringsKt.trimMargin$default(r0, r9, r10, r9)
            goto L1268
        L413:
            java.lang.stringBuilder r5 = r5.append(r13)
            goto Lf39
        L41b:
            r1 = r5
            goto L610
        L420:
            r1 = 0
        L421:
            goto L50a
        L425:
            r3.L$0 = r0
            goto L269
        L42b:
            java.lang.IllegalArgumentException r0 = new java.lang.IllegalArgumentException
            goto L354
        L431:
            java.lang.stringBuilder r5 = r5.append(r13)
            goto Lf7e
        L439:
            kotlinx.coroutines.sync.Mutex r1 = (kotlinx.coroutines.sync.Mutex) r1
            goto L697
        L43f:
            java.lang.object r12 = r3.L$0
            goto L316
        L445:
            int r2 = r13.ordinal()
            goto L64b
        L44d:
            r3.L$1 = r13
            goto L5fe
        L453:
            T r2 = r9.element
            goto L83f
        L459:
            goto L546
        L45b:
            goto L6dc
        L45f:
            kotlin.Unit r0 = kotlin.Unit.INSTANCE
            goto Labf
        L465:
            if (r1 != 0) goto L46a
            goto Lca6
        L46a:
            goto Ld11
        L46e:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L5dc
        L474:
            r8 = r2
            goto L63a
        L479:
            r3 = r7
            goto L10b
        L47e:
            r11 = 0
            goto L954
        L483:
            kotlinx.coroutines.sync.Mutex r5 = (kotlinx.coroutines.sync.Mutex) r5
            goto L940
        L489:
            androidx.paging.LoadType r8 = (androidx.paging.LoadType) r8
            goto La6d
        L48f:
            T r1 = r9.element
            goto L911
        L495:
            if (r13 == r0) goto L49a
            goto L1178
        L49a:
            goto Lb06
        L49e:
            r3.<init>(r0, r2)
        L4a1:
            goto Lcc4
        L4a5:
            r14 = 5
            goto L3ff
        L4aa:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L119b
        L4b2:
            androidx.paging.LoadType r13 = (androidx.paging.LoadType) r13
            goto L1132
        L4b8:
            androidx.paging.LoadType r11 = (androidx.paging.LoadType) r11
            goto L43f
        L4be:
            java.lang.object r7 = r3.L$7
            goto L873
        L4c4:
            r12 = r0
            goto L2e4
        L4c9:
            androidx.paging.GenerationalobjectportHint r8 = (androidx.paging.GenerationalobjectportHint) r8
            goto Ld1c
        L4cf:
            r3 = r2
            goto Ladd
        L4d4:
            java.lang.object r13 = r3.L$2
            goto L670
        L4da:
            java.lang.object r6 = r3.L$2
            goto L593
        L4e0:
            r3.L$5 = r7
            goto Lfd9
        L4e6:
            java.lang.object r14 = r3.L$1
            goto Laa7
        L4ec:
            r3.L$9 = r2
            goto L4a5
        L4f2:
            r1 = r7
            goto Lf4a
        L4f7:
            r11 = r8
            goto L216
        L4fc:
            java.util.List r2 = r1.getData()
            goto L531
        L504:
            goto L61c
        L506:
            goto Lb38
        L50a:
            bool r2 = r5 is androidx.paging.PagingSource.LoadParams.Append
            goto L297
        L510:
            java.lang.string r0 = r0.tostring()
            goto La17
        L518:
            r1 = r8
            goto L474
        L51d:
            if (r1 == 0) goto L522
            goto L936
        L522:
            goto L934
        L526:
            java.lang.object r7 = r3.L$3
            goto Lb64
        L52c:
            r12 = r9
            goto L847
        L531:
            int r2 = r2.Count
            goto La84
        L539:
            java.lang.object r15 = r3.L$3
            goto L620
        L53f:
            java.lang.object r0 = r3.L$6
            goto L96f
        L545:
            r12 = r11
        L546:
            androidx.paging.PageFetcherSnapshotState r1 = androidx.paging.PageFetcherSnapshotState.Holder.access$getState$p(r1)     // Catch: java.lang.Exception -> L339
            androidx.paging.objectportHint r10 = r13.getHint()     // Catch: java.lang.Exception -> L339
            androidx.paging.PageEvent$Drop r5 = r1.dropEventOrNull(r5, r10)     // Catch: java.lang.Exception -> L339
            if (r5 == 0) goto L1158
            r1.drop(r5)     // Catch: java.lang.Exception -> L339
            kotlinx.coroutines.channels.Channel<androidx.paging.PageEvent<Value>> r10 = r15.pageEventCh     // Catch: java.lang.Exception -> L339
            r3.L$0 = r15     // Catch: java.lang.Exception -> L339
            r3.L$1 = r14     // Catch: java.lang.Exception -> L339
            r3.L$2 = r13     // Catch: java.lang.Exception -> L339
            r3.L$3 = r12     // Catch: java.lang.Exception -> L339
            r3.L$4 = r9     // Catch: java.lang.Exception -> L339
            r3.L$5 = r0     // Catch: java.lang.Exception -> L339
            r3.L$6 = r8     // Catch: java.lang.Exception -> L339
            r3.L$7 = r7     // Catch: java.lang.Exception -> L339
            r3.L$8 = r2     // Catch: java.lang.Exception -> L339
            r3.L$9 = r1     // Catch: java.lang.Exception -> L339
            r11 = 0
            r3.L$10 = r11     // Catch: java.lang.Exception -> L339
            r11 = 9
            r3.label = r11     // Catch: java.lang.Exception -> L339
            java.lang.object r5 = r10.send(r5, r3)     // Catch: java.lang.Exception -> L339
            goto L23b
        L57c:
            r5 = 4
            goto L9b6
        L581:
            r2 = r0
            goto La60
        L586:
            java.lang.string r1 = r8.loadResultConsole(r13, r1, r5)
            goto L795
        L58e:
            r1 = r2
            goto Lbb8
        L593:
            androidx.paging.GenerationalobjectportHint r6 = (androidx.paging.GenerationalobjectportHint) r6
            goto L10ec
        L599:
            r14 = 0
            goto L997
        L59e:
            kotlin.Unit r0 = kotlin.Unit.INSTANCE
            goto L604
        L5a4:
            java.lang.object r7 = r3.L$4
            goto L3ca
        L5aa:
            java.lang.object r4 = r3.L$1
            goto L1120
        L5b0:
            java.lang.object r8 = r3.L$3
            goto L861
        L5b6:
            java.lang.object r1 = r3.L$8
            goto L439
        L5bc:
            if (r15 == r4) goto L5c1
            goto Lb34
        L5c1:
            goto Lb32
        L5c5:
            androidx.paging.PageFetcherSnapshot r9 = (androidx.paging.PageFetcherSnapshot) r9
            goto Lb4b
        L5cb:
            java.lang.object r0 = r3.L$10
            goto L975
        L5d1:
            goto L10dc
        L5d3:
            goto L106c
        L5d7:
            r14 = 0
            goto L36d
        L5dc:
            java.lang.string r2 = "The same value, "
            goto L84c
        L5e2:
            r3.L$1 = r13
            goto L398
        L5e8:
            kotlin.jvm.internal.Ref$objectRef r0 = (kotlin.jvm.internal.Ref.objectRef) r0
            goto L6e2
        L5ee:
            androidx.paging.PageFetcherSnapshotState r0 = (androidx.paging.PageFetcherSnapshotState) r0
            goto L5b6
        L5f4:
            r9 = r12
            goto Lc0f
        L5f9:
            r2 = r0
            goto L891
        L5fe:
            r3.L$2 = r12
            goto L1182
        L604:
            return r0
        L605:
            r0 = move-exception
            goto Lbe8
        L60a:
            java.lang.object r9 = r3.L$2
            goto L885
        L610:
            androidx.paging.PagingSource$LoadResult$Page r1 = (androidx.paging.PagingSource.LoadResult.Page) r1
            goto Lfe8
        L616:
            r11 = 2
            goto L6ee
        L61b:
            r1 = r5
        L61c:
            goto L35b
        L620:
            kotlin.jvm.internal.Ref$IntRef r15 = (kotlin.jvm.internal.Ref.IntRef) r15
            goto Lcaa
        L626:
            if (r0 != 0) goto L62b
            goto Lbae
        L62b:
            goto L1090
        L62f:
            r14 = 0
            goto Ld81
        L634:
            java.lang.object r0 = r3.L$7
            goto L5e8
        L63a:
            r2 = r0
            goto L1096
        L63f:
            r10 = 0
            goto L25c
        L644:
            kotlin.ResultKt.throwOnFailure(r2)
            goto L100
        L64b:
            r1 = r1[r2]
            goto L123d
        L651:
            java.lang.object r2 = r2.load(r1, r3)
            goto L92b
        L659:
            androidx.paging.GenerationalobjectportHint r9 = (androidx.paging.GenerationalobjectportHint) r9
            goto Le67
        L65f:
            r5 = r1
            goto L6be
        L664:
            int[] r1 = androidx.paging.PageFetcherSnapshot.WhenDictionarypings.$EnumSwitchDictionaryping$0
            goto L6c3
        L66a:
            r3.L$7 = r5
            goto L102e
        L670:
            androidx.paging.GenerationalobjectportHint r13 = (androidx.paging.GenerationalobjectportHint) r13
            goto L4e6
        L676:
            androidx.paging.GenerationalobjectportHint r14 = (androidx.paging.GenerationalobjectportHint) r14
            goto L9c7
        L67c:
            T r1 = r9.element
            goto L586
        L682:
            java.lang.object r1 = r3.L$6
            goto Lf09
        L688:
            kotlinx.coroutines.sync.Mutex r5 = (kotlinx.coroutines.sync.Mutex) r5
            goto L88b
        L68e:
            if (r0 == r4) goto L693
            goto Ldda
        L693:
            goto Ldd8
        L697:
            java.lang.object r5 = r3.L$7
            goto Lb20
        L69d:
            if (r2 != 0) goto L6a2
            goto Lfc
        L6a2:
            goto L75
        L6a6:
            r3.I$0 = r1
            goto L1162
        L6ac:
            goto L1b
        L6ae:
            goto La7f
        L6b2:
            java.lang.IllegalArgumentException r0 = new java.lang.IllegalArgumentException
            goto L10f2
        L6b8:
            kotlin.jvm.internal.Ref$IntRef r13 = (kotlin.jvm.internal.Ref.IntRef) r13
            goto L1146
        L6be:
            r1 = r2
            goto L7a7
        L6c3:
            int r14 = r13.ordinal()
            goto L203
        L6cb:
            r7 = r8
            goto L14b
        L6d0:
            androidx.paging.PagingConsoleger r0 = androidx.paging.PagingConsoleger.INSTANCE
            goto L616
        L6d6:
            androidx.paging.PagingConsoleger r2 = androidx.paging.PagingConsoleger.INSTANCE
            goto L9bc
        L6dc:
            java.lang.object r0 = r3.L$3
            goto La8f
        L6e2:
            java.lang.object r1 = r3.L$6
            goto L9e7
        L6e8:
            androidx.paging.RemoteMediatorConnection<Key, Value> r1 = r14.remoteMediatorConnection
            goto L2de
        L6ee:
            bool r1 = r0.isConsolegable(r11)
            goto Lcea
        L6f6:
            androidx.paging.LoadType r0 = androidx.paging.LoadType.APPEND
            goto Le0
        L6fc:
            r0.element = r2
            goto Ldb7
        L702:
            goto L327
        L704:
            r0 = move-exception
            goto L117
        L709:
            throw r0
        L70a:
            goto Lfbd
        L70e:
            r3.L$1 = r13
            goto L1066
        L714:
            throw r0
        L715:
            goto L770
        L719:
            androidx.paging.PageFetcherSnapshot r14 = (androidx.paging.PageFetcherSnapshot) r14
            kotlin.ResultKt.throwOnFailure(r2)     // Catch: java.lang.Exception -> L10db
            goto Lf45
        L722:
            androidx.paging.LoadType r1 = androidx.paging.LoadType.APPEND
            goto La22
        L728:
            r7 = r0
            goto L11f8
        L72d:
            r3.label = r2
            goto Le03
        L733:
            r12 = r6
            goto L479
        L738:
            java.lang.object r5 = r3.L$7
            goto L3b6
        L73e:
            kotlinx.coroutines.sync.Mutex r1 = (kotlinx.coroutines.sync.Mutex) r1
            goto L5aa
        L744:
            androidx.paging.LoadType r2 = androidx.paging.LoadType.REFRESH
            goto L3d0
        L74a:
            androidx.paging.PageFetcherSnapshot r14 = (androidx.paging.PageFetcherSnapshot) r14
            goto Laff
        L750:
            r5.<init>(r13)
            goto Lff6
        L757:
            r8 = r0
        L758:
            androidx.paging.PageFetcherSnapshotState r0 = androidx.paging.PageFetcherSnapshotState.Holder.access$getState$p(r1)     // Catch: java.lang.Exception -> Ld37
            int r1 = r12.getGenerationId()     // Catch: java.lang.Exception -> Ld37
            r15 = r5
            androidx.paging.PagingSource$LoadResult$Page r15 = (androidx.paging.PagingSource.LoadResult.Page) r15     // Catch: java.lang.Exception -> Ld37
            bool r0 = r0.insert(r1, r13, r15)     // Catch: java.lang.Exception -> Ld37
            goto L11
        L76b:
            r8 = r0
            goto L3e6
        L770:
            r1 = r5
            goto L925
        L775:
            androidx.paging.PageFetcherSnapshotState$Holder r1 = (androidx.paging.PageFetcherSnapshotState.Holder) r1
            goto L9ed
        L77b:
            goto L7f8
        L77d:
            r0 = move-exception
        L77e:
            goto L1168
        L782:
            r14 = r15
        L783:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L10db
            goto Lbf9
        L789:
            r3.L$10 = r2
            goto L10af
        L78f:
            r3.L$0 = r12
            goto L278
        L795:
            r0.log(r2, r1, r14)
        L798:
            goto L209
        L79c:
            r0 = r5
            goto L65f
        L7a1:
            goto L506
        L7a3:
            goto L28a
        L7a7:
            r8 = r9
            goto L9a9
        L7ac:
            r3.L$5 = r7
            goto Lff0
        L7b2:
            r12 = r2
        L7b3:
            androidx.paging.PageFetcherSnapshotState r2 = androidx.paging.PageFetcherSnapshotState.Holder.access$getState$p(r12)     // Catch: java.lang.Exception -> L704
            androidx.paging.HintHandler r10 = r14.hintHandler     // Catch: java.lang.Exception -> L704
            androidx.paging.objectportHint$Access r10 = r10.getLastAccessHint()     // Catch: java.lang.Exception -> L704
            androidx.paging.PagingState r2 = r2.currentPagingState$paging_common_release(r10)     // Catch: java.lang.Exception -> L704
            goto L63f
        L7c5:
            java.lang.object r0 = r3.L$9
            goto Lf2a
        L7cb:
            r3.L$7 = r5
            goto Lb26
        L7d1:
            java.lang.object r0 = r3.L$7
            goto L2b2
        L7d7:
            r3.L$3 = r11
            goto L134
        L7dd:
            java.lang.string r2 = r14.loadResultConsole(r13, r2, r1)
            goto L962
        L7e5:
            r3.L$6 = r7
            goto L7cb
        L7eb:
            java.lang.object r5 = r3.L$6
            goto L122
        L7f1:
            r11.element = r0
            goto L839
        L7f7:
            r4 = r12
        L7f8:
            java.util.Dictionary r0 = r0.getFailedHintsByLoadType$paging_common_release()     // Catch: java.lang.Exception -> L77d
            androidx.paging.objectportHint r2 = r4.getHint()     // Catch: java.lang.Exception -> L77d
            r0.Add(r3, r2)     // Catch: java.lang.Exception -> L77d
            kotlin.Unit r0 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L77d
            goto Ld6b
        L809:
            r15 = r8
            goto La02
        L80e:
            r14 = 0
            goto L969
        L813:
            throw r1
        L814:
            goto Lf5
        L818:
            kotlin.jvm.internal.Ref$objectRef r14 = (kotlin.jvm.internal.Ref.objectRef) r14
            goto L539
        L81e:
            r3.L$4 = r8
            goto L7ac
        L824:
            if (r13 == r0) goto L829
            goto L237
        L829:
            goto Lb3f
        L82d:
            androidx.paging.PagingSource<Key, Value> r2 = r12.pagingSource
            goto L78f
        L833:
            java.lang.object r1 = r3.L$8
            goto L2c6
        L839:
            androidx.paging.LoadType r0 = androidx.paging.LoadType.PREPEND
            goto L495
        L83f:
            bool r1 = kotlin.jvm.internal.Intrinsics.areEqual(r1, r2)
            goto L51d
        L847:
            r9 = r11
            goto L244
        L84c:
            r1.<init>(r2)
            goto L919
        L853:
            r1 = r2
            goto L5d1
        L858:
            if (r1 != r2) goto L85d
            goto L715
        L85d:
            goto L373
        L861:
            kotlin.jvm.internal.Ref$IntRef r8 = (kotlin.jvm.internal.Ref.IntRef) r8
            goto L60a
        L867:
            int r1 = r3.I$0
            goto L105
        L86d:
            r3.L$2 = r9
            goto Lacd
        L873:
            androidx.paging.PagingSource$LoadResult r7 = (androidx.paging.PagingSource.LoadResult) r7
            goto L2d2
        L879:
            r7 = r5
            goto Lbc3
        L87e:
            r5.unlock(r14)
            goto Lfb
        L885:
            androidx.paging.GenerationalobjectportHint r9 = (androidx.paging.GenerationalobjectportHint) r9
            goto Ldb1
        L88b:
            java.lang.object r7 = r3.L$4
            goto L122c
        L891:
            r0 = r3
            goto L733
        L896:
            goto L1b
        L898:
            goto L2f
        L89c:
            r2 = r0
            goto L1126
        L8a1:
            r7 = r8
            goto L2e9
        L8a6:
            goto L1b
        L8a8:
            goto L980
        L8ac:
            kotlinx.coroutines.sync.Mutex r1 = (kotlinx.coroutines.sync.Mutex) r1
            goto L7d1
        L8b2:
            goto L7b3
        L8b4:
            goto Le2f
        L8b8:
            r5 = r7
            goto Lc2e
        L8bd:
            if (r0 == 0) goto L8c2
            goto L9c3
        L8c2:
            goto Lcd1
        L8c6:
            r8 = r19
            goto L2d8
        L8cc:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto Le5b
        L8d4:
            java.lang.object r8 = r3.L$2
            goto L4c9
        L8da:
            r3.L$4 = r2
            goto Lba0
        L8e0:
            r14 = r15
            goto Lcf8
        L8e5:
            throw r0
        L902:
            goto L10cc
        L906:
            androidx.paging.RemoteMediatorConnection<Key, Value> r2 = r14.remoteMediatorConnection
            goto L69d
        L90c:
            r7 = r8
            goto L76b
        L911:
            java.lang.string r1 = r8.loadResultConsole(r13, r1, r5)
            goto L10fa
        L919:
            T r2 = r9.element
            goto L8cc
        L91f:
            kotlin.jvm.internal.Ref$objectRef r0 = (kotlin.jvm.internal.Ref.objectRef) r0
            goto L682
        L925:
            androidx.paging.PagingSource$LoadResult$Page r1 = (androidx.paging.PagingSource.LoadResult.Page) r1
            goto Ldf5
        L92b:
            if (r2 == r4) goto L930
            goto L6ae
        L930:
            goto L6ac
        L934:
            goto L814
        L936:
            goto L1226
        L93a:
            androidx.paging.PagingSource$LoadParams r7 = (androidx.paging.PagingSource.LoadParams) r7
            goto L1084
        L940:
            java.lang.object r12 = r3.L$6
            goto Lf3f
        L946:
            if (r11 == r4) goto L94b
            goto L265
        L94b:
            goto L263
        L94f:
            r9 = r7
            goto L5d
        L954:
            java.lang.object r12 = r9.lock(r11, r3)
            goto Lcd6
        L95c:
            java.lang.object r5 = r3.L$3
            goto Lb8f
        L962:
            r0.log(r11, r2, r1)
            goto L3b
        L969:
            goto L987
        L96b:
            goto L634
        L96f:
            androidx.paging.PagingSource$LoadParams r0 = (androidx.paging.PagingSource.LoadParams) r0
            goto L2c0
        L975:
            kotlinx.coroutines.sync.Mutex r0 = (kotlinx.coroutines.sync.Mutex) r0
            goto Le50
        L97b:
            int r2 = r2 - r5
            goto L72d
        L980:
            r2 = r0
            goto L99e
        L985:
            goto L1211
        L987:
            goto L249
        L98b:
            androidx.paging.PagingConsoleger r0 = androidx.paging.PagingConsoleger.INSTANCE
            goto Lcf3
        L991:
            java.lang.object r7 = r3.L$6
            goto L93a
        L997:
            r2.log(r13, r5, r14)
            goto L39e
        L99e:
            r0 = r3
            goto Lecf
        L9a3:
            goto L1b
        L9a5:
            goto L809
        L9a9:
            r9 = r13
            goto Lfc9
        L9ae:
            java.lang.stringBuilder r5 = r5.append(r13)
            goto L11c
        L9b6:
            r3.label = r5
            goto L651
        L9bc:
            r13 = 3
            goto L22d
        L9c1:
            goto Ld4e
        L9c3:
            goto Ld4d
        L9c7:
            java.lang.object r15 = r3.L$1
            goto Lcdf
        L9cd:
            r5 = r2
            goto Ld97
        L9d2:
            kotlin.jvm.internal.Ref$objectRef r2 = new kotlin.jvm.internal.Ref$objectRef
            goto L4
        L9d8:
            java.lang.object r9 = r3.L$4
            goto Lbed
        L9de:
            if (r5 != 0) goto L9e3
            goto L3a0
        L9e3:
            goto L3b0
        L9e7:
            kotlinx.coroutines.sync.Mutex r1 = (kotlinx.coroutines.sync.Mutex) r1
            goto Lb2c
        L9ed:
            java.lang.object r5 = r3.L$8
            goto L10b5
        L9f3:
            java.lang.object r5 = r3.L$3
            goto L1262
        L9f9:
            if (r2 != 0) goto L9fe
            goto Lca6
        L9fe:
            goto L10c6
        La02:
            r8 = r7
            goto L879
        La07:
            r15 = 3
            goto L83
        La0c:
            r3.label = r2
            goto Lcb0
        La12:
            r11 = r9
            goto Lad8
        La17:
            r9 = 0
            goto L40b
        La1c:
            r3.L$4 = r7
            goto L13a
        La22:
            goto Lf96
        La24:
            goto Lf94
        La28:
            androidx.paging.PageFetcherSnapshotState$Holder<Key, Value> r14 = r8.stateHolder
            goto L1188
        La2e:
            r3.L$3 = r8
            goto L8da
        La34:
            kotlinx.coroutines.sync.Mutex r0 = androidx.paging.PageFetcherSnapshotState.Holder.access$getLock$p(r1)
            goto Lfa0
        La3c:
            bool r1 = r5 is androidx.paging.PagingSource.LoadResult.Invalid
            goto Le9f
        La42:
            r9 = r5
            goto Ld17
        La47:
            r1 = r18
            goto Lefd
        La4d:
            r0.<init>(r1)
            goto L8e5
        La54:
            r3.L$3 = r5
            goto L91
        La5a:
            r3.L$7 = r14
            goto Ld3c
        La60:
            r0 = r9
            goto L5f4
        La65:
            bool r2 = r2.getKeyReuseSupported()
            goto Laf6
        La6d:
            java.lang.object r9 = r3.L$0
            goto Ld70
        La73:
            r13 = 3
            goto L599
        La78:
            r1.unlock(r10)
            goto Lb1a
        La7f:
            r13 = r11
            goto L4f7
        La84:
            int r0 = r0 + r2
            goto L7f1
        La89:
            r5 = -2147483648(0xffffffff80000000, float:-0.0)
            goto Ld48
        La8f:
            androidx.paging.PageFetcherSnapshotState r0 = (androidx.paging.PageFetcherSnapshotState) r0
            goto L127a
        La95:
            kotlin.jvm.internal.Ref$IntRef r12 = (kotlin.jvm.internal.Ref.IntRef) r12
            goto L4d4
        La9b:
            r3.L$3 = r8
            goto La1c
        Laa1:
            int r0 = r0 % r1
            goto Lb6a
        Laa7:
            androidx.paging.LoadType r14 = (androidx.paging.LoadType) r14
            goto L284
        Laad:
            r3.L$6 = r9
            goto Lcb8
        Lab3:
            androidx.paging.PagingSource<Key, Value> r2 = r8.pagingSource
            goto La65
        Lab9:
            java.lang.object r0 = r3.L$7
            goto L91f
        Labf:
            return r0
        Lac0:
            r0 = move-exception
            goto L58e
        Lac5:
            r10 = 1
            switch(r5) {
                case 0: goto Lb5a;
                case 1: goto Lf6e;
                case 2: goto L96b;
                case 3: goto L1234;
                case 4: goto L1128;
                case 5: goto L10d;
                case 6: goto L280;
                case 7: goto L45b;
                case 8: goto L36f;
                case 9: goto L117e;
                case 10: goto L8b4;
                case 11: goto L70a;
                default: goto Lac9;
            }
        Lac9:
            goto Lc9f
        Lacd:
            r3.L$3 = r12
            goto L81e
        Lad3:
            r9 = 0
            goto L50
        Lad8:
            r9 = r7
            goto L1115
        Ladd:
            androidx.paging.PageFetcherSnapshot$doLoad$1 r3 = (androidx.paging.PageFetcherSnapshot.C07381) r3
            goto Ldea
        Lae3:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L510
        Laeb:
            r3.L$0 = r8
            goto L70e
        Laf1:
            throw r0
        Laf2:
            goto L62f
        Laf6:
            if (r2 == 0) goto Lafb
            goto L814
        Lafb:
            goto L453
        Laff:
            kotlin.ResultKt.throwOnFailure(r2)
            goto L89c
        Lb06:
            java.lang.object r0 = r1.getPrevKey()
            goto L1173
        Lb0e:
            kotlin.jvm.internal.Ref$boolRef r9 = (kotlin.jvm.internal.Ref.boolRef) r9
            goto Lf72
        Lb14:
            java.lang.object r12 = r3.L$2
            goto Le99
        Lb1a:
            bool r1 = r5 is androidx.paging.PagingSource.LoadParams.Prepend
            goto Lde1
        Lb20:
            androidx.paging.PagingSource$LoadResult r5 = (androidx.paging.PagingSource.LoadResult) r5
            goto L991
        Lb26:
            r3.L$8 = r1
            goto L4ec
        Lb2c:
            java.lang.object r5 = r3.L$5
            goto L57
        Lb32:
            goto L1b
        Lb34:
            goto Le8e
        Lb38:
            r1.unlock(r5)
            goto L6fc
        Lb3f:
            java.lang.string r0 = "prevKey"
            goto L235
        Lb45:
            kotlin.jvm.internal.Ref$objectRef r12 = (kotlin.jvm.internal.Ref.objectRef) r12
            goto L62
        Lb4b:
            kotlin.ResultKt.throwOnFailure(r2)
            goto La12
        Lb52:
            kotlin.jvm.internal.Ref$IntRef r8 = (kotlin.jvm.internal.Ref.IntRef) r8
            goto L1280
        Lb58:
            goto L14d
        Lb5a:
            goto L100e
        Lb5e:
            androidx.paging.PageFetcherSnapshotState$Holder<Key, Value> r2 = r0.stateHolder
            goto Lf0f
        Lb64:
            kotlin.jvm.internal.Ref$IntRef r7 = (kotlin.jvm.internal.Ref.IntRef) r7
            goto L8d4
        Lb6a:
            if (r0 <= 0) goto Lb6f
            goto L2ae
        Lb6f:
            goto L2ab
        Lb73:
            if (r1 != 0) goto Lb78
            goto L114d
        Lb78:
            goto L6d0
        Lb7c:
            kotlin.jvm.internal.Ref$IntRef r5 = new kotlin.jvm.internal.Ref$IntRef
            goto Lea8
        Lb82:
            r2.unlock(r1)
            goto Le85
        Lb89:
            r3.L$5 = r0
            goto L7e5
        Lb8f:
            kotlin.jvm.internal.Ref$IntRef r5 = (kotlin.jvm.internal.Ref.IntRef) r5
            goto Ld8b
        Lb95:
            r12 = r9
            goto L94f
        Lb9a:
            androidx.paging.PagingSource$LoadResult r5 = (androidx.paging.PagingSource.LoadResult) r5
            goto Lc14
        Lba0:
            r3.L$5 = r5
            goto Laad
        Lba6:
            r8 = r11
            goto La42
        Lbab:
            r0.requestLoad(r1, r2)
        Lbae:
            goto Lbbe
        Lbb2:
            androidx.paging.PagingSource$LoadParams r7 = (androidx.paging.PagingSource.LoadParams) r7
            goto Lf8e
        Lbb8:
            goto L77e
        Lbba:
            goto Lcca
        Lbbe:
            r0 = r13
        Lbbf:
            goto L1196
        Lbc3:
            r5 = r1
            goto L10c1
        Lbc8:
            goto L1b
        Lbca:
            goto L4f2
        Lbce:
            androidx.paging.PagingSource$LoadResult$Page r1 = (androidx.paging.PagingSource.LoadResult.Page) r1
            goto L4fc
        Lbd4:
            r3.L$2 = r7
            goto La2e
        Lbda:
            r9 = r7
            goto La0
        Lbdf:
            if (r3 != 0) goto Lbe4
            goto Le05
        Lbe4:
            goto L4cf
        Lbe8:
            r5 = r1
            goto L985
        Lbed:
            kotlin.jvm.internal.Ref$objectRef r9 = (kotlin.jvm.internal.Ref.objectRef) r9
            goto L11a3
        Lbf3:
            java.lang.object r14 = r3.L$4
            goto L818
        Lbf9:
            r10 = 0
            goto La78
        Lbfe:
            java.lang.object r1 = r3.L$4
            goto Lef
        Lc04:
            r2 = 6
            goto La0c
        Lc09:
            androidx.paging.PagingSource$LoadResult$Page r1 = (androidx.paging.PagingSource.LoadResult.Page) r1
            goto Leaf
        Lc0f:
            r12 = r13
            goto Ldf0
        Lc14:
            bool r1 = r5 is androidx.paging.PagingSource.LoadResult.Page
            goto Le15
        Lc1a:
            java.lang.object r15 = r2.lock(r14, r3)
            goto L5bc
        Lc22:
            java.lang.string r13 = "Start "
            goto L750
        Lc28:
            java.lang.string r0 = "nextKey"
        Lc2a:
            goto L46e
        Lc2e:
            r7 = r8
        Lc2f:
            int r8 = r13.getGenerationId()     // Catch: java.lang.Exception -> L339
            androidx.paging.objectportHint r10 = r13.getHint()     // Catch: java.lang.Exception -> L339
            int r10 = r10.presentedItemsBeyondAnchor$paging_common_release(r14)     // Catch: java.lang.Exception -> L339
            int r11 = r12.element     // Catch: java.lang.Exception -> L339
            int r10 = r10 + r11
            java.lang.object r8 = r15.nextLoadKeyOrNull(r1, r14, r8, r10)     // Catch: java.lang.Exception -> L339
            r9.element = r8     // Catch: java.lang.Exception -> L339
            T r8 = r9.element     // Catch: java.lang.Exception -> L339
            if (r8 != 0) goto Lc6e
            androidx.paging.MutableLoadStateICollection r8 = r1.getSourceLoadStates$paging_common_release()     // Catch: java.lang.Exception -> L339
            androidx.paging.LoadState r8 = r8[r14)     // Catch: java.lang.Exception -> L339
            bool r8 = r8 is androidx.paging.LoadState.Error     // Catch: java.lang.Exception -> L339
            if (r8 != 0) goto Lc6e
            androidx.paging.MutableLoadStateICollection r8 = r1.getSourceLoadStates$paging_common_release()     // Catch: java.lang.Exception -> L339
            bool r10 = r0.element     // Catch: java.lang.Exception -> L339
            if (r10 == 0) goto Lc63
            androidx.paging.LoadState$NotLoading$Companion r10 = androidx.paging.LoadState.NotLoading.Companion     // Catch: java.lang.Exception -> L339
            androidx.paging.LoadState$NotLoading r10 = r10.getComplete$paging_common_release()     // Catch: java.lang.Exception -> L339
            goto Lc69
        Lc63:
            androidx.paging.LoadState$NotLoading$Companion r10 = androidx.paging.LoadState.NotLoading.Companion     // Catch: java.lang.Exception -> L339
            androidx.paging.LoadState$NotLoading r10 = r10.getIncomplete$paging_common_release()     // Catch: java.lang.Exception -> L339
        Lc69:
            androidx.paging.LoadState r10 = (androidx.paging.LoadState) r10     // Catch: java.lang.Exception -> L339
            r8.set(r14, r10)     // Catch: java.lang.Exception -> L339
        Lc6e:
            r8 = r5
            androidx.paging.PagingSource$LoadResult$Page r8 = (androidx.paging.PagingSource.LoadResult.Page) r8     // Catch: java.lang.Exception -> L339
            androidx.paging.PageEvent r1 = r1.toPageEvent$paging_common_release(r8, r14)     // Catch: java.lang.Exception -> L339
            kotlinx.coroutines.channels.Channel<androidx.paging.PageEvent<Value>> r8 = r15.pageEventCh     // Catch: java.lang.Exception -> L339
            r3.L$0 = r15     // Catch: java.lang.Exception -> L339
            r3.L$1 = r14     // Catch: java.lang.Exception -> L339
            r3.L$2 = r13     // Catch: java.lang.Exception -> L339
            r3.L$3 = r12     // Catch: java.lang.Exception -> L339
            r3.L$4 = r9     // Catch: java.lang.Exception -> L339
            r3.L$5 = r0     // Catch: java.lang.Exception -> L339
            r3.L$6 = r7     // Catch: java.lang.Exception -> L339
            r3.L$7 = r5     // Catch: java.lang.Exception -> L339
            r3.L$8 = r2     // Catch: java.lang.Exception -> L339
            r11 = 0
            r3.L$9 = r11     // Catch: java.lang.Exception -> L339
            r3.L$10 = r11     // Catch: java.lang.Exception -> L339
            r10 = 10
            r3.label = r10     // Catch: java.lang.Exception -> L339
            java.lang.object r1 = r8.send(r1, r3)     // Catch: java.lang.Exception -> L339
            goto L97
        Lc9a:
            r13 = r12
            goto L545
        Lc9f:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
            goto L10e0
        Lca5:
            throw r0
        Lca6:
            goto L59e
        Lcaa:
            java.lang.object r7 = r3.L$2
            goto Ld76
        Lcb0:
            java.lang.object r2 = r0.lock(r14, r3)
            goto Lfdf
        Lcb8:
            r3.L$7 = r2
            goto Ld7c
        Lcbe:
            int r0 = r0 + r1
            goto Laa1
        Lcc4:
            java.lang.object r2 = r3.result
            goto L41
        Lcca:
            r1.unlock(r14)
            goto L114c
        Lcd1:
            r0 = 1
            goto L9c1
        Lcd6:
            if (r12 == r4) goto Lcdb
            goto Lfc5
        Lcdb:
            goto Lfc3
        Lcdf:
            androidx.paging.LoadType r15 = (androidx.paging.LoadType) r15
            goto L11f2
        Lce5:
            r0 = r2
            goto L343
        Lcea:
            if (r1 != 0) goto Lcef
            goto L10fd
        Lcef:
            goto L48f
        Lcf3:
            r11 = 2
            goto L2ee
        Lcf8:
            r15 = r11
            goto L459
        Lcfd:
            r1 = 4
            goto Lcbe
        Ld04:
            androidx.paging.PagingSource$LoadParams r1 = r12.loadParams(r11, r1)
            goto L6d6
        Ld0c:
            r14 = r11
            goto L1209
        Ld11:
            T r1 = r7.element
            goto Ld04
        Ld17:
            r11 = r7
            goto L728
        Ld1c:
            java.lang.object r9 = r3.L$1
            goto Ld9c
        Ld22:
            java.lang.object r9 = r3.L$4
            goto Le45
        Ld28:
            r0 = 32
            goto Lcfd
        Ld2f:
            androidx.paging.PageFetcherSnapshot$doLoad$1 r3 = new androidx.paging.PageFetcherSnapshot$doLoad$1
            goto L49e
        Ld35:
            goto L141
        Ld37:
            r0 = move-exception
            goto L2a0
        Ld3c:
            r3.L$8 = r14
            goto L57c
        Ld42:
            java.lang.object r0 = r3.L$5
            goto Lef7
        Ld48:
            r4 = r4 & r5
            goto L1f
        Ld4d:
            r0 = 0
        Ld4e:
            goto L906
        Ld52:
            java.lang.string r6 = "Use doInitialLoad for LoadType == REFRESH"
            goto Lac5
        Ld58:
            androidx.paging.LoadType r3 = (androidx.paging.LoadType) r3
            kotlin.ResultKt.throwOnFailure(r2)     // Catch: java.lang.Exception -> L77d
            goto L77b
        Ld61:
            r2 = 2
            goto L664
        Ld66:
            r10 = 1
            goto L702
        Ld6b:
            r14 = 0
            goto L3d9
        Ld70:
            androidx.paging.PageFetcherSnapshot r9 = (androidx.paging.PageFetcherSnapshot) r9
            goto L644
        Ld76:
            androidx.paging.GenerationalobjectportHint r7 = (androidx.paging.GenerationalobjectportHint) r7
            goto Lf54
        Ld7c:
            r11 = 2
            goto L310
        Ld81:
            r15 = 3
            goto L3e0
        Ld86:
            r7 = r8
            goto Lf4f
        Ld8b:
            java.lang.object r7 = r3.L$2
            goto L10a9
        Ld91:
            r3.L$6 = r1
            goto La5a
        Ld97:
            r2 = r7
            goto L6cb
        Ld9c:
            androidx.paging.LoadType r9 = (androidx.paging.LoadType) r9
            goto L1fd
        Lda2:
            if (r2 != 0) goto Lda7
            goto L103d
        Lda7:
            goto Le09
        Ldab:
            r0 = r17
            goto La47
        Ldb1:
            java.lang.object r11 = r3.L$1
            goto L4b8
        Ldb7:
            kotlin.jvm.internal.Ref$boolRef r0 = new kotlin.jvm.internal.Ref$boolRef
            goto L324
        Ldbd:
            androidx.paging.LoadType r1 = androidx.paging.LoadType.APPEND
            goto Lbab
        Ldc3:
            kotlin.jvm.internal.Ref$objectRef r8 = (kotlin.jvm.internal.Ref.objectRef) r8
            goto Lec3
        Ldc9:
            androidx.paging.LoadType r11 = (androidx.paging.LoadType) r11
            goto Lec9
        Ldcf:
            if (r1 == r2) goto Ldd4
            goto La24
        Ldd4:
            goto L722
        Ldd8:
            goto L1b
        Ldda:
            goto L30b
        Ldde:
            goto L11d4
        Lde1:
            if (r1 != 0) goto Lde6
            goto L111c
        Lde6:
            goto L1101
        Ldea:
            int r4 = r3.label
            goto La89
        Ldf0:
            r13 = r14
            goto L8e0
        Ldf5:
            java.lang.object r1 = r1.getPrevKey()
        Ldf9:
            goto Lab3
        Ldfd:
            androidx.paging.PagingSource$LoadParams r8 = (androidx.paging.PagingSource.LoadParams) r8
            goto Lb
        Le03:
            goto L4a1
        Le05:
            goto Ld2f
        Le09:
            T r2 = r9.element
            goto L113e
        Le0f:
            java.lang.object r8 = r3.L$0
            goto Le79
        Le15:
            if (r1 != 0) goto Le1a
            goto Laf2
        Le1a:
            goto L1220
        Le1e:
            r1 = r5
            goto Lbce
        Le23:
            r9 = 0
            goto L3f1
        Le28:
            r1.<init>(r0)
            goto L813
        Le2f:
            java.lang.object r0 = r3.L$8
            goto L2fb
        Le35:
            if (r1 != 0) goto Le3a
            goto Lf5d
        Le3a:
            goto L6e8
        Le3e:
            r1 = r2
        Le3f:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L10db
            goto L1073
        Le45:
            kotlin.jvm.internal.Ref$objectRef r9 = (kotlin.jvm.internal.Ref.objectRef) r9
            goto L11c6
        Le4b:
            r13 = r7
            goto Ld86
        Le50:
            java.lang.object r1 = r3.L$9
            goto L775
        Le56:
            r8 = r14
            goto Ld35
        Le5b:
            java.lang.string r2 = ", was passed as the "
            goto L4aa
        Le61:
            java.lang.object r12 = r3.L$2
            goto Leb7
        Le67:
            java.lang.object r11 = r3.L$1
            goto Ldc9
        Le6d:
            r3.L$8 = r10
            goto L6a6
        Le73:
            r3.L$6 = r14
            goto Lc04
        Le79:
            androidx.paging.PageFetcherSnapshot r8 = (androidx.paging.PageFetcherSnapshot) r8
            goto L49
        Le7f:
            androidx.paging.PageFetcherSnapshot r12 = (androidx.paging.PageFetcherSnapshot) r12
            goto L68
        Le85:
            if (r0 == 0) goto Le8a
            goto L3d
        Le8a:
            goto L98b
        Le8e:
            r14 = r8
            goto L757
        Le93:
            java.lang.object r3 = r3.L$0
            goto Ld58
        Le99:
            androidx.paging.GenerationalobjectportHint r12 = (androidx.paging.GenerationalobjectportHint) r12
            goto L1256
        Le9f:
            if (r1 != 0) goto Lea4
            goto L141
        Lea4:
            goto L110f
        Lea8:
            r5.<init>()
            goto Lb5e
        Leaf:
            java.lang.object r1 = r1.getPrevKey()
            goto L38f
        Leb7:
            androidx.paging.GenerationalobjectportHint r12 = (androidx.paging.GenerationalobjectportHint) r12
            goto L383
        Lebd:
            kotlin.jvm.internal.Ref$objectRef r5 = (kotlin.jvm.internal.Ref.objectRef) r5
            goto L526
        Lec3:
            java.lang.object r9 = r3.L$3
            goto L115c
        Lec9:
            java.lang.object r12 = r3.L$0
            goto Le7f
        Lecf:
            r3 = r13
        Led0:
            androidx.paging.PageFetcherSnapshotState r1 = androidx.paging.PageFetcherSnapshotState.Holder.access$getState$p(r1)     // Catch: java.lang.Exception -> Lac0
            androidx.paging.LoadState$Error r6 = new androidx.paging.LoadState$Error     // Catch: java.lang.Exception -> Lac0
            androidx.paging.PagingSource$LoadResult$Error r5 = (androidx.paging.PagingSource.LoadResult.Error) r5     // Catch: java.lang.Exception -> Lac0
            java.lang.Exception r5 = r5.getException()     // Catch: java.lang.Exception -> Lac0
            r6.<init>(r5)     // Catch: java.lang.Exception -> Lac0
            r0.L$0 = r3     // Catch: java.lang.Exception -> Lac0
            r0.L$1 = r12     // Catch: java.lang.Exception -> Lac0
            r0.L$2 = r2     // Catch: java.lang.Exception -> Lac0
            r0.L$3 = r1     // Catch: java.lang.Exception -> Lac0
            r14 = 0
            r0.L$4 = r14     // Catch: java.lang.Exception -> Lac0
            r0.L$5 = r14     // Catch: java.lang.Exception -> Lac0
            r5 = 7
            r0.label = r5     // Catch: java.lang.Exception -> Lac0
            java.lang.object r0 = r8.setError(r1, r3, r6, r0)     // Catch: java.lang.Exception -> Lac0
            goto L68e
        Lef7:
            kotlinx.coroutines.sync.Mutex r0 = (kotlinx.coroutines.sync.Mutex) r0
            goto L1203
        Lefd:
            r2 = r20
            goto L11fd
        Lf03:
            r3.L$1 = r11
            goto L86d
        Lf09:
            java.lang.object r5 = r3.L$5
            goto L688
        Lf0f:
            kotlinx.coroutines.sync.Mutex r7 = androidx.paging.PageFetcherSnapshotState.Holder.access$getLock$p(r2)
            goto L112c
        Lf17:
            r0.<init>(r1)
            goto L709
        Lf1e:
            r3.L$9 = r14
            goto L789
        Lf24:
            r3.L$7 = r5
            goto L108a
        Lf2a:
            kotlinx.coroutines.sync.Mutex r0 = (kotlinx.coroutines.sync.Mutex) r0
            goto L833
        Lf30:
            if (r1 == r2) goto Lf35
            goto L2a7
        Lf35:
            goto L41b
        Lf39:
            java.lang.string r13 = " on "
            goto L9ae
        Lf3f:
            androidx.paging.PageFetcherSnapshotState$Holder r12 = (androidx.paging.PageFetcherSnapshotState.Holder) r12
            goto Lf9a
        Lf45:
            r11 = r12
            goto L52c
        Lf4a:
            r7 = r0
            goto L79c
        Lf4f:
            r8 = r12
            goto L7b2
        Lf54:
            java.lang.object r8 = r3.L$1
            goto Lfce
        Lf5a:
            r1.requestLoad(r5, r2)
        Lf5d:
            goto L626
        Lf61:
            androidx.paging.PageFetcherSnapshotState$Holder<Key, Value> r5 = r0.stateHolder
            goto L360
        Lf67:
            r8 = r15
            goto L8b2
        Lf6c:
            goto La1
        Lf6e:
            goto L21b
        Lf72:
            java.lang.object r12 = r3.L$4
            goto Lb45
        Lf78:
            T r1 = r7.element
            goto L465
        Lf7e:
            java.lang.string r5 = r5.tostring()
            goto La73
        Lf86:
            java.lang.object r0 = r0.getNextKey()
            goto L8bd
        Lf8e:
            java.lang.object r8 = r3.L$5
            goto L11af
        Lf94:
            androidx.paging.LoadType r1 = androidx.paging.LoadType.PREPEND
        Lf96:
            goto La28
        Lf9a:
            java.lang.object r13 = r3.L$5
            goto L111
        Lfa0:
            r3.L$0 = r8
            goto L5e2
        Lfa6:
            java.lang.object r0 = r3.L$9
            goto L5ee
        Lfac:
            throw r0
        Lfad:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException     // Catch: java.lang.Exception -> Lfb3
            r0.<init>(r6)     // Catch: java.lang.Exception -> Lfb3
            throw r0     // Catch: java.lang.Exception -> Lfb3
        Lfb3:
            r0 = move-exception
            goto L1151
        Lfb8:
            r12 = r8
            goto L31f
        Lfbd:
            int r0 = r3.I$1
            goto L867
        Lfc3:
            goto L1b
        Lfc5:
            goto L4c4
        Lfc9:
            r11 = r14
            goto L782
        Lfce:
            androidx.paging.LoadType r8 = (androidx.paging.LoadType) r8
            goto L37d
        Lfd4:
            r14 = 0
            goto Lc1a
        Lfd9:
            r3.label = r10
            goto Le23
        Lfdf:
            if (r2 == r4) goto Lfe4
            goto L8a8
        Lfe4:
            goto L8a6
        Lfe8:
            java.lang.object r1 = r1.getNextKey()
            goto L2a5
        Lff0:
            r3.L$6 = r2
            goto L66a
        Lff6:
            java.lang.stringBuilder r5 = r5.append(r11)
            goto L128
        Lffe:
            androidx.paging.PageFetcherSnapshot r11 = (androidx.paging.PageFetcherSnapshot) r11
            goto L1033
        L1004:
            r5 = r1
            goto L1138
        L1009:
            r14 = 0
        L100a:
            goto L82d
        L100e:
            kotlin.ResultKt.throwOnFailure(r2)
            goto L744
        L1015:
            r3.L$4 = r2
            goto L4e0
        L101b:
            java.lang.object r13 = r5.lock(r10, r3)
            goto L16
        L1023:
            r3.L$5 = r0
            goto L2cc
        L1029:
            r0 = r7
            goto L8a1
        L102e:
            r10 = 0
            goto Le6d
        L1033:
            kotlin.ResultKt.throwOnFailure(r2)
            goto Lfb8
        L103a:
            r0.log(r15, r2, r1)
        L103d:
            goto L6f
        L1041:
            java.lang.object r0 = r1.getNextKey()
            goto L11e9
        L1049:
            r5 = r1
            goto L518
        L104e:
            r3.label = r13
            goto L101b
        L1054:
            if (r2 == r4) goto L1059
            goto L898
        L1059:
            goto L896
        L105d:
            if (r1 != 0) goto L1062
            goto L798
        L1062:
            goto L67c
        L1066:
            r3.L$2 = r12
            goto L7d7
        L106c:
            r1.unlock(r14)
            goto Lca5
        L1073:
            r2 = r1
            goto Ldb
        L1078:
            kotlin.ResultKt.throwOnFailure(r2)
            goto L581
        L107f:
            r14 = r13
            goto Lc9a
        L1084:
            java.lang.object r8 = r3.L$5
            goto L1190
        L108a:
            r3.L$8 = r1
            goto Lf1e
        L1090:
            androidx.paging.RemoteMediatorConnection<Key, Value> r0 = r14.remoteMediatorConnection
            goto Ldbd
        L1096:
            r0 = r9
            goto Lb58
        L109b:
            java.lang.object r14 = r3.L$0
            goto L719
        L10a1:
            java.lang.object r15 = r2.lock(r10, r3)
            goto L11d8
        L10a9:
            androidx.paging.GenerationalobjectportHint r7 = (androidx.paging.GenerationalobjectportHint) r7
            goto L125c
        L10af:
            r10 = 8
            goto L1274
        L10b5:
            androidx.paging.LoadType r5 = (androidx.paging.LoadType) r5
            goto L4be
        L10bb:
            kotlinx.coroutines.sync.Mutex r0 = (kotlinx.coroutines.sync.Mutex) r0
            goto Lbfe
        L10c1:
            r1 = r14
            goto L107f
        L10c6:
            T r2 = r9.element
            goto L7dd
        L10cc:
            goto L2ae
        L10cf:
            goto Ldde
        L10d3:
            goto L1b
        L10d5:
            goto L11b5
        L10d9:
            goto Le3f
        L10db:
            r0 = move-exception
        L10dc:
            goto L5d7
        L10e0:
            java.lang.string r1 = "call to 'resume' before 'invoke' with coroutine"
            goto Lf17
        L10e6:
            T r13 = r7.element
            goto L413
        L10ec:
            java.lang.object r7 = r3.L$1
            goto L300
        L10f2:
            java.lang.string r1 = r6.tostring()
            goto La4d
        L10fa:
            r0.log(r11, r1, r14)
        L10fd:
            goto L35
        L1101:
            r1 = r0
            goto Lc09
        L1106:
            androidx.paging.PageFetcherSnapshot r15 = (androidx.paging.PageFetcherSnapshot) r15
            kotlin.ResultKt.throwOnFailure(r2)     // Catch: java.lang.Exception -> L10db
            goto L10d9
        L110f:
            androidx.paging.PagingConsoleger r0 = androidx.paging.PagingConsoleger.INSTANCE
            goto L378
        L1115:
            r7 = r14
            goto Ld0c
        L111a:
            goto L421
        L111c:
            goto L420
        L1120:
            androidx.paging.GenerationalobjectportHint r4 = (androidx.paging.GenerationalobjectportHint) r4
            goto Le93
        L1126:
            goto L758
        L1128:
            goto L53f
        L112c:
            r3.L$0 = r0
            goto L221
        L1132:
            java.lang.object r14 = r3.L$0
            goto L74a
        L1138:
            r1 = r16
        L113a:
            goto L306
        L113e:
            java.lang.string r2 = r14.loadResultConsole(r13, r2, r5)
            goto L103a
        L1146:
            java.lang.object r14 = r3.L$2
            goto L676
        L114c:
            throw r0
        L114d:
            goto La3c
        L1151:
            r14 = 0
            goto L34d
        L1156:
            goto Lc2f
        L1158:
            goto L8b8
        L115c:
            kotlin.jvm.internal.Ref$IntRef r9 = (kotlin.jvm.internal.Ref.IntRef) r9
            goto Le61
        L1162:
            r3.I$1 = r0
            goto L126e
        L1168:
            r14 = 0
            goto L27e
        L116d:
            java.lang.object r8 = r3.L$4
            goto Ldc3
        L1173:
            if (r0 != 0) goto L1178
            goto L11ee
        L1178:
            goto L6f6
        L117c:
            goto L783
        L117e:
            goto Lfa6
        L1182:
            r3.L$3 = r11
            goto L256
        L1188:
            kotlinx.coroutines.sync.Mutex r2 = androidx.paging.PageFetcherSnapshotState.Holder.access$getLock$p(r14)
            goto Laeb
        L1190:
            kotlin.jvm.internal.Ref$boolRef r8 = (kotlin.jvm.internal.Ref.boolRef) r8
            goto L9d8
        L1196:
            r12 = r14
            goto Ld66
        L119b:
            java.lang.stringBuilder r0 = r1.append(r0)
            goto L12e
        L11a3:
            java.lang.object r12 = r3.L$3
            goto La95
        L11a9:
            kotlin.Unit r0 = kotlin.Unit.INSTANCE
            goto L140
        L11af:
            kotlin.jvm.internal.Ref$boolRef r8 = (kotlin.jvm.internal.Ref.boolRef) r8
            goto Ld22
        L11b5:
            r5 = r7
            goto L90c
        L11ba:
            java.lang.object r5 = r3.L$4
            goto Lebd
        L11c0:
            kotlin.jvm.internal.Ref$boolRef r1 = (kotlin.jvm.internal.Ref.boolRef) r1
            goto L11ba
        L11c6:
            java.lang.object r11 = r3.L$3
            goto Le9
        L11cc:
            r0 = r8
            goto Le56
        L11d1:
            goto L10cf
        L11d4:
            goto Ld28
        L11d8:
            if (r15 == r4) goto L11dd
            goto L9a5
        L11dd:
            goto L9a3
        L11e1:
            java.lang.stringBuilder r5 = r5.append(r13)
            goto L10e6
        L11e9:
            if (r0 == 0) goto L11ee
            goto L407
        L11ee:
            goto L405
        L11f2:
            java.lang.object r11 = r3.L$0
            goto L1286
        L11f8:
            r0 = r1
            goto L1232
        L11fd:
            bool r3 = r2 is androidx.paging.PageFetcherSnapshot.C07381
            goto Lbdf
        L1203:
            java.lang.object r1 = r3.L$4
            goto L8b
        L1209:
            r11 = r8
            goto Lf67
        L120e:
            goto L113a
        L1210:
            r0 = move-exception
        L1211:
            goto L80e
        L1215:
            throw r0
        L1216:
            goto L6b2
        L121a:
            int r2 = r3.label
            goto L97b
        L1220:
            int[] r1 = androidx.paging.PageFetcherSnapshot.WhenDictionarypings.$EnumSwitchDictionaryping$0
            goto L445
        L1226:
            androidx.paging.LoadType r0 = androidx.paging.LoadType.PREPEND
            goto L824
        L122c:
            kotlin.jvm.internal.Ref$objectRef r7 = (kotlin.jvm.internal.Ref.objectRef) r7
            goto L5b0
        L1232:
            goto L5e
        L1234:
            goto Lab9
        L1238:
            r1 = r2
            goto L7f7
        L123d:
            r2 = 2
            goto L858
        L1242:
            androidx.paging.PagingSource$LoadResult$Page r0 = (androidx.paging.PagingSource.LoadResult.Page) r0
            goto Lf86
        L1248:
            kotlinx.coroutines.sync.Mutex r5 = androidx.paging.PageFetcherSnapshotState.Holder.access$getLock$p(r2)
            goto Ld5
        L1250:
            r3.L$0 = r8
            goto L44d
        L1256:
            java.lang.object r13 = r3.L$1
            goto L4b2
        L125c:
            java.lang.object r8 = r3.L$1
            goto L489
        L1262:
            androidx.paging.PagingSource$LoadResult r5 = (androidx.paging.PagingSource.LoadResult) r5
            goto L4da
        L1268:
            java.lang.IllegalStateException r1 = new java.lang.IllegalStateException
            goto L3c2
        L126e:
            r13 = 11
            goto L104e
        L1274:
            r3.label = r10
            goto L348
        L127a:
            java.lang.object r1 = r3.L$2
            goto L73e
        L1280:
            java.lang.object r9 = r3.L$2
            goto L659
        L1286:
            androidx.paging.PageFetcherSnapshot r11 = (androidx.paging.PageFetcherSnapshot) r11
            goto L1078
    }

    private readonly androidx.paging.PagingSource.LoadParams<Key> LoadParams(androidx.paging.LoadType r3, Key r4) {
            r2 = this;
            goto L4
        L4:
            goto Le
        L7:
            goto L7d
        Lb:
            goto L1e
        Le:
            goto L22
        L12:
            if (r3 == r1) goto L17
            goto L2c
        L17:
            goto L49
        L1b:
            goto L79
        L1e:
            goto L5e
        L22:
            goto L7
        L25:
            int r1 = r1.pageSize
        L27:
            goto L30
        L2b:
            goto L27
        L2c:
            goto L6a
        L30:
            androidx.paging.PagingConfig r2 = r2.config
            goto L64
        L36:
            androidx.paging.LoadType r1 = androidx.paging.LoadType.REFRESH
            goto L12
        L3c:
            r1 = 4
            goto L4f
        L43:
            int r1 = r1.initialLoadSize
            goto L2b
        L49:
            androidx.paging.PagingConfig r1 = r2.config
            goto L43
        L4f:
            int r0 = r0 + r1
            goto L84
        L55:
            if (r0 <= 0) goto L5a
            goto L1e
        L5a:
            goto L1b
        L5e:
            androidx.paging.PagingSource$LoadParams$Companion r0 = androidx.paging.PagingSource.LoadParams.Companion
            goto L36
        L64:
            bool r2 = r2.enablePlaceholders
            goto L70
        L6a:
            androidx.paging.PagingConfig r1 = r2.config
            goto L25
        L70:
            androidx.paging.PagingSource$LoadParams r2 = r0.create(r3, r4, r1, r2)
            goto L78
        L78:
            return r2
        L79:
            goto Lb
        L7d:
            r0 = 7
            goto L3c
        L84:
            int r0 = r0 % r1
            goto L55
    }

    private readonly java.lang.string LoadResultConsole(androidx.paging.LoadType r2, Key r3, androidx.paging.PagingSource.LoadResult<Key, Value> r4) {
            r1 = this;
            goto L40
        L4:
            r4.<init>(r1)
            goto L24
        Lb:
            return r1
        Lc:
            goto L85
        L10:
            java.lang.stringBuilder r1 = r1.append(r3)
            goto L1e
        L18:
            java.lang.string r2 = ". Returned "
            goto L75
        L1e:
            java.lang.string r2 = ". Load CANCELLED."
            goto L7d
        L24:
            java.lang.stringBuilder r1 = r4.append(r2)
            goto L67
        L2c:
            java.lang.string r1 = "End "
            goto L5e
        L32:
            java.lang.string r2 = " with loadKey "
            goto L9e
        L38:
            java.lang.string r1 = r1.tostring()
            goto Lac
        L40:
            goto Lad
        L43:
            goto L2c
        L47:
            java.lang.string r1 = r1.tostring()
            goto Lb
        L4f:
            java.lang.stringBuilder r1 = r1.append(r4)
            goto L38
        L57:
            r0.<init>(r1)
            goto L6d
        L5e:
            if (r4 == 0) goto L63
            goto Lc
        L63:
            goto La6
        L67:
            java.lang.string r2 = " with loadkey "
            goto L93
        L6d:
            java.lang.stringBuilder r1 = r0.append(r2)
            goto L32
        L75:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L4f
        L7d:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L47
        L85:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L57
        L8b:
            java.lang.stringBuilder r1 = r1.append(r3)
            goto L18
        L93:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L10
        L9b:
            goto L43
        L9e:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L8b
        La6:
            java.lang.stringBuilder r4 = new java.lang.stringBuilder
            goto L4
        Lac:
            return r1
        Lad:
            goto L9b
    }

    private readonly Key NextLoadKeyOrNull(androidx.paging.PageFetcherSnapshotState<Key, Value> r3, androidx.paging.LoadType r4, int r5, int r6) {
            r2 = this;
            goto La3
        L4:
            if (r5 != 0) goto L9
            goto L70
        L9:
            goto L6f
        Ld:
            androidx.paging.PagingConfig r2 = r2.config
            goto L33
        L13:
            androidx.paging.MutableLoadStateICollection r5 = r3.getSourceLoadStates$paging_common_release()
            goto Le5
        L1b:
            if (r4 == r2) goto L20
            goto Ldc
        L20:
            goto Lc0
        L24:
            java.util.List r2 = r3.getPages$paging_common_release()
            goto L7a
        L2c:
            goto L65
        L2f:
            goto L39
        L33:
            int r2 = r2.prefetchDistance
            goto Lb7
        L39:
            int r0 = r3.generationId$paging_common_release(r4)
            goto L5c
        L41:
            java.lang.object r2 = r2.getPrevKey()
            goto Ldb
        L49:
            java.lang.object r2 = r2.getNextKey()
            goto L64
        L51:
            bool r5 = r5 is androidx.paging.LoadState.Error
            goto L4
        L57:
            return r1
        L58:
            goto L13
        L5c:
            r1 = 0
            goto L82
        L61:
            goto La6
        L64:
            return r2
        L65:
            goto Laa
        L69:
            androidx.paging.PagingSource$LoadResult$Page r2 = (androidx.paging.PagingSource.LoadResult.Page) r2
            goto L49
        L6f:
            return r1
        L70:
            goto Ld
        L74:
            int r0 = r0 % r1
            goto L93
        L7a:
            java.lang.object r2 = kotlin.collections.ICollectionsKt.last(r2)
            goto L69
        L82:
            if (r5 != r0) goto L87
            goto L58
        L87:
            goto L57
        L8b:
            java.lang.object r2 = kotlin.collections.ICollectionsKt.first(r2)
            goto Ld5
        L93:
            if (r0 <= 0) goto L98
            goto L2f
        L98:
            goto L2c
        L9c:
            r1 = 13
            goto Lb1
        La3:
            goto Lad
        La6:
            goto Lc8
        Laa:
            goto L2f
        Lad:
            goto L61
        Lb1:
            int r0 = r0 + r1
            goto L74
        Lb7:
            if (r6 >= r2) goto Lbc
            goto Le1
        Lbc:
            goto Le0
        Lc0:
            java.util.List r2 = r3.getPages$paging_common_release()
            goto L8b
        Lc8:
            r0 = 10
            goto L9c
        Lcf:
            androidx.paging.LoadType r2 = androidx.paging.LoadType.PREPEND
            goto L1b
        Ld5:
            androidx.paging.PagingSource$LoadResult$Page r2 = (androidx.paging.PagingSource.LoadResult.Page) r2
            goto L41
        Ldb:
            return r2
        Ldc:
            goto L24
        Le0:
            return r1
        Le1:
            goto Lcf
        Le5:
            androidx.paging.LoadState r5 = r5[r4)
            goto L51
    }

    private readonly void OnInvalidLoad() {
            r0 = this;
            goto Le
        L4:
            goto L11
        L7:
            r0.invalidate()
            goto L22
        Le:
            goto L23
        L11:
            goto L15
        L15:
            r0.Dispose()
            goto L1c
        L1c:
            androidx.paging.PagingSource<Key, Value> r0 = r0.pagingSource
            goto L7
        L22:
            return
        L23:
            goto L4
    }

    private readonly java.lang.object RetryLoadError(androidx.paging.LoadType r3, androidx.paging.objectportHint r4, kotlin.coroutines.Continuation<kotlin.Unit> r5) {
            r2 = this;
            goto L74
        L4:
            return r2
        L5:
            goto L21
        L9:
            throw r2
        La:
            goto L6d
        Le:
            r2.<init>(r3)
            goto L9
        L15:
            return r2
        L16:
            goto L9c
        L1a:
            r1 = 5
            goto L33
        L21:
            if (r4 != 0) goto L26
            goto Lb2
        L26:
            goto Lb6
        L2a:
            if (r0 <= 0) goto L2f
            goto L85
        L2f:
            goto L82
        L33:
            int r0 = r0 + r1
            goto L57
        L39:
            goto L77
        L3c:
            java.lang.IllegalStateException r2 = new java.lang.IllegalStateException
            goto L42
        L42:
            java.lang.string r3 = "Cannot retry APPEND / PREPEND load on PagingSource without objectportHint"
            goto L94
        L48:
            if (r2 == r3) goto L4d
            goto L16
        L4d:
            goto L15
        L51:
            r0 = r0[r1]
            goto L8f
        L57:
            int r0 = r0 % r1
            goto L2a
        L5d:
            java.lang.object r2 = r2.doInitialLoad(r5)
            goto La2
        L65:
            int r1 = r3.ordinal()
            goto L51
        L6d:
            goto L85
        L70:
            goto L39
        L74:
            goto L70
        L77:
            goto Laa
        L7b:
            r2.forceHashSetHint(r3, r4)
            goto L89
        L82:
            goto La
        L85:
            goto Lc5
        L89:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto Lb1
        L8f:
            r1 = 1
            goto Lbc
        L94:
            java.lang.string r3 = r3.tostring()
            goto Le
        L9c:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto L4
        La2:
            java.lang.object r3 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L48
        Laa:
            r0 = 29
            goto L1a
        Lb1:
            return r2
        Lb2:
            goto L3c
        Lb6:
            androidx.paging.HintHandler r2 = r2.hintHandler
            goto L7b
        Lbc:
            if (r0 == r1) goto Lc1
            goto L5
        Lc1:
            goto L5d
        Lc5:
            int[] r0 = androidx.paging.PageFetcherSnapshot.WhenDictionarypings.$EnumSwitchDictionaryping$0
            goto L65
    }

    private readonly java.lang.object SetError(androidx.paging.PageFetcherSnapshotState<Key, Value> r2, androidx.paging.LoadType r3, androidx.paging.LoadState.Error r4, kotlin.coroutines.Continuation<kotlin.Unit> r5) {
            r1 = this;
            goto L69
        L4:
            if (r1 == r2) goto L9
            goto L5d
        L9:
            goto L5c
        Ld:
            return r1
        Le:
            goto L90
        L12:
            kotlinx.coroutines.channels.Channel<androidx.paging.PageEvent<Value>> r1 = r1.pageEventCh
            goto L39
        L18:
            r4 = 0
            goto L3f
        L1d:
            androidx.paging.MutableLoadStateICollection r0 = r2.getSourceLoadStates$paging_common_release()
            goto L25
        L25:
            androidx.paging.LoadState r4 = (androidx.paging.LoadState) r4
            goto L99
        L2b:
            if (r0 == 0) goto L30
            goto L35
        L30:
            goto L1d
        L34:
            return r1
        L35:
            goto L4e
        L39:
            androidx.paging.PageEvent$LoadStateUpdate r3 = new androidx.paging.PageEvent$LoadStateUpdate
            goto L46
        L3f:
            r3.<init>(r2, r4)
            goto L54
        L46:
            androidx.paging.MutableLoadStateICollection r2 = r2.getSourceLoadStates$paging_common_release()
            goto L78
        L4e:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto Ld
        L54:
            java.lang.object r1 = r1.send(r3, r5)
            goto L61
        L5c:
            return r1
        L5d:
            goto L93
        L61:
            java.lang.object r2 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L4
        L69:
            goto Le
        L6c:
            goto L80
        L70:
            androidx.paging.LoadState r0 = r0[r3)
            goto L88
        L78:
            androidx.paging.LoadStates r2 = r2.snapshot()
            goto L18
        L80:
            androidx.paging.MutableLoadStateICollection r0 = r2.getSourceLoadStates$paging_common_release()
            goto L70
        L88:
            bool r0 = kotlin.jvm.internal.Intrinsics.areEqual(r0, r4)
            goto L2b
        L90:
            goto L6c
        L93:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L34
        L99:
            r0.set(r3, r4)
            goto L12
    }

    private readonly java.lang.object SetLoading(androidx.paging.PageFetcherSnapshotState<Key, Value> r3, androidx.paging.LoadType r4, kotlin.coroutines.Continuation<kotlin.Unit> r5) {
            r2 = this;
            goto La
        L4:
            int r0 = r0 % r1
            goto Ld4
        La:
            goto L93
        Ld:
            goto L35
        L11:
            return r2
        L12:
            goto L90
        L16:
            androidx.paging.LoadState r0 = r0[r4)
            goto L47
        L1e:
            androidx.paging.MutableLoadStateICollection r3 = r3.getSourceLoadStates$paging_common_release()
            goto Lcc
        L26:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto L42
        L2c:
            if (r0 == 0) goto L31
            goto L43
        L31:
            goto L82
        L35:
            r0 = 23
            goto L9f
        L3c:
            int r0 = r0 + r1
            goto L4
        L42:
            return r2
        L43:
            goto L8a
        L47:
            androidx.paging.LoadState$Loading r1 = androidx.paging.LoadState.Loading.INSTANCE
            goto L97
        L4d:
            kotlinx.coroutines.channels.Channel<androidx.paging.PageEvent<Value>> r2 = r2.pageEventCh
            goto L53
        L53:
            androidx.paging.PageEvent$LoadStateUpdate r4 = new androidx.paging.PageEvent$LoadStateUpdate
            goto L1e
        L59:
            r4.<init>(r3, r0)
            goto La9
        L60:
            androidx.paging.MutableLoadStateICollection r0 = r3.getSourceLoadStates$paging_common_release()
            goto L16
        L68:
            if (r2 == r3) goto L6d
            goto L7e
        L6d:
            goto L7d
        L71:
            goto L12
        L74:
            goto L60
        L78:
            r0 = 0
            goto L59
        L7d:
            return r2
        L7e:
            goto L26
        L82:
            androidx.paging.MutableLoadStateICollection r0 = r3.getSourceLoadStates$paging_common_release()
            goto Lc0
        L8a:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto L11
        L90:
            goto L74
        L93:
            goto La6
        L97:
            bool r0 = kotlin.jvm.internal.Intrinsics.areEqual(r0, r1)
            goto L2c
        L9f:
            r1 = 20
            goto L3c
        La6:
            goto Ld
        La9:
            java.lang.object r2 = r2.send(r4, r5)
            goto Lb8
        Lb1:
            r0.set(r4, r1)
            goto L4d
        Lb8:
            java.lang.object r3 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L68
        Lc0:
            androidx.paging.LoadState$Loading r1 = androidx.paging.LoadState.Loading.INSTANCE
            goto Lc6
        Lc6:
            androidx.paging.LoadState r1 = (androidx.paging.LoadState) r1
            goto Lb1
        Lcc:
            androidx.paging.LoadStates r3 = r3.snapshot()
            goto L78
        Ld4:
            if (r0 <= 0) goto Ld9
            goto L74
        Ld9:
            goto L71
    }

    private readonly void StartConsumingHints(kotlinx.coroutines.CoroutineScope r17) {
            r16 = this;
            goto L53
        L4:
            int r1 = r1.jumpThreshold
            goto L48
        La:
            r13 = r1
            goto Lb8
        Lf:
            int r0 = r0 + r1
            goto L2e
        L15:
            r7 = r1
            goto L8b
        L1a:
            r0 = r16
            goto L5a
        L20:
            r0 = 10
            goto Lca
        L27:
            kotlinx.coroutines.BuildersKt.launch$default(r10, r11, r12, r13, r14, r15)
            goto Lea
        L2e:
            int r0 = r0 % r1
            goto L98
        L34:
            kotlinx.coroutines.BuildersKt.launch$default(r10, r11, r12, r13, r14, r15)
            goto L3b
        L3b:
            androidx.paging.PageFetcherSnapshot$startConsumingHints$3 r1 = new androidx.paging.PageFetcherSnapshot$startConsumingHints$3
            goto L41
        L41:
            r1.<init>(r0, r3)
            goto La
        L48:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L66
        L4e:
            r5 = 0
            goto Lac
        L53:
            goto Lc1
        L56:
            goto L20
        L5a:
            androidx.paging.PagingConfig r1 = r0.config
            goto L4
        L60:
            r10 = r17
            goto L34
        L66:
            r3 = 0
            goto Ld1
        L6b:
            goto L56
        L6e:
            r9 = 0
            goto L4e
        L73:
            kotlin.jvm.functions.Function2 r13 = (kotlin.jvm.functions.Function2) r13
            goto Lef
        L79:
            r8 = 3
            goto L6e
        L7e:
            kotlinx.coroutines.BuildersKt.launch$default(r4, r5, r6, r7, r8, r9)
        L81:
            goto La6
        L85:
            r4 = r17
            goto L7e
        L8b:
            kotlin.jvm.functions.Function2 r7 = (kotlin.jvm.functions.Function2) r7
            goto L79
        L91:
            goto Leb
        L94:
            goto L1a
        L98:
            if (r0 <= 0) goto L9d
            goto L94
        L9d:
            goto L91
        La1:
            r13 = r1
            goto L73
        La6:
            androidx.paging.PageFetcherSnapshot$startConsumingHints$2 r1 = new androidx.paging.PageFetcherSnapshot$startConsumingHints$2
            goto Lb1
        Lac:
            r6 = 0
            goto L85
        Lb1:
            r1.<init>(r0, r3)
            goto La1
        Lb8:
            kotlin.jvm.functions.Function2 r13 = (kotlin.jvm.functions.Function2) r13
            goto L27
        Lbe:
            goto L94
        Lc1:
            goto L6b
        Lc5:
            r11 = 0
            goto Lda
        Lca:
            r1 = 3
            goto Lf
        Ld1:
            if (r1 != r2) goto Ld6
            goto L81
        Ld6:
            goto Ldf
        Lda:
            r12 = 0
            goto L60
        Ldf:
            androidx.paging.PageFetcherSnapshot$startConsumingHints$1 r1 = new androidx.paging.PageFetcherSnapshot$startConsumingHints$1
            goto Lf4
        Le5:
            r15 = 0
            goto Lc5
        Lea:
            return
        Leb:
            goto Lbe
        Lef:
            r14 = 3
            goto Le5
        Lf4:
            r1.<init>(r0, r3)
            goto L15
    }

    public readonly void AccessHint(androidx.paging.objectportHint r2) {
            r1 = this;
            goto La
        L4:
            androidx.paging.HintHandler r1 = r1.hintHandler
            goto L20
        La:
            goto L1c
        Ld:
            goto L11
        L11:
            java.lang.string r0 = "viewportHint"
            goto L27
        L18:
            goto Ld
        L1b:
            return
        L1c:
            goto L18
        L20:
            r1.processHint(r2)
            goto L1b
        L27:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L4
    }

    public readonly void Close() {
            r2 = this;
            goto L44
        L4:
            int r0 = r0 + r1
            goto L4b
        La:
            r0 = 20
            goto L36
        L11:
            if (r0 <= 0) goto L16
            goto L29
        L16:
            goto L26
        L1a:
            r1 = 1
            goto L3d
        L1f:
            goto L29
        L22:
            goto L33
        L26:
            goto L52
        L29:
            goto L5b
        L2d:
            kotlinx.coroutines.Job r2 = (kotlinx.coroutines.Job) r2
            goto L56
        L33:
            goto L47
        L36:
            r1 = 29
            goto L4
        L3d:
            kotlinx.coroutines.Job.DefaultImpls.cancel$default(r2, r0, r1, r0)
            goto L51
        L44:
            goto L22
        L47:
            goto La
        L4b:
            int r0 = r0 % r1
            goto L11
        L51:
            return
        L52:
            goto L1f
        L56:
            r0 = 0
            goto L1a
        L5b:
            kotlinx.coroutines.CompletableJob r2 = r2.pageEventChannelFlowJob
            goto L2d
    }

    public readonly java.lang.object CurrentPagingState(kotlin.coroutines.Continuation<? super androidx.paging.PagingState<Key, Value>> r6) {
            r5 = this;
            goto L13e
        L4:
            r2 = r5
            goto Lc2
        L9:
            throw r5
        La:
            goto L167
        Le:
            java.lang.object r0 = r0.L$0
            goto L105
        L14:
            int r6 = r0.label
            goto L5c
        L1a:
            java.lang.IllegalStateException r5 = new java.lang.IllegalStateException
            goto L118
        L20:
            goto L4c
        L21:
            goto L3e
        L25:
            kotlinx.coroutines.sync.Mutex r2 = androidx.paging.PageFetcherSnapshotState.Holder.access$getLock$p(r6)
            goto Lb3
        L2d:
            return r1
        L2e:
            goto Lcf
        L32:
            if (r0 != 0) goto L37
            goto L21
        L37:
            goto L89
        L3b:
            goto L141
        L3e:
            androidx.paging.PageFetcherSnapshot$currentPagingState$1 r0 = new androidx.paging.PageFetcherSnapshot$currentPagingState$1
            goto L49
        L44:
            throw r5
        L45:
            goto L6d
        L49:
            r0.<init>(r5, r6)
        L4c:
            goto L56
        L50:
            androidx.paging.PageFetcherSnapshot$currentPagingState$1 r0 = (androidx.paging.PageFetcherSnapshot.C07361) r0
            goto L7d
        L56:
            java.lang.object r6 = r0.result
            goto Lc7
        L5c:
            int r6 = r6 - r2
            goto L61
        L61:
            r0.label = r6
            goto L20
        L67:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto La7
        L6d:
            goto L157
        L70:
            goto L3b
        L74:
            if (r2 == r4) goto L79
            goto L163
        L79:
            goto L94
        L7d:
            int r1 = r0.label
            goto L67
        L83:
            bool r0 = r6 is androidx.paging.PageFetcherSnapshot.C07361
            goto L32
        L89:
            r0 = r6
            goto L50
        L8e:
            androidx.paging.PageFetcherSnapshotState$Holder<Key, Value> r6 = r5.stateHolder
            goto L25
        L94:
            java.lang.object r5 = r0.L$2
            goto Le2
        L9a:
            int r2 = r0.label
            goto L132
        La0:
            kotlin.ResultKt.throwOnFailure(r6)
            goto L4
        La7:
            r1 = r1 & r2
            goto Lb9
        Lac:
            r1 = 3
            goto L11e
        Lb3:
            r0.L$0 = r5
            goto Le8
        Lb9:
            if (r1 != 0) goto Lbe
            goto L21
        Lbe:
            goto L14
        Lc2:
            r5 = r0
            goto L161
        Lc7:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L9a
        Lcf:
            r1 = r6
        Ld0:
            androidx.paging.PageFetcherSnapshotState r6 = androidx.paging.PageFetcherSnapshotState.Holder.access$getState$p(r1)     // Catch: java.lang.Exception -> L175
            androidx.paging.HintHandler r5 = r5.hintHandler     // Catch: java.lang.Exception -> L175
            androidx.paging.objectportHint$Access r5 = r5.getLastAccessHint()     // Catch: java.lang.Exception -> L175
            androidx.paging.PagingState r5 = r6.currentPagingState$paging_common_release(r5)     // Catch: java.lang.Exception -> L175
            goto L111
        Le2:
            kotlinx.coroutines.sync.Mutex r5 = (kotlinx.coroutines.sync.Mutex) r5
            goto Lf6
        Le8:
            r0.L$1 = r6
            goto L10b
        Lee:
            java.lang.object r0 = r2.lock(r3, r0)
            goto L14b
        Lf6:
            java.lang.object r1 = r0.L$1
            goto L145
        Lfc:
            if (r2 != 0) goto L101
            goto La
        L101:
            goto L74
        L105:
            androidx.paging.PageFetcherSnapshot r0 = (androidx.paging.PageFetcherSnapshot) r0
            goto La0
        L10b:
            r0.L$2 = r2
            goto L15b
        L111:
            r2.unlock(r3)
            goto L174
        L118:
            java.lang.string r6 = "call to 'resume' before 'invoke' with coroutine"
            goto L137
        L11e:
            int r0 = r0 + r1
            goto L16e
        L124:
            if (r0 <= 0) goto L129
            goto L157
        L129:
            goto L154
        L12d:
            r4 = 1
            goto Lfc
        L132:
            r3 = 0
            goto L12d
        L137:
            r5.<init>(r6)
            goto L9
        L13e:
            goto L70
        L141:
            goto L17a
        L145:
            androidx.paging.PageFetcherSnapshotState$Holder r1 = (androidx.paging.PageFetcherSnapshotState.Holder) r1
            goto Le
        L14b:
            if (r0 == r1) goto L150
            goto L2e
        L150:
            goto L2d
        L154:
            goto L45
        L157:
            goto L83
        L15b:
            r0.label = r4
            goto Lee
        L161:
            goto Ld0
        L163:
            goto L1a
        L167:
            kotlin.ResultKt.throwOnFailure(r6)
            goto L8e
        L16e:
            int r0 = r0 % r1
            goto L124
        L174:
            return r5
        L175:
            r5 = move-exception
            goto L181
        L17a:
            r0 = 27
            goto Lac
        L181:
            r2.unlock(r3)
            goto L44
    }

    public readonly Key getInitialKey$paging_common_release() {
            r0 = this;
            goto L12
        L4:
            goto L15
        L7:
            Key r0 = r0.initialKey
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

    public readonly kotlinx.coroutines.flow.Flow<androidx.paging.PageEvent<Value>> GetPageEventFlow() {
            r0 = this;
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
            kotlinx.coroutines.flow.Flow<androidx.paging.PageEvent<Value>> r0 = r0.pageEventFlow
            goto Le
    }

    public readonly androidx.paging.PagingSource<Key, Value> getPagingSource$paging_common_release() {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto Le
        Le:
            androidx.paging.PagingSource<Key, Value> r0 = r0.pagingSource
            goto L14
        L14:
            return r0
        L15:
            goto L4
    }

    public readonly androidx.paging.RemoteMediatorConnection<Key, Value> GetRemoteMediatorConnection() {
            r0 = this;
            goto L12
        L4:
            androidx.paging.RemoteMediatorConnection<Key, Value> r0 = r0.remoteMediatorConnection
            goto La
        La:
            return r0
        Lb:
            goto Lf
        Lf:
            goto L15
        L12:
            goto Lb
        L15:
            goto L4
    }
}

