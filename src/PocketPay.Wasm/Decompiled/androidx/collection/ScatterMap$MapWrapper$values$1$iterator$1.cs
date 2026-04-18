namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [V] */
/* JADX INFO: loaded from: classes6.dex */
@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u0004H\u008a@"}, d2 = {"<anonymous>", "", "K", "V", "Lkotlin/sequences/SequenceScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.collection.ScatterDictionary$DictionaryWrapper$values$1$iterator$1", m533f = "ScatterDictionary.kt", m534i = {0, 0, 0, 0, 0, 0, 0, 0}, m535l = {744}, m536m = "invokeSuspend", m537n = {"$this$iterator", "v$iv", "m$iv$iv", "lastIndex$iv$iv", "i$iv$iv", "slot$iv$iv", "bitCount$iv$iv", "j$iv$iv"}, m538s = {"L$0", "L$1", "L$2", "I$0", "I$1", "J$0", "I$2", "I$3"})
readonly class ScatterDictionary$DictionaryWrapper$values$1$iterator$1<V> : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<V>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
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

    ScatterDictionary$DictionaryWrapper$values$1$iterator$1(androidx.collection.ScatterDictionary<K, V> r1, kotlin.coroutines.Continuation<? super androidx.collection.ScatterDictionary$DictionaryWrapper$values$1$iterator$1> r2) {
            r0 = this;
            goto L19
        L4:
            goto L1c
        L7:
            r0.<init>(r1, r2)
            goto L14
        Le:
            r0.this$0 = r1
            goto L20
        L14:
            return
        L15:
            goto L4
        L19:
            goto L15
        L1c:
            goto Le
        L20:
            r1 = 2
            goto L7
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L16
        L4:
            return r0
        L5:
            goto L29
        L9:
            r0.<init>(r1, r3)
            goto L2c
        L10:
            androidx.collection.ScatterDictionary<K, V> r1 = r1.this$0
            goto L9
        L16:
            goto L5
        L19:
            goto L23
        L1d:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L4
        L23:
            androidx.collection.ScatterDictionary$DictionaryWrapper$values$1$iterator$1 r0 = new androidx.collection.ScatterDictionary$DictionaryWrapper$values$1$iterator$1
            goto L10
        L29:
            goto L19
        L2c:
            r0.L$0 = r2
            goto L1d
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto La
        L4:
            kotlin.sequences.SequenceScope r1 = (kotlin.sequences.SequenceScope) r1
            goto L21
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto Ld
        L19:
            java.lang.object r0 = r0.invoke(r1, r2)
            goto L11
        L21:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L19
    }

    public readonly java.lang.object Invoke(kotlin.sequences.SequenceScope<V> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L1b
        L4:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L10
        La:
            androidx.collection.ScatterDictionary$DictionaryWrapper$values$1$iterator$1 r0 = (androidx.collection.ScatterDictionary$DictionaryWrapper$values$1$iterator$1) r0
            goto L4
        L10:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L22
        L18:
            goto L1e
        L1b:
            goto L23
        L1e:
            goto L27
        L22:
            return r0
        L23:
            goto L18
        L27:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto La
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r21) {
            r20 = this;
            goto L1e7
        L4:
            r6 = r12
            goto L1b9
        L9:
            r0.I$0 = r10
            goto L8c
        Lf:
            if (r0 <= 0) goto L14
            goto L15e
        L14:
            goto L15b
        L18:
            int r14 = r14 + r2
            goto L23b
        L1d:
            if (r14 < 0) goto L22
            goto L22e
        L22:
            goto L120
        L26:
            r5 = 1
            goto L92
        L2b:
            r2 = r13
        L2c:
            goto L179
        L30:
            kotlin.Unit r0 = kotlin.Unit.INSTANCE
            goto L215
        L36:
            java.lang.string r1 = "call to 'resume' before 'invoke' with coroutine"
            goto L19c
        L3c:
            int r12 = (r12 > r14 ? 1 : (r12 == r14 ? 0 : -1))
            goto L193
        L42:
            int r8 = r6.length
            goto L6d
        L47:
            int r6 = r0.I$2
            goto Lde
        L4d:
            r11 = r6
            goto L174
        L52:
            r1 = 21
            goto L16e
        L59:
            long r12 = r12 & r14
            goto L3c
        L5e:
            java.lang.object[] r12 = (java.lang.object[]) r12
            goto Lb1
        L64:
            r4 = 8
            goto L26
        L6a:
            goto L1ea
        L6d:
            int r8 = r8 + (-2)
            goto Lea
        L73:
            r0 = 16
            goto L52
        L7a:
            int r12 = 8 - r12
            goto L20a
        L80:
            r16 = 128(0x80, double:6.3E-322)
            goto L1e1
        L86:
            java.lang.object r11 = r0.L$2
            goto L1ff
        L8c:
            r0.I$1 = r9
            goto L168
        L92:
            if (r2 != 0) goto L97
            goto L1cb
        L97:
            goto L117
        L9b:
            r7 = r18
        L9d:
            goto Lc4
        La1:
            long r12 = r12 & r10
            goto L126
        La6:
            int r12 = r9 - r8
            goto Lff
        Lac:
            long r12 = r12 << r14
            goto La1
        Lb1:
            java.lang.object r13 = r0.L$0
            goto L111
        Lb7:
            java.lang.object r14 = r13.yield(r14, r0)
            goto L232
        Lbf:
            r7 = r12
            goto L2b
        Lc4:
            if (r2 < r6) goto Lc9
            goto L249
        Lc9:
            goto L1d5
        Lcd:
            int r12 = r12 >>> 31
            goto L7a
        Ld3:
            java.lang.object r12 = r0.L$1
            goto L5e
        Ld9:
            long r7 = r7 >> r4
            goto L156
        Lde:
            long r7 = r0.J$0
            goto L162
        Le4:
            androidx.collection.ScatterDictionary<K, V> r6 = r0.this$0
            goto L1be
        Lea:
            if (r8 >= 0) goto Lef
            goto L137
        Lef:
            goto L1b4
        Lf3:
            r0.label = r5
            goto Lb7
        Lf9:
            r0 = r20
            goto L24d
        Lff:
            int r12 = ~r12
            goto Lcd
        L104:
            kotlin.ResultKt.throwOnFailure(r21)
            goto L187
        L10b:
            r0.L$2 = r11
            goto L9
        L111:
            kotlin.sequences.SequenceScope r13 = (kotlin.sequences.SequenceScope) r13
            goto L12f
        L117:
            if (r2 == r5) goto L11c
            goto L1ab
        L11c:
            goto L220
        L120:
            int r14 = r9 << 3
            goto L18
        L126:
            r14 = -9187201950435737472(0x8080808080808080, double:-2.937446524422997E-306)
            goto L59
        L12f:
            kotlin.ResultKt.throwOnFailure(r21)
            goto L1a9
        L136:
            goto L1b5
        L137:
            goto L30
        L13b:
            int r0 = r0 % r1
            goto Lf
        L141:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
            goto L36
        L147:
            if (r6 == r4) goto L14c
            goto L137
        L14c:
            goto L1f4
        L150:
            kotlin.sequences.SequenceScope r2 = (kotlin.sequences.SequenceScope) r2
            goto Le4
        L156:
            int r2 = r2 + r5
            goto L247
        L15b:
            goto L216
        L15e:
            goto Lf9
        L162:
            int r9 = r0.I$1
            goto L1c4
        L168:
            r0.J$0 = r7
            goto L1f9
        L16e:
            int r0 = r0 + r1
            goto L13b
        L174:
            r10 = r8
            goto L4
        L179:
            if (r9 != r8) goto L17e
            goto L137
        L17e:
            goto L1a3
        L182:
            r14 = 7
            goto Lac
        L187:
            java.lang.object r2 = r0.L$0
            goto L150
        L18d:
            int r2 = r0.label
            goto L205
        L193:
            if (r12 != 0) goto L198
            goto L2c
        L198:
            goto La6
        L19c:
            r0.<init>(r1)
            goto L1ca
        L1a3:
            int r9 = r9 + 1
            goto L136
        L1a9:
            goto L22e
        L1ab:
            goto L141
        L1af:
            long r12 = ~r10
            goto L182
        L1b4:
            r9 = r3
        L1b5:
            goto L1cf
        L1b9:
            r12 = r7
            goto L9b
        L1be:
            java.lang.object[] r7 = r6.values
            goto L20f
        L1c4:
            int r10 = r0.I$0
            goto L86
        L1ca:
            throw r0
        L1cb:
            goto L104
        L1cf:
            r10 = r6[r9]
            goto L1af
        L1d5:
            r14 = 255(0xff, double:1.26E-321)
            goto L255
        L1db:
            r18 = r10
            goto L4d
        L1e1:
            int r14 = (r14 > r16 ? 1 : (r14 == r16 ? 0 : -1))
            goto L1d
        L1e7:
            goto L229
        L1ea:
            goto L73
        L1ee:
            r0.L$1 = r12
            goto L10b
        L1f4:
            r8 = r10
            goto L25f
        L1f9:
            r0.I$2 = r6
            goto L21a
        L1ff:
            long[] r11 = (long[]) r11
            goto Ld3
        L205:
            r3 = 0
            goto L64
        L20a:
            r13 = r2
            goto L25a
        L20f:
            long[] r6 = r6.metadata
            goto L42
        L215:
            return r0
        L216:
            goto L226
        L21a:
            r0.I$3 = r2
            goto Lf3
        L220:
            int r2 = r0.I$3
            goto L47
        L226:
            goto L15e
        L229:
            goto L6a
        L22d:
            return r1
        L22e:
            goto Ld9
        L232:
            if (r14 == r1) goto L237
            goto L22e
        L237:
            goto L22d
        L23b:
            r14 = r12[r14]
            goto L241
        L241:
            r0.L$0 = r13
            goto L1ee
        L247:
            goto L9d
        L249:
            goto L147
        L24d:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L18d
        L255:
            long r14 = r14 & r7
            goto L80
        L25a:
            r2 = r3
            goto L1db
        L25f:
            r6 = r11
            goto Lbf
    }
}

