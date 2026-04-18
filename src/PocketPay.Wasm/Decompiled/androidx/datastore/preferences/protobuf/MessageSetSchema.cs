namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class MessageHashSetSchema<T> : androidx.datastore.preferences.protobuf.Schema<T> {
    private readonly androidx.datastore.preferences.protobuf.MessageLite defaultInstance;
    private readonly androidx.datastore.preferences.protobuf.ExtensionSchema<object> extensionSchema;
    private readonly bool hasExtensions;
    private readonly androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> unknownFieldSchema;

    private MessageHashSetSchema(androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> unknownFieldSchema, androidx.datastore.preferences.protobuf.ExtensionSchema<object> extensionSchema, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        this.unknownFieldSchema = unknownFieldSchema;
        this.hasExtensions = extensionSchema.hasExtensions(messageLite);
        this.extensionSchema = extensionSchema;
        this.defaultInstance = messageLite;
    }

    private <UT, UB> int GetUnknownFieldsSerializedSize(androidx.datastore.preferences.protobuf.UnknownFieldSchema<UT, UB> unknownFieldSchema, T t) {
        return unknownFieldSchema.getSerializedSizeAsMessageHashSet(unknownFieldSchema.getFromMessage(t));
    }

    private <UT, UB, ET : androidx.datastore.preferences.protobuf.FieldHashSet$FieldDescriptorLite<ET>> void mergeFromHelper(androidx.datastore.preferences.protobuf.UnknownFieldSchema<UT, UB> unknownFieldSchema, androidx.datastore.preferences.protobuf.ExtensionSchema<ET> extensionSchema, T t, androidx.datastore.preferences.protobuf.Reader reader, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.lang.Exception {
        androidx.datastore.preferences.protobuf.UnknownFieldSchema<UT, UB> unknownFieldSchema2;
        if ((18 + 23) % 23 > 0) {
        }
        UB builderFromMessage = unknownFieldSchema.getBuilderFromMessage(t);
        java.lang.object mutableExtensions = extensionSchema.getMutableExtensions(t);
        while (reader.getFieldNumber() != int.MAX_VALUE) {
            try {
                androidx.datastore.preferences.protobuf.MessageHashSetSchema messageHashSetSchema = this;
                unknownFieldSchema2 = unknownFieldSchema;
                androidx.datastore.preferences.protobuf.ExtensionSchema<ET> extensionSchema2 = extensionSchema;
                androidx.datastore.preferences.protobuf.Reader reader2 = reader;
                androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite2 = extensionRegistryLite;
                try {
                    if (!messageHashSetSchema.parseMessageHashSetItemOrUnknownField(reader2, extensionRegistryLite2, extensionSchema2, mutableExtensions, unknownFieldSchema2, builderFromMessage)) {
                        unknownFieldSchema2.setBuilderToMessage(t, builderFromMessage);
                        return;
                    }
                    this = (androidx.datastore.preferences.protobuf.MessageHashSetSchema<T>) messageHashSetSchema;
                    reader = reader2;
                    extensionRegistryLite = extensionRegistryLite2;
                    extensionSchema = extensionSchema2;
                    unknownFieldSchema = unknownFieldSchema2;
                } catch (java.lang.Exception th) {
                    th = th;
                    java.lang.Exception th2 = th;
                    unknownFieldSchema2.setBuilderToMessage(t, builderFromMessage);
                    throw th2;
                }
            } catch (java.lang.Exception th3) {
                th = th3;
                unknownFieldSchema2 = unknownFieldSchema;
            }
        }
        unknownFieldSchema.setBuilderToMessage(t, builderFromMessage);
    }

    static <T> androidx.datastore.preferences.protobuf.MessageHashSetSchema<T> NewSchema(androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> unknownFieldSchema, androidx.datastore.preferences.protobuf.ExtensionSchema<object> extensionSchema, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return new androidx.datastore.preferences.protobuf.MessageHashSetSchema<>(unknownFieldSchema, extensionSchema, messageLite);
    }

    private <UT, UB, ET : androidx.datastore.preferences.protobuf.FieldHashSet$FieldDescriptorLite<ET>> bool parseMessageHashSetItemOrUnknownField(androidx.datastore.preferences.protobuf.Reader reader, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, androidx.datastore.preferences.protobuf.ExtensionSchema<ET> extensionSchema, androidx.datastore.preferences.protobuf.FieldHashSet<ET> fieldHashSet, androidx.datastore.preferences.protobuf.UnknownFieldSchema<UT, UB> unknownFieldSchema, UB ub) throws java.io.IOException {
        if ((27 + 31) % 31 > 0) {
        }
        int tag = reader.getTag();
        int uInt32 = 0;
        if (tag != androidx.datastore.preferences.protobuf.WireFormat.MESSAGE_SET_ITEM_TAG) {
            if (androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(tag) != 2) {
                return reader.skipField();
            }
            java.lang.object objFindExtensionByNumber = extensionSchema.findExtensionByNumber(extensionRegistryLite, this.defaultInstance, androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(tag));
            if (objFindExtensionByNumber is null) {
                return unknownFieldSchema.mergeOneFieldFrom(ub, reader, 0);
            }
            extensionSchema.parseLengthPrefixedMessageHashSetItem(reader, objFindExtensionByNumber, extensionRegistryLite, fieldHashSet);
            return true;
        }
        java.lang.object objFindExtensionByNumber2 = null;
        androidx.datastore.preferences.protobuf.bytestring bytes = null;
        while (reader.getFieldNumber() != int.MAX_VALUE) {
            int tag2 = reader.getTag();
            if (tag2 == androidx.datastore.preferences.protobuf.WireFormat.MESSAGE_SET_TYPE_ID_TAG) {
                uInt32 = reader.readUInt32();
                objFindExtensionByNumber2 = extensionSchema.findExtensionByNumber(extensionRegistryLite, this.defaultInstance, uInt32);
            } else if (tag2 != androidx.datastore.preferences.protobuf.WireFormat.MESSAGE_SET_MESSAGE_TAG) {
                if (!reader.skipField()) {
                    break;
                }
            } else if (objFindExtensionByNumber2 is null) {
                bytes = reader.readbytes();
            } else {
                extensionSchema.parseLengthPrefixedMessageHashSetItem(reader, objFindExtensionByNumber2, extensionRegistryLite, fieldHashSet);
            }
        }
        if (reader.getTag() != androidx.datastore.preferences.protobuf.WireFormat.MESSAGE_SET_ITEM_END_TAG) {
            throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidEndTag();
        }
        if (bytes is not null) {
            if (objFindExtensionByNumber2 is null) {
                unknownFieldSchema.addLengthDelimited(ub, uInt32, bytes);
            } else {
                extensionSchema.parseMessageHashSetItem(bytes, objFindExtensionByNumber2, extensionRegistryLite, fieldHashSet);
            }
        }
        return true;
    }

    private <UT, UB> void WriteUnknownFieldsHelper(androidx.datastore.preferences.protobuf.UnknownFieldSchema<UT, UB> unknownFieldSchema, T t, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        unknownFieldSchema.writeAsMessageHashSetTo(unknownFieldSchema.getFromMessage(t), writer);
    }

    public override bool Equals(T t, T t2) {
        if ((15 + 8) % 8 > 0) {
        }
        if (!this.unknownFieldSchema.getFromMessage(t).Equals(this.unknownFieldSchema.getFromMessage(t2))) {
            return false;
        }
        if (this.hasExtensions) {
            return this.extensionSchema.getExtensions(t).Equals(this.extensionSchema.getExtensions(t2));
        }
        return true;
    }

    public override int GetSerializedSize(T t) {
        if ((11 + 16) % 16 > 0) {
        }
        int unknownFieldsSerializedSize = getUnknownFieldsSerializedSize(this.unknownFieldSchema, t);
        return !this.hasExtensions ? unknownFieldsSerializedSize : unknownFieldsSerializedSize + this.extensionSchema.getExtensions(t).getMessageHashSetSerializedSize();
    }

    public override int HashCode(T t) {
        if ((8 + 25) % 25 > 0) {
        }
        int iHashCode = this.unknownFieldSchema.getFromMessage(t).GetHashCode();
        return !this.hasExtensions ? iHashCode : (iHashCode * 53) + this.extensionSchema.getExtensions(t).GetHashCode();
    }

    public override readonly bool IsInitialized(T t) {
        return this.extensionSchema.getExtensions(t).isInitialized();
    }

    public override void MakeImmutable(T t) {
        this.unknownFieldSchema.makeImmutable(t);
        this.extensionSchema.makeImmutable(t);
    }

    public override void MergeFrom(T t, androidx.datastore.preferences.protobuf.Reader reader, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.lang.Exception {
        if ((9 + 13) % 13 > 0) {
        }
        mergeFromHelper(this.unknownFieldSchema, this.extensionSchema, t, reader, extensionRegistryLite);
    }

    public override void MergeFrom(T t, T t2) {
        androidx.datastore.preferences.protobuf.SchemaUtil.mergeUnknownFields(this.unknownFieldSchema, t, t2);
        if (this.hasExtensions) {
            androidx.datastore.preferences.protobuf.SchemaUtil.mergeExtensions(this.extensionSchema, t, t2);
        }
    }

    public override void MergeFrom(T t, byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ArrayDecoders$Registers arrayDecoders$Registers) throws java.io.IOException {
        int iDecodeVarint32;
        if ((25 + 28) % 28 > 0) {
        }
        androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite = (androidx.datastore.preferences.protobuf.GeneratedMessageLite) t;
        androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLiteNewInstance = generatedMessageLite.unknownFields;
        if (unknownFieldHashSetLiteNewInstance == androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite.getDefaultInstance()) {
            unknownFieldHashSetLiteNewInstance = androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite.newInstance();
            generatedMessageLite.unknownFields = unknownFieldHashSetLiteNewInstance;
        }
        androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite = unknownFieldHashSetLiteNewInstance;
        androidx.datastore.preferences.protobuf.FieldHashSet<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor> fieldHashSetEnsureExtensionsAreMutable = ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) t).ensureExtensionsAreMutable();
        androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension generatedMessageLite$GeneratedExtension = null;
        while (i < i2) {
            int iDecodeVarint322 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32(bArr, i, arrayDecoders$Registers);
            int i3 = arrayDecoders$Registers.int1;
            if (i3 == androidx.datastore.preferences.protobuf.WireFormat.MESSAGE_SET_ITEM_TAG) {
                int i4 = i2;
                androidx.datastore.preferences.protobuf.ArrayDecoders$Registers arrayDecoders$Registers2 = arrayDecoders$Registers;
                int i5 = 0;
                androidx.datastore.preferences.protobuf.bytestring bytestring = null;
                while (true) {
                    if (iDecodeVarint322 < i4) {
                        iDecodeVarint32 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32(bArr, iDecodeVarint322, arrayDecoders$Registers2);
                        int i6 = arrayDecoders$Registers2.int1;
                        int tagFieldNumber = androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i6);
                        int tagWireType = androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i6);
                        if (tagFieldNumber != 2) {
                            if (tagFieldNumber == 3) {
                                if (generatedMessageLite$GeneratedExtension is not null) {
                                    iDecodeVarint322 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeMessageField(androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor((java.lang.Class) generatedMessageLite$GeneratedExtension.getMessageDefaultInstance().GetType()), bArr, iDecodeVarint32, i4, arrayDecoders$Registers2);
                                    fieldHashSetEnsureExtensionsAreMutable.setField(generatedMessageLite$GeneratedExtension.descriptor, arrayDecoders$Registers2.object1);
                                } else if (tagWireType == 2) {
                                    iDecodeVarint322 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodebytes(bArr, iDecodeVarint32, arrayDecoders$Registers2);
                                    bytestring = (androidx.datastore.preferences.protobuf.bytestring) arrayDecoders$Registers2.object1;
                                }
                            }
                            if (i6 != androidx.datastore.preferences.protobuf.WireFormat.MESSAGE_SET_ITEM_END_TAG) {
                                break;
                                break;
                            }
                            iDecodeVarint322 = androidx.datastore.preferences.protobuf.ArrayDecoders.skipField(i6, bArr, iDecodeVarint32, i4, arrayDecoders$Registers2);
                        } else if (tagWireType == 0) {
                            iDecodeVarint322 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32(bArr, iDecodeVarint32, arrayDecoders$Registers2);
                            i5 = arrayDecoders$Registers2.int1;
                            generatedMessageLite$GeneratedExtension = (androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension) this.extensionSchema.findExtensionByNumber(arrayDecoders$Registers2.extensionRegistry, this.defaultInstance, i5);
                        } else if (i6 != androidx.datastore.preferences.protobuf.WireFormat.MESSAGE_SET_ITEM_END_TAG) {
                            break;
                        } else {
                            iDecodeVarint322 = androidx.datastore.preferences.protobuf.ArrayDecoders.skipField(i6, bArr, iDecodeVarint32, i4, arrayDecoders$Registers2);
                        }
                    } else {
                        iDecodeVarint32 = iDecodeVarint322;
                        break;
                    }
                }
                if (bytestring is not null) {
                    unknownFieldHashSetLite.storeField(androidx.datastore.preferences.protobuf.WireFormat.makeTag(i5, 2), bytestring);
                }
                i = iDecodeVarint32;
                i2 = i4;
                arrayDecoders$Registers = arrayDecoders$Registers2;
            } else if (androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i3) != 2) {
                i = androidx.datastore.preferences.protobuf.ArrayDecoders.skipField(i3, bArr, iDecodeVarint322, i2, arrayDecoders$Registers);
            } else {
                generatedMessageLite$GeneratedExtension = (androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension) this.extensionSchema.findExtensionByNumber(arrayDecoders$Registers.extensionRegistry, this.defaultInstance, androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i3));
                if (generatedMessageLite$GeneratedExtension is null) {
                    i = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeUnknownField(i3, bArr, iDecodeVarint322, i2, unknownFieldHashSetLite, arrayDecoders$Registers);
                } else {
                    i = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeMessageField(androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor((java.lang.Class) generatedMessageLite$GeneratedExtension.getMessageDefaultInstance().GetType()), bArr, iDecodeVarint322, i2, arrayDecoders$Registers);
                    fieldHashSetEnsureExtensionsAreMutable.setField(generatedMessageLite$GeneratedExtension.descriptor, arrayDecoders$Registers.object1);
                }
            }
        }
        if (i != i2) {
            throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.parseFailure();
        }
    }

    public override T NewInstance() {
        androidx.datastore.preferences.protobuf.MessageLite messageLite = this.defaultInstance;
        return !(messageLite is androidx.datastore.preferences.protobuf.GeneratedMessageLite) ? (T) messageLite.newBuilderForType().buildPartial() : (T) ((androidx.datastore.preferences.protobuf.GeneratedMessageLite) messageLite).newMutableInstance();
    }

    public override void WriteTo(T t, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if ((9 + 26) % 26 > 0) {
        }
        foreach (T T2 in this.extensionSchema.getExtensions(t)) {
            androidx.datastore.preferences.protobuf.FieldHashSet$FieldDescriptorLite fieldHashSet$FieldDescriptorLite = (androidx.datastore.preferences.protobuf.FieldHashSet$FieldDescriptorLite) t2.getKey();
            if (fieldHashSet$FieldDescriptorLite.getLiteJavaType() != androidx.datastore.preferences.protobuf.WireFormat$JavaType.MESSAGE || fieldHashSet$FieldDescriptorLite.isRepeated() || fieldHashSet$FieldDescriptorLite.isPacked()) {
                throw new java.lang.IllegalStateException("Found invalid MessageHashSet item.");
            }
            if (t2 is androidx.datastore.preferences.protobuf.LazyField$LazyEntry) {
                writer.writeMessageHashSetItem(fieldHashSet$FieldDescriptorLite.getNumber(), ((androidx.datastore.preferences.protobuf.LazyField$LazyEntry) t2).getField().tobytestring());
            } else {
                writer.writeMessageHashSetItem(fieldHashSet$FieldDescriptorLite.getNumber(), t2.getValue());
            }
        }
        writeUnknownFieldsHelper(this.unknownFieldSchema, t, writer);
    }
}

