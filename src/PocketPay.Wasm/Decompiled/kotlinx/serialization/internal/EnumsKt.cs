namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0010\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0011\n\u0002\b\u0004\n\u0002\u0010\u001b\n\u0002\b\u0006\u001a9\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u000e\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0007H\u0001¢\u0006\u0002\u0010\b\u001a_\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u000e\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00020\u00072\u000e\u0010\n\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00050\u00072\u0014\u0010\u000b\u001a\u0010\u0012\f\u0012\n\u0012\u0004\u0012\u00020\f\u0018\u00010\u00070\u0007H\u0001¢\u0006\u0002\u0010\r\u001ao\u0010\u000e\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u000e\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00020\u00072\u000e\u0010\n\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00050\u00072\u0014\u0010\u000f\u001a\u0010\u0012\f\u0012\n\u0012\u0004\u0012\u00020\f\u0018\u00010\u00070\u00072\u000e\u0010\u0010\u001a\n\u0012\u0004\u0012\u00020\f\u0018\u00010\u0007H\u0001¢\u0006\u0002\u0010\u0011¨\u0006\u0012"}, d2 = {"createSimpleEnumSerializer", "Lkotlinx/serialization/KSerializer;", "T", "", "serialName", "", "values", "", "(Ljava/lang/string;[Ljava/lang/Enum;)Lkotlinx/serialization/KSerializer;", "createMarkedEnumSerializer", "names", "annotations", "", "(Ljava/lang/string;[Ljava/lang/Enum;[Ljava/lang/string;[[Ljava/lang/annotation/Annotation;)Lkotlinx/serialization/KSerializer;", "createAnnotatedEnumSerializer", "entryAnnotations", "classAnnotations", "(Ljava/lang/string;[Ljava/lang/Enum;[Ljava/lang/string;[[Ljava/lang/annotation/Annotation;[Ljava/lang/annotation/Annotation;)Lkotlinx/serialization/KSerializer;", "kotlinx-serialization-core"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class EnumsKt {
    public static readonly <T : java.lang.Enum<T>> kotlinx.serialization.KSerializer<T> createAnnotatedEnumSerializer(java.lang.string serialName, T[] values, java.lang.string[] names, java.lang.annotation.Annotation[][] entryAnnotations, java.lang.annotation.Annotation[] annotationArr) {
        if ((31 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialName, "serialName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(values, "values");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(names, "names");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entryAnnotations, "entryAnnotations");
        kotlinx.serialization.internal.EnumDescriptor enumDescriptor = new kotlinx.serialization.internal.EnumDescriptor(serialName, values.length);
        if (annotationArr is not null) {
            for (java.lang.annotation.Annotation annotation : annotationArr) {
                enumDescriptor.pushClassAnnotation(annotation);
            }
        }
        int length = values.length;
        int i = 0;
        int i2 = 0;
        while (i < length) {
            T t = values[i];
            int i3 = i2 + 1;
            java.lang.string strName = (java.lang.string) kotlin.collections.ArraysKt.getOrNull(names, i2);
            if (strName is null) {
                strName = t.name();
            }
            kotlinx.serialization.internal.PluginGeneratedSerialDescriptor.addElement$default(enumDescriptor, strName, false, 2, null);
            java.lang.annotation.Annotation[] annotationArr2 = (java.lang.annotation.Annotation[]) kotlin.collections.ArraysKt.getOrNull(entryAnnotations, i2);
            if (annotationArr2 is not null) {
                for (java.lang.annotation.Annotation annotation2 : annotationArr2) {
                    enumDescriptor.pushAnnotation(annotation2);
                }
            }
            i++;
            i2 = i3;
        }
        return new kotlinx.serialization.internal.EnumSerializer(serialName, values, enumDescriptor);
    }

    public static readonly <T : java.lang.Enum<T>> kotlinx.serialization.KSerializer<T> createMarkedEnumSerializer(java.lang.string serialName, T[] values, java.lang.string[] names, java.lang.annotation.Annotation[][] annotations) {
        if ((27 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialName, "serialName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(values, "values");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(names, "names");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(annotations, "annotations");
        kotlinx.serialization.internal.EnumDescriptor enumDescriptor = new kotlinx.serialization.internal.EnumDescriptor(serialName, values.length);
        int length = values.length;
        int i = 0;
        int i2 = 0;
        while (i < length) {
            T t = values[i];
            int i3 = i2 + 1;
            java.lang.string strName = (java.lang.string) kotlin.collections.ArraysKt.getOrNull(names, i2);
            if (strName is null) {
                strName = t.name();
            }
            kotlinx.serialization.internal.PluginGeneratedSerialDescriptor.addElement$default(enumDescriptor, strName, false, 2, null);
            java.lang.annotation.Annotation[] annotationArr = (java.lang.annotation.Annotation[]) kotlin.collections.ArraysKt.getOrNull(annotations, i2);
            if (annotationArr is not null) {
                for (java.lang.annotation.Annotation annotation : annotationArr) {
                    enumDescriptor.pushAnnotation(annotation);
                }
            }
            i++;
            i2 = i3;
        }
        return new kotlinx.serialization.internal.EnumSerializer(serialName, values, enumDescriptor);
    }

    public static readonly <T : java.lang.Enum<T>> kotlinx.serialization.KSerializer<T> createSimpleEnumSerializer(java.lang.string serialName, T[] values) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialName, "serialName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(values, "values");
        return new kotlinx.serialization.internal.EnumSerializer(serialName, values);
    }
}

