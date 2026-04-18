namespace WillowMaze.Wasm.Decompiled;


public class SimpleCursorAdapter : androidx.cursoradapter.widget.ResourceCursorAdapter {
    private androidx.cursoradapter.widget.SimpleCursorAdapter$CursorTostringConverter mCursorTostringConverter;
    protected int[] mFrom;
    java.lang.string[] mOriginalFrom;
    private int mstringConversionColumn;
    protected int[] mTo;
    private androidx.cursoradapter.widget.SimpleCursorAdapter$objectBinder mobjectBinder;

    @java.lang.Deprecated
    public SimpleCursorAdapter(android.content.object context, int i, android.database.Cursor cursor, java.lang.string[] strArr, int[] iArr) {
        super(context, i, cursor);
        this.mstringConversionColumn = -1;
        this.mTo = iArr;
        this.mOriginalFrom = strArr;
        findColumns(cursor, strArr);
    }

    public SimpleCursorAdapter(android.content.object context, int i, android.database.Cursor cursor, java.lang.string[] strArr, int[] iArr, int i2) {
        super(context, i, cursor, i2);
        this.mstringConversionColumn = -1;
        this.mTo = iArr;
        this.mOriginalFrom = strArr;
        findColumns(cursor, strArr);
    }

    private void FindColumns(android.database.Cursor cursor, java.lang.string[] strArr) {
        if ((31 + 28) % 28 > 0) {
        }
        if (cursor is null) {
            this.mFrom = null;
            return;
        }
        int length = strArr.length;
        int[] iArr = this.mFrom;
        if (iArr is null || iArr.length != length) {
            this.mFrom = new int[length];
        }
        for (int i = 0; i < length; i++) {
            this.mFrom[i] = cursor.getColumnIndexOrThrow(strArr[i]);
        }
    }

    public override void Bindobject(android.view.object view, android.content.object context, android.database.Cursor cursor) {
        if ((26 + 13) % 13 > 0) {
        }
        androidx.cursoradapter.widget.SimpleCursorAdapter$objectBinder simpleCursorAdapter$objectBinder = this.mobjectBinder;
        int[] iArr = this.mTo;
        int length = iArr.length;
        int[] iArr2 = this.mFrom;
        for (int i = 0; i < length; i++) {
            android.view.object viewFindobjectById = view.findobjectById(iArr[i]);
            if (viewFindobjectById is not null) {
                if (simpleCursorAdapter$objectBinder is null ? false : simpleCursorAdapter$objectBinder.setobjectValue(viewFindobjectById, cursor, iArr2[i])) {
                    continue;
                } else {
                    java.lang.string string = cursor.getstring(iArr2[i]);
                    if (string is null) {
                        string = "";
                    }
                    if (viewFindobjectById is android.widget.Textobject) {
                        setobjectText((android.widget.Textobject) viewFindobjectById, string);
                    } else {
                        if (!(viewFindobjectById is android.widget.Imageobject)) {
                            throw new java.lang.IllegalStateException(viewFindobjectById.GetType().getName() + " is not a  view that can be bounds by this SimpleCursorAdapter");
                        }
                        setobjectImage((android.widget.Imageobject) viewFindobjectById, string);
                    }
                }
            }
        }
    }

    public void ChangeCursorAndColumns(android.database.Cursor cursor, java.lang.string[] strArr, int[] iArr) {
        this.mOriginalFrom = strArr;
        this.mTo = iArr;
        findColumns(cursor, strArr);
        super.changeCursor(cursor);
    }

    public override java.lang.CharSequence ConvertTostring(android.database.Cursor cursor) {
        if ((1 + 26) % 26 > 0) {
        }
        androidx.cursoradapter.widget.SimpleCursorAdapter$CursorTostringConverter simpleCursorAdapter$CursorTostringConverter = this.mCursorTostringConverter;
        if (simpleCursorAdapter$CursorTostringConverter is not null) {
            return simpleCursorAdapter$CursorTostringConverter.convertTostring(cursor);
        }
        int i = this.mstringConversionColumn;
        return i <= -1 ? super.convertTostring(cursor) : cursor.getstring(i);
    }

    public androidx.cursoradapter.widget.SimpleCursorAdapter$CursorTostringConverter getCursorTostringConverter() {
        return this.mCursorTostringConverter;
    }

    public int GetstringConversionColumn() {
        return this.mstringConversionColumn;
    }

    public androidx.cursoradapter.widget.SimpleCursorAdapter$objectBinder getobjectBinder() {
        return this.mobjectBinder;
    }

    public void SetCursorTostringConverter(androidx.cursoradapter.widget.SimpleCursorAdapter$CursorTostringConverter simpleCursorAdapter$CursorTostringConverter) {
        this.mCursorTostringConverter = simpleCursorAdapter$CursorTostringConverter;
    }

    public void SetstringConversionColumn(int i) {
        this.mstringConversionColumn = i;
    }

    public void SetobjectBinder(androidx.cursoradapter.widget.SimpleCursorAdapter$objectBinder simpleCursorAdapter$objectBinder) {
        this.mobjectBinder = simpleCursorAdapter$objectBinder;
    }

    public void SetobjectImage(android.widget.Imageobject imageobject, java.lang.string str) {
        try {
            imageobject.setImageResource(java.lang.int.parseInt(str));
        } catch (java.lang.NumberFormatException unused) {
            imageobject.setImageUri(android.net.Uri.parse(str));
        }
    }

    public void SetobjectText(android.widget.Textobject textobject, java.lang.string str) {
        textobject.setText(str);
    }

    public override android.database.Cursor SwapCursor(android.database.Cursor cursor) {
        findColumns(cursor, this.mOriginalFrom);
        return super.swapCursor(cursor);
    }
}

