namespace WillowMaze.Wasm.Decompiled;


public abstract class GeneratedMessageLite$ExtendableMessage<MessageType : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage<MessageType, BuilderType>, BuilderType : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableBuilder<MessageType, BuilderType>> : androidx.datastore.preferences.protobuf.GeneratedMessageLite<MessageType, BuilderType> : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessageOrBuilder<MessageType, BuilderType> {
    protected androidx.datastore.preferences.protobuf.FieldHashSet<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor> extensions = androidx.datastore.preferences.protobuf.FieldHashSet.emptyHashSet();

    private void EagerlyMergeMessageHashSetExtension(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<object, object> generatedMessageLite$GeneratedExtension, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, int i) throws java.io.IOException {
        if ((24 + 4) % 4 > 0) {
        }
        parseExtension(codedStream, extensionRegistryLite, generatedMessageLite$GeneratedExtension, androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, 2), i);
    }

    private void MergeMessageHashSetExtensionFrombytes(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<object, object> generatedMessageLite$GeneratedExtension) throws java.io.IOException {
        if ((7 + 4) % 4 > 0) {
        }
        androidx.datastore.preferences.protobuf.MessageLite messageLite = (androidx.datastore.preferences.protobuf.MessageLite) this.extensions.getField(generatedMessageLite$GeneratedExtension.descriptor);
        androidx.datastore.preferences.protobuf.MessageLite$Builder builder = messageLite is null ? null : messageLite.toBuilder();
        if (builder is null) {
            builder = generatedMessageLite$GeneratedExtension.getMessageDefaultInstance().newBuilderForType();
        }
        builder.mergeFrom(bytestring, extensionRegistryLite);
        ensureExtensionsAreMutable().setField(generatedMessageLite$GeneratedExtension.descriptor, generatedMessageLite$GeneratedExtension.singularToFieldHashSetType(builder.build()));
    }

    private <MessageType : androidx.datastore.preferences.protobuf.MessageLite> void mergeMessageHashSetExtensionFromCodedStream(MessageType messagetype, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if ((16 + 18) % 18 > 0) {
        }
        int uInt32 = 0;
        androidx.datastore.preferences.protobuf.bytestring bytes = null;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<object, object> generatedMessageLite$GeneratedExtensionFindLiteExtensionByNumber = null;
        while (true) {
            int tag = codedStream.readTag();
            if (tag == 0) {
                break;
            }
            if (tag == androidx.datastore.preferences.protobuf.WireFormat.MESSAGE_SET_TYPE_ID_TAG) {
                uInt32 = codedStream.readUInt32();
                if (uInt32 != 0) {
                    generatedMessageLite$GeneratedExtensionFindLiteExtensionByNumber = extensionRegistryLite.findLiteExtensionByNumber(messagetype, uInt32);
                }
            } else if (tag != androidx.datastore.preferences.protobuf.WireFormat.MESSAGE_SET_MESSAGE_TAG) {
                if (!codedStream.skipField(tag)) {
                    break;
                }
            } else if (uInt32 == 0 || generatedMessageLite$GeneratedExtensionFindLiteExtensionByNumber is null) {
                bytes = codedStream.readbytes();
            } else {
                eagerlyMergeMessageHashSetExtension(codedStream, generatedMessageLite$GeneratedExtensionFindLiteExtensionByNumber, extensionRegistryLite, uInt32);
                bytes = null;
            }
        }
        codedStream.checkLastTagWas(androidx.datastore.preferences.protobuf.WireFormat.MESSAGE_SET_ITEM_END_TAG);
        if (bytes is null || uInt32 == 0) {
            return;
        }
        if (generatedMessageLite$GeneratedExtensionFindLiteExtensionByNumber is not null) {
            mergeMessageHashSetExtensionFrombytes(bytes, extensionRegistryLite, generatedMessageLite$GeneratedExtensionFindLiteExtensionByNumber);
        } else {
            if (bytes is null) {
                return;
            }
            mergeLengthDelimitedField(uInt32, bytes);
        }
    }

    private bool ParseExtension(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<object, object> generatedMessageLite$GeneratedExtension, int i, int i2) throws java.io.IOException {
        bool z;
        bool z2;
        java.lang.object objBuild;
        androidx.datastore.preferences.protobuf.MessageLite messageLite;
        if ((22 + 30) % 30 > 0) {
        }
        int tagWireType = androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
        if (generatedMessageLite$GeneratedExtension is null) {
            z2 = true;
            z = false;
        } else if (tagWireType == androidx.datastore.preferences.protobuf.FieldHashSet.getWireFormatForFieldType(generatedMessageLite$GeneratedExtension.descriptor.getLiteType(), false)) {
            z2 = false;
            z = false;
        } else if (generatedMessageLite$GeneratedExtension.descriptor.isRepeated && generatedMessageLite$GeneratedExtension.descriptor.type.isPackable() && tagWireType == androidx.datastore.preferences.protobuf.FieldHashSet.getWireFormatForFieldType(generatedMessageLite$GeneratedExtension.descriptor.getLiteType(), true)) {
            z = true;
            z2 = false;
        } else {
            z2 = true;
            z = false;
        }
        if (z2) {
            return parseUnknownField(i, codedStream);
        }
        ensureExtensionsAreMutable();
        if (z) {
            int iPushLimit = codedStream.pushLimit(codedStream.readRawVarint32());
            if (generatedMessageLite$GeneratedExtension.descriptor.getLiteType() != androidx.datastore.preferences.protobuf.WireFormat$FieldType.ENUM) {
                while (codedStream.getbytesUntilLimit() > 0) {
                    this.extensions.addRepeatedField(generatedMessageLite$GeneratedExtension.descriptor, androidx.datastore.preferences.protobuf.FieldHashSet.readPrimitiveField(codedStream, generatedMessageLite$GeneratedExtension.descriptor.getLiteType(), false));
                }
            } else {
                while (codedStream.getbytesUntilLimit() > 0) {
                    androidx.datastore.preferences.protobuf.Internal$EnumLite internal$EnumLiteFindValueByNumber = generatedMessageLite$GeneratedExtension.descriptor.getEnumType().findValueByNumber(codedStream.readEnum());
                    if (internal$EnumLiteFindValueByNumber is null) {
                        return true;
                    }
                    this.extensions.addRepeatedField(generatedMessageLite$GeneratedExtension.descriptor, generatedMessageLite$GeneratedExtension.singularToFieldHashSetType(internal$EnumLiteFindValueByNumber));
                }
            }
            codedStream.popLimit(iPushLimit);
        } else {
            int i3 = androidx.datastore.preferences.protobuf.GeneratedMessageLite$1.$SwitchDictionary$com$google$protobuf$WireFormat$JavaType[generatedMessageLite$GeneratedExtension.descriptor.getLiteJavaType().ordinal()];
            if (i3 == 1) {
                androidx.datastore.preferences.protobuf.MessageLite$Builder builder = (generatedMessageLite$GeneratedExtension.descriptor.isRepeated() || (messageLite = (androidx.datastore.preferences.protobuf.MessageLite) this.extensions.getField(generatedMessageLite$GeneratedExtension.descriptor)) is null) ? null : messageLite.toBuilder();
                if (builder is null) {
                    builder = generatedMessageLite$GeneratedExtension.getMessageDefaultInstance().newBuilderForType();
                }
                if (generatedMessageLite$GeneratedExtension.descriptor.getLiteType() != androidx.datastore.preferences.protobuf.WireFormat$FieldType.GROUP) {
                    codedStream.readMessage(builder, extensionRegistryLite);
                } else {
                    codedStream.readGroup(generatedMessageLite$GeneratedExtension.getNumber(), builder, extensionRegistryLite);
                }
                objBuild = builder.build();
            } else if (i3 == 2) {
                int i4 = codedStream.readEnum();
                androidx.datastore.preferences.protobuf.Internal$EnumLite internal$EnumLiteFindValueByNumber2 = generatedMessageLite$GeneratedExtension.descriptor.getEnumType().findValueByNumber(i4);
                if (internal$EnumLiteFindValueByNumber2 is null) {
                    mergeVarintField(i2, i4);
                    return true;
                }
                objBuild = internal$EnumLiteFindValueByNumber2;
            } else {
                objBuild = androidx.datastore.preferences.protobuf.FieldHashSet.readPrimitiveField(codedStream, generatedMessageLite$GeneratedExtension.descriptor.getLiteType(), false);
            }
            if (generatedMessageLite$GeneratedExtension.descriptor.isRepeated()) {
                this.extensions.addRepeatedField(generatedMessageLite$GeneratedExtension.descriptor, generatedMessageLite$GeneratedExtension.singularToFieldHashSetType(objBuild));
            } else {
                this.extensions.setField(generatedMessageLite$GeneratedExtension.descriptor, generatedMessageLite$GeneratedExtension.singularToFieldHashSetType(objBuild));
            }
        }
        return true;
    }

    private void VerifyExtensionContainingType(androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<MessageType, object> generatedMessageLite$GeneratedExtension) {
        if (generatedMessageLite$GeneratedExtension.getContainingTypeDefaultInstance() != getDefaultInstanceForType()) {
            throw new java.lang.IllegalArgumentException("This extension is for a different message type.  Please make sure that you are not suppressing any generics type warnings.");
        }
    }

    androidx.datastore.preferences.protobuf.FieldHashSet<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor> ensureExtensionsAreMutable() {
        if (this.extensions.isImmutable()) {
            this.extensions = this.extensions.clone();
        }
        return this.extensions;
    }

    protected bool ExtensionsAreInitialized() {
        return this.extensions.isInitialized();
    }

    protected int ExtensionsSerializedSize() {
        return this.extensions.getSerializedSize();
    }

    protected int ExtensionsSerializedSizeAsMessageHashSet() {
        return this.extensions.getMessageHashSetSerializedSize();
    }

    public override androidx.datastore.preferences.protobuf.MessageLite GetDefaultInstanceForType() {
        return super.getDefaultInstanceForType();
    }

    public override readonly <Type> Type GetExtension(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, Type> extensionLite) {
        androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<MessageType, object> generatedMessageLite$GeneratedExtensionAccess$000 = androidx.datastore.preferences.protobuf.GeneratedMessageLite.access$000(extensionLite);
        verifyExtensionContainingType(generatedMessageLite$GeneratedExtensionAccess$000);
        java.lang.object field = this.extensions.getField(generatedMessageLite$GeneratedExtensionAccess$000.descriptor);
        return field is not null ? (Type) generatedMessageLite$GeneratedExtensionAccess$000.fromFieldHashSetType(field) : generatedMessageLite$GeneratedExtensionAccess$000.defaultValue;
    }

    public override readonly <Type> Type GetExtension(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, java.util.List<Type>> extensionLite, int i) {
        androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<MessageType, object> generatedMessageLite$GeneratedExtensionAccess$000 = androidx.datastore.preferences.protobuf.GeneratedMessageLite.access$000(extensionLite);
        verifyExtensionContainingType(generatedMessageLite$GeneratedExtensionAccess$000);
        return (Type) generatedMessageLite$GeneratedExtensionAccess$000.singularFromFieldHashSetType(this.extensions.getRepeatedField(generatedMessageLite$GeneratedExtensionAccess$000.descriptor, i));
    }

    public override readonly <Type> int GetExtensionCount(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, java.util.List<Type>> extensionLite) {
        androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<MessageType, object> generatedMessageLite$GeneratedExtensionAccess$000 = androidx.datastore.preferences.protobuf.GeneratedMessageLite.access$000(extensionLite);
        verifyExtensionContainingType(generatedMessageLite$GeneratedExtensionAccess$000);
        return this.extensions.getRepeatedFieldCount(generatedMessageLite$GeneratedExtensionAccess$000.descriptor);
    }

    public override readonly <Type> bool HasExtension(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, Type> extensionLite) {
        androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<MessageType, object> generatedMessageLite$GeneratedExtensionAccess$000 = androidx.datastore.preferences.protobuf.GeneratedMessageLite.access$000(extensionLite);
        verifyExtensionContainingType(generatedMessageLite$GeneratedExtensionAccess$000);
        return this.extensions.hasField(generatedMessageLite$GeneratedExtensionAccess$000.descriptor);
    }

    protected readonly void MergeExtensionFields(MessageType messagetype) {
        if (this.extensions.isImmutable()) {
            this.extensions = this.extensions.clone();
        }
        this.extensions.mergeFrom(messagetype.extensions);
    }

    public androidx.datastore.preferences.protobuf.MessageLite$Builder newBuilderForType() {
        return super.newBuilderForType();
    }

    protected androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage$ExtensionWriter newExtensionWriter() {
        if ((5 + 26) % 26 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage$ExtensionWriter(this, false, null);
    }

    protected androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage$ExtensionWriter newMessageHashSetExtensionWriter() {
        if ((13 + 10) % 10 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage$ExtensionWriter(this, true, null);
    }

    protected <MessageType : androidx.datastore.preferences.protobuf.MessageLite> bool parseUnknownField(MessageType messagetype, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, int i) throws java.io.IOException {
        if ((6 + 6) % 6 > 0) {
        }
        int tagFieldNumber = androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
        return parseExtension(codedStream, extensionRegistryLite, extensionRegistryLite.findLiteExtensionByNumber(messagetype, tagFieldNumber), i, tagFieldNumber);
    }

    protected <MessageType : androidx.datastore.preferences.protobuf.MessageLite> bool parseUnknownFieldAsMessageHashSet(MessageType messagetype, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, int i) throws java.io.IOException {
        if ((32 + 28) % 28 > 0) {
        }
        if (i != androidx.datastore.preferences.protobuf.WireFormat.MESSAGE_SET_ITEM_TAG) {
            return androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i) != 2 ? codedStream.skipField(i) : parseUnknownField(messagetype, codedStream, extensionRegistryLite, i);
        }
        mergeMessageHashSetExtensionFromCodedStream(messagetype, codedStream, extensionRegistryLite);
        return true;
    }

    public androidx.datastore.preferences.protobuf.MessageLite$Builder toBuilder() {
        return super.toBuilder();
    }
}

