$Files = Get-ChildItem 'C:\work\pocketpay-apk-v2\jadx-output\sources' -Recurse -Filter '*.java' | Where-Object { $_.Length -gt 2000 }
$Payment = $Files | Where-Object { $_.Name -match 'Payment|Receipt|Sell|Toph' } | Select-Object -First 3
foreach ($F in $Payment) {
    Write-Output "=== $($F.Name) ($($F.Length) bytes) ==="
    Get-Content $F.FullName -TotalCount 40
    Write-Output ""
}

Write-Output "Total Java files: $($Files.Count)"
Write-Output "Total all files: $((Get-ChildItem 'C:\work\pocketpay-apk-v2\jadx-output\sources' -Recurse -Filter '*.java').Count)"
