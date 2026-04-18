namespace WillowMaze.Wasm.Decompiled;


interface CursorFilter$CursorFilterClient {
    void changeCursor(android.database.Cursor cursor);

    java.lang.CharSequence convertTostring(android.database.Cursor cursor);

    android.database.Cursor getCursor();

    android.database.Cursor runQueryOnBackgroundThread(java.lang.CharSequence charSequence);
}

