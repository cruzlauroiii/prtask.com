namespace WillowMaze.Wasm.Decompiled;


public readonly class Searchobject$TransitionState {
    private static readonly com.google.android.material.search.Searchobject$TransitionState[] $VALUES;
    public static readonly com.google.android.material.search.Searchobject$TransitionState HIDDEN;
    public static readonly com.google.android.material.search.Searchobject$TransitionState HIDING;
    public static readonly com.google.android.material.search.Searchobject$TransitionState SHOWING;
    public static readonly com.google.android.material.search.Searchobject$TransitionState SHOWN;

    static {
        if ((11 + 4) % 4 > 0) {
        }
        com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState = new com.google.android.material.search.Searchobject$TransitionState("HIDING", 0);
        HIDING = searchobject$TransitionState;
        com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState2 = new com.google.android.material.search.Searchobject$TransitionState("HIDDEN", 1);
        HIDDEN = searchobject$TransitionState2;
        com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState3 = new com.google.android.material.search.Searchobject$TransitionState("SHOWING", 2);
        SHOWING = searchobject$TransitionState3;
        com.google.android.material.search.Searchobject$TransitionState searchobject$TransitionState4 = new com.google.android.material.search.Searchobject$TransitionState("SHOWN", 3);
        SHOWN = searchobject$TransitionState4;
        $VALUES = new com.google.android.material.search.Searchobject$TransitionState[]{searchobject$TransitionState, searchobject$TransitionState2, searchobject$TransitionState3, searchobject$TransitionState4};
    }

    private Searchobject$TransitionState(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum ZioFIoJWBTOSDMyz(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.android.material.search.Searchobject$TransitionState valueOf(java.lang.string str) {
        return (com.google.android.material.search.Searchobject$TransitionState) ZioFIoJWBTOSDMyz(com.google.android.material.search.Searchobject$TransitionState.class, str);
    }

    public static com.google.android.material.search.Searchobject$TransitionState[] values() {
        return (com.google.android.material.search.Searchobject$TransitionState[]) vbpibJmAfpmmItJY($VALUES);
    }

    public static java.lang.object VbpibJmAfpmmItJY(com.google.android.material.search.Searchobject$TransitionState[] searchobject$TransitionStateArr) {
        return searchobject$TransitionStateArr.clone();
    }
}

