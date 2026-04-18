namespace WillowMaze.Wasm.Decompiled;


class SubscriptionManagerCompat$Api29Impl {
    private SubscriptionManagerCompat$Api29Impl() {
    }

    static int GetSlotIndex(int i) {
        return android.telephony.SubscriptionManager.getSlotIndex(i);
    }
}

