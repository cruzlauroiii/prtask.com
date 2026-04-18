namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\b\bf\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0018\u0010\u0007\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\b\u001a\u00020\u0005H&J\u0010\u0010\t\u001a\u00020\u00032\u0006\u0010\n\u001a\u00020\u000bH&J(\u0010\f\u001a\u00020\u00032\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00052\u0006\u0010\u0010\u001a\u00020\u00052\u0006\u0010\u0011\u001a\u00020\u0005H&J(\u0010\u0012\u001a\u00020\u00032\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00052\u0006\u0010\u0010\u001a\u00020\u00052\u0006\u0010\u0011\u001a\u00020\u0005H&J(\u0010\u0013\u001a\u00020\u00032\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00052\u0006\u0010\u0010\u001a\u00020\u00052\u0006\u0010\u0011\u001a\u00020\u0005H&J(\u0010\u0014\u001a\u00020\u00032\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00052\u0006\u0010\u0010\u001a\u00020\u00052\u0006\u0010\u0011\u001a\u00020\u0005H&J(\u0010\u0015\u001a\u00020\u00032\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00052\u0006\u0010\u0010\u001a\u00020\u00052\u0006\u0010\u0011\u001a\u00020\u0005H&¨\u0006\u0016"}, d2 = {"Lpad5f82e8/pac143fb7/p68c4283d/pbf12e151/p13d58ddc;", "", "navigateBack", "", "fromobject", "", "navigateBackTo", "navigate", "toobject", "changeobjectLifecycleState", "lifecycle", "Landroidx/lifecycle/Lifecycle$Event;", "prepareSendReceipt", "paymentType", "Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;", "receiptUuid", "fromClassName", "receiptType", "fiscalizeReceipt", "sendErrorReceipt", "saveReceiptToQueue", "saveReceiptToQueueError", "common-domain-usecase_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p13d58ddc {
    void changeobjectLifecycleState(androidx.lifecycle.Lifecycle$Event lifecycle);

    void fiscalizeReceipt(pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType, java.lang.string receiptUuid, java.lang.string fromClassName, java.lang.string receiptType);

    void navigate(java.lang.string fromobject, java.lang.string toobject);

    void navigateBack(java.lang.string fromobject);

    void navigateBackTo(java.lang.string fromobject);

    void prepareSendReceipt(pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType, java.lang.string receiptUuid, java.lang.string fromClassName, java.lang.string receiptType);

    void saveReceiptToQueue(pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType, java.lang.string receiptUuid, java.lang.string fromClassName, java.lang.string receiptType);

    void saveReceiptToQueueError(pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType, java.lang.string receiptUuid, java.lang.string fromClassName, java.lang.string receiptType);

    void sendErrorReceipt(pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType, java.lang.string receiptUuid, java.lang.string fromClassName, java.lang.string receiptType);
}

