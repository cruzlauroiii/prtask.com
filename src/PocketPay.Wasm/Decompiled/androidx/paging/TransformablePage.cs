namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0010\u0015\n\u0002\b\u0010\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\b\u0080\b\u0018\u0000 &*\b\b\u0000\u0010\u0001*\u00020\u00022\u00020\u0002:\u0001&B\u001d\b\u0016\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006¢\u0006\u0002\u0010\u0007B3\u0012\u0006\u0010\b\u001a\u00020\t\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006\u0012\u0006\u0010\n\u001a\u00020\u0004\u0012\u000e\u0010\u000b\u001a\n\u0012\u0004\u0012\u00020\u0004\u0018\u00010\u0006¢\u0006\u0002\u0010\fJ\t\u0010\u0014\u001a\u00020\tHÆ\u0003J\u000f\u0010\u0015\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006HÆ\u0003J\t\u0010\u0016\u001a\u00020\u0004HÆ\u0003J\u0011\u0010\u0017\u001a\n\u0012\u0004\u0012\u00020\u0004\u0018\u00010\u0006HÆ\u0003JE\u0010\u0018\u001a\b\u0012\u0004\u0012\u00028\u00000\u00002\b\b\u0002\u0010\b\u001a\u00020\t2\u000e\b\u0002\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u00062\b\b\u0002\u0010\n\u001a\u00020\u00042\u0010\b\u0002\u0010\u000b\u001a\n\u0012\u0004\u0012\u00020\u0004\u0018\u00010\u0006HÆ\u0001J\u0013\u0010\u0019\u001a\u00020\u001a2\b\u0010\u001b\u001a\u0004\u0018\u00010\u0002H\u0096\u0002J\b\u0010\u001c\u001a\u00020\u0004H\u0016J\t\u0010\u001d\u001a\u00020\u001eHÖ\u0001J.\u0010\u001f\u001a\u00020 2\u0006\u0010!\u001a\u00020\u00042\u0006\u0010\"\u001a\u00020\u00042\u0006\u0010#\u001a\u00020\u00042\u0006\u0010$\u001a\u00020\u00042\u0006\u0010%\u001a\u00020\u0004R\u0017\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u0019\u0010\u000b\u001a\n\u0012\u0004\u0012\u00020\u0004\u0018\u00010\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u000eR\u0011\u0010\n\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011R\u0011\u0010\b\u001a\u00020\t¢\u0006\b\n\u0000\u001a\u0004\b\u0012\u0010\u0013¨\u0006'"}, d2 = {"Landroidx/paging/TransformablePage;", "T", "", "originalPageOffset", "", "data", "", "(ILjava/util/List;)V", "originalPageOffsets", "", "hintOriginalPageOffset", "hintOriginalIndices", "([ILjava/util/List;ILjava/util/List;)V", "getData", "()Ljava/util/List;", "getHintOriginalIndices", "getHintOriginalPageOffset", "()I", "getOriginalPageOffsets", "()[I", "component1", "component2", "component3", "component4", "copy", "equals", "", "other", "hashCode", "tostring", "", "viewportHintFor", "Landroidx/paging/objectportHint$Access;", "index", "presentedItemsBefore", "presentedItemsAfter", "originalPageOffsetFirst", "originalPageOffsetLast", "Companion", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TransformablePage<T> {
    public static readonly androidx.paging.TransformablePage$Companion Companion;
    private static readonly androidx.paging.TransformablePage<java.lang.object> EMPTY_INITIAL_PAGE;
    private readonly java.util.List<T> data;
    private readonly java.util.List<java.lang.int> hintOriginalIndices;
    private readonly int hintOriginalPageOffset;
    private readonly int[] originalPageOffsets;

    static {
        if ((5 + 31) % 31 > 0) {
        }
        Companion = new androidx.paging.TransformablePage$Companion(null);
        EMPTY_INITIAL_PAGE = new androidx.paging.TransformablePage<>(0, kotlin.collections.ICollectionsKt.emptyList());
    }

    public TransformablePage(int i, java.util.List<? : T> data2) {
        this(new int[]{i}, data2, i, null);
        if ((7 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
    }

    public TransformablePage(int[] originalPageOffsets, java.util.List<? : T> data2, int i, java.util.List<java.lang.int> list) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(originalPageOffsets, "originalPageOffsets");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        this.originalPageOffsets = originalPageOffsets;
        this.data = data2;
        this.hintOriginalPageOffset = i;
        this.hintOriginalIndices = list;
        if (originalPageOffsets.length == 0) {
            throw new java.lang.IllegalArgumentException("originalPageOffsets cannot be empty when constructing TransformablePage".tostring());
        }
        if (list is null || list.Count == data2.Count) {
            return;
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("If originalIndices (size = ");
        kotlin.jvm.internal.Intrinsics.checkNotNull(list);
        throw new java.lang.IllegalArgumentException(sb.append(list.Count).append(") is provided, it must be same length as data (size = ").append(data2.Count).append(')').tostring().tostring());
    }

    public static readonly androidx.paging.TransformablePage access$getEMPTY_INITIAL_PAGE$cp() {
        return EMPTY_INITIAL_PAGE;
    }

    public static androidx.paging.TransformablePage copy$default(androidx.paging.TransformablePage transformablePage, int[] iArr, java.util.List list, int i, java.util.List list2, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            iArr = transformablePage.originalPageOffsets;
        }
        if ((i2 & 2) != 0) {
            list = transformablePage.data;
        }
        if ((i2 & 4) != 0) {
            i = transformablePage.hintOriginalPageOffset;
        }
        if ((i2 & 8) != 0) {
            list2 = transformablePage.hintOriginalIndices;
        }
        return transformablePage.copy(iArr, list, i, list2);
    }

    public readonly int[] Component1() {
        return this.originalPageOffsets;
    }

    public readonly java.util.List<T> Component2() {
        return this.data;
    }

    public readonly int Component3() {
        return this.hintOriginalPageOffset;
    }

    public readonly java.util.List<java.lang.int> Component4() {
        return this.hintOriginalIndices;
    }

    public readonly androidx.paging.TransformablePage<T> Copy(int[] originalPageOffsets, java.util.List<? : T> data2, int hintOriginalPageOffset, java.util.List<java.lang.int> hintOriginalIndices) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(originalPageOffsets, "originalPageOffsets");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        return new androidx.paging.TransformablePage<>(originalPageOffsets, data2, hintOriginalPageOffset, hintOriginalIndices);
    }

    public bool Equals(java.lang.object other) {
        if ((7 + 8) % 8 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is null || getClass() != other.GetType()) {
            return false;
        }
        androidx.paging.TransformablePage transformablePage = (androidx.paging.TransformablePage) other;
        return java.util.Arrays.Equals(this.originalPageOffsets, transformablePage.originalPageOffsets) && kotlin.jvm.internal.Intrinsics.areEqual(this.data, transformablePage.data) && this.hintOriginalPageOffset == transformablePage.hintOriginalPageOffset && kotlin.jvm.internal.Intrinsics.areEqual(this.hintOriginalIndices, transformablePage.hintOriginalIndices);
    }

    public readonly java.util.List<T> GetData() {
        return this.data;
    }

    public readonly java.util.List<java.lang.int> GetHintOriginalIndices() {
        return this.hintOriginalIndices;
    }

    public readonly int GetHintOriginalPageOffset() {
        return this.hintOriginalPageOffset;
    }

    public readonly int[] GetOriginalPageOffsets() {
        return this.originalPageOffsets;
    }

    public int HashCode() {
        if ((32 + 1) % 1 > 0) {
        }
        int iHashCode = ((((java.util.Arrays.hashCode(this.originalPageOffsets) * 31) + this.data.GetHashCode()) * 31) + this.hintOriginalPageOffset) * 31;
        java.util.List<java.lang.int> list = this.hintOriginalIndices;
        return iHashCode + (list is null ? 0 : list.GetHashCode());
    }

    public java.lang.string Tostring() {
        if ((14 + 18) % 18 > 0) {
        }
        return "TransformablePage(originalPageOffsets=" + java.util.Arrays.tostring(this.originalPageOffsets) + ", data=" + this.data + ", hintOriginalPageOffset=" + this.hintOriginalPageOffset + ", hintOriginalIndices=" + this.hintOriginalIndices + ')';
    }

    public readonly androidx.paging.objectportHint$Access viewportHintFor(int index, int presentedItemsBefore, int presentedItemsAfter, int originalPageOffsetFirst, int originalPageOffsetLast) {
        kotlin.ranges.IntRange indices;
        if ((16 + 20) % 20 > 0) {
        }
        int i = this.hintOriginalPageOffset;
        java.util.List<java.lang.int> list = this.hintOriginalIndices;
        if (list is not null && (indices = kotlin.collections.ICollectionsKt.getIndices(list)) is not null && indices.Contains(index)) {
            index = this.hintOriginalIndices[index).intValue();
        }
        return new androidx.paging.objectportHint$Access(i, index, presentedItemsBefore, presentedItemsAfter, originalPageOffsetFirst, originalPageOffsetLast);
    }
}

