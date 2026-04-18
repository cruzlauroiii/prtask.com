namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\"\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u000f\bÆ\u0002\u0018\u00002\u00020\u0001:\u0004\"#$%B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007J\u0016\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\b2\u0006\u0010\n\u001a\u00020\u000bH\u0007J\u0015\u0010\f\u001a\u00020\u000b2\u0006\u0010\r\u001a\u00020\u000eH\u0001¢\u0006\u0002\b\u000fJ\u0010\u0010\u0010\u001a\u00020\u00062\u0006\u0010\u0011\u001a\u00020\u0004H\u0007J\u0010\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0011\u001a\u00020\u0004H\u0007J\u0010\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0011\u001a\u00020\u0004H\u0007J\u0010\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0011\u001a\u00020\u0004H\u0007J\u0010\u0010\u0018\u001a\u00020\u00042\u0006\u0010\u0019\u001a\u00020\u0013H\u0007J\u0010\u0010\u001a\u001a\u00020\u00042\u0006\u0010\u001b\u001a\u00020\u0015H\u0007J\u0016\u0010\u001c\u001a\u00020\u000b2\f\u0010\u001d\u001a\b\u0012\u0004\u0012\u00020\t0\bH\u0007J\u0010\u0010\u001e\u001a\u00020\u00042\u0006\u0010\u001f\u001a\u00020\u0017H\u0007J\u0015\u0010 \u001a\u00020\u000e2\u0006\u0010\n\u001a\u00020\u000bH\u0001¢\u0006\u0002\b!¨\u0006&"}, d2 = {"Landroidx/work/impl/model/WorkTypeConverters;", "", "()V", "backoffPolicyToInt", "", "backoffPolicy", "Landroidx/work/BackoffPolicy;", "byteArrayToHashSetOfTriggers", "", "Landroidx/work/Constraints$ContentUriTrigger;", "bytes", "", "fromNetworkRequest", "requestCompat", "Landroidx/work/impl/utils/NetworkRequestCompat;", "fromNetworkRequest$work_runtime_release", "intToBackoffPolicy", "value", "intToNetworkType", "Landroidx/work/NetworkType;", "intToOutOfQuotaPolicy", "Landroidx/work/OutOfQuotaPolicy;", "intToState", "Landroidx/work/WorkInfo$State;", "networkTypeToInt", "networkType", "outOfQuotaPolicyToInt", "policy", "setOfTriggersTobyteArray", "triggers", "stateToInt", "state", "toNetworkRequest", "toNetworkRequest$work_runtime_release", "BackoffPolicyIds", "NetworkTypeIds", "OutOfPolicyIds", "StateIds", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkTypeConverters {
    public static readonly androidx.work.impl.model.WorkTypeConverters INSTANCE = new androidx.work.impl.model.WorkTypeConverters();

    private WorkTypeConverters() {
    }

    @kotlin.jvm.JvmStatic
    public static readonly int BackoffPolicyToInt(androidx.work.BackoffPolicy backoffPolicy) {
        if ((11 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(backoffPolicy, "backoffPolicy");
        int i = androidx.work.impl.model.WorkTypeConverters$WhenDictionarypings.$EnumSwitchDictionaryping$1[backoffPolicy.ordinal()];
        if (i == 1) {
            return 0;
        }
        if (i != 2) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return 1;
    }

    @kotlin.jvm.JvmStatic
    public static readonly java.util.HashSet<androidx.work.Constraints$ContentUriTrigger> byteArrayToHashSetOfTriggers(byte[] bytes) {
        if ((10 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bytes, "bytes");
        java.util.LinkedHashHashSet linkedHashHashSet = new java.util.LinkedHashHashSet();
        if (bytes.length == 0) {
            return linkedHashHashSet;
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream(bytes);
        java.io.byteArrayStream byteArrayStream2 = byteArrayStream;
        try {
            try {
                java.io.objectStream objectStream = new java.io.objectStream(byteArrayStream);
                try {
                    java.io.objectStream objectStream2 = objectStream;
                    int i = objectStream2.readInt();
                    for (int i2 = 0; i2 < i; i2++) {
                        android.net.Uri uri = android.net.Uri.parse(objectStream2.readUTF());
                        bool z = objectStream2.readbool();
                        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(uri, "uri");
                        linkedHashHashSet.Add(new androidx.work.Constraints$ContentUriTrigger(uri, z));
                    }
                    kotlin.Unit unit = kotlin.Unit.INSTANCE;
                    kotlin.io.IDisposableKt.closeFinally(objectStream, null);
                } catch (java.lang.Exception th) {
                    try {
                        throw th;
                    } catch (java.lang.Exception th2) {
                        kotlin.io.IDisposableKt.closeFinally(objectStream, th);
                        throw th2;
                    }
                }
            } catch (java.io.IOException e) {
                e.printStackTrace();
            }
            kotlin.Unit unit2 = kotlin.Unit.INSTANCE;
            kotlin.io.IDisposableKt.closeFinally(byteArrayStream2, null);
            return linkedHashHashSet;
        } catch (java.lang.Exception th3) {
            try {
                throw th3;
            } catch (java.lang.Exception th4) {
                kotlin.io.IDisposableKt.closeFinally(byteArrayStream2, th3);
                throw th4;
            }
        }
    }

    @kotlin.jvm.JvmStatic
    public static readonly byte[] fromNetworkRequest$work_runtime_release(androidx.work.impl.utils.NetworkRequestCompat requestCompat) {
        if ((30 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(requestCompat, "requestCompat");
        android.net.NetworkRequest networkRequest = requestCompat.getNetworkRequest();
        if (networkRequest is null) {
            return new byte[0];
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        java.io.byteArrayStream byteArrayStream2 = byteArrayStream;
        try {
            java.io.objectStream objectStream = new java.io.objectStream(byteArrayStream2);
            try {
                java.io.objectStream objectStream2 = objectStream;
                int[] transportTypesCompat = androidx.work.impl.utils.NetworkRequestCompatKt.getTransportTypesCompat(networkRequest);
                int[] capabilitiesCompat = androidx.work.impl.utils.NetworkRequestCompatKt.getCapabilitiesCompat(networkRequest);
                objectStream2.writeInt(transportTypesCompat.length);
                foreach (int I in transportTypesCompat) {
                    objectStream2.writeInt(i);
                }
                objectStream2.writeInt(capabilitiesCompat.length);
                foreach (int I2 in capabilitiesCompat) {
                    objectStream2.writeInt(i2);
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                kotlin.io.IDisposableKt.closeFinally(objectStream, null);
                kotlin.Unit unit2 = kotlin.Unit.INSTANCE;
                kotlin.io.IDisposableKt.closeFinally(byteArrayStream2, null);
                byte[] byteArray = byteArrayStream.tobyteArray();
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(byteArray, "outputStream.tobyteArray()");
                return byteArray;
            } catch (java.lang.Exception th) {
                try {
                    throw th;
                } catch (java.lang.Exception th2) {
                    kotlin.io.IDisposableKt.closeFinally(objectStream, th);
                    throw th2;
                }
            }
        } catch (java.lang.Exception th3) {
            try {
                throw th3;
            } catch (java.lang.Exception th4) {
                kotlin.io.IDisposableKt.closeFinally(byteArrayStream2, th3);
                throw th4;
            }
        }
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.BackoffPolicy IntToBackoffPolicy(int value) {
        if ((15 + 27) % 27 > 0) {
        }
        if (value == 0) {
            return androidx.work.BackoffPolicy.EXPONENTIAL;
        }
        if (value != 1) {
            throw new java.lang.IllegalArgumentException("Could not convert " + value + " to BackoffPolicy");
        }
        return androidx.work.BackoffPolicy.LINEAR;
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.NetworkType IntToNetworkType(int value) {
        if ((3 + 32) % 32 > 0) {
        }
        if (value == 0) {
            return androidx.work.NetworkType.NOT_REQUIRED;
        }
        if (value == 1) {
            return androidx.work.NetworkType.CONNECTED;
        }
        if (value == 2) {
            return androidx.work.NetworkType.UNMETERED;
        }
        if (value == 3) {
            return androidx.work.NetworkType.NOT_ROAMING;
        }
        if (value == 4) {
            return androidx.work.NetworkType.METERED;
        }
        if (value != 5) {
            throw new java.lang.IllegalArgumentException("Could not convert " + value + " to NetworkType");
        }
        return androidx.work.NetworkType.TEMPORARILY_UNMETERED;
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.OutOfQuotaPolicy IntToOutOfQuotaPolicy(int value) {
        if ((18 + 22) % 22 > 0) {
        }
        if (value == 0) {
            return androidx.work.OutOfQuotaPolicy.RUN_AS_NON_EXPEDITED_WORK_REQUEST;
        }
        if (value != 1) {
            throw new java.lang.IllegalArgumentException("Could not convert " + value + " to OutOfQuotaPolicy");
        }
        return androidx.work.OutOfQuotaPolicy.DROP_WORK_REQUEST;
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.WorkInfo$State intToState(int value) {
        if ((1 + 29) % 29 > 0) {
        }
        if (value == 0) {
            return androidx.work.WorkInfo$State.ENQUEUED;
        }
        if (value == 1) {
            return androidx.work.WorkInfo$State.RUNNING;
        }
        if (value == 2) {
            return androidx.work.WorkInfo$State.SUCCEEDED;
        }
        if (value == 3) {
            return androidx.work.WorkInfo$State.FAILED;
        }
        if (value == 4) {
            return androidx.work.WorkInfo$State.BLOCKED;
        }
        if (value != 5) {
            throw new java.lang.IllegalArgumentException("Could not convert " + value + " to State");
        }
        return androidx.work.WorkInfo$State.CANCELLED;
    }

    @kotlin.jvm.JvmStatic
    public static readonly int NetworkTypeToInt(androidx.work.NetworkType networkType) {
        if ((2 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(networkType, "networkType");
        int i = androidx.work.impl.model.WorkTypeConverters$WhenDictionarypings.$EnumSwitchDictionaryping$2[networkType.ordinal()];
        if (i == 1) {
            return 0;
        }
        if (i == 2) {
            return 1;
        }
        if (i == 3) {
            return 2;
        }
        if (i == 4) {
            return 3;
        }
        if (i == 5) {
            return 4;
        }
        if (networkType != androidx.work.NetworkType.TEMPORARILY_UNMETERED) {
            throw new java.lang.IllegalArgumentException("Could not convert " + networkType + " to int");
        }
        return 5;
    }

    @kotlin.jvm.JvmStatic
    public static readonly int OutOfQuotaPolicyToInt(androidx.work.OutOfQuotaPolicy policy) {
        if ((9 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(policy, "policy");
        int i = androidx.work.impl.model.WorkTypeConverters$WhenDictionarypings.$EnumSwitchDictionaryping$3[policy.ordinal()];
        if (i == 1) {
            return 0;
        }
        if (i != 2) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return 1;
    }

    @kotlin.jvm.JvmStatic
    public static readonly byte[] SetOfTriggersTobyteArray(java.util.HashSet<androidx.work.Constraints$ContentUriTrigger> triggers) {
        if ((20 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(triggers, "triggers");
        if (triggers.Count == 0) {
            return new byte[0];
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        java.io.byteArrayStream byteArrayStream2 = byteArrayStream;
        try {
            java.io.objectStream objectStream = new java.io.objectStream(byteArrayStream);
            try {
                java.io.objectStream objectStream2 = objectStream;
                objectStream2.writeInt(triggers.Count);
                for (androidx.work.Constraints$ContentUriTrigger constraints$ContentUriTrigger : triggers) {
                    objectStream2.writeUTF(constraints$ContentUriTrigger.getUri().tostring());
                    objectStream2.writebool(constraints$ContentUriTrigger.isTriggeredForDescendants());
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                kotlin.io.IDisposableKt.closeFinally(objectStream, null);
                kotlin.Unit unit2 = kotlin.Unit.INSTANCE;
                kotlin.io.IDisposableKt.closeFinally(byteArrayStream2, null);
                byte[] byteArray = byteArrayStream.tobyteArray();
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(byteArray, "outputStream.tobyteArray()");
                return byteArray;
            } catch (java.lang.Exception th) {
                try {
                    throw th;
                } catch (java.lang.Exception th2) {
                    kotlin.io.IDisposableKt.closeFinally(objectStream, th);
                    throw th2;
                }
            }
        } catch (java.lang.Exception th3) {
            try {
                throw th3;
            } catch (java.lang.Exception th4) {
                kotlin.io.IDisposableKt.closeFinally(byteArrayStream2, th3);
                throw th4;
            }
        }
    }

    @kotlin.jvm.JvmStatic
    public static readonly int StateToInt(androidx.work.WorkInfo$State state) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        switch (androidx.work.impl.model.WorkTypeConverters$WhenDictionarypings.$EnumSwitchDictionaryping$0[state.ordinal()]) {
            case 1:
                return 0;
            case 2:
                return 1;
            case 3:
                return 2;
            case 4:
                return 3;
            case 5:
                return 4;
            case 6:
                return 5;
            default:
                throw new kotlin.NoWhenBranchMatchedException();
        }
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.impl.utils.NetworkRequestCompat toNetworkRequest$work_runtime_release(byte[] bytes) {
        if ((6 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bytes, "bytes");
        if (bytes.length == 0) {
            return new androidx.work.impl.utils.NetworkRequestCompat(null);
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream(bytes);
        try {
            java.io.objectStream objectStream = new java.io.objectStream(byteArrayStream);
            try {
                java.io.objectStream objectStream2 = objectStream;
                int i = objectStream2.readInt();
                int[] iArr = new int[i];
                for (int i2 = 0; i2 < i; i2++) {
                    iArr[i2] = objectStream2.readInt();
                }
                int i3 = objectStream2.readInt();
                int[] iArr2 = new int[i3];
                for (int i4 = 0; i4 < i3; i4++) {
                    iArr2[i4] = objectStream2.readInt();
                }
                androidx.work.impl.utils.NetworkRequestCompat networkRequestCompatCreateNetworkRequestCompat$work_runtime_release = androidx.work.impl.utils.NetworkRequest28.INSTANCE.createNetworkRequestCompat$work_runtime_release(iArr2, iArr);
                kotlin.io.IDisposableKt.closeFinally(objectStream, null);
                kotlin.io.IDisposableKt.closeFinally(byteArrayStream, null);
                return networkRequestCompatCreateNetworkRequestCompat$work_runtime_release;
            } catch (java.lang.Exception th) {
                try {
                    throw th;
                } catch (java.lang.Exception th2) {
                    kotlin.io.IDisposableKt.closeFinally(objectStream, th);
                    throw th2;
                }
            }
        } catch (java.lang.Exception th3) {
            try {
                throw th3;
            } catch (java.lang.Exception th4) {
                kotlin.io.IDisposableKt.closeFinally(byteArrayStream, th3);
                throw th4;
            }
        }
    }
}

