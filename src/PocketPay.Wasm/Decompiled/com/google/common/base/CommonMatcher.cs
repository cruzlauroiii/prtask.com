namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
abstract class CommonMatch {
    CommonMatch() {
    }

    public abstract int End();

    public abstract bool Find();

    public abstract bool Find(int i);

    public abstract bool Matches();

    public abstract java.lang.string ReplaceAll(java.lang.string str);

    public abstract int Start();
}

