using System;

namespace KartRider_TrackName
{
	public enum TrackName : uint
	{
		allRandom = 0,
		leagueRandom = 1,
		hot1Random = 3,
		hot2Random = 4,
		hot3Random = 5,
		hot4Random = 6,
		hot5Random = 7,
		newRandom = 8,
		reverseRandom = 30,
		newLeagueRandom = 33,
		speedAllRandom = 40,

		village_C01 = 879756263,
		village_R01 = 885654518,
		village_R02 = 885785591,
		village_R03 = 885916664,
		village_R04 = 886047737,
		village_R05 = 886178810,
		village_R06 = 886309883,
		village_R07 = 886440956,
		village_R08 = 886572029,
		village_R09 = 886703102,
		village_R10 = 885785590,
		village_R11 = 885916663,
		village_R12 = 886047736,
		village_R13 = 886178809,
		village_R14 = 886309882,
		village_I01 = 882115565,
		village_I02 = 882246638,
		village_I03 = 882377711,
		village_I04 = 882508784,
		village_I05 = 882639857,
		village_I06 = 882770930,
		village_I07 = 882902003,
		village_I08 = 883033076,
		village_I10 = 882246637,
		village_I11 = 882377710,
		village_I12 = 882508783,
		village_I13 = 882639856,
		village_I14 = 882770929,
		village_I15 = 882902002,
		forest_R02 = 744489894,
		forest_R03 = 744620967,
		forest_R04 = 744752040,
		forest_R05 = 744883113,
		forest_R06 = 745014186,
		forest_R07 = 745145259,
		forest_I01 = 740819868,
		forest_I02 = 740950941,
		forest_I03 = 741082014,
		forest_I04 = 741213087,
		forest_I05 = 741344160,
		forest_I06 = 741475233,
		forest_I07 = 741606306,
		forest_I08 = 741737379,
		forest_I09 = 741868452,
		forest_I10 = 740950940,
		desert_R01 = 730203033,
		desert_R02 = 730334106,
		desert_R03 = 730465179,
		desert_R04 = 730596252,
		desert_R05 = 730727325,
		desert_R06 = 730858398,
		desert_I01 = 726664080,
		desert_I02 = 726795153,
		desert_I03 = 726926226,
		desert_I04 = 727057299,
		desert_I05 = 727188372,
		desert_I06 = 727319445,
		desert_I07 = 727450518,
		desert_I08 = 727581591,
		desert_I09 = 727712664,
		desert_I10 = 726795152,
		desert_I11 = 726926225,
		ice_R01 = 341443139,
		ice_R02 = 341574212,
		ice_R03 = 341705285,
		ice_R04 = 341836358,
		ice_R05 = 341967431,
		ice_I01 = 337904186,
		ice_I02 = 338035259,
		ice_I03 = 338166332,
		ice_I04 = 338297405,
		ice_I05 = 338428478,
		ice_I06 = 338559551,
		ice_I07 = 338690624,
		ice_I08 = 338821697,
		mine_C04 = 458883759,
		mine_R01 = 464388795,
		mine_R02 = 464519868,
		mine_R03 = 464650941,
		mine_R04 = 464782014,
		mine_R05 = 464913087,
		mine_I01 = 460849842,
		mine_I02 = 460980915,
		mine_I03 = 461111988,
		mine_I04 = 461243061,
		mine_I05 = 461374134,
  		mine_I06 = 461505207,
		tomb_R01 = 474481348,
		tomb_R02 = 474612421,
		tomb_R03 = 474743494,
		tomb_R04 = 474874567,
		tomb_I01 = 470942395,
		tomb_I02 = 471073468,
		tomb_I03 = 471204541,
		tomb_I04 = 471335614,
		tomb_I05 = 471466687,
		tomb_I06 = 471597760,
		tomb_I07 = 471728833,
		northeu_R01 = 912786455,
		northeu_R02 = 912917528,
		northeu_R03 = 913048601,
		northeu_I01 = 909247502,
		northeu_I02 = 909378575,
		northeu_I03 = 909509648,
		northeu_I04 = 909640721,
		northeu_I05 = 909771794,
		northeu_I06 = 909902867,
		northeu_I07 = 910033940,
		northeu_I08 = 910165013,
		northeu_I09 = 910296086,
		factory_R01 = 884474890,
		factory_R02 = 884605963,
		factory_R03 = 884737036,
		factory_I01 = 880935937,
		factory_I02 = 881067010,
		factory_I03 = 881198083,
		factory_I04 = 881329156,
		factory_I05 = 881460229,
		factory_I06 = 881591302,
		factory_I07 = 881722375,
		factory_I08 = 881853448,
		pirate_R01 = 737674135,
		pirate_R02 = 737805208,
		pirate_R03 = 737936281,
		pirate_R04 = 738067354,
		pirate_R05 = 738198427,
		pirate_I01 = 734135182,
		pirate_I02 = 734266255,
		pirate_I03 = 734397328,
		pirate_I04 = 734528401,
		pirate_I05 = 734659474,
		fairy_R01 = 588383021,
		fairy_R02 = 588514094,
		fairy_R03 = 588645167,
		fairy_I01 = 584844068,
		fairy_I02 = 584975141,
		fairy_I03 = 585106214,
		fairy_I04 = 585237287,
		fairy_I05 = 585368360,
		fairy_I06 = 585499433,
		moonhill_R01 = 1068893300,
		moonhill_R02 = 1069024373,
		moonhill_R04 = 1069286519,
		moonhill_R05 = 1069417592,
		moonhill_I01 = 1065354347,
		moonhill_I02 = 1065485420,
		moonhill_I03 = 1065616493,
		moonhill_I04 = 1065747566,
		moonhill_I05 = 1065878639,
		moonhill_I06 = 1066009712,
		gold_R01 = 461374136,
		gold_R02 = 461505209,
		gold_R03 = 461636282,
		gold_I01 = 457835183,
		gold_I02 = 457966256,
		gold_I03 = 458097329,
		gold_I04 = 458228402,
		gold_I05 = 458359475,
		gold_I06 = 458490548,
		china_C01 = 567411462,
		china_R01 = 573309717,
		china_R02 = 573440790,
		china_R03 = 573571863,
		china_R04 = 573702936,
		china_R05 = 573834009,
		china_R06 = 573965082,
		china_R07 = 574096155,
		china_R08 = 574227228,
		china_R09 = 574358301,
		china_R10 = 573440789,
		china_R11 = 573571862,
		china_R12 = 573702935,
		china_I01 = 569770764,
		china_I02 = 569901837,
		china_I03 = 570032910,
		china_I04 = 570163983,
		china_I05 = 570295056,
		china_I06 = 570426129,
		china_I07 = 570557202,
		china_I08 = 570688275,
		china_I09 = 570819348,
		china_I10 = 569901836,
		china_I11 = 570032909,
		china_I12 = 570163982,
		castle_R01 = 723387278,
		castle_I01 = 719848325,
		castle_I02 = 719979398,
		castle_I03 = 720110471,
		castle_I04 = 720241544,
		castle_I05 = 720372617,
		castle_I06 = 720503690,
		castle_R02 = 723518351,
		nymph_R01 = 613942078,
		nymph_R02 = 614073151,
		nymph_I01 = 610403125,
		nymph_I02 = 610534198,
		nymph_I03 = 610665271,
		nymph_I04 = 610796344,
		nymph_I05 = 610927417,
		mechanic_R01 = 1020658762,
		mechanic_I01 = 1017119809,
		mechanic_I02 = 1017250882,
		xyy_R01 = 385614460,
		xyy_R02 = 385745533,
		xyy_I01 = 382075507,
		wkc_R01 = 359268951,
		wkc_R02 = 359400024,
		wkc_R03 = 359531097,
		wkc_R04 = 359662170,
		wkc_R05 = 359793243,
		wkc_R06 = 359924316,
		wkc_R07 = 360055389,
		wkc_R09 = 360317535,
		wkc_R11 = 359531096,
  		wkc_R12 = 359662169,
		wkc_I01 = 355729998,
		wkc_I02 = 355861071,
		brodi_R01 = 585499426,
		brodi_R02 = 585630499,
		brodi_I01 = 581960473,
		brodi_I02 = 582091546,
		park_R01 = 467272384,
		park_R02 = 467403457,
		park_I01 = 463733431,
		pirate_C001 = 856425400,
		beach_R01 = 557581061,
		beach_R02 = 557712134,
		beach_R03 = 557843207,
		beach_R04 = 557974280,
		beach_I01 = 554042108,
		beach_I02 = 554173181,
		beach_I03 = 554304254,
		steam_R01 = 598737708,
		steam_R02 = 598868781,
		steam_I01 = 595198755,
		transFormer_R01 = 1638794661,
		transFormer_R02 = 1638925734,
		transFormer_I01 = 1635255708,
		jurassic_R01 = 1073874038,
		jurassic_R03 = 1074136184,
		jurassic_R04 = 1074267257,
		jurassic_I01 = 1070335085,
		jurassic_I02 = 1070466158,
		world_C02 = 607126316,
		world_R01 = 612893498,
		world_R02 = 613024571,
		world_R03 = 613155644,
		world_R04 = 613286717,
		world_R05 = 613417790,
		world_R06 = 613548863,
		world_R10 = 613024570,
		world_I01 = 609354545,
		world_I02 = 609485618,
		world_I03 = 609616691,
		world_I04 = 609747764,
		world_I05 = 609878837,
		nemo_C02 = 461767347,
		nemo_R01 = 467534529,
		nemo_R02 = 467665602,
		nemo_R03 = 467796675,
		nemo_I01 = 463995576,
		nemo_I02 = 464126649,
		nemo_I03 = 464257722,
		sword_R01 = 618529601,
		sword_R02 = 618660674,
		sword_R03 = 618791747,
		sword_I01 = 614990648,
		sword_I02 = 615121721,
		god_R01 = 348389964,
		god_R02 = 348521037,
		god_R03 = 348652110,
		god_I01 = 344851011,
		god_I02 = 344982084,
		god_I03 = 345113157,
		abyss_R01 = 595067700,
		abyss_R02 = 595198773,
		abyss_R03 = 595329846,
		abyss_R04 = 595460919,
		abyss_R05 = 595591992,
		abyss_I01 = 591528747,
		abyss_I02 = 591659820,
		abyss_I03 = 591790893,
		camelot_I01 = 864289774,
		camelot_I02 = 864420847,
		camelot_I03 = 864551920,
		camelot_R01 = 867828727,
		camelot_R02 = 867959800,
		camelot_R03 = 868090873,
		olympos_I01 = 921568284,
		olympos_I02 = 921699357,
		olympos_I03 = 921830430,
		olympos_R01 = 925107237,
		olympos_R02 = 925238310,
		korea_I01 = 587727643,
		korea_I02 = 587858716,
		korea_I03 = 587989789,
		korea_I04 = 588120862,
		korea_I05 = 588251935,
		korea_R01 = 591266596,
		korea_R02 = 591397669,
		korea_R03 = 591528742,
		korea_R04 = 591659815,
		korea_S01 = 591659813,
		korea_S02 = 591790886,
		mabi_I01 = 446694050,
		mabi_I02 = 446825123,
		mabi_R01 = 450233003,
		mabi_R02 = 450364076,
		maple_R01 = 585237281,
		maple_R02 = 585368354,
		maple_R03 = 585499427,
		maple_I01 = 581698328,
		maple_I02 = 581829401,
		maple_I03 = 581960474,

		village_R01_rvs = 1557923248,
		village_R03_rvs = 1559233970,
		village_I01_rvs = 1549665703,
		village_I02_rvs = 1550321064,
		village_I03_rvs = 1550976425,
		village_I04_rvs = 1551631786,
		village_I05_rvs = 1552287147,
		village_I13_rvs = 1551762858,
		forest_R02_rvs = 1374815584,
		forest_I01_rvs = 1365902678,
		forest_I02_rvs = 1366558039,
		forest_I03_rvs = 1367213400,
		forest_I04_rvs = 1367868761,
		forest_I05_rvs = 1368524122,
		forest_I07_rvs = 1369834844,
		desert_R01_rvs = 1353712979,
		desert_I01_rvs = 1345455434,
		desert_I02_rvs = 1346110795,
		desert_I03_rvs = 1346766156,
		desert_I04_rvs = 1347421517,
		desert_I05_rvs = 1348076878,
		ice_I01_rvs = 777389044,
		ice_I02_rvs = 778044405,
		ice_I03_rvs = 778699766,
		ice_I04_rvs = 779355127,
		ice_I05_rvs = 780010488,
		mine_I01_rvs = 963249260,
		mine_I02_rvs = 963904621,
		tomb_R01_rvs = 986317950,
		tomb_I01_rvs = 978060405,
		northeu_I01_rvs = 1594099144,
		northeu_I02_rvs = 1594754505,
		northeu_I03_rvs = 1595409866,
		northeu_I04_rvs = 1596065227,
		northeu_I05_rvs = 1596720588,
		northeu_I06_rvs = 1597375949,
		northeu_I07_rvs = 1598031310,
		factory_I01_rvs = 1558971835,
		factory_I02_rvs = 1559627196,
		factory_I03_rvs = 1560282557,
		factory_I04_rvs = 1560937918,
		pirate_R01_rvs = 1360135505,
		pirate_I01_rvs = 1351877960,
		pirate_I02_rvs = 1352533321,
		pirate_I04_rvs = 1353844043,
		fairy_I02_rvs = 1147667679,
		fairy_I03_rvs = 1148323040,
		moonhill_R01_rvs = 1807222318,
		moonhill_I01_rvs = 1798964773,
		moonhill_I04_rvs = 1800930856,
		china_R01_rvs = 1127613647,
		china_R02_rvs = 1128269008,
		china_R03_rvs = 1128924369,
		china_R07_rvs = 1131545813,
		china_I01_rvs = 1119356102,
		china_I04_rvs = 1121322185,
		abyss_R02_rvs = 1166279919,
		korea_I01_rvs = 1145177301,
		korea_I03_rvs = 1146488023,
		korea_R01_rvs = 1153434846,
		korea_R02_rvs = 1154090207,
		korea_R03_rvs = 1154745568,
		mabi_I01_rvs = 940704860,
		mabi_R01_rvs = 948962405,

		village_F01 = 880935914,
		desert_F01 = 725484429,
		tomb_F01 = 469762744,
		forest_F01 = 739640217,
		ice_F01 = 336724535,
		sword_F01 = 613810997,
		factory_D01 = 878969852,
		god_D01 = 342884926,
		northeu_D01 = 907281417,
		ice_D01 = 335938101,
		wkc_D01 = 353763913,
		village_B01 = 879363046,
		village_B02 = 879494119,
		village_B03 = 879625192,
		village_B04 = 879756265,
		tomb_B01 = 468189876,
		ice_B01 = 335151667,
		forest_B01 = 738067349,
		forest_B02 = 738198422,
		mechanic_K01 = 1017906243,
		mechanic_K02 = 1018037316,
		mechanic_K03 = 1018168389,

		village_I04_crz = 1545602462,
		forest_I03_crz = 1361184076,
		ice_I03_crz = 772670442,
		hina_I02_crz = 1113982139,
		factory_I04_crz = 1554908594,
		desert_I03_crz = 1340736832,
		beach_I02_crz = 1089864875,
		world_I03_crz = 1173619937,
		gold_I03_crz = 953943135,
	}
}
