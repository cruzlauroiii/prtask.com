namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes3.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventory.repository.InventoryRepositoryImpl$startCommodityGroupsUpdate$1", m533f = "InventoryRepositoryImpl.kt", m534i = {0}, m535l = {218}, m536m = "invokeSuspend", m537n = {"$this$launch"}, m538s = {"L$0"})
readonly class p6810d8b2$p21db659d$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    private /* synthetic */ java.lang.object L$0;
    int fd304ba20;
    int ff0a9e8c8;
    readonly /* synthetic */ p7a1eabc3.pb3f20355.p6810d8b2 this$0;

    p6810d8b2$p21db659d$1(p7a1eabc3.pb3f20355.p6810d8b2 r1, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p6810d8b2$p21db659d$1> r2) {
            r0 = this;
            goto L11
        L4:
            return
        L5:
            goto Le
        L9:
            r1 = 2
            goto L1e
        Le:
            goto L14
        L11:
            goto L5
        L14:
            goto L18
        L18:
            r0.this$0 = r1
            goto L9
        L1e:
            r0.<init>(r1, r2)
            goto L4
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L13
        L4:
            p7a1eabc3.pb3f20355.p6810d8b2$p21db659d$1 r0 = new p7a1eabc3.pb3f20355.p6810d8b2$p21db659d$1
            goto L2c
        La:
            r0.L$0 = r2
            goto L21
        L10:
            goto L16
        L13:
            goto L28
        L16:
            goto L4
        L1a:
            r0.<init>(r1, r3)
            goto La
        L21:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L27
        L27:
            return r0
        L28:
            goto L10
        L2c:
            p7a1eabc3.pb3f20355.p6810d8b2 r1 = r1.this$0
            goto L1a
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto L21
        L11:
            return r0
        L12:
            goto L1e
        L16:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto L11
        L1e:
            goto L7
        L21:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L16
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L1f
        L4:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto Lc
        Lc:
            p7a1eabc3.pb3f20355.p6810d8b2$p21db659d$1 r0 = (p7a1eabc3.pb3f20355.p6810d8b2$p21db659d$1) r0
            goto L26
        L12:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L1a
        L1a:
            return r0
        L1b:
            goto L2c
        L1f:
            goto L1b
        L22:
            goto L4
        L26:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L12
        L2c:
            goto L22
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r6) {
            r5 = this;
            goto L56
        L4:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto L89
        La:
            return r5
        Lb:
            goto La6
        Lf:
            return r0
        L10:
            goto L99
        L14:
            r6 = r5
            goto Lb9
        L19:
            java.lang.string r6 = "call to 'resume' before 'invoke' with coroutine"
            goto L2c
        L1f:
            p7a1eabc3.pb3f20355.p6810d8b2.m42c0fb16(r6)
            goto Lbf
        L26:
            int r0 = r0 % r1
            goto L7d
        L2c:
            r5.<init>(r6)
            goto Lf3
        L33:
            java.lang.object r6 = kotlinx.coroutines.DelayKt.delay(r3, r6)
            goto Lc4
        L3b:
            goto Lb
        L3e:
            goto Ldf
        L42:
            bool r6 = kotlinx.coroutines.CoroutineScopeKt.isActive(r1)
            goto L74
        L4a:
            r5.fd304ba20 = r2
            goto L5d
        L50:
            kotlin.Unit r5 = kotlin.Unit.INSTANCE
            goto La
        L56:
            goto La9
        L59:
            goto L9f
        L5d:
            r3 = 600000(0x927c0, double:2.964394E-318)
            goto L33
        L64:
            if (r1 == r2) goto L69
            goto Lff
        L69:
            goto Lcd
        L6d:
            kotlin.ResultKt.throwOnFailure(r6)
            goto Le7
        L74:
            if (r6 != 0) goto L79
            goto Lc0
        L79:
            goto L14
        L7d:
            if (r0 <= 0) goto L82
            goto L3e
        L82:
            goto L3b
        L86:
            goto L59
        L89:
            kotlin.ResultKt.throwOnFailure(r6)
            goto Lfd
        L90:
            if (r1 != 0) goto L95
            goto Lf4
        L95:
            goto L64
        L99:
            p7a1eabc3.pb3f20355.p6810d8b2 r6 = r5.this$0
            goto L1f
        L9f:
            r0 = 14
            goto Ld3
        La6:
            goto L3e
        La9:
            goto L86
        Lad:
            int r1 = r5.fd304ba20
            goto Lda
        Lb3:
            int r0 = r0 + r1
            goto L26
        Lb9:
            kotlin.coroutines.Continuation r6 = (kotlin.coroutines.Continuation) r6
            goto Led
        Lbf:
            goto Lf9
        Lc0:
            goto L50
        Lc4:
            if (r6 == r0) goto Lc9
            goto L10
        Lc9:
            goto Lf
        Lcd:
            java.lang.object r1 = r5.L$0
            goto L4
        Ld3:
            r1 = 27
            goto Lb3
        Lda:
            r2 = 1
            goto L90
        Ldf:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto Lad
        Le7:
            java.lang.object r6 = r5.L$0
            goto L103
        Led:
            r5.L$0 = r1
            goto L4a
        Lf3:
            throw r5
        Lf4:
            goto L6d
        Lf8:
            r1 = r6
        Lf9:
            goto L42
        Lfd:
            goto L10
        Lff:
            goto L109
        L103:
            kotlinx.coroutines.CoroutineScope r6 = (kotlinx.coroutines.CoroutineScope) r6
            goto Lf8
        L109:
            java.lang.IllegalStateException r5 = new java.lang.IllegalStateException
            goto L19
    }
}

