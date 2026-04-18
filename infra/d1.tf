resource "cloudflare_d1_database" "prtask" {
  account_id = var.cloudflare_account_id
  name       = "prtask-db"
}

output "d1_database_id" {
  value = cloudflare_d1_database.prtask.id
}
