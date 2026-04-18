namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [E] */
/* JADX INFO: loaded from: classes6.dex */
@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "E", "Lkotlin/sequences/SequenceScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.collection.MutableScatterHashSet$MutableHashSetWrapper$iterator$1$iterator$1", m533f = "ScatterHashSet.kt", m534i = {0, 0, 0, 0, 0, 0, 0}, m535l = {1060}, m536m = "invokeSuspend", m537n = {"$this$iterator", "m$iv", "lastIndex$iv", "i$iv", "slot$iv", "bitCount$iv", "j$iv"}, m538s = {"L$0", "L$3", "I$0", "I$1", "J$0", "I$2", "I$3"})
readonly class MutableScatterHashSet$MutableHashSetWrapper$iterator$1$iterator$1<E> : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<E>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int I$0;
    int I$1;
    int I$2;
    int I$3;
    long J$0;
    private /* synthetic */ java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    int label;
    readonly /* synthetic */ androidx.collection.MutableScatterHashSet<E> this$0;
    readonly /* synthetic */ androidx.collection.MutableScatterHashSet$MutableHashSetWrapper$iterator$1<E> this$1;

    MutableScatterHashSet$MutableHashSetWrapper$iterator$1$iterator$1(androidx.collection.MutableScatterHashSet<E> r1, androidx.collection.MutableScatterHashSet$MutableHashSetWrapper$iterator$1<E> r2, kotlin.coroutines.Continuation<? super androidx.collection.MutableScatterHashSet$MutableHashSetWrapper$iterator$1$iterator$1> r3) {
            r0 = this;
            goto L9
        L4:
            r1 = 2
            goto L15
        L9:
            goto L11
        Lc:
            goto L22
        L10:
            return
        L11:
            goto L28
        L15:
            r0.<init>(r1, r3)
            goto L10
        L1c:
            r0.this$1 = r2
            goto L4
        L22:
            r0.this$0 = r1
            goto L1c
        L28:
            goto Lc
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r3, kotlin.coroutines.Continuation<object> r4) {
            r2 = this;
            goto L11
        L4:
            androidx.collection.MutableScatterHashSet$MutableHashSetWrapper$iterator$1$iterator$1 r0 = new androidx.collection.MutableScatterHashSet$MutableHashSetWrapper$iterator$1$iterator$1
            goto L23
        La:
            goto L46
        Ld:
            goto L59
        L11:
            goto Ld
        L14:
            goto L62
        L18:
            int r0 = r0 + r1
            goto L30
        L1e:
            return r0
        L1f:
            goto La
        L23:
            androidx.collection.MutableScatterHashSet<E> r1 = r2.this$0
            goto L5c
        L29:
            r0.<init>(r1, r2, r4)
            goto L3d
        L30:
            int r0 = r0 % r1
            goto L50
        L36:
            r1 = 14
            goto L18
        L3d:
            r0.L$0 = r3
            goto L4a
        L43:
            goto L1f
        L46:
            goto L4
        L4a:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L1e
        L50:
            if (r0 <= 0) goto L55
            goto L46
        L55:
            goto L43
        L59:
            goto L14
        L5c:
            androidx.collection.MutableScatterHashSet$MutableHashSetWrapper$iterator$1<E> r2 = r2.this$1
            goto L29
        L62:
            r0 = 6
            goto L36
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto Lc
        L4:
            java.lang.object r0 = r0.invoke(r1, r2)
            goto L22
        Lc:
            goto L23
        Lf:
            goto L1c
        L13:
            goto Lf
        L16:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L4
        L1c:
            kotlin.sequences.SequenceScope r1 = (kotlin.sequences.SequenceScope) r1
            goto L16
        L22:
            return r0
        L23:
            goto L13
    }

    public readonly java.lang.object Invoke(kotlin.sequences.SequenceScope<E> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L10
        L4:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L27
        La:
            androidx.collection.MutableScatterHashSet$MutableHashSetWrapper$iterator$1$iterator$1 r0 = (androidx.collection.MutableScatterHashSet$MutableHashSetWrapper$iterator$1$iterator$1) r0
            goto L4
        L10:
            goto L18
        L13:
            goto L1f
        L17:
            return r0
        L18:
            goto L1c
        L1c:
            goto L13
        L1f:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto La
        L27:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L17
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r22) {
            r21 = this;
            goto L1f1
        L4:
            r10 = 0
        L5:
            goto L46
        L9:
            int r13 = ~r13
            goto L145
        Le:
            r10 = r9
            goto L17e
        L13:
            java.lang.object r14 = r0.L$0
            goto L167
        L19:
            r15 = 7
            goto L4c
        L1e:
            long r13 = r13 & r15
            goto L1d2
        L23:
            r0.I$3 = r2
            goto L22e
        L29:
            long r15 = r15 & r7
            goto L102
        L2e:
            r0.<init>(r1)
            goto L223
        L35:
            java.lang.object r11 = r0.L$3
            goto L61
        L3b:
            r0.J$0 = r7
            goto L198
        L41:
            r7 = r11
            goto Lad
        L46:
            r11 = r7[r10]
            goto L57
        L4c:
            long r13 = r13 << r15
            goto Lce
        L51:
            kotlin.Unit r0 = kotlin.Unit.INSTANCE
            goto L73
        L57:
            long r13 = ~r11
            goto L19
        L5c:
            r14 = r10
            goto L250
        L61:
            long[] r11 = (long[]) r11
            goto L296
        L67:
            java.lang.object r2 = r0.L$0
            goto L19e
        L6d:
            int r10 = r0.I$0
            goto L35
        L73:
            return r0
        L74:
            goto L117
        L78:
            int r9 = r7.length
            goto L25b
        L7d:
            r0.L$2 = r12
            goto L24a
        L83:
            int r15 = (r15 > r17 ? 1 : (r15 == r17 ? 0 : -1))
            goto L1ad
        L89:
            r6 = r13
            goto La2
        L8e:
            int r10 = r10 + 1
            goto L18c
        L94:
            int r2 = r2 + r5
            goto L1c1
        L99:
            if (r2 != 0) goto L9e
            goto L224
        L9e:
            goto L10e
        La2:
            r13 = r8
            goto L273
        La7:
            androidx.collection.MutableScatterHashSet$MutableHashSetWrapper$iterator$1<E> r8 = r0.this$1
            goto Lb7
        Lad:
            r6 = r12
            goto L282
        Lb2:
            return r1
        Lb3:
            goto L1cd
        Lb7:
            long[] r7 = r7.metadata
            goto L78
        Lbd:
            java.lang.object[] r3 = r12.elements
            goto L133
        Lc3:
            goto Lb3
        Lc5:
            goto Lfc
        Lc9:
            r12 = r6
            goto Lf7
        Lce:
            long r13 = r13 & r11
            goto L287
        Ld3:
            int r2 = r0.label
            goto L108
        Ld9:
            androidx.collection.ScatterHashSet r7 = (androidx.collection.ScatterHashSet) r7
            goto La7
        Ldf:
            if (r2 < r6) goto Le4
            goto L1c3
        Le4:
            goto L1c7
        Le8:
            if (r6 == r4) goto Led
            goto L18e
        Led:
            goto L1b6
        Lf1:
            r0.L$0 = r14
            goto L139
        Lf7:
            r11 = r7
            goto L89
        Lfc:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
            goto L255
        L102:
            r17 = 128(0x80, double:6.3E-322)
            goto L83
        L108:
            r4 = 8
            goto L267
        L10e:
            if (r2 == r5) goto L113
            goto Lc5
        L113:
            goto L123
        L117:
            goto L207
        L11a:
            goto L20b
        L11e:
            r2 = 0
            goto L29c
        L123:
            int r2 = r0.I$3
            goto L234
        L129:
            r2 = r14
        L12a:
            goto L20e
        L12e:
            int r15 = r15 + r2
            goto L1df
        L133:
            r3 = r3[r15]
            goto Lf1
        L139:
            r0.L$1 = r13
            goto L7d
        L13f:
            androidx.collection.MutableScatterHashSet$MutableHashSetWrapper$iterator$1 r13 = (androidx.collection.MutableScatterHashSet$MutableHashSetWrapper$iterator$1) r13
            goto L13
        L145:
            int r13 = r13 >>> 31
            goto L21d
        L14b:
            java.lang.object r3 = r14.yield(r3, r0)
            goto L1a4
        L153:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto Ld3
        L15b:
            r7 = r6
            goto Ld9
        L160:
            r0 = 23
            goto L26c
        L167:
            kotlin.sequences.SequenceScope r14 = (kotlin.sequences.SequenceScope) r14
            goto L1d8
        L16d:
            r0 = r21
            goto L153
        L173:
            r9 = r14
            goto L1e6
        L178:
            int r0 = r0 + r1
            goto L228
        L17e:
            r9 = r2
            goto L41
        L183:
            if (r13 != 0) goto L188
            goto L12a
        L188:
            goto L1fe
        L18c:
            goto L5
        L18e:
            goto L51
        L192:
            r0.I$1 = r9
            goto L3b
        L198:
            r0.I$2 = r6
            goto L23
        L19e:
            kotlin.sequences.SequenceScope r2 = (kotlin.sequences.SequenceScope) r2
            goto L290
        L1a4:
            if (r3 == r1) goto L1a9
            goto Lb3
        L1a9:
            goto Lb2
        L1ad:
            if (r15 < 0) goto L1b2
            goto Lb3
        L1b2:
            goto L1bb
        L1b6:
            r2 = r10
            goto Le
        L1bb:
            int r15 = r9 << 3
            goto L12e
        L1c1:
            goto L275
        L1c3:
            goto Le8
        L1c7:
            r15 = 255(0xff, double:1.26E-321)
            goto L29
        L1cd:
            long r7 = r7 >> r4
            goto L94
        L1d2:
            int r13 = (r13 > r15 ? 1 : (r13 == r15 ? 0 : -1))
            goto L183
        L1d8:
            kotlin.ResultKt.throwOnFailure(r22)
            goto Lc3
        L1df:
            r13.setCurrent(r15)
            goto Lbd
        L1e6:
            r14 = r2
            goto L11e
        L1eb:
            long r7 = r0.J$0
            goto L217
        L1f1:
            goto L11a
        L1f4:
            goto L160
        L1f8:
            r0.I$0 = r10
            goto L192
        L1fe:
            int r13 = r10 - r9
            goto L9
        L204:
            goto L74
        L207:
            goto L16d
        L20b:
            goto L1f4
        L20e:
            if (r10 != r9) goto L213
            goto L18e
        L213:
            goto L8e
        L217:
            int r9 = r0.I$1
            goto L6d
        L21d:
            int r13 = 8 - r13
            goto L5c
        L223:
            throw r0
        L224:
            goto L243
        L228:
            int r0 = r0 % r1
            goto L23a
        L22e:
            r0.label = r5
            goto L14b
        L234:
            int r6 = r0.I$2
            goto L1eb
        L23a:
            if (r0 <= 0) goto L23f
            goto L207
        L23f:
            goto L204
        L243:
            kotlin.ResultKt.throwOnFailure(r22)
            goto L67
        L24a:
            r0.L$3 = r11
            goto L1f8
        L250:
            r10 = r9
            goto L173
        L255:
            java.lang.string r1 = "call to 'resume' before 'invoke' with coroutine"
            goto L2e
        L25b:
            int r9 = r9 + (-2)
            goto L279
        L261:
            androidx.collection.MutableScatterHashSet r12 = (androidx.collection.MutableScatterHashSet) r12
            goto L2a2
        L267:
            r5 = 1
            goto L99
        L26c:
            r1 = 31
            goto L178
        L273:
            r7 = r19
        L275:
            goto Ldf
        L279:
            if (r9 >= 0) goto L27e
            goto L18e
        L27e:
            goto L4
        L282:
            r8 = r13
            goto L129
        L287:
            r15 = -9187201950435737472(0x8080808080808080, double:-2.937446524422997E-306)
            goto L1e
        L290:
            androidx.collection.MutableScatterHashSet<E> r6 = r0.this$0
            goto L15b
        L296:
            java.lang.object r12 = r0.L$2
            goto L261
        L29c:
            r19 = r11
            goto Lc9
        L2a2:
            java.lang.object r13 = r0.L$1
            goto L13f
    }
}

