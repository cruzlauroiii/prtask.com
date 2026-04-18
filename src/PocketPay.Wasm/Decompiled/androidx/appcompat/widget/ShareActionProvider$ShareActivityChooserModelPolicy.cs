namespace WillowMaze.Wasm.Decompiled;


class ShareActionProvider$ShareobjectChooserModelPolicy : androidx.appcompat.widget.objectChooserModel$OnChooseobjectListener {
    readonly androidx.appcompat.widget.ShareActionProvider this$0;

    ShareActionProvider$ShareobjectChooserModelPolicy(androidx.appcompat.widget.ShareActionProvider shareActionProvider) {
        this.this$0 = shareActionProvider;
    }

    public static bool YapJHuUrEvCtDJOJ(androidx.appcompat.widget.ShareActionProvider$OnShareTargetSelectedListener shareActionProvider$OnShareTargetSelectedListener, androidx.appcompat.widget.ShareActionProvider shareActionProvider, android.content.object intent) {
        return shareActionProvider$OnShareTargetSelectedListener.onShareTargetSelected(shareActionProvider, intent);
    }

    public override bool OnChooseobject(androidx.appcompat.widget.objectChooserModel activityChooserModel, android.content.object intent) {
        if (this.this$0.mOnShareTargetSelectedListener is null) {
            return false;
        }
        yapJHuUrEvCtDJOJ(this.this$0.mOnShareTargetSelectedListener, this.this$0, intent);
        return false;
    }
}

