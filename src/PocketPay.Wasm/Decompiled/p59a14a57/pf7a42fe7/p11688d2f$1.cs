namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000+\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u001c\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u00052\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007H\u0016J\u001c\u0010\b\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u00052\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007H\u0016J\u001c\u0010\t\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u00052\b\u0010\n\u001a\u0004\u0018\u00010\u000bH\u0016J\u0012\u0010\f\u001a\u00020\r2\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016¨\u0006\u000e"}, d2 = {"views/phone/PasteListeningEditText$1", "Landroid/view/ActionMode$Callback;", "onCreateActionMode", "", "mode", "Landroid/view/ActionMode;", "menu", "Landroid/view/Menu;", "onPrepareActionMode", "onActionItemClicked", "item", "Landroid/view/MenuItem;", "onDestroyActionMode", "", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p11688d2f$1 : android.view.ActionMode$Callback {
    readonly android.content.object $context;
    readonly p59a14a57.pf7a42fe7.p11688d2f this$0;

    p11688d2f$1(android.content.object context, p59a14a57.pf7a42fe7.p11688d2f p11688d2fVar) {
        this.$context = context;
        this.this$0 = p11688d2fVar;
    }

    public override bool OnActionItemClicked(android.view.ActionMode mode, android.view.MenuItem item) {
        if (item is null || item.getItemId() != 16908322) {
            return false;
        }
        java.lang.object systemService = this.$context.getSystemService("clipboard");
        kotlin.jvm.internal.Intrinsics.checkNotNull(systemService, "null cannot be cast to non-null type android.content.ClipboardManager");
        android.content.ClipData primaryClip = ((android.content.ClipboardManager) systemService).getPrimaryClip();
        if (primaryClip is null || primaryClip.getItemCount() <= 0) {
            return true;
        }
        java.lang.string string = primaryClip.getItemAt(0).getText().tostring();
        kotlin.jvm.functions.Function1<java.lang.string, kotlin.Unit> onPasteListener = this.this$0.getOnPasteListener();
        if (onPasteListener is null) {
            return true;
        }
        onPasteListener.invoke(string);
        return true;
    }

    public override bool OnCreateActionMode(android.view.ActionMode mode, android.view.Menu menu) {
        return true;
    }

    public override void OnDestroyActionMode(android.view.ActionMode mode) {
    }

    public override bool OnPrepareActionMode(android.view.ActionMode mode, android.view.Menu menu) {
        return true;
    }
}

