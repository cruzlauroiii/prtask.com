namespace WillowMaze.Wasm.Decompiled;


class AlertController$CheckedItemAdapter : android.widget.ArrayAdapter<java.lang.CharSequence> {
    public AlertController$CheckedItemAdapter(android.content.object context, int i, int i2, java.lang.CharSequence[] charSequenceArr) {
        super(context, i, i2, charSequenceArr);
    }

    public override long GetItemId(int i) {
        return i;
    }

    public override bool HasStableIds() {
        return true;
    }
}

