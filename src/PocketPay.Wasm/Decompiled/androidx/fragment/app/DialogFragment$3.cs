namespace WillowMaze.Wasm.Decompiled;


class Dialogobject$3 : android.content.DialogInterface$OnDismissListener {
    readonly androidx.fragment.app.Dialogobject this$0;

    Dialogobject$3(androidx.fragment.app.Dialogobject dialogobject) {
        this.this$0 = dialogobject;
    }

    public override void OnDismiss(android.content.DialogInterface dialogInterface) {
        if (androidx.fragment.app.Dialogobject.access$000(this.this$0) is null) {
            return;
        }
        androidx.fragment.app.Dialogobject dialogobject = this.this$0;
        dialogobject.onDismiss(androidx.fragment.app.Dialogobject.access$000(dialogobject));
    }
}

