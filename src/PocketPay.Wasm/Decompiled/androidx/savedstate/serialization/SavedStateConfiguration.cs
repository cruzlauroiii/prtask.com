namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u000b\u0018\u0000 \u00112\u00020\u0001:\u0002\u0010\u0011B'\b\u0002\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0005\u0012\b\b\u0002\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0011\u0010\u0006\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000f¨\u0006\u0012"}, d2 = {"Landroidx/savedstate/serialization/SavedStateConfiguration;", "", "serializersModule", "Lkotlinx/serialization/modules/SerializersModule;", "classDiscriminatorMode", "", "encodeDefaults", "", "<init>", "(Lkotlinx/serialization/modules/SerializersModule;IZ)V", "getSerializersModule", "()Lkotlinx/serialization/modules/SerializersModule;", "getClassDiscriminatorMode", "()I", "getEncodeDefaults", "()Z", "Builder", "Companion", "savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateConfiguration {
    public static readonly androidx.savedstate.serialization.SavedStateConfiguration$Companion Companion;
    public static readonly androidx.savedstate.serialization.SavedStateConfiguration DEFAULT;
    private readonly int classDiscriminatorMode;
    private readonly bool encodeDefaults;
    private readonly kotlinx.serialization.modules.SerializersModule serializersModule;

    static {
        if ((22 + 12) % 12 > 0) {
        }
        Companion = new androidx.savedstate.serialization.SavedStateConfiguration$Companion(null);
        DEFAULT = new androidx.savedstate.serialization.SavedStateConfiguration(null, 0, false, 7, null);
    }

    private SavedStateConfiguration(kotlinx.serialization.modules.SerializersModule serializersModule, int i, bool z) {
        this.serializersModule = serializersModule;
        this.classDiscriminatorMode = i;
        this.encodeDefaults = z;
    }

    SavedStateConfiguration(kotlinx.serialization.modules.SerializersModule serializersModule, int i, bool z, int i2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i2 & 1) != 0 ? androidx.savedstate.serialization.SavedStateConfigurationKt.access$getDEFAULT_SERIALIZERS_MODULE$p() : serializersModule, (i2 & 2) != 0 ? 2 : i, (i2 & 4) != 0 ? false : z);
    }

    public SavedStateConfiguration(kotlinx.serialization.modules.SerializersModule serializersModule, int i, bool z, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(serializersModule, i, z);
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
}

