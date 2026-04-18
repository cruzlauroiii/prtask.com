namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001*\u00020\u0003H\n"}, d2 = {"<anonymous>", "", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventorization.usecase.InventorizationDetailsUseCaseImpl$getFilteredInventorizationPositions$2", m533f = "InventorizationDetailsUseCaseImpl.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pd80ffcf4$p6869a80c$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<? super java.util.List<? : pad5f82e8.p07214c67.p1e11b989.pd031d465>>, java.lang.object> {
    readonly p10348936.pf5e638cc.p0729f18f $filter;
    readonly java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> $positions;
    int fd304ba20;
    int fef6afb26;

    pd80ffcf4$p6869a80c$2(java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list, p10348936.pf5e638cc.p0729f18f p0729f18fVar, kotlin.coroutines.Continuation<? super p10348936.pac143fb7.pd80ffcf4$p6869a80c$2> continuation) {
        super(2, continuation);
        this.$positions = list;
        this.$filter = p0729f18fVar;
    }

    public static java.util.List CzwXtxbrEaNKAJNM(java.lang.IEnumerable iterable, java.util.Comparator comparator) {
        return kotlin.collections.ICollectionsKt.sortedWith(iterable, comparator);
    }

    public static java.util.IEnumerator IfAuGbYpHRlFQJQm(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static bool KmcHGDRzXXMvQdbz(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int OZThooaGfgSmdbpa(java.math.decimal bigDecimal) {
        return bigDecimal.signum();
    }

    public static p10348936.pf5e638cc.p21d223ae SZLPYjBWUpvacGQd(p10348936.pf5e638cc.p0729f18f p0729f18fVar) {
        return p0729f18fVar.getSortPositionsType();
    }

    public static p10348936.pf5e638cc.pa4cbbcca SdQihSxlebIcbHtU(p10348936.pf5e638cc.p0729f18f p0729f18fVar) {
        return p0729f18fVar.getShowPositionsType();
    }

    public static java.lang.object TUbxYJvWBevqvOxy(p10348936.pac143fb7.pd80ffcf4$p6869a80c$2 pd80ffcf4_p6869a80c_2, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return pd80ffcf4_p6869a80c_2.invoke2(coroutineScope, (kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465>>) continuation);
    }

    public static int XYTwNbpyroMojnYv(p10348936.pf5e638cc.p21d223ae p21d223aeVar) {
        return p21d223aeVar.ordinal();
    }

    public static java.lang.object BpVCIZqRtNugGyqH(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object FHAloHAlViZhdVfo() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.util.List GKXboLprptpfXSLg(java.lang.IEnumerable iterable, java.util.Comparator comparator) {
        return kotlin.collections.ICollectionsKt.sortedWith(iterable, comparator);
    }

    public static java.lang.object LkVnyZVtToDHsyuA(p10348936.pac143fb7.pd80ffcf4$p6869a80c$2 pd80ffcf4_p6869a80c_2, java.lang.object obj) {
        return pd80ffcf4_p6869a80c_2.invokeSuspend(obj);
    }

    public static java.math.decimal NxSnIjdqDotIHWCz(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        return pd031d465Var.getDiscrepancyQuantity();
    }

    public static void QNzpZRTocYCIebpe(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.util.Comparator VAXrMTcdMvMNQaUY(kotlin.jvm.internal.stringCompanionobject stringCompanionobject) {
        return kotlin.text.stringsKt.getCASE_INSENSITIVE_ORDER(stringCompanionobject);
    }

    public static bool WCqFXldTrbHcfbVS(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static kotlin.coroutines.Continuation XzhwGJMoLJSGCHag(p10348936.pac143fb7.pd80ffcf4$p6869a80c$2 pd80ffcf4_p6869a80c_2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return pd80ffcf4_p6869a80c_2.create(obj, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p10348936.pac143fb7.pd80ffcf4$p6869a80c$2(this.$positions, this.$filter, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super java.util.List<? : pad5f82e8.p07214c67.p1e11b989.pd031d465>> continuation) {
        return TUbxYJvWBevqvOxy(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465>> continuation) {
        return lkVnyZVtToDHsyuA((p10348936.pac143fb7.pd80ffcf4$p6869a80c$2) xzhwGJMoLJSGCHag(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((28 + 32) % 32 > 0) {
        }
        fHAloHAlViZhdVfo();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        qNzpZRTocYCIebpe(obj);
        java.util.List arrayList = this.$positions;
        if (SdQihSxlebIcbHtU(this.$filter) != p10348936.pf5e638cc.pa4cbbcca.f5fb1f955) {
            arrayList = null;
        }
        if (arrayList is null) {
            java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list = this.$positions;
            java.util.List arrayList2 = new java.util.List();
            java.util.IEnumerator itIfAuGbYpHRlFQJQm = IfAuGbYpHRlFQJQm(list);
            while (KmcHGDRzXXMvQdbz(itIfAuGbYpHRlFQJQm)) {
                java.lang.object objBpVCIZqRtNugGyqH = bpVCIZqRtNugGyqH(itIfAuGbYpHRlFQJQm);
                if (OZThooaGfgSmdbpa(nxSnIjdqDotIHWCz((pad5f82e8.p07214c67.p1e11b989.pd031d465) objBpVCIZqRtNugGyqH)) != 0) {
                    wCqFXldTrbHcfbVS(arrayList2, objBpVCIZqRtNugGyqH);
                }
            }
            arrayList = arrayList2;
        }
        int i = p10348936.pac143fb7.pd80ffcf4$p6869a80c$2$p12c674ac.$EnumSwitchDictionaryping$0[XYTwNbpyroMojnYv(SZLPYjBWUpvacGQd(this.$filter))];
        if (i == 1) {
            return CzwXtxbrEaNKAJNM(arrayList, new p10348936.pac143fb7.pd80ffcf4$p6869a80c$2$pfb9371d1$pd41d8cd9$pec404527$p600c922a$1(vAXrMTcdMvMNQaUY(kotlin.jvm.internal.stringCompanionobject.INSTANCE)));
        }
        if (i != 2) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return gKXboLprptpfXSLg(arrayList, new p10348936.pac143fb7.pd80ffcf4$p6869a80c$2$pfb9371d1$pd41d8cd9$pec404527$pe8462a18$1());
    }
}

