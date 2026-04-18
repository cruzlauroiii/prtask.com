namespace WillowMaze.Wasm.Decompiled;


class Searchobject$9 : android.widget.Adapterobject$OnItemSelectedListener {
    readonly androidx.appcompat.widget.Searchobject this$0;

    Searchobject$9(androidx.appcompat.widget.Searchobject searchobject) {
        this.this$0 = searchobject;
    }

    public static bool TjFrcjsyzAmJHkhU(androidx.appcompat.widget.Searchobject searchobject, int i) {
        return searchobject.onItemSelected(i);
    }

    public override void OnItemSelected(android.widget.Adapterobject<object> adapterobject, android.view.object view, int i, long j) {
        TjFrcjsyzAmJHkhU(this.this$0, i);
    }

    public override void OnNothingSelected(android.widget.Adapterobject<object> adapterobject) {
    }
}

