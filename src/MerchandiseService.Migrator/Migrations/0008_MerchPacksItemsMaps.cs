using FluentMigrator;

namespace MerchandiseService.Migrator.Migrations
{
	[Migration(8)]
	public class MerchPacksItemsMaps : Migration
	{
		public override void Up()
		{
			Create
				.Table("merch_packs_items_maps")
				.WithColumn("merch_pack_id").AsInt32().PrimaryKey()
				.WithColumn("merch_pack_item_id").AsInt32().PrimaryKey();
		}

		public override void Down()
		{
			Delete.Table("merch_packs_items_maps");
		}
	}
}