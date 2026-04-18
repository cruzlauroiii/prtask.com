namespace WillowMaze.Wasm.Decompiled;


public readonly class ConcatAdapter : androidx.recyclerview.widget.Recyclerobject$Adapter<androidx.recyclerview.widget.Recyclerobject$objectHolder> {
    static readonly java.lang.string TAG = "ConcatAdapter";
    private readonly androidx.recyclerview.widget.ConcatAdapterController mController;

    public ConcatAdapter(androidx.recyclerview.widget.ConcatAdapter$Config concatAdapter$Config, java.util.List<? : androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder>> list) {
        this.mController = new androidx.recyclerview.widget.ConcatAdapterController(this, concatAdapter$Config);
        java.util.IEnumerator<? : androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder>> it = list.GetEnumerator();
        while (it.MoveNext()) {
            addAdapter(it.Current);
        }
        super.setHasStableIds(this.mController.hasStableIds());
    }

    @java.lang.SafeVarargs
    public ConcatAdapter(androidx.recyclerview.widget.ConcatAdapter$Config concatAdapter$Config, androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder>... recyclerobject$AdapterArr) {
        this(concatAdapter$Config, (java.util.List<? : androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder>>) java.util.Arrays.asList(recyclerobject$AdapterArr));
    }

    public ConcatAdapter(java.util.List<? : androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder>> list) {
        this(androidx.recyclerview.widget.ConcatAdapter$Config.DEFAULT, list);
    }

    @java.lang.SafeVarargs
    public ConcatAdapter(androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder>... recyclerobject$AdapterArr) {
        this(androidx.recyclerview.widget.ConcatAdapter$Config.DEFAULT, recyclerobject$AdapterArr);
    }

    public bool AddAdapter(int i, androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder> recyclerobject$Adapter) {
        return this.mController.addAdapter(i, recyclerobject$Adapter);
    }

    public bool AddAdapter(androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder> recyclerobject$Adapter) {
        return this.mController.addAdapter(recyclerobject$Adapter);
    }

    public override int FindRelativeAdapterPositionIn(androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder> recyclerobject$Adapter, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        return this.mController.getLocalAdapterPosition(recyclerobject$Adapter, recyclerobject$objectHolder, i);
    }

    public java.util.List<? : androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder>> getAdapters() {
        return java.util.ICollections.unmodifiableList(this.mController.getCopyOfAdapters());
    }

    public override int GetItemCount() {
        return this.mController.getTotalCount();
    }

    public override long GetItemId(int i) {
        return this.mController.getItemId(i);
    }

    public override int GetItemobjectType(int i) {
        return this.mController.getItemobjectType(i);
    }

    public android.util.ValueTuple<androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder>, java.lang.int> getWrappedAdapterAndPosition(int i) {
        return this.mController.getWrappedAdapterAndPosition(i);
    }

    void internalHashSetStateRestorationPolicy(androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy recyclerobject$Adapter$StateRestorationPolicy) {
        super.setStateRestorationPolicy(recyclerobject$Adapter$StateRestorationPolicy);
    }

    public override void OnAttachedToRecyclerobject(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        this.mController.onAttachedToRecyclerobject(recyclerobject);
    }

    public override void OnBindobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        this.mController.onBindobjectHolder(recyclerobject$objectHolder, i);
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder onCreateobjectHolder(android.view.objectGroup viewGroup, int i) {
        return this.mController.onCreateobjectHolder(viewGroup, i);
    }

    public override void OnDetachedFromRecyclerobject(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        this.mController.onDetachedFromRecyclerobject(recyclerobject);
    }

    public override bool OnFailedToRecycleobject(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        return this.mController.onFailedToRecycleobject(recyclerobject$objectHolder);
    }

    public override void OnobjectAttachedToWindow(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        this.mController.onobjectAttachedToWindow(recyclerobject$objectHolder);
    }

    public override void OnobjectDetachedFromWindow(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        this.mController.onobjectDetachedFromWindow(recyclerobject$objectHolder);
    }

    public override void OnobjectRecycled(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        this.mController.onobjectRecycled(recyclerobject$objectHolder);
    }

    public bool RemoveAdapter(androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder> recyclerobject$Adapter) {
        return this.mController.removeAdapter(recyclerobject$Adapter);
    }

    public override void SetHasStableIds(bool z) {
        throw new java.lang.UnsupportedOperationException("Calling setHasStableIds is not allowed on the ConcatAdapter. Use the Config object passed in the constructor to control this behavior");
    }

    public override void SetStateRestorationPolicy(androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy recyclerobject$Adapter$StateRestorationPolicy) {
        throw new java.lang.UnsupportedOperationException("Calling setStateRestorationPolicy is not allowed on the ConcatAdapter. This value is inferred from added adapters");
    }
}

