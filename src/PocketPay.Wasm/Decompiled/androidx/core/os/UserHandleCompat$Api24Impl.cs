namespace WillowMaze.Wasm.Decompiled;


class UserHandleCompat$Api24Impl {
    private UserHandleCompat$Api24Impl() {
    }

    static android.os.UserHandle GetUserHandleForUid(int i) {
        return android.os.UserHandle.getUserHandleForUid(i);
    }
}

