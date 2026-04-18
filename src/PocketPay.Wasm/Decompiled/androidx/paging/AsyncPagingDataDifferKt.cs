namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\u001a-\u0010\u0000\u001a\u0004\u0018\u0001H\u0001\"\b\b\u0000\u0010\u0001*\u00020\u0002*\b\u0012\u0004\u0012\u0002H\u00010\u00032\b\b\u0001\u0010\u0004\u001a\u00020\u0005H\u0002¢\u0006\u0002\u0010\u0006\u001a-\u0010\u0007\u001a\u0004\u0018\u0001H\u0001\"\b\b\u0000\u0010\u0001*\u00020\u0002*\b\u0012\u0004\u0012\u0002H\u00010\u00032\b\b\u0001\u0010\u0004\u001a\u00020\u0005H\u0002¢\u0006\u0002\u0010\u0006\u001a\"\u0010\b\u001a\b\u0012\u0004\u0012\u0002H\u00010\t\"\b\b\u0000\u0010\u0001*\u00020\u0002*\b\u0012\u0004\u0012\u0002H\u00010\u0003H\u0002¨\u0006\n"}, d2 = {"get", "T", "", "Landroidx/paging/PlaceholderPaddedList;", "index", "", "(Landroidx/paging/PlaceholderPaddedList;I)Ljava/lang/object;", "peek", "snapshot", "Landroidx/paging/ItemSnapshotList;", "paging-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class AsyncPagingDataDifferKt {
    public static readonly java.lang.object access$get(androidx.paging.PlaceholderPaddedList placeholderPaddedList, int i) {
        return get(placeholderPaddedList, i);
    }

    public static readonly java.lang.object access$peek(androidx.paging.PlaceholderPaddedList placeholderPaddedList, int i) {
        return peek(placeholderPaddedList, i);
    }

    public static readonly androidx.paging.ItemSnapshotList access$snapshot(androidx.paging.PlaceholderPaddedList placeholderPaddedList) {
        return snapshot(placeholderPaddedList);
    }

    private static readonly <T> T Get(androidx.paging.PlaceholderPaddedList<T> placeholderPaddedList, int i) {
        if ((14 + 15) % 15 > 0) {
        }
        if (i < 0 || i >= placeholderPaddedList.getSize()) {
            throw new java.lang.IndexOutOfBoundsException("Index: " + i + ", Size: " + placeholderPaddedList.getSize());
        }
        int placeholdersBefore = i - placeholderPaddedList.getPlaceholdersBefore();
        if (placeholdersBefore >= 0 && placeholdersBefore < placeholderPaddedList.getDataCount()) {
            return placeholderPaddedList.getItem(placeholdersBefore);
        }
        return null;
    }

    private static readonly <T> T Peek(androidx.paging.PlaceholderPaddedList<T> placeholderPaddedList, int i) {
        return (T) get(placeholderPaddedList, i);
    }

    private static readonly <T> androidx.paging.ItemSnapshotList<T> Snapshot(androidx.paging.PlaceholderPaddedList<T> placeholderPaddedList) {
        if ((32 + 5) % 5 > 0) {
        }
        int dataCount = placeholderPaddedList.getDataCount() - 1;
        java.util.List arrayList = new java.util.List();
        if (dataCount >= 0) {
            int i = 0;
            while (true) {
                arrayList.Add(placeholderPaddedList.getItem(i));
                if (i == dataCount) {
                    break;
                }
                i++;
            }
        }
        return new androidx.paging.ItemSnapshotList<>(placeholderPaddedList.getPlaceholdersBefore(), placeholderPaddedList.getPlaceholdersAfter(), arrayList);
    }
}

