# PocketPay Payment Workflows

Captured from live transactions on Samsung Galaxy S25 Ultra (SM-S928B), Android 16 API 36, PocketPay app v1.0.30 (versionCode 110304).

## API Endpoints

- **Auth**: `POST https://pulsar.psr-it.com/api/v3/authorize`
- **Receipt**: `POST https://pulsar.psr-it.com/api/v3/receipt`
- **Store API**: `https://api.psr-it.com` (products, product-groups)

## Authentication

### Authorize Request Body
```json
{
  "device_model": "SM-S928B",
  "device_brand": "samsung",
  "package_name": "com.gcash.business.pocketpay",
  "time_zone_offset": 28800000,
  "password": "75734616b81a8309f17b2d5bfdd9415b927985aa1fdade85a5b8284582e610e5",
  "app_version": "1.0.30",
  "login": "639568564236",
  "fcmtoken": "<FCM token>",
  "android_id": "e14ceab085867eab"
}
```

POST to `/api/v3/authorize` returns JWT in response header:
```
Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9...
```
JWT payload contains: `iss=secure-api`, `aud=secure-app`, `sub=<user-id>`, `exp=<timestamp>`, `rol=[{"authority":"KASS"}]`

## Card Payment (TAP_ON_PHONE)

### Request
```
POST https://pulsar.psr-it.com/api/v3/receipt
Content-Type: application/json; charset=UTF-8
platform: Android
versionName: 1.0.30
versionCode: 110304
```

### Request Body
```json
{
  "time_zone_offset": 28800000,
  "cashier_uuid": "47d12aaa-31ee-4f49-9d75-5ff7fc65993f",
  "positions": [
    {
      "tax": "NO_VAT",
      "quantity": 1.00,
      "measureName": "EA",
      "type": "NORMAL",
      "price": {
        "purchase_price": 0.00,
        "price_without_tax": 1.00,
        "price": 1.00
      },
      "name": "test product",
      "initialQuantity": 0.00,
      "precision": 100,
      "position_uuid": "f43c6f70-5087-4a4b-8ccb-ccbc22f17406"
    }
  ],
  "payment_place": "",
  "device_uuid": "a29e8f74-e57b-46cf-80a9-a5dff92f49a2",
  "receipt_timestamp": 1774535578017,
  "payment_address": "",
  "device_id": "e14ceab085867eab",
  "payments": [
    {
      "payment_type": "TAP_ON_PHONE",
      "amount": 1.00,
      "uuid": "a9ce387e-5e92-4707-899d-0a48fa53c908",
      "transaction": {
        "authCode": "R99895",
        "terminalId": "SFT07056",
        "merchantId": "177397344332991",
        "topRefUuid": "be1ac4dc-feff-49f0-8746-259b019a5629",
        "responseCode": "000",
        "referenceNumber": "144908746259",
        "stan": "144908"
      }
    }
  ],
  "user_id": "34c9c05b-4de8-4edf-9bfa-0efdb09d8a94",
  "operation_type": "SELL",
  "store_id": "fc0f2f09-7b94-4140-b5f3-9fc589d7fa18",
  "receipt_uuid": "a9ce387e-5e92-4707-899d-0a48fa53c908"
}
```

### Response (200 OK)
```json
{
  "type": "SELL",
  "id": "a9ce387e-5e92-4707-899d-0a48fa53c908",
  "extras": {},
  "number": 21,
  "closeDate": 1774535578017,
  "timeZoneOffset": 28800000,
  "sessionId": "131ed2d1-5174-4867-b38b-565b3272a39f",
  "sessionNumber": 2,
  "closeUserId": "47d12aaa-31ee-4f49-9d75-5ff7fc65993f",
  "deviceId": "a29e8f74-e57b-46cf-80a9-a5dff92f49a2",
  "deviceImei": "e14ceab085867eab",
  "storeId": "fc0f2f09-7b94-4140-b5f3-9fc589d7fa18",
  "userId": "34c9c05b-4de8-4edf-9bfa-0efdb09d8a94",
  "body": {
    "positions": [
      {
        "productName": "test product",
        "measureName": "EA",
        "quantity": 1.00,
        "price": 1.00,
        "resultPrice": 1.00,
        "sum": 1.00,
        "resultSum": 1.00,
        "tax": {
          "rate": "NO_VAT",
          "taxCode": "NO_VAT",
          "taxType": "T1"
        },
        "settlementMethod": {
          "type": "CHECKOUT_FULL"
        }
      }
    ],
    "payments": [
      {
        "id": "a9ce387e-5e92-4707-899d-0a48fa53c908",
        "sum": 1.00,
        "type": "TAP_ON_PHONE",
        "transaction": {
          "referenceNumber": "144908746259",
          "responseCode": "000",
          "authCode": "R99895",
          "stan": "144908",
          "terminalId": "SFT07056",
          "merchantId": "177397344332991",
          "topRefUuid": "be1ac4dc-feff-49f0-8746-259b019a5629",
          "pinCheck": false
        }
      }
    ],
    "posPrintResults": [
      {
        "receiptNumber": 1,
        "documentNumber": 21,
        "sessionNumber": 2,
        "receiptDate": "26032026",
        "checkSum": 1.00
      }
    ],
    "sum": 1.00,
    "resultSum": 1.00
  },
  "version": "V2"
}
```

### Card Payment Key Fields
- `payment_type`: `TAP_ON_PHONE` (NFC card tap)
- `transaction.authCode`: Authorization code from payment processor
- `transaction.terminalId`: `SFT07056` (SoftPOS terminal)
- `transaction.merchantId`: `177397344332991`
- `transaction.responseCode`: `000` (approved)
- `transaction.referenceNumber`: Unique reference for the transaction
- `transaction.stan`: System trace audit number

## QR Payment (QR_PAY)

### Request
Same endpoint and structure as card payment, but with `payment_type: "QR_PAY"` and no `transaction` object.

### Request Body
```json
{
  "time_zone_offset": 28800000,
  "cashier_uuid": "47d12aaa-31ee-4f49-9d75-5ff7fc65993f",
  "positions": [
    {
      "tax": "NO_VAT",
      "quantity": 1.00,
      "measureName": "EA",
      "type": "NORMAL",
      "price": {
        "purchase_price": 0.00,
        "price_without_tax": 1.00,
        "price": 1.00
      },
      "name": "test product",
      "initialQuantity": 0.00,
      "precision": 100,
      "position_uuid": "b1f47aea-1dba-4d24-af17-2cafd9778d5b"
    }
  ],
  "payment_place": "",
  "device_uuid": "a29e8f74-e57b-46cf-80a9-a5dff92f49a2",
  "receipt_timestamp": 1774528555908,
  "payment_address": "",
  "device_id": "e14ceab085867eab",
  "payments": [
    {
      "payment_type": "QR_PAY",
      "amount": 1.00,
      "uuid": "9c937497-b04d-40bd-8abd-af7ae4282a23"
    }
  ],
  "user_id": "34c9c05b-4de8-4edf-9bfa-0efdb09d8a94",
  "operation_type": "SELL",
  "store_id": "fc0f2f09-7b94-4140-b5f3-9fc589d7fa18",
  "receipt_uuid": "9c937497-b04d-40bd-8abd-af7ae4282a23"
}
```

### Response (200 OK)
Same structure as card payment response, but:
```json
{
  "payments": [
    {
      "id": "9c937497-b04d-40bd-8abd-af7ae4282a23",
      "sum": 1.00,
      "type": "QR_PAY",
      "transaction": null
    }
  ]
}
```

### QR Payment Key Differences
- `payment_type`: `QR_PAY` (not `TAP_ON_PHONE`)
- `transaction`: `null` (no card terminal transaction data)
- No `authCode`, `terminalId`, `merchantId`, `stan`, `referenceNumber`
- Payment is processed via QR code scan (GCash/Maya)

## Common Fields

| Field | Value | Description |
|-------|-------|-------------|
| `device_uuid` | `a29e8f74-e57b-46cf-80a9-a5dff92f49a2` | Device registration ID |
| `device_id` | `e14ceab085867eab` | Device IMEI/hardware ID |
| `store_id` | `fc0f2f09-7b94-4140-b5f3-9fc589d7fa18` | Store registration ID |
| `user_id` | `34c9c05b-4de8-4edf-9bfa-0efdb09d8a94` | Logged-in user ID |
| `cashier_uuid` | `47d12aaa-31ee-4f49-9d75-5ff7fc65993f` | Cashier ID |
| `operation_type` | `SELL` | Sale operation |
| `time_zone_offset` | `28800000` | UTC+8 (Philippines) |
| `tax` | `NO_VAT` | No VAT applied |

## Session Info
- `sessionId`: `131ed2d1-5174-4867-b38b-565b3272a39f`
- `sessionNumber`: 2
- Receipt numbers increment per session (observed: 16-21)

## Monitoring Setup
- **Companion app** (`com.prtask.pocketpay.companion`) runs as foreground service on the same device
- **READ_LOGS** permission (granted via ADB) required to capture OkHttp traffic
- **Android 16 limitation**: `Runtime.exec("logcat")` and `ProcessBuilder` cannot read other apps' logs even with READ_LOGS — child processes don't inherit the capability. Logs must be read via ADB
- **Companion HTTP server** on port 8769 provides status, controls, settings toggles
- **Backoffice** (ASP.NET Kestrel HTTPS) proxies companion HTTP and reads logcat via ADB
