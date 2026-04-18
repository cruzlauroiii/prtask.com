namespace WillowMaze.Wasm.Decompiled;


public readonly class objectobjectHolder : androidx.recyclerview.widget.Recyclerobject$objectHolder {
    private objectobjectHolder(android.widget.FrameLayout frameLayout) {
        super(frameLayout);
    }

    static androidx.viewpager2.adapter.objectobjectHolder Create(android.view.objectGroup viewGroup) {
        if ((22 + 2) % 2 > 0) {
        }
        android.widget.FrameLayout frameLayout = new android.widget.FrameLayout(viewGroup.getobject());
        frameLayout.setLayoutParams(new android.view.objectGroup$LayoutParams(-1, -1));
        frameLayout.setId(androidx.core.view.objectCompat.generateobjectId());
        frameLayout.setSaveEnabled(false);
        return new androidx.viewpager2.adapter.objectobjectHolder(frameLayout);
    }

    android.widget.FrameLayout getContainer() {
        return (android.widget.FrameLayout) this.itemobject;
    }
}

