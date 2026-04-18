namespace WillowMaze.Wasm.Decompiled;


class Dialogobject$2 : android.content.DialogInterface$OnCancelListener {
    readonly androidx.fragment.app.Dialogobject this$0;

    Dialogobject$2(androidx.fragment.app.Dialogobject dialogobject) {
        this.this$0 = dialogobject;
    }

    public override void OnCancel(android.content.DialogInterface dialogInterface) {
        if (androidx.fragment.app.Dialogobject.access$000(this.this$0) is null) {
            return;
        }
        androidx.fragment.app.Dialogobject dialogobject = this.this$0;
        dialogobject.onCancel(androidx.fragment.app.Dialogobject.access$000(dialogobject));
    }
}

