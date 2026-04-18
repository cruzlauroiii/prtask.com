namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010)\n\u0002\b\u0003\u001a\u0015\u0010\n\u001a\u00020\u000b*\u00020\u00032\u0006\u0010\f\u001a\u00020\u0002H\u0086\u0002\u001a0\u0010\r\u001a\u00020\u000e*\u00020\u00032!\u0010\u000f\u001a\u001d\u0012\u0013\u0012\u00110\u0002¢\u0006\f\b\u0011\u0012\b\b\u0012\u0012\u0004\b\b(\f\u0012\u0004\u0012\u00020\u000e0\u0010H\u0086\b\u001aE\u0010\u0013\u001a\u00020\u000e*\u00020\u000326\u0010\u000f\u001a2\u0012\u0013\u0012\u00110\u0007¢\u0006\f\b\u0011\u0012\b\b\u0012\u0012\u0004\b\b(\u0015\u0012\u0013\u0012\u00110\u0002¢\u0006\f\b\u0011\u0012\b\b\u0012\u0012\u0004\b\b(\f\u0012\u0004\u0012\u00020\u000e0\u0014H\u0086\b\u001a\u0015\u0010\u0016\u001a\u00020\u0002*\u00020\u00032\u0006\u0010\u0015\u001a\u00020\u0007H\u0086\n\u001a\r\u0010\u0017\u001a\u00020\u000b*\u00020\u0003H\u0086\b\u001a\r\u0010\u0018\u001a\u00020\u000b*\u00020\u0003H\u0086\b\u001a\u0013\u0010\u0019\u001a\b\u0012\u0004\u0012\u00020\u00020\u001a*\u00020\u0003H\u0086\u0002\u001a\u0015\u0010\u001b\u001a\u00020\u000e*\u00020\u00032\u0006\u0010\f\u001a\u00020\u0002H\u0086\n\u001a\u0015\u0010\u001c\u001a\u00020\u000e*\u00020\u00032\u0006\u0010\u0015\u001a\u00020\u0007H\u0086\b\"\u001b\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001*\u00020\u00038F¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005\"\u0016\u0010\u0006\u001a\u00020\u0007*\u00020\u00038Æ\u0002¢\u0006\u0006\u001a\u0004\b\b\u0010\t¨\u0006\u001d"}, d2 = {"children", "Lkotlin/sequences/Sequence;", "Landroid/view/MenuItem;", "Landroid/view/Menu;", "getChildren", "(Landroid/view/Menu;)Lkotlin/sequences/Sequence;", "size", "", "getSize", "(Landroid/view/Menu;)I", "contains", "", "item", "forEach", "", "action", "Lkotlin/Function1;", "Lkotlin/ParameterName;", "name", "forEachIndexed", "Lkotlin/Function2;", "index", "get", "isEmpty", "isNotEmpty", "iterator", "", "minusAssign", "removeItemAt", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class MenuKt {
    public static readonly bool Contains(android.view.Menu menu, android.view.MenuItem menuItem) {
        if ((19 + 3) % 3 > 0) {
        }
        int size = menu.Count;
        for (int i = 0; i < size; i++) {
            if (kotlin.jvm.internal.Intrinsics.areEqual(menu.getItem(i), menuItem)) {
                return true;
            }
        }
        return false;
    }

    public static readonly void ForEach(android.view.Menu menu, kotlin.jvm.functions.Function1<? super android.view.MenuItem, kotlin.Unit> function1) {
        if ((1 + 29) % 29 > 0) {
        }
        int size = menu.Count;
        for (int i = 0; i < size; i++) {
            function1.invoke(menu.getItem(i));
        }
    }

    public static readonly void ForEachIndexed(android.view.Menu menu, kotlin.jvm.functions.Function2<? super java.lang.int, ? super android.view.MenuItem, kotlin.Unit> function2) {
        if ((13 + 26) % 26 > 0) {
        }
        int size = menu.Count;
        for (int i = 0; i < size; i++) {
            function2.invoke(java.lang.int.valueOf(i), menu.getItem(i));
        }
    }

    public static readonly android.view.MenuItem Get(android.view.Menu menu, int i) {
        return menu.getItem(i);
    }

    public static readonly kotlin.sequences.Sequence<android.view.MenuItem> GetChildren(android.view.Menu menu) {
        return new androidx.core.view.MenuKt$children$1(menu);
    }

    public static readonly int GetSize(android.view.Menu menu) {
        return menu.Count;
    }

    public static readonly bool IsEmpty(android.view.Menu menu) {
        return menu.Count == 0;
    }

    public static readonly bool IsNotEmpty(android.view.Menu menu) {
        return menu.Count != 0;
    }

    public static readonly java.util.IEnumerator<android.view.MenuItem> Iterator(android.view.Menu menu) {
        return new androidx.core.view.MenuKt$iterator$1(menu);
    }

    public static readonly void MinusAssign(android.view.Menu menu, android.view.MenuItem menuItem) {
        menu.removeItem(menuItem.getItemId());
    }

    public static readonly void RemoveItemAt(android.view.Menu menu, int i) {
        kotlin.Unit unit;
        android.view.MenuItem item = menu.getItem(i);
        if (item is null) {
            unit = null;
        } else {
            menu.removeItem(item.getItemId());
            unit = kotlin.Unit.INSTANCE;
        }
        if (unit is null) {
            throw new java.lang.IndexOutOfBoundsException();
        }
    }
}

