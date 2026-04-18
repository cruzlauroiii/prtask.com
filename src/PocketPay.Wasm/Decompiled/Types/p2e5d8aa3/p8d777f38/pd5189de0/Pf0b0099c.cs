namespace WillowMaze.Wasm.Decompiled;

public class Pf0b0099c : P88238ca6
{
    private readonly p2d884c28 F21e40c25;
    private readonly object F5c18ef72;
    private readonly object F5cbd770b;
    private readonly object F7c9ccd1f;
    private readonly p2d884c28 F85f49244;
    private readonly p2d884c28 F9e04f80a;
    private readonly p2d884c28 F9ee728b3;
    private readonly p2d884c28 Fbbcec403;
    private readonly object Fdc89a115;
    private readonly object Ffc19e2e3;

    private string M313e441c(double P0, double P1)
    {
        // str: "getAddressLine(...)"
        // str: "Address is null"
        // call: Address.getAdminArea
        // call: p2d884c28.getLocationInfo
        // call: CollectionsKt.firstOrNull
        // call: CultureInfo.getDefault
        // call: Address.getCountryName
        // call: Geocoder.<init>
        // call: Exception.<init>
        // call: Address.getAddressLine
        // call: Address.getSubThoroughfare
        // call: pad7a6ae3.m1c1e012b
        // call: Address.getSubAdminArea
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p2d884c28.setLocationInfo
        // call: Address.getThoroughfare
        // call: Geocoder.getFromLocation
        // call: Address.getPostalCode
        // field: p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c.fbbcec403
        // field: p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c.f5c18ef72
        // type: Exception
        // type: Geocoder
        return string.Empty;
    }

    private string Med587d0f(double P0, double P1)
    {
        // str: "Country is null"
        // str: "getCountryCode(...)"
        // call: Address.getCountryCode
        // call: CollectionsKt.firstOrNull
        // call: Geocoder.getFromLocation
        // call: CultureInfo.getDefault
        // call: Exception.<init>
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Geocoder.<init>
        // field: p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c.f5c18ef72
        // type: Exception
        // type: Geocoder
        return string.Empty;
    }

    public object GetCloseCountryCode(object P0)
    {
        // str: "Coordinates is null"
        // str: "android.permission.ACCESS_FINE_LOCATION"
        // str: "call to 'resume' before 'invoke' with coroutine"
        // str: "Permission not granted"
        // str: "getLastLocation(...)"
        // str: "getFusedLocationProviderClient(...)"
        // call: IllegalStateException.<init>
        // call: ResultKt.throwOnFailure
        // call: ActivityCompat.checkSelfPermission
        // call: pf0b0099c.med587d0f
        // call: Exception.<init>
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Location.getLongitude
        // call: FusedLocationProviderClient.getLastLocation
        // call: TasksKt.await
        // call: Location.getLatitude
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: pf0b0099c$pb125554d$1.<init>
        // call: LocationServices.getFusedLocationProviderClient
        // field: p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c.f5c18ef72
        // field: p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$pb125554d$1.L$0
        // field: p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$pb125554d$1.fb4a88417
        // field: p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$pb125554d$1.fd304ba20
        // type: pf0b0099c$pb125554d$1
        // type: IllegalStateException
        // type: Exception
        return default!;
    }

    public object UpdateUserLocation(object P0)
    {
        // str: "Permission not granted"
        // str: "android.permission.ACCESS_FINE_LOCATION"
        // str: "Coordinates is null"
        // str: "getLastLocation(...)"
        // str: "call to 'resume' before 'invoke' with coroutine"
        // str: "getFusedLocationProviderClient(...)"
        // call: FusedLocationProviderClient.getLastLocation
        // call: ResultKt.throwOnFailure
        // call: Intrinsics.checkNotNullExpressionValue
        // call: TasksKt.await
        // call: ActivityCompat.checkSelfPermission
        // call: Exception.<init>
        // call: pf0b0099c$p90fed63e$1.<init>
        // call: LocationServices.getFusedLocationProviderClient
        // call: IllegalStateException.<init>
        // call: pf0b0099c.m313e441c
        // call: Location.getLatitude
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: Location.getLongitude
        // field: p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c.f5c18ef72
        // field: p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$p90fed63e$1.fd304ba20
        // field: p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$p90fed63e$1.fb4a88417
        // field: p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$p90fed63e$1.L$0
        // type: Exception
        // type: IllegalStateException
        // type: pf0b0099c$p90fed63e$1
        return default!;
    }

}
