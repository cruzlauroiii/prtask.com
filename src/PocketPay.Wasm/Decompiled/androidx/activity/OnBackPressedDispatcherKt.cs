namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\u001a9\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\n\b\u0002\u0010\u0003\u001a\u0004\u0018\u00010\u00042\b\b\u0002\u0010\u0005\u001a\u00020\u00062\u0017\u0010\u0007\u001a\u0013\u0012\u0004\u0012\u00020\u0001\u0012\u0004\u0012\u00020\t0\b¢\u0006\u0002\b\n¨\u0006\u000b"}, d2 = {"addCallback", "Landroidx/activity/OnBackPressedCallback;", "Landroidx/activity/OnBackPressedDispatcher;", "owner", "Landroidx/lifecycle/LifecycleOwner;", "enabled", "", "onBackPressed", "Lkotlin/Function1;", "", "Lkotlin/ExtensionFunctionType;", "activity_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class OnBackPressedDispatcherKt {
    public static void AzeyKXkzFfAHqSPF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void AzeyKXkzFfAHqSPF(java.lang.object obj, java.lang.string str, java.lang.string str2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AzeyKXkzFfAHqSPF(java.lang.object obj, java.lang.string str, short s, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void AzeyKXkzFfAHqSPF(java.lang.object obj, java.lang.string str, short s, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ERtnvrjZLRWLVAdq(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.activity.OnBackPressedCallback onBackPressedCallback) {
        onBackPressedDispatcher.addCallback(lifecycleOwner, onBackPressedCallback);
    }

    public static void ERtnvrjZLRWLVAdq(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.activity.OnBackPressedCallback onBackPressedCallback, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ERtnvrjZLRWLVAdq(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.activity.OnBackPressedCallback onBackPressedCallback, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ERtnvrjZLRWLVAdq(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.activity.OnBackPressedCallback onBackPressedCallback, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HrXaLDLqkrKSLAIH(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.activity.OnBackPressedCallback onBackPressedCallback) {
        onBackPressedDispatcher.addCallback(onBackPressedCallback);
    }

    public static void HrXaLDLqkrKSLAIH(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.activity.OnBackPressedCallback onBackPressedCallback, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HrXaLDLqkrKSLAIH(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.activity.OnBackPressedCallback onBackPressedCallback, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HrXaLDLqkrKSLAIH(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.activity.OnBackPressedCallback onBackPressedCallback, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static readonly androidx.activity.OnBackPressedCallback AddCallback(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.LifecycleOwner lifecycleOwner, bool z, kotlin.jvm.functions.Function1<? super androidx.activity.OnBackPressedCallback, kotlin.Unit> function1) {
        skoFCFrCPAKtfDhX(onBackPressedDispatcher, "<this>");
        AzeyKXkzFfAHqSPF(function1, "onBackPressed");
        androidx.activity.OnBackPressedDispatcherKt$addCallback$callback$1 onBackPressedDispatcherKt$addCallback$callback$1 = new androidx.activity.OnBackPressedDispatcherKt$addCallback$callback$1(z, function1);
        if (lifecycleOwner is null) {
            HrXaLDLqkrKSLAIH(onBackPressedDispatcher, onBackPressedDispatcherKt$addCallback$callback$1);
        } else {
            ERtnvrjZLRWLVAdq(onBackPressedDispatcher, lifecycleOwner, onBackPressedDispatcherKt$addCallback$callback$1);
        }
        return onBackPressedDispatcherKt$addCallback$callback$1;
    }

    public static readonly void AddCallback(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.LifecycleOwner lifecycleOwner, bool z, kotlin.jvm.functions.Function1 function1, float f, short s, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static readonly void AddCallback(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.LifecycleOwner lifecycleOwner, bool z, kotlin.jvm.functions.Function1 function1, float f, bool z2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static readonly void AddCallback(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.LifecycleOwner lifecycleOwner, bool z, kotlin.jvm.functions.Function1 function1, bool z2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static androidx.activity.OnBackPressedCallback addCallback$default(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.LifecycleOwner lifecycleOwner, bool z, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            lifecycleOwner = null;
        }
        if ((i & 2) != 0) {
            z = true;
        }
        return dmsjRGKqKzrdgFcl(onBackPressedDispatcher, lifecycleOwner, z, function1);
    }

    public static void addCallback$default(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.LifecycleOwner lifecycleOwner, bool z, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void addCallback$default(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.LifecycleOwner lifecycleOwner, bool z, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void addCallback$default(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.LifecycleOwner lifecycleOwner, bool z, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static androidx.activity.OnBackPressedCallback DmsjRGKqKzrdgFcl(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.LifecycleOwner lifecycleOwner, bool z, kotlin.jvm.functions.Function1 function1) {
        return addCallback(onBackPressedDispatcher, lifecycleOwner, z, function1);
    }

    public static void DmsjRGKqKzrdgFcl(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.LifecycleOwner lifecycleOwner, bool z, kotlin.jvm.functions.Function1 function1, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DmsjRGKqKzrdgFcl(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.LifecycleOwner lifecycleOwner, bool z, kotlin.jvm.functions.Function1 function1, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DmsjRGKqKzrdgFcl(androidx.activity.OnBackPressedDispatcher onBackPressedDispatcher, androidx.lifecycle.LifecycleOwner lifecycleOwner, bool z, kotlin.jvm.functions.Function1 function1, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SkoFCFrCPAKtfDhX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SkoFCFrCPAKtfDhX(java.lang.object obj, java.lang.string str, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SkoFCFrCPAKtfDhX(java.lang.object obj, java.lang.string str, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SkoFCFrCPAKtfDhX(java.lang.object obj, java.lang.string str, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }
}

