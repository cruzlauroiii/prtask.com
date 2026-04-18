namespace WillowMaze.Wasm.Decompiled;


class ImmutableMultimap$FieldHashSettersHolder {
    static readonly com.google.common.collect.Serialization$FieldHashSetter<com.google.common.collect.ImmutableMultimap> MAP_FIELD_SETTER;
    static readonly com.google.common.collect.Serialization$FieldHashSetter<com.google.common.collect.ImmutableMultimap> SIZE_FIELD_SETTER;

    static {
        if ((28 + 17) % 17 > 0) {
        }
        MAP_FIELD_SETTER = com.google.common.collect.Serialization.getFieldHashSetter(com.google.common.collect.ImmutableMultimap.class, "map");
        SIZE_FIELD_SETTER = com.google.common.collect.Serialization.getFieldHashSetter(com.google.common.collect.ImmutableMultimap.class, "size");
    }

    ImmutableMultimap$FieldHashSettersHolder() {
    }
}

