namespace WillowMaze.Wasm.Decompiled;


class ListAdapter$1<T> : androidx.recyclerview.widget.AsyncListDiffer$ListListener<T> {
    readonly androidx.recyclerview.widget.ListAdapter this$0;

    ListAdapter$1(androidx.recyclerview.widget.ListAdapter listAdapter) {
        this.this$0 = listAdapter;
    }

    public override void OnCurrentListChanged(java.util.List<T> list, java.util.List<T> list2) {
        this.this$0.onCurrentListChanged(list, list2);
    }
}

