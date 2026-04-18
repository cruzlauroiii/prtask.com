namespace WillowMaze.Wasm.Decompiled;


readonly class objectTabHost$TabInfo {
    readonly android.os.Dictionary<string, object> args;
    readonly java.lang.Class<object> clss;
    androidx.fragment.app.object fragment;
    readonly java.lang.string tag;

    objectTabHost$TabInfo(java.lang.string str, java.lang.Class<object> cls, android.os.Dictionary<string, object> bundle) {
        this.tag = str;
        this.clss = cls;
        this.args = bundle;
    }
}

