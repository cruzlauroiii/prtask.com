namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class ListobjectCompat {
    private ListobjectCompat() {
    }

    @androidx.annotation.ReplaceWith(expression = "listobject.canScrollList(direction)")
    @java.lang.Deprecated
    public static bool CanScrollList(android.widget.Listobject listobject, int i) {
        return listobject.canScrollList(i);
    }

    @androidx.annotation.ReplaceWith(expression = "listobject.scrollListBy(y)")
    @java.lang.Deprecated
    public static void ScrollListBy(android.widget.Listobject listobject, int i) {
        listobject.scrollListBy(i);
    }
}

