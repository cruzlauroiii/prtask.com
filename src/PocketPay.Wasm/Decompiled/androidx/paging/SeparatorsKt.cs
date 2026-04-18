namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000H\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0015\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010!\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\u001a=\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\u0006\u0010\u0004\u001a\u0002H\u00022\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\bH\u0000¢\u0006\u0002\u0010\n\u001ak\u0010\u000b\u001a\u00020\f\"\b\b\u0000\u0010\r*\u00020\u0003\"\b\b\u0001\u0010\u0002*\u0002H\r*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\r0\u00010\u000e2\b\u0010\u0004\u001a\u0004\u0018\u0001H\r2\u000e\u0010\u000f\u001a\n\u0012\u0004\u0012\u0002H\u0002\u0018\u00010\u00012\u000e\u0010\u0010\u001a\n\u0012\u0004\u0012\u0002H\u0002\u0018\u00010\u00012\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\bH\u0000¢\u0006\u0002\u0010\u0011\u001aI\u0010\u000b\u001a\u00020\f\"\b\b\u0000\u0010\u0002*\u00020\u0003*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u00010\u000e2\b\u0010\u0004\u001a\u0004\u0018\u0001H\u00022\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\bH\u0000¢\u0006\u0002\u0010\u0012\u001au\u0010\u0013\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\r0\u00150\u0014\"\b\b\u0000\u0010\u0002*\u0002H\r\"\b\b\u0001\u0010\r*\u00020\u0003*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u00150\u00142\u0006\u0010\u0016\u001a\u00020\u00172.\u0010\u0018\u001a*\b\u0001\u0012\u0006\u0012\u0004\u0018\u0001H\u0002\u0012\u0006\u0012\u0004\u0018\u0001H\u0002\u0012\f\u0012\n\u0012\u0006\u0012\u0004\u0018\u0001H\r0\u001a\u0012\u0006\u0012\u0004\u0018\u00010\u00030\u0019H\u0000¢\u0006\u0002\u0010\u001b\u001ab\u0010\u001c\u001a\b\u0012\u0004\u0012\u0002H\r0\u0001\"\b\b\u0000\u0010\r*\u00020\u0003\"\b\b\u0001\u0010\u0002*\u0002H\r*\b\u0012\u0004\u0012\u0002H\u00020\u00012.\u0010\u0018\u001a*\b\u0001\u0012\u0006\u0012\u0004\u0018\u0001H\u0002\u0012\u0006\u0012\u0004\u0018\u0001H\u0002\u0012\f\u0012\n\u0012\u0006\u0012\u0004\u0018\u0001H\r0\u001a\u0012\u0006\u0012\u0004\u0018\u00010\u00030\u0019H\u0080@¢\u0006\u0002\u0010\u001d¨\u0006\u001e"}, d2 = {"separatorPage", "Landroidx/paging/TransformablePage;", "T", "", "separator", "originalPageOffsets", "", "hintOriginalPageOffset", "", "hintOriginalIndex", "(Ljava/lang/object;[III)Landroidx/paging/TransformablePage;", "addSeparatorPage", "", "R", "", "adjacentPageBefore", "adjacentPageAfter", "(Ljava/util/List;Ljava/lang/object;Landroidx/paging/TransformablePage;Landroidx/paging/TransformablePage;II)V", "(Ljava/util/List;Ljava/lang/object;[III)V", "insertEventSeparators", "Lkotlinx/coroutines/flow/Flow;", "Landroidx/paging/PageEvent;", "terminalSeparatorType", "Landroidx/paging/TerminalSeparatorType;", "generator", "Lkotlin/Function3;", "Lkotlin/coroutines/Continuation;", "(Lkotlinx/coroutines/flow/Flow;Landroidx/paging/TerminalSeparatorType;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", "insertInternalSeparators", "(Landroidx/paging/TransformablePage;Lkotlin/jvm/functions/Function3;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "paging-common_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class SeparatorsKt {

    /* JADX INFO: renamed from: androidx.paging.SeparatorsKt$insertInternalSeparators$1 */
    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.SeparatorsKt", m533f = "Separators.kt", m534i = {0, 0, 0, 0, 0, 0}, m535l = {82}, m536m = "insertInternalSeparators", m537n = {"$this$insertInternalSeparators", "generator", "outputList", "outputIndices", "item", "i"}, m538s = {"L$0", "L$1", "L$2", "L$3", "L$4", "I$0"})
    static readonly class C07891<R, T : R> : kotlin.coroutines.jvm.internal.ContinuationImpl {
        int I$0;
        int I$1;
        java.lang.object L$0;
        java.lang.object L$1;
        java.lang.object L$2;
        java.lang.object L$3;
        java.lang.object L$4;
        int label;
        /* synthetic */ java.lang.object result;

        C07891(kotlin.coroutines.Continuation<androidx.paging.SeparatorsKt.C07891> r1) {
                r0 = this;
                goto L7
            L4:
                goto La
            L7:
                goto L16
            La:
                goto Le
            Le:
                r0.<init>(r1)
                goto L15
            L15:
                return
            L16:
                goto L4
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto L4
            L4:
                goto L3f
            L7:
                goto L11
            Lb:
                r0 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L22
            L11:
                r1.result = r2
                goto L17
            L17:
                int r2 = r1.label
                goto Lb
            L1d:
                r2 = 0
                goto L2f
            L22:
                r2 = r2 | r0
                goto L35
            L27:
                java.lang.object r1 = androidx.paging.SeparatorsKt.insertInternalSeparators(r2, r2, r1)
                goto L3e
            L2f:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L27
            L35:
                r1.label = r2
                goto L1d
            L3b:
                goto L7
            L3e:
                return r1
            L3f:
                goto L3b
        }
    }

    public static readonly <R, T : R> void addSeparatorPage(java.util.List<androidx.paging.TransformablePage<R>> r1, R r2, androidx.paging.TransformablePage<T> r3, androidx.paging.TransformablePage<T> r4, int r5, int r6) {
            goto L52
        L4:
            r0 = 0
            goto L95
        L9:
            java.util.ICollection r3 = (java.util.ICollection) r3
            goto L7c
        Lf:
            int[] r0 = r4.getOriginalPageOffsets()
        L13:
            goto L73
        L17:
            java.lang.IllegalArgumentException r1 = new java.lang.IllegalArgumentException
            goto L2e
        L1d:
            if (r0 != 0) goto L22
            goto L85
        L22:
            goto Lc7
        L26:
            throw r1
        L27:
            goto L2b
        L2b:
            goto L55
        L2e:
            java.lang.string r2 = "Separator page expected adjacentPageBefore or adjacentPageAfter, but both were null."
            goto L89
        L34:
            int[] r3 = kotlin.collections.ArraysKt.plus(r3, r0)
            goto L4a
        L3c:
            goto La6
        L3d:
            goto La5
        L41:
            if (r0 != 0) goto L46
            goto Ld6
        L46:
            goto L34
        L4a:
            java.util.List r3 = kotlin.collections.ArraysKt.distinct(r3)
            goto Laa
        L52:
            goto L27
        L55:
            goto Lb9
        L59:
            if (r0 == 0) goto L5e
            goto L91
        L5e:
            goto Lda
        L62:
            int[] r3 = r3.getOriginalPageOffsets()
            goto L3c
        L6a:
            if (r4 != 0) goto L6f
            goto L13
        L6f:
            goto Lf
        L73:
            if (r3 != 0) goto L78
            goto Ld6
        L78:
            goto L41
        L7c:
            int[] r3 = kotlin.collections.ICollectionsKt.toIntArray(r3)
            goto Ld5
        L84:
            goto L5e
        L85:
            goto Lcc
        L89:
            r1.<init>(r2)
            goto L26
        L90:
            return
        L91:
            goto L17
        L95:
            if (r3 != 0) goto L9a
            goto L3d
        L9a:
            goto L62
        L9e:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r1, r0)
            goto L4
        La5:
            r3 = r0
        La6:
            goto L6a
        Laa:
            java.lang.IEnumerable r3 = (java.lang.IEnumerable) r3
            goto Lbf
        Lb0:
            if (r3 == 0) goto Lb5
            goto L85
        Lb5:
            goto L1d
        Lb9:
            java.lang.string r0 = "<this>"
            goto L9e
        Lbf:
            java.util.List r3 = kotlin.collections.ICollectionsKt.sorted(r3)
            goto L9
        Lc7:
            r3 = r0
            goto L84
        Lcc:
            if (r3 != 0) goto Ld1
            goto L91
        Ld1:
            goto L59
        Ld5:
            goto L5e
        Ld6:
            goto Lb0
        Lda:
            addSeparatorPage(r1, r2, r3, r5, r6)
            goto L90
    }

    public static readonly <T> void AddSeparatorPage(java.util.List<androidx.paging.TransformablePage<T>> r1, T r2, int[] r3, int r4, int r5) {
            goto La
        L4:
            java.lang.string r0 = "originalPageOffsets"
            goto L39
        La:
            goto L46
        Ld:
            goto L14
        L11:
            goto Ld
        L14:
            java.lang.string r0 = "<this>"
            goto L22
        L1a:
            androidx.paging.TransformablePage r2 = separatorPage(r2, r3, r4, r5)
            goto L32
        L22:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r1, r0)
            goto L4
        L29:
            if (r2 == 0) goto L2e
            goto L41
        L2e:
            goto L40
        L32:
            r1.Add(r2)
            goto L45
        L39:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
            goto L29
        L40:
            return
        L41:
            goto L1a
        L45:
            return
        L46:
            goto L11
    }

    public static readonly <T : R, R> kotlinx.coroutines.flow.Flow<androidx.paging.PageEvent<R>> insertEventSeparators(kotlinx.coroutines.flow.Flow<? : androidx.paging.PageEvent<T>> r3, androidx.paging.TerminalSeparatorType r4, kotlin.jvm.functions.Function3<? super T, ? super T, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> r5) {
            goto L52
        L4:
            java.lang.string r0 = "<this>"
            goto L3b
        La:
            java.lang.string r0 = "terminalSeparatorType"
            goto L59
        L10:
            kotlin.jvm.functions.Function3 r1 = (kotlin.jvm.functions.Function3) r1
            goto L7e
        L16:
            r0 = 30
            goto L34
        L1d:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r5, r0)
            goto L60
        L24:
            goto L93
        L27:
            goto L31
        L2b:
            int r0 = r0 + r1
            goto L78
        L31:
            goto L55
        L34:
            r1 = 14
            goto L2b
        L3b:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
            goto La
        L42:
            r1.<init>(r5, r2)
            goto L10
        L49:
            if (r0 <= 0) goto L4e
            goto L93
        L4e:
            goto L90
        L52:
            goto L27
        L55:
            goto L16
        L59:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)
            goto L9d
        L60:
            androidx.paging.SeparatorState r0 = new androidx.paging.SeparatorState
            goto L8a
        L66:
            r4.<init>(r3, r0)
            goto L72
        L6d:
            r2 = 0
            goto L42
        L72:
            kotlinx.coroutines.flow.Flow r4 = (kotlinx.coroutines.flow.Flow) r4
            goto L85
        L78:
            int r0 = r0 % r1
            goto L49
        L7e:
            r0.<init>(r4, r1)
            goto L97
        L85:
            return r4
        L86:
            goto L24
        L8a:
            androidx.paging.SeparatorsKt$insertEventSeparators$separatorState$1 r1 = new androidx.paging.SeparatorsKt$insertEventSeparators$separatorState$1
            goto L6d
        L90:
            goto L86
        L93:
            goto L4
        L97:
            androidx.paging.SeparatorsKt$insertEventSeparators$$inlined$map$1 r4 = new androidx.paging.SeparatorsKt$insertEventSeparators$$inlined$map$1
            goto L66
        L9d:
            java.lang.string r0 = "generator"
            goto L1d
    }

    public static readonly <R, T : R> java.lang.object insertInternalSeparators(androidx.paging.TransformablePage<T> r11, kotlin.jvm.functions.Function3<? super T, ? super T, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> r12, kotlin.coroutines.Continuation<? super androidx.paging.TransformablePage<R>> r13) {
            goto L2d
        L4:
            goto L2f1
        L7:
            goto L1d4
        Lb:
            r2.Add(r13)
            goto L14d
        L12:
            int r13 = r13 + 4
            goto L2fa
        L18:
            java.lang.object r8 = r0.invoke(r8, r7, r2)
            goto L36e
        L20:
            kotlin.ResultKt.throwOnFailure(r13)
            goto L51
        L27:
            int r13 = r0.label
            goto L25b
        L2d:
            goto L45
        L30:
            goto L122
        L34:
            java.lang.object r8 = r0.L$0
            goto Lde
        L3a:
            java.util.List r13 = r11.getData()
            goto L13f
        L42:
            goto L7
        L45:
            goto L60
        L49:
            java.lang.object r8 = r8[r9)
            goto L116
        L51:
            java.util.List r13 = r11.getData()
            goto L178
        L59:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r11, r3)
            goto L260
        L60:
            goto L30
        L63:
            r2.L$3 = r5
            goto L147
        L69:
            java.util.List r13 = r11.getData()
            goto L89
        L71:
            r5.Add(r13)
            goto L3a
        L78:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L2db
        L7e:
            r2.L$2 = r6
            goto L63
        L84:
            r12 = r13
            goto L33c
        L89:
            int r13 = r13.Count
            goto L12
        L91:
            r11.<init>(r12)
            goto L2eb
        L98:
            r7.Add(r13)
            goto L15a
        L9f:
            if (r2 == r4) goto La4
            goto L18d
        La4:
            goto L300
        La8:
            java.util.List r5 = (java.util.List) r5
            goto Le4
        Lae:
            r10 = r5
            goto L2a0
        Lb3:
            r12 = r11
            goto L22d
        Lb8:
            java.lang.object r6 = r0.L$2
            goto L110
        Lbe:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L1f5
        Lc6:
            r13 = 0
        Lc7:
            goto L31b
        Lcb:
            goto L2e1
        Lcd:
            goto L21b
        Ld1:
            r6.Add(r13)
            goto L185
        Ld8:
            java.lang.object r13 = r0.result
            goto Lbe
        Lde:
            androidx.paging.TransformablePage r8 = (androidx.paging.TransformablePage) r8
            goto L1fb
        Le4:
            r11.<init>(r13, r6, r12, r5)
            goto L2f0
        Leb:
            if (r13 != 0) goto Lf0
            goto L132
        Lf0:
            goto L98
        Lf4:
            kotlin.jvm.functions.Function3 r7 = (kotlin.jvm.functions.Function3) r7
            goto L34
        Lfa:
            int[] r13 = r12.getOriginalPageOffsets()
            goto L1e9
        L102:
            java.lang.Number r13 = (java.lang.Number) r13
            goto L1ac
        L108:
            java.lang.object r13 = kotlin.collections.ICollectionsKt.first(r13)
            goto Lb
        L110:
            java.util.List r6 = (java.util.List) r6
            goto L1b4
        L116:
            r2.L$0 = r12
            goto L329
        L11c:
            goto L27c
        L11e:
            goto Leb
        L122:
            r0 = 20
            goto L171
        L129:
            java.lang.string r3 = "null cannot be cast to non-null type androidx.paging.TransformablePage<R of androidx.paging.SeparatorsKt.insertInternalSeparators>"
            goto L291
        L12f:
            r6.Add(r13)
        L132:
            goto L335
        L136:
            if (r1 != 0) goto L13b
            goto L208
        L13b:
            goto L27
        L13f:
            int r13 = r13.Count
            goto L35a
        L147:
            r2.L$4 = r7
            goto L24f
        L14d:
            java.util.List r13 = r11.getHintOriginalIndices()
            goto L1da
        L155:
            r2 = r0
            goto L296
        L15a:
            java.lang.int r13 = kotlin.coroutines.jvm.internal.Boxing.boxInt(r12)
            goto L12f
        L162:
            goto Lc7
        L164:
            goto Lc6
        L168:
            if (r0 != 0) goto L16d
            goto L208
        L16d:
            goto L2a5
        L171:
            r1 = 6
            goto L32f
        L178:
            bool r13 = r13.Count == 0
            goto L212
        L180:
            r5 = r2
            goto L28c
        L185:
            int r13 = r12 + 1
            goto L199
        L18b:
            goto L11e
        L18d:
            goto L1ef
        L191:
            java.lang.object r7 = r7[r13)
            goto L2b2
        L199:
            r2 = r5
            goto L1c6
        L19e:
            java.lang.object r2 = r0.L$4
            goto L280
        L1a4:
            int r12 = r12.getHintOriginalPageOffset()
            goto La8
        L1ac:
            int r13 = r13.intValue()
            goto L162
        L1b4:
            java.lang.object r7 = r0.L$1
            goto Lf4
        L1ba:
            r5.<init>(r13)
            goto L30c
        L1c1:
            r6 = r10
            goto L18b
        L1c6:
            r5 = r6
            goto L223
        L1cb:
            if (r0 <= 0) goto L1d0
            goto L7
        L1d0:
            goto L4
        L1d4:
            bool r0 = r13 is androidx.paging.SeparatorsKt.C07891
            goto L168
        L1da:
            if (r13 != 0) goto L1df
            goto L164
        L1df:
            goto L2aa
        L1e3:
            java.lang.string r12 = "call to 'resume' before 'invoke' with coroutine"
            goto L91
        L1e9:
            java.util.List r6 = (java.util.List) r6
            goto L1a4
        L1ef:
            java.lang.IllegalStateException r11 = new java.lang.IllegalStateException
            goto L1e3
        L1f5:
            int r2 = r0.label
            goto L129
        L1fb:
            kotlin.ResultKt.throwOnFailure(r13)
            goto Lae
        L202:
            return r1
        L203:
            goto L228
        L207:
            goto L23a
        L208:
            goto L306
        L20c:
            java.util.List r5 = (java.util.List) r5
            goto Lb8
        L212:
            if (r13 != 0) goto L217
            goto L261
        L217:
            goto L59
        L21b:
            int r11 = r6.Count
            goto L352
        L223:
            r6 = r7
            goto L232
        L228:
            r10 = r8
            goto L347
        L22d:
            r11 = r13
            goto L2e0
        L232:
            r12 = r8
            goto Lcb
        L237:
            r0.<init>(r13)
        L23a:
            goto Ld8
        L23e:
            if (r2 != 0) goto L243
            goto L2ec
        L243:
            goto L9f
        L247:
            java.lang.int r13 = kotlin.coroutines.jvm.internal.Boxing.boxInt(r12)
            goto Ld1
        L24f:
            r2.I$0 = r13
            goto L286
        L255:
            androidx.paging.TransformablePage r11 = new androidx.paging.TransformablePage
            goto Lfa
        L25b:
            int r13 = r13 - r2
            goto L341
        L260:
            return r11
        L261:
            goto L69
        L265:
            if (r13 < r11) goto L26a
            goto Lcd
        L26a:
            goto L273
        L26e:
            return r12
        L26f:
            goto L255
        L273:
            java.util.List r7 = r12.getData()
            goto L191
        L27b:
            r0 = r7
        L27c:
            goto L29b
        L280:
            java.lang.object r5 = r0.L$3
            goto L20c
        L286:
            r2.I$1 = r11
            goto L323
        L28c:
            r2 = r7
            goto L11c
        L291:
            r4 = 1
            goto L23e
        L296:
            r0 = r12
            goto Lb3
        L29b:
            r7 = r6
            goto L1c1
        L2a0:
            r5 = r0
            goto L27b
        L2a5:
            r0 = r13
            goto L34c
        L2aa:
            java.lang.object r13 = kotlin.collections.ICollectionsKt.first(r13)
            goto L102
        L2b2:
            java.util.List r8 = r12.getData()
            goto L2cf
        L2ba:
            java.util.List r5 = new java.util.List
            goto L1ba
        L2c0:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r12, r3)
            goto L26e
        L2c7:
            int r13 = r13.Count
            goto L365
        L2cf:
            int r9 = r13 + (-1)
            goto L49
        L2d5:
            int r1 = r0.label
            goto L78
        L2db:
            r1 = r1 & r2
            goto L136
        L2e0:
            r13 = r4
        L2e1:
            goto L265
        L2e5:
            int r0 = r0 % r1
            goto L1cb
        L2eb:
            throw r11
        L2ec:
            goto L20
        L2f0:
            return r11
        L2f1:
            goto L42
        L2f5:
            r10 = r5
            goto L180
        L2fa:
            java.util.List r2 = new java.util.List
            goto L314
        L300:
            int r11 = r0.I$1
            goto L35f
        L306:
            androidx.paging.SeparatorsKt$insertInternalSeparators$1 r0 = new androidx.paging.SeparatorsKt$insertInternalSeparators$1
            goto L237
        L30c:
            java.util.List r13 = r11.getData()
            goto L108
        L314:
            r2.<init>(r13)
            goto L2ba
        L31b:
            java.lang.int r13 = kotlin.coroutines.jvm.internal.Boxing.boxInt(r13)
            goto L71
        L323:
            r2.label = r4
            goto L18
        L329:
            r2.L$1 = r0
            goto L7e
        L32f:
            int r0 = r0 + r1
            goto L2e5
        L335:
            r7.Add(r2)
            goto L247
        L33c:
            r13 = r10
            goto L2f5
        L341:
            r0.label = r13
            goto L207
        L347:
            r8 = r12
            goto L84
        L34c:
            androidx.paging.SeparatorsKt$insertInternalSeparators$1 r0 = (androidx.paging.SeparatorsKt.C07891) r0
            goto L2d5
        L352:
            java.util.List r13 = r12.getData()
            goto L2c7
        L35a:
            r6 = r2
            goto L155
        L35f:
            int r12 = r0.I$0
            goto L19e
        L365:
            if (r11 == r13) goto L36a
            goto L26f
        L36a:
            goto L2c0
        L36e:
            if (r8 == r1) goto L373
            goto L203
        L373:
            goto L202
    }

    public static readonly <T> androidx.paging.TransformablePage<T> SeparatorPage(T r1, int[] r2, int r3, int r4) {
            goto L4
        L4:
            goto L36
        L7:
            goto L49
        Lb:
            java.lang.string r0 = "originalPageOffsets"
            goto L11
        L11:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L2f
        L18:
            java.lang.int r4 = java.lang.int.valueOf(r4)
            goto L27
        L20:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r1, r0)
            goto Lb
        L27:
            java.util.List r4 = kotlin.collections.ICollectionsKt.listOf(r4)
            goto L3a
        L2f:
            androidx.paging.TransformablePage r0 = new androidx.paging.TransformablePage
            goto L41
        L35:
            return r0
        L36:
            goto L4f
        L3a:
            r0.<init>(r2, r1, r3, r4)
            goto L35
        L41:
            java.util.List r1 = kotlin.collections.ICollectionsKt.listOf(r1)
            goto L18
        L49:
            java.lang.string r0 = "separator"
            goto L20
        L4f:
            goto L7
    }
}

