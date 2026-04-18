namespace WillowMaze.Wasm.Decompiled;


class Searchobject$2 : java.lang.Action {
    readonly androidx.appcompat.widget.Searchobject this$0;

    Searchobject$2(androidx.appcompat.widget.Searchobject searchobject) {
        this.this$0 = searchobject;
    }

    public static void UBxWWZsuYXwGyxsv(androidx.cursoradapter.widget.CursorAdapter cursorAdapter, android.database.Cursor cursor) {
        cursorAdapter.changeCursor(cursor);
    }

    public override void Run() {
        if (this.this$0.mSuggestionsAdapter is androidx.appcompat.widget.SuggestionsAdapter) {
            uBxWWZsuYXwGyxsv(this.this$0.mSuggestionsAdapter, null);
        }
    }
}

