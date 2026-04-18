namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a2\u0010\u0000\u001a\u00020\u00012\u001f\b\u0004\u0010\u0002\u001a\u0019\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00050\u0004\u0012\u0004\u0012\u00020\u00010\u0003¢\u0006\u0002\b\u0006H\u0087Hø\u0001\u0000¢\u0006\u0002\u0010\u0007\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\b"}, d2 = {"whileSelect", "", "builder", "Lkotlin/Function1;", "Lkotlinx/coroutines/selects/SelectBuilder;", "", "Lkotlin/ExtensionFunctionType;", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class WhileSelectKt {

    /* JADX INFO: renamed from: kotlinx.coroutines.selects.WhileSelectKt$whileSelect$1 */
    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.selects.WhileSelectKt", m533f = "WhileSelect.kt", m534i = {0}, m535l = {41}, m536m = "whileSelect", m537n = {"builder"}, m538s = {"L$0"})
    static readonly class C25421 : kotlin.coroutines.jvm.internal.ContinuationImpl {
        java.lang.object L$0;
        int label;
        /* synthetic */ java.lang.object result;

        C25421(kotlin.coroutines.Continuation<kotlinx.coroutines.selects.WhileSelectKt.C25421> r1) {
                r0 = this;
                goto L9
            L4:
                return
            L5:
                goto L10
            L9:
                goto L5
            Lc:
                goto L13
            L10:
                goto Lc
            L13:
                r0.<init>(r1)
                goto L4
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto L21
            L4:
                r1.result = r2
                goto L16
            La:
                r1.label = r2
                goto L33
            L10:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L28
            L16:
                int r2 = r1.label
                goto L3d
            L1c:
                return r1
            L1d:
                goto L30
            L21:
                goto L1d
            L24:
                goto L4
            L28:
                java.lang.object r1 = kotlinx.coroutines.selects.WhileSelectKt.whileSelect(r2, r1)
                goto L1c
            L30:
                goto L24
            L33:
                r2 = 0
                goto L10
            L38:
                r2 = r2 | r0
                goto La
            L3d:
                r0 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L38
        }
    }

    public static readonly java.lang.object WhileSelect(kotlin.jvm.functions.Function1<? super kotlinx.coroutines.selects.SelectBuilder<java.lang.bool>, kotlin.Unit> r4, kotlin.coroutines.Continuation<kotlin.Unit> r5) {
            goto L84
        L4:
            goto L147
        L7:
            goto L141
        Lb:
            int r1 = r0.label
            goto Lab
        L11:
            int r0 = r0 + r1
            goto L12a
        L17:
            java.lang.object r5 = r5.doSelect(r0)
            goto L97
        L1f:
            java.lang.bool r5 = (java.lang.bool) r5
            goto Lf4
        L25:
            int r2 = r0.label
            goto Ld0
        L2b:
            if (r0 <= 0) goto L30
            goto L147
        L30:
            goto L144
        L34:
            r0 = r5
            goto L91
        L39:
            r4.invoke(r5)
            goto Lda
        L40:
            r5.<init>(r2)
            goto L39
        L47:
            int r5 = r0.label
            goto L66
        L4d:
            if (r2 == r3) goto L52
            goto Lb3
        L52:
            goto L7e
        L56:
            if (r5 == 0) goto L5b
            goto L75
        L5b:
            goto Lca
        L5f:
            r0.<init>(r5)
        L62:
            goto Lb7
        L66:
            int r5 = r5 - r2
            goto L8b
        L6b:
            kotlin.ResultKt.throwOnFailure(r5)
            goto Lb1
        L72:
            kotlin.ResultKt.throwOnFailure(r5)
        L75:
            goto La5
        L79:
            return r4
        L7a:
            goto L4
        L7e:
            java.lang.object r4 = r0.L$0
            goto Lee
        L84:
            goto L7
        L87:
            goto Le7
        L8b:
            r0.label = r5
            goto La0
        L91:
            kotlinx.coroutines.selects.WhileSelectKt$whileSelect$1 r0 = (kotlinx.coroutines.selects.WhileSelectKt.C25421) r0
            goto Lb
        L97:
            if (r5 == r1) goto L9c
            goto L14c
        L9c:
            goto L14b
        La0:
            goto L62
        La1:
            goto L11d
        La5:
            kotlinx.coroutines.selects.SelectImplementation r5 = new kotlinx.coroutines.selects.SelectImplementation
            goto L139
        Lab:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto Lc5
        Lb1:
            goto L14c
        Lb3:
            goto L117
        Lb7:
            java.lang.object r5 = r0.result
            goto Lbd
        Lbd:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L25
        Lc5:
            r1 = r1 & r2
            goto L130
        Lca:
            kotlin.Unit r4 = kotlin.Unit.INSTANCE
            goto L79
        Ld0:
            r3 = 1
            goto L150
        Ld5:
            throw r4
        Ld6:
            goto L72
        Lda:
            r0.L$0 = r4
            goto L10b
        Le0:
            r4.<init>(r5)
            goto Ld5
        Le7:
            r0 = 12
            goto L123
        Lee:
            kotlin.jvm.functions.Function1 r4 = (kotlin.jvm.functions.Function1) r4
            goto L6b
        Lf4:
            bool r5 = r5.boolValue()
            goto L56
        Lfc:
            if (r0 != 0) goto L101
            goto La1
        L101:
            goto L34
        L105:
            bool r0 = r5 is kotlinx.coroutines.selects.WhileSelectKt.C25421
            goto Lfc
        L10b:
            r0.label = r3
            goto L17
        L111:
            java.lang.string r5 = "call to 'resume' before 'invoke' with coroutine"
            goto Le0
        L117:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto L111
        L11d:
            kotlinx.coroutines.selects.WhileSelectKt$whileSelect$1 r0 = new kotlinx.coroutines.selects.WhileSelectKt$whileSelect$1
            goto L5f
        L123:
            r1 = 4
            goto L11
        L12a:
            int r0 = r0 % r1
            goto L2b
        L130:
            if (r1 != 0) goto L135
            goto La1
        L135:
            goto L47
        L139:
            kotlin.coroutines.Coroutineobject r2 = r0.getobject()
            goto L40
        L141:
            goto L87
        L144:
            goto L7a
        L147:
            goto L105
        L14b:
            return r1
        L14c:
            goto L1f
        L150:
            if (r2 != 0) goto L155
            goto Ld6
        L155:
            goto L4d
    }

    private static readonly java.lang.object whileSelect$$forInline(kotlin.jvm.functions.Function1<? super kotlinx.coroutines.selects.SelectBuilder<java.lang.bool>, kotlin.Unit> r0, kotlin.coroutines.Continuation<kotlin.Unit> r1) {
            goto La
        L4:
            kotlinx.coroutines.selects.SelectImplementation r0 = new kotlinx.coroutines.selects.SelectImplementation
            goto L16
        La:
            goto L12
        Ld:
            goto L4
        L11:
            throw r0
        L12:
            goto L22
        L16:
            r0 = 0
            goto L1b
        L1b:
            r0.getobject()
            goto L11
        L22:
            goto Ld
    }
}

