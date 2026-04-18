namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [E] */
/* JADX INFO: loaded from: classes6.dex */
@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "E", "Lkotlin/sequences/SequenceScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.collection.ScatterHashSet$HashSetWrapper$iterator$1", m533f = "ScatterHashSet.kt", m534i = {0, 0, 0, 0, 0, 0, 0, 0}, m535l = {495}, m536m = "invokeSuspend", m537n = {"$this$iterator", "k$iv", "m$iv$iv", "lastIndex$iv$iv", "i$iv$iv", "slot$iv$iv", "bitCount$iv$iv", "j$iv$iv"}, m538s = {"L$0", "L$1", "L$2", "I$0", "I$1", "J$0", "I$2", "I$3"})
readonly class ScatterHashSet$HashSetWrapper$iterator$1<E> : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<E>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int I$0;
    int I$1;
    int I$2;
    int I$3;
    long J$0;
    private /* synthetic */ java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    readonly /* synthetic */ androidx.collection.ScatterHashSet<E> this$0;

    ScatterHashSet$HashSetWrapper$iterator$1(androidx.collection.ScatterHashSet<E> r1, kotlin.coroutines.Continuation<? super androidx.collection.ScatterHashSet$HashSetWrapper$iterator$1> r2) {
            r0 = this;
            goto L1e
        L4:
            r1 = 2
            goto L9
        L9:
            r0.<init>(r1, r2)
            goto L16
        L10:
            r0.this$0 = r1
            goto L4
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto L21
        L1e:
            goto L17
        L21:
            goto L10
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L24
        L4:
            return r0
        L5:
            goto L1b
        L9:
            androidx.collection.ScatterHashSet$HashSetWrapper$iterator$1 r0 = new androidx.collection.ScatterHashSet$HashSetWrapper$iterator$1
            goto Lf
        Lf:
            androidx.collection.ScatterHashSet<E> r1 = r1.this$0
            goto L2b
        L15:
            r0.L$0 = r2
            goto L1e
        L1b:
            goto L27
        L1e:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L4
        L24:
            goto L5
        L27:
            goto L9
        L2b:
            r0.<init>(r1, r3)
            goto L15
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L12
        L4:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L19
        La:
            goto L15
        Ld:
            return r0
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L21
        L19:
            java.lang.object r0 = r0.invoke(r1, r2)
            goto Ld
        L21:
            kotlin.sequences.SequenceScope r1 = (kotlin.sequences.SequenceScope) r1
            goto L4
    }

    public readonly java.lang.object Invoke(kotlin.sequences.SequenceScope<E> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L22
        L4:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L1c
        Lc:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L14
        L14:
            return r0
        L15:
            goto L19
        L19:
            goto L25
        L1c:
            androidx.collection.ScatterHashSet$HashSetWrapper$iterator$1 r0 = (androidx.collection.ScatterHashSet$HashSetWrapper$iterator$1) r0
            goto L29
        L22:
            goto L15
        L25:
            goto L4
        L29:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto Lc
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r21) {
            r20 = this;
            goto L11e
        L4:
            kotlin.Unit r0 = kotlin.Unit.INSTANCE
            goto L10e
        La:
            r0.L$0 = r13
            goto L39
        L10:
            goto L10f
        L13:
            goto L15f
        L17:
            int r10 = r0.I$0
            goto L33
        L1d:
            r9 = r3
        L1e:
            goto L1cd
        L22:
            r14 = -9187201950435737472(0x8080808080808080, double:-2.937446524422997E-306)
            goto L151
        L2b:
            java.lang.object r14 = r13.yield(r14, r0)
            goto L12a
        L33:
            java.lang.object r11 = r0.L$2
            goto L188
        L39:
            r0.L$1 = r12
            goto L21f
        L3f:
            long r7 = r0.J$0
            goto L1a4
        L45:
            int r9 = r9 + 1
            goto L1b9
        L4b:
            r13 = r2
            goto L18e
        L50:
            java.lang.object r13 = r0.L$0
            goto L225
        L56:
            r18 = r10
            goto L84
        L5c:
            java.lang.object[] r12 = (java.lang.object[]) r12
            goto L50
        L62:
            r0.J$0 = r7
            goto Lb5
        L68:
            r8 = r10
            goto Ld5
        L6d:
            if (r2 < r6) goto L72
            goto L10a
        L72:
            goto L90
        L76:
            if (r8 >= 0) goto L7b
            goto L1bb
        L7b:
            goto L1d
        L7f:
            r12 = r7
            goto L1c7
        L84:
            r11 = r6
            goto Lda
        L89:
            kotlin.ResultKt.throwOnFailure(r21)
            goto L1d8
        L90:
            r14 = 255(0xff, double:1.26E-321)
            goto L1de
        L96:
            r0 = 14
            goto L139
        L9d:
            long[] r6 = r6.metadata
            goto L214
        La3:
            int r12 = r9 - r8
            goto L103
        La9:
            int r0 = r0 + r1
            goto L231
        Laf:
            int r12 = (r12 > r14 ? 1 : (r12 == r14 ? 0 : -1))
            goto Le6
        Lb5:
            r0.I$2 = r6
            goto L1b3
        Lbb:
            if (r2 != 0) goto Lc0
            goto L238
        Lc0:
            goto L156
        Lc4:
            long r7 = r7 >> r4
            goto L1f6
        Lc9:
            goto L249
        Lcb:
            goto L145
        Lcf:
            int r14 = r9 << 3
            goto L1fb
        Ld5:
            r6 = r11
            goto L1d3
        Lda:
            r10 = r8
            goto L200
        Ldf:
            r0.<init>(r1)
            goto L237
        Le6:
            if (r12 != 0) goto Leb
            goto L114
        Leb:
            goto La3
        Lef:
            java.lang.object r12 = r0.L$1
            goto L5c
        Lf5:
            if (r0 <= 0) goto Lfa
            goto L13
        Lfa:
            goto L10
        Lfe:
            r14 = 7
            goto L140
        L103:
            int r12 = ~r12
            goto L253
        L108:
            goto L1c9
        L10a:
            goto L17f
        L10e:
            return r0
        L10f:
            goto L165
        L113:
            r2 = r13
        L114:
            goto L1aa
        L118:
            r4 = 8
            goto L199
        L11e:
            goto L168
        L121:
            goto L96
        L125:
            long r12 = ~r10
            goto Lfe
        L12a:
            if (r14 == r1) goto L12f
            goto L249
        L12f:
            goto L248
        L133:
            int r14 = (r14 > r16 ? 1 : (r14 == r16 ? 0 : -1))
            goto L205
        L139:
            r1 = 4
            goto La9
        L140:
            long r12 = r12 << r14
            goto L1f1
        L145:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
            goto L193
        L14b:
            int r2 = r0.label
            goto L1e6
        L151:
            long r12 = r12 & r14
            goto Laf
        L156:
            if (r2 == r5) goto L15b
            goto Lcb
        L15b:
            goto L25f
        L15f:
            r0 = r20
            goto L1bf
        L165:
            goto L13
        L168:
            goto L1e3
        L16c:
            int r12 = 8 - r12
            goto L4b
        L172:
            r0.I$1 = r9
            goto L62
        L178:
            kotlin.ResultKt.throwOnFailure(r21)
            goto Lc9
        L17f:
            if (r6 == r4) goto L184
            goto L1bb
        L184:
            goto L68
        L188:
            long[] r11 = (long[]) r11
            goto Lef
        L18e:
            r2 = r3
            goto L56
        L193:
            java.lang.string r1 = "call to 'resume' before 'invoke' with coroutine"
            goto Ldf
        L199:
            r5 = 1
            goto Lbb
        L19e:
            r0.label = r5
            goto L2b
        L1a4:
            int r9 = r0.I$1
            goto L17
        L1aa:
            if (r9 != r8) goto L1af
            goto L1bb
        L1af:
            goto L45
        L1b3:
            r0.I$3 = r2
            goto L19e
        L1b9:
            goto L1e
        L1bb:
            goto L4
        L1bf:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L14b
        L1c7:
            r7 = r18
        L1c9:
            goto L6d
        L1cd:
            r10 = r6[r9]
            goto L125
        L1d3:
            r7 = r12
            goto L113
        L1d8:
            java.lang.object r2 = r0.L$0
            goto L259
        L1de:
            long r14 = r14 & r7
            goto L20e
        L1e3:
            goto L121
        L1e6:
            r3 = 0
            goto L118
        L1eb:
            r14 = r12[r14]
            goto La
        L1f1:
            long r12 = r12 & r10
            goto L22
        L1f6:
            int r2 = r2 + r5
            goto L108
        L1fb:
            int r14 = r14 + r2
            goto L1eb
        L200:
            r6 = r12
            goto L7f
        L205:
            if (r14 < 0) goto L20a
            goto L249
        L20a:
            goto Lcf
        L20e:
            r16 = 128(0x80, double:6.3E-322)
            goto L133
        L214:
            int r8 = r6.length
            goto L242
        L219:
            java.lang.object[] r7 = r6.elements
            goto L9d
        L21f:
            r0.L$2 = r11
            goto L23c
        L225:
            kotlin.sequences.SequenceScope r13 = (kotlin.sequences.SequenceScope) r13
            goto L178
        L22b:
            androidx.collection.ScatterHashSet<E> r6 = r0.this$0
            goto L219
        L231:
            int r0 = r0 % r1
            goto Lf5
        L237:
            throw r0
        L238:
            goto L89
        L23c:
            r0.I$0 = r10
            goto L172
        L242:
            int r8 = r8 + (-2)
            goto L76
        L248:
            return r1
        L249:
            goto Lc4
        L24d:
            int r6 = r0.I$2
            goto L3f
        L253:
            int r12 = r12 >>> 31
            goto L16c
        L259:
            kotlin.sequences.SequenceScope r2 = (kotlin.sequences.SequenceScope) r2
            goto L22b
        L25f:
            int r2 = r0.I$3
            goto L24d
    }
}

