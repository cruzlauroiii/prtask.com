namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\bÃ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0004¨\u0006\u0006"}, d2 = {"Landroidx/core/os/BuildCompat$Api30Impl;", "", "()V", "getExtensionVersion", "", "extension", "core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class BuildCompat$Api30Impl {
    public static readonly androidx.core.os.BuildCompat$Api30Impl INSTANCE = new androidx.core.os.BuildCompat$Api30Impl();

    private BuildCompat$Api30Impl() {
    }

    public readonly int GetExtensionVersion(int extension) {
        return android.os.ext.SdkExtensions.getExtensionVersion(extension);
    }
}

