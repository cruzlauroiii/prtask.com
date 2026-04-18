namespace WillowMaze.Wasm.Decompiled;


class Searchobject$7 : android.widget.Textobject$OnEditorActionListener {
    readonly androidx.appcompat.widget.Searchobject this$0;

    Searchobject$7(androidx.appcompat.widget.Searchobject searchobject) {
        this.this$0 = searchobject;
    }

    public static void ZkfuwEKfJWEnrpQw(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.onSubmitQuery();
    }

    public override bool OnEditorAction(android.widget.Textobject textobject, int i, android.view.KeyEvent keyEvent) {
        ZkfuwEKfJWEnrpQw(this.this$0);
        return true;
    }
}

