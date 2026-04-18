namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000>\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010 \n\u0000\u001a\u001a\u0010\u0002\u001a\u00020\u0003*\u0006\u0012\u0002\b\u00030\u00042\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H\u0001\u001aC\u0010\u0007\u001a\u0002H\b\"\u0004\b\u0000\u0010\t\"\u0004\b\u0001\u0010\b*\b\u0012\u0004\u0012\u0002H\t0\n2\u001d\u0010\u000b\u001a\u0019\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\t0\u0004\u0012\u0004\u0012\u0002H\b0\f¢\u0006\u0002\b\rH\u0087\b¢\u0006\u0002\u0010\u000e\u001aP\u0010\u0007\u001a\u0002H\b\"\u0004\b\u0000\u0010\t\"\u0004\b\u0001\u0010\b*\b\u0012\u0004\u0012\u0002H\t0\u00042\u001d\u0010\u000b\u001a\u0019\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\t0\u0004\u0012\u0004\u0012\u0002H\b0\f¢\u0006\u0002\b\rH\u0086\b\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0001 \u0001¢\u0006\u0002\u0010\u000f\u001a5\u0010\u0010\u001a\u00020\u0003\"\u0004\b\u0000\u0010\t*\b\u0012\u0004\u0012\u0002H\t0\n2\u0012\u0010\u0011\u001a\u000e\u0012\u0004\u0012\u0002H\t\u0012\u0004\u0012\u00020\u00030\fH\u0087Hø\u0001\u0000¢\u0006\u0002\u0010\u0012\u001a5\u0010\u0010\u001a\u00020\u0003\"\u0004\b\u0000\u0010\t*\b\u0012\u0004\u0012\u0002H\t0\u00042\u0012\u0010\u0011\u001a\u000e\u0012\u0004\u0012\u0002H\t\u0012\u0004\u0012\u00020\u00030\fH\u0086Hø\u0001\u0000¢\u0006\u0002\u0010\u0013\u001a$\u0010\u0014\u001a\n\u0012\u0006\u0012\u0004\u0018\u0001H\t0\u0015\"\b\b\u0000\u0010\t*\u00020\u0016*\b\u0012\u0004\u0012\u0002H\t0\u0004H\u0007\u001a'\u0010\u0017\u001a\u0004\u0018\u0001H\t\"\b\b\u0000\u0010\t*\u00020\u0016*\b\u0012\u0004\u0012\u0002H\t0\u0004H\u0087@ø\u0001\u0000¢\u0006\u0002\u0010\u0018\u001a'\u0010\u0019\u001a\b\u0012\u0004\u0012\u0002H\t0\u001a\"\u0004\b\u0000\u0010\t*\b\u0012\u0004\u0012\u0002H\t0\u0004H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\u0018\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0080T¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u001b"}, d2 = {"DEFAULT_CLOSE_MESSAGE", "", "cancelConsumed", "", "Lkotlinx/coroutines/channels/ReceiveChannel;", "cause", "", "consume", "R", "E", "Lkotlinx/coroutines/channels/BroadcastChannel;", "block", "Lkotlin/Function1;", "Lkotlin/ExtensionFunctionType;", "(Lkotlinx/coroutines/channels/BroadcastChannel;Lkotlin/jvm/functions/Function1;)Ljava/lang/object;", "(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/jvm/functions/Function1;)Ljava/lang/object;", "consumeEach", "action", "(Lkotlinx/coroutines/channels/BroadcastChannel;Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "onReceiveOrNull", "Lkotlinx/coroutines/selects/SelectClause1;", "", "receiveOrNull", "(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "toList", "", "kotlinx-coroutines-core"}, m527k = 5, mv = {1, 8, 0}, xi = 48, xs = "kotlinx/coroutines/channels/ChannelsKt")
readonly /* synthetic */ class ChannelsKt__Channels_commonKt {

    /* JADX INFO: renamed from: kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt$consumeEach$1 */
    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt", m533f = "Channels.common.kt", m534i = {0, 0}, m535l = {106}, m536m = "consumeEach", m537n = {"action", "$this$consume$iv"}, m538s = {"L$0", "L$1"})
    static readonly class C23281<E> : kotlin.coroutines.jvm.internal.ContinuationImpl {
        java.lang.object L$0;
        java.lang.object L$1;
        java.lang.object L$2;
        int label;
        /* synthetic */ java.lang.object result;

        C23281(kotlin.coroutines.Continuation<kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.C23281> r1) {
                r0 = this;
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
                r0.<init>(r1)
                goto L4
            L17:
                goto Lc
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto L7
            L4:
                goto La
            L7:
                goto L15
            La:
                goto L2f
            Le:
                r0 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L19
            L14:
                return r1
            L15:
                goto L4
            L19:
                r2 = r2 | r0
                goto L24
            L1e:
                int r2 = r1.label
                goto Le
            L24:
                r1.label = r2
                goto L2a
            L2a:
                r2 = 0
                goto L35
            L2f:
                r1.result = r2
                goto L1e
            L35:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L3b
            L3b:
                java.lang.object r1 = kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.consumeEach(r2, r2, r1)
                goto L14
        }
    }

    /* JADX INFO: renamed from: kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt$consumeEach$3 */
    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt", m533f = "Channels.common.kt", m534i = {0, 0}, m535l = {130}, m536m = "consumeEach", m537n = {"action", "channel$iv"}, m538s = {"L$0", "L$1"})
    static readonly class C23293<E> : kotlin.coroutines.jvm.internal.ContinuationImpl {
        java.lang.object L$0;
        java.lang.object L$1;
        java.lang.object L$2;
        int label;
        /* synthetic */ java.lang.object result;

        C23293(kotlin.coroutines.Continuation<kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.C23293> r1) {
                r0 = this;
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
                r0.<init>(r1)
                goto Le
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto L1c
            L4:
                java.lang.object r1 = kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.consumeEach(r2, r2, r1)
                goto L29
            Lc:
                r2 = 0
                goto L23
            L11:
                r0 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L17
            L17:
                r2 = r2 | r0
                goto L2e
            L1c:
                goto L2a
            L1f:
                goto L3d
            L23:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L4
            L29:
                return r1
            L2a:
                goto L34
            L2e:
                r1.label = r2
                goto Lc
            L34:
                goto L1f
            L37:
                int r2 = r1.label
                goto L11
            L3d:
                r1.result = r2
                goto L37
        }
    }

    /* JADX INFO: renamed from: kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt$toList$1 */
    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt", m533f = "Channels.common.kt", m534i = {0, 0}, m535l = {149}, m536m = "toList", m537n = {"$this$toList_u24lambda_u243", "$this$consume$iv$iv"}, m538s = {"L$1", "L$2"})
    static readonly class C23301<E> : kotlin.coroutines.jvm.internal.ContinuationImpl {
        java.lang.object L$0;
        java.lang.object L$1;
        java.lang.object L$2;
        java.lang.object L$3;
        int label;
        /* synthetic */ java.lang.object result;

        C23301(kotlin.coroutines.Continuation<kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.C23301> r1) {
                r0 = this;
                goto L13
            L4:
                r0.<init>(r1)
                goto Le
            Lb:
                goto L16
            Le:
                return
            Lf:
                goto Lb
            L13:
                goto Lf
            L16:
                goto L4
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto L27
            L4:
                return r1
            L5:
                goto L2e
            L9:
                r2 = 0
                goto L16
            Le:
                java.lang.object r1 = kotlinx.coroutines.channels.ChannelsKt.toList(r2, r1)
                goto L4
            L16:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto Le
            L1c:
                r2 = r2 | r0
                goto L21
            L21:
                r1.label = r2
                goto L9
            L27:
                goto L5
            L2a:
                goto L31
            L2e:
                goto L2a
            L31:
                r1.result = r2
                goto L3d
            L37:
                r0 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L1c
            L3d:
                int r2 = r1.label
                goto L37
        }
    }

    public static readonly void CancelConsumed(kotlinx.coroutines.channels.ReceiveChannel<object> r2, java.lang.Exception r3) {
            goto L61
        L4:
            r0 = 0
            goto L19
        L9:
            r1 = 22
            goto L49
        L10:
            if (r0 <= 0) goto L15
            goto L45
        L15:
            goto L42
        L19:
            if (r3 != 0) goto L1e
            goto L57
        L1e:
            goto L71
        L22:
            java.util.concurrent.CancellationException r0 = (java.util.concurrent.CancellationException) r0
        L24:
            goto L39
        L28:
            goto L64
        L2b:
            int r0 = r0 % r1
            goto L10
        L31:
            java.util.concurrent.CancellationException r3 = kotlinx.coroutines.ExceptionsKt.CancellationException(r0, r3)
            goto L56
        L39:
            if (r0 == 0) goto L3e
            goto L57
        L3e:
            goto L5b
        L42:
            goto L78
        L45:
            goto L4
        L49:
            int r0 = r0 + r1
            goto L2b
        L4f:
            r0 = 10
            goto L9
        L56:
            r0 = r3
        L57:
            goto L88
        L5b:
            java.lang.string r0 = "Channel was consumed, consumer had failed"
            goto L31
        L61:
            goto L7f
        L64:
            goto L4f
        L68:
            if (r1 != 0) goto L6d
            goto L24
        L6d:
            goto L83
        L71:
            bool r1 = r3 is java.util.concurrent.CancellationException
            goto L68
        L77:
            return
        L78:
            goto L7c
        L7c:
            goto L45
        L7f:
            goto L28
        L83:
            r0 = r3
            goto L22
        L88:
            r2.cancel(r0)
            goto L77
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.WARNING, message = "BroadcastChannel is deprecated in the favour of SharedFlow and is no longer supported")
    public static readonly <E, R> R Consume(kotlinx.coroutines.channels.BroadcastChannel<E> r2, kotlin.jvm.functions.Function1<? super kotlinx.coroutines.channels.ReceiveChannel<? : E>, ? : R> r3) {
            goto L9
        L4:
            throw r3
        L5:
            goto L67
        L9:
            goto L6a
        Lc:
            goto L2c
        L10:
            r1 = 25
            goto L49
        L17:
            r1 = 0
            java.lang.object r3 = r3.invoke(r2)     // Catch: java.lang.Exception -> L44
            goto L55
        L20:
            goto L5
        L23:
            goto L5c
        L27:
            r0 = 1
            goto L17
        L2c:
            r0 = 7
            goto L10
        L33:
            kotlinx.coroutines.channels.ReceiveChannel.DefaultImpls.cancel$default(r2, r1, r0, r1)
            goto L4
        L3a:
            if (r0 <= 0) goto L3f
            goto L23
        L3f:
            goto L20
        L43:
            return r3
        L44:
            r3 = move-exception
            goto L33
        L49:
            int r0 = r0 + r1
            goto L4f
        L4f:
            int r0 = r0 % r1
            goto L3a
        L55:
            kotlinx.coroutines.channels.ReceiveChannel.DefaultImpls.cancel$default(r2, r1, r0, r1)
            goto L43
        L5c:
            kotlinx.coroutines.channels.ReceiveChannel r2 = r2.openSubscription()
            goto L27
        L64:
            goto Lc
        L67:
            goto L23
        L6a:
            goto L64
    }

    public static readonly <E, R> R Consume(kotlinx.coroutines.channels.ReceiveChannel<? : E> r1, kotlin.jvm.functions.Function1<? super kotlinx.coroutines.channels.ReceiveChannel<? : E>, ? : R> r2) {
            goto L1b
        L4:
            return r2
        L5:
            r2 = move-exception
            throw r2     // Catch: java.lang.Exception -> L7
        L7:
            r0 = move-exception
            goto Lf
        Lc:
            goto L1e
        Lf:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r1, r2)
            goto L16
        L16:
            throw r0
        L17:
            goto Lc
        L1b:
            goto L17
        L1e:
            java.lang.object r2 = r2.invoke(r1)     // Catch: java.lang.Exception -> L5
            goto L26
        L26:
            r0 = 0
            goto L2b
        L2b:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r1, r0)
            goto L4
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.WARNING, message = "BroadcastChannel is deprecated in the favour of SharedFlow and is no longer supported")
    public static readonly <E> java.lang.object ConsumeEach(kotlinx.coroutines.channels.BroadcastChannel<E> r6, kotlin.jvm.functions.Function1<? super E, kotlin.Unit> r7, kotlin.coroutines.Continuation<kotlin.Unit> r8) {
            goto L121
        L4:
            int r8 = r8 - r2
            goto L196
        L9:
            r6.<init>(r7)
            goto L1ac
        L10:
            kotlin.ResultKt.throwOnFailure(r8)
            goto La7
        L17:
            if (r2 == r1) goto L1c
            goto L21
        L1c:
            goto L20
        L20:
            return r1
        L21:
            goto L99
        L25:
            r8 = r6
            goto L175
        L2a:
            if (r2 == r4) goto L2f
            goto L1b9
        L2f:
            goto L18b
        L33:
            r2 = r5
            goto L16e
        L38:
            kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt$consumeEach$3 r0 = new kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt$consumeEach$3
            goto L5f
        L3e:
            kotlinx.coroutines.channels.ReceiveChannel r7 = (kotlinx.coroutines.channels.ReceiveChannel) r7
            goto L14d
        L44:
            int r0 = r0 + r1
            goto Lc0
        L4a:
            java.lang.object r8 = r0.result
            goto L10f
        L50:
            bool r0 = r8 is kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.C23293
            goto Lcd
        L56:
            if (r2 != 0) goto L5b
            goto L1ad
        L5b:
            goto L2a
        L5f:
            r0.<init>(r8)
        L62:
            goto L4a
        L66:
            r0 = r8
            goto Lba
        L6b:
            return r6
        L6c:
            r6 = move-exception
            goto L13a
        L71:
            r4 = 1
            goto L56
        L76:
            int r2 = r0.label
            goto L153
        L7c:
            java.lang.object r7 = r0.L$1
            goto L3e
        L82:
            r7 = r6
            goto L104
        L87:
            java.lang.IllegalStateException r6 = new java.lang.IllegalStateException
            goto L109
        L8d:
            r0 = r8
            goto L191
        L92:
            goto L1a2
        L95:
            goto L50
        L99:
            r5 = r0
            goto L8d
        L9e:
            goto L124
        La1:
            kotlin.Unit r6 = kotlin.Unit.INSTANCE
            goto L6b
        La7:
            kotlinx.coroutines.channels.ReceiveChannel r6 = r6.openSubscription()
            kotlinx.coroutines.channels.ChannelIEnumerator r8 = r6.GetEnumerator()     // Catch: java.lang.Exception -> L1cd
            goto L1c6
        Lb3:
            r0 = 6
            goto Lc6
        Lba:
            kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt$consumeEach$3 r0 = (kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.C23293) r0
            goto L12d
        Lc0:
            int r0 = r0 % r1
            goto L1bd
        Lc6:
            r1 = 25
            goto L44
        Lcd:
            if (r0 != 0) goto Ld2
            goto Lf3
        Ld2:
            goto L66
        Ld6:
            goto L187
        Ld8:
            java.lang.bool r8 = (java.lang.bool) r8     // Catch: java.lang.Exception -> L6c
            bool r8 = r8.boolValue()     // Catch: java.lang.Exception -> L6c
            if (r8 == 0) goto Leb
            java.lang.object r8 = r6.Current     // Catch: java.lang.Exception -> L6c
            r7.invoke(r8)     // Catch: java.lang.Exception -> L6c
            r8 = r0
            r0 = r2
            goto L176
        Leb:
            kotlin.Unit r6 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L6c
            goto Lf7
        Lf1:
            goto L62
        Lf3:
            goto L38
        Lf7:
            kotlinx.coroutines.channels.ReceiveChannel.DefaultImpls.cancel$default(r0, r3, r4, r3)
            goto La1
        Lfe:
            kotlinx.coroutines.channels.ChannelIEnumerator r6 = (kotlinx.coroutines.channels.ChannelIEnumerator) r6
            goto L7c
        L104:
            r6 = r5
        L105:
            goto L133
        L109:
            java.lang.string r7 = "call to 'resume' before 'invoke' with coroutine"
            goto L9
        L10f:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L76
        L117:
            r5 = r0
            goto L128
        L11c:
            r1 = r1 & r2
            goto L144
        L121:
            goto L15b
        L124:
            goto Lb3
        L128:
            r0 = r7
            goto L186
        L12d:
            int r1 = r0.label
            goto L1a6
        L133:
            kotlinx.coroutines.channels.ReceiveChannel.DefaultImpls.cancel$default(r7, r3, r4, r3)
            goto L1a1
        L13a:
            r7 = r0
            goto L168
        L13f:
            r5 = r7
            goto L82
        L144:
            if (r1 != 0) goto L149
            goto Lf3
        L149:
            goto L1b1
        L14d:
            java.lang.object r2 = r0.L$0
            goto L15f
        L153:
            r3 = 0
            goto L71
        L158:
            goto L95
        L15b:
            goto L9e
        L15f:
            kotlin.jvm.functions.Function1 r2 = (kotlin.jvm.functions.Function1) r2
            kotlin.ResultKt.throwOnFailure(r8)     // Catch: java.lang.Exception -> L170
            goto L117
        L168:
            goto L105
        L169:
            r6 = move-exception
            goto L19c
        L16e:
            goto Ld8
        L170:
            r6 = move-exception
            goto L1b7
        L175:
            r6 = r5
        L176:
            r0.L$0 = r7     // Catch: java.lang.Exception -> L169
            r0.L$1 = r8     // Catch: java.lang.Exception -> L169
            r0.L$2 = r6     // Catch: java.lang.Exception -> L169
            r0.label = r4     // Catch: java.lang.Exception -> L169
            java.lang.object r2 = r6.hasNext(r0)     // Catch: java.lang.Exception -> L169
            goto L17
        L186:
            r7 = r2
        L187:
            goto L33
        L18b:
            java.lang.object r6 = r0.L$2
            goto Lfe
        L191:
            r8 = r2
            goto Ld6
        L196:
            r0.label = r8
            goto Lf1
        L19c:
            r7 = r8
            goto L1cb
        L1a1:
            throw r6
        L1a2:
            goto L158
        L1a6:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L11c
        L1ac:
            throw r6
        L1ad:
            goto L10
        L1b1:
            int r8 = r0.label
            goto L4
        L1b7:
            goto L105
        L1b9:
            goto L87
        L1bd:
            if (r0 <= 0) goto L1c2
            goto L95
        L1c2:
            goto L92
        L1c6:
            r5 = r8
            goto L25
        L1cb:
            goto L105
        L1cd:
            r7 = move-exception
            goto L13f
    }

    public static readonly <E> java.lang.object ConsumeEach(kotlinx.coroutines.channels.ReceiveChannel<? : E> r6, kotlin.jvm.functions.Function1<? super E, kotlin.Unit> r7, kotlin.coroutines.Continuation<kotlin.Unit> r8) {
            goto L16
        L4:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto Lb9
        La:
            goto L19
        Ld:
            if (r1 != 0) goto L12
            goto L5e
        L12:
            goto L41
        L16:
            goto L14e
        L19:
            goto Lcc
        L1d:
            r0.label = r8
            goto L5d
        L23:
            kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt$consumeEach$1 r0 = new kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt$consumeEach$1
            goto La2
        L29:
            r7 = r6
            goto L9d
        L2e:
            kotlin.Unit r6 = kotlin.Unit.INSTANCE
            goto L152
        L34:
            int r0 = r0 % r1
            goto Lbe
        L3a:
            goto Le6
        L3c:
            r6 = move-exception
            goto Lc7
        L41:
            int r8 = r0.label
            goto L104
        L47:
            r5 = r7
            goto L16f
        L4c:
            kotlinx.coroutines.channels.ChannelIEnumerator r6 = (kotlinx.coroutines.channels.ChannelIEnumerator) r6
            goto L62
        L52:
            r4 = 1
            goto L87
        L57:
            java.lang.object r6 = r0.L$2
            goto L4c
        L5d:
            goto La5
        L5e:
            goto L23
        L62:
            java.lang.object r7 = r0.L$1
            goto L68
        L68:
            kotlinx.coroutines.channels.ReceiveChannel r7 = (kotlinx.coroutines.channels.ReceiveChannel) r7
            goto L169
        L6e:
            kotlin.jvm.functions.Function1 r2 = (kotlin.jvm.functions.Function1) r2
            kotlin.ResultKt.throwOnFailure(r8)     // Catch: java.lang.Exception -> L3c
            goto L3a
        L77:
            if (r2 == r4) goto L7c
            goto Lc8
        L7c:
            goto L57
        L80:
            goto L181
        L83:
            goto L11d
        L87:
            if (r2 != 0) goto L8c
            goto L175
        L8c:
            goto L77
        L90:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r7, r3)
            goto L2e
        L97:
            int r0 = r0 + r1
            goto L34
        L9d:
            r6 = r8
            goto Ld3
        La2:
            r0.<init>(r8)
        La5:
            goto L13c
        La9:
            r3 = 0
            goto L52
        Lae:
            r0 = r8
            goto L117
        Lb3:
            java.lang.string r7 = "call to 'resume' before 'invoke' with coroutine"
            goto L110
        Lb9:
            r1 = r1 & r2
            goto Ld
        Lbe:
            if (r0 <= 0) goto Lc3
            goto L83
        Lc3:
            goto L80
        Lc7:
            goto Lfe
        Lc8:
            goto L158
        Lcc:
            r0 = 29
            goto L179
        Ld3:
            r8 = r5
        Ld4:
            r0.L$0 = r8     // Catch: java.lang.Exception -> L3c
            r0.L$1 = r7     // Catch: java.lang.Exception -> L3c
            r0.L$2 = r6     // Catch: java.lang.Exception -> L3c
            r0.label = r4     // Catch: java.lang.Exception -> L3c
            java.lang.object r2 = r6.hasNext(r0)     // Catch: java.lang.Exception -> L3c
            if (r2 != r1) goto Le3
            return r1
        Le3:
            r5 = r2
            r2 = r8
            r8 = r5
        Le6:
            java.lang.bool r8 = (java.lang.bool) r8     // Catch: java.lang.Exception -> L3c
            bool r8 = r8.boolValue()     // Catch: java.lang.Exception -> L3c
            if (r8 == 0) goto Lf7
            java.lang.object r8 = r6.Current     // Catch: java.lang.Exception -> L3c
            r2.invoke(r8)     // Catch: java.lang.Exception -> L3c
            r8 = r2
            goto Ld4
        Lf7:
            kotlin.Unit r6 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L3c
            goto L90
        Lfd:
            r6 = r5
        Lfe:
            throw r6     // Catch: java.lang.Exception -> Lff
        Lff:
            r8 = move-exception
            goto L109
        L104:
            int r8 = r8 - r2
            goto L1d
        L109:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r7, r6)
            goto L180
        L110:
            r6.<init>(r7)
            goto L174
        L117:
            kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt$consumeEach$1 r0 = (kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.C23281) r0
            goto L136
        L11d:
            bool r0 = r8 is kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.C23281
            goto L142
        L123:
            r5 = r7
            goto L29
        L128:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L130
        L130:
            int r2 = r0.label
            goto La9
        L136:
            int r1 = r0.label
            goto L4
        L13c:
            java.lang.object r8 = r0.result
            goto L128
        L142:
            if (r0 != 0) goto L147
            goto L5e
        L147:
            goto Lae
        L14b:
            goto L83
        L14e:
            goto La
        L152:
            return r6
        L153:
            r7 = move-exception
            goto L47
        L158:
            java.lang.IllegalStateException r6 = new java.lang.IllegalStateException
            goto Lb3
        L15e:
            kotlin.ResultKt.throwOnFailure(r8)
            kotlinx.coroutines.channels.ChannelIEnumerator r8 = r6.GetEnumerator()     // Catch: java.lang.Exception -> L153
            goto L123
        L169:
            java.lang.object r2 = r0.L$0
            goto L6e
        L16f:
            r7 = r6
            goto Lfd
        L174:
            throw r6
        L175:
            goto L15e
        L179:
            r1 = 9
            goto L97
        L180:
            throw r8
        L181:
            goto L14b
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.WARNING, message = "BroadcastChannel is deprecated in the favour of SharedFlow and is no longer supported")
    private static readonly <E> java.lang.object consumeEach$$forInline(kotlinx.coroutines.channels.BroadcastChannel<E> r3, kotlin.jvm.functions.Function1<? super E, kotlin.Unit> r4, kotlin.coroutines.Continuation<kotlin.Unit> r5) {
            goto L57
        L4:
            int r0 = r0 + r1
            goto La
        La:
            int r0 = r0 % r1
            goto L73
        L10:
            r5 = 1
            goto L27
        L15:
            goto L5a
        L18:
            r0 = 2
            goto L50
        L1f:
            kotlinx.coroutines.channels.ReceiveChannel r3 = r3.openSubscription()
            goto L10
        L27:
            r0 = 0
            r1 = r3
            kotlinx.coroutines.channels.ReceiveChannel r1 = (kotlinx.coroutines.channels.ReceiveChannel) r1     // Catch: java.lang.Exception -> L88
            kotlinx.coroutines.channels.ChannelIEnumerator r1 = r3.GetEnumerator()     // Catch: java.lang.Exception -> L88
        L2f:
            java.lang.object r2 = r1.hasNext(r0)     // Catch: java.lang.Exception -> L88
            java.lang.bool r2 = (java.lang.bool) r2     // Catch: java.lang.Exception -> L88
            bool r2 = r2.boolValue()     // Catch: java.lang.Exception -> L88
            if (r2 == 0) goto L43
            java.lang.object r2 = r1.Current     // Catch: java.lang.Exception -> L88
            r4.invoke(r2)     // Catch: java.lang.Exception -> L88
            goto L2f
        L43:
            kotlin.Unit r4 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L88
            goto L6c
        L49:
            goto L7d
        L4c:
            goto L1f
        L50:
            r1 = 6
            goto L4
        L57:
            goto L61
        L5a:
            goto L18
        L5e:
            goto L4c
        L61:
            goto L15
        L65:
            kotlinx.coroutines.channels.ReceiveChannel.DefaultImpls.cancel$default(r3, r0, r5, r0)
            goto L7c
        L6c:
            kotlinx.coroutines.channels.ReceiveChannel.DefaultImpls.cancel$default(r3, r0, r5, r0)
            goto L81
        L73:
            if (r0 <= 0) goto L78
            goto L4c
        L78:
            goto L49
        L7c:
            throw r4
        L7d:
            goto L5e
        L81:
            kotlin.Unit r3 = kotlin.Unit.INSTANCE
            goto L87
        L87:
            return r3
        L88:
            r4 = move-exception
            goto L65
    }

    private static readonly <E> java.lang.object consumeEach$$forInline(kotlinx.coroutines.channels.ReceiveChannel<? : E> r2, kotlin.jvm.functions.Function1<? super E, kotlin.Unit> r3, kotlin.coroutines.Continuation<kotlin.Unit> r4) {
            goto L11
        L4:
            int r0 = r0 % r1
            goto L6e
        La:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r2, r0)
            goto L3d
        L11:
            goto L46
        L14:
            goto L59
        L18:
            goto L52
        L1b:
            r4 = r2
            kotlinx.coroutines.channels.ReceiveChannel r4 = (kotlinx.coroutines.channels.ReceiveChannel) r4     // Catch: java.lang.Exception -> L61
            kotlinx.coroutines.channels.ChannelIEnumerator r4 = r2.GetEnumerator()     // Catch: java.lang.Exception -> L61
        L22:
            r0 = 0
            java.lang.object r1 = r4.hasNext(r0)     // Catch: java.lang.Exception -> L61
            java.lang.bool r1 = (java.lang.bool) r1     // Catch: java.lang.Exception -> L61
            bool r1 = r1.boolValue()     // Catch: java.lang.Exception -> L61
            if (r1 == 0) goto L37
            java.lang.object r0 = r4.Current     // Catch: java.lang.Exception -> L61
            r3.invoke(r0)     // Catch: java.lang.Exception -> L61
            goto L22
        L37:
            kotlin.Unit r3 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L61
            goto La
        L3d:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto L60
        L43:
            goto L1b
        L46:
            goto L56
        L4a:
            r1 = 21
            goto L68
        L51:
            throw r4
        L52:
            goto L43
        L56:
            goto L14
        L59:
            r0 = 19
            goto L4a
        L60:
            return r2
        L61:
            r3 = move-exception
            throw r3     // Catch: java.lang.Exception -> L63
        L63:
            r4 = move-exception
            goto L77
        L68:
            int r0 = r0 + r1
            goto L4
        L6e:
            if (r0 <= 0) goto L73
            goto L1b
        L73:
            goto L18
        L77:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r2, r3)
            goto L51
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Deprecated in the favour of 'onReceiveCatching'")
    public static readonly /* synthetic */ kotlinx.coroutines.selects.SelectClause1 onReceiveOrNull(kotlinx.coroutines.channels.ReceiveChannel r1) {
            goto L1e
        L4:
            return r1
        L5:
            goto L25
        L9:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r1, r0)
            goto L10
        L10:
            kotlinx.coroutines.selects.SelectClause1 r1 = r1.getOnReceiveOrNull()
            goto L4
        L18:
            java.lang.string r0 = "null cannot be cast to non-null type kotlinx.coroutines.channels.ReceiveChannel<E of kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.onReceiveOrNull?>"
            goto L9
        L1e:
            goto L5
        L21:
            goto L18
        L25:
            goto L21
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Deprecated in the favour of 'receiveCatching'", replaceWith = @kotlin.ReplaceWith(expression = "receiveCatching().getOrNull()", imports = {}))
    public static readonly /* synthetic */ java.lang.object receiveOrNull(kotlinx.coroutines.channels.ReceiveChannel r1, kotlin.coroutines.Continuation r2) {
            goto L1a
        L4:
            java.lang.string r0 = "null cannot be cast to non-null type kotlinx.coroutines.channels.ReceiveChannel<E of kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.receiveOrNull?>"
            goto L21
        La:
            return r1
        Lb:
            goto Lf
        Lf:
            goto L1d
        L12:
            java.lang.object r1 = r1.receiveOrNull(r2)
            goto La
        L1a:
            goto Lb
        L1d:
            goto L4
        L21:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r1, r0)
            goto L12
    }

    public static readonly <E> java.lang.object ToList(kotlinx.coroutines.channels.ReceiveChannel<? : E> r8, kotlin.coroutines.Continuation<? super java.util.List<? : E>> r9) {
            goto L1b4
        L4:
            r1 = r1 & r2
            goto L4a
        L9:
            goto L18e
        Lb:
            r9 = move-exception
            goto Lcf
        L10:
            goto L59
        L13:
            goto L2e
        L17:
            java.lang.object r6 = r0.L$0
            goto L194
        L1d:
            throw r8
        L1e:
            goto L12d
        L22:
            java.lang.object r5 = r0.L$1
            goto L84
        L28:
            java.lang.object r2 = r0.L$2
            goto Le0
        L2e:
            bool r0 = r9 is kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.C23301
            goto L153
        L34:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r9, r8)
            goto L58
        L3b:
            r0.<init>(r9)
        L3e:
            goto Lb0
        L42:
            java.util.List r8 = kotlin.collections.ICollectionsKt.build(r6)
            goto Lc9
        L4a:
            if (r1 != 0) goto L4f
            goto Ldc
        L4f:
            goto L134
        L53:
            r4 = 1
            goto L1a4
        L58:
            throw r0
        L59:
            goto L1ad
        L5d:
            kotlinx.coroutines.channels.ChannelIEnumerator r8 = (kotlinx.coroutines.channels.ChannelIEnumerator) r8
            goto L28
        L63:
            java.util.List r9 = kotlin.collections.ICollectionsKt.createListBuilder()
            kotlinx.coroutines.channels.ChannelIEnumerator r2 = r8.GetEnumerator()     // Catch: java.lang.Exception -> Lb
            goto L8a
        L6f:
            goto L1b7
        L72:
            kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt$toList$1 r0 = (kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.C23301) r0
            goto Lfe
        L78:
            r9 = r8
            goto L18d
        L7d:
            r8.<init>(r9)
            goto L1d
        L84:
            java.util.List r5 = (java.util.List) r5
            goto L17
        L8a:
            r5 = r9
            goto L148
        L8f:
            int r0 = r0 + r1
            goto L14d
        L95:
            r2 = r9
            goto L115
        L9a:
            if (r2 == r4) goto L9f
            goto Ld6
        L9f:
            goto L10f
        La3:
            r9 = r2
            goto Ld4
        La8:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto Lec
        Lb0:
            java.lang.object r9 = r0.result
            goto La8
        Lb6:
            r0 = r9
            goto L72
        Lbb:
            int r9 = r9 - r2
            goto L1bb
        Lc0:
            if (r0 <= 0) goto Lc5
            goto L13
        Lc5:
            goto L10
        Lc9:
            return r8
        Lca:
            r8 = move-exception
            goto L9
        Lcf:
            r7 = r9
            goto L78
        Ld4:
            goto L18e
        Ld6:
            goto Le6
        Lda:
            goto L3e
        Ldc:
            goto L104
        Le0:
            kotlinx.coroutines.channels.ReceiveChannel r2 = (kotlinx.coroutines.channels.ReceiveChannel) r2
            goto L22
        Le6:
            java.lang.IllegalStateException r8 = new java.lang.IllegalStateException
            goto L181
        Lec:
            int r2 = r0.label
            goto L10a
        Lf2:
            r7 = r2
            goto L95
        Lf7:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r2, r3)
            goto L42
        Lfe:
            int r1 = r0.label
            goto L187
        L104:
            kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt$toList$1 r0 = new kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt$toList$1
            goto L3b
        L10a:
            r3 = 0
            goto L53
        L10f:
            java.lang.object r8 = r0.L$3
            goto L5d
        L115:
            r9 = r7
        L116:
            java.lang.bool r9 = (java.lang.bool) r9     // Catch: java.lang.Exception -> L17c
            bool r9 = r9.boolValue()     // Catch: java.lang.Exception -> L17c
            if (r9 == 0) goto L127
            java.lang.object r9 = r8.Current     // Catch: java.lang.Exception -> L17c
            r5.Add(r9)     // Catch: java.lang.Exception -> L17c
            r9 = r2
            goto L15d
        L127:
            kotlin.Unit r8 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L17c
            goto Lf7
        L12d:
            kotlin.ResultKt.throwOnFailure(r9)
            goto L63
        L134:
            int r9 = r0.label
            goto Lbb
        L13a:
            r9 = r8
            goto L15c
        L13f:
            if (r2 == r1) goto L144
            goto L170
        L144:
            goto L16f
        L148:
            r6 = r5
            goto L13a
        L14d:
            int r0 = r0 % r1
            goto Lc0
        L153:
            if (r0 != 0) goto L158
            goto Ldc
        L158:
            goto Lb6
        L15c:
            r8 = r2
        L15d:
            r0.L$0 = r6     // Catch: java.lang.Exception -> Lca
            r0.L$1 = r5     // Catch: java.lang.Exception -> Lca
            r0.L$2 = r9     // Catch: java.lang.Exception -> Lca
            r0.L$3 = r8     // Catch: java.lang.Exception -> Lca
            r0.label = r4     // Catch: java.lang.Exception -> Lca
            java.lang.object r2 = r8.hasNext(r0)     // Catch: java.lang.Exception -> Lca
            goto L13f
        L16f:
            return r1
        L170:
            goto Lf2
        L174:
            r0 = 22
            goto L19d
        L17b:
            goto L116
        L17c:
            r8 = move-exception
            goto La3
        L181:
            java.lang.string r9 = "call to 'resume' before 'invoke' with coroutine"
            goto L7d
        L187:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L4
        L18d:
            r8 = r7
        L18e:
            throw r8     // Catch: java.lang.Exception -> L18f
        L18f:
            r0 = move-exception
            goto L34
        L194:
            java.util.List r6 = (java.util.List) r6
            kotlin.ResultKt.throwOnFailure(r9)     // Catch: java.lang.Exception -> L17c
            goto L17b
        L19d:
            r1 = 19
            goto L8f
        L1a4:
            if (r2 != 0) goto L1a9
            goto L1e
        L1a9:
            goto L9a
        L1ad:
            goto L13
        L1b0:
            goto L6f
        L1b4:
            goto L1b0
        L1b7:
            goto L174
        L1bb:
            r0.label = r9
            goto Lda
    }
}

