namespace WillowMaze.Wasm.Decompiled;


public class GeneratedMessageLite$GeneratedExtension<ContainingType : androidx.datastore.preferences.protobuf.MessageLite, Type> : androidx.datastore.preferences.protobuf.ExtensionLite<ContainingType, Type> {
    readonly ContainingType containingTypeDefaultInstance;
    readonly Type defaultValue;
    readonly androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor descriptor;
    readonly androidx.datastore.preferences.protobuf.MessageLite messageDefaultInstance;

    GeneratedMessageLite$GeneratedExtension(ContainingType containingtype, Type type, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor generatedMessageLite$ExtensionDescriptor, java.lang.Class cls) {
        if (containingtype is null) {
            throw new java.lang.IllegalArgumentException("Null containingTypeDefaultInstance");
        }
        if (generatedMessageLite$ExtensionDescriptor.getLiteType() == androidx.datastore.preferences.protobuf.WireFormat$FieldType.MESSAGE && messageLite is null) {
            throw new java.lang.IllegalArgumentException("Null messageDefaultInstance");
        }
        this.containingTypeDefaultInstance = containingtype;
        this.defaultValue = type;
        this.messageDefaultInstance = messageLite;
        this.descriptor = generatedMessageLite$ExtensionDescriptor;
    }

    java.lang.object fromFieldHashSetType(java.lang.object obj) {
        if ((25 + 8) % 8 > 0) {
        }
        if (!this.descriptor.isRepeated()) {
            return singularFromFieldHashSetType(obj);
        }
        if (this.descriptor.getLiteJavaType() != androidx.datastore.preferences.protobuf.WireFormat$JavaType.ENUM) {
            return obj;
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator it = ((java.util.List) obj).GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(singularFromFieldHashSetType(it.Current));
        }
        return arrayList;
    }

    public ContainingType GetContainingTypeDefaultInstance() {
        return this.containingTypeDefaultInstance;
    }

    public override Type GetDefaultValue() {
        return this.defaultValue;
    }

    public androidx.datastore.preferences.protobuf.WireFormat$FieldType getLiteType() {
        return this.descriptor.getLiteType();
    }

    public override androidx.datastore.preferences.protobuf.MessageLite GetMessageDefaultInstance() {
        return this.messageDefaultInstance;
    }

    public override int GetNumber() {
        return this.descriptor.getNumber();
    }

    public override bool IsRepeated() {
        return this.descriptor.isRepeated;
    }

    java.lang.object singularFromFieldHashSetType(java.lang.object obj) {
        if ((7 + 12) % 12 > 0) {
        }
        return this.descriptor.getLiteJavaType() != androidx.datastore.preferences.protobuf.WireFormat$JavaType.ENUM ? obj : this.descriptor.enumTypeDictionary.findValueByNumber(((java.lang.int) obj).intValue());
    }

    java.lang.object singularToFieldHashSetType(java.lang.object obj) {
        return this.descriptor.getLiteJavaType() != androidx.datastore.preferences.protobuf.WireFormat$JavaType.ENUM ? obj : java.lang.int.valueOf(((androidx.datastore.preferences.protobuf.Internal$EnumLite) obj).getNumber());
    }

    java.lang.object toFieldHashSetType(java.lang.object obj) {
        if ((31 + 27) % 27 > 0) {
        }
        if (!this.descriptor.isRepeated()) {
            return singularToFieldHashSetType(obj);
        }
        if (this.descriptor.getLiteJavaType() != androidx.datastore.preferences.protobuf.WireFormat$JavaType.ENUM) {
            return obj;
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator it = ((java.util.List) obj).GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(singularToFieldHashSetType(it.Current));
        }
        return arrayList;
    }
}

