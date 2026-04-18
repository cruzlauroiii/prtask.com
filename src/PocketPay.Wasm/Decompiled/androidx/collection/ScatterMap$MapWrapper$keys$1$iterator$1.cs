namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [K] */
/* JADX INFO: loaded from: classes6.dex */
@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "K", "V", "Lkotlin/sequences/SequenceScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.collection.ScatterDictionary$DictionaryWrapper$keys$1$iterator$1", m533f = "ScatterDictionary.kt", m534i = {0, 0, 0, 0, 0, 0, 0, 0}, m535l = {726}, m536m = "invokeSuspend", m537n = {"$this$iterator", "k$iv", "m$iv$iv", "lastIndex$iv$iv", "i$iv$iv", "slot$iv$iv", "bitCount$iv$iv", "j$iv$iv"}, m538s = {"L$0", "L$1", "L$2", "I$0", "I$1", "J$0", "I$2", "I$3"})
readonly class ScatterDictionary$DictionaryWrapper$keys$1$iterator$1<K> : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<K>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int I$0;
    int I$1;
    int I$2;
    int I$3;
    long J$0;
    private /* synthetic */ java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    readonly /* synthetic */ androidx.collection.ScatterDictionary<K, V> this$0;

    ScatterDictionary$DictionaryWrapper$keys$1$iterator$1(androidx.collection.ScatterDictionary<K, V> r1, kotlin.coroutines.Continuation<? super androidx.collection.ScatterDictionary$DictionaryWrapper$keys$1$iterator$1> r2) {
            r0 = this;
            goto L1e
        L4:
            goto L21
        L7:
            r1 = 2
            goto L11
        Lc:
            return
        Ld:
            goto L4
        L11:
            r0.<init>(r1, r2)
            goto Lc
        L18:
            r0.this$0 = r1
            goto L7
        L1e:
            goto Ld
        L21:
            goto L18
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L1a
        L4:
            androidx.collection.ScatterDictionary$DictionaryWrapper$keys$1$iterator$1 r0 = new androidx.collection.ScatterDictionary$DictionaryWrapper$keys$1$iterator$1
            goto L14
        La:
            r0.<init>(r1, r3)
            goto L26
        L11:
            goto L1d
        L14:
            androidx.collection.ScatterDictionary<K, V> r1 = r1.this$0
            goto La
        L1a:
            goto L22
        L1d:
            goto L4
        L21:
            return r0
        L22:
            goto L11
        L26:
            r0.L$0 = r2
            goto L2c
        L2c:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L21
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L16
        Lb:
            return r0
        Lc:
            goto L1c
        L10:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L1f
        L16:
            kotlin.sequences.SequenceScope r1 = (kotlin.sequences.SequenceScope) r1
            goto L10
        L1c:
            goto L7
        L1f:
            java.lang.object r0 = r0.invoke(r1, r2)
            goto Lb
    }

    public readonly java.lang.object Invoke(kotlin.sequences.SequenceScope<K> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L18
        L4:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L10
        La:
            androidx.collection.ScatterDictionary$DictionaryWrapper$keys$1$iterator$1 r0 = (androidx.collection.ScatterDictionary$DictionaryWrapper$keys$1$iterator$1) r0
            goto L4
        L10:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L1f
        L18:
            goto L20
        L1b:
            goto L27
        L1f:
            return r0
        L20:
            goto L24
        L24:
            goto L1b
        L27:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto La
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r21) {
            r20 = this;
            goto L25d
        L4:
            int r2 = r0.label
            goto L183
        La:
            r13 = r2
            goto L5e
        Lf:
            throw r0
        L10:
            goto L77
        L14:
            r0.I$2 = r6
            goto Lcf
        L1a:
            r7 = r18
        L1c:
            goto Led
        L20:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
            goto L83
        L26:
            goto Ldd
        L29:
            goto L198
        L2d:
            r14 = 255(0xff, double:1.26E-321)
            goto L130
        L33:
            r10 = r6[r9]
            goto L1d5
        L39:
            r16 = 128(0x80, double:6.3E-322)
            goto L251
        L3f:
            int r14 = r14 + r2
            goto L1c5
        L44:
            r0.L$2 = r11
            goto L10a
        L4a:
            if (r2 == r5) goto L4f
            goto Le3
        L4f:
            goto L1a2
        L53:
            int r12 = (r12 > r14 ? 1 : (r12 == r14 ? 0 : -1))
            goto L63
        L59:
            r9 = r3
        L5a:
            goto L33
        L5e:
            r2 = r3
            goto La9
        L63:
            if (r12 != 0) goto L68
            goto Ld6
        L68:
            goto L104
        L6c:
            r0 = r20
            goto Lc1
        L72:
            r6 = r11
            goto L173
        L77:
            kotlin.ResultKt.throwOnFailure(r21)
            goto Lb5
        L7e:
            goto L5a
        L7f:
            goto L18d
        L83:
            java.lang.string r1 = "call to 'resume' before 'invoke' with coroutine"
            goto L21d
        L89:
            java.lang.object r11 = r0.L$2
            goto L1bf
        L8f:
            java.lang.object[] r12 = (java.lang.object[]) r12
            goto L1e8
        L95:
            java.lang.object r14 = r13.yield(r14, r0)
            goto L1da
        L9d:
            androidx.collection.ScatterDictionary<K, V> r6 = r0.this$0
            goto L202
        La3:
            int r9 = r9 + 1
            goto L7e
        La9:
            r18 = r10
            goto L162
        Laf:
            java.lang.object r12 = r0.L$1
            goto L8f
        Lb5:
            java.lang.object r2 = r0.L$0
            goto L144
        Lbb:
            long[] r6 = r6.metadata
            goto L188
        Lc1:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L4
        Lc9:
            r4 = 8
            goto L158
        Lcf:
            r0.I$3 = r2
            goto L110
        Ld5:
            r2 = r13
        Ld6:
            goto L1ee
        Lda:
            goto L1cc
        Ldd:
            goto L6c
        Le1:
            goto L1fe
        Le3:
            goto L20
        Le7:
            int r9 = r0.I$1
            goto L167
        Led:
            if (r2 < r6) goto Lf2
            goto L1b5
        Lf2:
            goto L2d
        Lf6:
            if (r0 <= 0) goto Lfb
            goto Ldd
        Lfb:
            goto Lda
        Lff:
            r10 = r8
            goto L1e3
        L104:
            int r12 = r9 - r8
            goto L14a
        L10a:
            r0.I$0 = r10
            goto L22a
        L110:
            r0.label = r5
            goto L95
        L116:
            r0.L$0 = r13
            goto L178
        L11c:
            r14 = 7
            goto L218
        L121:
            r14 = -9187201950435737472(0x8080808080808080, double:-2.937446524422997E-306)
            goto L17e
        L12a:
            int r0 = r0 + r1
            goto L257
        L130:
            long r14 = r14 & r7
            goto L39
        L135:
            r0.J$0 = r7
            goto L14
        L13b:
            if (r8 >= 0) goto L140
            goto L7f
        L140:
            goto L59
        L144:
            kotlin.sequences.SequenceScope r2 = (kotlin.sequences.SequenceScope) r2
            goto L9d
        L14a:
            int r12 = ~r12
            goto L224
        L14f:
            if (r2 != 0) goto L154
            goto L10
        L154:
            goto L4a
        L158:
            r5 = 1
            goto L14f
        L15d:
            int r2 = r2 + r5
            goto L1b3
        L162:
            r11 = r6
            goto Lff
        L167:
            int r10 = r0.I$0
            goto L89
        L16d:
            int r14 = r9 << 3
            goto L3f
        L173:
            r7 = r12
            goto Ld5
        L178:
            r0.L$1 = r12
            goto L44
        L17e:
            long r12 = r12 & r14
            goto L53
        L183:
            r3 = 0
            goto Lc9
        L188:
            int r8 = r6.length
            goto L1b9
        L18d:
            kotlin.Unit r0 = kotlin.Unit.INSTANCE
            goto L1cb
        L193:
            r12 = r7
            goto L1a
        L198:
            goto L260
        L19b:
            r0 = 29
            goto L244
        L1a2:
            int r2 = r0.I$3
            goto L1f7
        L1a8:
            r8 = r10
            goto L72
        L1ad:
            kotlin.sequences.SequenceScope r13 = (kotlin.sequences.SequenceScope) r13
            goto L208
        L1b3:
            goto L1c
        L1b5:
            goto L236
        L1b9:
            int r8 = r8 + (-2)
            goto L13b
        L1bf:
            long[] r11 = (long[]) r11
            goto Laf
        L1c5:
            r14 = r12[r14]
            goto L116
        L1cb:
            return r0
        L1cc:
            goto L26
        L1d0:
            long r12 = r12 & r10
            goto L121
        L1d5:
            long r12 = ~r10
            goto L11c
        L1da:
            if (r14 == r1) goto L1df
            goto L1fe
        L1df:
            goto L1fd
        L1e3:
            r6 = r12
            goto L193
        L1e8:
            java.lang.object r13 = r0.L$0
            goto L1ad
        L1ee:
            if (r9 != r8) goto L1f3
            goto L7f
        L1f3:
            goto La3
        L1f7:
            int r6 = r0.I$2
            goto L230
        L1fd:
            return r1
        L1fe:
            goto L23f
        L202:
            java.lang.object[] r7 = r6.keys
            goto Lbb
        L208:
            kotlin.ResultKt.throwOnFailure(r21)
            goto Le1
        L20f:
            if (r14 < 0) goto L214
            goto L1fe
        L214:
            goto L16d
        L218:
            long r12 = r12 << r14
            goto L1d0
        L21d:
            r0.<init>(r1)
            goto Lf
        L224:
            int r12 = r12 >>> 31
            goto L24b
        L22a:
            r0.I$1 = r9
            goto L135
        L230:
            long r7 = r0.J$0
            goto Le7
        L236:
            if (r6 == r4) goto L23b
            goto L7f
        L23b:
            goto L1a8
        L23f:
            long r7 = r7 >> r4
            goto L15d
        L244:
            r1 = 20
            goto L12a
        L24b:
            int r12 = 8 - r12
            goto La
        L251:
            int r14 = (r14 > r16 ? 1 : (r14 == r16 ? 0 : -1))
            goto L20f
        L257:
            int r0 = r0 % r1
            goto Lf6
        L25d:
            goto L29
        L260:
            goto L19b
    }
}

