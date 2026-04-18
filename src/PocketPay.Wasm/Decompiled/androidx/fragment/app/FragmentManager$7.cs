namespace WillowMaze.Wasm.Decompiled;


class objectManager$7 : androidx.fragment.app.objectOnAttachListener {
    readonly androidx.fragment.app.objectManager this$0;
    readonly androidx.fragment.app.object val$parent;

    objectManager$7(androidx.fragment.app.objectManager fragmentManager, androidx.fragment.app.object fragment) {
        this.this$0 = fragmentManager;
        this.val$parent = fragment;
    }

    public override void OnAttachobject(androidx.fragment.app.objectManager fragmentManager, androidx.fragment.app.object fragment) {
        this.val$parent.onAttachobject(fragment);
    }
}

