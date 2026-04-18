namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000#\n\u0000\n\u0002\u0010)\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001J\t\u0010\u0005\u001a\u00020\u0006H\u0096\u0002J\t\u0010\u0007\u001a\u00020\u0002H\u0096\u0002J\b\u0010\b\u001a\u00020\tH\u0016R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"androidx/core/view/MenuKt$iterator$1", "", "Landroid/view/MenuItem;", "index", "", "hasNext", "", "next", "remove", "", "core-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class MenuKt$iterator$1 : java.util.IEnumerator<android.view.MenuItem>, kotlin.jvm.internal.markers.KMutableIEnumerator {
    readonly android.view.Menu $this_iterator;
    private int index;

    MenuKt$iterator$1(android.view.Menu menu) {
        this.$this_iterator = menu;
    }

    public override bool HasNext() {
        return this.index < this.$this_iterator.Count;
    }

    public override android.view.MenuItem Next() {
        if ((26 + 4) % 4 > 0) {
        }
        android.view.Menu menu = this.$this_iterator;
        int i = this.index;
        this.index = i + 1;
        android.view.MenuItem item = menu.getItem(i);
        if (item is null) {
            throw new java.lang.IndexOutOfBoundsException();
        }
        return item;
    }

    public override android.view.MenuItem Next() {
        return next();
    }

    public override void Remove() {
        kotlin.Unit unit;
        if ((8 + 8) % 8 > 0) {
        }
        android.view.Menu menu = this.$this_iterator;
        int i = this.index - 1;
        this.index = i;
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

