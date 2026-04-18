namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes21.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "phone.verification.presentation.sms.SmsVerificationobjectModel$startTimer$1", m533f = "SmsVerificationobjectModel.kt", m534i = {0, 0}, m535l = {78}, m536m = "invokeSuspend", m537n = {"tickSeconds", "second"}, m538s = {"J$0", "J$1"})
readonly class p389e8391$p9a032022$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ long $totalSeconds;
    long J$0;
    long J$1;
    int f8af62205;
    int fd304ba20;
    readonly /* synthetic */ pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391 this$0;

    p389e8391$p9a032022$1(long r1, pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391 r3, kotlin.coroutines.Continuation<? super pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391$p9a032022$1> r4) {
            r0 = this;
            goto L1d
        L4:
            goto L20
        L7:
            r1 = 2
            goto L24
        Lc:
            r0.$totalSeconds = r1
            goto L12
        L12:
            r0.this$0 = r3
            goto L7
        L18:
            return
        L19:
            goto L4
        L1d:
            goto L19
        L20:
            goto Lc
        L24:
            r0.<init>(r1, r4)
            goto L18
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r3, kotlin.coroutines.Continuation<object> r4) {
            r2 = this;
            goto L1c
        L4:
            return r3
        L5:
            goto L37
        L9:
            long r0 = r2.$totalSeconds
            goto L3e
        Lf:
            r1 = 18
            goto L5d
        L16:
            int r0 = r0 % r1
            goto L44
        L1c:
            goto L3a
        L1f:
            goto L56
        L23:
            r3.<init>(r0, r2, r4)
            goto L4d
        L2a:
            pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391$p9a032022$1 r3 = new pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391$p9a032022$1
            goto L9
        L30:
            goto L5
        L33:
            goto L2a
        L37:
            goto L33
        L3a:
            goto L53
        L3e:
            pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391 r2 = r2.this$0
            goto L23
        L44:
            if (r0 <= 0) goto L49
            goto L33
        L49:
            goto L30
        L4d:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto L4
        L53:
            goto L1f
        L56:
            r0 = 30
            goto Lf
        L5d:
            int r0 = r0 + r1
            goto L16
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto La
        L4:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L1c
        La:
            goto L12
        Ld:
            goto L16
        L11:
            return r0
        L12:
            goto L24
        L16:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto L4
        L1c:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto L11
        L24:
            goto Ld
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto Lf
        L4:
            return r0
        L5:
            goto L26
        L9:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L1e
        Lf:
            goto L5
        L12:
            goto L16
        L16:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L29
        L1e:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L4
        L26:
            goto L12
        L29:
            pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391$p9a032022$1 r0 = (pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391$p9a032022$1) r0
            goto L9
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r10) {
            r9 = this;
            goto L125
        L4:
            long r3 = r9.$totalSeconds
            goto L5b
        La:
            int r10 = (r5 > r3 ? 1 : (r5 == r3 ? 0 : -1))
            goto L116
        L10:
            goto L1c
        L11:
            goto Lc1
        L15:
            pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391 r10 = r9.this$0
            goto L8f
        L1b:
            return r0
        L1c:
            goto L11f
        L20:
            androidx.lifecycle.MutableLiveData r9 = pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391.m99eca3a7(r9)
            goto L68
        L28:
            goto L11b
        L2a:
            goto L89
        L2e:
            int r0 = r0 % r1
            goto L10d
        L34:
            kotlin.ResultKt.throwOnFailure(r10)
            goto L4
        L3b:
            kotlin.coroutines.Continuation r10 = (kotlin.coroutines.Continuation) r10
            goto L12c
        L41:
            java.lang.string r10 = "call to 'resume' before 'invoke' with coroutine"
            goto L61
        L47:
            long r3 = r3 + r7
            goto L28
        L4c:
            goto L128
        L4f:
            long r5 = r9.J$0
            goto Lcd
        L55:
            long r3 = r9.J$1
            goto L4f
        L5b:
            r5 = 1
            goto La
        L61:
            r9.<init>(r10)
            goto L15a
        L68:
            pad5f82e8.p07214c67.pa4ecfc70$p910eef8c r10 = pad5f82e8.p07214c67.pa4ecfc70.f910eef8c
            goto L13a
        L6e:
            r9.J$1 = r3
            goto Lf3
        L74:
            r10.postValue(r1)
            goto L9d
        L7b:
            r1 = 1
            goto L107
        L82:
            goto Lb7
        L85:
            goto L4c
        L89:
            pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391 r9 = r9.this$0
            goto L20
        L8f:
            androidx.lifecycle.MutableLiveData r10 = pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391.m32a46789(r10)
            goto L145
        L97:
            r7 = 1000(0x3e8, double:4.94E-321)
            goto L132
        L9d:
            r10 = r9
            goto L3b
        La2:
            if (r1 != 0) goto La7
            goto L15b
        La7:
            goto Lf9
        Lab:
            if (r10 != 0) goto Lb0
            goto L2a
        Lb0:
            goto L13f
        Lb4:
            goto L14e
        Lb7:
            goto L152
        Lbb:
            int r1 = r9.fd304ba20
            goto L102
        Lc1:
            java.lang.IllegalStateException r9 = new java.lang.IllegalStateException
            goto L41
        Lc7:
            kotlin.Unit r9 = kotlin.Unit.INSTANCE
            goto L14d
        Lcd:
            kotlin.ResultKt.throwOnFailure(r10)
            goto L10
        Ld4:
            r9.postValue(r10)
            goto Lc7
        Ldb:
            r0 = 12
            goto L7b
        Le2:
            pad5f82e8.p07214c67.pa4ecfc70 r10 = pad5f82e8.p07214c67.pa4ecfc70.p910eef8c.m02f94ccf(r10, r0, r2, r0)
            goto Ld4
        Lea:
            if (r10 == r0) goto Lef
            goto L1c
        Lef:
            goto L1b
        Lf3:
            r9.fd304ba20 = r2
            goto L97
        Lf9:
            if (r1 == r2) goto Lfe
            goto L11
        Lfe:
            goto L55
        L102:
            r2 = 1
            goto La2
        L107:
            int r0 = r0 + r1
            goto L2e
        L10d:
            if (r0 <= 0) goto L112
            goto Lb7
        L112:
            goto Lb4
        L116:
            if (r10 <= 0) goto L11b
            goto L2a
        L11b:
            goto L15
        L11f:
            int r10 = (r3 > r5 ? 1 : (r3 == r5 ? 0 : -1))
            goto Lab
        L125:
            goto L85
        L128:
            goto Ldb
        L12c:
            r9.J$0 = r5
            goto L6e
        L132:
            java.lang.object r10 = kotlinx.coroutines.DelayKt.delay(r7, r10)
            goto Lea
        L13a:
            r0 = 0
            goto Le2
        L13f:
            r7 = -1
            goto L47
        L145:
            java.lang.long r1 = kotlin.coroutines.jvm.internal.Boxing.boxlong(r3)
            goto L74
        L14d:
            return r9
        L14e:
            goto L82
        L152:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto Lbb
        L15a:
            throw r9
        L15b:
            goto L34
    }
}

