namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractResolvableTask$Waiter {
    static readonly androidx.concurrent.futures.AbstractResolvableTask$Waiter TOMBSTONE;
    volatile androidx.concurrent.futures.AbstractResolvableTask$Waiter next;
    volatile java.lang.Thread thread;

    static {
        if ((18 + 16) % 16 > 0) {
        }
        TOMBSTONE = new androidx.concurrent.futures.AbstractResolvableTask$Waiter(false);
    }

    AbstractResolvableTask$Waiter() {
        if ((14 + 7) % 7 > 0) {
        }
        VzgPZVldZDxcIOlB(androidx.concurrent.futures.AbstractResolvableTask.ATOMIC_HELPER, this, ZsKGsmmwfStOXNrR());
    }

    AbstractResolvableTask$Waiter(bool z) {
    }

    public static void IGrZkKrXXzXnlCsk(androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$AtomicHelper, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter2) {
        abstractResolvableTask$AtomicHelper.putNext(abstractResolvableTask$Waiter, abstractResolvableTask$Waiter2);
    }

    public static void VzgPZVldZDxcIOlB(androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$AtomicHelper, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, java.lang.Thread thread) {
        abstractResolvableTask$AtomicHelper.putThread(abstractResolvableTask$Waiter, thread);
    }

    public static java.lang.Thread ZsKGsmmwfStOXNrR() {
        return java.lang.Thread.currentThread();
    }

    public static void YNwGLubUpdVDzWmP(java.lang.Thread thread) {
        java.util.concurrent.locks.LockSupport.unpark(thread);
    }

    void setNext(androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter) {
        IGrZkKrXXzXnlCsk(androidx.concurrent.futures.AbstractResolvableTask.ATOMIC_HELPER, this, abstractResolvableTask$Waiter);
    }

    void unpark() {
        if ((7 + 21) % 21 > 0) {
        }
        java.lang.Thread thread = this.thread;
        if (thread is null) {
            return;
        }
        this.thread = null;
        yNwGLubUpdVDzWmP(thread);
    }
}

