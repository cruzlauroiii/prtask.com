namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes21.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.activation.confirm.TophActivationConfirmobjectModel$startTimer$1", m533f = "TophActivationConfirmobjectModel.kt", m534i = {0, 0, 1, 1}, m535l = {93, 94, 96}, m536m = "invokeSuspend", m537n = {"tickSeconds", "second", "tickSeconds", "second"}, m538s = {"I$0", "I$1", "I$0", "I$1"})
readonly class p05846114$p9a032022$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int I$0;
    int I$1;
    int fb34d36c3;
    int fd304ba20;
    int fd71ccb2e;
    int fe7a3e914;
    int ffa3e2451;
    readonly /* synthetic */ p83f5c3ad.p2486923a.p24eed33e.pd0cf705f.p05846114 this$0;

    p05846114$p9a032022$1(p83f5c3ad.p2486923a.p24eed33e.pd0cf705f.p05846114 r1, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p24eed33e.pd0cf705f.p05846114$p9a032022$1> r2) {
            r0 = this;
            goto L1e
        L4:
            r1 = 2
            goto L17
        L9:
            goto L21
        Lc:
            r0.this$0 = r1
            goto L4
        L12:
            return
        L13:
            goto L9
        L17:
            r0.<init>(r1, r2)
            goto L12
        L1e:
            goto L13
        L21:
            goto Lc
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r1, kotlin.coroutines.Continuation<object> r2) {
            r0 = this;
            goto L9
        L4:
            return r1
        L5:
            goto L1c
        L9:
            goto L5
        Lc:
            goto L16
        L10:
            p83f5c3ad.p2486923a.p24eed33e.pd0cf705f.p05846114 r0 = r0.this$0
            goto L1f
        L16:
            p83f5c3ad.p2486923a.p24eed33e.pd0cf705f.p05846114$p9a032022$1 r1 = new p83f5c3ad.p2486923a.p24eed33e.pd0cf705f.p05846114$p9a032022$1
            goto L10
        L1c:
            goto Lc
        L1f:
            r1.<init>(r0, r2)
            goto L26
        L26:
            kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
            goto L4
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L20
        L4:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto Lf
        La:
            return r0
        Lb:
            goto L15
        Lf:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L18
        L15:
            goto L23
        L18:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto La
        L20:
            goto Lb
        L23:
            goto L4
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto La
        L4:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L1c
        La:
            goto L12
        Ld:
            goto L24
        L11:
            return r0
        L12:
            goto L2c
        L16:
            p83f5c3ad.p2486923a.p24eed33e.pd0cf705f.p05846114$p9a032022$1 r0 = (p83f5c3ad.p2486923a.p24eed33e.pd0cf705f.p05846114$p9a032022$1) r0
            goto L4
        L1c:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L11
        L24:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L16
        L2c:
            goto Ld
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r9) {
            r8 = this;
            goto L169
        L4:
            goto L1c6
        L6:
            goto L176
        La:
            java.lang.IllegalStateException r8 = new java.lang.IllegalStateException
            goto L1e
        L10:
            r5 = r1
            goto Le2
        L15:
            if (r1 != r4) goto L1a
            goto L6
        L1a:
            goto L102
        L1e:
            java.lang.string r9 = "call to 'resume' before 'invoke' with coroutine"
            goto Ld3
        L24:
            java.lang.object r8 = r9.emit(r1, r3)
            goto L8b
        L2c:
            r1 = r4
        L2d:
            goto L11b
        L31:
            int r5 = r8.I$0
            goto L10b
        L37:
            goto L2d
        L38:
            goto L1d8
        L3c:
            kotlin.coroutines.Continuation r9 = (kotlin.coroutines.Continuation) r9
            goto L159
        L42:
            java.lang.object r5 = r5.emit(r6, r7)
            goto L112
        L4a:
            if (r1 != r5) goto L4f
            goto L38
        L4f:
            goto L1ca
        L53:
            r9 = r8
            goto L3c
        L58:
            throw r8
        L59:
            goto Lc4
        L5d:
            goto L135
        L5f:
            goto La
        L63:
            r8.I$1 = r1
            goto L146
        L69:
            goto L165
        L6c:
            goto Lda
        L70:
            kotlin.ResultKt.throwOnFailure(r9)
            goto L4
        L77:
            r3 = 2
            goto L1b9
        L7c:
            if (r0 <= 0) goto L81
            goto L6c
        L81:
            goto L69
        L85:
            int r1 = r8.fd304ba20
            goto L15f
        L8b:
            if (r8 == r0) goto L90
            goto L135
        L90:
            goto L134
        L94:
            r8.I$1 = r9
            goto L170
        L9a:
            r9 = 120(0x78, float:1.68E-43)
            goto L2c
        La0:
            int r0 = r0 % r1
            goto L7c
        La6:
            goto L16c
        La9:
            r8.fd304ba20 = r2
            goto L24
        Laf:
            pad5f82e8.p07214c67.pa4ecfc70 r1 = pad5f82e8.p07214c67.pa4ecfc70.p910eef8c.m02f94ccf(r1, r3, r4, r3)
            goto L141
        Lb7:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto La9
        Lbd:
            kotlin.ResultKt.throwOnFailure(r9)
            goto L5d
        Lc4:
            int r1 = r8.I$1
            goto Lf5
        Lca:
            if (r9 == r0) goto Lcf
            goto L1c6
        Lcf:
            goto L1c4
        Ld3:
            r8.<init>(r9)
            goto L58
        Lda:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L85
        Le2:
            r1 = r9
        Le3:
            goto L53
        Le7:
            kotlinx.coroutines.flow.MutableSharedFlow r9 = p83f5c3ad.p2486923a.p24eed33e.pd0cf705f.p05846114.m708f95ff(r9)
            goto L197
        Lef:
            kotlin.coroutines.Continuation r7 = (kotlin.coroutines.Continuation) r7
            goto L1b3
        Lf5:
            int r5 = r8.I$0
            goto L70
        Lfb:
            goto L6c
        Lfe:
            goto La6
        L102:
            if (r1 != r3) goto L107
            goto L59
        L107:
            goto L17c
        L10b:
            kotlin.ResultKt.throwOnFailure(r9)
            goto L1be
        L112:
            if (r5 == r0) goto L117
            goto L155
        L117:
            goto L153
        L11b:
            p83f5c3ad.p2486923a.p24eed33e.pd0cf705f.p05846114 r5 = r8.this$0
            goto L1d0
        L121:
            java.lang.int r6 = kotlin.coroutines.jvm.internal.Boxing.boxInt(r9)
            goto L1de
        L129:
            int r0 = r0 + r1
            goto La0
        L12f:
            r3 = 0
            goto Laf
        L134:
            return r0
        L135:
            goto L19d
        L139:
            java.lang.object r9 = kotlinx.coroutines.DelayKt.delay(r6, r9)
            goto Lca
        L141:
            r3 = r8
            goto Lb7
        L146:
            r8.fd304ba20 = r3
            goto L18c
        L14c:
            kotlin.ResultKt.throwOnFailure(r9)
            goto L9a
        L153:
            goto L90
        L155:
            goto L10
        L159:
            r8.I$0 = r5
            goto L63
        L15f:
            r2 = 3
            goto L77
        L164:
            return r8
        L165:
            goto Lfb
        L169:
            goto Lfe
        L16c:
            goto L1ac
        L170:
            r8.fd304ba20 = r4
            goto L42
        L176:
            int r1 = r8.I$1
            goto L31
        L17c:
            if (r1 == r2) goto L181
            goto L5f
        L181:
            goto Lbd
        L185:
            r1 = 30
            goto L129
        L18c:
            r6 = 1000(0x3e8, double:4.94E-321)
            goto L139
        L192:
            r1 = r5
            goto L37
        L197:
            pad5f82e8.p07214c67.pa4ecfc70$p910eef8c r1 = pad5f82e8.p07214c67.pa4ecfc70.f910eef8c
            goto L12f
        L19d:
            kotlin.Unit r8 = kotlin.Unit.INSTANCE
            goto L164
        L1a3:
            if (r1 != 0) goto L1a8
            goto L1c0
        L1a8:
            goto L15
        L1ac:
            r0 = 14
            goto L185
        L1b3:
            r8.I$0 = r1
            goto L94
        L1b9:
            r4 = 1
            goto L1a3
        L1be:
            goto Le3
        L1c0:
            goto L14c
        L1c4:
            goto L90
        L1c6:
            goto L4a
        L1ca:
            int r9 = r1 + (-1)
            goto L192
        L1d0:
            kotlinx.coroutines.flow.MutableSharedFlow r5 = p83f5c3ad.p2486923a.p24eed33e.pd0cf705f.p05846114.md3476081(r5)
            goto L121
        L1d8:
            p83f5c3ad.p2486923a.p24eed33e.pd0cf705f.p05846114 r9 = r8.this$0
            goto Le7
        L1de:
            r7 = r8
            goto Lef
    }
}

