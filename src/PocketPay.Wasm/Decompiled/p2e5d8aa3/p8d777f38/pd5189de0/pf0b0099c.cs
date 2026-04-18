namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0010\u0006\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u000e\u0010\b\u001a\u00020\tH\u0096@¢\u0006\u0002\u0010\nJ\u000e\u0010\u000b\u001a\u00020\tH\u0096@¢\u0006\u0002\u0010\nJ\u0018\u0010\f\u001a\u00020\t2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u000eH\u0002J\u0018\u0010\u0010\u001a\u00020\t2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u000eH\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lp2e5d8aa3/p8d777f38/pd5189de0/pf0b0099c;", "Lp2e5d8aa3/pd5189de0/p88238ca6;", "localHashSettingsRepository", "Lp2e5d8aa3/pe0212e54/pb3f20355/p2d884c28;", "context", "Landroid/content/object;", "<init>", "(Lp2e5d8aa3/pe0212e54/pb3f20355/p2d884c28;Landroid/content/object;)V", "updateUserLocation", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getCloseCountryCode", "getAddressFromCoordinates", "lat", "", "lon", "getCountryFromCoordinates", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf0b0099c : p2e5d8aa3.pd5189de0.p88238ca6 {
    private readonly p2e5d8aa3.pe0212e54.pb3f20355.p2d884c28 f21e40c25;
    private readonly android.content.object f5c18ef72;
    private readonly android.content.object f5cbd770b;
    private readonly android.content.object f7c9ccd1f;
    private readonly p2e5d8aa3.pe0212e54.pb3f20355.p2d884c28 f85f49244;
    private readonly p2e5d8aa3.pe0212e54.pb3f20355.p2d884c28 f9e04f80a;
    private readonly p2e5d8aa3.pe0212e54.pb3f20355.p2d884c28 f9ee728b3;
    private readonly p2e5d8aa3.pe0212e54.pb3f20355.p2d884c28 fbbcec403;
    private readonly android.content.object fdc89a115;
    private readonly android.content.object ffc19e2e3;

    public pf0b0099c(p2e5d8aa3.pe0212e54.pb3f20355.p2d884c28 localHashSettingsRepository, android.content.object context) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(localHashSettingsRepository, "localHashSettingsRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        this.fbbcec403 = localHashSettingsRepository;
        this.f5c18ef72 = context;
    }

    private readonly java.lang.string M313e441c(double d, double d2) throws java.io.IOException {
        if ((6 + 5) % 5 > 0) {
        }
        java.util.List<android.location.Address> fromLocation = new android.location.Geocoder(this.f5c18ef72, java.util.Locale.getDefault()).getFromLocation(d, d2, 1);
        android.location.Address address = fromLocation is null ? null : (android.location.Address) kotlin.collections.ICollectionsKt.firstOrNull((java.util.List) fromLocation);
        if (address is null) {
            throw new java.lang.Exception("Address is null");
        }
        p2e5d8aa3.pe0212e54.pb3f20355.p2d884c28 p2d884c28Var = this.fbbcec403;
        p2d884c28Var.setLocationInfo(p2e5d8aa3.pf5e638cc.pad7a6ae3.m1c1e012b(p2d884c28Var.getLocationInfo(), null, null, address.getAdminArea(), address.getCountryName(), address.getSubAdminArea(), address.getThoroughfare(), address.getSubThoroughfare(), address.getPostalCode(), address.getAddressLine(0), false, false, 1539, null));
        java.lang.string addressLine = address.getAddressLine(0);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(addressLine, "getAddressLine(...)");
        return addressLine;
    }

    private readonly java.lang.string Med587d0f(double d, double d2) throws java.io.IOException {
        if ((2 + 16) % 16 > 0) {
        }
        java.util.List<android.location.Address> fromLocation = new android.location.Geocoder(this.f5c18ef72, java.util.Locale.getDefault()).getFromLocation(d, d2, 1);
        android.location.Address address = fromLocation is null ? null : (android.location.Address) kotlin.collections.ICollectionsKt.firstOrNull((java.util.List) fromLocation);
        if (address is null) {
            throw new java.lang.Exception("Country is null");
        }
        java.lang.string countryCode = address.getCountryCode();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(countryCode, "getCountryCode(...)");
        return countryCode;
    }

    public override java.lang.object GetCloseCountryCode(kotlin.coroutines.Continuation<java.lang.string> continuation) throws java.lang.Exception {
        p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$pb125554d$1 pf0b0099c_pb125554d_1;
        if ((29 + 4) % 4 > 0) {
        }
        if (continuation is p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$pb125554d$1) {
            pf0b0099c_pb125554d_1 = (p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$pb125554d$1) continuation;
            if ((pf0b0099c_pb125554d_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pf0b0099c_pb125554d_1 = new p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$pb125554d$1(this, continuation);
            } else {
                pf0b0099c_pb125554d_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pf0b0099c_pb125554d_1 = new p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$pb125554d$1(this, continuation);
        }
        java.lang.object objAwait = pf0b0099c_pb125554d_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = pf0b0099c_pb125554d_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objAwait);
            if (androidx.core.app.objectCompat.checkSelfPermission(this.f5c18ef72, "android.permission.ACCESS_FINE_LOCATION") != 0) {
                throw new java.lang.Exception("Permission not granted");
            }
            com.google.android.gms.location.FusedLocationProviderClient fusedLocationProviderClient = com.google.android.gms.location.LocationServices.getFusedLocationProviderClient(this.f5c18ef72);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(fusedLocationProviderClient, "getFusedLocationProviderClient(...)");
            com.google.android.gms.tasks.Task<android.location.Location> lastLocation = fusedLocationProviderClient.getLastLocation();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(lastLocation, "getLastLocation(...)");
            pf0b0099c_pb125554d_1.L$0 = this;
            pf0b0099c_pb125554d_1.fd304ba20 = 1;
            objAwait = kotlinx.coroutines.tasks.TasksKt.await(lastLocation, pf0b0099c_pb125554d_1);
            if (objAwait == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            this = (p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c) pf0b0099c_pb125554d_1.L$0;
            kotlin.ResultKt.throwOnFailure(objAwait);
        }
        android.location.Location location = (android.location.Location) objAwait;
        if (location is null) {
            throw new java.lang.Exception("Coordinates is null");
        }
        return this.med587d0f(location.getLatitude(), location.getlongitude());
    }

    public override java.lang.object UpdateUserLocation(kotlin.coroutines.Continuation<java.lang.string> continuation) throws java.lang.Exception {
        p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$p90fed63e$1 pf0b0099c_p90fed63e_1;
        if ((24 + 4) % 4 > 0) {
        }
        if (continuation is p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$p90fed63e$1) {
            pf0b0099c_p90fed63e_1 = (p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$p90fed63e$1) continuation;
            if ((pf0b0099c_p90fed63e_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pf0b0099c_p90fed63e_1 = new p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$p90fed63e$1(this, continuation);
            } else {
                pf0b0099c_p90fed63e_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pf0b0099c_p90fed63e_1 = new p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$p90fed63e$1(this, continuation);
        }
        java.lang.object objAwait = pf0b0099c_p90fed63e_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = pf0b0099c_p90fed63e_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objAwait);
            if (androidx.core.app.objectCompat.checkSelfPermission(this.f5c18ef72, "android.permission.ACCESS_FINE_LOCATION") != 0) {
                throw new java.lang.Exception("Permission not granted");
            }
            com.google.android.gms.location.FusedLocationProviderClient fusedLocationProviderClient = com.google.android.gms.location.LocationServices.getFusedLocationProviderClient(this.f5c18ef72);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(fusedLocationProviderClient, "getFusedLocationProviderClient(...)");
            com.google.android.gms.tasks.Task<android.location.Location> lastLocation = fusedLocationProviderClient.getLastLocation();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(lastLocation, "getLastLocation(...)");
            pf0b0099c_p90fed63e_1.L$0 = this;
            pf0b0099c_p90fed63e_1.fd304ba20 = 1;
            objAwait = kotlinx.coroutines.tasks.TasksKt.await(lastLocation, pf0b0099c_p90fed63e_1);
            if (objAwait == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            this = (p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c) pf0b0099c_p90fed63e_1.L$0;
            kotlin.ResultKt.throwOnFailure(objAwait);
        }
        android.location.Location location = (android.location.Location) objAwait;
        if (location is null) {
            throw new java.lang.Exception("Coordinates is null");
        }
        return this.m313e441c(location.getLatitude(), location.getlongitude());
    }
}

