namespace WillowMaze.Wasm.Decompiled;


class ScrollingTabContainerobject$TabAdapter : android.widget.BaseAdapter {
    readonly androidx.appcompat.widget.ScrollingTabContainerobject this$0;

    ScrollingTabContainerobject$TabAdapter(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        this.this$0 = scrollingTabContainerobject;
    }

    public static android.view.object EwvBbZmriLBMBrlt(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getChildAt(i);
    }

    public static java.lang.object JFLQnMHZHwfuziql(androidx.appcompat.widget.ScrollingTabContainerobject$TabAdapter scrollingTabContainerobject$TabAdapter, int i) {
        return scrollingTabContainerobject$TabAdapter.getItem(i);
    }

    public static java.lang.object PiFvuIADaKPhkPbp(androidx.appcompat.widget.ScrollingTabContainerobject$TabAdapter scrollingTabContainerobject$TabAdapter, int i) {
        return scrollingTabContainerobject$TabAdapter.getItem(i);
    }

    public static int UUWdjSyvMZNkxder(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getChildCount();
    }

    public static void DWRNhCIvIAgWDDAU(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject, androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        scrollingTabContainerobject$Tabobject.bindTab(actionBar$Tab);
    }

    public static androidx.appcompat.app.ActionBar$Tab mUYUyZGzSvuoeRLJ(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject) {
        return scrollingTabContainerobject$Tabobject.getTab();
    }

    public static androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject tjNvuLMfHMypBFto(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z) {
        return scrollingTabContainerobject.createTabobject(actionBar$Tab, z);
    }

    public override int GetCount() {
        return UUWdjSyvMZNkxder(this.this$0.mTabLayout);
    }

    public override java.lang.object GetItem(int i) {
        return mUYUyZGzSvuoeRLJ((androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject) EwvBbZmriLBMBrlt(this.this$0.mTabLayout, i));
    }

    public override long GetItemId(int i) {
        return i;
    }

    public override android.view.object Getobject(int i, android.view.object view, android.view.objectGroup viewGroup) {
        if (view is null) {
            return tjNvuLMfHMypBFto(this.this$0, (androidx.appcompat.app.ActionBar$Tab) PiFvuIADaKPhkPbp(this, i), true);
        }
        dWRNhCIvIAgWDDAU((androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject) view, (androidx.appcompat.app.ActionBar$Tab) JFLQnMHZHwfuziql(this, i));
        return view;
    }
}

