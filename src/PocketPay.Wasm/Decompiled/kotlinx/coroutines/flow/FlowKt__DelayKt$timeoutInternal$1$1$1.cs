namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [T] */
/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "value", "Lkotlinx/coroutines/channels/ChannelResult;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1$1$1", m533f = "Delay.kt", m534i = {0}, m535l = {404}, m536m = "invokeSuspend", m537n = {"$this$onSuccess_u2dWpGqRn0$iv"}, m538s = {"L$0"})
readonly class FlowKt__DelayKt$timeoutInternal$1$1$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ChannelResult<? : T>, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    readonly /* synthetic */ kotlinx.coroutines.flow.FlowCollector<T> $downStream;
    /* synthetic */ java.lang.object L$0;
    int label;

    FlowKt__DelayKt$timeoutInternal$1$1$1(kotlinx.coroutines.flow.FlowCollector<T> r1, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1$1$1> r2) {
            r0 = this;
            goto L19
        L4:
            r1 = 2
            goto Lf
        L9:
            r0.$downStream = r1
            goto L4
        Lf:
            r0.<init>(r1, r2)
            goto L20
        L16:
            goto L1c
        L19:
            goto L21
        L1c:
            goto L9
        L20:
            return
        L21:
            goto L16
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L1b
        L4:
            r0.L$0 = r2
            goto L15
        La:
            kotlinx.coroutines.flow.FlowCollector<T> r1 = r1.$downStream
            goto L2b
        L10:
            return r0
        L11:
            goto L22
        L15:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L10
        L1b:
            goto L11
        L1e:
            goto L25
        L22:
            goto L1e
        L25:
            kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1$1$1 r0 = new kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1$1$1
            goto La
        L2b:
            r0.<init>(r1, r3)
            goto L4
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, kotlin.coroutines.Continuation<java.lang.bool> r2) {
            r0 = this;
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.object r1 = r1.m3491unboximpl()
            goto L1c
        Lf:
            goto L2b
        L12:
            goto L16
        L16:
            kotlinx.coroutines.channels.ChannelResult r1 = (kotlinx.coroutines.channels.ChannelResult) r1
            goto L7
        L1c:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L22
        L22:
            java.lang.object r0 = r0.m3508invokeWpGqRn0(r1, r2)
            goto L2a
        L2a:
            return r0
        L2b:
            goto L4
    }

    /* JADX INFO: renamed from: invoke-WpGqRn0, reason: not valid java name */
    public readonly java.lang.object M3508invokeWpGqRn0(java.lang.object r1, kotlin.coroutines.Continuation<java.lang.bool> r2) {
            r0 = this;
            goto L22
        L4:
            kotlinx.coroutines.channels.ChannelResult r1 = kotlinx.coroutines.channels.ChannelResult.m3479boximpl(r1)
            goto L1a
        Lc:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L29
        L14:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto Lc
        L1a:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L31
        L22:
            goto L2a
        L25:
            goto L4
        L29:
            return r0
        L2a:
            goto L2e
        L2e:
            goto L25
        L31:
            kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1$1$1 r0 = (kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1$1$1) r0
            goto L14
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r5) {
            r4 = this;
            goto L83
        L4:
            r4.label = r2
            goto Lfc
        La:
            r4.L$0 = r5
            goto L4
        L10:
            java.lang.object r5 = r5.m3491unboximpl()
            goto Lc0
        L18:
            java.lang.string r5 = "call to 'resume' before 'invoke' with coroutine"
            goto L50
        L1e:
            r1 = 3
            goto L5f
        L25:
            if (r4 == r0) goto L2a
            goto L66
        L2a:
            goto L65
        L2e:
            java.lang.object r5 = r4.L$0
            goto Ldb
        L34:
            r4 = r5
        L35:
            goto L10d
        L39:
            kotlinx.coroutines.channels.ChannelResult.m3483exceptionOrNullimpl(r5)
            goto Lb6
        L40:
            java.lang.object r4 = r4.L$0
            goto Lc6
        L46:
            goto L35
        L47:
            goto L9b
        L4b:
            return r4
        L4c:
            goto L57
        L50:
            r4.<init>(r5)
            goto Lbb
        L57:
            java.lang.bool r4 = kotlin.coroutines.jvm.internal.Boxing.boxbool(r2)
            goto L7e
        L5f:
            int r0 = r0 + r1
            goto L112
        L65:
            return r0
        L66:
            goto L34
        L6a:
            goto Ld0
        L6d:
            goto Lf9
        L71:
            java.lang.bool r4 = kotlin.coroutines.jvm.internal.Boxing.boxbool(r4)
            goto L4b
        L79:
            r2 = 1
            goto L104
        L7e:
            return r4
        L7f:
            goto L6a
        L83:
            goto L6d
        L86:
            goto L118
        L8a:
            if (r4 != 0) goto L8f
            goto L4c
        L8f:
            goto L39
        L93:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto Laa
        L9b:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto L18
        La1:
            if (r0 <= 0) goto La6
            goto Ld0
        La6:
            goto Lcd
        Laa:
            int r1 = r4.label
            goto L79
        Lb0:
            bool r4 = r5 is kotlinx.coroutines.channels.ChannelResult.Closed
            goto L8a
        Lb6:
            r4 = 0
            goto L71
        Lbb:
            throw r4
        Lbc:
            goto Ld4
        Lc0:
            kotlinx.coroutines.flow.FlowCollector<T> r1 = r4.$downStream
            goto Lf3
        Lc6:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L46
        Lcd:
            goto L7f
        Ld0:
            goto L93
        Ld4:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L2e
        Ldb:
            kotlinx.coroutines.channels.ChannelResult r5 = (kotlinx.coroutines.channels.ChannelResult) r5
            goto L10
        Le1:
            if (r3 == 0) goto Le6
            goto L10e
        Le6:
            goto La
        Lea:
            if (r1 == r2) goto Lef
            goto L47
        Lef:
            goto L40
        Lf3:
            bool r3 = r5 is kotlinx.coroutines.channels.ChannelResult.Failed
            goto Le1
        Lf9:
            goto L86
        Lfc:
            java.lang.object r4 = r1.emit(r5, r4)
            goto L25
        L104:
            if (r1 != 0) goto L109
            goto Lbc
        L109:
            goto Lea
        L10d:
            r5 = r4
        L10e:
            goto Lb0
        L112:
            int r0 = r0 % r1
            goto La1
        L118:
            r0 = 5
            goto L1e
    }
}

