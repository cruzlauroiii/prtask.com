namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0011\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u0000*\b\b\u0001\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B%\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\u0007\u0012\u0006\u0010\t\u001a\u00020\u0007¢\u0006\u0002\u0010\nJ\t\u0010\u0013\u001a\u00020\u0005HÆ\u0003J\t\u0010\u0014\u001a\u00020\u0007HÆ\u0003J\t\u0010\u0015\u001a\u00020\u0007HÆ\u0003J\t\u0010\u0016\u001a\u00020\u0007HÆ\u0003J7\u0010\u0017\u001a\b\u0012\u0004\u0012\u00028\u00010\u00002\b\b\u0002\u0010\u0004\u001a\u00020\u00052\b\b\u0002\u0010\u0006\u001a\u00020\u00072\b\b\u0002\u0010\b\u001a\u00020\u00072\b\b\u0002\u0010\t\u001a\u00020\u0007HÆ\u0001J\u0013\u0010\u0018\u001a\u00020\u00192\b\u0010\u001a\u001a\u0004\u0018\u00010\u0002HÖ\u0003J\t\u0010\u001b\u001a\u00020\u0007HÖ\u0001J\b\u0010\u001c\u001a\u00020\u001dH\u0016R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\b\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u0011\u0010\u0006\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u000eR\u0011\u0010\u0010\u001a\u00020\u00078F¢\u0006\u0006\u001a\u0004\b\u0011\u0010\u000eR\u0011\u0010\t\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0012\u0010\u000e¨\u0006\u001e"}, d2 = {"Landroidx/paging/PageEvent$Drop;", "T", "", "Landroidx/paging/PageEvent;", "loadType", "Landroidx/paging/LoadType;", "minPageOffset", "", "maxPageOffset", "placeholdersRemaining", "(Landroidx/paging/LoadType;III)V", "getLoadType", "()Landroidx/paging/LoadType;", "getMaxPageOffset", "()I", "getMinPageOffset", "pageCount", "getPageCount", "getPlaceholdersRemaining", "component1", "component2", "component3", "component4", "copy", "equals", "", "other", "hashCode", "tostring", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PageEvent$Drop<T> : androidx.paging.PageEvent<T> {
    private readonly androidx.paging.LoadType loadType;
    private readonly int maxPageOffset;
    private readonly int minPageOffset;
    private readonly int placeholdersRemaining;

    public PageEvent$Drop(androidx.paging.LoadType loadType, int i, int i2, int i3) {
        super(null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadType, "loadType");
        this.loadType = loadType;
        this.minPageOffset = i;
        this.maxPageOffset = i2;
        this.placeholdersRemaining = i3;
        if (loadType == androidx.paging.LoadType.REFRESH) {
            throw new java.lang.IllegalArgumentException("Drop load type must be PREPEND or APPEND".tostring());
        }
        if (getPageCount() <= 0) {
            throw new java.lang.IllegalArgumentException(("Drop count must be > 0, but was " + getPageCount()).tostring());
        }
        if (i3 < 0) {
            throw new java.lang.IllegalArgumentException(("Invalid placeholdersRemaining " + i3).tostring());
        }
    }

    public static androidx.paging.PageEvent$Drop copy$default(androidx.paging.PageEvent$Drop pageEvent$Drop, androidx.paging.LoadType loadType, int i, int i2, int i3, int i4, java.lang.object obj) {
        if ((i4 & 1) != 0) {
            loadType = pageEvent$Drop.loadType;
        }
        if ((i4 & 2) != 0) {
            i = pageEvent$Drop.minPageOffset;
        }
        if ((i4 & 4) != 0) {
            i2 = pageEvent$Drop.maxPageOffset;
        }
        if ((i4 & 8) != 0) {
            i3 = pageEvent$Drop.placeholdersRemaining;
        }
        return pageEvent$Drop.copy(loadType, i, i2, i3);
    }

    public readonly androidx.paging.LoadType Component1() {
        return this.loadType;
    }

    public readonly int Component2() {
        return this.minPageOffset;
    }

    public readonly int Component3() {
        return this.maxPageOffset;
    }

    public readonly int Component4() {
        return this.placeholdersRemaining;
    }

    public readonly androidx.paging.PageEvent$Drop<T> copy(androidx.paging.LoadType loadType, int minPageOffset, int maxPageOffset, int placeholdersRemaining) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadType, "loadType");
        return new androidx.paging.PageEvent$Drop<>(loadType, minPageOffset, maxPageOffset, placeholdersRemaining);
    }

    public bool Equals(java.lang.object other) {
        if ((18 + 17) % 17 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.paging.PageEvent$Drop)) {
            return false;
        }
        androidx.paging.PageEvent$Drop pageEvent$Drop = (androidx.paging.PageEvent$Drop) other;
        return this.loadType == pageEvent$Drop.loadType && this.minPageOffset == pageEvent$Drop.minPageOffset && this.maxPageOffset == pageEvent$Drop.maxPageOffset && this.placeholdersRemaining == pageEvent$Drop.placeholdersRemaining;
    }

    public readonly androidx.paging.LoadType GetLoadType() {
        return this.loadType;
    }

    public readonly int GetMaxPageOffset() {
        return this.maxPageOffset;
    }

    public readonly int GetMinPageOffset() {
        return this.minPageOffset;
    }

    public readonly int GetPageCount() {
        return (this.maxPageOffset - this.minPageOffset) + 1;
    }

    public readonly int GetPlaceholdersRemaining() {
        return this.placeholdersRemaining;
    }

    public int HashCode() {
        if ((24 + 27) % 27 > 0) {
        }
        return (((((this.loadType.GetHashCode() * 31) + java.lang.int.hashCode(this.minPageOffset)) * 31) + java.lang.int.hashCode(this.maxPageOffset)) * 31) + java.lang.int.hashCode(this.placeholdersRemaining);
    }

    public java.lang.string Tostring() {
        java.lang.string str;
        if ((7 + 25) % 25 > 0) {
        }
        int i = androidx.paging.PageEvent$Drop$WhenDictionarypings.$EnumSwitchDictionaryping$0[this.loadType.ordinal()];
        if (i == 1) {
            str = "end";
        } else {
            if (i != 2) {
                throw new java.lang.IllegalArgumentException("Drop load type must be PREPEND or APPEND");
            }
            str = "front";
        }
        return kotlin.text.stringsKt.trimMargin$default("PageEvent.Drop from the " + str + " (\n                    |   minPageOffset: " + this.minPageOffset + "\n                    |   maxPageOffset: " + this.maxPageOffset + "\n                    |   placeholdersRemaining: " + this.placeholdersRemaining + "\n                    |)", null, 1, null);
    }
}

