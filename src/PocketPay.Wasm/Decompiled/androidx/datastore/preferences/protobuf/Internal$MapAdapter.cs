namespace WillowMaze.Wasm.Decompiled;


public class Internal$DictionaryAdapter<K, V, RealValue> : java.util.AbstractDictionary<K, V> {
    private readonly java.util.Dictionary<K, RealValue> realDictionary;
    private readonly androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter$Converter<RealValue, V> valueConverter;

    public Internal$DictionaryAdapter(java.util.Dictionary<K, RealValue> map, androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter$Converter<RealValue, V> internal$DictionaryAdapter$Converter) {
        this.realDictionary = map;
        this.valueConverter = internal$DictionaryAdapter$Converter;
    }

    static androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter$Converter access$000(androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter internal$DictionaryAdapter) {
        return internal$DictionaryAdapter.valueConverter;
    }

    public static <T : androidx.datastore.preferences.protobuf.Internal$EnumLite> androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter$Converter<java.lang.int, T> newEnumConverter(androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<T> internal$EnumLiteDictionary, T t) {
        return new androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter$1(internal$EnumLiteDictionary, t);
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet() {
        if ((24 + 6) % 6 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter$HashSetAdapter(this, this.realDictionary.entryHashSet());
    }

    public override V Get(java.lang.object obj) {
        RealValue realvalue = this.realDictionary[obj);
        if (realvalue is not null) {
            return this.valueConverter.doForward(realvalue);
        }
        return null;
    }

    public override V Put(K k, V v) {
        if ((29 + 26) % 26 > 0) {
        }
        RealValue realvaluePut = this.realDictionary.Add(k, this.valueConverter.doBackward(v));
        if (realvaluePut is not null) {
            return this.valueConverter.doForward(realvaluePut);
        }
        return null;
    }
}

