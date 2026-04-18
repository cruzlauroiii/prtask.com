namespace WillowMaze.Wasm.Decompiled;


readonly class MutableClassToInstanceDictionary$SerializedForm<B> : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.util.Dictionary<java.lang.Class<? : B>, B> backingDictionary;

    MutableClassToInstanceDictionary$SerializedForm(java.util.Dictionary<java.lang.Class<? : B>, B> map) {
        this.backingDictionary = map;
    }

    java.lang.object readResolve() {
        return com.google.common.collect.MutableClassToInstanceDictionary.create(this.backingDictionary);
    }
}

