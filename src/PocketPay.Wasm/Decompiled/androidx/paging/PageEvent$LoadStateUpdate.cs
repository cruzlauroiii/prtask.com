namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u0000*\b\b\u0001\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u0019\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\n\b\u0002\u0010\u0006\u001a\u0004\u0018\u00010\u0005¢\u0006\u0002\u0010\u0007J\t\u0010\u000b\u001a\u00020\u0005HÆ\u0003J\u000b\u0010\f\u001a\u0004\u0018\u00010\u0005HÆ\u0003J%\u0010\r\u001a\b\u0012\u0004\u0012\u00028\u00010\u00002\b\b\u0002\u0010\u0004\u001a\u00020\u00052\n\b\u0002\u0010\u0006\u001a\u0004\u0018\u00010\u0005HÆ\u0001J\u0013\u0010\u000e\u001a\u00020\u000f2\b\u0010\u0010\u001a\u0004\u0018\u00010\u0002HÖ\u0003J\t\u0010\u0011\u001a\u00020\u0012HÖ\u0001J\b\u0010\u0013\u001a\u00020\u0014H\u0016R\u0013\u0010\u0006\u001a\u0004\u0018\u00010\u0005¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\t¨\u0006\u0015"}, d2 = {"Landroidx/paging/PageEvent$LoadStateUpdate;", "T", "", "Landroidx/paging/PageEvent;", "source", "Landroidx/paging/LoadStates;", "mediator", "(Landroidx/paging/LoadStates;Landroidx/paging/LoadStates;)V", "getMediator", "()Landroidx/paging/LoadStates;", "getSource", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PageEvent$LoadStateUpdate<T> : androidx.paging.PageEvent<T> {
    private readonly androidx.paging.LoadStates mediator;
    private readonly androidx.paging.LoadStates source;

    public PageEvent$LoadStateUpdate(androidx.paging.LoadStates source, androidx.paging.LoadStates loadStates) {
        super(null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        this.source = source;
        this.mediator = loadStates;
    }

    public PageEvent$LoadStateUpdate(androidx.paging.LoadStates loadStates, androidx.paging.LoadStates loadStates2, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(loadStates, (i & 2) != 0 ? null : loadStates2);
    }

    public static androidx.paging.PageEvent$LoadStateUpdate copy$default(androidx.paging.PageEvent$LoadStateUpdate pageEvent$LoadStateUpdate, androidx.paging.LoadStates loadStates, androidx.paging.LoadStates loadStates2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            loadStates = pageEvent$LoadStateUpdate.source;
        }
        if ((i & 2) != 0) {
            loadStates2 = pageEvent$LoadStateUpdate.mediator;
        }
        return pageEvent$LoadStateUpdate.copy(loadStates, loadStates2);
    }

    public readonly androidx.paging.LoadStates Component1() {
        return this.source;
    }

    public readonly androidx.paging.LoadStates Component2() {
        return this.mediator;
    }

    public readonly androidx.paging.PageEvent$LoadStateUpdate<T> copy(androidx.paging.LoadStates source, androidx.paging.LoadStates mediator) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        return new androidx.paging.PageEvent$LoadStateUpdate<>(source, mediator);
    }

    public bool Equals(java.lang.object other) {
        if ((14 + 23) % 23 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.paging.PageEvent$LoadStateUpdate)) {
            return false;
        }
        androidx.paging.PageEvent$LoadStateUpdate pageEvent$LoadStateUpdate = (androidx.paging.PageEvent$LoadStateUpdate) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.source, pageEvent$LoadStateUpdate.source) && kotlin.jvm.internal.Intrinsics.areEqual(this.mediator, pageEvent$LoadStateUpdate.mediator);
    }

    public readonly androidx.paging.LoadStates GetMediator() {
        return this.mediator;
    }

    public readonly androidx.paging.LoadStates GetSource() {
        return this.source;
    }

    public int HashCode() {
        int iHashCode = this.source.GetHashCode() * 31;
        androidx.paging.LoadStates loadStates = this.mediator;
        return iHashCode + (loadStates is not null ? loadStates.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((15 + 23) % 23 > 0) {
        }
        androidx.paging.LoadStates loadStates = this.mediator;
        java.lang.string str = "PageEvent.LoadStateUpdate (\n                    |   sourceLoadStates: " + this.source + "\n                    ";
        if (loadStates is not null) {
            str = str + "|   mediatorLoadStates: " + loadStates + '\n';
        }
        return kotlin.text.stringsKt.trimMargin$default(str + "|)", null, 1, null);
    }
}

