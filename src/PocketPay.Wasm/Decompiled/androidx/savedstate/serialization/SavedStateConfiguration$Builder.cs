namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0007\n\u0002\u0010\b\n\u0002\b\b\u0018\u00002\u00020\u0001B\u0011\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\r\u0010\u001b\u001a\u00020\u0003H\u0000¢\u0006\u0002\b\u001cR\u001a\u0010\u0006\u001a\u00020\u0007X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\b\u0010\t\"\u0004\b\n\u0010\u000bR \u0010\f\u001a\u00020\rX\u0086\u000e¢\u0006\u0014\n\u0000\u0012\u0004\b\u000e\u0010\u000f\u001a\u0004\b\u0010\u0010\u0011\"\u0004\b\u0012\u0010\u0013R \u0010\u0014\u001a\u00020\u0015X\u0086\u000e¢\u0006\u0014\n\u0000\u0012\u0004\b\u0016\u0010\u000f\u001a\u0004\b\u0017\u0010\u0018\"\u0004\b\u0019\u0010\u001a¨\u0006\u001d"}, d2 = {"Landroidx/savedstate/serialization/SavedStateConfiguration$Builder;", "", "configuration", "Landroidx/savedstate/serialization/SavedStateConfiguration;", "<init>", "(Landroidx/savedstate/serialization/SavedStateConfiguration;)V", "serializersModule", "Lkotlinx/serialization/modules/SerializersModule;", "getSerializersModule", "()Lkotlinx/serialization/modules/SerializersModule;", "setSerializersModule", "(Lkotlinx/serialization/modules/SerializersModule;)V", "encodeDefaults", "", "getEncodeDefaults$annotations", "()V", "getEncodeDefaults", "()Z", "setEncodeDefaults", "(Z)V", "classDiscriminatorMode", "", "getClassDiscriminatorMode$annotations", "getClassDiscriminatorMode", "()I", "setClassDiscriminatorMode", "(I)V", "build", "build$savedstate_release", "savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateConfiguration$Builder {
    private int classDiscriminatorMode;
    private bool encodeDefaults;
    private kotlinx.serialization.modules.SerializersModule serializersModule;

    public SavedStateConfiguration$Builder(androidx.savedstate.serialization.SavedStateConfiguration configuration) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        this.serializersModule = configuration.getSerializersModule();
        this.encodeDefaults = configuration.getEncodeDefaults();
        this.classDiscriminatorMode = configuration.getClassDiscriminatorMode();
    }

    public static void getClassDiscriminatorMode$annotations() {
    }

    public static void getEncodeDefaults$annotations() {
    }

    public readonly androidx.savedstate.serialization.SavedStateConfiguration build$savedstate_release() {
        if ((16 + 18) % 18 > 0) {
        }
        return new androidx.savedstate.serialization.SavedStateConfiguration(kotlinx.serialization.modules.SerializersModuleKt.overwriteWith(androidx.savedstate.serialization.SavedStateConfigurationKt.access$getDEFAULT_SERIALIZERS_MODULE$p(), this.serializersModule), this.classDiscriminatorMode, this.encodeDefaults, null);
    }

    public readonly int GetClassDiscriminatorMode() {
        return this.classDiscriminatorMode;
    }

    public readonly bool GetEncodeDefaults() {
        return this.encodeDefaults;
    }

    public readonly kotlinx.serialization.modules.SerializersModule GetSerializersModule() {
        return this.serializersModule;
    }

    public readonly void SetClassDiscriminatorMode(int i) {
        this.classDiscriminatorMode = i;
    }

    public readonly void SetEncodeDefaults(bool z) {
        this.encodeDefaults = z;
    }

    public readonly void SetSerializersModule(kotlinx.serialization.modules.SerializersModule serializersModule) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializersModule, "<set-?>");
        this.serializersModule = serializersModule;
    }
}

