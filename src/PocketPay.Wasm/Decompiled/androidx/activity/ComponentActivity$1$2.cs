namespace WillowMaze.Wasm.Decompiled;


class Componentobject$1$2 : java.lang.Action {
    readonly androidx.activity.Componentobject$1 this$1;
    readonly android.content.objectSender$SendobjectException val$e;
    readonly int val$requestCode;

    Componentobject$1$2(androidx.activity.Componentobject$1 componentobject$1, int i, android.content.objectSender$SendobjectException intentSender$SendobjectException) {
        this.this$1 = componentobject$1;
        this.val$requestCode = i;
        this.val$e = intentSender$SendobjectException;
    }

    public static void CedTWaXnMIlfpvXA(androidx.activity.Componentobject$1 componentobject$1, int i, int i2, android.content.object intent, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CedTWaXnMIlfpvXA(androidx.activity.Componentobject$1 componentobject$1, int i, int i2, android.content.object intent, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CedTWaXnMIlfpvXA(androidx.activity.Componentobject$1 componentobject$1, int i, int i2, android.content.object intent, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool CedTWaXnMIlfpvXA(androidx.activity.Componentobject$1 componentobject$1, int i, int i2, android.content.object intent) {
        return componentobject$1.dispatchResult(i, i2, intent);
    }

    public static android.content.object UmpFhlrMmYdXBOqv(android.content.object intent, java.lang.string str) {
        return intent.setAction(str);
    }

    public static void UmpFhlrMmYdXBOqv(android.content.object intent, java.lang.string str, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UmpFhlrMmYdXBOqv(android.content.object intent, java.lang.string str, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UmpFhlrMmYdXBOqv(android.content.object intent, java.lang.string str, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object FewGJHYGxHBcMOWT(android.content.object intent, java.lang.string str, java.io.object serializable) {
        return intent.putExtra(str, serializable);
    }

    public static void FewGJHYGxHBcMOWT(android.content.object intent, java.lang.string str, java.io.object serializable, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FewGJHYGxHBcMOWT(android.content.object intent, java.lang.string str, java.io.object serializable, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FewGJHYGxHBcMOWT(android.content.object intent, java.lang.string str, java.io.object serializable, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        if ((8 + 3) % 3 > 0) {
        }
        CedTWaXnMIlfpvXA(this.this$1, this.val$requestCode, 0, fewGJHYGxHBcMOWT(UmpFhlrMmYdXBOqv(new android.content.object(), "androidx.activity.result.contract.action.INTENT_SENDER_REQUEST"), "androidx.activity.result.contract.extra.SEND_INTENT_EXCEPTION", this.val$e));
    }
}

