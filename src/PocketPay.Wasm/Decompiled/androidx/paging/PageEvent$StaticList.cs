namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0000\n\u0002\u0018\u0002\n\u0002\b\f\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u001c\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u0000*\b\b\u0001\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B+\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00010\u0005\u0012\n\b\u0002\u0010\u0006\u001a\u0004\u0018\u00010\u0007\u0012\n\b\u0002\u0010\b\u001a\u0004\u0018\u00010\u0007¢\u0006\u0002\u0010\tJ\u000f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00028\u00010\u0005HÆ\u0003J\u000b\u0010\u0010\u001a\u0004\u0018\u00010\u0007HÆ\u0003J\u000b\u0010\u0011\u001a\u0004\u0018\u00010\u0007HÆ\u0003J7\u0010\u0012\u001a\b\u0012\u0004\u0012\u00028\u00010\u00002\u000e\b\u0002\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00010\u00052\n\b\u0002\u0010\u0006\u001a\u0004\u0018\u00010\u00072\n\b\u0002\u0010\b\u001a\u0004\u0018\u00010\u0007HÆ\u0001J\u0013\u0010\u0013\u001a\u00020\u00142\b\u0010\u0015\u001a\u0004\u0018\u00010\u0002HÖ\u0003J8\u0010\u0016\u001a\b\u0012\u0004\u0012\u00028\u00010\u00032\"\u0010\u0017\u001a\u001e\b\u0001\u0012\u0004\u0012\u00028\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00140\u0019\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u0018H\u0096@¢\u0006\u0002\u0010\u001aJH\u0010\u001b\u001a\b\u0012\u0004\u0012\u0002H\u001c0\u0003\"\b\b\u0002\u0010\u001c*\u00020\u00022(\u0010\u001d\u001a$\b\u0001\u0012\u0004\u0012\u00028\u0001\u0012\u0010\u0012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u001c0\u001e0\u0019\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u0018H\u0096@¢\u0006\u0002\u0010\u001aJ\t\u0010\u001f\u001a\u00020 HÖ\u0001JB\u0010!\u001a\b\u0012\u0004\u0012\u0002H\u001c0\u0003\"\b\b\u0002\u0010\u001c*\u00020\u00022\"\u0010\u001d\u001a\u001e\b\u0001\u0012\u0004\u0012\u00028\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u001c0\u0019\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u0018H\u0096@¢\u0006\u0002\u0010\u001aJ\b\u0010\"\u001a\u00020#H\u0016R\u0017\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00010\u0005¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0013\u0010\b\u001a\u0004\u0018\u00010\u0007¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0013\u0010\u0006\u001a\u0004\u0018\u00010\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\r¨\u0006$"}, d2 = {"Landroidx/paging/PageEvent$StaticList;", "T", "", "Landroidx/paging/PageEvent;", "data", "", "sourceLoadStates", "Landroidx/paging/LoadStates;", "mediatorLoadStates", "(Ljava/util/List;Landroidx/paging/LoadStates;Landroidx/paging/LoadStates;)V", "getData", "()Ljava/util/List;", "getMediatorLoadStates", "()Landroidx/paging/LoadStates;", "getSourceLoadStates", "component1", "component2", "component3", "copy", "equals", "", "other", "filter", "predicate", "Lkotlin/Function2;", "Lkotlin/coroutines/Continuation;", "(Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "flatDictionary", "R", "transform", "", "hashCode", "", "map", "tostring", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PageEvent$StaticList<T> : androidx.paging.PageEvent<T> {
    private readonly java.util.List<T> data;
    private readonly androidx.paging.LoadStates mediatorLoadStates;
    private readonly androidx.paging.LoadStates sourceLoadStates;

    public PageEvent$StaticList(java.util.List<? : T> data2, androidx.paging.LoadStates loadStates, androidx.paging.LoadStates loadStates2) {
        super(null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        this.data = data2;
        this.sourceLoadStates = loadStates;
        this.mediatorLoadStates = loadStates2;
    }

    public PageEvent$StaticList(java.util.List list, androidx.paging.LoadStates loadStates, androidx.paging.LoadStates loadStates2, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(list, (i & 2) != 0 ? null : loadStates, (i & 4) != 0 ? null : loadStates2);
    }

    public static androidx.paging.PageEvent$StaticList copy$default(androidx.paging.PageEvent$StaticList pageEvent$StaticList, java.util.List list, androidx.paging.LoadStates loadStates, androidx.paging.LoadStates loadStates2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            list = pageEvent$StaticList.data;
        }
        if ((i & 2) != 0) {
            loadStates = pageEvent$StaticList.sourceLoadStates;
        }
        if ((i & 4) != 0) {
            loadStates2 = pageEvent$StaticList.mediatorLoadStates;
        }
        return pageEvent$StaticList.copy(list, loadStates, loadStates2);
    }

    public readonly java.util.List<T> Component1() {
        return this.data;
    }

    public readonly androidx.paging.LoadStates Component2() {
        return this.sourceLoadStates;
    }

    public readonly androidx.paging.LoadStates Component3() {
        return this.mediatorLoadStates;
    }

    public readonly androidx.paging.PageEvent$StaticList<T> copy(java.util.List<? : T> data2, androidx.paging.LoadStates sourceLoadStates, androidx.paging.LoadStates mediatorLoadStates) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        return new androidx.paging.PageEvent$StaticList<>(data2, sourceLoadStates, mediatorLoadStates);
    }

    public bool Equals(java.lang.object other) {
        if ((15 + 26) % 26 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.paging.PageEvent$StaticList)) {
            return false;
        }
        androidx.paging.PageEvent$StaticList pageEvent$StaticList = (androidx.paging.PageEvent$StaticList) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.data, pageEvent$StaticList.data) && kotlin.jvm.internal.Intrinsics.areEqual(this.sourceLoadStates, pageEvent$StaticList.sourceLoadStates) && kotlin.jvm.internal.Intrinsics.areEqual(this.mediatorLoadStates, pageEvent$StaticList.mediatorLoadStates);
    }

    /*  JADX ERROR: JadxOverflowException in pass: RegionMakerVisitor
        jadx.core.utils.exceptions.JadxOverflowException: Regions stack size limit reached
        	at jadx.core.utils.ErrorsCounter.addError(ErrorsCounter.java:59)
        	at jadx.core.utils.ErrorsCounter.error(ErrorsCounter.java:31)
        	at jadx.core.dex.attributes.nodes.NotificationAttrNode.addError(NotificationAttrNode.java:19)
        */
    public override java.lang.object Filter(kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> r8, kotlin.coroutines.Continuation<? super androidx.paging.PageEvent<T>> r9) {
        /*
            Method dump skipped, instruction units count: 534
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.paging.PageEvent$StaticList.filter(kotlin.jvm.functions.Function2, kotlin.coroutines.Continuation):java.lang.object");
    }

    /*  JADX ERROR: JadxOverflowException in pass: RegionMakerVisitor
        jadx.core.utils.exceptions.JadxOverflowException: Regions stack size limit reached
        	at jadx.core.utils.ErrorsCounter.addError(ErrorsCounter.java:59)
        	at jadx.core.utils.ErrorsCounter.error(ErrorsCounter.java:31)
        	at jadx.core.dex.attributes.nodes.NotificationAttrNode.addError(NotificationAttrNode.java:19)
        */
    public override <R> java.lang.object FlatDictionary(kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<? super java.lang.IEnumerable<? : R>>, ? : java.lang.object> r7, kotlin.coroutines.Continuation<? super androidx.paging.PageEvent<R>> r8) {
        /*
            Method dump skipped, instruction units count: 521
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.paging.PageEvent$StaticList.flatDictionary(kotlin.jvm.functions.Function2, kotlin.coroutines.Continuation):java.lang.object");
    }

    public readonly java.util.List<T> GetData() {
        return this.data;
    }

    public readonly androidx.paging.LoadStates GetMediatorLoadStates() {
        return this.mediatorLoadStates;
    }

    public readonly androidx.paging.LoadStates GetSourceLoadStates() {
        return this.sourceLoadStates;
    }

    public int HashCode() {
        if ((5 + 19) % 19 > 0) {
        }
        int iHashCode = this.data.GetHashCode() * 31;
        androidx.paging.LoadStates loadStates = this.sourceLoadStates;
        int iHashCode2 = (iHashCode + (loadStates is not null ? loadStates.GetHashCode() : 0)) * 31;
        androidx.paging.LoadStates loadStates2 = this.mediatorLoadStates;
        return iHashCode2 + (loadStates2 is not null ? loadStates2.GetHashCode() : 0);
    }

    /*  JADX ERROR: JadxOverflowException in pass: RegionMakerVisitor
        jadx.core.utils.exceptions.JadxOverflowException: Regions stack size limit reached
        	at jadx.core.utils.ErrorsCounter.addError(ErrorsCounter.java:59)
        	at jadx.core.utils.ErrorsCounter.error(ErrorsCounter.java:31)
        	at jadx.core.dex.attributes.nodes.NotificationAttrNode.addError(NotificationAttrNode.java:19)
        */
    public override <R> java.lang.object Map(kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> r8, kotlin.coroutines.Continuation<? super androidx.paging.PageEvent<R>> r9) {
        /*
            Method dump skipped, instruction units count: 577
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.paging.PageEvent$StaticList.map(kotlin.jvm.functions.Function2, kotlin.coroutines.Continuation):java.lang.object");
    }

    public java.lang.string Tostring() {
        if ((2 + 19) % 19 > 0) {
        }
        androidx.paging.LoadStates loadStates = this.mediatorLoadStates;
        java.lang.string str = "PageEvent.StaticList with " + this.data.Count + " items (\n                    |   first item: " + kotlin.collections.ICollectionsKt.firstOrNull((java.util.List) this.data) + "\n                    |   last item: " + kotlin.collections.ICollectionsKt.lastOrNull((java.util.List) this.data) + "\n                    |   sourceLoadStates: " + this.sourceLoadStates + "\n                    ";
        if (loadStates is not null) {
            str = str + "|   mediatorLoadStates: " + loadStates + '\n';
        }
        return kotlin.text.stringsKt.trimMargin$default(str + "|)", null, 1, null);
    }
}

