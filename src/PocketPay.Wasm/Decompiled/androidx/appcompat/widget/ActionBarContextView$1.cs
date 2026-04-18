namespace WillowMaze.Wasm.Decompiled;


class ActionBarobjectobject$1 : android.view.object$OnClickListener {
    readonly androidx.appcompat.widget.ActionBarobjectobject this$0;
    readonly androidx.appcompat.view.ActionMode val$mode;

    ActionBarobjectobject$1(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, androidx.appcompat.view.ActionMode actionMode) {
        this.this$0 = actionBarobjectobject;
        this.val$mode = actionMode;
    }

    public static void NDuyhBxhldmpfjzk(androidx.appcompat.view.ActionMode actionMode) {
        actionMode.finish();
    }

    public override void OnClick(android.view.object view) {
        nDuyhBxhldmpfjzk(this.val$mode);
    }
}

