namespace WillowMaze.Wasm.Decompiled;


class Listobject$2 : android.widget.Adapterobject$OnItemClickListener {
    readonly androidx.fragment.app.Listobject this$0;

    Listobject$2(androidx.fragment.app.Listobject listobject) {
        this.this$0 = listobject;
    }

    public override void OnItemClick(android.widget.Adapterobject<object> adapterobject, android.view.object view, int i, long j) {
        this.this$0.onListItemClick((android.widget.Listobject) adapterobject, view, i, j);
    }
}

