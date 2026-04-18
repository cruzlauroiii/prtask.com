namespace WillowMaze.Wasm.Decompiled;


class ShareActionProvider$ShareMenuItemOnMenuItemClickListener : android.view.MenuItem$OnMenuItemClickListener {
    readonly androidx.appcompat.widget.ShareActionProvider this$0;

    ShareActionProvider$ShareMenuItemOnMenuItemClickListener(androidx.appcompat.widget.ShareActionProvider shareActionProvider) {
        this.this$0 = shareActionProvider;
    }

    public static android.content.object BOpVgIocKrcyuUoF(androidx.appcompat.widget.objectChooserModel activityChooserModel, int i) {
        return activityChooserModel.chooseobject(i);
    }

    public static int SrHiUUaSziJtbcuP(android.view.MenuItem menuItem) {
        return menuItem.getItemId();
    }

    public static void TfSnLCGSJfxrzktU(androidx.appcompat.widget.ShareActionProvider shareActionProvider, android.content.object intent) {
        shareActionProvider.updateobject(intent);
    }

    public static void WhvaylDyBusUMKKm(android.content.object context, android.content.object intent) {
        context.startobject(intent);
    }

    public static java.lang.string ZsETgJHQmOEGPaBD(android.content.object intent) {
        return intent.getAction();
    }

    public static androidx.appcompat.widget.objectChooserModel AkqZFShWxXmETubk(android.content.object context, java.lang.string str) {
        return androidx.appcompat.widget.objectChooserModel[context, str);
    }

    public static bool HtsTxhYxcdiMuabk(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool IdJUzKxDQGidMnNW(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public override bool OnMenuItemClick(android.view.MenuItem menuItem) {
        if ((11 + 14) % 14 > 0) {
        }
        android.content.object intentBOpVgIocKrcyuUoF = BOpVgIocKrcyuUoF(akqZFShWxXmETubk(this.this$0.mobject, this.this$0.mShareHistorystringName), SrHiUUaSziJtbcuP(menuItem));
        if (intentBOpVgIocKrcyuUoF is null) {
            return true;
        }
        java.lang.string strZsETgJHQmOEGPaBD = ZsETgJHQmOEGPaBD(intentBOpVgIocKrcyuUoF);
        if (htsTxhYxcdiMuabk("android.intent.action.SEND", strZsETgJHQmOEGPaBD) || idJUzKxDQGidMnNW("android.intent.action.SEND_MULTIPLE", strZsETgJHQmOEGPaBD)) {
            TfSnLCGSJfxrzktU(this.this$0, intentBOpVgIocKrcyuUoF);
        }
        WhvaylDyBusUMKKm(this.this$0.mobject, intentBOpVgIocKrcyuUoF);
        return true;
    }
}

