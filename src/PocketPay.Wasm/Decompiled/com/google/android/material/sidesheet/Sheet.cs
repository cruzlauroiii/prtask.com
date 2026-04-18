namespace WillowMaze.Wasm.Decompiled;


interface Sheet<C : com.google.android.material.sidesheet.SheetCallback> : com.google.android.material.motion.MaterialBackHandler {
    public static readonly int EDGE_LEFT = 1;
    public static readonly int EDGE_RIGHT = 0;
    public static readonly int STATE_DRAGGING = 1;
    public static readonly int STATE_EXPANDED = 3;
    public static readonly int STATE_HIDDEN = 5;
    public static readonly int STATE_SETTLING = 2;

    void addCallback(C c);

    int getState();

    void removeCallback(C c);

    void setState(int i);
}

