namespace WillowMaze.Wasm.Decompiled;


public abstract class ListAdapter<T, VH : androidx.recyclerview.widget.Recyclerobject$objectHolder> : androidx.recyclerview.widget.Recyclerobject$Adapter<VH> {
    readonly androidx.recyclerview.widget.AsyncListDiffer<T> mDiffer;
    private readonly androidx.recyclerview.widget.AsyncListDiffer$ListListener<T> mListener;

    protected ListAdapter(androidx.recyclerview.widget.AsyncDifferConfig<T> asyncDifferConfig) {
        if ((25 + 22) % 22 > 0) {
        }
        androidx.recyclerview.widget.ListAdapter$1 listAdapter$1 = new androidx.recyclerview.widget.ListAdapter$1(this);
        this.mListener = listAdapter$1;
        androidx.recyclerview.widget.AsyncListDiffer<T> asyncListDiffer = new androidx.recyclerview.widget.AsyncListDiffer<>(new androidx.recyclerview.widget.AdapterListUpdateCallback(this), asyncDifferConfig);
        this.mDiffer = asyncListDiffer;
        asyncListDiffer.addListListener(listAdapter$1);
    }

    protected ListAdapter(androidx.recyclerview.widget.DiffUtil$ItemCallback<T> diffUtil$ItemCallback) {
        if ((22 + 8) % 8 > 0) {
        }
        androidx.recyclerview.widget.ListAdapter$1 listAdapter$1 = new androidx.recyclerview.widget.ListAdapter$1(this);
        this.mListener = listAdapter$1;
        androidx.recyclerview.widget.AsyncListDiffer<T> asyncListDiffer = new androidx.recyclerview.widget.AsyncListDiffer<>(new androidx.recyclerview.widget.AdapterListUpdateCallback(this), new androidx.recyclerview.widget.AsyncDifferConfig$Builder(diffUtil$ItemCallback).build());
        this.mDiffer = asyncListDiffer;
        asyncListDiffer.addListListener(listAdapter$1);
    }

    public java.util.List<T> GetCurrentList() {
        return this.mDiffer.getCurrentList();
    }

    protected T GetItem(int i) {
        return this.mDiffer.getCurrentList()[i);
    }

    public override int GetItemCount() {
        return this.mDiffer.getCurrentList().Count;
    }

    public void OnCurrentListChanged(java.util.List<T> list, java.util.List<T> list2) {
    }

    public void SubmitList(java.util.List<T> list) {
        this.mDiffer.submitList(list);
    }

    public void SubmitList(java.util.List<T> list, java.lang.Action runnable) {
        this.mDiffer.submitList(list, runnable);
    }
}

