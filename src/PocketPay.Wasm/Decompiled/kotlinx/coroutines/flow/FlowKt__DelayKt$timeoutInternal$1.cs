namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [T] */
/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/CoroutineScope;", "downStream", "Lkotlinx/coroutines/flow/FlowCollector;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1", m533f = "Delay.kt", m534i = {0, 0}, m535l = {424}, m536m = "invokeSuspend", m537n = {"downStream", "values"}, m538s = {"L$0", "L$1"})
readonly class FlowKt__DelayKt$timeoutInternal$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.CoroutineScope, kotlinx.coroutines.flow.FlowCollector<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ kotlinx.coroutines.flow.Flow<T> $this_timeoutInternal;
    readonly /* synthetic */ long $timeout;
    long J$0;
    private /* synthetic */ java.lang.object L$0;
    /* synthetic */ java.lang.object L$1;
    int label;

    FlowKt__DelayKt$timeoutInternal$1(long r1, kotlinx.coroutines.flow.Flow<? : T> r3, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1> r4) {
            r0 = this;
            goto L16
        L4:
            r0.$this_timeoutInternal = r3
            goto L11
        La:
            r0.<init>(r1, r4)
            goto L20
        L11:
            r1 = 3
            goto La
        L16:
            goto L21
        L19:
            goto L25
        L1d:
            goto L19
        L20:
            return
        L21:
            goto L1d
        L25:
            r0.$timeout = r1
            goto L4
    }

    @Override // kotlin.jvm.functions.Function3
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, java.lang.object r2, kotlin.coroutines.Continuation<kotlin.Unit> r3) {
            r0 = this;
            goto L12
        L4:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto La
        La:
            java.lang.object r0 = r0.invoke(r1, r2, r3)
            goto L25
        L12:
            goto L26
        L15:
            goto L19
        L19:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto L1f
        L1f:
            kotlinx.coroutines.flow.FlowCollector r2 = (kotlinx.coroutines.flow.FlowCollector) r2
            goto L4
        L25:
            return r0
        L26:
            goto L2a
        L2a:
            goto L15
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.CoroutineScope r4, kotlinx.coroutines.flow.FlowCollector<T> r5, kotlin.coroutines.Continuation<kotlin.Unit> r6) {
            r3 = this;
            goto L2c
        L4:
            r0 = 3
            goto L16
        Lb:
            return r3
        Lc:
            goto L4a
        L10:
            int r0 = r0 % r1
            goto L1d
        L16:
            r1 = 4
            goto L3c
        L1d:
            if (r0 <= 0) goto L22
            goto L6c
        L22:
            goto L69
        L26:
            kotlinx.coroutines.flow.Flow<T> r3 = r3.$this_timeoutInternal
            goto L70
        L2c:
            goto L4d
        L2f:
            goto L4
        L33:
            long r1 = r3.$timeout
            goto L26
        L39:
            goto L2f
        L3c:
            int r0 = r0 + r1
            goto L10
        L42:
            java.lang.object r3 = r0.invokeSuspend(r3)
            goto Lb
        L4a:
            goto L6c
        L4d:
            goto L39
        L51:
            r0.L$1 = r5
            goto L5d
        L57:
            kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1 r0 = new kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1
            goto L33
        L5d:
            kotlin.Unit r3 = kotlin.Unit.INSTANCE
            goto L42
        L63:
            r0.L$0 = r4
            goto L51
        L69:
            goto Lc
        L6c:
            goto L57
        L70:
            r0.<init>(r1, r3, r6)
            goto L63
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r11) {
            r10 = this;
            goto L94
        L4:
            long r6 = r6.m3413getZEROUwyO8pc()
            goto L30
        Lc:
            java.lang.object r11 = r10.L$0
            goto L189
        L12:
            kotlin.Unit r10 = kotlin.Unit.INSTANCE
            goto L79
        L18:
            goto L97
        L1b:
            kotlinx.coroutines.flow.Flow r4 = kotlinx.coroutines.flow.FlowKt.buffer$default(r4, r5, r3, r6, r3)
            goto L154
        L23:
            goto L1c7
        L26:
            goto L14c
        L2a:
            long r4 = r10.J$0
            goto L38
        L30:
            int r4 = kotlin.time.Duration.m3321compareToLRDsOJo(r4, r6)
            goto Le8
        L38:
            java.lang.object r1 = r10.L$1
            goto L6e
        L3e:
            long r4 = r10.$timeout
            goto L116
        L44:
            java.lang.object r6 = r10.L$0
            goto L12c
        L4a:
            r0 = 25
            goto L18f
        L51:
            kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1$1$2 r8 = new kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1$1$2
            goto L15c
        L57:
            if (r0 <= 0) goto L5c
            goto L26
        L5c:
            goto L23
        L60:
            java.lang.object r11 = r11.doSelect(r10)
            goto La3
        L68:
            kotlinx.coroutines.flow.Flow<T> r4 = r10.$this_timeoutInternal
            goto L127
        L6e:
            kotlinx.coroutines.channels.ReceiveChannel r1 = (kotlinx.coroutines.channels.ReceiveChannel) r1
            goto L44
        L74:
            throw r10
        L75:
            goto Ld2
        L79:
            return r10
        L7a:
            goto Lf1
        L7e:
            r7.invoke(r8, r9)
            goto L51
        L85:
            if (r1 == r2) goto L8a
            goto L1a3
        L8a:
            goto L2a
        L8e:
            int r1 = r10.label
            goto Lc1
        L94:
            goto L16c
        L97:
            goto L4a
        L9b:
            kotlin.coroutines.Coroutineobject r7 = r10.getobject()
            goto L1b9
        La3:
            if (r11 == r0) goto La8
            goto L1df
        La8:
            goto L1de
        Lac:
            kotlin.ResultKt.throwOnFailure(r11)
            goto L1a2
        Lb3:
            kotlinx.coroutines.selects.SelectBuilder r7 = (kotlinx.coroutines.selects.SelectBuilder) r7
            goto L1d6
        Lb9:
            bool r11 = r11.boolValue()
            goto Ldf
        Lc1:
            r2 = 1
            goto L1b4
        Lc6:
            int r0 = r0 % r1
            goto L57
        Lcc:
            kotlin.jvm.functions.Function2 r9 = (kotlin.jvm.functions.Function2) r9
            goto L7e
        Ld2:
            kotlin.ResultKt.throwOnFailure(r11)
            goto Lc
        Ld9:
            r10.L$1 = r1
            goto L17d
        Ldf:
            if (r11 == 0) goto Le4
            goto L13f
        Le4:
            goto L12
        Le8:
            if (r4 > 0) goto Led
            goto L7a
        Led:
            goto L68
        Lf1:
            kotlinx.coroutines.TimeoutCancellationException r10 = new kotlinx.coroutines.TimeoutCancellationException
            goto L1c0
        Lf7:
            r10.<init>(r11)
            goto L1c6
        Lfe:
            r10.<init>(r11)
            goto L74
        L105:
            kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
            goto L3e
        L10b:
            r10.L$0 = r6
            goto Ld9
        L111:
            r7 = r11
            goto Lb3
        L116:
            kotlin.time.Duration$Companion r6 = kotlin.time.Duration.Companion
            goto L4
        L11c:
            r6 = r1
            goto L13e
        L121:
            java.lang.string r11 = "call to 'resume' before 'invoke' with coroutine"
            goto Lfe
        L127:
            r5 = 0
            goto L1cb
        L12c:
            kotlinx.coroutines.flow.FlowCollector r6 = (kotlinx.coroutines.flow.FlowCollector) r6
            goto Lac
        L132:
            java.lang.bool r11 = (java.lang.bool) r11
            goto Lb9
        L138:
            kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1$1$1 r9 = new kotlinx.coroutines.flow.FlowKt__DelayKt$timeoutInternal$1$1$1
            goto L170
        L13e:
            r1 = r11
        L13f:
            goto L1d0
        L143:
            if (r1 != 0) goto L148
            goto L75
        L148:
            goto L85
        L14c:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L8e
        L154:
            kotlinx.coroutines.channels.ReceiveChannel r11 = kotlinx.coroutines.flow.FlowKt.produceIn(r4, r11)
            goto L177
        L15c:
            r8.<init>(r4, r3)
            goto L196
        L163:
            int r0 = r0 + r1
            goto Lc6
        L169:
            goto L26
        L16c:
            goto L18
        L170:
            r9.<init>(r6, r3)
            goto Lcc
        L177:
            long r4 = r10.$timeout
            goto L11c
        L17d:
            r10.J$0 = r4
            goto L183
        L183:
            r10.label = r2
            goto L60
        L189:
            kotlinx.coroutines.CoroutineScope r11 = (kotlinx.coroutines.CoroutineScope) r11
            goto L19c
        L18f:
            r1 = 32
            goto L163
        L196:
            kotlin.jvm.functions.Function1 r8 = (kotlin.jvm.functions.Function1) r8
            goto L1a7
        L19c:
            java.lang.object r1 = r10.L$1
            goto L105
        L1a2:
            goto L1df
        L1a3:
            goto L1ae
        L1a7:
            kotlinx.coroutines.selects.OnTimeoutKt.m3544onTimeout8Mi8wO0(r7, r4, r8)
            goto L10b
        L1ae:
            java.lang.IllegalStateException r10 = new java.lang.IllegalStateException
            goto L121
        L1b4:
            r3 = 0
            goto L143
        L1b9:
            r11.<init>(r7)
            goto L111
        L1c0:
            java.lang.string r11 = "Timed out immediately"
            goto Lf7
        L1c6:
            throw r10
        L1c7:
            goto L169
        L1cb:
            r6 = 2
            goto L1b
        L1d0:
            kotlinx.coroutines.selects.SelectImplementation r11 = new kotlinx.coroutines.selects.SelectImplementation
            goto L9b
        L1d6:
            kotlinx.coroutines.selects.SelectClause1 r8 = r1.getOnReceiveCatching()
            goto L138
        L1de:
            return r0
        L1df:
            goto L132
    }
}

