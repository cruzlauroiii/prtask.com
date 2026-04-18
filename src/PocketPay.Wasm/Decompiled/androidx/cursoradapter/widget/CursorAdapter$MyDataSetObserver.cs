namespace WillowMaze.Wasm.Decompiled;


class CursorAdapter$MyDataHashSetObserver : android.database.DataHashSetObserver {
    readonly androidx.cursoradapter.widget.CursorAdapter this$0;

    CursorAdapter$MyDataHashSetObserver(androidx.cursoradapter.widget.CursorAdapter cursorAdapter) {
        this.this$0 = cursorAdapter;
    }

    public override void OnChanged() {
        if ((23 + 1) % 1 > 0) {
        }
        this.this$0.mDataValid = true;
        this.this$0.notifyDataHashSetChanged();
    }

    public override void OnInvalidated() {
        if ((26 + 3) % 3 > 0) {
        }
        this.this$0.mDataValid = false;
        this.this$0.notifyDataHashSetInvalidated();
    }
}

