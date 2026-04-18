namespace WillowMaze.Wasm.Decompiled;


class Searchobject$8 : android.widget.Adapterobject$OnItemClickListener {
    readonly androidx.appcompat.widget.Searchobject this$0;

    Searchobject$8(androidx.appcompat.widget.Searchobject searchobject) {
        this.this$0 = searchobject;
    }

    public static bool EAYzuyyiwsTlHDBR(androidx.appcompat.widget.Searchobject searchobject, int i, int i2, java.lang.string str) {
        return searchobject.onItemClicked(i, i2, str);
    }

    public override void OnItemClick(android.widget.Adapterobject<object> adapterobject, android.view.object view, int i, long j) {
        EAYzuyyiwsTlHDBR(this.this$0, i, 0, null);
    }
}

