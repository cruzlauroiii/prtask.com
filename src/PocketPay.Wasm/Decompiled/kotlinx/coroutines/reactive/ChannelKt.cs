namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000$\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\u001a5\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u00020\u00010\u0005H\u0086Hø\u0001\u0000¢\u0006\u0002\u0010\u0006\u001a(\u0010\u0007\u001a\b\u0012\u0004\u0012\u0002H\u00020\b\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\b\b\u0002\u0010\t\u001a\u00020\nH\u0007\u001a(\u0010\u000b\u001a\b\u0012\u0004\u0012\u0002H\u00020\b\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\b\b\u0002\u0010\t\u001a\u00020\nH\u0001\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\f"}, d2 = {"collect", "", "T", "Lp5a445d71/p18f29add/p32c73be0;", "action", "Lkotlin/Function1;", "(Lp5a445d71/p18f29add/p32c73be0;Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "openSubscription", "Lkotlinx/coroutines/channels/ReceiveChannel;", "request", "", "toChannel", "kotlinx-coroutines-reactive"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class ChannelKt {

    /* JADX INFO: renamed from: kotlinx.coroutines.reactive.ChannelKt$collect$1 */
    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.reactive.ChannelKt", m533f = "Channel.kt", m534i = {0, 0}, m535l = {119}, m536m = "collect", m537n = {"action", "$this$consume$iv$iv"}, m538s = {"L$0", "L$1"})
    static readonly class C25121<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
        java.lang.object L$0;
        java.lang.object L$1;
        java.lang.object L$2;
        int label;
        /* synthetic */ java.lang.object result;

        C25121(kotlin.coroutines.Continuation<kotlinx.coroutines.reactive.ChannelKt.C25121> r1) {
                r0 = this;
                goto L4
            L4:
                goto L16
            L7:
                goto Le
            Lb:
                goto L7
            Le:
                r0.<init>(r1)
                goto L15
            L15:
                return
            L16:
                goto Lb
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto L1d
            L4:
                int r2 = r1.label
                goto L2e
            La:
                r1.result = r2
                goto L4
            L10:
                return r1
            L11:
                goto L40
            L15:
                java.lang.object r1 = kotlinx.coroutines.reactive.ChannelKt.collect(r2, r2, r1)
                goto L10
            L1d:
                goto L11
            L20:
                goto La
            L24:
                r2 = r2 | r0
                goto L3a
            L29:
                r2 = 0
                goto L34
            L2e:
                r0 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L24
            L34:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L15
            L3a:
                r1.label = r2
                goto L29
            L40:
                goto L20
        }
    }

    public static readonly <T> java.lang.object Collect(org.reactivestreams.Publisher<T> r6, kotlin.jvm.functions.Function1<? super T, kotlin.Unit> r7, kotlin.coroutines.Continuation<kotlin.Unit> r8) {
            goto L4
        L4:
            goto L16b
        L7:
            goto L142
        Lb:
            if (r0 <= 0) goto L10
            goto L42
        L10:
            goto L3f
        L14:
            r0 = r7
            goto L163
        L19:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r0, r3)
            goto L149
        L20:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r7, r6)
            goto L135
        L27:
            r1 = r1 & r2
            goto L9e
        L2c:
            r5 = r7
            goto Lbe
        L31:
            r8 = r6
            goto Le5
        L36:
            if (r2 == r1) goto L3b
            goto L8f
        L3b:
            goto L8e
        L3f:
            goto L136
        L42:
            goto L17f
        L46:
            r0 = r8
            goto Lb8
        L4b:
            int r8 = r8 - r2
            goto L196
        L50:
            int r0 = r0 + r1
            goto L19c
        L56:
            r7 = r8
            goto L10f
        L5b:
            java.lang.object r8 = r0.result
            goto L13a
        L61:
            goto L7
        L64:
            throw r6
        L65:
            goto Ld8
        L69:
            r5 = r8
            goto L31
        L6e:
            goto L164
        L70:
            java.lang.bool r8 = (java.lang.bool) r8     // Catch: java.lang.Exception -> L89
            bool r8 = r8.boolValue()     // Catch: java.lang.Exception -> L89
            if (r8 == 0) goto L82
            java.lang.object r8 = r6.Current     // Catch: java.lang.Exception -> L89
            r7.invoke(r8)     // Catch: java.lang.Exception -> L89
            r8 = r0
            r0 = r2
            goto Le6
        L82:
            kotlin.Unit r6 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L89
            goto L19
        L88:
            return r6
        L89:
            r6 = move-exception
            goto L185
        L8e:
            return r1
        L8f:
            goto L99
        L93:
            kotlinx.coroutines.channels.ReceiveChannel r7 = (kotlinx.coroutines.channels.ReceiveChannel) r7
            goto L14f
        L99:
            r5 = r0
            goto Lfc
        L9e:
            if (r1 != 0) goto La3
            goto L10b
        La3:
            goto Lf6
        La7:
            kotlinx.coroutines.channels.ChannelIEnumerator r6 = (kotlinx.coroutines.channels.ChannelIEnumerator) r6
            goto L190
        Lad:
            r2 = r5
            goto L11d
        Lb2:
            java.lang.string r7 = "call to 'resume' before 'invoke' with coroutine"
            goto L116
        Lb8:
            kotlinx.coroutines.reactive.ChannelKt$collect$1 r0 = (kotlinx.coroutines.reactive.ChannelKt.C25121) r0
            goto L1be
        Lbe:
            r7 = r6
            goto L1a2
        Lc3:
            r0.<init>(r8)
        Lc6:
            goto L5b
        Lca:
            kotlin.jvm.functions.Function1 r2 = (kotlin.jvm.functions.Function1) r2
            kotlin.ResultKt.throwOnFailure(r8)     // Catch: java.lang.Exception -> L11f
            goto L17a
        Ld3:
            r4 = 1
            goto L101
        Ld8:
            kotlin.ResultKt.throwOnFailure(r8)
            goto L129
        Ldf:
            java.lang.IllegalStateException r6 = new java.lang.IllegalStateException
            goto Lb2
        Le5:
            r6 = r5
        Le6:
            r0.L$0 = r7     // Catch: java.lang.Exception -> L1d1
            r0.L$1 = r8     // Catch: java.lang.Exception -> L1d1
            r0.L$2 = r6     // Catch: java.lang.Exception -> L1d1
            r0.label = r4     // Catch: java.lang.Exception -> L1d1
            java.lang.object r2 = r6.hasNext(r0)     // Catch: java.lang.Exception -> L1d1
            goto L36
        Lf6:
            int r8 = r0.label
            goto L4b
        Lfc:
            r0 = r8
            goto L124
        L101:
            if (r2 != 0) goto L106
            goto L65
        L106:
            goto L155
        L10a:
            goto Lc6
        L10b:
            goto L1a9
        L10f:
            goto L1a3
        L111:
            r7 = move-exception
            goto L2c
        L116:
            r6.<init>(r7)
            goto L64
        L11d:
            goto L70
        L11f:
            r6 = move-exception
            goto L15e
        L124:
            r8 = r2
            goto L6e
        L129:
            r8 = 0
            goto L1c4
        L12e:
            r1 = 13
            goto L50
        L135:
            throw r8
        L136:
            goto L168
        L13a:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L1af
        L142:
            r0 = 29
            goto L12e
        L149:
            kotlin.Unit r6 = kotlin.Unit.INSTANCE
            goto L88
        L14f:
            java.lang.object r2 = r0.L$0
            goto Lca
        L155:
            if (r2 == r4) goto L15a
            goto L15f
        L15a:
            goto L16f
        L15e:
            goto L1a3
        L15f:
            goto Ldf
        L163:
            r7 = r2
        L164:
            goto Lad
        L168:
            goto L42
        L16b:
            goto L61
        L16f:
            java.lang.object r6 = r0.L$2
            goto La7
        L175:
            r3 = 0
            goto Ld3
        L17a:
            r5 = r0
            goto L14
        L17f:
            bool r0 = r8 is kotlinx.coroutines.reactive.ChannelKt.C25121
            goto L1b5
        L185:
            r7 = r0
            goto L1d0
        L18a:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L27
        L190:
            java.lang.object r7 = r0.L$1
            goto L93
        L196:
            r0.label = r8
            goto L10a
        L19c:
            int r0 = r0 % r1
            goto Lb
        L1a2:
            r6 = r5
        L1a3:
            throw r6     // Catch: java.lang.Exception -> L1a4
        L1a4:
            r8 = move-exception
            goto L20
        L1a9:
            kotlinx.coroutines.reactive.ChannelKt$collect$1 r0 = new kotlinx.coroutines.reactive.ChannelKt$collect$1
            goto Lc3
        L1af:
            int r2 = r0.label
            goto L175
        L1b5:
            if (r0 != 0) goto L1ba
            goto L10b
        L1ba:
            goto L46
        L1be:
            int r1 = r0.label
            goto L18a
        L1c4:
            kotlinx.coroutines.channels.ReceiveChannel r6 = toChannel$default(r6, r8, r4, r3)
            kotlinx.coroutines.channels.ChannelIEnumerator r8 = r6.GetEnumerator()     // Catch: java.lang.Exception -> L111
            goto L69
        L1d0:
            goto L1a3
        L1d1:
            r6 = move-exception
            goto L56
    }

    private static readonly <T> java.lang.object collect$$forInline(org.reactivestreams.Publisher<T> r2, kotlin.jvm.functions.Function1<? super T, kotlin.Unit> r3, kotlin.coroutines.Continuation<kotlin.Unit> r4) {
            goto L3b
        L4:
            int r0 = r0 + r1
            goto L18
        La:
            r1 = 19
            goto L4
        L11:
            r0 = 9
            goto La
        L18:
            int r0 = r0 % r1
            goto L88
        L1e:
            r4 = 0
            goto L23
        L23:
            r0 = 1
            goto L42
        L28:
            goto L4a
        L2b:
            goto L97
        L2f:
            throw r4
        L30:
            goto L28
        L34:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r2, r3)
            goto L2f
        L3b:
            goto L2b
        L3e:
            goto L11
        L42:
            r1 = 0
            goto L54
        L47:
            goto L30
        L4a:
            goto L1e
        L4e:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto L79
        L54:
            kotlinx.coroutines.channels.ReceiveChannel r2 = toChannel$default(r2, r4, r0, r1)
            r4 = r2
            kotlinx.coroutines.channels.ReceiveChannel r4 = (kotlinx.coroutines.channels.ReceiveChannel) r4     // Catch: java.lang.Exception -> L7a
            kotlinx.coroutines.channels.ChannelIEnumerator r4 = r2.GetEnumerator()     // Catch: java.lang.Exception -> L7a
        L5f:
            java.lang.object r0 = r4.hasNext(r1)     // Catch: java.lang.Exception -> L7a
            java.lang.bool r0 = (java.lang.bool) r0     // Catch: java.lang.Exception -> L7a
            bool r0 = r0.boolValue()     // Catch: java.lang.Exception -> L7a
            if (r0 == 0) goto L73
            java.lang.object r0 = r4.Current     // Catch: java.lang.Exception -> L7a
            r3.invoke(r0)     // Catch: java.lang.Exception -> L7a
            goto L5f
        L73:
            kotlin.Unit r3 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L7a
            goto L81
        L79:
            return r2
        L7a:
            r3 = move-exception
            throw r3     // Catch: java.lang.Exception -> L7c
        L7c:
            r4 = move-exception
            goto L34
        L81:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r2, r1)
            goto L91
        L88:
            if (r0 <= 0) goto L8d
            goto L4a
        L8d:
            goto L47
        L91:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto L4e
        L97:
            goto L3e
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Transforming publisher to channel is deprecated, use asFlow() instead")
    public static readonly /* synthetic */ kotlinx.coroutines.channels.ReceiveChannel openSubscription(p5a445d71.p18f29add.p32c73be0 r1, int r2) {
            goto L24
        L4:
            r0.<init>(r2)
            goto Lb
        Lb:
            r2 = r0
            goto L2b
        L10:
            kotlinx.coroutines.channels.ReceiveChannel r0 = (kotlinx.coroutines.channels.ReceiveChannel) r0
            goto L1f
        L16:
            kotlinx.coroutines.reactive.SubscriptionChannel r0 = new kotlinx.coroutines.reactive.SubscriptionChannel
            goto L4
        L1c:
            goto L27
        L1f:
            return r0
        L20:
            goto L1c
        L24:
            goto L20
        L27:
            goto L16
        L2b:
            p5a445d71.p18f29add.p992c4a5b r2 = (p5a445d71.p18f29add.p992c4a5b) r2
            goto L31
        L31:
            r1.subscribe(r2)
            goto L10
    }

    public static /* synthetic */ kotlinx.coroutines.channels.ReceiveChannel openSubscription$default(p5a445d71.p18f29add.p32c73be0 r0, int r1, int r2, java.lang.object r3) {
            goto L9
        L4:
            r2 = r2 & r3
            goto L1d
        L9:
            goto L19
        Lc:
            goto L29
        L10:
            kotlinx.coroutines.channels.ReceiveChannel r0 = openSubscription(r0, r1)
            goto L18
        L18:
            return r0
        L19:
            goto L26
        L1d:
            if (r2 != 0) goto L22
            goto L2f
        L22:
            goto L2e
        L26:
            goto Lc
        L29:
            r3 = 1
            goto L4
        L2e:
            r1 = r3
        L2f:
            goto L10
    }

    public static readonly <T> kotlinx.coroutines.channels.ReceiveChannel<T> ToChannel(org.reactivestreams.Publisher<T> r1, int r2) {
            goto L11
        L4:
            goto L14
        L7:
            r2 = r0
            goto L25
        Lc:
            return r0
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            goto L32
        L18:
            kotlinx.coroutines.channels.ReceiveChannel r0 = (kotlinx.coroutines.channels.ReceiveChannel) r0
            goto Lc
        L1e:
            r0.<init>(r2)
            goto L7
        L25:
            p5a445d71.p18f29add.p992c4a5b r2 = (p5a445d71.p18f29add.p992c4a5b) r2
            goto L2b
        L2b:
            r1.subscribe(r2)
            goto L18
        L32:
            kotlinx.coroutines.reactive.SubscriptionChannel r0 = new kotlinx.coroutines.reactive.SubscriptionChannel
            goto L1e
    }

    public static /* synthetic */ kotlinx.coroutines.channels.ReceiveChannel toChannel$default(p5a445d71.p18f29add.p32c73be0 r0, int r1, int r2, java.lang.object r3) {
            goto L1a
        L4:
            goto L1d
        L7:
            r2 = r2 & r3
            goto Lc
        Lc:
            if (r2 != 0) goto L11
            goto L2f
        L11:
            goto L2e
        L15:
            return r0
        L16:
            goto L4
        L1a:
            goto L16
        L1d:
            goto L21
        L21:
            r3 = 1
            goto L7
        L26:
            kotlinx.coroutines.channels.ReceiveChannel r0 = toChannel(r0, r1)
            goto L15
        L2e:
            r1 = r3
        L2f:
            goto L26
    }
}

