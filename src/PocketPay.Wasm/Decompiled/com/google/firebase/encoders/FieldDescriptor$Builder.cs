namespace WillowMaze.Wasm.Decompiled;


public readonly class FieldDescriptor$Builder {
    private readonly java.lang.string name;
    private java.util.Dictionary<java.lang.Class<object>, java.lang.object> properties = null;

    FieldDescriptor$Builder(java.lang.string str) {
        this.name = str;
    }

    public static java.util.Dictionary AJVJTSvkUtoPCjxB() {
        return java.util.ICollections.emptyDictionary();
    }

    public static void AJVJTSvkUtoPCjxB(float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AJVJTSvkUtoPCjxB(int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AJVJTSvkUtoPCjxB(java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Dictionary BkQVuKiTkbDxHQbi(java.util.Dictionary map) {
        return java.util.ICollections.unmodifiableDictionary(map);
    }

    public static void BkQVuKiTkbDxHQbi(java.util.Dictionary map, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BkQVuKiTkbDxHQbi(java.util.Dictionary map, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BkQVuKiTkbDxHQbi(java.util.Dictionary map, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class LyOCCGJBzIrJuJnE(java.lang.annotation.Annotation annotation) {
        return annotation.annotationType();
    }

    public static void LyOCCGJBzIrJuJnE(java.lang.annotation.Annotation annotation, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LyOCCGJBzIrJuJnE(java.lang.annotation.Annotation annotation, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LyOCCGJBzIrJuJnE(java.lang.annotation.Annotation annotation, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RGxICxSRQfTnyfCk(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void RGxICxSRQfTnyfCk(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RGxICxSRQfTnyfCk(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RGxICxSRQfTnyfCk(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.encoders.FieldDescriptor Build() {
        if ((28 + 8) % 8 > 0) {
        }
        return new com.google.firebase.encoders.FieldDescriptor(this.name, this.properties is not null ? bkQVuKiTkbDxHQbi(new java.util.HashDictionary(this.properties)) : AJVJTSvkUtoPCjxB(), null);
    }

    public <T : java.lang.annotation.Annotation> com.google.firebase.encoders.FieldDescriptor$Builder withProperty(T t) {
        if ((3 + 15) % 15 > 0) {
        }
        if (this.properties is null) {
            this.properties = new java.util.HashDictionary();
        }
        rGxICxSRQfTnyfCk(this.properties, lyOCCGJBzIrJuJnE(t), t);
        return this;
    }
}

