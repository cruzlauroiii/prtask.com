namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes6.dex */
@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\b\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u00020\u00050\u0004H\u008a@"}, d2 = {"<anonymous>", "", "K", "V", "Lkotlin/sequences/SequenceScope;", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$keys$1$iterator$1$iterator$1", m533f = "ScatterDictionary.kt", m534i = {0, 0, 0, 0, 0, 0, 0}, m535l = {1431}, m536m = "invokeSuspend", m537n = {"$this$iterator", "m$iv", "lastIndex$iv", "i$iv", "slot$iv", "bitCount$iv", "j$iv"}, m538s = {"L$0", "L$1", "I$0", "I$1", "J$0", "I$2", "I$3"})
readonly class MutableScatterDictionary$MutableDictionaryWrapper$keys$1$iterator$1$iterator$1 : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<java.lang.int>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int I$0;
    int I$1;
    int I$2;
    int I$3;
    long J$0;
    private /* synthetic */ java.lang.object L$0;
    java.lang.object L$1;
    int label;
    readonly /* synthetic */ androidx.collection.MutableScatterDictionary<K, V> this$0;

    MutableScatterDictionary$MutableDictionaryWrapper$keys$1$iterator$1$iterator$1(androidx.collection.MutableScatterDictionary<K, V> r1, kotlin.coroutines.Continuation<? super androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$keys$1$iterator$1$iterator$1> r2) {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L21
        La:
            goto L1a
        Le:
            r0.<init>(r1, r2)
            goto L20
        L15:
            r1 = 2
            goto Le
        L1a:
            r0.this$0 = r1
            goto L15
        L20:
            return
        L21:
            goto L4
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L4
        L4:
            goto L21
        L7:
            goto L1a
        Lb:
            r0.L$0 = r2
            goto L2c
        L11:
            androidx.collection.MutableScatterDictionary<K, V> r1 = r1.this$0
            goto L25
        L17:
            goto L7
        L1a:
            androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$keys$1$iterator$1$iterator$1 r0 = new androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$keys$1$iterator$1$iterator$1
            goto L11
        L20:
            return r0
        L21:
            goto L17
        L25:
            r0.<init>(r1, r3)
            goto Lb
        L2c:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L20
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlin.sequences.SequenceScope<java.lang.int> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L4
        L4:
            goto L12
        L7:
            goto L21
        Lb:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L16
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
            kotlin.sequences.SequenceScope r1 = (kotlin.sequences.SequenceScope) r1
            goto Lb
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlin.sequences.SequenceScope<java.lang.int> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L21
        L10:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L4
        L18:
            goto Lc
        L1b:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L10
        L21:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L29
        L29:
            androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$keys$1$iterator$1$iterator$1 r0 = (androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$keys$1$iterator$1$iterator$1) r0
            goto L1b
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r20) {
            r19 = this;
            goto Lc7
        L4:
            int r11 = ~r11
            goto L7b
        L9:
            kotlin.sequences.SequenceScope r2 = (kotlin.sequences.SequenceScope) r2
            goto L1d
        Lf:
            r2 = r12
        L10:
            goto L23e
        L14:
            if (r13 == r1) goto L19
            goto L181
        L19:
            goto L180
        L1d:
            androidx.collection.MutableScatterDictionary<K, V> r6 = r0.this$0
            goto L8c
        L23:
            java.lang.object r11 = r0.L$1
            goto L231
        L29:
            r7 = r10
            goto L1dc
        L2e:
            r17 = r9
            goto L146
        L34:
            int r0 = r0 + r1
            goto L17a
        L3a:
            r8 = r9
            goto L29
        L3f:
            int r13 = r9 << 3
            goto L21d
        L45:
            r12 = r2
            goto L1ae
        L4a:
            long r11 = r11 & r9
            goto L1a5
        L4f:
            int r11 = 8 - r11
            goto Ldb
        L55:
            if (r6 == r4) goto L5a
            goto L13d
        L5a:
            goto L3a
        L5e:
            r0.I$0 = r10
            goto L1c0
        L64:
            java.lang.string r1 = "call to 'resume' before 'invoke' with coroutine"
            goto L162
        L6a:
            r9 = r8
            goto L131
        L6f:
            java.lang.object r12 = r0.L$0
            goto Lea
        L75:
            r0.L$1 = r11
            goto L5e
        L7b:
            int r11 = r11 >>> 31
            goto L4f
        L81:
            r13 = 7
            goto Ld6
        L86:
            goto L133
        L88:
            goto L55
        L8c:
            androidx.collection.ScatterDictionary r6 = (androidx.collection.ScatterDictionary) r6
            goto L1fa
        L92:
            r0 = 30
            goto L99
        L99:
            r1 = 16
            goto L34
        La0:
            int r7 = r6.length
            goto L253
        La5:
            return r0
        La6:
            goto L1b9
        Laa:
            r0.J$0 = r7
            goto Lf0
        Lb0:
            kotlin.Unit r0 = kotlin.Unit.INSTANCE
            goto La5
        Lb6:
            goto L181
        Lb8:
            goto L24d
        Lbc:
            r11 = r6
            goto L206
        Lc1:
            java.lang.object r2 = r0.L$0
            goto L9
        Lc7:
            goto L1bc
        Lca:
            goto L92
        Lce:
            java.lang.object r13 = r12.yield(r13, r0)
            goto L14
        Ld6:
            long r11 = r11 << r13
            goto L4a
        Ldb:
            r12 = r11
            goto Lbc
        Le0:
            long r11 = r11 & r13
            goto L200
        Le5:
            r8 = r3
        Le6:
            goto L18c
        Lea:
            kotlin.sequences.SequenceScope r12 = (kotlin.sequences.SequenceScope) r12
            goto L185
        Lf0:
            r0.I$2 = r6
            goto L120
        Lf6:
            r0.label = r5
            goto Lce
        Lfc:
            int r11 = r8 - r7
            goto L4
        L102:
            int r6 = r0.I$2
            goto L10e
        L108:
            r13 = 255(0xff, double:1.26E-321)
            goto L137
        L10e:
            long r7 = r0.J$0
            goto L247
        L114:
            goto Lca
        L117:
            if (r7 >= 0) goto L11c
            goto L13d
        L11c:
            goto Le5
        L120:
            r0.I$3 = r2
            goto Lf6
        L126:
            r5 = 1
            goto L154
        L12b:
            r0.L$0 = r12
            goto L75
        L131:
            r7 = r17
        L133:
            goto L222
        L137:
            long r13 = r13 & r7
            goto L19f
        L13c:
            goto Le6
        L13d:
            goto Lb0
        L141:
            r3 = 0
            goto L169
        L146:
            r10 = r7
            goto L6a
        L14b:
            if (r2 == r5) goto L150
            goto Lb8
        L150:
            goto L1e7
        L154:
            if (r2 != 0) goto L159
            goto L193
        L159:
            goto L14b
        L15d:
            int r2 = r2 + r5
            goto L86
        L162:
            r0.<init>(r1)
            goto L192
        L169:
            r4 = 8
            goto L126
        L16f:
            int r10 = r0.I$0
            goto L23
        L175:
            long r7 = r7 >> r4
            goto L15d
        L17a:
            int r0 = r0 % r1
            goto L214
        L180:
            return r1
        L181:
            goto L175
        L185:
            kotlin.ResultKt.throwOnFailure(r20)
            goto Lb6
        L18c:
            r9 = r6[r8]
            goto L1c6
        L192:
            throw r0
        L193:
            goto L1f3
        L197:
            java.lang.int r13 = kotlin.coroutines.jvm.internal.Boxing.boxInt(r13)
            goto L12b
        L19f:
            r15 = 128(0x80, double:6.3E-322)
            goto L22b
        L1a5:
            r13 = -9187201950435737472(0x8080808080808080, double:-2.937446524422997E-306)
            goto Le0
        L1ae:
            r2 = r3
            goto L2e
        L1b3:
            int r8 = r8 + 1
            goto L13c
        L1b9:
            goto L23a
        L1bc:
            goto L114
        L1c0:
            r0.I$1 = r9
            goto Laa
        L1c6:
            long r11 = ~r9
            goto L81
        L1cb:
            if (r11 != 0) goto L1d0
            goto L10
        L1d0:
            goto Lfc
        L1d4:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L1e1
        L1dc:
            r6 = r11
            goto Lf
        L1e1:
            int r2 = r0.label
            goto L141
        L1e7:
            int r2 = r0.I$3
            goto L102
        L1ed:
            r0 = r19
            goto L1d4
        L1f3:
            kotlin.ResultKt.throwOnFailure(r20)
            goto Lc1
        L1fa:
            long[] r6 = r6.metadata
            goto La0
        L200:
            int r11 = (r11 > r13 ? 1 : (r11 == r13 ? 0 : -1))
            goto L1cb
        L206:
            r6 = r12
            goto L45
        L20b:
            if (r13 < 0) goto L210
            goto L181
        L210:
            goto L3f
        L214:
            if (r0 <= 0) goto L219
            goto L23a
        L219:
            goto L237
        L21d:
            int r13 = r13 + r2
            goto L197
        L222:
            if (r2 < r6) goto L227
            goto L88
        L227:
            goto L108
        L22b:
            int r13 = (r13 > r15 ? 1 : (r13 == r15 ? 0 : -1))
            goto L20b
        L231:
            long[] r11 = (long[]) r11
            goto L6f
        L237:
            goto La6
        L23a:
            goto L1ed
        L23e:
            if (r8 != r7) goto L243
            goto L13d
        L243:
            goto L1b3
        L247:
            int r9 = r0.I$1
            goto L16f
        L24d:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
            goto L64
        L253:
            int r7 = r7 + (-2)
            goto L117
    }
}

