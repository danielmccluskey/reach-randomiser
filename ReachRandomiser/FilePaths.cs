using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ReachTesting
{
    public static class FilePathsForReach
    {
        public static List<string> LevelNames = new List<string>()
        {
            "m10",
            "m20",
            "m30",
            "m35",
            "m45",
            "m50",
            "m52",
            "m60",
            "m70",
            "m70_bonus",

        };
        public static List<string> SquadTemplates = new List<string>()
        {
            @"ai\squad_templates\sq_camp_banshee_1",
            @"ai\squad_templates\sq_camp_banshee_2",
            @"ai\squad_templates\sq_camp_banshee_3",
            @"ai\squad_templates\sq_camp_banshee_air_1",
            @"ai\squad_templates\sq_camp_banshee_air_2",
            @"ai\squad_templates\sq_camp_banshee_air_3",
            @"ai\squad_templates\sq_camp_brute_1",
            @"ai\squad_templates\sq_camp_brute_2",
            @"ai\squad_templates\sq_camp_brute_3",
            @"ai\squad_templates\sq_camp_brute_captain_1",
            @"ai\squad_templates\sq_camp_brute_captain_2",
            @"ai\squad_templates\sq_camp_brute_captain_3",
            @"ai\squad_templates\sq_camp_bugger_1",
            @"ai\squad_templates\sq_camp_bugger_4",
            @"ai\squad_templates\sq_camp_cov_bc1_g3",
            @"ai\squad_templates\sq_camp_cov_bc1_j3",
            @"ai\squad_templates\sq_camp_cov_e1_g2",
            @"ai\squad_templates\sq_camp_cov_e1_g3",
            @"ai\squad_templates\sq_camp_cov_e1_g3_j2",
            @"ai\squad_templates\sq_camp_cov_e1_g4",
            @"ai\squad_templates\sq_camp_cov_e1_j2",
            @"ai\squad_templates\sq_camp_cov_e1_j3",
            @"ai\squad_templates\sq_camp_cov_e1_s2",
            @"ai\squad_templates\sq_camp_cov_e1_s3",
            @"ai\squad_templates\sq_camp_cov_e1_s4",
            @"ai\squad_templates\sq_camp_cov_e2_j2",
            @"ai\squad_templates\sq_camp_cov_e3_g3",
            @"ai\squad_templates\sq_camp_cov_g2_j1",
            @"ai\squad_templates\sq_camp_cov_g3_j1",
            @"ai\squad_templates\sq_camp_cov_g3_j2",
            @"ai\squad_templates\sq_camp_cov_js1_j3",
            @"ai\squad_templates\sq_camp_elite_1",
            @"ai\squad_templates\sq_camp_elite_2",
            @"ai\squad_templates\sq_camp_elite_3",
            @"ai\squad_templates\sq_camp_elite_bob_1",
            @"ai\squad_templates\sq_camp_elite_general_1",
            @"ai\squad_templates\sq_camp_elite_jetpack_1",
            @"ai\squad_templates\sq_camp_elite_jetpack_2",
            @"ai\squad_templates\sq_camp_elite_jetpack_3",
            @"ai\squad_templates\sq_camp_elite_jetpack_4",
            @"ai\squad_templates\sq_camp_elite_minor_1",
            @"ai\squad_templates\sq_camp_elite_minor_2",
            @"ai\squad_templates\sq_camp_elite_minor_3",
            @"ai\squad_templates\sq_camp_elite_officer_1",
            @"ai\squad_templates\sq_camp_elite_ultra_1",
            @"ai\squad_templates\sq_camp_engineer_1",
            @"ai\squad_templates\sq_camp_ghost_1",
            @"ai\squad_templates\sq_camp_ghost_2",
            @"ai\squad_templates\sq_camp_ghost_elite_1",
            @"ai\squad_templates\sq_camp_ghost_elite_2",
            @"ai\squad_templates\sq_camp_ghost_grunt_1",
            @"ai\squad_templates\sq_camp_ghost_grunt_2",
            @"ai\squad_templates\sq_camp_grunt_1",
            @"ai\squad_templates\sq_camp_grunt_2",
            @"ai\squad_templates\sq_camp_grunt_3",
            @"ai\squad_templates\sq_camp_grunt_4",
            @"ai\squad_templates\sq_camp_grunt_fc_1",
            @"ai\squad_templates\sq_camp_grunt_fc_2",
            @"ai\squad_templates\sq_camp_hunters",
            @"ai\squad_templates\sq_camp_hunter_solo",
            @"ai\squad_templates\sq_camp_jackalsniper_nr_1",
            @"ai\squad_templates\sq_camp_jackalsniper_nr_2",
            @"ai\squad_templates\sq_camp_jackalsniper_nr_3",
            @"ai\squad_templates\sq_camp_jackalsniper_nr_4",
            @"ai\squad_templates\sq_camp_jackalsniper_sr_1",
            @"ai\squad_templates\sq_camp_jackalsniper_sr_2",
            @"ai\squad_templates\sq_camp_jackal_1",
            @"ai\squad_templates\sq_camp_jackal_2",
            @"ai\squad_templates\sq_camp_jackal_3",
            @"ai\squad_templates\sq_camp_jackal_4",
            @"ai\squad_templates\sq_camp_revenant",
            @"ai\squad_templates\sq_camp_shade",
            @"ai\squad_templates\sq_camp_shade_anti_air",
            @"ai\squad_templates\sq_camp_shade_flak",
            @"ai\squad_templates\sq_camp_skirmisher_closerange_4",
            @"ai\squad_templates\sq_camp_skirmisher_ne_1",
            @"ai\squad_templates\sq_camp_skirmisher_ne_2",
            @"ai\squad_templates\sq_camp_skirmisher_ne_3",
            @"ai\squad_templates\sq_camp_skirmisher_ne_4",
            @"ai\squad_templates\sq_camp_skirmisher_nr_1",
            @"ai\squad_templates\sq_camp_skirmisher_nr_2",
            @"ai\squad_templates\sq_camp_skirmisher_nr_3",
            @"ai\squad_templates\sq_camp_skirmisher_nr_4",
            @"ai\squad_templates\sq_camp_skirmisher_pp_1",
            @"ai\squad_templates\sq_camp_skirmisher_pp_2",
            @"ai\squad_templates\sq_camp_skirmisher_pp_3",
            @"ai\squad_templates\sq_camp_skirmisher_pp_4",
            @"ai\squad_templates\sq_camp_skirmisher_sr_1",
            @"ai\squad_templates\sq_camp_skirmisher_sr_2",
            @"ai\squad_templates\sq_camp_wraith",
        };

        public class WeaponDetails
        {
            public string Name { get; set; }
            public string Path { get; set; }
            public int AmmoMag { get; set; } = 0;
            public int AmmoTotal {get; set;} = 0;

            public int PaletteIndex { get; set; } = -1;

            public List<EnemyObjectPaths> CompatibleEnemies { get; set; } = new List<EnemyObjectPaths>();
        }

        public class EquipmentDetails
        {
            public string Name { get; set; }
            public string Path { get; set; }

            public int PaletteIndex { get; set; } = -1;
        }

        public class EnemyObjectPaths
        {
            public string Name { get; set; }
            public string Path { get; set; }
            public int PaletteIndex { get; set; } = -1;
        }

        public class VehicleObjectPaths
        {
            public string Name { get; set; }
            public string Path { get; set; }
            public int PaletteIndex { get; set; } = -1;
        }
        public class VariantList
        {
            public string Name { get; set; }
            public string Path { get; set; }
            public List<string> Variants{ get; set; } 
            public int PaletteIndex { get; set; } = -1;
        }
        public static List<EnemyObjectPaths> enemyObjectPaths = new List<EnemyObjectPaths>()
        {
            new EnemyObjectPaths{Name = "mule", Path =  @"objects\characters\mule\ai\mule"},
            new EnemyObjectPaths{Name = "brute", Path =  @"objects\characters\brute\ai\brute"},
            new EnemyObjectPaths{Name = "brute_captain", Path =   @"objects\characters\brute\ai\brute_captain"},
            new EnemyObjectPaths{Name = "brute_chieftain_armor",  Path =  @"objects\characters\brute\ai\brute_chieftain_armor"},
            new EnemyObjectPaths{Name = "brute_chieftain_weapon", Path =   @"objects\characters\brute\ai\brute_chieftain_weapon"},
            new EnemyObjectPaths{Name = "grunt", Path = @"objects\characters\grunt\ai\grunt"},
            new EnemyObjectPaths{Name = "grunt_heavy", Path =   @"objects\characters\grunt\ai\grunt_heavy"},
            new EnemyObjectPaths{Name = "grunt_major", Path =   @"objects\characters\grunt\ai\grunt_major"},
            new EnemyObjectPaths{Name = "grunt_specops", Path =   @"objects\characters\grunt\ai\grunt_specops"},
            new EnemyObjectPaths{Name = "grunt_ultra", Path =   @"objects\characters\grunt\ai\grunt_ultra"},
            new EnemyObjectPaths{Name = "jackal", Path =   @"objects\characters\jackal\ai\jackal"},
            new EnemyObjectPaths{Name = "jackal_major", Path =   @"objects\characters\jackal\ai\jackal_major"},
            new EnemyObjectPaths{Name = "skirmisher", Path =   @"objects\characters\jackal\ai\skirmisher"},
            new EnemyObjectPaths{Name = "skirmisher_champion", Path =   @"objects\characters\jackal\ai\skirmisher_champion"},
            new EnemyObjectPaths{Name = "skirmisher_commando", Path =   @"objects\characters\jackal\ai\skirmisher_commando"},
            new EnemyObjectPaths{Name = "skirmisher_major", Path =   @"objects\characters\jackal\ai\skirmisher_major"},
            new EnemyObjectPaths{Name = "skirmisher_murmillone", Path =   @"objects\characters\jackal\ai\skirmisher_murmillone"},
            new EnemyObjectPaths{Name = "elite", Path =   @"objects\characters\elite\ai\elite"},
            new EnemyObjectPaths{Name = "elite_general", Path =   @"objects\characters\elite\ai\elite_general"},
            new EnemyObjectPaths{Name = "elite_jetpack",  Path =  @"objects\characters\elite\ai\elite_jetpack"},
            new EnemyObjectPaths{Name = "elite_officer", Path =   @"objects\characters\elite\ai\elite_officer"},
            new EnemyObjectPaths{Name = "elite_specops", Path =   @"objects\characters\elite\ai\elite_specops"},
            new EnemyObjectPaths{Name = "elite_story", Path =   @"objects\characters\elite\ai\elite_story"},
            new EnemyObjectPaths{Name = "elite_story_unique", Path =   @"objects\characters\elite\ai\elite_story_unique"},
            new EnemyObjectPaths{Name = "elite_ultra", Path =   @"objects\characters\elite\ai\elite_ultra"},
            new EnemyObjectPaths{Name = "hunter", Path =   @"objects\characters\hunter\ai\hunter"},
            new EnemyObjectPaths{Name = "engineer",  Path =  @"objects\characters\engineer\ai\engineer"},
            new EnemyObjectPaths{Name = "bugger",  Path =  @"objects\characters\bugger\ai\bugger"},
            new EnemyObjectPaths{Name = "bugger_captain", Path =   @"objects\characters\bugger\ai\bugger_captain"},
            new EnemyObjectPaths{Name = "bugger_captain_major", Path =   @"objects\characters\bugger\ai\bugger_captain_major"},
            new EnemyObjectPaths{Name = "bugger_major",  Path =  @"objects\characters\bugger\ai\bugger_major"},
            new EnemyObjectPaths{Name = "bugger_ultra",  Path =  @"objects\characters\bugger\ai\bugger_ultra"},
        };

        public static List<EnemyObjectPaths> ghostenemyObjectPaths = new List<EnemyObjectPaths>()
        {
            new EnemyObjectPaths{Name = "grunt", Path = @"objects\characters\grunt\ai\grunt"},
            new EnemyObjectPaths{Name = "grunt_heavy", Path =   @"objects\characters\grunt\ai\grunt_heavy"},
            new EnemyObjectPaths{Name = "grunt_major", Path =   @"objects\characters\grunt\ai\grunt_major"},
            new EnemyObjectPaths{Name = "grunt_specops", Path =   @"objects\characters\grunt\ai\grunt_specops"},
            new EnemyObjectPaths{Name = "grunt_ultra", Path =   @"objects\characters\grunt\ai\grunt_ultra"},
            new EnemyObjectPaths{Name = "elite", Path =   @"objects\characters\elite\ai\elite"},
            new EnemyObjectPaths{Name = "elite_general", Path =   @"objects\characters\elite\ai\elite_general"},
            new EnemyObjectPaths{Name = "elite_jetpack",  Path =  @"objects\characters\elite\ai\elite_jetpack"},
            new EnemyObjectPaths{Name = "elite_officer", Path =   @"objects\characters\elite\ai\elite_officer"},
            new EnemyObjectPaths{Name = "elite_specops", Path =   @"objects\characters\elite\ai\elite_specops"},
            new EnemyObjectPaths{Name = "elite_story", Path =   @"objects\characters\elite\ai\elite_story"},
            new EnemyObjectPaths{Name = "elite_story_unique", Path =   @"objects\characters\elite\ai\elite_story_unique"},
            new EnemyObjectPaths{Name = "elite_ultra", Path =   @"objects\characters\elite\ai\elite_ultra"},
        };

        public static List<EnemyObjectPaths> wraithenemyObjectPaths = new List<EnemyObjectPaths>()
        {
            new EnemyObjectPaths{Name = "elite", Path =   @"objects\characters\elite\ai\elite"},
            new EnemyObjectPaths{Name = "elite_general", Path =   @"objects\characters\elite\ai\elite_general"},
            new EnemyObjectPaths{Name = "elite_jetpack",  Path =  @"objects\characters\elite\ai\elite_jetpack"},
            new EnemyObjectPaths{Name = "elite_officer", Path =   @"objects\characters\elite\ai\elite_officer"},
            new EnemyObjectPaths{Name = "elite_specops", Path =   @"objects\characters\elite\ai\elite_specops"},
            new EnemyObjectPaths{Name = "elite_story", Path =   @"objects\characters\elite\ai\elite_story"},
            new EnemyObjectPaths{Name = "elite_story_unique", Path =   @"objects\characters\elite\ai\elite_story_unique"},
            new EnemyObjectPaths{Name = "elite_ultra", Path =   @"objects\characters\elite\ai\elite_ultra"},
        };

        public static List<WeaponDetails> weapons = new List<WeaponDetails>()
        {
            new WeaponDetails{Name = "energy_sword", Path = @"objects\weapons\melee\energy_sword\energy_sword", CompatibleEnemies = enemyObjectPaths.Where(o => o.Name.Contains("elite")).ToList() },
            new WeaponDetails{Name = "gravity_hammer", Path = @"objects\weapons\melee\gravity_hammer\gravity_hammer", CompatibleEnemies = enemyObjectPaths.Where(o => o.Name.Contains("brute")).ToList() },
            //new WeaponDetails{Name = "jackal_shield", Path = @"objects\weapons\melee\jackal_shield\jackal_shield" },
            //new WeaponDetails{Name = "skirmisher_bracers", Path = @"objects\weapons\melee\skirmisher_bracers\skirmisher_bracers" },
            //new WeaponDetails{Name = "unarmed", Path = @"objects\weapons\melee\unarmed\unarmed", CompatibleEnemies = enemyObjectPaths.Where(o => o.Name.Contains("engineer")).ToList() },
            new WeaponDetails{Name = "magnum", Path = @"objects\weapons\pistol\magnum\magnum", AmmoMag = 8, AmmoTotal = 24, CompatibleEnemies = enemyObjectPaths.ToList() },
            new WeaponDetails{Name = "needler", Path = @"objects\weapons\pistol\needler\needler", AmmoMag = 24, AmmoTotal = 72, CompatibleEnemies = enemyObjectPaths.ToList()  },
            new WeaponDetails{Name = "plasma_pistol", Path = @"objects\weapons\pistol\plasma_pistol\plasma_pistol", CompatibleEnemies = enemyObjectPaths.ToList() },
            new WeaponDetails{Name = "assault_rifle", Path = @"objects\weapons\rifle\assault_rifle\assault_rifle", AmmoMag = 32, AmmoTotal = 160, CompatibleEnemies = enemyObjectPaths.ToList() },
            new WeaponDetails{Name = "concussion_rifle", Path = @"objects\weapons\rifle\concussion_rifle\concussion_rifle", AmmoMag = 6, AmmoTotal = 18, CompatibleEnemies = enemyObjectPaths.ToList() },
            new WeaponDetails{Name = "dmr", Path = @"objects\weapons\rifle\dmr\dmr", AmmoMag = 15, AmmoTotal = 45, CompatibleEnemies = enemyObjectPaths.ToList() },
            new WeaponDetails{Name = "focus_rifle", Path = @"objects\weapons\rifle\focus_rifle\focus_rifle", CompatibleEnemies = enemyObjectPaths.ToList() },
            new WeaponDetails{Name = "grenade_launcher", Path = @"objects\weapons\rifle\grenade_launcher\grenade_launcher", AmmoMag = 1, AmmoTotal = 16, CompatibleEnemies = enemyObjectPaths},
            new WeaponDetails{Name = "needle_rifle", Path = @"objects\weapons\rifle\needle_rifle\needle_rifle", AmmoMag = 21, AmmoTotal = 63, CompatibleEnemies = enemyObjectPaths.ToList() },
            new WeaponDetails{Name = "plasma_repeater", Path = @"objects\weapons\rifle\plasma_repeater\plasma_repeater", CompatibleEnemies = enemyObjectPaths.ToList() },
            new WeaponDetails{Name = "plasma_rifle", Path = @"objects\weapons\rifle\plasma_rifle\plasma_rifle", CompatibleEnemies = enemyObjectPaths.ToList() },//Jackals, grunts, elites, skirms
            new WeaponDetails{Name = "shotgun", Path = @"objects\weapons\rifle\shotgun\shotgun", AmmoMag = 6, AmmoTotal = 18, CompatibleEnemies = enemyObjectPaths.ToList() },
            new WeaponDetails{Name = "sniper_rifle", Path = @"objects\weapons\rifle\sniper_rifle\sniper_rifle", AmmoMag = 4, AmmoTotal = 12, CompatibleEnemies = enemyObjectPaths.ToList() },
            new WeaponDetails{Name = "spike_rifle", Path = @"objects\weapons\rifle\spike_rifle\spike_rifle", AmmoMag = 20, AmmoTotal = 120, CompatibleEnemies = enemyObjectPaths.ToList() },
            new WeaponDetails{Name = "flak_cannon", Path = @"objects\weapons\support_high\flak_cannon\flak_cannon", AmmoMag = 5, AmmoTotal = 20, CompatibleEnemies = enemyObjectPaths.ToList() }, //elites, brutes and grunts
            new WeaponDetails{Name = "plasma_launcher", Path = @"objects\weapons\support_high\plasma_launcher\plasma_launcher", CompatibleEnemies = enemyObjectPaths.ToList() },
            new WeaponDetails{Name = "rocket_launcher", Path = @"objects\weapons\support_high\rocket_launcher\rocket_launcher", AmmoMag = 2, AmmoTotal = 8, CompatibleEnemies = enemyObjectPaths.ToList() },
            new WeaponDetails{Name = "spartan_laser", Path = @"objects\weapons\support_high\spartan_laser\spartan_laser", CompatibleEnemies = enemyObjectPaths },
            new WeaponDetails{Name = "machinegun_turret_jorge", Path = @"objects\weapons\turret\machinegun_turret_jorge\machinegun_turret_jorge", AmmoMag = 200, AmmoTotal = 200, CompatibleEnemies = enemyObjectPaths.ToList() },
            new WeaponDetails{Name = "plasma_turret", Path = @"objects\vehicles\covenant\turrets\plasma_turret\weapon\plasma_turret\plasma_turret", AmmoMag = 200, AmmoTotal = 200, CompatibleEnemies = enemyObjectPaths.ToList() },
            new WeaponDetails{Name = "machinegun_turret", Path = @"objects\vehicles\human\turrets\machinegun\weapon\machinegun_turret\machinegun_turret", AmmoMag = 200, AmmoTotal = 200, CompatibleEnemies = enemyObjectPaths.ToList() },
        };

        public static List<EquipmentDetails> equipments = new List<EquipmentDetails>()
        {
            new EquipmentDetails{Name = "active_camo", Path = @"objects\equipment\active_camouflage\active_camouflage"},
            new EquipmentDetails{Name = "armor_lockup", Path = @"objects\equipment\armor_lockup\armor_lockup"},
            new EquipmentDetails{Name = "drop_shield", Path = @"objects\equipment\drop_shield\drop_shield"},
            new EquipmentDetails{Name = "evade", Path = @"objects\equipment\evade\evade"},
            new EquipmentDetails{Name = "hologram", Path = @"objects\equipment\hologram\hologram"},
            new EquipmentDetails{Name = "jet_pack", Path = @"objects\equipment\jet_pack\jet_pack"},
            new EquipmentDetails{Name = "sprint", Path = @"objects\equipment\sprint\sprint"},
        };

        public static List<VehicleObjectPaths> vehicleObjectPaths = new List<VehicleObjectPaths>()
        {
            new VehicleObjectPaths{Name = "banshee", Path =  @"objects\vehicles\covenant\banshee\banshee" },
            new VehicleObjectPaths{Name = "ghost",  Path = @"objects\vehicles\covenant\ghost\ghost" },
            new VehicleObjectPaths{Name = "revenant", Path =  @"objects\vehicles\covenant\revenant\revenant" },
            new VehicleObjectPaths{Name = "wraith",  Path = @"objects\vehicles\covenant\wraith\wraith" },
            new VehicleObjectPaths{Name = "falcon",  Path = @"objects\vehicles\human\falcon\falcon" },
            new VehicleObjectPaths{Name = "mongoose",  Path = @"objects\vehicles\human\mongoose\mongoose" },
            new VehicleObjectPaths{Name = "scorpion",  Path = @"objects\vehicles\human\scorpion\scorpion" },
            new VehicleObjectPaths{Name = "warthog",  Path = @"objects\vehicles\human\warthog\warthog" },
        };

        public static List<string> skipKeyWords = new List<string>()
        {
            "marine",
            "pelican",
            "space",
            "warthog",
            "falcon",
            "phantom",
            "seraph",
            "spirit",
            "dropship",
            "shade",
            "turret",
            "spartan",
            "trooper",
            "bfg",
            "aa",
            "hog",
            "carter",
            "emile",
            "jorge",
            "kat",
            "jun",
            "shade",
            "allies",
            "ally",
            "civilian",
            "human",
            "witness",
            "fork",
            "sq_court_cov_w1",
            "unsc",
            "crv_sbr",
            "crv_sph",
            "crv_ph",
            "crv_cannon",
            "crv_bsh",
            "seraph",
            "sabre",
            "waf_sbr",
            "waf_bsh",
            "waf_sph",
            "waf_ph",
            "sq_cov_bch_ds",
            "odst"


        };

        public static List<string> skipSpecialEnemySquads = new List<string>()
        {
            "3kiva03_cov_drop01a",
            "3kiva03_cov_drop01b",
            "3kiva03_cov_drop01c",
            "3kiva03_cov_drop02a",
            "3kiva03_cov_drop02b",
            "3kiva03_cov_drop02c",
            "3kiva03_cov_drop02a_coop",
            "3kiva02_cov_drop01a",
            "3kiva02_cov_drop01b",
            "3kiva02_cov_drop01c",
            "3kiva02_cov_drop02a",
            "3kiva02_cov_drop02b",
            "3kiva02_cov_drop02c",
            "3kiva02_cov_drop02a_coop",
            "atrium_cov_counter_inf0",
            "atrium_cov_counter_inf1",
            "atrium_cov_counter_inf2",
            "atrium_cov_counter_inf3",
            "atrium_cov_concussion_inf0",
            "atrium_cov_rangers_inf0",
            "atrium_cov_rangers_inf1",
            "atrium_cov_captain0",
            "atrium_cov_captain1",
            "sq_platform_w0_1",
            "sq_platform_w0_2",
            "sq_platform_w0_3",
            "sq_platform_w0_4",
            "sq_platform_w1_1",
            "sq_platform_w1_2",
            "sq_platform_w1_3",
            "sq_platform_w1_4a",
            "sq_platform_w1_4b",
            "sq_platform_w2_1",
            "sq_platform_w2_2",
            "sq_platform_w2_3",

        };

        public static List<VariantList> SceneryVariants = new List<VariantList>()
        {
            new VariantList{Name = "weapon_rack", Path = @"objects\gear\human\military\weapon_rack\weapon_rack", Variants = new List<string>(){"empty", "heavy_weapons", "armor_locks", "jetpack", "ar", "ar_frags", "br", "br_frags", "shotgun", "shotgun_frags", "drop_shields", "holograms", "jetpacks", "active_camo", "sprint"}},
            new VariantList{Name = "equipment_case", Path = @"objects\gear\human\military\equipment_case\equipment_case", Variants = new List<string>(){"default", "jetpack_2", "drop_lockup", "sprint_hologram", "drop_hologram", "sprint_lockup", "drop_camo", "lock_hologram", "empty", "lockup"}},
            new VariantList{Name = "armory_shelf", Path = @"objects\gear\human\military\armory_shelf\armory_shelf", Variants = new List<string>(){"empty", "ar", "ar01", "ar02", "br", "br01", "br02", "shot", "shot01", "shot02", "closed", "shot_dmr_rl"}},
            new VariantList{Name = "armory_shelf_small", Path = @"objects\gear\human\military\armory_shelf_small\armory_shelf_small,impo", Variants = new List<string>(){"4ar_no_grenade", "4ar_grenade", "4pistol_no_grenade", "4pistol_grenade", "2ar_no_grenade", "2ar_grenade", "2pistol_no_grenade", "2pistol_grenade", "empty", "2br_grenade"}},
        };

        public static List<VariantList> CrateVariants = new List<VariantList>()
        {
            new VariantList{Name = "crate_h_gun_rack_1", Path = @"objects\gear\human\military\crate_h_gun_rack_1\crate_h_gun_rack_1", Variants = new List<string>(){"example", "shot_rock01", "br_rock01", "ar_shot", "br_shot", "ar_10", "br_5", "mag_shot", "empty", "mag_grenade", "mag_dmr_ar"}},
            new VariantList{Name = "crate_space_a", Path = @"objects\props\covenant\crate_space_a\crate_space_a,hlmt", Variants = new List<string>(){"default", "plasma_rifles0", "plasma_rifles1", "mixed0", "energy_blades0", "spike_rifle0", "spike_rifle1", "plasma_pistols0", "plasma_pistols1", "flak_cannons0", "needle_rifles0", "hologram", "active_camo", "armor_lockup", "jet_pack", "concussion_rifles0", "plasma_launchers0", "plasma_launchers1"}},
            new VariantList{Name = "crate_space_b", Path = @"objects\gear\human\military\crate_space_b\crate_space_b", Variants = new List<string>(){"default", "plasma_rifles0", "spike_rifle0", "needle_rifles0"}},
        };
        
    }
}
