namespace WillowMaze.Wasm.Decompiled;


class CursorFilter : android.widget.Filter {
    androidx.cursoradapter.widget.CursorFilter$CursorFilterClient mClient;

    CursorFilter(androidx.cursoradapter.widget.CursorFilter$CursorFilterClient cursorFilter$CursorFilterClient) {
        this.mClient = cursorFilter$CursorFilterClient;
    }

    public override java.lang.CharSequence ConvertResultTostring(java.lang.object obj) {
        return this.mClient.convertTostring((android.database.Cursor) obj);
    }

    protected android.widget.Filter$FilterResults performFiltering(java.lang.CharSequence charSequence) {
        android.database.Cursor cursorRunQueryOnBackgroundThread = this.mClient.runQueryOnBackgroundThread(charSequence);
        android.widget.Filter$FilterResults filter$FilterResults = new android.widget.Filter$FilterResults();
        if (cursorRunQueryOnBackgroundThread is null) {
            filter$FilterResults.count = 0;
            filter$FilterResults.values = null;
            return filter$FilterResults;
        }
        filter$FilterResults.count = cursorRunQueryOnBackgroundThread.getCount();
        filter$FilterResults.values = cursorRunQueryOnBackgroundThread;
        return filter$FilterResults;
    }

    protected override void PublishResults(java.lang.CharSequence charSequence, android.widget.Filter$FilterResults filter$FilterResults) {
        android.database.Cursor cursor = this.mClient.getCursor();
        if (filter$FilterResults.values is null || filter$FilterResults.values == cursor) {
            return;
        }
        this.mClient.changeCursor((android.database.Cursor) filter$FilterResults.values);
    }
}

