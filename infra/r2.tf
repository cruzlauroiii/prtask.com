resource "cloudflare_r2_bucket" "prtask_diffs" {
  account_id = var.cloudflare_account_id
  name       = "prtask-diffs"
}

resource "cloudflare_r2_bucket" "prtask_avatars" {
  account_id = var.cloudflare_account_id
  name       = "prtask-avatars"
}

output "r2_diffs_bucket" {
  value = cloudflare_r2_bucket.prtask_diffs.name
}

output "r2_avatars_bucket" {
  value = cloudflare_r2_bucket.prtask_avatars.name
}
