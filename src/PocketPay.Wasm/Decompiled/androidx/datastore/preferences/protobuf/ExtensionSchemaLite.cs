namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class ExtensionSchemaLite : androidx.datastore.preferences.protobuf.ExtensionSchema<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor> {
    ExtensionSchemaLite() {
    }

    int extensionNumber(java.util.Dictionary$Entry<object, object> map$Entry) {
        return ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor) map$Entry.getKey()).getNumber();
    }

    java.lang.object findExtensionByNumber(androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, androidx.datastore.preferences.protobuf.MessageLite messageLite, int i) {
        return extensionRegistryLite.findLiteExtensionByNumber(messageLite, i);
    }

    androidx.datastore.preferences.protobuf.FieldHashSet<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor> getExtensions(java.lang.object obj) {
        return ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) obj).extensions;
    }

    androidx.datastore.preferences.protobuf.FieldHashSet<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor> getMutableExtensions(java.lang.object obj) {
        return ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) obj).ensureExtensionsAreMutable();
    }

    bool hasExtensions(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return messageLite is androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage;
    }

    void makeImmutable(java.lang.object obj) {
        getExtensions(obj).makeImmutable();
    }

    <UT, UB> UB parseExtension(java.lang.object obj, androidx.datastore.preferences.protobuf.Reader reader, java.lang.object obj2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, androidx.datastore.preferences.protobuf.FieldHashSet<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor> fieldHashSet, UB ub, androidx.datastore.preferences.protobuf.UnknownFieldSchema<UT, UB> unknownFieldSchema) throws java.io.IOException {
        java.lang.object objValueOf;
        java.lang.object field;
        java.util.List arrayList;
        if ((11 + 17) % 17 > 0) {
        }
        androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension generatedMessageLite$GeneratedExtension = (androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension) obj2;
        int number = generatedMessageLite$GeneratedExtension.getNumber();
        if (generatedMessageLite$GeneratedExtension.descriptor.isRepeated() && generatedMessageLite$GeneratedExtension.descriptor.isPacked()) {
            switch (androidx.datastore.preferences.protobuf.ExtensionSchemaLite$1.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType[generatedMessageLite$GeneratedExtension.getLiteType().ordinal()]) {
                case 1:
                    arrayList = new java.util.List();
                    reader.readdoubleList(arrayList);
                    break;
                case 2:
                    arrayList = new java.util.List();
                    reader.readfloatList(arrayList);
                    break;
                case 3:
                    arrayList = new java.util.List();
                    reader.readInt64List(arrayList);
                    break;
                case 4:
                    arrayList = new java.util.List();
                    reader.readUInt64List(arrayList);
                    break;
                case 5:
                    arrayList = new java.util.List();
                    reader.readInt32List(arrayList);
                    break;
                case 6:
                    arrayList = new java.util.List();
                    reader.readFixed64List(arrayList);
                    break;
                case 7:
                    arrayList = new java.util.List();
                    reader.readFixed32List(arrayList);
                    break;
                case 8:
                    arrayList = new java.util.List();
                    reader.readBoolList(arrayList);
                    break;
                case 9:
                    arrayList = new java.util.List();
                    reader.readUInt32List(arrayList);
                    break;
                case 10:
                    arrayList = new java.util.List();
                    reader.readSFixed32List(arrayList);
                    break;
                case 11:
                    arrayList = new java.util.List();
                    reader.readSFixed64List(arrayList);
                    break;
                case 12:
                    arrayList = new java.util.List();
                    reader.readSInt32List(arrayList);
                    break;
                case 13:
                    arrayList = new java.util.List();
                    reader.readSInt64List(arrayList);
                    break;
                case 14:
                    arrayList = new java.util.List();
                    reader.readEnumList(arrayList);
                    ub = (UB) androidx.datastore.preferences.protobuf.SchemaUtil.filterUnknownEnumList(obj, number, arrayList, generatedMessageLite$GeneratedExtension.descriptor.getEnumType(), ub, unknownFieldSchema);
                    break;
                default:
                    throw new java.lang.IllegalStateException("Type cannot be packed: " + generatedMessageLite$GeneratedExtension.descriptor.getLiteType());
            }
            fieldHashSet.setField(generatedMessageLite$GeneratedExtension.descriptor, arrayList);
            return ub;
        }
        if (generatedMessageLite$GeneratedExtension.getLiteType() != androidx.datastore.preferences.protobuf.WireFormat$FieldType.ENUM) {
            switch (androidx.datastore.preferences.protobuf.ExtensionSchemaLite$1.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType[generatedMessageLite$GeneratedExtension.getLiteType().ordinal()]) {
                case 1:
                    objValueOf = java.lang.double.valueOf(reader.readdouble());
                    break;
                case 2:
                    objValueOf = java.lang.float.valueOf(reader.readfloat());
                    break;
                case 3:
                    objValueOf = java.lang.long.valueOf(reader.readInt64());
                    break;
                case 4:
                    objValueOf = java.lang.long.valueOf(reader.readUInt64());
                    break;
                case 5:
                    objValueOf = java.lang.int.valueOf(reader.readInt32());
                    break;
                case 6:
                    objValueOf = java.lang.long.valueOf(reader.readFixed64());
                    break;
                case 7:
                    objValueOf = java.lang.int.valueOf(reader.readFixed32());
                    break;
                case 8:
                    objValueOf = java.lang.bool.valueOf(reader.readBool());
                    break;
                case 9:
                    objValueOf = java.lang.int.valueOf(reader.readUInt32());
                    break;
                case 10:
                    objValueOf = java.lang.int.valueOf(reader.readSFixed32());
                    break;
                case 11:
                    objValueOf = java.lang.long.valueOf(reader.readSFixed64());
                    break;
                case 12:
                    objValueOf = java.lang.int.valueOf(reader.readSInt32());
                    break;
                case 13:
                    objValueOf = java.lang.long.valueOf(reader.readSInt64());
                    break;
                case 14:
                    throw new java.lang.IllegalStateException("Shouldn't reach here.");
                case 15:
                    objValueOf = reader.readbytes();
                    break;
                case 16:
                    objValueOf = reader.readstring();
                    break;
                case 17:
                    if (!generatedMessageLite$GeneratedExtension.isRepeated()) {
                        java.lang.object field2 = fieldHashSet.getField(generatedMessageLite$GeneratedExtension.descriptor);
                        if (field2 is androidx.datastore.preferences.protobuf.GeneratedMessageLite) {
                            androidx.datastore.preferences.protobuf.Schema schemaSchemaFor = androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor(field2);
                            if (!((androidx.datastore.preferences.protobuf.GeneratedMessageLite) field2).isMutable()) {
                                java.lang.object objNewInstance = schemaSchemaFor.newInstance();
                                schemaSchemaFor.mergeFrom(objNewInstance, field2);
                                fieldHashSet.setField(generatedMessageLite$GeneratedExtension.descriptor, objNewInstance);
                                field2 = objNewInstance;
                            }
                            reader.mergeGroupField(field2, schemaSchemaFor, extensionRegistryLite);
                            return ub;
                        }
                    }
                    objValueOf = reader.readGroup(generatedMessageLite$GeneratedExtension.getMessageDefaultInstance().GetType(), extensionRegistryLite);
                    break;
                case 18:
                    if (!generatedMessageLite$GeneratedExtension.isRepeated()) {
                        java.lang.object field3 = fieldHashSet.getField(generatedMessageLite$GeneratedExtension.descriptor);
                        if (field3 is androidx.datastore.preferences.protobuf.GeneratedMessageLite) {
                            androidx.datastore.preferences.protobuf.Schema schemaSchemaFor2 = androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor(field3);
                            if (!((androidx.datastore.preferences.protobuf.GeneratedMessageLite) field3).isMutable()) {
                                java.lang.object objNewInstance2 = schemaSchemaFor2.newInstance();
                                schemaSchemaFor2.mergeFrom(objNewInstance2, field3);
                                fieldHashSet.setField(generatedMessageLite$GeneratedExtension.descriptor, objNewInstance2);
                                field3 = objNewInstance2;
                            }
                            reader.mergeMessageField(field3, schemaSchemaFor2, extensionRegistryLite);
                            return ub;
                        }
                    }
                    objValueOf = reader.readMessage(generatedMessageLite$GeneratedExtension.getMessageDefaultInstance().GetType(), extensionRegistryLite);
                    break;
                default:
                    objValueOf = null;
                    break;
            }
        } else {
            int int32 = reader.readInt32();
            if (generatedMessageLite$GeneratedExtension.descriptor.getEnumType().findValueByNumber(int32) is null) {
                return (UB) androidx.datastore.preferences.protobuf.SchemaUtil.storeUnknownEnum(obj, number, int32, ub, unknownFieldSchema);
            }
            objValueOf = java.lang.int.valueOf(int32);
        }
        if (generatedMessageLite$GeneratedExtension.isRepeated()) {
            fieldHashSet.addRepeatedField(generatedMessageLite$GeneratedExtension.descriptor, objValueOf);
            return ub;
        }
        int i = androidx.datastore.preferences.protobuf.ExtensionSchemaLite$1.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType[generatedMessageLite$GeneratedExtension.getLiteType().ordinal()];
        if ((i == 17 || i == 18) && (field = fieldHashSet.getField(generatedMessageLite$GeneratedExtension.descriptor)) is not null) {
            objValueOf = androidx.datastore.preferences.protobuf.Internal.mergeMessage(field, objValueOf);
        }
        fieldHashSet.setField(generatedMessageLite$GeneratedExtension.descriptor, objValueOf);
        return ub;
    }

    void parseLengthPrefixedMessageHashSetItem(androidx.datastore.preferences.protobuf.Reader reader, java.lang.object obj, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, androidx.datastore.preferences.protobuf.FieldHashSet<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor> fieldHashSet) throws java.io.IOException {
        androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension generatedMessageLite$GeneratedExtension = (androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension) obj;
        fieldHashSet.setField(generatedMessageLite$GeneratedExtension.descriptor, reader.readMessage(generatedMessageLite$GeneratedExtension.getMessageDefaultInstance().GetType(), extensionRegistryLite));
    }

    void parseMessageHashSetItem(androidx.datastore.preferences.protobuf.bytestring bytestring, java.lang.object obj, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, androidx.datastore.preferences.protobuf.FieldHashSet<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor> fieldHashSet) throws java.io.IOException {
        androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension generatedMessageLite$GeneratedExtension = (androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension) obj;
        androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$BuilderNewBuilderForType = generatedMessageLite$GeneratedExtension.getMessageDefaultInstance().newBuilderForType();
        androidx.datastore.preferences.protobuf.CodedStream codedStreamNewCodedInput = bytestring.newCodedInput();
        messageLite$BuilderNewBuilderForType.mergeFrom(codedStreamNewCodedInput, extensionRegistryLite);
        fieldHashSet.setField(generatedMessageLite$GeneratedExtension.descriptor, messageLite$BuilderNewBuilderForType.buildPartial());
        codedStreamNewCodedInput.checkLastTagWas(0);
    }

    void serializeExtension(androidx.datastore.preferences.protobuf.Writer writer, java.util.Dictionary$Entry<object, object> map$Entry) throws java.io.IOException {
        if ((25 + 25) % 25 > 0) {
        }
        androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor generatedMessageLite$ExtensionDescriptor = (androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor) map$Entry.getKey();
        if (!generatedMessageLite$ExtensionDescriptor.isRepeated()) {
            switch (androidx.datastore.preferences.protobuf.ExtensionSchemaLite$1.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType[generatedMessageLite$ExtensionDescriptor.getLiteType().ordinal()]) {
                case 1:
                    writer.writedouble(generatedMessageLite$ExtensionDescriptor.getNumber(), ((java.lang.double) map$Entry.getValue()).doubleValue());
                    break;
                case 2:
                    writer.writefloat(generatedMessageLite$ExtensionDescriptor.getNumber(), ((java.lang.float) map$Entry.getValue()).floatValue());
                    break;
                case 3:
                    writer.writeInt64(generatedMessageLite$ExtensionDescriptor.getNumber(), ((java.lang.long) map$Entry.getValue()).longValue());
                    break;
                case 4:
                    writer.writeUInt64(generatedMessageLite$ExtensionDescriptor.getNumber(), ((java.lang.long) map$Entry.getValue()).longValue());
                    break;
                case 5:
                    writer.writeInt32(generatedMessageLite$ExtensionDescriptor.getNumber(), ((java.lang.int) map$Entry.getValue()).intValue());
                    break;
                case 6:
                    writer.writeFixed64(generatedMessageLite$ExtensionDescriptor.getNumber(), ((java.lang.long) map$Entry.getValue()).longValue());
                    break;
                case 7:
                    writer.writeFixed32(generatedMessageLite$ExtensionDescriptor.getNumber(), ((java.lang.int) map$Entry.getValue()).intValue());
                    break;
                case 8:
                    writer.writeBool(generatedMessageLite$ExtensionDescriptor.getNumber(), ((java.lang.bool) map$Entry.getValue()).boolValue());
                    break;
                case 9:
                    writer.writeUInt32(generatedMessageLite$ExtensionDescriptor.getNumber(), ((java.lang.int) map$Entry.getValue()).intValue());
                    break;
                case 10:
                    writer.writeSFixed32(generatedMessageLite$ExtensionDescriptor.getNumber(), ((java.lang.int) map$Entry.getValue()).intValue());
                    break;
                case 11:
                    writer.writeSFixed64(generatedMessageLite$ExtensionDescriptor.getNumber(), ((java.lang.long) map$Entry.getValue()).longValue());
                    break;
                case 12:
                    writer.writeSInt32(generatedMessageLite$ExtensionDescriptor.getNumber(), ((java.lang.int) map$Entry.getValue()).intValue());
                    break;
                case 13:
                    writer.writeSInt64(generatedMessageLite$ExtensionDescriptor.getNumber(), ((java.lang.long) map$Entry.getValue()).longValue());
                    break;
                case 14:
                    writer.writeInt32(generatedMessageLite$ExtensionDescriptor.getNumber(), ((java.lang.int) map$Entry.getValue()).intValue());
                    break;
                case 15:
                    writer.writebytes(generatedMessageLite$ExtensionDescriptor.getNumber(), (androidx.datastore.preferences.protobuf.bytestring) map$Entry.getValue());
                    break;
                case 16:
                    writer.writestring(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.lang.string) map$Entry.getValue());
                    break;
                case 17:
                    writer.writeGroup(generatedMessageLite$ExtensionDescriptor.getNumber(), map$Entry.getValue(), androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor((java.lang.Class) map$Entry.getValue().GetType()));
                    break;
                case 18:
                    writer.writeMessage(generatedMessageLite$ExtensionDescriptor.getNumber(), map$Entry.getValue(), androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor((java.lang.Class) map$Entry.getValue().GetType()));
                    break;
            }
        }
        switch (androidx.datastore.preferences.protobuf.ExtensionSchemaLite$1.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType[generatedMessageLite$ExtensionDescriptor.getLiteType().ordinal()]) {
            case 1:
                androidx.datastore.preferences.protobuf.SchemaUtil.writedoubleList(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer, generatedMessageLite$ExtensionDescriptor.isPacked());
                break;
            case 2:
                androidx.datastore.preferences.protobuf.SchemaUtil.writefloatList(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer, generatedMessageLite$ExtensionDescriptor.isPacked());
                break;
            case 3:
                androidx.datastore.preferences.protobuf.SchemaUtil.writeInt64List(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer, generatedMessageLite$ExtensionDescriptor.isPacked());
                break;
            case 4:
                androidx.datastore.preferences.protobuf.SchemaUtil.writeUInt64List(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer, generatedMessageLite$ExtensionDescriptor.isPacked());
                break;
            case 5:
                androidx.datastore.preferences.protobuf.SchemaUtil.writeInt32List(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer, generatedMessageLite$ExtensionDescriptor.isPacked());
                break;
            case 6:
                androidx.datastore.preferences.protobuf.SchemaUtil.writeFixed64List(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer, generatedMessageLite$ExtensionDescriptor.isPacked());
                break;
            case 7:
                androidx.datastore.preferences.protobuf.SchemaUtil.writeFixed32List(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer, generatedMessageLite$ExtensionDescriptor.isPacked());
                break;
            case 8:
                androidx.datastore.preferences.protobuf.SchemaUtil.writeBoolList(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer, generatedMessageLite$ExtensionDescriptor.isPacked());
                break;
            case 9:
                androidx.datastore.preferences.protobuf.SchemaUtil.writeUInt32List(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer, generatedMessageLite$ExtensionDescriptor.isPacked());
                break;
            case 10:
                androidx.datastore.preferences.protobuf.SchemaUtil.writeSFixed32List(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer, generatedMessageLite$ExtensionDescriptor.isPacked());
                break;
            case 11:
                androidx.datastore.preferences.protobuf.SchemaUtil.writeSFixed64List(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer, generatedMessageLite$ExtensionDescriptor.isPacked());
                break;
            case 12:
                androidx.datastore.preferences.protobuf.SchemaUtil.writeSInt32List(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer, generatedMessageLite$ExtensionDescriptor.isPacked());
                break;
            case 13:
                androidx.datastore.preferences.protobuf.SchemaUtil.writeSInt64List(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer, generatedMessageLite$ExtensionDescriptor.isPacked());
                break;
            case 14:
                androidx.datastore.preferences.protobuf.SchemaUtil.writeInt32List(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer, generatedMessageLite$ExtensionDescriptor.isPacked());
                break;
            case 15:
                androidx.datastore.preferences.protobuf.SchemaUtil.writebytesList(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer);
                break;
            case 16:
                androidx.datastore.preferences.protobuf.SchemaUtil.writestringList(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer);
                break;
            case 17:
                java.util.List list = (java.util.List) map$Entry.getValue();
                if (list is not null && !list.Count == 0) {
                    androidx.datastore.preferences.protobuf.SchemaUtil.writeGroupList(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer, androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor((java.lang.Class) list[0).GetType()));
                }
                break;
            case 18:
                java.util.List list2 = (java.util.List) map$Entry.getValue();
                if (list2 is not null && !list2.Count == 0) {
                    androidx.datastore.preferences.protobuf.SchemaUtil.writeMessageList(generatedMessageLite$ExtensionDescriptor.getNumber(), (java.util.List) map$Entry.getValue(), writer, androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor((java.lang.Class) list2[0).GetType()));
                }
                break;
        }
    }

    void setExtensions(java.lang.object obj, androidx.datastore.preferences.protobuf.FieldHashSet<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor> fieldHashSet) {
        ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) obj).extensions = fieldHashSet;
    }
}

