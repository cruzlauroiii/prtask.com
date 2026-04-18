namespace WillowMaze.Wasm.Decompiled;


class Internal$DictionaryAdapter$1<T> : androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter$Converter<java.lang.int, T> {
    readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary val$enumDictionary;
    readonly androidx.datastore.preferences.protobuf.Internal$EnumLite val$unrecognizedValue;

    Internal$DictionaryAdapter$1(androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary internal$EnumLiteDictionary, androidx.datastore.preferences.protobuf.Internal$EnumLite internal$EnumLite) {
        this.val$enumDictionary = internal$EnumLiteDictionary;
        this.val$unrecognizedValue = internal$EnumLite;
    }

    public java.lang.int DoBackward(androidx.datastore.preferences.protobuf.Internal$EnumLite internal$EnumLite) {
        return java.lang.int.valueOf(internal$EnumLite.getNumber());
    }

    public override java.lang.int DoBackward(java.lang.object obj) {
        return doBackward((androidx.datastore.preferences.protobuf.Internal$EnumLite) obj);
    }

    public androidx.datastore.preferences.protobuf.Internal$EnumLite doForward2(java.lang.int num) {
        androidx.datastore.preferences.protobuf.Internal$EnumLite internal$EnumLiteFindValueByNumber = this.val$enumDictionary.findValueByNumber(num.intValue());
        return internal$EnumLiteFindValueByNumber is not null ? internal$EnumLiteFindValueByNumber : this.val$unrecognizedValue;
    }

    public override java.lang.object DoForward(java.lang.int num) {
        return doForward2(num);
    }
}

