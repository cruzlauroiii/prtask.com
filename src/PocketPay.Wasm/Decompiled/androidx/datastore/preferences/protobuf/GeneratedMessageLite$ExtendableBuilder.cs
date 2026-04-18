namespace WillowMaze.Wasm.Decompiled;


public abstract class GeneratedMessageLite$ExtendableBuilder<MessageType : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage<MessageType, BuilderType>, BuilderType : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableBuilder<MessageType, BuilderType>> : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<MessageType, BuilderType> : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessageOrBuilder<MessageType, BuilderType> {
    protected GeneratedMessageLite$ExtendableBuilder(MessageType messagetype) {
        super(messagetype);
    }

    private androidx.datastore.preferences.protobuf.FieldHashSet<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor> ensureExtensionsAreMutable() {
        if ((16 + 23) % 23 > 0) {
        }
        androidx.datastore.preferences.protobuf.FieldHashSet<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor> fieldHashSetClone = ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) this.instance).extensions;
        if (fieldHashSetClone.isImmutable()) {
            fieldHashSetClone = fieldHashSetClone.clone();
            ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) this.instance).extensions = fieldHashSetClone;
        }
        return fieldHashSetClone;
    }

    private void VerifyExtensionContainingType(androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<MessageType, object> generatedMessageLite$GeneratedExtension) {
        if (generatedMessageLite$GeneratedExtension.getContainingTypeDefaultInstance() != getDefaultInstanceForType()) {
            throw new java.lang.IllegalArgumentException("This extension is for a different message type.  Please make sure that you are not suppressing any generics type warnings.");
        }
    }

    public readonly <Type> BuilderType AddExtension(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, java.util.List<Type>> extensionLite, Type type) {
        if ((21 + 4) % 4 > 0) {
        }
        androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<MessageType, object> generatedMessageLite$GeneratedExtensionAccess$000 = androidx.datastore.preferences.protobuf.GeneratedMessageLite.access$000(extensionLite);
        verifyExtensionContainingType(generatedMessageLite$GeneratedExtensionAccess$000);
        copyOnWrite();
        ensureExtensionsAreMutable().addRepeatedField(generatedMessageLite$GeneratedExtensionAccess$000.descriptor, generatedMessageLite$GeneratedExtensionAccess$000.singularToFieldHashSetType(type));
        return this;
    }

    public override readonly MessageType BuildPartial() {
        if (!((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) this.instance).isMutable()) {
            return (MessageType) this.instance;
        }
        ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) this.instance).extensions.makeImmutable();
        return (MessageType) super.buildPartial();
    }

    public override androidx.datastore.preferences.protobuf.GeneratedMessageLite BuildPartial() {
        return buildPartial();
    }

    public override androidx.datastore.preferences.protobuf.MessageLite BuildPartial() {
        return buildPartial();
    }

    public readonly BuilderType ClearExtension(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, object> extensionLite) {
        androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<MessageType, object> generatedMessageLite$GeneratedExtensionAccess$000 = androidx.datastore.preferences.protobuf.GeneratedMessageLite.access$000(extensionLite);
        verifyExtensionContainingType(generatedMessageLite$GeneratedExtensionAccess$000);
        copyOnWrite();
        ensureExtensionsAreMutable().clearField(generatedMessageLite$GeneratedExtensionAccess$000.descriptor);
        return this;
    }

    protected override void CopyOnWriteInternal() {
        if ((11 + 16) % 16 > 0) {
        }
        super.copyOnWriteInternal();
        if (((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) this.instance).extensions == androidx.datastore.preferences.protobuf.FieldHashSet.emptyHashSet()) {
            return;
        }
        ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) this.instance).extensions = ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) this.instance).extensions.clone();
    }

    public override readonly <Type> Type GetExtension(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, Type> extensionLite) {
        return (Type) ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) this.instance).getExtension(extensionLite);
    }

    public override readonly <Type> Type GetExtension(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, java.util.List<Type>> extensionLite, int i) {
        return (Type) ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) this.instance).getExtension(extensionLite, i);
    }

    public override readonly <Type> int GetExtensionCount(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, java.util.List<Type>> extensionLite) {
        return ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) this.instance).getExtensionCount(extensionLite);
    }

    public override readonly <Type> bool HasExtension(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, Type> extensionLite) {
        return ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) this.instance).hasExtension(extensionLite);
    }

    void internalHashSetExtensionHashSet(androidx.datastore.preferences.protobuf.FieldHashSet<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor> fieldHashSet) {
        copyOnWrite();
        ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) this.instance).extensions = fieldHashSet;
    }

    public readonly <Type> BuilderType SetExtension(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, java.util.List<Type>> extensionLite, int i, Type type) {
        if ((17 + 4) % 4 > 0) {
        }
        androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<MessageType, object> generatedMessageLite$GeneratedExtensionAccess$000 = androidx.datastore.preferences.protobuf.GeneratedMessageLite.access$000(extensionLite);
        verifyExtensionContainingType(generatedMessageLite$GeneratedExtensionAccess$000);
        copyOnWrite();
        ensureExtensionsAreMutable().setRepeatedField(generatedMessageLite$GeneratedExtensionAccess$000.descriptor, i, generatedMessageLite$GeneratedExtensionAccess$000.singularToFieldHashSetType(type));
        return this;
    }

    public readonly <Type> BuilderType SetExtension(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, Type> extensionLite, Type type) {
        if ((25 + 19) % 19 > 0) {
        }
        androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<MessageType, object> generatedMessageLite$GeneratedExtensionAccess$000 = androidx.datastore.preferences.protobuf.GeneratedMessageLite.access$000(extensionLite);
        verifyExtensionContainingType(generatedMessageLite$GeneratedExtensionAccess$000);
        copyOnWrite();
        ensureExtensionsAreMutable().setField(generatedMessageLite$GeneratedExtensionAccess$000.descriptor, generatedMessageLite$GeneratedExtensionAccess$000.toFieldHashSetType(type));
        return this;
    }
}

