namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes3.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventory.repository.InventoryRepositoryImpl$startCommoditiesUpdate$1", m533f = "InventoryRepositoryImpl.kt", m534i = {0}, m535l = {208}, m536m = "invokeSuspend", m537n = {"$this$launch"}, m538s = {"L$0"})
readonly class p6810d8b2$p0e020c86$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    private /* synthetic */ java.lang.object L$0;
    int f59a6ef0d;
    int f9cf21cf0;
    int fd304ba20;
    readonly /* synthetic */ p7a1eabc3.pb3f20355.p6810d8b2 this$0;

    p6810d8b2$p0e020c86$1(p7a1eabc3.pb3f20355.p6810d8b2 r1, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p6810d8b2$p0e020c86$1> r2) {
            r0 = this;
            goto L14
        L4:
            r0.this$0 = r1
            goto Lf
        La:
            return
        Lb:
            goto L22
        Lf:
            r1 = 2
            goto L1b
        L14:
            goto Lb
        L17:
            goto L4
        L1b:
            r0.<init>(r1, r2)
            goto La
        L22:
            goto L17
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L1e
        L4:
            p7a1eabc3.pb3f20355.p6810d8b2$p0e020c86$1 r0 = new p7a1eabc3.pb3f20355.p6810d8b2$p0e020c86$1
            goto L15
        La:
            r0.L$0 = r2
            goto L25
        L10:
            return r0
        L11:
            goto L1b
        L15:
            p7a1eabc3.pb3f20355.p6810d8b2 r1 = r1.this$0
            goto L2b
        L1b:
            goto L21
        L1e:
            goto L11
        L21:
            goto L4
        L25:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L10
        L2b:
            r0.<init>(r1, r3)
            goto La
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L1d
        L4:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto Lf
        La:
            return r0
        Lb:
            goto L24
        Lf:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L15
        L15:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto La
        L1d:
            goto Lb
        L20:
            goto L4
        L24:
            goto L20
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L1c
        L4:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L29
        Lc:
            goto L1f
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto Lf
        L1c:
            goto L10
        L1f:
            goto L4
        L23:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L14
        L29:
            p7a1eabc3.pb3f20355.p6810d8b2$p0e020c86$1 r0 = (p7a1eabc3.pb3f20355.p6810d8b2$p0e020c86$1) r0
            goto L23
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r6) {
            r5 = this;
            goto Le0
        L4:
            r0 = 1
            goto Ld9
        Lb:
            r3 = 600000(0x927c0, double:2.964394E-318)
            goto L72
        L12:
            int r1 = r5.fd304ba20
            goto L54
        L18:
            goto Lc3
        L1a:
            goto Lec
        L1e:
            if (r6 == r0) goto L23
            goto Lb8
        L23:
            goto Lb7
        L27:
            r5.L$0 = r1
            goto L85
        L2d:
            if (r6 != 0) goto L32
            goto L1a
        L32:
            goto L6d
        L36:
            kotlin.ResultKt.throwOnFailure(r6)
            goto L7a
        L3d:
            goto Le3
        L40:
            goto L81
        L43:
            goto La4
        L47:
            java.lang.string r6 = "call to 'resume' before 'invoke' with coroutine"
            goto L8b
        L4d:
            p7a1eabc3.pb3f20355.p6810d8b2.m134a222c(r6)
            goto L18
        L54:
            r2 = 1
            goto L92
        L59:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto Lf2
        L5f:
            bool r6 = kotlinx.coroutines.CoroutineScopeKt.isActive(r1)
            goto L2d
        L67:
            java.lang.object r1 = r5.L$0
            goto L59
        L6d:
            r6 = r5
            goto Lf9
        L72:
            java.lang.object r6 = kotlinx.coroutines.DelayKt.delay(r3, r6)
            goto L1e
        L7a:
            java.lang.object r6 = r5.L$0
            goto Lcd
        L80:
            return r5
        L81:
            goto Lff
        L85:
            r5.fd304ba20 = r2
            goto Lb
        L8b:
            r5.<init>(r6)
            goto Le7
        L92:
            if (r1 != 0) goto L97
            goto Le8
        L97:
            goto L106
        L9b:
            if (r0 <= 0) goto La0
            goto L43
        La0:
            goto L40
        La4:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L12
        Lac:
            int r0 = r0 + r1
            goto Lc7
        Lb2:
            goto Lb8
        Lb3:
            goto Ld3
        Lb7:
            return r0
        Lb8:
            goto Lbc
        Lbc:
            p7a1eabc3.pb3f20355.p6810d8b2 r6 = r5.this$0
            goto L4d
        Lc2:
            r1 = r6
        Lc3:
            goto L5f
        Lc7:
            int r0 = r0 % r1
            goto L9b
        Lcd:
            kotlinx.coroutines.CoroutineScope r6 = (kotlinx.coroutines.CoroutineScope) r6
            goto Lc2
        Ld3:
            java.lang.IllegalStateException r5 = new java.lang.IllegalStateException
            goto L47
        Ld9:
            r1 = 3
            goto Lac
        Le0:
            goto L102
        Le3:
            goto L4
        Le7:
            throw r5
        Le8:
            goto L36
        Lec:
            kotlin.Unit r5 = kotlin.Unit.INSTANCE
            goto L80
        Lf2:
            kotlin.ResultKt.throwOnFailure(r6)
            goto Lb2
        Lf9:
            kotlin.coroutines.Continuation r6 = (kotlin.coroutines.Continuation) r6
            goto L27
        Lff:
            goto L43
        L102:
            goto L3d
        L106:
            if (r1 == r2) goto L10b
            goto Lb3
        L10b:
            goto L67
    }
}

