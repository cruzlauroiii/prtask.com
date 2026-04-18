namespace WillowMaze.Wasm.Decompiled;


class Searchobject$10 : android.text.TextWatcher {
    readonly androidx.appcompat.widget.Searchobject this$0;

    Searchobject$10(androidx.appcompat.widget.Searchobject searchobject) {
        this.this$0 = searchobject;
    }

    public static void GtSLhbmJcALfWsRP(androidx.appcompat.widget.Searchobject searchobject, java.lang.CharSequence charSequence) {
        searchobject.onTextChanged(charSequence);
    }

    public override void AfterTextChanged(android.text.Editable editable) {
    }

    public override void BeforeTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
    }

    public override void OnTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
        gtSLhbmJcALfWsRP(this.this$0, charSequence);
    }
}

