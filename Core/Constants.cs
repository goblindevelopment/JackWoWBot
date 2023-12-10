using System;

namespace Jack.Core
{
	// Token: 0x0200011C RID: 284
	public class Constants
	{
		// Token: 0x0200011D RID: 285
		public enum ObjectType_Retail : byte
		{
			// Token: 0x04000C8E RID: 3214
			Object,
			// Token: 0x04000C8F RID: 3215
			Item,
			// Token: 0x04000C90 RID: 3216
			Container,
			// Token: 0x04000C91 RID: 3217
			EmpAzeriteItem,
			// Token: 0x04000C92 RID: 3218
			AzeriteItem,
			// Token: 0x04000C93 RID: 3219
			Unit,
			// Token: 0x04000C94 RID: 3220
			Player,
			// Token: 0x04000C95 RID: 3221
			LocalPlayer,
			// Token: 0x04000C96 RID: 3222
			GameObject,
			// Token: 0x04000C97 RID: 3223
			DynamicObject,
			// Token: 0x04000C98 RID: 3224
			Corpse,
			// Token: 0x04000C99 RID: 3225
			AreaTrigger,
			// Token: 0x04000C9A RID: 3226
			SceneObject,
			// Token: 0x04000C9B RID: 3227
			Conversation,
			// Token: 0x04000C9C RID: 3228
			NA
		}

		// Token: 0x0200011E RID: 286
		public enum ObjectType : byte
		{
			// Token: 0x04000C9E RID: 3230
			Object,
			// Token: 0x04000C9F RID: 3231
			Item,
			// Token: 0x04000CA0 RID: 3232
			Container,
			// Token: 0x04000CA1 RID: 3233
			Unit,
			// Token: 0x04000CA2 RID: 3234
			Player,
			// Token: 0x04000CA3 RID: 3235
			ActivePlayer,
			// Token: 0x04000CA4 RID: 3236
			GameObject,
			// Token: 0x04000CA5 RID: 3237
			DynamicObject,
			// Token: 0x04000CA6 RID: 3238
			Corpse,
			// Token: 0x04000CA7 RID: 3239
			AreaTrigger,
			// Token: 0x04000CA8 RID: 3240
			SceneObject,
			// Token: 0x04000CA9 RID: 3241
			Conversation,
			// Token: 0x04000CAA RID: 3242
			AIGroup,
			// Token: 0x04000CAB RID: 3243
			Scenario,
			// Token: 0x04000CAC RID: 3244
			Loot,
			// Token: 0x04000CAD RID: 3245
			NA
		}

		// Token: 0x0200011F RID: 287
		public enum ObjectDetail
		{
			// Token: 0x04000CAF RID: 3247
			Door,
			// Token: 0x04000CB0 RID: 3248
			Button,
			// Token: 0x04000CB1 RID: 3249
			Questgiver,
			// Token: 0x04000CB2 RID: 3250
			Chest,
			// Token: 0x04000CB3 RID: 3251
			Binder,
			// Token: 0x04000CB4 RID: 3252
			Generic,
			// Token: 0x04000CB5 RID: 3253
			Trap,
			// Token: 0x04000CB6 RID: 3254
			Chair,
			// Token: 0x04000CB7 RID: 3255
			SpellFocus,
			// Token: 0x04000CB8 RID: 3256
			Text,
			// Token: 0x04000CB9 RID: 3257
			Goober,
			// Token: 0x04000CBA RID: 3258
			TransportElevator,
			// Token: 0x04000CBB RID: 3259
			AreaDamage,
			// Token: 0x04000CBC RID: 3260
			Camera,
			// Token: 0x04000CBD RID: 3261
			MapObject,
			// Token: 0x04000CBE RID: 3262
			MapObjectTransport,
			// Token: 0x04000CBF RID: 3263
			DuelFlag,
			// Token: 0x04000CC0 RID: 3264
			FishingNode,
			// Token: 0x04000CC1 RID: 3265
			Ritual,
			// Token: 0x04000CC2 RID: 3266
			Mailbox,
			// Token: 0x04000CC3 RID: 3267
			DONOTUSE1,
			// Token: 0x04000CC4 RID: 3268
			GuardPost,
			// Token: 0x04000CC5 RID: 3269
			SpellCaster,
			// Token: 0x04000CC6 RID: 3270
			MeetingStone,
			// Token: 0x04000CC7 RID: 3271
			FlagStand,
			// Token: 0x04000CC8 RID: 3272
			FishingHole,
			// Token: 0x04000CC9 RID: 3273
			FlagDrop,
			// Token: 0x04000CCA RID: 3274
			MiniGame,
			// Token: 0x04000CCB RID: 3275
			DONOTUSE2,
			// Token: 0x04000CCC RID: 3276
			ControlZone,
			// Token: 0x04000CCD RID: 3277
			AuraGenerator,
			// Token: 0x04000CCE RID: 3278
			DungeonDifficulty,
			// Token: 0x04000CCF RID: 3279
			BarberChair,
			// Token: 0x04000CD0 RID: 3280
			DestructibleBuilding,
			// Token: 0x04000CD1 RID: 3281
			GuildBank,
			// Token: 0x04000CD2 RID: 3282
			Trapdoor,
			// Token: 0x04000CD3 RID: 3283
			Newflag,
			// Token: 0x04000CD4 RID: 3284
			Newflagdrop,
			// Token: 0x04000CD5 RID: 3285
			GarrisonBuilding,
			// Token: 0x04000CD6 RID: 3286
			GarrisonPlot,
			// Token: 0x04000CD7 RID: 3287
			ClientCreature,
			// Token: 0x04000CD8 RID: 3288
			ClientItem,
			// Token: 0x04000CD9 RID: 3289
			CapturePoint,
			// Token: 0x04000CDA RID: 3290
			PhaseableMO,
			// Token: 0x04000CDB RID: 3291
			GarrisonMonument,
			// Token: 0x04000CDC RID: 3292
			GarrisonShipment,
			// Token: 0x04000CDD RID: 3293
			GarrisonMonumentPlaque,
			// Token: 0x04000CDE RID: 3294
			ItemForge,
			// Token: 0x04000CDF RID: 3295
			UILink,
			// Token: 0x04000CE0 RID: 3296
			KeystoneReceptacle,
			// Token: 0x04000CE1 RID: 3297
			GatheringNode,
			// Token: 0x04000CE2 RID: 3298
			ChallengeModeReward,
			// Token: 0x04000CE3 RID: 3299
			Multi,
			// Token: 0x04000CE4 RID: 3300
			SiegeableMulti,
			// Token: 0x04000CE5 RID: 3301
			SiegeableMapObject,
			// Token: 0x04000CE6 RID: 3302
			PVPReward,
			// Token: 0x04000CE7 RID: 3303
			PlayerChoiceChest,
			// Token: 0x04000CE8 RID: 3304
			LegendaryForge,
			// Token: 0x04000CE9 RID: 3305
			GarrTalentTree,
			// Token: 0x04000CEA RID: 3306
			WeeklyRewardChest,
			// Token: 0x04000CEB RID: 3307
			ClientModel,
			// Token: 0x04000CEC RID: 3308
			NA
		}

		// Token: 0x02000120 RID: 288
		public enum ObjectLowFlags
		{
			// Token: 0x04000CEE RID: 3310
			GO_FLAG_IN_USE = 1,
			// Token: 0x04000CEF RID: 3311
			GO_FLAG_LOCKED,
			// Token: 0x04000CF0 RID: 3312
			GO_FLAG_INTERACT_COND = 4,
			// Token: 0x04000CF1 RID: 3313
			GO_FLAG_TRANSPORT = 8,
			// Token: 0x04000CF2 RID: 3314
			GO_FLAG_NO_INTERACT = 16,
			// Token: 0x04000CF3 RID: 3315
			GO_FLAG_NODESPAWN = 32,
			// Token: 0x04000CF4 RID: 3316
			GO_FLAG_TRIGGERED = 64
		}

		// Token: 0x02000121 RID: 289
		public enum PlayerRace
		{
			// Token: 0x04000CF6 RID: 3318
			Human = 1,
			// Token: 0x04000CF7 RID: 3319
			Orc,
			// Token: 0x04000CF8 RID: 3320
			Dwarf,
			// Token: 0x04000CF9 RID: 3321
			NightElf,
			// Token: 0x04000CFA RID: 3322
			Undead,
			// Token: 0x04000CFB RID: 3323
			Tauren,
			// Token: 0x04000CFC RID: 3324
			Gnome = 115,
			// Token: 0x04000CFD RID: 3325
			Troll,
			// Token: 0x04000CFE RID: 3326
			BloodElf = 1610,
			// Token: 0x04000CFF RID: 3327
			Draenei = 1629,
			// Token: 0x04000D00 RID: 3328
			Worgen = 2203,
			// Token: 0x04000D01 RID: 3329
			Goblin,
			// Token: 0x04000D02 RID: 3330
			NA
		}

		// Token: 0x02000122 RID: 290
		public enum UnitClass
		{
			// Token: 0x04000D04 RID: 3332
			NA,
			// Token: 0x04000D05 RID: 3333
			Warrior,
			// Token: 0x04000D06 RID: 3334
			Paladin,
			// Token: 0x04000D07 RID: 3335
			Hunter,
			// Token: 0x04000D08 RID: 3336
			Rogue,
			// Token: 0x04000D09 RID: 3337
			Priest,
			// Token: 0x04000D0A RID: 3338
			DeathKnight,
			// Token: 0x04000D0B RID: 3339
			Shaman,
			// Token: 0x04000D0C RID: 3340
			Mage,
			// Token: 0x04000D0D RID: 3341
			Warlock,
			// Token: 0x04000D0E RID: 3342
			Monk,
			// Token: 0x04000D0F RID: 3343
			Druid,
			// Token: 0x04000D10 RID: 3344
			DemonHunter
		}

		// Token: 0x02000123 RID: 291
		public enum UnitFlags : uint
		{
			// Token: 0x04000D12 RID: 3346
			None,
			// Token: 0x04000D13 RID: 3347
			Sitting,
			// Token: 0x04000D14 RID: 3348
			Influenced = 4U,
			// Token: 0x04000D15 RID: 3349
			PlayerControlled = 8U,
			// Token: 0x04000D16 RID: 3350
			RunningBack = 16U,
			// Token: 0x04000D17 RID: 3351
			Preparation = 32U,
			// Token: 0x04000D18 RID: 3352
			PlusMob = 64U,
			// Token: 0x04000D19 RID: 3353
			NotAttackable = 256U,
			// Token: 0x04000D1A RID: 3354
			Looting = 1024U,
			// Token: 0x04000D1B RID: 3355
			PetInCombat = 2048U,
			// Token: 0x04000D1C RID: 3356
			PvPFlagged = 4096U,
			// Token: 0x04000D1D RID: 3357
			Silenced = 8192U,
			// Token: 0x04000D1E RID: 3358
			Pacified = 131072U,
			// Token: 0x04000D1F RID: 3359
			Stunned = 262144U,
			// Token: 0x04000D20 RID: 3360
			CanPerformAction_Mask1 = 393216U,
			// Token: 0x04000D21 RID: 3361
			Combat = 524288U,
			// Token: 0x04000D22 RID: 3362
			TaxiFlight = 1048576U,
			// Token: 0x04000D23 RID: 3363
			Disarmed = 2097152U,
			// Token: 0x04000D24 RID: 3364
			Confused = 4194304U,
			// Token: 0x04000D25 RID: 3365
			Fleeing = 8388608U,
			// Token: 0x04000D26 RID: 3366
			Possessed = 16777216U,
			// Token: 0x04000D27 RID: 3367
			NotSelectable = 33554432U,
			// Token: 0x04000D28 RID: 3368
			Skinnable = 67108864U,
			// Token: 0x04000D29 RID: 3369
			Mounted = 134217728U,
			// Token: 0x04000D2A RID: 3370
			Dazed = 536870912U,
			// Token: 0x04000D2B RID: 3371
			Sheathe = 1073741824U,
			// Token: 0x04000D2C RID: 3372
			NA
		}

		// Token: 0x02000124 RID: 292
		public enum UnitDynamicFlags : uint
		{
			// Token: 0x04000D2E RID: 3374
			None,
			// Token: 0x04000D2F RID: 3375
			Invisible,
			// Token: 0x04000D30 RID: 3376
			Lootable = 4U,
			// Token: 0x04000D31 RID: 3377
			TrackUnit = 8U,
			// Token: 0x04000D32 RID: 3378
			Tapped = 16U,
			// Token: 0x04000D33 RID: 3379
			TappedByMe = 32U,
			// Token: 0x04000D34 RID: 3380
			Dead = 64U,
			// Token: 0x04000D35 RID: 3381
			ReferAFriendLinked = 128U,
			// Token: 0x04000D36 RID: 3382
			IsTappedByAllThreatList = 256U,
			// Token: 0x04000D37 RID: 3383
			NA
		}

		// Token: 0x02000125 RID: 293
		public enum DruidShapeshift
		{
			// Token: 0x04000D39 RID: 3385
			Normal,
			// Token: 0x04000D3A RID: 3386
			Cat,
			// Token: 0x04000D3B RID: 3387
			TreeOfLife,
			// Token: 0x04000D3C RID: 3388
			Travel,
			// Token: 0x04000D3D RID: 3389
			Aqua,
			// Token: 0x04000D3E RID: 3390
			Bear,
			// Token: 0x04000D3F RID: 3391
			Ambient,
			// Token: 0x04000D40 RID: 3392
			Ghoul,
			// Token: 0x04000D41 RID: 3393
			DireBear,
			// Token: 0x04000D42 RID: 3394
			CreatureBear = 14,
			// Token: 0x04000D43 RID: 3395
			CreatureCat,
			// Token: 0x04000D44 RID: 3396
			GhostWolf,
			// Token: 0x04000D45 RID: 3397
			BattleStance,
			// Token: 0x04000D46 RID: 3398
			DefensiveStance,
			// Token: 0x04000D47 RID: 3399
			BerserkerStance,
			// Token: 0x04000D48 RID: 3400
			EpicFlightForm = 27,
			// Token: 0x04000D49 RID: 3401
			Shadow,
			// Token: 0x04000D4A RID: 3402
			FlightForm,
			// Token: 0x04000D4B RID: 3403
			Stealth,
			// Token: 0x04000D4C RID: 3404
			Moonkin,
			// Token: 0x04000D4D RID: 3405
			NA
		}

		// Token: 0x02000126 RID: 294
		public enum ActionBar : uint
		{
			// Token: 0x04000D4F RID: 3407
			Item = 2147483648U
		}

		// Token: 0x02000127 RID: 295
		public enum CreatureRank
		{
			// Token: 0x04000D51 RID: 3409
			Normal,
			// Token: 0x04000D52 RID: 3410
			Elite,
			// Token: 0x04000D53 RID: 3411
			RareElite,
			// Token: 0x04000D54 RID: 3412
			WorldBoss,
			// Token: 0x04000D55 RID: 3413
			Rare,
			// Token: 0x04000D56 RID: 3414
			NA
		}

		// Token: 0x02000128 RID: 296
		public enum Reaction
		{
			// Token: 0x04000D58 RID: 3416
			Unknown,
			// Token: 0x04000D59 RID: 3417
			Hated,
			// Token: 0x04000D5A RID: 3418
			Hostile,
			// Token: 0x04000D5B RID: 3419
			Unfriendly,
			// Token: 0x04000D5C RID: 3420
			Neutral,
			// Token: 0x04000D5D RID: 3421
			Friendly,
			// Token: 0x04000D5E RID: 3422
			Honored,
			// Token: 0x04000D5F RID: 3423
			Revered,
			// Token: 0x04000D60 RID: 3424
			Exalted
		}

		// Token: 0x02000129 RID: 297
		public enum CreatureType
		{
			// Token: 0x04000D62 RID: 3426
			NA,
			// Token: 0x04000D63 RID: 3427
			Beast,
			// Token: 0x04000D64 RID: 3428
			Dragon,
			// Token: 0x04000D65 RID: 3429
			Demon,
			// Token: 0x04000D66 RID: 3430
			Elemental,
			// Token: 0x04000D67 RID: 3431
			Giant,
			// Token: 0x04000D68 RID: 3432
			Undead,
			// Token: 0x04000D69 RID: 3433
			Humanoid,
			// Token: 0x04000D6A RID: 3434
			Critter,
			// Token: 0x04000D6B RID: 3435
			Mechanical,
			// Token: 0x04000D6C RID: 3436
			NotSpecified,
			// Token: 0x04000D6D RID: 3437
			Totem,
			// Token: 0x04000D6E RID: 3438
			NonCombatPet,
			// Token: 0x04000D6F RID: 3439
			GasCloud
		}

		// Token: 0x0200012A RID: 298
		public enum Professions : short
		{
			// Token: 0x04000D71 RID: 3441
			None,
			// Token: 0x04000D72 RID: 3442
			Archaeology = 794,
			// Token: 0x04000D73 RID: 3443
			Alchemy = 171,
			// Token: 0x04000D74 RID: 3444
			Blacksmith = 164,
			// Token: 0x04000D75 RID: 3445
			Cooking = 185,
			// Token: 0x04000D76 RID: 3446
			Enchanting = 333,
			// Token: 0x04000D77 RID: 3447
			Engineer = 202,
			// Token: 0x04000D78 RID: 3448
			FirstAid = 129,
			// Token: 0x04000D79 RID: 3449
			Fishing = 356,
			// Token: 0x04000D7A RID: 3450
			Herbalism = 182,
			// Token: 0x04000D7B RID: 3451
			Inscription = 773,
			// Token: 0x04000D7C RID: 3452
			Jewelcrafting = 755,
			// Token: 0x04000D7D RID: 3453
			Leatherworking = 165,
			// Token: 0x04000D7E RID: 3454
			Mining = 186,
			// Token: 0x04000D7F RID: 3455
			Skinning = 393,
			// Token: 0x04000D80 RID: 3456
			Tailoring = 197,
			// Token: 0x04000D81 RID: 3457
			Frost = 6,
			// Token: 0x04000D82 RID: 3458
			Fire = 8,
			// Token: 0x04000D83 RID: 3459
			Arms = 26,
			// Token: 0x04000D84 RID: 3460
			Combat = 38,
			// Token: 0x04000D85 RID: 3461
			Subtlety,
			// Token: 0x04000D86 RID: 3462
			Swords = 43,
			// Token: 0x04000D87 RID: 3463
			Axes,
			// Token: 0x04000D88 RID: 3464
			Bows,
			// Token: 0x04000D89 RID: 3465
			Guns,
			// Token: 0x04000D8A RID: 3466
			BeastMastery = 50,
			// Token: 0x04000D8B RID: 3467
			HunterSurvival,
			// Token: 0x04000D8C RID: 3468
			Maces = 54,
			// Token: 0x04000D8D RID: 3469
			TwoHandedSwords,
			// Token: 0x04000D8E RID: 3470
			Holy,
			// Token: 0x04000D8F RID: 3471
			ShadowMagic = 78,
			// Token: 0x04000D90 RID: 3472
			Defense = 95,
			// Token: 0x04000D91 RID: 3473
			LanguageCommon = 98,
			// Token: 0x04000D92 RID: 3474
			DwarvenRacial = 101,
			// Token: 0x04000D93 RID: 3475
			LanguageOrcish = 109,
			// Token: 0x04000D94 RID: 3476
			LanguageDwarven = 111,
			// Token: 0x04000D95 RID: 3477
			LanguageDarnassian = 113,
			// Token: 0x04000D96 RID: 3478
			LanguageTaurahe = 115,
			// Token: 0x04000D97 RID: 3479
			DualWield = 118,
			// Token: 0x04000D98 RID: 3480
			TaurenRacial = 124,
			// Token: 0x04000D99 RID: 3481
			OrcRacial,
			// Token: 0x04000D9A RID: 3482
			NightElfRacial,
			// Token: 0x04000D9B RID: 3483
			FeralCombat = 134,
			// Token: 0x04000D9C RID: 3484
			Staves = 136,
			// Token: 0x04000D9D RID: 3485
			LanguageThalassian,
			// Token: 0x04000D9E RID: 3486
			LanguageDraconic,
			// Token: 0x04000D9F RID: 3487
			LanguageDemonTongue,
			// Token: 0x04000DA0 RID: 3488
			LanguageTitan,
			// Token: 0x04000DA1 RID: 3489
			LanguageOldTongue,
			// Token: 0x04000DA2 RID: 3490
			Survival,
			// Token: 0x04000DA3 RID: 3491
			HorseRiding = 148,
			// Token: 0x04000DA4 RID: 3492
			WolfRiding,
			// Token: 0x04000DA5 RID: 3493
			TigerRiding,
			// Token: 0x04000DA6 RID: 3494
			RamRiding = 152,
			// Token: 0x04000DA7 RID: 3495
			Swimming = 155,
			// Token: 0x04000DA8 RID: 3496
			TwoHandedMaces = 160,
			// Token: 0x04000DA9 RID: 3497
			Unarmed = 162,
			// Token: 0x04000DAA RID: 3498
			Marksmanship,
			// Token: 0x04000DAB RID: 3499
			Blacksmithing,
			// Token: 0x04000DAC RID: 3500
			TwoHandedAxes = 172,
			// Token: 0x04000DAD RID: 3501
			Daggers,
			// Token: 0x04000DAE RID: 3502
			Thrown = 176,
			// Token: 0x04000DAF RID: 3503
			Retribution = 184,
			// Token: 0x04000DB0 RID: 3504
			PetImp = 188,
			// Token: 0x04000DB1 RID: 3505
			PetFelhunter,
			// Token: 0x04000DB2 RID: 3506
			Engineering = 202,
			// Token: 0x04000DB3 RID: 3507
			PetSpider,
			// Token: 0x04000DB4 RID: 3508
			PetVoidwalker,
			// Token: 0x04000DB5 RID: 3509
			PetSuccubus,
			// Token: 0x04000DB6 RID: 3510
			PetInfernal,
			// Token: 0x04000DB7 RID: 3511
			PetDoomguard,
			// Token: 0x04000DB8 RID: 3512
			PetWolf,
			// Token: 0x04000DB9 RID: 3513
			PetCat,
			// Token: 0x04000DBA RID: 3514
			PetBear,
			// Token: 0x04000DBB RID: 3515
			PetBoar,
			// Token: 0x04000DBC RID: 3516
			PetCrocolisk,
			// Token: 0x04000DBD RID: 3517
			PetCarrionBird,
			// Token: 0x04000DBE RID: 3518
			PetCrab,
			// Token: 0x04000DBF RID: 3519
			PetGorilla,
			// Token: 0x04000DC0 RID: 3520
			PetRaptor = 217,
			// Token: 0x04000DC1 RID: 3521
			PetTallstrider,
			// Token: 0x04000DC2 RID: 3522
			RacialUndead = 220,
			// Token: 0x04000DC3 RID: 3523
			Crossbows = 226,
			// Token: 0x04000DC4 RID: 3524
			Wands = 228,
			// Token: 0x04000DC5 RID: 3525
			Polearms,
			// Token: 0x04000DC6 RID: 3526
			PetScorpid = 236,
			// Token: 0x04000DC7 RID: 3527
			Arcane,
			// Token: 0x04000DC8 RID: 3528
			PetTurtle = 251,
			// Token: 0x04000DC9 RID: 3529
			Assassination = 253,
			// Token: 0x04000DCA RID: 3530
			Fury = 256,
			// Token: 0x04000DCB RID: 3531
			Protection,
			// Token: 0x04000DCC RID: 3532
			Protection2 = 267,
			// Token: 0x04000DCD RID: 3533
			PetGenericHunter = 270,
			// Token: 0x04000DCE RID: 3534
			PlateMail = 293,
			// Token: 0x04000DCF RID: 3535
			LanguageGnomish = 313,
			// Token: 0x04000DD0 RID: 3536
			LanguageTroll = 315,
			// Token: 0x04000DD1 RID: 3537
			Demonology = 354,
			// Token: 0x04000DD2 RID: 3538
			Affliction,
			// Token: 0x04000DD3 RID: 3539
			Enhancement = 373,
			// Token: 0x04000DD4 RID: 3540
			ShamanRestoration,
			// Token: 0x04000DD5 RID: 3541
			ElementalCombat,
			// Token: 0x04000DD6 RID: 3542
			Mail = 413,
			// Token: 0x04000DD7 RID: 3543
			Leather,
			// Token: 0x04000DD8 RID: 3544
			Cloth,
			// Token: 0x04000DD9 RID: 3545
			Shield = 433,
			// Token: 0x04000DDA RID: 3546
			FistWeapons = 473,
			// Token: 0x04000DDB RID: 3547
			RaptorRiding = 533,
			// Token: 0x04000DDC RID: 3548
			MechanostriderPiloting = 553,
			// Token: 0x04000DDD RID: 3549
			UndeadHorsemanship,
			// Token: 0x04000DDE RID: 3550
			Restoration = 573,
			// Token: 0x04000DDF RID: 3551
			Balance,
			// Token: 0x04000DE0 RID: 3552
			Destruction = 593,
			// Token: 0x04000DE1 RID: 3553
			DruidHoly,
			// Token: 0x04000DE2 RID: 3554
			Discipline = 613,
			// Token: 0x04000DE3 RID: 3555
			Lockpicking = 633,
			// Token: 0x04000DE4 RID: 3556
			PetBat = 653,
			// Token: 0x04000DE5 RID: 3557
			PetHyena,
			// Token: 0x04000DE6 RID: 3558
			PetBirdofPrey,
			// Token: 0x04000DE7 RID: 3559
			PetWindSerpent,
			// Token: 0x04000DE8 RID: 3560
			LanguageGutterspeak = 673,
			// Token: 0x04000DE9 RID: 3561
			KodoRiding = 713,
			// Token: 0x04000DEA RID: 3562
			RacialTroll = 733,
			// Token: 0x04000DEB RID: 3563
			RacialGnome = 753,
			// Token: 0x04000DEC RID: 3564
			RacialHuman,
			// Token: 0x04000DED RID: 3565
			BloodElfRacial = 756,
			// Token: 0x04000DEE RID: 3566
			PetEventRemoteControl = 758,
			// Token: 0x04000DEF RID: 3567
			LanguageDraenei,
			// Token: 0x04000DF0 RID: 3568
			DraeneiRacial,
			// Token: 0x04000DF1 RID: 3569
			PetFelguard,
			// Token: 0x04000DF2 RID: 3570
			Riding,
			// Token: 0x04000DF3 RID: 3571
			PetDragonhawk,
			// Token: 0x04000DF4 RID: 3572
			PetNetherRay,
			// Token: 0x04000DF5 RID: 3573
			PetSporebat,
			// Token: 0x04000DF6 RID: 3574
			PetWarpStalker,
			// Token: 0x04000DF7 RID: 3575
			PetRavager,
			// Token: 0x04000DF8 RID: 3576
			PetSerpent,
			// Token: 0x04000DF9 RID: 3577
			Internal,
			// Token: 0x04000DFA RID: 3578
			DkBlood,
			// Token: 0x04000DFB RID: 3579
			DkFrost,
			// Token: 0x04000DFC RID: 3580
			DkUnholy,
			// Token: 0x04000DFD RID: 3581
			PetMoth = 775,
			// Token: 0x04000DFE RID: 3582
			Runeforging,
			// Token: 0x04000DFF RID: 3583
			Mounts,
			// Token: 0x04000E00 RID: 3584
			Companions,
			// Token: 0x04000E01 RID: 3585
			PetExoticChimaera = 780,
			// Token: 0x04000E02 RID: 3586
			PetExoticDevlisaur,
			// Token: 0x04000E03 RID: 3587
			PetGhoul,
			// Token: 0x04000E04 RID: 3588
			PetExoticSilithid,
			// Token: 0x04000E05 RID: 3589
			PetExoticWorm,
			// Token: 0x04000E06 RID: 3590
			PetWasp,
			// Token: 0x04000E07 RID: 3591
			PetExoticRhino,
			// Token: 0x04000E08 RID: 3592
			PetExoticCoreHound,
			// Token: 0x04000E09 RID: 3593
			PetExoticSpiritBeast,
			// Token: 0x04000E0A RID: 3594
			RacialWorgen,
			// Token: 0x04000E0B RID: 3595
			RacialGoblin,
			// Token: 0x04000E0C RID: 3596
			LanguageGilnean,
			// Token: 0x04000E0D RID: 3597
			LanguageGoblin,
			// Token: 0x04000E0E RID: 3598
			HunterGeneral = 795,
			// Token: 0x04000E0F RID: 3599
			DeathKnightGeneral,
			// Token: 0x04000E10 RID: 3600
			RogueGeneral,
			// Token: 0x04000E11 RID: 3601
			DruidGeneral,
			// Token: 0x04000E12 RID: 3602
			MageGeneral,
			// Token: 0x04000E13 RID: 3603
			PaladinGeneral,
			// Token: 0x04000E14 RID: 3604
			ShamanGeneral,
			// Token: 0x04000E15 RID: 3605
			WarlockGeneral,
			// Token: 0x04000E16 RID: 3606
			WarriorGeneral,
			// Token: 0x04000E17 RID: 3607
			PriestGeneral,
			// Token: 0x04000E18 RID: 3608
			PetWaterElemental,
			// Token: 0x04000E19 RID: 3609
			PetFox = 808,
			// Token: 0x04000E1A RID: 3610
			AllGlyphs = 810,
			// Token: 0x04000E1B RID: 3611
			PetDog,
			// Token: 0x04000E1C RID: 3612
			Monkey = 815,
			// Token: 0x04000E1D RID: 3613
			ShaleSpider = 817,
			// Token: 0x04000E1E RID: 3614
			Beetle
		}

		// Token: 0x0200012B RID: 299
		public enum ChatTypes
		{
			// Token: 0x04000E20 RID: 3616
			Say,
			// Token: 0x04000E21 RID: 3617
			Group,
			// Token: 0x04000E22 RID: 3618
			Guild = 3,
			// Token: 0x04000E23 RID: 3619
			Yell = 5,
			// Token: 0x04000E24 RID: 3620
			Whisper,
			// Token: 0x04000E25 RID: 3621
			Channel = 14
		}
	}
}
