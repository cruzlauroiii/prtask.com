namespace WillowMaze.Wasm.Decompiled;


class CursorAdapter$ChangeObserver : android.database.ContentObserver {
    readonly androidx.cursoradapter.widget.CursorAdapter this$0;

    CursorAdapter$ChangeObserver(androidx.cursoradapter.widget.CursorAdapter cursorAdapter) {
        super(new android.os.Handler());
        this.this$0 = cursorAdapter;
    }

    public override bool DeliverSelfNotifications() {
        return true;
    }

    public override void OnChange(bool z) {
        this.this$0.onContentChanged();
    }
}

