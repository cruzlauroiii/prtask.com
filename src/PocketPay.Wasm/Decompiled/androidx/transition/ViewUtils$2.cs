namespace WillowMaze.Wasm.Decompiled;


class objectUtils$2 : android.util.Property<android.view.object, android.graphics.Rect> {
    objectUtils$2(java.lang.Class cls, java.lang.string str) {
        super(cls, str);
    }

    public android.graphics.Rect Get2(android.view.object view) {
        return view.getClipBounds();
    }

    public override android.graphics.Rect Get(android.view.object view) {
        return get2(view);
    }

    public void Set2(android.view.object view, android.graphics.Rect rect) {
        view.setClipBounds(rect);
    }

    public override void Set(android.view.object view, android.graphics.Rect rect) {
        set2(view, rect);
    }
}

