using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bungie;
using Bungie.Tags;
using static ReachTesting.FilePathsForReach;
namespace ReachTesting
{
    internal partial class Program
    {
        //Get Squads from a TagFile, return a tagfield
        public static TagField GetSquads(TagFile tagFile)
        {
            foreach (var field in tagFile.Fields)
            {
                if (field.DisplayName == "squads")
                {
                    return field;
                }
            }
            return null;
        }

        //Get Vehicle Palette from a TagFile, return a tagfield
        public static TagFieldBlock GetVehiclePalette(TagFile tagFile)
        {
            foreach (var field in tagFile.Fields)
            {
                if (field.DisplayName.Contains("vehicle palette"))
                {
                    return (TagFieldBlock)field;
                }
            }
            return null;
        }

        //Get Character Palette from a TagFile, return a tagfield
        public static TagFieldBlock GetCharacterPalette(TagFile tagFile)
        {
            var tag = tagFile.Fields.Where(x => x.DisplayName.ToLower().Contains("character palette")).FirstOrDefault();
            if (tag != null)
            {
                return (TagFieldBlock)tag;

            }
            return null;
        }

        //Get Weapon Palette from a TagFile, return a tagfield
        public static TagFieldBlock GetWeaponPalette(TagFile tagFile)
        {
            foreach (var field in tagFile.Fields)
            {
                if (field.DisplayName.Contains("weapon palette"))
                {
                    return (TagFieldBlock)field;
                }
            }
            return null;
        }

        //Add characters to a palette
        public static void AddCharactersToPalette(TagField tagField, List<EnemyObjectPaths> enemyList)
        {
            //Get the elements of the field
            var tagFieldBlock = (Bungie.Tags.TagFieldBlock)tagField;
            foreach (var EnemyType in enemyList)
            {
                bool found = false;
                //Check if the element is already in the palette
                foreach (var element in tagFieldBlock.Elements)
                {
                    if (element.ElementHeaderText.ToLower().Contains(EnemyType.Name.ToLower()))
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    //Get the count of the elements
                    var count = tagFieldBlock.Elements.Count;
                    tagFieldBlock.AddElement();

                    //Get the last element
                    var tag = ((Bungie.Tags.TagFieldBlockElement)tagFieldBlock.Elements[count]);
                    var tgb = (Bungie.Tags.TagFieldReference)tag.Fields[0];

                    tgb.Path = Bungie.Tags.TagPath.FromPathAndType(EnemyType.Path, "char");
                }
            }

            //Loop through and set the palette index
            foreach (var element in tagFieldBlock.Elements)
            {
                foreach (var EnemyType in enemyList)
                {
                    if (element.ElementHeaderText.ToLower() == EnemyType.Name.ToLower())
                    {
                        EnemyType.PaletteIndex = element.ElementIndex;
                        break;
                    }
                }
            }
        }

        //Add vehicles to a palette
        public static void AddVehiclesToPalette(TagField tagField, List<VehicleObjectPaths> vehicleList)
        {
            //Get the elements of the field
            var tagFieldBlock = (Bungie.Tags.TagFieldBlock)tagField;
            foreach (var VehicleType in vehicleList)
            {
                bool found = false;
                foreach (var element in tagFieldBlock.Elements)
                {
                    if (element.ElementHeaderText.ToLower().Contains(VehicleType.Name.ToLower()))
                    {
                        //Remove the element
                        //tagFieldBlock.RemoveElement(element.ElementIndex);

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    //Get the count of the elements
                    var count = tagFieldBlock.Elements.Count;
                    tagFieldBlock.AddElement();

                    //Get the last element
                    var tag = ((Bungie.Tags.TagFieldBlockElement)tagFieldBlock.Elements[count]);
                    var tgb = (Bungie.Tags.TagFieldReference)tag.Fields[0];

                    tgb.Path = Bungie.Tags.TagPath.FromPathAndType(VehicleType.Path, "vehi");
                    //Add the not found element
                }
            }

            //Loop through and set the palette index
            foreach (var element in tagFieldBlock.Elements)
            {
                foreach (var VehicleType in vehicleList)
                {
                    if (element.ElementHeaderText.ToLower() == VehicleType.Name.ToLower())
                    {
                        VehicleType.PaletteIndex = element.ElementIndex;
                        break;
                    }
                }
            }

        }

        //Add weapons to a palette
        public static void AddWeaponsToPalette(TagField tagField, List<WeaponDetails> weaponList)
        {
            //Get the elements of the field
            var tagFieldBlock = (Bungie.Tags.TagFieldBlock)tagField;
            foreach (var WeaponType in weaponList)
            {
                bool found = false;
                foreach (var element in tagFieldBlock.Elements)
                {
                    if (element.ElementHeaderText.ToLower().Contains(WeaponType.Name.ToLower()))
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    //Get the count of the elements
                    var count = tagFieldBlock.Elements.Count;
                    tagFieldBlock.AddElement();

                    //Get the last element
                    var tag = ((Bungie.Tags.TagFieldBlockElement)tagFieldBlock.Elements[count]);
                    var tgb = (Bungie.Tags.TagFieldReference)tag.Fields[0];

                    tgb.Path = Bungie.Tags.TagPath.FromPathAndType(WeaponType.Path, "weap");
                    //Add the not found element
                }
            }

            //Loop through and set the palette index
            foreach (var element in tagFieldBlock.Elements)
            {
                foreach (var WeaponType in weaponList)
                {
                    if (element.ElementHeaderText.ToLower() == WeaponType.Name.ToLower())
                    {
                        WeaponType.PaletteIndex = element.ElementIndex;
                        break;
                    }
                }
            }
        }

        //Check if a squad element has a template
        public static string HasTemplate(TagElement tagElement)
        {
            var find = ((Bungie.Tags.TagFieldBlockElement)tagElement).Fields.Where(x => x.DisplayName.ToString().ToLower().Contains("squad template index")).FirstOrDefault();
            if (find != null)
            {
                TagFieldElementInteger tfr = (TagFieldElementInteger)find;
                if (tfr.Data == -1)
                {
                }
                else
                {
                    //Get number of cells in the template and replicate them in this cell
                    //tfr.Data = -1;
                }

            }
            var findb = ((Bungie.Tags.TagFieldBlockElement)tagElement).Fields.Where(x => x.DisplayName.ToString() == "template").FirstOrDefault();
            if (findb != null)
            {
                TagFieldElementStringIDWithMenu tfr = (TagFieldElementStringIDWithMenu)findb;
                if (tfr.Data == "")
                {
                }
                else
                {
                    //Get number of cells in the template and replicate them in this cell
                    //tfr.Data = "";
                    return tfr.Data;
                }

            }
            return "";
        }

        //Get Enemy count from a squad template
        public static int GetEnemyCountFromTemplate(string template)
        {
            int enemyCount = 0;

            if (!string.IsNullOrEmpty(template))
            {
                //Find the template in the list of squad templates with exact name with prefix like "ai\squad_templates\{template}"
                var templatewithprefix = @"ai\squad_templates\" + template;
                var found = FilePathsForReach.SquadTemplates.Where(x => x.ToLower() == templatewithprefix.ToLower()).FirstOrDefault();
                if (found != null)
                {
                    //Open the template file
                    var tag_path = Bungie.Tags.TagPath.FromPathAndType(found, "sqtm*");
                    using (var tagFileTemplate = new Bungie.Tags.TagFile(tag_path))
                    {
                        //Get the "normal diff count" of the template
                        foreach (var element in tagFileTemplate.Elements)
                        {
                            //Loop through the elements of Fields[1] which is "Block:Cell Templates"
                            foreach (var field in ((Bungie.Tags.TagFieldBlock)element.Fields[1]).Elements)
                            {
                                //Loop through the elements of Fields[1] which is "Block:Cell Templates"
                                foreach (var ele_field in field.Fields)
                                {
                                    //If it is "Field:Name"
                                    if (ele_field.DisplayName.ToString().Contains("normal diff count"))
                                    {
                                        //Get ele_field.Data as a shortinteger
                                        var tfr = (TagFieldElementInteger)ele_field;
                                        enemyCount += (int)tfr.Data;

                                    }
                                }
                            }
                        }
                    }



                }
                else
                {
                    Console.WriteLine("Template not found: " + template);
                    Random random = new Random();
                    enemyCount = random.Next(1, 4);
                    Console.WriteLine("Random enemy count: " + enemyCount);

                }


            }
            return enemyCount;
        }

        //Remove template from squad
        public static void RemoveTemplate(TagElement tagElement)
        {
            var find = ((Bungie.Tags.TagFieldBlockElement)tagElement).Fields.Where(x => x.DisplayName.ToString().ToLower().Contains("squad template index")).FirstOrDefault();
            if (find != null)
            {
                TagFieldElementInteger tfr = (TagFieldElementInteger)find;
                if (tfr.Data == -1)
                {
                }
                else
                {
                    //Get number of cells in the template and replicate them in this cell
                    tfr.Data = -1;
                }

            }
            var findb = ((Bungie.Tags.TagFieldBlockElement)tagElement).Fields.Where(x => x.DisplayName.ToString() == "template").FirstOrDefault();
            if (findb != null)
            {
                TagFieldElementStringIDWithMenu tfr = (TagFieldElementStringIDWithMenu)findb;
                if (tfr.Data == "")
                {
                }
                else
                {
                    //Get number of cells in the template and replicate them in this cell
                    tfr.Data = "";
                }

            }
        }


        //check if a template has a vehicle
        public static bool TemplateHasVehicle(string template)
        {
            //Open the template file and check if it has a vehicle
            if (!string.IsNullOrEmpty(template))
            {
                //Find the template in the list of squad templates with exact name with prefix like "ai\squad_templates\{template}"
                var templatewithprefix = @"ai\squad_templates\" + template;
                var found = FilePathsForReach.SquadTemplates.Where(x => x.ToLower() == templatewithprefix.ToLower()).FirstOrDefault();
                if (found != null)
                {
                    //Open the template file
                    var tag_path = Bungie.Tags.TagPath.FromPathAndType(found, "sqtm*");
                    using (var tagFileTemplate = new Bungie.Tags.TagFile(tag_path))
                    {
                        //Get the "normal diff count" of the template
                        foreach (var element in tagFileTemplate.Elements)
                        {
                            //Loop through the elements of Fields[1] which is "Block:Cell Templates"
                            foreach (var field in ((Bungie.Tags.TagFieldBlock)element.Fields[1]).Elements)
                            {
                                //Loop through the elements of Fields[1] which is "Block:Cell Templates"
                                foreach (var ele_field in field.Fields)
                                {
                                    //If it is "Field:Name"
                                    if (ele_field.DisplayName.ToString().Contains("vehicle type"))
                                    {
                                        //Check if the vehichle type path is not null
                                        var tfr = (TagFieldReference)ele_field;
                                        if (tfr.Path != null)
                                        {
                                            return true;
                                        }
                                    }
                                }
                            }
                        }
                    }



                }
                else
                {
                    Console.WriteLine("Template not found: " + template);
                }


            }
            return false;

        }

        //Set the initial weapon of a cell with palette index
        public static void SetWeaponOfCell(TagElement cell, Random rand, int PaletteIndex)
        {
            //Choose a random weapon for the cell
            var weapon = cell.Fields.Where(x => x.DisplayName == "initial weapon").FirstOrDefault();
            if (weapon != null)
            {
                if (((TagFieldBlock)weapon).Elements.Count < 1)
                {
                    //Add an element
                    ((TagFieldBlock)weapon).AddElement();
                }
                //Get weapon type field from elements[0]
                var weaponType = ((Bungie.Tags.TagFieldBlock)weapon).Elements[0].Fields.Where(x => x.DisplayName == "weapon type").FirstOrDefault();
                if (weaponType != null)
                {
                    //Set the weapon type to the random weapon shortblockindex
                    ((TagFieldBlockIndex)weaponType).Value = (short)PaletteIndex;

                }


            }
        }

        //Remove all weapons from cell with RemoveAllElements()
        public static void RemoveAllWeaponsOfCell(TagElement cell)
        {
            //Choose a random weapon for the cell
            var weapon = cell.Fields.Where(x => x.DisplayName == "initial weapon").FirstOrDefault();
            if (weapon != null)
            {
                ((TagFieldBlock)weapon).RemoveAllElements();
            }
        }

        //Set normal diff count of a cell
        public static void SetNormalDiffCountOfCell(TagElement cell, int count)
        {
            //Find normal diff count
            var normalDiffCount = cell.Fields.Where(x => x.DisplayName == "normal diff count").FirstOrDefault();
            if (normalDiffCount != null)
            {
                //Set the normal diff count to the enemy count
                ((TagFieldElementInteger)normalDiffCount).Data = count;
            }

        }


        //Remove all characters from cell with RemoveAllElements()
        public static void RemoveAllCharactersOfCell(TagElement cell)
        {
            //Choose a random weapon for the cell
            var characters = cell.Fields.Where(x => x.DisplayName == "character type").FirstOrDefault();
            if (characters != null)
            {
                ((TagFieldBlock)characters).RemoveAllElements();
            }
        }


        //Get "designer zones" from tagfile
        public static TagField GetDesignerZones(TagFile tagFile)
        {
            foreach (var field in tagFile.Fields)
            {
                if (field.DisplayName == "designer zones")
                {
                    return field;
                }
            }
            return null;
        }
    }
}
