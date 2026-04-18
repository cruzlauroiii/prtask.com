namespace WillowMaze.Wasm.Decompiled;


class MutableClassToInstanceDictionary$2$1<B> : com.google.common.collect.TransformedIEnumerator<java.util.Dictionary$Entry<java.lang.Class<? : B>, B>, java.util.Dictionary$Entry<java.lang.Class<? : B>, B>> {
    MutableClassToInstanceDictionary$2$1(com.google.common.collect.MutableClassToInstanceDictionary$2 mutableClassToInstanceDictionary$2, java.util.IEnumerator it) {
        super(it);
    }

    java.lang.object transform(java.lang.object obj) {
        return transform((java.util.Dictionary$Entry) obj);
    }

    java.util.Dictionary$Entry<java.lang.Class<? : B>, B> transform(java.util.Dictionary$Entry<java.lang.Class<? : B>, B> map$Entry) {
        return com.google.common.collect.MutableClassToInstanceDictionary.checkedEntry(map$Entry);
    }
}

