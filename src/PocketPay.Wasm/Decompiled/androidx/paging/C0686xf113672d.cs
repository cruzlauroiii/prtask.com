namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.paging.AsyncPagingDataDiffer$presenter$1$presentPagingDataEvent$2$diffResult$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "Landroidx/paging/PlaceholderPaddedDiffResult;", "T", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.AsyncPagingDataDiffer$presenter$1$presentPagingDataEvent$2$diffResult$1", m533f = "AsyncPagingDataDiffer.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0686xf113672d : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<androidx.paging.PlaceholderPaddedDiffResult>, java.lang.object> {
    readonly /* synthetic */ androidx.paging.PagingDataEvent.Refresh<T> $this_apply;
    int label;
    readonly /* synthetic */ androidx.paging.AsyncPagingDataDiffer<T> this$0;

    C0686xf113672d(androidx.paging.PagingDataEvent.Refresh<T> r1, androidx.paging.AsyncPagingDataDiffer<T> r2, kotlin.coroutines.Continuation<androidx.paging.C0686xf113672d> r3) {
            r0 = this;
            goto L9
        L4:
            return
        L5:
            goto L15
        L9:
            goto L5
        Lc:
            goto L18
        L10:
            r1 = 2
            goto L24
        L15:
            goto Lc
        L18:
            r0.$this_apply = r1
            goto L1e
        L1e:
            r0.this$0 = r2
            goto L10
        L24:
            r0.<init>(r1, r3)
            goto L4
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L15
        L4:
            return r2
        L5:
            goto L2f
        L9:
            androidx.paging.AsyncPagingDataDiffer<T> r1 = r1.this$0
            goto L28
        Lf:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L4
        L15:
            goto L5
        L18:
            goto L22
        L1c:
            androidx.paging.PagingDataEvent$Refresh<T> r0 = r1.$this_apply
            goto L9
        L22:
            androidx.paging.AsyncPagingDataDiffer$presenter$1$presentPagingDataEvent$2$diffResult$1 r2 = new androidx.paging.AsyncPagingDataDiffer$presenter$1$presentPagingDataEvent$2$diffResult$1
            goto L1c
        L28:
            r2.<init>(r0, r1, r3)
            goto Lf
        L2f:
            goto L18
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<androidx.paging.PlaceholderPaddedDiffResult> r2) {
            r0 = this;
            goto L12
        L4:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto L21
        La:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto L1c
        L12:
            goto L1d
        L15:
            goto L4
        L19:
            goto L15
        L1c:
            return r0
        L1d:
            goto L19
        L21:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto La
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<androidx.paging.PlaceholderPaddedDiffResult> r2) {
            r0 = this;
            goto L28
        L4:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L23
        Lc:
            androidx.paging.AsyncPagingDataDiffer$presenter$1$presentPagingDataEvent$2$diffResult$1 r0 = (androidx.paging.C0686xf113672d) r0
            goto L1d
        L12:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto Lc
        L1a:
            goto L2b
        L1d:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L4
        L23:
            return r0
        L24:
            goto L1a
        L28:
            goto L24
        L2b:
            goto L12
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
            r1 = this;
            goto L67
        L4:
            throw r1
        L5:
            goto L1b
        L9:
            androidx.paging.AsyncPagingDataDiffer<T> r1 = r1.this$0
            goto L5f
        Lf:
            androidx.paging.PagingDataEvent$Refresh<T> r2 = r1.$this_apply
            goto L1e
        L15:
            java.lang.string r2 = "call to 'resume' before 'invoke' with coroutine"
            goto L4a
        L1b:
            goto L6a
        L1e:
            androidx.paging.PlaceholderPaddedList r2 = r2.getPreviousList()
            goto L35
        L26:
            if (r0 == 0) goto L2b
            goto L76
        L2b:
            goto L6e
        L2f:
            int r0 = r1.label
            goto L26
        L35:
            androidx.paging.PagingDataEvent$Refresh<T> r0 = r1.$this_apply
            goto L42
        L3b:
            kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L2f
        L42:
            androidx.paging.PlaceholderPaddedList r0 = r0.getNewList()
            goto L9
        L4a:
            r1.<init>(r2)
            goto L4
        L51:
            java.lang.IllegalStateException r1 = new java.lang.IllegalStateException
            goto L15
        L57:
            androidx.paging.PlaceholderPaddedDiffResult r1 = androidx.paging.PlaceholderPaddedListDiffHelperKt.computeDiff(r2, r0, r1)
            goto L75
        L5f:
            androidx.recyclerview.widget.DiffUtil$ItemCallback r1 = androidx.paging.AsyncPagingDataDiffer.access$getDiffCallback$p(r1)
            goto L57
        L67:
            goto L5
        L6a:
            goto L3b
        L6e:
            kotlin.ResultKt.throwOnFailure(r2)
            goto Lf
        L75:
            return r1
        L76:
            goto L51
    }
}

