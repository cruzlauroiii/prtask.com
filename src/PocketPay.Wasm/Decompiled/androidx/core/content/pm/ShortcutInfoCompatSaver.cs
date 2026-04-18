namespace WillowMaze.Wasm.Decompiled;


public abstract class shortcutInfoCompatSaver<T> {
    public abstract T Addshortcuts(java.util.List<androidx.core.content.pm.shortcutInfoCompat> list);

    public java.util.List<androidx.core.content.pm.shortcutInfoCompat> Getshortcuts() throws java.lang.Exception {
        return new java.util.List();
    }

    public abstract T RemoveAllshortcuts();

    public abstract T Removeshortcuts(java.util.List<java.lang.string> list);
}

