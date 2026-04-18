namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes21.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.view.TOPobject$startPagerSwap$1", m533f = "Tophobject.kt", m534i = {0}, m535l = {428}, m536m = "invokeSuspend", m537n = {"i"}, m538s = {"I$0"})
readonly class pff09e7a3$p39aba625$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int I$0;
    int f4d0b1ef0;
    int f7411ea6a;
    int fd304ba20;
    int fef7fbbca;
    readonly /* synthetic */ p83f5c3ad.p2486923a.p1bda80f2.pff09e7a3 this$0;

    pff09e7a3$p39aba625$1(p83f5c3ad.p2486923a.p1bda80f2.pff09e7a3 r1, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p1bda80f2.pff09e7a3$p39aba625$1> r2) {
            r0 = this;
            goto L1e
        L4:
            return
        L5:
            goto Le
        L9:
            r1 = 2
            goto L17
        Le:
            goto L21
        L11:
            r0.this$0 = r1
            goto L9
        L17:
            r0.<init>(r1, r2)
            goto L4
        L1e:
            goto L5
        L21:
            goto L11
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r1, kotlin.coroutines.Continuation<object> r2) {
            r0 = this;
            goto L18
        L4:
            kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
            goto L13
        La:
            p83f5c3ad.p2486923a.p1bda80f2.pff09e7a3 r0 = r0.this$0
            goto L25
        L10:
            goto L1b
        L13:
            return r1
        L14:
            goto L10
        L18:
            goto L14
        L1b:
            goto L1f
        L1f:
            p83f5c3ad.p2486923a.p1bda80f2.pff09e7a3$p39aba625$1 r1 = new p83f5c3ad.p2486923a.p1bda80f2.pff09e7a3$p39aba625$1
            goto La
        L25:
            r1.<init>(r0, r2)
            goto L4
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
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
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto L21
        L19:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto L4
        L21:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L19
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L22
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L4
        L11:
            goto L25
        L14:
            p83f5c3ad.p2486923a.p1bda80f2.pff09e7a3$p39aba625$1 r0 = (p83f5c3ad.p2486923a.p1bda80f2.pff09e7a3$p39aba625$1) r0
            goto L29
        L1a:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L14
        L22:
            goto L5
        L25:
            goto L1a
        L29:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L9
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r7) {
            r6 = this;
            goto L51
        L4:
            java.lang.IllegalStateException r6 = new java.lang.IllegalStateException
            goto L121
        La:
            return r6
        Lb:
            goto L58
        Lf:
            if (r1 != 0) goto L14
            goto Lb6
        L14:
            goto Ldb
        L18:
            int r0 = r0 + r1
            goto L24
        L1e:
            goto Lab
        L20:
            goto L72
        L24:
            int r0 = r0 % r1
            goto Lc6
        L2a:
            int r1 = r6.fd304ba20
            goto Lcf
        L30:
            p83f5c3ad.p2486923a.p1bda80f2.pff09e7a3.mb2b442ce(r7, r4)
            goto L10b
        L37:
            r7.invalidate()
            goto L46
        L3e:
            bool r7 = p83f5c3ad.p2486923a.p1bda80f2.pff09e7a3.mb40e9c41(r7)
            goto L127
        L46:
            goto L111
        L48:
            goto Laf
        L4c:
            return r0
        L4d:
            goto L130
        L51:
            goto L5b
        L54:
            goto L138
        L58:
            goto Ld7
        L5b:
            goto La2
        L5f:
            goto L4d
        L60:
            goto L4
        L64:
            r3 = 1
            goto Lf
        L69:
            if (r1 == r7) goto L6e
            goto L20
        L6e:
            goto Lf3
        L72:
            int r7 = r1 + 1
            goto L86
        L78:
            kotlin.coroutines.Continuation r7 = (kotlin.coroutines.Continuation) r7
            goto Led
        L7e:
            java.lang.object r7 = kotlinx.coroutines.DelayKt.delay(r4, r7)
            goto Le4
        L86:
            kotlin.coroutines.jvm.internal.Boxing.boxInt(r1)
            goto Laa
        L8d:
            r4 = 800(0x320, double:3.953E-321)
            goto L7e
        L93:
            p83f5c3ad.p2486923a.p1bda80f2.p728711fb[] r4 = p83f5c3ad.p2486923a.p1bda80f2.p728711fb.Values
            goto L11b
        L9b:
            kotlin.ResultKt.throwOnFailure(r7)
            goto L5f
        La2:
            goto L54
        La5:
            int r7 = r7 - r3
            goto L69
        Laa:
            r1 = r7
        Lab:
            goto Lc0
        Laf:
            kotlin.Unit r6 = kotlin.Unit.INSTANCE
            goto La
        Lb5:
            throw r6
        Lb6:
            goto Lf8
        Lba:
            r6.fd304ba20 = r3
            goto L8d
        Lc0:
            p83f5c3ad.p2486923a.p1bda80f2.pff09e7a3 r7 = r6.this$0
            goto L37
        Lc6:
            if (r0 <= 0) goto Lcb
            goto Ld7
        Lcb:
            goto Ld4
        Lcf:
            r2 = 0
            goto L64
        Ld4:
            goto Lb
        Ld7:
            goto L146
        Ldb:
            if (r1 == r3) goto Le0
            goto L60
        Le0:
            goto L154
        Le4:
            if (r7 == r0) goto Le9
            goto L4d
        Le9:
            goto L4c
        Led:
            r6.I$0 = r1
            goto Lba
        Lf3:
            r1 = r2
            goto L1e
        Lf8:
            kotlin.ResultKt.throwOnFailure(r7)
            goto L110
        Lff:
            r1 = 7
            goto L18
        L106:
            int r7 = r7.length
            goto La5
        L10b:
            r7 = r6
            goto L78
        L110:
            r1 = r2
        L111:
            goto L14e
        L115:
            p83f5c3ad.p2486923a.p1bda80f2.pff09e7a3 r7 = r6.this$0
            goto L93
        L11b:
            r4 = r4[r1]
            goto L30
        L121:
            java.lang.string r7 = "call to 'resume' before 'invoke' with coroutine"
            goto L13f
        L127:
            if (r7 != 0) goto L12c
            goto L48
        L12c:
            goto L115
        L130:
            p83f5c3ad.p2486923a.p1bda80f2.p728711fb[] r7 = p83f5c3ad.p2486923a.p1bda80f2.p728711fb.Values
            goto L106
        L138:
            r0 = 4
            goto Lff
        L13f:
            r6.<init>(r7)
            goto Lb5
        L146:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L2a
        L14e:
            p83f5c3ad.p2486923a.p1bda80f2.pff09e7a3 r7 = r6.this$0
            goto L3e
        L154:
            int r1 = r6.I$0
            goto L9b
    }
}

