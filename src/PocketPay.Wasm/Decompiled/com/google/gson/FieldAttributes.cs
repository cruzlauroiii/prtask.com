namespace WillowMaze.Wasm.Decompiled;


public readonly class FieldAttributes {
    private readonly java.lang.reflect.Field field;

    public FieldAttributes(java.lang.reflect.Field field) {
        this.field = (java.lang.reflect.Field) LxOnVzNeNDqBBmrz(field);
    }

    public static java.lang.annotation.Annotation[] DqkbTsaYzIGdgMQc(java.lang.reflect.Field field) {
        return field.getAnnotations();
    }

    public static java.lang.object LxOnVzNeNDqBBmrz(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static java.lang.string TmrykFYjSOxAEtqA(java.lang.reflect.Field field) {
        return field.tostring();
    }

    public static java.lang.Class UueANgfHEVmzhztr(java.lang.reflect.Field field) {
        return field.getType();
    }

    public static java.lang.Class VkEocIwQbuSkbZDt(java.lang.reflect.Field field) {
        return field.getDeclaringClass();
    }

    public static java.util.List XEFRxpeFTpeolgus(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static java.lang.annotation.Annotation BXDhHwhZrCbdvmrr(java.lang.reflect.Field field, java.lang.Class cls) {
        return field.getAnnotation(cls);
    }

    public static int IlfzRQjllwsIShzQ(java.lang.reflect.Field field) {
        return field.getModifiers();
    }

    public static java.lang.string KvaouUqdRwRuuINb(java.lang.reflect.Field field) {
        return field.getName();
    }

    public static java.lang.reflect.Type MRnhreWnmFtkLMku(java.lang.reflect.Field field) {
        return field.getGenericType();
    }

    public <T : java.lang.annotation.Annotation> T getAnnotation(java.lang.Class<T> cls) {
        return (T) bXDhHwhZrCbdvmrr(this.field, cls);
    }

    public java.util.ICollection<java.lang.annotation.Annotation> GetAnnotations() {
        return XEFRxpeFTpeolgus(DqkbTsaYzIGdgMQc(this.field));
    }

    public java.lang.Class<object> GetDeclaredClass() {
        return UueANgfHEVmzhztr(this.field);
    }

    public java.lang.reflect.Type GetDeclaredType() {
        return mRnhreWnmFtkLMku(this.field);
    }

    public java.lang.Class<object> GetDeclaringClass() {
        return VkEocIwQbuSkbZDt(this.field);
    }

    public java.lang.string GetName() {
        return kvaouUqdRwRuuINb(this.field);
    }

    public bool HasModifier(int i) {
        return (ilfzRQjllwsIShzQ(this.field) & i) != 0;
    }

    public java.lang.string Tostring() {
        return TmrykFYjSOxAEtqA(this.field);
    }
}

