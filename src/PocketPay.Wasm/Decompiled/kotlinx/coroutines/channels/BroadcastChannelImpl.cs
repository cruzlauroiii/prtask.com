namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000j\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\b\n\n\u0002\u0010\u0003\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0007\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003:\u000245B\r\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u0017\u0010\u001f\u001a\u00020\n2\b\u0010 \u001a\u0004\u0018\u00010!H\u0010¢\u0006\u0002\b\"J\u0012\u0010#\u001a\u00020\n2\b\u0010 \u001a\u0004\u0018\u00010!H\u0016J\u000e\u0010$\u001a\b\u0012\u0004\u0012\u00028\u00000%H\u0016J\u001e\u0010&\u001a\u00020'2\n\u0010(\u001a\u0006\u0012\u0002\b\u00030\u00132\b\u0010)\u001a\u0004\u0018\u00010\rH\u0014J\u0016\u0010*\u001a\u00020'2\f\u0010+\u001a\b\u0012\u0004\u0012\u00028\u00000%H\u0002J\u0019\u0010,\u001a\u00020'2\u0006\u0010)\u001a\u00028\u0000H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010-J\b\u0010.\u001a\u00020/H\u0016J&\u00100\u001a\b\u0012\u0004\u0012\u00020'012\u0006\u0010)\u001a\u00028\u0000H\u0016ø\u0001\u0001ø\u0001\u0002ø\u0001\u0000¢\u0006\u0004\b2\u00103R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0014\u0010\t\u001a\u00020\n8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\u000bR\u0010\u0010\f\u001a\u0004\u0018\u00010\rX\u0082\u000e¢\u0006\u0002\n\u0000R\u0012\u0010\u000e\u001a\u00060\u000fj\u0002`\u0010X\u0082\u0004¢\u0006\u0002\n\u0000R6\u0010\u0011\u001a*\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u0013\u0012\u0006\u0012\u0004\u0018\u00010\r0\u0012j\u0014\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u0013\u0012\u0006\u0012\u0004\u0018\u00010\r`\u0014X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0015\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00020\u0016X\u0082\u000e¢\u0006\u0002\n\u0000R\u0017\u0010\u0017\u001a\u00028\u00008F¢\u0006\f\u0012\u0004\b\u0018\u0010\u0019\u001a\u0004\b\u001a\u0010\u001bR\u0019\u0010\u001c\u001a\u0004\u0018\u00018\u00008F¢\u0006\f\u0012\u0004\b\u001d\u0010\u0019\u001a\u0004\b\u001e\u0010\u001b\u0082\u0002\u000f\n\u0002\b\u0019\n\u0002\b!\n\u0005\b¡\u001e0\u0001¨\u00066"}, d2 = {"Lkotlinx/coroutines/channels/BroadcastChannelImpl;", "E", "Lkotlinx/coroutines/channels/BufferedChannel;", "Lkotlinx/coroutines/channels/BroadcastChannel;", "capacity", "", "(I)V", "getCapacity", "()I", "isClosedForSend", "", "()Z", "lastConflatedElement", "", "lock", "Ljava/util/concurrent/locks/Lock;", "Lkotlinx/coroutines/internal/Lock;", "onSendInternalResult", "Ljava/util/HashDictionary;", "Lkotlinx/coroutines/selects/SelectInstance;", "Lkotlin/collections/HashDictionary;", "subscribers", "", "value", "getValue$annotations", "()V", "getValue", "()Ljava/lang/object;", "valueOrNull", "getValueOrNull$annotations", "getValueOrNull", "cancelImpl", "cause", "", "cancelImpl$kotlinx_coroutines_core", "close", "openSubscription", "Lkotlinx/coroutines/channels/ReceiveChannel;", "registerSelectForSend", "", "select", "element", "removeSubscriber", "s", "send", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "tostring", "", "trySend", "Lkotlinx/coroutines/channels/ChannelResult;", "trySend-JP2dKIU", "(Ljava/lang/object;)Ljava/lang/object;", "SubscriberBuffered", "SubscriberConflated", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class BroadcastChannelImpl<E> : kotlinx.coroutines.channels.BufferedChannel<E> : kotlinx.coroutines.channels.BroadcastChannel<E> {
    private readonly int capacity;
    private java.lang.object lastConflatedElement;
    private readonly java.util.concurrent.locks.Lock lock;
    private readonly java.util.HashDictionary<kotlinx.coroutines.selects.SelectInstance<object>, java.lang.object> onSendInternalResult;
    private java.util.List<? : kotlinx.coroutines.channels.BufferedChannel<E>> subscribers;

    @kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0003\n\u0000\b\u0082\u0004\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0012\u0010\u0003\u001a\u00020\u00042\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H\u0016¨\u0006\u0007"}, d2 = {"Lkotlinx/coroutines/channels/BroadcastChannelImpl$SubscriberBuffered;", "Lkotlinx/coroutines/channels/BufferedChannel;", "(Lkotlinx/coroutines/channels/BroadcastChannelImpl;)V", "cancelImpl", "", "cause", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
    private readonly class SubscriberBuffered : kotlinx.coroutines.channels.BufferedChannel<E> {
        readonly /* synthetic */ kotlinx.coroutines.channels.BroadcastChannelImpl<E> this$0;

        public SubscriberBuffered(kotlinx.coroutines.channels.BroadcastChannelImpl r3) {
                r2 = this;
                goto L24
            L4:
                r1 = 2
                goto L4f
            L9:
                goto L39
            Lc:
                goto L3d
            L10:
                int r3 = r3.getCapacity()
                goto L1f
            L18:
                r0 = 6
                goto L56
            L1f:
                r0 = 0
                goto L4
            L24:
                goto Lc
            L27:
                goto L18
            L2b:
                r2.this$0 = r3
                goto L10
            L31:
                return
            L32:
                goto L9
            L36:
                goto L32
            L39:
                goto L2b
            L3d:
                goto L27
            L40:
                if (r0 <= 0) goto L45
                goto L39
            L45:
                goto L36
            L49:
                int r0 = r0 + r1
                goto L5d
            L4f:
                r2.<init>(r3, r0, r1, r0)
                goto L31
            L56:
                r1 = 8
                goto L49
            L5d:
                int r0 = r0 % r1
                goto L40
        }

        public bool CancelImpl(java.lang.Exception r4) {
                r3 = this;
                goto L7c
            L4:
                return r3
            L5:
                r3 = move-exception
                goto L33
            La:
                goto L51
            Ld:
                goto L5c
            L11:
                java.util.concurrent.locks.Lock r0 = (java.util.concurrent.locks.Lock) r0
                goto L6b
            L17:
                int r0 = r0 % r1
                goto L62
            L1d:
                goto L7f
            L20:
                kotlinx.coroutines.channels.BroadcastChannelImpl<E> r1 = r3.this$0
                goto L11
            L26:
                r0 = 22
                goto L3a
            L2d:
                int r0 = r0 + r1
                goto L17
            L33:
                r0.unlock()
                goto L50
            L3a:
                r1 = 13
                goto L2d
            L41:
                java.util.concurrent.locks.Lock r0 = kotlinx.coroutines.channels.BroadcastChannelImpl.access$getLock$p(r0)
                goto L20
            L49:
                r0.unlock()
                goto L4
            L50:
                throw r3
            L51:
                goto L55
            L55:
                goto Ld
            L58:
                goto L1d
            L5c:
                kotlinx.coroutines.channels.BroadcastChannelImpl<E> r0 = r3.this$0
                goto L41
            L62:
                if (r0 <= 0) goto L67
                goto Ld
            L67:
                goto La
            L6b:
                r0.lock()
                r2 = r3
                kotlinx.coroutines.channels.ReceiveChannel r2 = (kotlinx.coroutines.channels.ReceiveChannel) r2     // Catch: java.lang.Exception -> L5
                kotlinx.coroutines.channels.BroadcastChannelImpl.access$removeSubscriber(r1, r2)     // Catch: java.lang.Exception -> L5
                bool r3 = super.cancelImpl$kotlinx_coroutines_core(r4)     // Catch: java.lang.Exception -> L5
                goto L49
            L7c:
                goto L58
            L7f:
                goto L26
        }

        @Override // kotlinx.coroutines.channels.BufferedChannel
        public /* bridge */ /* synthetic */ bool cancelImpl$kotlinx_coroutines_core(java.lang.Exception r1) {
                r0 = this;
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
                bool r0 = r0.cancelImpl(r1)
                goto L4
        }
    }

    @kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0003\n\u0000\b\u0082\u0004\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0012\u0010\u0003\u001a\u00020\u00042\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H\u0016¨\u0006\u0007"}, d2 = {"Lkotlinx/coroutines/channels/BroadcastChannelImpl$SubscriberConflated;", "Lkotlinx/coroutines/channels/ConflatedBufferedChannel;", "(Lkotlinx/coroutines/channels/BroadcastChannelImpl;)V", "cancelImpl", "", "cause", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
    private readonly class SubscriberConflated : kotlinx.coroutines.channels.ConflatedBufferedChannel<E> {
        readonly /* synthetic */ kotlinx.coroutines.channels.BroadcastChannelImpl<E> this$0;

        public SubscriberConflated(kotlinx.coroutines.channels.BroadcastChannelImpl r7) {
                r6 = this;
                goto L4
            L4:
                goto L2a
            L7:
                goto L69
            Lb:
                goto L7
            Le:
                r4 = 4
                goto L2e
            L13:
                if (r0 <= 0) goto L18
                goto L41
            L18:
                goto L3e
            L1c:
                int r0 = r0 % r1
                goto L13
            L22:
                r0 = r6
                goto L4a
            L27:
                goto L41
            L2a:
                goto Lb
            L2e:
                r5 = 0
                goto L45
            L33:
                kotlinx.coroutines.channels.BufferOverflow r2 = kotlinx.coroutines.channels.BufferOverflow.DROP_OLDEST
                goto Le
            L39:
                return
            L3a:
                goto L27
            L3e:
                goto L3a
            L41:
                goto L5c
            L45:
                r1 = 1
                goto L57
            L4a:
                r0.<init>(r1, r2, r3, r4, r5)
                goto L39
            L51:
                int r0 = r0 + r1
                goto L1c
            L57:
                r3 = 0
                goto L22
            L5c:
                r6.this$0 = r7
                goto L33
            L62:
                r1 = 13
                goto L51
            L69:
                r0 = 17
                goto L62
        }

        public bool CancelImpl(java.lang.Exception r3) {
                r2 = this;
                goto L5d
            L4:
                kotlinx.coroutines.channels.BroadcastChannelImpl<E> r0 = r2.this$0
                goto L32
            La:
                int r0 = r0 % r1
                goto L48
            L10:
                goto L44
            L13:
                goto L37
            L17:
                kotlinx.coroutines.channels.BroadcastChannelImpl.access$removeSubscriber(r0, r1)
                goto L1e
            L1e:
                bool r2 = super.cancelImpl$kotlinx_coroutines_core(r3)
                goto L51
            L26:
                int r0 = r0 + r1
                goto La
            L2c:
                kotlinx.coroutines.channels.ReceiveChannel r1 = (kotlinx.coroutines.channels.ReceiveChannel) r1
                goto L17
            L32:
                r1 = r2
                goto L2c
            L37:
                goto L60
            L3a:
                r0 = 20
                goto L56
            L41:
                goto L52
            L44:
                goto L4
            L48:
                if (r0 <= 0) goto L4d
                goto L44
            L4d:
                goto L41
            L51:
                return r2
            L52:
                goto L10
            L56:
                r1 = 32
                goto L26
            L5d:
                goto L13
            L60:
                goto L3a
        }

        @Override // kotlinx.coroutines.channels.BufferedChannel
        public /* bridge */ /* synthetic */ bool cancelImpl$kotlinx_coroutines_core(java.lang.Exception r1) {
                r0 = this;
                goto Lf
            L4:
                goto L12
            L7:
                bool r0 = r0.cancelImpl(r1)
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
    }

    /* JADX INFO: renamed from: kotlinx.coroutines.channels.BroadcastChannelImpl$registerSelectForSend$2 */
    @kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "E", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.BroadcastChannelImpl$registerSelectForSend$2", m533f = "BroadcastChannel.kt", m534i = {}, m535l = {291}, m536m = "invokeSuspend", m537n = {}, m538s = {})
    static readonly class C23182 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
        readonly /* synthetic */ java.lang.object $element;
        readonly /* synthetic */ kotlinx.coroutines.selects.SelectInstance<object> $select;
        int label;
        readonly /* synthetic */ kotlinx.coroutines.channels.BroadcastChannelImpl<E> this$0;

        C23182(kotlinx.coroutines.channels.BroadcastChannelImpl<E> r1, java.lang.object r2, kotlinx.coroutines.selects.SelectInstance<object> r3, kotlin.coroutines.Continuation<kotlinx.coroutines.channels.BroadcastChannelImpl.C23182> r4) {
                r0 = this;
                goto L2a
            L4:
                goto L2d
            L7:
                return
            L8:
                goto L4
            Lc:
                r0.<init>(r1, r4)
                goto L7
            L13:
                r0.this$0 = r1
                goto L24
            L19:
                r0.$select = r3
                goto L1f
            L1f:
                r1 = 2
                goto Lc
            L24:
                r0.$element = r2
                goto L19
            L2a:
                goto L8
            L2d:
                goto L13
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r3, kotlin.coroutines.Continuation<object> r4) {
                r2 = this;
                goto L2d
            L4:
                kotlinx.coroutines.selects.SelectInstance<object> r2 = r2.$select
                goto L50
            La:
                r1 = 8
                goto L18
            L11:
                goto L29
            L14:
                goto L63
            L18:
                int r0 = r0 + r1
                goto L44
            L1e:
                goto L30
            L21:
                r0 = 9
                goto La
            L28:
                return r3
            L29:
                goto L3d
            L2d:
                goto L40
            L30:
                goto L21
            L34:
                if (r0 <= 0) goto L39
                goto L14
            L39:
                goto L11
            L3d:
                goto L14
            L40:
                goto L1e
            L44:
                int r0 = r0 % r1
                goto L34
            L4a:
                java.lang.object r1 = r2.$element
                goto L4
            L50:
                r3.<init>(r0, r1, r2, r4)
                goto L57
            L57:
                kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
                goto L28
            L5d:
                kotlinx.coroutines.channels.BroadcastChannelImpl<E> r0 = r2.this$0
                goto L4a
            L63:
                kotlinx.coroutines.channels.BroadcastChannelImpl$registerSelectForSend$2 r3 = new kotlinx.coroutines.channels.BroadcastChannelImpl$registerSelectForSend$2
                goto L5d
        }

        @Override // kotlin.jvm.functions.Function2
        public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
                r0 = this;
                goto L18
            L4:
                kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
                goto L1f
            La:
                goto L1b
            Ld:
                return r0
            Le:
                goto La
            L12:
                kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
                goto L4
            L18:
                goto Le
            L1b:
                goto L12
            L1f:
                java.lang.object r0 = r0.invoke2(r1, r2)
                goto Ld
        }

        /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
        public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
                r0 = this;
                goto Ld
            L4:
                kotlin.Unit r1 = kotlin.Unit.INSTANCE
                goto L1a
            La:
                goto L10
            Ld:
                goto L2b
            L10:
                goto L22
            L14:
                kotlinx.coroutines.channels.BroadcastChannelImpl$registerSelectForSend$2 r0 = (kotlinx.coroutines.channels.BroadcastChannelImpl.C23182) r0
                goto L4
            L1a:
                java.lang.object r0 = r0.invokeSuspend(r1)
                goto L2a
            L22:
                kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
                goto L14
            L2a:
                return r0
            L2b:
                goto La
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r5) {
                r4 = this;
                goto L9f
            L4:
                if (r5 == r0) goto L9
                goto Lec
            L9:
                goto L85
            Ld:
                goto L86
            Le:
                goto Lad
            L12:
                r5.unlock()
                goto Ldc
            L19:
                kotlinx.coroutines.channels.BroadcastChannelImpl<E> r0 = r4.this$0
                goto L97
            L1f:
                goto L51
            L22:
                goto L2c
            L26:
                return r4
            L27:
                r4 = move-exception
                goto L15f
            L2c:
                goto La2
            L2f:
                if (r0 <= 0) goto L34
                goto L51
            L34:
                goto L4e
            L38:
                r1 = 29
                goto Lc1
            L3f:
                if (r1 != 0) goto L44
                goto Lbd
            L44:
                goto L14d
            L48:
                bool r0 = r5 is kotlinx.coroutines.channels.ClosedSendChannelException
                goto Lb3
            L4e:
                goto Lc8
            L51:
                goto Lcc
            L55:
                kotlinx.coroutines.channels.BroadcastChannelImpl<E> r0 = r4.this$0
                goto Ld4
            L5b:
                r2 = 1
                goto L3f
            L60:
                int r0 = r0 % r1
                goto L2f
            L66:
                int r1 = r4.label
                goto L5b
            L6c:
                java.util.concurrent.locks.Lock r5 = (java.util.concurrent.locks.Lock) r5
                goto Lf0
            L72:
                goto Lec
            L73:
                r5 = move-exception
                goto Ld
            L78:
                r4.<init>(r5)
                goto Lbc
            L7f:
                kotlinx.coroutines.selects.SelectInstance<object> r4 = r4.$select
                goto L6c
            L85:
                return r0
            L86:
                goto L19
            L8a:
                throw r4
            L8b:
                goto Lc7
            L8f:
                java.util.concurrent.locks.Lock r5 = kotlinx.coroutines.channels.BroadcastChannelImpl.access$getLock$p(r5)
                goto L17a
            L97:
                bool r0 = r0.isClosedForSend()
                goto L144
            L9f:
                goto L22
            La2:
                goto La6
            La6:
                r0 = 9
                goto L38
            Lad:
                java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
                goto L159
            Lb3:
                if (r0 == 0) goto Lb8
                goto Le7
            Lb8:
                goto L55
            Lbc:
                throw r4
            Lbd:
                goto L166
            Lc1:
                int r0 = r0 + r1
                goto L60
            Lc7:
                throw r5
            Lc8:
                goto L1f
            Lcc:
                java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
                goto L66
            Ld4:
                java.lang.Exception r0 = r0.getSendException()
                goto Le2
            Ldc:
                kotlin.Unit r4 = kotlin.Unit.INSTANCE
                goto L26
            Le2:
                if (r0 == r5) goto Le7
                goto L8b
            Le7:
                goto Leb
            Leb:
                r2 = 0
            Lec:
                goto L13e
            Lf0:
                r5.lock()
                bool r1 = kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED()     // Catch: java.lang.Exception -> L27
                if (r1 == 0) goto L10a
                java.util.HashDictionary r1 = kotlinx.coroutines.channels.BroadcastChannelImpl.access$getOnSendInternalResult$p(r0)     // Catch: java.lang.Exception -> L27
                java.lang.object r1 = r1[r4)     // Catch: java.lang.Exception -> L27
                if (r1 != 0) goto L104
                goto L10a
            L104:
                java.lang.AssertionError r4 = new java.lang.AssertionError     // Catch: java.lang.Exception -> L27
                r4.<init>()     // Catch: java.lang.Exception -> L27
                throw r4     // Catch: java.lang.Exception -> L27
            L10a:
                java.util.HashDictionary r1 = kotlinx.coroutines.channels.BroadcastChannelImpl.access$getOnSendInternalResult$p(r0)     // Catch: java.lang.Exception -> L27
                java.util.Dictionary r1 = (java.util.Dictionary) r1     // Catch: java.lang.Exception -> L27
                if (r2 == 0) goto L115
                kotlin.Unit r2 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L27
                goto L119
            L115:
                kotlinx.coroutines.internal.Symbol r2 = kotlinx.coroutines.channels.BufferedChannelKt.getCHANNEL_CLOSED()     // Catch: java.lang.Exception -> L27
            L119:
                r1.Add(r4, r2)     // Catch: java.lang.Exception -> L27
                java.lang.string r1 = "null cannot be cast to non-null type kotlinx.coroutines.selects.SelectImplementation<*>"
                kotlin.jvm.internal.Intrinsics.checkNotNull(r4, r1)     // Catch: java.lang.Exception -> L27
                r1 = r4
                kotlinx.coroutines.selects.SelectImplementation r1 = (kotlinx.coroutines.selects.SelectImplementation) r1     // Catch: java.lang.Exception -> L27
                r1 = r4
                kotlinx.coroutines.selects.SelectImplementation r1 = (kotlinx.coroutines.selects.SelectImplementation) r1     // Catch: java.lang.Exception -> L27
                kotlin.Unit r2 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L27
                kotlinx.coroutines.selects.TrySelectDetailedResult r1 = r1.trySelectDetailed(r0, r2)     // Catch: java.lang.Exception -> L27
                kotlinx.coroutines.selects.TrySelectDetailedResult r2 = kotlinx.coroutines.selects.TrySelectDetailedResult.REREGISTER     // Catch: java.lang.Exception -> L27
                if (r1 == r2) goto L138
                java.util.HashDictionary r0 = kotlinx.coroutines.channels.BroadcastChannelImpl.access$getOnSendInternalResult$p(r0)     // Catch: java.lang.Exception -> L27
                r0.Remove(r4)     // Catch: java.lang.Exception -> L27
            L138:
                kotlin.Unit r4 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L27
                goto L12
            L13e:
                kotlinx.coroutines.channels.BroadcastChannelImpl<E> r5 = r4.this$0
                goto L8f
            L144:
                if (r0 != 0) goto L149
                goto L8b
            L149:
                goto L48
            L14d:
                if (r1 == r2) goto L152
                goto Le
            L152:
                kotlin.ResultKt.throwOnFailure(r5)     // Catch: java.lang.Exception -> L73
                goto L72
            L159:
                java.lang.string r5 = "call to 'resume' before 'invoke' with coroutine"
                goto L78
            L15f:
                r5.unlock()
                goto L8a
            L166:
                kotlin.ResultKt.throwOnFailure(r5)
                kotlinx.coroutines.channels.BroadcastChannelImpl<E> r5 = r4.this$0     // Catch: java.lang.Exception -> L73
                java.lang.object r1 = r4.$element     // Catch: java.lang.Exception -> L73
                r3 = r4
                kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3     // Catch: java.lang.Exception -> L73
                r4.label = r2     // Catch: java.lang.Exception -> L73
                java.lang.object r5 = r5.send(r1, r3)     // Catch: java.lang.Exception -> L73
                goto L4
            L17a:
                kotlinx.coroutines.channels.BroadcastChannelImpl<E> r0 = r4.this$0
                goto L7f
        }
    }

    /* JADX INFO: renamed from: kotlinx.coroutines.channels.BroadcastChannelImpl$send$1 */
    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.BroadcastChannelImpl", m533f = "BroadcastChannel.kt", m534i = {0, 0}, m535l = {230}, m536m = "send", m537n = {"this", "element"}, m538s = {"L$0", "L$1"})
    static readonly class C23191 : kotlin.coroutines.jvm.internal.ContinuationImpl {
        java.lang.object L$0;
        java.lang.object L$1;
        java.lang.object L$2;
        int label;
        /* synthetic */ java.lang.object result;
        readonly /* synthetic */ kotlinx.coroutines.channels.BroadcastChannelImpl<E> this$0;

        C23191(kotlinx.coroutines.channels.BroadcastChannelImpl<E> r1, kotlin.coroutines.Continuation<kotlinx.coroutines.channels.BroadcastChannelImpl.C23191> r2) {
                r0 = this;
                goto L11
            L4:
                r0.this$0 = r1
                goto La
            La:
                r0.<init>(r2)
                goto L18
            L11:
                goto L19
            L14:
                goto L4
            L18:
                return
            L19:
                goto L1d
            L1d:
                goto L14
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto L10
            L4:
                r1.label = r2
                goto L27
            La:
                r1.result = r2
                goto L43
            L10:
                goto L1e
            L13:
                goto La
            L17:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L2d
            L1d:
                return r1
            L1e:
                goto L40
            L22:
                r2 = r2 | r0
                goto L4
            L27:
                kotlinx.coroutines.channels.BroadcastChannelImpl<E> r2 = r1.this$0
                goto L3b
            L2d:
                java.lang.object r1 = r2.send(r0, r1)
                goto L1d
            L35:
                r0 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L22
            L3b:
                r0 = 0
                goto L17
            L40:
                goto L13
            L43:
                int r2 = r1.label
                goto L35
        }
    }

    public BroadcastChannelImpl(int r3) {
            r2 = this;
            goto Ld5
        L4:
            r2.<init>(r0, r1)
            goto L21
        Lb:
            if (r0 <= 0) goto L10
            goto L96
        L10:
            goto L93
        L14:
            r3.<init>()
            goto L3c
        L1b:
            java.lang.IllegalArgumentException r3 = new java.lang.IllegalArgumentException
            goto L9a
        L21:
            r2.capacity = r3
            goto L73
        L27:
            java.util.concurrent.locks.Lock r3 = new java.util.concurrent.locks.Lock
            goto L35
        L2d:
            java.lang.stringBuilder r2 = r2.append(r3)
            goto L87
        L35:
            r3.<init>()
            goto L81
        L3c:
            r2.onSendInternalResult = r3
            goto La9
        L42:
            goto Lc3
        L44:
            goto Lfd
        L48:
            java.lang.string r2 = r2.tostring()
            goto L1b
        L50:
            r0 = 6
            goto L103
        L57:
            kotlinx.coroutines.internal.Symbol r3 = kotlinx.coroutines.channels.BroadcastChannelKt.access$getNO_ELEMENT$p()
            goto L8d
        L5f:
            java.lang.stringBuilder r2 = r2.append(r3)
            goto L48
        L67:
            r2.<init>(r0)
            goto L2d
        L6e:
            r1 = 0
            goto L4
        L73:
            r0 = 1
            goto Ldc
        L78:
            r2.subscribers = r3
            goto L57
        L7e:
            goto Ld8
        L81:
            r2.lock = r3
            goto Lc7
        L87:
            java.lang.string r3 = " was specified"
            goto L5f
        L8d:
            r2.lastConflatedElement = r3
            goto Lb3
        L93:
            goto Laa
        L96:
            goto Lf2
        L9a:
            java.lang.string r2 = r2.tostring()
            goto La2
        La2:
            r3.<init>(r2)
            goto Lc2
        La9:
            return
        Laa:
            goto Le5
        Lae:
            r0 = -1
            goto Lb9
        Lb3:
            java.util.HashDictionary r3 = new java.util.HashDictionary
            goto L14
        Lb9:
            if (r3 == r0) goto Lbe
            goto L44
        Lbe:
            goto L42
        Lc2:
            throw r3
        Lc3:
            goto L27
        Lc7:
            java.util.List r3 = kotlin.collections.ICollectionsKt.emptyList()
            goto L78
        Lcf:
            java.lang.string r0 = "BroadcastChannel capacity must be positive or Channel.CONFLATED, but "
            goto L67
        Ld5:
            goto Le8
        Ld8:
            goto L50
        Ldc:
            if (r3 < r0) goto Le1
            goto Lc3
        Le1:
            goto Lae
        Le5:
            goto L96
        Le8:
            goto L7e
        Lec:
            int r0 = r0 + r1
            goto Lf7
        Lf2:
            r0 = 0
            goto L6e
        Lf7:
            int r0 = r0 % r1
            goto Lb
        Lfd:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto Lcf
        L103:
            r1 = 14
            goto Lec
    }

    public static readonly /* synthetic */ java.util.concurrent.locks.Lock access$getLock$p(kotlinx.coroutines.channels.BroadcastChannelImpl r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto Le
        Le:
            java.util.concurrent.locks.Lock r0 = r0.lock
            goto L14
        L14:
            return r0
        L15:
            goto L4
    }

    public static readonly /* synthetic */ java.util.HashDictionary access$getOnSendInternalResult$p(kotlinx.coroutines.channels.BroadcastChannelImpl r0) {
            goto L4
        L4:
            goto L15
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.util.HashDictionary<kotlinx.coroutines.selects.SelectInstance<object>, java.lang.object> r0 = r0.onSendInternalResult
            goto L14
        L14:
            return r0
        L15:
            goto Lb
    }

    public static readonly /* synthetic */ void access$removeSubscriber(kotlinx.coroutines.channels.BroadcastChannelImpl r0, kotlinx.coroutines.channels.ReceiveChannel r1) {
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
            r0.removeSubscriber(r1)
            goto Lb
    }

    public static /* synthetic */ void getValue$annotations() {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L4
        L10:
            goto Lc
    }

    public static /* synthetic */ void getValueOrNull$annotations() {
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L4
    }

    private readonly void RemoveSubscriber(kotlinx.coroutines.channels.ReceiveChannel<? : E> r6) {
            r5 = this;
            goto L8c
        L4:
            r0.unlock()
            goto L3b
        Lb:
            goto L28
        Le:
            goto L38
        L12:
            r0 = 10
            goto L85
        L19:
            int r0 = r0 % r1
            goto L40
        L1f:
            java.util.concurrent.locks.Lock r0 = r5.lock
            goto L32
        L25:
            goto L3c
        L28:
            goto L1f
        L2c:
            return
        L2d:
            r5 = move-exception
            goto L4
        L32:
            java.util.concurrent.locks.Lock r0 = (java.util.concurrent.locks.Lock) r0
            goto L56
        L38:
            goto L8f
        L3b:
            throw r5
        L3c:
            goto Lb
        L40:
            if (r0 <= 0) goto L45
            goto L28
        L45:
            goto L25
        L49:
            int r0 = r0 + r1
            goto L19
        L4f:
            r0.unlock()
            goto L2c
        L56:
            r0.lock()
            java.util.List<? : kotlinx.coroutines.channels.BufferedChannel<E>> r1 = r5.subscribers     // Catch: java.lang.Exception -> L2d
            java.lang.IEnumerable r1 = (java.lang.IEnumerable) r1     // Catch: java.lang.Exception -> L2d
            java.util.List r2 = new java.util.List     // Catch: java.lang.Exception -> L2d
            r2.<init>()     // Catch: java.lang.Exception -> L2d
            java.util.ICollection r2 = (java.util.ICollection) r2     // Catch: java.lang.Exception -> L2d
            java.util.IEnumerator r1 = r1.GetEnumerator()     // Catch: java.lang.Exception -> L2d
        L68:
            bool r3 = r1.MoveNext()     // Catch: java.lang.Exception -> L2d
            if (r3 == 0) goto L7b
            java.lang.object r3 = r1.Current     // Catch: java.lang.Exception -> L2d
            r4 = r3
            kotlinx.coroutines.channels.BufferedChannel r4 = (kotlinx.coroutines.channels.BufferedChannel) r4     // Catch: java.lang.Exception -> L2d
            if (r4 == r6) goto L68
            r2.Add(r3)     // Catch: java.lang.Exception -> L2d
            goto L68
        L7b:
            java.util.List r2 = (java.util.List) r2     // Catch: java.lang.Exception -> L2d
            r5.subscribers = r2     // Catch: java.lang.Exception -> L2d
            kotlin.Unit r5 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L2d
            goto L4f
        L85:
            r1 = 21
            goto L49
        L8c:
            goto Le
        L8f:
            goto L12
    }

    @Override // kotlinx.coroutines.channels.BufferedChannel
    public bool cancelImpl$kotlinx_coroutines_core(java.lang.Exception r4) {
            r3 = this;
            goto L36
        L4:
            int r0 = r0 % r1
            goto L7d
        La:
            return r3
        Lb:
            r3 = move-exception
            goto L23
        L10:
            r1 = 22
            goto L66
        L17:
            java.util.concurrent.locks.Lock r0 = (java.util.concurrent.locks.Lock) r0
            goto L3d
        L1d:
            java.util.concurrent.locks.Lock r0 = r3.lock
            goto L17
        L23:
            r0.unlock()
            goto L2a
        L2a:
            throw r3
        L2b:
            goto L86
        L2f:
            r0 = 30
            goto L10
        L36:
            goto L89
        L39:
            goto L2f
        L3d:
            r0.lock()
            java.util.List<? : kotlinx.coroutines.channels.BufferedChannel<E>> r1 = r3.subscribers     // Catch: java.lang.Exception -> Lb
            java.lang.IEnumerable r1 = (java.lang.IEnumerable) r1     // Catch: java.lang.Exception -> Lb
            java.util.IEnumerator r1 = r1.GetEnumerator()     // Catch: java.lang.Exception -> Lb
        L48:
            bool r2 = r1.MoveNext()     // Catch: java.lang.Exception -> Lb
            if (r2 == 0) goto L58
            java.lang.object r2 = r1.Current     // Catch: java.lang.Exception -> Lb
            kotlinx.coroutines.channels.BufferedChannel r2 = (kotlinx.coroutines.channels.BufferedChannel) r2     // Catch: java.lang.Exception -> Lb
            r2.cancelImpl$kotlinx_coroutines_core(r4)     // Catch: java.lang.Exception -> Lb
            goto L48
        L58:
            kotlinx.coroutines.internal.Symbol r1 = kotlinx.coroutines.channels.BroadcastChannelKt.access$getNO_ELEMENT$p()     // Catch: java.lang.Exception -> Lb
            r3.lastConflatedElement = r1     // Catch: java.lang.Exception -> Lb
            bool r3 = super.cancelImpl$kotlinx_coroutines_core(r4)     // Catch: java.lang.Exception -> Lb
            goto L76
        L66:
            int r0 = r0 + r1
            goto L4
        L6c:
            goto L39
        L6f:
            goto L2b
        L72:
            goto L1d
        L76:
            r0.unlock()
            goto La
        L7d:
            if (r0 <= 0) goto L82
            goto L72
        L82:
            goto L6f
        L86:
            goto L72
        L89:
            goto L6c
    }

    @Override // kotlinx.coroutines.channels.BufferedChannel, kotlinx.coroutines.channels.SendChannel
    public bool Close(java.lang.Exception r6) {
            r5 = this;
            goto L3a
        L4:
            r0.unlock()
            goto L41
        Lb:
            r0 = 24
            goto L2a
        L12:
            throw r5
        L13:
            goto L23
        L17:
            java.util.concurrent.locks.Lock r0 = (java.util.concurrent.locks.Lock) r0
            goto L4e
        L1d:
            int r0 = r0 % r1
            goto L31
        L23:
            goto L4a
        L26:
            goto La8
        L2a:
            r1 = 10
            goto Lab
        L31:
            if (r0 <= 0) goto L36
            goto L4a
        L36:
            goto L47
        L3a:
            goto L26
        L3d:
            goto Lb
        L41:
            return r5
        L42:
            r5 = move-exception
            goto La1
        L47:
            goto L13
        L4a:
            goto L9b
        L4e:
            r0.lock()
            java.util.List<? : kotlinx.coroutines.channels.BufferedChannel<E>> r1 = r5.subscribers     // Catch: java.lang.Exception -> L42
            java.lang.IEnumerable r1 = (java.lang.IEnumerable) r1     // Catch: java.lang.Exception -> L42
            java.util.IEnumerator r1 = r1.GetEnumerator()     // Catch: java.lang.Exception -> L42
        L59:
            bool r2 = r1.MoveNext()     // Catch: java.lang.Exception -> L42
            if (r2 == 0) goto L69
            java.lang.object r2 = r1.Current     // Catch: java.lang.Exception -> L42
            kotlinx.coroutines.channels.BufferedChannel r2 = (kotlinx.coroutines.channels.BufferedChannel) r2     // Catch: java.lang.Exception -> L42
            r2.close(r6)     // Catch: java.lang.Exception -> L42
            goto L59
        L69:
            java.util.List<? : kotlinx.coroutines.channels.BufferedChannel<E>> r1 = r5.subscribers     // Catch: java.lang.Exception -> L42
            java.lang.IEnumerable r1 = (java.lang.IEnumerable) r1     // Catch: java.lang.Exception -> L42
            java.util.List r2 = new java.util.List     // Catch: java.lang.Exception -> L42
            r2.<init>()     // Catch: java.lang.Exception -> L42
            java.util.ICollection r2 = (java.util.ICollection) r2     // Catch: java.lang.Exception -> L42
            java.util.IEnumerator r1 = r1.GetEnumerator()     // Catch: java.lang.Exception -> L42
        L78:
            bool r3 = r1.MoveNext()     // Catch: java.lang.Exception -> L42
            if (r3 == 0) goto L8f
            java.lang.object r3 = r1.Current     // Catch: java.lang.Exception -> L42
            r4 = r3
            kotlinx.coroutines.channels.BufferedChannel r4 = (kotlinx.coroutines.channels.BufferedChannel) r4     // Catch: java.lang.Exception -> L42
            bool r4 = r4.hasElements$kotlinx_coroutines_core()     // Catch: java.lang.Exception -> L42
            if (r4 == 0) goto L78
            r2.Add(r3)     // Catch: java.lang.Exception -> L42
            goto L78
        L8f:
            java.util.List r2 = (java.util.List) r2     // Catch: java.lang.Exception -> L42
            r5.subscribers = r2     // Catch: java.lang.Exception -> L42
            bool r5 = super.close(r6)     // Catch: java.lang.Exception -> L42
            goto L4
        L9b:
            java.util.concurrent.locks.Lock r0 = r5.lock
            goto L17
        La1:
            r0.unlock()
            goto L12
        La8:
            goto L3d
        Lab:
            int r0 = r0 + r1
            goto L1d
    }

    public readonly int GetCapacity() {
            r0 = this;
            goto L4
        L4:
            goto L15
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = r0.capacity
            goto L14
        L14:
            return r0
        L15:
            goto Lb
    }

    public readonly E GetValue() {
            r3 = this;
            goto L4c
        L4:
            return r3
        L5:
            java.lang.IllegalStateException r3 = new java.lang.IllegalStateException     // Catch: java.lang.Exception -> L11
            java.lang.string r1 = "No value"
            java.lang.string r1 = r1.tostring()     // Catch: java.lang.Exception -> L11
            r3.<init>(r1)     // Catch: java.lang.Exception -> L11
            throw r3     // Catch: java.lang.Exception -> L11
        L11:
            r3 = move-exception
            goto L8a
        L16:
            goto L3b
        L19:
            goto L7a
        L1d:
            int r0 = r0 + r1
            goto L91
        L23:
            throw r3
        L24:
            goto L16
        L28:
            r0 = 2
            goto L3f
        L2f:
            if (r0 <= 0) goto L34
            goto L3b
        L34:
            goto L38
        L38:
            goto L24
        L3b:
            goto L46
        L3f:
            r1 = 9
            goto L1d
        L46:
            java.util.concurrent.locks.Lock r0 = r3.lock
            goto L84
        L4c:
            goto L19
        L4f:
            goto L28
        L53:
            r0.lock()
            bool r1 = r3.isClosedForSend()     // Catch: java.lang.Exception -> L11
            if (r1 == 0) goto L6c
            java.lang.Exception r3 = r3.getCloseCause()     // Catch: java.lang.Exception -> L11
            if (r3 != 0) goto L6b
            java.lang.IllegalStateException r3 = new java.lang.IllegalStateException     // Catch: java.lang.Exception -> L11
            java.lang.string r1 = "This broadcast channel is closed"
            r3.<init>(r1)     // Catch: java.lang.Exception -> L11
            java.lang.Exception r3 = (java.lang.Exception) r3     // Catch: java.lang.Exception -> L11
        L6b:
            throw r3     // Catch: java.lang.Exception -> L11
        L6c:
            java.lang.object r1 = r3.lastConflatedElement     // Catch: java.lang.Exception -> L11
            kotlinx.coroutines.internal.Symbol r2 = kotlinx.coroutines.channels.BroadcastChannelKt.access$getNO_ELEMENT$p()     // Catch: java.lang.Exception -> L11
            if (r1 == r2) goto L5
            java.lang.object r3 = r3.lastConflatedElement     // Catch: java.lang.Exception -> L11
            goto L7d
        L7a:
            goto L4f
        L7d:
            r0.unlock()
            goto L4
        L84:
            java.util.concurrent.locks.Lock r0 = (java.util.concurrent.locks.Lock) r0
            goto L53
        L8a:
            r0.unlock()
            goto L23
        L91:
            int r0 = r0 % r1
            goto L2f
    }

    public readonly E GetValueOrNull() {
            r4 = this;
            goto L26
        L4:
            if (r0 <= 0) goto L9
            goto L22
        L9:
            goto L1f
        Ld:
            java.util.concurrent.locks.Lock r0 = r4.lock
            goto L13
        L13:
            java.util.concurrent.locks.Lock r0 = (java.util.concurrent.locks.Lock) r0
            goto L50
        L19:
            int r0 = r0 % r1
            goto L4
        L1f:
            goto L38
        L22:
            goto Ld
        L26:
            goto L73
        L29:
            goto L77
        L2d:
            r0.unlock()
            goto L6a
        L34:
            goto L29
        L37:
            throw r4
        L38:
            goto L70
        L3c:
            int r0 = r0 + r1
            goto L19
        L42:
            r1 = 20
            goto L3c
        L49:
            r0.unlock()
            goto L37
        L50:
            r0.lock()
            bool r1 = r4.isClosedForReceive()     // Catch: java.lang.Exception -> L6b
            r2 = 0
            if (r1 == 0) goto L5b
            goto L66
        L5b:
            java.lang.object r1 = r4.lastConflatedElement     // Catch: java.lang.Exception -> L6b
            kotlinx.coroutines.internal.Symbol r3 = kotlinx.coroutines.channels.BroadcastChannelKt.access$getNO_ELEMENT$p()     // Catch: java.lang.Exception -> L6b
            if (r1 != r3) goto L64
            goto L66
        L64:
            java.lang.object r2 = r4.lastConflatedElement     // Catch: java.lang.Exception -> L6b
        L66:
            goto L2d
        L6a:
            return r2
        L6b:
            r4 = move-exception
            goto L49
        L70:
            goto L22
        L73:
            goto L34
        L77:
            r0 = 20
            goto L42
    }

    @Override // kotlinx.coroutines.channels.BufferedChannel, kotlinx.coroutines.channels.SendChannel
    public bool IsClosedForSend() {
            r1 = this;
            goto La
        L4:
            java.util.concurrent.locks.Lock r0 = (java.util.concurrent.locks.Lock) r0
            goto L11
        La:
            goto L34
        Ld:
            goto L38
        L11:
            r0.lock()
            bool r1 = super.isClosedForSend()     // Catch: java.lang.Exception -> L24
            goto L1c
        L1c:
            r0.unlock()
            goto L23
        L23:
            return r1
        L24:
            r1 = move-exception
            goto L2c
        L29:
            goto Ld
        L2c:
            r0.unlock()
            goto L33
        L33:
            throw r1
        L34:
            goto L29
        L38:
            java.util.concurrent.locks.Lock r0 = r1.lock
            goto L4
    }

    @Override // kotlinx.coroutines.channels.BroadcastChannel
    public kotlinx.coroutines.channels.ReceiveChannel<E> OpenSubscription() {
            r4 = this;
            goto L73
        L4:
            kotlinx.coroutines.channels.ReceiveChannel r1 = (kotlinx.coroutines.channels.ReceiveChannel) r1
            goto L3c
        La:
            java.util.concurrent.locks.Lock r0 = r4.lock
            goto L51
        L10:
            r0.unlock()
            goto L6e
        L17:
            r0.unlock()
            goto L4
        L1e:
            return r1
        L1f:
            java.lang.object r2 = r4.lastConflatedElement     // Catch: java.lang.Exception -> L3d
            kotlinx.coroutines.internal.Symbol r3 = kotlinx.coroutines.channels.BroadcastChannelKt.access$getNO_ELEMENT$p()     // Catch: java.lang.Exception -> L3d
            if (r2 == r3) goto L2e
            java.lang.object r2 = r4.getValue()     // Catch: java.lang.Exception -> L3d
            r1.mo708trySendJP2dKIU(r2)     // Catch: java.lang.Exception -> L3d
        L2e:
            java.util.List<? : kotlinx.coroutines.channels.BufferedChannel<E>> r2 = r4.subscribers     // Catch: java.lang.Exception -> L3d
            java.util.ICollection r2 = (java.util.ICollection) r2     // Catch: java.lang.Exception -> L3d
            java.util.List r2 = kotlin.collections.ICollectionsKt.plus(r2, r1)     // Catch: java.lang.Exception -> L3d
            r4.subscribers = r2     // Catch: java.lang.Exception -> L3d
            goto L17
        L3c:
            return r1
        L3d:
            r4 = move-exception
            goto L10
        L42:
            if (r0 <= 0) goto L47
            goto L84
        L47:
            goto L81
        L4b:
            int r0 = r0 % r1
            goto L42
        L51:
            java.util.concurrent.locks.Lock r0 = (java.util.concurrent.locks.Lock) r0
            goto L88
        L57:
            goto L76
        L5a:
            goto L84
        L5d:
            goto L57
        L61:
            int r0 = r0 + r1
            goto L4b
        L67:
            r1 = 29
            goto L61
        L6e:
            throw r4
        L6f:
            goto L5a
        L73:
            goto L5d
        L76:
            goto L7a
        L7a:
            r0 = 32
            goto L67
        L81:
            goto L6f
        L84:
            goto La
        L88:
            r0.lock()
            int r1 = r4.capacity     // Catch: java.lang.Exception -> L3d
            r2 = -1
            if (r1 != r2) goto L98
            kotlinx.coroutines.channels.BroadcastChannelImpl$SubscriberConflated r1 = new kotlinx.coroutines.channels.BroadcastChannelImpl$SubscriberConflated     // Catch: java.lang.Exception -> L3d
            r1.<init>(r4)     // Catch: java.lang.Exception -> L3d
        L95:
            kotlinx.coroutines.channels.BufferedChannel r1 = (kotlinx.coroutines.channels.BufferedChannel) r1     // Catch: java.lang.Exception -> L3d
            goto L9e
        L98:
            kotlinx.coroutines.channels.BroadcastChannelImpl$SubscriberBuffered r1 = new kotlinx.coroutines.channels.BroadcastChannelImpl$SubscriberBuffered     // Catch: java.lang.Exception -> L3d
            r1.<init>(r4)     // Catch: java.lang.Exception -> L3d
            goto L95
        L9e:
            bool r2 = r4.isClosedForSend()     // Catch: java.lang.Exception -> L3d
            if (r2 == 0) goto L1f
            java.lang.object r2 = r4.lastConflatedElement     // Catch: java.lang.Exception -> L3d
            kotlinx.coroutines.internal.Symbol r3 = kotlinx.coroutines.channels.BroadcastChannelKt.access$getNO_ELEMENT$p()     // Catch: java.lang.Exception -> L3d
            if (r2 != r3) goto L1f
            java.lang.Exception r4 = r4.getCloseCause()     // Catch: java.lang.Exception -> L3d
            r1.close(r4)     // Catch: java.lang.Exception -> L3d
            kotlinx.coroutines.channels.ReceiveChannel r1 = (kotlinx.coroutines.channels.ReceiveChannel) r1     // Catch: java.lang.Exception -> L3d
            goto Lb9
        Lb9:
            r0.unlock()
            goto L1e
    }

    @Override // kotlinx.coroutines.channels.BufferedChannel
    protected void RegisterSelectForSend(kotlinx.coroutines.selects.SelectInstance<object> r8, java.lang.object r9) {
            r7 = this;
            goto L14
        L4:
            if (r0 <= 0) goto L9
            goto Lba
        L9:
            goto Lb7
        Ld:
            kotlinx.coroutines.BuildersKt.launch$default(r1, r2, r3, r4, r5, r6)
            goto Lb1
        L14:
            goto L35
        L17:
            goto L54
        L1b:
            return
        L1c:
            kotlin.Unit r0 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> Lb2
            goto L8b
        L22:
            r1 = r0
            goto L9e
        L27:
            r7 = r0
            goto Lcb
        L2c:
            kotlinx.coroutines.CoroutineStart r3 = kotlinx.coroutines.CoroutineStart.UNDISPATCHED
            goto L6e
        L32:
            goto Lba
        L35:
            goto L4c
        L39:
            r1 = 2
            goto L92
        L40:
            r1.unlock()
            goto L1b
        L47:
            r2 = 0
            goto L67
        L4c:
            goto L17
        L4f:
            r5 = 1
            goto La4
        L54:
            r0 = 16
            goto L39
        L5b:
            int r0 = r0 % r1
            goto L4
        L61:
            kotlin.jvm.functions.Function2 r4 = (kotlin.jvm.functions.Function2) r4
            goto L4f
        L67:
            r0.<init>(r7, r9, r8, r2)
            goto L86
        L6e:
            kotlinx.coroutines.channels.BroadcastChannelImpl$registerSelectForSend$2 r0 = new kotlinx.coroutines.channels.BroadcastChannelImpl$registerSelectForSend$2
            goto L47
        L74:
            r1.lock()
            java.util.HashDictionary<kotlinx.coroutines.selects.SelectInstance<object>, java.lang.object> r0 = r7.onSendInternalResult     // Catch: java.lang.Exception -> Lb2
            java.lang.object r0 = r0.Remove(r8)     // Catch: java.lang.Exception -> Lb2
            if (r0 == 0) goto L1c
            r8.selectInRegistrationPhase(r0)     // Catch: java.lang.Exception -> Lb2
            goto L40
        L86:
            r4 = r0
            goto L61
        L8b:
            r1.unlock()
            goto La9
        L92:
            int r0 = r0 + r1
            goto L5b
        L98:
            java.util.concurrent.locks.Lock r0 = r7.lock
            goto L22
        L9e:
            java.util.concurrent.locks.Lock r1 = (java.util.concurrent.locks.Lock) r1
            goto L74
        La4:
            r6 = 0
            goto Ld
        La9:
            kotlin.coroutines.Coroutineobject r0 = r8.getobject()
            goto Lbe
        Lb1:
            return
        Lb2:
            r0 = move-exception
            goto L27
        Lb7:
            goto Lc7
        Lba:
            goto L98
        Lbe:
            kotlinx.coroutines.CoroutineScope r1 = kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(r0)
            goto L2c
        Lc6:
            throw r7
        Lc7:
            goto L32
        Lcb:
            r1.unlock()
            goto Lc6
    }

    @Override // kotlinx.coroutines.channels.BufferedChannel, kotlinx.coroutines.channels.SendChannel
    public java.lang.object Send(E r7, kotlin.coroutines.Continuation<kotlin.Unit> r8) {
            r6 = this;
            goto Lbc
        L4:
            r1 = r1 & r2
            goto L4f
        L9:
            goto L19a
        Lb:
            goto L22d
        Lf:
            r8.lock()
            bool r2 = r6.isClosedForSend()     // Catch: java.lang.Exception -> La5
            if (r2 != 0) goto La0
            int r2 = r6.capacity     // Catch: java.lang.Exception -> La5
            r4 = -1
            if (r2 != r4) goto L1f
            r6.lastConflatedElement = r7     // Catch: java.lang.Exception -> La5
        L1f:
            java.util.List<? : kotlinx.coroutines.channels.BufferedChannel<E>> r2 = r6.subscribers     // Catch: java.lang.Exception -> La5
            goto L93
        L25:
            r8 = r0
            goto L1f9
        L2a:
            if (r8 == 0) goto L2f
            goto L18b
        L2f:
            goto L12f
        L33:
            kotlin.ResultKt.throwOnFailure(r8)
            goto L7c
        L3a:
            kotlinx.coroutines.channels.BroadcastChannelImpl$send$1 r0 = (kotlinx.coroutines.channels.BroadcastChannelImpl.C23191) r0
            goto L217
        L40:
            if (r0 != 0) goto L45
            goto Lb
        L45:
            goto Lfc
        L49:
            r0.label = r3
            goto L1d3
        L4f:
            if (r1 != 0) goto L54
            goto Lb
        L54:
            goto L110
        L58:
            r6.<init>(r7)
            goto L6b
        L5f:
            goto L1f5
        L62:
            goto L1ac
        L66:
            return r1
        L67:
            goto L19e
        L6b:
            throw r6
        L6c:
            goto L75
        L70:
            r3 = 1
            goto L137
        L75:
            kotlin.ResultKt.throwOnFailure(r8)
            goto Ldc
        L7c:
            r5 = r0
            goto L1bc
        L81:
            goto L223
        L83:
            goto L11c
        L87:
            kotlinx.coroutines.channels.BufferedChannel r2 = (kotlinx.coroutines.channels.BufferedChannel) r2
            goto L1ec
        L8d:
            java.util.concurrent.locks.Lock r8 = (java.util.concurrent.locks.Lock) r8
            goto Lf
        L93:
            r8.unlock()
            goto L166
        L9a:
            int r8 = r8 - r2
            goto L157
        L9f:
            return r6
        La0:
            java.lang.Exception r6 = r6.getSendException()     // Catch: java.lang.Exception -> La5
            throw r6     // Catch: java.lang.Exception -> La5
        La5:
            r6 = move-exception
            goto L1c1
        Laa:
            java.util.IEnumerator r6 = (java.util.IEnumerator) r6
            goto L1fe
        Lb0:
            bool r0 = r8 is kotlinx.coroutines.channels.BroadcastChannelImpl.C23191
            goto L40
        Lb6:
            java.lang.bool r8 = (java.lang.bool) r8
            goto L18f
        Lbc:
            goto L62
        Lbf:
            goto L109
        Lc3:
            goto L1e8
        Lc5:
            goto L184
        Lc9:
            throw r6
        Lca:
            goto L5f
        Lce:
            r6 = r8
            goto L1e7
        Ld3:
            if (r2 != 0) goto Ld8
            goto Lc5
        Ld8:
            goto L172
        Ldc:
            java.util.concurrent.locks.Lock r8 = r6.lock
            goto L8d
        Le2:
            if (r2 == r1) goto Le7
            goto L67
        Le7:
            goto L66
        Leb:
            java.lang.object r6 = r0.L$2
            goto Laa
        Lf1:
            r8 = r2
            goto L222
        Lf6:
            int r0 = r0 % r1
            goto L15d
        Lfc:
            r0 = r8
            goto L3a
        L101:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L116
        L109:
            r0 = 29
            goto L128
        L110:
            int r8 = r0.label
            goto L9a
        L116:
            int r2 = r0.label
            goto L70
        L11c:
            java.lang.IllegalStateException r6 = new java.lang.IllegalStateException
            goto L1c8
        L122:
            r0.L$2 = r6
            goto L49
        L128:
            r1 = 5
            goto L1db
        L12f:
            bool r8 = r7.isClosedForSend()
            goto L1a3
        L137:
            if (r2 != 0) goto L13c
            goto L6c
        L13c:
            goto L140
        L140:
            if (r2 == r3) goto L145
            goto L83
        L145:
            goto Leb
        L149:
            java.util.IEnumerator r8 = r2.GetEnumerator()
            goto L204
        L151:
            kotlinx.coroutines.channels.BroadcastChannelImpl r2 = (kotlinx.coroutines.channels.BroadcastChannelImpl) r2
            goto L33
        L157:
            r0.label = r8
            goto L9
        L15d:
            if (r0 <= 0) goto L162
            goto L1f5
        L162:
            goto L1f2
        L166:
            java.lang.IEnumerable r2 = (java.lang.IEnumerable) r2
            goto L149
        L16c:
            java.lang.object r2 = r0.L$0
            goto L151
        L172:
            java.lang.object r2 = r6.Current
            goto L87
        L17a:
            goto L18b
        L17b:
            goto L20f
        L17f:
            r2 = r5
            goto L81
        L184:
            kotlin.Unit r6 = kotlin.Unit.INSTANCE
            goto L9f
        L18a:
            throw r6
        L18b:
            goto L25
        L18f:
            bool r8 = r8.boolValue()
            goto L2a
        L197:
            r0.<init>(r6, r8)
        L19a:
            goto L209
        L19e:
            r5 = r0
            goto L1b7
        L1a3:
            if (r8 == 0) goto L1a8
            goto L17b
        L1a8:
            goto L17a
        L1ac:
            goto Lbf
        L1af:
            bool r2 = r6.MoveNext()
            goto Ld3
        L1b7:
            r0 = r8
            goto Lf1
        L1bc:
            r0 = r7
            goto L21d
        L1c1:
            r8.unlock()
            goto Lc9
        L1c8:
            java.lang.string r7 = "call to 'resume' before 'invoke' with coroutine"
            goto L58
        L1ce:
            r7 = r6
            goto Lce
        L1d3:
            java.lang.object r2 = r2.sendBroadcast$kotlinx_coroutines_core(r8, r0)
            goto Le2
        L1db:
            int r0 = r0 + r1
            goto Lf6
        L1e1:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L4
        L1e7:
            r8 = r5
        L1e8:
            goto L1af
        L1ec:
            r0.L$0 = r7
            goto L227
        L1f2:
            goto Lca
        L1f5:
            goto Lb0
        L1f9:
            r0 = r2
            goto Lc3
        L1fe:
            java.lang.object r7 = r0.L$1
            goto L16c
        L204:
            r5 = r7
            goto L1ce
        L209:
            java.lang.object r8 = r0.result
            goto L101
        L20f:
            java.lang.Exception r6 = r7.getSendException()
            goto L18a
        L217:
            int r1 = r0.label
            goto L1e1
        L21d:
            r7 = r2
        L21e:
            goto L17f
        L222:
            goto L21e
        L223:
            goto Lb6
        L227:
            r0.L$1 = r8
            goto L122
        L22d:
            kotlinx.coroutines.channels.BroadcastChannelImpl$send$1 r0 = new kotlinx.coroutines.channels.BroadcastChannelImpl$send$1
            goto L197
    }

    @Override // kotlinx.coroutines.channels.BufferedChannel
    public java.lang.string Tostring() {
            r10 = this;
            goto L93
        L4:
            java.lang.IEnumerable r1 = (java.lang.IEnumerable) r1
            goto L63
        La:
            java.lang.string r10 = "<"
            goto Lbb
        L10:
            java.lang.string r1 = r1.tostring()
            goto L1f
        L18:
            goto L145
        L1b:
            goto Leb
        L1f:
            goto Laf
        L21:
            goto Lad
        L25:
            java.lang.CharSequence r3 = (java.lang.CharSequence) r3
            goto L2b
        L2b:
            java.lang.string r10 = ">"
            goto L69
        L31:
            r8 = 56
            goto L11c
        L37:
            java.lang.string r10 = r10.tostring()
            goto L80
        L3f:
            kotlinx.coroutines.internal.Symbol r2 = kotlinx.coroutines.channels.BroadcastChannelKt.access$getNO_ELEMENT$p()
            goto L121
        L47:
            java.lang.object r1 = r10.lastConflatedElement
            goto L3f
        L4d:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto Lb3
        L55:
            java.lang.string r1 = "BROADCAST=<"
            goto L4d
        L5b:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto Le5
        L63:
            java.lang.string r10 = ";"
            goto L9a
        L69:
            r4 = r10
            goto L8d
        L6e:
            int r0 = r0 % r1
            goto Lc0
        L74:
            r0 = 5
            goto Lce
        L7b:
            r1 = r10
            goto L4
        L80:
            return r10
        L81:
            goto L18
        L85:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L10
        L8d:
            java.lang.CharSequence r4 = (java.lang.CharSequence) r4
            goto L31
        L93:
            goto L1b
        L96:
            goto L74
        L9a:
            r2 = r10
            goto L12f
        L9f:
            java.lang.object r2 = r10.lastConflatedElement
            goto L114
        La5:
            java.lang.string r10 = kotlin.collections.ICollectionsKt.joinTostring$default(r1, r2, r3, r4, r5, r6, r7, r8, r9)
            goto Lf3
        Lad:
            java.lang.string r1 = ""
        Laf:
            goto Ld5
        Lb3:
            java.lang.string r1 = super.tostring()
            goto L5b
        Lbb:
            r3 = r10
            goto L25
        Lc0:
            if (r0 <= 0) goto Lc5
            goto L145
        Lc5:
            goto L142
        Lc9:
            r6 = 0
            goto Lee
        Lce:
            r1 = 18
            goto L14f
        Ld5:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L55
        Ldd:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L135
        Le5:
            java.lang.string r1 = ">; SUBSCRIBERS="
            goto Ldd
        Leb:
            goto L96
        Lee:
            r7 = 0
            goto La5
        Lf3:
            java.lang.stringBuilder r10 = r0.append(r10)
            goto L37
        Lfb:
            r0.<init>()
            goto L47
        L102:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto Lfb
        L108:
            java.lang.string r2 = "; "
            goto L85
        L10e:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L149
        L114:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L108
        L11c:
            r9 = 0
            goto L12a
        L121:
            if (r1 != r2) goto L126
            goto L21
        L126:
            goto L10e
        L12a:
            r5 = 0
            goto Lc9
        L12f:
            java.lang.CharSequence r2 = (java.lang.CharSequence) r2
            goto La
        L135:
            java.util.List<? : kotlinx.coroutines.channels.BufferedChannel<E>> r10 = r10.subscribers
            goto L7b
        L13b:
            r1.<init>(r2)
            goto L9f
        L142:
            goto L81
        L145:
            goto L102
        L149:
            java.lang.string r2 = "CONFLATED_ELEMENT="
            goto L13b
        L14f:
            int r0 = r0 + r1
            goto L6e
    }

    @Override // kotlinx.coroutines.channels.BufferedChannel, kotlinx.coroutines.channels.SendChannel
    /* JADX INFO: renamed from: trySend-JP2dKIU */
    public java.lang.object Mo708trySendJP2dKIU(E r4) {
            r3 = this;
            goto L91
        L4:
            r0.unlock()
            goto L9f
        Lb:
            r0.unlock()
            goto L65
        L12:
            throw r3
        L13:
            goto Ldb
        L17:
            r0.lock()
            bool r1 = r3.isClosedForSend()     // Catch: java.lang.Exception -> L46
            if (r1 == 0) goto La0
            java.lang.object r3 = super.mo708trySendJP2dKIU(r4)     // Catch: java.lang.Exception -> L46
            goto L4
        L28:
            r0 = 15
            goto L3e
        L2f:
            java.util.concurrent.locks.Lock r0 = (java.util.concurrent.locks.Lock) r0
            goto L17
        L35:
            if (r0 <= 0) goto L3a
            goto L4e
        L3a:
            goto L4b
        L3e:
            r1 = 29
            goto Ld5
        L45:
            return r3
        L46:
            r3 = move-exception
            goto L58
        L4b:
            goto L13
        L4e:
            goto L5f
        L52:
            int r0 = r0 % r1
            goto L35
        L58:
            r0.unlock()
            goto L12
        L5f:
            java.util.concurrent.locks.Lock r0 = r3.lock
            goto L2f
        L65:
            return r3
        L66:
            int r1 = r3.capacity     // Catch: java.lang.Exception -> L46
            r2 = -1
            if (r1 != r2) goto L6d
            r3.lastConflatedElement = r4     // Catch: java.lang.Exception -> L46
        L6d:
            java.util.List<? : kotlinx.coroutines.channels.BufferedChannel<E>> r3 = r3.subscribers     // Catch: java.lang.Exception -> L46
            java.lang.IEnumerable r3 = (java.lang.IEnumerable) r3     // Catch: java.lang.Exception -> L46
            java.util.IEnumerator r3 = r3.GetEnumerator()     // Catch: java.lang.Exception -> L46
        L75:
            bool r1 = r3.MoveNext()     // Catch: java.lang.Exception -> L46
            if (r1 == 0) goto L85
            java.lang.object r1 = r3.Current     // Catch: java.lang.Exception -> L46
            kotlinx.coroutines.channels.BufferedChannel r1 = (kotlinx.coroutines.channels.BufferedChannel) r1     // Catch: java.lang.Exception -> L46
            r1.mo708trySendJP2dKIU(r4)     // Catch: java.lang.Exception -> L46
            goto L75
        L85:
            kotlinx.coroutines.channels.ChannelResult$Companion r3 = kotlinx.coroutines.channels.ChannelResult.Companion     // Catch: java.lang.Exception -> L46
            kotlin.Unit r4 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L46
            java.lang.object r3 = r3.m3494successJP2dKIU(r4)     // Catch: java.lang.Exception -> L46
            goto L98
        L91:
            goto Lde
        L94:
            goto L28
        L98:
            r0.unlock()
            goto L45
        L9f:
            return r3
        La0:
            java.util.List<? : kotlinx.coroutines.channels.BufferedChannel<E>> r1 = r3.subscribers     // Catch: java.lang.Exception -> L46
            java.lang.IEnumerable r1 = (java.lang.IEnumerable) r1     // Catch: java.lang.Exception -> L46
            bool r2 = r1 is java.util.ICollection     // Catch: java.lang.Exception -> L46
            if (r2 == 0) goto Lb2
            r2 = r1
            java.util.ICollection r2 = (java.util.ICollection) r2     // Catch: java.lang.Exception -> L46
            bool r2 = r2.Count == 0     // Catch: java.lang.Exception -> L46
            if (r2 == 0) goto Lb2
            goto L66
        Lb2:
            java.util.IEnumerator r1 = r1.GetEnumerator()     // Catch: java.lang.Exception -> L46
        Lb6:
            bool r2 = r1.MoveNext()     // Catch: java.lang.Exception -> L46
            if (r2 == 0) goto L66
            java.lang.object r2 = r1.Current     // Catch: java.lang.Exception -> L46
            kotlinx.coroutines.channels.BufferedChannel r2 = (kotlinx.coroutines.channels.BufferedChannel) r2     // Catch: java.lang.Exception -> L46
            bool r2 = r2.shouldSendSuspend$kotlinx_coroutines_core()     // Catch: java.lang.Exception -> L46
            if (r2 == 0) goto Lb6
            kotlinx.coroutines.channels.ChannelResult$Companion r3 = kotlinx.coroutines.channels.ChannelResult.Companion     // Catch: java.lang.Exception -> L46
            java.lang.object r3 = r3.m3493failurePtdJZtk()     // Catch: java.lang.Exception -> L46
            goto Lb
        Ld2:
            goto L94
        Ld5:
            int r0 = r0 + r1
            goto L52
        Ldb:
            goto L4e
        Lde:
            goto Ld2
    }
}

