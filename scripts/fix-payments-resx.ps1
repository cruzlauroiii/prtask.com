$EnPath = "C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.resx"
[xml]$En = Get-Content $EnPath -Encoding UTF8

$Keys = @{
    'PaymentSeoTitle'            = 'Payments - PrTask'
    'PaymentSeoDescription'      = 'View your payment history and transaction details.'
    'PaymentPageHeading'         = 'Payment History'
    'PaymentPageDescription'     = 'View all your payments and their status.'
    'PaymentUserIdLabel'         = 'Your User ID'
    'PaymentUserIdPlaceholder'   = 'Enter your user ID'
    'PaymentLoadButton'          = 'Load Payments'
    'PaymentEmptyStateText'      = 'No payments found.'
    'PaymentHeaderDate'          = 'Date'
    'PaymentHeaderTask'          = 'Task'
    'PaymentHeaderAmount'        = 'Amount'
    'PaymentHeaderStatus'        = 'Status'
    'PaymentHeaderType'          = 'Type'
    'PaymentTaskNotApplicable'   = 'N/A'
    'PaymentDescriptionHeading'  = 'About Payment History'
    'PaymentDescriptionParagraph1' = 'The Payment History page provides a comprehensive view of all financial transactions associated with your PrTask account. Whether you are a developer receiving bounty payouts or a client funding task bounties, this page gives you full transparency into every payment made through the platform. Each transaction record includes the date, associated task, amount, current status, and payment type so you can track your finances with confidence.'
    'PaymentDescriptionParagraph2' = 'PrTask processes payments automatically when a pull request is approved and merged by the task owner. Developers receive 100% of the bounty amount with no platform fees deducted from their earnings. Payment statuses update in real time, allowing you to see whether a transaction is pending, completed, or requires attention. You can filter your payment history by entering your user ID to view transactions specific to your account.'
    'PaymentDescriptionParagraph3' = 'For clients, this page also serves as a record of all bounty disbursements made to developers who completed your tasks. You can cross-reference payments with specific tasks to verify that funds were distributed correctly. If you have questions about a specific transaction or need to dispute a payment, PrTask provides a dedicated support channel accessible from your account settings. All payment data is encrypted and stored securely in compliance with PCI DSS standards.'
}

$Existing = @{}
foreach ($d in $En.root.data) { $Existing[$d.name] = $true }

foreach ($Key in $Keys.Keys) {
    if ($Existing.ContainsKey($Key)) { continue }
    $DataNode = $En.CreateElement('data')
    $DataNode.SetAttribute('name', $Key)
    $DataNode.SetAttribute('xml:space', 'preserve')
    $ValNode = $En.CreateElement('value')
    $ValNode.InnerText = $Keys[$Key]
    $DataNode.AppendChild($ValNode) | Out-Null
    $En.root.AppendChild($DataNode) | Out-Null
}

$Settings = [System.Xml.XmlWriterSettings]::new()
$Settings.Encoding = [System.Text.UTF8Encoding]::new($false)
$Settings.Indent = $true
$Settings.IndentChars = '  '
$Writer = [System.Xml.XmlWriter]::Create($EnPath, $Settings)
$En.Save($Writer); $Writer.Flush(); $Writer.Dispose()
Write-Host 'Done'
