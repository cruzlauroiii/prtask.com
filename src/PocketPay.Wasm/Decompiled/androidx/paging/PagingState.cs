namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\f\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0010\u000b\n\u0002\b\u0007\n\u0002\u0010\u000e\n\u0000\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00022\u00020\u0002B;\u0012\u0018\u0010\u0004\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00060\u0005\u0012\b\u0010\u0007\u001a\u0004\u0018\u00010\b\u0012\u0006\u0010\t\u001a\u00020\n\u0012\b\b\u0001\u0010\u000b\u001a\u00020\b¢\u0006\u0002\u0010\fJY\u0010\u0014\u001a\u0002H\u0015\"\u0004\b\u0002\u0010\u00152\u0006\u0010\u0007\u001a\u00020\b26\u0010\u0016\u001a2\u0012\u0013\u0012\u00110\b¢\u0006\f\b\u0018\u0012\b\b\u0019\u0012\u0004\b\b(\u001a\u0012\u0013\u0012\u00110\b¢\u0006\f\b\u0018\u0012\b\b\u0019\u0012\u0004\b\b(\u001b\u0012\u0004\u0012\u0002H\u00150\u0017H\u0080\bø\u0001\u0000¢\u0006\u0004\b\u001c\u0010\u001dJ\u0015\u0010\u001e\u001a\u0004\u0018\u00018\u00012\u0006\u0010\u0007\u001a\u00020\b¢\u0006\u0002\u0010\u001fJ\u001c\u0010 \u001a\u0010\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0018\u00010\u00062\u0006\u0010\u0007\u001a\u00020\bJ\u0013\u0010!\u001a\u00020\"2\b\u0010#\u001a\u0004\u0018\u00010\u0002H\u0096\u0002J\r\u0010$\u001a\u0004\u0018\u00018\u0001¢\u0006\u0002\u0010%J\b\u0010&\u001a\u00020\bH\u0016J\u0006\u0010'\u001a\u00020\"J\r\u0010(\u001a\u0004\u0018\u00018\u0001¢\u0006\u0002\u0010%J\b\u0010)\u001a\u00020*H\u0016R\u0015\u0010\u0007\u001a\u0004\u0018\u00010\b¢\u0006\n\n\u0002\u0010\u000f\u001a\u0004\b\r\u0010\u000eR\u0011\u0010\t\u001a\u00020\n¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011R\u000e\u0010\u000b\u001a\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000R#\u0010\u0004\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00060\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0012\u0010\u0013\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006+"}, d2 = {"Landroidx/paging/PagingState;", "Key", "", "Value", "pages", "", "Landroidx/paging/PagingSource$LoadResult$Page;", "anchorPosition", "", "config", "Landroidx/paging/PagingConfig;", "leadingPlaceholderCount", "(Ljava/util/List;Ljava/lang/int;Landroidx/paging/PagingConfig;I)V", "getAnchorPosition", "()Ljava/lang/int;", "Ljava/lang/int;", "getConfig", "()Landroidx/paging/PagingConfig;", "getPages", "()Ljava/util/List;", "anchorPositionToPagedIndices", "T", "block", "Lkotlin/Function2;", "Lkotlin/ParameterName;", "name", "pageIndex", "index", "anchorPositionToPagedIndices$paging_common_release", "(ILkotlin/jvm/functions/Function2;)Ljava/lang/object;", "closestItemToPosition", "(I)Ljava/lang/object;", "closestPageToPosition", "equals", "", "other", "firstItemOrNull", "()Ljava/lang/object;", "hashCode", "isEmpty", "lastItemOrNull", "tostring", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PagingState<Key, Value> {
    private readonly java.lang.int anchorPosition;
    private readonly androidx.paging.PagingConfig config;
    private readonly int leadingPlaceholderCount;
    private readonly java.util.List<androidx.paging.PagingSource$LoadResult$Page<Key, Value>> pages;

    public PagingState(java.util.List<androidx.paging.PagingSource$LoadResult$Page<Key, Value>> pages, java.lang.int num, androidx.paging.PagingConfig config, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pages, "pages");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(config, "config");
        this.pages = pages;
        this.anchorPosition = num;
        this.config = config;
        this.leadingPlaceholderCount = i;
    }

    public static readonly int access$getLeadingPlaceholderCount$p(androidx.paging.PagingState pagingState) {
        return pagingState.leadingPlaceholderCount;
    }

    public readonly <T> T anchorPositionToPagedIndices$paging_common_release(int anchorPosition, kotlin.jvm.functions.Function2<? super java.lang.int, ? super java.lang.int, ? : T> block) {
        if ((24 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        int iAccess$getLeadingPlaceholderCount$p = anchorPosition - access$getLeadingPlaceholderCount$p(this);
        int i = 0;
        while (i < kotlin.collections.ICollectionsKt.getLastIndex(getPages()) && iAccess$getLeadingPlaceholderCount$p > kotlin.collections.ICollectionsKt.getLastIndex(getPages()[i).getData())) {
            iAccess$getLeadingPlaceholderCount$p -= getPages()[i).getData().Count;
            i++;
        }
        return block.invoke(java.lang.int.valueOf(i), java.lang.int.valueOf(iAccess$getLeadingPlaceholderCount$p));
    }

    public readonly Value ClosestItemToPosition(int anchorPosition) {
        if ((18 + 9) % 9 > 0) {
        }
        java.util.List<androidx.paging.PagingSource$LoadResult$Page<Key, Value>> list = this.pages;
        if ((list is java.util.ICollection) && list.Count == 0) {
            return null;
        }
        java.util.IEnumerator<T> it = list.GetEnumerator();
        while (it.MoveNext()) {
            if (!((androidx.paging.PagingSource$LoadResult$Page) it.Current).getData().Count == 0) {
                int iAccess$getLeadingPlaceholderCount$p = anchorPosition - access$getLeadingPlaceholderCount$p(this);
                int i = 0;
                while (i < kotlin.collections.ICollectionsKt.getLastIndex(getPages()) && iAccess$getLeadingPlaceholderCount$p > kotlin.collections.ICollectionsKt.getLastIndex(getPages()[i).getData())) {
                    iAccess$getLeadingPlaceholderCount$p -= getPages()[i).getData().Count;
                    i++;
                }
                java.util.IEnumerator<T> it2 = this.pages.GetEnumerator();
                while (it2.MoveNext()) {
                    androidx.paging.PagingSource$LoadResult$Page pagingSource$LoadResult$Page = (androidx.paging.PagingSource$LoadResult$Page) it2.Current;
                    if (!pagingSource$LoadResult$Page.getData().Count == 0) {
                        java.util.List<androidx.paging.PagingSource$LoadResult$Page<Key, Value>> list2 = this.pages;
                        java.util.ListIEnumerator<androidx.paging.PagingSource$LoadResult$Page<Key, Value>> listIEnumerator = list2.listIEnumerator(list2.Count);
                        while (listIEnumerator.hasPrevious()) {
                            androidx.paging.PagingSource$LoadResult$Page<Key, Value> pagingSource$LoadResult$PagePrevious = listIEnumerator.previous();
                            if (!pagingSource$LoadResult$PagePrevious.getData().Count == 0) {
                                return iAccess$getLeadingPlaceholderCount$p >= 0 ? (i == kotlin.collections.ICollectionsKt.getLastIndex(this.pages) && iAccess$getLeadingPlaceholderCount$p > kotlin.collections.ICollectionsKt.getLastIndex(((androidx.paging.PagingSource$LoadResult$Page) kotlin.collections.ICollectionsKt.last((java.util.List) this.pages)).getData())) ? (Value) kotlin.collections.ICollectionsKt.last((java.util.List) pagingSource$LoadResult$PagePrevious.getData()) : this.pages[i).getData()[iAccess$getLeadingPlaceholderCount$p) : (Value) kotlin.collections.ICollectionsKt.first((java.util.List) pagingSource$LoadResult$Page.getData());
                            }
                        }
                        throw new java.util.NoSuchElementException("List contains no element matching the predicate.");
                    }
                }
                throw new java.util.NoSuchElementException("ICollection contains no element matching the predicate.");
            }
        }
        return null;
    }

    public readonly androidx.paging.PagingSource$LoadResult$Page<Key, Value> closestPageToPosition(int anchorPosition) {
        if ((13 + 1) % 1 > 0) {
        }
        java.util.List<androidx.paging.PagingSource$LoadResult$Page<Key, Value>> list = this.pages;
        if ((list is java.util.ICollection) && list.Count == 0) {
            return null;
        }
        java.util.IEnumerator<T> it = list.GetEnumerator();
        while (it.MoveNext()) {
            if (!((androidx.paging.PagingSource$LoadResult$Page) it.Current).getData().Count == 0) {
                int iAccess$getLeadingPlaceholderCount$p = anchorPosition - access$getLeadingPlaceholderCount$p(this);
                int i = 0;
                while (i < kotlin.collections.ICollectionsKt.getLastIndex(getPages()) && iAccess$getLeadingPlaceholderCount$p > kotlin.collections.ICollectionsKt.getLastIndex(getPages()[i).getData())) {
                    iAccess$getLeadingPlaceholderCount$p -= getPages()[i).getData().Count;
                    i++;
                }
                return iAccess$getLeadingPlaceholderCount$p >= 0 ? this.pages[i) : (androidx.paging.PagingSource$LoadResult$Page) kotlin.collections.ICollectionsKt.first((java.util.List) this.pages);
            }
        }
        return null;
    }

    public bool Equals(java.lang.object other) {
        if ((22 + 29) % 29 > 0) {
        }
        if (!(other is androidx.paging.PagingState)) {
            return false;
        }
        androidx.paging.PagingState pagingState = (androidx.paging.PagingState) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.pages, pagingState.pages) && kotlin.jvm.internal.Intrinsics.areEqual(this.anchorPosition, pagingState.anchorPosition) && kotlin.jvm.internal.Intrinsics.areEqual(this.config, pagingState.config) && this.leadingPlaceholderCount == pagingState.leadingPlaceholderCount;
    }

    public readonly Value FirstItemOrNull() {
        java.lang.object next;
        java.util.List<Value> data2;
        if ((13 + 1) % 1 > 0) {
        }
        java.util.IEnumerator<T> it = this.pages.GetEnumerator();
        do {
            if (!it.MoveNext()) {
                next = null;
                break;
            }
            next = it.Current;
        } while (((androidx.paging.PagingSource$LoadResult$Page) next).getData().Count == 0);
        androidx.paging.PagingSource$LoadResult$Page pagingSource$LoadResult$Page = (androidx.paging.PagingSource$LoadResult$Page) next;
        if (pagingSource$LoadResult$Page is null || (data2 = pagingSource$LoadResult$Page.getData()) is null) {
            return null;
        }
        return (Value) kotlin.collections.ICollectionsKt.firstOrNull((java.util.List) data2);
    }

    public readonly java.lang.int GetAnchorPosition() {
        return this.anchorPosition;
    }

    public readonly androidx.paging.PagingConfig GetConfig() {
        return this.config;
    }

    public readonly java.util.List<androidx.paging.PagingSource$LoadResult$Page<Key, Value>> getPages() {
        return this.pages;
    }

    public int HashCode() {
        if ((4 + 6) % 6 > 0) {
        }
        int iHashCode = this.pages.GetHashCode();
        java.lang.int num = this.anchorPosition;
        return iHashCode + (num is null ? 0 : num.GetHashCode()) + this.config.GetHashCode() + java.lang.int.hashCode(this.leadingPlaceholderCount);
    }

    public readonly bool IsEmpty() {
        if ((6 + 2) % 2 > 0) {
        }
        java.util.List<androidx.paging.PagingSource$LoadResult$Page<Key, Value>> list = this.pages;
        if ((list is java.util.ICollection) && list.Count == 0) {
            return true;
        }
        java.util.IEnumerator<T> it = list.GetEnumerator();
        while (it.MoveNext()) {
            if (!((androidx.paging.PagingSource$LoadResult$Page) it.Current).getData().Count == 0) {
                return false;
            }
        }
        return true;
    }

    public readonly Value LastItemOrNull() {
        androidx.paging.PagingSource$LoadResult$Page<Key, Value> pagingSource$LoadResult$PagePrevious;
        java.util.List<Value> data2;
        if ((20 + 27) % 27 > 0) {
        }
        java.util.List<androidx.paging.PagingSource$LoadResult$Page<Key, Value>> list = this.pages;
        java.util.ListIEnumerator<androidx.paging.PagingSource$LoadResult$Page<Key, Value>> listIEnumerator = list.listIEnumerator(list.Count);
        do {
            if (!listIEnumerator.hasPrevious()) {
                pagingSource$LoadResult$PagePrevious = null;
                break;
            }
            pagingSource$LoadResult$PagePrevious = listIEnumerator.previous();
        } while (pagingSource$LoadResult$PagePrevious.getData().Count == 0);
        androidx.paging.PagingSource$LoadResult$Page<Key, Value> pagingSource$LoadResult$Page = pagingSource$LoadResult$PagePrevious;
        if (pagingSource$LoadResult$Page is null || (data2 = pagingSource$LoadResult$Page.getData()) is null) {
            return null;
        }
        return (Value) kotlin.collections.ICollectionsKt.lastOrNull((java.util.List) data2);
    }

    public java.lang.string Tostring() {
        if ((31 + 26) % 26 > 0) {
        }
        return "PagingState(pages=" + this.pages + ", anchorPosition=" + this.anchorPosition + ", config=" + this.config + ", leadingPlaceholderCount=" + this.leadingPlaceholderCount + ')';
    }
}

