namespace WillowMaze.Wasm.Decompiled;


public class Event<T> {
    private readonly T payload;
    private readonly java.lang.Class<T> type;

    public Event(java.lang.Class<T> cls, T t) {
        this.type = (java.lang.Class) YSpJGEzTxZsWKYuT(cls);
        this.payload = (T) qsbJTDfQuapHazAj(t);
    }

    public static java.lang.string YPbNIzCEvyjoTinV(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void YPbNIzCEvyjoTinV(java.lang.string str, java.lang.object[] objArr, char c, short s, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YPbNIzCEvyjoTinV(java.lang.string str, java.lang.object[] objArr, float f, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YPbNIzCEvyjoTinV(java.lang.string str, java.lang.object[] objArr, short s, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YSpJGEzTxZsWKYuT(java.lang.object obj) {
        return com.google.firebase.components.Preconditions.checkNotNull(obj);
    }

    public static void YSpJGEzTxZsWKYuT(java.lang.object obj, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YSpJGEzTxZsWKYuT(java.lang.object obj, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YSpJGEzTxZsWKYuT(java.lang.object obj, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object QsbJTDfQuapHazAj(java.lang.object obj) {
        return com.google.firebase.components.Preconditions.checkNotNull(obj);
    }

    public static void QsbJTDfQuapHazAj(java.lang.object obj, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QsbJTDfQuapHazAj(java.lang.object obj, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QsbJTDfQuapHazAj(java.lang.object obj, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public T GetPayload() {
        return this.payload;
    }

    public java.lang.Class<T> GetType() {
        return this.type;
    }

    public java.lang.string Tostring() {
        return YPbNIzCEvyjoTinV("Event{type: %s, payload: %s}", new java.lang.object[]{this.type, this.payload});
    }
}

