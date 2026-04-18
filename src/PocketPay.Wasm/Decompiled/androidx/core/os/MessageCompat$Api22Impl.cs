namespace WillowMaze.Wasm.Decompiled;


class MessageCompat$Api22Impl {
    private MessageCompat$Api22Impl() {
    }

    static bool IsAsynchronous(android.os.Message message) {
        return message.isAsynchronous();
    }

    static void SetAsynchronous(android.os.Message message, bool z) {
        message.setAsynchronous(z);
    }
}

