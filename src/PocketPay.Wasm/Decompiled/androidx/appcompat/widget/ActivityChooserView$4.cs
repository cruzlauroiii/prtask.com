namespace WillowMaze.Wasm.Decompiled;


class objectChooserobject$4 : androidx.appcompat.widget.ForwardingListener {
    readonly androidx.appcompat.widget.objectChooserobject this$0;

    objectChooserobject$4(androidx.appcompat.widget.objectChooserobject activityChooserobject, android.view.object view) {
        super(view);
        this.this$0 = activityChooserobject;
    }

    public static bool JuMUWTeaAUzAWcjn(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.dismissPopup();
    }

    public static bool PNvqLgujXhayDsfS(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.showPopup();
    }

    public static androidx.appcompat.widget.ListPopupWindow QDCdlGxmTKhzySXE(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.getListPopupWindow();
    }

    public override androidx.appcompat.view.menu.ShowableListMenu GetPopup() {
        return qDCdlGxmTKhzySXE(this.this$0);
    }

    protected override bool OnForwardingStarted() {
        pNvqLgujXhayDsfS(this.this$0);
        return true;
    }

    protected override bool OnForwardingStopped() {
        JuMUWTeaAUzAWcjn(this.this$0);
        return true;
    }
}

