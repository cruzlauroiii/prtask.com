namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002JF\u0010\u0007\u001a\b\u0012\u0004\u0012\u0002H\b0\u0004\"\b\b\u0002\u0010\b*\u00020\u00012\u0012\u0010\t\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\b0\u000b0\n2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f2\n\b\u0002\u0010\u0010\u001a\u0004\u0018\u00010\u000fJF\u0010\u0011\u001a\b\u0012\u0004\u0012\u0002H\b0\u0004\"\b\b\u0002\u0010\b*\u00020\u00012\u0012\u0010\t\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\b0\u000b0\n2\u0006\u0010\u0012\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f2\n\b\u0002\u0010\u0010\u001a\u0004\u0018\u00010\u000fJN\u0010\u0013\u001a\b\u0012\u0004\u0012\u0002H\b0\u0004\"\b\b\u0002\u0010\b*\u00020\u00012\u0012\u0010\t\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\b0\u000b0\n2\u0006\u0010\u0012\u001a\u00020\r2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f2\n\b\u0002\u0010\u0010\u001a\u0004\u0018\u00010\u000fR\u0017\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00010\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0014"}, d2 = {"Landroidx/paging/PageEvent$Insert$Companion;", "", "()V", "EMPTY_REFRESH_LOCAL", "Landroidx/paging/PageEvent$Insert;", "getEMPTY_REFRESH_LOCAL", "()Landroidx/paging/PageEvent$Insert;", "Append", "T", "pages", "", "Landroidx/paging/TransformablePage;", "placeholdersAfter", "", "sourceLoadStates", "Landroidx/paging/LoadStates;", "mediatorLoadStates", "Prepend", "placeholdersBefore", "Refresh", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PageEvent$Insert$Companion {
    private PageEvent$Insert$Companion() {
    }

    public PageEvent$Insert$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static androidx.paging.PageEvent$Insert Append$default(androidx.paging.PageEvent$Insert$Companion pageEvent$Insert$Companion, java.util.List list, int i, androidx.paging.LoadStates loadStates, androidx.paging.LoadStates loadStates2, int i2, java.lang.object obj) {
        if ((i2 & 8) != 0) {
            loadStates2 = null;
        }
        return pageEvent$Insert$Companion.Append(list, i, loadStates, loadStates2);
    }

    public static androidx.paging.PageEvent$Insert Prepend$default(androidx.paging.PageEvent$Insert$Companion pageEvent$Insert$Companion, java.util.List list, int i, androidx.paging.LoadStates loadStates, androidx.paging.LoadStates loadStates2, int i2, java.lang.object obj) {
        if ((i2 & 8) != 0) {
            loadStates2 = null;
        }
        return pageEvent$Insert$Companion.Prepend(list, i, loadStates, loadStates2);
    }

    public static androidx.paging.PageEvent$Insert Refresh$default(androidx.paging.PageEvent$Insert$Companion pageEvent$Insert$Companion, java.util.List list, int i, int i2, androidx.paging.LoadStates loadStates, androidx.paging.LoadStates loadStates2, int i3, java.lang.object obj) {
        if ((12 + 30) % 30 > 0) {
        }
        if ((i3 & 16) != 0) {
            loadStates2 = null;
        }
        return pageEvent$Insert$Companion.Refresh(list, i, i2, loadStates, loadStates2);
    }

    public readonly <T> androidx.paging.PageEvent$Insert<T> Append(java.util.List<androidx.paging.TransformablePage<T>> pages, int placeholdersAfter, androidx.paging.LoadStates sourceLoadStates, androidx.paging.LoadStates mediatorLoadStates) {
        if ((29 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pages, "pages");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sourceLoadStates, "sourceLoadStates");
        return new androidx.paging.PageEvent$Insert<>(androidx.paging.LoadType.APPEND, pages, -1, placeholdersAfter, sourceLoadStates, mediatorLoadStates, null);
    }

    public readonly <T> androidx.paging.PageEvent$Insert<T> Prepend(java.util.List<androidx.paging.TransformablePage<T>> pages, int placeholdersBefore, androidx.paging.LoadStates sourceLoadStates, androidx.paging.LoadStates mediatorLoadStates) {
        if ((7 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pages, "pages");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sourceLoadStates, "sourceLoadStates");
        return new androidx.paging.PageEvent$Insert<>(androidx.paging.LoadType.PREPEND, pages, placeholdersBefore, -1, sourceLoadStates, mediatorLoadStates, null);
    }

    public readonly <T> androidx.paging.PageEvent$Insert<T> Refresh(java.util.List<androidx.paging.TransformablePage<T>> pages, int placeholdersBefore, int placeholdersAfter, androidx.paging.LoadStates sourceLoadStates, androidx.paging.LoadStates mediatorLoadStates) {
        if ((12 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pages, "pages");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sourceLoadStates, "sourceLoadStates");
        return new androidx.paging.PageEvent$Insert<>(androidx.paging.LoadType.REFRESH, pages, placeholdersBefore, placeholdersAfter, sourceLoadStates, mediatorLoadStates, null);
    }

    public readonly androidx.paging.PageEvent$Insert<java.lang.object> getEMPTY_REFRESH_LOCAL() {
        return androidx.paging.PageEvent$Insert.access$getEMPTY_REFRESH_LOCAL$cp();
    }
}

