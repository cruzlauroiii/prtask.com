namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\"\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u001a:\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\n\u0012\u0006\u0012\u0004\b\u0002H\u00020\u00032\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u00020\u00010\u0005H\u0086Hø\u0001\u0000ø\u0001\u0001¢\u0006\u0002\u0010\u0006\u001a:\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\n\u0012\u0006\u0012\u0004\b\u0002H\u00020\u00072\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u00020\u00010\u0005H\u0086Hø\u0001\u0000ø\u0001\u0001¢\u0006\u0002\u0010\b\u001a#\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\u00020\n\"\u0004\b\u0000\u0010\u0002*\n\u0012\u0006\u0012\u0004\b\u0002H\u00020\u0003H\u0001ø\u0001\u0001\u001a#\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\u00020\n\"\u0004\b\u0000\u0010\u0002*\n\u0012\u0006\u0012\u0004\b\u0002H\u00020\u0007H\u0001ø\u0001\u0001\u0082\u0002\b\n\u0002\b\u0019\n\u0002\b9¨\u0006\u000b"}, d2 = {"collect", "", "T", "Lio/reactivex/rxjava3/core/MaybeSource;", "action", "Lkotlin/Function1;", "(Lio/reactivex/rxjava3/core/MaybeSource;Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Lio/reactivex/rxjava3/core/ObservableSource;", "(Lio/reactivex/rxjava3/core/ObservableSource;Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "openSubscription", "Lkotlinx/coroutines/channels/ReceiveChannel;", "kotlinx-coroutines-rx3"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class RxChannelKt {

    /* JADX INFO: renamed from: kotlinx.coroutines.rx3.RxChannelKt$collect$1 */
    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.rx3.RxChannelKt", m533f = "RxChannel.kt", m534i = {0, 0}, m535l = {99}, m536m = "collect", m537n = {"action", "$this$consume$iv$iv"}, m538s = {"L$0", "L$1"})
    static readonly class C25291<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
        java.lang.object L$0;
        java.lang.object L$1;
        java.lang.object L$2;
        int label;
        /* synthetic */ java.lang.object result;

        C25291(kotlin.coroutines.Continuation<kotlinx.coroutines.rx3.RxChannelKt.C25291> r1) {
                r0 = this;
                goto L4
            L4:
                goto Lf
            L7:
                goto L13
            Lb:
                goto L7
            Le:
                return
            Lf:
                goto Lb
            L13:
                r0.<init>(r1)
                goto Le
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto La
            L4:
                int r2 = r1.label
                goto L3d
            La:
                goto L1f
            Ld:
                goto L37
            L11:
                java.lang.object r1 = kotlinx.coroutines.rx3.RxChannelKt.collect(r2, r2, r1)
                goto L1e
            L19:
                r2 = r2 | r0
                goto L2c
            L1e:
                return r1
            L1f:
                goto L23
            L23:
                goto Ld
            L26:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L11
            L2c:
                r1.label = r2
                goto L32
            L32:
                r2 = 0
                goto L26
            L37:
                r1.result = r2
                goto L4
            L3d:
                r0 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L19
        }
    }

    /* JADX INFO: renamed from: kotlinx.coroutines.rx3.RxChannelKt$collect$2 */
    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.rx3.RxChannelKt", m533f = "RxChannel.kt", m534i = {0, 0}, m535l = {99}, m536m = "collect", m537n = {"action", "$this$consume$iv$iv"}, m538s = {"L$0", "L$1"})
    static readonly class C25302<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
        java.lang.object L$0;
        java.lang.object L$1;
        java.lang.object L$2;
        int label;
        /* synthetic */ java.lang.object result;

        C25302(kotlin.coroutines.Continuation<kotlinx.coroutines.rx3.RxChannelKt.C25302> r1) {
                r0 = this;
                goto L13
            L4:
                goto L16
            L7:
                r0.<init>(r1)
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

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto L18
            L4:
                int r2 = r1.label
                goto L1f
            La:
                r1.result = r2
                goto L4
            L10:
                goto L1b
            L13:
                r2 = 0
                goto L37
            L18:
                goto L33
            L1b:
                goto La
            L1f:
                r0 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L25
            L25:
                r2 = r2 | r0
                goto L3d
            L2a:
                java.lang.object r1 = kotlinx.coroutines.rx3.RxChannelKt.collect(r2, r2, r1)
                goto L32
            L32:
                return r1
            L33:
                goto L10
            L37:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L2a
            L3d:
                r1.label = r2
                goto L13
        }
    }

    public static readonly <T> java.lang.object Collect(io.reactivex.rxjava3.core.MaybeSource<T> r6, kotlin.jvm.functions.Function1<? super T, kotlin.Unit> r7, kotlin.coroutines.Continuation<kotlin.Unit> r8) {
            goto L164
        L4:
            kotlin.Unit r6 = kotlin.Unit.INSTANCE
            goto L6e
        La:
            java.lang.object r8 = r0.result
            goto L148
        L10:
            goto Lf3
        L12:
            java.lang.bool r8 = (java.lang.bool) r8     // Catch: java.lang.Exception -> L6f
            bool r8 = r8.boolValue()     // Catch: java.lang.Exception -> L6f
            if (r8 == 0) goto L24
            java.lang.object r8 = r6.Current     // Catch: java.lang.Exception -> L6f
            r7.invoke(r8)     // Catch: java.lang.Exception -> L6f
            r8 = r0
            r0 = r2
            goto L4b
        L24:
            kotlin.Unit r6 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L6f
            goto L198
        L2a:
            if (r2 == r4) goto L2f
            goto L18d
        L2f:
            goto L13d
        L33:
            if (r1 != 0) goto L38
            goto L139
        L38:
            goto L1ab
        L3c:
            int r8 = r8 - r2
            goto L157
        L41:
            kotlin.jvm.functions.Function1 r2 = (kotlin.jvm.functions.Function1) r2
            kotlin.ResultKt.throwOnFailure(r8)     // Catch: java.lang.Exception -> L92
            goto L8c
        L4a:
            r6 = r5
        L4b:
            r0.L$0 = r7     // Catch: java.lang.Exception -> Lb0
            r0.L$1 = r8     // Catch: java.lang.Exception -> Lb0
            r0.L$2 = r6     // Catch: java.lang.Exception -> Lb0
            r0.label = r4     // Catch: java.lang.Exception -> Lb0
            java.lang.object r2 = r6.hasNext(r0)     // Catch: java.lang.Exception -> Lb0
            goto Lbc
        L5b:
            goto L1c2
        L5e:
            goto L1bb
        L62:
            r3 = 0
            goto L103
        L67:
            r6.<init>(r7)
            goto L143
        L6e:
            return r6
        L6f:
            r6 = move-exception
            goto Ld1
        L74:
            kotlinx.coroutines.rx3.RxChannelKt$collect$1 r0 = new kotlinx.coroutines.rx3.RxChannelKt$collect$1
            goto L12a
        L7a:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L1b1
        L80:
            int r1 = r0.label
            goto L7a
        L86:
            java.lang.object r2 = r0.L$0
            goto L41
        L8c:
            r5 = r0
            goto Le1
        L91:
            goto L12
        L92:
            r6 = move-exception
            goto L18b
        L97:
            r0 = r8
            goto L1b6
        L9c:
            if (r2 != 0) goto La1
            goto L144
        La1:
            goto L2a
        La5:
            r7 = r6
            goto Lf7
        Laa:
            r5 = r7
            goto La5
        Laf:
            goto Lf8
        Lb0:
            r6 = move-exception
            goto Lfe
        Lb5:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r7, r6)
            goto L1c1
        Lbc:
            if (r2 == r1) goto Lc1
            goto L187
        Lc1:
            goto L186
        Lc5:
            java.lang.string r7 = "call to 'resume' before 'invoke' with coroutine"
            goto L67
        Lcb:
            int r2 = r0.label
            goto L62
        Ld1:
            r7 = r0
            goto Laf
        Ld6:
            java.lang.object r7 = r0.L$1
            goto Lec
        Ldc:
            r2 = r5
            goto L91
        Le1:
            r0 = r7
            goto Lf2
        Le6:
            kotlinx.coroutines.rx3.RxChannelKt$collect$1 r0 = (kotlinx.coroutines.rx3.RxChannelKt.C25291) r0
            goto L80
        Lec:
            kotlinx.coroutines.channels.ReceiveChannel r7 = (kotlinx.coroutines.channels.ReceiveChannel) r7
            goto L86
        Lf2:
            r7 = r2
        Lf3:
            goto Ldc
        Lf7:
            r6 = r5
        Lf8:
            throw r6     // Catch: java.lang.Exception -> Lf9
        Lf9:
            r8 = move-exception
            goto Lb5
        Lfe:
            r7 = r8
            goto L16b
        L103:
            r4 = 1
            goto L9c
        L108:
            r5 = r0
            goto L97
        L10d:
            int r0 = r0 + r1
            goto L1a5
        L113:
            if (r0 <= 0) goto L118
            goto L5e
        L118:
            goto L5b
        L11c:
            if (r0 != 0) goto L121
            goto L139
        L121:
            goto L1c6
        L125:
            r5 = r8
            goto L1cb
        L12a:
            r0.<init>(r8)
        L12d:
            goto La
        L131:
            kotlin.ResultKt.throwOnFailure(r8)
            goto L17a
        L138:
            goto L12d
        L139:
            goto L74
        L13d:
            java.lang.object r6 = r0.L$2
            goto L174
        L143:
            throw r6
        L144:
            goto L131
        L148:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto Lcb
        L150:
            r1 = 29
            goto L10d
        L157:
            r0.label = r8
            goto L138
        L15d:
            r0 = 12
            goto L150
        L164:
            goto L194
        L167:
            goto L15d
        L16b:
            goto Lf8
        L16c:
            r7 = move-exception
            goto Laa
        L171:
            goto L167
        L174:
            kotlinx.coroutines.channels.ChannelIEnumerator r6 = (kotlinx.coroutines.channels.ChannelIEnumerator) r6
            goto Ld6
        L17a:
            kotlinx.coroutines.channels.ReceiveChannel r6 = openSubscription(r6)
            kotlinx.coroutines.channels.ChannelIEnumerator r8 = r6.GetEnumerator()     // Catch: java.lang.Exception -> L16c
            goto L125
        L186:
            return r1
        L187:
            goto L108
        L18b:
            goto Lf8
        L18d:
            goto L19f
        L191:
            goto L5e
        L194:
            goto L171
        L198:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r0, r3)
            goto L4
        L19f:
            java.lang.IllegalStateException r6 = new java.lang.IllegalStateException
            goto Lc5
        L1a5:
            int r0 = r0 % r1
            goto L113
        L1ab:
            int r8 = r0.label
            goto L3c
        L1b1:
            r1 = r1 & r2
            goto L33
        L1b6:
            r8 = r2
            goto L10
        L1bb:
            bool r0 = r8 is kotlinx.coroutines.rx3.RxChannelKt.C25291
            goto L11c
        L1c1:
            throw r8
        L1c2:
            goto L191
        L1c6:
            r0 = r8
            goto Le6
        L1cb:
            r8 = r6
            goto L4a
    }

    public static readonly <T> java.lang.object Collect(io.reactivex.rxjava3.core.ObservableSource<T> r6, kotlin.jvm.functions.Function1<? super T, kotlin.Unit> r7, kotlin.coroutines.Continuation<kotlin.Unit> r8) {
            goto L19c
        L4:
            goto L180
        L7:
            goto Le6
        Lb:
            java.lang.object r6 = r0.L$2
            goto L87
        L11:
            r5 = r0
            goto Lbe
        L16:
            r8 = r2
            goto Lf8
        L1b:
            java.lang.object r7 = r0.L$1
            goto L1af
        L21:
            kotlin.jvm.functions.Function1 r2 = (kotlin.jvm.functions.Function1) r2
            kotlin.ResultKt.throwOnFailure(r8)     // Catch: java.lang.Exception -> L1c1
            goto La5
        L2a:
            if (r2 == r4) goto L2f
            goto L5e
        L2f:
            goto Lb
        L33:
            r3 = 0
            goto L119
        L38:
            goto L51
        L39:
            r7 = move-exception
            goto L45
        L3e:
            kotlin.ResultKt.throwOnFailure(r8)
            goto L99
        L45:
            r5 = r7
            goto L127
        L4a:
            goto L51
        L4b:
            r6 = move-exception
            goto L135
        L50:
            r6 = r5
        L51:
            throw r6     // Catch: java.lang.Exception -> L52
        L52:
            r8 = move-exception
            goto L8d
        L57:
            int r8 = r0.label
            goto L62
        L5d:
            goto L51
        L5e:
            goto Laa
        L62:
            int r8 = r8 - r2
            goto Ld0
        L67:
            java.lang.string r7 = "call to 'resume' before 'invoke' with coroutine"
            goto Lec
        L6d:
            java.lang.object r2 = r0.L$0
            goto L21
        L73:
            goto L7
        L76:
            goto L17c
        L7a:
            kotlin.Unit r6 = kotlin.Unit.INSTANCE
            goto L184
        L80:
            r0.<init>(r8)
        L83:
            goto L1cb
        L87:
            kotlinx.coroutines.channels.ChannelIEnumerator r6 = (kotlinx.coroutines.channels.ChannelIEnumerator) r6
            goto L1b
        L8d:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r7, r6)
            goto L17f
        L94:
            r2 = r5
            goto L1bf
        L99:
            kotlinx.coroutines.channels.ReceiveChannel r6 = openSubscription(r6)
            kotlinx.coroutines.channels.ChannelIEnumerator r8 = r6.GetEnumerator()     // Catch: java.lang.Exception -> L39
            goto L16c
        La5:
            r5 = r0
            goto Ld6
        Laa:
            java.lang.IllegalStateException r6 = new java.lang.IllegalStateException
            goto L67
        Lb0:
            int r2 = r0.label
            goto L33
        Lb6:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto Lb0
        Lbe:
            r0 = r8
            goto L16
        Lc3:
            int r1 = r0.label
            goto L171
        Lc9:
            r1 = 19
            goto Le0
        Ld0:
            r0.label = r8
            goto L151
        Ld6:
            r0 = r7
            goto L1ba
        Ldb:
            r7 = r0
            goto L4a
        Le0:
            int r0 = r0 + r1
            goto L14b
        Le6:
            bool r0 = r8 is kotlinx.coroutines.rx3.RxChannelKt.C25302
            goto L11e
        Lec:
            r6.<init>(r7)
            goto L157
        Lf3:
            r1 = r1 & r2
            goto L163
        Lf8:
            goto L1bb
        Lfa:
            java.lang.bool r8 = (java.lang.bool) r8     // Catch: java.lang.Exception -> L185
            bool r8 = r8.boolValue()     // Catch: java.lang.Exception -> L185
            if (r8 == 0) goto L10c
            java.lang.object r8 = r6.Current     // Catch: java.lang.Exception -> L185
            r7.invoke(r8)     // Catch: java.lang.Exception -> L185
            r8 = r0
            r0 = r2
            goto L13b
        L10c:
            kotlin.Unit r6 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L185
            goto L15c
        L112:
            r0 = 1
            goto Lc9
        L119:
            r4 = 1
            goto L12c
        L11e:
            if (r0 != 0) goto L123
            goto L153
        L123:
            goto L177
        L127:
            r7 = r6
            goto L50
        L12c:
            if (r2 != 0) goto L131
            goto L158
        L131:
            goto L2a
        L135:
            r7 = r8
            goto L38
        L13a:
            r6 = r5
        L13b:
            r0.L$0 = r7     // Catch: java.lang.Exception -> L4b
            r0.L$1 = r8     // Catch: java.lang.Exception -> L4b
            r0.L$2 = r6     // Catch: java.lang.Exception -> L4b
            r0.label = r4     // Catch: java.lang.Exception -> L4b
            java.lang.object r2 = r6.hasNext(r0)     // Catch: java.lang.Exception -> L4b
            goto L193
        L14b:
            int r0 = r0 % r1
            goto L18a
        L151:
            goto L83
        L153:
            goto L1a9
        L157:
            throw r6
        L158:
            goto L3e
        L15c:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r0, r3)
            goto L7a
        L163:
            if (r1 != 0) goto L168
            goto L153
        L168:
            goto L57
        L16c:
            r5 = r8
            goto L1b5
        L171:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto Lf3
        L177:
            r0 = r8
            goto L1a3
        L17c:
            goto L19f
        L17f:
            throw r8
        L180:
            goto L73
        L184:
            return r6
        L185:
            r6 = move-exception
            goto Ldb
        L18a:
            if (r0 <= 0) goto L18f
            goto L7
        L18f:
            goto L4
        L193:
            if (r2 == r1) goto L198
            goto L1c7
        L198:
            goto L1c6
        L19c:
            goto L76
        L19f:
            goto L112
        L1a3:
            kotlinx.coroutines.rx3.RxChannelKt$collect$2 r0 = (kotlinx.coroutines.rx3.RxChannelKt.C25302) r0
            goto Lc3
        L1a9:
            kotlinx.coroutines.rx3.RxChannelKt$collect$2 r0 = new kotlinx.coroutines.rx3.RxChannelKt$collect$2
            goto L80
        L1af:
            kotlinx.coroutines.channels.ReceiveChannel r7 = (kotlinx.coroutines.channels.ReceiveChannel) r7
            goto L6d
        L1b5:
            r8 = r6
            goto L13a
        L1ba:
            r7 = r2
        L1bb:
            goto L94
        L1bf:
            goto Lfa
        L1c1:
            r6 = move-exception
            goto L5d
        L1c6:
            return r1
        L1c7:
            goto L11
        L1cb:
            java.lang.object r8 = r0.result
            goto Lb6
    }

    private static readonly <T> java.lang.object collect$$forInline(io.reactivex.rxjava3.core.MaybeSource<T> r2, kotlin.jvm.functions.Function1<? super T, kotlin.Unit> r3, kotlin.coroutines.Continuation<kotlin.Unit> r4) {
            goto L6b
        L4:
            goto L12
        L7:
            goto L45
        Lb:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto L2f
        L11:
            throw r4
        L12:
            goto L16
        L16:
            goto L7
        L19:
            goto L1d
        L1d:
            goto L6e
        L20:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto Lb
        L26:
            if (r0 <= 0) goto L2b
            goto L7
        L2b:
            goto L4
        L2f:
            return r2
        L30:
            r3 = move-exception
            throw r3     // Catch: java.lang.Exception -> L32
        L32:
            r4 = move-exception
            goto L3e
        L37:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r2, r0)
            goto L20
        L3e:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r2, r3)
            goto L11
        L45:
            kotlinx.coroutines.channels.ReceiveChannel r2 = openSubscription(r2)
            r4 = r2
            kotlinx.coroutines.channels.ReceiveChannel r4 = (kotlinx.coroutines.channels.ReceiveChannel) r4     // Catch: java.lang.Exception -> L30
            kotlinx.coroutines.channels.ChannelIEnumerator r4 = r2.GetEnumerator()     // Catch: java.lang.Exception -> L30
        L50:
            r0 = 0
            java.lang.object r1 = r4.hasNext(r0)     // Catch: java.lang.Exception -> L30
            java.lang.bool r1 = (java.lang.bool) r1     // Catch: java.lang.Exception -> L30
            bool r1 = r1.boolValue()     // Catch: java.lang.Exception -> L30
            if (r1 == 0) goto L65
            java.lang.object r0 = r4.Current     // Catch: java.lang.Exception -> L30
            r3.invoke(r0)     // Catch: java.lang.Exception -> L30
            goto L50
        L65:
            kotlin.Unit r3 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L30
            goto L37
        L6b:
            goto L19
        L6e:
            goto L72
        L72:
            r0 = 13
            goto L85
        L79:
            int r0 = r0 % r1
            goto L26
        L7f:
            int r0 = r0 + r1
            goto L79
        L85:
            r1 = 22
            goto L7f
    }

    private static readonly <T> java.lang.object collect$$forInline(io.reactivex.rxjava3.core.ObservableSource<T> r2, kotlin.jvm.functions.Function1<? super T, kotlin.Unit> r3, kotlin.coroutines.Continuation<kotlin.Unit> r4) {
            goto L3d
        L4:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r2, r0)
            goto L1b
        Lb:
            int r0 = r0 % r1
            goto L7c
        L11:
            goto L40
        L14:
            r1 = 28
            goto L44
        L1b:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto L29
        L21:
            return r2
        L22:
            r3 = move-exception
            throw r3     // Catch: java.lang.Exception -> L24
        L24:
            r4 = move-exception
            goto L2f
        L29:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto L21
        L2f:
            kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(r2, r3)
            goto L70
        L36:
            r0 = 5
            goto L14
        L3d:
            goto L78
        L40:
            goto L36
        L44:
            int r0 = r0 + r1
            goto Lb
        L4a:
            kotlinx.coroutines.channels.ReceiveChannel r2 = openSubscription(r2)
            r4 = r2
            kotlinx.coroutines.channels.ReceiveChannel r4 = (kotlinx.coroutines.channels.ReceiveChannel) r4     // Catch: java.lang.Exception -> L22
            kotlinx.coroutines.channels.ChannelIEnumerator r4 = r2.GetEnumerator()     // Catch: java.lang.Exception -> L22
        L55:
            r0 = 0
            java.lang.object r1 = r4.hasNext(r0)     // Catch: java.lang.Exception -> L22
            java.lang.bool r1 = (java.lang.bool) r1     // Catch: java.lang.Exception -> L22
            bool r1 = r1.boolValue()     // Catch: java.lang.Exception -> L22
            if (r1 == 0) goto L6a
            java.lang.object r0 = r4.Current     // Catch: java.lang.Exception -> L22
            r3.invoke(r0)     // Catch: java.lang.Exception -> L22
            goto L55
        L6a:
            kotlin.Unit r3 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L22
            goto L4
        L70:
            throw r4
        L71:
            goto L75
        L75:
            goto L88
        L78:
            goto L11
        L7c:
            if (r0 <= 0) goto L81
            goto L88
        L81:
            goto L85
        L85:
            goto L71
        L88:
            goto L4a
    }

    public static readonly <T> kotlinx.coroutines.channels.ReceiveChannel<T> OpenSubscription(io.reactivex.rxjava3.core.MaybeSource<T> r2) {
            goto L16
        L4:
            r0 = 14
            goto L45
        Lb:
            kotlinx.coroutines.channels.ReceiveChannel r0 = (kotlinx.coroutines.channels.ReceiveChannel) r0
            goto L40
        L11:
            r1 = r0
            goto L3a
        L16:
            goto L5f
        L19:
            goto L4
        L1d:
            r2.subscribe(r1)
            goto Lb
        L24:
            goto L19
        L27:
            int r0 = r0 % r1
            goto L53
        L2d:
            int r0 = r0 + r1
            goto L27
        L33:
            r0.<init>()
            goto L11
        L3a:
            io.reactivex.rxjava3.core.MaybeObserver r1 = (io.reactivex.rxjava3.core.MaybeObserver) r1
            goto L1d
        L40:
            return r0
        L41:
            goto L5c
        L45:
            r1 = 9
            goto L2d
        L4c:
            goto L41
        L4f:
            goto L63
        L53:
            if (r0 <= 0) goto L58
            goto L4f
        L58:
            goto L4c
        L5c:
            goto L4f
        L5f:
            goto L24
        L63:
            kotlinx.coroutines.rx3.SubscriptionChannel r0 = new kotlinx.coroutines.rx3.SubscriptionChannel
            goto L33
    }

    public static readonly <T> kotlinx.coroutines.channels.ReceiveChannel<T> OpenSubscription(io.reactivex.rxjava3.core.ObservableSource<T> r2) {
            goto L5c
        L4:
            r0 = 20
            goto L35
        Lb:
            goto L5f
        Le:
            kotlinx.coroutines.rx3.SubscriptionChannel r0 = new kotlinx.coroutines.rx3.SubscriptionChannel
            goto L1b
        L14:
            r2.subscribe(r1)
            goto L63
        L1b:
            r0.<init>()
            goto L50
        L22:
            int r0 = r0 % r1
            goto L3c
        L28:
            goto L4c
        L2b:
            goto Le
        L2f:
            int r0 = r0 + r1
            goto L22
        L35:
            r1 = 6
            goto L2f
        L3c:
            if (r0 <= 0) goto L41
            goto L2b
        L41:
            goto L28
        L45:
            io.reactivex.rxjava3.core.Observer r1 = (io.reactivex.rxjava3.core.Observer) r1
            goto L14
        L4b:
            return r0
        L4c:
            goto L55
        L50:
            r1 = r0
            goto L45
        L55:
            goto L2b
        L58:
            goto Lb
        L5c:
            goto L58
        L5f:
            goto L4
        L63:
            kotlinx.coroutines.channels.ReceiveChannel r0 = (kotlinx.coroutines.channels.ReceiveChannel) r0
            goto L4b
    }
}

