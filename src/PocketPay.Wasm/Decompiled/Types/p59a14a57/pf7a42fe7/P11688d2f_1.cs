namespace WillowMaze.Wasm.Decompiled;

public class P11688d2f_1 : ActionMode$Callback
{
    private readonly object $context;
    private readonly p11688d2f This$0;

    public bool OnActionItemClicked(ActionMode P0, MenuItem P1)
    {
        // str: "clipboard"
        // str: "null cannot be cast to non-null type android.content.ClipboardManager"
        // call: ClipData.getItemAt
        // call: object.getSystemService
        // call: Intrinsics.checkNotNull
        // call: p11688d2f.getOnPasteListener
        // call: MenuItem.getItemId
        // call: Func<object, object>.invoke
        // call: ClipData$Item.getText
        // call: ClipboardManager.getPrimaryClip
        // call: ClipData.getItemCount
        // call: object.toString
        // field: p59a14a57.pf7a42fe7.p11688d2f$1.$context
        // field: p59a14a57.pf7a42fe7.p11688d2f$1.this$0
        return false;
    }

    public bool OnCreateActionMode(ActionMode P0, Menu P1)
    {
        return false;
    }

    public void OnDestroyActionMode(ActionMode P0)
    {
    }

    public bool OnPrepareActionMode(ActionMode P0, Menu P1)
    {
        return false;
    }

}
