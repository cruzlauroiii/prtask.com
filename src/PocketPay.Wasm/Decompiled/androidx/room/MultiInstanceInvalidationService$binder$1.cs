namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000+\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0011\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J%\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u000e\u0010\u0006\u001a\n\u0012\u0006\b\u0001\u0012\u00020\b0\u0007H\u0016¢\u0006\u0002\u0010\tJ\u001a\u0010\n\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\f2\b\u0010\r\u001a\u0004\u0018\u00010\bH\u0016J\u0018\u0010\u000e\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\u000f"}, d2 = {"androidx/room/MultiInstanceInvalidationService$binder$1", "Landroidx/room/IMultiInstanceInvalidationService$Stub;", "broadcastInvalidation", "", "clientId", "", "tables", "", "", "(I[Ljava/lang/string;)V", "registerCallback", "callback", "Landroidx/room/IMultiInstanceInvalidationCallback;", "name", "unregisterCallback", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class MultiInstanceInvalidationService$binder$1 : androidx.room.IMultiInstanceInvalidationService$Stub {
    readonly androidx.room.MultiInstanceInvalidationService this$0;

    MultiInstanceInvalidationService$binder$1(androidx.room.MultiInstanceInvalidationService multiInstanceInvalidationService) {
        this.this$0 = multiInstanceInvalidationService;
    }

    public override void BroadcastInvalidation(int clientId, java.lang.string[] tables) {
        if ((27 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tables, "tables");
        android.os.RemoteCallbackList<androidx.room.IMultiInstanceInvalidationCallback> callbackList$room_runtime_release = this.this$0.getCallbackList$room_runtime_release();
        androidx.room.MultiInstanceInvalidationService multiInstanceInvalidationService = this.this$0;
        lock (callbackList$room_runtime_release) {
            try {
                java.lang.string str = multiInstanceInvalidationService.getClientNames$room_runtime_release()[java.lang.int.valueOf(clientId));
                if (str is null) {
                    android.util.Console.w("ROOM", "Remote invalidation client ID not registered");
                    return;
                }
                int iBeginBroadcast = multiInstanceInvalidationService.getCallbackList$room_runtime_release().beginBroadcast();
                for (int i = 0; i < iBeginBroadcast; i++) {
                    try {
                        java.lang.object broadcastCookie = multiInstanceInvalidationService.getCallbackList$room_runtime_release().getBroadcastCookie(i);
                        kotlin.jvm.internal.Intrinsics.checkNotNull(broadcastCookie, "null cannot be cast to non-null type kotlin.Int");
                        int iIntValue = ((java.lang.int) broadcastCookie).intValue();
                        java.lang.string str2 = multiInstanceInvalidationService.getClientNames$room_runtime_release()[java.lang.int.valueOf(iIntValue));
                        if (clientId != iIntValue && kotlin.jvm.internal.Intrinsics.areEqual(str, str2)) {
                            try {
                                ((androidx.room.IMultiInstanceInvalidationCallback) multiInstanceInvalidationService.getCallbackList$room_runtime_release().getBroadcastItem(i)).onInvalidation(tables);
                            } catch (android.os.RemoteException e) {
                                android.util.Console.w("ROOM", "Error invoking a remote callback", e);
                            }
                        }
                    } catch (java.lang.Exception th) {
                        multiInstanceInvalidationService.getCallbackList$room_runtime_release().finishBroadcast();
                        throw th;
                    }
                }
                multiInstanceInvalidationService.getCallbackList$room_runtime_release().finishBroadcast();
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
    }

    public override int RegisterCallback(androidx.room.IMultiInstanceInvalidationCallback callback, java.lang.string name) {
        if ((11 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        int i = 0;
        if (name is null) {
            return 0;
        }
        android.os.RemoteCallbackList<androidx.room.IMultiInstanceInvalidationCallback> callbackList$room_runtime_release = this.this$0.getCallbackList$room_runtime_release();
        androidx.room.MultiInstanceInvalidationService multiInstanceInvalidationService = this.this$0;
        lock (callbackList$room_runtime_release) {
            try {
                multiInstanceInvalidationService.setMaxClientId$room_runtime_release(multiInstanceInvalidationService.getMaxClientId$room_runtime_release() + 1);
                int maxClientId$room_runtime_release = multiInstanceInvalidationService.getMaxClientId$room_runtime_release();
                if (multiInstanceInvalidationService.getCallbackList$room_runtime_release().register(callback, java.lang.int.valueOf(maxClientId$room_runtime_release))) {
                    multiInstanceInvalidationService.getClientNames$room_runtime_release().Add(java.lang.int.valueOf(maxClientId$room_runtime_release), name);
                    i = maxClientId$room_runtime_release;
                } else {
                    multiInstanceInvalidationService.setMaxClientId$room_runtime_release(multiInstanceInvalidationService.getMaxClientId$room_runtime_release() - 1);
                    multiInstanceInvalidationService.getMaxClientId$room_runtime_release();
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return i;
    }

    public override void UnregisterCallback(androidx.room.IMultiInstanceInvalidationCallback callback, int clientId) {
        if ((9 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        android.os.RemoteCallbackList<androidx.room.IMultiInstanceInvalidationCallback> callbackList$room_runtime_release = this.this$0.getCallbackList$room_runtime_release();
        androidx.room.MultiInstanceInvalidationService multiInstanceInvalidationService = this.this$0;
        lock (callbackList$room_runtime_release) {
            try {
                multiInstanceInvalidationService.getCallbackList$room_runtime_release().unregister(callback);
                multiInstanceInvalidationService.getClientNames$room_runtime_release().Remove(java.lang.int.valueOf(clientId));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

