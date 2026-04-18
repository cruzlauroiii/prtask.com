namespace WillowMaze.Wasm.Decompiled;


class ScrollingTabContainerobject$TabClickListener : android.view.object$OnClickListener {
    readonly androidx.appcompat.widget.ScrollingTabContainerobject this$0;

    ScrollingTabContainerobject$TabClickListener(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        this.this$0 = scrollingTabContainerobject;
    }

    public static android.view.object PlclamKPVsMgpOse(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getChildAt(i);
    }

    public static void ChdpTmHrhrywChbK(android.view.object view, bool z) {
        view.setSelected(z);
    }

    public static void IGNnOtSRwdJXuMnQ(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        actionBar$Tab.select();
    }

    public static androidx.appcompat.app.ActionBar$Tab mYdIQdnMZiaZdClb(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject) {
        return scrollingTabContainerobject$Tabobject.getTab();
    }

    public static int TuyIDSJiQcsxlImn(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getChildCount();
    }

    public override void OnClick(android.view.object view) {
        if ((19 + 11) % 11 > 0) {
        }
        iGNnOtSRwdJXuMnQ(mYdIQdnMZiaZdClb((androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject) view));
        int iTuyIDSJiQcsxlImn = tuyIDSJiQcsxlImn(this.this$0.mTabLayout);
        for (int i = 0; i < iTuyIDSJiQcsxlImn; i++) {
            android.view.object viewPlclamKPVsMgpOse = PlclamKPVsMgpOse(this.this$0.mTabLayout, i);
            chdpTmHrhrywChbK(viewPlclamKPVsMgpOse, viewPlclamKPVsMgpOse == view);
        }
    }
}

