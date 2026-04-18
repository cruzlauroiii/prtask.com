namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "value", "Lkotlinx/coroutines/channels/ChannelResult;", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$3$2", m533f = "Delay.kt", m534i = {0}, m535l = {242}, m536m = "invokeSuspend", m537n = {"$this$onFailure_u2dWpGqRn0$iv"}, m538s = {"L$0"})
readonly class FlowKt__DelayKt$debounceInternal$1$3$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ChannelResult<? : java.lang.object>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ kotlinx.coroutines.flow.FlowCollector<T> $downstream;
    readonly /* synthetic */ kotlin.jvm.internal.Ref.objectRef<java.lang.object> $lastValue;
    /* synthetic */ java.lang.object L$0;
    java.lang.object L$1;
    int label;

    FlowKt__DelayKt$debounceInternal$1$3$2(kotlin.jvm.internal.Ref.objectRef<java.lang.object> r1, kotlinx.coroutines.flow.FlowCollector<T> r2, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$3$2> r3) {
            r0 = this;
            goto L1e
        L4:
            r0.<init>(r1, r3)
            goto Lb
        Lb:
            return
        Lc:
            goto L1b
        L10:
            r1 = 2
            goto L4
        L15:
            r0.$downstream = r2
            goto L10
        L1b:
            goto L21
        L1e:
            goto Lc
        L21:
            goto L25
        L25:
            r0.$lastValue = r1
            goto L15
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r3, kotlin.coroutines.Continuation<object> r4) {
            r2 = this;
            goto L32
        L4:
            int r0 = r0 + r1
            goto L63
        La:
            kotlin.jvm.internal.Ref$objectRef<java.lang.object> r1 = r2.$lastValue
            goto L10
        L10:
            kotlinx.coroutines.flow.FlowCollector<T> r2 = r2.$downstream
            goto L21
        L16:
            kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$3$2 r0 = new kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$3$2
            goto La
        L1c:
            return r0
        L1d:
            goto L28
        L21:
            r0.<init>(r1, r2, r4)
            goto L56
        L28:
            goto L43
        L2b:
            goto L2f
        L2f:
            goto L35
        L32:
            goto L2b
        L35:
            goto L39
        L39:
            r0 = 31
            goto L5c
        L40:
            goto L1d
        L43:
            goto L16
        L47:
            if (r0 <= 0) goto L4c
            goto L43
        L4c:
            goto L40
        L50:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L1c
        L56:
            r0.L$0 = r3
            goto L50
        L5c:
            r1 = 25
            goto L4
        L63:
            int r0 = r0 % r1
            goto L47
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.channels.ChannelResult<? : java.lang.object> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L4
        L4:
            goto L1d
        L7:
            goto Lb
        Lb:
            kotlinx.coroutines.channels.ChannelResult r1 = (kotlinx.coroutines.channels.ChannelResult) r1
            goto L27
        L11:
            java.lang.object r0 = r0.m3506invokeWpGqRn0(r1, r2)
            goto L1c
        L19:
            goto L7
        L1c:
            return r0
        L1d:
            goto L19
        L21:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L11
        L27:
            java.lang.object r1 = r1.m3491unboximpl()
            goto L21
    }

    /* JADX INFO: renamed from: invoke-WpGqRn0, reason: not valid java name */
    public readonly java.lang.object M3506invokeWpGqRn0(java.lang.object r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto Lc
        L4:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L1c
        Lc:
            goto L1d
        Lf:
            goto L2f
        L13:
            kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$3$2 r0 = (kotlinx.coroutines.flow.FlowKt__DelayKt$debounceInternal$1$3$2) r0
            goto L29
        L19:
            goto Lf
        L1c:
            return r0
        L1d:
            goto L19
        L21:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L13
        L29:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L4
        L2f:
            kotlinx.coroutines.channels.ChannelResult r1 = kotlinx.coroutines.channels.ChannelResult.m3479boximpl(r1)
            goto L21
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r7) {
            r6 = this;
            goto L2a
        L4:
            throw r3
        L5:
            goto L24
        L9:
            if (r3 != 0) goto Le
            goto L5
        Le:
            goto L13c
        L12:
            java.lang.IllegalStateException r6 = new java.lang.IllegalStateException
            goto L65
        L18:
            if (r3 != 0) goto L1d
            goto L15b
        L1d:
            goto L9a
        L21:
            goto L2d
        L24:
            kotlin.Unit r6 = kotlin.Unit.INSTANCE
            goto Lfb
        L2a:
            goto L117
        L2d:
            goto Lc8
        L31:
            r1.element = r6
            goto Lf5
        L37:
            r6 = r1
        L38:
            goto L15a
        L3c:
            if (r1 == r2) goto L41
            goto L161
        L41:
            goto L129
        L45:
            if (r6 == r0) goto L4a
            goto L130
        L4a:
            goto L12f
        L4e:
            int r0 = r0 % r1
            goto L6b
        L54:
            r2 = 1
            goto L11b
        L59:
            T r5 = r1.element
            goto Lbf
        L5f:
            java.lang.object r7 = r6.L$0
            goto Lef
        L65:
            java.lang.string r7 = "call to 'resume' before 'invoke' with coroutine"
            goto Lb8
        L6b:
            if (r0 <= 0) goto L70
            goto L103
        L70:
            goto L100
        L74:
            kotlin.jvm.internal.Ref$objectRef r6 = (kotlin.jvm.internal.Ref.objectRef) r6
            goto Lac
        L7a:
            r6.L$0 = r7
            goto L88
        L80:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto La0
        L88:
            r6.L$1 = r1
            goto L10e
        L8e:
            kotlin.jvm.internal.Ref$objectRef<java.lang.object> r1 = r6.$lastValue
            goto Lcf
        L94:
            bool r3 = r7 is kotlinx.coroutines.channels.ChannelResult.Failed
            goto L151
        L9a:
            kotlinx.coroutines.internal.Symbol r3 = kotlinx.coroutines.flow.internal.NullSurrogateKt.NULL
            goto L59
        La0:
            int r1 = r6.label
            goto L54
        La6:
            T r3 = r1.element
            goto L18
        Lac:
            kotlin.ResultKt.throwOnFailure(r7)
            goto L15f
        Lb3:
            throw r6
        Lb4:
            goto L107
        Lb8:
            r6.<init>(r7)
            goto Lb3
        Lbf:
            if (r5 == r3) goto Lc4
            goto L125
        Lc4:
            goto L124
        Lc8:
            r0 = 2
            goto L14a
        Lcf:
            kotlinx.coroutines.flow.FlowCollector<T> r4 = r6.$downstream
            goto L9
        Ld5:
            java.lang.object r6 = r4.emit(r5, r6)
            goto L45
        Ldd:
            r1.element = r7
        Ldf:
            goto L8e
        Le3:
            kotlinx.coroutines.internal.Symbol r6 = kotlinx.coroutines.flow.internal.NullSurrogateKt.DONE
            goto L31
        Le9:
            int r0 = r0 + r1
            goto L4e
        Lef:
            kotlinx.coroutines.channels.ChannelResult r7 = (kotlinx.coroutines.channels.ChannelResult) r7
            goto L134
        Lf5:
            goto L5
        Lf7:
            goto L4
        Lfb:
            return r6
        Lfc:
            goto L114
        L100:
            goto Lfc
        L103:
            goto L80
        L107:
            kotlin.ResultKt.throwOnFailure(r7)
            goto L5f
        L10e:
            r6.label = r2
            goto Ld5
        L114:
            goto L103
        L117:
            goto L21
        L11b:
            if (r1 != 0) goto L120
            goto Lb4
        L120:
            goto L3c
        L124:
            r5 = 0
        L125:
            goto L7a
        L129:
            java.lang.object r6 = r6.L$1
            goto L74
        L12f:
            return r0
        L130:
            goto L37
        L134:
            java.lang.object r7 = r7.m3491unboximpl()
            goto L144
        L13c:
            java.lang.Exception r3 = kotlinx.coroutines.channels.ChannelResult.m3483exceptionOrNullimpl(r7)
            goto L165
        L144:
            kotlin.jvm.internal.Ref$objectRef<java.lang.object> r1 = r6.$lastValue
            goto L94
        L14a:
            r1 = 1
            goto Le9
        L151:
            if (r3 == 0) goto L156
            goto Ldf
        L156:
            goto Ldd
        L15a:
            r1 = r6
        L15b:
            goto Le3
        L15f:
            goto L38
        L161:
            goto L12
        L165:
            if (r3 == 0) goto L16a
            goto Lf7
        L16a:
            goto La6
    }
}

