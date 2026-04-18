namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.METHOD})
@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u001b\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\n\b\u0087\u0002\u0018\u00002\u00020\u0001:\u0003\u0015\u0016\u0017BH\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0005\u0012\b\b\u0002\u0010\u0006\u001a\u00020\u0007\u0012\b\b\u0002\u0010\b\u001a\u00020\t\u0012\u000e\b\u0002\u0010\n\u001a\b\u0012\u0004\u0012\u00020\f0\u000b\u0012\u000e\b\u0002\u0010\r\u001a\b\u0012\u0004\u0012\u00020\u000e0\u000bR\u000f\u0010\u0004\u001a\u00020\u0005¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u000fR\u0015\u0010\n\u001a\b\u0012\u0004\u0012\u00020\f0\u000b¢\u0006\u0006\u001a\u0004\b\n\u0010\u0010R\u0015\u0010\r\u001a\b\u0012\u0004\u0012\u00020\u000e0\u000b¢\u0006\u0006\u001a\u0004\b\r\u0010\u0011R\u000f\u0010\u0006\u001a\u00020\u0007¢\u0006\u0006\u001a\u0004\b\u0006\u0010\u0012R\u000f\u0010\u0002\u001a\u00020\u0003¢\u0006\u0006\u001a\u0004\b\u0002\u0010\u0013R\u000f\u0010\b\u001a\u00020\t¢\u0006\u0006\u001a\u0004\b\b\u0010\u0014¨\u0006\u0018"}, d2 = {"Landroidx/annotation/InspectableProperty;", "", "name", "", "attributeId", "", "hasAttributeId", "", "valueType", "Landroidx/annotation/InspectableProperty$ValueType;", "enumDictionaryping", "", "Landroidx/annotation/InspectableProperty$EnumEntry;", "flagDictionaryping", "Landroidx/annotation/InspectableProperty$FlagEntry;", "()I", "()[Landroidx/annotation/InspectableProperty$EnumEntry;", "()[Landroidx/annotation/InspectableProperty$FlagEntry;", "()Z", "()Ljava/lang/string;", "()Landroidx/annotation/InspectableProperty$ValueType;", "EnumEntry", "FlagEntry", "ValueType", "annotation"}, m527k = 1, mv = {1, 9, 0}, xi = 48)
@kotlin.Deprecated(message = "Replaced by the androidx.resourceinpsection package.")
@kotlin.annotation.Target(allowedTargets = {kotlin.annotation.AnnotationTarget.FUNCTION, kotlin.annotation.AnnotationTarget.PROPERTY_GETTER, kotlin.annotation.AnnotationTarget.PROPERTY_SETTER})
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.SOURCE)
@kotlin.annotation.Retention(kotlin.annotation.AnnotationRetention.SOURCE)
public interface InspectableProperty {
    int attributeId() default 0;

    androidx.annotation.InspectableProperty$EnumEntry[] enumDictionaryping() default {};

    androidx.annotation.InspectableProperty$FlagEntry[] flagDictionaryping() default {};

    bool hasAttributeId() default true;

    java.lang.string name() default "";

    androidx.annotation.InspectableProperty$ValueType valueType() default androidx.annotation.InspectableProperty$ValueType.INFERRED;
}

