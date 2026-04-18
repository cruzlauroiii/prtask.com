namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0010\u000b\n\u0002\b\u0003\b'\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u0002H\u00012\b\u0012\u0004\u0012\u0002H\u00030\u0004B:\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004\u0012#\u0010\u0006\u001a\u001f\u0012\u0013\u0012\u00110\u0002¢\u0006\f\b\b\u0012\b\b\t\u0012\u0004\b\b(\n\u0012\u0006\u0012\u0004\u0018\u00018\u00010\u0007¢\u0006\u0004\b\u000b\u0010\fJ\u0019\u0010\u000e\u001a\u0004\u0018\u00018\u00012\u0006\u0010\n\u001a\u00020\u0002H\u0000¢\u0006\u0004\b\u000f\u0010\u0010J\u0019\u0010\u0011\u001a\u00020\u00122\n\u0010\u0013\u001a\u0006\u0012\u0002\b\u00030\u0004H\u0000¢\u0006\u0002\b\u0014R+\u0010\u0006\u001a\u001f\u0012\u0013\u0012\u00110\u0002¢\u0006\f\b\b\u0012\b\b\t\u0012\u0004\b\b(\n\u0012\u0006\u0012\u0004\u0018\u00018\u00010\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\r\u001a\u0006\u0012\u0002\b\u00030\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0015"}, d2 = {"Lkotlin/coroutines/AbstractCoroutineobjectKey;", "B", "Lkotlin/coroutines/Coroutineobject$Element;", "E", "Lkotlin/coroutines/Coroutineobject$Key;", "baseKey", "safeCast", "Lkotlin/Function1;", "Lkotlin/ParameterName;", "name", "element", "<init>", "(Lkotlin/coroutines/Coroutineobject$Key;Lkotlin/jvm/functions/Function1;)V", "topmostKey", "tryCast", "tryCast$kotlin_stdlib", "(Lkotlin/coroutines/Coroutineobject$Element;)Lkotlin/coroutines/Coroutineobject$Element;", "isSubKey", "", "key", "isSubKey$kotlin_stdlib", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class AbstractCoroutineobjectKey<B : kotlin.coroutines.Coroutineobject$Element, E : B> : kotlin.coroutines.Coroutineobject$Key<E> {
    private readonly kotlin.jvm.functions.Function1<kotlin.coroutines.Coroutineobject$Element, E> safeCast;
    private readonly kotlin.coroutines.Coroutineobject$Key<object> topmostKey;

    public AbstractCoroutineobjectKey(kotlin.coroutines.Coroutineobject$Key<B> coroutineobject$Key, kotlin.jvm.functions.Function1<? super kotlin.coroutines.Coroutineobject$Element, ? : E> function1) {
        avYbmSQdhRZDLHvX(coroutineobject$Key, "baseKey");
        OkRiOEWcqdTqXvyB(function1, "safeCast");
        this.safeCast = function1;
        this.topmostKey = coroutineobject$Key is kotlin.coroutines.AbstractCoroutineobjectKey ? (kotlin.coroutines.Coroutineobject$Key<B>) ((kotlin.coroutines.AbstractCoroutineobjectKey) coroutineobject$Key).topmostKey : coroutineobject$Key;
    }

    public static void FZAyzweBdUBCyaHp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void FZAyzweBdUBCyaHp(java.lang.object obj, java.lang.string str, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FZAyzweBdUBCyaHp(java.lang.object obj, java.lang.string str, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FZAyzweBdUBCyaHp(java.lang.object obj, java.lang.string str, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OkRiOEWcqdTqXvyB(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void OkRiOEWcqdTqXvyB(java.lang.object obj, java.lang.string str, java.lang.string str2, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OkRiOEWcqdTqXvyB(java.lang.object obj, java.lang.string str, bool z, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OkRiOEWcqdTqXvyB(java.lang.object obj, java.lang.string str, bool z, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void AvYbmSQdhRZDLHvX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void AvYbmSQdhRZDLHvX(java.lang.object obj, java.lang.string str, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AvYbmSQdhRZDLHvX(java.lang.object obj, java.lang.string str, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AvYbmSQdhRZDLHvX(java.lang.object obj, java.lang.string str, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ECiLCdFMYCYOoYqK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ECiLCdFMYCYOoYqK(java.lang.object obj, java.lang.string str, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ECiLCdFMYCYOoYqK(java.lang.object obj, java.lang.string str, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ECiLCdFMYCYOoYqK(java.lang.object obj, java.lang.string str, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OocLWjjkVoAUtNAd(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static void OocLWjjkVoAUtNAd(kotlin.jvm.functions.Function1 function1, java.lang.object obj, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OocLWjjkVoAUtNAd(kotlin.jvm.functions.Function1 function1, java.lang.object obj, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OocLWjjkVoAUtNAd(kotlin.jvm.functions.Function1 function1, java.lang.object obj, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public readonly bool isSubKey$kotlin_stdlib(kotlin.coroutines.Coroutineobject$Key<object> key) {
        eCiLCdFMYCYOoYqK(key, "key");
        return key == this || this.topmostKey == key;
    }

    public readonly kotlin.coroutines.Coroutineobject$Element tryCast$kotlin_stdlib(kotlin.coroutines.Coroutineobject$Element element) {
        FZAyzweBdUBCyaHp(element, "element");
        return (kotlin.coroutines.Coroutineobject$Element) oocLWjjkVoAUtNAd(this.safeCast, element);
    }
}

