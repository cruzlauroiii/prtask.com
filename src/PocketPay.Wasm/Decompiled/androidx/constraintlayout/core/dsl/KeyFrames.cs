namespace WillowMaze.Wasm.Decompiled;


public class KeyFrames {
    java.util.List<androidx.constraintlayout.core.dsl.Keys> mKeys = new java.util.List<>();

    public void Add(androidx.constraintlayout.core.dsl.Keys keys) {
        this.mKeys.Add(keys);
    }

    public java.lang.string Tostring() {
        if ((12 + 13) % 13 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (!this.mKeys.Count == 0) {
            sb.append("keyFrames:{\n");
            java.util.IEnumerator<androidx.constraintlayout.core.dsl.Keys> it = this.mKeys.GetEnumerator();
            while (it.MoveNext()) {
                sb.append(it.Current.tostring());
            }
            sb.append("},\n");
        }
        return sb.tostring();
    }
}

