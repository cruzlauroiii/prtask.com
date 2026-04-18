namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$values$1$iterator$1$iterator$1 */
/* JADX INFO: loaded from: classes6.dex */
@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\b\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u00020\u00050\u0004H\u008a@"}, d2 = {"<anonymous>", "", "K", "V", "Lkotlin/sequences/SequenceScope;", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$values$1$iterator$1$iterator$1", m533f = "ScatterDictionary.kt", m534i = {0, 0, 0, 0, 0, 0, 0}, m535l = {1511}, m536m = "invokeSuspend", m537n = {"$this$iterator", "m$iv", "lastIndex$iv", "i$iv", "slot$iv", "bitCount$iv", "j$iv"}, m538s = {"L$0", "L$1", "I$0", "I$1", "J$0", "I$2", "I$3"})
readonly class C0178x9ca97416 : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<java.lang.int>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int I$0;
    int I$1;
    int I$2;
    int I$3;
    long J$0;
    private /* synthetic */ java.lang.object L$0;
    java.lang.object L$1;
    int label;
    readonly /* synthetic */ androidx.collection.MutableScatterDictionary<K, V> this$0;

    C0178x9ca97416(androidx.collection.MutableScatterDictionary<K, V> r1, kotlin.coroutines.Continuation<androidx.collection.C0178x9ca97416> r2) {
            r0 = this;
            goto L15
        L4:
            r1 = 2
            goto Le
        L9:
            return
        La:
            goto L22
        Le:
            r0.<init>(r1, r2)
            goto L9
        L15:
            goto La
        L18:
            goto L1c
        L1c:
            r0.this$0 = r1
            goto L4
        L22:
            goto L18
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L25
        L4:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L14
        La:
            goto L28
        Ld:
            r0.<init>(r1, r3)
            goto L2c
        L14:
            return r0
        L15:
            goto La
        L19:
            androidx.collection.MutableScatterDictionary<K, V> r1 = r1.this$0
            goto Ld
        L1f:
            androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$values$1$iterator$1$iterator$1 r0 = new androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$values$1$iterator$1$iterator$1
            goto L19
        L25:
            goto L15
        L28:
            goto L1f
        L2c:
            r0.L$0 = r2
            goto L4
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlin.sequences.SequenceScope<java.lang.int> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L1d
        L4:
            return r0
        L5:
            goto L24
        L9:
            kotlin.sequences.SequenceScope r1 = (kotlin.sequences.SequenceScope) r1
            goto L17
        Lf:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto L4
        L17:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto Lf
        L1d:
            goto L5
        L20:
            goto L9
        L24:
            goto L20
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlin.sequences.SequenceScope<java.lang.int> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L20
        L4:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L18
        La:
            goto L23
        Ld:
            androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$values$1$iterator$1$iterator$1 r0 = (androidx.collection.C0178x9ca97416) r0
            goto L4
        L13:
            return r0
        L14:
            goto La
        L18:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L13
        L20:
            goto L14
        L23:
            goto L27
        L27:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto Ld
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r20) {
            r19 = this;
            goto L2f
        L4:
            r0.I$3 = r2
            goto L238
        La:
            r0.L$1 = r11
            goto L1f3
        L10:
            r5 = 1
            goto L12e
        L15:
            long r13 = r13 & r7
            goto L150
        L1a:
            r7 = r17
        L1c:
            goto L99
        L20:
            if (r8 != r7) goto L25
            goto Ld4
        L25:
            goto L104
        L29:
            java.lang.object r11 = r0.L$1
            goto L22d
        L2f:
            goto L164
        L32:
            goto L1d2
        L36:
            int r2 = r0.I$3
            goto L210
        L3c:
            if (r6 == r4) goto L41
            goto Ld4
        L41:
            goto L1e2
        L45:
            r4 = 8
            goto L10
        L4b:
            long r7 = r0.J$0
            goto L19f
        L51:
            java.lang.object r12 = r0.L$0
            goto L184
        L57:
            java.lang.object r13 = r12.yield(r13, r0)
            goto L1b6
        L5f:
            r17 = r9
            goto L85
        L65:
            long r11 = r11 & r9
            goto L1bf
        L6a:
            goto L1c
        L6b:
            goto L3c
        L6f:
            goto L32
        L72:
            goto La3
        L75:
            goto L79
        L79:
            r0 = r19
            goto L250
        L7f:
            java.lang.string r1 = "call to 'resume' before 'invoke' with coroutine"
            goto Lbd
        L85:
            r10 = r7
            goto Lee
        L8a:
            if (r2 == r5) goto L8f
            goto L218
        L8f:
            goto L36
        L93:
            int r13 = (r13 > r15 ? 1 : (r13 == r15 ? 0 : -1))
            goto L1f9
        L99:
            if (r2 < r6) goto L9e
            goto L6b
        L9e:
            goto Le3
        La2:
            return r0
        La3:
            goto L161
        La7:
            int r0 = r0 + r1
            goto L1a5
        Lad:
            return r1
        Lae:
            goto L119
        Lb2:
            r0.I$2 = r6
            goto L4
        Lb8:
            r6 = r12
            goto L195
        Lbd:
            r0.<init>(r1)
            goto L1ab
        Lc4:
            if (r0 <= 0) goto Lc9
            goto L75
        Lc9:
            goto L72
        Lcd:
            java.lang.object r2 = r0.L$0
            goto L137
        Ld3:
            goto Ld9
        Ld4:
            goto L168
        Ld8:
            r8 = r3
        Ld9:
            goto Ldd
        Ldd:
            r9 = r6[r8]
            goto L244
        Le3:
            r13 = 255(0xff, double:1.26E-321)
            goto L15
        Le9:
            int r13 = r13 + r2
            goto L202
        Lee:
            r9 = r8
            goto L1a
        Lf3:
            r2 = r3
            goto L5f
        Lf8:
            int r11 = r11 >>> 31
            goto L13d
        Lfe:
            int r7 = r7 + (-2)
            goto L1d9
        L104:
            int r8 = r8 + 1
            goto Ld3
        L10a:
            if (r11 != 0) goto L10f
            goto L234
        L10f:
            goto L14a
        L113:
            androidx.collection.ScatterDictionary r6 = (androidx.collection.ScatterDictionary) r6
            goto L221
        L119:
            long r7 = r7 >> r4
            goto L129
        L11e:
            r3 = 0
            goto L45
        L123:
            r0.L$0 = r12
            goto La
        L129:
            int r2 = r2 + r5
            goto L6a
        L12e:
            if (r2 != 0) goto L133
            goto L1ac
        L133:
            goto L8a
        L137:
            kotlin.sequences.SequenceScope r2 = (kotlin.sequences.SequenceScope) r2
            goto L18f
        L13d:
            int r11 = 8 - r11
            goto L1e7
        L143:
            r1 = 8
            goto La7
        L14a:
            int r11 = r8 - r7
            goto L1cd
        L150:
            r15 = 128(0x80, double:6.3E-322)
            goto L93
        L156:
            r0.I$1 = r9
            goto L23e
        L15c:
            long r11 = r11 & r13
            goto L227
        L161:
            goto L75
        L164:
            goto L6f
        L168:
            kotlin.Unit r0 = kotlin.Unit.INSTANCE
            goto La2
        L16e:
            int r13 = r9 << 3
            goto Le9
        L174:
            int r2 = r0.label
            goto L11e
        L17a:
            r11 = r6
            goto Lb8
        L17f:
            r6 = r11
            goto L233
        L184:
            kotlin.sequences.SequenceScope r12 = (kotlin.sequences.SequenceScope) r12
            goto L1ec
        L18a:
            r13 = 7
            goto L19a
        L18f:
            androidx.collection.MutableScatterDictionary<K, V> r6 = r0.this$0
            goto L113
        L195:
            r12 = r2
            goto Lf3
        L19a:
            long r11 = r11 << r13
            goto L65
        L19f:
            int r9 = r0.I$1
            goto L20a
        L1a5:
            int r0 = r0 % r1
            goto Lc4
        L1ab:
            throw r0
        L1ac:
            goto L249
        L1b0:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
            goto L7f
        L1b6:
            if (r13 == r1) goto L1bb
            goto Lae
        L1bb:
            goto Lad
        L1bf:
            r13 = -9187201950435737472(0x8080808080808080, double:-2.937446524422997E-306)
            goto L15c
        L1c8:
            r7 = r10
            goto L17f
        L1cd:
            int r11 = ~r11
            goto Lf8
        L1d2:
            r0 = 15
            goto L143
        L1d9:
            if (r7 >= 0) goto L1de
            goto Ld4
        L1de:
            goto Ld8
        L1e2:
            r8 = r9
            goto L1c8
        L1e7:
            r12 = r11
            goto L17a
        L1ec:
            kotlin.ResultKt.throwOnFailure(r20)
            goto L216
        L1f3:
            r0.I$0 = r10
            goto L156
        L1f9:
            if (r13 < 0) goto L1fe
            goto Lae
        L1fe:
            goto L16e
        L202:
            java.lang.int r13 = kotlin.coroutines.jvm.internal.Boxing.boxInt(r13)
            goto L123
        L20a:
            int r10 = r0.I$0
            goto L29
        L210:
            int r6 = r0.I$2
            goto L4b
        L216:
            goto Lae
        L218:
            goto L1b0
        L21c:
            int r7 = r6.length
            goto Lfe
        L221:
            long[] r6 = r6.metadata
            goto L21c
        L227:
            int r11 = (r11 > r13 ? 1 : (r11 == r13 ? 0 : -1))
            goto L10a
        L22d:
            long[] r11 = (long[]) r11
            goto L51
        L233:
            r2 = r12
        L234:
            goto L20
        L238:
            r0.label = r5
            goto L57
        L23e:
            r0.J$0 = r7
            goto Lb2
        L244:
            long r11 = ~r9
            goto L18a
        L249:
            kotlin.ResultKt.throwOnFailure(r20)
            goto Lcd
        L250:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L174
    }
}

