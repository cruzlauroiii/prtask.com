namespace WillowMaze.Wasm.Decompiled;


class objectChooserobject$1 : android.database.DataHashSetObserver {
    readonly androidx.appcompat.widget.objectChooserobject this$0;

    objectChooserobject$1(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        this.this$0 = activityChooserobject;
    }

    public static void IzhxPxvefkMZaPco(android.database.DataHashSetObserver dataHashSetObserver) {
        super.onInvalidated();
    }

    public static void XSrLdIjfFxOmrEJq(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter) {
        activityChooserobject$objectChooserobjectAdapter.notifyDataHashSetChanged();
    }

    public static void IaAVZYIQJXgcUycZ(android.database.DataHashSetObserver dataHashSetObserver) {
        super.onChanged();
    }

    public static void XWtwGcDnSXIPeUMm(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter) {
        activityChooserobject$objectChooserobjectAdapter.notifyDataHashSetInvalidated();
    }

    public override void OnChanged() {
        iaAVZYIQJXgcUycZ(this);
        XSrLdIjfFxOmrEJq(this.this$0.mAdapter);
    }

    public override void OnInvalidated() {
        IzhxPxvefkMZaPco(this);
        xWtwGcDnSXIPeUMm(this.this$0.mAdapter);
    }
}

