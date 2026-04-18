namespace WillowMaze.Wasm.Decompiled;


public class SubscriptionManagerCompat {
    private static java.lang.reflect.Method sGetSlotIndexMethod;

    private SubscriptionManagerCompat() {
    }

    public static int GetSlotIndex(int i) {
        if (i != -1) {
            return androidx.core.telephony.SubscriptionManagerCompat$Api29Impl.getSlotIndex(i);
        }
        return -1;
    }
}

