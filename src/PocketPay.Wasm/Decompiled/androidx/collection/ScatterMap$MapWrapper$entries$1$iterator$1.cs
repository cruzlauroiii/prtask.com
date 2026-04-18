namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [V, K] */
/* JADX INFO: loaded from: classes6.dex */
@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010&\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00030\u00050\u0004H\u008a@"}, d2 = {"<anonymous>", "", "K", "V", "Lkotlin/sequences/SequenceScope;", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.collection.ScatterDictionary$DictionaryWrapper$entries$1$iterator$1", m533f = "ScatterDictionary.kt", m534i = {0, 0, 0, 0, 0, 0, 0}, m535l = {701}, m536m = "invokeSuspend", m537n = {"$this$iterator", "m$iv", "lastIndex$iv", "i$iv", "slot$iv", "bitCount$iv", "j$iv"}, m538s = {"L$0", "L$2", "I$0", "I$1", "J$0", "I$2", "I$3"})
readonly class ScatterDictionary$DictionaryWrapper$entries$1$iterator$1<K, V> : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<? super java.util.Dictionary.Entry<? : K, ? : V>>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
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

    ScatterDictionary$DictionaryWrapper$entries$1$iterator$1(androidx.collection.ScatterDictionary<K, V> r1, kotlin.coroutines.Continuation<? super androidx.collection.ScatterDictionary$DictionaryWrapper$entries$1$iterator$1> r2) {
            r0 = this;
            goto L9
        L4:
            r1 = 2
            goto L10
        L9:
            goto L18
        Lc:
            goto L1f
        L10:
            r0.<init>(r1, r2)
            goto L17
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto Lc
        L1f:
            r0.this$0 = r1
            goto L4
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto La
        L4:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L27
        La:
            goto L28
        Ld:
            goto L1a
        L11:
            goto Ld
        L14:
            r0.L$0 = r2
            goto L4
        L1a:
            androidx.collection.ScatterDictionary$DictionaryWrapper$entries$1$iterator$1 r0 = new androidx.collection.ScatterDictionary$DictionaryWrapper$entries$1$iterator$1
            goto L2c
        L20:
            r0.<init>(r1, r3)
            goto L14
        L27:
            return r0
        L28:
            goto L11
        L2c:
            androidx.collection.ScatterDictionary<K, V> r1 = r1.this$0
            goto L20
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L9
        L4:
            return r0
        L5:
            goto L1e
        L9:
            goto L5
        Lc:
            goto L18
        L10:
            java.lang.object r0 = r0.invoke(r1, r2)
            goto L4
        L18:
            kotlin.sequences.SequenceScope r1 = (kotlin.sequences.SequenceScope) r1
            goto L21
        L1e:
            goto Lc
        L21:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L10
    }

    public readonly java.lang.object Invoke(kotlin.sequences.SequenceScope<? super java.util.Dictionary.Entry<? : K, ? : V>> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L28
        L4:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L22
        Lc:
            return r0
        Ld:
            goto L1f
        L11:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto Lc
        L19:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L11
        L1f:
            goto L2b
        L22:
            androidx.collection.ScatterDictionary$DictionaryWrapper$entries$1$iterator$1 r0 = (androidx.collection.ScatterDictionary$DictionaryWrapper$entries$1$iterator$1) r0
            goto L19
        L28:
            goto Ld
        L2b:
            goto L4
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r21) {
            r20 = this;
            goto Ld6
        L4:
            long r12 = r12 & r10
            goto Laf
        L9:
            goto L169
        Lb:
            goto L247
        Lf:
            if (r8 >= 0) goto L14
            goto Lcd
        L14:
            goto L196
        L18:
            throw r0
        L19:
            goto Ldd
        L1d:
            int r6 = r0.I$2
            goto L52
        L23:
            int r14 = r14 + r2
            goto L173
        L28:
            if (r9 != r8) goto L2d
            goto Lcd
        L2d:
            goto L1da
        L31:
            long r12 = ~r10
            goto L111
        L36:
            r2 = 0
            goto L256
        L3b:
            java.lang.object r13 = r0.L$0
            goto L224
        L41:
            r12 = r6
            goto Laa
        L46:
            r0.I$2 = r6
            goto L12f
        L4c:
            java.lang.object r2 = r0.L$0
            goto L271
        L52:
            long r7 = r0.J$0
            goto L129
        L58:
            int r2 = r0.label
            goto Le4
        L5e:
            r7 = r18
        L60:
            goto L11b
        L64:
            long r12 = r12 << r14
            goto L4
        L69:
            int r8 = r8 + (-2)
            goto Lf
        L6f:
            r0.L$0 = r13
            goto L1e0
        L75:
            long r14 = r14 & r7
            goto L16d
        L7a:
            r1 = 5
            goto L29a
        L81:
            r0.J$0 = r7
            goto L46
        L87:
            int r12 = r12 >>> 31
            goto L17f
        L8d:
            java.lang.object[] r3 = r12.keys
            goto L10b
        L93:
            if (r6 == r3) goto L98
            goto Lcd
        L98:
            goto L14e
        L9c:
            long r7 = r7 >> r17
            goto L28f
        La2:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L58
        Laa:
            r6 = r13
            goto Lb8
        Laf:
            r14 = -9187201950435737472(0x8080808080808080, double:-2.937446524422997E-306)
            goto L149
        Lb8:
            r13 = r2
            goto L36
        Lbd:
            goto L28b
        Lc0:
            goto L253
        Lc4:
            r0.<init>(r1)
            goto L18
        Lcb:
            goto L197
        Lcd:
            goto L1bc
        Ld1:
            int r8 = r7.length
            goto L69
        Ld6:
            goto Lc0
        Ld9:
            goto L104
        Ldd:
            kotlin.ResultKt.throwOnFailure(r21)
            goto L4c
        Le4:
            r4 = 8
            goto L23c
        Lea:
            goto L60
        Lec:
            goto L219
        Lf0:
            r3 = r4
        Lf1:
            goto L28
        Lf5:
            r13 = r12
            goto L41
        Lfa:
            r6 = r12
            goto L144
        Lff:
            return r0
        L100:
            goto Lbd
        L104:
            r0 = 20
            goto L7a
        L10b:
            r3 = r3[r14]
            goto L236
        L111:
            r14 = 7
            goto L64
        L116:
            int r12 = ~r12
            goto L87
        L11b:
            if (r2 < r6) goto L120
            goto Lec
        L120:
            goto L1ec
        L124:
            r11 = r7
            goto L185
        L129:
            int r9 = r0.I$1
            goto L20d
        L12f:
            r0.I$3 = r2
            goto L24d
        L135:
            androidx.collection.ScatterDictionary r12 = (androidx.collection.ScatterDictionary) r12
            goto L3b
        L13b:
            if (r2 == r5) goto L140
            goto Lb
        L140:
            goto L213
        L144:
            r2 = r13
            goto L21e
        L149:
            long r12 = r12 & r14
            goto L230
        L14e:
            r8 = r10
            goto L27d
        L153:
            if (r14 < 0) goto L158
            goto L169
        L158:
            goto L26b
        L15c:
            r10 = r7[r9]
            goto L31
        L162:
            int r0 = r0 % r1
            goto L1ff
        L168:
            return r1
        L169:
            goto L1aa
        L16d:
            r16 = 128(0x80, double:6.3E-322)
            goto L1b0
        L173:
            androidx.collection.DictionaryEntry r15 = new androidx.collection.DictionaryEntry
            goto L8d
        L179:
            java.lang.object r11 = r0.L$2
            goto L241
        L17f:
            int r12 = 8 - r12
            goto Lf5
        L185:
            r10 = r8
            goto L5e
        L18a:
            int r12 = r9 - r8
            goto L116
        L190:
            long[] r7 = r6.metadata
            goto Ld1
        L196:
            r9 = 0
        L197:
            goto L15c
        L19b:
            if (r12 != 0) goto L1a0
            goto L220
        L1a0:
            goto L18a
        L1a4:
            r0 = r20
            goto La2
        L1aa:
            r17 = r4
        L1ac:
            goto L9c
        L1b0:
            int r14 = (r14 > r16 ? 1 : (r14 == r16 ? 0 : -1))
            goto L153
        L1b6:
            r4 = r17
            goto Lea
        L1bc:
            kotlin.Unit r0 = kotlin.Unit.INSTANCE
            goto Lff
        L1c2:
            if (r3 == r1) goto L1c7
            goto L1ac
        L1c7:
            goto L168
        L1cb:
            r15.<init>(r3, r4)
            goto L6f
        L1d2:
            java.lang.object r3 = r13.yield(r15, r0)
            goto L1c2
        L1da:
            int r9 = r9 + 1
            goto L208
        L1e0:
            r0.L$1 = r12
            goto L277
        L1e6:
            r0.I$1 = r9
            goto L81
        L1ec:
            r14 = 255(0xff, double:1.26E-321)
            goto L75
        L1f2:
            java.lang.object r12 = r0.L$1
            goto L135
        L1f8:
            kotlin.ResultKt.throwOnFailure(r21)
            goto L9
        L1ff:
            if (r0 <= 0) goto L204
            goto L28b
        L204:
            goto L288
        L208:
            r4 = r3
            goto Lcb
        L20d:
            int r10 = r0.I$0
            goto L179
        L213:
            int r2 = r0.I$3
            goto L1d
        L219:
            r3 = r4
            goto L93
        L21e:
            goto Lf1
        L220:
            goto Lf0
        L224:
            kotlin.sequences.SequenceScope r13 = (kotlin.sequences.SequenceScope) r13
            goto L1f8
        L22a:
            java.lang.object[] r4 = r12.values
            goto L265
        L230:
            int r12 = (r12 > r14 ? 1 : (r12 == r14 ? 0 : -1))
            goto L19b
        L236:
            r17 = r4
            goto L22a
        L23c:
            r5 = 1
            goto L25c
        L241:
            long[] r11 = (long[]) r11
            goto L1f2
        L247:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
            goto L294
        L24d:
            r0.label = r5
            goto L1d2
        L253:
            goto Ld9
        L256:
            r18 = r10
            goto L124
        L25c:
            if (r2 != 0) goto L261
            goto L19
        L261:
            goto L13b
        L265:
            r4 = r4[r14]
            goto L1cb
        L26b:
            int r14 = r9 << 3
            goto L23
        L271:
            kotlin.sequences.SequenceScope r2 = (kotlin.sequences.SequenceScope) r2
            goto L2a0
        L277:
            r0.L$2 = r11
            goto L282
        L27d:
            r7 = r11
            goto Lfa
        L282:
            r0.I$0 = r10
            goto L1e6
        L288:
            goto L100
        L28b:
            goto L1a4
        L28f:
            int r2 = r2 + r5
            goto L1b6
        L294:
            java.lang.string r1 = "call to 'resume' before 'invoke' with coroutine"
            goto Lc4
        L29a:
            int r0 = r0 + r1
            goto L162
        L2a0:
            androidx.collection.ScatterDictionary<K, V> r6 = r0.this$0
            goto L190
    }
}

