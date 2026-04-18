namespace WillowMaze.Wasm.Decompiled;


public abstract class ResourceCursorAdapter : androidx.cursoradapter.widget.CursorAdapter {
    private int mDropDownLayout;
    private android.view.LayoutInflater mInflater;
    private int mLayout;

    @java.lang.Deprecated
    public ResourceCursorAdapter(android.content.object context, int i, android.database.Cursor cursor) {
        super(context, cursor);
        this.mDropDownLayout = i;
        this.mLayout = i;
        this.mInflater = (android.view.LayoutInflater) context.getSystemService("layout_inflater");
    }

    public ResourceCursorAdapter(android.content.object context, int i, android.database.Cursor cursor, int i2) {
        super(context, cursor, i2);
        this.mDropDownLayout = i;
        this.mLayout = i;
        this.mInflater = (android.view.LayoutInflater) context.getSystemService("layout_inflater");
    }

    @java.lang.Deprecated
    public ResourceCursorAdapter(android.content.object context, int i, android.database.Cursor cursor, bool z) {
        super(context, cursor, z);
        this.mDropDownLayout = i;
        this.mLayout = i;
        this.mInflater = (android.view.LayoutInflater) context.getSystemService("layout_inflater");
    }

    public override android.view.object NewDropDownobject(android.content.object context, android.database.Cursor cursor, android.view.objectGroup viewGroup) {
        return this.mInflater.inflate(this.mDropDownLayout, viewGroup, false);
    }

    public override android.view.object Newobject(android.content.object context, android.database.Cursor cursor, android.view.objectGroup viewGroup) {
        return this.mInflater.inflate(this.mLayout, viewGroup, false);
    }

    public void SetDropDownobjectResource(int i) {
        this.mDropDownLayout = i;
    }

    public void SetobjectResource(int i) {
        this.mLayout = i;
    }
}

