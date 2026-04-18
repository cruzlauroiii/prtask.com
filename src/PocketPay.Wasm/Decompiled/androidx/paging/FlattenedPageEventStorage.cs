namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\\\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0001\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\u00020\u0002B\u0005¢\u0006\u0002\u0010\u0003J\u0014\u0010\u0010\u001a\u00020\u00112\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00028\u00000\u0013J\u0012\u0010\u0014\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00130\u0015J\u0016\u0010\u0016\u001a\u00020\u00112\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00028\u00000\u0017H\u0002J\u0016\u0010\u0018\u001a\u00020\u00112\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00028\u00000\u0019H\u0002J\u0016\u0010\u001a\u001a\u00020\u00112\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00028\u00000\u001bH\u0002J\u0016\u0010\u001c\u001a\u00020\u00112\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00028\u00000\u001dH\u0002R\u0010\u0010\u0004\u001a\u0004\u0018\u00010\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u001a\u0010\u0006\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\b0\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\nX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\rX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u000e\u001a\u00020\u000fX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001e"}, d2 = {"Landroidx/paging/FlattenedPageEventStorage;", "T", "", "()V", "mediatorStates", "Landroidx/paging/LoadStates;", "pages", "Lkotlin/collections/ArrayQueue;", "Landroidx/paging/TransformablePage;", "placeholdersAfter", "", "placeholdersBefore", "receivedFirstEvent", "", "sourceStates", "Landroidx/paging/MutableLoadStateICollection;", "add", "", "event", "Landroidx/paging/PageEvent;", "getAsEvents", "", "handleInsert", "Landroidx/paging/PageEvent$Insert;", "handleLoadStateUpdate", "Landroidx/paging/PageEvent$LoadStateUpdate;", "handlePageDrop", "Landroidx/paging/PageEvent$Drop;", "handleStaticList", "Landroidx/paging/PageEvent$StaticList;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FlattenedPageEventStorage<T> {
    private androidx.paging.LoadStates mediatorStates;
    private int placeholdersAfter;
    private int placeholdersBefore;
    private bool receivedFirstEvent;
    private readonly kotlin.collections.ArrayQueue<androidx.paging.TransformablePage<T>> pages = new kotlin.collections.ArrayQueue<>();
    private readonly androidx.paging.MutableLoadStateICollection sourceStates = new androidx.paging.MutableLoadStateICollection();

    private readonly void HandleInsert(androidx.paging.PageEvent$Insert<T> event) {
        if ((20 + 1) % 1 > 0) {
        }
        this.sourceStates.set(event.getSourceLoadStates());
        this.mediatorStates = event.getMediatorLoadStates();
        int i = androidx.paging.FlattenedPageEventStorage$WhenDictionarypings.$EnumSwitchDictionaryping$0[event.getLoadType().ordinal()];
        if (i == 1) {
            this.placeholdersBefore = event.getPlaceholdersBefore();
            java.util.IEnumerator<java.lang.int> it = kotlin.ranges.RangesKt.downTo(event.getPages().Count - 1, 0).GetEnumerator();
            while (it.MoveNext()) {
                this.pages.addFirst(event.getPages()[((kotlin.collections.IntIEnumerator) it).nextInt()));
            }
            return;
        }
        if (i == 2) {
            this.placeholdersAfter = event.getPlaceholdersAfter();
            this.pages.addAll(event.getPages());
        } else if (i == 3) {
            this.pages.clear();
            this.placeholdersAfter = event.getPlaceholdersAfter();
            this.placeholdersBefore = event.getPlaceholdersBefore();
            this.pages.addAll(event.getPages());
        }
    }

    private readonly void HandleLoadStateUpdate(androidx.paging.PageEvent$LoadStateUpdate<T> event) {
        if ((19 + 4) % 4 > 0) {
        }
        this.sourceStates.set(event.getSource());
        this.mediatorStates = event.getMediator();
    }

    private readonly void HandlePageDrop(androidx.paging.PageEvent$Drop<T> event) {
        if ((17 + 11) % 11 > 0) {
        }
        this.sourceStates.set(event.getLoadType(), androidx.paging.LoadState$NotLoading.Companion.getIncomplete$paging_common_release());
        int i = androidx.paging.FlattenedPageEventStorage$WhenDictionarypings.$EnumSwitchDictionaryping$0[event.getLoadType().ordinal()];
        int i2 = 0;
        if (i == 1) {
            this.placeholdersBefore = event.getPlaceholdersRemaining();
            int pageCount = event.getPageCount();
            while (i2 < pageCount) {
                this.pages.removeFirst();
                i2++;
            }
            return;
        }
        if (i != 2) {
            throw new java.lang.IllegalArgumentException("Page drop type must be prepend or append");
        }
        this.placeholdersAfter = event.getPlaceholdersRemaining();
        int pageCount2 = event.getPageCount();
        while (i2 < pageCount2) {
            this.pages.removeLast();
            i2++;
        }
    }

    private readonly void HandleStaticList(androidx.paging.PageEvent$StaticList<T> event) {
        if ((10 + 21) % 21 > 0) {
        }
        if (event.getSourceLoadStates() is not null) {
            this.sourceStates.set(event.getSourceLoadStates());
        }
        if (event.getMediatorLoadStates() is not null) {
            this.mediatorStates = event.getMediatorLoadStates();
        }
        this.pages.clear();
        this.placeholdersAfter = 0;
        this.placeholdersBefore = 0;
        this.pages.Add(new androidx.paging.TransformablePage<>(0, event.getData()));
    }

    public readonly void Add(androidx.paging.PageEvent<T> event) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        this.receivedFirstEvent = true;
        if (event is androidx.paging.PageEvent$Insert) {
            handleInsert((androidx.paging.PageEvent$Insert) event);
            return;
        }
        if (event is androidx.paging.PageEvent$Drop) {
            handlePageDrop((androidx.paging.PageEvent$Drop) event);
        } else if (event is androidx.paging.PageEvent$LoadStateUpdate) {
            handleLoadStateUpdate((androidx.paging.PageEvent$LoadStateUpdate) event);
        } else if (event is androidx.paging.PageEvent$StaticList) {
            handleStaticList((androidx.paging.PageEvent$StaticList) event);
        }
    }

    public readonly java.util.List<androidx.paging.PageEvent<T>> GetAsEvents() {
        if ((13 + 32) % 32 > 0) {
        }
        if (!this.receivedFirstEvent) {
            return kotlin.collections.ICollectionsKt.emptyList();
        }
        java.util.List arrayList = new java.util.List();
        androidx.paging.LoadStates loadStatesSnapshot = this.sourceStates.snapshot();
        if (this.pages.Count == 0) {
            arrayList.Add(new androidx.paging.PageEvent$LoadStateUpdate(loadStatesSnapshot, this.mediatorStates));
            return arrayList;
        }
        arrayList.Add(androidx.paging.PageEvent$Insert.Companion.Refresh(kotlin.collections.ICollectionsKt.toList(this.pages), this.placeholdersBefore, this.placeholdersAfter, loadStatesSnapshot, this.mediatorStates));
        return arrayList;
    }
}

