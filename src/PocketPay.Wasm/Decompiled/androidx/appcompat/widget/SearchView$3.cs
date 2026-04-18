namespace WillowMaze.Wasm.Decompiled;


class Searchobject$3 : android.view.object$OnFocusChangeListener {
    readonly androidx.appcompat.widget.Searchobject this$0;

    Searchobject$3(androidx.appcompat.widget.Searchobject searchobject) {
        this.this$0 = searchobject;
    }

    public static void HJzLrSoFMwUOUscN(android.view.object$OnFocusChangeListener view$OnFocusChangeListener, android.view.object view, bool z) {
        view$OnFocusChangeListener.onFocusChange(view, z);
    }

    public override void OnFocusChange(android.view.object view, bool z) {
        if (this.this$0.mOnQueryTextFocusChangeListener is null) {
            return;
        }
        hJzLrSoFMwUOUscN(this.this$0.mOnQueryTextFocusChangeListener, this.this$0, z);
    }
}

