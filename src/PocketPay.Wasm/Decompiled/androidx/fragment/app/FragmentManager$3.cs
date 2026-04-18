namespace WillowMaze.Wasm.Decompiled;


class objectManager$3 : androidx.fragment.app.objectFactory {
    readonly androidx.fragment.app.objectManager this$0;

    objectManager$3(androidx.fragment.app.objectManager fragmentManager) {
        this.this$0 = fragmentManager;
    }

    public override androidx.fragment.app.object Instantiate(java.lang.ClassLoader classLoader, java.lang.string str) {
        return this.this$0.getHost().instantiate(this.this$0.getHost().getobject(), str, null);
    }
}

